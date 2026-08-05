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
	public class LogRegistrationIndex : DEDNPPDJFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x691E900", Offset = "0x691D300", VA = "0x18691E900", Slot = "4")]
		public override void JIGIEBIDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
	public class _AssemblyIndex : JFIBNGDIICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LMAJIBLOEFA bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1393310", Offset = "0x1391D10", VA = "0x181393310", Slot = "5")]
		public override void HPCPHMIICDG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6928A50", Offset = "0x6927450", VA = "0x186928A50")]
		private void BDLNLNECOOJ(DBBHKBEGOEB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6928D50", Offset = "0x6927750", VA = "0x186928D50", Slot = "6")]
		public override void ILFDKCPJAHD(DBBHKBEGOEB registry, [In] GADFEOAAHAK filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
		public override void OOPDCFDDFOD(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6928DB0", Offset = "0x69277B0", VA = "0x186928DB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, IHGKDIOHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LBNENDFDEJK ENFBBEIDDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool OJOGNAJNHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BGKFOFFDBCF NDOHCFNDAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[FHOJJMNIIDJ(PHOLEAOCMFP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[FHOJJMNIIDJ(PHOLEAOCMFP.SelfAndParent, true, false, false)]
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
		private JFKHEFJKEKA physicsInterpolation;

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
		internal BGKFOFFDBCF GMKKFAACACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6924290", Offset = "0x6922C90", VA = "0x186924290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BGKFOFFDBCF DOHEFPFPCBG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OGNMMBAHNCH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6925EC0", Offset = "0x69248C0", VA = "0x186925EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HIBCINNNKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6926220", Offset = "0x6924C20", VA = "0x186926220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx PCJLIOJLCMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6926160", Offset = "0x6924B60", VA = "0x186926160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HHJLJBMAMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6926EC0", Offset = "0x69258C0", VA = "0x186926EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69283C0", Offset = "0x6926DC0", VA = "0x1869283C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ONMGPACABAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7EB780", Offset = "0x7EA180", VA = "0x1807EB780", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FCLFGALHMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7EB780", Offset = "0x7EA180", VA = "0x1807EB780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OKAPGIDMLME GLFJHOPEKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6925F20", Offset = "0x6924920", VA = "0x186925F20")]
			get
			{
				return default(OKAPGIDMLME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6927B70", Offset = "0x6926570", VA = "0x186927B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IJNDOBJJHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6926530", Offset = "0x6924F30", VA = "0x186926530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EACCFBALNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6926040", Offset = "0x6924A40", VA = "0x186926040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KEGIGDFABJI NPEIHINPKOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6926470", Offset = "0x6924E70", VA = "0x186926470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6927D30", Offset = "0x6926730", VA = "0x186927D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GJIGFONCOIL ELNOHMHCOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6926410", Offset = "0x6924E10", VA = "0x186926410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6927CC0", Offset = "0x69266C0", VA = "0x186927CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LAPOJFBCBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6926360", Offset = "0x6924D60", VA = "0x186926360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody POOBCMLELBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69263C0", Offset = "0x6924DC0", VA = "0x1869263C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FDBNPEOBIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69260A0", Offset = "0x6924AA0", VA = "0x1869260A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6927BE0", Offset = "0x69265E0", VA = "0x186927BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DKANKFKPAML
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6074140", Offset = "0x6072B40", VA = "0x186074140", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float FMGPKOIDGIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6926E60", Offset = "0x6925860", VA = "0x186926E60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float FNKPGOFMDOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6926E00", Offset = "0x6925800", VA = "0x186926E00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6928350", Offset = "0x6926D50", VA = "0x186928350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KILJGMPMJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6926790", Offset = "0x6925190", VA = "0x186926790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6927FD0", Offset = "0x69269D0", VA = "0x186927FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float PCJDNEMEBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6926590", Offset = "0x6924F90", VA = "0x186926590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6927DA0", Offset = "0x69267A0", VA = "0x186927DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OOJHLGAABAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6927410", Offset = "0x6925E10", VA = "0x186927410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6928900", Offset = "0x6927300", VA = "0x186928900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 NNOBMNCDGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6926BE0", Offset = "0x69255E0", VA = "0x186926BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6928120", Offset = "0x6926B20", VA = "0x186928120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 CFEGECBODCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6927550", Offset = "0x6925F50", VA = "0x186927550")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode KDHLLMGMLCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69266D0", Offset = "0x69250D0", VA = "0x1869266D0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6927EF0", Offset = "0x69268F0", VA = "0x186927EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float BGIOEPDEEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6926100", Offset = "0x6924B00", VA = "0x186926100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6927C50", Offset = "0x6926650", VA = "0x186927C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints AMMCNKHJGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6926730", Offset = "0x6925130", VA = "0x186926730")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6927F60", Offset = "0x6926960", VA = "0x186927F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 KGCBGFBPCPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6926F80", Offset = "0x6925980", VA = "0x186926F80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 EGEAMIHOGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6926F80", Offset = "0x6925980", VA = "0x186926F80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x69286E0", Offset = "0x69270E0", VA = "0x1869286E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AFDEFBJNOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6926CC0", Offset = "0x69256C0", VA = "0x186926CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6928200", Offset = "0x6926C00", VA = "0x186928200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AGBPONFCCHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x69273B0", Offset = "0x6925DB0", VA = "0x1869273B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6928890", Offset = "0x6927290", VA = "0x186928890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion CMFIBHMHEDO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6927060", Offset = "0x6925A60", VA = "0x186927060")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6928460", Offset = "0x6926E60", VA = "0x186928460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KGABFOJCJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x69272E0", Offset = "0x6925CE0", VA = "0x1869272E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69287C0", Offset = "0x69271C0", VA = "0x1869287C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 NLFBDOBIJHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6927130", Offset = "0x6925B30", VA = "0x186927130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6928530", Offset = "0x6926F30", VA = "0x186928530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JCAJEONAOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6927210", Offset = "0x6925C10", VA = "0x186927210")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6928610", Offset = "0x6927010", VA = "0x186928610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HLHANNCAGLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6927470", Offset = "0x6925E70", VA = "0x186927470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6928970", Offset = "0x6927370", VA = "0x186928970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BIIBBMJOAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6926D20", Offset = "0x6925720", VA = "0x186926D20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6928270", Offset = "0x6926C70", VA = "0x186928270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CEBHPCKMGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x69265F0", Offset = "0x6924FF0", VA = "0x1869265F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6927E10", Offset = "0x6926810", VA = "0x186927E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MCDLIMPJKBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6926B00", Offset = "0x6925500", VA = "0x186926B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6928040", Offset = "0x6926A40", VA = "0x186928040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HFJLFDEDEMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x69269C0", Offset = "0x69253C0", VA = "0x1869269C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion GIHHPHDACDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x69268F0", Offset = "0x69252F0", VA = "0x1869268F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NEIKPHLEANI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6927710", Offset = "0x6926110", VA = "0x186927710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 JMBNLBHNAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6927630", Offset = "0x6926030", VA = "0x186927630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool IMGHLLPFGEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6926AA0", Offset = "0x69254A0", VA = "0x186926AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OIACFEKBPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x69264D0", Offset = "0x6924ED0", VA = "0x1869264D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DECAMAJIKLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6925FE0", Offset = "0x69249E0", VA = "0x186925FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CEDGNNHPDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6925F80", Offset = "0x6924980", VA = "0x186925F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MPCJEDIBACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6925E60", Offset = "0x6924860", VA = "0x186925E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OECJBDDOMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x69267F0", Offset = "0x69251F0", VA = "0x1869267F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CIENOIJGBFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x53EE720", Offset = "0x53ED120", VA = "0x1853EE720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OLMONNFPBFD AINKPPOBDAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6925D80", Offset = "0x6924780", VA = "0x186925D80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6927A90", Offset = "0x6926490", VA = "0x186927A90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CLJCKLONOHI BJIOIJFOJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6925AF0", Offset = "0x69244F0", VA = "0x186925AF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x69277F0", Offset = "0x69261F0", VA = "0x1869277F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CLJCKLONOHI DPJFOMNMFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6925B50", Offset = "0x6924550", VA = "0x186925B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6927860", Offset = "0x6926260", VA = "0x186927860")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CLJCKLONOHI KHOLKLLCLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6925CA0", Offset = "0x69246A0", VA = "0x186925CA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x69279B0", Offset = "0x69263B0", VA = "0x1869279B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NGCLDJOGPMC, NGCLDJOGPMC> BJNHNPOFEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6925C30", Offset = "0x6924630", VA = "0x186925C30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6927940", Offset = "0x6926340", VA = "0x186927940")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event CLJCKLONOHI JJCFFMACGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6925D10", Offset = "0x6924710", VA = "0x186925D10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6927A20", Offset = "0x6926420", VA = "0x186927A20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CLJCKLONOHI AENGPGJMNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6925DF0", Offset = "0x69247F0", VA = "0x186925DF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6927B00", Offset = "0x6926500", VA = "0x186927B00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CLJCKLONOHI LAIOPJDIFOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6925BC0", Offset = "0x69245C0", VA = "0x186925BC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69278D0", Offset = "0x69262D0", VA = "0x1869278D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0", Slot = "8")]
		private void JAEPEONGENB(BGKFOFFDBCF KGDPHHJJNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69247D0", Offset = "0x69231D0", VA = "0x1869247D0")]
		internal void IHPOLDJOEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6925810", Offset = "0x6924210", VA = "0x186925810")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody ACOEBGHOHJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6924520", Offset = "0x6922F20", VA = "0x186924520")]
		public IHGKDIOHOHL GetChild(int ABBNIPHGMGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6925480", Offset = "0x6923E80", VA = "0x186925480")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IIOBFIHKMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6924000", Offset = "0x6922A00", VA = "0x186924000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6924290", Offset = "0x6922C90", VA = "0x186924290")]
		private BGKFOFFDBCF DIJJBDIOJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6924070", Offset = "0x6922A70", VA = "0x186924070")]
		private void BMGPKAMLICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6924C50", Offset = "0x6923650", VA = "0x186924C50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69247D0", Offset = "0x69231D0", VA = "0x1869247D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6924BF0", Offset = "0x69235F0", VA = "0x186924BF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6924CB0", Offset = "0x69236B0", VA = "0x186924CB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69235F0", Offset = "0x6921FF0", VA = "0x1869235F0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6924D10", Offset = "0x6923710", VA = "0x186924D10")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69244C0", Offset = "0x6922EC0", VA = "0x1869244C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6924B90", Offset = "0x6923590", VA = "0x186924B90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69255E0", Offset = "0x6923FE0", VA = "0x1869255E0")]
		public void SetParent(RigidbodyEx AEJBOLFACJC, bool NCHCLNHGGLP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6925020", Offset = "0x6923A20", VA = "0x186925020")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6924860", Offset = "0x6923260", VA = "0x186924860")]
		public bool IsRigidbodyAncestor(RigidbodyEx PFLBLCBDIMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6924940", Offset = "0x6923340", VA = "0x186924940")]
		public bool IsRigidbodyDescendant(RigidbodyEx LPLHIKCIGHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6923860", Offset = "0x6922260", VA = "0x186923860")]
		public void AddInterpolationRestriction(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6924D80", Offset = "0x6923780", VA = "0x186924D80")]
		public void RemoveInterpolationRestriction(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69238D0", Offset = "0x69222D0", VA = "0x1869238D0")]
		public void AddKinematic(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6924DF0", Offset = "0x69237F0", VA = "0x186924DF0")]
		public void RemoveKinematic(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6925560", Offset = "0x6923F60", VA = "0x186925560")]
		public void SetKinematic(object AIDIDMJCFEK, bool PFAHELLLIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6925380", Offset = "0x6923D80", VA = "0x186925380")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JDBMNCDPHAH, Quaternion LIPKGNFGFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6925280", Offset = "0x6923C80", VA = "0x186925280")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MOPEEKHJBPM, Quaternion GMLNFMGAOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69246C0", Offset = "0x69230C0", VA = "0x1869246C0")]
		public Vector3 GetConstrainedVelocity(Vector3 HLHANNCAGLP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69245B0", Offset = "0x6922FB0", VA = "0x1869245B0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 CEBHPCKMGCF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6923770", Offset = "0x6922170", VA = "0x186923770")]
		public void AddForce(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6923660", Offset = "0x6922060", VA = "0x186923660")]
		public void AddForceAtPosition(Vector3 AHPBABJEPBH, Vector3 DGOJEOCFHHN, ForceMode CJPJJJBPAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6923AA0", Offset = "0x69224A0", VA = "0x186923AA0")]
		public void AddTorque(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6923940", Offset = "0x6922340", VA = "0x186923940")]
		public void AddRelativeTorque(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69258E0", Offset = "0x69242E0", VA = "0x1869258E0")]
		public Vector3 WorldToLocalVelocity(Vector3 EJPNFJPEMJC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6924A80", Offset = "0x6923480", VA = "0x186924A80")]
		public Vector3 LocalToWorldVelocity(Vector3 BIIBBMJOAGE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6924460", Offset = "0x6922E60", VA = "0x186924460")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6924400", Offset = "0x6922E00", VA = "0x186924400")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69243A0", Offset = "0x6922DA0", VA = "0x1869243A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6924340", Offset = "0x6922D40", VA = "0x186924340")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6925180", Offset = "0x6923B80", VA = "0x186925180")]
		public void ResetVelocityWorldSpace(Vector3 PCFNCEMBLII, Vector3 JDJIFNJBEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6925080", Offset = "0x6923A80", VA = "0x186925080")]
		public void ResetVelocityLocalSpace(Vector3 LCOIJGMOGBI, Vector3 MCDLIMPJKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6924F40", Offset = "0x6923940", VA = "0x186924F40")]
		public void ResetLinearVelocityLocalSpace(Vector3 LCOIJGMOGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6925710", Offset = "0x6924110", VA = "0x186925710")]
		public bool SweepTest(Vector3 COKBJHHCBCI, [Out] RaycastHit AGDEAHCJKJG, float EHAOBONCKIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6924A20", Offset = "0x6923420", VA = "0x186924A20")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69256B0", Offset = "0x69240B0", VA = "0x1869256B0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6925880", Offset = "0x6924280", VA = "0x186925880")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6923A30", Offset = "0x6922430", VA = "0x186923A30")]
		public void AddShouldHaveUnityRigidbodyToken(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6924E60", Offset = "0x6923860", VA = "0x186924E60")]
		public void RemoveShouldHaveUnityRigidbodyToken(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6923E30", Offset = "0x6922830", VA = "0x186923E30")]
		public void ApplyForceVelocityChange(HFJBCEABLKK PKAFBMHMFIK, Vector3 OAEBAFNOOID, float JFGFKKKJALP, float BGKBBCAODHG = 8f, float LNEPLNANENF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6923D30", Offset = "0x6922730", VA = "0x186923D30")]
		public void ApplyAngularVelocityChange(JICPGDJPMBL IAKHFJKEGIK, Vector3 EDDODGHDOCK, float NOGBLOAKKEM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6923EF0", Offset = "0x69228F0", VA = "0x186923EF0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JICPGDJPMBL IAKHFJKEGIK, Vector3 DMBBOEJIOJM, float OGMNDMHPDON = 7f, float AENPFKNAHJG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6923C60", Offset = "0x6922660", VA = "0x186923C60")]
		public bool AllowedScaleChange(float BFAOHJDJGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6923B90", Offset = "0x6922590", VA = "0x186923B90")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx EEDACFGPMMI, object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6924ED0", Offset = "0x69238D0", VA = "0x186924ED0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AIDIDMJCFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6925A80", Offset = "0x6924480", VA = "0x186925A80")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x882150", Offset = "0x880B50", VA = "0x180882150", Slot = "4")]
		private GameObject DDPMLIHLENI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB780", Offset = "0x7EA180", VA = "0x1807EB780", Slot = "5")]
		private Transform GJMLIGMFLEK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KACINIOJICE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x691E890", Offset = "0x691D290", VA = "0x18691E890")]
	public static BGKFOFFDBCF GMKKFAACACB(this RigidbodyEx FBPPOBEEAPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MBBAAMILDKG(typeof(MFDOLHEPGFE), new string[] { })]
public class HOJMDFMPGDO : MFDOLHEPGFE, IODBKHDEGIK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PNALMCICKOO NHCOKFHAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JBLHBGLODCJ NJALJHMFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AELENFJJBGG FGOILLLEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JBLHBGLODCJ KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AELENFJJBGG NGHBOBANFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x691AF00", Offset = "0x6919900", VA = "0x18691AF00", Slot = "7")]
	public void InitReferences(GHIFKENEMPN GIMKPCGFLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x691AF90", Offset = "0x6919990", VA = "0x18691AF90", Slot = "6")]
	public BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public HOJMDFMPGDO()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static KMHDPFOFGLH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int PKCKIDJINEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AOFMOMJELLJ;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6923450", Offset = "0x6921E50", VA = "0x186923450")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6923490", Offset = "0x6921E90", VA = "0x186923490")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6923470", Offset = "0x6921E70", VA = "0x186923470")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CPPFNMDMGHI, [Optional] UnityEngine.Object JGGBEOJAHKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CPPFNMDMGHI, [Optional] UnityEngine.Object JGGBEOJAHKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69235A0", Offset = "0x6921FA0", VA = "0x1869235A0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MMPGBCLLHOC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MFIJMAFBPDI : KEGIGDFABJI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D60", Offset = "0x7D1760", VA = "0x1807D2D60", Slot = "4")]
		public Vector3 BKEIKKAHGFA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D2D60", Offset = "0x7D1760", VA = "0x1807D2D60", Slot = "5")]
		public Vector3 HBBAIEDHJIB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public MFIJMAFBPDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static KEGIGDFABJI EBJDJFGAEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x691EA70", Offset = "0x691D470", VA = "0x18691EA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LJMBHIAJMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode LKBHNAHMPCP
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
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHENAOCEEPF(bool IMGHLLPFGEO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCEGFKLDIBP(bool IMGHLLPFGEO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CHGGLCJMIHC(Vector3 COKBJHHCBCI, [Out] RaycastHit AGDEAHCJKJG, float EHAOBONCKIL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HFBJIBGOGDM : IDisposable, ICMCGDFALFC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OKAPGIDMLME GLFJHOPEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<NGCLDJOGPMC, NGCLDJOGPMC> BJNHNPOFEEO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADOMGPBBEKI();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface AELENFJJBGG
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AFMBNCEHFJO NNOPMLBCCDF(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BJBFAHKCPDK EPPOIGPLOJJ(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMBJJNAGKKN MOOJMONOIIE(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KECIFNCILIP HLHJCFDFKBH(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ABJMLPOLMOM EAFKCMEIADN(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HFBJIBGOGDM MDBPCBMOHEI(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LNDPLGJGNOF FGGDJGMGFKP(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DJALPJBENNN HDGCANGAFOC(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LJMBHIAJMHG IHMENACEKKJ(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FDBFLDCBHNC CBIJFLGGOKK(BGKFOFFDBCF KGDPHHJJNLN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ONBIFHENLDB HPOIFAHAHHN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FEOEOALIHIE OOPENAGDIMK(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FHFKJNHIBIA LPHNAANBLDA(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	APCPPIKGEHG ACFGAPBMPKO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IBKODPIFJNF OLMEELEAIFP(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC, MFDOLHEPGFE KEKOHNJFKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DJALPJBENNN
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOLAFBPFEMC(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCIPFGJCDLF(Vector3 AHPBABJEPBH, Vector3 DGOJEOCFHHN, ForceMode CJPJJJBPAPC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJDDIPGEGOA(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOCDCMBKMJE(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FDBFLDCBHNC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KHOANBPNIKG
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
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void POGBNCADIAC(Rigidbody MAGECLDKLMK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AFMBNCEHFJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<BGKFOFFDBCF> JGPLFFJIMED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BGKFOFFDBCF PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CLJCKLONOHI BJIOIJFOJBP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CLJCKLONOHI DPJFOMNMFGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OLMONNFPBFD JCBDPCJNBOI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action FODDOPNFCAA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EEBDHHPMENL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BGKFOFFDBCF> DGPGDNHFKFG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BGKFOFFDBCF> IJBDDPCPGGP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action NFKAKLFPMGJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BGKFOFFDBCF> BLBDPACOIHI;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HADFEPOJAPP(BGKFOFFDBCF GCDDFMLCKMH, bool NCHCLNHGGLP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EMBJJNAGKKN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 IAKGHCODGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 HCALOFOLJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMKAJDJJGFJ(BGKFOFFDBCF HHJLJBMAMDD, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKHPMKHHBLA(object AIDIDMJCFEK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface APCPPIKGEHG
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 PGBEPMPOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FGOOHHJNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float HNFBPHKMJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float LADAJJHHKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 GEDNJPOJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion HHEPOOJKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event CLJCKLONOHI CPPLGLMKDLF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LBIDHDCCHFN((Quaternion rot, Vector3 moments) IIOBFIHKMKA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CPBFJJKCNDF();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MEIKPFPCEND();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DNFMDMLCDBL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void POGBNCADIAC(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EIDDFCDABLD();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FHFKJNHIBIA
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAKOFOICCKI(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFDPPJMJNJL(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIBGPLCPEKH(BGKFOFFDBCF FBPPOBEEAPL);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPPPLEHHDHK(BGKFOFFDBCF FBPPOBEEAPL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKIDJLNNAGF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LNDPLGJGNOF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool BNGHHFBGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CLJCKLONOHI BKCAALMFKGG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFGJFDJEKON(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFMMBGEIBIN(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMPJPEGBADP(object AIDIDMJCFEK, bool PFAHELLLIJF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOONAHLFFPI(Rigidbody LNCKMBKIAHH);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void POGBNCADIAC(Rigidbody MAGECLDKLMK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FEOEOALIHIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool IJNDOBJJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool EACCFBALNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CLJCKLONOHI KDCFGOKPIMG;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ONFNPMCGPDC(BGKFOFFDBCF HHJLJBMAMDD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNONIFOJPBJ(BGKFOFFDBCF HHJLJBMAMDD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IBKODPIFJNF
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FDBNPEOBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CNIPCEOCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints EBCHHJPEJPO
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
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void POGBNCADIAC(Rigidbody MAGECLDKLMK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KECIFNCILIP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float APDNNPKAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float JGAGIKGBKMK
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
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POGBNCADIAC(Rigidbody MAGECLDKLMK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ABJMLPOLMOM
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CLJCKLONOHI KLFKOBHMENA;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IODNPBHJDNI();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEPNJBJKLMH();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKGGGOAKKFI();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDFHMPIDDJL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INLIEIBMNOL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ONBIFHENLDB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool NBEIBFKKIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIKEAHAJACC(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEJIHGANKGN(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPFKFPBCHGH();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCIELFDFAOF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BJBFAHKCPDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	KEGIGDFABJI NPEIHINPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GJIGFONCOIL ELNOHMHCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 FDLLPICOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 OIHIHNLLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 CBOMGOGEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 ANAGKNDCEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float BGIOEPDEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LAPOJFBCBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADOMGPBBEKI();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKPPCMGIFNG(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BKIJAODPLKO(JICPGDJPMBL IAKHFJKEGIK, Vector3 EDDODGHDOCK, float NOGBLOAKKEM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BFJMDJJMNGM(HFJBCEABLKK PKAFBMHMFIK, Vector3 OAEBAFNOOID, float JFGFKKKJALP, float BGKBBCAODHG = 8f, float LNEPLNANENF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OCKBMELOJNJ(JICPGDJPMBL IAKHFJKEGIK, Vector3 DMBBOEJIOJM, float OGMNDMHPDON = 7f, float AENPFKNAHJG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FLPNFDKEPED();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FNFLFILCDCB();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PNMKOJELMAB();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AINBAPPNEND();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FOONAHLFFPI(Rigidbody MAGECLDKLMK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JHCACNAMEEL(Vector3 HLHANNCAGLP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void INLELIFCBDB(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MEJCMJJNGAP(Vector3 OJFLAKENKHK);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DJCKPOFCHOG(Vector3 LCOIJGMOGBI, Vector3 MCDLIMPJKBK);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FKFBIOKHALP(Vector3 PCFNCEMBLII, Vector3 JDJIFNJBEPK);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GLHINNLNEJM(Vector3 BIIBBMJOAGE);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 ABAJAMKFLOC(Vector3 EJPNFJPEMJC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface JBLHBGLODCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NNMJANJKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGCAEKMEBNH(string MBGOEMJAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFIADDFOKIH(RigidbodyEx FBPPOBEEAPL, Action HKIJJKKNOIF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PAENFKLKNDA GNBMKNICNBO(int MNKKNCLGDBL);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFCKDKEJMGM(Vector3 CFEGECBODCM, float GJNBEGPLMHO, Color GLALCIBBONF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
public interface MFDOLHEPGFE
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	JBLHBGLODCJ KHOMGDACNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	AELENFJJBGG NGHBOBANFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FMLBEMMBMDK : BGKFOFFDBCF, IDisposable, FEDLEFMHMOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly MFDOLHEPGFE KEKOHNJFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal AFMBNCEHFJO BMICOFMPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal FHFKJNHIBIA IPLPCGKJKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal FEOEOALIHIE NOEOCCOIGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BJBFAHKCPDK HLHANNCAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal EMBJJNAGKKN EEIHKPCCHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal APCPPIKGEHG COFBMBCDAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal KECIFNCILIP KOHMNEOLONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FDBFLDCBHNC NNNJKAMIPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal ABJMLPOLMOM LFOCNMJBLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal HFBJIBGOGDM JLEOHJMHBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal LNDPLGJGNOF EACHGDGODGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal DJALPJBENNN AHPBABJEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal IBKODPIFJNF GOLFAKFFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal ONBIFHENLDB MAGECLDKLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LJMBHIAJMHG LHOGDKEKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable LBLNJHMAKLJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public MMBMADJJEAB BGGLMNANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "22")]
		get
		{
			return default(MMBMADJJEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public IHGKDIOHOHL HDABIAIFIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8B0", Offset = "0x7CE2B0", VA = "0x1807CF8B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9A0", Offset = "0x7CE3A0", VA = "0x1807CF9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE850", Offset = "0x8AD250", VA = "0x1808AE850", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x88B860", Offset = "0x88A260", VA = "0x18088B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6916AF0", Offset = "0x69154F0", VA = "0x186916AF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6915B00", Offset = "0x6914500", VA = "0x186915B00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6914FB0", Offset = "0x69139B0", VA = "0x186914FB0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6916E00", Offset = "0x6915800", VA = "0x186916E00", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OGNMMBAHNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6915C90", Offset = "0x6914690", VA = "0x186915C90", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BGKFOFFDBCF PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6917D00", Offset = "0x6916700", VA = "0x186917D00", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool JBNBNCHDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6915000", Offset = "0x6913A00", VA = "0x186915000", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool IJNDOBJJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6916400", Offset = "0x6914E00", VA = "0x186916400", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EACCFBALNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x69185E0", Offset = "0x6916FE0", VA = "0x1869185E0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KEGIGDFABJI NPEIHINPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6918EB0", Offset = "0x69178B0", VA = "0x186918EB0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x691A420", Offset = "0x6918E20", VA = "0x18691A420", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GJIGFONCOIL ELNOHMHCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6919690", Offset = "0x6918090", VA = "0x186919690", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6915720", Offset = "0x6914120", VA = "0x186915720", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float BGIOEPDEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69172E0", Offset = "0x6915CE0", VA = "0x1869172E0", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x691A5B0", Offset = "0x6918FB0", VA = "0x18691A5B0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 OIHIHNLLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x69166D0", Offset = "0x69150D0", VA = "0x1869166D0", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6915D50", Offset = "0x6914750", VA = "0x186915D50", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 ANAGKNDCEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x69157E0", Offset = "0x69141E0", VA = "0x1869157E0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6919350", Offset = "0x6917D50", VA = "0x186919350", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 FDLLPICOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6915EE0", Offset = "0x69148E0", VA = "0x186915EE0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6919480", Offset = "0x6917E80", VA = "0x186919480", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 CBOMGOGEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6917680", Offset = "0x6916080", VA = "0x186917680", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6919A80", Offset = "0x6918480", VA = "0x186919A80", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DECAMAJIKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6915430", Offset = "0x6913E30", VA = "0x186915430", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool CEDGNNHPDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6919FF0", Offset = "0x69189F0", VA = "0x186919FF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MPCJEDIBACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x69199A0", Offset = "0x69183A0", VA = "0x1869199A0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LAPOJFBCBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6916350", Offset = "0x6914D50", VA = "0x186916350", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 IAKGHCODGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x69195C0", Offset = "0x6917FC0", VA = "0x1869195C0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 HCALOFOLJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x69189A0", Offset = "0x69173A0", VA = "0x1869189A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 PGBEPMPOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6915540", Offset = "0x6913F40", VA = "0x186915540", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6918DD0", Offset = "0x69177D0", VA = "0x186918DD0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FGOOHHJNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6919860", Offset = "0x6918260", VA = "0x186919860", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float HNFBPHKMJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x691A050", Offset = "0x6918A50", VA = "0x18691A050", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float LADAJJHHKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6919430", Offset = "0x6917E30", VA = "0x186919430", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6917AD0", Offset = "0x69164D0", VA = "0x186917AD0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 GEDNJPOJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6916E60", Offset = "0x6915860", VA = "0x186916E60", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion HHEPOOJKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x69188D0", Offset = "0x69172D0", VA = "0x1869188D0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float APDNNPKAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6918FB0", Offset = "0x69179B0", VA = "0x186918FB0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x691A1B0", Offset = "0x6918BB0", VA = "0x18691A1B0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float JGAGIKGBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x691A480", Offset = "0x6918E80", VA = "0x18691A480", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6916800", Offset = "0x6915200", VA = "0x186916800", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool KHOANBPNIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x69196E0", Offset = "0x69180E0", VA = "0x1869196E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x69160B0", Offset = "0x6914AB0", VA = "0x1869160B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OKAPGIDMLME GLFJHOPEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6917BE0", Offset = "0x69165E0", VA = "0x186917BE0", Slot = "68")]
		get
		{
			return default(OKAPGIDMLME);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6914F50", Offset = "0x6913950", VA = "0x186914F50", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool BNGHHFBGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6918D80", Offset = "0x6917780", VA = "0x186918D80", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform FCLFGALHMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x691A5A0", Offset = "0x6918FA0", VA = "0x18691A5A0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 AIBDOKJKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6917560", Offset = "0x6915F60", VA = "0x186917560", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x691A2B0", Offset = "0x6918CB0", VA = "0x18691A2B0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float KCMMJBAEDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6917C30", Offset = "0x6916630", VA = "0x186917C30", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6917D90", Offset = "0x6916790", VA = "0x186917D90", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float LKJBPNCMFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x69190E0", Offset = "0x6917AE0", VA = "0x1869190E0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6916F40", Offset = "0x6915940", VA = "0x186916F40", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion NLDEDKHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6918F00", Offset = "0x6917900", VA = "0x186918F00", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6919B60", Offset = "0x6918560", VA = "0x186919B60", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 BMNHEIGADNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6915E30", Offset = "0x6914830", VA = "0x186915E30", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6917B30", Offset = "0x6916530", VA = "0x186917B30", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JGNDFHLFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x691A210", Offset = "0x6918C10", VA = "0x18691A210", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6917D50", Offset = "0x6916750", VA = "0x186917D50", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints EBCHHJPEJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6919EE0", Offset = "0x69188E0", VA = "0x186919EE0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6918720", Offset = "0x6917120", VA = "0x186918720", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool FDBNPEOBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x69164A0", Offset = "0x6914EA0", VA = "0x1869164A0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6915780", Offset = "0x6914180", VA = "0x186915780", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode LKBHNAHMPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x69167B0", Offset = "0x69151B0", VA = "0x1869167B0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6919F30", Offset = "0x6918930", VA = "0x186919F30", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool EIJLNOMCIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6915B50", Offset = "0x6914550", VA = "0x186915B50", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool OIACFEKBPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x691A8D0", Offset = "0x69192D0", VA = "0x18691A8D0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CLJCKLONOHI BJIOIJFOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x691A250", Offset = "0x6918C50", VA = "0x18691A250", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x691A610", Offset = "0x6919010", VA = "0x18691A610", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CLJCKLONOHI DPJFOMNMFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6916CE0", Offset = "0x69156E0", VA = "0x186916CE0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x691AA50", Offset = "0x6919450", VA = "0x18691AA50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OLMONNFPBFD JCBDPCJNBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x69183A0", Offset = "0x6916DA0", VA = "0x1869183A0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6919560", Offset = "0x6917F60", VA = "0x186919560", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CLJCKLONOHI KDCFGOKPIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6919940", Offset = "0x6918340", VA = "0x186919940", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6917220", Offset = "0x6915C20", VA = "0x186917220", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CLJCKLONOHI KHOLKLLCLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6916290", Offset = "0x6914C90", VA = "0x186916290", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6916110", Offset = "0x6914B10", VA = "0x186916110", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CLJCKLONOHI KLFKOBHMENA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x69162F0", Offset = "0x6914CF0", VA = "0x1869162F0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x69153D0", Offset = "0x6913DD0", VA = "0x1869153D0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<NGCLDJOGPMC, NGCLDJOGPMC> BJNHNPOFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6917280", Offset = "0x6915C80", VA = "0x186917280", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x69163A0", Offset = "0x6914DA0", VA = "0x1869163A0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CLJCKLONOHI BKCAALMFKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6917500", Offset = "0x6915F00", VA = "0x186917500", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6915E80", Offset = "0x6914880", VA = "0x186915E80", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CLJCKLONOHI LAIOPJDIFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x69192A0", Offset = "0x6917CA0", VA = "0x1869192A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x69169F0", Offset = "0x69153F0", VA = "0x1869169F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x691AE30", Offset = "0x6919830", VA = "0x18691AE30")]
	public FMLBEMMBMDK(GameObject PACDKKMGCFJ, RigidbodyEx EPBPEJCJMKN, MFDOLHEPGFE KEKOHNJFKFJ, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x691AB00", Offset = "0x6919500", VA = "0x18691AB00", Slot = "136")]
	protected virtual void POLPOBFGGGM(MFDOLHEPGFE KEKOHNJFKFJ, JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69161C0", Offset = "0x6914BC0", VA = "0x1869161C0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6914E10", Offset = "0x6913810", VA = "0x186914E10", Slot = "91")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6915060", Offset = "0x6913A60", VA = "0x186915060", Slot = "92")]
	public void LINONLKPEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6918630", Offset = "0x6917030", VA = "0x186918630", Slot = "93")]
	public void JKIOMGPKAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x691A370", Offset = "0x6918D70", VA = "0x18691A370")]
	private void OJNMNHGDNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6919E60", Offset = "0x6918860", VA = "0x186919E60", Slot = "30")]
	public BGKFOFFDBCF NDAFDJIEKFK(int ABBNIPHGMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x69171B0", Offset = "0x6915BB0", VA = "0x1869171B0", Slot = "95")]
	public void HADFEPOJAPP(BGKFOFFDBCF AEJBOLFACJC, bool NCHCLNHGGLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6916B80", Offset = "0x6915580", VA = "0x186916B80", Slot = "96")]
	public void FOEBIJPHJJJ(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6917E00", Offset = "0x6916800", VA = "0x186917E00", Slot = "97")]
	public void IMPEAMEHLOH(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6914D10", Offset = "0x6913710", VA = "0x186914D10", Slot = "98")]
	public Vector3 ABAJAMKFLOC(Vector3 EJPNFJPEMJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6917040", Offset = "0x6915A40", VA = "0x186917040", Slot = "99")]
	public Vector3 GLHINNLNEJM(Vector3 BIIBBMJOAGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6915060", Offset = "0x6913A60", VA = "0x186915060", Slot = "100")]
	public void AINBAPPNEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6916AA0", Offset = "0x69154A0", VA = "0x186916AA0", Slot = "101")]
	public void FNFLFILCDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x69169A0", Offset = "0x69153A0", VA = "0x1869169A0", Slot = "102")]
	public void FLPNFDKEPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6916860", Offset = "0x6915260", VA = "0x186916860", Slot = "103")]
	public void FKFBIOKHALP(Vector3 PCFNCEMBLII, Vector3 JDJIFNJBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6915FC0", Offset = "0x69149C0", VA = "0x186915FC0", Slot = "104")]
	public void DJCKPOFCHOG(Vector3 LCOIJGMOGBI, Vector3 MCDLIMPJKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6919780", Offset = "0x6918180", VA = "0x186919780", Slot = "105")]
	public void MEJCMJJNGAP(Vector3 OJFLAKENKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6915480", Offset = "0x6913E80", VA = "0x186915480", Slot = "106")]
	public void BFJMDJJMNGM(HFJBCEABLKK PKAFBMHMFIK, Vector3 OAEBAFNOOID, float JFGFKKKJALP, float BGKBBCAODHG = 8f, float LNEPLNANENF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6915620", Offset = "0x6914020", VA = "0x186915620", Slot = "107")]
	public void BKIJAODPLKO(JICPGDJPMBL IAKHFJKEGIK, Vector3 EDDODGHDOCK, float NOGBLOAKKEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x691A0A0", Offset = "0x6918AA0", VA = "0x18691A0A0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OCKBMELOJNJ(JICPGDJPMBL IAKHFJKEGIK, Vector3 DMBBOEJIOJM, float OGMNDMHPDON = 7f, float AENPFKNAHJG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x69184E0", Offset = "0x6916EE0", VA = "0x1869184E0", Slot = "109")]
	public Vector3 JHCACNAMEEL(Vector3 AEJBOLFACJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6916BE0", Offset = "0x69155E0", VA = "0x186916BE0", Slot = "110")]
	public Vector3 GCAKDAIEHMO(Vector3 AEJBOLFACJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x691AAB0", Offset = "0x69194B0", VA = "0x18691AAB0", Slot = "111")]
	public void PNMKOJELMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6917610", Offset = "0x6916010", VA = "0x186917610", Slot = "112")]
	public void HJJBINLBBCI(BGKFOFFDBCF EEDACFGPMMI, object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6919240", Offset = "0x6917C40", VA = "0x186919240", Slot = "113")]
	public void LGFMBCFACKP(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6919100", Offset = "0x6917B00", VA = "0x186919100", Slot = "61")]
	public void LBIDHDCCHFN((Quaternion rot, Vector3 moments) IIOBFIHKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6919730", Offset = "0x6918130", VA = "0x186919730", Slot = "114")]
	public void MEIKPFPCEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6915D00", Offset = "0x6914700", VA = "0x186915D00", Slot = "115")]
	public void CPBFJJKCNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6916170", Offset = "0x6914B70", VA = "0x186916170", Slot = "116")]
	public void DNFMDMLCDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6917EB0", Offset = "0x69168B0", VA = "0x186917EB0", Slot = "117")]
	public bool IODNPBHJDNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6916950", Offset = "0x6915350", VA = "0x186916950", Slot = "94")]
	public void FKGGGOAKKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6917E60", Offset = "0x6916860", VA = "0x186917E60", Slot = "118")]
	public void INLIEIBMNOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x69191E0", Offset = "0x6917BE0", VA = "0x1869191E0", Slot = "119")]
	public void LFGJFDJEKON(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x69159A0", Offset = "0x69143A0", VA = "0x1869159A0", Slot = "120")]
	public void CFMMBGEIBIN(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6917140", Offset = "0x6915B40", VA = "0x186917140", Slot = "121")]
	public void GMPJPEGBADP(object AIDIDMJCFEK, bool PFAHELLLIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x691A6D0", Offset = "0x69190D0", VA = "0x18691A6D0", Slot = "122")]
	public void PGAPIICOCLF(Vector3 JDBMNCDPHAH, Quaternion LIPKGNFGFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6918780", Offset = "0x6917180", VA = "0x186918780", Slot = "123")]
	public void KAAJFAFHMMP(Vector3 MOPEEKHJBPM, Quaternion GMLNFMGAOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6919F90", Offset = "0x6918990", VA = "0x186919F90", Slot = "124")]
	public bool NJKBLPIDFPK(float BFAOHJDJGOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6917B80", Offset = "0x6916580", VA = "0x186917B80", Slot = "125")]
	public void IBEANELNEKL(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x691A670", Offset = "0x6919070", VA = "0x18691A670", Slot = "126")]
	public void PFHJHANKBIH(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69164F0", Offset = "0x6914EF0", VA = "0x1869164F0", Slot = "127")]
	public void EIKEAHAJACC(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6917330", Offset = "0x6915D30", VA = "0x186917330", Slot = "128")]
	public void HEJIHGANKGN(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69182C0", Offset = "0x6916CC0", VA = "0x1869182C0", Slot = "129")]
	public void IOLAFBPFEMC(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6918A80", Offset = "0x6917480", VA = "0x186918A80", Slot = "130")]
	public void KCIPFGJCDLF(Vector3 AHPBABJEPBH, Vector3 DGOJEOCFHHN, ForceMode CJPJJJBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6919000", Offset = "0x6917A00", VA = "0x186919000", Slot = "131")]
	public void KJDDIPGEGOA(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x69158C0", Offset = "0x69142C0", VA = "0x1869158C0", Slot = "132")]
	public void BOCDCMBKMJE(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6915A00", Offset = "0x6914400", VA = "0x186915A00", Slot = "133")]
	public bool CHGGLCJMIHC(Vector3 COKBJHHCBCI, [Out] RaycastHit AGDEAHCJKJG, float EHAOBONCKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6916450", Offset = "0x6914E50", VA = "0x186916450", Slot = "134")]
	public void EIDDFCDABLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x691ADF0", Offset = "0x69197F0", VA = "0x18691ADF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6918400", Offset = "0x6916E00", VA = "0x186918400")]
	private void JBLECNJCCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6919D50", Offset = "0x6918750", VA = "0x186919D50")]
	private void NCHFMKLOOEA(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6918B90", Offset = "0x6917590", VA = "0x186918B90")]
	private void KCNMOFNMOHK(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6917C50", Offset = "0x6916650", VA = "0x186917C50")]
	private void IIKBLEKIKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6919C50", Offset = "0x6918650", VA = "0x186919C50")]
	private void MNNIKIBOFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6916550", Offset = "0x6914F50", VA = "0x186916550")]
	private void EJEGMCKHJJO(BGKFOFFDBCF KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x691A4D0", Offset = "0x6918ED0", VA = "0x18691A4D0")]
	private void ONFNPMCGPDC(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6918650", Offset = "0x6917050", VA = "0x186918650")]
	private void JNONIFOJPBJ(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6917390", Offset = "0x6915D90", VA = "0x186917390")]
	private void HGDEBFCHGBL(IHGKDIOHOHL HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6917F00", Offset = "0x6916900", VA = "0x186917F00", Slot = "141")]
	protected virtual void IOGFEHAFIMO(IHGKDIOHOHL FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69150B0", Offset = "0x6913AB0", VA = "0x1869150B0")]
	protected void AJIHEDLOONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6917760", Offset = "0x6916160", VA = "0x186917760")]
	protected void HMMLPHLHNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6916D40", Offset = "0x6915740", VA = "0x186916D40", Slot = "142")]
	protected virtual IDisposable GDIPBEJLEPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class ACJLCMBAKCJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x690CA70", Offset = "0x690B470", VA = "0x18690CA70")]
	public static BGKFOFFDBCF LNLGICGBLMG(this BGKFOFFDBCF FBPPOBEEAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x690C970", Offset = "0x690B370", VA = "0x18690C970")]
	public static bool LJIBNNBKMJF(this BGKFOFFDBCF FBPPOBEEAPL, BGKFOFFDBCF PFLBLCBDIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x690C8F0", Offset = "0x690B2F0", VA = "0x18690C8F0")]
	public static bool APKDHBADNDG(this BGKFOFFDBCF FBPPOBEEAPL, BGKFOFFDBCF LPLHIKCIGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x690CB30", Offset = "0x690B530", VA = "0x18690CB30")]
	public static IHGKDIOHOHL OJJCINDCDIC(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x690C9F0", Offset = "0x690B3F0", VA = "0x18690C9F0")]
	public static FMLBEMMBMDK LKDBBDLNFBP(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MHDAFINPOEH : AELENFJJBGG
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x691E9D0", Offset = "0x691D3D0", VA = "0x18691E9D0", Slot = "19")]
	public BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC, MFDOLHEPGFE KEKOHNJFKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "4")]
	public AFMBNCEHFJO NNOPMLBCCDF(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "5")]
	public BJBFAHKCPDK EPPOIGPLOJJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "6")]
	public EMBJJNAGKKN MOOJMONOIIE(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "7")]
	public KECIFNCILIP HLHJCFDFKBH(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "8")]
	public ABJMLPOLMOM EAFKCMEIADN(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "9")]
	public HFBJIBGOGDM MDBPCBMOHEI(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "10")]
	public LNDPLGJGNOF FGGDJGMGFKP(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "11")]
	public DJALPJBENNN HDGCANGAFOC(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "12")]
	public LJMBHIAJMHG IHMENACEKKJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "13")]
	public FDBFLDCBHNC CBIJFLGGOKK(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	public ONBIFHENLDB HPOIFAHAHHN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	public FEOEOALIHIE OOPENAGDIMK(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	public FHFKJNHIBIA LPHNAANBLDA(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	public APCPPIKGEHG ACFGAPBMPKO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	public IBKODPIFJNF OLMEELEAIFP(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public MHDAFINPOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "14")]
	private ONBIFHENLDB AIJNEMDLIDO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "15")]
	private FEOEOALIHIE JDFIGOKHAHB(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "16")]
	private FHFKJNHIBIA LFKMGDGGGNI(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "17")]
	private APCPPIKGEHG HJJFFBONKBG(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "18")]
	private IBKODPIFJNF IMAABIAGMGN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[MBBAAMILDKG(typeof(AELENFJJBGG), new string[] { })]
public class NINJFOPBFCE : AELENFJJBGG, IODBKHDEGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AELENFJJBGG DOAHDJEPHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly AELENFJJBGG AJENIECCFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PNALMCICKOO NHCOKFHAEJP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private AELENFJJBGG NGHBOBANFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x691F8A0", Offset = "0x691E2A0", VA = "0x18691F8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x691FE10", Offset = "0x691E810", VA = "0x18691FE10", Slot = "20")]
	public void InitReferences(GHIFKENEMPN GIMKPCGFLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6920250", Offset = "0x691EC50", VA = "0x186920250", Slot = "4")]
	public AFMBNCEHFJO NNOPMLBCCDF(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x691FA40", Offset = "0x691E440", VA = "0x18691FA40", Slot = "5")]
	public BJBFAHKCPDK EPPOIGPLOJJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69201B0", Offset = "0x691EBB0", VA = "0x1869201B0", Slot = "6")]
	public EMBJJNAGKKN MOOJMONOIIE(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x691FC20", Offset = "0x691E620", VA = "0x18691FC20", Slot = "7")]
	public KECIFNCILIP HLHJCFDFKBH(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x691F9A0", Offset = "0x691E3A0", VA = "0x18691F9A0", Slot = "8")]
	public ABJMLPOLMOM EAFKCMEIADN(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6920110", Offset = "0x691EB10", VA = "0x186920110", Slot = "9")]
	public HFBJIBGOGDM MDBPCBMOHEI(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x691FAE0", Offset = "0x691E4E0", VA = "0x18691FAE0", Slot = "10")]
	public LNDPLGJGNOF FGGDJGMGFKP(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x691FB80", Offset = "0x691E580", VA = "0x18691FB80", Slot = "11")]
	public DJALPJBENNN HDGCANGAFOC(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x691FCC0", Offset = "0x691E6C0", VA = "0x18691FCC0", Slot = "12")]
	public LJMBHIAJMHG IHMENACEKKJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x691F900", Offset = "0x691E300", VA = "0x18691F900", Slot = "13")]
	public FDBFLDCBHNC CBIJFLGGOKK(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x691F7F0", Offset = "0x691E1F0", VA = "0x18691F7F0")]
	public ONBIFHENLDB HPOIFAHAHHN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x691FE60", Offset = "0x691E860", VA = "0x18691FE60")]
	public FEOEOALIHIE OOPENAGDIMK(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6920060", Offset = "0x691EA60", VA = "0x186920060")]
	public FHFKJNHIBIA LPHNAANBLDA(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x691F740", Offset = "0x691E140", VA = "0x18691F740")]
	public APCPPIKGEHG ACFGAPBMPKO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x691FD60", Offset = "0x691E760", VA = "0x18691FD60")]
	public IBKODPIFJNF OLMEELEAIFP(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x691FF10", Offset = "0x691E910", VA = "0x18691FF10", Slot = "19")]
	public BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC, MFDOLHEPGFE KEKOHNJFKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x69202F0", Offset = "0x691ECF0", VA = "0x1869202F0")]
	public NINJFOPBFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x691F7F0", Offset = "0x691E1F0", VA = "0x18691F7F0", Slot = "14")]
	private ONBIFHENLDB AIJNEMDLIDO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x691FE60", Offset = "0x691E860", VA = "0x18691FE60", Slot = "15")]
	private FEOEOALIHIE JDFIGOKHAHB(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6920060", Offset = "0x691EA60", VA = "0x186920060", Slot = "16")]
	private FHFKJNHIBIA LFKMGDGGGNI(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x691F740", Offset = "0x691E140", VA = "0x18691F740", Slot = "17")]
	private APCPPIKGEHG HJJFFBONKBG(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x691FD60", Offset = "0x691E760", VA = "0x18691FD60", Slot = "18")]
	private IBKODPIFJNF IMAABIAGMGN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OMIDGDGEHKA : AFMBNCEHFJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMKOOHPFFKM(BGKFOFFDBCF FBPPOBEEAPL);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHMLBDKJDCI(BGKFOFFDBCF FBPPOBEEAPL);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OFIBCNGGADF(BGKFOFFDBCF KGMEKBANJGP);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDCGLHENNKB(BGKFOFFDBCF KGMEKBANJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LIOAECFLGMK : EMBJJNAGKKN
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	NIOLBLBOOKO<BGKFOFFDBCF> BNKKGBAPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	BGKFOFFDBCF APNMLMADMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HGPNIGJHLGJ : APCPPIKGEHG
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DJHNOGBKIAJ(Rigidbody PCJLNNKLADO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KDEFIMDNJHB : FEOEOALIHIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView CFIHGBGDFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BMJKAOPOKGE : LJMBHIAJMHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode PMKOJGGKMCC;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x690CEA0", Offset = "0x690B8A0", VA = "0x18690CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode LKBHNAHMPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x690FF40", Offset = "0x690E940", VA = "0x18690FF40", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x69100D0", Offset = "0x690EAD0", VA = "0x1869100D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x690D940", Offset = "0x690C340", VA = "0x18690D940")]
	public BMJKAOPOKGE(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x690FBA0", Offset = "0x690E5A0", VA = "0x18690FBA0", Slot = "6")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6910050", Offset = "0x690EA50", VA = "0x186910050", Slot = "9")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x690FCB0", Offset = "0x690E6B0", VA = "0x18690FCB0", Slot = "7")]
	public void AHENAOCEEPF(bool IMGHLLPFGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6910140", Offset = "0x690EB40", VA = "0x186910140", Slot = "8")]
	public void PCEGFKLDIBP(bool IMGHLLPFGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x690FCC0", Offset = "0x690E6C0", VA = "0x18690FCC0", Slot = "10")]
	public bool CHGGLCJMIHC(Vector3 COKBJHHCBCI, [Out] RaycastHit AGDEAHCJKJG, float EHAOBONCKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x690FE20", Offset = "0x690E820", VA = "0x18690FE20")]
	private void DCKIPCFJAOO(bool IMGHLLPFGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MNGEDAHELJP : HFBJIBGOGDM, IDisposable, ICMCGDFALFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OKAPGIDMLME AAIHAPDFAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private PAENFKLKNDA NGENBBFNLBH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OKAPGIDMLME GLFJHOPEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x691F060", Offset = "0x691DA60", VA = "0x18691F060", Slot = "6")]
		get
		{
			return default(OKAPGIDMLME);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x691EDC0", Offset = "0x691D7C0", VA = "0x18691EDC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform HJGHMCKICBK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x691EE90", Offset = "0x691D890", VA = "0x18691EE90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<NGCLDJOGPMC, NGCLDJOGPMC> BJNHNPOFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x691EFB0", Offset = "0x691D9B0", VA = "0x18691EFB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x691EF00", Offset = "0x691D900", VA = "0x18691EF00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x691F1B0", Offset = "0x691DBB0", VA = "0x18691F1B0")]
	public MNGEDAHELJP(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB40", Offset = "0x691D540", VA = "0x18691EB40", Slot = "8")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x691EEB0", Offset = "0x691D8B0", VA = "0x18691EEB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x848080", Offset = "0x846A80", VA = "0x180848080", Slot = "11")]
	private void HABNLFPNJLC(NGCLDJOGPMC BPNOEBOCJLD, NGCLDJOGPMC PMNBEIGDOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "12")]
	private void ODGJBKEMODB(bool NPDFIGMPMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BEONHLGAIIH : AELENFJJBGG
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x690FAB0", Offset = "0x690E4B0", VA = "0x18690FAB0", Slot = "4")]
	public AFMBNCEHFJO NNOPMLBCCDF(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x690EFA0", Offset = "0x690D9A0", VA = "0x18690EFA0", Slot = "5")]
	public BJBFAHKCPDK EPPOIGPLOJJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x690F980", Offset = "0x690E380", VA = "0x18690F980", Slot = "6")]
	public EMBJJNAGKKN MOOJMONOIIE(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x690F2B0", Offset = "0x690DCB0", VA = "0x18690F2B0", Slot = "7")]
	public KECIFNCILIP HLHJCFDFKBH(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x690EED0", Offset = "0x690D8D0", VA = "0x18690EED0", Slot = "8")]
	public ABJMLPOLMOM EAFKCMEIADN(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x690F8B0", Offset = "0x690E2B0", VA = "0x18690F8B0", Slot = "9")]
	public HFBJIBGOGDM MDBPCBMOHEI(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x690F0D0", Offset = "0x690DAD0", VA = "0x18690F0D0", Slot = "10")]
	public LNDPLGJGNOF FGGDJGMGFKP(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x690F1F0", Offset = "0x690DBF0", VA = "0x18690F1F0", Slot = "11")]
	public DJALPJBENNN HDGCANGAFOC(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x690F330", Offset = "0x690DD30", VA = "0x18690F330", Slot = "12")]
	public LJMBHIAJMHG IHMENACEKKJ(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x690EE10", Offset = "0x690D810", VA = "0x18690EE10", Slot = "13")]
	public FDBFLDCBHNC CBIJFLGGOKK(BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x690ECD0", Offset = "0x690D6D0", VA = "0x18690ECD0")]
	public ONBIFHENLDB HPOIFAHAHHN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x690F4D0", Offset = "0x690DED0", VA = "0x18690F4D0")]
	public FEOEOALIHIE OOPENAGDIMK(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x690F780", Offset = "0x690E180", VA = "0x18690F780")]
	public FHFKJNHIBIA LPHNAANBLDA(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x690EB30", Offset = "0x690D530", VA = "0x18690EB30")]
	public APCPPIKGEHG ACFGAPBMPKO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x690F3F0", Offset = "0x690DDF0", VA = "0x18690F3F0")]
	public IBKODPIFJNF OLMEELEAIFP(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x690F660", Offset = "0x690E060", VA = "0x18690F660", Slot = "19")]
	public BGKFOFFDBCF JPJNMPCCLMD(RigidbodyEx FBPPOBEEAPL, JEHGHBKNBMB ABDLEBPKDKC, MFDOLHEPGFE KEKOHNJFKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public BEONHLGAIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x690ECD0", Offset = "0x690D6D0", VA = "0x18690ECD0", Slot = "14")]
	private ONBIFHENLDB AIJNEMDLIDO(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x690F4D0", Offset = "0x690DED0", VA = "0x18690F4D0", Slot = "15")]
	private FEOEOALIHIE JDFIGOKHAHB(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x690F780", Offset = "0x690E180", VA = "0x18690F780", Slot = "16")]
	private FHFKJNHIBIA LFKMGDGGGNI(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x690EB30", Offset = "0x690D530", VA = "0x18690EB30", Slot = "17")]
	private APCPPIKGEHG HJJFFBONKBG(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x690F3F0", Offset = "0x690DDF0", VA = "0x18690F3F0", Slot = "18")]
	private IBKODPIFJNF IMAABIAGMGN(BGKFOFFDBCF KGDPHHJJNLN, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class AMMKGDGOMNI : DJALPJBENNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x690CEA0", Offset = "0x690B8A0", VA = "0x18690CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool BNGHHFBGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x690D2D0", Offset = "0x690BCD0", VA = "0x18690D2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool JBNBNCHDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x690CBE0", Offset = "0x690B5E0", VA = "0x18690CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x690CB80", Offset = "0x690B580", VA = "0x18690CB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x690D940", Offset = "0x690C340", VA = "0x18690D940")]
	public AMMKGDGOMNI(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x690CEF0", Offset = "0x690B8F0", VA = "0x18690CEF0", Slot = "4")]
	public void IOLAFBPFEMC(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x690D480", Offset = "0x690BE80", VA = "0x18690D480")]
	private void OIHJKBMIFNP(Vector3 AHPBABJEPBH, ForceMode CJPJJJBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x690D050", Offset = "0x690BA50", VA = "0x18690D050", Slot = "5")]
	public void KCIPFGJCDLF(Vector3 AHPBABJEPBH, Vector3 DGOJEOCFHHN, ForceMode CJPJJJBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x690D320", Offset = "0x690BD20", VA = "0x18690D320", Slot = "6")]
	public void KJDDIPGEGOA(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x690D6E0", Offset = "0x690C0E0", VA = "0x18690D6E0")]
	private void PEPEPKODFHC(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x690CC40", Offset = "0x690B640", VA = "0x18690CC40", Slot = "7")]
	public void BOCDCMBKMJE(Vector3 CLENPCIPLGG, ForceMode CJPJJJBPAPC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EGHBIFIAJOB : FDBFLDCBHNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool OOJHLGAABAA;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KHOANBPNIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6914B60", Offset = "0x6913560", VA = "0x186914B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x690D940", Offset = "0x690C340", VA = "0x18690D940")]
	public EGHBIFIAJOB(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6914C70", Offset = "0x6913670", VA = "0x186914C70", Slot = "6")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6914CA0", Offset = "0x69136A0", VA = "0x186914CA0", Slot = "7")]
	public void POGBNCADIAC(Rigidbody MAGECLDKLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class DHHNLKKANIM : OMIDGDGEHKA, AFMBNCEHFJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BGKFOFFDBCF FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<BGKFOFFDBCF> DPJIJIIHOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private BGKFOFFDBCF AKBOHBAKCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BGKFOFFDBCF HHJLJBMAMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform OHABAEBHCAG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69130A0", Offset = "0x6911AA0", VA = "0x1869130A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x69131A0", Offset = "0x6911BA0", VA = "0x1869131A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public BGKFOFFDBCF PCJLIOJLCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C6920", Offset = "0x7C5320", VA = "0x1807C6920", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<BGKFOFFDBCF> JGPLFFJIMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C6960", Offset = "0x7C5360", VA = "0x1807C6960", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CLJCKLONOHI BJIOIJFOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6914400", Offset = "0x6912E00", VA = "0x186914400", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6914720", Offset = "0x6913120", VA = "0x186914720", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CLJCKLONOHI DPJFOMNMFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6913100", Offset = "0x6911B00", VA = "0x186913100", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x69147C0", Offset = "0x69131C0", VA = "0x1869147C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OLMONNFPBFD JCBDPCJNBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x69139F0", Offset = "0x69123F0", VA = "0x1869139F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6913D10", Offset = "0x6912710", VA = "0x186913D10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action FODDOPNFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6913950", Offset = "0x6912350", VA = "0x186913950", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6912BD0", Offset = "0x69115D0", VA = "0x186912BD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EEBDHHPMENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6912C70", Offset = "0x6911670", VA = "0x186912C70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6913C70", Offset = "0x6912670", VA = "0x186913C70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BGKFOFFDBCF> DGPGDNHFKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6912FB0", Offset = "0x69119B0", VA = "0x186912FB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6913DB0", Offset = "0x69127B0", VA = "0x186913DB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BGKFOFFDBCF> IJBDDPCPGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6912F00", Offset = "0x6911900", VA = "0x186912F00", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911710", VA = "0x186912D10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action NFKAKLFPMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6912E60", Offset = "0x6911860", VA = "0x186912E60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6912A70", Offset = "0x6911470", VA = "0x186912A70", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BGKFOFFDBCF> BLBDPACOIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6913E60", Offset = "0x6912860", VA = "0x186913E60", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6914040", Offset = "0x6912A40", VA = "0x186914040", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6914860", Offset = "0x6913260", VA = "0x186914860")]
	public DHHNLKKANIM(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6912DC0", Offset = "0x69117C0", VA = "0x186912DC0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x69132E0", Offset = "0x6911CE0", VA = "0x1869132E0", Slot = "30")]
	public void HADFEPOJAPP(BGKFOFFDBCF GCDDFMLCKMH, bool NCHCLNHGGLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x69140F0", Offset = "0x6912AF0", VA = "0x1869140F0", Slot = "6")]
	public void OFIBCNGGADF(BGKFOFFDBCF KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x69144A0", Offset = "0x6912EA0", VA = "0x1869144A0", Slot = "7")]
	public void PDCGLHENNKB(BGKFOFFDBCF KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6913860", Offset = "0x6912260", VA = "0x186913860", Slot = "4")]
	public void HMKOOHPFFKM(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6914360", Offset = "0x6912D60", VA = "0x186914360", Slot = "5")]
	public void OHMLBDKJDCI(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6913A90", Offset = "0x6912490", VA = "0x186913A90")]
	private void JAHAEPOBECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6913060", Offset = "0x6911A60", VA = "0x186913060")]
	private void FMMCJCJCPIM(BGKFOFFDBCF KGMEKBANJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6913B30", Offset = "0x6912530", VA = "0x186913B30")]
	private void JBHGPPJCMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x69131B0", Offset = "0x6911BB0", VA = "0x1869131B0")]
	private void GLMICDKJBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6913F10", Offset = "0x6912910", VA = "0x186913F10")]
	private void MJHAKFFFKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6912B10", Offset = "0x6911510", VA = "0x186912B10")]
	[CompilerGenerated]
	private object CHMEINIGKHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CLAMIDNFCDM
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6911AD0", Offset = "0x69104D0", VA = "0x186911AD0")]
	public static OMIDGDGEHKA KIOIPHAMENG(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CAJCMKKDNBD : LIOAECFLGMK, EMBJJNAGKKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NIOLBLBOOKO<BGKFOFFDBCF> NLJFLOEAKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool IGOMNDDFNHD;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public NIOLBLBOOKO<BGKFOFFDBCF> BNKKGBAPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 IAKGHCODGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6911610", Offset = "0x6910010", VA = "0x186911610", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 HCALOFOLJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6911050", Offset = "0x690FA50", VA = "0x186911050", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 FDLLPICOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6910F60", Offset = "0x690F960", VA = "0x186910F60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BGKFOFFDBCF APNMLMADMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6910E50", Offset = "0x690F850", VA = "0x186910E50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x69119D0", Offset = "0x69103D0", VA = "0x1869119D0")]
	public CAJCMKKDNBD(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6911210", Offset = "0x690FC10", VA = "0x186911210", Slot = "8")]
	public void LMKAJDJJGFJ(BGKFOFFDBCF HHJLJBMAMDD, object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6910F00", Offset = "0x690F900", VA = "0x186910F00", Slot = "9")]
	public void BKHPMKHHBLA(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6911640", Offset = "0x6910040", VA = "0x186911640")]
	private Vector3 MLADEBAPCAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6911280", Offset = "0x690FC80", VA = "0x186911280")]
	private void LOKDBMCPDGJ(BGKFOFFDBCF MFIAOILEACM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class IILONLOKLLO
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x691B130", Offset = "0x6919B30", VA = "0x18691B130")]
	public static LIOAECFLGMK MIILPFMGMED(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PLEJDKJKHBM : HGPNIGJHLGJ, APCPPIKGEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 IHPJGIMODNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 NPFKJJFNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float FNKPGOFMDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float FMGPKOIDGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 NNOBMNCDGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? HFJLFDEDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? GIHHPHDACDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool CHPOLJAKPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool CKALMDDMCFP;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 PGBEPMPOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xC331E0", Offset = "0xC31BE0", VA = "0x180C331E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6922390", Offset = "0x6920D90", VA = "0x186922390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 FGOOHHJNAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6922CE0", Offset = "0x69216E0", VA = "0x186922CE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float HNFBPHKMJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x127FB30", Offset = "0x127E530", VA = "0x18127FB30", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6922670", Offset = "0x6921070", VA = "0x186922670")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float LADAJJHHKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC91B70", VA = "0x180C93170", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6920BB0", Offset = "0x691F5B0", VA = "0x186920BB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GEDNJPOJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6922440", Offset = "0x6920E40", VA = "0x186922440", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion HHEPOOJKCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6922780", Offset = "0x6921180", VA = "0x186922780", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6911D80", Offset = "0x6910780", VA = "0x186911D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CLJCKLONOHI CPPLGLMKDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6922210", Offset = "0x6920C10", VA = "0x186922210", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x69225D0", Offset = "0x6920FD0", VA = "0x1869225D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x69232F0", Offset = "0x6921CF0", VA = "0x1869232F0")]
	public PLEJDKJKHBM(BGKFOFFDBCF FBPPOBEEAPL, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6922B30", Offset = "0x6921530", VA = "0x186922B30", Slot = "17")]
	public void MEIKPFPCEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6920C60", Offset = "0x691F660", VA = "0x186920C60", Slot = "16")]
	public void CPBFJJKCNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x69222B0", Offset = "0x6920CB0", VA = "0x1869222B0", Slot = "19")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6923100", Offset = "0x6921B00", VA = "0x186923100", Slot = "20")]
	public void POGBNCADIAC(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6921BC0", Offset = "0x69205C0", VA = "0x186921BC0", Slot = "18")]
	public void DNFMDMLCDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6921D70", Offset = "0x6920770", VA = "0x186921D70", Slot = "21")]
	public void EIDDFCDABLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6922390", Offset = "0x6920D90", VA = "0x186922390")]
	private void GGLNNACFCOO(Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6920AC0", Offset = "0x691F4C0", VA = "0x186920AC0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BNBKLECBGAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6922670", Offset = "0x6921070", VA = "0x186922670")]
	private void JPIFGPGHIND(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6920BB0", Offset = "0x691F5B0", VA = "0x186920BB0")]
	private void CJJJAIFDFNG(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6922F60", Offset = "0x6921960", VA = "0x186922F60")]
	private Vector3 NAOKKOAMMEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6922900", Offset = "0x6921300", VA = "0x186922900", Slot = "15")]
	public void LBIDHDCCHFN((Quaternion rot, Vector3 moments) IIOBFIHKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6922DE0", Offset = "0x69217E0", VA = "0x186922DE0")]
	private Quaternion MILBOGIMHJJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6921AF0", Offset = "0x69204F0", VA = "0x186921AF0")]
	public void DJHNOGBKIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6920D40", Offset = "0x691F740", VA = "0x186920D40", Slot = "4")]
	public (float, Vector3) DJHNOGBKIAJ(Rigidbody PCJLNNKLADO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class DCGLHMLCLFF
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x69129B0", Offset = "0x69113B0", VA = "0x1869129B0")]
	public static HGPNIGJHLGJ ILPBBMLLFLK(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ONNAHGEHCON : FHFKJNHIBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly DMNFIAAEHEB FDPGGEJFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly JFKHEFJKEKA GACJJBDOHIK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool DBIOFCDLEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xDCBAE0", Offset = "0xDCA4E0", VA = "0x180DCBAE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JFKHEFJKEKA HNPAGELODMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90", Slot = "11")]
		get
		{
			return default(JFKHEFJKEKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x69209C0", Offset = "0x691F3C0", VA = "0x1869209C0")]
	public ONNAHGEHCON(BGKFOFFDBCF FBPPOBEEAPL, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x69203A0", Offset = "0x691EDA0", VA = "0x1869203A0", Slot = "4")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6920790", Offset = "0x691F190", VA = "0x186920790")]
	private bool LJMINIPCJAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6920990", Offset = "0x691F390", VA = "0x186920990", Slot = "5")]
	public void OAKOFOICCKI(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6920720", Offset = "0x691F120", VA = "0x186920720", Slot = "6")]
	public void HFDPPJMJNJL(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6920470", Offset = "0x691EE70", VA = "0x186920470", Slot = "9")]
	public void AKIDJLNNAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6920830", Offset = "0x691F230", VA = "0x186920830")]
	private void MONONIINEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x69205B0", Offset = "0x691EFB0", VA = "0x1869205B0")]
	private void CENDCJDMNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6920950", Offset = "0x691F350", VA = "0x186920950", Slot = "8")]
	public void NPPPLEHHDHK(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6920750", Offset = "0x691F150", VA = "0x186920750", Slot = "7")]
	public void HIBGPLCPEKH(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NFDELBJKNPD : LNDPLGJGNOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DMNFIAAEHEB IDCJKLIBLCA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool BNGHHFBGLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x691F560", Offset = "0x691DF60", VA = "0x18691F560", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CLJCKLONOHI BKCAALMFKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x691F4C0", Offset = "0x691DEC0", VA = "0x18691F4C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x691F290", Offset = "0x691DC90", VA = "0x18691F290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x691F650", Offset = "0x691E050", VA = "0x18691F650")]
	public NFDELBJKNPD(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x691F610", Offset = "0x691E010", VA = "0x18691F610", Slot = "7")]
	public void LFGJFDJEKON(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x691F280", Offset = "0x691DC80", VA = "0x18691F280", Slot = "8")]
	public void CFMMBGEIBIN(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x691F3B0", Offset = "0x691DDB0", VA = "0x18691F3B0", Slot = "9")]
	public void GMPJPEGBADP(object AIDIDMJCFEK, bool PFAHELLLIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x691F240", Offset = "0x691DC40", VA = "0x18691F240", Slot = "12")]
	public void AEAHGNJLADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x691F330", Offset = "0x691DD30", VA = "0x18691F330", Slot = "10")]
	public void FOONAHLFFPI(Rigidbody LNCKMBKIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x691F620", Offset = "0x691E020", VA = "0x18691F620", Slot = "11")]
	public void POGBNCADIAC(Rigidbody MAGECLDKLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class BNPPPGAIAAD : KDEFIMDNJHB, FEOEOALIHIE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView DJFIGOLNDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool EOKILFBPHFA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView CFIHGBGDFBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool IJNDOBJJHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6910380", Offset = "0x690ED80", VA = "0x186910380", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool EACCFBALNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9184F0", Offset = "0x916EF0", VA = "0x1809184F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CLJCKLONOHI KDCFGOKPIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6910720", Offset = "0x690F120", VA = "0x186910720", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x69103A0", Offset = "0x690EDA0", VA = "0x1869103A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6910CF0", Offset = "0x690F6F0", VA = "0x186910CF0")]
	public BNPPPGAIAAD(BGKFOFFDBCF FBPPOBEEAPL, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6910150", Offset = "0x690EB50", VA = "0x186910150", Slot = "9")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6910280", Offset = "0x690EC80", VA = "0x186910280", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6910B80", Offset = "0x690F580", VA = "0x186910B80", Slot = "10")]
	public void ONFNPMCGPDC(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6910440", Offset = "0x690EE40", VA = "0x186910440", Slot = "11")]
	public void JNONIFOJPBJ(BGKFOFFDBCF HHJLJBMAMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69105B0", Offset = "0x690EFB0", VA = "0x1869105B0")]
	private void MBANJGICLHH(PhotonView IJEPJBFBDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x69107C0", Offset = "0x690F1C0", VA = "0x1869107C0")]
	private void MNLDIAFHBEM(IHGKDIOHOHL PLCEGOFKPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6910910", Offset = "0x690F310", VA = "0x186910910")]
	private void OIDFECHLAEJ(PhotonView JFIIPPMOFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class AOBMMAMGJHE
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x690D9D0", Offset = "0x690C3D0", VA = "0x18690D9D0")]
	public static KDEFIMDNJHB FGDJFLANNKE(this BGKFOFFDBCF KGDPHHJJNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class DIJNHHNCHJJ : IBKODPIFJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints AMMCNKHJGOI;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool FDBNPEOBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB9CE20", Offset = "0xB9B820", VA = "0x180B9CE20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x40A9710", Offset = "0x40A8110", VA = "0x1840A9710", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CNIPCEOCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE20660", Offset = "0xE1F060", VA = "0x180E20660", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x40A9700", Offset = "0x40A8100", VA = "0x1840A9700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints EBCHHJPEJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6914950", Offset = "0x6913350", VA = "0x186914950", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6914AB0", Offset = "0x69134B0", VA = "0x186914AB0")]
	public DIJNHHNCHJJ(BGKFOFFDBCF FBPPOBEEAPL, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6914920", Offset = "0x6913320", VA = "0x186914920", Slot = "9")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6914A80", Offset = "0x6913480", VA = "0x186914A80", Slot = "10")]
	public void POGBNCADIAC(Rigidbody MAGECLDKLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DBIGEKANJCF : KECIFNCILIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly BGKFOFFDBCF FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float KILJGMPMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float PCJDNEMEBMM;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float APDNNPKAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x955000", VA = "0x180956600", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6912800", Offset = "0x6911200", VA = "0x186912800", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float JGAGIKGBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA141A0", Offset = "0xA12BA0", VA = "0x180A141A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x69126E0", Offset = "0x69110E0", VA = "0x1869126E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6912970", Offset = "0x6911370", VA = "0x186912970")]
	public DBIGEKANJCF(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x69127B0", Offset = "0x69111B0", VA = "0x1869127B0", Slot = "8")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x69128D0", Offset = "0x69112D0", VA = "0x1869128D0", Slot = "9")]
	public void POGBNCADIAC(Rigidbody MAGECLDKLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class COOJDIADDAJ : ABJMLPOLMOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool GGENFNNNPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool KCGJGMIPMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int NEDENKGPICB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6911D80", Offset = "0x6910780", VA = "0x186911D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool EIJLNOMCIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6911DD0", Offset = "0x69107D0", VA = "0x186911DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private BGKFOFFDBCF OCIMJODBDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6911C20", Offset = "0x6910620", VA = "0x186911C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JBNBNCHDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6911C80", Offset = "0x6910680", VA = "0x186911C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CLJCKLONOHI KLFKOBHMENA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6911DF0", Offset = "0x69107F0", VA = "0x186911DF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6911CE0", Offset = "0x69106E0", VA = "0x186911CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6912650", Offset = "0x6911050", VA = "0x186912650")]
	public COOJDIADDAJ(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6911B90", Offset = "0x6910590", VA = "0x186911B90", Slot = "6")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6912270", Offset = "0x6910C70", VA = "0x186912270", Slot = "8")]
	public void IEPNJBJKLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6912320", Offset = "0x6910D20", VA = "0x186912320", Slot = "7")]
	public bool IODNPBHJDNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x69121D0", Offset = "0x6910BD0", VA = "0x1869121D0", Slot = "9")]
	public void FKGGGOAKKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6912280", Offset = "0x6910C80", VA = "0x186912280", Slot = "11")]
	public void INLIEIBMNOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6911E90", Offset = "0x6910890", VA = "0x186911E90", Slot = "10")]
	public void FDFHMPIDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6912470", Offset = "0x6910E70", VA = "0x186912470")]
	private bool MDPFJIECIJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6912040", Offset = "0x6910A40", VA = "0x186912040")]
	private void FJDENOLGJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class APMCMOKENEB : ONBIFHENLDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly DMNFIAAEHEB JIOBPAKGHCH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody POOBCMLELBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool JBNBNCHDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x690CBE0", Offset = "0x690B5E0", VA = "0x18690CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool NBEIBFKKIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xDCBAE0", Offset = "0xDCA4E0", VA = "0x180DCBAE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x690EA20", Offset = "0x690D420", VA = "0x18690EA20")]
	public APMCMOKENEB(BGKFOFFDBCF FBPPOBEEAPL, [In] JEHGHBKNBMB ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x690DA90", Offset = "0x690C490", VA = "0x18690DA90", Slot = "5")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x690DB30", Offset = "0x690C530", VA = "0x18690DB30", Slot = "7")]
	public void EIKEAHAJACC(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x690DB60", Offset = "0x690C560", VA = "0x18690DB60", Slot = "8")]
	public void HEJIHGANKGN(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x690E3C0", Offset = "0x690CDC0", VA = "0x18690E3C0", Slot = "9")]
	public void LPFKFPBCHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x690E020", Offset = "0x690CA20", VA = "0x18690E020", Slot = "11")]
	public void KCKILCACKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x690E6F0", Offset = "0x690D0F0", VA = "0x18690E6F0", Slot = "12")]
	public void MGPAPKKNGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x690DB90", Offset = "0x690C590", VA = "0x18690DB90", Slot = "10")]
	public void JCIELFDFAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x690E210", Offset = "0x690CC10", VA = "0x18690E210")]
	private void LILGNIJJAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x690E870", Offset = "0x690D270", VA = "0x18690E870")]
	private void NKMAEFPAMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JJDADMHPCLO : BJBFAHKCPDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FMLBEMMBMDK FBPPOBEEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DMNFIAAEHEB HBJEMMLMDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float HJGGHBFHEJE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public KEGIGDFABJI NPEIHINPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GJIGFONCOIL ELNOHMHCOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 FDLLPICOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x691C4A0", Offset = "0x691AEA0", VA = "0x18691C4A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x691DA70", Offset = "0x691C470", VA = "0x18691DA70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 OIHIHNLLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x691C860", Offset = "0x691B260", VA = "0x18691C860", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x691C470", Offset = "0x691AE70", VA = "0x18691C470", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 CBOMGOGEPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x691D5D0", Offset = "0x691BFD0", VA = "0x18691D5D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x691DCD0", Offset = "0x691C6D0", VA = "0x18691DCD0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 ANAGKNDCEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x691C320", Offset = "0x691AD20", VA = "0x18691C320", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x691DA40", Offset = "0x691C440", VA = "0x18691DA40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float BGIOEPDEEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x979250", Offset = "0x977C50", VA = "0x180979250", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x691D810", Offset = "0x691C210", VA = "0x18691D810", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LAPOJFBCBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x178E720", Offset = "0x178D120", VA = "0x18178E720", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DJALPJBENNN OLEFDMIGJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x61CB8C0", Offset = "0x61CA2C0", VA = "0x1861CB8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool EIJLNOMCIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x691C450", Offset = "0x691AE50", VA = "0x18691C450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x691E7A0", Offset = "0x691D1A0", VA = "0x18691E7A0")]
	public JJDADMHPCLO(BGKFOFFDBCF FBPPOBEEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x691B3D0", Offset = "0x6919DD0", VA = "0x18691B3D0", Slot = "19")]
	public void ADOMGPBBEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x691C660", Offset = "0x691B060", VA = "0x18691C660", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x691D110", Offset = "0x691BB10", VA = "0x18691D110", Slot = "28")]
	public void FOONAHLFFPI(Rigidbody MAGECLDKLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xBD7780", Offset = "0xBD6180", VA = "0x180BD7780", Slot = "20")]
	public void JKPPCMGIFNG(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBD7320", Offset = "0xBD5D20", VA = "0x180BD7320", Slot = "30")]
	public void INLELIFCBDB(object AIDIDMJCFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x691B1F0", Offset = "0x6919BF0", VA = "0x18691B1F0", Slot = "35")]
	public Vector3 ABAJAMKFLOC(Vector3 EJPNFJPEMJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x691D240", Offset = "0x691BC40", VA = "0x18691D240", Slot = "34")]
	public Vector3 GLHINNLNEJM(Vector3 BIIBBMJOAGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x691B3D0", Offset = "0x6919DD0", VA = "0x18691B3D0", Slot = "27")]
	public void AINBAPPNEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x691D0B0", Offset = "0x691BAB0", VA = "0x18691D0B0", Slot = "25")]
	public void FNFLFILCDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x691D050", Offset = "0x691BA50", VA = "0x18691D050", Slot = "24")]
	public void FLPNFDKEPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x691CE10", Offset = "0x691B810", VA = "0x18691CE10", Slot = "33")]
	public void FKFBIOKHALP(Vector3 PCFNCEMBLII, Vector3 JDJIFNJBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x691C600", Offset = "0x691B000", VA = "0x18691C600", Slot = "32")]
	public void DJCKPOFCHOG(Vector3 LCOIJGMOGBI, Vector3 MCDLIMPJKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x691DB30", Offset = "0x691C530", VA = "0x18691DB30", Slot = "31")]
	public void MEJCMJJNGAP(Vector3 OJFLAKENKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x691BA20", Offset = "0x691A420", VA = "0x18691BA20", Slot = "22")]
	public void BFJMDJJMNGM(HFJBCEABLKK PKAFBMHMFIK, Vector3 OAEBAFNOOID, float JFGFKKKJALP, float BGKBBCAODHG = 8f, float LNEPLNANENF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x691C090", Offset = "0x691AA90", VA = "0x18691C090", Slot = "21")]
	public void BKIJAODPLKO(JICPGDJPMBL IAKHFJKEGIK, Vector3 EDDODGHDOCK, float NOGBLOAKKEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x691E220", Offset = "0x691CC20", VA = "0x18691E220", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OCKBMELOJNJ(JICPGDJPMBL IAKHFJKEGIK, Vector3 DMBBOEJIOJM, float OGMNDMHPDON = 7f, float AENPFKNAHJG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xCD5800", Offset = "0xCD4200", VA = "0x180CD5800")]
	private static void FMJNNKFICKA(Vector3 HLHANNCAGLP, Vector3 AMMBIDJOPFP, [Out] Vector3 KNPKDBCBEFK, [Out] Vector3 OFENGNIBMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x691D730", Offset = "0x691C130", VA = "0x18691D730", Slot = "29")]
	public Vector3 JHCACNAMEEL(Vector3 HLHANNCAGLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x691E610", Offset = "0x691D010", VA = "0x18691E610", Slot = "26")]
	public void PNMKOJELMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x691D810", Offset = "0x691C210", VA = "0x18691D810")]
	private void JIJNNJKNCGH(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x691C6C0", Offset = "0x691B0C0", VA = "0x18691C6C0")]
	private void EHFGECPPKOM(Vector3 EDDODGHDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x691D920", Offset = "0x691C320", VA = "0x18691D920")]
	private Vector3 LIOOGICDOMO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x691DD90", Offset = "0x691C790", VA = "0x18691DD90")]
	private void MKAIFBDCBOG(Vector3 BIIBBMJOAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x691D4B0", Offset = "0x691BEB0", VA = "0x18691D4B0")]
	private Vector3 HBBAIEDHJIB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x691C980", Offset = "0x691B380", VA = "0x18691C980")]
	private void FIPMDHEFNBJ(Vector3 AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x691B480", Offset = "0x6919E80", VA = "0x18691B480")]
	private void AKIPEDLIAOA(Vector3 BIIBBMJOAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x691D400", Offset = "0x691BE00", VA = "0x18691D400")]
	private void GNHJHABOFBP()
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
