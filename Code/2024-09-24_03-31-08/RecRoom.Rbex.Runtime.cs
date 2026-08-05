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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x720C860", Offset = "0x720B260", VA = "0x18720C860", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HMPAICJIGED bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1854250", Offset = "0x1852C50", VA = "0x181854250", Slot = "5")]
		public override void MOJOJHIFMIM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7213DD0", Offset = "0x72127D0", VA = "0x187213DD0")]
		private void ILLMDAGMECA(CIEDHBGLHLN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72140D0", Offset = "0x7212AD0", VA = "0x1872140D0", Slot = "6")]
		public override void OHBCOLHBNBK(CIEDHBGLHLN registry, [In] NMJMFLJNABF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7214130", Offset = "0x7212B30", VA = "0x187214130")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HFLALFLFNKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly CAFGMNLACIN IOBFEBNJOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool HIOANPLOAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private OBJADMFPMJH EEGCGGPDNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[IBDNIDADCCI(NEFCELJHDOC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IBDNIDADCCI(NEFCELJHDOC.SelfAndParent, true, false, false)]
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
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private DJFECCHKBLN physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal OBJADMFPMJH CIALMPKLFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x720FCD0", Offset = "0x720E6D0", VA = "0x18720FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OBJADMFPMJH EHKJEJBOGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NFJJMFLIFGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7211240", Offset = "0x720FC40", VA = "0x187211240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HNCADFFBKFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x72115A0", Offset = "0x720FFA0", VA = "0x1872115A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx CHMOOKFGBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72114E0", Offset = "0x720FEE0", VA = "0x1872114E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KMAENCDMJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7212240", Offset = "0x7210C40", VA = "0x187212240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7213740", Offset = "0x7212140", VA = "0x187213740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CLCFMOBCLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AD490", Offset = "0x8ABE90", VA = "0x1808AD490", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FEAFHMIFNOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8AD490", Offset = "0x8ABE90", VA = "0x1808AD490", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JGCAFIGAFFP JCGDEDNKJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72112A0", Offset = "0x720FCA0", VA = "0x1872112A0")]
			get
			{
				return default(JGCAFIGAFFP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7212EF0", Offset = "0x72118F0", VA = "0x187212EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GLJAGCBNLCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72118B0", Offset = "0x72102B0", VA = "0x1872118B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FNNONNNMHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72113C0", Offset = "0x720FDC0", VA = "0x1872113C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EAEHANAOBNM AFBAAJPFHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72117F0", Offset = "0x72101F0", VA = "0x1872117F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x72130B0", Offset = "0x7211AB0", VA = "0x1872130B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EFMMKCONAKN PNLCBHJMPHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7211790", Offset = "0x7210190", VA = "0x187211790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7213040", Offset = "0x7211A40", VA = "0x187213040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JONIPFJBLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72116E0", Offset = "0x72100E0", VA = "0x1872116E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody LMOODLOFANM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7211740", Offset = "0x7210140", VA = "0x187211740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ODFMFNHICOK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7211420", Offset = "0x720FE20", VA = "0x187211420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7212F60", Offset = "0x7211960", VA = "0x187212F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EPMDBPGJGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EECBC0", Offset = "0x6EEB5C0", VA = "0x186EECBC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float ELNCKLJNHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72121E0", Offset = "0x7210BE0", VA = "0x1872121E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float MJBKJCHOPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7212180", Offset = "0x7210B80", VA = "0x187212180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72136D0", Offset = "0x72120D0", VA = "0x1872136D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EJENIGIADEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7211B10", Offset = "0x7210510", VA = "0x187211B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7213350", Offset = "0x7211D50", VA = "0x187213350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GDBONDCADGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7211910", Offset = "0x7210310", VA = "0x187211910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7213120", Offset = "0x7211B20", VA = "0x187213120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool BPJEPAIPEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7212790", Offset = "0x7211190", VA = "0x187212790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7213C80", Offset = "0x7212680", VA = "0x187213C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 FKOLFMJGGBE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7211F60", Offset = "0x7210960", VA = "0x187211F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72134A0", Offset = "0x7211EA0", VA = "0x1872134A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 AODBHBPFPNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72128D0", Offset = "0x72112D0", VA = "0x1872128D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode JHJLHPMKCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7211A50", Offset = "0x7210450", VA = "0x187211A50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7213270", Offset = "0x7211C70", VA = "0x187213270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OBNECJIFDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7211480", Offset = "0x720FE80", VA = "0x187211480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7212FD0", Offset = "0x72119D0", VA = "0x187212FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints MMHODEDNBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7211AB0", Offset = "0x72104B0", VA = "0x187211AB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x72132E0", Offset = "0x7211CE0", VA = "0x1872132E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FCAFKIHLDIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7212300", Offset = "0x7210D00", VA = "0x187212300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 CCIKMGEGKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7212300", Offset = "0x7210D00", VA = "0x187212300")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7213A60", Offset = "0x7212460", VA = "0x187213A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EOPFFPFBBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7212040", Offset = "0x7210A40", VA = "0x187212040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7213580", Offset = "0x7211F80", VA = "0x187213580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PALOMKBNDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7212730", Offset = "0x7211130", VA = "0x187212730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7213C10", Offset = "0x7212610", VA = "0x187213C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion FKKMJPCMCLM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72123E0", Offset = "0x7210DE0", VA = "0x1872123E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72137E0", Offset = "0x72121E0", VA = "0x1872137E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PFOJHBKPLOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7212660", Offset = "0x7211060", VA = "0x187212660")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7213B40", Offset = "0x7212540", VA = "0x187213B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 AKINGIFLABF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72124B0", Offset = "0x7210EB0", VA = "0x1872124B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72138B0", Offset = "0x72122B0", VA = "0x1872138B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion LGMAACBCKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7212590", Offset = "0x7210F90", VA = "0x187212590")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7213990", Offset = "0x7212390", VA = "0x187213990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DPBIGMHBMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72127F0", Offset = "0x72111F0", VA = "0x1872127F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7213CF0", Offset = "0x72126F0", VA = "0x187213CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 KDBAABAMFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72120A0", Offset = "0x7210AA0", VA = "0x1872120A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72135F0", Offset = "0x7211FF0", VA = "0x1872135F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 LJFEFIKHHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7211970", Offset = "0x7210370", VA = "0x187211970")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7213190", Offset = "0x7211B90", VA = "0x187213190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 NHLDMOEHBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7211E80", Offset = "0x7210880", VA = "0x187211E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72133C0", Offset = "0x7211DC0", VA = "0x1872133C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 BEDBAGAOPLA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7211D40", Offset = "0x7210740", VA = "0x187211D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PEAAMJLAGCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7211C70", Offset = "0x7210670", VA = "0x187211C70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BCCGLIDFLPA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7212A90", Offset = "0x7211490", VA = "0x187212A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 PBJBJILFDOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72129B0", Offset = "0x72113B0", VA = "0x1872129B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BHHJMGOHDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7211E20", Offset = "0x7210820", VA = "0x187211E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool APKDHMBELGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7211850", Offset = "0x7210250", VA = "0x187211850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KCMNBDEIGLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7211360", Offset = "0x720FD60", VA = "0x187211360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AFJEFEFBAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7211300", Offset = "0x720FD00", VA = "0x187211300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PLAFMNFAGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x72111E0", Offset = "0x720FBE0", VA = "0x1872111E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HGBKGOIPBML
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7211B70", Offset = "0x7210570", VA = "0x187211B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HACHFHFHEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1A92750", Offset = "0x1A91150", VA = "0x181A92750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FMDFHEHDPPJ KJNGGMBJAOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7211100", Offset = "0x720FB00", VA = "0x187211100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7212E10", Offset = "0x7211810", VA = "0x187212E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JIBAICMKDBF PLLJDLBDCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7210E70", Offset = "0x720F870", VA = "0x187210E70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7212B70", Offset = "0x7211570", VA = "0x187212B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JIBAICMKDBF KAGPEGHHNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7210ED0", Offset = "0x720F8D0", VA = "0x187210ED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7212BE0", Offset = "0x72115E0", VA = "0x187212BE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JIBAICMKDBF HELFJJFGNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7211020", Offset = "0x720FA20", VA = "0x187211020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7212D30", Offset = "0x7211730", VA = "0x187212D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HDLBMLPIHPN, HDLBMLPIHPN> LNMNLFIDGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7210FB0", Offset = "0x720F9B0", VA = "0x187210FB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7212CC0", Offset = "0x72116C0", VA = "0x187212CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event JIBAICMKDBF IBPIJNKKAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7211090", Offset = "0x720FA90", VA = "0x187211090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7212DA0", Offset = "0x72117A0", VA = "0x187212DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JIBAICMKDBF MNJFDLPIMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7211170", Offset = "0x720FB70", VA = "0x187211170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7212E80", Offset = "0x7211880", VA = "0x187212E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JIBAICMKDBF HIFBEIGFKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7210F40", Offset = "0x720F940", VA = "0x187210F40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7212C50", Offset = "0x7211650", VA = "0x187212C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640", Slot = "8")]
		private void EIPHMLLDCDA(OBJADMFPMJH KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x720FEF0", Offset = "0x720E8F0", VA = "0x18720FEF0")]
		internal void PDPIOGPNKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7210BA0", Offset = "0x720F5A0", VA = "0x187210BA0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody KILNAAKBJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x720F800", Offset = "0x720E200", VA = "0x18720F800")]
		public HFLALFLFNKL GetChild(int ENMILGHAHOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7210810", Offset = "0x720F210", VA = "0x187210810")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KEAIEABHOPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x720F390", Offset = "0x720DD90", VA = "0x18720F390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x720FCD0", Offset = "0x720E6D0", VA = "0x18720FCD0")]
		private OBJADMFPMJH LACJOJJKMBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x720F400", Offset = "0x720DE00", VA = "0x18720F400")]
		private void BDNFIJHBNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x720FFE0", Offset = "0x720E9E0", VA = "0x18720FFE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x720FEF0", Offset = "0x720E8F0", VA = "0x18720FEF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x720FF80", Offset = "0x720E980", VA = "0x18720FF80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7210040", Offset = "0x720EA40", VA = "0x187210040")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x720E980", Offset = "0x720D380", VA = "0x18720E980")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72100A0", Offset = "0x720EAA0", VA = "0x1872100A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x720F7A0", Offset = "0x720E1A0", VA = "0x18720F7A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x720FE90", Offset = "0x720E890", VA = "0x18720FE90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7210970", Offset = "0x720F370", VA = "0x187210970")]
		public void SetParent(RigidbodyEx IPHMAHBENGI, bool NOCMPIEOFCP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72103B0", Offset = "0x720EDB0", VA = "0x1872103B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x720FAB0", Offset = "0x720E4B0", VA = "0x18720FAB0")]
		public bool IsRigidbodyAncestor(RigidbodyEx KNFGKJMJFNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x720FB90", Offset = "0x720E590", VA = "0x18720FB90")]
		public bool IsRigidbodyDescendant(RigidbodyEx PMHHELHJDLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x720EBF0", Offset = "0x720D5F0", VA = "0x18720EBF0")]
		public void AddInterpolationRestriction(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7210110", Offset = "0x720EB10", VA = "0x187210110")]
		public void RemoveInterpolationRestriction(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x720EC60", Offset = "0x720D660", VA = "0x18720EC60")]
		public void AddKinematic(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7210180", Offset = "0x720EB80", VA = "0x187210180")]
		public void RemoveKinematic(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72108F0", Offset = "0x720F2F0", VA = "0x1872108F0")]
		public void SetKinematic(object OEELDHBFFAF, bool GHLPIJPFEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7210710", Offset = "0x720F110", VA = "0x187210710")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MMHKIDDFEKP, Quaternion NMANLJPNBHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7210610", Offset = "0x720F010", VA = "0x187210610")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JJPDKKMDNGG, Quaternion EKPDAGMGKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x720F9A0", Offset = "0x720E3A0", VA = "0x18720F9A0")]
		public Vector3 GetConstrainedVelocity(Vector3 DPBIGMHBMBN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x720F890", Offset = "0x720E290", VA = "0x18720F890")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LJFEFIKHHHB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x720EB00", Offset = "0x720D500", VA = "0x18720EB00")]
		public void AddForce(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x720E9F0", Offset = "0x720D3F0", VA = "0x18720E9F0")]
		public void AddForceAtPosition(Vector3 LCIPAAAOEPD, Vector3 EJEBFMEPKGF, ForceMode COIAPCCPMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x720EE30", Offset = "0x720D830", VA = "0x18720EE30")]
		public void AddTorque(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x720ECD0", Offset = "0x720D6D0", VA = "0x18720ECD0")]
		public void AddRelativeTorque(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7210C70", Offset = "0x720F670", VA = "0x187210C70")]
		public Vector3 WorldToLocalVelocity(Vector3 MGCJLNPPEHB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x720FD80", Offset = "0x720E780", VA = "0x18720FD80")]
		public Vector3 LocalToWorldVelocity(Vector3 KDBAABAMFFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x720F740", Offset = "0x720E140", VA = "0x18720F740")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x720F6E0", Offset = "0x720E0E0", VA = "0x18720F6E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x720F680", Offset = "0x720E080", VA = "0x18720F680")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x720F620", Offset = "0x720E020", VA = "0x18720F620")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7210510", Offset = "0x720EF10", VA = "0x187210510")]
		public void ResetVelocityWorldSpace(Vector3 CMOABHDGOOA, Vector3 OFDEGDNPEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7210410", Offset = "0x720EE10", VA = "0x187210410")]
		public void ResetVelocityLocalSpace(Vector3 JJPPCHKBGCE, Vector3 NHLDMOEHBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72102D0", Offset = "0x720ECD0", VA = "0x1872102D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 JJPPCHKBGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7210AA0", Offset = "0x720F4A0", VA = "0x187210AA0")]
		public bool SweepTest(Vector3 FJODMBFILLK, [Out] RaycastHit NJKLEFHEHBB, float PEAKDEKJAOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x720FC70", Offset = "0x720E670", VA = "0x18720FC70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7210A40", Offset = "0x720F440", VA = "0x187210A40")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7210C10", Offset = "0x720F610", VA = "0x187210C10")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x720EDC0", Offset = "0x720D7C0", VA = "0x18720EDC0")]
		public void AddShouldHaveUnityRigidbodyToken(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x72101F0", Offset = "0x720EBF0", VA = "0x1872101F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x720F1C0", Offset = "0x720DBC0", VA = "0x18720F1C0")]
		public void ApplyForceVelocityChange(KFHHPEHINFA IGPGKDFNPIE, Vector3 MKNOEHKBNIG, float BJFBGGPKGPA, float EFMCFCCKEMH = 8f, float JBMOFLKNCDP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x720F0C0", Offset = "0x720DAC0", VA = "0x18720F0C0")]
		public void ApplyAngularVelocityChange(HOBGLFAGAKH GGCOHIKNBGE, Vector3 FODDDPLGLIO, float GANNKOJAILG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x720F280", Offset = "0x720DC80", VA = "0x18720F280")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HOBGLFAGAKH GGCOHIKNBGE, Vector3 PCIAHIPKDFG, float IBHPJNLNOPM = 7f, float PAOBAPJMBLG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x720EFF0", Offset = "0x720D9F0", VA = "0x18720EFF0")]
		public bool AllowedScaleChange(float IBDBBIJPGDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x720EF20", Offset = "0x720D920", VA = "0x18720EF20")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HBPBPEHMMEK, object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7210260", Offset = "0x720EC60", VA = "0x187210260")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OEELDHBFFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7210E00", Offset = "0x720F800", VA = "0x187210E00")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xC295B0", Offset = "0xC27FB0", VA = "0x180C295B0", Slot = "4")]
		private GameObject GHEIMHJFKLE()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD490", Offset = "0x8ABE90", VA = "0x1808AD490", Slot = "5")]
		private Transform CKPIFJBNNCK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class OCNAOOJPMHI
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x720E290", Offset = "0x720CC90", VA = "0x18720E290")]
	public static OBJADMFPMJH CIALMPKLFAP(this RigidbodyEx DGJECMOALOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HFJNCABCFLK(typeof(JNPFMEMIKMB), new string[] { })]
public class FKLAGFMHIAF : JNPFMEMIKMB, AGOPHKGBOPE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private KNKBCNKBMPM PJCMNKAAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private IDCEFCJKKHD HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BNKBIDNBHPE CJENILNPCGC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IDCEFCJKKHD FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BNKBIDNBHPE FOMJLKMEBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72058D0", Offset = "0x72042D0", VA = "0x1872058D0", Slot = "7")]
	public void InitReferences(BEMAECNLOEH PFGCONMFOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7205960", Offset = "0x7204360", VA = "0x187205960", Slot = "6")]
	public OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public FKLAGFMHIAF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BPJHNJKJMPB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int CPALMDDNOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int APAMLHKABJH;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x720E800", Offset = "0x720D200", VA = "0x18720E800")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x720E840", Offset = "0x720D240", VA = "0x18720E840")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x720E820", Offset = "0x720D220", VA = "0x18720E820")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BBDGOIMNDJI, [Optional] UnityEngine.Object MPOBGCPIOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BBDGOIMNDJI, [Optional] UnityEngine.Object MPOBGCPIOEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x720E930", Offset = "0x720D330", VA = "0x18720E930")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DGGJOGHJIHM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CKIDNMOBNLM : EAEHANAOBNM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8939F0", Offset = "0x8923F0", VA = "0x1808939F0", Slot = "4")]
		public Vector3 CIEBEHAEGOO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8939F0", Offset = "0x8923F0", VA = "0x1808939F0", Slot = "5")]
		public Vector3 FCJAAOBIKII()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CKIDNMOBNLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static EAEHANAOBNM DILKGACDJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71FCAB0", Offset = "0x71FB4B0", VA = "0x1871FCAB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLGADBDOOIG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode JENKMMFDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCGLDIBBDIE(bool BHHJMGOHDCN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNNPGLLJLCJ(bool BHHJMGOHDCN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBJCAILECDJ(Vector3 FJODMBFILLK, [Out] RaycastHit NJKLEFHEHBB, float PEAKDEKJAOG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EAOMAANKAFE : IDisposable, FNJKPCHPEGH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JGCAFIGAFFP JCGDEDNKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<HDLBMLPIHPN, HDLBMLPIHPN> LNMNLFIDGAC;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNBEJFPEDIJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface BNKBIDNBHPE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KKLOCIOOIJC EENJBLIKKMF(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAAPFDLIGNJ FMLPMPELCJB(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FOLDPEHOMLH HIKKPJLHLGG(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DBMCEOHMEEO GOKLOCDCNDB(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AAPCFFOMJDB GIHFAAODADA(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EAOMAANKAFE ICEMKNKAJGO(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HLACGAEOOBN PBBJBHGLNPC(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FELHEFMEMFK CAHLOKOGPIO(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PLGADBDOOIG PEAKILADGLB(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LBPMOEBGIAB KLDACFCOKGE(OBJADMFPMJH KCEPABIAINB);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LJIHFPJGIJD CGPBNIABIFD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ONGNJPHBDLJ GPMNFFKENOB(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PJGJBBEFOMP POIGFIMACNI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GNBHDEADFGP HEPKIPELFOA(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GABFPCKLHNH ICBANGCPNEN(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF, JNPFMEMIKMB PEDEFMGDCEP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FELHEFMEMFK
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHFFLMGGOEE(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNBEAJFIEBH(Vector3 LCIPAAAOEPD, Vector3 EJEBFMEPKGF, ForceMode COIAPCCPMKA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHEIBOGMLPO(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBGIFGNIIII(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LBPMOEBGIAB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BNPFHDHMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KKLOCIOOIJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<OBJADMFPMJH> CAMGNEHBANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OBJADMFPMJH CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JIBAICMKDBF PLLJDLBDCIN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JIBAICMKDBF KAGPEGHHNBH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FMDFHEHDPPJ BNNFELKGANA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ABJHDBHDEKM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LBHOEOIILAN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<OBJADMFPMJH> ACFJJELGLHL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<OBJADMFPMJH> CIFFANAHOAI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action ADKLPIGOADK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<OBJADMFPMJH> HOLEFAJABAF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NJPHAMCIKMD(OBJADMFPMJH AAJANANFHLN, bool NOCMPIEOFCP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FOLDPEHOMLH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 PPMHLINFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 KAKKDFCIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDCGDHOAFOL(OBJADMFPMJH KMAENCDMJDN, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INJAGJNDDME(object OEELDHBFFAF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GNBHDEADFGP
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 JIBEMDPOGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NKHEICDPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CHFHCFNLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float PDGNJGENKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 HOBBFJCBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion CMEBOEMNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JIBAICMKDBF FFIOJLAGFAD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DDGKNGAHJFL((Quaternion rot, Vector3 moments) KEAIEABHOPH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JKFFMLHADFL();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJIFKEHOGFP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LFBJHLBLBPF();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDFHACHAABG();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PJGJBBEFOMP
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMHGOIGFFJC(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POHDMHOIGPB(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMANIKGLCEK(OBJADMFPMJH DGJECMOALOE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOFDAFAMLIO(OBJADMFPMJH DGJECMOALOE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLFCFIJBBEO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HLACGAEOOBN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool GGPDDMGENEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JIBAICMKDBF APDLPNCFNBK;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAOENGGNPGD(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFILENDOGBD(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIFDANPJPHH(object OEELDHBFFAF, bool GHLPIJPFEDO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BIOIMJFMMDH(Rigidbody EKAOOBAECFJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONGNJPHBDLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GLJAGCBNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FNNONNNMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JIBAICMKDBF KNAHBFFHDDL;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNKCPKBDEHH(OBJADMFPMJH KMAENCDMJDN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IEFPDJGKGGK(OBJADMFPMJH KMAENCDMJDN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GABFPCKLHNH
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ODFMFNHICOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OFNHGPPMICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints LPECEDODPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DBMCEOHMEEO
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float FFGBNMGCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float FMAENBBMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AAPCFFOMJDB
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JIBAICMKDBF BGDEBCFEJKC;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBKLFPKPOMA();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HBFPCBFOCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPABKONNCBM();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HNGDDDLPKMP();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BIEJNIFKODB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LJIHFPJGIJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JHMINGEBEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONLCBPFAFMM(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPBCCIHJINH(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NICCCHAJIEK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FAAPFDLIGNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	EAEHANAOBNM AFBAAJPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EFMMKCONAKN PNLCBHJMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 GMCDCOKFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 KNBHDMOLPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 IHGLKAFHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 CJDIOLOJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float OBNECJIFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JONIPFJBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HECGDIKDGOJ(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OGPDFMKJDFI(HOBGLFAGAKH GGCOHIKNBGE, Vector3 FODDDPLGLIO, float GANNKOJAILG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CJPBHAPNMFG(KFHHPEHINFA IGPGKDFNPIE, Vector3 MKNOEHKBNIG, float BJFBGGPKGPA, float EFMCFCCKEMH = 8f, float JBMOFLKNCDP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GGKLLBBNOAC(HOBGLFAGAKH GGCOHIKNBGE, Vector3 PCIAHIPKDFG, float IBHPJNLNOPM = 7f, float PAOBAPJMBLG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DHMAFDFHBIC();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JCANOFJDADK();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FIPFFHLOCEL();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EKHIMMNIPEL();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 DFEHIKEOCCH(Vector3 DPBIGMHBMBN);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DHNPOEGOCKO(object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HAHIILPKFJK(Vector3 KHPDDAPGGEM);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AABEDGLNCKP(Vector3 JJPPCHKBGCE, Vector3 NHLDMOEHBNF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GJMJHNCDPNG(Vector3 CMOABHDGOOA, Vector3 OFDEGDNPEGJ);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 EFPIBHDKJHO(Vector3 KDBAABAMFFN);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CCFOBGDNPCK(Vector3 MGCJLNPPEHB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface IDCEFCJKKHD
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool MAAGOEKHMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BONEAEHFBJC(string EJIIMGEBDBD);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBNBNAALFMF(RigidbodyEx DGJECMOALOE, Action GGEEGOKOMKJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDBCJKICNLJ DALFMEKJCMP(int GBFCKMKJNOB);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLGIDHPNMJB(Vector3 AODBHBPFPNF, float MNLMFKNAEPI, Color BJCIGJMGMBG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface JNPFMEMIKMB
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	IDCEFCJKKHD FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	BNKBIDNBHPE FOMJLKMEBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FHBJODFDMCI : OBJADMFPMJH, IDisposable, MFGJMNBKMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly JNPFMEMIKMB PEDEFMGDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal KKLOCIOOIJC CKMLNLJIJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal PJGJBBEFOMP IPMFJGHIJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal ONGNJPHBDLJ PDIDAIJMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FAAPFDLIGNJ DPBIGMHBMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FOLDPEHOMLH BKDLECPOBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal GNBHDEADFGP HFOOENAKPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DBMCEOHMEEO KPANIMPJIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LBPMOEBGIAB KBBAHCGPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal AAPCFFOMJDB CKMIBLBMCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal EAOMAANKAFE INOAGOLKLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal HLACGAEOOBN ICHOMIBNHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal FELHEFMEMFK LCIPAAAOEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal GABFPCKLHNH BIODJDMEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal LJIHFPJGIJD ODEHBHJNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal PLGADBDOOIG DFJDENEGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable MEGALHMFJBI;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "22")]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HFLALFLFNKL FIKFFPNBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x883D00", Offset = "0x882700", VA = "0x180883D00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x883E60", Offset = "0x882860", VA = "0x180883E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject HIHCJEHCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x92C030", Offset = "0x92AA30", VA = "0x18092C030", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x913BD0", Offset = "0x9125D0", VA = "0x180913BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x88EC20", Offset = "0x88D620", VA = "0x18088EC20", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x88EBD0", Offset = "0x88D5D0", VA = "0x18088EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7200380", Offset = "0x71FED80", VA = "0x187200380", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7203150", Offset = "0x7201B50", VA = "0x187203150", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7202780", Offset = "0x7201180", VA = "0x187202780", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NFJJMFLIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7202010", Offset = "0x7200A10", VA = "0x187202010", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public OBJADMFPMJH CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7204F60", Offset = "0x7203960", VA = "0x187204F60", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MHCELDGENCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x72053C0", Offset = "0x7203DC0", VA = "0x1872053C0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GLJAGCBNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x71FFA70", Offset = "0x71FE470", VA = "0x1871FFA70", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FNNONNNMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7205490", Offset = "0x7203E90", VA = "0x187205490", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EAEHANAOBNM AFBAAJPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7201720", Offset = "0x7200120", VA = "0x187201720", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x72031A0", Offset = "0x7201BA0", VA = "0x1872031A0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EFMMKCONAKN PNLCBHJMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x71FF9C0", Offset = "0x71FE3C0", VA = "0x1871FF9C0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7203BB0", Offset = "0x72025B0", VA = "0x187203BB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float OBNECJIFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7204070", Offset = "0x7202A70", VA = "0x187204070", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72041F0", Offset = "0x7202BF0", VA = "0x1872041F0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 KNBHDMOLPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7201420", Offset = "0x71FFE20", VA = "0x187201420", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7201640", Offset = "0x7200040", VA = "0x187201640", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 CJDIOLOJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7202C60", Offset = "0x7201660", VA = "0x187202C60", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7200F30", Offset = "0x71FF930", VA = "0x187200F30", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GMCDCOKFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x72036F0", Offset = "0x72020F0", VA = "0x1872036F0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7204840", Offset = "0x7203240", VA = "0x187204840", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 IHGLKAFHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7204250", Offset = "0x7202C50", VA = "0x187204250", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7201770", Offset = "0x7200170", VA = "0x187201770", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool KCMNBDEIGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7201FC0", Offset = "0x72009C0", VA = "0x187201FC0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool AFJEFEFBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7202840", Offset = "0x7201240", VA = "0x187202840", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PLAFMNFAGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7202DF0", Offset = "0x72017F0", VA = "0x187202DF0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JONIPFJBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7200620", Offset = "0x71FF020", VA = "0x187200620", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 PPMHLINFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7203830", Offset = "0x7202230", VA = "0x187203830", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 KAKKDFCIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7203390", Offset = "0x7201D90", VA = "0x187203390", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 JIBEMDPOGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x71FFEE0", Offset = "0x71FE8E0", VA = "0x1871FFEE0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7200D40", Offset = "0x71FF740", VA = "0x187200D40", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 NKHEICDPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7204C80", Offset = "0x7203680", VA = "0x187204C80", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CHFHCFNLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7202A60", Offset = "0x7201460", VA = "0x187202A60", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float PDGNJGENKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72003D0", Offset = "0x71FEDD0", VA = "0x1872003D0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72043E0", Offset = "0x7202DE0", VA = "0x1872043E0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 HOBBFJCBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7202ED0", Offset = "0x72018D0", VA = "0x187202ED0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion CMEBOEMNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7203F50", Offset = "0x7202950", VA = "0x187203F50", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float FFGBNMGCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x72047F0", Offset = "0x72031F0", VA = "0x1872047F0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7204FB0", Offset = "0x72039B0", VA = "0x187204FB0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float FMAENBBMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7202DA0", Offset = "0x72017A0", VA = "0x187202DA0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7203520", Offset = "0x7201F20", VA = "0x187203520", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BNPFHDHMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7200420", Offset = "0x71FEE20", VA = "0x187200420", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72027E0", Offset = "0x72011E0", VA = "0x1872027E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JGCAFIGAFFP JCGDEDNKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x71FFDD0", Offset = "0x71FE7D0", VA = "0x1871FFDD0", Slot = "68")]
		get
		{
			return default(JGCAFIGAFFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7202BA0", Offset = "0x72015A0", VA = "0x187202BA0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GGPDDMGENEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7201140", Offset = "0x71FFB40", VA = "0x187201140", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform FEAFHMIFNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x88EC20", Offset = "0x88D620", VA = "0x18088EC20", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 MNAPKDBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7200070", Offset = "0x71FEA70", VA = "0x187200070", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x71FFFC0", Offset = "0x71FE9C0", VA = "0x1871FFFC0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float BNGJEHMADBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7203200", Offset = "0x7201C00", VA = "0x187203200", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7205420", Offset = "0x7203E20", VA = "0x187205420", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float PMNNJADHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x72035E0", Offset = "0x7201FE0", VA = "0x1872035E0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7203A00", Offset = "0x7202400", VA = "0x187203A00", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion IHFEKLBPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7203DF0", Offset = "0x72027F0", VA = "0x187203DF0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7203C10", Offset = "0x7202610", VA = "0x187203C10", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 AIFDJMPCLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x71FFAC0", Offset = "0x71FE4C0", VA = "0x1871FFAC0", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7202330", Offset = "0x7200D30", VA = "0x187202330", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion HCLPIOBIAKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72036B0", Offset = "0x72020B0", VA = "0x1872036B0", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72047C0", Offset = "0x72031C0", VA = "0x1872047C0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints LPECEDODPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7202080", Offset = "0x7200A80", VA = "0x187202080", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x71FFA10", Offset = "0x71FE410", VA = "0x1871FFA10", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool ODFMFNHICOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7200280", Offset = "0x71FEC80", VA = "0x187200280", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7204380", Offset = "0x7202D80", VA = "0x187204380", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode JENKMMFDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x72005D0", Offset = "0x71FEFD0", VA = "0x1872005D0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7202C00", Offset = "0x7201600", VA = "0x187202C00", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool HOJLMMDILAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x72021F0", Offset = "0x7200BF0", VA = "0x1872021F0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool APKDHMBELGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7201E40", Offset = "0x7200840", VA = "0x187201E40", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JIBAICMKDBF PLLJDLBDCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7200A30", Offset = "0x71FF430", VA = "0x187200A30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x71FF960", Offset = "0x71FE360", VA = "0x1871FF960", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JIBAICMKDBF KAGPEGHHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7204760", Offset = "0x7203160", VA = "0x187204760", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7204BC0", Offset = "0x72035C0", VA = "0x187204BC0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FMDFHEHDPPJ BNNFELKGANA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72030F0", Offset = "0x7201AF0", VA = "0x1872030F0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72040C0", Offset = "0x7202AC0", VA = "0x1872040C0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JIBAICMKDBF KNAHBFFHDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x71FFE20", Offset = "0x71FE820", VA = "0x1871FFE20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7203470", Offset = "0x7201E70", VA = "0x187203470", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event JIBAICMKDBF HELFJJFGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7202D40", Offset = "0x7201740", VA = "0x187202D40", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7200B40", Offset = "0x71FF540", VA = "0x187200B40", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event JIBAICMKDBF BGDEBCFEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7203580", Offset = "0x7201F80", VA = "0x187203580", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7201A70", Offset = "0x7200470", VA = "0x187201A70", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HDLBMLPIHPN, HDLBMLPIHPN> LNMNLFIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7203210", Offset = "0x7201C10", VA = "0x187203210", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7200470", Offset = "0x71FEE70", VA = "0x187200470", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event JIBAICMKDBF APDLPNCFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7204C20", Offset = "0x7203620", VA = "0x187204C20", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7205110", Offset = "0x7203B10", VA = "0x187205110", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JIBAICMKDBF HIFBEIGFKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7200A90", Offset = "0x71FF490", VA = "0x187200A90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x72029B0", Offset = "0x72013B0", VA = "0x1872029B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72057E0", Offset = "0x72041E0", VA = "0x1872057E0")]
	public FHBJODFDMCI(GameObject BICFCMICGIH, RigidbodyEx LLNAKALPLPF, JNPFMEMIKMB PEDEFMGDCEP, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7202490", Offset = "0x7200E90", VA = "0x187202490", Slot = "136")]
	protected virtual void GCLPLDELGEL(JNPFMEMIKMB PEDEFMGDCEP, AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7201850", Offset = "0x7200250", VA = "0x187201850", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7205660", Offset = "0x7204060", VA = "0x187205660", Slot = "91")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7201A20", Offset = "0x7200420", VA = "0x187201A20", Slot = "92")]
	public void IDNHGDBOGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7202370", Offset = "0x7200D70", VA = "0x187202370", Slot = "93")]
	public void GCFKKEGNCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72020D0", Offset = "0x7200AD0", VA = "0x1872020D0")]
	private void FHCPNFEMDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7204120", Offset = "0x7202B20", VA = "0x187204120", Slot = "30")]
	public OBJADMFPMJH LNHPKHIMEPL(int ENMILGHAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7204A00", Offset = "0x7203400", VA = "0x187204A00", Slot = "95")]
	public void NJPHAMCIKMD(OBJADMFPMJH IPHMAHBENGI, bool NOCMPIEOFCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7201370", Offset = "0x71FFD70", VA = "0x187201370", Slot = "96")]
	public void DFNBBBAMPMM(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x71FFE80", Offset = "0x71FE880", VA = "0x1871FFE80", Slot = "97")]
	public void BAAGALPHEMH(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x72004D0", Offset = "0x71FEED0", VA = "0x1872004D0", Slot = "98")]
	public Vector3 CCFOBGDNPCK(Vector3 MGCJLNPPEHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7201920", Offset = "0x7200320", VA = "0x187201920", Slot = "99")]
	public Vector3 EFPIBHDKJHO(Vector3 KDBAABAMFFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7201A20", Offset = "0x7200420", VA = "0x187201A20", Slot = "100")]
	public void EKHIMMNIPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x72034D0", Offset = "0x7201ED0", VA = "0x1872034D0", Slot = "101")]
	public void JCANOFJDADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x72013D0", Offset = "0x71FFDD0", VA = "0x1872013D0", Slot = "102")]
	public void DHMAFDFHBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7202AB0", Offset = "0x72014B0", VA = "0x187202AB0", Slot = "103")]
	public void GJMJHNCDPNG(Vector3 CMOABHDGOOA, Vector3 OFDEGDNPEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71FF870", Offset = "0x71FE270", VA = "0x1871FF870", Slot = "104")]
	public void AABEDGLNCKP(Vector3 JJPPCHKBGCE, Vector3 NHLDMOEHBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7202FB0", Offset = "0x72019B0", VA = "0x187202FB0", Slot = "105")]
	public void HAHIILPKFJK(Vector3 KHPDDAPGGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7200BA0", Offset = "0x71FF5A0", VA = "0x187200BA0", Slot = "106")]
	public void CJPBHAPNMFG(KFHHPEHINFA IGPGKDFNPIE, Vector3 MKNOEHKBNIG, float BJFBGGPKGPA, float EFMCFCCKEMH = 8f, float JBMOFLKNCDP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7205010", Offset = "0x7203A10", VA = "0x187205010", Slot = "107")]
	public void OGPDFMKJDFI(HOBGLFAGAKH GGCOHIKNBGE, Vector3 FODDDPLGLIO, float GANNKOJAILG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72028A0", Offset = "0x72012A0", VA = "0x1872028A0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GGKLLBBNOAC(HOBGLFAGAKH GGCOHIKNBGE, Vector3 PCIAHIPKDFG, float IBHPJNLNOPM = 7f, float PAOBAPJMBLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7201270", Offset = "0x71FFC70", VA = "0x187201270", Slot = "109")]
	public Vector3 DFEHIKEOCCH(Vector3 IPHMAHBENGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7203900", Offset = "0x7202300", VA = "0x187203900", Slot = "110")]
	public Vector3 KHKLOIIMINK(Vector3 IPHMAHBENGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7202150", Offset = "0x7200B50", VA = "0x187202150", Slot = "111")]
	public void FIPFFHLOCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72010D0", Offset = "0x71FFAD0", VA = "0x1872010D0", Slot = "112")]
	public void DBDOCPIAHDH(OBJADMFPMJH HBPBPEHMMEK, object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7201070", Offset = "0x71FFA70", VA = "0x187201070", Slot = "113")]
	public void CPFOJOCHHKB(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7201190", Offset = "0x71FFB90", VA = "0x187201190", Slot = "61")]
	public void DDGKNGAHJFL((Quaternion rot, Vector3 moments) KEAIEABHOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72021A0", Offset = "0x7200BA0", VA = "0x1872021A0", Slot = "114")]
	public void FJIFKEHOGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7203660", Offset = "0x7202060", VA = "0x187203660", Slot = "115")]
	public void JKFFMLHADFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7204020", Offset = "0x7202A20", VA = "0x187204020", Slot = "116")]
	public void LFBJHLBLBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x72041A0", Offset = "0x7202BA0", VA = "0x1872041A0", Slot = "117")]
	public bool MBKLFPKPOMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x72052B0", Offset = "0x7203CB0", VA = "0x1872052B0", Slot = "94")]
	public void OPABKONNCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7200230", Offset = "0x71FEC30", VA = "0x187200230", Slot = "118")]
	public void BIEJNIFKODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7203090", Offset = "0x7201A90", VA = "0x187203090", Slot = "119")]
	public void HAOENGGNPGD(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72037D0", Offset = "0x72021D0", VA = "0x1872037D0", Slot = "120")]
	public void KFILENDOGBD(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72035F0", Offset = "0x7201FF0", VA = "0x1872035F0", Slot = "121")]
	public void JIFDANPJPHH(object OEELDHBFFAF, bool GHLPIJPFEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7204D60", Offset = "0x7203760", VA = "0x187204D60", Slot = "122")]
	public void NPNMAPDDIKF(Vector3 MMHKIDDFEKP, Quaternion NMANLJPNBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7201500", Offset = "0x71FFF00", VA = "0x187201500", Slot = "123")]
	public void DIFGLEKFDDM(Vector3 JJPDKKMDNGG, Quaternion EKPDAGMGKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7204330", Offset = "0x7202D30", VA = "0x187204330", Slot = "124")]
	public bool MFGHFCBEFBK(float IBDBBIJPGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7203E90", Offset = "0x7202890", VA = "0x187203E90", Slot = "125")]
	public void LCHCEDDLHNE(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7203EF0", Offset = "0x72028F0", VA = "0x187203EF0", Slot = "126")]
	public void LCIKPFAJPFD(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7205250", Offset = "0x7203C50", VA = "0x187205250", Slot = "127")]
	public void ONLCBPFAFMM(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7201010", Offset = "0x71FFA10", VA = "0x187201010", Slot = "128")]
	public void CPBCCIHJINH(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7205170", Offset = "0x7203B70", VA = "0x187205170", Slot = "129")]
	public void OHFFLMGGOEE(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7200E20", Offset = "0x71FF820", VA = "0x187200E20", Slot = "130")]
	public void CNBEAJFIEBH(Vector3 LCIPAAAOEPD, Vector3 EJEBFMEPKGF, ForceMode COIAPCCPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x71FFCF0", Offset = "0x71FE6F0", VA = "0x1871FFCF0", Slot = "131")]
	public void AHEIBOGMLPO(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7204920", Offset = "0x7203320", VA = "0x187204920", Slot = "132")]
	public void NBGIFGNIIII(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7203CF0", Offset = "0x72026F0", VA = "0x187203CF0", Slot = "133")]
	public bool LBJCAILECDJ(Vector3 FJODMBFILLK, [Out] RaycastHit NJKLEFHEHBB, float PEAKDEKJAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7203270", Offset = "0x7201C70", VA = "0x187203270", Slot = "134")]
	public void IDFHACHAABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72057A0", Offset = "0x72041A0", VA = "0x1872057A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7200C60", Offset = "0x71FF660", VA = "0x187200C60")]
	private void CLAPEIPLBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7200120", Offset = "0x71FEB20", VA = "0x187200120")]
	private void BHPFBBMGEII(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x71FFB00", Offset = "0x71FE500", VA = "0x1871FFB00")]
	private void AGOFENIAHFN(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72002D0", Offset = "0x71FECD0", VA = "0x1872002D0")]
	private void BLNENBLMLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7202390", Offset = "0x7200D90", VA = "0x187202390")]
	private void GCHBDNKDOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72054E0", Offset = "0x7203EE0", VA = "0x1872054E0")]
	private void PNAKNILEKAE(OBJADMFPMJH OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7203AE0", Offset = "0x72024E0", VA = "0x187203AE0")]
	private void KNKCPKBDEHH(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72032C0", Offset = "0x7201CC0", VA = "0x1872032C0")]
	private void IEFPDJGKGGK(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7204A70", Offset = "0x7203470", VA = "0x187204A70")]
	private void NMFONNINAPK(HFLALFLFNKL KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7200670", Offset = "0x71FF070", VA = "0x187200670", Slot = "141")]
	protected virtual void CFGBCKFLBKG(HFLALFLFNKL DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7204440", Offset = "0x7202E40", VA = "0x187204440")]
	protected void MLKLBBACDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7201AD0", Offset = "0x72004D0", VA = "0x187201AD0")]
	protected void ENABEDGJBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7205300", Offset = "0x7203D00", VA = "0x187205300", Slot = "142")]
	protected virtual IDisposable PAGDDJBCHCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class IPKAGGDFEPI
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7207BF0", Offset = "0x72065F0", VA = "0x187207BF0")]
	public static OBJADMFPMJH IJCFCJHFOHN(this OBJADMFPMJH DGJECMOALOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7207B70", Offset = "0x7206570", VA = "0x187207B70")]
	public static bool GOPEBENKNAD(this OBJADMFPMJH DGJECMOALOE, OBJADMFPMJH KNFGKJMJFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7207CB0", Offset = "0x72066B0", VA = "0x187207CB0")]
	public static bool MNBLILMIKBD(this OBJADMFPMJH DGJECMOALOE, OBJADMFPMJH PMHHELHJDLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7207D30", Offset = "0x7206730", VA = "0x187207D30")]
	public static HFLALFLFNKL MPICFLIJLBO(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7207AF0", Offset = "0x72064F0", VA = "0x187207AF0")]
	public static FHBJODFDMCI FOLMMECEPAA(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CNNOEOOEHNJ : BNKBIDNBHPE
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x71FC310", Offset = "0x71FAD10", VA = "0x1871FC310", Slot = "19")]
	public OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF, JNPFMEMIKMB PEDEFMGDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "4")]
	public KKLOCIOOIJC EENJBLIKKMF(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "5")]
	public FAAPFDLIGNJ FMLPMPELCJB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "6")]
	public FOLDPEHOMLH HIKKPJLHLGG(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "7")]
	public DBMCEOHMEEO GOKLOCDCNDB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "8")]
	public AAPCFFOMJDB GIHFAAODADA(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "9")]
	public EAOMAANKAFE ICEMKNKAJGO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "10")]
	public HLACGAEOOBN PBBJBHGLNPC(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "11")]
	public FELHEFMEMFK CAHLOKOGPIO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "12")]
	public PLGADBDOOIG PEAKILADGLB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "13")]
	public LBPMOEBGIAB KLDACFCOKGE(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	public LJIHFPJGIJD CGPBNIABIFD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	public ONGNJPHBDLJ GPMNFFKENOB(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	public PJGJBBEFOMP POIGFIMACNI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	public GNBHDEADFGP HEPKIPELFOA(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	public GABFPCKLHNH ICBANGCPNEN(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public CNNOEOOEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "14")]
	private LJIHFPJGIJD DHMJANICFLK(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "15")]
	private ONGNJPHBDLJ PNMFNHMLHJI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "16")]
	private PJGJBBEFOMP OCICEHEPAJM(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "17")]
	private GNBHDEADFGP AKGODDKMEGD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "18")]
	private GABFPCKLHNH GJFBCPBNIPL(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HFJNCABCFLK(typeof(BNKBIDNBHPE), new string[] { })]
public class MLLLBMLLJNJ : BNKBIDNBHPE, AGOPHKGBOPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly BNKBIDNBHPE CBNOOCEGAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly BNKBIDNBHPE INDKBPJONOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private KNKBCNKBMPM PJCMNKAAOIH;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private BNKBIDNBHPE FOMJLKMEBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x720E040", Offset = "0x720CA40", VA = "0x18720E040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x720DD50", Offset = "0x720C750", VA = "0x18720DD50", Slot = "20")]
	public void InitReferences(BEMAECNLOEH PFGCONMFOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x720D830", Offset = "0x720C230", VA = "0x18720D830", Slot = "4")]
	public KKLOCIOOIJC EENJBLIKKMF(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x720D8D0", Offset = "0x720C2D0", VA = "0x18720D8D0", Slot = "5")]
	public FAAPFDLIGNJ FMLPMPELCJB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x720DC10", Offset = "0x720C610", VA = "0x18720DC10", Slot = "6")]
	public FOLDPEHOMLH HIKKPJLHLGG(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x720DAC0", Offset = "0x720C4C0", VA = "0x18720DAC0", Slot = "7")]
	public DBMCEOHMEEO GOKLOCDCNDB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x720D970", Offset = "0x720C370", VA = "0x18720D970", Slot = "8")]
	public AAPCFFOMJDB GIHFAAODADA(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x720DCB0", Offset = "0x720C6B0", VA = "0x18720DCB0", Slot = "9")]
	public EAOMAANKAFE ICEMKNKAJGO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x720E0A0", Offset = "0x720CAA0", VA = "0x18720E0A0", Slot = "10")]
	public HLACGAEOOBN PBBJBHGLNPC(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x720D6E0", Offset = "0x720C0E0", VA = "0x18720D6E0", Slot = "11")]
	public FELHEFMEMFK CAHLOKOGPIO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x720E140", Offset = "0x720CB40", VA = "0x18720E140", Slot = "12")]
	public PLGADBDOOIG PEAKILADGLB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x720DDA0", Offset = "0x720C7A0", VA = "0x18720DDA0", Slot = "13")]
	public LBPMOEBGIAB KLDACFCOKGE(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x720D780", Offset = "0x720C180", VA = "0x18720D780")]
	public LJIHFPJGIJD CGPBNIABIFD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x720DB60", Offset = "0x720C560", VA = "0x18720DB60")]
	public ONGNJPHBDLJ GPMNFFKENOB(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x720DF90", Offset = "0x720C990", VA = "0x18720DF90")]
	public PJGJBBEFOMP POIGFIMACNI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x720D630", Offset = "0x720C030", VA = "0x18720D630")]
	public GNBHDEADFGP HEPKIPELFOA(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x720DA10", Offset = "0x720C410", VA = "0x18720DA10")]
	public GABFPCKLHNH ICBANGCPNEN(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x720DE40", Offset = "0x720C840", VA = "0x18720DE40", Slot = "19")]
	public OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF, JNPFMEMIKMB PEDEFMGDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x720E1E0", Offset = "0x720CBE0", VA = "0x18720E1E0")]
	public MLLLBMLLJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x720D780", Offset = "0x720C180", VA = "0x18720D780", Slot = "14")]
	private LJIHFPJGIJD DHMJANICFLK(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x720DB60", Offset = "0x720C560", VA = "0x18720DB60", Slot = "15")]
	private ONGNJPHBDLJ PNMFNHMLHJI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x720DF90", Offset = "0x720C990", VA = "0x18720DF90", Slot = "16")]
	private PJGJBBEFOMP OCICEHEPAJM(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x720D630", Offset = "0x720C030", VA = "0x18720D630", Slot = "17")]
	private GNBHDEADFGP AKGODDKMEGD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x720DA10", Offset = "0x720C410", VA = "0x18720DA10", Slot = "18")]
	private GABFPCKLHNH GJFBCPBNIPL(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CCHGDIJJKDI : KKLOCIOOIJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBLGBIHLLBM(OBJADMFPMJH DGJECMOALOE);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMHGNMEIMPN(OBJADMFPMJH DGJECMOALOE);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMJAOPHCPMO(OBJADMFPMJH OBDDDPBKGNK);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMMOAHNLEPM(OBJADMFPMJH OBDDDPBKGNK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NEMDKMPIFFN : FOLDPEHOMLH
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	BCJFGAIKODP<OBJADMFPMJH> ILIAILCCHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	OBJADMFPMJH HHCJLEIBLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BPPMDDKCDEH : GNBHDEADFGP
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PNGMNEJKPKK(Rigidbody NJPFPAFIHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CGDHAEEJCPH : ONGNJPHBDLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView IHENDNHDJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BJAIHGNEHBL : PLGADBDOOIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode HEDHHOJBLEO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x71F9360", Offset = "0x71F7D60", VA = "0x1871F9360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode JENKMMFDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x71F93B0", Offset = "0x71F7DB0", VA = "0x1871F93B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x71F94C0", Offset = "0x71F7EC0", VA = "0x1871F94C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x71F98E0", Offset = "0x71F82E0", VA = "0x1871F98E0")]
	public BJAIHGNEHBL(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x71F97D0", Offset = "0x71F81D0", VA = "0x1871F97D0", Slot = "6")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x71F92E0", Offset = "0x71F7CE0", VA = "0x1871F92E0", Slot = "9")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x71F9530", Offset = "0x71F7F30", VA = "0x1871F9530", Slot = "7")]
	public void HCGLDIBBDIE(bool BHHJMGOHDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x71F97C0", Offset = "0x71F81C0", VA = "0x1871F97C0", Slot = "8")]
	public void NNNPGLLJLCJ(bool BHHJMGOHDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x71F9660", Offset = "0x71F8060", VA = "0x1871F9660", Slot = "10")]
	public bool LBJCAILECDJ(Vector3 FJODMBFILLK, [Out] RaycastHit NJKLEFHEHBB, float PEAKDEKJAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x71F9540", Offset = "0x71F7F40", VA = "0x1871F9540")]
	private void KHALPANKFMM(bool BHHJMGOHDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DFLILMAPBFD : EAOMAANKAFE, IDisposable, FNJKPCHPEGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private JGCAFIGAFFP ICEBJPLLDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private IDBCJKICNLJ PNLKLIOMHIG;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JGCAFIGAFFP JCGDEDNKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x71FC3B0", Offset = "0x71FADB0", VA = "0x1871FC3B0", Slot = "6")]
		get
		{
			return default(JGCAFIGAFFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x71FC620", Offset = "0x71FB020", VA = "0x1871FC620", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform EGPGJIOMLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x71FC600", Offset = "0x71FB000", VA = "0x1871FC600", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HDLBMLPIHPN, HDLBMLPIHPN> LNMNLFIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x71FC6F0", Offset = "0x71FB0F0", VA = "0x1871FC6F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71FC500", Offset = "0x71FAF00", VA = "0x1871FC500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x71FCA20", Offset = "0x71FB420", VA = "0x1871FCA20")]
	public DFLILMAPBFD(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x71FC7A0", Offset = "0x71FB1A0", VA = "0x1871FC7A0", Slot = "8")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x71FC5B0", Offset = "0x71FAFB0", VA = "0x1871FC5B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xBCF340", Offset = "0xBCDD40", VA = "0x180BCF340", Slot = "11")]
	private void NIIIJLHMLNH(HDLBMLPIHPN KEMJDCKCHMC, HDLBMLPIHPN PDPCPICHGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "12")]
	private void OFNMAHLDACO(bool ELHHPBLDOIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GHHBPAJABOP : BNKBIDNBHPE
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7206480", Offset = "0x7204E80", VA = "0x187206480", Slot = "4")]
	public KKLOCIOOIJC EENJBLIKKMF(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7206570", Offset = "0x7204F70", VA = "0x187206570", Slot = "5")]
	public FAAPFDLIGNJ FMLPMPELCJB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7206A60", Offset = "0x7205460", VA = "0x187206A60", Slot = "6")]
	public FOLDPEHOMLH HIKKPJLHLGG(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7206850", Offset = "0x7205250", VA = "0x187206850", Slot = "7")]
	public DBMCEOHMEEO GOKLOCDCNDB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x72066A0", Offset = "0x72050A0", VA = "0x1872066A0", Slot = "8")]
	public AAPCFFOMJDB GIHFAAODADA(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7206B90", Offset = "0x7205590", VA = "0x187206B90", Slot = "9")]
	public EAOMAANKAFE ICEMKNKAJGO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7206FA0", Offset = "0x72059A0", VA = "0x187206FA0", Slot = "10")]
	public HLACGAEOOBN PBBJBHGLNPC(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7206280", Offset = "0x7204C80", VA = "0x187206280", Slot = "11")]
	public FELHEFMEMFK CAHLOKOGPIO(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x72070C0", Offset = "0x7205AC0", VA = "0x1872070C0", Slot = "12")]
	public PLGADBDOOIG PEAKILADGLB(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7206C60", Offset = "0x7205660", VA = "0x187206C60", Slot = "13")]
	public LBPMOEBGIAB KLDACFCOKGE(OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7206340", Offset = "0x7204D40", VA = "0x187206340")]
	public LJIHFPJGIJD CGPBNIABIFD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x72068D0", Offset = "0x72052D0", VA = "0x1872068D0")]
	public ONGNJPHBDLJ GPMNFFKENOB(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7206E70", Offset = "0x7205870", VA = "0x187206E70")]
	public PJGJBBEFOMP POIGFIMACNI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x72060F0", Offset = "0x7204AF0", VA = "0x1872060F0")]
	public GNBHDEADFGP HEPKIPELFOA(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7206770", Offset = "0x7205170", VA = "0x187206770")]
	public GABFPCKLHNH ICBANGCPNEN(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7206D20", Offset = "0x7205720", VA = "0x187206D20", Slot = "19")]
	public OBJADMFPMJH MOMEILIGMEO(RigidbodyEx DGJECMOALOE, AIPJCHOFLBG LNCKNHNHHDF, JNPFMEMIKMB PEDEFMGDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GHHBPAJABOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7206340", Offset = "0x7204D40", VA = "0x187206340", Slot = "14")]
	private LJIHFPJGIJD DHMJANICFLK(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x72068D0", Offset = "0x72052D0", VA = "0x1872068D0", Slot = "15")]
	private ONGNJPHBDLJ PNMFNHMLHJI(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7206E70", Offset = "0x7205870", VA = "0x187206E70", Slot = "16")]
	private PJGJBBEFOMP OCICEHEPAJM(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x72060F0", Offset = "0x7204AF0", VA = "0x1872060F0", Slot = "17")]
	private GNBHDEADFGP AKGODDKMEGD(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7206770", Offset = "0x7205170", VA = "0x187206770", Slot = "18")]
	private GABFPCKLHNH GJFBCPBNIPL(OBJADMFPMJH KCEPABIAINB, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class FGCLEHCDJFC : FELHEFMEMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x71F9360", Offset = "0x71F7D60", VA = "0x1871F9360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool GGPDDMGENEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x71FF140", Offset = "0x71FDB40", VA = "0x1871FF140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool MHCELDGENCE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x71FF810", Offset = "0x71FE210", VA = "0x1871FF810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x71FF190", Offset = "0x71FDB90", VA = "0x1871FF190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x71F98E0", Offset = "0x71F82E0", VA = "0x1871F98E0")]
	public FGCLEHCDJFC(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x71FF6B0", Offset = "0x71FE0B0", VA = "0x1871FF6B0", Slot = "4")]
	public void OHFFLMGGOEE(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x71FEC60", Offset = "0x71FD660", VA = "0x1871FEC60")]
	private void CBIDNHKCLHM(Vector3 LCIPAAAOEPD, ForceMode COIAPCCPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x71FEEC0", Offset = "0x71FD8C0", VA = "0x1871FEEC0", Slot = "5")]
	public void CNBEAJFIEBH(Vector3 LCIPAAAOEPD, Vector3 EJEBFMEPKGF, ForceMode COIAPCCPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x71FEB00", Offset = "0x71FD500", VA = "0x1871FEB00", Slot = "6")]
	public void AHEIBOGMLPO(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x71FF1F0", Offset = "0x71FDBF0", VA = "0x1871FF1F0")]
	private void HEKFNJCJMPD(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x71FF450", Offset = "0x71FDE50", VA = "0x1871FF450", Slot = "7")]
	public void NBGIFGNIIII(Vector3 LPAGCBFLEJB, ForceMode COIAPCCPMKA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class FLAPPNPPACI : LBPMOEBGIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool BPJEPAIPEFG;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BNPFHDHMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7205B90", Offset = "0x7204590", VA = "0x187205B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x71F98E0", Offset = "0x71F82E0", VA = "0x1871F98E0")]
	public FLAPPNPPACI(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7205AF0", Offset = "0x72044F0", VA = "0x187205AF0", Slot = "6")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7205B20", Offset = "0x7204520", VA = "0x187205B20", Slot = "7")]
	public void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ECEMAILHEEF : CCHGDIJJKDI, KKLOCIOOIJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OBJADMFPMJH DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<OBJADMFPMJH> ANNNGFKCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OBJADMFPMJH BAFHJDFHJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private OBJADMFPMJH KMAENCDMJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform FIOPDECIOEA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x71FD1D0", Offset = "0x71FBBD0", VA = "0x1871FD1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x88B1C0", Offset = "0x889BC0", VA = "0x18088B1C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x71FD550", Offset = "0x71FBF50", VA = "0x1871FD550", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public OBJADMFPMJH CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x88B270", Offset = "0x889C70", VA = "0x18088B270", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<OBJADMFPMJH> CAMGNEHBANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x88C420", Offset = "0x88AE20", VA = "0x18088C420", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JIBAICMKDBF PLLJDLBDCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x71FCD80", Offset = "0x71FB780", VA = "0x1871FCD80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x71FCC40", Offset = "0x71FB640", VA = "0x1871FCC40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JIBAICMKDBF KAGPEGHHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x71FDDC0", Offset = "0x71FC7C0", VA = "0x1871FDDC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x71FE550", Offset = "0x71FCF50", VA = "0x1871FE550", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FMDFHEHDPPJ BNNFELKGANA
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x71FD600", Offset = "0x71FC000", VA = "0x1871FD600", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x71FDC80", Offset = "0x71FC680", VA = "0x1871FDC80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ABJHDBHDEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x71FD9B0", Offset = "0x71FC3B0", VA = "0x1871FD9B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x71FD230", Offset = "0x71FBC30", VA = "0x1871FD230", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action LBHOEOIILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x71FD6A0", Offset = "0x71FC0A0", VA = "0x1871FD6A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x71FCCE0", Offset = "0x71FB6E0", VA = "0x1871FCCE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<OBJADMFPMJH> ACFJJELGLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x71FCED0", Offset = "0x71FB8D0", VA = "0x1871FCED0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x71FDA50", Offset = "0x71FC450", VA = "0x1871FDA50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<OBJADMFPMJH> CIFFANAHOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x71FDE60", Offset = "0x71FC860", VA = "0x1871FDE60", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x71FE690", Offset = "0x71FD090", VA = "0x1871FE690", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action ADKLPIGOADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x71FE5F0", Offset = "0x71FCFF0", VA = "0x1871FE5F0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x71FDD20", Offset = "0x71FC720", VA = "0x1871FDD20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<OBJADMFPMJH> HOLEFAJABAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x71FE990", Offset = "0x71FD390", VA = "0x1871FE990", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x71FCE20", Offset = "0x71FB820", VA = "0x1871FCE20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x71FEA40", Offset = "0x71FD440", VA = "0x1871FEA40")]
	public ECEMAILHEEF(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x71FD020", Offset = "0x71FBA20", VA = "0x1871FD020", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x71FDF10", Offset = "0x71FC910", VA = "0x1871FDF10", Slot = "30")]
	public void NJPHAMCIKMD(OBJADMFPMJH AAJANANFHLN, bool NOCMPIEOFCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x71FD740", Offset = "0x71FC140", VA = "0x1871FD740", Slot = "6")]
	public void HMJAOPHCPMO(OBJADMFPMJH OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x71FD2D0", Offset = "0x71FBCD0", VA = "0x1871FD2D0", Slot = "7")]
	public void FMMOAHNLEPM(OBJADMFPMJH OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x71FD0C0", Offset = "0x71FBAC0", VA = "0x1871FD0C0", Slot = "4")]
	public void EBLGBIHLLBM(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x71FD560", Offset = "0x71FBF60", VA = "0x1871FD560", Slot = "5")]
	public void GMHGNMEIMPN(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x71FCF80", Offset = "0x71FB980", VA = "0x1871FCF80")]
	private void DDDCCBDGOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x71FDB00", Offset = "0x71FC500", VA = "0x1871FDB00")]
	private void KMFNKCJKJCK(OBJADMFPMJH OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x71FDB40", Offset = "0x71FC540", VA = "0x1871FDB40")]
	private void LGICIJFPPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x71FE860", Offset = "0x71FD260", VA = "0x1871FE860")]
	private void PCGGMKMOAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x71FE740", Offset = "0x71FD140", VA = "0x1871FE740")]
	private void OFHJDLDIHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x71FE490", Offset = "0x71FCE90", VA = "0x1871FE490")]
	[CompilerGenerated]
	private object NLMFPNIBOHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class GABBLDNKFMB
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7205F70", Offset = "0x7204970", VA = "0x187205F70")]
	public static CCHGDIJJKDI FCJKIIMGIJB(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class BHHJHPKGIAP : NEMDKMPIFFN, FOLDPEHOMLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BCJFGAIKODP<OBJADMFPMJH> HDFICBMIGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KMKMPCHFJDK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BCJFGAIKODP<OBJADMFPMJH> ILIAILCCHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 PPMHLINFJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x71F9090", Offset = "0x71F7A90", VA = "0x1871F9090", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 KAKKDFCIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x71F8D80", Offset = "0x71F7780", VA = "0x1871F8D80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 GMCDCOKFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x71F8FA0", Offset = "0x71F79A0", VA = "0x1871F8FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public OBJADMFPMJH HHCJLEIBLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x71F9130", Offset = "0x71F7B30", VA = "0x1871F9130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x71F91E0", Offset = "0x71F7BE0", VA = "0x1871F91E0")]
	public BHHJHPKGIAP(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x71F90C0", Offset = "0x71F7AC0", VA = "0x1871F90C0", Slot = "8")]
	public void NDCGDHOAFOL(OBJADMFPMJH KMAENCDMJDN, object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x71F8F40", Offset = "0x71F7940", VA = "0x1871F8F40", Slot = "9")]
	public void INJAGJNDDME(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x71F8670", Offset = "0x71F7070", VA = "0x1871F8670")]
	private Vector3 FLIEFEOMJNA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x71F89F0", Offset = "0x71F73F0", VA = "0x1871F89F0")]
	private void HFFJGOKBHCN(OBJADMFPMJH PHIPOLIPDGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class GFDFEHGFFAD
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7206030", Offset = "0x7204A30", VA = "0x187206030")]
	public static NEMDKMPIFFN LHOMGJKGLNC(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BKCGFMCOKEB : BPPMDDKCDEH, GNBHDEADFGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 JEJOBFHBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 PCIJHHCOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float MJBKJCHOPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float ELNCKLJNHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 FKOLFMJGGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? BEDBAGAOPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? PEAAMJLAGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool DGKKKLGMEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool HPCDBJGMDDJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JIBEMDPOGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xFA5290", Offset = "0xFA3C90", VA = "0x180FA5290", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x71F9B40", Offset = "0x71F8540", VA = "0x1871F9B40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 NKHEICDPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x71FAF20", Offset = "0x71F9920", VA = "0x1871FAF20", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CHFHCFNLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0D0", Offset = "0xAAAAD0", VA = "0x180AAC0D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x71FA4C0", Offset = "0x71F8EC0", VA = "0x1871FA4C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float PDGNJGENKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0C0", Offset = "0xAAAAC0", VA = "0x180AAC0C0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x71FAA60", Offset = "0x71F9460", VA = "0x1871FAA60", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 HOBBFJCBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x71FA330", Offset = "0x71F8D30", VA = "0x1871FA330", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion CMEBOEMNIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x71FABF0", Offset = "0x71F95F0", VA = "0x1871FABF0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x71F9AF0", Offset = "0x71F84F0", VA = "0x1871F9AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event JIBAICMKDBF FFIOJLAGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x71F9970", Offset = "0x71F8370", VA = "0x1871F9970", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x71FB010", Offset = "0x71F9A10", VA = "0x1871FB010", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x71FC1B0", Offset = "0x71FABB0", VA = "0x1871FC1B0")]
	public BKCGFMCOKEB(OBJADMFPMJH DGJECMOALOE, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x71FA180", Offset = "0x71F8B80", VA = "0x1871FA180", Slot = "17")]
	public void FJIFKEHOGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x71FAB10", Offset = "0x71F9510", VA = "0x1871FAB10", Slot = "16")]
	public void JKFFMLHADFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x71F9A10", Offset = "0x71F8410", VA = "0x1871F9A10", Slot = "19")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x71F9FA0", Offset = "0x71F89A0", VA = "0x1871F9FA0", Slot = "20")]
	public void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x71FAD70", Offset = "0x71F9770", VA = "0x1871FAD70", Slot = "18")]
	public void LFBJHLBLBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x71FA5D0", Offset = "0x71F8FD0", VA = "0x1871FA5D0", Slot = "21")]
	public void IDFHACHAABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x71F9B40", Offset = "0x71F8540", VA = "0x1871F9B40")]
	private void JCNKMNLNMBA(Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x71FB0B0", Offset = "0x71F9AB0", VA = "0x1871FB0B0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PDPCDNHHNJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x71FA4C0", Offset = "0x71F8EC0", VA = "0x1871FA4C0")]
	private void HIMFKEKMLPE(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x71FAA60", Offset = "0x71F9460", VA = "0x1871FAA60")]
	private void JJKIEJELDLL(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x71FB1A0", Offset = "0x71F9BA0", VA = "0x1871FB1A0")]
	private Vector3 PLIJKHIOGDA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x71F9D70", Offset = "0x71F8770", VA = "0x1871F9D70", Slot = "15")]
	public void DDGKNGAHJFL((Quaternion rot, Vector3 moments) KEAIEABHOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x71F9BF0", Offset = "0x71F85F0", VA = "0x1871F9BF0")]
	private Quaternion CPNHLKIPJAF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x71FB340", Offset = "0x71F9D40", VA = "0x1871FB340")]
	public void PNGMNEJKPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x71FB410", Offset = "0x71F9E10", VA = "0x1871FB410", Slot = "4")]
	public (float, Vector3) PNGMNEJKPKK(Rigidbody NJPFPAFIHKC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class IHCBCONOBEB
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7207A30", Offset = "0x7206430", VA = "0x187207A30")]
	public static BPPMDDKCDEH OJEPLEKEBNM(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JANENLGGJPE : PJGJBBEFOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly INDEDCJDEPL HPHAJEGJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DJFECCHKBLN KKELJBMGMIN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GJIDMFFMNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1156760", Offset = "0x1155160", VA = "0x181156760", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DJFECCHKBLN OOFOACHKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80", Slot = "11")]
		get
		{
			return default(DJFECCHKBLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7208390", Offset = "0x7206D90", VA = "0x187208390")]
	public JANENLGGJPE(OBJADMFPMJH DGJECMOALOE, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7208290", Offset = "0x7206C90", VA = "0x187208290", Slot = "4")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7207DF0", Offset = "0x72067F0", VA = "0x187207DF0")]
	private bool HCNMNMDDOIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7207DC0", Offset = "0x72067C0", VA = "0x187207DC0", Slot = "5")]
	public void EMHGOIGFFJC(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7208360", Offset = "0x7206D60", VA = "0x187208360", Slot = "6")]
	public void POHDMHOIGPB(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7208010", Offset = "0x7206A10", VA = "0x187208010", Slot = "9")]
	public void OLFCFIJBBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7208180", Offset = "0x7206B80", VA = "0x187208180")]
	private void PGEADFJEDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7207E90", Offset = "0x7206890", VA = "0x187207E90")]
	private void LBGIJOFIBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7208140", Offset = "0x7206B40", VA = "0x187208140", Slot = "8")]
	public void OOFDAFAMLIO(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7207D80", Offset = "0x7206780", VA = "0x187207D80", Slot = "7")]
	public void CMANIKGLCEK(OBJADMFPMJH DGJECMOALOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PKOBPGMFJCA : HLACGAEOOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly INDEDCJDEPL OKPPIPJLJDH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool GGPDDMGENEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x720E380", Offset = "0x720CD80", VA = "0x18720E380", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JIBAICMKDBF APDLPNCFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x720E5D0", Offset = "0x720CFD0", VA = "0x18720E5D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x720E670", Offset = "0x720D070", VA = "0x18720E670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x720E710", Offset = "0x720D110", VA = "0x18720E710")]
	public PKOBPGMFJCA(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x720E460", Offset = "0x720CE60", VA = "0x18720E460", Slot = "7")]
	public void HAOENGGNPGD(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x720E580", Offset = "0x720CF80", VA = "0x18720E580", Slot = "8")]
	public void KFILENDOGBD(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x720E470", Offset = "0x720CE70", VA = "0x18720E470", Slot = "9")]
	public void JIFDANPJPHH(object OEELDHBFFAF, bool GHLPIJPFEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x720E590", Offset = "0x720CF90", VA = "0x18720E590", Slot = "12")]
	public void KIAPBECGNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x720E300", Offset = "0x720CD00", VA = "0x18720E300", Slot = "10")]
	public void BIOIMJFMMDH(Rigidbody EKAOOBAECFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x720E430", Offset = "0x720CE30", VA = "0x18720E430", Slot = "11")]
	public void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class MFPKFFBOPML : CGDHAEEJCPH, ONGNJPHBDLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView LENOGFOLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool FOIGJFDHMHD;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView IHENDNHDJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool GLJAGCBNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x720C930", Offset = "0x720B330", VA = "0x18720C930", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool FNNONNNMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JIBAICMKDBF KNAHBFFHDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x720C950", Offset = "0x720B350", VA = "0x18720C950", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x720CDB0", Offset = "0x720B7B0", VA = "0x18720CDB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x720D4D0", Offset = "0x720BED0", VA = "0x18720D4D0")]
	public MFPKFFBOPML(OBJADMFPMJH DGJECMOALOE, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x720D3A0", Offset = "0x720BDA0", VA = "0x18720D3A0", Slot = "9")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x720CB40", Offset = "0x720B540", VA = "0x18720CB40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x720D0C0", Offset = "0x720BAC0", VA = "0x18720D0C0", Slot = "10")]
	public void KNKCPKBDEHH(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x720CC40", Offset = "0x720B640", VA = "0x18720CC40", Slot = "11")]
	public void IEFPDJGKGGK(OBJADMFPMJH KMAENCDMJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x720D230", Offset = "0x720BC30", VA = "0x18720D230")]
	private void MGMCOHPNFGA(PhotonView AKPEMIHLPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x720C9F0", Offset = "0x720B3F0", VA = "0x18720C9F0")]
	private void CKOGEJDOCLD(HFLALFLFNKL JBLIPGAPOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x720CE50", Offset = "0x720B850", VA = "0x18720CE50")]
	private void KAKAGMKGNMD(PhotonView LPPGIHPBOHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class DIJKKODIALI
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x71FCB80", Offset = "0x71FB580", VA = "0x1871FCB80")]
	public static CGDHAEEJCPH EGHCLNHCBIK(this OBJADMFPMJH KCEPABIAINB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JJMKFDFEGOF : GABFPCKLHNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints MMHODEDNBAM;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool ODFMFNHICOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E7350", Offset = "0x8E5D50", VA = "0x1808E7350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x477AB30", Offset = "0x4779530", VA = "0x18477AB30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OFNHGPPMICB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC070", Offset = "0xAAAA70", VA = "0x180AAC070", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x477AB20", Offset = "0x4779520", VA = "0x18477AB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints LPECEDODPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7208490", Offset = "0x7206E90", VA = "0x187208490", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7208620", Offset = "0x7207020", VA = "0x187208620")]
	public JJMKFDFEGOF(OBJADMFPMJH DGJECMOALOE, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x72085C0", Offset = "0x7206FC0", VA = "0x1872085C0", Slot = "9")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x72085F0", Offset = "0x7206FF0", VA = "0x1872085F0", Slot = "10")]
	public void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FPGMHOBBDGF : DBMCEOHMEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OBJADMFPMJH DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float EJENIGIADEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float GDBONDCADGP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float FFGBNMGCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E20", Offset = "0x9B2820", VA = "0x1809B3E20", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7205E60", Offset = "0x7204860", VA = "0x187205E60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float FMAENBBMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAF17E0", Offset = "0xAF01E0", VA = "0x180AF17E0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7205D90", Offset = "0x7204790", VA = "0x187205D90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7205F30", Offset = "0x7204930", VA = "0x187205F30")]
	public FPGMHOBBDGF(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7205CA0", Offset = "0x72046A0", VA = "0x187205CA0", Slot = "8")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7205CF0", Offset = "0x72046F0", VA = "0x187205CF0", Slot = "9")]
	public void EIPLFEMDFAN(Rigidbody ODEHBHJNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KGIIKIONMNN : AAPCFFOMJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool FMLHNDHKJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool IANPODNBMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int GOAINEGCKCC;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x71F9AF0", Offset = "0x71F84F0", VA = "0x1871F9AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool HOJLMMDILAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x72089A0", Offset = "0x72073A0", VA = "0x1872089A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private OBJADMFPMJH JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x72089D0", Offset = "0x72073D0", VA = "0x1872089D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool MHCELDGENCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7209050", Offset = "0x7207A50", VA = "0x187209050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event JIBAICMKDBF BGDEBCFEJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7208BE0", Offset = "0x72075E0", VA = "0x187208BE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7208900", Offset = "0x7207300", VA = "0x187208900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7209140", Offset = "0x7207B40", VA = "0x187209140")]
	public KGIIKIONMNN(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x72090B0", Offset = "0x7207AB0", VA = "0x1872090B0", Slot = "6")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x72089C0", Offset = "0x72073C0", VA = "0x1872089C0", Slot = "8")]
	public void HBFPCBFOCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7208E60", Offset = "0x7207860", VA = "0x187208E60", Slot = "7")]
	public bool MBKLFPKPOMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7208FB0", Offset = "0x72079B0", VA = "0x187208FB0", Slot = "9")]
	public void OPABKONNCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x72086D0", Offset = "0x72070D0", VA = "0x1872086D0", Slot = "11")]
	public void BIEJNIFKODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7208A30", Offset = "0x7207430", VA = "0x187208A30", Slot = "10")]
	public void HNGDDDLPKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7208C80", Offset = "0x7207680", VA = "0x187208C80")]
	private bool LLIFEGLBPBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7208770", Offset = "0x7207170", VA = "0x187208770")]
	private void CHIJLNBCDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GNGHIIAKMDO : LJIHFPJGIJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly INDEDCJDEPL EIAEMMCHBLP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody LMOODLOFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MHCELDGENCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x71FF810", Offset = "0x71FE210", VA = "0x1871FF810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JHMINGEBEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1156760", Offset = "0x1155160", VA = "0x181156760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7207920", Offset = "0x7206320", VA = "0x187207920")]
	public GNGHIIAKMDO(OBJADMFPMJH DGJECMOALOE, [In] AIPJCHOFLBG LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7207880", Offset = "0x7206280", VA = "0x187207880", Slot = "5")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7207850", Offset = "0x7206250", VA = "0x187207850", Slot = "7")]
	public void ONLCBPFAFMM(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7207180", Offset = "0x7205B80", VA = "0x187207180", Slot = "8")]
	public void CPBCCIHJINH(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x72073A0", Offset = "0x7205DA0", VA = "0x1872073A0", Slot = "9")]
	public void NICCCHAJIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x72071B0", Offset = "0x7205BB0", VA = "0x1872071B0", Slot = "10")]
	public void MGOJDBHBONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x72076D0", Offset = "0x72060D0", VA = "0x1872076D0", Slot = "11")]
	public void OMCCMCDEJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KNBIMHFDCPB : FAAPFDLIGNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FHBJODFDMCI DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly INDEDCJDEPL PKGBIPCMJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float NJEIMEHMNLE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EAEHANAOBNM AFBAAJPFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EFMMKCONAKN PNLCBHJMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 GMCDCOKFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x720B660", Offset = "0x720A060", VA = "0x18720B660", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x720C430", Offset = "0x720AE30", VA = "0x18720C430", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 KNBHDMOLPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7209DB0", Offset = "0x72087B0", VA = "0x187209DB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7209ED0", Offset = "0x72088D0", VA = "0x187209ED0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 IHGLKAFHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x720C2E0", Offset = "0x720ACE0", VA = "0x18720C2E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7209F00", Offset = "0x7208900", VA = "0x187209F00", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 CJDIOLOJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x720B1A0", Offset = "0x7209BA0", VA = "0x18720B1A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7209C40", Offset = "0x7208640", VA = "0x187209C40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float OBNECJIFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0E0", Offset = "0xAAAAE0", VA = "0x180AAC0E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x720B7B0", Offset = "0x720A1B0", VA = "0x18720B7B0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JONIPFJBLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAE50", Offset = "0x1AB9850", VA = "0x181ABAE50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private FELHEFMEMFK MJAFAAHFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6A102A0", Offset = "0x6A0ECA0", VA = "0x186A102A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool HOJLMMDILAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x720A530", Offset = "0x7208F30", VA = "0x18720A530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x720C770", Offset = "0x720B170", VA = "0x18720C770")]
	public KNBIMHFDCPB(OBJADMFPMJH DGJECMOALOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x720A1E0", Offset = "0x7208BE0", VA = "0x18720A1E0", Slot = "19")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7209FC0", Offset = "0x72089C0", VA = "0x187209FC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7209230", Offset = "0x7207C30", VA = "0x187209230", Slot = "28")]
	public void BIOIMJFMMDH(Rigidbody ODEHBHJNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xF6A4D0", Offset = "0xF68ED0", VA = "0x180F6A4D0", Slot = "20")]
	public void HECGDIKDGOJ(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xF6C650", Offset = "0xF6B050", VA = "0x180F6C650", Slot = "30")]
	public void DHNPOEGOCKO(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7209410", Offset = "0x7207E10", VA = "0x187209410", Slot = "35")]
	public Vector3 CCFOBGDNPCK(Vector3 MGCJLNPPEHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x720A020", Offset = "0x7208A20", VA = "0x18720A020", Slot = "34")]
	public Vector3 EFPIBHDKJHO(Vector3 KDBAABAMFFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x720A1E0", Offset = "0x7208BE0", VA = "0x18720A1E0", Slot = "27")]
	public void EKHIMMNIPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x720B600", Offset = "0x720A000", VA = "0x18720B600", Slot = "25")]
	public void JCANOFJDADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7209D50", Offset = "0x7208750", VA = "0x187209D50", Slot = "24")]
	public void DHMAFDFHBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x720AF60", Offset = "0x7209960", VA = "0x18720AF60", Slot = "33")]
	public void GJMJHNCDPNG(Vector3 CMOABHDGOOA, Vector3 OFDEGDNPEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x72091D0", Offset = "0x7207BD0", VA = "0x1872091D0", Slot = "32")]
	public void AABEDGLNCKP(Vector3 JJPPCHKBGCE, Vector3 NHLDMOEHBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x720B2C0", Offset = "0x7209CC0", VA = "0x18720B2C0", Slot = "31")]
	public void HAHIILPKFJK(Vector3 KHPDDAPGGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x72095F0", Offset = "0x7207FF0", VA = "0x1872095F0", Slot = "22")]
	public void CJPBHAPNMFG(KFHHPEHINFA IGPGKDFNPIE, Vector3 MKNOEHKBNIG, float BJFBGGPKGPA, float EFMCFCCKEMH = 8f, float JBMOFLKNCDP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x720C4F0", Offset = "0x720AEF0", VA = "0x18720C4F0", Slot = "21")]
	public void OGPDFMKJDFI(HOBGLFAGAKH GGCOHIKNBGE, Vector3 FODDDPLGLIO, float GANNKOJAILG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x720AAE0", Offset = "0x72094E0", VA = "0x18720AAE0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GGKLLBBNOAC(HOBGLFAGAKH GGCOHIKNBGE, Vector3 PCIAHIPKDFG, float IBHPJNLNOPM = 7f, float PAOBAPJMBLG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1071CA0", Offset = "0x10706A0", VA = "0x181071CA0")]
	private static void ANPMLLDOAMP(Vector3 DPBIGMHBMBN, Vector3 MLNCIIKLLEK, [Out] Vector3 KGOGCFEADDA, [Out] Vector3 KHAICNPLEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7209C70", Offset = "0x7208670", VA = "0x187209C70", Slot = "29")]
	public Vector3 DFEHIKEOCCH(Vector3 DPBIGMHBMBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x720A3A0", Offset = "0x7208DA0", VA = "0x18720A3A0", Slot = "26")]
	public void FIPFFHLOCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x720B7B0", Offset = "0x720A1B0", VA = "0x18720B7B0")]
	private void KIGLBLAAGBJ(float IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x720B460", Offset = "0x7209E60", VA = "0x18720B460")]
	private void IOKHGCOIECH(Vector3 FODDDPLGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x720A9D0", Offset = "0x72093D0", VA = "0x18720A9D0")]
	private Vector3 GDCLEAKPGEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x720BE60", Offset = "0x720A860", VA = "0x18720BE60")]
	private void LIPPNIODBCP(Vector3 KDBAABAMFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x720A280", Offset = "0x7208C80", VA = "0x18720A280")]
	private Vector3 FCJAAOBIKII()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x720A550", Offset = "0x7208F50", VA = "0x18720A550")]
	private void FPADHBJNFPF(Vector3 IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x720B8C0", Offset = "0x720A2C0", VA = "0x18720B8C0")]
	private void KPLHALMNMAP(Vector3 KDBAABAMFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7209360", Offset = "0x7207D60", VA = "0x187209360")]
	private void CBCNMEEHHIM()
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
