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
		public static BOBAGNNLEHP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int BFHDPKIGOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int DBGJIFDIFNN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71308D0", Offset = "0x712EED0", VA = "0x1871308D0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7130910", Offset = "0x712EF10", VA = "0x187130910")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71308F0", Offset = "0x712EEF0", VA = "0x1871308F0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JIEHBANCLJP, [Optional] UnityEngine.Object JHAKINLMMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JIEHBANCLJP, [Optional] UnityEngine.Object JHAKINLMMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7130A00", Offset = "0x712F000", VA = "0x187130A00")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DCBINFEMIOA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class NDKNMKHNFEL : DNHKGEGLKBK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE66170", Offset = "0xE64770", VA = "0x180E66170", Slot = "4")]
		public Vector3 FKKLDPBDFDI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE66170", Offset = "0xE64770", VA = "0x180E66170", Slot = "5")]
		public Vector3 BKNJLFFOMOG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NDKNMKHNFEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DNHKGEGLKBK LHNABIHEFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8150", Offset = "0x5AF6750", VA = "0x185AF8150")]
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
		private static readonly CMJEFMOJNAO LOENAOFMKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool OBGCOMANLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private OFONBGHOJGA DBMJFLMGPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HHJACFLANNE(ODACEGFBLCL.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[HHJACFLANNE(ODACEGFBLCL.SelfAndParent, true, false, false)]
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
		private IBACOACLMDN physicsInterpolation;

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
		internal OFONBGHOJGA LIPHOMAOMMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7131EA0", Offset = "0x71304A0", VA = "0x187131EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> PPNNCBGGBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x920E90", Offset = "0x91F490", VA = "0x180920E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LPNCHLHOEBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7133660", Offset = "0x7131C60", VA = "0x187133660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PACKEMKPJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7133600", Offset = "0x7131C00", VA = "0x187133600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KHJHJOOPMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71341B0", Offset = "0x71327B0", VA = "0x1871341B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7135670", Offset = "0x7133C70", VA = "0x187135670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform BBPLLCKGKGO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xCBB030", Offset = "0xCB9630", VA = "0x180CBB030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BIGDKHPDJKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCBB030", Offset = "0xCB9630", VA = "0x180CBB030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LPLLAOJLKBB KCBNOHCCLHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71333C0", Offset = "0x71319C0", VA = "0x1871333C0")]
			get
			{
				return default(LPLLAOJLKBB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7134E10", Offset = "0x7133410", VA = "0x187134E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DLBPCIKJDDA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71338C0", Offset = "0x7131EC0", VA = "0x1871338C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GJFHOJKDLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71334E0", Offset = "0x7131AE0", VA = "0x1871334E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DNHKGEGLKBK DHCDAHJIONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7133800", Offset = "0x7131E00", VA = "0x187133800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7135020", Offset = "0x7133620", VA = "0x187135020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LBPNAALLFFO HDBDNCDOINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71337A0", Offset = "0x7131DA0", VA = "0x1871337A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7134FB0", Offset = "0x71335B0", VA = "0x187134FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MDAHJPLFBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7133690", Offset = "0x7131C90", VA = "0x187133690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody COHKPGCDCFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71336F0", Offset = "0x7131CF0", VA = "0x1871336F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NIHHOMFNEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7133540", Offset = "0x7131B40", VA = "0x187133540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7134ED0", Offset = "0x71334D0", VA = "0x187134ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JAFCBJGGIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x150E5A0", Offset = "0x150CBA0", VA = "0x18150E5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3685450", Offset = "0x3683A50", VA = "0x183685450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float JGAFGMLHFID
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7134150", Offset = "0x7132750", VA = "0x187134150")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float OGAOFMHMEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x71340F0", Offset = "0x71326F0", VA = "0x1871340F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7135600", Offset = "0x7133C00", VA = "0x187135600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float FHNDOPNGBEH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7133B10", Offset = "0x7132110", VA = "0x187133B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71352B0", Offset = "0x71338B0", VA = "0x1871352B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float PBMOANADGLE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7133920", Offset = "0x7131F20", VA = "0x187133920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7135090", Offset = "0x7133690", VA = "0x187135090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OPCNBLMOAJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7134680", Offset = "0x7132C80", VA = "0x187134680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7135B60", Offset = "0x7134160", VA = "0x187135B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 OIJFJCECNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7133EF0", Offset = "0x71324F0", VA = "0x187133EF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71353F0", Offset = "0x71339F0", VA = "0x1871353F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 GILEAFLLKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71347B0", Offset = "0x7132DB0", VA = "0x1871347B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode ALONBHDGGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7133A50", Offset = "0x7132050", VA = "0x187133A50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71351D0", Offset = "0x71337D0", VA = "0x1871351D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ACKCLFFFIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71335A0", Offset = "0x7131BA0", VA = "0x1871335A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7134F40", Offset = "0x7133540", VA = "0x187134F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints PLAAPHPJNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7133AB0", Offset = "0x71320B0", VA = "0x187133AB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7135240", Offset = "0x7133840", VA = "0x187135240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 AEJHKMOMIDH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7134210", Offset = "0x7132810", VA = "0x187134210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 OLPNCHEOHJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7134210", Offset = "0x7132810", VA = "0x187134210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7135950", Offset = "0x7133F50", VA = "0x187135950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CGGDAIKDGDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7133FC0", Offset = "0x71325C0", VA = "0x187133FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71354C0", Offset = "0x7133AC0", VA = "0x1871354C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BFGEBKKBFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7134620", Offset = "0x7132C20", VA = "0x187134620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7135AF0", Offset = "0x71340F0", VA = "0x187135AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion PPFAAAPBCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x71342E0", Offset = "0x71328E0", VA = "0x1871342E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x71356E0", Offset = "0x7133CE0", VA = "0x1871356E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion MNAKPMFOCJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7134550", Offset = "0x7132B50", VA = "0x187134550")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7135A20", Offset = "0x7134020", VA = "0x187135A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DKMDGJADCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71343B0", Offset = "0x71329B0", VA = "0x1871343B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71357B0", Offset = "0x7133DB0", VA = "0x1871357B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion GDFJCJFFEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7134480", Offset = "0x7132A80", VA = "0x187134480")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7135880", Offset = "0x7133E80", VA = "0x187135880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 BHCAEBJCEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x71346E0", Offset = "0x7132CE0", VA = "0x1871346E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7135BD0", Offset = "0x71341D0", VA = "0x187135BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CLKLNJLAMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7134020", Offset = "0x7132620", VA = "0x187134020")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7135530", Offset = "0x7133B30", VA = "0x187135530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 LPOFGCMCEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7133980", Offset = "0x7131F80", VA = "0x187133980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7135100", Offset = "0x7133700", VA = "0x187135100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NJNFBPAFGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7133E20", Offset = "0x7132420", VA = "0x187133E20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7135320", Offset = "0x7133920", VA = "0x187135320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HDOKHMMEHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7133CF0", Offset = "0x71322F0", VA = "0x187133CF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion GGPJNMNHNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7133C20", Offset = "0x7132220", VA = "0x187133C20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MLLIMFKJEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7134950", Offset = "0x7132F50", VA = "0x187134950")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BDKIEIFFMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7134880", Offset = "0x7132E80", VA = "0x187134880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool AFLMDOLPCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7133DC0", Offset = "0x71323C0", VA = "0x187133DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LAOKPHOANHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7133860", Offset = "0x7131E60", VA = "0x187133860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DLIAJNPEHGL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7133480", Offset = "0x7131A80", VA = "0x187133480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FMOCGGDMJJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7133420", Offset = "0x7131A20", VA = "0x187133420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool HIBACOKMGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7133360", Offset = "0x7131960", VA = "0x187133360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CICNAEJDFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7133B70", Offset = "0x7132170", VA = "0x187133B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AGOOCBLDBDE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD4CA70", Offset = "0xD4B070", VA = "0x180D4CA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EHABGBMCGIM ODCJNBKLIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7133280", Offset = "0x7131880", VA = "0x187133280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7134D30", Offset = "0x7133330", VA = "0x187134D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FDGOKJCHHNL MFPELGBHHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7133210", Offset = "0x7131810", VA = "0x187133210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7134CC0", Offset = "0x71332C0", VA = "0x187134CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EHABGBMCGIM DKLNHBKPOON
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7132F70", Offset = "0x7131570", VA = "0x187132F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7134A20", Offset = "0x7133020", VA = "0x187134A20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EHABGBMCGIM JBEIBIJNDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7132FE0", Offset = "0x71315E0", VA = "0x187132FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7134A90", Offset = "0x7133090", VA = "0x187134A90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EHABGBMCGIM IOJJHKECJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7133130", Offset = "0x7131730", VA = "0x187133130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7134BE0", Offset = "0x71331E0", VA = "0x187134BE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x71330C0", Offset = "0x71316C0", VA = "0x1871330C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7134B70", Offset = "0x7133170", VA = "0x187134B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EHABGBMCGIM DGEDABEJCKO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x71331A0", Offset = "0x71317A0", VA = "0x1871331A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7134C50", Offset = "0x7133250", VA = "0x187134C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EHABGBMCGIM GIEEMLNEDIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71332F0", Offset = "0x71318F0", VA = "0x1871332F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7134DA0", Offset = "0x71333A0", VA = "0x187134DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event EHABGBMCGIM ADODCIHHFGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7133050", Offset = "0x7131650", VA = "0x187133050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7134B00", Offset = "0x7133100", VA = "0x187134B00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9989D0", Offset = "0x996FD0", VA = "0x1809989D0")]
		internal void ELHANOCGECG(OFONBGHOJGA EGHMJNHBHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7131560", Offset = "0x712FB60", VA = "0x187131560")]
		internal void CJFBGBFJDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7132C60", Offset = "0x7131260", VA = "0x187132C60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody DENFBNOOIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7132920", Offset = "0x7130F20", VA = "0x187132920")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) EDPHAEDLFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7131490", Offset = "0x712FA90", VA = "0x187131490")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7131EA0", Offset = "0x71304A0", VA = "0x187131EA0")]
		private OFONBGHOJGA LCPNBHDIKDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7131A30", Offset = "0x7130030", VA = "0x187131A30")]
		private void IONAJKOHHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7132110", Offset = "0x7130710", VA = "0x187132110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7131560", Offset = "0x712FB60", VA = "0x187131560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71317D0", Offset = "0x712FDD0", VA = "0x1871317D0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71320B0", Offset = "0x71306B0", VA = "0x1871320B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7132170", Offset = "0x7130770", VA = "0x187132170")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7130A50", Offset = "0x712F050", VA = "0x187130A50")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71321E0", Offset = "0x71307E0", VA = "0x1871321E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7131770", Offset = "0x712FD70", VA = "0x187131770")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7132050", Offset = "0x7130650", VA = "0x187132050")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7132A80", Offset = "0x7131080", VA = "0x187132A80")]
		public void SetParent(RigidbodyEx FEBHELIDNED, bool KBOMCJLJCEI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x71324E0", Offset = "0x7130AE0", VA = "0x1871324E0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7131DC0", Offset = "0x71303C0", VA = "0x187131DC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx EEFJJAMAMIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7131E00", Offset = "0x7130400", VA = "0x187131E00")]
		public bool IsRigidbodyDescendant(RigidbodyEx MJHPJJNBELH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7130CC0", Offset = "0x712F2C0", VA = "0x187130CC0")]
		public void AddInterpolationRestriction(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7132250", Offset = "0x7130850", VA = "0x187132250")]
		public void RemoveInterpolationRestriction(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7131500", Offset = "0x712FB00", VA = "0x187131500")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7130D30", Offset = "0x712F330", VA = "0x187130D30")]
		public void AddKinematic(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71322C0", Offset = "0x71308C0", VA = "0x1871322C0")]
		public void RemoveKinematic(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7132A00", Offset = "0x7131000", VA = "0x187132A00")]
		public void SetKinematic(object LODBJLOKBLP, bool HCLOPJHBCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7132830", Offset = "0x7130E30", VA = "0x187132830")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JCLIPFPAKNB, Quaternion IFKFMPIADDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7132740", Offset = "0x7130D40", VA = "0x187132740")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 BMLLLNHBIGO, Quaternion DGGEILNBDKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7131930", Offset = "0x712FF30", VA = "0x187131930")]
		public Vector3 GetConstrainedVelocity(Vector3 BHCAEBJCEFE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7131830", Offset = "0x712FE30", VA = "0x187131830")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LPOFGCMCEJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7130BD0", Offset = "0x712F1D0", VA = "0x187130BD0")]
		public void AddForce(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7130AC0", Offset = "0x712F0C0", VA = "0x187130AC0")]
		public void AddForceAtPosition(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7130F00", Offset = "0x712F500", VA = "0x187130F00")]
		public void AddTorque(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7130DA0", Offset = "0x712F3A0", VA = "0x187130DA0")]
		public void AddRelativeTorque(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7132D40", Offset = "0x7131340", VA = "0x187132D40")]
		public Vector3 WorldToLocalVelocity(Vector3 JICDEFICCCA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7131F50", Offset = "0x7130550", VA = "0x187131F50")]
		public Vector3 LocalToWorldVelocity(Vector3 CLKLNJLAMJP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7131710", Offset = "0x712FD10", VA = "0x187131710")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71316B0", Offset = "0x712FCB0", VA = "0x1871316B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7131650", Offset = "0x712FC50", VA = "0x187131650")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71315F0", Offset = "0x712FBF0", VA = "0x1871315F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7132640", Offset = "0x7130C40", VA = "0x187132640")]
		public void ResetVelocityWorldSpace(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7132540", Offset = "0x7130B40", VA = "0x187132540")]
		public void ResetVelocityLocalSpace(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7132410", Offset = "0x7130A10", VA = "0x187132410")]
		public void ResetLinearVelocityLocalSpace(Vector3 BFHFALKFPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7132B70", Offset = "0x7131170", VA = "0x187132B70")]
		public bool SweepTest(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7131E40", Offset = "0x7130440", VA = "0x187131E40")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7132B10", Offset = "0x7131110", VA = "0x187132B10")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7132CE0", Offset = "0x71312E0", VA = "0x187132CE0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7130E90", Offset = "0x712F490", VA = "0x187130E90")]
		public void AddShouldHaveUnityRigidbodyToken(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7132330", Offset = "0x7130930", VA = "0x187132330")]
		public void RemoveShouldHaveUnityRigidbodyToken(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7131280", Offset = "0x712F880", VA = "0x187131280")]
		public void ApplyForceVelocityChange(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7131190", Offset = "0x712F790", VA = "0x187131190")]
		public void ApplyAngularVelocityChange(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7131390", Offset = "0x712F990", VA = "0x187131390")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71310D0", Offset = "0x712F6D0", VA = "0x1871310D0")]
		public bool AllowedScaleChange(float IPBDNGOJOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7130FF0", Offset = "0x712F5F0", VA = "0x187130FF0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MHCAFIHKNDF, object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x71323A0", Offset = "0x71309A0", VA = "0x1871323A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object LODBJLOKBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7132ED0", Offset = "0x71314D0", VA = "0x187132ED0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class BMFBFGNMOOB
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3D40", Offset = "0x5AF2340", VA = "0x185AF3D40")]
	public static OFONBGHOJGA LIPHOMAOMMD(this RigidbodyEx CIJHLIHFIBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void EHABGBMCGIM(RigidbodyEx CBOJELMBIMF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KHCBBFGBLKI : KEJBPCKPMPL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DKAENLKAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int EPBDDNEHEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x954B80", Offset = "0x953180", VA = "0x180954B80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "6")]
	public HGKLKDHHOMH MNLAOEIFKNI(float DGCKGDHMMMM)
	{
		return default(HGKLKDHHOMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
	public void PEECNHFNIGK(AFGAEDNKNBI IAMEECMGPIF, float FLPLIPPLLCO, LPLLAOJLKBB NELFOKMNLNO = LPLLAOJLKBB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void PEECNHFNIGK(AFGAEDNKNBI IAMEECMGPIF, Transform IFLPOAOMDME, float FLPLIPPLLCO, LPLLAOJLKBB NELFOKMNLNO = LPLLAOJLKBB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "9")]
	public void KIDNCLKOIPP(AFGAEDNKNBI IAMEECMGPIF, [Optional] float? FLPLIPPLLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "10")]
	public void FAKCPBGGFBC(AFGAEDNKNBI MPHDELHOAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "11")]
	public HGKLKDHHOMH PBFDANJLNFG(AFGAEDNKNBI IAMEECMGPIF)
	{
		return default(HGKLKDHHOMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "12")]
	public bool LJPILFONFHE(AFGAEDNKNBI IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "13")]
	public void LDDPABGLCJC(AFGAEDNKNBI IAMEECMGPIF, LPLLAOJLKBB GFMIMHIIAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public KHCBBFGBLKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IBACOACLMDN
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum OOEFPNBEJNC
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MHIFJHDIDOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody JNOABPPDPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView DBCKNEFLANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 AEBCBPIOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 CHDJMFPCPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IBACOACLMDN PPKMCBDGMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool PAMAKEMHNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool HCAGPGLNOLJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void FDGOKJCHHNL(RigidbodyEx CBOJELMBIMF, bool KBOMCJLJCEI = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NNNFPBGOJKC(typeof(DGIEEJNABDO), new string[] { "Ignore", "Mock" })]
public class LJKBHBEIIPK : DGIEEJNABDO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool AFBNMJFLBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA33AD0", Offset = "0xA320D0", VA = "0x180A33AD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
	public void BMLHHEBEGHE(string KAEDNDEPIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "6")]
	public void GGIBFOOAIBM(RigidbodyEx CIJHLIHFIBP, Action INJMGBDPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x921950", Offset = "0x91FF50", VA = "0x180921950", Slot = "7")]
	public KEJBPCKPMPL MFDOHJJPGNM(int BHKLPNKELKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void DMAAOLJDHAA(Vector3 GILEAFLLKKG, float DBONHNMDDPC, Color OOJLGEBJDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public LJKBHBEIIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NNNFPBGOJKC(typeof(FCIJLMHOABL), new string[] { })]
public class EHCPPBAFFPC : FCIJLMHOABL, BIAEDGDMGKC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AMIGGHNJKLM MHPDKIIMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private DGIEEJNABDO OODHPHIHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EFENGCOLBME BGEDACCBFEA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OJKHHGOLFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA570", Offset = "0x5AF8B70", VA = "0x185AFA570", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DGIEEJNABDO JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public EFENGCOLBME MBGHEHKJBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA4E0", Offset = "0x5AF8AE0", VA = "0x185AFA4E0", Slot = "12")]
	public void InitReferences(AONANDJIJLG FPOFNDLOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA5C0", Offset = "0x5AF8BC0", VA = "0x185AFA5C0", Slot = "7")]
	public AIEJIADOHAF KCHEGJIAAPJ(RigidbodyEx CIJHLIHFIBP)
	{
		return default(AIEJIADOHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA3E0", Offset = "0x5AF89E0", VA = "0x185AFA3E0")]
	private static AIEJIADOHAF IFBBONDDHLN(RigidbodyEx CIJHLIHFIBP)
	{
		return default(AIEJIADOHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA200", Offset = "0x5AF8800", VA = "0x185AFA200", Slot = "8")]
	public OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA310", Offset = "0x5AF8910", VA = "0x185AFA310", Slot = "11")]
	private RigidbodyEx IDOMBIFKIMI(GameObject GMNIHJDBJGJ, MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA8B0", Offset = "0x5AF8EB0", VA = "0x185AFA8B0", Slot = "9")]
	public void NNIDJMEDMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA9A0", Offset = "0x5AF8FA0", VA = "0x185AFA9A0", Slot = "10")]
	public void NOCAEMMNDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public EHCPPBAFFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class OKJMBNPMOPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float PIDPDNLHEOP = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float BFOPPELPCEA = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float FMENFANEGIO = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public OKJMBNPMOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PPDHCFGCLEE
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7130780", Offset = "0x712ED80", VA = "0x187130780")]
	public static void HLINPEHGMNJ(this Rigidbody DENFBNOOIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7130670", Offset = "0x712EC70", VA = "0x187130670")]
	public static void HLINPEHGMNJ(this Rigidbody DENFBNOOIIJ, Vector3 NKPEMFJAHDJ, Quaternion GGPJNMNHNBA, Vector3 PMNJOKOOFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D6A5C0", Offset = "0x4D68BC0", VA = "0x184D6A5C0")]
	public static void EFAOGGFFCOG(Vector3 BHCAEBJCEFE, Vector3 MCAKNKCONJB, out Vector3 BPEDGBBPMGM, out Vector3 DAGOMEJCONN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum LOEECLHCINF
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HOKCEFENPDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EHABGBMCGIM HKDLNOLGELI;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAGHPDPHLJH(OFONBGHOJGA KHJHJOOPMKP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMFKCFAPGBC(OFONBGHOJGA KHJHJOOPMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JFEACPHKHLG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float OBJCBEKNNJF
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
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAEFCEBGKHG(Rigidbody JNOABPPDPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface DGIEEJNABDO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool AFBNMJFLBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMLHHEBEGHE(string KAEDNDEPIBA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGIBFOOAIBM(RigidbodyEx CIJHLIHFIBP, Action INJMGBDPOBO);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KEJBPCKPMPL MFDOHJJPGNM(int BHKLPNKELKE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMAAOLJDHAA(Vector3 GILEAFLLKKG, float DBONHNMDDPC, Color OOJLGEBJDPI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface FCIJLMHOABL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DGIEEJNABDO JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EFENGCOLBME MBGHEHKJBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool OJKHHGOLFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIEJIADOHAF KCHEGJIAAPJ(RigidbodyEx CIJHLIHFIBP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNIDJMEDMLC();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOCAEMMNDEG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx BCJDKLHOJFA(GameObject GMNIHJDBJGJ, [Optional] MHIFJHDIDOK GOMDNNCBLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CBELPAABGGE
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NMGJJNJKLDI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OOGHMNBHLKO
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJEHGAAAKMN(OFONBGHOJGA KHJHJOOPMKP, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKAMICOMAAK(object LODBJLOKBLP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class JIOMDEBEHDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F180", Offset = "0x5B0D780", VA = "0x185B0F180")]
	public JIOMDEBEHDC(FPMFILCBKBL MBLEGMGDGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F120", Offset = "0x5B0D720", VA = "0x185B0F120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FPMFILCBKBL : OFONBGHOJGA, IDisposable, PLNCLHNPCMP
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string KPENJPJJING = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly FCIJLMHOABL HGEKNDJMGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal GKNFMLNNAHO DFAJGJDLFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal LJOMOANBFHO FEOCMODPDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal HOKCEFENPDF OILKGFFBJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal ACMKCJNLEDE BHCAEBJCEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal OOGHMNBHLKO HLCJBAOAHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal IOPJPDHCIPA KBFNNKADGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal JFEACPHKHLG MGJGHNBILMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DCBKBOBKLGO NHFICCKFJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal OLODFMHJBBA PBKGIGCGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HLMDHICCLOP GKNNKPLIBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal BGPBCNOJGKF KDGHIBCKCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal BGHPFEHEINP PNPIPMIPGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal HHFMMECNAIN AAOCLHBOCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LJFAGHMDHNE JNOABPPDPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal NNGPHHMDKOJ AGIKNMLJJJM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx LPMEDPADBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA503B0", Offset = "0xA4E9B0", VA = "0x180A503B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA72E20", Offset = "0xA71420", VA = "0x180A72E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject GLLEEPIMCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAE6900", Offset = "0xAE4F00", VA = "0x180AE6900", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAE6920", Offset = "0xAE4F20", VA = "0x180AE6920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B076E0", Offset = "0x5B05CE0", VA = "0x185B076E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> JLFKDFDFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B05BF0", Offset = "0x5B041F0", VA = "0x185B05BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B05750", Offset = "0x5B03D50", VA = "0x185B05750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B04E40", Offset = "0x5B03440", VA = "0x185B04E40", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B06D60", Offset = "0x5B05360", VA = "0x185B06D60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B08420", Offset = "0x5B06A20", VA = "0x185B08420", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B04410", Offset = "0x5B02A10", VA = "0x185B04410", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B040D0", Offset = "0x5B026D0", VA = "0x185B040D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5B06810", Offset = "0x5B04E10", VA = "0x185B06810", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5B090D0", Offset = "0x5B076D0", VA = "0x185B090D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5B06BF0", Offset = "0x5B051F0", VA = "0x185B06BF0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5B03F70", Offset = "0x5B02570", VA = "0x185B03F70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B03E60", Offset = "0x5B02460", VA = "0x185B03E60", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B08360", Offset = "0x5B06960", VA = "0x185B08360", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B07840", Offset = "0x5B05E40", VA = "0x185B07840", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5B04E90", Offset = "0x5B03490", VA = "0x185B04E90", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B037F0", Offset = "0x5B01DF0", VA = "0x185B037F0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B06AD0", Offset = "0x5B050D0", VA = "0x185B06AD0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B07890", Offset = "0x5B05E90", VA = "0x185B07890", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B06C40", Offset = "0x5B05240", VA = "0x185B06C40", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5B07040", Offset = "0x5B05640", VA = "0x185B07040", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5B03720", Offset = "0x5B01D20", VA = "0x185B03720", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B07770", Offset = "0x5B05D70", VA = "0x185B07770", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B06180", Offset = "0x5B04780", VA = "0x185B06180", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DLIAJNPEHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B04EF0", Offset = "0x5B034F0", VA = "0x185B04EF0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool FMOCGGDMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5B052F0", Offset = "0x5B038F0", VA = "0x185B052F0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool HIBACOKMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5B03C90", Offset = "0x5B02290", VA = "0x185B03C90", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B05970", Offset = "0x5B03F70", VA = "0x185B05970", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5B065D0", Offset = "0x5B04BD0", VA = "0x185B065D0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5B04BD0", Offset = "0x5B031D0", VA = "0x185B04BD0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5B06F20", Offset = "0x5B05520", VA = "0x185B06F20", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5B05D40", Offset = "0x5B04340", VA = "0x185B05D40", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5B07610", Offset = "0x5B05C10", VA = "0x185B07610", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5B06FF0", Offset = "0x5B055F0", VA = "0x185B06FF0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B059C0", Offset = "0x5B03FC0", VA = "0x185B059C0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B09180", Offset = "0x5B07780", VA = "0x185B09180", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5B05E60", Offset = "0x5B04460", VA = "0x185B05E60", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5B05220", Offset = "0x5B03820", VA = "0x185B05220", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B081F0", Offset = "0x5B067F0", VA = "0x185B081F0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5B03520", Offset = "0x5B01B20", VA = "0x185B03520", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float OBJCBEKNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B09550", Offset = "0x5B07B50", VA = "0x185B09550", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B06290", Offset = "0x5B04890", VA = "0x185B06290", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool CMBGCMCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5B060E0", Offset = "0x5B046E0", VA = "0x185B060E0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5B03C30", Offset = "0x5B02230", VA = "0x185B03C30", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B08580", Offset = "0x5B06B80", VA = "0x185B08580", Slot = "51")]
		get
		{
			return default(DEJBIADAKBB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5B08470", Offset = "0x5B06A70", VA = "0x185B08470", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5B04CA0", Offset = "0x5B032A0", VA = "0x185B04CA0", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform BBPLLCKGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5B071F0", Offset = "0x5B057F0", VA = "0x185B071F0", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform BIGDKHPDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5B071F0", Offset = "0x5B057F0", VA = "0x185B071F0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 JEKEADKLECO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5B092A0", Offset = "0x5B078A0", VA = "0x185B092A0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5B03FD0", Offset = "0x5B025D0", VA = "0x185B03FD0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MNBIEAAONEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5B09240", Offset = "0x5B07840", VA = "0x185B09240", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5B03AD0", Offset = "0x5B020D0", VA = "0x185B03AD0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float JFIILHNBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5B04CF0", Offset = "0x5B032F0", VA = "0x185B04CF0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5B057A0", Offset = "0x5B03DA0", VA = "0x185B057A0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion HCENNMNFPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5B088B0", Offset = "0x5B06EB0", VA = "0x185B088B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5B07310", Offset = "0x5B05910", VA = "0x185B07310", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5B05E10", Offset = "0x5B04410", VA = "0x185B05E10", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5B08060", Offset = "0x5B06660", VA = "0x185B08060", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5B06250", Offset = "0x5B04850", VA = "0x185B06250", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5B06920", Offset = "0x5B04F20", VA = "0x185B06920", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints OGBPDLNAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5B080B0", Offset = "0x5B066B0", VA = "0x185B080B0", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5B069D0", Offset = "0x5B04FD0", VA = "0x185B069D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5B05F30", Offset = "0x5B04530", VA = "0x185B05F30", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5B04DE0", Offset = "0x5B033E0", VA = "0x185B04DE0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5B08860", Offset = "0x5B06E60", VA = "0x185B08860", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode MFCAHEKOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5B08530", Offset = "0x5B06B30", VA = "0x185B08530", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5B08BF0", Offset = "0x5B071F0", VA = "0x185B08BF0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5B08710", Offset = "0x5B06D10", VA = "0x185B08710", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool LAOKPHOANHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5B04770", Offset = "0x5B02D70", VA = "0x185B04770", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool ABGKKLKEAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5B096A0", Offset = "0x5B07CA0", VA = "0x185B096A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool BGNJMGIFFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5B09260", Offset = "0x5B07860", VA = "0x185B09260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event EHABGBMCGIM DKLNHBKPOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5B07550", Offset = "0x5B05B50", VA = "0x185B07550", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5B086B0", Offset = "0x5B06CB0", VA = "0x185B086B0", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event EHABGBMCGIM JBEIBIJNDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B09360", Offset = "0x5B07960", VA = "0x185B09360", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B05910", Offset = "0x5B03F10", VA = "0x185B05910", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event FDGOKJCHHNL JCIJGADBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B045B0", Offset = "0x5B02BB0", VA = "0x185B045B0", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B058B0", Offset = "0x5B03EB0", VA = "0x185B058B0", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event EHABGBMCGIM HKDLNOLGELI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B06EA0", Offset = "0x5B054A0", VA = "0x185B06EA0", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5B093C0", Offset = "0x5B079C0", VA = "0x185B093C0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event EHABGBMCGIM IOJJHKECJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5B04550", Offset = "0x5B02B50", VA = "0x185B04550", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5B068C0", Offset = "0x5B04EC0", VA = "0x185B068C0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EHABGBMCGIM MOMJPHEDCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5B08240", Offset = "0x5B06840", VA = "0x185B08240", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5B08000", Offset = "0x5B06600", VA = "0x185B08000", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5B091E0", Offset = "0x5B077E0", VA = "0x185B091E0", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B07CC0", Offset = "0x5B062C0", VA = "0x185B07CC0", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event EHABGBMCGIM LPFNLALMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5B083C0", Offset = "0x5B069C0", VA = "0x185B083C0", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5B038C0", Offset = "0x5B01EC0", VA = "0x185B038C0", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EHABGBMCGIM ADODCIHHFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5B074B0", Offset = "0x5B05AB0", VA = "0x185B074B0", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5B05C40", Offset = "0x5B04240", VA = "0x185B05C40", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B09790", Offset = "0x5B07D90", VA = "0x185B09790")]
	public FPMFILCBKBL(GameObject CGLKMGEDNPH, RigidbodyEx BIIKLPMNIBF, FCIJLMHOABL HGEKNDJMGCO, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B062F0", Offset = "0x5B048F0", VA = "0x185B062F0", Slot = "143")]
	protected virtual void HPGDCLAJMBK(FCIJLMHOABL HGEKNDJMGCO, MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B04D10", Offset = "0x5B03310", VA = "0x185B04D10", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B05440", Offset = "0x5B03A40", VA = "0x185B05440", Slot = "75")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A80", Offset = "0x5B05080", VA = "0x185B06A80", Slot = "76")]
	public void PLHLJLJDDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B06F00", Offset = "0x5B05500", VA = "0x185B06F00", Slot = "77")]
	public void KBGPAMMAFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5B08C50", Offset = "0x5B07250", VA = "0x185B08C50", Slot = "145")]
	public virtual void OBHHBEMGIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5B06070", Offset = "0x5B04670", VA = "0x185B06070", Slot = "86")]
	public void HGKEBMICHFN(OFONBGHOJGA FEBHELIDNED, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5B04610", Offset = "0x5B02C10", VA = "0x185B04610", Slot = "89")]
	public void DAIOEMKCMEC(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5B075B0", Offset = "0x5B05BB0", VA = "0x185B075B0", Slot = "90")]
	public void LEOOOCJMKHO(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5B05F80", Offset = "0x5B04580", VA = "0x185B05F80", Slot = "91")]
	public Vector3 HFDJJMINECH(Vector3 JICDEFICCCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5B07BD0", Offset = "0x5B061D0", VA = "0x185B07BD0", Slot = "92")]
	public Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A80", Offset = "0x5B05080", VA = "0x185B06A80", Slot = "93")]
	public void JFPKJFDHKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5B073B0", Offset = "0x5B059B0", VA = "0x185B073B0", Slot = "94")]
	public void LBJBMANOAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A30", Offset = "0x5B05030", VA = "0x185B06A30", Slot = "95")]
	public void JEOBCDAPIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5B08100", Offset = "0x5B06700", VA = "0x185B08100", Slot = "96")]
	public void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5B04460", Offset = "0x5B02A60", VA = "0x185B04460", Slot = "97")]
	public void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B05680", Offset = "0x5B03C80", VA = "0x185B05680", Slot = "98")]
	public void FHOCDJKNCJL(Vector3 OFJNMKKLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5B039C0", Offset = "0x5B01FC0", VA = "0x185B039C0", Slot = "99")]
	public void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5B05350", Offset = "0x5B03950", VA = "0x185B05350", Slot = "100")]
	public void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5B04670", Offset = "0x5B02C70", VA = "0x185B04670", Slot = "101")]
	[Obsolete]
	public void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5B05130", Offset = "0x5B03730", VA = "0x185B05130", Slot = "102")]
	public Vector3 EKEKOIBPHPJ(Vector3 FEBHELIDNED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5B035D0", Offset = "0x5B01BD0", VA = "0x185B035D0", Slot = "103")]
	public Vector3 AEDDENFLODI(Vector3 FEBHELIDNED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5B06D10", Offset = "0x5B05310", VA = "0x185B06D10", Slot = "104")]
	public void JNOJFFHNMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5B03EB0", Offset = "0x5B024B0", VA = "0x185B03EB0", Slot = "105")]
	public void CAJFNDHHJOE(OFONBGHOJGA MHCAFIHKNDF, object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5B06860", Offset = "0x5B04E60", VA = "0x185B06860", Slot = "106")]
	public void IGBABONPJLI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B05AC0", Offset = "0x5B040C0", VA = "0x185B05AC0", Slot = "44")]
	public void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B04B80", Offset = "0x5B03180", VA = "0x185B04B80", Slot = "109")]
	public void DLAGFDIMLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5B06BA0", Offset = "0x5B051A0", VA = "0x185B06BA0", Slot = "110")]
	public void JGEONDKMANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5B09650", Offset = "0x5B07C50", VA = "0x185B09650", Slot = "111")]
	public void PKGBPBNDJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5B04080", Offset = "0x5B02680", VA = "0x185B04080", Slot = "114")]
	public bool CDHJLIEIJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5B05A70", Offset = "0x5B04070", VA = "0x185B05A70", Slot = "78")]
	public void GHJILLNAPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5B05BA0", Offset = "0x5B041A0", VA = "0x185B05BA0", Slot = "115")]
	public void GKCCAMEHBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5B03580", Offset = "0x5B01B80", VA = "0x185B03580", Slot = "120")]
	public IDisposable ADDACNNIKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5B08300", Offset = "0x5B06900", VA = "0x185B08300", Slot = "121")]
	public void MMJFEINIPCF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5B043B0", Offset = "0x5B029B0", VA = "0x185B043B0", Slot = "122")]
	public void CGNPOECLLLF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5B06960", Offset = "0x5B04F60", VA = "0x185B06960", Slot = "123")]
	public void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5B07960", Offset = "0x5B05F60", VA = "0x185B07960", Slot = "126")]
	public void LMCMIMKGIIP(Vector3 JCLIPFPAKNB, Quaternion IFKFMPIADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5B049D0", Offset = "0x5B02FD0", VA = "0x185B049D0", Slot = "127")]
	public void DJLOLFFHDPO(Vector3 BMLLLNHBIGO, Quaternion DGGEILNBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5B082A0", Offset = "0x5B068A0", VA = "0x185B082A0", Slot = "128")]
	public bool MMBBNPNAHDG(float IPBDNGOJOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5B05CE0", Offset = "0x5B042E0", VA = "0x185B05CE0", Slot = "129")]
	public void GOBLFPLMJHI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5B036C0", Offset = "0x5B01CC0", VA = "0x185B036C0", Slot = "130")]
	public void AGHCFIJAHDG(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5B09120", Offset = "0x5B07720", VA = "0x185B09120", Slot = "131")]
	public void OFLHGNEJJLB(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5B05A10", Offset = "0x5B04010", VA = "0x185B05A10", Slot = "132")]
	public void GHFKJENLLMH(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5B03920", Offset = "0x5B01F20", VA = "0x185B03920")]
	public void ALKLECNDJEA(object LODBJLOKBLP, bool ECEEIOKBPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5B08B10", Offset = "0x5B07110", VA = "0x185B08B10", Slot = "134")]
	public void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5B07200", Offset = "0x5B05800", VA = "0x185B07200", Slot = "135")]
	public void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5B03D80", Offset = "0x5B02380", VA = "0x185B03D80", Slot = "136")]
	public void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5B085D0", Offset = "0x5B06BD0", VA = "0x185B085D0", Slot = "137")]
	public void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5B03B40", Offset = "0x5B02140", VA = "0x185B03B40", Slot = "138")]
	public bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5B06130", Offset = "0x5B04730", VA = "0x185B06130", Slot = "139")]
	public void HKMNJPJFKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5B09750", Offset = "0x5B07D50", VA = "0x185B09750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5B04900", Offset = "0x5B02F00", VA = "0x185B04900")]
	private void DJACCHPEDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5B08960", Offset = "0x5B06F60", VA = "0x185B08960")]
	private void NOPLEHFPLPC(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5B04F40", Offset = "0x5B03540", VA = "0x185B04F40")]
	private void EFNILLOOEEH(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5B095A0", Offset = "0x5B07BA0", VA = "0x185B095A0")]
	private void PFPMCEECGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5B05580", Offset = "0x5B03B80", VA = "0x185B05580")]
	private void FGMKCHFAEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5B07400", Offset = "0x5B05A00", VA = "0x185B07400")]
	private void LCFDNJMOHIM(OFONBGHOJGA CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5B06DC0", Offset = "0x5B053C0", VA = "0x185B06DC0")]
	private void KAGHPDPHLJH(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5B07110", Offset = "0x5B05710", VA = "0x185B07110")]
	private void KMFKCFAPGBC(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5B066A0", Offset = "0x5B04CA0", VA = "0x185B066A0")]
	private void IDMFOIIOOFB(RigidbodyEx KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5B04130", Offset = "0x5B02730", VA = "0x185B04130", Slot = "146")]
	protected virtual void CGJLGLFNFHL(RigidbodyEx CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5B09420", Offset = "0x5B07A20", VA = "0x185B09420")]
	[Conditional("UNITY_EDITOR")]
	private void PBAICNFBAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5B07D20", Offset = "0x5B06320", VA = "0x185B07D20")]
	protected void MAGHCOPBFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5B08D00", Offset = "0x5B07300", VA = "0x185B08D00")]
	protected void OCLFBKPMOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class BOFMNNHPKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3F80", Offset = "0x5AF2580", VA = "0x185AF3F80")]
	public static OFONBGHOJGA OJEGEFEDKLK(this OFONBGHOJGA CIJHLIHFIBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3EB0", Offset = "0x5AF24B0", VA = "0x185AF3EB0")]
	public static bool LKFOHKICEED(this OFONBGHOJGA CIJHLIHFIBP, OFONBGHOJGA EEFJJAMAMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3DC0", Offset = "0x5AF23C0", VA = "0x185AF3DC0")]
	public static bool FIEGILLLCHP(this OFONBGHOJGA CIJHLIHFIBP, OFONBGHOJGA MJHPJJNBELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3F30", Offset = "0x5AF2530", VA = "0x185AF3F30")]
	public static RigidbodyEx LPMEDPADBKE(this OFONBGHOJGA LIPHOMAOMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3E40", Offset = "0x5AF2440", VA = "0x185AF3E40")]
	public static FPMFILCBKBL KJGHGPBDBGA(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IOPJPDHCIPA
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EHABGBMCGIM BMJECAPOBHN;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGEONDKMANN();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DLAGFDIMLAH();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PKGBPBNDJPL();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PAEFCEBGKHG(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HKMNJPJFKJH();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PLNCLHNPCMP
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OFONBGHOJGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx LPMEDPADBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject GLLEEPIMCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> JLFKDFDFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool DLIAJNPEHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool FMOCGGDMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool HIBACOKMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float OBJCBEKNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool CMBGCMCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform BBPLLCKGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform BIGDKHPDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 JEKEADKLECO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float MNBIEAAONEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float JFIILHNBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion HCENNMNFPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints OGBPDLNAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode MFCAHEKOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool LAOKPHOANHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EHABGBMCGIM DKLNHBKPOON;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EHABGBMCGIM JBEIBIJNDEO;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FDGOKJCHHNL JCIJGADBKJO;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EHABGBMCGIM HKDLNOLGELI;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EHABGBMCGIM IOJJHKECJLG;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event EHABGBMCGIM MOMJPHEDCGB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event EHABGBMCGIM LPFNLALMPOI;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event EHABGBMCGIM ADODCIHHFGO;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void PLHLJLJDDOL();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void KBGPAMMAFKP();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void GHJILLNAPAF();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void OBHHBEMGIKN();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void HGKEBMICHFN(OFONBGHOJGA FEBHELIDNED, bool KBOMCJLJCEI = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void DAIOEMKCMEC(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void LEOOOCJMKHO(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 HFDJJMINECH(Vector3 JICDEFICCCA);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JFPKJFDHKLP();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LBJBMANOAOH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void JEOBCDAPIGG();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void FHOCDJKNCJL(Vector3 OFJNMKKLKJK);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 EKEKOIBPHPJ(Vector3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 AEDDENFLODI(Vector3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JNOJFFHNMJP();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CAJFNDHHJOE(OFONBGHOJGA MHCAFIHKNDF, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void IGBABONPJLI(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void DLAGFDIMLAH();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JGEONDKMANN();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void PKGBPBNDJPL();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool CDHJLIEIJJJ();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void GKCCAMEHBOB();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable ADDACNNIKEF();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MMJFEINIPCF(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CGNPOECLLLF(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LMCMIMKGIIP(Vector3 JCLIPFPAKNB, Quaternion IFKFMPIADDE);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void DJLOLFFHDPO(Vector3 BMLLLNHBIGO, Quaternion DGGEILNBDKG);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool MMBBNPNAHDG(float IPBDNGOJOJP);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void GOBLFPLMJHI(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AGHCFIJAHDG(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void OFLHGNEJJLB(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void GHFKJENLLMH(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void HKMNJPJFKJH();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BGHPFEHEINP
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DNHKGEGLKBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FKKLDPBDFDI();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BKNJLFFOMOG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LJOMOANBFHO
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool PHHLNNCCNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	BJDBFCFOACF KOPEINDOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNCKHAPHAFN(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BADOAAPJEHK(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDLGJJHMABK(OFONBGHOJGA CIJHLIHFIBP);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHFHLFKCDHN(OFONBGHOJGA CIJHLIHFIBP);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHHLNODDKHK();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HLMDHICCLOP : IDisposable, AFGAEDNKNBI
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGDKKKLNPMH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GKNFMLNNAHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event EHABGBMCGIM DKLNHBKPOON;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event EHABGBMCGIM JBEIBIJNDEO;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event FDGOKJCHHNL JCIJGADBKJO;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action MGIFLMOGBHA;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action DLAFHBLNKLP;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<OFONBGHOJGA> OONOIGCCGHM;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<OFONBGHOJGA> OMBFFKBBNBJ;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action HOOLNOFKHNF;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<OFONBGHOJGA> KDOGMAIBLMM;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HGKEBMICHFN(OFONBGHOJGA BMPJGPJDGHG, bool KBOMCJLJCEI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface EFENGCOLBME
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKNFMLNNAHO DAMNKLJDJPJ(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACMKCJNLEDE GKGABEELBPB(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOGHMNBHLKO AEKJEJIPNEB(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JFEACPHKHLG DPBNECFPGJJ(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OLODFMHJBBA PEKGKHECOLB(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HLMDHICCLOP IGMKIDOEGBJ(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BGPBCNOJGKF JDMLHOAPKHJ(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BGHPFEHEINP EFKOOHFIMIH(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NNGPHHMDKOJ GLFKANBJMHC(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DCBKBOBKLGO BCKKLLDPNGL(OFONBGHOJGA EGHMJNHBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LJFAGHMDHNE LFPJCAMPPFD(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HOKCEFENPDF BHAOOJHJBBG(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LJOMOANBFHO KIJCBFLOGMP(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IOPJPDHCIPA NKKDPDPDBIF(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HHFMMECNAIN HBHIPILPCEB(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP, FCIJLMHOABL HGEKNDJMGCO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HHFMMECNAIN
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool DBODLLAEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints OGBPDLNAGBP
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
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PAEFCEBGKHG(Rigidbody JNOABPPDPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LBPNAALLFFO
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFMOIBOFKLG(Vector3 BKAMFFFPLFF);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBAFMAKCHDP(Vector3 LPOFGCMCEJI);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEOOMLIBJPO(Vector3 BKAMFFFPLFF);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNGKFDBABKF(Vector3 LPOFGCMCEJI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BGPBCNOJGKF
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> JFKMHBFFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event EHABGBMCGIM LPFNLALMPOI;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDNABFJNFPB();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMJFEINIPCF(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGNPOECLLLF(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable ADDACNNIKEF();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHDOOOFAHKJ(Rigidbody PJFGPOLLAAL);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAEFCEBGKHG(Rigidbody JNOABPPDPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NNGPHHMDKOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode MFCAHEKOFAL
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
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBCGONHGDKF(bool AFLMDOLPCAA);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANGPKGAEGNC(bool AFLMDOLPCAA);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ACMKCJNLEDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MKILCDKGECE(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JEOBCDAPIGG();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LBJBMANOAOH();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JNOJFFHNMJP();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JFPKJFDHKLP();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AEDDENFLODI(Vector3 LPOFGCMCEJI);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 EKEKOIBPHPJ(Vector3 BHCAEBJCEFE);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GOBGLKEECOI(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FHOCDJKNCJL(Vector3 OFJNMKKLKJK);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 HFDJJMINECH(Vector3 JICDEFICCCA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LJFAGHMDHNE
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OFLHGNEJJLB(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHFKJENLLMH(object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFCINKFFNOE();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKLJFMHCOMC();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ENJIKJNGMAG();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BEAEIFIOPCE();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DCBKBOBKLGO
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool CMBGCMCPCAF
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
	void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAEFCEBGKHG(Rigidbody JNOABPPDPPH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OLODFMHJBBA
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event EHABGBMCGIM MOMJPHEDCGB;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGDKKKLNPMH();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CDHJLIEIJJJ();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEFHAGLBJOF();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHJILLNAPAF();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLMCNPNCLHI();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKCCAMEHBOB();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCOIBLJJPNH(bool JBNIAAIKEEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NNNFPBGOJKC(typeof(EJCELCGLOFD), new string[] { })]
public sealed class GNJBFDKNBJA : BIAEDGDMGKC, EJCELCGLOFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ENHHFOCNECE]
	private NMOPMAJCNOG CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool PGDNGHJKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C550", Offset = "0x5B0AB50", VA = "0x185B0C550", Slot = "4")]
	public void InitReferences(AONANDJIJLG FPOFNDLOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C3C0", Offset = "0x5B0A9C0", VA = "0x185B0C3C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BD30", Offset = "0x5B0A330", VA = "0x185B0BD30", Slot = "6")]
	public void AEEOGBCBCNH(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C140", Offset = "0x5B0A740", VA = "0x185B0C140", Slot = "7")]
	public void DPMGAGHPLDA(AIEJIADOHAF EHPNFPDFJDJ, bool PNBAFBCIGBE, bool HFPFGBLDLPH, bool PPJHBDFFDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BEB0", Offset = "0x5B0A4B0", VA = "0x185B0BEB0")]
	private bool DGEKKOKOFGB(AIEJIADOHAF EHPNFPDFJDJ, out CPJNIBJHFEP EGHMJNHBHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C3F0", Offset = "0x5B0A9F0", VA = "0x185B0C3F0")]
	private bool FAKBKGPMPCN(AIEJIADOHAF EHPNFPDFJDJ, out HLNIIGGAEIF EDBMKIGMAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BFE0", Offset = "0x5B0A5E0", VA = "0x185B0BFE0")]
	private bool DGIHAJKBDBB(AIEJIADOHAF EHPNFPDFJDJ, out AOIALPHPIPD DDICPMAHNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public GNJBFDKNBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class AOIALPHPIPD : CFGOLMNEHPA, IOPJPDHCIPA
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDF00", Offset = "0x5AEC500", VA = "0x185AEDF00", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5AED0C0", Offset = "0x5AEB6C0", VA = "0x185AED0C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 JJONLMHKICK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AED960", Offset = "0x5AEBF60", VA = "0x185AED960")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AED0C0", Offset = "0x5AEB6C0", VA = "0x185AED0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 BNHBOMENDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC380", Offset = "0x5AEA980", VA = "0x185AEC380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE260", Offset = "0x5AEC860", VA = "0x185AEE260", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE020", Offset = "0x5AEC620", VA = "0x185AEE020", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float FLBEMBMHOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC5F0", Offset = "0x5AEABF0", VA = "0x185AEC5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5AECB50", Offset = "0x5AEB150", VA = "0x185AECB50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDA80", Offset = "0x5AEC080", VA = "0x185AEDA80", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5AED1D0", Offset = "0x5AEB7D0", VA = "0x185AED1D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5AECA60", Offset = "0x5AEB060", VA = "0x185AECA60", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EHABGBMCGIM BMJECAPOBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AED0F0", Offset = "0x5AEB6F0", VA = "0x185AED0F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE610", Offset = "0x5AECC10", VA = "0x185AEE610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEB00", Offset = "0x5AED100", VA = "0x185AEEB00")]
	public AOIALPHPIPD(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5AECA90", Offset = "0x5AEB090", VA = "0x185AECA90")]
	public float3 GFBEPAEEHJL()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC970", Offset = "0x5AEAF70", VA = "0x185AEC970")]
	public bool DNDADHAGPPK(out float3 GILEAFLLKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE6B0", Offset = "0x5AECCB0", VA = "0x185AEE6B0")]
	public void OGJEPHGOCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE3E0", Offset = "0x5AEC9E0", VA = "0x185AEE3E0")]
	public bool MKLCNPNNELN(out float JGAFGMLHFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AECE50", Offset = "0x5AEB450", VA = "0x185AECE50", Slot = "14")]
	public void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC6E0", Offset = "0x5AEACE0", VA = "0x185AEC6E0", Slot = "16")]
	public void DLAGFDIMLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDB80", Offset = "0x5AEC180", VA = "0x185AEDB80", Slot = "15")]
	public void JGEONDKMANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE4D0", Offset = "0x5AECAD0", VA = "0x185AEE4D0", Slot = "18")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE780", Offset = "0x5AECD80", VA = "0x185AEE780", Slot = "19")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEA30", Offset = "0x5AED030", VA = "0x185AEEA30", Slot = "17")]
	public void PKGBPBNDJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AED200", Offset = "0x5AEB800", VA = "0x185AED200", Slot = "20")]
	public void HKMNJPJFKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AED190", Offset = "0x5AEB790", VA = "0x185AED190")]
	public void HAPOBENEPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC4B0", Offset = "0x5AEAAB0", VA = "0x185AEC4B0")]
	private void BOIGPOIGIOH(Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5AEE0F0", Offset = "0x5AEC6F0", VA = "0x185AEE0F0")]
	[Obsolete]
	private Vector3 KEIMIFNFLNI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDA80", Offset = "0x5AEC080", VA = "0x185AEDA80")]
	private void JDDMCNCDEIB(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AED720", Offset = "0x5AEBD20", VA = "0x185AED720")]
	private Vector3 HOFNCCDDFGH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AECC20", Offset = "0x5AEB220", VA = "0x185AECC20")]
	private Quaternion GHGLPMFHHGN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB2D0", Offset = "0x5AE98D0", VA = "0x185AEB2D0")]
	internal (float, Vector3) AEEOGBCBCNH(Rigidbody BBHLOGLFLAM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class BOHPEHEKNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4040", Offset = "0x5AF2640", VA = "0x185AF4040")]
	public static AOIALPHPIPD FKBMHAAMNPF(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BALBBBPDMFI : CFGOLMNEHPA, ACMKCJNLEDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5AF14D0", Offset = "0x5AEFAD0", VA = "0x185AF14D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AEFB80", Offset = "0x5AEE180", VA = "0x185AEFB80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AEFA50", Offset = "0x5AEE050", VA = "0x185AEFA50", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2330", Offset = "0x5AF0930", VA = "0x185AF2330", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1790", Offset = "0x5AEFD90", VA = "0x185AF1790", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AEEEF0", Offset = "0x5AED4F0", VA = "0x185AEEEF0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AEEFB0", Offset = "0x5AED5B0", VA = "0x185AEEFB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AF14A0", Offset = "0x5AEFAA0", VA = "0x185AF14A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1890", Offset = "0x5AEFE90", VA = "0x185AF1890", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AF13A0", Offset = "0x5AEF9A0", VA = "0x185AF13A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5AF19C0", Offset = "0x5AEFFC0", VA = "0x185AF19C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1600", Offset = "0x5AEFC00", VA = "0x185AF1600", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5AF18F0", Offset = "0x5AEFEF0", VA = "0x185AF18F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0120", Offset = "0x5AEE720", VA = "0x185AF0120", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0FF0", Offset = "0x5AEF5F0", VA = "0x185AF0FF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private BGHPFEHEINP IPFEBIHJIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x21016C0", Offset = "0x20FFCC0", VA = "0x1821016C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2460", Offset = "0x5AF0A60", VA = "0x185AF2460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public BALBBBPDMFI(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2240", Offset = "0x5AF0840", VA = "0x185AF2240", Slot = "20")]
	public void MKILCDKGECE(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5AF10D0", Offset = "0x5AEF6D0", VA = "0x185AF10D0", Slot = "31")]
	public void GOBGLKEECOI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0CF0", Offset = "0x5AEF2F0", VA = "0x185AF0CF0", Slot = "19")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFFF0", Offset = "0x5AEE5F0", VA = "0x185AEFFF0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2420", Offset = "0x5AF0A20", VA = "0x185AF2420", Slot = "28")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5AF11C0", Offset = "0x5AEF7C0", VA = "0x185AF11C0", Slot = "36")]
	public Vector3 HFDJJMINECH(Vector3 JICDEFICCCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5AF19F0", Offset = "0x5AEFFF0", VA = "0x185AF19F0", Slot = "35")]
	public Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0CF0", Offset = "0x5AEF2F0", VA = "0x185AF0CF0", Slot = "27")]
	public void JFPKJFDHKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1850", Offset = "0x5AEFE50", VA = "0x185AF1850", Slot = "25")]
	public void LBJBMANOAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1460", Offset = "0x5AEFA60", VA = "0x185AF1460", Slot = "24")]
	public void JEOBCDAPIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2000", Offset = "0x5AF0600", VA = "0x185AF2000", Slot = "34")]
	public void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFC70", Offset = "0x5AEE270", VA = "0x185AEFC70", Slot = "33")]
	public void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0D60", Offset = "0x5AEF360", VA = "0x185AF0D60", Slot = "32")]
	public void FHOCDJKNCJL(Vector3 OFJNMKKLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF1B0", Offset = "0x5AED7B0", VA = "0x185AEF1B0", Slot = "22")]
	public void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0AB0", Offset = "0x5AEF0B0", VA = "0x185AF0AB0", Slot = "21")]
	public void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEFCD0", Offset = "0x5AEE2D0", VA = "0x185AEFCD0", Slot = "23")]
	[Obsolete]
	public void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0740", Offset = "0x5AEED40", VA = "0x185AF0740", Slot = "30")]
	public Vector3 EKEKOIBPHPJ(Vector3 BHCAEBJCEFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEDF0", Offset = "0x5AED3F0", VA = "0x185AEEDF0", Slot = "29")]
	public Vector3 AEDDENFLODI(Vector3 LPOFGCMCEJI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1630", Offset = "0x5AEFC30", VA = "0x185AF1630", Slot = "26")]
	public void JNOJFFHNMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5AEEFE0", Offset = "0x5AED5E0", VA = "0x185AEEFE0")]
	private void AOANOJALJKB(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF5D0", Offset = "0x5AEDBD0", VA = "0x185AEF5D0")]
	private void BILBAFACLFF(Vector3 ENMFGCINHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0800", Offset = "0x5AEEE00", VA = "0x185AF0800")]
	private Vector3 EPJHPNOPAGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2480", Offset = "0x5AF0A80", VA = "0x185AF2480")]
	private void OJGJCHEGPIM(Vector3 CLKLNJLAMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5AEF7A0", Offset = "0x5AEDDA0", VA = "0x185AEF7A0")]
	private Vector3 BKNJLFFOMOG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5AF1BB0", Offset = "0x5AF01B0", VA = "0x185AF1BB0")]
	private void MBAFMAKCHDP(Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5AF28E0", Offset = "0x5AF0EE0", VA = "0x185AF28E0")]
	private void PDACDMMECGL(Vector3 BHCAEBJCEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5AF17F0", Offset = "0x5AEFDF0", VA = "0x185AF17F0")]
	private void KKCDFAFLCAH(Vector3 LPOFGCMCEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0130", Offset = "0x5AEE730", VA = "0x185AF0130")]
	private void ECMFNHAKCNN(string CMIPJEIOKPM, Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5AF0F30", Offset = "0x5AEF530", VA = "0x185AF0F30")]
	private void FLKMPONDDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class BKHCIECMKDD : CFGOLMNEHPA, JFEACPHKHLG
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5AF3910", Offset = "0x5AF1F10", VA = "0x185AF3910", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5AF3570", Offset = "0x5AF1B70", VA = "0x185AF3570", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float OBJCBEKNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5AF3C70", Offset = "0x5AF2270", VA = "0x185AF3C70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5AF3740", Offset = "0x5AF1D40", VA = "0x185AF3740", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public BKHCIECMKDD(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5AF39E0", Offset = "0x5AF1FE0", VA = "0x185AF39E0", Slot = "8")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3BA0", Offset = "0x5AF21A0", VA = "0x185AF3BA0", Slot = "9")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class KLGDMHNAPIM : OFONBGHOJGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KLGDMHNAPIM FBBAELKBDJK;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx LPMEDPADBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject GLLEEPIMCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> JLFKDFDFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x943FA0", Offset = "0x9425A0", VA = "0x180943FA0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9440C0", Offset = "0x9426C0", VA = "0x1809440C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9440B0", Offset = "0x9426B0", VA = "0x1809440B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x943F80", Offset = "0x942580", VA = "0x180943F80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x923330", Offset = "0x921930", VA = "0x180923330", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x943FB0", Offset = "0x9425B0", VA = "0x180943FB0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x920E90", Offset = "0x91F490", VA = "0x180920E90", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE0D100", Offset = "0xE0B700", VA = "0x180E0D100", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE0C8C0", Offset = "0xE0AEC0", VA = "0x180E0C8C0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2E398D0", Offset = "0x2E37ED0", VA = "0x182E398D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2E39830", Offset = "0x2E37E30", VA = "0x182E39830", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x17402A0", Offset = "0x173E8A0", VA = "0x1817402A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x173DC80", Offset = "0x173C280", VA = "0x18173DC80", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x17402C0", Offset = "0x173E8C0", VA = "0x1817402C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x173CEA0", Offset = "0x173B4A0", VA = "0x18173CEA0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool DLIAJNPEHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x925720", Offset = "0x923D20", VA = "0x180925720", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool FMOCGGDMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x925760", Offset = "0x923D60", VA = "0x180925760", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool HIBACOKMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8C00", Offset = "0x1CC7200", VA = "0x181CC8C00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8C40", Offset = "0x1CC7240", VA = "0x181CC8C40", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE61E60", Offset = "0xE60460", VA = "0x180E61E60", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x16BF750", Offset = "0x16BDD50", VA = "0x1816BF750", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x925450", Offset = "0x923A50", VA = "0x180925450", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1C0D090", Offset = "0x1C0B690", VA = "0x181C0D090", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBD9800", VA = "0x180BDB200", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1396B20", Offset = "0x1395120", VA = "0x181396B20", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBD9800", VA = "0x180BDB200", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float OBJCBEKNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBD9800", VA = "0x180BDB200", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool CMBGCMCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool NIPGFOMJMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "51")]
		get
		{
			return default(DEJBIADAKBB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x2573830", Offset = "0x2571E30", VA = "0x182573830", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform BBPLLCKGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1244180", Offset = "0x1242780", VA = "0x181244180", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform BIGDKHPDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x921940", Offset = "0x91FF40", VA = "0x180921940", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 JEKEADKLECO
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float MNBIEAAONEC
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBD9800", VA = "0x180BDB200", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float JFIILHNBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBD9800", VA = "0x180BDB200", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion HCENNMNFPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1468DF0", Offset = "0x14673F0", VA = "0x181468DF0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1468DF0", Offset = "0x14673F0", VA = "0x181468DF0", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints OGBPDLNAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode MFCAHEKOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LAOKPHOANHG
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE34B20", Offset = "0xE33120", VA = "0x180E34B20", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EHABGBMCGIM DKLNHBKPOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EHABGBMCGIM JBEIBIJNDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FDGOKJCHHNL JCIJGADBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event EHABGBMCGIM HKDLNOLGELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event EHABGBMCGIM IOJJHKECJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event EHABGBMCGIM MOMJPHEDCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event EHABGBMCGIM LPFNLALMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event EHABGBMCGIM ADODCIHHFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "44")]
	public void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "75")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "76")]
	public void PLHLJLJDDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "77")]
	public void KBGPAMMAFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "78")]
	public void GHJILLNAPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "79")]
	public void OBHHBEMGIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "86")]
	public void HGKEBMICHFN(OFONBGHOJGA FEBHELIDNED, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "89")]
	public void DAIOEMKCMEC(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "90")]
	public void LEOOOCJMKHO(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "91")]
	public Vector3 HFDJJMINECH(Vector3 JICDEFICCCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "92")]
	public Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "93")]
	public void JFPKJFDHKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "94")]
	public void LBJBMANOAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "95")]
	public void JEOBCDAPIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "96")]
	public void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "97")]
	public void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "98")]
	public void FHOCDJKNCJL(Vector3 OFJNMKKLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "99")]
	public void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "100")]
	public void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "101")]
	public void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "102")]
	public Vector3 EKEKOIBPHPJ(Vector3 FEBHELIDNED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xABED20", Offset = "0xABD320", VA = "0x180ABED20", Slot = "103")]
	public Vector3 AEDDENFLODI(Vector3 FEBHELIDNED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "104")]
	public void JNOJFFHNMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "105")]
	public void CAJFNDHHJOE(OFONBGHOJGA MHCAFIHKNDF, object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "106")]
	public void IGBABONPJLI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "109")]
	public void DLAGFDIMLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "110")]
	public void JGEONDKMANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "111")]
	public void PKGBPBNDJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "114")]
	public bool CDHJLIEIJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "115")]
	public void GKCCAMEHBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "120")]
	public IDisposable ADDACNNIKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "121")]
	public void MMJFEINIPCF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "122")]
	public void CGNPOECLLLF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "123")]
	public void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "126")]
	public void LMCMIMKGIIP(Vector3 JCLIPFPAKNB, Quaternion IFKFMPIADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "127")]
	public void DJLOLFFHDPO(Vector3 BMLLLNHBIGO, Quaternion DGGEILNBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "128")]
	public bool MMBBNPNAHDG(float IPBDNGOJOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "129")]
	public void GOBLFPLMJHI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "130")]
	public void AGHCFIJAHDG(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "131")]
	public void OFLHGNEJJLB(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "132")]
	public void GHFKJENLLMH(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "134")]
	public void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "135")]
	public void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "136")]
	public void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "137")]
	public void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F260", Offset = "0x5B0D860", VA = "0x185B0F260", Slot = "138")]
	public bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "139")]
	public void HKMNJPJFKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public KLGDMHNAPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FJOEAFLJBIC : CFGOLMNEHPA, OOGHMNBHLKO
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF320", Offset = "0x5AFD920", VA = "0x185AFF320", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF160", Offset = "0x5AFD760", VA = "0x185AFF160", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF350", Offset = "0x5AFD950", VA = "0x185AFF350")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private OFONBGHOJGA FKENCIFKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF7E0", Offset = "0x5AFDDE0", VA = "0x185AFF7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public FJOEAFLJBIC(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF940", Offset = "0x5AFDF40", VA = "0x185AFF940", Slot = "6")]
	public void OJEHGAAAKMN(OFONBGHOJGA KHJHJOOPMKP, object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AFFAC0", Offset = "0x5AFE0C0", VA = "0x185AFFAC0")]
	private void OJEHGAAAKMN(CPJNIBJHFEP KHJHJOOPMKP, object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF070", Offset = "0x5AFD670", VA = "0x185AFF070", Slot = "7")]
	public void BKAMICOMAAK(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF430", Offset = "0x5AFDA30", VA = "0x185AFF430")]
	private Vector3 MGFHDJCFOCH()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class MALFLJABBMK
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x712BB00", Offset = "0x712A100", VA = "0x18712BB00")]
	public static FJOEAFLJBIC AEKFJHHOBAP(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class CNGKGHFNFFP : CFGOLMNEHPA, GKNFMLNNAHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly CMJEFMOJNAO NAPJDOILKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OCHKLIDFKOH ECFLHHEDNLI;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5AD0", Offset = "0x5AF40D0", VA = "0x185AF5AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public AIEJIADOHAF HGFPLOKBADO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4680", Offset = "0x5AF2C80", VA = "0x185AF4680")]
		get
		{
			return default(AIEJIADOHAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4EC0", Offset = "0x5AF34C0", VA = "0x185AF4EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4A00", Offset = "0x5AF3000", VA = "0x185AF4A00", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5AF59C0", Offset = "0x5AF3FC0", VA = "0x185AF59C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public AIEJIADOHAF MNJMMEDHDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4220", Offset = "0x5AF2820", VA = "0x185AF4220")]
		get
		{
			return default(AIEJIADOHAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5820", Offset = "0x5AF3E20", VA = "0x185AF5820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4460", Offset = "0x5AF2A60", VA = "0x185AF4460", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event EHABGBMCGIM DKLNHBKPOON
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5A30", Offset = "0x5AF4030", VA = "0x185AF5A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5FC0", Offset = "0x5AF45C0", VA = "0x185AF5FC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event EHABGBMCGIM JBEIBIJNDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6190", Offset = "0x5AF4790", VA = "0x185AF6190", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5AF55F0", Offset = "0x5AF3BF0", VA = "0x185AF55F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event FDGOKJCHHNL JCIJGADBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5AF45E0", Offset = "0x5AF2BE0", VA = "0x185AF45E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4E20", Offset = "0x5AF3420", VA = "0x185AF4E20", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action MGIFLMOGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5690", Offset = "0x5AF3C90", VA = "0x185AF5690", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4780", Offset = "0x5AF2D80", VA = "0x185AF4780", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action DLAFHBLNKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5B00", Offset = "0x5AF4100", VA = "0x185AF5B00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6400", Offset = "0x5AF4A00", VA = "0x185AF6400", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<OFONBGHOJGA> OONOIGCCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5AF44A0", Offset = "0x5AF2AA0", VA = "0x185AF44A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5920", Offset = "0x5AF3F20", VA = "0x185AF5920", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<OFONBGHOJGA> OMBFFKBBNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6360", Offset = "0x5AF4960", VA = "0x185AF6360", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4540", Offset = "0x5AF2B40", VA = "0x185AF4540", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action HOOLNOFKHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5D20", Offset = "0x5AF4320", VA = "0x185AF5D20", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4320", Offset = "0x5AF2920", VA = "0x185AF4320", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<OFONBGHOJGA> KDOGMAIBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4BE0", Offset = "0x5AF31E0", VA = "0x185AF4BE0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5AF43C0", Offset = "0x5AF29C0", VA = "0x185AF43C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6530", Offset = "0x5AF4B30", VA = "0x185AF6530")]
	public CNGKGHFNFFP(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4820", Offset = "0x5AF2E20", VA = "0x185AF4820", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5AF57A0", Offset = "0x5AF3DA0", VA = "0x185AF57A0", Slot = "26")]
	public void HGKEBMICHFN(OFONBGHOJGA BMPJGPJDGHG, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5AF5730", Offset = "0x5AF3D30", VA = "0x185AF5730")]
	private void HGKEBMICHFN(CPJNIBJHFEP BMPJGPJDGHG, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4FC0", Offset = "0x5AF35C0", VA = "0x185AF4FC0")]
	private void FPDNHKHINIE(CPJNIBJHFEP BMPJGPJDGHG, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4A40", Offset = "0x5AF3040", VA = "0x185AF4A40")]
	private void ELBNLOIKKHK(CPJNIBJHFEP CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4C80", Offset = "0x5AF3280", VA = "0x185AF4C80")]
	private void FLKANIFBOGB(CPJNIBJHFEP CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AF5DC0", Offset = "0x5AF43C0", VA = "0x185AF5DC0")]
	private void MOGCAGPABHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AF5C50", Offset = "0x5AF4250", VA = "0x185AF5C50")]
	private void MKBGEMJMEPL(CPJNIBJHFEP CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AF5BA0", Offset = "0x5AF41A0", VA = "0x185AF5BA0")]
	private void MEPIACJHGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6060", Offset = "0x5AF4660", VA = "0x185AF6060")]
	private void OHKLDBMINNB(CPJNIBJHFEP CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6230", Offset = "0x5AF4830", VA = "0x185AF6230")]
	private void OPLEBKGGPAP(CPJNIBJHFEP CIJHLIHFIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class LMALHDCPGJB
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x712BA90", Offset = "0x712A090", VA = "0x18712BA90")]
	public static CNGKGHFNFFP ALAPLOOKJDD(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CPJNIBJHFEP : FPMFILCBKBL, CMEDKBLEPDC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal NMOPMAJCNOG GKPEJEEHMAO;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8140", Offset = "0x5AF6740", VA = "0x185AF8140")]
	public CPJNIBJHFEP(GameObject CGLKMGEDNPH, RigidbodyEx BIIKLPMNIBF, FCIJLMHOABL HGEKNDJMGCO, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AF79E0", Offset = "0x5AF5FE0", VA = "0x185AF79E0", Slot = "143")]
	protected override void HPGDCLAJMBK(FCIJLMHOABL HGEKNDJMGCO, MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AF76E0", Offset = "0x5AF5CE0", VA = "0x185AF76E0", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7620", Offset = "0x5AF5C20", VA = "0x185AF7620", Slot = "147")]
	public void BFHABDBJNEC(LADENCOPJDI IOHGKHFMCBP, LADENCOPJDI AODCBCDFMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7FC0", Offset = "0x5AF65C0", VA = "0x185AF7FC0", Slot = "148")]
	public void PMMBANIDNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8080", Offset = "0x5AF6680", VA = "0x185AF8080", Slot = "149")]
	public void POJPONNLGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7F60", Offset = "0x5AF6560", VA = "0x185AF7F60", Slot = "150")]
	public void OCOIBLJJPNH(bool JBNIAAIKEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7870", Offset = "0x5AF5E70", VA = "0x185AF7870", Slot = "151")]
	public bool GJHNHBIFCLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7F00", Offset = "0x5AF6500", VA = "0x185AF7F00", Slot = "152")]
	public void LNKFBDMKMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "146")]
	protected override void CGJLGLFNFHL(RigidbodyEx HHOBHGKDNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7CC0", Offset = "0x5AF62C0", VA = "0x185AF7CC0")]
	private void LGODCJDENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "145")]
	public override void OBHHBEMGIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class KIKLBMMOLHK
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F210", Offset = "0x5B0D810", VA = "0x185B0F210")]
	public static FPMFILCBKBL GAIAHONJKND(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class AEGLFAOFGAC : CFGOLMNEHPA, LJOMOANBFHO
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string NPOADBJLCJF = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool PHHLNNCCNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA2B0", Offset = "0x5AE88B0", VA = "0x185AEA2B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public BJDBFCFOACF KOPEINDOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA0B0", Offset = "0x5AE86B0", VA = "0x185AEA0B0", Slot = "5")]
		get
		{
			return default(BJDBFCFOACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private BJDBFCFOACF MMJHLPGHKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9D50", Offset = "0x5AE8350", VA = "0x185AE9D50")]
		get
		{
			return default(BJDBFCFOACF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA0C0", Offset = "0x5AE86C0", VA = "0x185AEA0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA620", Offset = "0x5AE8C20", VA = "0x185AEA620")]
	public AEGLFAOFGAC(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9FB0", Offset = "0x5AE85B0", VA = "0x185AE9FB0", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA380", Offset = "0x5AE8980", VA = "0x185AEA380")]
	private bool OHOEEBKCOMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA1B0", Offset = "0x5AE87B0", VA = "0x185AEA1B0", Slot = "7")]
	public void JNCKHAPHAFN(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9C50", Offset = "0x5AE8250", VA = "0x185AE9C50", Slot = "8")]
	public void BADOAAPJEHK(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA510", Offset = "0x5AE8B10", VA = "0x185AEA510", Slot = "11")]
	public void PHHLNODDKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA420", Offset = "0x5AE8A20", VA = "0x185AEA420")]
	private void PFPDGBINIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9E20", Offset = "0x5AE8420", VA = "0x185AE9E20")]
	private void FCACPILADIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9C10", Offset = "0x5AE8210", VA = "0x185AE9C10", Slot = "10")]
	public void AHFHLFKCDHN(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA070", Offset = "0x5AE8670", VA = "0x185AEA070", Slot = "9")]
	public void IDLGJJHMABK(OFONBGHOJGA CIJHLIHFIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class COJIIDBBGPP : CFGOLMNEHPA, BGHPFEHEINP
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6EF0", Offset = "0x5AF54F0", VA = "0x185AF6EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6E90", Offset = "0x5AF5490", VA = "0x185AF6E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6F40", Offset = "0x5AF5540", VA = "0x185AF6F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public COJIIDBBGPP(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5AF74C0", Offset = "0x5AF5AC0", VA = "0x185AF74C0", Slot = "4")]
	public void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6950", Offset = "0x5AF4F50", VA = "0x185AF6950")]
	private void BBJEFKAKGPN(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6FA0", Offset = "0x5AF55A0", VA = "0x185AF6FA0", Slot = "5")]
	public void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6C40", Offset = "0x5AF5240", VA = "0x185AF6C40", Slot = "6")]
	public void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5AF66D0", Offset = "0x5AF4CD0", VA = "0x185AF66D0")]
	private void ACBGDFLNFPM(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5AF7240", Offset = "0x5AF5840", VA = "0x185AF7240", Slot = "7")]
	public void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5AF6DA0", Offset = "0x5AF53A0", VA = "0x185AF6DA0")]
	private void BKMKBHBEAIO(string JIEHBANCLJP, UnityEngine.Object JHAKINLMMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class OGHJFKJHNDD : CFGOLMNEHPA, LJFAGHMDHNE
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string MDOIGPOGDCA = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x712D300", Offset = "0x712B900", VA = "0x18712D300", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x712DE90", Offset = "0x712C490", VA = "0x18712DE90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x712C030", Offset = "0x712A630", VA = "0x18712C030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x712D990", Offset = "0x712BF90", VA = "0x18712D990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x712DF90", Offset = "0x712C590", VA = "0x18712DF90")]
	public OGHJFKJHNDD(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x712D250", Offset = "0x712B850", VA = "0x18712D250", Slot = "5")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x712DD90", Offset = "0x712C390", VA = "0x18712DD90", Slot = "7")]
	public void OFLHGNEJJLB(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x712D3E0", Offset = "0x712B9E0", VA = "0x18712D3E0", Slot = "8")]
	public void GHFKJENLLMH(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x712D740", Offset = "0x712BD40", VA = "0x18712D740", Slot = "9")]
	public void MFCINKFFNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x712D4E0", Offset = "0x712BAE0", VA = "0x18712D4E0", Slot = "10")]
	public void HKLJFMHCOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x712D080", Offset = "0x712B680", VA = "0x18712D080", Slot = "11")]
	public void ENJIKJNGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "12")]
	public void BEAEIFIOPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x712DC00", Offset = "0x712C200", VA = "0x18712DC00")]
	private void OFGLLHJGNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x712DA70", Offset = "0x712C070", VA = "0x18712DA70")]
	private void NNPJOBEFPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class HLNIIGGAEIF : CFGOLMNEHPA, BGPBCNOJGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D510", Offset = "0x5B0BB10", VA = "0x185B0D510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> JFKMHBFFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D6E0", Offset = "0x5B0BCE0", VA = "0x185B0D6E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool KNBGCPGILCK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D860", Offset = "0x5B0BE60", VA = "0x185B0D860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event EHABGBMCGIM LPFNLALMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D7C0", Offset = "0x5B0BDC0", VA = "0x185B0D7C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D460", Offset = "0x5B0BA60", VA = "0x185B0D460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public HLNIIGGAEIF(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D3A0", Offset = "0x5B0B9A0", VA = "0x185B0D3A0", Slot = "12")]
	public IDisposable ADDACNNIKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D7B0", Offset = "0x5B0BDB0", VA = "0x185B0D7B0", Slot = "9")]
	public void MMJFEINIPCF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D500", Offset = "0x5B0BB00", VA = "0x185B0D500", Slot = "10")]
	public void CGNPOECLLLF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D5E0", Offset = "0x5B0BBE0", VA = "0x185B0D5E0", Slot = "11")]
	public void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D930", Offset = "0x5B0BF30", VA = "0x185B0D930", Slot = "13")]
	public void NHDOOOFAHKJ(Rigidbody PJFGPOLLAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DB00", Offset = "0x5B0C100", VA = "0x185B0DB00", Slot = "14")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5AED190", Offset = "0x5AEB790", VA = "0x185AED190", Slot = "6")]
	public void CDNABFJNFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GAGONLLNNGM : CFGOLMNEHPA, NNGPHHMDKOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode DIEAGHFAILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AB10", Offset = "0x5B09110", VA = "0x185B0AB10")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AEF0", Offset = "0x5B094F0", VA = "0x185B0AEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode MFCAHEKOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AFF0", Offset = "0x5B095F0", VA = "0x185B0AFF0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B190", Offset = "0x5B09790", VA = "0x185B0B190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public GAGONLLNNGM(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ABE0", Offset = "0x5B091E0", VA = "0x185B0ABE0", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B100", Offset = "0x5B09700", VA = "0x185B0B100", Slot = "9")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AFE0", Offset = "0x5B095E0", VA = "0x185B0AFE0", Slot = "7")]
	public void LBCGONHGDKF(bool AFLMDOLPCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A990", Offset = "0x5B08F90", VA = "0x185B0A990", Slot = "8")]
	public void ANGPKGAEGNC(bool AFLMDOLPCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A9A0", Offset = "0x5B08FA0", VA = "0x185B0A9A0", Slot = "10")]
	public bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ACF0", Offset = "0x5B092F0", VA = "0x185B0ACF0")]
	private void HCEHELJJMBO(bool AFLMDOLPCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class OCHKLIDFKOH : IReadOnlyList<OFONBGHOJGA>, IEnumerable<OFONBGHOJGA>, IEnumerable, IReadOnlyCollection<OFONBGHOJGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly NMOPMAJCNOG LNGEDFDIBDI;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x712CE00", Offset = "0x712B400", VA = "0x18712CE00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public OFONBGHOJGA KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x712CED0", Offset = "0x712B4D0", VA = "0x18712CED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x712CDB0", Offset = "0x712B3B0", VA = "0x18712CDB0")]
	public OCHKLIDFKOH(AIEJIADOHAF PAGDHPEICGI, NMOPMAJCNOG LNGEDFDIBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x712CC20", Offset = "0x712B220", VA = "0x18712CC20", Slot = "6")]
	public IEnumerator<OFONBGHOJGA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x712CC20", Offset = "0x712B220", VA = "0x18712CC20", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x712CC10", Offset = "0x712B210", VA = "0x18712CC10")]
	[CompilerGenerated]
	private OFONBGHOJGA ALHKMMPEDJJ(int JMCLMPHOKNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HAEGKLJBADD : EFENGCOLBME
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C9E0", Offset = "0x5B0AFE0", VA = "0x185B0C9E0", Slot = "4")]
	public GKNFMLNNAHO DAMNKLJDJPJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CDA0", Offset = "0x5B0B3A0", VA = "0x185B0CDA0", Slot = "5")]
	public ACMKCJNLEDE GKGABEELBPB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C660", Offset = "0x5B0AC60", VA = "0x185B0C660", Slot = "6")]
	public OOGHMNBHLKO AEKJEJIPNEB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CBB0", Offset = "0x5B0B1B0", VA = "0x185B0CBB0", Slot = "7")]
	public JFEACPHKHLG DPBNECFPGJJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D170", Offset = "0x5B0B770", VA = "0x185B0D170", Slot = "8")]
	public OLODFMHJBBA PEKGKHECOLB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CF50", Offset = "0x5B0B550", VA = "0x185B0CF50", Slot = "9")]
	public HLMDHICCLOP IGMKIDOEGBJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CFF0", Offset = "0x5B0B5F0", VA = "0x185B0CFF0", Slot = "10")]
	public BGPBCNOJGKF JDMLHOAPKHJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CC50", Offset = "0x5B0B250", VA = "0x185B0CC50", Slot = "11")]
	public BGHPFEHEINP EFKOOHFIMIH(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CE40", Offset = "0x5B0B440", VA = "0x185B0CE40", Slot = "12")]
	public NNGPHHMDKOJ GLFKANBJMHC(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C700", Offset = "0x5B0AD00", VA = "0x185B0C700", Slot = "13")]
	public DCBKBOBKLGO BCKKLLDPNGL(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D090", Offset = "0x5B0B690", VA = "0x185B0D090")]
	public LJFAGHMDHNE LFPJCAMPPFD(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C7A0", Offset = "0x5B0ADA0", VA = "0x185B0C7A0")]
	public HOKCEFENPDF BHAOOJHJBBG(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C860", Offset = "0x5B0AE60", VA = "0x185B0C860")]
	public LJOMOANBFHO KIJCBFLOGMP(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D100", Offset = "0x5B0B700", VA = "0x185B0D100")]
	public IOPJPDHCIPA NKKDPDPDBIF(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CEE0", Offset = "0x5B0B4E0", VA = "0x185B0CEE0")]
	public HHFMMECNAIN HBHIPILPCEB(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CCF0", Offset = "0x5B0B2F0", VA = "0x185B0CCF0", Slot = "19")]
	public OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP, FCIJLMHOABL HGEKNDJMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public HAEGKLJBADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D090", Offset = "0x5B0B690", VA = "0x185B0D090", Slot = "14")]
	private LJFAGHMDHNE MDOMHAMPMON(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C7A0", Offset = "0x5B0ADA0", VA = "0x185B0C7A0", Slot = "15")]
	private HOKCEFENPDF JPNFJJICMPC(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C860", Offset = "0x5B0AE60", VA = "0x185B0C860", Slot = "16")]
	private LJOMOANBFHO CEIHNAPLGLN(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D100", Offset = "0x5B0B700", VA = "0x185B0D100", Slot = "17")]
	private IOPJPDHCIPA MJMBGCOGJAI(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CEE0", Offset = "0x5B0B4E0", VA = "0x185B0CEE0", Slot = "18")]
	private HHFMMECNAIN KKBEPLBNKED(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class GACJPIFGJIC : CFGOLMNEHPA, OLODFMHJBBA
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int HHCFOEIMAAK = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float JLPCKHEJGML = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float IKLBMDFCJAB = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float HNLNLHAELJD = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool CFONHMGIGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A700", Offset = "0x5B08D00", VA = "0x185B0A700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2460", Offset = "0x5AF0A60", VA = "0x185AF2460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5B09F60", Offset = "0x5B08560", VA = "0x185B09F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5B09E00", Offset = "0x5B08400", VA = "0x185B09E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool LAIGDOMNPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5B09B10", Offset = "0x5B08110", VA = "0x185B09B10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A4A0", Offset = "0x5B08AA0", VA = "0x185B0A4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool GIDEOAIMCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A330", Offset = "0x5B08930", VA = "0x185B0A330")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5B09E60", Offset = "0x5B08460", VA = "0x185B09E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int CKLKGNOHGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A630", Offset = "0x5B08C30", VA = "0x185B0A630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5B09860", Offset = "0x5B07E60", VA = "0x185B09860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event EHABGBMCGIM MOMJPHEDCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A590", Offset = "0x5B08B90", VA = "0x185B0A590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A400", Offset = "0x5B08A00", VA = "0x185B0A400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A7A0", Offset = "0x5B08DA0", VA = "0x185B0A7A0")]
	public GACJPIFGJIC(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5B09FC0", Offset = "0x5B085C0", VA = "0x185B09FC0", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5B09F50", Offset = "0x5B08550", VA = "0x185B09F50", Slot = "8")]
	public void DEFHAGLBJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5B09BE0", Offset = "0x5B081E0", VA = "0x185B09BE0", Slot = "7")]
	public bool CDHJLIEIJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A070", Offset = "0x5B08670", VA = "0x185B0A070", Slot = "9")]
	public void GHJILLNAPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5AED190", Offset = "0x5AEB790", VA = "0x185AED190", Slot = "12")]
	public void OCOIBLJJPNH(bool JBNIAAIKEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A120", Offset = "0x5B08720", VA = "0x185B0A120", Slot = "11")]
	public void GKCCAMEHBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "10")]
	public void MLMCNPNCLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5B09950", Offset = "0x5B07F50", VA = "0x185B09950")]
	private bool ADJCEAOGKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A1D0", Offset = "0x5B087D0", VA = "0x185B0A1D0")]
	private void IJIFINGABBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[NNNFPBGOJKC(typeof(EFENGCOLBME), new string[] { })]
public class PANFHCPONFK : EFENGCOLBME, BIAEDGDMGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly EFENGCOLBME HOKMHJDBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly EFENGCOLBME BCEKDHLECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private AMIGGHNJKLM MHPDKIIMBGC;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private EFENGCOLBME MBGHEHKJBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x712F1E0", Offset = "0x712D7E0", VA = "0x18712F1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x712F2E0", Offset = "0x712D8E0", VA = "0x18712F2E0", Slot = "20")]
	public void InitReferences(AONANDJIJLG FPOFNDLOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x712ECC0", Offset = "0x712D2C0", VA = "0x18712ECC0", Slot = "4")]
	public GKNFMLNNAHO DAMNKLJDJPJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x712EFF0", Offset = "0x712D5F0", VA = "0x18712EFF0", Slot = "5")]
	public ACMKCJNLEDE GKGABEELBPB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x712EA20", Offset = "0x712D020", VA = "0x18712EA20", Slot = "6")]
	public OOGHMNBHLKO AEKJEJIPNEB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x712ED60", Offset = "0x712D360", VA = "0x18712ED60", Slot = "7")]
	public JFEACPHKHLG DPBNECFPGJJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x712F530", Offset = "0x712DB30", VA = "0x18712F530", Slot = "8")]
	public OLODFMHJBBA PEKGKHECOLB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x712F240", Offset = "0x712D840", VA = "0x18712F240", Slot = "9")]
	public HLMDHICCLOP IGMKIDOEGBJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x712F330", Offset = "0x712D930", VA = "0x18712F330", Slot = "10")]
	public BGPBCNOJGKF JDMLHOAPKHJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x712EE00", Offset = "0x712D400", VA = "0x18712EE00", Slot = "11")]
	public BGHPFEHEINP EFKOOHFIMIH(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x712F090", Offset = "0x712D690", VA = "0x18712F090", Slot = "12")]
	public NNGPHHMDKOJ GLFKANBJMHC(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x712EAC0", Offset = "0x712D0C0", VA = "0x18712EAC0", Slot = "13")]
	public DCBKBOBKLGO BCKKLLDPNGL(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x712F3D0", Offset = "0x712D9D0", VA = "0x18712F3D0")]
	public LJFAGHMDHNE LFPJCAMPPFD(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x712EB60", Offset = "0x712D160", VA = "0x18712EB60")]
	public HOKCEFENPDF BHAOOJHJBBG(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x712EC10", Offset = "0x712D210", VA = "0x18712EC10")]
	public LJOMOANBFHO KIJCBFLOGMP(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x712F480", Offset = "0x712DA80", VA = "0x18712F480")]
	public IOPJPDHCIPA NKKDPDPDBIF(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x712F130", Offset = "0x712D730", VA = "0x18712F130")]
	public HHFMMECNAIN HBHIPILPCEB(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x712EEA0", Offset = "0x712D4A0", VA = "0x18712EEA0", Slot = "19")]
	public OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP, FCIJLMHOABL HGEKNDJMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x712F5D0", Offset = "0x712DBD0", VA = "0x18712F5D0")]
	public PANFHCPONFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x712F3D0", Offset = "0x712D9D0", VA = "0x18712F3D0", Slot = "14")]
	private LJFAGHMDHNE MDOMHAMPMON(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x712EB60", Offset = "0x712D160", VA = "0x18712EB60", Slot = "15")]
	private HOKCEFENPDF JPNFJJICMPC(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x712EC10", Offset = "0x712D210", VA = "0x18712EC10", Slot = "16")]
	private LJOMOANBFHO CEIHNAPLGLN(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x712F480", Offset = "0x712DA80", VA = "0x18712F480", Slot = "17")]
	private IOPJPDHCIPA MJMBGCOGJAI(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x712F130", Offset = "0x712D730", VA = "0x18712F130", Slot = "18")]
	private HHFMMECNAIN KKBEPLBNKED(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class AKKLGNFMLJE : CFGOLMNEHPA, DCBKBOBKLGO
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool CMBGCMCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA950", Offset = "0x5AE8F50", VA = "0x185AEA950", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA780", Offset = "0x5AE8D80", VA = "0x185AEA780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public AKKLGNFMLJE(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAA20", Offset = "0x5AE9020", VA = "0x185AEAA20", Slot = "6")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB20", Offset = "0x5AE9120", VA = "0x185AEAB20", Slot = "7")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class CFGOLMNEHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly CPJNIBJHFEP CIJHLIHFIBP;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected NMOPMAJCNOG DPGHBHLJCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x54F7800", Offset = "0x54F5E00", VA = "0x1854F7800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5AF41F0", Offset = "0x5AF27F0", VA = "0x185AF41F0")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public CFGOLMNEHPA(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5AF40D0", Offset = "0x5AF26D0", VA = "0x185AF40D0")]
	protected OFONBGHOJGA AFIHDOELMPF(AIEJIADOHAF PAGDHPEICGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class FLNJHCGAPCA : CFGOLMNEHPA, HOKCEFENPDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView DBCKNEFLANI;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5B02C40", Offset = "0x5B01240", VA = "0x185B02C40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5B03120", Offset = "0x5B01720", VA = "0x185B03120", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event EHABGBMCGIM HKDLNOLGELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x5B02E70", Offset = "0x5B01470", VA = "0x185B02E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5B033F0", Offset = "0x5B019F0", VA = "0x185B033F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5B03490", Offset = "0x5B01A90", VA = "0x185B03490")]
	public FLNJHCGAPCA(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5B028C0", Offset = "0x5B00EC0", VA = "0x185B028C0", Slot = "8")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5B026D0", Offset = "0x5B00CD0", VA = "0x185B026D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5B02C60", Offset = "0x5B01260", VA = "0x185B02C60", Slot = "9")]
	public void KAGHPDPHLJH(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5B02F10", Offset = "0x5B01510", VA = "0x185B02F10", Slot = "10")]
	public void KMFKCFAPGBC(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5B02A10", Offset = "0x5B01010", VA = "0x185B02A10")]
	private void HJDDABIBOFC(PhotonView IIBLEIOEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5B03240", Offset = "0x5B01840", VA = "0x185B03240")]
	private void OHCCBKOPCCC(RigidbodyEx AHAMNKNBHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5B024F0", Offset = "0x5B00AF0", VA = "0x185B024F0")]
	private void BEGDNMNPCOA(PhotonView AJBKOALBKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class DKMNFIKEKJI
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5AF84F0", Offset = "0x5AF6AF0", VA = "0x185AF84F0")]
	public static FLNJHCGAPCA DCDPKEOAJJC(this FPMFILCBKBL EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class FIJIBCGFLAC : CFGOLMNEHPA, HHFMMECNAIN
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE6D0", Offset = "0x5AFCCD0", VA = "0x185AFE6D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE5E0", Offset = "0x5AFCBE0", VA = "0x185AFE5E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool DBODLLAEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5AFED70", Offset = "0x5AFD370", VA = "0x185AFED70", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE7A0", Offset = "0x5AFCDA0", VA = "0x185AFE7A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints OGBPDLNAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5AFEAA0", Offset = "0x5AFD0A0", VA = "0x185AFEAA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE890", Offset = "0x5AFCE90", VA = "0x185AFE890", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5AFEE40", Offset = "0x5AFD440", VA = "0x185AFEE40")]
	public FIJIBCGFLAC(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5AFEB70", Offset = "0x5AFD170", VA = "0x185AFEB70", Slot = "9")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5AFEC70", Offset = "0x5AFD270", VA = "0x185AFEC70", Slot = "10")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class FCOJGCOMFGA : CFGOLMNEHPA, HLMDHICCLOP, IDisposable, AFGAEDNKNBI
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public DEJBIADAKBB OCPOCPOPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDBD0", Offset = "0x5AFC1D0", VA = "0x185AFDBD0")]
		get
		{
			return default(DEJBIADAKBB);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDD40", Offset = "0x5AFC340", VA = "0x185AFDD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDE30", Offset = "0x5AFC430", VA = "0x185AFDE30", Slot = "6")]
		get
		{
			return default(DEJBIADAKBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDD40", Offset = "0x5AFC340", VA = "0x185AFDD40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform APFIGKMHIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE040", Offset = "0x5AFC640", VA = "0x185AFE040", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDCA0", Offset = "0x5AFC2A0", VA = "0x185AFDCA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB90", Offset = "0x5AE9190", VA = "0x185AEAB90")]
	public FCOJGCOMFGA(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5AFE0E0", Offset = "0x5AFC6E0", VA = "0x185AFE0E0", Slot = "11")]
	public void OnChangedDistanceBand(HGKLKDHHOMH IOHGKHFMCBP, HGKLKDHHOMH AODCBCDFMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "12")]
	public void OnChangedVisibility(bool CBHMPGAJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class KNFFOBLONLM : HLMDHICCLOP, IDisposable, AFGAEDNKNBI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int CNPMMBDAFAN = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private DEJBIADAKBB MHNGNMMDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private KEJBPCKPMPL FILGCBFKAME;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public DEJBIADAKBB KCBNOHCCLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x712B760", Offset = "0x7129D60", VA = "0x18712B760", Slot = "6")]
		get
		{
			return default(DEJBIADAKBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x712B690", Offset = "0x7129C90", VA = "0x18712B690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform APFIGKMHIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x712B5D0", Offset = "0x7129BD0", VA = "0x18712B5D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<HGKLKDHHOMH, HGKLKDHHOMH> DEMJOMCCDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x712B810", Offset = "0x7129E10", VA = "0x18712B810", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x712B5F0", Offset = "0x7129BF0", VA = "0x18712B5F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x712B8B0", Offset = "0x7129EB0", VA = "0x18712B8B0")]
	public KNFFOBLONLM(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x712B370", Offset = "0x7129970", VA = "0x18712B370", Slot = "8")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x712B2C0", Offset = "0x71298C0", VA = "0x18712B2C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x712B310", Offset = "0x7129910", VA = "0x18712B310", Slot = "11")]
	private void EDEEFEBOJNO(HGKLKDHHOMH FAMEAJFIOMB, HGKLKDHHOMH IAEIKKJEGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "12")]
	private void LKPBDEMANLI(bool CBHMPGAJEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class PKGNHDMPKML : FAKMAGEOGIN, HOKCEFENPDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView DBCKNEFLANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool HCHMGABFAIG;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView DDMPLJHAEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool DLBPCIKJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5B02C40", Offset = "0x5B01240", VA = "0x185B02C40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool GJFHOJKDLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC0", Offset = "0xA614C0", VA = "0x180A62EC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event EHABGBMCGIM HKDLNOLGELI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7130250", Offset = "0x712E850", VA = "0x187130250", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x71304F0", Offset = "0x712EAF0", VA = "0x1871304F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7130590", Offset = "0x712EB90", VA = "0x187130590")]
	public PKGNHDMPKML(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x712FE70", Offset = "0x712E470", VA = "0x18712FE70", Slot = "9")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x712FD60", Offset = "0x712E360", VA = "0x18712FD60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x71300D0", Offset = "0x712E6D0", VA = "0x1871300D0", Slot = "10")]
	public void KAGHPDPHLJH(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x71302F0", Offset = "0x712E8F0", VA = "0x1871302F0", Slot = "11")]
	public void KMFKCFAPGBC(OFONBGHOJGA KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x712FFC0", Offset = "0x712E5C0", VA = "0x18712FFC0")]
	private void HJDDABIBOFC(PhotonView IIBLEIOEFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7130470", Offset = "0x712EA70", VA = "0x187130470")]
	private void OHCCBKOPCCC(RigidbodyEx AHAMNKNBHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x712FB70", Offset = "0x712E170", VA = "0x18712FB70")]
	private void BEGDNMNPCOA(PhotonView AJBKOALBKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class NJEOICBLEPK
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x712CB90", Offset = "0x712B190", VA = "0x18712CB90")]
	public static FAKMAGEOGIN DCDPKEOAJJC(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class MJJGDKJKFIC : LJFAGHMDHNE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string MDOIGPOGDCA = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HMOFDMCMMHE FLJOHLNPBDC;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x9989D0", Offset = "0x996FD0", VA = "0x1809989D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x712C030", Offset = "0x712A630", VA = "0x18712C030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool ADOGCNAHFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x94C630", Offset = "0x94AC30", VA = "0x18094C630", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x712CAE0", Offset = "0x712B0E0", VA = "0x18712CAE0")]
	public MJJGDKJKFIC(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x712C1D0", Offset = "0x712A7D0", VA = "0x18712C1D0", Slot = "5")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x712CAB0", Offset = "0x712B0B0", VA = "0x18712CAB0", Slot = "7")]
	public void OFLHGNEJJLB(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x712C280", Offset = "0x712A880", VA = "0x18712C280", Slot = "8")]
	public void GHFKJENLLMH(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x712C4B0", Offset = "0x712AAB0", VA = "0x18712C4B0", Slot = "9")]
	public void MFCINKFFNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x712C2B0", Offset = "0x712A8B0", VA = "0x18712C2B0", Slot = "10")]
	public void HKLJFMHCOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x712C050", Offset = "0x712A650", VA = "0x18712C050", Slot = "11")]
	public void ENJIKJNGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x712BBF0", Offset = "0x712A1F0", VA = "0x18712BBF0", Slot = "12")]
	public void BEAEIFIOPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x712C930", Offset = "0x712AF30", VA = "0x18712C930")]
	private void OFGLLHJGNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x712C7B0", Offset = "0x712ADB0", VA = "0x18712C7B0")]
	private void NNPJOBEFPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LFKMDPDHGEN : HHFMMECNAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints PLAAPHPJNLF;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool NIHHOMFNEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xC91740", Offset = "0xC8FD40", VA = "0x180C91740", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x2497420", Offset = "0x2495A20", VA = "0x182497420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool DBODLLAEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x284D2E0", Offset = "0x284B8E0", VA = "0x18284D2E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x284D2F0", Offset = "0x284B8F0", VA = "0x18284D2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints OGBPDLNAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x944070", Offset = "0x942670", VA = "0x180944070", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x712B8F0", Offset = "0x7129EF0", VA = "0x18712B8F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x712BA30", Offset = "0x712A030", VA = "0x18712BA30")]
	public LFKMDPDHGEN(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x712B9D0", Offset = "0x7129FD0", VA = "0x18712B9D0", Slot = "9")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x712BA00", Offset = "0x712A000", VA = "0x18712BA00", Slot = "10")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class IGNHGOLMDAO : BGHPFEHEINP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6EF0", Offset = "0x5AF54F0", VA = "0x185AF6EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6E90", Offset = "0x5AF5490", VA = "0x185AF6E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B0E340", Offset = "0x5B0C940", VA = "0x185B0E340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB240", Offset = "0x5AE9840", VA = "0x185AEB240")]
	public IGNHGOLMDAO(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E8C0", Offset = "0x5B0CEC0", VA = "0x185B0E8C0", Slot = "4")]
	public void OAJIOHFPOAL(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DF60", Offset = "0x5B0C560", VA = "0x185B0DF60")]
	private void BBJEFKAKGPN(Vector3 PNPIPMIPGBD, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E3A0", Offset = "0x5B0C9A0", VA = "0x185B0E3A0", Slot = "5")]
	public void KPOIPOPAFOB(Vector3 PNPIPMIPGBD, Vector3 FADCMIMHMJH, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E1E0", Offset = "0x5B0C7E0", VA = "0x185B0E1E0", Slot = "6")]
	public void BJDDMJJACJB(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DCE0", Offset = "0x5B0C2E0", VA = "0x185B0DCE0")]
	private void ACBGDFLNFPM(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E640", Offset = "0x5B0CC40", VA = "0x185B0E640", Slot = "7")]
	public void NIKGEDBNIMC(Vector3 DJKOOGGABNP, ForceMode JEOJBIEFCAO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class BHODDEJMABO : FNKGNMMIHCC, OOGHMNBHLKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NLJDCNPADCK<OFONBGHOJGA> FGKODNOALIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool DCKJKGKMDKO;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public NLJDCNPADCK<OFONBGHOJGA> HOKNGAPFMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 NHDHGKMPFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2B70", Offset = "0x5AF1170", VA = "0x185AF2B70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 NAGDBNPOHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5AF29A0", Offset = "0x5AF0FA0", VA = "0x185AF29A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2BA0", Offset = "0x5AF11A0", VA = "0x185AF2BA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public OFONBGHOJGA FKENCIFKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AF3360", Offset = "0x5AF1960", VA = "0x185AF3360", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3480", Offset = "0x5AF1A80", VA = "0x185AF3480")]
	public BHODDEJMABO(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3410", Offset = "0x5AF1A10", VA = "0x185AF3410", Slot = "8")]
	public void OJEHGAAAKMN(OFONBGHOJGA KHJHJOOPMKP, object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2940", Offset = "0x5AF0F40", VA = "0x185AF2940", Slot = "9")]
	public void BKAMICOMAAK(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3030", Offset = "0x5AF1630", VA = "0x185AF3030")]
	private Vector3 MGFHDJCFOCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AF2C80", Offset = "0x5AF1280", VA = "0x185AF2C80")]
	private void MBHDGIBLCKG(OFONBGHOJGA DOKNNNBLCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class GPPAHJGBCAB
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C5A0", Offset = "0x5B0ABA0", VA = "0x185B0C5A0")]
	public static FNKGNMMIHCC AEKFJHHOBAP(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class FKPNEDKEPGD : BAFNJAAGCAH, IOPJPDHCIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 AEBCBPIOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 CHDJMFPCPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float OGAOFMHMEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float JGAFGMLHFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 OIJFJCECNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? HDOKHMMEHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? GGPJNMNHNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool FHMEOLDNOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool NPNGEFKPDFP;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 HGLHBMFCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x507CFA0", Offset = "0x507B5A0", VA = "0x18507CFA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B01120", Offset = "0x5AFF720", VA = "0x185B01120", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 BFKLIGLCAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B01E10", Offset = "0x5B00410", VA = "0x185B01E10", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float ECONCMCFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xBF9130", Offset = "0xBF7730", VA = "0x180BF9130", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B01CF0", Offset = "0x5B002F0", VA = "0x185B01CF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float EKLMDCOJJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xBF9140", Offset = "0xBF7740", VA = "0x180BF9140", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B01A10", Offset = "0x5B00010", VA = "0x185B01A10", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 IAAIHFLJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B01270", Offset = "0x5AFF870", VA = "0x185B01270", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion JHBPDOIIJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B00BB0", Offset = "0x5AFF1B0", VA = "0x185B00BB0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B00D20", Offset = "0x5AFF320", VA = "0x185B00D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event EHABGBMCGIM BMJECAPOBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B011D0", Offset = "0x5AFF7D0", VA = "0x185B011D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B02000", Offset = "0x5B00600", VA = "0x185B02000", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5B023F0", Offset = "0x5B009F0", VA = "0x185B023F0")]
	public FKPNEDKEPGD(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B009E0", Offset = "0x5AFEFE0", VA = "0x185B009E0", Slot = "17")]
	public void DLAGFDIMLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B01AC0", Offset = "0x5B000C0", VA = "0x185B01AC0", Slot = "16")]
	public void JGEONDKMANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B01F20", Offset = "0x5B00520", VA = "0x185B01F20", Slot = "19")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B020A0", Offset = "0x5B006A0", VA = "0x185B020A0", Slot = "20")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B02290", Offset = "0x5B00890", VA = "0x185B02290", Slot = "18")]
	public void PKGBPBNDJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B013E0", Offset = "0x5AFF9E0", VA = "0x185B013E0", Slot = "21")]
	public void HKMNJPJFKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B01120", Offset = "0x5AFF720", VA = "0x185B01120")]
	private void NJELCPADHHK(Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B01BE0", Offset = "0x5B001E0", VA = "0x185B01BE0")]
	[Obsolete]
	private Vector3 KEIMIFNFLNI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5B01CF0", Offset = "0x5B002F0", VA = "0x185B01CF0")]
	private void OKHPOAGOPGK(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5B01A10", Offset = "0x5B00010", VA = "0x185B01A10")]
	private void JDDMCNCDEIB(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5B018A0", Offset = "0x5AFFEA0", VA = "0x185B018A0")]
	private Vector3 HOFNCCDDFGH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5B00EE0", Offset = "0x5AFF4E0", VA = "0x185B00EE0", Slot = "15")]
	public void GHKHKLPLBCA((Quaternion rot, Vector3 moments) EDPHAEDLFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5B00D70", Offset = "0x5AFF370", VA = "0x185B00D70")]
	private Quaternion GHGLPMFHHGN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5B00900", Offset = "0x5AFEF00", VA = "0x185B00900")]
	public void AEEOGBCBCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5AFFBE0", Offset = "0x5AFE1E0", VA = "0x185AFFBE0", Slot = "4")]
	public (float, Vector3) AEEOGBCBCNH(Rigidbody BBHLOGLFLAM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class MEINIDAKHAM
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x712BB70", Offset = "0x712A170", VA = "0x18712BB70")]
	public static BAFNJAAGCAH FKBMHAAMNPF(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FNKGNMMIHCC : OOGHMNBHLKO
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	NLJDCNPADCK<OFONBGHOJGA> HOKNGAPFMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	OFONBGHOJGA FKENCIFKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class FCJEFGCAMMD : ACMKCJNLEDE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HMOFDMCMMHE DACLLHBELMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float DJJLJFPNFJA;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DNHKGEGLKBK DHCDAHJIONP
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x943F60", Offset = "0x942560", VA = "0x180943F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public LBPNAALLFFO HDBDNCDOINO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 KNMOOFMPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC5F0", Offset = "0x5AFABF0", VA = "0x185AFC5F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAC80", Offset = "0x5AF9280", VA = "0x185AFAC80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 NBLLECMFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAD40", Offset = "0x5AF9340", VA = "0x185AFAD40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC430", Offset = "0x5AFAA30", VA = "0x185AFC430", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 BMIIBFGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC750", Offset = "0x5AFAD50", VA = "0x185AFC750", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC330", Offset = "0x5AFA930", VA = "0x185AFC330", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 GAJCBFMAAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC880", Offset = "0x5AFAE80", VA = "0x185AFC880", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC460", Offset = "0x5AFAA60", VA = "0x185AFC460", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float ACKCLFFFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xC57580", Offset = "0xC55B80", VA = "0x180C57580", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAE30", Offset = "0x5AF9430", VA = "0x185AFAE30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool MDAHJPLFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x994240", Offset = "0x992840", VA = "0x180994240", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private BGHPFEHEINP IPFEBIHJIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x21016C0", Offset = "0x20FFCC0", VA = "0x1821016C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2460", Offset = "0x5AF0A60", VA = "0x185AF2460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDAF0", Offset = "0x5AFC0F0", VA = "0x185AFDAF0")]
	public FCJEFGCAMMD(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBE80", Offset = "0x5AFA480", VA = "0x185AFBE80", Slot = "19")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBA40", Offset = "0x5AFA040", VA = "0x185AFBA40", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD0A0", Offset = "0x5AFB6A0", VA = "0x185AFD0A0", Slot = "28")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x993EB0", Offset = "0x9924B0", VA = "0x180993EB0", Slot = "20")]
	public void MKILCDKGECE(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x993E10", Offset = "0x992410", VA = "0x180993E10", Slot = "31")]
	public void GOBGLKEECOI(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC150", Offset = "0x5AFA750", VA = "0x185AFC150", Slot = "36")]
	public Vector3 HFDJJMINECH(Vector3 JICDEFICCCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC970", Offset = "0x5AFAF70", VA = "0x185AFC970", Slot = "35")]
	public Vector3 LMEKDDLFGDE(Vector3 CLKLNJLAMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBE80", Offset = "0x5AFA480", VA = "0x185AFBE80", Slot = "27")]
	public void JFPKJFDHKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC710", Offset = "0x5AFAD10", VA = "0x185AFC710", Slot = "25")]
	public void LBJBMANOAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC3F0", Offset = "0x5AFA9F0", VA = "0x185AFC3F0", Slot = "24")]
	public void JEOBCDAPIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5AFCE60", Offset = "0x5AFB460", VA = "0x185AFCE60", Slot = "34")]
	public void MGGCINPEMFP(Vector3 AJGIGALFKDA, Vector3 JHGJCJNLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB6E0", Offset = "0x5AF9CE0", VA = "0x185AFB6E0", Slot = "33")]
	public void CLHMBAOFDPB(Vector3 BFHFALKFPAC, Vector3 NJNFBPAFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBEF0", Offset = "0x5AFA4F0", VA = "0x185AFBEF0", Slot = "32")]
	public void FHOCDJKNCJL(Vector3 OFJNMKKLKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAF50", Offset = "0x5AF9550", VA = "0x185AFAF50", Slot = "22")]
	public void AOIENOOHCJO(LOEECLHCINF CIIMDLNKAPA, Vector3 BHEIKHNMCPN, float ODHMCIGDEAA, float EIMLBHKJAOK = 8f, float HKIKICNPCGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBC50", Offset = "0x5AFA250", VA = "0x185AFBC50", Slot = "21")]
	public void EPNJOMGCCLC(OOEFPNBEJNC IHBNLJJEOEF, Vector3 ENMFGCINHOM, float HMMIJIPDNDD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB740", Offset = "0x5AF9D40", VA = "0x185AFB740", Slot = "23")]
	[Obsolete]
	public void DHIABCCKKLE(OOEFPNBEJNC IHBNLJJEOEF, Vector3 HOHKOHLHECA, float NFLAJEHEGPG = 7f, float OHMJFDANMNM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBAA0", Offset = "0x5AFA0A0", VA = "0x185AFBAA0", Slot = "30")]
	public Vector3 EKEKOIBPHPJ(Vector3 BHCAEBJCEFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAB80", Offset = "0x5AF9180", VA = "0x185AFAB80", Slot = "29")]
	public Vector3 AEDDENFLODI(Vector3 LPOFGCMCEJI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC490", Offset = "0x5AFAA90", VA = "0x185AFC490", Slot = "26")]
	public void JNOJFFHNMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAE30", Offset = "0x5AF9430", VA = "0x185AFAE30")]
	private void AOANOJALJKB(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB440", Offset = "0x5AF9A40", VA = "0x185AFB440")]
	private void BILBAFACLFF(Vector3 ENMFGCINHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBB60", Offset = "0x5AFA160", VA = "0x185AFBB60")]
	private Vector3 EPJHPNOPAGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD1D0", Offset = "0x5AFB7D0", VA = "0x185AFD1D0")]
	private void OJGJCHEGPIM(Vector3 CLKLNJLAMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB5E0", Offset = "0x5AF9BE0", VA = "0x185AFB5E0")]
	private Vector3 BKNJLFFOMOG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5AFCB30", Offset = "0x5AFB130", VA = "0x185AFCB30")]
	private void MBAFMAKCHDP(Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD4F0", Offset = "0x5AFBAF0", VA = "0x185AFD4F0")]
	private void PDACDMMECGL(Vector3 CLKLNJLAMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC090", Offset = "0x5AFA690", VA = "0x185AFC090")]
	private void FLKMPONDDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class PJPLINBGNPD : BGPBCNOJGKF
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string AOMDOOKGGJA = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HMOFDMCMMHE EDMHFOHNMBC;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool FCJFIFJMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x712F7C0", Offset = "0x712DDC0", VA = "0x18712F7C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> JFKMHBFFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x712F960", Offset = "0x712DF60", VA = "0x18712F960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event EHABGBMCGIM LPFNLALMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x712F990", Offset = "0x712DF90", VA = "0x18712F990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x712F6D0", Offset = "0x712DCD0", VA = "0x18712F6D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x712FAE0", Offset = "0x712E0E0", VA = "0x18712FAE0")]
	public PJPLINBGNPD(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x712F670", Offset = "0x712DC70", VA = "0x18712F670", Slot = "12")]
	public IDisposable ADDACNNIKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x712F980", Offset = "0x712DF80", VA = "0x18712F980", Slot = "9")]
	public void MMJFEINIPCF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x712F7B0", Offset = "0x712DDB0", VA = "0x18712F7B0", Slot = "10")]
	public void CGNPOECLLLF(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x712F860", Offset = "0x712DE60", VA = "0x18712F860", Slot = "11")]
	public void JBDJOOKINFL(object LODBJLOKBLP, bool HCLOPJHBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x712F770", Offset = "0x712DD70", VA = "0x18712F770", Slot = "6")]
	public void CDNABFJNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x712FA30", Offset = "0x712E030", VA = "0x18712FA30", Slot = "13")]
	public void NHDOOOFAHKJ(Rigidbody PJFGPOLLAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x712FAB0", Offset = "0x712E0B0", VA = "0x18712FAB0", Slot = "14")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class ANCMEHMBMBA : NNGPHHMDKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode BJIEJGAKEFA;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAEB0", Offset = "0x5AE94B0", VA = "0x185AEAEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode MFCAHEKOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB040", Offset = "0x5AE9640", VA = "0x185AEB040", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB1D0", Offset = "0x5AE97D0", VA = "0x185AEB1D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB240", Offset = "0x5AE9840", VA = "0x185AEB240")]
	public ANCMEHMBMBA(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAD90", Offset = "0x5AE9390", VA = "0x185AEAD90", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB150", Offset = "0x5AE9750", VA = "0x185AEB150", Slot = "9")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB030", Offset = "0x5AE9630", VA = "0x185AEB030", Slot = "7")]
	public void LBCGONHGDKF(bool AFLMDOLPCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAC10", Offset = "0x5AE9210", VA = "0x185AEAC10", Slot = "8")]
	public void ANGPKGAEGNC(bool AFLMDOLPCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAC20", Offset = "0x5AE9220", VA = "0x185AEAC20", Slot = "10")]
	public bool BCGAMKDIIPP(Vector3 JPHMHCBHKFF, out RaycastHit DEGGBIADFMP, float HPJGDBFIPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAF00", Offset = "0x5AE9500", VA = "0x185AEAF00")]
	private void HCEHELJJMBO(bool AFLMDOLPCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GFHJPOAIJBN : EFENGCOLBME
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B580", Offset = "0x5B09B80", VA = "0x185B0B580", Slot = "4")]
	public GKNFMLNNAHO DAMNKLJDJPJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B840", Offset = "0x5B09E40", VA = "0x185B0B840", Slot = "5")]
	public ACMKCJNLEDE GKGABEELBPB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B210", Offset = "0x5B09810", VA = "0x185B0B210", Slot = "6")]
	public OOGHMNBHLKO AEKJEJIPNEB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B670", Offset = "0x5B09C70", VA = "0x185B0B670", Slot = "7")]
	public JFEACPHKHLG DPBNECFPGJJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BCD0", Offset = "0x5B0A2D0", VA = "0x185B0BCD0", Slot = "8")]
	public OLODFMHJBBA PEKGKHECOLB(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BA70", Offset = "0x5B0A070", VA = "0x185B0BA70", Slot = "9")]
	public HLMDHICCLOP IGMKIDOEGBJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BAD0", Offset = "0x5B0A0D0", VA = "0x185B0BAD0", Slot = "10")]
	public BGPBCNOJGKF JDMLHOAPKHJ(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B6E0", Offset = "0x5B09CE0", VA = "0x185B0B6E0", Slot = "11")]
	public BGHPFEHEINP EFKOOHFIMIH(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B950", Offset = "0x5B09F50", VA = "0x185B0B950", Slot = "12")]
	public NNGPHHMDKOJ GLFKANBJMHC(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B330", Offset = "0x5B09930", VA = "0x185B0B330", Slot = "13")]
	public DCBKBOBKLGO BCKKLLDPNGL(OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BB30", Offset = "0x5B0A130", VA = "0x185B0BB30")]
	public LJFAGHMDHNE LFPJCAMPPFD(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B3F0", Offset = "0x5B099F0", VA = "0x185B0B3F0")]
	public HOKCEFENPDF BHAOOJHJBBG(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B460", Offset = "0x5B09A60", VA = "0x185B0B460")]
	public LJOMOANBFHO KIJCBFLOGMP(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BBA0", Offset = "0x5B0A1A0", VA = "0x185B0BBA0")]
	public IOPJPDHCIPA NKKDPDPDBIF(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BA00", Offset = "0x5B0A000", VA = "0x185B0BA00")]
	public HHFMMECNAIN HBHIPILPCEB(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B790", Offset = "0x5B09D90", VA = "0x185B0B790", Slot = "19")]
	public OFONBGHOJGA FDMBLGGAMGJ(RigidbodyEx CIJHLIHFIBP, MHIFJHDIDOK GOMDNNCBLHP, FCIJLMHOABL HGEKNDJMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public GFHJPOAIJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BB30", Offset = "0x5B0A130", VA = "0x185B0BB30", Slot = "14")]
	private LJFAGHMDHNE MDOMHAMPMON(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B3F0", Offset = "0x5B099F0", VA = "0x185B0B3F0", Slot = "15")]
	private HOKCEFENPDF JPNFJJICMPC(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B460", Offset = "0x5B09A60", VA = "0x185B0B460", Slot = "16")]
	private LJOMOANBFHO CEIHNAPLGLN(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BBA0", Offset = "0x5B0A1A0", VA = "0x185B0BBA0", Slot = "17")]
	private IOPJPDHCIPA MJMBGCOGJAI(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BA00", Offset = "0x5B0A000", VA = "0x185B0BA00", Slot = "18")]
	private HHFMMECNAIN KKBEPLBNKED(OFONBGHOJGA EGHMJNHBHOI, in MHIFJHDIDOK GOMDNNCBLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class DPNNPDPCDCL : KFICGMAAIDL, GKNFMLNNAHO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly OFONBGHOJGA CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<OFONBGHOJGA> LKDCEDKMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private OFONBGHOJGA MPEICFNBKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private OFONBGHOJGA KHJHJOOPMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform MJEOHFAKDFM;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5AF99E0", Offset = "0x5AF7FE0", VA = "0x185AF99E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x940DB0", Offset = "0x93F3B0", VA = "0x180940DB0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9710", Offset = "0x5AF7D10", VA = "0x185AF9710", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public OFONBGHOJGA PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<OFONBGHOJGA> EKNLGJHNBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event EHABGBMCGIM DKLNHBKPOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9810", Offset = "0x5AF7E10", VA = "0x185AF9810", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9D80", Offset = "0x5AF8380", VA = "0x185AF9D80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event EHABGBMCGIM JBEIBIJNDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9EC0", Offset = "0x5AF84C0", VA = "0x185AF9EC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8E40", Offset = "0x5AF7440", VA = "0x185AF8E40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event FDGOKJCHHNL JCIJGADBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5AF87D0", Offset = "0x5AF6DD0", VA = "0x185AF87D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8DA0", Offset = "0x5AF73A0", VA = "0x185AF8DA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action MGIFLMOGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8EE0", Offset = "0x5AF74E0", VA = "0x185AF8EE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8870", Offset = "0x5AF6E70", VA = "0x185AF8870", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action DLAFHBLNKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9A40", Offset = "0x5AF8040", VA = "0x185AF9A40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA0A0", Offset = "0x5AF86A0", VA = "0x185AFA0A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<OFONBGHOJGA> OONOIGCCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8690", Offset = "0x5AF6C90", VA = "0x185AF8690", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9670", Offset = "0x5AF7C70", VA = "0x185AF9670", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<OFONBGHOJGA> OMBFFKBBNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA000", Offset = "0x5AF8600", VA = "0x185AFA000", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8730", Offset = "0x5AF6D30", VA = "0x185AF8730", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action HOOLNOFKHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5AF9C50", Offset = "0x5AF8250", VA = "0x185AF9C50", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8550", Offset = "0x5AF6B50", VA = "0x185AF8550", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<OFONBGHOJGA> KDOGMAIBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8B40", Offset = "0x5AF7140", VA = "0x185AF8B40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5AF85F0", Offset = "0x5AF6BF0", VA = "0x185AF85F0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA140", Offset = "0x5AF8740", VA = "0x185AFA140")]
	public DPNNPDPCDCL(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8910", Offset = "0x5AF6F10", VA = "0x185AF8910", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5AF90D0", Offset = "0x5AF76D0", VA = "0x185AF90D0", Slot = "30")]
	public void HGKEBMICHFN(OFONBGHOJGA BMPJGPJDGHG, bool KBOMCJLJCEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8990", Offset = "0x5AF6F90", VA = "0x185AF8990", Slot = "6")]
	public void ELBNLOIKKHK(OFONBGHOJGA CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8BE0", Offset = "0x5AF71E0", VA = "0x185AF8BE0", Slot = "7")]
	public void FLKANIFBOGB(OFONBGHOJGA CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9E20", Offset = "0x5AF8420", VA = "0x185AF9E20", Slot = "4")]
	public void OHKLDBMINNB(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9F60", Offset = "0x5AF8560", VA = "0x185AF9F60", Slot = "5")]
	public void OPLEBKGGPAP(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9CF0", Offset = "0x5AF82F0", VA = "0x185AF9CF0")]
	private void MOGCAGPABHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9C10", Offset = "0x5AF8210", VA = "0x185AF9C10")]
	private void MKBGEMJMEPL(OFONBGHOJGA CPKPAOGCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8F80", Offset = "0x5AF7580", VA = "0x185AF8F80")]
	private void HGFAEALDMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9AE0", Offset = "0x5AF80E0", VA = "0x185AF9AE0")]
	private void MEPIACJHGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5AF98B0", Offset = "0x5AF7EB0", VA = "0x185AF98B0")]
	private void LEPCGDGFLIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5AF9720", Offset = "0x5AF7D20", VA = "0x185AF9720")]
	[CompilerGenerated]
	private object KAOGFIPFMDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class PLJPDPBNMFD
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x71305F0", Offset = "0x712EBF0", VA = "0x1871305F0")]
	public static KFICGMAAIDL ALAPLOOKJDD(this OFONBGHOJGA EGHMJNHBHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JHFJBDAKNMA : LJOMOANBFHO
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string NPOADBJLCJF = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly HMOFDMCMMHE LBDHLAPFMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly BJDBFCFOACF PPKMCBDGMPJ;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool PHHLNNCCNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x94C630", Offset = "0x94AC30", VA = "0x18094C630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public BJDBFCFOACF KOPEINDOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x9B80A0", Offset = "0x9B66A0", VA = "0x1809B80A0", Slot = "5")]
		get
		{
			return default(BJDBFCFOACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F030", Offset = "0x5B0D630", VA = "0x185B0F030")]
	public JHFJBDAKNMA(OFONBGHOJGA CIJHLIHFIBP, in MHIFJHDIDOK GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EC10", Offset = "0x5B0D210", VA = "0x185B0EC10", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ED50", Offset = "0x5B0D350", VA = "0x185B0ED50")]
	private bool OHOEEBKCOMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ED20", Offset = "0x5B0D320", VA = "0x185B0ED20", Slot = "7")]
	public void JNCKHAPHAFN(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EA60", Offset = "0x5B0D060", VA = "0x185B0EA60", Slot = "8")]
	public void BADOAAPJEHK(object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EF00", Offset = "0x5B0D500", VA = "0x185B0EF00", Slot = "11")]
	public void PHHLNODDKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EDF0", Offset = "0x5B0D3F0", VA = "0x185B0EDF0")]
	private void PFPDGBINIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EA90", Offset = "0x5B0D090", VA = "0x185B0EA90")]
	private void FCACPILADIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EA20", Offset = "0x5B0D020", VA = "0x185B0EA20", Slot = "10")]
	public void AHFHLFKCDHN(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ECE0", Offset = "0x5B0D2E0", VA = "0x185B0ECE0", Slot = "9")]
	public void IDLGJJHMABK(OFONBGHOJGA CIJHLIHFIBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BAFNJAAGCAH : IOPJPDHCIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AEEOGBCBCNH(Rigidbody BBHLOGLFLAM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KFICGMAAIDL : GKNFMLNNAHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHKLDBMINNB(OFONBGHOJGA CIJHLIHFIBP);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPLEBKGGPAP(OFONBGHOJGA CIJHLIHFIBP);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELBNLOIKKHK(OFONBGHOJGA CPKPAOGCJOL);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLKANIFBOGB(OFONBGHOJGA CPKPAOGCJOL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class HBJBEBFPKOG : DCBKBOBKLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool OPCNBLMOAJG;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CMBGCMCPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x954B90", Offset = "0x953190", VA = "0x180954B90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D1D0", Offset = "0x5B0B7D0", VA = "0x185B0D1D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D310", Offset = "0x5B0B910", VA = "0x185B0D310")]
	public HBJBEBFPKOG(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D2E0", Offset = "0x5B0B8E0", VA = "0x185B0D2E0", Slot = "6")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB20", Offset = "0x5AE9120", VA = "0x185AEAB20", Slot = "7")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class OLABMFJJGNN : OLODFMHJBBA
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int HHCFOEIMAAK = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float JLPCKHEJGML = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float IKLBMDFCJAB = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float HNLNLHAELJD = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly FPMFILCBKBL CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool BNNCNFCOJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool OICPNPCHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int CABNHPJEJFD;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody COHKPGCDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x712E330", Offset = "0x712C930", VA = "0x18712E330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool CFONHMGIGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x712E8F0", Offset = "0x712CEF0", VA = "0x18712E8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool DHELCLKAHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x712E960", Offset = "0x712CF60", VA = "0x18712E960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private OFONBGHOJGA IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x712E270", Offset = "0x712C870", VA = "0x18712E270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool OOPCMFCPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x712E200", Offset = "0x712C800", VA = "0x18712E200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event EHABGBMCGIM MOMJPHEDCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x712E610", Offset = "0x712CC10", VA = "0x18712E610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x712E570", Offset = "0x712CB70", VA = "0x18712E570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x712E9C0", Offset = "0x712CFC0", VA = "0x18712E9C0")]
	public OLABMFJJGNN(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x712E2D0", Offset = "0x712C8D0", VA = "0x18712E2D0", Slot = "6")]
	public void FGDKKKLNPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x712E260", Offset = "0x712C860", VA = "0x18712E260", Slot = "8")]
	public void DEFHAGLBJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x712E0E0", Offset = "0x712C6E0", VA = "0x18712E0E0", Slot = "7")]
	public bool CDHJLIEIJJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x712E350", Offset = "0x712C950", VA = "0x18712E350", Slot = "9")]
	public void GHJILLNAPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x712E3C0", Offset = "0x712C9C0", VA = "0x18712E3C0", Slot = "11")]
	public void GKCCAMEHBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x712E980", Offset = "0x712CF80", VA = "0x18712E980", Slot = "12")]
	public void OCOIBLJJPNH(bool JBNIAAIKEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x712E6B0", Offset = "0x712CCB0", VA = "0x18712E6B0", Slot = "10")]
	public void MLMCNPNCLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x712DFC0", Offset = "0x712C5C0", VA = "0x18712DFC0")]
	private bool ADJCEAOGKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x712E420", Offset = "0x712CA20", VA = "0x18712E420")]
	private void IJIFINGABBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class DJMEHGKANKF : JFEACPHKHLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly OFONBGHOJGA CIJHLIHFIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float FHNDOPNGBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float PBMOANADGLE;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float CDODBKDHIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A4790", Offset = "0x9A2D90", VA = "0x1809A4790", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8220", Offset = "0x5AF6820", VA = "0x185AF8220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float OBJCBEKNNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A4780", Offset = "0x9A2D80", VA = "0x1809A4780", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5AF82F0", Offset = "0x5AF68F0", VA = "0x185AF82F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5AF84B0", Offset = "0x5AF6AB0", VA = "0x185AF84B0")]
	public DJMEHGKANKF(OFONBGHOJGA CIJHLIHFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AF83C0", Offset = "0x5AF69C0", VA = "0x185AF83C0", Slot = "8")]
	public void NHDOOOFAHKJ(Rigidbody JNOABPPDPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5AF8410", Offset = "0x5AF6A10", VA = "0x185AF8410", Slot = "9")]
	public void PAEFCEBGKHG(Rigidbody JNOABPPDPPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface FAKMAGEOGIN : HOKCEFENPDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView DDMPLJHAEHI
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
	internal class _RRAssemblyIndex : GCCNFJGECLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7135DB0", Offset = "0x71343B0", VA = "0x187135DB0", Slot = "6")]
		public sealed override void GNMHHDMHPFL(FFIKMFDECCE OIBMDOLHJFJ)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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
