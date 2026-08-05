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
	public class LogRegistrationIndex : JICBOCPMGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6700DE0", Offset = "0x66FFFE0", VA = "0x186700DE0", Slot = "4")]
		public override void OEPCKJDAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
	public class _AssemblyIndex : BHGNIPDAAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PLDKANGDDDP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13511C0", Offset = "0x13503C0", VA = "0x1813511C0", Slot = "5")]
		public override void NFPDFNDEAED(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x670DCF0", Offset = "0x670CEF0", VA = "0x18670DCF0")]
		private void LFIGPBIMHMM(NFPJJEAKHFP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x670E000", Offset = "0x670D200", VA = "0x18670E000", Slot = "6")]
		public override void PLBJNCNNDBL(NFPJJEAKHFP registry, [In] MFEOBGFJEOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "8")]
		public override void AKMCFODBHPA(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x670E060", Offset = "0x670D260", VA = "0x18670E060")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, POKMEHNCJBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IOBNAOMELJK MOHFGHNAHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PHHFMMFOBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MPABILDJPPM JMOPCLGEBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[CPBKDNLKGAP(DGCAKKBAIEP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[CPBKDNLKGAP(DGCAKKBAIEP.SelfAndParent, true, false, false)]
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
		private BKKIHAGPCJF physicsInterpolation;

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
		internal MPABILDJPPM PGAIFKPODHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6708970", Offset = "0x6707B70", VA = "0x186708970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MPABILDJPPM CCJMNMNPMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FKDINEDDBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x670B160", Offset = "0x670A360", VA = "0x18670B160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GKINMHLNHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x670B4C0", Offset = "0x670A6C0", VA = "0x18670B4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NECEBBLCHMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x670B400", Offset = "0x670A600", VA = "0x18670B400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DLAKBCKOLFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x670C160", Offset = "0x670B360", VA = "0x18670C160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x670D660", Offset = "0x670C860", VA = "0x18670D660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FANCFKPBFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA70", Offset = "0x7DCC70", VA = "0x1807DDA70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MPPFKJCEGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA70", Offset = "0x7DCC70", VA = "0x1807DDA70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DOAGAABAFKI DCLHOBDFJDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x670B1C0", Offset = "0x670A3C0", VA = "0x18670B1C0")]
			get
			{
				return default(DOAGAABAFKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x670CE10", Offset = "0x670C010", VA = "0x18670CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OGNGDDIFAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x670B7D0", Offset = "0x670A9D0", VA = "0x18670B7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AHBMMBODCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x670B2E0", Offset = "0x670A4E0", VA = "0x18670B2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public AEELDBJLIOI OCIHGIEMFAF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x670B710", Offset = "0x670A910", VA = "0x18670B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x670CFD0", Offset = "0x670C1D0", VA = "0x18670CFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OFDDOEGADFI AOGLCJHKNIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x670B6B0", Offset = "0x670A8B0", VA = "0x18670B6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x670CF60", Offset = "0x670C160", VA = "0x18670CF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LABKLHCLHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x670B600", Offset = "0x670A800", VA = "0x18670B600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody LKJEANBPGDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x670B660", Offset = "0x670A860", VA = "0x18670B660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CKEOACICAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x670B340", Offset = "0x670A540", VA = "0x18670B340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x670CE80", Offset = "0x670C080", VA = "0x18670CE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MHGJEPJCAHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5EAD6A0", Offset = "0x5EAC8A0", VA = "0x185EAD6A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HKBONEANDOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x670C100", Offset = "0x670B300", VA = "0x18670C100")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OKLIAJJPEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x670C0A0", Offset = "0x670B2A0", VA = "0x18670C0A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x670D5F0", Offset = "0x670C7F0", VA = "0x18670D5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GKGGFPDPLHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x670BA30", Offset = "0x670AC30", VA = "0x18670BA30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x670D270", Offset = "0x670C470", VA = "0x18670D270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float AILOPPMEIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x670B830", Offset = "0x670AA30", VA = "0x18670B830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x670D040", Offset = "0x670C240", VA = "0x18670D040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EFNKDELENDF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x670C6B0", Offset = "0x670B8B0", VA = "0x18670C6B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x670DBA0", Offset = "0x670CDA0", VA = "0x18670DBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 IHDEPBHGEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x670BE80", Offset = "0x670B080", VA = "0x18670BE80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x670D3C0", Offset = "0x670C5C0", VA = "0x18670D3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 AGFIDHELAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x670C7F0", Offset = "0x670B9F0", VA = "0x18670C7F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode DJBMAFKMOND
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x670B970", Offset = "0x670AB70", VA = "0x18670B970")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x670D190", Offset = "0x670C390", VA = "0x18670D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float PKPAGNEHHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x670B3A0", Offset = "0x670A5A0", VA = "0x18670B3A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x670CEF0", Offset = "0x670C0F0", VA = "0x18670CEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints JDFMLCNEJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x670B9D0", Offset = "0x670ABD0", VA = "0x18670B9D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x670D200", Offset = "0x670C400", VA = "0x18670D200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FHMADJCJGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x670C220", Offset = "0x670B420", VA = "0x18670C220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 IENIAOCFBEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x670C220", Offset = "0x670B420", VA = "0x18670C220")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x670D980", Offset = "0x670CB80", VA = "0x18670D980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MMALJBFNOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x670BF60", Offset = "0x670B160", VA = "0x18670BF60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x670D4A0", Offset = "0x670C6A0", VA = "0x18670D4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float HOOIIAJEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x670C650", Offset = "0x670B850", VA = "0x18670C650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x670DB30", Offset = "0x670CD30", VA = "0x18670DB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion HMGDIKNHDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x670C300", Offset = "0x670B500", VA = "0x18670C300")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x670D700", Offset = "0x670C900", VA = "0x18670D700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion ICLAIABHOFI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x670C580", Offset = "0x670B780", VA = "0x18670C580")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x670DA60", Offset = "0x670CC60", VA = "0x18670DA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 DKOIBHOGIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x670C3D0", Offset = "0x670B5D0", VA = "0x18670C3D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x670D7D0", Offset = "0x670C9D0", VA = "0x18670D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion AEGOLJMLHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x670C4B0", Offset = "0x670B6B0", VA = "0x18670C4B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x670D8B0", Offset = "0x670CAB0", VA = "0x18670D8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 MDKLJOBFIPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x670C710", Offset = "0x670B910", VA = "0x18670C710")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x670DC10", Offset = "0x670CE10", VA = "0x18670DC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 KAIPEFHNECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x670BFC0", Offset = "0x670B1C0", VA = "0x18670BFC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x670D510", Offset = "0x670C710", VA = "0x18670D510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DIDBDFPOMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x670B890", Offset = "0x670AA90", VA = "0x18670B890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x670D0B0", Offset = "0x670C2B0", VA = "0x18670D0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MLKEHNHJPMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x670BDA0", Offset = "0x670AFA0", VA = "0x18670BDA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x670D2E0", Offset = "0x670C4E0", VA = "0x18670D2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JHFHHANIEJN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x670BC60", Offset = "0x670AE60", VA = "0x18670BC60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion GJPAPHHKJEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x670BB90", Offset = "0x670AD90", VA = "0x18670BB90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HCJIOLAPMGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x670C9B0", Offset = "0x670BBB0", VA = "0x18670C9B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 JNMCDLGKMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x670C8D0", Offset = "0x670BAD0", VA = "0x18670C8D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DJLJECFADMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x670BD40", Offset = "0x670AF40", VA = "0x18670BD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CLLNGBLDHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x670B770", Offset = "0x670A970", VA = "0x18670B770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AFPEAKEFDME
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x670B280", Offset = "0x670A480", VA = "0x18670B280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KLJNFPNIMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x670B220", Offset = "0x670A420", VA = "0x18670B220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FIABCHJOGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x670B100", Offset = "0x670A300", VA = "0x18670B100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HOJPFCGDJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x670BA90", Offset = "0x670AC90", VA = "0x18670BA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HKJFMKICGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x522E9D0", Offset = "0x522DBD0", VA = "0x18522E9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MBDFLHOAEJJ GAKAGBNCEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x670B020", Offset = "0x670A220", VA = "0x18670B020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x670CD30", Offset = "0x670BF30", VA = "0x18670CD30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DJPOHPOJKMP MIKEDADMJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x670AD90", Offset = "0x6709F90", VA = "0x18670AD90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x670CA90", Offset = "0x670BC90", VA = "0x18670CA90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DJPOHPOJKMP IKFDKBDLEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x670ADF0", Offset = "0x6709FF0", VA = "0x18670ADF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x670CB00", Offset = "0x670BD00", VA = "0x18670CB00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DJPOHPOJKMP MNJPFKICJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x670AF40", Offset = "0x670A140", VA = "0x18670AF40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x670CC50", Offset = "0x670BE50", VA = "0x18670CC50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LABHNEIMMOD, LABHNEIMMOD> IFDAOOPJMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x670AED0", Offset = "0x670A0D0", VA = "0x18670AED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x670CBE0", Offset = "0x670BDE0", VA = "0x18670CBE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event DJPOHPOJKMP PCNCJBLHNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x670AFB0", Offset = "0x670A1B0", VA = "0x18670AFB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x670CCC0", Offset = "0x670BEC0", VA = "0x18670CCC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DJPOHPOJKMP GHBNPOAHNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x670B090", Offset = "0x670A290", VA = "0x18670B090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x670CDA0", Offset = "0x670BFA0", VA = "0x18670CDA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DJPOHPOJKMP CBFNHGBDHGO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x670AE60", Offset = "0x670A060", VA = "0x18670AE60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x670CB70", Offset = "0x670BD70", VA = "0x18670CB70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110", Slot = "8")]
		private void KIBDDHNPELD(MPABILDJPPM HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6709620", Offset = "0x6708820", VA = "0x186709620")]
		internal void EFAMKEHGMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x670AAC0", Offset = "0x6709CC0", VA = "0x18670AAC0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody NOEDFAGHGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67098C0", Offset = "0x6708AC0", VA = "0x1867098C0")]
		public POKMEHNCJBC GetChild(int MBGANDEDPDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x670A790", Offset = "0x6709990", VA = "0x18670A790")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) OBCPHNOEGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67093D0", Offset = "0x67085D0", VA = "0x1867093D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6708970", Offset = "0x6707B70", VA = "0x186708970")]
		private MPABILDJPPM MMGBIHEENNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67096B0", Offset = "0x67088B0", VA = "0x1867096B0")]
		private void GNCDFEHEFDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6709F60", Offset = "0x6709160", VA = "0x186709F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6709620", Offset = "0x6708820", VA = "0x186709620")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6709F00", Offset = "0x6709100", VA = "0x186709F00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6709FC0", Offset = "0x67091C0", VA = "0x186709FC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6708A20", Offset = "0x6707C20", VA = "0x186708A20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x670A020", Offset = "0x6709220", VA = "0x18670A020")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67095C0", Offset = "0x67087C0", VA = "0x1867095C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6709EA0", Offset = "0x67090A0", VA = "0x186709EA0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x670A8F0", Offset = "0x6709AF0", VA = "0x18670A8F0")]
		public void SetParent(RigidbodyEx EKDDCPALANJ, bool DJPOIHCPABJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x670A330", Offset = "0x6709530", VA = "0x18670A330")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6709B70", Offset = "0x6708D70", VA = "0x186709B70")]
		public bool IsRigidbodyAncestor(RigidbodyEx GDPCBFCLPIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6709C50", Offset = "0x6708E50", VA = "0x186709C50")]
		public bool IsRigidbodyDescendant(RigidbodyEx GEDCDDICNAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6708C90", Offset = "0x6707E90", VA = "0x186708C90")]
		public void AddInterpolationRestriction(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x670A090", Offset = "0x6709290", VA = "0x18670A090")]
		public void RemoveInterpolationRestriction(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6708D00", Offset = "0x6707F00", VA = "0x186708D00")]
		public void AddKinematic(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x670A100", Offset = "0x6709300", VA = "0x18670A100")]
		public void RemoveKinematic(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x670A870", Offset = "0x6709A70", VA = "0x18670A870")]
		public void SetKinematic(object GMMJMENGHCD, bool AHPGPMLNBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x670A690", Offset = "0x6709890", VA = "0x18670A690")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BBIPDCGGCJI, Quaternion HDGDBKNDAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x670A590", Offset = "0x6709790", VA = "0x18670A590")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 KNIDEDNJIKD, Quaternion IINALNNAGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6709A60", Offset = "0x6708C60", VA = "0x186709A60")]
		public Vector3 GetConstrainedVelocity(Vector3 MDKLJOBFIPP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6709950", Offset = "0x6708B50", VA = "0x186709950")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DIDBDFPOMNO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6708BA0", Offset = "0x6707DA0", VA = "0x186708BA0")]
		public void AddForce(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6708A90", Offset = "0x6707C90", VA = "0x186708A90")]
		public void AddForceAtPosition(Vector3 HLOIBGCELIK, Vector3 JCMPCLFLJHD, ForceMode CEHCIFMOKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6708ED0", Offset = "0x67080D0", VA = "0x186708ED0")]
		public void AddTorque(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6708D70", Offset = "0x6707F70", VA = "0x186708D70")]
		public void AddRelativeTorque(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x670AB90", Offset = "0x6709D90", VA = "0x18670AB90")]
		public Vector3 WorldToLocalVelocity(Vector3 NIPPPODPAFG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6709D90", Offset = "0x6708F90", VA = "0x186709D90")]
		public Vector3 LocalToWorldVelocity(Vector3 KAIPEFHNECD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6709560", Offset = "0x6708760", VA = "0x186709560")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6709500", Offset = "0x6708700", VA = "0x186709500")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67094A0", Offset = "0x67086A0", VA = "0x1867094A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6709440", Offset = "0x6708640", VA = "0x186709440")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x670A490", Offset = "0x6709690", VA = "0x18670A490")]
		public void ResetVelocityWorldSpace(Vector3 ADCGEFMCJOH, Vector3 EGBIJKDMLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x670A390", Offset = "0x6709590", VA = "0x18670A390")]
		public void ResetVelocityLocalSpace(Vector3 FBFKKIJADKF, Vector3 MLKEHNHJPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x670A250", Offset = "0x6709450", VA = "0x18670A250")]
		public void ResetLinearVelocityLocalSpace(Vector3 FBFKKIJADKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x670AA20", Offset = "0x6709C20", VA = "0x18670AA20")]
		public bool SweepTest(Vector3 HIMAANDEJKI, [Out] RaycastHit HAENHELGKML, float NHMHEGFGMMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6709D30", Offset = "0x6708F30", VA = "0x186709D30")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x670A9C0", Offset = "0x6709BC0", VA = "0x18670A9C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x670AB30", Offset = "0x6709D30", VA = "0x18670AB30")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6708E60", Offset = "0x6708060", VA = "0x186708E60")]
		public void AddShouldHaveUnityRigidbodyToken(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x670A170", Offset = "0x6709370", VA = "0x18670A170")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6709260", Offset = "0x6708460", VA = "0x186709260")]
		public void ApplyForceVelocityChange(IFIOCMHLOGF OOJJGDDKMPH, Vector3 NKPBIBGIGIC, float FDGBHJOLFOB, float KCMPEKMFBNO = 8f, float MLECCBHOGPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6709160", Offset = "0x6708360", VA = "0x186709160")]
		public void ApplyAngularVelocityChange(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 CGOPPOICKIH, float AHDEBMHEIKE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6709320", Offset = "0x6708520", VA = "0x186709320")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 ECLCOOPOABI, float CMFBFEMGGMP = 7f, float HHEHPPDENGJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6709090", Offset = "0x6708290", VA = "0x186709090")]
		public bool AllowedScaleChange(float GGHLFGGDEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6708FC0", Offset = "0x67081C0", VA = "0x186708FC0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OFEKIDOIODB, object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x670A1E0", Offset = "0x67093E0", VA = "0x18670A1E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GMMJMENGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x670AD20", Offset = "0x6709F20", VA = "0x18670AD20")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x879D00", Offset = "0x878F00", VA = "0x180879D00", Slot = "4")]
		private GameObject KNDNBEKNELP()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA70", Offset = "0x7DCC70", VA = "0x1807DDA70", Slot = "5")]
		private Transform EGCFKCODGHI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class ECGCKHEGDKP
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66F86B0", Offset = "0x66F78B0", VA = "0x1866F86B0")]
	public static MPABILDJPPM PGAIFKPODHO(this RigidbodyEx IFDOJINLLBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GENMAJFODJG(typeof(DOGDBCICNDF), new string[] { })]
public class KAKBFKKCNHK : DOGDBCICNDF, BFELDJAKDCH
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private ELDNEGPEECB JAGNMFMJABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NKCEGEIMEEK CHEOCJAKLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IIFBFOMHPLG FGPJKLPHBCA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NKCEGEIMEEK FKBLCLBKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IIFBFOMHPLG BPAEHNEPIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66FF820", Offset = "0x66FEA20", VA = "0x1866FF820", Slot = "7")]
	public void InitReferences(NKHDFGLOEFE HHEDJECGCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66FF790", Offset = "0x66FE990", VA = "0x1866FF790", Slot = "6")]
	public MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KAKBFKKCNHK()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static DPAIEAIPOBP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int LNJMMPIDMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int OLCNLBKOLMH;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67087F0", Offset = "0x67079F0", VA = "0x1867087F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6708830", Offset = "0x6707A30", VA = "0x186708830")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6708810", Offset = "0x6707A10", VA = "0x186708810")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FFDOAJJEAOK, [Optional] UnityEngine.Object DPGBKIGAHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FFDOAJJEAOK, [Optional] UnityEngine.Object DPGBKIGAHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6708920", Offset = "0x6707B20", VA = "0x186708920")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DLJHAHJBOBE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EBOOBGCDIPJ : AEELDBJLIOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C47D0", Offset = "0x7C39D0", VA = "0x1807C47D0", Slot = "4")]
		public Vector3 FBJACNMIAPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C47D0", Offset = "0x7C39D0", VA = "0x1807C47D0", Slot = "5")]
		public Vector3 KKLDNPIJPEJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public EBOOBGCDIPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static AEELDBJLIOI KALIANAAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x66F85E0", Offset = "0x66F77E0", VA = "0x1866F85E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DEMKOPAMLLI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode EDHBGNGDFJA
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
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EBDJGIKEFLN(bool DJLJECFADMH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIDEICPKAIG(bool DJLJECFADMH);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IMBEONMFNPO(Vector3 HIMAANDEJKI, [Out] RaycastHit HAENHELGKML, float NHMHEGFGMMF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NBJGCIOOCMG : IDisposable, OKCPJPPOLPD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DOAGAABAFKI DCLHOBDFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LABHNEIMMOD, LABHNEIMMOD> IFDAOOPJMGM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLCNDFBLMIC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface IIFBFOMHPLG
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GNIKMKOHLHD OGHCEJNONDD(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBDLGBEPPIH COMMPGAEOOM(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LILECGPANDH PGKKLHCHPFO(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBIMJGCBKKA OHPPHOAGGJP(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GJIBIEPIFAM LLKHCLKCFJA(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBJGCIOOCMG LAPAEAFPHHM(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PHOOBEADFBI FLGOFKMKDOK(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LJKFLAEDCNM CFMPOKBFKOG(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DEMKOPAMLLI ILEEHEKPKLM(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OBHEHLEABAK IOJDFBCBLHA(MPABILDJPPM HMEKKAINJCD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KMNGNDHAEIF MNLGILEKBIJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PJIPIMFNJCN HDAEHLOJJBP(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MMADDFJJIIH HJLKDBIIAON(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ICHNJGFNMGO MPLNEAJEEJJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HPHDDFIAHBG BJLGJAAMJOH(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD, DOGDBCICNDF JPFNBECBJPL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LJKFLAEDCNM
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOFFMCNJKFD(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMMBJLBFGNI(Vector3 HLOIBGCELIK, Vector3 JCMPCLFLJHD, ForceMode CEHCIFMOKCP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKPNHPKHKJI(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHMIPAHPANM(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OBHEHLEABAK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FGLBIDFCLGD
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
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJECHFHJCDA(Rigidbody KIMBNNEGFIH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GNIKMKOHLHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<MPABILDJPPM> MPPKAEPJGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MPABILDJPPM NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DJPOHPOJKMP MIKEDADMJIE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DJPOHPOJKMP IKFDKBDLEKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MBDFLHOAEJJ ECCHALHHPCJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ALEGJENOFKB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action OLJOHPLMKDN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MPABILDJPPM> OEMFKPDJCMA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MPABILDJPPM> FMJNAGMDFFN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action FMOANFNHBLK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MPABILDJPPM> OKBPOCJEBFI;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DPPHNCDDAIK(MPABILDJPPM EBKJLIBKJMN, bool DJPOIHCPABJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LILECGPANDH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 OACIIGEFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 GNCLKAIHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALECIFJKJBF(MPABILDJPPM DLAKBCKOLFN, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCDDFHJDOPL(object GMMJMENGHCD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ICHNJGFNMGO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CMPINJFJFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DGCOODKILIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CEFKOHHOLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float IDCMHAOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 MOMIPLEMDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion JHJINPPHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event DJPOHPOJKMP HICHBFGBEFD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HMFLODDFELK((Quaternion rot, Vector3 moments) OBCPHNOEGPK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KEJBHMJHIGD();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGIIBBJKPBG();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HMHJBGCCKEF();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HJECHFHJCDA(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HEBNFIPHGLG();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MMADDFJJIIH
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGLNIGMAADO(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKMONOFDDKP(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOOJKEHBHII(MPABILDJPPM IFDOJINLLBE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNOBNFNJKHG(MPABILDJPPM IFDOJINLLBE);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CBMCIMPFMLI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PHOOBEADFBI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DMFCIKABDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DJPOHPOJKMP KLHHGNIABHH;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNJEKJEBIAF(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOEMMMCOGNB(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDGDJJIOCAK(object GMMJMENGHCD, bool AHPGPMLNBDI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APAFAGCFFFF(Rigidbody BCOOEAJBGOP);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJECHFHJCDA(Rigidbody KIMBNNEGFIH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PJIPIMFNJCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OGNGDDIFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool AHBMMBODCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DJPOHPOJKMP PFJLKPMAOJM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCINAEOOHDE(MPABILDJPPM DLAKBCKOLFN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OABMHGBELJH(MPABILDJPPM DLAKBCKOLFN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HPHDDFIAHBG
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CKEOACICAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BACENNOJOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints HKEHMJBNHAJ
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
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJECHFHJCDA(Rigidbody KIMBNNEGFIH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBIMJGCBKKA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float NNIBHOHJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float OOLIMOECINP
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
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJECHFHJCDA(Rigidbody KIMBNNEGFIH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GJIBIEPIFAM
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DJPOHPOJKMP OEFIGOGDIMI;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NMGHIDBNOPP();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNBKCBGBNAE();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMLPDOPBLNJ();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKEFPEJAGKM();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODJKIEDOKDA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KMNGNDHAEIF
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PGLOBOPHBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGGEPJLINMM(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAPMHAHADDB(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGENLAOMAPF();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFHFAEIDKIL();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GBDLGBEPPIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AEELDBJLIOI OCIHGIEMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	OFDDOEGADFI AOGLCJHKNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 HEGJMPMNGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 MLDNALOKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 OOBKCEPGDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 BIKJNHHJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float PKPAGNEHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LABKLHCLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKPAINFKNBG(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KONHEMLLAAO(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 CGOPPOICKIH, float AHDEBMHEIKE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GDMKGLIKMNN(IFIOCMHLOGF OOJJGDDKMPH, Vector3 NKPBIBGIGIC, float FDGBHJOLFOB, float KCMPEKMFBNO = 8f, float MLECCBHOGPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BMADFLFMOBL(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 ECLCOOPOABI, float CMFBFEMGGMP = 7f, float HHEHPPDENGJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ABFEFKGBJEG();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JIBBBIAEOBJ();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AMIMOGILGBF();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GJGAKFBBGJK();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void APAFAGCFFFF(Rigidbody KIMBNNEGFIH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AFNHCCJOILN(Vector3 MDKLJOBFIPP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OJIFKKBAKHB(object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GACEHJBOCDE(Vector3 LIEBIHNKIND);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KAOOKPDMDAH(Vector3 FBFKKIJADKF, Vector3 MLKEHNHJPMP);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LBIFKLFNFJM(Vector3 ADCGEFMCJOH, Vector3 EGBIJKDMLFI);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 DEGALIMHJLI(Vector3 KAIPEFHNECD);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BJBEJCNBCNB(Vector3 NIPPPODPAFG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface NKCEGEIMEEK
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool EMBMMGAIENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHLIPHPDCML(string AABEEDLKHEA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBCNCJODOHD(RigidbodyEx IFDOJINLLBE, Action OFOIHENMFDE);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGIADOCIEAL BMNEJJLPLBC(int JFKHGAFFECA);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKKAOOBGAEK(Vector3 AGFIDHELAFJ, float NNMMCCKOEGD, Color CMIODFEAKCF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface DOGDBCICNDF
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NKCEGEIMEEK FKBLCLBKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	IIFBFOMHPLG BPAEHNEPIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NKLMHKPBNIE : MPABILDJPPM, IDisposable, OEHIAEEMGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly DOGDBCICNDF JPFNBECBJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal GNIKMKOHLHD BDJFCJPIEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal MMADDFJJIIH MMBHKPGBOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal PJIPIMFNJCN IKNKOKAIKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GBDLGBEPPIH MDKLJOBFIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LILECGPANDH KFLMNPFFODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ICHNJGFNMGO IHGECHCCJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal CBIMJGCBKKA KNFBHNGKNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OBHEHLEABAK AOKCAIADGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal GJIBIEPIFAM HONOLDOGDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal NBJGCIOOCMG HKGAKIPMCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PHOOBEADFBI NFAMOPOOAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal LJKFLAEDCNM HLOIBGCELIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal HPHDDFIAHBG JJCNBLJLMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal KMNGNDHAEIF KIMBNNEGFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal DEMKOPAMLLI HCGKPFIBKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable EEBDEGPLBIH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "22")]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public POKMEHNCJBC MCBNKDJJGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD430", Offset = "0x7BC630", VA = "0x1807BD430", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD5A0", Offset = "0x7BC7A0", VA = "0x1807BD5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject MCONHIMIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x87F4A0", Offset = "0x87E6A0", VA = "0x18087F4A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x87F5C0", Offset = "0x87E7C0", VA = "0x18087F5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x67035E0", Offset = "0x67027E0", VA = "0x1867035E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x67052A0", Offset = "0x67044A0", VA = "0x1867052A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6702E40", Offset = "0x6702040", VA = "0x186702E40", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6705DF0", Offset = "0x6704FF0", VA = "0x186705DF0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FKDINEDDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6705D80", Offset = "0x6704F80", VA = "0x186705D80", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MPABILDJPPM NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6703730", Offset = "0x6702930", VA = "0x186703730", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DGHGDGMONLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6701700", Offset = "0x6700900", VA = "0x186701700", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OGNGDDIFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6706C90", Offset = "0x6705E90", VA = "0x186706C90", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool AHBMMBODCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6704770", Offset = "0x6703970", VA = "0x186704770", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AEELDBJLIOI OCIHGIEMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6706460", Offset = "0x6705660", VA = "0x186706460", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6705CC0", Offset = "0x6704EC0", VA = "0x186705CC0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OFDDOEGADFI AOGLCJHKNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6701760", Offset = "0x6700960", VA = "0x186701760", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6705140", Offset = "0x6704340", VA = "0x186705140", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float PKPAGNEHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6703230", Offset = "0x6702430", VA = "0x186703230", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6705980", Offset = "0x6704B80", VA = "0x186705980", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 MLDNALOKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6704840", Offset = "0x6703A40", VA = "0x186704840", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x67074F0", Offset = "0x67066F0", VA = "0x1867074F0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 BIKJNHHJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6703ED0", Offset = "0x67030D0", VA = "0x186703ED0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x67058A0", Offset = "0x6704AA0", VA = "0x1867058A0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 HEGJMPMNGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6706BB0", Offset = "0x6705DB0", VA = "0x186706BB0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6706A20", Offset = "0x6705C20", VA = "0x186706A20", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 OOBKCEPGDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6704920", Offset = "0x6703B20", VA = "0x186704920", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67018B0", Offset = "0x6700AB0", VA = "0x1867018B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AFPEAKEFDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67053A0", Offset = "0x67045A0", VA = "0x1867053A0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool KLJNFPNIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6706310", Offset = "0x6705510", VA = "0x186706310", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool FIABCHJOGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6704FA0", Offset = "0x67041A0", VA = "0x186704FA0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LABKLHCLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6703590", Offset = "0x6702790", VA = "0x186703590", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 OACIIGEFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6704060", Offset = "0x6703260", VA = "0x186704060", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 GNCLKAIHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6707320", Offset = "0x6706520", VA = "0x186707320", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CMPINJFJFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67071E0", Offset = "0x67063E0", VA = "0x1867071E0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6703450", Offset = "0x6702650", VA = "0x186703450", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 DGCOODKILIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6707000", Offset = "0x6706200", VA = "0x186707000", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CEFKOHHOLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6703AC0", Offset = "0x6702CC0", VA = "0x186703AC0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float IDCMHAOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x67025B0", Offset = "0x67017B0", VA = "0x1867025B0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x67047C0", Offset = "0x67039C0", VA = "0x1867047C0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 MOMIPLEMDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67024D0", Offset = "0x67016D0", VA = "0x1867024D0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion JHJINPPHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6704A50", Offset = "0x6703C50", VA = "0x186704A50", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float NNIBHOHJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67074A0", Offset = "0x67066A0", VA = "0x1867074A0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x67033F0", Offset = "0x67025F0", VA = "0x1867033F0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float OOLIMOECINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6705350", Offset = "0x6704550", VA = "0x186705350", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6704B20", Offset = "0x6703D20", VA = "0x186704B20", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool FGLBIDFCLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6706370", Offset = "0x6705570", VA = "0x186706370", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6703780", Offset = "0x6702980", VA = "0x186703780", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DOAGAABAFKI DCLHOBDFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6703280", Offset = "0x6702480", VA = "0x186703280", Slot = "68")]
		get
		{
			return default(DOAGAABAFKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6705080", Offset = "0x6704280", VA = "0x186705080", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool DMFCIKABDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6701A60", Offset = "0x6700C60", VA = "0x186701A60", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform MPPFKJCEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67055B0", Offset = "0x67047B0", VA = "0x1867055B0", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 JCMLCJJMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6702920", Offset = "0x6701B20", VA = "0x186702920", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6703670", Offset = "0x6702870", VA = "0x186703670", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float OFEANHDOONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6701990", Offset = "0x6700B90", VA = "0x186701990", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6705C50", Offset = "0x6704E50", VA = "0x186705C50", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float GCFGGEMOFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6704820", Offset = "0x6703A20", VA = "0x186704820", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6701DB0", Offset = "0x6700FB0", VA = "0x186701DB0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion OGJCDKOFEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x67019B0", Offset = "0x6700BB0", VA = "0x1867019B0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6701B00", Offset = "0x6700D00", VA = "0x186701B00", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 LBCBIKCAOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6707450", Offset = "0x6706650", VA = "0x186707450", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x67061F0", Offset = "0x67053F0", VA = "0x1867061F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion HLNGFPFIIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6703A20", Offset = "0x6702C20", VA = "0x186703A20", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6704C70", Offset = "0x6703E70", VA = "0x186704C70", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints HKEHMJBNHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6707400", Offset = "0x6706600", VA = "0x186707400", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6703070", Offset = "0x6702270", VA = "0x186703070", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool CKEOACICAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6701D60", Offset = "0x6700F60", VA = "0x186701D60", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6703A60", Offset = "0x6702C60", VA = "0x186703A60", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode EDHBGNGDFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6705C00", Offset = "0x6704E00", VA = "0x186705C00", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6703E70", Offset = "0x6703070", VA = "0x186703E70", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BLBMBJLHFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67059E0", Offset = "0x6704BE0", VA = "0x1867059E0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CLLNGBLDHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x67021A0", Offset = "0x67013A0", VA = "0x1867021A0", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DJPOHPOJKMP MIKEDADMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6703390", Offset = "0x6702590", VA = "0x186703390", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x67026B0", Offset = "0x67018B0", VA = "0x1867026B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event DJPOHPOJKMP IKFDKBDLEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6704CB0", Offset = "0x6703EB0", VA = "0x186704CB0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6706190", Offset = "0x6705390", VA = "0x186706190", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MBDFLHOAEJJ ECCHALHHPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6703FB0", Offset = "0x67031B0", VA = "0x186703FB0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6702A80", Offset = "0x6701C80", VA = "0x186702A80", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DJPOHPOJKMP PFJLKPMAOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6702650", Offset = "0x6701850", VA = "0x186702650", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x67030D0", Offset = "0x67022D0", VA = "0x1867030D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event DJPOHPOJKMP MNJPFKICJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x67052F0", Offset = "0x67044F0", VA = "0x1867052F0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6704260", Offset = "0x6703460", VA = "0x186704260", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event DJPOHPOJKMP OEFIGOGDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6703D00", Offset = "0x6702F00", VA = "0x186703D00", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6705D20", Offset = "0x6704F20", VA = "0x186705D20", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<LABHNEIMMOD, LABHNEIMMOD> IFDAOOPJMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6703C40", Offset = "0x6702E40", VA = "0x186703C40", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6705E50", Offset = "0x6705050", VA = "0x186705E50", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DJPOHPOJKMP KLHHGNIABHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6703CA0", Offset = "0x6702EA0", VA = "0x186703CA0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x67032D0", Offset = "0x67024D0", VA = "0x1867032D0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DJPOHPOJKMP CBFNHGBDHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x67029D0", Offset = "0x6701BD0", VA = "0x1867029D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6702C50", Offset = "0x6701E50", VA = "0x186702C50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6707610", Offset = "0x6706810", VA = "0x186707610")]
	public NKLMHKPBNIE(GameObject CHIOFKOKCNE, RigidbodyEx FOOKBFDCOMB, DOGDBCICNDF JPFNBECBJPL, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6701EB0", Offset = "0x67010B0", VA = "0x186701EB0", Slot = "136")]
	protected virtual void BFFLFMHIBMN(DOGDBCICNDF JPFNBECBJPL, GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6702D70", Offset = "0x6701F70", VA = "0x186702D70", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6705EB0", Offset = "0x67050B0", VA = "0x186705EB0", Slot = "91")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6702600", Offset = "0x6701800", VA = "0x186702600", Slot = "92")]
	public void BOGHDHHJJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6703210", Offset = "0x6702410", VA = "0x186703210", Slot = "93")]
	public void ELEABJCGEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6706B00", Offset = "0x6705D00", VA = "0x186706B00")]
	private void PCGAADGDHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67037E0", Offset = "0x67029E0", VA = "0x1867037E0", Slot = "30")]
	public MPABILDJPPM FMAHEHLKPDM(int MBGANDEDPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6702D00", Offset = "0x6701F00", VA = "0x186702D00", Slot = "95")]
	public void DPPHNCDDAIK(MPABILDJPPM EKDDCPALANJ, bool DJPOIHCPABJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6705790", Offset = "0x6704990", VA = "0x186705790", Slot = "96")]
	public void MCLCMPHELAM(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6704F40", Offset = "0x6704140", VA = "0x186704F40", Slot = "97")]
	public void KHLIHLENIEO(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6702320", Offset = "0x6701520", VA = "0x186702320", Slot = "98")]
	public Vector3 BJBEJCNBCNB(Vector3 NIPPPODPAFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6702B50", Offset = "0x6701D50", VA = "0x186702B50", Slot = "99")]
	public Vector3 DEGALIMHJLI(Vector3 KAIPEFHNECD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6702600", Offset = "0x6701800", VA = "0x186702600", Slot = "100")]
	public void GJGAKFBBGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6704A00", Offset = "0x6703C00", VA = "0x186704A00", Slot = "101")]
	public void JIBBBIAEOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67015E0", Offset = "0x67007E0", VA = "0x1867015E0", Slot = "102")]
	public void ABFEFKGBJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67053F0", Offset = "0x67045F0", VA = "0x1867053F0", Slot = "103")]
	public void LBIFKLFNFJM(Vector3 ADCGEFMCJOH, Vector3 EGBIJKDMLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6704B80", Offset = "0x6703D80", VA = "0x186704B80", Slot = "104")]
	public void KAOOKPDMDAH(Vector3 FBFKKIJADKF, Vector3 MLKEHNHJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6703940", Offset = "0x6702B40", VA = "0x186703940", Slot = "105")]
	public void GACEHJBOCDE(Vector3 LIEBIHNKIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6703B10", Offset = "0x6702D10", VA = "0x186703B10", Slot = "106")]
	public void GDMKGLIKMNN(IFIOCMHLOGF OOJJGDDKMPH, Vector3 NKPBIBGIGIC, float FDGBHJOLFOB, float KCMPEKMFBNO = 8f, float MLECCBHOGPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67051A0", Offset = "0x67043A0", VA = "0x1867051A0", Slot = "107")]
	public void KONHEMLLAAO(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 CGOPPOICKIH, float AHDEBMHEIKE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6702420", Offset = "0x6701620", VA = "0x186702420", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BMADFLFMOBL(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 ECLCOOPOABI, float CMFBFEMGGMP = 7f, float HHEHPPDENGJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67017B0", Offset = "0x67009B0", VA = "0x1867017B0", Slot = "109")]
	public Vector3 AFNHCCJOILN(Vector3 EKDDCPALANJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67027D0", Offset = "0x67019D0", VA = "0x1867027D0", Slot = "110")]
	public Vector3 CLCBFIDAFJA(Vector3 EKDDCPALANJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6701AB0", Offset = "0x6700CB0", VA = "0x186701AB0", Slot = "111")]
	public void AMIMOGILGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6703BD0", Offset = "0x6702DD0", VA = "0x186703BD0", Slot = "112")]
	public void GEHOFEDEDAB(MPABILDJPPM OFEKIDOIODB, object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67072C0", Offset = "0x67064C0", VA = "0x1867072C0", Slot = "113")]
	public void PJOGHJMIMBC(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6704130", Offset = "0x6703330", VA = "0x186704130", Slot = "61")]
	public void HMFLODDFELK((Quaternion rot, Vector3 moments) OBCPHNOEGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6706410", Offset = "0x6705610", VA = "0x186706410", Slot = "114")]
	public void OGIIBBJKPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6704D10", Offset = "0x6703F10", VA = "0x186704D10", Slot = "115")]
	public void KEJBHMJHIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6704210", Offset = "0x6703410", VA = "0x186704210", Slot = "116")]
	public void HMHJBGCCKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6706140", Offset = "0x6705340", VA = "0x186706140", Slot = "117")]
	public bool NMGHIDBNOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x67028D0", Offset = "0x6701AD0", VA = "0x1867028D0", Slot = "94")]
	public void CMLPDOPBLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x67063C0", Offset = "0x67055C0", VA = "0x1867063C0", Slot = "118")]
	public void ODJKIEDOKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6705730", Offset = "0x6704930", VA = "0x186705730", Slot = "119")]
	public void LNJEKJEBIAF(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6701D00", Offset = "0x6700F00", VA = "0x186701D00", Slot = "120")]
	public void AOEMMMCOGNB(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6702AE0", Offset = "0x6701CE0", VA = "0x186702AE0", Slot = "121")]
	public void DDGDJJIOCAK(object GMMJMENGHCD, bool AHPGPMLNBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6706820", Offset = "0x6705A20", VA = "0x186706820", Slot = "122")]
	public void PADFEOACABO(Vector3 BBIPDCGGCJI, Quaternion HDGDBKNDAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6705FF0", Offset = "0x67051F0", VA = "0x186705FF0", Slot = "123")]
	public void NLNKIPBMLCK(Vector3 KNIDEDNJIKD, Quaternion IINALNNAGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x67042C0", Offset = "0x67034C0", VA = "0x1867042C0", Slot = "124")]
	public bool IGOMPGANJPA(float GGHLFGGDEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x67050E0", Offset = "0x67042E0", VA = "0x1867050E0", Slot = "125")]
	public void KNCHCJPNICA(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6703330", Offset = "0x6702530", VA = "0x186703330", Slot = "126")]
	public void FBOLFKCDDHF(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6703530", Offset = "0x6702730", VA = "0x186703530", Slot = "127")]
	public void FGGEPJLINMM(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6702E90", Offset = "0x6702090", VA = "0x186702E90", Slot = "128")]
	public void EAPMHAHADDB(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6703860", Offset = "0x6702A60", VA = "0x186703860", Slot = "129")]
	public void FOFFMCNJKFD(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6703D60", Offset = "0x6702F60", VA = "0x186703D60", Slot = "130")]
	public void GMMBJLBFGNI(Vector3 HLOIBGCELIK, Vector3 JCMPCLFLJHD, ForceMode CEHCIFMOKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6705B20", Offset = "0x6704D20", VA = "0x186705B20", Slot = "131")]
	public void MKPNHPKHKJI(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6703130", Offset = "0x6702330", VA = "0x186703130", Slot = "132")]
	public void EHMIPAHPANM(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6704320", Offset = "0x6703520", VA = "0x186704320", Slot = "133")]
	public bool IMBEONMFNPO(Vector3 HIMAANDEJKI, [Out] RaycastHit HAENHELGKML, float NHMHEGFGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6704010", Offset = "0x6703210", VA = "0x186704010", Slot = "134")]
	public void HEBNFIPHGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x67075D0", Offset = "0x67067D0", VA = "0x1867075D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6701630", Offset = "0x6700830", VA = "0x186701630")]
	private void ABLKDKGPBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6701BF0", Offset = "0x6700DF0", VA = "0x186701BF0")]
	private void ANOFJLKPFAP(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6704D60", Offset = "0x6703F60", VA = "0x186704D60")]
	private void KFGNGEHKLMF(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x67057F0", Offset = "0x67049F0", VA = "0x1867057F0")]
	private void MDGBMIDHKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67070E0", Offset = "0x67062E0", VA = "0x1867070E0")]
	private void PIIEDCNHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6702EF0", Offset = "0x67020F0", VA = "0x186702EF0")]
	private void EENJIIFJOAC(MPABILDJPPM JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67054E0", Offset = "0x67046E0", VA = "0x1867054E0")]
	private void LCINAEOOHDE(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6706240", Offset = "0x6705440", VA = "0x186706240")]
	private void OABMHGBELJH(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67055C0", Offset = "0x67047C0", VA = "0x1867055C0")]
	private void LFCMKIDKDOM(POKMEHNCJBC DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67043C0", Offset = "0x67035C0", VA = "0x1867043C0", Slot = "141")]
	protected virtual void IPGGCOMKJKN(POKMEHNCJBC IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6706CE0", Offset = "0x6705EE0", VA = "0x186706CE0")]
	protected void PDGPPJODDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67064B0", Offset = "0x67056B0", VA = "0x1867064B0")]
	protected void OOLNCMBHEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6702710", Offset = "0x6701910", VA = "0x186702710", Slot = "142")]
	protected virtual IDisposable CJBMONHABBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class GHLHKBCDLDO
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x66FA300", Offset = "0x66F9500", VA = "0x1866FA300")]
	public static MPABILDJPPM GHMJHBBEFFC(this MPABILDJPPM IFDOJINLLBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x66FA3C0", Offset = "0x66F95C0", VA = "0x1866FA3C0")]
	public static bool HBFJPCNMADO(this MPABILDJPPM IFDOJINLLBE, MPABILDJPPM GDPCBFCLPIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x66FA440", Offset = "0x66F9640", VA = "0x1866FA440")]
	public static bool HIIHOLGFEJM(this MPABILDJPPM IFDOJINLLBE, MPABILDJPPM GEDCDDICNAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x66FA530", Offset = "0x66F9730", VA = "0x1866FA530")]
	public static POKMEHNCJBC JPPAIOKKJDC(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x66FA4C0", Offset = "0x66F96C0", VA = "0x1866FA4C0")]
	public static NKLMHKPBNIE JPJJIJJHOOC(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GINGBCMILPG : IIFBFOMHPLG
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x66FA580", Offset = "0x66F9780", VA = "0x1866FA580", Slot = "19")]
	public MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD, DOGDBCICNDF JPFNBECBJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "4")]
	public GNIKMKOHLHD OGHCEJNONDD(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "5")]
	public GBDLGBEPPIH COMMPGAEOOM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "6")]
	public LILECGPANDH PGKKLHCHPFO(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "7")]
	public CBIMJGCBKKA OHPPHOAGGJP(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "8")]
	public GJIBIEPIFAM LLKHCLKCFJA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "9")]
	public NBJGCIOOCMG LAPAEAFPHHM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "10")]
	public PHOOBEADFBI FLGOFKMKDOK(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "11")]
	public LJKFLAEDCNM CFMPOKBFKOG(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "12")]
	public DEMKOPAMLLI ILEEHEKPKLM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "13")]
	public OBHEHLEABAK IOJDFBCBLHA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	public KMNGNDHAEIF MNLGILEKBIJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	public PJIPIMFNJCN HDAEHLOJJBP(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	public MMADDFJJIIH HJLKDBIIAON(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	public ICHNJGFNMGO MPLNEAJEEJJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	public HPHDDFIAHBG BJLGJAAMJOH(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GINGBCMILPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "14")]
	private KMNGNDHAEIF PCGEOEENJCC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "15")]
	private PJIPIMFNJCN BMALLIPLJNM(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "16")]
	private MMADDFJJIIH KPGEGIJDINN(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "17")]
	private ICHNJGFNMGO CNKAFGLLEJI(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "18")]
	private HPHDDFIAHBG GFONHCLIIDC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GENMAJFODJG(typeof(IIFBFOMHPLG), new string[] { })]
public class BNNMGJJLBFM : IIFBFOMHPLG, BFELDJAKDCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IIFBFOMHPLG FAMMCLHOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IIFBFOMHPLG JNAHJKIJJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private ELDNEGPEECB JAGNMFMJABI;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private IIFBFOMHPLG BPAEHNEPIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x66F4AD0", Offset = "0x66F3CD0", VA = "0x1866F4AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x66F4940", Offset = "0x66F3B40", VA = "0x1866F4940", Slot = "20")]
	public void InitReferences(NKHDFGLOEFE HHEDJECGCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x66F4BE0", Offset = "0x66F3DE0", VA = "0x1866F4BE0", Slot = "4")]
	public GNIKMKOHLHD OGHCEJNONDD(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x66F4530", Offset = "0x66F3730", VA = "0x1866F4530", Slot = "5")]
	public GBDLGBEPPIH COMMPGAEOOM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x66F4D20", Offset = "0x66F3F20", VA = "0x1866F4D20", Slot = "6")]
	public LILECGPANDH PGKKLHCHPFO(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x66F4C80", Offset = "0x66F3E80", VA = "0x1866F4C80", Slot = "7")]
	public CBIMJGCBKKA OHPPHOAGGJP(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x66F4A30", Offset = "0x66F3C30", VA = "0x1866F4A30", Slot = "8")]
	public GJIBIEPIFAM LLKHCLKCFJA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x66F4990", Offset = "0x66F3B90", VA = "0x1866F4990", Slot = "9")]
	public NBJGCIOOCMG LAPAEAFPHHM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x66F45D0", Offset = "0x66F37D0", VA = "0x1866F45D0", Slot = "10")]
	public PHOOBEADFBI FLGOFKMKDOK(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x66F43E0", Offset = "0x66F35E0", VA = "0x1866F43E0", Slot = "11")]
	public LJKFLAEDCNM CFMPOKBFKOG(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x66F4800", Offset = "0x66F3A00", VA = "0x1866F4800", Slot = "12")]
	public DEMKOPAMLLI ILEEHEKPKLM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x66F48A0", Offset = "0x66F3AA0", VA = "0x1866F48A0", Slot = "13")]
	public OBHEHLEABAK IOJDFBCBLHA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x66F4B30", Offset = "0x66F3D30", VA = "0x1866F4B30")]
	public KMNGNDHAEIF MNLGILEKBIJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x66F4330", Offset = "0x66F3530", VA = "0x1866F4330")]
	public PJIPIMFNJCN HDAEHLOJJBP(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x66F4670", Offset = "0x66F3870", VA = "0x1866F4670")]
	public MMADDFJJIIH HJLKDBIIAON(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x66F4480", Offset = "0x66F3680", VA = "0x1866F4480")]
	public ICHNJGFNMGO MPLNEAJEEJJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x66F4280", Offset = "0x66F3480", VA = "0x1866F4280")]
	public HPHDDFIAHBG BJLGJAAMJOH(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x66F4720", Offset = "0x66F3920", VA = "0x1866F4720", Slot = "19")]
	public MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD, DOGDBCICNDF JPFNBECBJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x66F4DC0", Offset = "0x66F3FC0", VA = "0x1866F4DC0")]
	public BNNMGJJLBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x66F4B30", Offset = "0x66F3D30", VA = "0x1866F4B30", Slot = "14")]
	private KMNGNDHAEIF PCGEOEENJCC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x66F4330", Offset = "0x66F3530", VA = "0x1866F4330", Slot = "15")]
	private PJIPIMFNJCN BMALLIPLJNM(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x66F4670", Offset = "0x66F3870", VA = "0x1866F4670", Slot = "16")]
	private MMADDFJJIIH KPGEGIJDINN(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x66F4480", Offset = "0x66F3680", VA = "0x1866F4480", Slot = "17")]
	private ICHNJGFNMGO CNKAFGLLEJI(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x66F4280", Offset = "0x66F3480", VA = "0x1866F4280", Slot = "18")]
	private HPHDDFIAHBG GFONHCLIIDC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KJGPIDGEHNK : GNIKMKOHLHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJAHBJFPKEC(MPABILDJPPM IFDOJINLLBE);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABLBDOGEKDF(MPABILDJPPM IFDOJINLLBE);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKKOABMGOLN(MPABILDJPPM JEPODBIJBKG);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMNCMACLAOH(MPABILDJPPM JEPODBIJBKG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KCINCIAFPEK : LILECGPANDH
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	CBGGGINCELM<MPABILDJPPM> JDBCMGNHJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	MPABILDJPPM JKAMFADDHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NEEBKLHJLJP : ICHNJGFNMGO
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) GFKOHACHFDN(Rigidbody GJHLCOGPDKK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NKAODGNJJPA : PJIPIMFNJCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView GGNMFDIJIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class AGJJOOHPEGO : DEMKOPAMLLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode CBLFCJIPJAE;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x66F3EB0", Offset = "0x66F30B0", VA = "0x1866F3EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode EDHBGNGDFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x66F3F00", Offset = "0x66F3100", VA = "0x1866F3F00", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x66F3CE0", Offset = "0x66F2EE0", VA = "0x1866F3CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x66F4130", Offset = "0x66F3330", VA = "0x1866F4130")]
	public AGJJOOHPEGO(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x66F4010", Offset = "0x66F3210", VA = "0x1866F4010", Slot = "6")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x66F3B30", Offset = "0x66F2D30", VA = "0x1866F3B30", Slot = "9")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x66F3CD0", Offset = "0x66F2ED0", VA = "0x1866F3CD0", Slot = "7")]
	public void EBDJGIKEFLN(bool DJLJECFADMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x66F4120", Offset = "0x66F3320", VA = "0x1866F4120", Slot = "8")]
	public void PIDEICPKAIG(bool DJLJECFADMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x66F3D50", Offset = "0x66F2F50", VA = "0x1866F3D50", Slot = "10")]
	public bool IMBEONMFNPO(Vector3 HIMAANDEJKI, [Out] RaycastHit HAENHELGKML, float NHMHEGFGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x66F3BB0", Offset = "0x66F2DB0", VA = "0x1866F3BB0")]
	private void DMKDPMFINPK(bool DJLJECFADMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LMKOGBLLFGF : NBJGCIOOCMG, IDisposable, OKCPJPPOLPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DOAGAABAFKI NMCDGOOCCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private FGIADOCIEAL FEPOPKDHHPN;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DOAGAABAFKI DCLHOBDFJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6700750", Offset = "0x66FF950", VA = "0x186700750", Slot = "6")]
		get
		{
			return default(DOAGAABAFKI);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6700940", Offset = "0x66FFB40", VA = "0x186700940", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform HKHCEDHLACP
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6700A10", Offset = "0x66FFC10", VA = "0x186700A10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<LABHNEIMMOD, LABHNEIMMOD> IFDAOOPJMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6700890", Offset = "0x66FFA90", VA = "0x186700890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6700A30", Offset = "0x66FFC30", VA = "0x186700A30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6700D50", Offset = "0x66FFF50", VA = "0x186700D50")]
	public LMKOGBLLFGF(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6700AE0", Offset = "0x66FFCE0", VA = "0x186700AE0", Slot = "8")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6700700", Offset = "0x66FF900", VA = "0x186700700", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x826730", Offset = "0x825930", VA = "0x180826730", Slot = "11")]
	private void KFHAHOGGHCI(LABHNEIMMOD NFCAMIMIJJF, LABHNEIMMOD DAENCJNIDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "12")]
	private void CAHADJDMLAB(bool IAMGENCLHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PEEEPKCNGIP : IIFBFOMHPLG
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6708490", Offset = "0x6707690", VA = "0x186708490", Slot = "4")]
	public GNIKMKOHLHD OGHCEJNONDD(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6707BA0", Offset = "0x6706DA0", VA = "0x186707BA0", Slot = "5")]
	public GBDLGBEPPIH COMMPGAEOOM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6708600", Offset = "0x6707800", VA = "0x186708600", Slot = "6")]
	public LILECGPANDH PGKKLHCHPFO(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6708580", Offset = "0x6707780", VA = "0x186708580", Slot = "7")]
	public CBIMJGCBKKA OHPPHOAGGJP(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6708280", Offset = "0x6707480", VA = "0x186708280", Slot = "8")]
	public GJIBIEPIFAM LLKHCLKCFJA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x67081B0", Offset = "0x67073B0", VA = "0x1867081B0", Slot = "9")]
	public NBJGCIOOCMG LAPAEAFPHHM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6707CC0", Offset = "0x6706EC0", VA = "0x186707CC0", Slot = "10")]
	public PHOOBEADFBI FLGOFKMKDOK(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6707950", Offset = "0x6706B50", VA = "0x186707950", Slot = "11")]
	public LJKFLAEDCNM CFMPOKBFKOG(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6708030", Offset = "0x6707230", VA = "0x186708030", Slot = "12")]
	public DEMKOPAMLLI ILEEHEKPKLM(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x67080F0", Offset = "0x67072F0", VA = "0x1867080F0", Slot = "13")]
	public OBHEHLEABAK IOJDFBCBLHA(MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6708350", Offset = "0x6707550", VA = "0x186708350")]
	public KMNGNDHAEIF MNLGILEKBIJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x67077C0", Offset = "0x67069C0", VA = "0x1867077C0")]
	public PJIPIMFNJCN HDAEHLOJJBP(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6707DE0", Offset = "0x6706FE0", VA = "0x186707DE0")]
	public MMADDFJJIIH HJLKDBIIAON(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6707A10", Offset = "0x6706C10", VA = "0x186707A10")]
	public ICHNJGFNMGO MPLNEAJEEJJ(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x67076E0", Offset = "0x67068E0", VA = "0x1867076E0")]
	public HPHDDFIAHBG BJLGJAAMJOH(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6707F10", Offset = "0x6707110", VA = "0x186707F10", Slot = "19")]
	public MPABILDJPPM IJOLIOMHNKB(RigidbodyEx IFDOJINLLBE, GFEFICMLNMG MJGHOBDIDHD, DOGDBCICNDF JPFNBECBJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public PEEEPKCNGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6708350", Offset = "0x6707550", VA = "0x186708350", Slot = "14")]
	private KMNGNDHAEIF PCGEOEENJCC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67077C0", Offset = "0x67069C0", VA = "0x1867077C0", Slot = "15")]
	private PJIPIMFNJCN BMALLIPLJNM(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6707DE0", Offset = "0x6706FE0", VA = "0x186707DE0", Slot = "16")]
	private MMADDFJJIIH KPGEGIJDINN(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6707A10", Offset = "0x6706C10", VA = "0x186707A10", Slot = "17")]
	private ICHNJGFNMGO CNKAFGLLEJI(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x67076E0", Offset = "0x67068E0", VA = "0x1867076E0", Slot = "18")]
	private HPHDDFIAHBG GFONHCLIIDC(MPABILDJPPM HMEKKAINJCD, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class EDFDPGPLNPL : LJKFLAEDCNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x66F3EB0", Offset = "0x66F30B0", VA = "0x1866F3EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool DMFCIKABDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x66F8780", Offset = "0x66F7980", VA = "0x1866F8780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool DGHGDGMONLM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x66F8720", Offset = "0x66F7920", VA = "0x1866F8720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x66F87D0", Offset = "0x66F79D0", VA = "0x1866F87D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x66F4130", Offset = "0x66F3330", VA = "0x1866F4130")]
	public EDFDPGPLNPL(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x66F8A90", Offset = "0x66F7C90", VA = "0x1866F8A90", Slot = "4")]
	public void FOFFMCNJKFD(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x66F90D0", Offset = "0x66F82D0", VA = "0x1866F90D0")]
	private void HPLDMCKEEGE(Vector3 HLOIBGCELIK, ForceMode CEHCIFMOKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x66F8BF0", Offset = "0x66F7DF0", VA = "0x1866F8BF0", Slot = "5")]
	public void GMMBJLBFGNI(Vector3 HLOIBGCELIK, Vector3 JCMPCLFLJHD, ForceMode CEHCIFMOKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x66F9330", Offset = "0x66F8530", VA = "0x1866F9330", Slot = "6")]
	public void MKPNHPKHKJI(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x66F8E70", Offset = "0x66F8070", VA = "0x1866F8E70")]
	private void HOMMPCKJAPF(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x66F8830", Offset = "0x66F7A30", VA = "0x1866F8830", Slot = "7")]
	public void EHMIPAHPANM(Vector3 OAMGOONLJPM, ForceMode CEHCIFMOKCP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class JKCKFMHGNOE : OBHEHLEABAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool EFNKDELENDF;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FGLBIDFCLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x66FBDF0", Offset = "0x66FAFF0", VA = "0x1866FBDF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x66F4130", Offset = "0x66F3330", VA = "0x1866F4130")]
	public JKCKFMHGNOE(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x66FBDC0", Offset = "0x66FAFC0", VA = "0x1866FBDC0", Slot = "6")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x66FBF00", Offset = "0x66FB100", VA = "0x1866FBF00", Slot = "7")]
	public void HJECHFHJCDA(Rigidbody KIMBNNEGFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ACHLKNCIPIC : KJGPIDGEHNK, GNIKMKOHLHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MPABILDJPPM IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<MPABILDJPPM> GJFFLIKOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MPABILDJPPM MFIBAFBMCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MPABILDJPPM DLAKBCKOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform HKDKHEHEBIA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x66F28C0", Offset = "0x66F1AC0", VA = "0x1866F28C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC50", Offset = "0x7BBE50", VA = "0x1807BCC50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x66F3680", Offset = "0x66F2880", VA = "0x1866F3680", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public MPABILDJPPM NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BC530", Offset = "0x7BB730", VA = "0x1807BC530", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<MPABILDJPPM> MPPKAEPJGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BB150", VA = "0x1807BBF50", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DJPOHPOJKMP MIKEDADMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x66F2820", Offset = "0x66F1A20", VA = "0x1866F2820", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x66F1DE0", Offset = "0x66F0FE0", VA = "0x1866F1DE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DJPOHPOJKMP IKFDKBDLEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x66F3490", Offset = "0x66F2690", VA = "0x1866F3490", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x66F37C0", Offset = "0x66F29C0", VA = "0x1866F37C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MBDFLHOAEJJ ECCHALHHPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x66F2C40", Offset = "0x66F1E40", VA = "0x1866F2C40", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66F1F20", Offset = "0x66F1120", VA = "0x1866F1F20", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ALEGJENOFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x66F3530", Offset = "0x66F2730", VA = "0x1866F3530", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x66F1E80", Offset = "0x66F1080", VA = "0x1866F1E80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action OLJOHPLMKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x66F2E00", Offset = "0x66F2000", VA = "0x1866F2E00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x66F2780", Offset = "0x66F1980", VA = "0x1866F2780", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<MPABILDJPPM> OEMFKPDJCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x66F3080", Offset = "0x66F2280", VA = "0x1866F3080", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x66F25E0", Offset = "0x66F17E0", VA = "0x1866F25E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MPABILDJPPM> FMJNAGMDFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x66F2690", Offset = "0x66F1890", VA = "0x1866F2690", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x66F35D0", Offset = "0x66F27D0", VA = "0x1866F35D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action FMOANFNHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x66F2FE0", Offset = "0x66F21E0", VA = "0x1866F2FE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x66F2920", Offset = "0x66F1B20", VA = "0x1866F2920", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<MPABILDJPPM> OKBPOCJEBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x66F1D30", Offset = "0x66F0F30", VA = "0x1866F1D30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x66F3860", Offset = "0x66F2A60", VA = "0x1866F3860", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x66F3A70", Offset = "0x66F2C70", VA = "0x1866F3A70")]
	public ACHLKNCIPIC(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x66F2540", Offset = "0x66F1740", VA = "0x1866F2540", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x66F1FC0", Offset = "0x66F11C0", VA = "0x1866F1FC0", Slot = "30")]
	public void DPPHNCDDAIK(MPABILDJPPM EBKJLIBKJMN, bool DJPOIHCPABJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x66F3220", Offset = "0x66F2420", VA = "0x1866F3220", Slot = "6")]
	public void JKKOABMGOLN(MPABILDJPPM JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x66F29C0", Offset = "0x66F1BC0", VA = "0x1866F29C0", Slot = "7")]
	public void GMNCMACLAOH(MPABILDJPPM JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x66F3130", Offset = "0x66F2330", VA = "0x1866F3130", Slot = "4")]
	public void JJAHBJFPKEC(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x66F1C90", Offset = "0x66F0E90", VA = "0x1866F1C90", Slot = "5")]
	public void ABLBDOGEKDF(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x66F39D0", Offset = "0x66F2BD0", VA = "0x1866F39D0")]
	private void PKKPHGBDMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x66F2740", Offset = "0x66F1940", VA = "0x1866F2740")]
	private void FAKBOBOFMLD(MPABILDJPPM JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x66F2EA0", Offset = "0x66F20A0", VA = "0x1866F2EA0")]
	private void IBKLPPBBFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x66F3690", Offset = "0x66F2890", VA = "0x1866F3690")]
	private void NLEACCKOEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x66F2CE0", Offset = "0x66F1EE0", VA = "0x1866F2CE0")]
	private void HDHIEIGNALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x66F3910", Offset = "0x66F2B10", VA = "0x1866F3910")]
	[CompilerGenerated]
	private object PBJCLPBNKEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class EMEGHDNDGNP
{
	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x66FA240", Offset = "0x66F9440", VA = "0x1866FA240")]
	public static KJGPIDGEHNK JGPHNJNADEF(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class EDLDFCGNMLB : KCINCIAFPEK, LILECGPANDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CBGGGINCELM<MPABILDJPPM> HIDOBAHHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool BHACJJJNKHG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CBGGGINCELM<MPABILDJPPM> JDBCMGNHJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 OACIIGEFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x66F9C20", Offset = "0x66F8E20", VA = "0x1866F9C20", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 GNCLKAIHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x66F9E40", Offset = "0x66F9040", VA = "0x1866F9E40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 HEGJMPMNGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x66F9D60", Offset = "0x66F8F60", VA = "0x1866F9D60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public MPABILDJPPM JKAMFADDHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x66F9CB0", Offset = "0x66F8EB0", VA = "0x1866F9CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x66FA140", Offset = "0x66F9340", VA = "0x1866FA140")]
	public EDLDFCGNMLB(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x66F9490", Offset = "0x66F8690", VA = "0x1866F9490", Slot = "8")]
	public void ALECIFJKJBF(MPABILDJPPM DLAKBCKOLFN, object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x66F9C50", Offset = "0x66F8E50", VA = "0x1866F9C50", Slot = "9")]
	public void LCDDFHJDOPL(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x66F9890", Offset = "0x66F8A90", VA = "0x1866F9890")]
	private Vector3 CFILEKHCNAC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x66F9500", Offset = "0x66F8700", VA = "0x1866F9500")]
	private void BJGOOPEPJPB(MPABILDJPPM FCDCFCLKGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class BKGNMDGPLNK
{
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x66F41C0", Offset = "0x66F33C0", VA = "0x1866F41C0")]
	public static KCINCIAFPEK JBHOGMMNDGK(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CJPIOALJBKA : NEEBKLHJLJP, ICHNJGFNMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 ACMNOFBFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 AECMCLOEGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float OKLIAJJPEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float HKBONEANDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 IHDEPBHGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? JHFHHANIEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? GJPAPHHKJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool CHJABEMOILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool ENOAAALPFAJ;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CMPINJFJFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xBD9D70", Offset = "0xBD8F70", VA = "0x180BD9D70", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x66F5700", Offset = "0x66F4900", VA = "0x1866F5700", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 DGCOODKILIE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x66F75D0", Offset = "0x66F67D0", VA = "0x1866F75D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CEFKOHHOLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1242870", Offset = "0x1241A70", VA = "0x181242870", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x66F4F50", Offset = "0x66F4150", VA = "0x1866F4F50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float IDCMHAOKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC66390", Offset = "0xC65590", VA = "0x180C66390", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x66F51F0", Offset = "0x66F43F0", VA = "0x1866F51F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 MOMIPLEMDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x66F5060", Offset = "0x66F4260", VA = "0x1866F5060", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion JHJINPPHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x66F7080", Offset = "0x66F6280", VA = "0x1866F7080", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x66F73D0", Offset = "0x66F65D0", VA = "0x1866F73D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event DJPOHPOJKMP HICHBFGBEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x66F5660", Offset = "0x66F4860", VA = "0x1866F5660", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x66F5420", Offset = "0x66F4620", VA = "0x1866F5420", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x66F76D0", Offset = "0x66F68D0", VA = "0x1866F76D0")]
	public CJPIOALJBKA(MPABILDJPPM IFDOJINLLBE, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x66F7420", Offset = "0x66F6620", VA = "0x1866F7420", Slot = "17")]
	public void OGIIBBJKPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x66F72F0", Offset = "0x66F64F0", VA = "0x1866F72F0", Slot = "16")]
	public void KEJBHMJHIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x66F4E70", Offset = "0x66F4070", VA = "0x1866F4E70", Slot = "19")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66F6AC0", Offset = "0x66F5CC0", VA = "0x1866F6AC0", Slot = "20")]
	public void HJECHFHJCDA(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x66F6EE0", Offset = "0x66F60E0", VA = "0x1866F6EE0", Slot = "18")]
	public void HMHJBGCCKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x66F6620", Offset = "0x66F5820", VA = "0x1866F6620", Slot = "21")]
	public void HEBNFIPHGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x66F5700", Offset = "0x66F4900", VA = "0x1866F5700")]
	private void ONOEJJIGNHM(Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x66F7200", Offset = "0x66F6400", VA = "0x1866F7200")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JKENBNNOFNH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x66F4F50", Offset = "0x66F4150", VA = "0x1866F4F50")]
	private void KFIOBLCAOMI(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x66F51F0", Offset = "0x66F43F0", VA = "0x1866F51F0")]
	private void BNCHNDDEEEC(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x66F54C0", Offset = "0x66F46C0", VA = "0x1866F54C0")]
	private Vector3 EKDHIMPMIIM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x66F6CB0", Offset = "0x66F5EB0", VA = "0x1866F6CB0", Slot = "15")]
	public void HMFLODDFELK((Quaternion rot, Vector3 moments) OBCPHNOEGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x66F52A0", Offset = "0x66F44A0", VA = "0x1866F52A0")]
	private Quaternion CONOKGHCMCB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x66F57B0", Offset = "0x66F49B0", VA = "0x1866F57B0")]
	public void GFKOHACHFDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x66F5880", Offset = "0x66F4A80", VA = "0x1866F5880", Slot = "4")]
	public (float, Vector3) GFKOHACHFDN(Rigidbody GJHLCOGPDKK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class PMBMHEFCMKB
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6708730", Offset = "0x6707930", VA = "0x186708730")]
	public static NEEBKLHJLJP CJBJMKGOKNH(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class IFDMLOPNLPC : MMADDFJJIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly AHHBNJJODED FPPICFJDHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BKKIHAGPCJF ACJKHHABOOP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool AIGACGINGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5DFC0", Offset = "0xD5D1C0", VA = "0x180D5DFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public BKKIHAGPCJF MPKCFOPLCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910", Slot = "11")]
		get
		{
			return default(BKKIHAGPCJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x66FBCC0", Offset = "0x66FAEC0", VA = "0x1866FBCC0")]
	public IFDMLOPNLPC(MPABILDJPPM IFDOJINLLBE, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x66FBBB0", Offset = "0x66FADB0", VA = "0x1866FBBB0", Slot = "4")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x66FB930", Offset = "0x66FAB30", VA = "0x1866FB930")]
	private bool EBCNGDHBIGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x66FBB40", Offset = "0x66FAD40", VA = "0x1866FBB40", Slot = "5")]
	public void HGLNIGMAADO(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x66FB900", Offset = "0x66FAB00", VA = "0x1866FB900", Slot = "6")]
	public void CKMONOFDDKP(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x66FB7D0", Offset = "0x66FA9D0", VA = "0x1866FB7D0", Slot = "9")]
	public void CBMCIMPFMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x66FB6C0", Offset = "0x66FA8C0", VA = "0x1866FB6C0")]
	private void AJEKBJIGAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x66FB9D0", Offset = "0x66FABD0", VA = "0x1866FB9D0")]
	private void FFIKCJKEPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x66FBB70", Offset = "0x66FAD70", VA = "0x1866FBB70", Slot = "8")]
	public void HNOBNFNJKHG(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x66FBC80", Offset = "0x66FAE80", VA = "0x1866FBC80", Slot = "7")]
	public void OOOJKEHBHII(MPABILDJPPM IFDOJINLLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MAHOHKGNAHA : PHOOBEADFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AHHBNJJODED EKGLOGBFDDP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool DMFCIKABDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6700EB0", Offset = "0x67000B0", VA = "0x186700EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DJPOHPOJKMP KLHHGNIABHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x67011A0", Offset = "0x67003A0", VA = "0x1867011A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6701100", Offset = "0x6700300", VA = "0x186701100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x67012C0", Offset = "0x67004C0", VA = "0x1867012C0")]
	public MAHOHKGNAHA(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x67012B0", Offset = "0x67004B0", VA = "0x1867012B0", Slot = "7")]
	public void LNJEKJEBIAF(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6700F60", Offset = "0x6700160", VA = "0x186700F60", Slot = "8")]
	public void AOEMMMCOGNB(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6700FF0", Offset = "0x67001F0", VA = "0x186700FF0", Slot = "9")]
	public void DDGDJJIOCAK(object GMMJMENGHCD, bool AHPGPMLNBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6701270", Offset = "0x6700470", VA = "0x186701270", Slot = "12")]
	public void KEPKLAHINIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6700F70", Offset = "0x6700170", VA = "0x186700F70", Slot = "10")]
	public void APAFAGCFFFF(Rigidbody BCOOEAJBGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6701240", Offset = "0x6700440", VA = "0x186701240", Slot = "11")]
	public void HJECHFHJCDA(Rigidbody KIMBNNEGFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CNFGOJMKBFK : NKAODGNJJPA, PJIPIMFNJCN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView NDMFFPNMIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool GFBODIEHPOB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView GGNMFDIJIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OGNGDDIFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x66F83B0", Offset = "0x66F75B0", VA = "0x1866F83B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool AHBMMBODCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DJPOHPOJKMP PFJLKPMAOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x66F7830", Offset = "0x66F6A30", VA = "0x1866F7830", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x66F7B40", Offset = "0x66F6D40", VA = "0x1866F7B40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x66F83D0", Offset = "0x66F75D0", VA = "0x1866F83D0")]
	public CNFGOJMKBFK(MPABILDJPPM IFDOJINLLBE, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x66F8110", Offset = "0x66F7310", VA = "0x1866F8110", Slot = "9")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x66F7A40", Offset = "0x66F6C40", VA = "0x1866F7A40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x66F7D30", Offset = "0x66F6F30", VA = "0x1866F7D30", Slot = "10")]
	public void LCINAEOOHDE(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x66F8240", Offset = "0x66F7440", VA = "0x1866F8240", Slot = "11")]
	public void OABMHGBELJH(MPABILDJPPM DLAKBCKOLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x66F78D0", Offset = "0x66F6AD0", VA = "0x1866F78D0")]
	private void CJDAIKLDKAL(PhotonView EEEHJFGAFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x66F7BE0", Offset = "0x66F6DE0", VA = "0x1866F7BE0")]
	private void KFGIAMGAPNP(POKMEHNCJBC HBGBLGEJOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x66F7EA0", Offset = "0x66F70A0", VA = "0x1866F7EA0")]
	private void LIODJBJEGEN(PhotonView NONLELCGAHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class DFGMCCFAPDA
{
	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x66F8520", Offset = "0x66F7720", VA = "0x1866F8520")]
	public static NKAODGNJJPA IAHELLAFDGB(this MPABILDJPPM HMEKKAINJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NJONEEOFHGB : HPHDDFIAHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints JDFMLCNEJHG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CKEOACICAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xB72710", Offset = "0xB71910", VA = "0x180B72710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F78AB0", Offset = "0x3F77CB0", VA = "0x183F78AB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BACENNOJOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xDEF8F0", Offset = "0xDEEAF0", VA = "0x180DEF8F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F78AA0", Offset = "0x3F77CA0", VA = "0x183F78AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints HKEHMJBNHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x67013E0", Offset = "0x67005E0", VA = "0x1867013E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6701540", Offset = "0x6700740", VA = "0x186701540")]
	public NJONEEOFHGB(MPABILDJPPM IFDOJINLLBE, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x67013B0", Offset = "0x67005B0", VA = "0x1867013B0", Slot = "9")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6701510", Offset = "0x6700710", VA = "0x186701510", Slot = "10")]
	public void HJECHFHJCDA(Rigidbody KIMBNNEGFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LMIENICNNGH : CBIMJGCBKKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MPABILDJPPM IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float GKGGFPDPLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float AILOPPMEIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float NNIBHOHJPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x939B60", Offset = "0x938D60", VA = "0x180939B60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6700480", Offset = "0x66FF680", VA = "0x186700480", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float OOLIMOECINP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2660", Offset = "0x9F1860", VA = "0x1809F2660", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x67005F0", Offset = "0x66FF7F0", VA = "0x1867005F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x67006C0", Offset = "0x66FF8C0", VA = "0x1867006C0")]
	public LMIENICNNGH(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6700430", Offset = "0x66FF630", VA = "0x186700430", Slot = "8")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6700550", Offset = "0x66FF750", VA = "0x186700550", Slot = "9")]
	public void HJECHFHJCDA(Rigidbody KIMBNNEGFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LGNCENPCFLE : GJIBIEPIFAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool GADODFKBKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool ABFACDPBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int HHGKGNAECCN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x66F73D0", Offset = "0x66F65D0", VA = "0x1866F73D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool BLBMBJLHFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6700060", Offset = "0x66FF260", VA = "0x186700060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private MPABILDJPPM IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x66FFD70", Offset = "0x66FEF70", VA = "0x1866FFD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool DGHGDGMONLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x66FFAC0", Offset = "0x66FECC0", VA = "0x1866FFAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event DJPOHPOJKMP OEFIGOGDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x66FFDD0", Offset = "0x66FEFD0", VA = "0x1866FFDD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6700080", Offset = "0x66FF280", VA = "0x186700080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x67003A0", Offset = "0x66FF5A0", VA = "0x1867003A0")]
	public LGNCENPCFLE(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6700120", Offset = "0x66FF320", VA = "0x186700120", Slot = "6")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6700050", Offset = "0x66FF250", VA = "0x186700050", Slot = "8")]
	public void KNBKCBGBNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x67001B0", Offset = "0x66FF3B0", VA = "0x1867001B0", Slot = "7")]
	public bool NMGHIDBNOPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x66FFB20", Offset = "0x66FED20", VA = "0x1866FFB20", Slot = "9")]
	public void CMLPDOPBLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6700300", Offset = "0x66FF500", VA = "0x186700300", Slot = "11")]
	public void ODJKIEDOKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x66FFBC0", Offset = "0x66FEDC0", VA = "0x1866FFBC0", Slot = "10")]
	public void DKEFPEJAGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x66FFE70", Offset = "0x66FF070", VA = "0x1866FFE70")]
	private bool HJOFMKNPDED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x66FF930", Offset = "0x66FEB30", VA = "0x1866FF930")]
	private void ADJGADHMDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GNNBEBJAMNI : KMNGNDHAEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AHHBNJJODED MNMPJFMBJPI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody LKJEANBPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DGHGDGMONLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x66F8720", Offset = "0x66F7920", VA = "0x1866F8720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PGLOBOPHBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xD5DFC0", Offset = "0xD5D1C0", VA = "0x180D5DFC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x66FB5B0", Offset = "0x66FA7B0", VA = "0x1866FB5B0")]
	public GNNBEBJAMNI(MPABILDJPPM IFDOJINLLBE, [In] GFEFICMLNMG MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x66FB1E0", Offset = "0x66FA3E0", VA = "0x1866FB1E0", Slot = "5")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x66FAE80", Offset = "0x66FA080", VA = "0x1866FAE80", Slot = "7")]
	public void FGGEPJLINMM(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x66FAE50", Offset = "0x66FA050", VA = "0x1866FAE50", Slot = "8")]
	public void EAPMHAHADDB(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x66FB280", Offset = "0x66FA480", VA = "0x1866FB280", Slot = "9")]
	public void PGENLAOMAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x66FAC60", Offset = "0x66F9E60", VA = "0x1866FAC60", Slot = "11")]
	public void CMDFGJCLFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x66FAEB0", Offset = "0x66FA0B0", VA = "0x1866FAEB0", Slot = "12")]
	public void JFNACOOCJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x66FA620", Offset = "0x66F9820", VA = "0x1866FA620", Slot = "10")]
	public void BFHFAEIDKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x66FAAB0", Offset = "0x66F9CB0", VA = "0x1866FAAB0")]
	private void BKFJDGHGDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x66FB030", Offset = "0x66FA230", VA = "0x1866FB030")]
	private void JHFAAIPNPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JMCPJJBPFLD : GBDLGBEPPIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly NKLMHKPBNIE IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly AHHBNJJODED CLCBLGOHNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float AEFLHIAGBKE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public AEELDBJLIOI OCIHGIEMFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public OFDDOEGADFI AOGLCJHKNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 HEGJMPMNGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x66FF030", Offset = "0x66FE230", VA = "0x1866FF030", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x66FEF70", Offset = "0x66FE170", VA = "0x1866FEF70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 MLDNALOKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x66FDE70", Offset = "0x66FD070", VA = "0x1866FDE70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x66FF670", Offset = "0x66FE870", VA = "0x1866FF670", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 OOBKCEPGDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x66FE000", Offset = "0x66FD200", VA = "0x1866FE000", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x66FC0B0", Offset = "0x66FB2B0", VA = "0x1866FC0B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 BIKJNHHJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x66FDA30", Offset = "0x66FCC30", VA = "0x1866FDA30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x66FEF20", Offset = "0x66FE120", VA = "0x1866FEF20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float PKPAGNEHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9722C0", Offset = "0x9714C0", VA = "0x1809722C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x66FDBC0", Offset = "0x66FCDC0", VA = "0x1866FDBC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LABKLHCLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x173E960", Offset = "0x173DB60", VA = "0x18173E960", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private LJKFLAEDCNM FMCFFIPOHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1B50", Offset = "0x5FE0D50", VA = "0x185FE1B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool BLBMBJLHFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x66FEF50", Offset = "0x66FE150", VA = "0x1866FEF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x66FF6A0", Offset = "0x66FE8A0", VA = "0x1866FF6A0")]
	public JMCPJJBPFLD(MPABILDJPPM IFDOJINLLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x66FD990", Offset = "0x66FCB90", VA = "0x1866FD990", Slot = "19")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x66FCC50", Offset = "0x66FBE50", VA = "0x1866FCC50", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x66FC300", Offset = "0x66FB500", VA = "0x1866FC300", Slot = "28")]
	public void APAFAGCFFFF(Rigidbody KIMBNNEGFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xBAED50", Offset = "0xBADF50", VA = "0x180BAED50", Slot = "20")]
	public void JKPAINFKNBG(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBB07F0", Offset = "0xBAF9F0", VA = "0x180BB07F0", Slot = "30")]
	public void OJIFKKBAKHB(object GMMJMENGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x66FC430", Offset = "0x66FB630", VA = "0x1866FC430", Slot = "35")]
	public Vector3 BJBEJCNBCNB(Vector3 NIPPPODPAFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x66FCA90", Offset = "0x66FBC90", VA = "0x1866FCA90", Slot = "34")]
	public Vector3 DEGALIMHJLI(Vector3 KAIPEFHNECD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x66FD990", Offset = "0x66FCB90", VA = "0x1866FD990", Slot = "27")]
	public void GJGAKFBBGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x66FE1C0", Offset = "0x66FD3C0", VA = "0x1866FE1C0", Slot = "25")]
	public void JIBBBIAEOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x66FBF70", Offset = "0x66FB170", VA = "0x1866FBF70", Slot = "24")]
	public void ABFEFKGBJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x66FEC30", Offset = "0x66FDE30", VA = "0x1866FEC30", Slot = "33")]
	public void LBIFKLFNFJM(Vector3 ADCGEFMCJOH, Vector3 EGBIJKDMLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x66FE220", Offset = "0x66FD420", VA = "0x1866FE220", Slot = "32")]
	public void KAOOKPDMDAH(Vector3 FBFKKIJADKF, Vector3 MLKEHNHJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x66FD2B0", Offset = "0x66FC4B0", VA = "0x1866FD2B0", Slot = "31")]
	public void GACEHJBOCDE(Vector3 LIEBIHNKIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x66FD450", Offset = "0x66FC650", VA = "0x1866FD450", Slot = "22")]
	public void GDMKGLIKMNN(IFIOCMHLOGF OOJJGDDKMPH, Vector3 NKPBIBGIGIC, float FDGBHJOLFOB, float KCMPEKMFBNO = 8f, float MLECCBHOGPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x66FE9B0", Offset = "0x66FDBB0", VA = "0x1866FE9B0", Slot = "21")]
	public void KONHEMLLAAO(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 CGOPPOICKIH, float AHDEBMHEIKE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x66FC610", Offset = "0x66FB810", VA = "0x1866FC610", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void BMADFLFMOBL(MIGAFPNFDBJ AAJGHHOMLEP, Vector3 ECLCOOPOABI, float CMFBFEMGGMP = 7f, float HHEHPPDENGJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xCBE770", Offset = "0xCBD970", VA = "0x180CBE770")]
	private static void OIELOMOOEOB(Vector3 MDKLJOBFIPP, Vector3 KBHLNPNINOC, [Out] Vector3 LECEAKIBMBO, [Out] Vector3 FNOOKIOIPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x66FBFD0", Offset = "0x66FB1D0", VA = "0x1866FBFD0", Slot = "29")]
	public Vector3 AFNHCCJOILN(Vector3 MDKLJOBFIPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x66FC170", Offset = "0x66FB370", VA = "0x1866FC170", Slot = "26")]
	public void AMIMOGILGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x66FDBC0", Offset = "0x66FCDC0", VA = "0x1866FDBC0")]
	private void HNKEPJADPBG(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x66FDCD0", Offset = "0x66FCED0", VA = "0x1866FDCD0")]
	private void JAJIELDKIMH(Vector3 CGOPPOICKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x66FCCB0", Offset = "0x66FBEB0", VA = "0x1866FCCB0")]
	private Vector3 FHODLNLOMOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x66FCE30", Offset = "0x66FC030", VA = "0x1866FCE30")]
	private void FNDLAPAGNOC(Vector3 KAIPEFHNECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x66FE820", Offset = "0x66FDA20", VA = "0x1866FE820")]
	private Vector3 KKLDNPIJPEJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x66FF1F0", Offset = "0x66FE3F0", VA = "0x1866FF1F0")]
	private void PJCDPEFJJNA(Vector3 EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x66FE280", Offset = "0x66FD480", VA = "0x1866FE280")]
	private void KJEEFIIECJN(Vector3 KAIPEFHNECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x66FEE70", Offset = "0x66FE070", VA = "0x1866FEE70")]
	private void LILBABOMNFN()
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
