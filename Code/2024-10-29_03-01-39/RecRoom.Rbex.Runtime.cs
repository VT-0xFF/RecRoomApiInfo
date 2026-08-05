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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7527180", Offset = "0x7526180", VA = "0x187527180", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GLGOJCKACLK bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E4D0", Offset = "0x1A8D4D0", VA = "0x181A8E4D0", Slot = "5")]
		public override void MKAPIGNDNBF(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7536E70", Offset = "0x7535E70", VA = "0x187536E70")]
		private void OLGBKHIMPDP(ACAAONIHEEI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7536E10", Offset = "0x7535E10", VA = "0x187536E10", Slot = "6")]
		public override void EILKJNIAHKG(ACAAONIHEEI registry, [In] KJALCLNPCLF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7537170", Offset = "0x7536170", VA = "0x187537170")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FEJLBHKHNGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly CDBONJBDMGH PMLLBDELHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool EEBJNKHBPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AKHNJNONFPF ACMCOMOEFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[MONCIELHEAI(CCPGINMHCCO.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MONCIELHEAI(CCPGINMHCCO.SelfAndParent, true, false, false)]
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
		private BJBOIDJKKGM physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
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
		internal AKHNJNONFPF OLHLCHGCLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x75326C0", Offset = "0x75316C0", VA = "0x1875326C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AKHNJNONFPF JLFAKOCGPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BJGBHMKOODA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7534320", Offset = "0x7533320", VA = "0x187534320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GBMJECJPDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7534680", Offset = "0x7533680", VA = "0x187534680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ALCFFKKOPEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x75345C0", Offset = "0x75335C0", VA = "0x1875345C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx JNLBEALAMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7535280", Offset = "0x7534280", VA = "0x187535280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7536780", Offset = "0x7535780", VA = "0x187536780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ABFHMFFCHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8F0", Offset = "0x8DD8F0", VA = "0x1808DE8F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DDENAFMPDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8F0", Offset = "0x8DD8F0", VA = "0x1808DE8F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HJCFABINHDE PMAHCBBJMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7534380", Offset = "0x7533380", VA = "0x187534380")]
			get
			{
				return default(HJCFABINHDE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7535F30", Offset = "0x7534F30", VA = "0x187535F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ECDLHGDFBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7534990", Offset = "0x7533990", VA = "0x187534990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OGJGJKAOELJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x75344A0", Offset = "0x75334A0", VA = "0x1875344A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ONDEDAHJONB JHIHEHEIGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x75348D0", Offset = "0x75338D0", VA = "0x1875348D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x75360F0", Offset = "0x75350F0", VA = "0x1875360F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NDJCFNMENCK DPIEMOJLNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7534870", Offset = "0x7533870", VA = "0x187534870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7536080", Offset = "0x7535080", VA = "0x187536080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JPEFHMBDIII
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x75347C0", Offset = "0x75337C0", VA = "0x1875347C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody NJJKCCDDEEK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7534820", Offset = "0x7533820", VA = "0x187534820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HPEOKFGCHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7534500", Offset = "0x7533500", VA = "0x187534500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7535FA0", Offset = "0x7534FA0", VA = "0x187535FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool APCBPAFILNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7203990", Offset = "0x7202990", VA = "0x187203990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float GIGICIOALEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7535220", Offset = "0x7534220", VA = "0x187535220")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NAEBBHHCDMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75351C0", Offset = "0x75341C0", VA = "0x1875351C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7536710", Offset = "0x7535710", VA = "0x187536710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EIBKJKGFOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7534BF0", Offset = "0x7533BF0", VA = "0x187534BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7536390", Offset = "0x7535390", VA = "0x187536390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IHEIHEJADLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x75349F0", Offset = "0x75339F0", VA = "0x1875349F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7536160", Offset = "0x7535160", VA = "0x187536160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KDOCKMBDLAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75357D0", Offset = "0x75347D0", VA = "0x1875357D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7536CC0", Offset = "0x7535CC0", VA = "0x187536CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 CBPHNLELMLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7534FA0", Offset = "0x7533FA0", VA = "0x187534FA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x75364E0", Offset = "0x75354E0", VA = "0x1875364E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 HJEPAGCGNPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7535910", Offset = "0x7534910", VA = "0x187535910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode JPPNDIMPDFN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7534B30", Offset = "0x7533B30", VA = "0x187534B30")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x75362B0", Offset = "0x75352B0", VA = "0x1875362B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LGJBNCCABEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7534560", Offset = "0x7533560", VA = "0x187534560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7536010", Offset = "0x7535010", VA = "0x187536010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints BIGLDLOJOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7534B90", Offset = "0x7533B90", VA = "0x187534B90")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7536320", Offset = "0x7535320", VA = "0x187536320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 GNMKEDKCLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7535340", Offset = "0x7534340", VA = "0x187535340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LBLGJLPHNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7535340", Offset = "0x7534340", VA = "0x187535340")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7536AA0", Offset = "0x7535AA0", VA = "0x187536AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GINADKKGMEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7535080", Offset = "0x7534080", VA = "0x187535080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x75365C0", Offset = "0x75355C0", VA = "0x1875365C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float ENKMHNEHEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7535770", Offset = "0x7534770", VA = "0x187535770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7536C50", Offset = "0x7535C50", VA = "0x187536C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion GLHJKLIMJID
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7535420", Offset = "0x7534420", VA = "0x187535420")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7536820", Offset = "0x7535820", VA = "0x187536820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DNJIGOLGPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x75356A0", Offset = "0x75346A0", VA = "0x1875356A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7536B80", Offset = "0x7535B80", VA = "0x187536B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 PBAIIOACMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x75354F0", Offset = "0x75344F0", VA = "0x1875354F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75368F0", Offset = "0x75358F0", VA = "0x1875368F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion KEHBBMDKEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x75355D0", Offset = "0x75345D0", VA = "0x1875355D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75369D0", Offset = "0x75359D0", VA = "0x1875369D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLJIHGEKHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7535830", Offset = "0x7534830", VA = "0x187535830")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7536D30", Offset = "0x7535D30", VA = "0x187536D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 AILEJDCFILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x75350E0", Offset = "0x75340E0", VA = "0x1875350E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7536630", Offset = "0x7535630", VA = "0x187536630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DLOHMJPHMGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7534A50", Offset = "0x7533A50", VA = "0x187534A50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x75361D0", Offset = "0x75351D0", VA = "0x1875361D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BOBFECAGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7534EC0", Offset = "0x7533EC0", VA = "0x187534EC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7536400", Offset = "0x7535400", VA = "0x187536400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JIKPFJEBGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7534D80", Offset = "0x7533D80", VA = "0x187534D80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion KANLHAAKCPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7534CB0", Offset = "0x7533CB0", VA = "0x187534CB0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FEMGCABLFAP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7535AD0", Offset = "0x7534AD0", VA = "0x187535AD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HLHENMDNPAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x75359F0", Offset = "0x75349F0", VA = "0x1875359F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MFAKABJBHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7534E60", Offset = "0x7533E60", VA = "0x187534E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BABDMLAGNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7534930", Offset = "0x7533930", VA = "0x187534930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool BFGANBAKBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7534440", Offset = "0x7533440", VA = "0x187534440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GHBBIAKEDHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x75343E0", Offset = "0x75333E0", VA = "0x1875343E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KJOKMLACOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x75342C0", Offset = "0x75332C0", VA = "0x1875342C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FEGABJEOLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7534C50", Offset = "0x7533C50", VA = "0x187534C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool GIKNMPKMNJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1D1BDC0", Offset = "0x1D1ADC0", VA = "0x181D1BDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event LECCBHNGBKB AAPICBAHIKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x75341E0", Offset = "0x75331E0", VA = "0x1875341E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7535E50", Offset = "0x7534E50", VA = "0x187535E50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MDCOCNFPMGL BEMNMPMHGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7533F50", Offset = "0x7532F50", VA = "0x187533F50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7535BB0", Offset = "0x7534BB0", VA = "0x187535BB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MDCOCNFPMGL NLBEPNFOIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7533FB0", Offset = "0x7532FB0", VA = "0x187533FB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7535C20", Offset = "0x7534C20", VA = "0x187535C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MDCOCNFPMGL PDKAINJGLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7534100", Offset = "0x7533100", VA = "0x187534100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7535D70", Offset = "0x7534D70", VA = "0x187535D70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DJFOEHMHKBO, DJFOEHMHKBO> BCPJNGNDLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7534090", Offset = "0x7533090", VA = "0x187534090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7535D00", Offset = "0x7534D00", VA = "0x187535D00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MDCOCNFPMGL HIMOHOBFHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7534170", Offset = "0x7533170", VA = "0x187534170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7535DE0", Offset = "0x7534DE0", VA = "0x187535DE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MDCOCNFPMGL MFDLGGNADNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7534250", Offset = "0x7533250", VA = "0x187534250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7535EC0", Offset = "0x7534EC0", VA = "0x187535EC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MDCOCNFPMGL NLLDHMDCDEH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7534020", Offset = "0x7533020", VA = "0x187534020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7535C90", Offset = "0x7534C90", VA = "0x187535C90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670", Slot = "8")]
		private void BLEEACPHNHO(AKHNJNONFPF PHOINLFJEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7532F70", Offset = "0x7531F70", VA = "0x187532F70")]
		internal void MOMKCFDPPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7533C80", Offset = "0x7532C80", VA = "0x187533C80")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody DHHPHOHHNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7532950", Offset = "0x7531950", VA = "0x187532950")]
		public FEJLBHKHNGD GetChild(int KHAIDMGPIED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75338F0", Offset = "0x75328F0", VA = "0x1875338F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BDCEEOCLFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7532430", Offset = "0x7531430", VA = "0x187532430")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75326C0", Offset = "0x75316C0", VA = "0x1875326C0")]
		private AKHNJNONFPF LMNJNPGNBJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75324A0", Offset = "0x75314A0", VA = "0x1875324A0")]
		private void BCCFFCEEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75330C0", Offset = "0x75320C0", VA = "0x1875330C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7532F70", Offset = "0x7531F70", VA = "0x187532F70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7533060", Offset = "0x7532060", VA = "0x187533060")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7533120", Offset = "0x7532120", VA = "0x187533120")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7531A20", Offset = "0x7530A20", VA = "0x187531A20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7533180", Offset = "0x7532180", VA = "0x187533180")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75328F0", Offset = "0x75318F0", VA = "0x1875328F0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7533000", Offset = "0x7532000", VA = "0x187533000")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7533A50", Offset = "0x7532A50", VA = "0x187533A50")]
		public void SetParent(RigidbodyEx BJDKOHEGDOK, bool BDOONMIDCCI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7533490", Offset = "0x7532490", VA = "0x187533490")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7532C00", Offset = "0x7531C00", VA = "0x187532C00")]
		public bool IsRigidbodyAncestor(RigidbodyEx OLNNEMPGLNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7532D00", Offset = "0x7531D00", VA = "0x187532D00")]
		public bool IsRigidbodyDescendant(RigidbodyEx IIHBPBJBHLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7531C90", Offset = "0x7530C90", VA = "0x187531C90")]
		public void AddInterpolationRestriction(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75331F0", Offset = "0x75321F0", VA = "0x1875331F0")]
		public void RemoveInterpolationRestriction(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7531D00", Offset = "0x7530D00", VA = "0x187531D00")]
		public void AddKinematic(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7533260", Offset = "0x7532260", VA = "0x187533260")]
		public void RemoveKinematic(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75339D0", Offset = "0x75329D0", VA = "0x1875339D0")]
		public void SetKinematic(object NANMDIJGGLP, bool NDIICNIHPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75337F0", Offset = "0x75327F0", VA = "0x1875337F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CJIFKLKANBL, Quaternion OJPJJEDKNDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75336F0", Offset = "0x75326F0", VA = "0x1875336F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 DDDGFIIJFMJ, Quaternion HHNPPALCIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7532AF0", Offset = "0x7531AF0", VA = "0x187532AF0")]
		public Vector3 GetConstrainedVelocity(Vector3 DLJIHGEKHEP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75329E0", Offset = "0x75319E0", VA = "0x1875329E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DLOHMJPHMGK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7531BA0", Offset = "0x7530BA0", VA = "0x187531BA0")]
		public void AddForce(Vector3 OCPABOGIINL, ForceMode DHEPCFAGBLI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7531A90", Offset = "0x7530A90", VA = "0x187531A90")]
		public void AddForceAtPosition(Vector3 OCPABOGIINL, Vector3 PAMMLHPIJIB, ForceMode DHEPCFAGBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7531ED0", Offset = "0x7530ED0", VA = "0x187531ED0")]
		public void AddTorque(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7531D70", Offset = "0x7530D70", VA = "0x187531D70")]
		public void AddRelativeTorque(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7533D50", Offset = "0x7532D50", VA = "0x187533D50")]
		public Vector3 WorldToLocalVelocity(Vector3 LHHOGDBNLML)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7532E60", Offset = "0x7531E60", VA = "0x187532E60")]
		public Vector3 LocalToWorldVelocity(Vector3 AILEJDCFILE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7532890", Offset = "0x7531890", VA = "0x187532890")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7532830", Offset = "0x7531830", VA = "0x187532830")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75327D0", Offset = "0x75317D0", VA = "0x1875327D0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7532770", Offset = "0x7531770", VA = "0x187532770")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75335F0", Offset = "0x75325F0", VA = "0x1875335F0")]
		public void ResetVelocityWorldSpace(Vector3 ACBOLABNEEC, Vector3 NOFPLPBOOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75334F0", Offset = "0x75324F0", VA = "0x1875334F0")]
		public void ResetVelocityLocalSpace(Vector3 HEDNFJFIFCK, Vector3 BOBFECAGCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75333B0", Offset = "0x75323B0", VA = "0x1875333B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HEDNFJFIFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7533B80", Offset = "0x7532B80", VA = "0x187533B80")]
		public bool SweepTest(Vector3 IKMGCHAHKMB, [Out] RaycastHit PICLEONLIDJ, float OCANAPGPKID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7532E00", Offset = "0x7531E00", VA = "0x187532E00")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7533B20", Offset = "0x7532B20", VA = "0x187533B20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7533CF0", Offset = "0x7532CF0", VA = "0x187533CF0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7531E60", Offset = "0x7530E60", VA = "0x187531E60")]
		public void AddShouldHaveUnityRigidbodyToken(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75332D0", Offset = "0x75322D0", VA = "0x1875332D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7532260", Offset = "0x7531260", VA = "0x187532260")]
		public void ApplyForceVelocityChange(LMIMIJBONNN HBMFKGKENDH, Vector3 AKKHKOGDNKH, float JOBCMFOMHOP, float ELFKNNFHBFC = 8f, float PECLEMMEGFM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7532160", Offset = "0x7531160", VA = "0x187532160")]
		public void ApplyAngularVelocityChange(LJAEDMAHHKF AGGJIANGPHP, Vector3 BPEPPABJCOI, float MBDACAEELBM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7532320", Offset = "0x7531320", VA = "0x187532320")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LJAEDMAHHKF AGGJIANGPHP, Vector3 JKJHCABJJIO, float EGHAKJENMLO = 7f, float FDIBJKLEEJH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7532090", Offset = "0x7531090", VA = "0x187532090")]
		public bool AllowedScaleChange(float OPMJCEFOCMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7531FC0", Offset = "0x7530FC0", VA = "0x187531FC0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx IOHCIGNDOKI, object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7533340", Offset = "0x7532340", VA = "0x187533340")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7533EE0", Offset = "0x7532EE0", VA = "0x187533EE0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDB8460", Offset = "0xDB7460", VA = "0x180DB8460", Slot = "4")]
		private GameObject GEJGJPDFENB()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8F0", Offset = "0x8DD8F0", VA = "0x1808DE8F0", Slot = "5")]
		private Transform CPHGBINLJPP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BFGIPOJADLP
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x751DF30", Offset = "0x751CF30", VA = "0x18751DF30")]
	public static AKHNJNONFPF OLHLCHGCLHP(this RigidbodyEx IPGMKLKJGEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CPEGFBANFJI(typeof(DIHCEFAEPDD), new string[] { })]
public class FPHFPFKAMMH : DIHCEFAEPDD, PGDGDABKPIE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HJMOPKJIFCO IHBCKLGPIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private CDMEFMILIJM LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PGBNCDEAMGG OKKHBECPMBN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CDMEFMILIJM PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PGBNCDEAMGG MBLBOIACNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75254F0", Offset = "0x75244F0", VA = "0x1875254F0", Slot = "7")]
	public void InitReferences(KKPADIDKOMK MOLJCIFKDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75253E0", Offset = "0x75243E0", VA = "0x1875253E0", Slot = "6")]
	public AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public FPHFPFKAMMH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static GDBINPMHEFP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static GDBINPMHEFP AfterSyncTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GIEJMNCNJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GJJMEBGMBJP;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75317F0", Offset = "0x75307F0", VA = "0x1875317F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7531890", Offset = "0x7530890", VA = "0x187531890")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7531810", Offset = "0x7530810", VA = "0x187531810")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ABHPFCOODAJ, [Optional] UnityEngine.Object NDMMIOJEOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ABHPFCOODAJ, [Optional] UnityEngine.Object NDMMIOJEOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75319D0", Offset = "0x75309D0", VA = "0x1875319D0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CJILKDDKOJG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ANPEILOBLFH : ONDEDAHJONB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5860", Offset = "0x8C4860", VA = "0x1808C5860", Slot = "4")]
		public Vector3 GNMMMDJNOEJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5860", Offset = "0x8C4860", VA = "0x1808C5860", Slot = "5")]
		public Vector3 NKBNCKKBLOC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ANPEILOBLFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static ONDEDAHJONB MLOFLCCCEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x751DFA0", Offset = "0x751CFA0", VA = "0x18751DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EBFHHJPCOKN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode EFACACNIFOD
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
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKFJCDHBMBC(bool MFAKABJBHFK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEFEBADBOHA(bool MFAKABJBHFK);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CDGFEMBLDJA(Vector3 IKMGCHAHKMB, [Out] RaycastHit PICLEONLIDJ, float OCANAPGPKID);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IBDGPDNBALL : IDisposable, LKBGBEKOGHP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HJCFABINHDE PMAHCBBJMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DJFOEHMHKBO, DJFOEHMHKBO> BCPJNGNDLCL;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBMDLPFFOHA();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BOKBHMFLMCH(OFNPJLHIBJA.Application)]
public interface PGBNCDEAMGG
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJBHONCMKIP FHPNBKPCNIN(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCFHMGKHKMM GPLANGGCLLH(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FHAEJECMDBP BFIKDOKPHHF(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HCICJCMOFNA PDEHLLOIIFN(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHEECLJAANH NOCNIPDJNAB(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBDGPDNBALL NEAJJIMAJBG(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LECKKHMIGDK NCICHCHDNKM(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ADAECEIMPMI ABGKHHBHANM(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EBFHHJPCOKN GKIBHCOFAGB(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HDBCPJCONEE KCKDLGDBCKJ(AKHNJNONFPF PHOINLFJEFI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EKJKOMEGFEE MJDJOKKAAIM(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KADPPPIGKHB BFJNCKEAPKI(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GKHJLNGKDFL EMGBLOBEEEO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EHJLOADKFEI JPIHBLJGINF(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BABLMGDPMDK HLAGECIABLC(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL, DIHCEFAEPDD PMNMDCCMPDH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ADAECEIMPMI
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEGLJFIFLPK(Vector3 OCPABOGIINL, ForceMode DHEPCFAGBLI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBFELPGOEBF(Vector3 OCPABOGIINL, Vector3 PAMMLHPIJIB, ForceMode DHEPCFAGBLI);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFAFBNAMHIG(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGAEDBBMLLB(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HDBCPJCONEE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BBLGDPIHGNP
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
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADEJCDFOECN(Rigidbody IMEDPEAFOFL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJBHONCMKIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<AKHNJNONFPF> CILOAPIDAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AKHNJNONFPF ALCFFKKOPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AKHNJNONFPF CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MDCOCNFPMGL BEMNMPMHGHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MDCOCNFPMGL NLBEPNFOIBP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event LECCBHNGBKB JBGPEMEOJOG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JOLMKFKOMPA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CBHLJGNACEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AKHNJNONFPF> IBMBPOBNDBD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AKHNJNONFPF> EHMIDOJCAIO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IJFOADCGPNM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AKHNJNONFPF> PHKMCAHJDBI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IMAOJFCAENJ(AKHNJNONFPF LNEILPPCDKB, bool BDOONMIDCCI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FHAEJECMDBP
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EAJOCDAEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DADPDBLHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAAAOFBCCKB(AKHNJNONFPF JNLBEALAMNB, object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAFAIJDALFA(object NANMDIJGGLP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EHJLOADKFEI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CFBBKOCECBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 AFPGIHPPDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float BNIEFEKAHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float FHPKLFPAPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 OADPDHGGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion NPMOBGMBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MDCOCNFPMGL KDGIEEIHAJD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CDLEEBMGJPA((Quaternion rot, Vector3 moments) BDCEEOCLFFH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BCMDIEBOEJL();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JDOHJNEKHCF();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LDNLMGCBJNK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADEJCDFOECN(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BBOELKAJKID();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GKHJLNGKDFL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCOBANOHBCC(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPMCEFJOIOP(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AJJJEOGOHAN(AKHNJNONFPF IPGMKLKJGEN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAJDAJJMGOE(AKHNJNONFPF IPGMKLKJGEN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void INAEAELHHJC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LECKKHMIGDK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool KEMMFALEJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MDCOCNFPMGL GMIAJKAPOFJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEMLLCGAIHK(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEOIHDOKAOF(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEDFCNAEPFP(object NANMDIJGGLP, bool NDIICNIHPIJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FLEIGIBNGKO(Rigidbody MIGHIIBDOBO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADEJCDFOECN(Rigidbody IMEDPEAFOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KADPPPIGKHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool ECDLHGDFBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OGJGJKAOELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MDCOCNFPMGL KEMGAKEDDHA;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKPGJEBNJML(AKHNJNONFPF JNLBEALAMNB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFBOEFNHDMK(AKHNJNONFPF JNLBEALAMNB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BABLMGDPMDK
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HPEOKFGCHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ICPIJDEADFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints OPJFJICGHPP
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
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADEJCDFOECN(Rigidbody IMEDPEAFOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HCICJCMOFNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float CIGOPJMKKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float DJBGNDLNAIP
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
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADEJCDFOECN(Rigidbody IMEDPEAFOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GHEECLJAANH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MDCOCNFPMGL AAIGBKNPEHL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENIEOIGNHIG();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGAOIIFAGNI();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMHEPFBJECN();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCNLGNEHOLJ();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGLKHHKEIPM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EKJKOMEGFEE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EGIHACKOINH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKAMLFFFPIK(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBJOECHLLDN(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOONIEFPEPO();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NCFHMGKHKMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	ONDEDAHJONB JHIHEHEIGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NDJCFNMENCK DPIEMOJLNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OPEMPCBIMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 NBBCALIIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 PLFLAEHBFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JEFIHANGHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float LGJBNCCABEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JPEFHMBDIII
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MBMDLPFFOHA();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NENJBDAPEIL(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MLMEGHJFEJB(LJAEDMAHHKF AGGJIANGPHP, Vector3 BPEPPABJCOI, float MBDACAEELBM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OPIKHFMBCNB(LMIMIJBONNN HBMFKGKENDH, Vector3 AKKHKOGDNKH, float JOBCMFOMHOP, float ELFKNNFHBFC = 8f, float PECLEMMEGFM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ABNHDNMHEJH(LJAEDMAHHKF AGGJIANGPHP, Vector3 JKJHCABJJIO, float EGHAKJENMLO = 7f, float FDIBJKLEEJH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HJDEDLCAKCF();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HOGJFFAKAEE();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KPJHKIJBAOG();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EAOMIBNNAAK();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EKJGCKKJONM(Vector3 DLJIHGEKHEP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HBJKNNAPBIE(object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EKLAFIHBKPP(Vector3 LEEPGGPHONF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ECAFOBPNBOK(Vector3 HEDNFJFIFCK, Vector3 BOBFECAGCEJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FFILGFJHDIL(Vector3 ACBOLABNEEC, Vector3 NOFPLPBOOOC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 AGHGBBENDEL(Vector3 AILEJDCFILE);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OMPDIGGFIPI(Vector3 LHHOGDBNLML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BOKBHMFLMCH(OFNPJLHIBJA.Application)]
public interface CDMEFMILIJM
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FBIBLPGKHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLLMJDGEKEF(string IPLILPPMPOG);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOGCCOFKDFJ(RigidbodyEx IPGMKLKJGEN, Action NDLMGANFCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OICHLINLOOD KFHKFNKEBBG(int GGFHDJEIODP);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIILKDPDHPM(Vector3 HJEPAGCGNPO, float KBAMNBFIDOP, Color DANHKIEIFNH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BOKBHMFLMCH(OFNPJLHIBJA.Application)]
public interface DIHCEFAEPDD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	CDMEFMILIJM PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	PGBNCDEAMGG MBLBOIACNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EAPBPJOMKLC : AKHNJNONFPF, IDisposable, LEJKBAOAGNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly DIHCEFAEPDD PMNMDCCMPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal EJBHONCMKIP OANCIFBHAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal GKHJLNGKDFL GAMOFJBJOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal KADPPPIGKHB AOHMHLKPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NCFHMGKHKMM DLJIHGEKHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FHAEJECMDBP ABJMPFPDCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EHJLOADKFEI AMOOBJBEGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal HCICJCMOFNA BDCCCLBNNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal HDBCPJCONEE OPOMBFPNKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal GHEECLJAANH BJFAICIGOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal IBDGPDNBALL HJFOFDPMFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal LECKKHMIGDK GBIFEPNJIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal ADAECEIMPMI OCPABOGIINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal BABLMGDPMDK HJEPFHGHNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal EKJKOMEGFEE IMEDPEAFOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal EBFHHJPCOKN BNCLOMADLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal IDisposable OMILPCHLHIM;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IIEINKOMOLH OKCGBELAOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "22")]
		get
		{
			return default(IIEINKOMOLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public FEJLBHKHNGD NNJIEANELEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8B8220", Offset = "0x8B7220", VA = "0x1808B8220", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B82D0", Offset = "0x8B72D0", VA = "0x1808B82D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject HPOBJCALLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAC53E0", Offset = "0xAC43E0", VA = "0x180AC53E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B90", Offset = "0xABFB90", VA = "0x180AC0B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAB0", Offset = "0x8BDAB0", VA = "0x1808BEAB0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA70", Offset = "0x8BDA70", VA = "0x1808BEA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7523640", Offset = "0x7522640", VA = "0x187523640", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public AKHNJNONFPF CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x75237F0", Offset = "0x75227F0", VA = "0x1875237F0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7523BE0", Offset = "0x7522BE0", VA = "0x187523BE0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int BJGBHMKOODA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7522AA0", Offset = "0x7521AA0", VA = "0x187522AA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AKHNJNONFPF ALCFFKKOPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7524280", Offset = "0x7523280", VA = "0x187524280", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool GBKEFOHBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x751FB40", Offset = "0x751EB40", VA = "0x18751FB40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool ECDLHGDFBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7524820", Offset = "0x7523820", VA = "0x187524820", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OGJGJKAOELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7523380", Offset = "0x7522380", VA = "0x187523380", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ONDEDAHJONB JHIHEHEIGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75236F0", Offset = "0x75226F0", VA = "0x1875236F0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7522210", Offset = "0x7521210", VA = "0x187522210", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NDJCFNMENCK DPIEMOJLNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7523F60", Offset = "0x7522F60", VA = "0x187523F60", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7523D50", Offset = "0x7522D50", VA = "0x187523D50", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float LGJBNCCABEM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x75237A0", Offset = "0x75227A0", VA = "0x1875237A0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7520CD0", Offset = "0x751FCD0", VA = "0x187520CD0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 NBBCALIIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7520250", Offset = "0x751F250", VA = "0x187520250", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7520390", Offset = "0x751F390", VA = "0x187520390", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 JEFIHANGHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x751F2D0", Offset = "0x751E2D0", VA = "0x18751F2D0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7521990", Offset = "0x7520990", VA = "0x187521990", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 OPEMPCBIMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x75242D0", Offset = "0x75232D0", VA = "0x1875242D0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x75229C0", Offset = "0x75219C0", VA = "0x1875229C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 PLFLAEHBFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x75232A0", Offset = "0x75222A0", VA = "0x1875232A0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x75223C0", Offset = "0x75213C0", VA = "0x1875223C0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool BFGANBAKBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7522B10", Offset = "0x7521B10", VA = "0x187522B10", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool GHBBIAKEDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x75244E0", Offset = "0x75234E0", VA = "0x1875244E0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool KJOKMLACOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x75234C0", Offset = "0x75224C0", VA = "0x1875234C0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JPEFHMBDIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7521870", Offset = "0x7520870", VA = "0x187521870", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 EAJOCDAEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x751F410", Offset = "0x751E410", VA = "0x18751F410", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 DADPDBLHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7524B60", Offset = "0x7523B60", VA = "0x187524B60", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CFBBKOCECBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7524A30", Offset = "0x7523A30", VA = "0x187524A30", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x75204C0", Offset = "0x751F4C0", VA = "0x1875204C0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 AFPGIHPPDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x75243B0", Offset = "0x75233B0", VA = "0x1875243B0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float BNIEFEKAHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x75245A0", Offset = "0x75235A0", VA = "0x1875245A0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float FHPKLFPAPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x75205A0", Offset = "0x751F5A0", VA = "0x1875205A0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7523740", Offset = "0x7522740", VA = "0x187523740", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 OADPDHGGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7522760", Offset = "0x7521760", VA = "0x187522760", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion NPMOBGMBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x75218C0", Offset = "0x75208C0", VA = "0x1875218C0", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float CIGOPJMKKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x75241D0", Offset = "0x75231D0", VA = "0x1875241D0", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x75201F0", Offset = "0x751F1F0", VA = "0x1875201F0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float DJBGNDLNAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x751F280", Offset = "0x751E280", VA = "0x18751F280", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x75224A0", Offset = "0x75214A0", VA = "0x1875224A0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BBLGDPIHGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7523EB0", Offset = "0x7522EB0", VA = "0x187523EB0", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7524C90", Offset = "0x7523C90", VA = "0x187524C90", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HJCFABINHDE PMAHCBBJMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7524B10", Offset = "0x7523B10", VA = "0x187524B10", Slot = "69")]
		get
		{
			return default(HJCFABINHDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7523B80", Offset = "0x7522B80", VA = "0x187523B80", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool KEMMFALEJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7520470", Offset = "0x751F470", VA = "0x187520470", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform DDENAFMPDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAB0", Offset = "0x8BDAB0", VA = "0x1808BEAB0", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 CHDGJLDKFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7523CA0", Offset = "0x7522CA0", VA = "0x187523CA0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7520B30", Offset = "0x751FB30", VA = "0x187520B30", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float LHHHGLLHPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7521860", Offset = "0x7520860", VA = "0x187521860", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x751EDC0", Offset = "0x751DDC0", VA = "0x18751EDC0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float OLIFJEAMFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x75223B0", Offset = "0x75213B0", VA = "0x1875223B0", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x75238A0", Offset = "0x75228A0", VA = "0x1875238A0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion BNLHOAFPOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x751FFA0", Offset = "0x751EFA0", VA = "0x18751FFA0", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x751FE60", Offset = "0x751EE60", VA = "0x18751FE60", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 DIHMGFFLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7522EC0", Offset = "0x7521EC0", VA = "0x187522EC0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7523480", Offset = "0x7522480", VA = "0x187523480", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion FMEMKMLEONC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x75205F0", Offset = "0x751F5F0", VA = "0x1875205F0", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7520D30", Offset = "0x751FD30", VA = "0x187520D30", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints OPJFJICGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x75225B0", Offset = "0x75215B0", VA = "0x1875225B0", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7523B20", Offset = "0x7522B20", VA = "0x187523B20", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HPEOKFGCHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7522E00", Offset = "0x7521E00", VA = "0x187522E00", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7520330", Offset = "0x751F330", VA = "0x187520330", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode EFACACNIFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7524C40", Offset = "0x7523C40", VA = "0x187524C40", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7523080", Offset = "0x7522080", VA = "0x187523080", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool ONFHACJGFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7520720", Offset = "0x751F720", VA = "0x187520720", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool BABDMLAGNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7522840", Offset = "0x7521840", VA = "0x187522840", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MDCOCNFPMGL BEMNMPMHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7524760", Offset = "0x7523760", VA = "0x187524760", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7523F00", Offset = "0x7522F00", VA = "0x187523F00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MDCOCNFPMGL NLBEPNFOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7522C60", Offset = "0x7521C60", VA = "0x187522C60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x751F3B0", Offset = "0x751E3B0", VA = "0x18751F3B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event LECCBHNGBKB JBGPEMEOJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x751FE00", Offset = "0x751EE00", VA = "0x18751FE00", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7521E90", Offset = "0x7520E90", VA = "0x187521E90", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MDCOCNFPMGL KEMGAKEDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7522350", Offset = "0x7521350", VA = "0x187522350", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7524220", Offset = "0x7523220", VA = "0x187524220", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event MDCOCNFPMGL PDKAINJGLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7522F50", Offset = "0x7521F50", VA = "0x187522F50", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7523840", Offset = "0x7522840", VA = "0x187523840", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event MDCOCNFPMGL AAIGBKNPEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x751EF40", Offset = "0x751DF40", VA = "0x18751EF40", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x75240F0", Offset = "0x75230F0", VA = "0x1875240F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<DJFOEHMHKBO, DJFOEHMHKBO> BCPJNGNDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7522600", Offset = "0x7521600", VA = "0x187522600", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7523FB0", Offset = "0x7522FB0", VA = "0x187523FB0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MDCOCNFPMGL GMIAJKAPOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7522B60", Offset = "0x7521B60", VA = "0x187522B60", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7524540", Offset = "0x7523540", VA = "0x187524540", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MDCOCNFPMGL NLLDHMDCDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7521A70", Offset = "0x7520A70", VA = "0x187521A70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x75231F0", Offset = "0x75221F0", VA = "0x1875231F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7524D30", Offset = "0x7523D30", VA = "0x187524D30")]
	public EAPBPJOMKLC(GameObject IEELEEMHGEB, RigidbodyEx AKNOEMBKPCB, DIHCEFAEPDD PMNMDCCMPDH, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x751F780", Offset = "0x751E780", VA = "0x18751F780", Slot = "137")]
	protected virtual void BOAKGIDEOKO(DIHCEFAEPDD PMNMDCCMPDH, ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7520630", Offset = "0x751F630", VA = "0x187520630", Slot = "138")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7523980", Offset = "0x7522980", VA = "0x187523980", Slot = "92")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7520960", Offset = "0x751F960", VA = "0x187520960", Slot = "93")]
	public void EKLMJINHFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x75241B0", Offset = "0x75231B0", VA = "0x1875241B0", Slot = "94")]
	public void NIKNDGJLCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x751FD80", Offset = "0x751ED80", VA = "0x18751FD80")]
	private void CEKFMPIEFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7522CC0", Offset = "0x7521CC0", VA = "0x187522CC0", Slot = "30")]
	public AKHNJNONFPF ICNLOADLNNL(int KHAIDMGPIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7522E50", Offset = "0x7521E50", VA = "0x187522E50", Slot = "96")]
	public void IMAOJFCAENJ(AKHNJNONFPF BJDKOHEGDOK, bool BDOONMIDCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7521350", Offset = "0x7520350", VA = "0x187521350", Slot = "97")]
	public void ENILEJMIDPM(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7523AC0", Offset = "0x7522AC0", VA = "0x187523AC0", Slot = "98")]
	public void MEOFFLDIHKA(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7524870", Offset = "0x7523870", VA = "0x187524870", Slot = "99")]
	public Vector3 OMPDIGGFIPI(Vector3 LHHOGDBNLML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x751F180", Offset = "0x751E180", VA = "0x18751F180", Slot = "100")]
	public Vector3 AGHGBBENDEL(Vector3 AILEJDCFILE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7520960", Offset = "0x751F960", VA = "0x187520960", Slot = "101")]
	public void EAOMIBNNAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7522C10", Offset = "0x7521C10", VA = "0x187522C10", Slot = "102")]
	public void HOGJFFAKAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7522BC0", Offset = "0x7521BC0", VA = "0x187522BC0", Slot = "103")]
	public void HJDEDLCAKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7521770", Offset = "0x7520770", VA = "0x187521770", Slot = "104")]
	public void FFILGFJHDIL(Vector3 ACBOLABNEEC, Vector3 NOFPLPBOOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7520BE0", Offset = "0x751FBE0", VA = "0x187520BE0", Slot = "105")]
	public void ECAFOBPNBOK(Vector3 HEDNFJFIFCK, Vector3 BOBFECAGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7520E60", Offset = "0x751FE60", VA = "0x187520E60", Slot = "106")]
	public void EKLAFIHBKPP(Vector3 LEEPGGPHONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7524970", Offset = "0x7523970", VA = "0x187524970", Slot = "107")]
	public void OPIKHFMBCNB(LMIMIJBONNN HBMFKGKENDH, Vector3 AKKHKOGDNKH, float JOBCMFOMHOP, float ELFKNNFHBFC = 8f, float PECLEMMEGFM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7523DB0", Offset = "0x7522DB0", VA = "0x187523DB0", Slot = "108")]
	public void MLMEGHJFEJB(LJAEDMAHHKF AGGJIANGPHP, Vector3 BPEPPABJCOI, float MBDACAEELBM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x751EE30", Offset = "0x751DE30", VA = "0x18751EE30", Slot = "109")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ABNHDNMHEJH(LJAEDMAHHKF AGGJIANGPHP, Vector3 JKJHCABJJIO, float EGHAKJENMLO = 7f, float FDIBJKLEEJH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7520D60", Offset = "0x751FD60", VA = "0x187520D60", Slot = "110")]
	public Vector3 EKJGCKKJONM(Vector3 BJDKOHEGDOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7522660", Offset = "0x7521660", VA = "0x187522660", Slot = "111")]
	public Vector3 GMGFKNEJHEI(Vector3 BJDKOHEGDOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x75235A0", Offset = "0x75225A0", VA = "0x1875235A0", Slot = "112")]
	public void KPJHKIJBAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7522D40", Offset = "0x7521D40", VA = "0x187522D40", Slot = "113")]
	public void IKADHCFIEGK(AKHNJNONFPF IOHCIGNDOKI, object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x75247C0", Offset = "0x75237C0", VA = "0x1875247C0", Slot = "114")]
	public void OIGCJAKLDCA(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x751FCA0", Offset = "0x751ECA0", VA = "0x18751FCA0", Slot = "62")]
	public void CDLEEBMGJPA((Quaternion rot, Vector3 moments) BDCEEOCLFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7522F00", Offset = "0x7521F00", VA = "0x187522F00", Slot = "115")]
	public void JDOHJNEKHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x751F670", Offset = "0x751E670", VA = "0x18751F670", Slot = "116")]
	public void BCMDIEBOEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x75235F0", Offset = "0x75225F0", VA = "0x1875235F0", Slot = "117")]
	public void LDNLMGCBJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7521300", Offset = "0x7520300", VA = "0x187521300", Slot = "118")]
	public bool ENIEOIGNHIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7524490", Offset = "0x7523490", VA = "0x187524490", Slot = "95")]
	public void NMHEPFBJECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x75233D0", Offset = "0x75223D0", VA = "0x1875233D0", Slot = "119")]
	public void KGLKHHKEIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7523690", Offset = "0x7522690", VA = "0x187523690", Slot = "120")]
	public void LEMLLCGAIHK(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7524700", Offset = "0x7523700", VA = "0x187524700", Slot = "121")]
	public void OEOIHDOKAOF(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x75215B0", Offset = "0x75205B0", VA = "0x1875215B0", Slot = "122")]
	public void FEDFCNAEPFP(object NANMDIJGGLP, bool NDIICNIHPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x75213B0", Offset = "0x75203B0", VA = "0x1875213B0", Slot = "123")]
	public void FAEEAOGKHGC(Vector3 CJIFKLKANBL, Quaternion OJPJJEDKNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x751F4E0", Offset = "0x751E4E0", VA = "0x18751F4E0", Slot = "124")]
	public void BAKGOKHEHEA(Vector3 DDDGFIIJFMJ, Quaternion HHNPPALCIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7522DB0", Offset = "0x7521DB0", VA = "0x187522DB0", Slot = "125")]
	public bool IKAPFCGLPAO(float OPMJCEFOCMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7523C40", Offset = "0x7522C40", VA = "0x187523C40", Slot = "126")]
	public void MIIBNONLJFE(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7524150", Offset = "0x7523150", VA = "0x187524150", Slot = "127")]
	public void NGKGADIJMLI(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7523420", Offset = "0x7522420", VA = "0x187523420", Slot = "128")]
	public void KKAMLFFFPIK(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x751FF40", Offset = "0x751EF40", VA = "0x18751FF40", Slot = "129")]
	public void DBJOECHLLDN(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7520040", Offset = "0x751F040", VA = "0x187520040", Slot = "130")]
	public void DEGLJFIFLPK(Vector3 OCPABOGIINL, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x75245F0", Offset = "0x75235F0", VA = "0x1875245F0", Slot = "131")]
	public void OBFELPGOEBF(Vector3 OCPABOGIINL, Vector3 PAMMLHPIJIB, ForceMode DHEPCFAGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7522270", Offset = "0x7521270", VA = "0x187522270", Slot = "132")]
	public void GFAFBNAMHIG(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7524010", Offset = "0x7523010", VA = "0x187524010", Slot = "133")]
	public void NGAEDBBMLLB(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x751FBA0", Offset = "0x751EBA0", VA = "0x18751FBA0", Slot = "134")]
	public bool CDGFEMBLDJA(Vector3 IKMGCHAHKMB, [Out] RaycastHit PICLEONLIDJ, float OCANAPGPKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x751F620", Offset = "0x751E620", VA = "0x18751F620", Slot = "135")]
	public void BBOELKAJKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7524CF0", Offset = "0x7523CF0", VA = "0x187524CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x751FA70", Offset = "0x751EA70", VA = "0x18751FA70")]
	private void CAKEDFBBBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x75230E0", Offset = "0x75220E0", VA = "0x1875230E0")]
	private void JNCJJDMPNGK(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x751EFA0", Offset = "0x751DFA0", VA = "0x18751EFA0")]
	private void ACJMPPHCEGK(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7522500", Offset = "0x7521500", VA = "0x187522500")]
	private void GHOGJEJACBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7520860", Offset = "0x751F860", VA = "0x187520860")]
	private void EACDNMHPPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x75209B0", Offset = "0x751F9B0", VA = "0x1875209B0")]
	private void EBMEGEHJOFF(AKHNJNONFPF NNFELHIFAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7522FB0", Offset = "0x7521FB0", VA = "0x187522FB0")]
	private void JKPGJEBNJML(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7520120", Offset = "0x751F120", VA = "0x187520120")]
	private void DFBOEFNHDMK(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7521620", Offset = "0x7520620", VA = "0x187521620")]
	private void FFEOHJOBHNK(FEJLBHKHNGD JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7520F40", Offset = "0x751FF40", VA = "0x187520F40", Slot = "141")]
	protected virtual void ELDNDJCPBBL(FEJLBHKHNGD IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7521EF0", Offset = "0x7520EF0", VA = "0x187521EF0")]
	protected void GCINPFEENPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7521B20", Offset = "0x7520B20", VA = "0x187521B20")]
	protected void GACDMAFLFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x751F6C0", Offset = "0x751E6C0", VA = "0x18751F6C0", Slot = "142")]
	protected virtual IDisposable BDONJCELDMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class KIJCJKLOOEP
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x75270C0", Offset = "0x75260C0", VA = "0x1875270C0")]
	public static AKHNJNONFPF PFNEPHIKGDK(this AKHNJNONFPF IPGMKLKJGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7526EC0", Offset = "0x7525EC0", VA = "0x187526EC0")]
	public static bool GIEOMMHBFKF(this AKHNJNONFPF IPGMKLKJGEN, AKHNJNONFPF OLNNEMPGLNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7527020", Offset = "0x7526020", VA = "0x187527020")]
	public static bool JALMADLOKFH(this AKHNJNONFPF IPGMKLKJGEN, AKHNJNONFPF IIHBPBJBHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7526F60", Offset = "0x7525F60", VA = "0x187526F60")]
	public static FEJLBHKHNGD IDGLOKDFAML(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7526FB0", Offset = "0x7525FB0", VA = "0x187526FB0")]
	public static EAPBPJOMKLC IOJLJDHBEOE(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JPEDICHOJNL : PGBNCDEAMGG
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7526740", Offset = "0x7525740", VA = "0x187526740", Slot = "19")]
	public AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL, DIHCEFAEPDD PMNMDCCMPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "4")]
	public EJBHONCMKIP FHPNBKPCNIN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "5")]
	public NCFHMGKHKMM GPLANGGCLLH(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
	public FHAEJECMDBP BFIKDOKPHHF(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "7")]
	public HCICJCMOFNA PDEHLLOIIFN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "8")]
	public GHEECLJAANH NOCNIPDJNAB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "9")]
	public IBDGPDNBALL NEAJJIMAJBG(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "10")]
	public LECKKHMIGDK NCICHCHDNKM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "11")]
	public ADAECEIMPMI ABGKHHBHANM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "12")]
	public EBFHHJPCOKN GKIBHCOFAGB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "13")]
	public HDBCPJCONEE KCKDLGDBCKJ(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	public EKJKOMEGFEE MJDJOKKAAIM(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	public KADPPPIGKHB BFJNCKEAPKI(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	public GKHJLNGKDFL EMGBLOBEEEO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	public EHJLOADKFEI JPIHBLJGINF(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	public BABLMGDPMDK HLAGECIABLC(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public JPEDICHOJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "14")]
	private EKJKOMEGFEE NJGPNKFNAKL(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "15")]
	private KADPPPIGKHB FGBDCBHFIKD(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "16")]
	private GKHJLNGKDFL PPPFOBFPAJO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "17")]
	private EHJLOADKFEI APBLKIFGEAE(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "18")]
	private BABLMGDPMDK MKLGGBFKFID(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CPEGFBANFJI(typeof(PGBNCDEAMGG), new string[] { })]
public class AHKFBACICEB : PGBNCDEAMGG, PGDGDABKPIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly PGBNCDEAMGG ANLOLILPCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly PGBNCDEAMGG CDDOCJAIDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private HJMOPKJIFCO IHBCKLGPIIA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private PGBNCDEAMGG MBLBOIACNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x751D0B0", Offset = "0x751C0B0", VA = "0x18751D0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x751D300", Offset = "0x751C300", VA = "0x18751D300", Slot = "20")]
	public void InitReferences(KKPADIDKOMK MOLJCIFKDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x751CEC0", Offset = "0x751BEC0", VA = "0x18751CEC0", Slot = "4")]
	public EJBHONCMKIP FHPNBKPCNIN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x751D1B0", Offset = "0x751C1B0", VA = "0x18751D1B0", Slot = "5")]
	public NCFHMGKHKMM GPLANGGCLLH(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x751CCC0", Offset = "0x751BCC0", VA = "0x18751CCC0", Slot = "6")]
	public FHAEJECMDBP BFIKDOKPHHF(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x751D680", Offset = "0x751C680", VA = "0x18751D680", Slot = "7")]
	public HCICJCMOFNA PDEHLLOIIFN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x751D5E0", Offset = "0x751C5E0", VA = "0x18751D5E0", Slot = "8")]
	public GHEECLJAANH NOCNIPDJNAB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x751D540", Offset = "0x751C540", VA = "0x18751D540", Slot = "9")]
	public IBDGPDNBALL NEAJJIMAJBG(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x751D4A0", Offset = "0x751C4A0", VA = "0x18751D4A0", Slot = "10")]
	public LECKKHMIGDK NCICHCHDNKM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x751CB70", Offset = "0x751BB70", VA = "0x18751CB70", Slot = "11")]
	public ADAECEIMPMI ABGKHHBHANM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x751D110", Offset = "0x751C110", VA = "0x18751D110", Slot = "12")]
	public EBFHHJPCOKN GKIBHCOFAGB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x751D350", Offset = "0x751C350", VA = "0x18751D350", Slot = "13")]
	public HDBCPJCONEE KCKDLGDBCKJ(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x751D3F0", Offset = "0x751C3F0", VA = "0x18751D3F0")]
	public EKJKOMEGFEE MJDJOKKAAIM(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x751CD60", Offset = "0x751BD60", VA = "0x18751CD60")]
	public KADPPPIGKHB BFJNCKEAPKI(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x751CE10", Offset = "0x751BE10", VA = "0x18751CE10")]
	public GKHJLNGKDFL EMGBLOBEEEO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x751CC10", Offset = "0x751BC10", VA = "0x18751CC10")]
	public EHJLOADKFEI JPIHBLJGINF(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x751D250", Offset = "0x751C250", VA = "0x18751D250")]
	public BABLMGDPMDK HLAGECIABLC(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x751CF60", Offset = "0x751BF60", VA = "0x18751CF60", Slot = "19")]
	public AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL, DIHCEFAEPDD PMNMDCCMPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x751D720", Offset = "0x751C720", VA = "0x18751D720")]
	public AHKFBACICEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x751D3F0", Offset = "0x751C3F0", VA = "0x18751D3F0", Slot = "14")]
	private EKJKOMEGFEE NJGPNKFNAKL(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x751CD60", Offset = "0x751BD60", VA = "0x18751CD60", Slot = "15")]
	private KADPPPIGKHB FGBDCBHFIKD(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x751CE10", Offset = "0x751BE10", VA = "0x18751CE10", Slot = "16")]
	private GKHJLNGKDFL PPPFOBFPAJO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x751CC10", Offset = "0x751BC10", VA = "0x18751CC10", Slot = "17")]
	private EHJLOADKFEI APBLKIFGEAE(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x751D250", Offset = "0x751C250", VA = "0x18751D250", Slot = "18")]
	private BABLMGDPMDK MKLGGBFKFID(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KEDNOPAMGDH : EJBHONCMKIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCDDLLPCHEM(AKHNJNONFPF IPGMKLKJGEN);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBMAACIEDEH(AKHNJNONFPF IPGMKLKJGEN);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFGBGLMIGBH(AKHNJNONFPF NNFELHIFAKF);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KINNKGHEDEC(AKHNJNONFPF NNFELHIFAKF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FPKPBHHKLEM : FHAEJECMDBP
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IKJPHCKCAAO<AKHNJNONFPF> LCAPFCKGLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	AKHNJNONFPF KHOJDKAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GDFAFEODLAF : EHJLOADKFEI
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) OLBDNMBEFAN(Rigidbody DJFLLGFPAKO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AGEFHCBLGAG : KADPPPIGKHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView EOFGMHEAMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class BABDBFCJDGO : EBFHHJPCOKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private CollisionDetectionMode EFOBGBBOHFK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x751B850", Offset = "0x751A850", VA = "0x18751B850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode EFACACNIFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x751DD00", Offset = "0x751CD00", VA = "0x18751DD00", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x751DB60", Offset = "0x751CB60", VA = "0x18751DB60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x751C040", Offset = "0x751B040", VA = "0x18751C040")]
	public BABDBFCJDGO(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x751DBF0", Offset = "0x751CBF0", VA = "0x18751DBF0", Slot = "6")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x751DAE0", Offset = "0x751CAE0", VA = "0x18751DAE0", Slot = "9")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x751DBE0", Offset = "0x751CBE0", VA = "0x18751DBE0", Slot = "7")]
	public void LKFJCDHBMBC(bool MFAKABJBHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x751DBD0", Offset = "0x751CBD0", VA = "0x18751DBD0", Slot = "8")]
	public void LEFEBADBOHA(bool MFAKABJBHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x751D980", Offset = "0x751C980", VA = "0x18751D980", Slot = "10")]
	public bool CDGFEMBLDJA(Vector3 IKMGCHAHKMB, [Out] RaycastHit PICLEONLIDJ, float OCANAPGPKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x751DE10", Offset = "0x751CE10", VA = "0x18751DE10")]
	private void PNKIJOIDDIH(bool MFAKABJBHFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KFFEOKOGBHJ : IBDGPDNBALL, IDisposable, LKBGBEKOGHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HJCFABINHDE MHOAMNDGJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private OICHLINLOOD JMHJAGOPIIB;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HJCFABINHDE PMAHCBBJMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7526CF0", Offset = "0x7525CF0", VA = "0x187526CF0", Slot = "6")]
		get
		{
			return default(HJCFABINHDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7526B50", Offset = "0x7525B50", VA = "0x187526B50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MLNHJCEGABM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7526C20", Offset = "0x7525C20", VA = "0x187526C20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DJFOEHMHKBO, DJFOEHMHKBO> BCPJNGNDLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7526830", Offset = "0x7525830", VA = "0x187526830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7526C40", Offset = "0x7525C40", VA = "0x187526C40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7526E30", Offset = "0x7525E30", VA = "0x187526E30")]
	public KFFEOKOGBHJ(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x75268E0", Offset = "0x75258E0", VA = "0x1875268E0", Slot = "8")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x75267E0", Offset = "0x75257E0", VA = "0x1875267E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xD559C0", Offset = "0xD549C0", VA = "0x180D559C0", Slot = "11")]
	private void AMFDCJAFCCD(DJFOEHMHKBO OGCIJEGBFAE, DJFOEHMHKBO LEAOHHOLMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "12")]
	private void BKHHFCHDMKM(bool IMEKHNJIOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HCPBIPBNFCG : PGBNCDEAMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7525C40", Offset = "0x7524C40", VA = "0x187525C40", Slot = "4")]
	public EJBHONCMKIP FHPNBKPCNIN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7525F40", Offset = "0x7524F40", VA = "0x187525F40", Slot = "5")]
	public NCFHMGKHKMM GPLANGGCLLH(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7525850", Offset = "0x7524850", VA = "0x187525850", Slot = "6")]
	public FHAEJECMDBP BFIKDOKPHHF(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7526600", Offset = "0x7525600", VA = "0x187526600", Slot = "7")]
	public HCICJCMOFNA PDEHLLOIIFN(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7526530", Offset = "0x7525530", VA = "0x187526530", Slot = "8")]
	public GHEECLJAANH NOCNIPDJNAB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7526460", Offset = "0x7525460", VA = "0x187526460", Slot = "9")]
	public IBDGPDNBALL NEAJJIMAJBG(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7526340", Offset = "0x7525340", VA = "0x187526340", Slot = "10")]
	public LECKKHMIGDK NCICHCHDNKM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7525600", Offset = "0x7524600", VA = "0x187525600", Slot = "11")]
	public ADAECEIMPMI ABGKHHBHANM(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7525E80", Offset = "0x7524E80", VA = "0x187525E80", Slot = "12")]
	public EBFHHJPCOKN GKIBHCOFAGB(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7526140", Offset = "0x7525140", VA = "0x187526140", Slot = "13")]
	public HDBCPJCONEE KCKDLGDBCKJ(AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7526200", Offset = "0x7525200", VA = "0x187526200")]
	public EKJKOMEGFEE MJDJOKKAAIM(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7525980", Offset = "0x7524980", VA = "0x187525980")]
	public KADPPPIGKHB BFJNCKEAPKI(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7525B10", Offset = "0x7524B10", VA = "0x187525B10")]
	public GKHJLNGKDFL EMGBLOBEEEO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x75256C0", Offset = "0x75246C0", VA = "0x1875256C0")]
	public EHJLOADKFEI JPIHBLJGINF(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7526060", Offset = "0x7525060", VA = "0x187526060")]
	public BABLMGDPMDK HLAGECIABLC(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7525D30", Offset = "0x7524D30", VA = "0x187525D30", Slot = "19")]
	public AKHNJNONFPF FMJBJFMOKFL(RigidbodyEx IPGMKLKJGEN, ALGHBJPFMBB CONAFKKIHKL, DIHCEFAEPDD PMNMDCCMPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public HCPBIPBNFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7526200", Offset = "0x7525200", VA = "0x187526200", Slot = "14")]
	private EKJKOMEGFEE NJGPNKFNAKL(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7525980", Offset = "0x7524980", VA = "0x187525980", Slot = "15")]
	private KADPPPIGKHB FGBDCBHFIKD(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7525B10", Offset = "0x7524B10", VA = "0x187525B10", Slot = "16")]
	private GKHJLNGKDFL PPPFOBFPAJO(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x75256C0", Offset = "0x75246C0", VA = "0x1875256C0", Slot = "17")]
	private EHJLOADKFEI APBLKIFGEAE(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7526060", Offset = "0x7525060", VA = "0x187526060", Slot = "18")]
	private BABLMGDPMDK MKLGGBFKFID(AKHNJNONFPF PHOINLFJEFI, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class AAIIGDPNMIF : ADAECEIMPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x751B850", Offset = "0x751A850", VA = "0x18751B850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool KEMMFALEJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x751B440", Offset = "0x751A440", VA = "0x18751B440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool GBKEFOHBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x751B280", Offset = "0x751A280", VA = "0x18751B280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private AKHNJNONFPF CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x751B8A0", Offset = "0x751A8A0", VA = "0x18751B8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x751C040", Offset = "0x751B040", VA = "0x18751C040")]
	public AAIIGDPNMIF(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x751B2E0", Offset = "0x751A2E0", VA = "0x18751B2E0", Slot = "4")]
	public void DEGLJFIFLPK(Vector3 OCPABOGIINL, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x751B5F0", Offset = "0x751A5F0", VA = "0x18751B5F0")]
	private void IBNCKBINICI(Vector3 OCPABOGIINL, ForceMode DHEPCFAGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x751BDC0", Offset = "0x751ADC0", VA = "0x18751BDC0", Slot = "5")]
	public void OBFELPGOEBF(Vector3 OCPABOGIINL, Vector3 PAMMLHPIJIB, ForceMode DHEPCFAGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x751B490", Offset = "0x751A490", VA = "0x18751B490", Slot = "6")]
	public void GFAFBNAMHIG(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x751BB60", Offset = "0x751AB60", VA = "0x18751BB60")]
	private void NHJGAHMEGBL(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x751B900", Offset = "0x751A900", VA = "0x18751B900", Slot = "7")]
	public void NGAEDBBMLLB(Vector3 HPAOLKEDMCC, ForceMode DHEPCFAGBLI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class AMLKBAEEBGJ : HDBCPJCONEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool KDOCKMBDLAB;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BBLGDPIHGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x751D870", Offset = "0x751C870", VA = "0x18751D870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x751C040", Offset = "0x751B040", VA = "0x18751C040")]
	public AMLKBAEEBGJ(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x751D840", Offset = "0x751C840", VA = "0x18751D840", Slot = "6")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x751D7D0", Offset = "0x751C7D0", VA = "0x18751D7D0", Slot = "7")]
	public void ADEJCDFOECN(Rigidbody IMEDPEAFOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class NMABMELBEDI : KEDNOPAMGDH, EJBHONCMKIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AKHNJNONFPF IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly List<AKHNJNONFPF> AMPHOBAHPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private AKHNJNONFPF BAOAKGNNKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private AKHNJNONFPF JNLBEALAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Transform JOPHGKHMLKB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x752EE20", Offset = "0x752DE20", VA = "0x18752EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public AKHNJNONFPF CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4260", Offset = "0x8B3260", VA = "0x1808B4260", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x752FF80", Offset = "0x752EF80", VA = "0x18752FF80", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public AKHNJNONFPF ALCFFKKOPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B3270", VA = "0x1808B4270", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<AKHNJNONFPF> CILOAPIDAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B4290", Offset = "0x8B3290", VA = "0x1808B4290", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MDCOCNFPMGL BEMNMPMHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x75303B0", Offset = "0x752F3B0", VA = "0x1875303B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x752FF90", Offset = "0x752EF90", VA = "0x18752FF90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MDCOCNFPMGL NLBEPNFOIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x752F100", Offset = "0x752E100", VA = "0x18752F100", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x752EAF0", Offset = "0x752DAF0", VA = "0x18752EAF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LECCBHNGBKB JBGPEMEOJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x752EC30", Offset = "0x752DC30", VA = "0x18752EC30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x752F060", Offset = "0x752E060", VA = "0x18752F060", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action JOLMKFKOMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x75306D0", Offset = "0x752F6D0", VA = "0x1875306D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x752FC60", Offset = "0x752EC60", VA = "0x18752FC60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CBHLJGNACEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7530770", Offset = "0x752F770", VA = "0x187530770", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7530580", Offset = "0x752F580", VA = "0x187530580", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AKHNJNONFPF> IBMBPOBNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x752F870", Offset = "0x752E870", VA = "0x18752F870", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x752F240", Offset = "0x752E240", VA = "0x18752F240", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AKHNJNONFPF> EHMIDOJCAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7530620", Offset = "0x752F620", VA = "0x187530620", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x752ECD0", Offset = "0x752DCD0", VA = "0x18752ECD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IJFOADCGPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x752FE40", Offset = "0x752EE40", VA = "0x18752FE40", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x752F1A0", Offset = "0x752E1A0", VA = "0x18752F1A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AKHNJNONFPF> PHKMCAHJDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x752EFB0", Offset = "0x752DFB0", VA = "0x18752EFB0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x752EA00", Offset = "0x752DA00", VA = "0x18752EA00", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7530810", Offset = "0x752F810", VA = "0x187530810")]
	public NMABMELBEDI(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x752ED80", Offset = "0x752DD80", VA = "0x18752ED80", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x752F2F0", Offset = "0x752E2F0", VA = "0x18752F2F0", Slot = "30")]
	public void IMAOJFCAENJ(AKHNJNONFPF LNEILPPCDKB, bool BDOONMIDCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7530030", Offset = "0x752F030", VA = "0x187530030", Slot = "6")]
	public void NFGBGLMIGBH(AKHNJNONFPF NNFELHIFAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x752F9E0", Offset = "0x752E9E0", VA = "0x18752F9E0", Slot = "7")]
	public void KINNKGHEDEC(AKHNJNONFPF NNFELHIFAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x75302A0", Offset = "0x752F2A0", VA = "0x1875302A0", Slot = "4")]
	public void OCDDLLPCHEM(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x752EB90", Offset = "0x752DB90", VA = "0x18752EB90", Slot = "5")]
	public void CBMAACIEDEH(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x752FEE0", Offset = "0x752EEE0", VA = "0x18752FEE0")]
	private void MBCPOALKBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x752EAB0", Offset = "0x752DAB0", VA = "0x18752EAB0")]
	private void AKHEBKEJJKA(AKHNJNONFPF NNFELHIFAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x752FD00", Offset = "0x752ED00", VA = "0x18752FD00")]
	private void LBKODHFHEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x752EE80", Offset = "0x752DE80", VA = "0x18752EE80")]
	private void FGKEDPIIOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7530450", Offset = "0x752F450", VA = "0x187530450")]
	private void OGAMMAPNBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x752F920", Offset = "0x752E920", VA = "0x18752F920")]
	[CompilerGenerated]
	private object KCNMAOBNEBP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CNLHIMJPIJO
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x751ED00", Offset = "0x751DD00", VA = "0x18751ED00")]
	public static KEDNOPAMGDH EHBJOOMLAJB(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CLKHEBCAEOM : FPKPBHHKLEM, FHAEJECMDBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly IKJPHCKCAAO<AKHNJNONFPF> DEBGMNGKLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool CFGLBMCBMFL;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IKJPHCKCAAO<AKHNJNONFPF> LCAPFCKGLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EAJOCDAEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x751E070", Offset = "0x751D070", VA = "0x18751E070", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DADPDBLHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x751EA40", Offset = "0x751DA40", VA = "0x18751EA40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 OPEMPCBIMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x751E880", Offset = "0x751D880", VA = "0x18751E880")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public AKHNJNONFPF KHOJDKAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x751E440", Offset = "0x751D440", VA = "0x18751E440", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x751EC00", Offset = "0x751DC00", VA = "0x18751EC00")]
	public CLKHEBCAEOM(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x751E9D0", Offset = "0x751D9D0", VA = "0x18751E9D0", Slot = "8")]
	public void PAAAOFBCCKB(AKHNJNONFPF JNLBEALAMNB, object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x751E970", Offset = "0x751D970", VA = "0x18751E970", Slot = "9")]
	public void OAFAIJDALFA(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x751E0A0", Offset = "0x751D0A0", VA = "0x18751E0A0")]
	private Vector3 GDCHNCEKEGO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x751E4F0", Offset = "0x751D4F0", VA = "0x18751E4F0")]
	private void MBPJHELNAPG(AKHNJNONFPF OCEDAANFMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EOOFOHDFCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7524E20", Offset = "0x7523E20", VA = "0x187524E20")]
	public static FPKPBHHKLEM EGMGDEFALKP(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NGJHPPGEMAF : GDFAFEODLAF, EHJLOADKFEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 AFCAJCHKJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OverridableVector3 HELHLEJOBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float NAEBBHHCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float GIGICIOALEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3 CBPHNLELMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Vector3? JIKPFJEBGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Quaternion? KANLHAAKCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool MNLPBJAEHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool AFIANADJKGB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CFBBKOCECBA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1156560", Offset = "0x1155560", VA = "0x181156560", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x752CB80", Offset = "0x752BB80", VA = "0x18752CB80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 AFPGIHPPDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x752D8A0", Offset = "0x752C8A0", VA = "0x18752D8A0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BNIEFEKAHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x95FC20", Offset = "0x95EC20", VA = "0x18095FC20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x752CC30", Offset = "0x752BC30", VA = "0x18752CC30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FHPKLFPAPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x95FBE0", Offset = "0x95EBE0", VA = "0x18095FBE0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x752CAD0", Offset = "0x752BAD0", VA = "0x18752CAD0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 OADPDHGGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x752D1C0", Offset = "0x752C1C0", VA = "0x18752D1C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion NPMOBGMBGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x752CDE0", Offset = "0x752BDE0", VA = "0x18752CDE0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x752D850", Offset = "0x752C850", VA = "0x18752D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MDCOCNFPMGL KDGIEEIHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x752CD40", Offset = "0x752BD40", VA = "0x18752CD40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x752E800", Offset = "0x752D800", VA = "0x18752E800", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x752E8A0", Offset = "0x752D8A0", VA = "0x18752E8A0")]
	public NGJHPPGEMAF(AKHNJNONFPF IPGMKLKJGEN, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x752D350", Offset = "0x752C350", VA = "0x18752D350", Slot = "17")]
	public void JDOHJNEKHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x752C6D0", Offset = "0x752B6D0", VA = "0x18752C6D0", Slot = "16")]
	public void BCMDIEBOEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x752D0E0", Offset = "0x752C0E0", VA = "0x18752D0E0", Slot = "19")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x752C060", Offset = "0x752B060", VA = "0x18752C060", Slot = "20")]
	public void ADEJCDFOECN(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x752D6A0", Offset = "0x752C6A0", VA = "0x18752D6A0", Slot = "18")]
	public void LDNLMGCBJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x752C240", Offset = "0x752B240", VA = "0x18752C240", Slot = "21")]
	public void BBOELKAJKID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x752CB80", Offset = "0x752BB80", VA = "0x18752CB80")]
	private void GHBFFLJHGLG(Vector3 BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x752C9E0", Offset = "0x752B9E0", VA = "0x18752C9E0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CHNNDNKFMEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x752CC30", Offset = "0x752BC30", VA = "0x18752CC30")]
	private void JLEMGPOBLJO(float BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x752CAD0", Offset = "0x752BAD0", VA = "0x18752CAD0")]
	private void CPHNNDMOPIN(float BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x752D500", Offset = "0x752C500", VA = "0x18752D500")]
	private Vector3 KPIFFOBEBEC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x752C7B0", Offset = "0x752B7B0", VA = "0x18752C7B0", Slot = "15")]
	public void CDLEEBMGJPA((Quaternion rot, Vector3 moments) BDCEEOCLFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x752CF60", Offset = "0x752BF60", VA = "0x18752CF60")]
	private Quaternion FKLBJCNJDPL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x752E730", Offset = "0x752D730", VA = "0x18752E730")]
	public void OLBDNMBEFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x752D990", Offset = "0x752C990", VA = "0x18752D990", Slot = "4")]
	public (float, Vector3) OLBDNMBEFAN(Rigidbody DJFLLGFPAKO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class JDMHNCFFPCN
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7526680", Offset = "0x7525680", VA = "0x187526680")]
	public static GDFAFEODLAF OMFDEDGAEGE(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ABJIDMEJLOK : GKHJLNGKDFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MPAMFIMFCFF CLKNCCGFOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BJBOIDJKKGM BHFCKEOBCFF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool EGLCMBPDIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x130C0A0", Offset = "0x130B0A0", VA = "0x18130C0A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public BJBOIDJKKGM NKLBOBJCAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600", Slot = "11")]
		get
		{
			return default(BJBOIDJKKGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x751C7A0", Offset = "0x751B7A0", VA = "0x18751C7A0")]
	public ABJIDMEJLOK(AKHNJNONFPF IPGMKLKJGEN, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x751C5C0", Offset = "0x751B5C0", VA = "0x18751C5C0", Slot = "4")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x751C190", Offset = "0x751B190", VA = "0x18751C190")]
	private bool AIBEGMGHNFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x751C270", Offset = "0x751B270", VA = "0x18751C270", Slot = "5")]
	public void BCOBANOHBCC(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x751C590", Offset = "0x751B590", VA = "0x18751C590", Slot = "6")]
	public void JPMCEFJOIOP(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x751C460", Offset = "0x751B460", VA = "0x18751C460", Slot = "9")]
	public void INAEAELHHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x751C690", Offset = "0x751B690", VA = "0x18751C690")]
	private void PAINCMALPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x751C2E0", Offset = "0x751B2E0", VA = "0x18751C2E0")]
	private void HHJJPCJEGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x751C2A0", Offset = "0x751B2A0", VA = "0x18751C2A0", Slot = "8")]
	public void DAJDAJJMGOE(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x751C230", Offset = "0x751B230", VA = "0x18751C230", Slot = "7")]
	public void AJJJEOGOHAN(AKHNJNONFPF IPGMKLKJGEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FDOCFMNCKNB : LECKKHMIGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MPAMFIMFCFF DJAGNIAAKPB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool KEMMFALEJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7524F10", Offset = "0x7523F10", VA = "0x187524F10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MDCOCNFPMGL GMIAJKAPOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7525150", Offset = "0x7524150", VA = "0x187525150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7525240", Offset = "0x7524240", VA = "0x187525240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x75252F0", Offset = "0x75242F0", VA = "0x1875252F0")]
	public FDOCFMNCKNB(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7525230", Offset = "0x7524230", VA = "0x187525230", Slot = "7")]
	public void LEMLLCGAIHK(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x75252E0", Offset = "0x75242E0", VA = "0x1875252E0", Slot = "8")]
	public void OEOIHDOKAOF(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7524FC0", Offset = "0x7523FC0", VA = "0x187524FC0", Slot = "9")]
	public void FEDFCNAEPFP(object NANMDIJGGLP, bool NDIICNIHPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x75251F0", Offset = "0x75241F0", VA = "0x1875251F0", Slot = "12")]
	public void IMIBIFAPKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x75250D0", Offset = "0x75240D0", VA = "0x1875250D0", Slot = "10")]
	public void FLEIGIBNGKO(Rigidbody MIGHIIBDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7524EE0", Offset = "0x7523EE0", VA = "0x187524EE0", Slot = "11")]
	public void ADEJCDFOECN(Rigidbody IMEDPEAFOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OHCPAELGMHD : AGEFHCBLGAG, KADPPPIGKHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private PhotonView AKICAIGKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool JEBDAALDMGA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView EOFGMHEAMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool ECDLHGDFBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7531450", Offset = "0x7530450", VA = "0x187531450", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool OGJGJKAOELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA39CA0", Offset = "0xA38CA0", VA = "0x180A39CA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MDCOCNFPMGL KEMGAKEDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7530DB0", Offset = "0x752FDB0", VA = "0x187530DB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x75313B0", Offset = "0x75303B0", VA = "0x1875313B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7531470", Offset = "0x7530470", VA = "0x187531470")]
	public OHCPAELGMHD(AKHNJNONFPF IPGMKLKJGEN, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7531110", Offset = "0x7530110", VA = "0x187531110", Slot = "9")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7530CB0", Offset = "0x752FCB0", VA = "0x187530CB0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7530FA0", Offset = "0x752FFA0", VA = "0x187530FA0", Slot = "10")]
	public void JKPGJEBNJML(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7530B40", Offset = "0x752FB40", VA = "0x187530B40", Slot = "11")]
	public void DFBOEFNHDMK(AKHNJNONFPF JNLBEALAMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7531240", Offset = "0x7530240", VA = "0x187531240")]
	private void MBOGCLCHOEF(PhotonView BMDIHIGKEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7530E50", Offset = "0x752FE50", VA = "0x187530E50")]
	private void HLDEBOMOFDH(FEJLBHKHNGD JBNJKDHCBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x75308D0", Offset = "0x752F8D0", VA = "0x1875308D0")]
	private void AFHCDBMMOBK(PhotonView BMMLGIDBPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class ABGOMNFHKLK
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x751C0D0", Offset = "0x751B0D0", VA = "0x18751C0D0")]
	public static AGEFHCBLGAG OECMCDPFKMO(this AKHNJNONFPF PHOINLFJEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OIPMFPHEPFL : BABLMGDPMDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RigidbodyConstraints BIGLDLOJOLB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HPEOKFGCHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x904DF0", Offset = "0x903DF0", VA = "0x180904DF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x49AF2A0", Offset = "0x49AE2A0", VA = "0x1849AF2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ICPIJDEADFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xC5F1D0", Offset = "0xC5E1D0", VA = "0x180C5F1D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x49AF290", Offset = "0x49AE290", VA = "0x1849AF290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints OPJFJICGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7531620", Offset = "0x7530620", VA = "0x187531620", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7531750", Offset = "0x7530750", VA = "0x187531750")]
	public OIPMFPHEPFL(AKHNJNONFPF IPGMKLKJGEN, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x75315F0", Offset = "0x75305F0", VA = "0x1875315F0", Slot = "9")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x75315C0", Offset = "0x75305C0", VA = "0x1875315C0", Slot = "10")]
	public void ADEJCDFOECN(Rigidbody IMEDPEAFOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class AFBIKLNDDHJ : HCICJCMOFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly AKHNJNONFPF IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float EIBKJKGFOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private float IHEIHEJADLH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float CIGOPJMKKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xB2DDE0", Offset = "0xB2CDE0", VA = "0x180B2DDE0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x751C940", Offset = "0x751B940", VA = "0x18751C940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float DJBGNDLNAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A7610", Offset = "0x9A6610", VA = "0x1809A7610", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x751CA60", Offset = "0x751BA60", VA = "0x18751CA60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x751CB30", Offset = "0x751BB30", VA = "0x18751CB30")]
	public AFBIKLNDDHJ(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x751CA10", Offset = "0x751BA10", VA = "0x18751CA10", Slot = "8")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x751C8A0", Offset = "0x751B8A0", VA = "0x18751C8A0", Slot = "9")]
	public void ADEJCDFOECN(Rigidbody IMEDPEAFOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class MEGPOOHPBAJ : GHEECLJAANH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private NOFJDNKBMKA LIKAOGBPBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool FFNFNFMOMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool FODIMFDFBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int NBADINIBHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool IMDJHELGALH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x752BBC0", Offset = "0x752ABC0", VA = "0x18752BBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool ONFHACJGFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x752B580", Offset = "0x752A580", VA = "0x18752B580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private AKHNJNONFPF CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x752BC10", Offset = "0x752AC10", VA = "0x18752BC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool GBKEFOHBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x752B230", Offset = "0x752A230", VA = "0x18752B230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MDCOCNFPMGL AAIGBKNPEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x752B190", Offset = "0x752A190", VA = "0x18752B190", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x752BE30", Offset = "0x752AE30", VA = "0x18752BE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x752BFD0", Offset = "0x752AFD0", VA = "0x18752BFD0")]
	public MEGPOOHPBAJ(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x752BC70", Offset = "0x752AC70", VA = "0x18752BC70", Slot = "6")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x752B4A0", Offset = "0x752A4A0", VA = "0x18752B4A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x752BFC0", Offset = "0x752AFC0", VA = "0x18752BFC0", Slot = "8")]
	public void OGAOIIFAGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x752B5A0", Offset = "0x752A5A0", VA = "0x18752B5A0", Slot = "7")]
	public bool ENIEOIGNHIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x752BED0", Offset = "0x752AED0", VA = "0x18752BED0", Slot = "9")]
	public void NMHEPFBJECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x752B6F0", Offset = "0x752A6F0", VA = "0x18752B6F0")]
	private void GMGJECKKLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x752B990", Offset = "0x752A990", VA = "0x18752B990", Slot = "11")]
	public void KGLKHHKEIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x752B290", Offset = "0x752A290", VA = "0x18752B290", Slot = "10")]
	public void DCNLGNEHOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x752B7B0", Offset = "0x752A7B0", VA = "0x18752B7B0")]
	private bool HNPNMKCNAFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x752BA30", Offset = "0x752AA30", VA = "0x18752BA30")]
	private void KLMJKFMALHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MEAJNPJBALL : EKJKOMEGFEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly MPAMFIMFCFF GPJOEDNAOJI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody NJJKCCDDEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool GBKEFOHBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x751B280", Offset = "0x751A280", VA = "0x18751B280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool EGIHACKOINH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x130C0A0", Offset = "0x130B0A0", VA = "0x18130C0A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x752B080", Offset = "0x752A080", VA = "0x18752B080")]
	public MEAJNPJBALL(AKHNJNONFPF IPGMKLKJGEN, [In] ALGHBJPFMBB CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x752AB30", Offset = "0x7529B30", VA = "0x18752AB30", Slot = "5")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x752AB00", Offset = "0x7529B00", VA = "0x18752AB00", Slot = "7")]
	public void KKAMLFFFPIK(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x752A8E0", Offset = "0x75298E0", VA = "0x18752A8E0", Slot = "8")]
	public void DBJOECHLLDN(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x752AD50", Offset = "0x7529D50", VA = "0x18752AD50", Slot = "9")]
	public void NOONIEFPEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x752A910", Offset = "0x7529910", VA = "0x18752A910", Slot = "10")]
	public void HMBMIFEPHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x752ABD0", Offset = "0x7529BD0", VA = "0x18752ABD0", Slot = "11")]
	public void MEOJIPOKCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MBJHDINEHEM : NCFHMGKHKMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EAPBPJOMKLC IPGMKLKJGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MPAMFIMFCFF HNOBMIMCJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float NDBOODBGHDN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ONDEDAHJONB JHIHEHEIGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public NDJCFNMENCK DPIEMOJLNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 OPEMPCBIMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x75298D0", Offset = "0x75288D0", VA = "0x1875298D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7528BA0", Offset = "0x7527BA0", VA = "0x187528BA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 NBBCALIIIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7527B50", Offset = "0x7526B50", VA = "0x187527B50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7527C70", Offset = "0x7526C70", VA = "0x187527C70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 PLFLAEHBFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7528DD0", Offset = "0x7527DD0", VA = "0x187528DD0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7528AE0", Offset = "0x7527AE0", VA = "0x187528AE0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JEFIHANGHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7527890", Offset = "0x7526890", VA = "0x187527890", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7528AB0", Offset = "0x7527AB0", VA = "0x187528AB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float LGJBNCCABEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xC5F210", Offset = "0xC5E210", VA = "0x180C5F210", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7527E20", Offset = "0x7526E20", VA = "0x187527E20", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JPEFHMBDIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1C57490", Offset = "0x1C56490", VA = "0x181C57490", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ADAECEIMPMI IIEMOJKFCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6D13C30", Offset = "0x6D12C30", VA = "0x186D13C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool ONFHACJGFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7527D00", Offset = "0x7526D00", VA = "0x187527D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x752A7F0", Offset = "0x75297F0", VA = "0x18752A7F0")]
	public MBJHDINEHEM(AKHNJNONFPF IPGMKLKJGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7527D20", Offset = "0x7526D20", VA = "0x187527D20", Slot = "19")]
	public void MBMDLPFFOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7527CA0", Offset = "0x7526CA0", VA = "0x187527CA0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7528980", Offset = "0x7527980", VA = "0x187528980", Slot = "28")]
	public void FLEIGIBNGKO(Rigidbody IMEDPEAFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x11187B0", Offset = "0x11177B0", VA = "0x1811187B0", Slot = "20")]
	public void NENJBDAPEIL(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1117500", Offset = "0x1116500", VA = "0x181117500", Slot = "30")]
	public void HBJKNNAPBIE(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7529A20", Offset = "0x7528A20", VA = "0x187529A20", Slot = "35")]
	public Vector3 OMPDIGGFIPI(Vector3 LHHOGDBNLML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x75276D0", Offset = "0x75266D0", VA = "0x1875276D0", Slot = "34")]
	public Vector3 AGHGBBENDEL(Vector3 AILEJDCFILE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7527D20", Offset = "0x7526D20", VA = "0x187527D20", Slot = "27")]
	public void EAOMIBNNAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x7528CC0", Offset = "0x7527CC0", VA = "0x187528CC0", Slot = "25")]
	public void HOGJFFAKAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7528C60", Offset = "0x7527C60", VA = "0x187528C60", Slot = "24")]
	public void HJDEDLCAKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7528740", Offset = "0x7527740", VA = "0x187528740", Slot = "33")]
	public void FFILGFJHDIL(Vector3 ACBOLABNEEC, Vector3 NOFPLPBOOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7527DC0", Offset = "0x7526DC0", VA = "0x187527DC0", Slot = "32")]
	public void ECAFOBPNBOK(Vector3 HEDNFJFIFCK, Vector3 BOBFECAGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7528010", Offset = "0x7527010", VA = "0x187528010", Slot = "31")]
	public void EKLAFIHBKPP(Vector3 LEEPGGPHONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7529C00", Offset = "0x7528C00", VA = "0x187529C00", Slot = "22")]
	public void OPIKHFMBCNB(LMIMIJBONNN HBMFKGKENDH, Vector3 AKKHKOGDNKH, float JOBCMFOMHOP, float ELFKNNFHBFC = 8f, float PECLEMMEGFM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7529530", Offset = "0x7528530", VA = "0x187529530", Slot = "21")]
	public void MLMEGHJFEJB(LJAEDMAHHKF AGGJIANGPHP, Vector3 BPEPPABJCOI, float MBDACAEELBM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7527250", Offset = "0x7526250", VA = "0x187527250", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ABNHDNMHEJH(LJAEDMAHHKF AGGJIANGPHP, Vector3 JKJHCABJJIO, float EGHAKJENMLO = 7f, float FDIBJKLEEJH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1239420", Offset = "0x1238420", VA = "0x181239420")]
	private static void PKNKIFBELON(Vector3 DLJIHGEKHEP, Vector3 LCMGGHKGECO, [Out] Vector3 PKIAMOPDACH, [Out] Vector3 BCOMKAOANNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7527F30", Offset = "0x7526F30", VA = "0x187527F30", Slot = "29")]
	public Vector3 EKJGCKKJONM(Vector3 DLJIHGEKHEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x75293A0", Offset = "0x75283A0", VA = "0x1875293A0", Slot = "26")]
	public void KPJHKIJBAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7527E20", Offset = "0x7526E20", VA = "0x187527E20")]
	private void KMMEKKCIDIB(float BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x75279B0", Offset = "0x75269B0", VA = "0x1875279B0")]
	private void BHPEMKIHOCN(Vector3 BPEPPABJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7528630", Offset = "0x7527630", VA = "0x187528630")]
	private Vector3 FAPHDBEJFPE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x75281B0", Offset = "0x75271B0", VA = "0x1875281B0")]
	private void EMBLGGONGPM(Vector3 AILEJDCFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x75297B0", Offset = "0x75287B0", VA = "0x1875297B0")]
	private Vector3 NKBNCKKBLOC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7528F20", Offset = "0x7527F20", VA = "0x187528F20")]
	private void KJGPHODHNNH(Vector3 BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x752A250", Offset = "0x7529250", VA = "0x18752A250")]
	private void PLFAECIDJLL(Vector3 AILEJDCFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7528D20", Offset = "0x7527D20", VA = "0x187528D20")]
	private void IFIJACJAFIO()
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
