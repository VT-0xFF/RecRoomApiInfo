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
	public class LogRegistrationIndex : KGHKLAJDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67EF420", Offset = "0x67EE220", VA = "0x1867EF420", Slot = "4")]
		public override void GEBEKKCKBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
	public class _AssemblyIndex : FIMMIOHCHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HLCBOADGLMF bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x135B0D0", Offset = "0x1359ED0", VA = "0x18135B0D0", Slot = "5")]
		public override void JMDPNECFGBJ(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67FA2C0", Offset = "0x67F90C0", VA = "0x1867FA2C0")]
		private void ALEDFJENALM(GHFIOEGMBOH registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67FA260", Offset = "0x67F9060", VA = "0x1867FA260", Slot = "6")]
		public override void ADBCMJOMFPM(GHFIOEGMBOH registry, [In] FJBHLFEMEAA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "8")]
		public override void PMLABOBIDNF(KLINEBNHAFG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67FA5C0", Offset = "0x67F93C0", VA = "0x1867FA5C0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, CJBNPFDPBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly JNOMMELLEMA NBGFFOLKJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JFONPGLDJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AKGHONDNBFH PAJLDBCANGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[IMNLDENHNLG(KLKJAELFHOF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IMNLDENHNLG(KLKJAELFHOF.SelfAndParent, true, false, false)]
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
		private HOHJIBLCPPE physicsInterpolation;

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
		internal AKGHONDNBFH IAFJCNLFJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67F5AB0", Offset = "0x67F48B0", VA = "0x1867F5AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AKGHONDNBFH AAKCIMBIMOI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GDNKIELLEMI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67F76D0", Offset = "0x67F64D0", VA = "0x1867F76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DMIIMAHHCAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x67F7A30", Offset = "0x67F6830", VA = "0x1867F7A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OLBMHECMJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67F7970", Offset = "0x67F6770", VA = "0x1867F7970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx OGCHMLDLLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67F86D0", Offset = "0x67F74D0", VA = "0x1867F86D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67F9BD0", Offset = "0x67F89D0", VA = "0x1867F9BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform EFALPNEADAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7D89E0", Offset = "0x7D77E0", VA = "0x1807D89E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HGPOKOHBALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D89E0", Offset = "0x7D77E0", VA = "0x1807D89E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KCLBDKBPBDN IEJKKMMOANH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x67F7730", Offset = "0x67F6530", VA = "0x1867F7730")]
			get
			{
				return default(KCLBDKBPBDN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x67F9380", Offset = "0x67F8180", VA = "0x1867F9380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NGPEMOIEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67F7D40", Offset = "0x67F6B40", VA = "0x1867F7D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DMFHGMAJOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67F7850", Offset = "0x67F6650", VA = "0x1867F7850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NBCOLHOOHLA LIBEDDGLDEC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67F7C80", Offset = "0x67F6A80", VA = "0x1867F7C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x67F9540", Offset = "0x67F8340", VA = "0x1867F9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IPMNNOHAGGH KEDDGLJGBOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x67F7C20", Offset = "0x67F6A20", VA = "0x1867F7C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x67F94D0", Offset = "0x67F82D0", VA = "0x1867F94D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool EHBJIEEACAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x67F7B70", Offset = "0x67F6970", VA = "0x1867F7B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody KHNHAENIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x67F7BD0", Offset = "0x67F69D0", VA = "0x1867F7BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HPEMPGOJNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x67F78B0", Offset = "0x67F66B0", VA = "0x1867F78B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67F93F0", Offset = "0x67F81F0", VA = "0x1867F93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EHMCAKFPMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5F85FF0", Offset = "0x5F84DF0", VA = "0x185F85FF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KLOLLNHBEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67F8670", Offset = "0x67F7470", VA = "0x1867F8670")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float GGKHMKMJJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67F8610", Offset = "0x67F7410", VA = "0x1867F8610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x67F9B60", Offset = "0x67F8960", VA = "0x1867F9B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GCNJANMKHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67F7FA0", Offset = "0x67F6DA0", VA = "0x1867F7FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67F97E0", Offset = "0x67F85E0", VA = "0x1867F97E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GMNCHFOEOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x67F7DA0", Offset = "0x67F6BA0", VA = "0x1867F7DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x67F95B0", Offset = "0x67F83B0", VA = "0x1867F95B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GPCCFCGNBBG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x67F8C20", Offset = "0x67F7A20", VA = "0x1867F8C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x67FA110", Offset = "0x67F8F10", VA = "0x1867FA110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 BPFKIFENBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x67F83F0", Offset = "0x67F71F0", VA = "0x1867F83F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x67F9930", Offset = "0x67F8730", VA = "0x1867F9930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 ENFFFMCBNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x67F8D60", Offset = "0x67F7B60", VA = "0x1867F8D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode HJPIBPOAENF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x67F7EE0", Offset = "0x67F6CE0", VA = "0x1867F7EE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x67F9700", Offset = "0x67F8500", VA = "0x1867F9700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float GDDDCPAMJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x67F7910", Offset = "0x67F6710", VA = "0x1867F7910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x67F9460", Offset = "0x67F8260", VA = "0x1867F9460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints AFHMPPHFBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x67F7F40", Offset = "0x67F6D40", VA = "0x1867F7F40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x67F9770", Offset = "0x67F8570", VA = "0x1867F9770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 EPKBIKJFCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67F8790", Offset = "0x67F7590", VA = "0x1867F8790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LDHMJPLOHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x67F8790", Offset = "0x67F7590", VA = "0x1867F8790")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x67F9EF0", Offset = "0x67F8CF0", VA = "0x1867F9EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NDBJANJICJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67F84D0", Offset = "0x67F72D0", VA = "0x1867F84D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67F9A10", Offset = "0x67F8810", VA = "0x1867F9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MKNOOGKJIGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67F8BC0", Offset = "0x67F79C0", VA = "0x1867F8BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x67FA0A0", Offset = "0x67F8EA0", VA = "0x1867FA0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion HHMGOPMPEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x67F8870", Offset = "0x67F7670", VA = "0x1867F8870")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67F9C70", Offset = "0x67F8A70", VA = "0x1867F9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BBGCPFFJLKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x67F8AF0", Offset = "0x67F78F0", VA = "0x1867F8AF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67F9FD0", Offset = "0x67F8DD0", VA = "0x1867F9FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 HHLDLLLDFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67F8940", Offset = "0x67F7740", VA = "0x1867F8940")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x67F9D40", Offset = "0x67F8B40", VA = "0x1867F9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NGJLOBOLGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x67F8A20", Offset = "0x67F7820", VA = "0x1867F8A20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x67F9E20", Offset = "0x67F8C20", VA = "0x1867F9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PKCNPDCOCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x67F8C80", Offset = "0x67F7A80", VA = "0x1867F8C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x67FA180", Offset = "0x67F8F80", VA = "0x1867FA180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JJEHMIEJHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x67F8530", Offset = "0x67F7330", VA = "0x1867F8530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x67F9A80", Offset = "0x67F8880", VA = "0x1867F9A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 JHCGPEPGKKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x67F7E00", Offset = "0x67F6C00", VA = "0x1867F7E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x67F9620", Offset = "0x67F8420", VA = "0x1867F9620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LKIGCGOOIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x67F8310", Offset = "0x67F7110", VA = "0x1867F8310")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x67F9850", Offset = "0x67F8650", VA = "0x1867F9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 PPDGJPEPHFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67F81D0", Offset = "0x67F6FD0", VA = "0x1867F81D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion BOGDKECCPFP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x67F8100", Offset = "0x67F6F00", VA = "0x1867F8100")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BEOEDHKDALJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67F8F20", Offset = "0x67F7D20", VA = "0x1867F8F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NJMGHGKEGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x67F8E40", Offset = "0x67F7C40", VA = "0x1867F8E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OFPPLCANFFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x67F82B0", Offset = "0x67F70B0", VA = "0x1867F82B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HFLBHCECNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67F7CE0", Offset = "0x67F6AE0", VA = "0x1867F7CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AJELDMMDIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67F77F0", Offset = "0x67F65F0", VA = "0x1867F77F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NNMKFCFPEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67F7790", Offset = "0x67F6590", VA = "0x1867F7790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AJJFIHHHDPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67F7670", Offset = "0x67F6470", VA = "0x1867F7670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BAAIPNDDCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67F8000", Offset = "0x67F6E00", VA = "0x1867F8000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HLCDKGLKBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x52EBF60", Offset = "0x52EAD60", VA = "0x1852EBF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BPNEMCMFOAO DHNGNIEMHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x67F7590", Offset = "0x67F6390", VA = "0x1867F7590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x67F92A0", Offset = "0x67F80A0", VA = "0x1867F92A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OFINEMEBIAE JMCJLJFFOAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x67F7300", Offset = "0x67F6100", VA = "0x1867F7300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67F9000", Offset = "0x67F7E00", VA = "0x1867F9000")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OFINEMEBIAE DMEPABNCDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67F7360", Offset = "0x67F6160", VA = "0x1867F7360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67F9070", Offset = "0x67F7E70", VA = "0x1867F9070")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OFINEMEBIAE NPPHEFNJOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x67F74B0", Offset = "0x67F62B0", VA = "0x1867F74B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x67F91C0", Offset = "0x67F7FC0", VA = "0x1867F91C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LJIBDJGPFIC, LJIBDJGPFIC> LKFLKOBHLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x67F7440", Offset = "0x67F6240", VA = "0x1867F7440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67F9150", Offset = "0x67F7F50", VA = "0x1867F9150")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OFINEMEBIAE MKMIECAGIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67F7520", Offset = "0x67F6320", VA = "0x1867F7520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67F9230", Offset = "0x67F8030", VA = "0x1867F9230")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OFINEMEBIAE MGEBMMLDEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67F7600", Offset = "0x67F6400", VA = "0x1867F7600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67F9310", Offset = "0x67F8110", VA = "0x1867F9310")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OFINEMEBIAE JEHPOLLEKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67F73D0", Offset = "0x67F61D0", VA = "0x1867F73D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x67F90E0", Offset = "0x67F7EE0", VA = "0x1867F90E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940", Slot = "8")]
		private void BKFKFBMKMHI(AKGHONDNBFH LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A20", Offset = "0x67F4820", VA = "0x1867F5A20")]
		internal void DKEDIOFCBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67F7030", Offset = "0x67F5E30", VA = "0x1867F7030")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody IBHHKEIHCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67F5BC0", Offset = "0x67F49C0", VA = "0x1867F5BC0")]
		public CJBNPFDPBKJ GetChild(int AELAKOMEEDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67F6CA0", Offset = "0x67F5AA0", VA = "0x1867F6CA0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) HFPKCKDFCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67F5830", Offset = "0x67F4630", VA = "0x1867F5830")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67F5AB0", Offset = "0x67F48B0", VA = "0x1867F5AB0")]
		private AKGHONDNBFH DPOJEKFJNEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67F6090", Offset = "0x67F4E90", VA = "0x1867F6090")]
		private void LMFMKFLHHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67F6470", Offset = "0x67F5270", VA = "0x1867F6470")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A20", Offset = "0x67F4820", VA = "0x1867F5A20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67F6410", Offset = "0x67F5210", VA = "0x1867F6410")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67F64D0", Offset = "0x67F52D0", VA = "0x1867F64D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67F4E20", Offset = "0x67F3C20", VA = "0x1867F4E20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67F6530", Offset = "0x67F5330", VA = "0x1867F6530")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67F5B60", Offset = "0x67F4960", VA = "0x1867F5B60")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67F63B0", Offset = "0x67F51B0", VA = "0x1867F63B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x67F6E00", Offset = "0x67F5C00", VA = "0x1867F6E00")]
		public void SetParent(RigidbodyEx DIBNBLEEFNN, bool OECKDFDIPHD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67F6840", Offset = "0x67F5640", VA = "0x1867F6840")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67F5E70", Offset = "0x67F4C70", VA = "0x1867F5E70")]
		public bool IsRigidbodyAncestor(RigidbodyEx EONAKGMJOPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x67F5F50", Offset = "0x67F4D50", VA = "0x1867F5F50")]
		public bool IsRigidbodyDescendant(RigidbodyEx LGKLHHCCIME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67F5090", Offset = "0x67F3E90", VA = "0x1867F5090")]
		public void AddInterpolationRestriction(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67F65A0", Offset = "0x67F53A0", VA = "0x1867F65A0")]
		public void RemoveInterpolationRestriction(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67F5100", Offset = "0x67F3F00", VA = "0x1867F5100")]
		public void AddKinematic(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67F6610", Offset = "0x67F5410", VA = "0x1867F6610")]
		public void RemoveKinematic(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67F6D80", Offset = "0x67F5B80", VA = "0x1867F6D80")]
		public void SetKinematic(object ADNDMAGEPOK, bool GBKJJHMELHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67F6BA0", Offset = "0x67F59A0", VA = "0x1867F6BA0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 KJHMEEOOCAB, Quaternion KHCHBAAGICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67F6AA0", Offset = "0x67F58A0", VA = "0x1867F6AA0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EPECGJEPBIE, Quaternion AMMFCHMAFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67F5D60", Offset = "0x67F4B60", VA = "0x1867F5D60")]
		public Vector3 GetConstrainedVelocity(Vector3 PKCNPDCOCJE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x67F5C50", Offset = "0x67F4A50", VA = "0x1867F5C50")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JHCGPEPGKKC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x67F4FA0", Offset = "0x67F3DA0", VA = "0x1867F4FA0")]
		public void AddForce(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67F4E90", Offset = "0x67F3C90", VA = "0x1867F4E90")]
		public void AddForceAtPosition(Vector3 NLMEJPDDFJD, Vector3 JPLKOMKCHGP, ForceMode JNAPKOAKBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67F52D0", Offset = "0x67F40D0", VA = "0x1867F52D0")]
		public void AddTorque(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x67F5170", Offset = "0x67F3F70", VA = "0x1867F5170")]
		public void AddRelativeTorque(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x67F7100", Offset = "0x67F5F00", VA = "0x1867F7100")]
		public Vector3 WorldToLocalVelocity(Vector3 FEBEDMALBGL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67F62A0", Offset = "0x67F50A0", VA = "0x1867F62A0")]
		public Vector3 LocalToWorldVelocity(Vector3 JJEHMIEJHFH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x67F59C0", Offset = "0x67F47C0", VA = "0x1867F59C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x67F5960", Offset = "0x67F4760", VA = "0x1867F5960")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67F5900", Offset = "0x67F4700", VA = "0x1867F5900")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67F58A0", Offset = "0x67F46A0", VA = "0x1867F58A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x67F69A0", Offset = "0x67F57A0", VA = "0x1867F69A0")]
		public void ResetVelocityWorldSpace(Vector3 NCHINPMAHPE, Vector3 CNNDEIHAEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x67F68A0", Offset = "0x67F56A0", VA = "0x1867F68A0")]
		public void ResetVelocityLocalSpace(Vector3 MIOENFHJJMC, Vector3 LKIGCGOOIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67F6760", Offset = "0x67F5560", VA = "0x1867F6760")]
		public void ResetLinearVelocityLocalSpace(Vector3 MIOENFHJJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67F6F30", Offset = "0x67F5D30", VA = "0x1867F6F30")]
		public bool SweepTest(Vector3 BCGALFAPEPA, [Out] RaycastHit HKJCACJKGEK, float OGFHDAHPALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67F6030", Offset = "0x67F4E30", VA = "0x1867F6030")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67F6ED0", Offset = "0x67F5CD0", VA = "0x1867F6ED0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67F70A0", Offset = "0x67F5EA0", VA = "0x1867F70A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67F5260", Offset = "0x67F4060", VA = "0x1867F5260")]
		public void AddShouldHaveUnityRigidbodyToken(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67F6680", Offset = "0x67F5480", VA = "0x1867F6680")]
		public void RemoveShouldHaveUnityRigidbodyToken(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67F5660", Offset = "0x67F4460", VA = "0x1867F5660")]
		public void ApplyForceVelocityChange(NFOPMPPJPBC DAAKAAMCJGM, Vector3 FJPCMFDNDLK, float EALDBOAOAAB, float NLNDBIOAOBP = 8f, float ALNOJOLJNPA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67F5560", Offset = "0x67F4360", VA = "0x1867F5560")]
		public void ApplyAngularVelocityChange(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IPBBPJAIBDM, float EEBGFNENBKN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67F5720", Offset = "0x67F4520", VA = "0x1867F5720")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IHHAEIJMAPE, float LBPGBDGINCH = 7f, float GIGKBFGDMPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67F5490", Offset = "0x67F4290", VA = "0x1867F5490")]
		public bool AllowedScaleChange(float HGBKJEFLNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67F53C0", Offset = "0x67F41C0", VA = "0x1867F53C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MHGCENJIJEI, object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x67F66F0", Offset = "0x67F54F0", VA = "0x1867F66F0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object ADNDMAGEPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67F7290", Offset = "0x67F6090", VA = "0x1867F7290")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x874110", Offset = "0x872F10", VA = "0x180874110", Slot = "4")]
		private GameObject KMLBEHEDFHO()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7D89E0", Offset = "0x7D77E0", VA = "0x1807D89E0", Slot = "5")]
		private Transform PAIPBPEBMFB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class GGOHFEONOEF
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67E4B20", Offset = "0x67E3920", VA = "0x1867E4B20")]
	public static AKGHONDNBFH IAFJCNLFJBK(this RigidbodyEx LELBNINIFLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PDIJHEJCBNI(typeof(JDMKHCJJDAK), new string[] { })]
public class NOFFKILHLNH : JDMKHCJJDAK, IAJFKKACDGA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private FNFHLMDBIJH BFMNGJACJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LGDHOAMPJLB EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AGPKAJDFCKN HHOIFOFLLCA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LGDHOAMPJLB PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AGPKAJDFCKN JIOCCKMCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67F2590", Offset = "0x67F1390", VA = "0x1867F2590", Slot = "7")]
	public void InitReferences(JMJKBBCBMJB KIBPNKGEGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67F2490", Offset = "0x67F1290", VA = "0x1867F2490", Slot = "6")]
	public AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NOFFKILHLNH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BFNGIAHHPKE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int KFJFBOIFIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KDJFIEHCFIP;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67F4CA0", Offset = "0x67F3AA0", VA = "0x1867F4CA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x67F4CE0", Offset = "0x67F3AE0", VA = "0x1867F4CE0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67F4CC0", Offset = "0x67F3AC0", VA = "0x1867F4CC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HPJAAILCALJ, [Optional] UnityEngine.Object EJDIFPAIGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HPJAAILCALJ, [Optional] UnityEngine.Object EJDIFPAIGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67F4DD0", Offset = "0x67F3BD0", VA = "0x1867F4DD0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PGLEKHLOPHG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ADGIAONCKOA : NBCOLHOOHLA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BE8C0", VA = "0x1807BFAC0", Slot = "4")]
		public Vector3 EEGECBKPBGF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BE8C0", VA = "0x1807BFAC0", Slot = "5")]
		public Vector3 GMJBDEAEEMF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ADGIAONCKOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static NBCOLHOOHLA PFAOOAAOONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67F44D0", Offset = "0x67F32D0", VA = "0x1867F44D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GHCAAGEKBAH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode IGMIECLBNLD
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
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMBKHMNNCNI(bool OFPPLCANFFI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JICIGENHCDF(bool OFPPLCANFFI);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PKFDFPLKPFA(Vector3 BCGALFAPEPA, [Out] RaycastHit HKJCACJKGEK, float OGFHDAHPALD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MCKDMDOLKMG : IDisposable, PABHKGMPHOH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KCLBDKBPBDN IEJKKMMOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LJIBDJGPFIC, LJIBDJGPFIC> LKFLKOBHLBB;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOFCKMODMNI();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface AGPKAJDFCKN
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENJLEOAAPPD MKHJAABOMMI(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHHLAKMKOGB CIAFGKFOFID(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMELBLHPCCO CCJAGDHMMBK(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJFAFBCDBDG KOFNBIICKPH(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NOFJCCIMPKP LKMGHABKANB(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCKDMDOLKMG EGIADBIEFNG(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PDNHMPMDPED MFKGIKLCCLM(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ACLNFJFMMHD DNJEJFCAMJD(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GHCAAGEKBAH IAKGFBINBHD(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PBPLGONMKMC MKCPFFDCLLD(AKGHONDNBFH LFPEHEIJNLK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BEAJMPDJLHK AHKGEAFOALC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LILLPBLBCGC FHODFBGOANK(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IFMBIBLACCF NMJGNALLHDH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KKPGAAKBGGF NDEIOLAKKME(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	INOCKBEDMFM BKJEDNGBBIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC, JDMKHCJJDAK JOMBJDFNECI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ACLNFJFMMHD
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJMLFKJEBEC(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOIECACNPKP(Vector3 NLMEJPDDFJD, Vector3 JPLKOMKCHGP, ForceMode JNAPKOAKBGI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKGDGBCNPIJ(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APICNIJKFEF(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PBPLGONMKMC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GEADIDCMMAG
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
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ENJLEOAAPPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<AKGHONDNBFH> IBPLKIFKNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AKGHONDNBFH OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OFINEMEBIAE JMCJLJFFOAF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OFINEMEBIAE DMEPABNCDPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BPNEMCMFOAO FBGAKAKMMMG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action MGLMFHMDGHK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EMAAIDJKIOM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AKGHONDNBFH> CDNAGOPIBFJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AKGHONDNBFH> ELFBFDGMOBF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action NFNBFLMFHJM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AKGHONDNBFH> CGFMLIIGLJM;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CHDAKFMCKBA(AKGHONDNBFH OIJEBDLJMMH, bool OECKDFDIPHD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MMELBLHPCCO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 OOHEKELGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DGAPEEKADCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNMNPAEOFHM(AKGHONDNBFH OGCHMLDLLMJ, object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAOOIAPNGJL(object ADNDMAGEPOK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KKPGAAKBGGF
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KFFPBAIEJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 MELNCNPPNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float KLOHAEEPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float COEGFAGDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 IJNNDDDEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion INEHOMGOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event OFINEMEBIAE LIHBKPIFBEH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AOFMFEHAFMM((Quaternion rot, Vector3 moments) HFPKCKDFCCP);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BHBBAJNCMJF();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKHIJIJIIKL();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAKLCLKFBEL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HLHJHEBCDHE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IFMBIBLACCF
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJPFDNLPFBF(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNFNDJKKMGD(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLIDMGBKDDO(AKGHONDNBFH LELBNINIFLI);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODKHNHBBMGK(AKGHONDNBFH LELBNINIFLI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGPJHCCEKGK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PDNHMPMDPED
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool AOJAFCMIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OFINEMEBIAE DHPMKMEMJNC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMPLLPCGDLC(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJJHOONEELH(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABLEDFOLHJC(object ADNDMAGEPOK, bool GBKJJHMELHF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNCDLJANDGC(Rigidbody AAHNMGFGCFC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LILLPBLBCGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool NGPEMOIEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DMFHGMAJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OFINEMEBIAE EENGHCPLOOB;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGOHJAHJGKP(AKGHONDNBFH OGCHMLDLLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJCBPKKDFON(AKGHONDNBFH OGCHMLDLLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface INOCKBEDMFM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HPEMPGOJNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FCEHPCIPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints EFFFCMMEDJH
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
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CJFAFBCDBDG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float OEDBHJNKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float GGIEPMABIGM
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
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NOFJCCIMPKP
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event OFINEMEBIAE OFALEBHKKAN;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPKOCFBPGPK();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDLAKMGFDOJ();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJPEANJCFPK();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODDGKCKGNED();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJGFGFIGPMD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BEAJMPDJLHK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LFACIAPODND
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEANEJDDGLP(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLIIOIMOEDI(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNLEPIJOKNE();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMIBGCFEJNK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NHHLAKMKOGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NBCOLHOOHLA LIBEDDGLDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	IPMNNOHAGGH KEDDGLJGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OONJHIGHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 FKLCHNPGOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MLJDAKDGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 NGGKALLNEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float GDDDCPAMJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool EHBJIEEACAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KKKHKGAKJHI(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FJEPJOKBNPN(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IPBBPJAIBDM, float EEBGFNENBKN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MOBOBKOMMJE(NFOPMPPJPBC DAAKAAMCJGM, Vector3 FJPCMFDNDLK, float EALDBOAOAAB, float NLNDBIOAOBP = 8f, float ALNOJOLJNPA = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PJLACDEEHEJ(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IHHAEIJMAPE, float LBPGBDGINCH = 7f, float GIGKBFGDMPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CNBMLLDKMID();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NODOGLFFAJJ();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GMCECHADLDH();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PDLIEDFBGGD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CNCDLJANDGC(Rigidbody GDOCMGOHKNC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FCAGAKMLKIM(Vector3 PKCNPDCOCJE);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CGJEDMDHGCB(object ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NODLCLEJEMD(Vector3 OHOEONEMMCE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JJLILNLBEND(Vector3 MIOENFHJJMC, Vector3 LKIGCGOOIDL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FDEINDINLMA(Vector3 NCHINPMAHPE, Vector3 CNNDEIHAEKF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OFLBNPLJECH(Vector3 JJEHMIEJHFH);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 HNHPBBIDOPP(Vector3 FEBEDMALBGL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface LGDHOAMPJLB
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool DENACNOGGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APBKJGOLEOI(string EPIMHJFIPDE);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POPJHENHHDJ(RigidbodyEx LELBNINIFLI, Action GOECALGCLOK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BALFFALPJCK IONBGOIKOCB(int LHGLALBICCM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIKFLNJBNKM(Vector3 ENFFFMCBNNI, float IHINIPGNHDL, Color BGJPICBMDGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface JDMKHCJJDAK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LGDHOAMPJLB PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	AGPKAJDFCKN JIOCCKMCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KGNKJDNANDM : AKGHONDNBFH, IDisposable, HKHGKFMCJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly JDMKHCJJDAK JOMBJDFNECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal ENJLEOAAPPD HIGIEDDKDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal IFMBIBLACCF POJCPJENDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal LILLPBLBCGC ICCIOIHFKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NHHLAKMKOGB PKCNPDCOCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal MMELBLHPCCO GDMGKFLOMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal KKPGAAKBGGF BGFGBBHKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal CJFAFBCDBDG IKMIKFNGBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal PBPLGONMKMC LNJPDAFNIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal NOFJCCIMPKP BCCJKEDFHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MCKDMDOLKMG BINFGGKEOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PDNHMPMDPED IJKIKNONGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ACLNFJFMMHD NLMEJPDDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal INOCKBEDMFM NFEMJLPDJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal BEAJMPDJLHK GDOCMGOHKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal GHCAAGEKBAH CKNHGHFBPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable FFEODDKENMD;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "22")]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public CJBNPFDPBKJ AOLGLPEJIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5B0", Offset = "0x7AD3B0", VA = "0x1807AE5B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4D0", Offset = "0x7AD2D0", VA = "0x1807AE4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject DBBMAMINFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x879BF0", Offset = "0x8789F0", VA = "0x180879BF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x879D10", Offset = "0x878B10", VA = "0x180879D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x67E65B0", Offset = "0x67E53B0", VA = "0x1867E65B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x67EBFE0", Offset = "0x67EADE0", VA = "0x1867EBFE0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x67EC200", Offset = "0x67EB000", VA = "0x1867EC200", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x67EA600", Offset = "0x67E9400", VA = "0x1867EA600", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int GDNKIELLEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x67E7970", Offset = "0x67E6770", VA = "0x1867E7970", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AKGHONDNBFH OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x67EACB0", Offset = "0x67E9AB0", VA = "0x1867EACB0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool BILKBDDKIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x67EB0C0", Offset = "0x67E9EC0", VA = "0x1867EB0C0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool NGPEMOIEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x67E8D40", Offset = "0x67E7B40", VA = "0x1867E8D40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DMFHGMAJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x67E66E0", Offset = "0x67E54E0", VA = "0x1867E66E0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NBCOLHOOHLA LIBEDDGLDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x67EAE00", Offset = "0x67E9C00", VA = "0x1867EAE00", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x67E6D70", Offset = "0x67E5B70", VA = "0x1867E6D70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public IPMNNOHAGGH KEDDGLJGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x67E6640", Offset = "0x67E5440", VA = "0x1867E6640", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x67EA9C0", Offset = "0x67E97C0", VA = "0x1867EA9C0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float GDDDCPAMJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67E8A20", Offset = "0x67E7820", VA = "0x1867E8A20", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x67E85C0", Offset = "0x67E73C0", VA = "0x1867E85C0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 FKLCHNPGOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x67EAA20", Offset = "0x67E9820", VA = "0x1867EAA20", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67E93E0", Offset = "0x67E81E0", VA = "0x1867E93E0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 NGGKALLNEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x67EAE50", Offset = "0x67E9C50", VA = "0x1867EAE50", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x67E8A70", Offset = "0x67E7870", VA = "0x1867E8A70", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 OONJHIGHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67E7B10", Offset = "0x67E6910", VA = "0x1867E7B10", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67E9B00", Offset = "0x67E8900", VA = "0x1867E9B00", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MLJDAKDGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67E88D0", Offset = "0x67E76D0", VA = "0x1867E88D0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67E6C90", Offset = "0x67E5A90", VA = "0x1867E6C90", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AJELDMMDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F70", Offset = "0x67E7D70", VA = "0x1867E8F70", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool NNMKFCFPEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67EB020", Offset = "0x67E9E20", VA = "0x1867EB020", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool AJJFIHHHDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67E8620", Offset = "0x67E7420", VA = "0x1867E8620", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool EHBJIEEACAL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x67E6690", Offset = "0x67E5490", VA = "0x1867E6690", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 OOHEKELGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x67E8700", Offset = "0x67E7500", VA = "0x1867E8700", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 DGAPEEKADCM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x67E7220", Offset = "0x67E6020", VA = "0x1867E7220", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KFFPBAIEJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67EAB70", Offset = "0x67E9970", VA = "0x1867EAB70", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x67E7A30", Offset = "0x67E6830", VA = "0x1867E7A30", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 MELNCNPPNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x67E6E20", Offset = "0x67E5C20", VA = "0x1867E6E20", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float KLOHAEEPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x67E6F00", Offset = "0x67E5D00", VA = "0x1867E6F00", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float COEGFAGDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x67EAD00", Offset = "0x67E9B00", VA = "0x1867EAD00", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x67EADA0", Offset = "0x67E9BA0", VA = "0x1867EADA0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 IJNNDDDEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67E8DF0", Offset = "0x67E7BF0", VA = "0x1867E8DF0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion INEHOMGOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x67E6BC0", Offset = "0x67E59C0", VA = "0x1867E6BC0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float OEDBHJNKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67EAB00", Offset = "0x67E9900", VA = "0x1867EAB00", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x67EB340", Offset = "0x67EA140", VA = "0x1867EB340", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float GGIEPMABIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x67E9AB0", Offset = "0x67E88B0", VA = "0x1867E9AB0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x67EBF10", Offset = "0x67EAD10", VA = "0x1867EBF10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool GEADIDCMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x67EAF30", Offset = "0x67E9D30", VA = "0x1867EAF30", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x67E7DE0", Offset = "0x67E6BE0", VA = "0x1867E7DE0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KCLBDKBPBDN IEJKKMMOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x67E6920", Offset = "0x67E5720", VA = "0x1867E6920", Slot = "68")]
		get
		{
			return default(KCLBDKBPBDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x67EA870", Offset = "0x67E9670", VA = "0x1867EA870", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool AOJAFCMIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F20", Offset = "0x67E7D20", VA = "0x1867E8F20", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform HGPOKOHBALD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67E8A10", Offset = "0x67E7810", VA = "0x1867E8A10", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 PLJDFINMPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x67E70B0", Offset = "0x67E5EB0", VA = "0x1867E70B0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x67EA540", Offset = "0x67E9340", VA = "0x1867EA540", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float GLALHHELIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x67EAB50", Offset = "0x67E9950", VA = "0x1867EAB50", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67EBF70", Offset = "0x67EAD70", VA = "0x1867EBF70", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float KDADLHAHELE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67EB2A0", Offset = "0x67EA0A0", VA = "0x1867EB2A0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x67EB700", Offset = "0x67EA500", VA = "0x1867EB700", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HCADLGNAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x67E9900", Offset = "0x67E8700", VA = "0x1867E9900", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x67EA710", Offset = "0x67E9510", VA = "0x1867EA710", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 CBHGHOKJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x67EC030", Offset = "0x67EAE30", VA = "0x1867EC030", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x67EA820", Offset = "0x67E9620", VA = "0x1867EA820", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion PEMBIJKPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x67EB080", Offset = "0x67E9E80", VA = "0x1867EB080", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67E95D0", Offset = "0x67E83D0", VA = "0x1867E95D0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints EFFFCMMEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x67EB4C0", Offset = "0x67EA2C0", VA = "0x1867EB4C0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x67E7910", Offset = "0x67E6710", VA = "0x1867E7910", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HPEMPGOJNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x67E7060", Offset = "0x67E5E60", VA = "0x1867E7060", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x67E89B0", Offset = "0x67E77B0", VA = "0x1867E89B0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode IGMIECLBNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x67EAFD0", Offset = "0x67E9DD0", VA = "0x1867EAFD0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x67E8310", Offset = "0x67E7110", VA = "0x1867E8310", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool ALEPKLJPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67E7300", Offset = "0x67E6100", VA = "0x1867E7300", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HFLBHCECNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x67EC080", Offset = "0x67EAE80", VA = "0x1867EC080", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OFINEMEBIAE JMCJLJFFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x67E9610", Offset = "0x67E8410", VA = "0x1867E9610", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x67E6B60", Offset = "0x67E5960", VA = "0x1867E6B60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event OFINEMEBIAE DMEPABNCDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x67EB6A0", Offset = "0x67EA4A0", VA = "0x1867EB6A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x67EBCB0", Offset = "0x67EAAB0", VA = "0x1867EBCB0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BPNEMCMFOAO FBGAKAKMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x67EC460", Offset = "0x67EB260", VA = "0x1867EC460", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x67E8370", Offset = "0x67E7170", VA = "0x1867E8370", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OFINEMEBIAE EENGHCPLOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x67E9570", Offset = "0x67E8370", VA = "0x1867E9570", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x67E8D90", Offset = "0x67E7B90", VA = "0x1867E8D90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event OFINEMEBIAE NPPHEFNJOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x67E9510", Offset = "0x67E8310", VA = "0x1867E9510", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x67E80B0", Offset = "0x67E6EB0", VA = "0x1867E80B0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event OFINEMEBIAE OFALEBHKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x67E7440", Offset = "0x67E6240", VA = "0x1867E7440", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x67E98A0", Offset = "0x67E86A0", VA = "0x1867E98A0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<LJIBDJGPFIC, LJIBDJGPFIC> LKFLKOBHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x67E7E40", Offset = "0x67E6C40", VA = "0x1867E7E40", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67EB400", Offset = "0x67EA200", VA = "0x1867EB400", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OFINEMEBIAE DHPMKMEMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x67EB3A0", Offset = "0x67EA1A0", VA = "0x1867EB3A0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x67E9670", Offset = "0x67E8470", VA = "0x1867E9670", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event OFINEMEBIAE JEHPOLLEKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x67E6F50", Offset = "0x67E5D50", VA = "0x1867E6F50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x67E74A0", Offset = "0x67E62A0", VA = "0x1867E74A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67EC500", Offset = "0x67EB300", VA = "0x1867EC500")]
	public KGNKJDNANDM(GameObject EBIGFKEAJMH, RigidbodyEx ONEJKOJJBGA, JDMKHCJJDAK JOMBJDFNECI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67E9BE0", Offset = "0x67E89E0", VA = "0x1867E9BE0", Slot = "136")]
	protected virtual void IIILPIAJPLE(JDMKHCJJDAK JOMBJDFNECI, FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67E7FE0", Offset = "0x67E6DE0", VA = "0x1867E7FE0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67E7EA0", Offset = "0x67E6CA0", VA = "0x1867E7EA0", Slot = "91")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67E94C0", Offset = "0x67E82C0", VA = "0x1867E94C0", Slot = "92")]
	public void HECDDJLFMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x67EA800", Offset = "0x67E9600", VA = "0x1867EA800", Slot = "93")]
	public void JEDLMHNBLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67EA660", Offset = "0x67E9460", VA = "0x1867EA660")]
	private void JAGFKKAKGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67EB2C0", Offset = "0x67EA0C0", VA = "0x1867EB2C0", Slot = "30")]
	public AKGHONDNBFH NFGLKOCPPME(int AELAKOMEEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x67E7550", Offset = "0x67E6350", VA = "0x1867E7550", Slot = "95")]
	public void CHDAKFMCKBA(AKGHONDNBFH DIBNBLEEFNN, bool OECKDFDIPHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x67E6730", Offset = "0x67E5530", VA = "0x1867E6730", Slot = "96")]
	public void AGOPCJCHLOH(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x67E7000", Offset = "0x67E5E00", VA = "0x1867E7000", Slot = "97")]
	public void BKGGLMHLDEI(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x67E99B0", Offset = "0x67E87B0", VA = "0x1867E99B0", Slot = "98")]
	public Vector3 HNHPBBIDOPP(Vector3 FEBEDMALBGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x67EB800", Offset = "0x67EA600", VA = "0x1867EB800", Slot = "99")]
	public Vector3 OFLBNPLJECH(Vector3 JJEHMIEJHFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x67E94C0", Offset = "0x67E82C0", VA = "0x1867E94C0", Slot = "100")]
	public void PDLIEDFBGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67EB5F0", Offset = "0x67EA3F0", VA = "0x1867EB5F0", Slot = "101")]
	public void NODOGLFFAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67E78C0", Offset = "0x67E66C0", VA = "0x1867E78C0", Slot = "102")]
	public void CNBMLLDKMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67E84D0", Offset = "0x67E72D0", VA = "0x1867E84D0", Slot = "103")]
	public void FDEINDINLMA(Vector3 NCHINPMAHPE, Vector3 CNNDEIHAEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67EA8D0", Offset = "0x67E96D0", VA = "0x1867EA8D0", Slot = "104")]
	public void JJLILNLBEND(Vector3 MIOENFHJJMC, Vector3 LKIGCGOOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67EB510", Offset = "0x67EA310", VA = "0x1867EB510", Slot = "105")]
	public void NODLCLEJEMD(Vector3 OHOEONEMMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67EB180", Offset = "0x67E9F80", VA = "0x1867EB180", Slot = "106")]
	public void MOBOBKOMMJE(NFOPMPPJPBC DAAKAAMCJGM, Vector3 FJPCMFDNDLK, float EALDBOAOAAB, float NLNDBIOAOBP = 8f, float ALNOJOLJNPA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67E87D0", Offset = "0x67E75D0", VA = "0x1867E87D0", Slot = "107")]
	public void FJEPJOKBNPN(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IPBBPJAIBDM, float EEBGFNENBKN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67EC250", Offset = "0x67EB050", VA = "0x1867EC250", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PJLACDEEHEJ(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IHHAEIJMAPE, float LBPGBDGINCH = 7f, float GIGKBFGDMPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67E83D0", Offset = "0x67E71D0", VA = "0x1867E83D0", Slot = "109")]
	public Vector3 FCAGAKMLKIM(Vector3 DIBNBLEEFNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67E75C0", Offset = "0x67E63C0", VA = "0x1867E75C0", Slot = "110")]
	public Vector3 CHIMGNKOCOK(Vector3 DIBNBLEEFNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67E8ED0", Offset = "0x67E7CD0", VA = "0x1867E8ED0", Slot = "111")]
	public void GMCECHADLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67E7850", Offset = "0x67E6650", VA = "0x1867E7850", Slot = "112")]
	public void CMMGKHOPAPA(AKGHONDNBFH MHGCENJIJEI, object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67E77F0", Offset = "0x67E65F0", VA = "0x1867E77F0", Slot = "113")]
	public void CLLFKKEHBIC(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67E6840", Offset = "0x67E5640", VA = "0x1867E6840", Slot = "61")]
	public void AOFMFEHAFMM((Quaternion rot, Vector3 moments) HFPKCKDFCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67E9FB0", Offset = "0x67E8DB0", VA = "0x1867E9FB0", Slot = "114")]
	public void IKHIJIJIIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x67E6DD0", Offset = "0x67E5BD0", VA = "0x1867E6DD0", Slot = "115")]
	public void BHBBAJNCMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x67E79E0", Offset = "0x67E67E0", VA = "0x1867E79E0", Slot = "116")]
	public void DAKLCLKFBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x67EAD50", Offset = "0x67E9B50", VA = "0x1867EAD50", Slot = "117")]
	public bool KPKOCFBPGPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x67E76C0", Offset = "0x67E64C0", VA = "0x1867E76C0", Slot = "94")]
	public void CJPEANJCFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x67EAF80", Offset = "0x67E9D80", VA = "0x1867EAF80", Slot = "118")]
	public void LJGFGFIGPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x67EA4E0", Offset = "0x67E92E0", VA = "0x1867EA4E0", Slot = "119")]
	public void IMPLLPCGDLC(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x67EB120", Offset = "0x67E9F20", VA = "0x1867EB120", Slot = "120")]
	public void MJJHOONEELH(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x67E6540", Offset = "0x67E5340", VA = "0x1867E6540", Slot = "121")]
	public void ABLEDFOLHJC(object ADNDMAGEPOK, bool GBKJJHMELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x67EBD10", Offset = "0x67EAB10", VA = "0x1867EBD10", Slot = "122")]
	public void OMKKJNIEPCH(Vector3 KJHMEEOOCAB, Quaternion KHCHBAAGICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x67E63F0", Offset = "0x67E51F0", VA = "0x1867E63F0", Slot = "123")]
	public void AAMKMBIAAOG(Vector3 EPECGJEPBIE, Quaternion AMMFCHMAFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x67EB640", Offset = "0x67EA440", VA = "0x1867EB640", Slot = "124")]
	public bool OALIGHPAKGD(float HGBKJEFLNMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x67EB460", Offset = "0x67EA260", VA = "0x1867EB460", Slot = "125")]
	public void NJLHEHFMPCD(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x67EB240", Offset = "0x67EA040", VA = "0x1867EB240", Slot = "126")]
	public void MPGBICNDDCJ(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x67E8110", Offset = "0x67E6F10", VA = "0x1867E8110", Slot = "127")]
	public void EEANEJDDGLP(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x67EAC50", Offset = "0x67E9A50", VA = "0x1867EAC50", Slot = "128")]
	public void KLIIOIMOEDI(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x67E9ED0", Offset = "0x67E8CD0", VA = "0x1867E9ED0", Slot = "129")]
	public void IJMLFKJEBEC(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x67E6970", Offset = "0x67E5770", VA = "0x1867E6970", Slot = "130")]
	public void AOIECACNPKP(Vector3 NLMEJPDDFJD, Vector3 JPLKOMKCHGP, ForceMode JNAPKOAKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x67E7710", Offset = "0x67E6510", VA = "0x1867E7710", Slot = "131")]
	public void CKGDGBCNPIJ(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x67E6A80", Offset = "0x67E5880", VA = "0x1867E6A80", Slot = "132")]
	public void APICNIJKFEF(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x67EC360", Offset = "0x67EB160", VA = "0x1867EC360", Slot = "133")]
	public bool PKFDFPLKPFA(Vector3 BCGALFAPEPA, [Out] RaycastHit HKJCACJKGEK, float OGFHDAHPALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x67E9850", Offset = "0x67E8650", VA = "0x1867E9850", Slot = "134")]
	public void HLHJHEBCDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x67EC4C0", Offset = "0x67EB2C0", VA = "0x1867EC4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x67E8C60", Offset = "0x67E7A60", VA = "0x1867E8C60")]
	private void GCBIOMKPEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67E8B50", Offset = "0x67E7950", VA = "0x1867E8B50")]
	private void FOMOFOIOGGH(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x67E7BF0", Offset = "0x67E69F0", VA = "0x1867E7BF0")]
	private void DHHAOELBAKE(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x67E6790", Offset = "0x67E5590", VA = "0x1867E6790")]
	private void AKGHBFEKDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67E92E0", Offset = "0x67E80E0", VA = "0x1867E92E0")]
	private void HACKEDCJJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x67E96D0", Offset = "0x67E84D0", VA = "0x1867E96D0")]
	private void HKDGDBALLCL(AKGHONDNBFH MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67E8170", Offset = "0x67E6F70", VA = "0x1867E8170")]
	private void EGOHJAHJGKP(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x67E8240", Offset = "0x67E7040", VA = "0x1867E8240")]
	private void EJCBPKKDFON(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67EA370", Offset = "0x67E9170", VA = "0x1867EA370")]
	private void IMJIKDNBDDJ(CJBNPFDPBKJ OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67EB900", Offset = "0x67EA700", VA = "0x1867EB900", Slot = "141")]
	protected virtual void OLJAIMODJMI(CJBNPFDPBKJ LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x67E8FC0", Offset = "0x67E7DC0", VA = "0x1867E8FC0")]
	protected void GOKJGPMKJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67EA000", Offset = "0x67E8E00", VA = "0x1867EA000")]
	protected void IKONOENPION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x67E7160", Offset = "0x67E5F60", VA = "0x1867E7160", Slot = "142")]
	protected virtual IDisposable BMIMFDONINC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class IDJJNPOOKEE
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x67E5040", Offset = "0x67E3E40", VA = "0x1867E5040")]
	public static AKGHONDNBFH DIKEPHEJAGN(this AKGHONDNBFH LELBNINIFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x67E5180", Offset = "0x67E3F80", VA = "0x1867E5180")]
	public static bool GMDOELEJOEP(this AKGHONDNBFH LELBNINIFLI, AKGHONDNBFH EONAKGMJOPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x67E5100", Offset = "0x67E3F00", VA = "0x1867E5100")]
	public static bool GJHCAEELLMO(this AKGHONDNBFH LELBNINIFLI, AKGHONDNBFH LGKLHHCCIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x67E5280", Offset = "0x67E4080", VA = "0x1867E5280")]
	public static CJBNPFDPBKJ KDPBCBAIIGH(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x67E5200", Offset = "0x67E4000", VA = "0x1867E5200")]
	public static KGNKJDNANDM HPDPLAABFOD(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JMFHFHAALLP : AGPKAJDFCKN
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x67E52D0", Offset = "0x67E40D0", VA = "0x1867E52D0", Slot = "19")]
	public AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC, JDMKHCJJDAK JOMBJDFNECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "4")]
	public ENJLEOAAPPD MKHJAABOMMI(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "5")]
	public NHHLAKMKOGB CIAFGKFOFID(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "6")]
	public MMELBLHPCCO CCJAGDHMMBK(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "7")]
	public CJFAFBCDBDG KOFNBIICKPH(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "8")]
	public NOFJCCIMPKP LKMGHABKANB(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "9")]
	public MCKDMDOLKMG EGIADBIEFNG(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "10")]
	public PDNHMPMDPED MFKGIKLCCLM(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "11")]
	public ACLNFJFMMHD DNJEJFCAMJD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "12")]
	public GHCAAGEKBAH IAKGFBINBHD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "13")]
	public PBPLGONMKMC MKCPFFDCLLD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	public BEAJMPDJLHK AHKGEAFOALC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	public LILLPBLBCGC FHODFBGOANK(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	public IFMBIBLACCF NMJGNALLHDH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	public KKPGAAKBGGF NDEIOLAKKME(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	public INOCKBEDMFM BKJEDNGBBIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JMFHFHAALLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "14")]
	private BEAJMPDJLHK ILBJKGCIJFI(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "15")]
	private LILLPBLBCGC JGGJHDKGEIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "16")]
	private IFMBIBLACCF FDFJLFPIIBP(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "17")]
	private KKPGAAKBGGF FOGGBLPFGPH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "18")]
	private INOCKBEDMFM CCDJHLHHKLC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[PDIJHEJCBNI(typeof(AGPKAJDFCKN), new string[] { })]
public class BMLFCKMJOEM : AGPKAJDFCKN, IAJFKKACDGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AGPKAJDFCKN HIJPCFPOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly AGPKAJDFCKN GHDIEJIAKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private FNFHLMDBIJH BFMNGJACJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private AGPKAJDFCKN JIOCCKMCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x67E2310", Offset = "0x67E1110", VA = "0x1867E2310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x67E2760", Offset = "0x67E1560", VA = "0x1867E2760", Slot = "20")]
	public void InitReferences(JMJKBBCBMJB KIBPNKGEGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67E2A30", Offset = "0x67E1830", VA = "0x1867E2A30", Slot = "4")]
	public ENJLEOAAPPD MKHJAABOMMI(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67E2120", Offset = "0x67E0F20", VA = "0x1867E2120", Slot = "5")]
	public NHHLAKMKOGB CIAFGKFOFID(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67E2080", Offset = "0x67E0E80", VA = "0x1867E2080", Slot = "6")]
	public MMELBLHPCCO CCJAGDHMMBK(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x67E27B0", Offset = "0x67E15B0", VA = "0x1867E27B0", Slot = "7")]
	public CJFAFBCDBDG KOFNBIICKPH(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67E2850", Offset = "0x67E1650", VA = "0x1867E2850", Slot = "8")]
	public NOFJCCIMPKP LKMGHABKANB(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67E2410", Offset = "0x67E1210", VA = "0x1867E2410", Slot = "9")]
	public MCKDMDOLKMG EGIADBIEFNG(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x67E28F0", Offset = "0x67E16F0", VA = "0x1867E28F0", Slot = "10")]
	public PDNHMPMDPED MFKGIKLCCLM(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x67E2370", Offset = "0x67E1170", VA = "0x1867E2370", Slot = "11")]
	public ACLNFJFMMHD DNJEJFCAMJD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x67E26C0", Offset = "0x67E14C0", VA = "0x1867E26C0", Slot = "12")]
	public GHCAAGEKBAH IAKGFBINBHD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x67E2990", Offset = "0x67E1790", VA = "0x1867E2990", Slot = "13")]
	public PBPLGONMKMC MKCPFFDCLLD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x67E1F20", Offset = "0x67E0D20", VA = "0x1867E1F20")]
	public BEAJMPDJLHK AHKGEAFOALC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x67E2560", Offset = "0x67E1360", VA = "0x1867E2560")]
	public LILLPBLBCGC FHODFBGOANK(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x67E24B0", Offset = "0x67E12B0", VA = "0x1867E24B0")]
	public IFMBIBLACCF NMJGNALLHDH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x67E2610", Offset = "0x67E1410", VA = "0x1867E2610")]
	public KKPGAAKBGGF NDEIOLAKKME(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x67E1FD0", Offset = "0x67E0DD0", VA = "0x1867E1FD0")]
	public INOCKBEDMFM BKJEDNGBBIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x67E21C0", Offset = "0x67E0FC0", VA = "0x1867E21C0", Slot = "19")]
	public AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC, JDMKHCJJDAK JOMBJDFNECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x67E2AD0", Offset = "0x67E18D0", VA = "0x1867E2AD0")]
	public BMLFCKMJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x67E1F20", Offset = "0x67E0D20", VA = "0x1867E1F20", Slot = "14")]
	private BEAJMPDJLHK ILBJKGCIJFI(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x67E2560", Offset = "0x67E1360", VA = "0x1867E2560", Slot = "15")]
	private LILLPBLBCGC JGGJHDKGEIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x67E24B0", Offset = "0x67E12B0", VA = "0x1867E24B0", Slot = "16")]
	private IFMBIBLACCF FDFJLFPIIBP(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x67E2610", Offset = "0x67E1410", VA = "0x1867E2610", Slot = "17")]
	private KKPGAAKBGGF FOGGBLPFGPH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x67E1FD0", Offset = "0x67E0DD0", VA = "0x1867E1FD0", Slot = "18")]
	private INOCKBEDMFM CCDJHLHHKLC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FBFAMGCGCKC : ENJLEOAAPPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMOKIJJFMPI(AKGHONDNBFH LELBNINIFLI);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALEADCEDJPP(AKGHONDNBFH LELBNINIFLI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCGLPOHPKLD(AKGHONDNBFH MLCHFHHFNBC);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPEJIIMDEFC(AKGHONDNBFH MLCHFHHFNBC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EIBNFFJALBB : MMELBLHPCCO
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	DFBBOHICGKE<AKGHONDNBFH> DAPGLHBHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	AKGHONDNBFH NLIKNKFNOHL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GDCHBGEFFPC : KKPGAAKBGGF
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PANCIFMFFEK(Rigidbody EJAMDOGMOII);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NDKEFEGDBLD : LILLPBLBCGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView CLNAIDAEIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class COKCMHKABKD : GHCAAGEKBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode OOPGBJDKDFO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x67E3B20", Offset = "0x67E2920", VA = "0x1867E3B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode IGMIECLBNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x67E3A10", Offset = "0x67E2810", VA = "0x1867E3A10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x67E3870", Offset = "0x67E2670", VA = "0x1867E3870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CD0", Offset = "0x67E2AD0", VA = "0x1867E3CD0")]
	public COKCMHKABKD(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x67E3760", Offset = "0x67E2560", VA = "0x1867E3760", Slot = "6")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x67E36E0", Offset = "0x67E24E0", VA = "0x1867E36E0", Slot = "9")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x67E36D0", Offset = "0x67E24D0", VA = "0x1867E36D0", Slot = "7")]
	public void BMBKHMNNCNI(bool OFPPLCANFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x67E3A00", Offset = "0x67E2800", VA = "0x1867E3A00", Slot = "8")]
	public void JICIGENHCDF(bool OFPPLCANFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x67E3B70", Offset = "0x67E2970", VA = "0x1867E3B70", Slot = "10")]
	public bool PKFDFPLKPFA(Vector3 BCGALFAPEPA, [Out] RaycastHit HKJCACJKGEK, float OGFHDAHPALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x67E38E0", Offset = "0x67E26E0", VA = "0x1867E38E0")]
	private void GBBFPMFBKED(bool OFPPLCANFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BGDHMLCNIOD : MCKDMDOLKMG, IDisposable, PABHKGMPHOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KCLBDKBPBDN JKEGCFOMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BALFFALPJCK BDMEHNNPAND;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KCLBDKBPBDN IEJKKMMOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x67E1830", Offset = "0x67E0630", VA = "0x1867E1830", Slot = "6")]
		get
		{
			return default(KCLBDKBPBDN);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x67E1D10", Offset = "0x67E0B10", VA = "0x1867E1D10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform OCJIPHNGKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x67E1CF0", Offset = "0x67E0AF0", VA = "0x1867E1CF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LJIBDJGPFIC, LJIBDJGPFIC> LKFLKOBHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x67E1980", Offset = "0x67E0780", VA = "0x1867E1980", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x67E1DE0", Offset = "0x67E0BE0", VA = "0x1867E1DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x67E1E90", Offset = "0x67E0C90", VA = "0x1867E1E90")]
	public BGDHMLCNIOD(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x67E1A30", Offset = "0x67E0830", VA = "0x1867E1A30", Slot = "8")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x67E1CA0", Offset = "0x67E0AA0", VA = "0x1867E1CA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x82EA30", Offset = "0x82D830", VA = "0x18082EA30", Slot = "11")]
	private void JILOHGBPPHE(LJIBDJGPFIC OEMIAGMILEE, LJIBDJGPFIC LODCBDFPENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "12")]
	private void KCEMPIAHIFN(bool MGIKOAEGEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OIHAPGHEMDH : AGPKAJDFCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x67F36D0", Offset = "0x67F24D0", VA = "0x1867F36D0", Slot = "4")]
	public ENJLEOAAPPD MKHJAABOMMI(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AB0", Offset = "0x67F18B0", VA = "0x1867F2AB0", Slot = "5")]
	public NHHLAKMKOGB CIAFGKFOFID(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x67F2980", Offset = "0x67F1780", VA = "0x1867F2980", Slot = "6")]
	public MMELBLHPCCO CCJAGDHMMBK(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x67F33A0", Offset = "0x67F21A0", VA = "0x1867F33A0", Slot = "7")]
	public CJFAFBCDBDG KOFNBIICKPH(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x67F3420", Offset = "0x67F2220", VA = "0x1867F3420", Slot = "8")]
	public NOFJCCIMPKP LKMGHABKANB(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x67F2DC0", Offset = "0x67F1BC0", VA = "0x1867F2DC0", Slot = "9")]
	public MCKDMDOLKMG EGIADBIEFNG(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x67F34F0", Offset = "0x67F22F0", VA = "0x1867F34F0", Slot = "10")]
	public PDNHMPMDPED MFKGIKLCCLM(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2D00", Offset = "0x67F1B00", VA = "0x1867F2D00", Slot = "11")]
	public ACLNFJFMMHD DNJEJFCAMJD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x67F32E0", Offset = "0x67F20E0", VA = "0x1867F32E0", Slot = "12")]
	public GHCAAGEKBAH IAKGFBINBHD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x67F3610", Offset = "0x67F2410", VA = "0x1867F3610", Slot = "13")]
	public PBPLGONMKMC MKCPFFDCLLD(AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x67F2760", Offset = "0x67F1560", VA = "0x1867F2760")]
	public BEAJMPDJLHK AHKGEAFOALC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x67F2FC0", Offset = "0x67F1DC0", VA = "0x1867F2FC0")]
	public LILLPBLBCGC FHODFBGOANK(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x67F2E90", Offset = "0x67F1C90", VA = "0x1867F2E90")]
	public IFMBIBLACCF NMJGNALLHDH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x67F3150", Offset = "0x67F1F50", VA = "0x1867F3150")]
	public KKPGAAKBGGF NDEIOLAKKME(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x67F28A0", Offset = "0x67F16A0", VA = "0x1867F28A0")]
	public INOCKBEDMFM BKJEDNGBBIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x67F2BE0", Offset = "0x67F19E0", VA = "0x1867F2BE0", Slot = "19")]
	public AKGHONDNBFH CLADPPLBEHG(RigidbodyEx LELBNINIFLI, FAFMMNEEDEJ LHODDAGAJKC, JDMKHCJJDAK JOMBJDFNECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OIHAPGHEMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x67F2760", Offset = "0x67F1560", VA = "0x1867F2760", Slot = "14")]
	private BEAJMPDJLHK ILBJKGCIJFI(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67F2FC0", Offset = "0x67F1DC0", VA = "0x1867F2FC0", Slot = "15")]
	private LILLPBLBCGC JGGJHDKGEIO(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x67F2E90", Offset = "0x67F1C90", VA = "0x1867F2E90", Slot = "16")]
	private IFMBIBLACCF FDFJLFPIIBP(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x67F3150", Offset = "0x67F1F50", VA = "0x1867F3150", Slot = "17")]
	private KKPGAAKBGGF FOGGBLPFGPH(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x67F28A0", Offset = "0x67F16A0", VA = "0x1867F28A0", Slot = "18")]
	private INOCKBEDMFM CCDJHLHHKLC(AKGHONDNBFH LFPEHEIJNLK, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class PFAHCFCMDAF : ACLNFJFMMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x67E3B20", Offset = "0x67E2920", VA = "0x1867E3B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool AOJAFCMIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x67F4060", Offset = "0x67F2E60", VA = "0x1867F4060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool BILKBDDKIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x67F0300", Offset = "0x67EF100", VA = "0x1867F0300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x67F4470", Offset = "0x67F3270", VA = "0x1867F4470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CD0", Offset = "0x67E2AD0", VA = "0x1867E3CD0")]
	public PFAHCFCMDAF(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x67F40B0", Offset = "0x67F2EB0", VA = "0x1867F40B0", Slot = "4")]
	public void IJMLFKJEBEC(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x67F3E00", Offset = "0x67F2C00", VA = "0x1867F3E00")]
	private void EMMOICKMIDE(Vector3 NLMEJPDDFJD, ForceMode JNAPKOAKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x67F37C0", Offset = "0x67F25C0", VA = "0x1867F37C0", Slot = "5")]
	public void AOIECACNPKP(Vector3 NLMEJPDDFJD, Vector3 JPLKOMKCHGP, ForceMode JNAPKOAKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x67F3CA0", Offset = "0x67F2AA0", VA = "0x1867F3CA0", Slot = "6")]
	public void CKGDGBCNPIJ(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x67F4210", Offset = "0x67F3010", VA = "0x1867F4210")]
	private void LLEJOCAJGCB(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x67F3A40", Offset = "0x67F2840", VA = "0x1867F3A40", Slot = "7")]
	public void APICNIJKFEF(Vector3 EFPBPAKGILI, ForceMode JNAPKOAKBGI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class HLHDEHCMPOM : PBPLGONMKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool GPCCFCGNBBG;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GEADIDCMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x67E4E00", Offset = "0x67E3C00", VA = "0x1867E4E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CD0", Offset = "0x67E2AD0", VA = "0x1867E3CD0")]
	public HLHDEHCMPOM(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x67E4DD0", Offset = "0x67E3BD0", VA = "0x1867E4DD0", Slot = "6")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x67E4F10", Offset = "0x67E3D10", VA = "0x1867E4F10", Slot = "7")]
	public void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class MEEOEGPFGAH : FBFAMGCGCKC, ENJLEOAAPPD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AKGHONDNBFH LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<AKGHONDNBFH> EBOOIHOJPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private AKGHONDNBFH GDOPFEEANMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private AKGHONDNBFH OGCHMLDLLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform KDLDMGGLDNL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x67F05F0", Offset = "0x67EF3F0", VA = "0x1867F05F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x67F1AD0", Offset = "0x67F08D0", VA = "0x1867F1AD0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public AKGHONDNBFH OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7B7050", Offset = "0x7B5E50", VA = "0x1807B7050", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<AKGHONDNBFH> IBPLKIFKNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B5840", Offset = "0x7B4640", VA = "0x1807B5840", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OFINEMEBIAE JMCJLJFFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67F18F0", Offset = "0x67F06F0", VA = "0x1867F18F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67F0840", Offset = "0x67EF640", VA = "0x1867F0840", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OFINEMEBIAE DMEPABNCDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x67F20C0", Offset = "0x67F0EC0", VA = "0x1867F20C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x67F2290", Offset = "0x67F1090", VA = "0x1867F2290", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BPNEMCMFOAO FBGAKAKMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x67F2330", Offset = "0x67F1130", VA = "0x1867F2330", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x67F1590", Offset = "0x67F0390", VA = "0x1867F1590", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action MGLMFHMDGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x67F1630", Offset = "0x67F0430", VA = "0x1867F1630", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x67F1850", Offset = "0x67F0650", VA = "0x1867F1850", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EMAAIDJKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x67F1990", Offset = "0x67F0790", VA = "0x1867F1990", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x67F0990", Offset = "0x67EF790", VA = "0x1867F0990", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AKGHONDNBFH> CDNAGOPIBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x67F1E00", Offset = "0x67F0C00", VA = "0x1867F1E00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x67F08E0", Offset = "0x67EF6E0", VA = "0x1867F08E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AKGHONDNBFH> ELFBFDGMOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x67F0A30", Offset = "0x67EF830", VA = "0x1867F0A30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x67F1060", Offset = "0x67EFE60", VA = "0x1867F1060", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action NFNBFLMFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x67F0650", Offset = "0x67EF450", VA = "0x1867F0650", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x67F14F0", Offset = "0x67F02F0", VA = "0x1867F14F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AKGHONDNBFH> CGFMLIIGLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x67F1AE0", Offset = "0x67F08E0", VA = "0x1867F1AE0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x67F0790", Offset = "0x67EF590", VA = "0x1867F0790", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x67F23D0", Offset = "0x67F11D0", VA = "0x1867F23D0")]
	public MEEOEGPFGAH(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x67F1450", Offset = "0x67F0250", VA = "0x1867F1450", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x67F0AE0", Offset = "0x67EF8E0", VA = "0x1867F0AE0", Slot = "30")]
	public void CHDAKFMCKBA(AKGHONDNBFH OIJEBDLJMMH, bool OECKDFDIPHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x67F1B90", Offset = "0x67F0990", VA = "0x1867F1B90", Slot = "6")]
	public void KCGLPOHPKLD(AKGHONDNBFH MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x67F11D0", Offset = "0x67EFFD0", VA = "0x1867F11D0", Slot = "7")]
	public void DPEJIIMDEFC(AKGHONDNBFH MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x67F1EB0", Offset = "0x67F0CB0", VA = "0x1867F1EB0", Slot = "4")]
	public void LMOKIJJFMPI(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x67F06F0", Offset = "0x67EF4F0", VA = "0x1867F06F0", Slot = "5")]
	public void ALEADCEDJPP(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x67F1A30", Offset = "0x67F0830", VA = "0x1867F1A30")]
	private void HMLBBDGJJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x67F16D0", Offset = "0x67F04D0", VA = "0x1867F16D0")]
	private void GCABBAHMPBN(AKGHONDNBFH MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x67F1710", Offset = "0x67F0510", VA = "0x1867F1710")]
	private void GHJMLPFFNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2160", Offset = "0x67F0F60", VA = "0x1867F2160")]
	private void OFIKFDPHGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x67F1FA0", Offset = "0x67F0DA0", VA = "0x1867F1FA0")]
	private void ODDEMDOPNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x67F1110", Offset = "0x67EFF10", VA = "0x1867F1110")]
	[CompilerGenerated]
	private object DHIMOJNDHEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class HPFFAFKCDED
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x67E4F80", Offset = "0x67E3D80", VA = "0x1867E4F80")]
	public static FBFAMGCGCKC PCLEIHPBPIJ(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KABIAALEKPI : EIBNFFJALBB, MMELBLHPCCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DFBBOHICGKE<AKGHONDNBFH> DGAGFAFBPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MLINLOGCALN;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DFBBOHICGKE<AKGHONDNBFH> DAPGLHBHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 OOHEKELGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x67E5F80", Offset = "0x67E4D80", VA = "0x1867E5F80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DGAPEEKADCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67E57B0", Offset = "0x67E45B0", VA = "0x1867E57B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 OONJHIGHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x67E5EA0", Offset = "0x67E4CA0", VA = "0x1867E5EA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public AKGHONDNBFH NLIKNKFNOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x67E5700", Offset = "0x67E4500", VA = "0x1867E5700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x67E6020", Offset = "0x67E4E20", VA = "0x1867E6020")]
	public KABIAALEKPI(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x67E5FB0", Offset = "0x67E4DB0", VA = "0x1867E5FB0", Slot = "8")]
	public void JNMNPAEOFHM(AKGHONDNBFH OGCHMLDLLMJ, object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x67E5AB0", Offset = "0x67E48B0", VA = "0x1867E5AB0", Slot = "9")]
	public void CAOOIAPNGJL(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x67E5B10", Offset = "0x67E4910", VA = "0x1867E5B10")]
	private Vector3 CBPDHMDAHAM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x67E5370", Offset = "0x67E4170", VA = "0x1867E5370")]
	private void BDEAHMLEAII(AKGHONDNBFH ACEMLLAIMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class FEFFPBHFBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x67E3D60", Offset = "0x67E2B60", VA = "0x1867E3D60")]
	public static EIBNFFJALBB PIHMHNENMAC(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LAJOBECJNAN : GDCHBGEFFPC, KKPGAAKBGGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 OKCDMFDFCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 GEBACHONAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float GGKHMKMJJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float KLOLLNHBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 BPFKIFENBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? PPDGJPEPHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? BOGDKECCPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool DPABHKDNFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool LFKGBEPILMA;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 KFFPBAIEJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xBDD4E0", Offset = "0xBDC2E0", VA = "0x180BDD4E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x67ECED0", Offset = "0x67EBCD0", VA = "0x1867ECED0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 MELNCNPPNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x67ECB50", Offset = "0x67EB950", VA = "0x1867ECB50", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float KLOHAEEPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1249920", Offset = "0x1248720", VA = "0x181249920", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x67ECF80", Offset = "0x67EBD80", VA = "0x1867ECF80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float COEGFAGDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC662B0", Offset = "0xC650B0", VA = "0x180C662B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x67EDD30", Offset = "0x67ECB30", VA = "0x1867EDD30", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 IJNNDDDEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x67ED130", Offset = "0x67EBF30", VA = "0x1867ED130", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion INEHOMGOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x67EC800", Offset = "0x67EB600", VA = "0x1867EC800", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x67E3590", Offset = "0x67E2390", VA = "0x1867E3590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event OFINEMEBIAE LIHBKPIFBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x67ED090", Offset = "0x67EBE90", VA = "0x1867ED090", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x67ED900", Offset = "0x67EC700", VA = "0x1867ED900", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x67EEDC0", Offset = "0x67EDBC0", VA = "0x1867EEDC0")]
	public LAJOBECJNAN(AKGHONDNBFH LELBNINIFLI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x67ED750", Offset = "0x67EC550", VA = "0x1867ED750", Slot = "17")]
	public void IKHIJIJIIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x67ECA70", Offset = "0x67EB870", VA = "0x1867ECA70", Slot = "16")]
	public void BHBBAJNCMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x67ECC50", Offset = "0x67EBA50", VA = "0x1867ECC50", Slot = "19")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x67EDB40", Offset = "0x67EC940", VA = "0x1867EDB40", Slot = "20")]
	public void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x67ECD30", Offset = "0x67EBB30", VA = "0x1867ECD30", Slot = "18")]
	public void DAKLCLKFBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x67ED2C0", Offset = "0x67EC0C0", VA = "0x1867ED2C0", Slot = "21")]
	public void HLHJHEBCDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x67ECED0", Offset = "0x67EBCD0", VA = "0x1867ECED0")]
	private void IHILBIOBGHH(Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x67EC980", Offset = "0x67EB780", VA = "0x1867EC980")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BEOABPEGMME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x67ECF80", Offset = "0x67EBD80", VA = "0x1867ECF80")]
	private void FJKDGMNDJCA(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x67EDD30", Offset = "0x67ECB30", VA = "0x1867EDD30")]
	private void KEPCDLPEGGL(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x67ED9A0", Offset = "0x67EC7A0", VA = "0x1867ED9A0")]
	private Vector3 JJPBJICPLOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x67EC5D0", Offset = "0x67EB3D0", VA = "0x1867EC5D0", Slot = "15")]
	public void AOFMFEHAFMM((Quaternion rot, Vector3 moments) HFPKCKDFCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x67EDDE0", Offset = "0x67ECBE0", VA = "0x1867EDDE0")]
	private Quaternion OEIEOKCIOAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x67EECF0", Offset = "0x67EDAF0", VA = "0x1867EECF0")]
	public void PANCIFMFFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x67EDF60", Offset = "0x67ECD60", VA = "0x1867EDF60", Slot = "4")]
	public (float, Vector3) PANCIFMFFEK(Rigidbody EJAMDOGMOII)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class OIGFLECBHIN
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x67F26A0", Offset = "0x67F14A0", VA = "0x1867F26A0")]
	public static GDCHBGEFFPC CCHNNGMJHJN(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PKDENEECJEH : IFMBIBLACCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly MJAHGDHMCCG IJIEOLOLCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HOHJIBLCPPE OMNCCIOEEKP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool DEHCDBPLAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xD9DE10", Offset = "0xD9CC10", VA = "0x180D9DE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HOHJIBLCPPE DJGNOOGIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0", Slot = "11")]
		get
		{
			return default(HOHJIBLCPPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x67F4BA0", Offset = "0x67F39A0", VA = "0x1867F4BA0")]
	public PKDENEECJEH(AKGHONDNBFH LELBNINIFLI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x67F47B0", Offset = "0x67F35B0", VA = "0x1867F47B0", Slot = "4")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x67F4710", Offset = "0x67F3510", VA = "0x1867F4710")]
	private bool DNAJFEHGLDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x67F4880", Offset = "0x67F3680", VA = "0x1867F4880", Slot = "5")]
	public void EJPFDNLPFBF(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x67F4B30", Offset = "0x67F3930", VA = "0x1867F4B30", Slot = "6")]
	public void NNFNDJKKMGD(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x67F4A00", Offset = "0x67F3800", VA = "0x1867F4A00", Slot = "9")]
	public void LGPJHCCEKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x67F48B0", Offset = "0x67F36B0", VA = "0x1867F48B0")]
	private void KKGGCCLOLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x67F45A0", Offset = "0x67F33A0", VA = "0x1867F45A0")]
	private void DCHHFCEGCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x67F4B60", Offset = "0x67F3960", VA = "0x1867F4B60", Slot = "8")]
	public void ODKHNHBBMGK(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x67F49C0", Offset = "0x67F37C0", VA = "0x1867F49C0", Slot = "7")]
	public void KLIDMGBKDDO(AKGHONDNBFH LELBNINIFLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LOAJAJMKOKG : PDNHMPMDPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MJAHGDHMCCG BBLOJGLOFDH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AOJAFCMIGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x67EF0B0", Offset = "0x67EDEB0", VA = "0x1867EF0B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event OFINEMEBIAE DHPMKMEMJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x67EF290", Offset = "0x67EE090", VA = "0x1867EF290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x67EF160", Offset = "0x67EDF60", VA = "0x1867EF160", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x67EF330", Offset = "0x67EE130", VA = "0x1867EF330")]
	public LOAJAJMKOKG(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x67EF200", Offset = "0x67EE000", VA = "0x1867EF200", Slot = "7")]
	public void IMPLLPCGDLC(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x67EF280", Offset = "0x67EE080", VA = "0x1867EF280", Slot = "8")]
	public void MJJHOONEELH(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x67EEF20", Offset = "0x67EDD20", VA = "0x1867EEF20", Slot = "9")]
	public void ABLEDFOLHJC(object ADNDMAGEPOK, bool GBKJJHMELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x67EF210", Offset = "0x67EE010", VA = "0x1867EF210", Slot = "12")]
	public void JOAOEAHKKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x67EF030", Offset = "0x67EDE30", VA = "0x1867EF030", Slot = "10")]
	public void CNCDLJANDGC(Rigidbody AAHNMGFGCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x67EF250", Offset = "0x67EE050", VA = "0x1867EF250", Slot = "11")]
	public void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class GBGFHAAMJIC : NDKEFEGDBLD, LILLPBLBCGC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView EDFAPFELCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool ICPPDGEGOGL;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView CLNAIDAEIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool NGPEMOIEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x67E45F0", Offset = "0x67E33F0", VA = "0x1867E45F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool DMFHGMAJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F8610", Offset = "0x8F7410", VA = "0x1808F8610", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OFINEMEBIAE EENGHCPLOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x67E46B0", Offset = "0x67E34B0", VA = "0x1867E46B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x67E4610", Offset = "0x67E3410", VA = "0x1867E4610", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x67E49C0", Offset = "0x67E37C0", VA = "0x1867E49C0")]
	public GBGFHAAMJIC(AKGHONDNBFH LELBNINIFLI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x67E3E20", Offset = "0x67E2C20", VA = "0x1867E3E20", Slot = "9")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x67E3F50", Offset = "0x67E2D50", VA = "0x1867E3F50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x67E4050", Offset = "0x67E2E50", VA = "0x1867E4050", Slot = "10")]
	public void EGOHJAHJGKP(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x67E41C0", Offset = "0x67E2FC0", VA = "0x1867E41C0", Slot = "11")]
	public void EJCBPKKDFON(AKGHONDNBFH OGCHMLDLLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x67E4480", Offset = "0x67E3280", VA = "0x1867E4480")]
	private void GCKJDFAELPN(PhotonView JCGDKCIPBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x67E4330", Offset = "0x67E3130", VA = "0x1867E4330")]
	private void FJKOFHCCKGG(CJBNPFDPBKJ AIGAPFFOPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x67E4750", Offset = "0x67E3550", VA = "0x1867E4750")]
	private void NANOFAOPEGC(PhotonView BCCEPILFLGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BALJNJOEBMJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x67E1770", Offset = "0x67E0570", VA = "0x1867E1770")]
	public static NDKEFEGDBLD HNPIKPGLKGM(this AKGHONDNBFH LFPEHEIJNLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HBKAJEKCNJP : INOCKBEDMFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints AFHMPPHFBOJ;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HPEMPGOJNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB71950", Offset = "0xB70750", VA = "0x180B71950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3FEBD00", Offset = "0x3FEAB00", VA = "0x183FEBD00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FCEHPCIPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xDECA10", Offset = "0xDEB810", VA = "0x180DECA10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3FEBCF0", Offset = "0x3FEAAF0", VA = "0x183FEBCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints EFFFCMMEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x67E4BC0", Offset = "0x67E39C0", VA = "0x1867E4BC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x67E4D20", Offset = "0x67E3B20", VA = "0x1867E4D20")]
	public HBKAJEKCNJP(AKGHONDNBFH LELBNINIFLI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x67E4B90", Offset = "0x67E3990", VA = "0x1867E4B90", Slot = "9")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x67E4CF0", Offset = "0x67E3AF0", VA = "0x1867E4CF0", Slot = "10")]
	public void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KCMMBMCIOIB : CJFAFBCDBDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AKGHONDNBFH LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float GCNJANMKHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float GMNCHFOEOHH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float OEDBHJNKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x938680", Offset = "0x937480", VA = "0x180938680", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x67E6210", Offset = "0x67E5010", VA = "0x1867E6210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float GGIEPMABIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9EF930", Offset = "0x9EE730", VA = "0x1809EF930", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x67E62E0", Offset = "0x67E50E0", VA = "0x1867E62E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x67E63B0", Offset = "0x67E51B0", VA = "0x1867E63B0")]
	public KCMMBMCIOIB(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x67E6120", Offset = "0x67E4F20", VA = "0x1867E6120", Slot = "8")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x67E6170", Offset = "0x67E4F70", VA = "0x1867E6170", Slot = "9")]
	public void KBBFIOAGNOM(Rigidbody GDOCMGOHKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class CAEIGAIHMCK : NOFJCCIMPKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PLNCEHBOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool LNHEGJOFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int JJPOFFFNDJB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x67E3590", Offset = "0x67E2390", VA = "0x1867E3590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool ALEPKLJPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x67E2D60", Offset = "0x67E1B60", VA = "0x1867E2D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private AKGHONDNBFH DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x67E35E0", Offset = "0x67E23E0", VA = "0x1867E35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool BILKBDDKIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x67E31F0", Offset = "0x67E1FF0", VA = "0x1867E31F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OFINEMEBIAE OFALEBHKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x67E2D80", Offset = "0x67E1B80", VA = "0x1867E2D80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x67E2F60", Offset = "0x67E1D60", VA = "0x1867E2F60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x67E3640", Offset = "0x67E2440", VA = "0x1867E3640")]
	public CAEIGAIHMCK(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x67E2ED0", Offset = "0x67E1CD0", VA = "0x1867E2ED0", Slot = "6")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x67E2EC0", Offset = "0x67E1CC0", VA = "0x1867E2EC0", Slot = "8")]
	public void DDLAKMGFDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x67E3000", Offset = "0x67E1E00", VA = "0x1867E3000", Slot = "7")]
	public bool KPKOCFBPGPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x67E2E20", Offset = "0x67E1C20", VA = "0x1867E2E20", Slot = "9")]
	public void CJPEANJCFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x67E3150", Offset = "0x67E1F50", VA = "0x1867E3150", Slot = "11")]
	public void LJGFGFIGPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x67E33E0", Offset = "0x67E21E0", VA = "0x1867E33E0", Slot = "10")]
	public void ODDGKCKGNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x67E2B80", Offset = "0x67E1980", VA = "0x1867E2B80")]
	private bool BEKJKGEBGFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x67E3250", Offset = "0x67E2050", VA = "0x1867E3250")]
	private void NELHKLNOIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MBINOOGNGGC : BEAJMPDJLHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MJAHGDHMCCG IGONMIFKCFF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody KHNHAENIIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool BILKBDDKIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x67F0300", Offset = "0x67EF100", VA = "0x1867F0300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LFACIAPODND
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xD9DE10", Offset = "0xD9CC10", VA = "0x180D9DE10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x67F04E0", Offset = "0x67EF2E0", VA = "0x1867F04E0")]
	public MBINOOGNGGC(AKGHONDNBFH LELBNINIFLI, [In] FAFMMNEEDEJ LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x67EFCE0", Offset = "0x67EEAE0", VA = "0x1867EFCE0", Slot = "5")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x67EFD80", Offset = "0x67EEB80", VA = "0x1867EFD80", Slot = "7")]
	public void EEANEJDDGLP(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x67F00E0", Offset = "0x67EEEE0", VA = "0x1867F00E0", Slot = "8")]
	public void KLIIOIMOEDI(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x67EFDB0", Offset = "0x67EEBB0", VA = "0x1867EFDB0", Slot = "9")]
	public void JNLEPIJOKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x67F0110", Offset = "0x67EEF10", VA = "0x1867F0110", Slot = "11")]
	public void LFOMFIPHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x67F0360", Offset = "0x67EF160", VA = "0x1867F0360", Slot = "12")]
	public void MNDKMBAAKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x67EF850", Offset = "0x67EE650", VA = "0x1867EF850", Slot = "10")]
	public void BMIBGCFEJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x67EF4F0", Offset = "0x67EE2F0", VA = "0x1867EF4F0")]
	private void AEECOOPLMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x67EF6A0", Offset = "0x67EE4A0", VA = "0x1867EF6A0")]
	private void BEEKPGGFAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AOFLBACKHGK : NHHLAKMKOGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly KGNKJDNANDM LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly MJAHGDHMCCG GHKCEODIMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float NLLKAOHMMKA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NBCOLHOOHLA LIBEDDGLDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IPMNNOHAGGH KEDDGLJGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 OONJHIGHOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x67DE350", Offset = "0x67DD150", VA = "0x1867DE350", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x67DF3E0", Offset = "0x67DE1E0", VA = "0x1867DF3E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 FKLCHNPGOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x67DF980", Offset = "0x67DE780", VA = "0x1867DF980", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x67DF1D0", Offset = "0x67DDFD0", VA = "0x1867DF1D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MLJDAKDGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x67DECC0", Offset = "0x67DDAC0", VA = "0x1867DECC0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x67DE0E0", Offset = "0x67DCEE0", VA = "0x1867DE0E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NGGKALLNEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x67DFB10", Offset = "0x67DE910", VA = "0x1867DFB10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x67DEE80", Offset = "0x67DDC80", VA = "0x1867DEE80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float GDDDCPAMJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x975D90", Offset = "0x974B90", VA = "0x180975D90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x67DE930", Offset = "0x67DD730", VA = "0x1867DE930", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool EHBJIEEACAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1753620", Offset = "0x1752420", VA = "0x181753620", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ACLNFJFMMHD FKKMCCJKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x60AD1F0", Offset = "0x60ABFF0", VA = "0x1860AD1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool ALEPKLJPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x67DE1A0", Offset = "0x67DCFA0", VA = "0x1867DE1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x67E1680", Offset = "0x67E0480", VA = "0x1867E1680")]
	public AOFLBACKHGK(AKGHONDNBFH LELBNINIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x67DE510", Offset = "0x67DD310", VA = "0x1867DE510", Slot = "19")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x67DE5B0", Offset = "0x67DD3B0", VA = "0x1867DE5B0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x67DE220", Offset = "0x67DD020", VA = "0x1867DE220", Slot = "28")]
	public void CNCDLJANDGC(Rigidbody GDOCMGOHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xBB21E0", Offset = "0xBB0FE0", VA = "0x180BB21E0", Slot = "20")]
	public void KKKHKGAKJHI(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBB34D0", Offset = "0xBB22D0", VA = "0x180BB34D0", Slot = "30")]
	public void CGJEDMDHGCB(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x67DF200", Offset = "0x67DE000", VA = "0x1867DF200", Slot = "35")]
	public Vector3 HNHPBBIDOPP(Vector3 FEBEDMALBGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F90", Offset = "0x67DFD90", VA = "0x1867E0F90", Slot = "34")]
	public Vector3 OFLBNPLJECH(Vector3 JJEHMIEJHFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x67DE510", Offset = "0x67DD310", VA = "0x1867DE510", Slot = "27")]
	public void PDLIEDFBGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F30", Offset = "0x67DFD30", VA = "0x1867E0F30", Slot = "25")]
	public void NODOGLFFAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x67DE1C0", Offset = "0x67DCFC0", VA = "0x1867DE1C0", Slot = "24")]
	public void CNBMLLDKMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x67DE6F0", Offset = "0x67DD4F0", VA = "0x1867DE6F0", Slot = "33")]
	public void FDEINDINLMA(Vector3 NCHINPMAHPE, Vector3 CNNDEIHAEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x67DF920", Offset = "0x67DE720", VA = "0x1867DF920", Slot = "32")]
	public void JJLILNLBEND(Vector3 MIOENFHJJMC, Vector3 LKIGCGOOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x67E0D90", Offset = "0x67DFB90", VA = "0x1867E0D90", Slot = "31")]
	public void NODLCLEJEMD(Vector3 OHOEONEMMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x67E06D0", Offset = "0x67DF4D0", VA = "0x1867E06D0", Slot = "22")]
	public void MOBOBKOMMJE(NFOPMPPJPBC DAAKAAMCJGM, Vector3 FJPCMFDNDLK, float EALDBOAOAAB, float NLNDBIOAOBP = 8f, float ALNOJOLJNPA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x67DEA40", Offset = "0x67DD840", VA = "0x1867DEA40", Slot = "21")]
	public void FJEPJOKBNPN(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IPBBPJAIBDM, float EEBGFNENBKN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x67E1200", Offset = "0x67E0000", VA = "0x1867E1200", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PJLACDEEHEJ(OGKHIFLJBDJ LCIAHOMDBIP, Vector3 IHHAEIJMAPE, float LBPGBDGINCH = 7f, float GIGKBFGDMPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xCAB9C0", Offset = "0xCAA7C0", VA = "0x180CAB9C0")]
	private static void ABGBFDBLLNM(Vector3 PKCNPDCOCJE, Vector3 ELKFIDDLEIG, [Out] Vector3 NIAFGOBLGEK, [Out] Vector3 IIPDEDMDOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x67DE610", Offset = "0x67DD410", VA = "0x1867DE610", Slot = "29")]
	public Vector3 FCAGAKMLKIM(Vector3 PKCNPDCOCJE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEB0", Offset = "0x67DDCB0", VA = "0x1867DEEB0", Slot = "26")]
	public void GMCECHADLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x67DE930", Offset = "0x67DD730", VA = "0x1867DE930")]
	private void NCANMJDHDJF(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x67DDF40", Offset = "0x67DCD40", VA = "0x1867DDF40")]
	private void AKDKEMOGAFE(Vector3 IPBBPJAIBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x67E0C10", Offset = "0x67DFA10", VA = "0x1867E0C10")]
	private Vector3 NJKAHLDGOJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x67DF4A0", Offset = "0x67DE2A0", VA = "0x1867DF4A0")]
	private void IODAMJHDDLL(Vector3 JJEHMIEJHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x67DF040", Offset = "0x67DDE40", VA = "0x1867DF040")]
	private Vector3 GMJBDEAEEMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x67DFCA0", Offset = "0x67DEAA0", VA = "0x1867DFCA0")]
	private void LJOBIHONCNN(Vector3 DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x67E0120", Offset = "0x67DEF20", VA = "0x1867E0120")]
	private void MKDNNOHFAAL(Vector3 JJEHMIEJHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x67E1150", Offset = "0x67DFF50", VA = "0x1867E1150")]
	private void PDKCHHAJFNK()
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
