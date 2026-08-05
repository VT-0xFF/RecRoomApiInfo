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
		[Cpp2IlInjected.Address(RVA = "0x8028020", Offset = "0x8027420", VA = "0x188028020", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AA20", Offset = "0x1F49E20", VA = "0x181F4AA20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8032280", Offset = "0x8031680", VA = "0x188032280")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8032590", Offset = "0x8031990", VA = "0x188032590", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80325F0", Offset = "0x80319F0", VA = "0x1880325F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x802DB10", Offset = "0x802CF10", VA = "0x18802DB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BLDMDGLHGCG FCCJOMDBPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int FDCAABAGLFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x802F790", Offset = "0x802EB90", VA = "0x18802F790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GMMIAOMPPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x802FAF0", Offset = "0x802EEF0", VA = "0x18802FAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HLJCJLLDIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x802FA30", Offset = "0x802EE30", VA = "0x18802FA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KLDFHLFOOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x80306F0", Offset = "0x802FAF0", VA = "0x1880306F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8031BF0", Offset = "0x8030FF0", VA = "0x188031BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7C980D0", Offset = "0x7C974D0", VA = "0x187C980D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C974A0", Offset = "0x7C968A0", VA = "0x187C974A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KHDOKFIGIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1D829D0", Offset = "0x1D81DD0", VA = "0x181D829D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform DLDINAKNGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D829D0", Offset = "0x1D81DD0", VA = "0x181D829D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform NLGEJCOEKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1D829D0", Offset = "0x1D81DD0", VA = "0x181D829D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LFLBFNEONAP KLHFHGAFLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x802F7F0", Offset = "0x802EBF0", VA = "0x18802F7F0")]
			get
			{
				return default(LFLBFNEONAP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x80313A0", Offset = "0x80307A0", VA = "0x1880313A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BHFLGMJBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x802FE00", Offset = "0x802F200", VA = "0x18802FE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MLONIAAAKCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x802F910", Offset = "0x802ED10", VA = "0x18802F910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LHMOOAIDCGG OCADJDNOPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x802FD40", Offset = "0x802F140", VA = "0x18802FD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8031560", Offset = "0x8030960", VA = "0x188031560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MDELKDJPJMO LJPNJEDDINK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x802FCE0", Offset = "0x802F0E0", VA = "0x18802FCE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x80314F0", Offset = "0x80308F0", VA = "0x1880314F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MKGODOHPGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x802FC30", Offset = "0x802F030", VA = "0x18802FC30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody ILPJNOBFDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x802FC90", Offset = "0x802F090", VA = "0x18802FC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool FPCOEMKLHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x802F970", Offset = "0x802ED70", VA = "0x18802F970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8031410", Offset = "0x8030810", VA = "0x188031410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BOJICOMEDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x14B3EA0", Offset = "0x14B32A0", VA = "0x1814B3EA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BGANKPBNBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8030690", Offset = "0x802FA90", VA = "0x188030690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float PPBNKHJBEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8030630", Offset = "0x802FA30", VA = "0x188030630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8031B80", Offset = "0x8030F80", VA = "0x188031B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HKKACPANMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8030060", Offset = "0x802F460", VA = "0x188030060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8031800", Offset = "0x8030C00", VA = "0x188031800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float JGEJGDEPAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x802FE60", Offset = "0x802F260", VA = "0x18802FE60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80315D0", Offset = "0x80309D0", VA = "0x1880315D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool DONEJBLJENJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8030C40", Offset = "0x8030040", VA = "0x188030C40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8032130", Offset = "0x8031530", VA = "0x188032130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 LMGJJEBAMGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8030410", Offset = "0x802F810", VA = "0x188030410")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8031950", Offset = "0x8030D50", VA = "0x188031950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 KAJIBONNCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8030D80", Offset = "0x8030180", VA = "0x188030D80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode LKNPCHFDOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x802FFA0", Offset = "0x802F3A0", VA = "0x18802FFA0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8031720", Offset = "0x8030B20", VA = "0x188031720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NGPMJBAEEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x802F9D0", Offset = "0x802EDD0", VA = "0x18802F9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8031480", Offset = "0x8030880", VA = "0x188031480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints JCJBHGPHKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8030000", Offset = "0x802F400", VA = "0x188030000")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8031790", Offset = "0x8030B90", VA = "0x188031790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 NPNOLNGAMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x80307B0", Offset = "0x802FBB0", VA = "0x1880307B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 KBDEDNFMILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x80307B0", Offset = "0x802FBB0", VA = "0x1880307B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8031F10", Offset = "0x8031310", VA = "0x188031F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NBBPCMCINPH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x80304F0", Offset = "0x802F8F0", VA = "0x1880304F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8031A30", Offset = "0x8030E30", VA = "0x188031A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FKLGOEAPHHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8030BE0", Offset = "0x802FFE0", VA = "0x188030BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x80320C0", Offset = "0x80314C0", VA = "0x1880320C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LLCLFFKBKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8030890", Offset = "0x802FC90", VA = "0x188030890")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8031C90", Offset = "0x8031090", VA = "0x188031C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JFPGIHEJAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8030B10", Offset = "0x802FF10", VA = "0x188030B10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8031FF0", Offset = "0x80313F0", VA = "0x188031FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLAHJBBFNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8030960", Offset = "0x802FD60", VA = "0x188030960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8031D60", Offset = "0x8031160", VA = "0x188031D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion AGDDFHJMNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8030A40", Offset = "0x802FE40", VA = "0x188030A40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8031E40", Offset = "0x8031240", VA = "0x188031E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GPBFPENHNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8030CA0", Offset = "0x80300A0", VA = "0x188030CA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x80321A0", Offset = "0x80315A0", VA = "0x1880321A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PKMPKCGGDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8030550", Offset = "0x802F950", VA = "0x188030550")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8031AA0", Offset = "0x8030EA0", VA = "0x188031AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 APEPLMENJNI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x802FEC0", Offset = "0x802F2C0", VA = "0x18802FEC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8031640", Offset = "0x8030A40", VA = "0x188031640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KPLENMNPPFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8030330", Offset = "0x802F730", VA = "0x188030330")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8031870", Offset = "0x8030C70", VA = "0x188031870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IKGOFIJNLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80301F0", Offset = "0x802F5F0", VA = "0x1880301F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MPKPCDBODCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8030120", Offset = "0x802F520", VA = "0x188030120")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 MPLHFFEPPJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8030F40", Offset = "0x8030340", VA = "0x188030F40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ANGNJGOKLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8030E60", Offset = "0x8030260", VA = "0x188030E60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DLKMLFFELFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x80302D0", Offset = "0x802F6D0", VA = "0x1880302D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EDOCKFIIGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x802FDA0", Offset = "0x802F1A0", VA = "0x18802FDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JLONDOFCCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x802F8B0", Offset = "0x802ECB0", VA = "0x18802F8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KMMBJEHDKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x802F850", Offset = "0x802EC50", VA = "0x18802F850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool GFALBPLJJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x802F730", Offset = "0x802EB30", VA = "0x18802F730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool OKIBLPDEPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80300C0", Offset = "0x802F4C0", VA = "0x1880300C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LCONPCPHNJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x223F6F0", Offset = "0x223EAF0", VA = "0x18223F6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HDOGKPOEOHJ LPHPFJMKJLI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x802F650", Offset = "0x802EA50", VA = "0x18802F650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80312C0", Offset = "0x80306C0", VA = "0x1880312C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EICBMHINKNM ALOAJEBKNJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x802F3C0", Offset = "0x802E7C0", VA = "0x18802F3C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8031020", Offset = "0x8030420", VA = "0x188031020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EICBMHINKNM GNEHPPELDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x802F420", Offset = "0x802E820", VA = "0x18802F420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8031090", Offset = "0x8030490", VA = "0x188031090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EICBMHINKNM IHKIECJNFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x802F570", Offset = "0x802E970", VA = "0x18802F570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x80311E0", Offset = "0x80305E0", VA = "0x1880311E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x802F500", Offset = "0x802E900", VA = "0x18802F500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8031170", Offset = "0x8030570", VA = "0x188031170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event EICBMHINKNM NKNLGJIFEPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x802F5E0", Offset = "0x802E9E0", VA = "0x18802F5E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8031250", Offset = "0x8030650", VA = "0x188031250")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EICBMHINKNM IHDANKCPPOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x802F6C0", Offset = "0x802EAC0", VA = "0x18802F6C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8031330", Offset = "0x8030730", VA = "0x188031330")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EICBMHINKNM CBBDAKIOLFC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x802F490", Offset = "0x802E890", VA = "0x18802F490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8031100", Offset = "0x8030500", VA = "0x188031100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260", Slot = "8")]
		private void HBJKBPFBMJA(BLDMDGLHGCG BGCEKLPNCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x802E050", Offset = "0x802D450", VA = "0x18802E050", Slot = "9")]
		public KDCCJFNCNKM GetData()
		{
			return default(KDCCJFNCNKM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x802D900", Offset = "0x802CD00", VA = "0x18802D900")]
		internal void BCKAMPNIFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x802F0F0", Offset = "0x802E4F0", VA = "0x18802F0F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CMOKMLIBNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x802DDA0", Offset = "0x802D1A0", VA = "0x18802DDA0")]
		public FGIODNKADFN GetChild(int CJFNAFNJJLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x802EDB0", Offset = "0x802E1B0", VA = "0x18802EDB0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x802D740", Offset = "0x802CB40", VA = "0x18802D740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x802F040", Offset = "0x802E440", VA = "0x18802F040")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x802DB10", Offset = "0x802CF10", VA = "0x18802DB10")]
		private BLDMDGLHGCG BJKBIKCBNIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x802D990", Offset = "0x802CD90", VA = "0x18802D990")]
		private void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x802E580", Offset = "0x802D980", VA = "0x18802E580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x802E4C0", Offset = "0x802D8C0", VA = "0x18802E4C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x802D900", Offset = "0x802CD00", VA = "0x18802D900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x802E520", Offset = "0x802D920", VA = "0x18802E520")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x802E5E0", Offset = "0x802D9E0", VA = "0x18802E5E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x802CD90", Offset = "0x802C190", VA = "0x18802CD90")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x802E640", Offset = "0x802DA40", VA = "0x18802E640")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x802DD40", Offset = "0x802D140", VA = "0x18802DD40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x802E460", Offset = "0x802D860", VA = "0x18802E460")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x802EF10", Offset = "0x802E310", VA = "0x18802EF10")]
		public void SetParent(RigidbodyEx FFOEEMKIKJO, bool IIGOHJFNEAG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x802E950", Offset = "0x802DD50", VA = "0x18802E950")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x802E0E0", Offset = "0x802D4E0", VA = "0x18802E0E0")]
		public bool IsRigidbodyAncestor(RigidbodyEx BOLABIDFOPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x802E1E0", Offset = "0x802D5E0", VA = "0x18802E1E0")]
		public bool IsRigidbodyDescendant(RigidbodyEx NFKPKOGFLHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x802D000", Offset = "0x802C400", VA = "0x18802D000")]
		public void AddInterpolationRestriction(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x802E6B0", Offset = "0x802DAB0", VA = "0x18802E6B0")]
		public void RemoveInterpolationRestriction(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x802D070", Offset = "0x802C470", VA = "0x18802D070")]
		public void AddKinematic(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x802E720", Offset = "0x802DB20", VA = "0x18802E720")]
		public void RemoveKinematic(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x802EE90", Offset = "0x802E290", VA = "0x18802EE90")]
		public void SetKinematic(object HHGPJKKLNIG, bool HCLIPONIBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x802ECB0", Offset = "0x802E0B0", VA = "0x18802ECB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DOAGHIHKDJB, Quaternion JJONIBIPPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x802EBB0", Offset = "0x802DFB0", VA = "0x18802EBB0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MHMKEPELAFJ, Quaternion GOADIINENHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x802DF40", Offset = "0x802D340", VA = "0x18802DF40")]
		public Vector3 GetConstrainedVelocity(Vector3 GPBFPENHNGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x802DE30", Offset = "0x802D230", VA = "0x18802DE30")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 APEPLMENJNI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x802CF10", Offset = "0x802C310", VA = "0x18802CF10")]
		public void AddForce(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x802CE00", Offset = "0x802C200", VA = "0x18802CE00")]
		public void AddForceAtPosition(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x802D240", Offset = "0x802C640", VA = "0x18802D240")]
		public void AddTorque(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x802D0E0", Offset = "0x802C4E0", VA = "0x18802D0E0")]
		public void AddRelativeTorque(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x802F1C0", Offset = "0x802E5C0", VA = "0x18802F1C0")]
		public Vector3 WorldToLocalVelocity(Vector3 FNHOFIFJKGL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x802E350", Offset = "0x802D750", VA = "0x18802E350")]
		public Vector3 LocalToWorldVelocity(Vector3 PKMPKCGGDCJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x802DCE0", Offset = "0x802D0E0", VA = "0x18802DCE0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x802DC80", Offset = "0x802D080", VA = "0x18802DC80")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x802DC20", Offset = "0x802D020", VA = "0x18802DC20")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x802DBC0", Offset = "0x802CFC0", VA = "0x18802DBC0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x802EAB0", Offset = "0x802DEB0", VA = "0x18802EAB0")]
		public void ResetVelocityWorldSpace(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x802E9B0", Offset = "0x802DDB0", VA = "0x18802E9B0")]
		public void ResetVelocityLocalSpace(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x802E870", Offset = "0x802DC70", VA = "0x18802E870")]
		public void ResetLinearVelocityLocalSpace(Vector3 HHKLHBJKBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x802F050", Offset = "0x802E450", VA = "0x18802F050")]
		public bool SweepTest(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x802E2E0", Offset = "0x802D6E0", VA = "0x18802E2E0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x802EFE0", Offset = "0x802E3E0", VA = "0x18802EFE0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x802F160", Offset = "0x802E560", VA = "0x18802F160")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x802D1D0", Offset = "0x802C5D0", VA = "0x18802D1D0")]
		public void AddShouldHaveUnityRigidbodyToken(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x802E790", Offset = "0x802DB90", VA = "0x18802E790")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x802D5D0", Offset = "0x802C9D0", VA = "0x18802D5D0")]
		public void ApplyForceVelocityChange(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x802D4D0", Offset = "0x802C8D0", VA = "0x18802D4D0")]
		public void ApplyAngularVelocityChange(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x802D690", Offset = "0x802CA90", VA = "0x18802D690")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x802D400", Offset = "0x802C800", VA = "0x18802D400")]
		public bool AllowedScaleChange(float KMDFDGNLAGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x802D330", Offset = "0x802C730", VA = "0x18802D330")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GFNFBDBACGA, object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x802E800", Offset = "0x802DC00", VA = "0x18802E800")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x802E340", Offset = "0x802D740", VA = "0x18802E340", Slot = "12")]
		private void KEHLOLILFEP(LBONLJHNMPC PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x802F350", Offset = "0x802E750", VA = "0x18802F350")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB187E0", Offset = "0xB17BE0", VA = "0x180B187E0", Slot = "4")]
		private GameObject NJGKDKNHODD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9D6930", Offset = "0x9D5D30", VA = "0x1809D6930", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x8025BB0", Offset = "0x8024FB0", VA = "0x188025BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BJKJFECGOOO JGAIAPCNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x801E3A0", Offset = "0x801D7A0", VA = "0x18801E3A0", Slot = "7")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x801E410", Offset = "0x801D810", VA = "0x18801E410", Slot = "6")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x802CC10", Offset = "0x802C010", VA = "0x18802CC10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x802CC50", Offset = "0x802C050", VA = "0x18802CC50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x802CC30", Offset = "0x802C030", VA = "0x18802CC30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DAMFJFKKFBI, [Optional] UnityEngine.Object PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DAMFJFKKFBI, [Optional] UnityEngine.Object PCJJKLDOJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x802CD40", Offset = "0x802C140", VA = "0x18802CD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BA860", Offset = "0x9B9C60", VA = "0x1809BA860", Slot = "4")]
		public Vector3 LPCDBNKIDHI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BA860", Offset = "0x9B9C60", VA = "0x1809BA860", Slot = "5")]
		public Vector3 FGOKNOFDKJK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "6")]
		public bool ODHDGKFCHMK(float JJDIDKFPPAL, float ACPOHLDGHJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IJEGPHNEDAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LHMOOAIDCGG EJEENKAPOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x801E5C0", Offset = "0x801D9C0", VA = "0x18801E5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "22")]
		get
		{
			return default(ENLBBCIDMLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FGIODNKADFN HDBNKJAJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC35E10", Offset = "0xC35210", VA = "0x180C35E10", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xDAB2F0", Offset = "0xDAA6F0", VA = "0x180DAB2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ANCELBFINAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A70", Offset = "0x9B1E70", VA = "0x1809B2A70", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AD0", Offset = "0x9B1ED0", VA = "0x1809B2AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform IGBFJKOBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB6DE10", Offset = "0xB6D210", VA = "0x180B6DE10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xDB0000", Offset = "0xDAF400", VA = "0x180DB0000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x80226A0", Offset = "0x8021AA0", VA = "0x1880226A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80219B0", Offset = "0x8020DB0", VA = "0x1880219B0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x801F270", Offset = "0x801E670", VA = "0x18801F270", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FDCAABAGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80226F0", Offset = "0x8021AF0", VA = "0x1880226F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BLDMDGLHGCG HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8023CC0", Offset = "0x80230C0", VA = "0x188023CC0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x80238E0", Offset = "0x8022CE0", VA = "0x1880238E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BHFLGMJBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80241D0", Offset = "0x80235D0", VA = "0x1880241D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool MLONIAAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8022760", Offset = "0x8021B60", VA = "0x188022760", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LHMOOAIDCGG OCADJDNOPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80248C0", Offset = "0x8023CC0", VA = "0x1880248C0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8024BA0", Offset = "0x8023FA0", VA = "0x188024BA0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MDELKDJPJMO LJPNJEDDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8024050", Offset = "0x8023450", VA = "0x188024050", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8022CA0", Offset = "0x80220A0", VA = "0x188022CA0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float NGPMJBAEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8022F00", Offset = "0x8022300", VA = "0x188022F00", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8024910", Offset = "0x8023D10", VA = "0x188024910", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 GNLAPFBAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x801F6A0", Offset = "0x801EAA0", VA = "0x18801F6A0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x801F130", Offset = "0x801E530", VA = "0x18801F130", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 NIADJEHEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8020550", Offset = "0x801F950", VA = "0x188020550", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8023940", Offset = "0x8022D40", VA = "0x188023940", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x80230A0", Offset = "0x80224A0", VA = "0x1880230A0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8023B00", Offset = "0x8022F00", VA = "0x188023B00", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 CCOJCBMDALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x801EF70", Offset = "0x801E370", VA = "0x18801EF70", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x80207C0", Offset = "0x801FBC0", VA = "0x1880207C0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JLONDOFCCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8022BA0", Offset = "0x8021FA0", VA = "0x188022BA0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KMMBJEHDKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80236B0", Offset = "0x8022AB0", VA = "0x1880236B0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool GFALBPLJJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8022AC0", Offset = "0x8021EC0", VA = "0x188022AC0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MKGODOHPGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8022980", Offset = "0x8021D80", VA = "0x188022980", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CMHABAONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x801E690", Offset = "0x801DA90", VA = "0x18801E690", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FGKCAICHENO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x801FE10", Offset = "0x801F210", VA = "0x18801FE10", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 AMJGAFKLJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x801F780", Offset = "0x801EB80", VA = "0x18801F780", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8021C70", Offset = "0x8021070", VA = "0x188021C70", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 FMMJGFGCNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x801FFA0", Offset = "0x801F3A0", VA = "0x18801FFA0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float NCOFGJEEKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8021C20", Offset = "0x8021020", VA = "0x188021C20", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float ONHGEOPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8021A50", Offset = "0x8020E50", VA = "0x188021A50", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x80221C0", Offset = "0x80215C0", VA = "0x1880221C0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 GAAGIFCFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x801F050", Offset = "0x801E450", VA = "0x18801F050", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion MEKDJFANFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x80228B0", Offset = "0x8021CB0", VA = "0x1880228B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float NDMOEKDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x801FEF0", Offset = "0x801F2F0", VA = "0x18801FEF0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8022160", Offset = "0x8021560", VA = "0x188022160", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float KOOFMHKLIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x801F9A0", Offset = "0x801EDA0", VA = "0x18801F9A0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x80240A0", Offset = "0x80234A0", VA = "0x1880240A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool CCBPNOFMMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8020500", Offset = "0x801F900", VA = "0x188020500", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8020A90", Offset = "0x801FE90", VA = "0x188020A90", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LFLBFNEONAP KLHFHGAFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x801E860", Offset = "0x801DC60", VA = "0x18801E860", Slot = "70")]
		get
		{
			return default(LFLBFNEONAP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x80233F0", Offset = "0x80227F0", VA = "0x1880233F0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8023DD0", Offset = "0x80231D0", VA = "0x188023DD0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform NLGEJCOEKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB6DE10", Offset = "0xB6D210", VA = "0x180B6DE10", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GBPFMJCENDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x80209E0", Offset = "0x801FDE0", VA = "0x1880209E0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x801F3D0", Offset = "0x801E7D0", VA = "0x18801F3D0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CGIBJMLFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8022E90", Offset = "0x8022290", VA = "0x188022E90", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8023A90", Offset = "0x8022E90", VA = "0x188023A90", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FLEBLMGGHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x801F690", Offset = "0x801EA90", VA = "0x18801F690", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x80247E0", Offset = "0x8023BE0", VA = "0x1880247E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JGCLCFDKMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x801F480", Offset = "0x801E880", VA = "0x18801F480", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8021F50", Offset = "0x8021350", VA = "0x188021F50", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 MFPCIJJNMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8022280", Offset = "0x8021680", VA = "0x188022280", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8022E50", Offset = "0x8022250", VA = "0x188022E50", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion IGDJELKFIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x801F520", Offset = "0x801E920", VA = "0x18801F520", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8024020", Offset = "0x8023420", VA = "0x188024020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HGNBCLAGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x801F380", Offset = "0x801E780", VA = "0x18801F380", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8022460", Offset = "0x8021860", VA = "0x188022460", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool FPCOEMKLHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8020770", Offset = "0x801FB70", VA = "0x188020770", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x801F2D0", Offset = "0x801E6D0", VA = "0x18801F2D0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode BIGAHNDHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8023710", Offset = "0x8022B10", VA = "0x188023710", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8021950", Offset = "0x8020D50", VA = "0x188021950", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x801F860", Offset = "0x801EC60", VA = "0x18801F860", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool EDOCKFIIGON
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8023760", Offset = "0x8022B60", VA = "0x188023760", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EICBMHINKNM ALOAJEBKNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x801F210", Offset = "0x801E610", VA = "0x18801F210", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8023C60", Offset = "0x8023060", VA = "0x188023C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event EICBMHINKNM GNEHPPELDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x801ED60", Offset = "0x801E160", VA = "0x18801ED60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8023590", Offset = "0x8022990", VA = "0x188023590", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HDOGKPOEOHJ JIKOBJGJECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8020710", Offset = "0x801FB10", VA = "0x188020710", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8022640", Offset = "0x8021A40", VA = "0x188022640", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EICBMHINKNM JOPJCBEHOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x801EE70", Offset = "0x801E270", VA = "0x18801EE70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80218F0", Offset = "0x8020CF0", VA = "0x1880218F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EICBMHINKNM IHKIECJNFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x80215B0", Offset = "0x80209B0", VA = "0x1880215B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8020980", Offset = "0x801FD80", VA = "0x188020980", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event EICBMHINKNM GBKGIKGPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8022220", Offset = "0x8021620", VA = "0x188022220", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x801EDC0", Offset = "0x801E1C0", VA = "0x18801EDC0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8021890", Offset = "0x8020C90", VA = "0x188021890", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8022F50", Offset = "0x8022350", VA = "0x188022F50", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EICBMHINKNM DBLHHGBKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8021550", Offset = "0x8020950", VA = "0x188021550", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8023180", Offset = "0x8022580", VA = "0x188023180", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EICBMHINKNM CBBDAKIOLFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x80224C0", Offset = "0x80218C0", VA = "0x1880224C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8020E00", Offset = "0x8020200", VA = "0x188020E00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8024CD0", Offset = "0x80240D0", VA = "0x188024CD0")]
	public GGNHHJDHICI(GameObject GIIGFIAPGGB, RigidbodyEx KPMNEKMAFNC, NIHOCGKJMHE HEKFIEJNOCO, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x801EA10", Offset = "0x801DE10", VA = "0x18801EA10", Slot = "139")]
	protected virtual void AIIMIDEFBKG(NIHOCGKJMHE HEKFIEJNOCO, KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x80202D0", Offset = "0x801F6D0", VA = "0x1880202D0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8023450", Offset = "0x8022850", VA = "0x188023450", Slot = "93")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8022FB0", Offset = "0x80223B0", VA = "0x188022FB0", Slot = "94")]
	public void MABBNJBFHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8022EA0", Offset = "0x80222A0", VA = "0x188022EA0", Slot = "95")]
	public void LMKILLMBFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8020630", Offset = "0x801FA30", VA = "0x188020630", Slot = "96")]
	public void EIKLAHENAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8021610", Offset = "0x8020A10", VA = "0x188021610")]
	private void GLNCPHIAFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8023BE0", Offset = "0x8022FE0", VA = "0x188023BE0")]
	private void OBOFOBEMNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x801E9B0", Offset = "0x801DDB0", VA = "0x18801E9B0")]
	private void AHDEHEMHABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8021BA0", Offset = "0x8020FA0", VA = "0x188021BA0", Slot = "30")]
	public BLDMDGLHGCG HNDLFCCAFAM(int CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x80206A0", Offset = "0x801FAA0", VA = "0x1880206A0", Slot = "98")]
	public void EMLOMBIHCBC(BLDMDGLHGCG FFOEEMKIKJO, bool IIGOHJFNEAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x801FF40", Offset = "0x801F340", VA = "0x18801FF40", Slot = "99")]
	public void DLCPJLEFDKA(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8024270", Offset = "0x8023670", VA = "0x188024270", Slot = "100")]
	public void OOMAACFBINP(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x801E8B0", Offset = "0x801DCB0", VA = "0x18801E8B0", Slot = "101")]
	public Vector3 ADFPDAEBLKI(Vector3 FNHOFIFJKGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8021D50", Offset = "0x8021150", VA = "0x188021D50", Slot = "102")]
	public Vector3 IEDGBHBCANN(Vector3 PKMPKCGGDCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x80227B0", Offset = "0x8021BB0", VA = "0x1880227B0", Slot = "103")]
	public void KMOCPELJBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8024220", Offset = "0x8023620", VA = "0x188024220", Slot = "104")]
	public void OOAGCIMBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8024720", Offset = "0x8023B20", VA = "0x188024720", Slot = "105")]
	public void PBHCEHPEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x80229D0", Offset = "0x8021DD0", VA = "0x1880229D0", Slot = "106")]
	public void LBPCOGEPHJA(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8022320", Offset = "0x8021720", VA = "0x188022320", Slot = "107")]
	public void KECDDBGCHMH(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x80208A0", Offset = "0x801FCA0", VA = "0x1880208A0", Slot = "108")]
	public void EODLFCNONFH(Vector3 HHPBPILOIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8023D10", Offset = "0x8023110", VA = "0x188023D10", Slot = "109")]
	public void OEDAHHABPJD(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8021AA0", Offset = "0x8020EA0", VA = "0x188021AA0", Slot = "110")]
	public void HMEFCOOCCJA(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8022BF0", Offset = "0x8021FF0", VA = "0x188022BF0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LGNKHCCBCDE(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8021E50", Offset = "0x8021250", VA = "0x188021E50", Slot = "112")]
	public Vector3 IOEDKKBEBPA(Vector3 FFOEEMKIKJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x801E760", Offset = "0x801DB60", VA = "0x18801E760", Slot = "113")]
	public Vector3 ACIFDECJOIA(Vector3 FFOEEMKIKJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8022410", Offset = "0x8021810", VA = "0x188022410", Slot = "114")]
	public void KEDOOOBMBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8024770", Offset = "0x8023B70", VA = "0x188024770", Slot = "115")]
	public void PCIHOIHPKPH(BLDMDGLHGCG GFNFBDBACGA, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x801F9F0", Offset = "0x801EDF0", VA = "0x18801F9F0", Slot = "116")]
	public void CMFLBHGIKOM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x801F560", Offset = "0x801E960", VA = "0x18801F560", Slot = "63")]
	public void CCMOBCFBADO((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x801F330", Offset = "0x801E730", VA = "0x18801F330", Slot = "117")]
	public void BLPCMPDPKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x80235F0", Offset = "0x80229F0", VA = "0x1880235F0", Slot = "118")]
	public void MPFMGECAPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x801EE20", Offset = "0x801E220", VA = "0x18801EE20", Slot = "119")]
	public void APLJKCDAGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8020AF0", Offset = "0x801FEF0", VA = "0x188020AF0", Slot = "120")]
	public bool FFGLGDIECKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8020650", Offset = "0x801FA50", VA = "0x188020650", Slot = "97")]
	public void EIPLMBFAJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8023640", Offset = "0x8022A40", VA = "0x188023640", Slot = "121")]
	public void NACDKDDODFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8023040", Offset = "0x8022440", VA = "0x188023040", Slot = "122")]
	public void MEGBKFPNHJD(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x80222C0", Offset = "0x80216C0", VA = "0x1880222C0", Slot = "123")]
	public void JPLPJEDDEFM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8023A20", Offset = "0x8022E20", VA = "0x188023A20", Slot = "124")]
	public void NKLDDLODFLG(object HHGPJKKLNIG, bool HCLIPONIBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8023E20", Offset = "0x8023220", VA = "0x188023E20", Slot = "125")]
	public void OFKJPGGODMG(Vector3 DOAGHIHKDJB, Quaternion JJONIBIPPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8022030", Offset = "0x8021430", VA = "0x188022030", Slot = "126")]
	public void JDKEJLBOJEL(Vector3 MHMKEPELAFJ, Quaternion GOADIINENHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x801F640", Offset = "0x801EA40", VA = "0x18801F640", Slot = "127")]
	public bool CEIEFFNICJM(float KMDFDGNLAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8023390", Offset = "0x8022790", VA = "0x188023390", Slot = "128")]
	public void MIMMAFHDBHA(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x801ED00", Offset = "0x801E100", VA = "0x18801ED00", Slot = "129")]
	public void AIMLGGEGEPN(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x80213E0", Offset = "0x80207E0", VA = "0x1880213E0", Slot = "130")]
	public void GCBAHEBKPMO(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x801FA50", Offset = "0x801EE50", VA = "0x18801FA50", Slot = "131")]
	public void DALGMHHCMGK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8020D20", Offset = "0x8020120", VA = "0x188020D20", Slot = "132")]
	public void FNGLFKHAFDE(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8021440", Offset = "0x8020840", VA = "0x188021440", Slot = "133")]
	public void GEJABLBKGKK(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x80201F0", Offset = "0x801F5F0", VA = "0x1880201F0", Slot = "134")]
	public void DNGDLHDIEGJ(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8021300", Offset = "0x8020700", VA = "0x188021300", Slot = "135")]
	public void GAIHBHFGPEC(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x801EED0", Offset = "0x801E2D0", VA = "0x18801EED0", Slot = "136")]
	public bool BDFOGFLPAEP(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8021A00", Offset = "0x8020E00", VA = "0x188021A00", Slot = "137")]
	public void HIKDFKDNGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8024C90", Offset = "0x8024090", VA = "0x188024C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8022570", Offset = "0x8021970", VA = "0x188022570")]
	private void KJKGHKKDJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8024A90", Offset = "0x8023E90", VA = "0x188024A90")]
	private void PNNBHLHAJPK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8020B40", Offset = "0x801FF40", VA = "0x188020B40")]
	private void FJOBFDDOLGF(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8022800", Offset = "0x8021C00", VA = "0x188022800")]
	private void KPPBPJDGBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8024970", Offset = "0x8023D70", VA = "0x188024970")]
	private void PIBJICBAKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x80231E0", Offset = "0x80225E0", VA = "0x1880231E0")]
	private void MGIJJJNHKPP(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8024650", Offset = "0x8023A50", VA = "0x188024650")]
	private void PBGKFOKDNBN(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8024100", Offset = "0x8023500", VA = "0x188024100")]
	private void OICPBNFOKLK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8022D00", Offset = "0x8022100", VA = "0x188022D00")]
	private void LIJLLKOKDBI(FGIODNKADFN KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8020EB0", Offset = "0x80202B0", VA = "0x188020EB0", Slot = "142")]
	protected virtual void FPJHFDEODIK(FGIODNKADFN LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x801FAB0", Offset = "0x801EEB0", VA = "0x18801FAB0")]
	protected void DBCBGAGMEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x80242D0", Offset = "0x80236D0", VA = "0x1880242D0")]
	protected void OPLHBBNAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x80203D0", Offset = "0x801F7D0", VA = "0x1880203D0")]
	private void EBAHKOMJKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8020080", Offset = "0x801F480", VA = "0x188020080")]
	private void DMIDMLCJMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class PNKNMJECMKA
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x802C9F0", Offset = "0x802BDF0", VA = "0x18802C9F0")]
	public static BLDMDGLHGCG BCGCMOAGLCF(this BLDMDGLHGCG LPNNCKGGDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x802CB70", Offset = "0x802BF70", VA = "0x18802CB70")]
	public static bool OEEBOFPBGBN(this BLDMDGLHGCG LPNNCKGGDEC, BLDMDGLHGCG BOLABIDFOPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x802C950", Offset = "0x802BD50", VA = "0x18802C950")]
	public static bool AMBJJEHEJOB(this BLDMDGLHGCG LPNNCKGGDEC, BLDMDGLHGCG NFKPKOGFLHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x802CAB0", Offset = "0x802BEB0", VA = "0x18802CAB0")]
	public static FGIODNKADFN HKIHPDGGKBM(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x802CB00", Offset = "0x802BF00", VA = "0x18802CB00")]
	public static GGNHHJDHICI HNLLPNEJLLP(this BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AMNIKIBDGLH : BJKJFECGOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8015EE0", Offset = "0x80152E0", VA = "0x188015EE0", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public AMNIKIBDGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x801DEA0", Offset = "0x801D2A0", VA = "0x18801DEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x801DC20", Offset = "0x801D020", VA = "0x18801DC20", Slot = "20")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x801DB80", Offset = "0x801CF80", VA = "0x18801DB80", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x801DF00", Offset = "0x801D300", VA = "0x18801DF00", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x801E040", Offset = "0x801D440", VA = "0x18801E040", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x801DD20", Offset = "0x801D120", VA = "0x18801DD20", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x801D790", Offset = "0x801CB90", VA = "0x18801D790", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x801DFA0", Offset = "0x801D3A0", VA = "0x18801DFA0", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x801DAE0", Offset = "0x801CEE0", VA = "0x18801DAE0", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x801E190", Offset = "0x801D590", VA = "0x18801E190", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x801D6F0", Offset = "0x801CAF0", VA = "0x18801D6F0", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x801D8E0", Offset = "0x801CCE0", VA = "0x18801D8E0", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x801DA30", Offset = "0x801CE30", VA = "0x18801DA30")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x801D980", Offset = "0x801CD80", VA = "0x18801D980")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x801DC70", Offset = "0x801D070", VA = "0x18801DC70")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x801D830", Offset = "0x801CC30", VA = "0x18801D830")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x801E0E0", Offset = "0x801D4E0", VA = "0x18801E0E0")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x801DDC0", Offset = "0x801D1C0", VA = "0x18801DDC0", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x801E230", Offset = "0x801D630", VA = "0x18801E230")]
	public EEBNDNDCOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x801DA30", Offset = "0x801CE30", VA = "0x18801DA30", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x801D980", Offset = "0x801CD80", VA = "0x18801D980", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x801DC70", Offset = "0x801D070", VA = "0x18801DC70", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x801D830", Offset = "0x801CC30", VA = "0x18801D830", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x801E0E0", Offset = "0x801D4E0", VA = "0x18801E0E0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x80255C0", Offset = "0x80249C0", VA = "0x1880255C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode BIGAHNDHKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x802BA90", Offset = "0x802AE90", VA = "0x18802BA90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x802B870", Offset = "0x802AC70", VA = "0x18802B870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8025B20", Offset = "0x8024F20", VA = "0x188025B20")]
	public OJHBKLNEGDP(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x802B980", Offset = "0x802AD80", VA = "0x18802B980", Slot = "6")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x802B8F0", Offset = "0x802ACF0", VA = "0x18802B8F0", Slot = "9")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x802B970", Offset = "0x802AD70", VA = "0x18802B970", Slot = "7")]
	public void MKJAGJCBDDB(bool DLKMLFFELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x802B8E0", Offset = "0x802ACE0", VA = "0x18802B8E0", Slot = "8")]
	public void LIMDMBIGCBB(bool DLKMLFFELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x802B5F0", Offset = "0x802A9F0", VA = "0x18802B5F0", Slot = "10")]
	public bool BDFOGFLPAEP(Vector3 GOMJGIJPEPD, [Out] RaycastHit LMFJOEHIBFL, float KGELMMBOFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x802B750", Offset = "0x802AB50", VA = "0x18802B750")]
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
		[Cpp2IlInjected.Address(RVA = "0x80268E0", Offset = "0x8025CE0", VA = "0x1880268E0", Slot = "6")]
		get
		{
			return default(LFLBFNEONAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8026BD0", Offset = "0x8025FD0", VA = "0x188026BD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform IHHLIJKELOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC1E580", Offset = "0xC1D980", VA = "0x180C1E580", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<FIEJAHACKON, FIEJAHACKON> LDAMNHEMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8026A70", Offset = "0x8025E70", VA = "0x188026A70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8026B20", Offset = "0x8025F20", VA = "0x188026B20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8026F10", Offset = "0x8026310", VA = "0x188026F10")]
	public JLINOGHHGIO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8026CA0", Offset = "0x80260A0", VA = "0x188026CA0", Slot = "8")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8026A20", Offset = "0x8025E20", VA = "0x188026A20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x10AA020", Offset = "0x10A9420", VA = "0x1810AA020", Slot = "11")]
	private void KAEHPACHBNF(FIEJAHACKON EODAOCIBHCJ, FIEJAHACKON HLCKONMPLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "12")]
	private void PBDJEINHFPJ(bool CIDNJAKHCBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KPGGDGBMDOH : BJKJFECGOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8027770", Offset = "0x8026B70", VA = "0x188027770", Slot = "4")]
	public KGIFNKHHFOK IJPEPMNABCM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8027B60", Offset = "0x8026F60", VA = "0x188027B60", Slot = "5")]
	public NBGGJLGJHBD KFAJEHEFAJE(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8027D50", Offset = "0x8027150", VA = "0x188027D50", Slot = "6")]
	public CBOKOEONGEL NKJMGPAABPH(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8027990", Offset = "0x8026D90", VA = "0x188027990", Slot = "7")]
	public IODIOIMAIND JKCNHKCECKD(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8027060", Offset = "0x8026460", VA = "0x188027060", Slot = "8")]
	public CHJMJNCJFPP DFDDIKBFCAK(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8027C80", Offset = "0x8027080", VA = "0x188027C80", Slot = "9")]
	public HODBPPHMBPK NBEECMDAGHI(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8027650", Offset = "0x8026A50", VA = "0x188027650", Slot = "10")]
	public IJJJLBHIFDI GEBKMJOFIAB(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8027F60", Offset = "0x8027360", VA = "0x188027F60", Slot = "11")]
	public PCIHJIDAFOL OLEMAEOAAKG(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8026FA0", Offset = "0x80263A0", VA = "0x188026FA0", Slot = "12")]
	public PFLEMMAAOMH ADJIFBAHJHA(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x80272C0", Offset = "0x80266C0", VA = "0x1880272C0", Slot = "13")]
	public BPECJDJIALG DPFLGIILCNM(BLDMDGLHGCG BGCEKLPNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8027510", Offset = "0x8026910", VA = "0x188027510")]
	public BIKICEBBCAG FPBMLJBPENO(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8027380", Offset = "0x8026780", VA = "0x188027380")]
	public KFCFJPCGCLB FNPJGBELEIG(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8027860", Offset = "0x8026C60", VA = "0x188027860")]
	public EBKMFCDKDAO JEDAKOHKPOI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8027130", Offset = "0x8026530", VA = "0x188027130")]
	public AEPNNNHLOGL DLJGJJNKNLL(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8027E80", Offset = "0x8027280", VA = "0x188027E80")]
	public KCOFFCEFAKL PMKBHOFFCPE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8027A10", Offset = "0x8026E10", VA = "0x188027A10", Slot = "19")]
	public BLDMDGLHGCG KBCBPCGPLBJ(RigidbodyEx LPNNCKGGDEC, KDCCJFNCNKM HPMNBNLACCC, NIHOCGKJMHE HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KPGGDGBMDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8027510", Offset = "0x8026910", VA = "0x188027510", Slot = "14")]
	private BIKICEBBCAG PHDOJJLMEGN(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8027380", Offset = "0x8026780", VA = "0x188027380", Slot = "15")]
	private KFCFJPCGCLB MKBDCPBEECE(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8027860", Offset = "0x8026C60", VA = "0x188027860", Slot = "16")]
	private EBKMFCDKDAO JGHCEBGJAGI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8027130", Offset = "0x8026530", VA = "0x188027130", Slot = "17")]
	private AEPNNNHLOGL FEEDGNAGNBI(BLDMDGLHGCG BGCEKLPNCIL, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8027E80", Offset = "0x8027280", VA = "0x188027E80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x80255C0", Offset = "0x80249C0", VA = "0x1880255C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CILDDLFLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8025AD0", Offset = "0x8024ED0", VA = "0x188025AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8016B00", Offset = "0x8015F00", VA = "0x188016B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8025560", Offset = "0x8024960", VA = "0x188025560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8025B20", Offset = "0x8024F20", VA = "0x188025B20")]
	public HBLJPOPHHHO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8024F20", Offset = "0x8024320", VA = "0x188024F20", Slot = "4")]
	public void FNGLFKHAFDE(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8025610", Offset = "0x8024A10", VA = "0x188025610")]
	private void KNKJLPACOOF(Vector3 HLPBIKLHEBD, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x80252E0", Offset = "0x80246E0", VA = "0x1880252E0", Slot = "5")]
	public void GEJABLBKGKK(Vector3 HLPBIKLHEBD, Vector3 INHMOEHIHAJ, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8024DC0", Offset = "0x80241C0", VA = "0x188024DC0", Slot = "6")]
	public void DNGDLHDIEGJ(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8025870", Offset = "0x8024C70", VA = "0x188025870")]
	private void NPAELNAMHIG(Vector3 CDDMEBJGIMB, ForceMode KEDFMECBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8025080", Offset = "0x8024480", VA = "0x188025080", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA11750", Offset = "0xA10B50", VA = "0x180A11750", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8028EF0", Offset = "0x80282F0", VA = "0x188028EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8025B20", Offset = "0x8024F20", VA = "0x188025B20")]
	public MCFFJPGLGAG(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8029070", Offset = "0x8028470", VA = "0x188029070", Slot = "6")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8029000", Offset = "0x8028400", VA = "0x188029000", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x802A850", Offset = "0x8029C50", VA = "0x18802A850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A30", Offset = "0x9A8E30", VA = "0x1809A9A30", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x80298A0", Offset = "0x8028CA0", VA = "0x1880298A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BLDMDGLHGCG HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA0", Offset = "0x9A8EA0", VA = "0x1809A9AA0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<BLDMDGLHGCG> GGJCFLEHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A40", Offset = "0x9A8E40", VA = "0x1809A9A40", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EICBMHINKNM ALOAJEBKNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8029800", Offset = "0x8028C00", VA = "0x188029800", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x802ADC0", Offset = "0x802A1C0", VA = "0x18802ADC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EICBMHINKNM GNEHPPELDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8029720", Offset = "0x8028B20", VA = "0x188029720", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x802ABD0", Offset = "0x8029FD0", VA = "0x18802ABD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event HDOGKPOEOHJ JIKOBJGJECI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x802A2B0", Offset = "0x80296B0", VA = "0x18802A2B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x802AA80", Offset = "0x8029E80", VA = "0x18802AA80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action NBELHKJODLF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x802B3F0", Offset = "0x802A7F0", VA = "0x18802B3F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8029AB0", Offset = "0x8028EB0", VA = "0x188029AB0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action NLHBDDCKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x802AC70", Offset = "0x802A070", VA = "0x18802AC70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8029950", Offset = "0x8028D50", VA = "0x188029950", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BLDMDGLHGCG> IHFEIDBPHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x802B340", Offset = "0x802A740", VA = "0x18802B340", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x802AD10", Offset = "0x802A110", VA = "0x18802AD10", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BLDMDGLHGCG> KAJIJIHGLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x802A350", Offset = "0x8029750", VA = "0x18802A350", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x802A7A0", Offset = "0x8029BA0", VA = "0x18802A7A0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action CLOICHHAIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x802B490", Offset = "0x802A890", VA = "0x18802B490", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x802B2A0", Offset = "0x802A6A0", VA = "0x18802B2A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BLDMDGLHGCG> AJIEOMHMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x802AB20", Offset = "0x8029F20", VA = "0x18802AB20", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x802B1F0", Offset = "0x802A5F0", VA = "0x18802B1F0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x802B530", Offset = "0x802A930", VA = "0x18802B530")]
	public OCCDEOLPCAJ(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8029B50", Offset = "0x8028F50", VA = "0x188029B50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8029D30", Offset = "0x8029130", VA = "0x188029D30", Slot = "30")]
	public void EMLOMBIHCBC(BLDMDGLHGCG BBFFOKPDHFL, bool IIGOHJFNEAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x802A530", Offset = "0x8029930", VA = "0x18802A530", Slot = "6")]
	public void GMOJLKDHIHH(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x802AF70", Offset = "0x802A370", VA = "0x18802AF70", Slot = "7")]
	public void OLJLMOIOGFB(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x802AE60", Offset = "0x802A260", VA = "0x18802AE60", Slot = "4")]
	public void OEHIFBKDANM(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x802A8B0", Offset = "0x8029CB0", VA = "0x18802A8B0", Slot = "5")]
	public void JBNINBDDBCA(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x80298B0", Offset = "0x8028CB0", VA = "0x1880298B0")]
	private void CEJMBKEPGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x80297C0", Offset = "0x8028BC0", VA = "0x1880297C0")]
	private void BDGKDNBNPBH(BLDMDGLHGCG PLHEJCLJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8029BF0", Offset = "0x8028FF0", VA = "0x188029BF0")]
	private void EJGKIOLOFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x802A400", Offset = "0x8029800", VA = "0x18802A400")]
	private void GLEPBBNBOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x802A950", Offset = "0x8029D50", VA = "0x18802A950")]
	private void JKDAIENGGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x80299F0", Offset = "0x8028DF0", VA = "0x1880299F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x801E2E0", Offset = "0x801D6E0", VA = "0x18801E2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CMHABAONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8028130", Offset = "0x8027530", VA = "0x188028130", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FGKCAICHENO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x80284F0", Offset = "0x80278F0", VA = "0x1880284F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8028970", Offset = "0x8027D70", VA = "0x188028970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BLDMDGLHGCG JJIJDBNFEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8028860", Offset = "0x8027C60", VA = "0x188028860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8028DF0", Offset = "0x80281F0", VA = "0x188028DF0")]
	public MBCOPOOIEKO(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x80287F0", Offset = "0x8027BF0", VA = "0x1880287F0", Slot = "8")]
	public void FHHLNIMMEPH(BLDMDGLHGCG KLDFHLFOOFN, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8028910", Offset = "0x8027D10", VA = "0x188028910", Slot = "9")]
	public void LPNNJDCLDFH(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8028A50", Offset = "0x8027E50", VA = "0x188028A50")]
	private Vector3 MOFMJGDBFPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8028160", Offset = "0x8027560", VA = "0x188028160")]
	private void AGILADNKBNA(BLDMDGLHGCG GDPLDINDKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NPJOPEFBDCA
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8029660", Offset = "0x8028A60", VA = "0x188029660")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F2CF0", Offset = "0x14F20F0", VA = "0x1814F2CF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8018BB0", Offset = "0x8017FB0", VA = "0x188018BB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 FMMJGFGCNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x80185A0", Offset = "0x80179A0", VA = "0x1880185A0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float NCOFGJEEKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC43D70", Offset = "0xC43170", VA = "0x180C43D70", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8018140", Offset = "0x8017540", VA = "0x188018140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float ONHGEOPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB4D0F0", Offset = "0xB4C4F0", VA = "0x180B4D0F0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8018C60", Offset = "0x8018060", VA = "0x188018C60", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 GAAGIFCFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8017140", Offset = "0x8016540", VA = "0x188017140", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion MEKDJFANFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8018E50", Offset = "0x8018250", VA = "0x188018E50", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody ILPJNOBFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8018E00", Offset = "0x8018200", VA = "0x188018E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EICBMHINKNM CFJHMGGJNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8018FD0", Offset = "0x80183D0", VA = "0x188018FD0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8018690", Offset = "0x8017A90", VA = "0x188018690", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8019730", Offset = "0x8018B30", VA = "0x188019730")]
	public CELBMPFCBJI(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8018250", Offset = "0x8017650", VA = "0x188018250", Slot = "17")]
	public void BLPCMPDPKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x80194B0", Offset = "0x80188B0", VA = "0x1880194B0", Slot = "16")]
	public void MPFMGECAPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8019250", Offset = "0x8018650", VA = "0x188019250", Slot = "19")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8019070", Offset = "0x8018470", VA = "0x188019070", Slot = "20")]
	public void LKDPGNMHKPN(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8016FA0", Offset = "0x80163A0", VA = "0x188016FA0", Slot = "18")]
	public void APLJKCDAGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8018730", Offset = "0x8017B30", VA = "0x188018730", Slot = "21")]
	public void HIKDFKDNGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8018BB0", Offset = "0x8017FB0", VA = "0x188018BB0")]
	private void NPELHFKENPO(Vector3 FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8018D10", Offset = "0x8018110", VA = "0x188018D10")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 JJOMKFBBPJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8018140", Offset = "0x8017540", VA = "0x188018140")]
	private void NGFEDMBMLIB(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8018C60", Offset = "0x8018060", VA = "0x188018C60")]
	private void PBNFCHFLIOE(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8019590", Offset = "0x8018990", VA = "0x188019590")]
	private Vector3 NAJOIMADAJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8018370", Offset = "0x8017770", VA = "0x188018370", Slot = "15")]
	public void CCMOBCFBADO((Quaternion rot, Vector3 moments) MKJGDLEKAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8019330", Offset = "0x8018730", VA = "0x188019330")]
	private Quaternion MLBKFONGHIA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8018070", Offset = "0x8017470", VA = "0x188018070")]
	public void BIOJBLKOCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x80172D0", Offset = "0x80166D0", VA = "0x1880172D0", Slot = "4")]
	public (float, Vector3) BIOJBLKOCKF(Rigidbody HDNHPNMKCLN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class NJFFDLJDAJE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x80292D0", Offset = "0x80286D0", VA = "0x1880292D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16A83B0", Offset = "0x16A77B0", VA = "0x1816A83B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FIBKGJKLAIB GGJDAFKPKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410", Slot = "11")]
		get
		{
			return default(FIBKGJKLAIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8016590", Offset = "0x8015990", VA = "0x188016590")]
	public BIBGNKNKMCO(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8016390", Offset = "0x8015790", VA = "0x188016390", Slot = "4")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8016100", Offset = "0x8015500", VA = "0x188016100")]
	private bool HHBKKMLGKDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8015FC0", Offset = "0x80153C0", VA = "0x188015FC0", Slot = "5")]
	public void CCNFLPILHDM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x80161A0", Offset = "0x80155A0", VA = "0x1880161A0", Slot = "6")]
	public void IJILPFOJMFP(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8016460", Offset = "0x8015860", VA = "0x188016460", Slot = "9")]
	public void PBHLOFGIOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8015FF0", Offset = "0x80153F0", VA = "0x188015FF0")]
	private void CJGMILNECCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8016210", Offset = "0x8015610", VA = "0x188016210")]
	private void LPOBFHMGKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x80161D0", Offset = "0x80155D0", VA = "0x1880161D0", Slot = "8")]
	public void JLJCMCIACCJ(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8015F80", Offset = "0x8015380", VA = "0x188015F80", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x801D510", Offset = "0x801C910", VA = "0x18801D510", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EICBMHINKNM DBLHHGBKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x801D1F0", Offset = "0x801C5F0", VA = "0x18801D1F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x801D2E0", Offset = "0x801C6E0", VA = "0x18801D2E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x801D600", Offset = "0x801CA00", VA = "0x18801D600")]
	public COAOEHBKJBN(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x801D2D0", Offset = "0x801C6D0", VA = "0x18801D2D0", Slot = "7")]
	public void MEGBKFPNHJD(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x801D290", Offset = "0x801C690", VA = "0x18801D290", Slot = "8")]
	public void JPLPJEDDEFM(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x801D400", Offset = "0x801C800", VA = "0x18801D400", Slot = "9")]
	public void NKLDDLODFLG(object HHGPJKKLNIG, bool HCLIPONIBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x801D5C0", Offset = "0x801C9C0", VA = "0x18801D5C0", Slot = "12")]
	public void OEGPFHAIAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x801D380", Offset = "0x801C780", VA = "0x18801D380", Slot = "10")]
	public void MIEOMMOBGJE(Rigidbody OIBOOLMLIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x801D2A0", Offset = "0x801C6A0", VA = "0x18801D2A0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BHFLGMJBADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x802C400", Offset = "0x802B800", VA = "0x18802C400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MLONIAAAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EICBMHINKNM JOPJCBEHOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x802BC60", Offset = "0x802B060", VA = "0x18802BC60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x802BF70", Offset = "0x802B370", VA = "0x18802BF70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x802C800", Offset = "0x802BC00", VA = "0x18802C800")]
	public PEJLJGGNJOB(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x802C160", Offset = "0x802B560", VA = "0x18802C160", Slot = "9")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x802BE70", Offset = "0x802B270", VA = "0x18802BE70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x802C690", Offset = "0x802BA90", VA = "0x18802C690", Slot = "10")]
	public void PBGKFOKDNBN(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x802C290", Offset = "0x802B690", VA = "0x18802C290", Slot = "11")]
	public void OICPBNFOKLK(BLDMDGLHGCG KLDFHLFOOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x802BD00", Offset = "0x802B100", VA = "0x18802BD00")]
	private void DDIFADMOJDA(PhotonView DJJKMLALGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x802C010", Offset = "0x802B410", VA = "0x18802C010")]
	private void KLLNKEGPKAA(FGIODNKADFN ILBJKPHCLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x802C420", Offset = "0x802B820", VA = "0x18802C420")]
	private void OPOIDGPNEHP(PhotonView EBIBDEDMEFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OPHJGCBEKNC
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x802BBA0", Offset = "0x802AFA0", VA = "0x18802BBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0E460", Offset = "0xA0D860", VA = "0x180A0E460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xC5D140", Offset = "0xC5C540", VA = "0x180C5D140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OECOLOCJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xC5C810", Offset = "0xC5BC10", VA = "0x180C5C810", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xC5D130", Offset = "0xC5C530", VA = "0x180C5D130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HGNBCLAGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x80290A0", Offset = "0x80284A0", VA = "0x1880290A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8029230", Offset = "0x8028630", VA = "0x188029230")]
	public MOOPAFEBPGI(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8029200", Offset = "0x8028600", VA = "0x188029200", Slot = "9")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x80291D0", Offset = "0x80285D0", VA = "0x1880291D0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0xE36A60", Offset = "0xE35E60", VA = "0x180E36A60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8029390", Offset = "0x8028790", VA = "0x188029390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float KOOFMHKLIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC8A4A0", VA = "0x180C8B0A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8029550", Offset = "0x8028950", VA = "0x188029550", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8029620", Offset = "0x8028A20", VA = "0x188029620")]
	public NNPJIOAAEBN(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8029500", Offset = "0x8028900", VA = "0x188029500", Slot = "8")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8029460", Offset = "0x8028860", VA = "0x188029460", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x8018E00", Offset = "0x8018200", VA = "0x188018E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8026070", Offset = "0x8025470", VA = "0x188026070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BLDMDGLHGCG HBBFFDLJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x80263A0", Offset = "0x80257A0", VA = "0x1880263A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8026770", Offset = "0x8025B70", VA = "0x188026770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EICBMHINKNM GBKGIKGPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8026400", Offset = "0x8025800", VA = "0x188026400", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8025F60", Offset = "0x8025360", VA = "0x188025F60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8026850", Offset = "0x8025C50", VA = "0x188026850")]
	public JFMKEEMANNC(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8026630", Offset = "0x8025A30", VA = "0x188026630", Slot = "6")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8026760", Offset = "0x8025B60", VA = "0x188026760", Slot = "8")]
	public void NBPEIGJBMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8026130", Offset = "0x8025530", VA = "0x188026130", Slot = "7")]
	public bool FFGLGDIECKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8026090", Offset = "0x8025490", VA = "0x188026090", Slot = "9")]
	public void EIPLMBFAJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x80266C0", Offset = "0x8025AC0", VA = "0x1880266C0", Slot = "13")]
	public void NACDKDDODFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8026280", Offset = "0x8025680", VA = "0x188026280", Slot = "12")]
	public void GLNCPHIAFJH(bool GPOLJOPKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8026000", Offset = "0x8025400", VA = "0x188026000", Slot = "10")]
	public bool BEMGGEBPPEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8025C20", Offset = "0x8025020", VA = "0x188025C20", Slot = "11")]
	public bool AHDEHEMHABF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8025CE0", Offset = "0x80250E0", VA = "0x188025CE0")]
	private bool AICJEDNAAIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x80264A0", Offset = "0x80258A0", VA = "0x1880264A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool KOLLEAGMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8016B00", Offset = "0x8015F00", VA = "0x188016B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OGHLPIEIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x16A83B0", Offset = "0x16A77B0", VA = "0x1816A83B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8016E90", Offset = "0x8016290", VA = "0x188016E90")]
	public BPBMOFHEFCJ(BLDMDGLHGCG LPNNCKGGDEC, [In] KDCCJFNCNKM HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8016A60", Offset = "0x8015E60", VA = "0x188016A60", Slot = "5")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8016840", Offset = "0x8015C40", VA = "0x188016840", Slot = "7")]
	public void GCBAHEBKPMO(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8016810", Offset = "0x8015C10", VA = "0x188016810", Slot = "8")]
	public void DALGMHHCMGK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8016B60", Offset = "0x8015F60", VA = "0x188016B60", Slot = "9")]
	public void OPAANLOFAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8016870", Offset = "0x8015C70", VA = "0x188016870", Slot = "10")]
	public void MGAEEGEBIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8016690", Offset = "0x8015A90", VA = "0x188016690", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MDELKDJPJMO LJPNJEDDINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 ODJMCKKDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x801C5D0", Offset = "0x801B9D0", VA = "0x18801C5D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x801C8E0", Offset = "0x801BCE0", VA = "0x18801C8E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GNLAPFBAHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8019C60", Offset = "0x8019060", VA = "0x188019C60", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8019C30", Offset = "0x8019030", VA = "0x188019C30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 CCOJCBMDALI
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8019A70", Offset = "0x8018E70", VA = "0x188019A70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x801A220", Offset = "0x8019620", VA = "0x18801A220", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 NIADJEHEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8019FE0", Offset = "0x80193E0", VA = "0x188019FE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x801C8B0", Offset = "0x801BCB0", VA = "0x18801C8B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float NGPMJBAEEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE3E9B0", Offset = "0xE3DDB0", VA = "0x180E3E9B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x801B740", Offset = "0x801AB40", VA = "0x18801B740", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MKGODOHPGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7DD0", Offset = "0x1FD71D0", VA = "0x181FD7DD0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PCIHJIDAFOL FGJPDEIDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7672F50", Offset = "0x7672350", VA = "0x187672F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PBPFEEGEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8019DE0", Offset = "0x80191E0", VA = "0x188019DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x801D100", Offset = "0x801C500", VA = "0x18801D100")]
	public CKAIAJAGCJD(BLDMDGLHGCG LPNNCKGGDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x801BCD0", Offset = "0x801B0D0", VA = "0x18801BCD0", Slot = "19")]
	public void MNNJMFNPKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8019E00", Offset = "0x8019200", VA = "0x188019E00", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x801C780", Offset = "0x801BB80", VA = "0x18801C780", Slot = "28")]
	public void MIEOMMOBGJE(Rigidbody HLIOIFKCLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x14AFFE0", Offset = "0x14AF3E0", VA = "0x1814AFFE0", Slot = "20")]
	public void JLFGJMOLNJL(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x14B0000", Offset = "0x14AF400", VA = "0x1814B0000", Slot = "30")]
	public void LLHOANOEIDI(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8019890", Offset = "0x8018C90", VA = "0x188019890", Slot = "35")]
	public Vector3 ADFPDAEBLKI(Vector3 FNHOFIFJKGL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x801A890", Offset = "0x8019C90", VA = "0x18801A890", Slot = "34")]
	public Vector3 IEDGBHBCANN(Vector3 PKMPKCGGDCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x801BCD0", Offset = "0x801B0D0", VA = "0x18801BCD0", Slot = "27")]
	public void KMOCPELJBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x801D040", Offset = "0x801C440", VA = "0x18801D040", Slot = "25")]
	public void OOAGCIMBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x801D0A0", Offset = "0x801C4A0", VA = "0x18801D0A0", Slot = "24")]
	public void PBHCEHPEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x801BF10", Offset = "0x801B310", VA = "0x18801BF10", Slot = "33")]
	public void LBPCOGEPHJA(Vector3 PONLMFMGCGE, Vector3 ENCDPIAPLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x801B550", Offset = "0x801A950", VA = "0x18801B550", Slot = "32")]
	public void KECDDBGCHMH(Vector3 HHKLHBJKBJH, Vector3 KPLENMNPPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x801A2E0", Offset = "0x80196E0", VA = "0x18801A2E0", Slot = "31")]
	public void EODLFCNONFH(Vector3 HHPBPILOIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x801C9A0", Offset = "0x801BDA0", VA = "0x18801C9A0", Slot = "22")]
	public void OEDAHHABPJD(PBBDJPMEPMG PGBABGJEBDH, Vector3 KCFFDKICILI, float MEICJJPGIHP, float FMDBMHHHJAB = 8f, float FINEFEOOKBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x801A610", Offset = "0x8019A10", VA = "0x18801A610", Slot = "21")]
	public void HMEFCOOCCJA(BJNFOPLFCIL HFENEBDLIJG, Vector3 LEDBBMALJPC, float LEENEGGNBFL = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x801C150", Offset = "0x801B550", VA = "0x18801C150", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LGNKHCCBCDE(BJNFOPLFCIL HFENEBDLIJG, Vector3 AJFJKBHPFHG, float MCHBFHBAGFM = 7f, float JKNNHDOKHHJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x15DF000", Offset = "0x15DE400", VA = "0x1815DF000")]
	private static void FGMOMKDPOAP(Vector3 GPBFPENHNGM, Vector3 BELINKGJHGO, [Out] Vector3 CMLOFINBEND, [Out] Vector3 HDBHGKKLLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x801AFF0", Offset = "0x801A3F0", VA = "0x18801AFF0", Slot = "29")]
	public Vector3 IOEDKKBEBPA(Vector3 GPBFPENHNGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x801B5B0", Offset = "0x801A9B0", VA = "0x18801B5B0", Slot = "26")]
	public void KEDOOOBMBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x801B740", Offset = "0x801AB40", VA = "0x18801B740")]
	private void KFENJAEKMFP(float FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x801BD70", Offset = "0x801B170", VA = "0x18801BD70")]
	private void LANEPCIAACP(Vector3 LEDBBMALJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8019E60", Offset = "0x8019260", VA = "0x188019E60")]
	private Vector3 EEBBGBINOEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x801B850", Offset = "0x801AC50", VA = "0x18801B850")]
	private void KLKDIGHICNB(Vector3 PKMPKCGGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x801A480", Offset = "0x8019880", VA = "0x18801A480")]
	private Vector3 FGOKNOFDKJK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x801B0D0", Offset = "0x801A4D0", VA = "0x18801B0D0")]
	private void JOLPEBMEHMM(Vector3 FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x801AA50", Offset = "0x8019E50", VA = "0x18801AA50")]
	private void IKGPIFNLGGO(Vector3 PKMPKCGGDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x801A170", Offset = "0x8019570", VA = "0x18801A170")]
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
