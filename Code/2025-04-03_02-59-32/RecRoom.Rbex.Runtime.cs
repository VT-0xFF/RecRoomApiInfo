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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBBB0", Offset = "0x7FDAFB0", VA = "0x187FDBBB0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F3DA80", Offset = "0x1F3CE80", VA = "0x181F3DA80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5D30", Offset = "0x7FE5130", VA = "0x187FE5D30")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6040", Offset = "0x7FE5440", VA = "0x187FE6040", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FE60A0", Offset = "0x7FE54A0", VA = "0x187FE60A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FGIODNKADFN, LEGAGIOCBAL, NGCJMMEPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly GBHBOJAPDOA GIIMCDNJOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool HPMLINOGNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BLDMDGLHGCG HGPJDADJFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[IDNFDPCBAID(GKKLJNPNNON.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[IDNFDPCBAID(GKKLJNPNNON.SelfAndParent, true, false, false)]
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
		private FIBKGJKLAIB physicsInterpolation;

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

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform GCOMKJBPJFD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal BLDMDGLHGCG GGEMNOPDOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7FE1570", Offset = "0x7FE0970", VA = "0x187FE1570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BLDMDGLHGCG FCCJOMDBPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FDCAABAGLFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3200", Offset = "0x7FE2600", VA = "0x187FE3200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GMMIAOMPPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3560", Offset = "0x7FE2960", VA = "0x187FE3560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HLJCJLLDIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7FE34A0", Offset = "0x7FE28A0", VA = "0x187FE34A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KLDFHLFOOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4170", Offset = "0x7FE3570", VA = "0x187FE4170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7FE56A0", Offset = "0x7FE4AA0", VA = "0x187FE56A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7C44760", Offset = "0x7C43B60", VA = "0x187C44760", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C43B30", Offset = "0x7C42F30", VA = "0x187C43B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KHDOKFIGIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1D71F50", Offset = "0x1D71350", VA = "0x181D71F50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform DLDINAKNGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D71F50", Offset = "0x1D71350", VA = "0x181D71F50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform NLGEJCOEKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1D71F50", Offset = "0x1D71350", VA = "0x181D71F50", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LFLBFNEONAP KLHFHGAFLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3260", Offset = "0x7FE2660", VA = "0x187FE3260")]
			get
			{
				return default(LFLBFNEONAP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4E50", Offset = "0x7FE4250", VA = "0x187FE4E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BHFLGMJBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3870", Offset = "0x7FE2C70", VA = "0x187FE3870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MLONIAAAKCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3380", Offset = "0x7FE2780", VA = "0x187FE3380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LHMOOAIDCGG OCADJDNOPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE37B0", Offset = "0x7FE2BB0", VA = "0x187FE37B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5010", Offset = "0x7FE4410", VA = "0x187FE5010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MDELKDJPJMO LJPNJEDDINK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3750", Offset = "0x7FE2B50", VA = "0x187FE3750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4FA0", Offset = "0x7FE43A0", VA = "0x187FE4FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MKGODOHPGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7FE36A0", Offset = "0x7FE2AA0", VA = "0x187FE36A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody ILPJNOBFDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3700", Offset = "0x7FE2B00", VA = "0x187FE3700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FPCOEMKLHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7FE33E0", Offset = "0x7FE27E0", VA = "0x187FE33E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4EC0", Offset = "0x7FE42C0", VA = "0x187FE4EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BOJICOMEDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x149BAD0", Offset = "0x149AED0", VA = "0x18149BAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BGANKPBNBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4110", Offset = "0x7FE3510", VA = "0x187FE4110")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float PPBNKHJBEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7FE40B0", Offset = "0x7FE34B0", VA = "0x187FE40B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5630", Offset = "0x7FE4A30", VA = "0x187FE5630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HKKACPANMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3AD0", Offset = "0x7FE2ED0", VA = "0x187FE3AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE52B0", Offset = "0x7FE46B0", VA = "0x187FE52B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float JGEJGDEPAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE38D0", Offset = "0x7FE2CD0", VA = "0x187FE38D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5080", Offset = "0x7FE4480", VA = "0x187FE5080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool DONEJBLJENJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE46F0", Offset = "0x7FE3AF0", VA = "0x187FE46F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5BE0", Offset = "0x7FE4FE0", VA = "0x187FE5BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 LMGJJEBAMGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3E90", Offset = "0x7FE3290", VA = "0x187FE3E90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5400", Offset = "0x7FE4800", VA = "0x187FE5400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 KAJIBONNCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4830", Offset = "0x7FE3C30", VA = "0x187FE4830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode LKNPCHFDOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A10", Offset = "0x7FE2E10", VA = "0x187FE3A10")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7FE51D0", Offset = "0x7FE45D0", VA = "0x187FE51D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NGPMJBAEEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3440", Offset = "0x7FE2840", VA = "0x187FE3440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4F30", Offset = "0x7FE4330", VA = "0x187FE4F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints JCJBHGPHKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3A70", Offset = "0x7FE2E70", VA = "0x187FE3A70")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5240", Offset = "0x7FE4640", VA = "0x187FE5240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 NPNOLNGAMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4230", Offset = "0x7FE3630", VA = "0x187FE4230")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 KBDEDNFMILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4230", Offset = "0x7FE3630", VA = "0x187FE4230")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE59C0", Offset = "0x7FE4DC0", VA = "0x187FE59C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NBBPCMCINPH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3F70", Offset = "0x7FE3370", VA = "0x187FE3F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE54E0", Offset = "0x7FE48E0", VA = "0x187FE54E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FKLGOEAPHHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4690", Offset = "0x7FE3A90", VA = "0x187FE4690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5B70", Offset = "0x7FE4F70", VA = "0x187FE5B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LLCLFFKBKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4310", Offset = "0x7FE3710", VA = "0x187FE4310")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5740", Offset = "0x7FE4B40", VA = "0x187FE5740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JFPGIHEJAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FE45B0", Offset = "0x7FE39B0", VA = "0x187FE45B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5AA0", Offset = "0x7FE4EA0", VA = "0x187FE5AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLAHJBBFNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7FE43F0", Offset = "0x7FE37F0", VA = "0x187FE43F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5810", Offset = "0x7FE4C10", VA = "0x187FE5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion AGDDFHJMNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7FE44D0", Offset = "0x7FE38D0", VA = "0x187FE44D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7FE58F0", Offset = "0x7FE4CF0", VA = "0x187FE58F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GPBFPENHNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4750", Offset = "0x7FE3B50", VA = "0x187FE4750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5C50", Offset = "0x7FE5050", VA = "0x187FE5C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PKMPKCGGDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3FD0", Offset = "0x7FE33D0", VA = "0x187FE3FD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5550", Offset = "0x7FE4950", VA = "0x187FE5550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 APEPLMENJNI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3930", Offset = "0x7FE2D30", VA = "0x187FE3930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE50F0", Offset = "0x7FE44F0", VA = "0x187FE50F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KPLENMNPPFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3DB0", Offset = "0x7FE31B0", VA = "0x187FE3DB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE5320", Offset = "0x7FE4720", VA = "0x187FE5320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IKGOFIJNLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3C70", Offset = "0x7FE3070", VA = "0x187FE3C70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MPKPCDBODCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3B90", Offset = "0x7FE2F90", VA = "0x187FE3B90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 MPLHFFEPPJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7FE49F0", Offset = "0x7FE3DF0", VA = "0x187FE49F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ANGNJGOKLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4910", Offset = "0x7FE3D10", VA = "0x187FE4910")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DLKMLFFELFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3D50", Offset = "0x7FE3150", VA = "0x187FE3D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EDOCKFIIGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3810", Offset = "0x7FE2C10", VA = "0x187FE3810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JLONDOFCCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3320", Offset = "0x7FE2720", VA = "0x187FE3320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KMMBJEHDKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7FE32C0", Offset = "0x7FE26C0", VA = "0x187FE32C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool GFALBPLJJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7FE31A0", Offset = "0x7FE25A0", VA = "0x187FE31A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool OKIBLPDEPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3B30", Offset = "0x7FE2F30", VA = "0x187FE3B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LCONPCPHNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x22344E0", Offset = "0x22338E0", VA = "0x1822344E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HDOGKPOEOHJ LPHPFJMKJLI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE30C0", Offset = "0x7FE24C0", VA = "0x187FE30C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4D70", Offset = "0x7FE4170", VA = "0x187FE4D70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EICBMHINKNM ALOAJEBKNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2E30", Offset = "0x7FE2230", VA = "0x187FE2E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4AD0", Offset = "0x7FE3ED0", VA = "0x187FE4AD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EICBMHINKNM GNEHPPELDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2E90", Offset = "0x7FE2290", VA = "0x187FE2E90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4B40", Offset = "0x7FE3F40", VA = "0x187FE4B40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EICBMHINKNM IHKIECJNFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2FE0", Offset = "0x7FE23E0", VA = "0x187FE2FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4C90", Offset = "0x7FE4090", VA = "0x187FE4C90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2F70", Offset = "0x7FE2370", VA = "0x187FE2F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4C20", Offset = "0x7FE4020", VA = "0x187FE4C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event EICBMHINKNM NKNLGJIFEPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3050", Offset = "0x7FE2450", VA = "0x187FE3050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4D00", Offset = "0x7FE4100", VA = "0x187FE4D00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EICBMHINKNM IHDANKCPPOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7FE3130", Offset = "0x7FE2530", VA = "0x187FE3130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4DE0", Offset = "0x7FE41E0", VA = "0x187FE4DE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EICBMHINKNM CBBDAKIOLFC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2F00", Offset = "0x7FE2300", VA = "0x187FE2F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7FE4BB0", Offset = "0x7FE3FB0", VA = "0x187FE4BB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "8")]
		private void HBJKBPFBMJA(BLDMDGLHGCG BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1AB0", Offset = "0x7FE0EB0", VA = "0x187FE1AB0", Slot = "9")]
		public KDCCJFNCNKM GetData()
		{
			return default(KDCCJFNCNKM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1360", Offset = "0x7FE0760", VA = "0x187FE1360")]
		internal void BCKAMPNIFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2B50", Offset = "0x7FE1F50", VA = "0x187FE2B50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CMOKMLIBNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1800", Offset = "0x7FE0C00", VA = "0x187FE1800")]
		public FGIODNKADFN GetChild(int CJFNAFNJJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2810", Offset = "0x7FE1C10", VA = "0x187FE2810")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1190", Offset = "0x7FE0590", VA = "0x187FE1190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2AA0", Offset = "0x7FE1EA0", VA = "0x187FE2AA0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1570", Offset = "0x7FE0970", VA = "0x187FE1570")]
		private BLDMDGLHGCG BJKBIKCBNIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE13F0", Offset = "0x7FE07F0", VA = "0x187FE13F0")]
		private void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1FE0", Offset = "0x7FE13E0", VA = "0x187FE1FE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1F20", Offset = "0x7FE1320", VA = "0x187FE1F20")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1360", Offset = "0x7FE0760", VA = "0x187FE1360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1F80", Offset = "0x7FE1380", VA = "0x187FE1F80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2040", Offset = "0x7FE1440", VA = "0x187FE2040")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0840", Offset = "0x7FDFC40", VA = "0x187FE0840")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7FE20A0", Offset = "0x7FE14A0", VA = "0x187FE20A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7FE17A0", Offset = "0x7FE0BA0", VA = "0x187FE17A0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1EC0", Offset = "0x7FE12C0", VA = "0x187FE1EC0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2970", Offset = "0x7FE1D70", VA = "0x187FE2970")]
		public void SetParent(RigidbodyEx FFOEEMKIKJO, bool IIGOHJFNEAG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7FE23B0", Offset = "0x7FE17B0", VA = "0x187FE23B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1B40", Offset = "0x7FE0F40", VA = "0x187FE1B40")]
		public bool IsRigidbodyAncestor(RigidbodyEx BOLABIDFOPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C40", Offset = "0x7FE1040", VA = "0x187FE1C40")]
		public bool IsRigidbodyDescendant(RigidbodyEx NFKPKOGFLHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0AB0", Offset = "0x7FDFEB0", VA = "0x187FE0AB0")]
		public void AddInterpolationRestriction(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2110", Offset = "0x7FE1510", VA = "0x187FE2110")]
		public void RemoveInterpolationRestriction(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B20", Offset = "0x7FDFF20", VA = "0x187FE0B20")]
		public void AddKinematic(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2180", Offset = "0x7FE1580", VA = "0x187FE2180")]
		public void RemoveKinematic(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7FE28F0", Offset = "0x7FE1CF0", VA = "0x187FE28F0")]
		public void SetKinematic(object HHGPJKKLNIG, bool HCLIPONIBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2710", Offset = "0x7FE1B10", VA = "0x187FE2710")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DOAGHIHKDJB, Quaternion JJONIBIPPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2610", Offset = "0x7FE1A10", VA = "0x187FE2610")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MHMKEPELAFJ, Quaternion GOADIINENHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7FE19A0", Offset = "0x7FE0DA0", VA = "0x187FE19A0")]
		public Vector3 GetConstrainedVelocity(Vector3 GPBFPENHNGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1890", Offset = "0x7FE0C90", VA = "0x187FE1890")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 APEPLMENJNI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FE09C0", Offset = "0x7FDFDC0", VA = "0x187FE09C0")]
		public void AddForce(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FE08B0", Offset = "0x7FDFCB0", VA = "0x187FE08B0")]
		public void AddForceAtPosition(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0CF0", Offset = "0x7FE00F0", VA = "0x187FE0CF0")]
		public void AddTorque(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B90", Offset = "0x7FDFF90", VA = "0x187FE0B90")]
		public void AddRelativeTorque(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2C20", Offset = "0x7FE2020", VA = "0x187FE2C20")]
		public Vector3 WorldToLocalVelocity(Vector3 FNHOFIFJKGL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1DB0", Offset = "0x7FE11B0", VA = "0x187FE1DB0")]
		public Vector3 LocalToWorldVelocity(Vector3 PKMPKCGGDCJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1740", Offset = "0x7FE0B40", VA = "0x187FE1740")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE16E0", Offset = "0x7FE0AE0", VA = "0x187FE16E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1680", Offset = "0x7FE0A80", VA = "0x187FE1680")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1620", Offset = "0x7FE0A20", VA = "0x187FE1620")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2510", Offset = "0x7FE1910", VA = "0x187FE2510")]
		public void ResetVelocityWorldSpace(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2410", Offset = "0x7FE1810", VA = "0x187FE2410")]
		public void ResetVelocityLocalSpace(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FE22D0", Offset = "0x7FE16D0", VA = "0x187FE22D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HHKLHBJKBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2AB0", Offset = "0x7FE1EB0", VA = "0x187FE2AB0")]
		public bool SweepTest(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1D40", Offset = "0x7FE1140", VA = "0x187FE1D40")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2A40", Offset = "0x7FE1E40", VA = "0x187FE2A40")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2BC0", Offset = "0x7FE1FC0", VA = "0x187FE2BC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0C80", Offset = "0x7FE0080", VA = "0x187FE0C80")]
		public void AddShouldHaveUnityRigidbodyToken(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7FE21F0", Offset = "0x7FE15F0", VA = "0x187FE21F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1020", Offset = "0x7FE0420", VA = "0x187FE1020")]
		public void ApplyForceVelocityChange(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0F80", Offset = "0x7FE0380", VA = "0x187FE0F80")]
		public void ApplyAngularVelocityChange(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE10E0", Offset = "0x7FE04E0", VA = "0x187FE10E0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0EB0", Offset = "0x7FE02B0", VA = "0x187FE0EB0")]
		public bool AllowedScaleChange(float KMDFDGNLAGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0DE0", Offset = "0x7FE01E0", VA = "0x187FE0DE0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GFNFBDBACGA, object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2260", Offset = "0x7FE1660", VA = "0x187FE2260")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1DA0", Offset = "0x7FE11A0", VA = "0x187FE1DA0", Slot = "12")]
		private void KEHLOLILFEP(LBONLJHNMPC PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE2DC0", Offset = "0x7FE21C0", VA = "0x187FE2DC0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB109A0", Offset = "0xB0FDA0", VA = "0x180B109A0", Slot = "4")]
		private GameObject NJGKDKNHODD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0950", Offset = "0x9BFD50", VA = "0x1809C0950", Slot = "10")]
		private bool CBMMHJLPIMM()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class IFGFPOOBJCF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD96E0", Offset = "0x7FD8AE0", VA = "0x187FD96E0")]
	public static BLDMDGLHGCG GGEMNOPDOAG(this RigidbodyEx LPNNCKGGDEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(NIHOCGKJMHE), new string[] { })]
public class FBGAHIPAMPJ : NIHOCGKJMHE, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BMHAHLCFFNP IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BJKJFECGOOO DNJCOFHCCGA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BMHAHLCFFNP LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BJKJFECGOOO JGAIAPCNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1EF0", Offset = "0x7FD12F0", VA = "0x187FD1EF0", Slot = "7")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1F60", Offset = "0x7FD1360", VA = "0x187FD1F60", Slot = "6")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public FBGAHIPAMPJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static OPNNLJDPBAB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KIKNDNDEHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int NHENNFNNDGP;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE06A0", Offset = "0x7FDFAA0", VA = "0x187FE06A0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE06E0", Offset = "0x7FDFAE0", VA = "0x187FE06E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE06C0", Offset = "0x7FDFAC0", VA = "0x187FE06C0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DAMFJFKKFBI, [Optional] UnityEngine.Object PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DAMFJFKKFBI, [Optional] UnityEngine.Object PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FE07F0", Offset = "0x7FDFBF0", VA = "0x187FE07F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FFHPNGPKPDP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IJEGPHNEDAP : LHMOOAIDCGG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A4A40", Offset = "0x9A3E40", VA = "0x1809A4A40", Slot = "4")]
		public Vector3 LPCDBNKIDHI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A4A40", Offset = "0x9A3E40", VA = "0x1809A4A40", Slot = "5")]
		public Vector3 FGOKNOFDKJK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "6")]
		public bool ODHDGKFCHMK(float JJDIDKFPPAL, float ACPOHLDGHJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IJEGPHNEDAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LHMOOAIDCGG EJEENKAPOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2120", Offset = "0x7FD1520", VA = "0x187FD2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PFLEMMAAOMH
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode BIGAHNDHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKJAGJCBDDB(bool DLKMLFFELFO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIMDMBIGCBB(bool DLKMLFFELFO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BDFOGFLPAEP(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HODBPPHMBPK : IDisposable, AFLGOOFMPPF
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LFLBFNEONAP KLHFHGAFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNNJMFNPKAP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BJKJFECGOOO
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PCIHJIDAFOL
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNGLFKHAFDE(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEJABLBKGKK(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNGDLHDIEGJ(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAIHBHFGPEC(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BPECJDJIALG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CCBPNOFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KGIFNKHHFOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<BLDMDGLHGCG> GGJCFLEHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BLDMDGLHGCG HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EICBMHINKNM ALOAJEBKNJF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EICBMHINKNM GNEHPPELDEI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HDOGKPOEOHJ JIKOBJGJECI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NBELHKJODLF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action NLHBDDCKOJB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BLDMDGLHGCG> IHFEIDBPHHA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BLDMDGLHGCG> KAJIJIHGLAL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action CLOICHHAIJA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BLDMDGLHGCG> AJIEOMHMGMN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EMLOMBIHCBC(BLDMDGLHGCG BBFFOKPDHFL, bool IIGOHJFNEAG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CBOKOEONGEL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CMHABAONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FGKCAICHENO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHHLNIMMEPH(BLDMDGLHGCG KLDFHLFOOFN, object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPNNJDCLDFH(object HHGPJKKLNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AEPNNNHLOGL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 AMJGAFKLJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 FMMJGFGCNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float NCOFGJEEKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float ONHGEOPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 GAAGIFCFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion MEKDJFANFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event EICBMHINKNM CFJHMGGJNHO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CCMOBCFBADO((Quaternion rot, Vector3 moments) MKJGDLEKAIO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MPFMGECAPDL();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BLPCMPDPKCJ();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void APLJKCDAGML();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HIKDFKDNGAA();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EBKMFCDKDAO
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCNFLPILHDM(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJILPFOJMFP(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPPNGHCCMMB(BLDMDGLHGCG LPNNCKGGDEC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLJCMCIACCJ(BLDMDGLHGCG LPNNCKGGDEC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBHLOFGIOIG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IJJJLBHIFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EICBMHINKNM DBLHHGBKBIP;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEGBKFPNHJD(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPLPJEDDEFM(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKLDDLODFLG(object HHGPJKKLNIG, bool HCLIPONIBGI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIEOMMOBGJE(Rigidbody OIBOOLMLIIP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KFCFJPCGCLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BHFLGMJBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MLONIAAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EICBMHINKNM JOPJCBEHOPN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBGKFOKDNBN(BLDMDGLHGCG KLDFHLFOOFN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OICPBNFOKLK(BLDMDGLHGCG KLDFHLFOOFN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KCOFFCEFAKL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FPCOEMKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool OECOLOCJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints HGNBCLAGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IODIOIMAIND
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float NDMOEKDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float KOOFMHKLIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CHJMJNCJFPP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool CJBALBMGHFO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EICBMHINKNM GBKGIKGPKIH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FFGLGDIECKB();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBPEIGJBMOF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EIPLMBFAJMC();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BEMGGEBPPEL();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AHDEHEMHABF();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GLNCPHIAFJH(bool GPOLJOPKODG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NACDKDDODFL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BIKICEBBCAG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool OGHLPIEIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCBAHEBKPMO(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DALGMHHCMGK(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPAANLOFAEN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NBGGJLGJHBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	LHMOOAIDCGG OCADJDNOPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MDELKDJPJMO LJPNJEDDINK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 GNLAPFBAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 CCOJCBMDALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 NIADJEHEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float NGPMJBAEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MKGODOHPGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MNNJMFNPKAP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JLFGJMOLNJL(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HMEFCOOCCJA(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OEDAHHABPJD(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LGNKHCCBCDE(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PBHCEHPEPMM();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OOAGCIMBMHE();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KEDOOOBMBKP();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KMOCPELJBAH();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IOEDKKBEBPA(Vector3 GPBFPENHNGM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LLHOANOEIDI(object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EODLFCNONFH(Vector3 HHPBPILOIBH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KECDDBGCHMH(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LBPCOGEPHJA(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IEDGBHBCANN(Vector3 PKMPKCGGDCJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 ADFPDAEBLKI(Vector3 FNHOFIFJKGL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface BMHAHLCFFNP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool HAADOPOLLNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENCNMGKDOMM(string AFHGIBDEPMG);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBEFBAKAEJI(RigidbodyEx LPNNCKGGDEC, Action IOPCFKOHPBF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FFAJMDDLMGH KBBLCMBILNP(int CJCDOGMLAHC);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANBPMOJHIPG(Vector3 KAJIBONNCNE, float GOGAGOCHNHF, Color ODFBFMBMBOG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface NIHOCGKJMHE
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	BMHAHLCFFNP LDPIMCPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	BJKJFECGOOO JGAIAPCNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GGNHHJDHICI : BLDMDGLHGCG, IDisposable, PHOGAFJDEIE
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool LDGBOHBOHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly NIHOCGKJMHE HEKFIEJNOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal KGIFNKHHFOK DJIDDNDFIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal EBKMFCDKDAO GAPODAAODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal KFCFJPCGCLB MMDOIBNNACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal NBGGJLGJHBD GPBFPENHNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CBOKOEONGEL ELKOBKLJGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal AEPNNNHLOGL LNFNFJLHAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal IODIOIMAIND IBMMKMBHFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal BPECJDJIALG BBKJMAGPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal CHJMJNCJFPP JPJBLMIKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal HODBPPHMBPK LEPDPJNJICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal IJJJLBHIFDI JGDPOCHDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal PCIHJIDAFOL HLPBIKLHEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal KCOFFCEFAKL OFGLEDNGHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal BIKICEBBCAG HLIOIFKCLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal PFLEMMAAOMH NEHFGHLBKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HAAPDNKEMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool MEFMBLPBFOL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ENLBBCIDMLB HIMBPBKIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "22")]
		get
		{
			return default(ENLBBCIDMLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FGIODNKADFN HDBNKJAJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC2F980", Offset = "0xC2ED80", VA = "0x180C2F980", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xDA69D0", Offset = "0xDA5DD0", VA = "0x180DA69D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99CBA0", Offset = "0x99BFA0", VA = "0x18099CBA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x99CC00", Offset = "0x99C000", VA = "0x18099CC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7D520", VA = "0x180B7E120", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xDAB6E0", Offset = "0xDAAAE0", VA = "0x180DAB6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7FD61C0", Offset = "0x7FD55C0", VA = "0x187FD61C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5520", Offset = "0x7FD4920", VA = "0x187FD5520", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2DD0", Offset = "0x7FD21D0", VA = "0x187FD2DD0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FDCAABAGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6210", Offset = "0x7FD5610", VA = "0x187FD6210", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BLDMDGLHGCG HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD77E0", Offset = "0x7FD6BE0", VA = "0x187FD77E0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7400", Offset = "0x7FD6800", VA = "0x187FD7400", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BHFLGMJBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7CF0", Offset = "0x7FD70F0", VA = "0x187FD7CF0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool MLONIAAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6280", Offset = "0x7FD5680", VA = "0x187FD6280", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LHMOOAIDCGG OCADJDNOPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FD83E0", Offset = "0x7FD77E0", VA = "0x187FD83E0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FD86D0", Offset = "0x7FD7AD0", VA = "0x187FD86D0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MDELKDJPJMO LJPNJEDDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7B70", Offset = "0x7FD6F70", VA = "0x187FD7B70", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7FD67C0", Offset = "0x7FD5BC0", VA = "0x187FD67C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float NGPMJBAEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6A20", Offset = "0x7FD5E20", VA = "0x187FD6A20", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8430", Offset = "0x7FD7830", VA = "0x187FD8430", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GNLAPFBAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3200", Offset = "0x7FD2600", VA = "0x187FD3200", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2C90", Offset = "0x7FD2090", VA = "0x187FD2C90", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 NIADJEHEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD40B0", Offset = "0x7FD34B0", VA = "0x187FD40B0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7460", Offset = "0x7FD6860", VA = "0x187FD7460", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6BC0", Offset = "0x7FD5FC0", VA = "0x187FD6BC0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7620", Offset = "0x7FD6A20", VA = "0x187FD7620", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 CCOJCBMDALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2AD0", Offset = "0x7FD1ED0", VA = "0x187FD2AD0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4320", Offset = "0x7FD3720", VA = "0x187FD4320", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JLONDOFCCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7FD66C0", Offset = "0x7FD5AC0", VA = "0x187FD66C0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KMMBJEHDKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7FD71D0", Offset = "0x7FD65D0", VA = "0x187FD71D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool GFALBPLJJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FD65E0", Offset = "0x7FD59E0", VA = "0x187FD65E0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MKGODOHPGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7FD64A0", Offset = "0x7FD58A0", VA = "0x187FD64A0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CMHABAONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD21F0", Offset = "0x7FD15F0", VA = "0x187FD21F0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FGKCAICHENO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3970", Offset = "0x7FD2D70", VA = "0x187FD3970", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 AMJGAFKLJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD32E0", Offset = "0x7FD26E0", VA = "0x187FD32E0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5780", Offset = "0x7FD4B80", VA = "0x187FD5780", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 FMMJGFGCNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3B00", Offset = "0x7FD2F00", VA = "0x187FD3B00", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float NCOFGJEEKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5730", Offset = "0x7FD4B30", VA = "0x187FD5730", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float ONHGEOPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD55C0", Offset = "0x7FD49C0", VA = "0x187FD55C0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5CD0", Offset = "0x7FD50D0", VA = "0x187FD5CD0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 GAAGIFCFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2BB0", Offset = "0x7FD1FB0", VA = "0x187FD2BB0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion MEKDJFANFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD63D0", Offset = "0x7FD57D0", VA = "0x187FD63D0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float NDMOEKDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3A50", Offset = "0x7FD2E50", VA = "0x187FD3A50", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5C70", Offset = "0x7FD5070", VA = "0x187FD5C70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float KOOFMHKLIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3500", Offset = "0x7FD2900", VA = "0x187FD3500", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7BC0", Offset = "0x7FD6FC0", VA = "0x187FD7BC0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool CCBPNOFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4060", Offset = "0x7FD3460", VA = "0x187FD4060", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD45F0", Offset = "0x7FD39F0", VA = "0x187FD45F0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LFLBFNEONAP KLHFHGAFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD23C0", Offset = "0x7FD17C0", VA = "0x187FD23C0", Slot = "70")]
		get
		{
			return default(LFLBFNEONAP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6F10", Offset = "0x7FD6310", VA = "0x187FD6F10", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD78F0", Offset = "0x7FD6CF0", VA = "0x187FD78F0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform NLGEJCOEKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7D520", VA = "0x180B7E120", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GBPFMJCENDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4540", Offset = "0x7FD3940", VA = "0x187FD4540", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2F30", Offset = "0x7FD2330", VA = "0x187FD2F30", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CGIBJMLFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD69B0", Offset = "0x7FD5DB0", VA = "0x187FD69B0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD75B0", Offset = "0x7FD69B0", VA = "0x187FD75B0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FLEBLMGGHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD31F0", Offset = "0x7FD25F0", VA = "0x187FD31F0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8300", Offset = "0x7FD7700", VA = "0x187FD8300", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JGCLCFDKMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2FE0", Offset = "0x7FD23E0", VA = "0x187FD2FE0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5A60", Offset = "0x7FD4E60", VA = "0x187FD5A60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 MFPCIJJNMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5D90", Offset = "0x7FD5190", VA = "0x187FD5D90", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6970", Offset = "0x7FD5D70", VA = "0x187FD6970", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion IGDJELKFIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3080", Offset = "0x7FD2480", VA = "0x187FD3080", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7B40", Offset = "0x7FD6F40", VA = "0x187FD7B40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HGNBCLAGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2EE0", Offset = "0x7FD22E0", VA = "0x187FD2EE0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5F70", Offset = "0x7FD5370", VA = "0x187FD5F70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool FPCOEMKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD42D0", Offset = "0x7FD36D0", VA = "0x187FD42D0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2E30", Offset = "0x7FD2230", VA = "0x187FD2E30", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode BIGAHNDHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7230", Offset = "0x7FD6630", VA = "0x187FD7230", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FD54C0", Offset = "0x7FD48C0", VA = "0x187FD54C0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD33C0", Offset = "0x7FD27C0", VA = "0x187FD33C0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool EDOCKFIIGON
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7280", Offset = "0x7FD6680", VA = "0x187FD7280", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EICBMHINKNM ALOAJEBKNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2D70", Offset = "0x7FD2170", VA = "0x187FD2D70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7780", Offset = "0x7FD6B80", VA = "0x187FD7780", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event EICBMHINKNM GNEHPPELDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7FD28C0", Offset = "0x7FD1CC0", VA = "0x187FD28C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FD70B0", Offset = "0x7FD64B0", VA = "0x187FD70B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HDOGKPOEOHJ JIKOBJGJECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4270", Offset = "0x7FD3670", VA = "0x187FD4270", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6160", Offset = "0x7FD5560", VA = "0x187FD6160", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EICBMHINKNM JOPJCBEHOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7FD29D0", Offset = "0x7FD1DD0", VA = "0x187FD29D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5460", Offset = "0x7FD4860", VA = "0x187FD5460", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EICBMHINKNM IHKIECJNFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5120", Offset = "0x7FD4520", VA = "0x187FD5120", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD44E0", Offset = "0x7FD38E0", VA = "0x187FD44E0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event EICBMHINKNM GBKGIKGPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5D30", Offset = "0x7FD5130", VA = "0x187FD5D30", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2920", Offset = "0x7FD1D20", VA = "0x187FD2920", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5400", Offset = "0x7FD4800", VA = "0x187FD5400", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6A70", Offset = "0x7FD5E70", VA = "0x187FD6A70", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EICBMHINKNM DBLHHGBKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD50C0", Offset = "0x7FD44C0", VA = "0x187FD50C0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6CA0", Offset = "0x7FD60A0", VA = "0x187FD6CA0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EICBMHINKNM CBBDAKIOLFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5FD0", Offset = "0x7FD53D0", VA = "0x187FD5FD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4970", Offset = "0x7FD3D70", VA = "0x187FD4970", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8800", Offset = "0x7FD7C00", VA = "0x187FD8800")]
	public GGNHHJDHICI(GameObject GIIGFIAPGGB, RigidbodyEx KPMNEKMAFNC, NIHOCGKJMHE HEKFIEJNOCO, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2570", Offset = "0x7FD1970", VA = "0x187FD2570", Slot = "139")]
	protected virtual void AIIMIDEFBKG(NIHOCGKJMHE HEKFIEJNOCO, KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3E30", Offset = "0x7FD3230", VA = "0x187FD3E30", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6F70", Offset = "0x7FD6370", VA = "0x187FD6F70", Slot = "93")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6AD0", Offset = "0x7FD5ED0", VA = "0x187FD6AD0", Slot = "94")]
	public void MABBNJBFHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD69C0", Offset = "0x7FD5DC0", VA = "0x187FD69C0", Slot = "95")]
	public void LMKILLMBFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4190", Offset = "0x7FD3590", VA = "0x187FD4190", Slot = "96")]
	public void EIKLAHENAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5180", Offset = "0x7FD4580", VA = "0x187FD5180")]
	private void GLNCPHIAFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7700", Offset = "0x7FD6B00", VA = "0x187FD7700")]
	private void OBOFOBEMNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2510", Offset = "0x7FD1910", VA = "0x187FD2510")]
	private void AHDEHEMHABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD56B0", Offset = "0x7FD4AB0", VA = "0x187FD56B0", Slot = "30")]
	public BLDMDGLHGCG HNDLFCCAFAM(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4200", Offset = "0x7FD3600", VA = "0x187FD4200", Slot = "98")]
	public void EMLOMBIHCBC(BLDMDGLHGCG FFOEEMKIKJO, bool IIGOHJFNEAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3AA0", Offset = "0x7FD2EA0", VA = "0x187FD3AA0", Slot = "99")]
	public void DLCPJLEFDKA(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7D90", Offset = "0x7FD7190", VA = "0x187FD7D90", Slot = "100")]
	public void OOMAACFBINP(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2410", Offset = "0x7FD1810", VA = "0x187FD2410", Slot = "101")]
	public Vector3 ADFPDAEBLKI(Vector3 FNHOFIFJKGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5860", Offset = "0x7FD4C60", VA = "0x187FD5860", Slot = "102")]
	public Vector3 IEDGBHBCANN(Vector3 PKMPKCGGDCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD62D0", Offset = "0x7FD56D0", VA = "0x187FD62D0", Slot = "103")]
	public void KMOCPELJBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7D40", Offset = "0x7FD7140", VA = "0x187FD7D40", Slot = "104")]
	public void OOAGCIMBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8240", Offset = "0x7FD7640", VA = "0x187FD8240", Slot = "105")]
	public void PBHCEHPEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD64F0", Offset = "0x7FD58F0", VA = "0x187FD64F0", Slot = "106")]
	public void LBPCOGEPHJA(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5E30", Offset = "0x7FD5230", VA = "0x187FD5E30", Slot = "107")]
	public void KECDDBGCHMH(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4400", Offset = "0x7FD3800", VA = "0x187FD4400", Slot = "108")]
	public void EODLFCNONFH(Vector3 HHPBPILOIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7830", Offset = "0x7FD6C30", VA = "0x187FD7830", Slot = "109")]
	public void OEDAHHABPJD(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5610", Offset = "0x7FD4A10", VA = "0x187FD5610", Slot = "110")]
	public void HMEFCOOCCJA(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6710", Offset = "0x7FD5B10", VA = "0x187FD6710", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LGNKHCCBCDE(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5960", Offset = "0x7FD4D60", VA = "0x187FD5960", Slot = "112")]
	public Vector3 IOEDKKBEBPA(Vector3 FFOEEMKIKJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD22C0", Offset = "0x7FD16C0", VA = "0x187FD22C0", Slot = "113")]
	public Vector3 ACIFDECJOIA(Vector3 FFOEEMKIKJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5F20", Offset = "0x7FD5320", VA = "0x187FD5F20", Slot = "114")]
	public void KEDOOOBMBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8290", Offset = "0x7FD7690", VA = "0x187FD8290", Slot = "115")]
	public void PCIHOIHPKPH(BLDMDGLHGCG GFNFBDBACGA, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3550", Offset = "0x7FD2950", VA = "0x187FD3550", Slot = "116")]
	public void CMFLBHGIKOM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD30C0", Offset = "0x7FD24C0", VA = "0x187FD30C0", Slot = "63")]
	public void CCMOBCFBADO((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2E90", Offset = "0x7FD2290", VA = "0x187FD2E90", Slot = "117")]
	public void BLPCMPDPKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7110", Offset = "0x7FD6510", VA = "0x187FD7110", Slot = "118")]
	public void MPFMGECAPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2980", Offset = "0x7FD1D80", VA = "0x187FD2980", Slot = "119")]
	public void APLJKCDAGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4650", Offset = "0x7FD3A50", VA = "0x187FD4650", Slot = "120")]
	public bool FFGLGDIECKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD41B0", Offset = "0x7FD35B0", VA = "0x187FD41B0", Slot = "97")]
	public void EIPLMBFAJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7160", Offset = "0x7FD6560", VA = "0x187FD7160", Slot = "121")]
	public void NACDKDDODFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6B60", Offset = "0x7FD5F60", VA = "0x187FD6B60", Slot = "122")]
	public void MEGBKFPNHJD(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5DD0", Offset = "0x7FD51D0", VA = "0x187FD5DD0", Slot = "123")]
	public void JPLPJEDDEFM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7540", Offset = "0x7FD6940", VA = "0x187FD7540", Slot = "124")]
	public void NKLDDLODFLG(object HHGPJKKLNIG, bool HCLIPONIBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7940", Offset = "0x7FD6D40", VA = "0x187FD7940", Slot = "125")]
	public void OFKJPGGODMG(Vector3 DOAGHIHKDJB, Quaternion JJONIBIPPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5B40", Offset = "0x7FD4F40", VA = "0x187FD5B40", Slot = "126")]
	public void JDKEJLBOJEL(Vector3 MHMKEPELAFJ, Quaternion GOADIINENHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FD31A0", Offset = "0x7FD25A0", VA = "0x187FD31A0", Slot = "127")]
	public bool CEIEFFNICJM(float KMDFDGNLAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6EB0", Offset = "0x7FD62B0", VA = "0x187FD6EB0", Slot = "128")]
	public void MIMMAFHDBHA(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2860", Offset = "0x7FD1C60", VA = "0x187FD2860", Slot = "129")]
	public void AIMLGGEGEPN(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4F50", Offset = "0x7FD4350", VA = "0x187FD4F50", Slot = "130")]
	public void GCBAHEBKPMO(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD35B0", Offset = "0x7FD29B0", VA = "0x187FD35B0", Slot = "131")]
	public void DALGMHHCMGK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4890", Offset = "0x7FD3C90", VA = "0x187FD4890", Slot = "132")]
	public void FNGLFKHAFDE(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4FB0", Offset = "0x7FD43B0", VA = "0x187FD4FB0", Slot = "133")]
	public void GEJABLBKGKK(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3D50", Offset = "0x7FD3150", VA = "0x187FD3D50", Slot = "134")]
	public void DNGDLHDIEGJ(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4E70", Offset = "0x7FD4270", VA = "0x187FD4E70", Slot = "135")]
	public void GAIHBHFGPEC(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2A30", Offset = "0x7FD1E30", VA = "0x187FD2A30", Slot = "136")]
	public bool BDFOGFLPAEP(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5570", Offset = "0x7FD4970", VA = "0x187FD5570", Slot = "137")]
	public void HIKDFKDNGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD87C0", Offset = "0x7FD7BC0", VA = "0x187FD87C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6080", Offset = "0x7FD5480", VA = "0x187FD6080")]
	private void KJKGHKKDJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD85C0", Offset = "0x7FD79C0", VA = "0x187FD85C0")]
	private void PNNBHLHAJPK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD46A0", Offset = "0x7FD3AA0", VA = "0x187FD46A0")]
	private void FJOBFDDOLGF(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6320", Offset = "0x7FD5720", VA = "0x187FD6320")]
	private void KPPBPJDGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8490", Offset = "0x7FD7890", VA = "0x187FD8490")]
	private void PIBJICBAKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6D00", Offset = "0x7FD6100", VA = "0x187FD6D00")]
	private void MGIJJJNHKPP(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8170", Offset = "0x7FD7570", VA = "0x187FD8170")]
	private void PBGKFOKDNBN(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7C20", Offset = "0x7FD7020", VA = "0x187FD7C20")]
	private void OICPBNFOKLK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6820", Offset = "0x7FD5C20", VA = "0x187FD6820")]
	private void LIJLLKOKDBI(FGIODNKADFN KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD4A20", Offset = "0x7FD3E20", VA = "0x187FD4A20", Slot = "142")]
	protected virtual void FPJHFDEODIK(FGIODNKADFN LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3610", Offset = "0x7FD2A10", VA = "0x187FD3610")]
	protected void DBCBGAGMEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7DF0", Offset = "0x7FD71F0", VA = "0x187FD7DF0")]
	protected void OPLHBBNAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3F30", Offset = "0x7FD3330", VA = "0x187FD3F30")]
	private void EBAHKOMJKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3BE0", Offset = "0x7FD2FE0", VA = "0x187FD3BE0")]
	private void DMIDMLCJMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class PNKNMJECMKA
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0470", Offset = "0x7FDF870", VA = "0x187FE0470")]
	public static BLDMDGLHGCG BCGCMOAGLCF(this BLDMDGLHGCG LPNNCKGGDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0600", Offset = "0x7FDFA00", VA = "0x187FE0600")]
	public static bool OEEBOFPBGBN(this BLDMDGLHGCG LPNNCKGGDEC, BLDMDGLHGCG BOLABIDFOPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7FE03D0", Offset = "0x7FDF7D0", VA = "0x187FE03D0")]
	public static bool AMBJJEHEJOB(this BLDMDGLHGCG LPNNCKGGDEC, BLDMDGLHGCG NFKPKOGFLHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0530", Offset = "0x7FDF930", VA = "0x187FE0530")]
	public static FGIODNKADFN HKIHPDGGKBM(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0580", Offset = "0x7FDF980", VA = "0x187FE0580")]
	public static GGNHHJDHICI HNLLPNEJLLP(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AMNIKIBDGLH : BJKJFECGOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9CD0", Offset = "0x7FC90D0", VA = "0x187FC9CD0", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public AMNIKIBDGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "18")]
	private KCOFFCEFAKL OCNCNDNLLLK(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(BJKJFECGOOO), new string[] { })]
public class EEBNDNDCOCB : BJKJFECGOOO, NOIGPCCMOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BJKJFECGOOO EAHEBHGIJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BJKJFECGOOO OLEPOKBNLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NEGHIAIGOHG HKKLKFKMNJC;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private BJKJFECGOOO JGAIAPCNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD19F0", Offset = "0x7FD0DF0", VA = "0x187FD19F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1770", Offset = "0x7FD0B70", VA = "0x187FD1770", Slot = "20")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD16D0", Offset = "0x7FD0AD0", VA = "0x187FD16D0", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1A50", Offset = "0x7FD0E50", VA = "0x187FD1A50", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1B90", Offset = "0x7FD0F90", VA = "0x187FD1B90", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1870", Offset = "0x7FD0C70", VA = "0x187FD1870", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7FD12E0", Offset = "0x7FD06E0", VA = "0x187FD12E0", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1AF0", Offset = "0x7FD0EF0", VA = "0x187FD1AF0", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1630", Offset = "0x7FD0A30", VA = "0x187FD1630", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1CE0", Offset = "0x7FD10E0", VA = "0x187FD1CE0", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1240", Offset = "0x7FD0640", VA = "0x187FD1240", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1430", Offset = "0x7FD0830", VA = "0x187FD1430", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1580", Offset = "0x7FD0980", VA = "0x187FD1580")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7FD14D0", Offset = "0x7FD08D0", VA = "0x187FD14D0")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD17C0", Offset = "0x7FD0BC0", VA = "0x187FD17C0")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1380", Offset = "0x7FD0780", VA = "0x187FD1380")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1C30", Offset = "0x7FD1030", VA = "0x187FD1C30")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1910", Offset = "0x7FD0D10", VA = "0x187FD1910", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1D80", Offset = "0x7FD1180", VA = "0x187FD1D80")]
	public EEBNDNDCOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1580", Offset = "0x7FD0980", VA = "0x187FD1580", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7FD14D0", Offset = "0x7FD08D0", VA = "0x187FD14D0", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7FD17C0", Offset = "0x7FD0BC0", VA = "0x187FD17C0", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1380", Offset = "0x7FD0780", VA = "0x187FD1380", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1C30", Offset = "0x7FD1030", VA = "0x187FD1C30", Slot = "18")]
	private KCOFFCEFAKL OCNCNDNLLLK(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PDCLENBCADL : KGIFNKHHFOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEHIFBKDANM(BLDMDGLHGCG LPNNCKGGDEC);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBNINBDDBCA(BLDMDGLHGCG LPNNCKGGDEC);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMOJLKDHIHH(BLDMDGLHGCG PLHEJCLJJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLJLMOIOGFB(BLDMDGLHGCG PLHEJCLJJDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IMMLNOGCEGB : CBOKOEONGEL
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CPPBICOIDFP<BLDMDGLHGCG> GNBECKILFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	BLDMDGLHGCG JJIJDBNFEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EPCAALOONMB : AEPNNNHLOGL
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) BIOJBLKOCKF(Rigidbody HDNHPNMKCLN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CDACNGFMOKE : KFCFJPCGCLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView CODLDKPDACB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OJHBKLNEGDP : PFLEMMAAOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JKONDHLDKND;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD90F0", Offset = "0x7FD84F0", VA = "0x187FD90F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode BIGAHNDHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF500", Offset = "0x7FDE900", VA = "0x187FDF500", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF2E0", Offset = "0x7FDE6E0", VA = "0x187FDF2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9650", Offset = "0x7FD8A50", VA = "0x187FD9650")]
	public OJHBKLNEGDP(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF3F0", Offset = "0x7FDE7F0", VA = "0x187FDF3F0", Slot = "6")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF360", Offset = "0x7FDE760", VA = "0x187FDF360", Slot = "9")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF3E0", Offset = "0x7FDE7E0", VA = "0x187FDF3E0", Slot = "7")]
	public void MKJAGJCBDDB(bool DLKMLFFELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF350", Offset = "0x7FDE750", VA = "0x187FDF350", Slot = "8")]
	public void LIMDMBIGCBB(bool DLKMLFFELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF060", Offset = "0x7FDE460", VA = "0x187FDF060", Slot = "10")]
	public bool BDFOGFLPAEP(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF1C0", Offset = "0x7FDE5C0", VA = "0x187FDF1C0")]
	private void DGEPEGDKCCK(bool DLKMLFFELFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JLINOGHHGIO : HODBPPHMBPK, IDisposable, AFLGOOFMPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private LFLBFNEONAP HDOICKANEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FFAJMDDLMGH FHPKBNBDFLO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LFLBFNEONAP KLHFHGAFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA440", Offset = "0x7FD9840", VA = "0x187FDA440", Slot = "6")]
		get
		{
			return default(LFLBFNEONAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA740", Offset = "0x7FD9B40", VA = "0x187FDA740", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform IHHLIJKELOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC17F00", Offset = "0xC17300", VA = "0x180C17F00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA5E0", Offset = "0x7FD99E0", VA = "0x187FDA5E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA690", Offset = "0x7FD9A90", VA = "0x187FDA690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAA80", Offset = "0x7FD9E80", VA = "0x187FDAA80")]
	public JLINOGHHGIO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA810", Offset = "0x7FD9C10", VA = "0x187FDA810", Slot = "8")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA590", Offset = "0x7FD9990", VA = "0x187FDA590", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x109DCA0", Offset = "0x109D0A0", VA = "0x18109DCA0", Slot = "11")]
	private void KAEHPACHBNF(FIEJAHACKON EODAOCIBHCJ, FIEJAHACKON HLCKONMPLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "12")]
	private void PBDJEINHFPJ(bool CIDNJAKHCBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KPGGDGBMDOH : BJKJFECGOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB2F0", Offset = "0x7FDA6F0", VA = "0x187FDB2F0", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB6E0", Offset = "0x7FDAAE0", VA = "0x187FDB6E0", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB8E0", Offset = "0x7FDACE0", VA = "0x187FDB8E0", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB510", Offset = "0x7FDA910", VA = "0x187FDB510", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7FDABD0", Offset = "0x7FD9FD0", VA = "0x187FDABD0", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB810", Offset = "0x7FDAC10", VA = "0x187FDB810", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB1D0", Offset = "0x7FDA5D0", VA = "0x187FDB1D0", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBAF0", Offset = "0x7FDAEF0", VA = "0x187FDBAF0", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAB10", Offset = "0x7FD9F10", VA = "0x187FDAB10", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAE40", Offset = "0x7FDA240", VA = "0x187FDAE40", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB090", Offset = "0x7FDA490", VA = "0x187FDB090")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAF00", Offset = "0x7FDA300", VA = "0x187FDAF00")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB3E0", Offset = "0x7FDA7E0", VA = "0x187FDB3E0")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDACA0", Offset = "0x7FDA0A0", VA = "0x187FDACA0")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBA10", Offset = "0x7FDAE10", VA = "0x187FDBA10")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB590", Offset = "0x7FDA990", VA = "0x187FDB590", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public KPGGDGBMDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB090", Offset = "0x7FDA490", VA = "0x187FDB090", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAF00", Offset = "0x7FDA300", VA = "0x187FDAF00", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB3E0", Offset = "0x7FDA7E0", VA = "0x187FDB3E0", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7FDACA0", Offset = "0x7FDA0A0", VA = "0x187FDACA0", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBA10", Offset = "0x7FDAE10", VA = "0x187FDBA10", Slot = "18")]
	private KCOFFCEFAKL OCNCNDNLLLK(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class HBLJPOPHHHO : PCIHJIDAFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7FD90F0", Offset = "0x7FD84F0", VA = "0x187FD90F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9600", Offset = "0x7FD8A00", VA = "0x187FD9600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA910", Offset = "0x7FC9D10", VA = "0x187FCA910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9090", Offset = "0x7FD8490", VA = "0x187FD9090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9650", Offset = "0x7FD8A50", VA = "0x187FD9650")]
	public HBLJPOPHHHO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8A50", Offset = "0x7FD7E50", VA = "0x187FD8A50", Slot = "4")]
	public void FNGLFKHAFDE(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9140", Offset = "0x7FD8540", VA = "0x187FD9140")]
	private void KNKJLPACOOF(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8E10", Offset = "0x7FD8210", VA = "0x187FD8E10", Slot = "5")]
	public void GEJABLBKGKK(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD88F0", Offset = "0x7FD7CF0", VA = "0x187FD88F0", Slot = "6")]
	public void DNGDLHDIEGJ(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD93A0", Offset = "0x7FD87A0", VA = "0x187FD93A0")]
	private void NPAELNAMHIG(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8BB0", Offset = "0x7FD7FB0", VA = "0x187FD8BB0", Slot = "7")]
	public void GAIHBHFGPEC(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class MCFFJPGLGAG : BPECJDJIALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool DONEJBLJENJ;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CCBPNOFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9FB880", Offset = "0x9FAC80", VA = "0x1809FB880", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC950", Offset = "0x7FDBD50", VA = "0x187FDC950", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9650", Offset = "0x7FD8A50", VA = "0x187FD9650")]
	public MCFFJPGLGAG(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCAD0", Offset = "0x7FDBED0", VA = "0x187FDCAD0", Slot = "6")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCA60", Offset = "0x7FDBE60", VA = "0x187FDCA60", Slot = "7")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class OCCDEOLPCAJ : PDCLENBCADL, KGIFNKHHFOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BLDMDGLHGCG LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<BLDMDGLHGCG> GJEHAFFEENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BLDMDGLHGCG BKHMOJGGBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private BLDMDGLHGCG KLDFHLFOOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform CBFMLKBFINL;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE2C0", Offset = "0x7FDD6C0", VA = "0x187FDE2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x993A40", Offset = "0x992E40", VA = "0x180993A40", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD310", Offset = "0x7FDC710", VA = "0x187FDD310", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BLDMDGLHGCG HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x993AB0", Offset = "0x992EB0", VA = "0x180993AB0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<BLDMDGLHGCG> GGJCFLEHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992E50", VA = "0x180993A50", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EICBMHINKNM ALOAJEBKNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD270", Offset = "0x7FDC670", VA = "0x187FDD270", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE830", Offset = "0x7FDDC30", VA = "0x187FDE830", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EICBMHINKNM GNEHPPELDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD190", Offset = "0x7FDC590", VA = "0x187FDD190", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE640", Offset = "0x7FDDA40", VA = "0x187FDE640", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event HDOGKPOEOHJ JIKOBJGJECI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDDD20", Offset = "0x7FDD120", VA = "0x187FDDD20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE4F0", Offset = "0x7FDD8F0", VA = "0x187FDE4F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action NBELHKJODLF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEE60", Offset = "0x7FDE260", VA = "0x187FDEE60", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD520", Offset = "0x7FDC920", VA = "0x187FDD520", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action NLHBDDCKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE6E0", Offset = "0x7FDDAE0", VA = "0x187FDE6E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD3C0", Offset = "0x7FDC7C0", VA = "0x187FDD3C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BLDMDGLHGCG> IHFEIDBPHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEDB0", Offset = "0x7FDE1B0", VA = "0x187FDEDB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE780", Offset = "0x7FDDB80", VA = "0x187FDE780", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BLDMDGLHGCG> KAJIJIHGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7FDDDC0", Offset = "0x7FDD1C0", VA = "0x187FDDDC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE210", Offset = "0x7FDD610", VA = "0x187FDE210", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action CLOICHHAIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEF00", Offset = "0x7FDE300", VA = "0x187FDEF00", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7FDED10", Offset = "0x7FDE110", VA = "0x187FDED10", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BLDMDGLHGCG> AJIEOMHMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE590", Offset = "0x7FDD990", VA = "0x187FDE590", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEC60", Offset = "0x7FDE060", VA = "0x187FDEC60", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEFA0", Offset = "0x7FDE3A0", VA = "0x187FDEFA0")]
	public OCCDEOLPCAJ(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD5C0", Offset = "0x7FDC9C0", VA = "0x187FDD5C0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD7A0", Offset = "0x7FDCBA0", VA = "0x187FDD7A0", Slot = "30")]
	public void EMLOMBIHCBC(BLDMDGLHGCG BBFFOKPDHFL, bool IIGOHJFNEAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDFA0", Offset = "0x7FDD3A0", VA = "0x187FDDFA0", Slot = "6")]
	public void GMOJLKDHIHH(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE9E0", Offset = "0x7FDDDE0", VA = "0x187FDE9E0", Slot = "7")]
	public void OLJLMOIOGFB(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE8D0", Offset = "0x7FDDCD0", VA = "0x187FDE8D0", Slot = "4")]
	public void OEHIFBKDANM(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE320", Offset = "0x7FDD720", VA = "0x187FDE320", Slot = "5")]
	public void JBNINBDDBCA(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD320", Offset = "0x7FDC720", VA = "0x187FDD320")]
	private void CEJMBKEPGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD230", Offset = "0x7FDC630", VA = "0x187FDD230")]
	private void BDGKDNBNPBH(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD660", Offset = "0x7FDCA60", VA = "0x187FDD660")]
	private void EJGKIOLOFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDE70", Offset = "0x7FDD270", VA = "0x187FDDE70")]
	private void GLEPBBNBOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE3C0", Offset = "0x7FDD7C0", VA = "0x187FDE3C0")]
	private void JKDAIENGGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD460", Offset = "0x7FDC860", VA = "0x187FDD460")]
	[CompilerGenerated]
	private object CNIEFOBOLEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class EGPBAFKFIPH
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1E30", Offset = "0x7FD1230", VA = "0x187FD1E30")]
	public static PDCLENBCADL OINMGBDMILF(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MBCOPOOIEKO : IMMLNOGCEGB, CBOKOEONGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CPPBICOIDFP<BLDMDGLHGCG> BHNPANKOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool NIFFGLJABON;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CPPBICOIDFP<BLDMDGLHGCG> GNBECKILFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CMHABAONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBCC0", Offset = "0x7FDB0C0", VA = "0x187FDBCC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FGKCAICHENO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC080", Offset = "0x7FDB480", VA = "0x187FDC080", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC3C0", Offset = "0x7FDB7C0", VA = "0x187FDC3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BLDMDGLHGCG JJIJDBNFEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FDC2B0", Offset = "0x7FDB6B0", VA = "0x187FDC2B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC850", Offset = "0x7FDBC50", VA = "0x187FDC850")]
	public MBCOPOOIEKO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC240", Offset = "0x7FDB640", VA = "0x187FDC240", Slot = "8")]
	public void FHHLNIMMEPH(BLDMDGLHGCG KLDFHLFOOFN, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC360", Offset = "0x7FDB760", VA = "0x187FDC360", Slot = "9")]
	public void LPNNJDCLDFH(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC4B0", Offset = "0x7FDB8B0", VA = "0x187FDC4B0")]
	private Vector3 MOFMJGDBFPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBCF0", Offset = "0x7FDB0F0", VA = "0x187FDBCF0")]
	private void AGILADNKBNA(BLDMDGLHGCG GDPLDINDKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NPJOPEFBDCA
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD0D0", Offset = "0x7FDC4D0", VA = "0x187FDD0D0")]
	public static IMMLNOGCEGB GIOLGIAEMNF(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CELBMPFCBJI : EPCAALOONMB, AEPNNNHLOGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 NNNHBNCKIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 GCIKGIFFIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float PPBNKHJBEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BGANKPBNBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 LMGJJEBAMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? IKGOFIJNLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? MPKPCDBODCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool LNEAPAJFNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool CPLADGBDEFH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 AMJGAFKLJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x14D8440", Offset = "0x14D7840", VA = "0x1814D8440", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC9F0", Offset = "0x7FCBDF0", VA = "0x187FCC9F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 FMMJGFGCNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC3D0", Offset = "0x7FCB7D0", VA = "0x187FCC3D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float NCOFGJEEKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC3DA00", Offset = "0xC3CE00", VA = "0x180C3DA00", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FCBF70", Offset = "0x7FCB370", VA = "0x187FCBF70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float ONHGEOPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB45BA0", Offset = "0xB44FA0", VA = "0x180B45BA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCAA0", Offset = "0x7FCBEA0", VA = "0x187FCCAA0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 GAAGIFCFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF60", Offset = "0x7FCA360", VA = "0x187FCAF60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion MEKDJFANFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCC90", Offset = "0x7FCC090", VA = "0x187FCCC90", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCC40", Offset = "0x7FCC040", VA = "0x187FCCC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EICBMHINKNM CFJHMGGJNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCE10", Offset = "0x7FCC210", VA = "0x187FCCE10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC4C0", Offset = "0x7FCB8C0", VA = "0x187FCC4C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD570", Offset = "0x7FCC970", VA = "0x187FCD570")]
	public CELBMPFCBJI(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC080", Offset = "0x7FCB480", VA = "0x187FCC080", Slot = "17")]
	public void BLPCMPDPKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD2F0", Offset = "0x7FCC6F0", VA = "0x187FCD2F0", Slot = "16")]
	public void MPFMGECAPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD090", Offset = "0x7FCC490", VA = "0x187FCD090", Slot = "19")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCEB0", Offset = "0x7FCC2B0", VA = "0x187FCCEB0", Slot = "20")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCADB0", Offset = "0x7FCA1B0", VA = "0x187FCADB0", Slot = "18")]
	public void APLJKCDAGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC560", Offset = "0x7FCB960", VA = "0x187FCC560", Slot = "21")]
	public void HIKDFKDNGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC9F0", Offset = "0x7FCBDF0", VA = "0x187FCC9F0")]
	private void NPELHFKENPO(Vector3 FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCB50", Offset = "0x7FCBF50", VA = "0x187FCCB50")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JJOMKFBBPJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBF70", Offset = "0x7FCB370", VA = "0x187FCBF70")]
	private void NGFEDMBMLIB(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCAA0", Offset = "0x7FCBEA0", VA = "0x187FCCAA0")]
	private void PBNFCHFLIOE(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD3D0", Offset = "0x7FCC7D0", VA = "0x187FCD3D0")]
	private Vector3 NAJOIMADAJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC1A0", Offset = "0x7FCB5A0", VA = "0x187FCC1A0", Slot = "15")]
	public void CCMOBCFBADO((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD170", Offset = "0x7FCC570", VA = "0x187FCD170")]
	private Quaternion MLBKFONGHIA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBEA0", Offset = "0x7FCB2A0", VA = "0x187FCBEA0")]
	public void BIOJBLKOCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB0F0", Offset = "0x7FCA4F0", VA = "0x187FCB0F0", Slot = "4")]
	public (float, Vector3) BIOJBLKOCKF(Rigidbody HDNHPNMKCLN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class NJFFDLJDAJE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCD40", Offset = "0x7FDC140", VA = "0x187FDCD40")]
	public static EPCAALOONMB IBBHIDACDCD(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BIBGNKNKMCO : EBKMFCDKDAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BBOIFKBNJEM GDIADAPKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FIBKGJKLAIB CHIPIMBLAEM;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PAHNNBEBBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1692680", Offset = "0x1691A80", VA = "0x181692680", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FIBKGJKLAIB GGJDAFKPKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0", Slot = "11")]
		get
		{
			return default(FIBKGJKLAIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA3A0", Offset = "0x7FC97A0", VA = "0x187FCA3A0")]
	public BIBGNKNKMCO(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA190", Offset = "0x7FC9590", VA = "0x187FCA190", Slot = "4")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9F00", Offset = "0x7FC9300", VA = "0x187FC9F00")]
	private bool HHBKKMLGKDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9DB0", Offset = "0x7FC91B0", VA = "0x187FC9DB0", Slot = "5")]
	public void CCNFLPILHDM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9FA0", Offset = "0x7FC93A0", VA = "0x187FC9FA0", Slot = "6")]
	public void IJILPFOJMFP(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA260", Offset = "0x7FC9660", VA = "0x187FCA260", Slot = "9")]
	public void PBHLOFGIOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9DE0", Offset = "0x7FC91E0", VA = "0x187FC9DE0")]
	private void CJGMILNECCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA010", Offset = "0x7FC9410", VA = "0x187FCA010")]
	private void LPOBFHMGKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9FD0", Offset = "0x7FC93D0", VA = "0x187FC9FD0", Slot = "8")]
	public void JLJCMCIACCJ(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9D70", Offset = "0x7FC9170", VA = "0x187FC9D70", Slot = "7")]
	public void BPPNGHCCMMB(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class COAOEHBKJBN : IJJJLBHIFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BBOIFKBNJEM JIINNDJEKJM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1060", Offset = "0x7FD0460", VA = "0x187FD1060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EICBMHINKNM DBLHHGBKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0D40", Offset = "0x7FD0140", VA = "0x187FD0D40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0E30", Offset = "0x7FD0230", VA = "0x187FD0E30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1150", Offset = "0x7FD0550", VA = "0x187FD1150")]
	public COAOEHBKJBN(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0E20", Offset = "0x7FD0220", VA = "0x187FD0E20", Slot = "7")]
	public void MEGBKFPNHJD(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0DE0", Offset = "0x7FD01E0", VA = "0x187FD0DE0", Slot = "8")]
	public void JPLPJEDDEFM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0F50", Offset = "0x7FD0350", VA = "0x187FD0F50", Slot = "9")]
	public void NKLDDLODFLG(object HHGPJKKLNIG, bool HCLIPONIBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1110", Offset = "0x7FD0510", VA = "0x187FD1110", Slot = "12")]
	public void OEGPFHAIAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0ED0", Offset = "0x7FD02D0", VA = "0x187FD0ED0", Slot = "10")]
	public void MIEOMMOBGJE(Rigidbody OIBOOLMLIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0DF0", Offset = "0x7FD01F0", VA = "0x187FD0DF0", Slot = "11")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class PEJLJGGNJOB : CDACNGFMOKE, KFCFJPCGCLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView CBKJHEDHFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LCAEDGLLKGB;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView CODLDKPDACB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BHFLGMJBADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFE70", Offset = "0x7FDF270", VA = "0x187FDFE70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MLONIAAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EICBMHINKNM JOPJCBEHOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF6D0", Offset = "0x7FDEAD0", VA = "0x187FDF6D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF9E0", Offset = "0x7FDEDE0", VA = "0x187FDF9E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0270", Offset = "0x7FDF670", VA = "0x187FE0270")]
	public PEJLJGGNJOB(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFBD0", Offset = "0x7FDEFD0", VA = "0x187FDFBD0", Slot = "9")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF8E0", Offset = "0x7FDECE0", VA = "0x187FDF8E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FE0100", Offset = "0x7FDF500", VA = "0x187FE0100", Slot = "10")]
	public void PBGKFOKDNBN(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFD00", Offset = "0x7FDF100", VA = "0x187FDFD00", Slot = "11")]
	public void OICPBNFOKLK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF770", Offset = "0x7FDEB70", VA = "0x187FDF770")]
	private void DDIFADMOJDA(PhotonView DJJKMLALGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFA80", Offset = "0x7FDEE80", VA = "0x187FDFA80")]
	private void KLLNKEGPKAA(FGIODNKADFN ILBJKPHCLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FDFE90", Offset = "0x7FDF290", VA = "0x187FDFE90")]
	private void OPOIDGPNEHP(PhotonView EBIBDEDMEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OPHJGCBEKNC
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF610", Offset = "0x7FDEA10", VA = "0x187FDF610")]
	public static CDACNGFMOKE MMJGHBJPNMC(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MOOPAFEBPGI : KCOFFCEFAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints JCJBHGPHKEH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool FPCOEMKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F8460", Offset = "0x9F7860", VA = "0x1809F8460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC6FD20", Offset = "0xC6F120", VA = "0x180C6FD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OECOLOCJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC6F3D0", Offset = "0xC6E7D0", VA = "0x180C6F3D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC6FD10", Offset = "0xC6F110", VA = "0x180C6FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HGNBCLAGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCB00", Offset = "0x7FDBF00", VA = "0x187FDCB00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCC90", Offset = "0x7FDC090", VA = "0x187FDCC90")]
	public MOOPAFEBPGI(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCC60", Offset = "0x7FDC060", VA = "0x187FDCC60", Slot = "9")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCC30", Offset = "0x7FDC030", VA = "0x187FDCC30", Slot = "10")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NNPJIOAAEBN : IODIOIMAIND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BLDMDGLHGCG LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float HKKACPANMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float JGEJGDEPAMA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float NDMOEKDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE322F0", Offset = "0xE316F0", VA = "0x180E322F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCE00", Offset = "0x7FDC200", VA = "0x187FDCE00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float KOOFMHKLIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC84750", VA = "0x180C85350", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCFC0", Offset = "0x7FDC3C0", VA = "0x187FDCFC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD090", Offset = "0x7FDC490", VA = "0x187FDD090")]
	public NNPJIOAAEBN(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCF70", Offset = "0x7FDC370", VA = "0x187FDCF70", Slot = "8")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCED0", Offset = "0x7FDC2D0", VA = "0x187FDCED0", Slot = "9")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JFMKEEMANNC : CHJMJNCJFPP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly GBHBOJAPDOA ADGJNIECNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool GGFKJBAAHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool FKMPPMBHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int HPFLMMCJPMO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCC40", Offset = "0x7FCC040", VA = "0x187FCCC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9BB0", Offset = "0x7FD8FB0", VA = "0x187FD9BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9EF0", Offset = "0x7FD92F0", VA = "0x187FD9EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA2C0", Offset = "0x7FD96C0", VA = "0x187FDA2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EICBMHINKNM GBKGIKGPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9F50", Offset = "0x7FD9350", VA = "0x187FD9F50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9AA0", Offset = "0x7FD8EA0", VA = "0x187FD9AA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA3B0", Offset = "0x7FD97B0", VA = "0x187FDA3B0")]
	public JFMKEEMANNC(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA180", Offset = "0x7FD9580", VA = "0x187FDA180", Slot = "6")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA2B0", Offset = "0x7FD96B0", VA = "0x187FDA2B0", Slot = "8")]
	public void NBPEIGJBMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C70", Offset = "0x7FD9070", VA = "0x187FD9C70", Slot = "7")]
	public bool FFGLGDIECKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9BD0", Offset = "0x7FD8FD0", VA = "0x187FD9BD0", Slot = "9")]
	public void EIPLMBFAJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA210", Offset = "0x7FD9610", VA = "0x187FDA210", Slot = "13")]
	public void NACDKDDODFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9DC0", Offset = "0x7FD91C0", VA = "0x187FD9DC0", Slot = "12")]
	public void GLNCPHIAFJH(bool GPOLJOPKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9B40", Offset = "0x7FD8F40", VA = "0x187FD9B40", Slot = "10")]
	public bool BEMGGEBPPEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9750", Offset = "0x7FD8B50", VA = "0x187FD9750", Slot = "11")]
	public bool AHDEHEMHABF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9810", Offset = "0x7FD8C10", VA = "0x187FD9810")]
	private bool AICJEDNAAIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9FF0", Offset = "0x7FD93F0", VA = "0x187FD9FF0")]
	private void MEOPBPJFBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BPBMOFHEFCJ : BIKICEBBCAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BBOIFKBNJEM FDLNIEBPCHN;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA910", Offset = "0x7FC9D10", VA = "0x187FCA910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OGHLPIEIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1692680", Offset = "0x1691A80", VA = "0x181692680", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCACA0", Offset = "0x7FCA0A0", VA = "0x187FCACA0")]
	public BPBMOFHEFCJ(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA870", Offset = "0x7FC9C70", VA = "0x187FCA870", Slot = "5")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA650", Offset = "0x7FC9A50", VA = "0x187FCA650", Slot = "7")]
	public void GCBAHEBKPMO(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA620", Offset = "0x7FC9A20", VA = "0x187FCA620", Slot = "8")]
	public void DALGMHHCMGK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA970", Offset = "0x7FC9D70", VA = "0x187FCA970", Slot = "9")]
	public void OPAANLOFAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA680", Offset = "0x7FC9A80", VA = "0x187FCA680", Slot = "10")]
	public void MGAEEGEBIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA4A0", Offset = "0x7FC98A0", VA = "0x187FCA4A0", Slot = "11")]
	public void CJJGPEOKODJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CKAIAJAGCJD : NBGGJLGJHBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GGNHHJDHICI LPNNCKGGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BBOIFKBNJEM FDGPPAKKOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float FJKIFFMNIOF;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LHMOOAIDCGG OCADJDNOPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MDELKDJPJMO LJPNJEDDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7FD01C0", Offset = "0x7FCF5C0", VA = "0x187FD01C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0470", Offset = "0x7FCF870", VA = "0x187FD0470", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GNLAPFBAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDA40", Offset = "0x7FCCE40", VA = "0x187FCDA40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDA10", Offset = "0x7FCCE10", VA = "0x187FCDA10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 CCOJCBMDALI
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD8B0", Offset = "0x7FCCCB0", VA = "0x187FCD8B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDED0", Offset = "0x7FCD2D0", VA = "0x187FCDED0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 NIADJEHEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDD00", Offset = "0x7FCD100", VA = "0x187FCDD00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0440", Offset = "0x7FCF840", VA = "0x187FD0440", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float NGPMJBAEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE3A470", Offset = "0xE39870", VA = "0x180E3A470", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF3A0", Offset = "0x7FCE7A0", VA = "0x187FCF3A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MKGODOHPGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAC90", Offset = "0x1FCA090", VA = "0x181FCAC90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PCIHJIDAFOL FGJPDEIDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x762BD90", Offset = "0x762B190", VA = "0x18762BD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDB60", Offset = "0x7FCCF60", VA = "0x187FCDB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0C50", Offset = "0x7FD0050", VA = "0x187FD0C50")]
	public CKAIAJAGCJD(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF940", Offset = "0x7FCED40", VA = "0x187FCF940", Slot = "19")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDB80", Offset = "0x7FCCF80", VA = "0x187FCDB80", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0310", Offset = "0x7FCF710", VA = "0x187FD0310", Slot = "28")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x148CDB0", Offset = "0x148C1B0", VA = "0x18148CDB0", Slot = "20")]
	public void JLFGJMOLNJL(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x148CDD0", Offset = "0x148C1D0", VA = "0x18148CDD0", Slot = "30")]
	public void LLHOANOEIDI(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD6D0", Offset = "0x7FCCAD0", VA = "0x187FCD6D0", Slot = "35")]
	public Vector3 ADFPDAEBLKI(Vector3 FNHOFIFJKGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE4E0", Offset = "0x7FCD8E0", VA = "0x187FCE4E0", Slot = "34")]
	public Vector3 IEDGBHBCANN(Vector3 PKMPKCGGDCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF940", Offset = "0x7FCED40", VA = "0x187FCF940", Slot = "27")]
	public void KMOCPELJBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0B90", Offset = "0x7FCFF90", VA = "0x187FD0B90", Slot = "25")]
	public void OOAGCIMBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0BF0", Offset = "0x7FCFFF0", VA = "0x187FD0BF0", Slot = "24")]
	public void PBHCEHPEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFB90", Offset = "0x7FCEF90", VA = "0x187FCFB90", Slot = "33")]
	public void LBPCOGEPHJA(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF1B0", Offset = "0x7FCE5B0", VA = "0x187FCF1B0", Slot = "32")]
	public void KECDDBGCHMH(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDF90", Offset = "0x7FCD390", VA = "0x187FCDF90", Slot = "31")]
	public void EODLFCNONFH(Vector3 HHPBPILOIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0530", Offset = "0x7FCF930", VA = "0x187FD0530", Slot = "22")]
	public void OEDAHHABPJD(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE250", Offset = "0x7FCD650", VA = "0x187FCE250", Slot = "21")]
	public void HMEFCOOCCJA(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFDD0", Offset = "0x7FCF1D0", VA = "0x187FCFDD0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LGNKHCCBCDE(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x15C9D80", Offset = "0x15C9180", VA = "0x1815C9D80")]
	private static void FGMOMKDPOAP(Vector3 GPBFPENHNGM, Vector3 BELINKGJHGO, [Out] Vector3 CMLOFINBEND, [Out] Vector3 HDBHGKKLLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEC40", Offset = "0x7FCE040", VA = "0x187FCEC40", Slot = "29")]
	public Vector3 IOEDKKBEBPA(Vector3 GPBFPENHNGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF210", Offset = "0x7FCE610", VA = "0x187FCF210", Slot = "26")]
	public void KEDOOOBMBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF3A0", Offset = "0x7FCE7A0", VA = "0x187FCF3A0")]
	private void KFENJAEKMFP(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF9F0", Offset = "0x7FCEDF0", VA = "0x187FCF9F0")]
	private void LANEPCIAACP(Vector3 LEDBBMALJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDBE0", Offset = "0x7FCCFE0", VA = "0x187FCDBE0")]
	private Vector3 EEBBGBINOEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF4B0", Offset = "0x7FCE8B0", VA = "0x187FCF4B0")]
	private void KLKDIGHICNB(Vector3 PKMPKCGGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE130", Offset = "0x7FCD530", VA = "0x187FCE130")]
	private Vector3 FGOKNOFDKJK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCED20", Offset = "0x7FCE120", VA = "0x187FCED20")]
	private void JOLPEBMEHMM(Vector3 FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE6A0", Offset = "0x7FCDAA0", VA = "0x187FCE6A0")]
	private void IKGPIFNLGGO(Vector3 PKMPKCGGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDE20", Offset = "0x7FCD220", VA = "0x187FCDE20")]
	private void EMEEIGMCICA()
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
