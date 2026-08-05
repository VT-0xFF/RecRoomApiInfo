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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9E00", Offset = "0x7BA9200", VA = "0x187BA9E00", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E06FF0", Offset = "0x1E063F0", VA = "0x181E06FF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BB67A0", Offset = "0x7BB5BA0", VA = "0x187BB67A0")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6AA0", Offset = "0x7BB5EA0", VA = "0x187BB6AA0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6B00", Offset = "0x7BB5F00", VA = "0x187BB6B00")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, DOJENFHJKGB, NFEDKEMNHKL, BNNAEHMNCPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IBCMILIKEJG OOPJJOPOLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DDKJPDBBMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ALGKOANMNJA DGAEKIFLAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[AICMCMODPDA(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AICMCMODPDA(KCNGGJNCENB.SelfAndParent, true, false, false)]
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
		private FALLENFFJHK physicsInterpolation;

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
		private Transform JFBBGIKFOBI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ALGKOANMNJA NBIHMNBOAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2110", Offset = "0x7BB1510", VA = "0x187BB2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ALGKOANMNJA DGDEFGEGLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KIIPMJCADCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3CB0", Offset = "0x7BB30B0", VA = "0x187BB3CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FJKLIKAMMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4010", Offset = "0x7BB3410", VA = "0x187BB4010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HAMMPINBCBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3F50", Offset = "0x7BB3350", VA = "0x187BB3F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LDIAONMHHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4C10", Offset = "0x7BB4010", VA = "0x187BB4C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6110", Offset = "0x7BB5510", VA = "0x187BB6110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7B7A640", Offset = "0x7B79A40", VA = "0x187B7A640", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C700", Offset = "0x7B7BB00", VA = "0x187B7C700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform EJNLPEDOMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1C48C10", Offset = "0x1C48010", VA = "0x181C48C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OBNPHIMIBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1C48C10", Offset = "0x1C48010", VA = "0x181C48C10", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IEAFPNGLCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1C48C10", Offset = "0x1C48010", VA = "0x181C48C10", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GPBDIJCMDDB IDGNDNBMKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3D10", Offset = "0x7BB3110", VA = "0x187BB3D10")]
			get
			{
				return default(GPBDIJCMDDB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB58C0", Offset = "0x7BB4CC0", VA = "0x187BB58C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BFGJHJKGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4320", Offset = "0x7BB3720", VA = "0x187BB4320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EGPMEMMIMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E30", Offset = "0x7BB3230", VA = "0x187BB3E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OPMGDNEPOAI APEKLIAHFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4260", Offset = "0x7BB3660", VA = "0x187BB4260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5A80", Offset = "0x7BB4E80", VA = "0x187BB5A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HHKIIOIPKEL JFPFGLNJMAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4200", Offset = "0x7BB3600", VA = "0x187BB4200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5A10", Offset = "0x7BB4E10", VA = "0x187BB5A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EFAJKHNIDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4150", Offset = "0x7BB3550", VA = "0x187BB4150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody EFGIGFEGANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BB41B0", Offset = "0x7BB35B0", VA = "0x187BB41B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NFOMOHIOLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3E90", Offset = "0x7BB3290", VA = "0x187BB3E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5930", Offset = "0x7BB4D30", VA = "0x187BB5930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DNABDOIEBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x13A8C40", Offset = "0x13A8040", VA = "0x1813A8C40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IIEANAFKKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4BB0", Offset = "0x7BB3FB0", VA = "0x187BB4BB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GLMFLGEIELN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4B50", Offset = "0x7BB3F50", VA = "0x187BB4B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BB60A0", Offset = "0x7BB54A0", VA = "0x187BB60A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float AOJLFKPPHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4580", Offset = "0x7BB3980", VA = "0x187BB4580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5D20", Offset = "0x7BB5120", VA = "0x187BB5D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NPJINIJDOIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4380", Offset = "0x7BB3780", VA = "0x187BB4380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5AF0", Offset = "0x7BB4EF0", VA = "0x187BB5AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IICABGONHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5160", Offset = "0x7BB4560", VA = "0x187BB5160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6650", Offset = "0x7BB5A50", VA = "0x187BB6650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 ABIGCEEDGFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4930", Offset = "0x7BB3D30", VA = "0x187BB4930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5E70", Offset = "0x7BB5270", VA = "0x187BB5E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 AFGAKBBGKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7BB52A0", Offset = "0x7BB46A0", VA = "0x187BB52A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode KNEHMJFBMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7BB44C0", Offset = "0x7BB38C0", VA = "0x187BB44C0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5C40", Offset = "0x7BB5040", VA = "0x187BB5C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float POMMCKJPGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3EF0", Offset = "0x7BB32F0", VA = "0x187BB3EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BB59A0", Offset = "0x7BB4DA0", VA = "0x187BB59A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints MPLKFGNDEDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4520", Offset = "0x7BB3920", VA = "0x187BB4520")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5CB0", Offset = "0x7BB50B0", VA = "0x187BB5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 IOELABKCDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4CD0", Offset = "0x7BB40D0", VA = "0x187BB4CD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 JAMGPAENPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4CD0", Offset = "0x7BB40D0", VA = "0x187BB4CD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6430", Offset = "0x7BB5830", VA = "0x187BB6430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float OPPJBCDKOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4A10", Offset = "0x7BB3E10", VA = "0x187BB4A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5F50", Offset = "0x7BB5350", VA = "0x187BB5F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PHCEMLFIAPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5100", Offset = "0x7BB4500", VA = "0x187BB5100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB65E0", Offset = "0x7BB59E0", VA = "0x187BB65E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion APHPDOAEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4DB0", Offset = "0x7BB41B0", VA = "0x187BB4DB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7BB61B0", Offset = "0x7BB55B0", VA = "0x187BB61B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion ELHCBGJDCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5030", Offset = "0x7BB4430", VA = "0x187BB5030")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6510", Offset = "0x7BB5910", VA = "0x187BB6510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ODKNMCDFNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4E80", Offset = "0x7BB4280", VA = "0x187BB4E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6280", Offset = "0x7BB5680", VA = "0x187BB6280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IBABBGFIAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4F60", Offset = "0x7BB4360", VA = "0x187BB4F60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7BB6360", Offset = "0x7BB5760", VA = "0x187BB6360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PGIPNLMJJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BB51C0", Offset = "0x7BB45C0", VA = "0x187BB51C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7BB66C0", Offset = "0x7BB5AC0", VA = "0x187BB66C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HGIAGFCHLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4A70", Offset = "0x7BB3E70", VA = "0x187BB4A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5FC0", Offset = "0x7BB53C0", VA = "0x187BB5FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 GNFIJOGHJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB43E0", Offset = "0x7BB37E0", VA = "0x187BB43E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5B60", Offset = "0x7BB4F60", VA = "0x187BB5B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 PMBLIKDJDDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4850", Offset = "0x7BB3C50", VA = "0x187BB4850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5D90", Offset = "0x7BB5190", VA = "0x187BB5D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MJODOEGLMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4710", Offset = "0x7BB3B10", VA = "0x187BB4710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion KMLKLHHAONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7BB4640", Offset = "0x7BB3A40", VA = "0x187BB4640")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 ELCFJGJNPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5460", Offset = "0x7BB4860", VA = "0x187BB5460")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 KJNCPIJEKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5380", Offset = "0x7BB4780", VA = "0x187BB5380")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FCBHBKAKIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7BB47F0", Offset = "0x7BB3BF0", VA = "0x187BB47F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MCIMPKMOLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7BB42C0", Offset = "0x7BB36C0", VA = "0x187BB42C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BFIFIOEMIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3DD0", Offset = "0x7BB31D0", VA = "0x187BB3DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KDNCHPOIPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3D70", Offset = "0x7BB3170", VA = "0x187BB3D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HFNDMANAEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3C50", Offset = "0x7BB3050", VA = "0x187BB3C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IKMPMKPFCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7BB45E0", Offset = "0x7BB39E0", VA = "0x187BB45E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KFMLNKJFEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x20CBAA0", Offset = "0x20CAEA0", VA = "0x1820CBAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PEAKMKHCICL EIPEDEOGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3B70", Offset = "0x7BB2F70", VA = "0x187BB3B70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB57E0", Offset = "0x7BB4BE0", VA = "0x187BB57E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PDAGHPCAEPO JMNJMHPELEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7BB38E0", Offset = "0x7BB2CE0", VA = "0x187BB38E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5540", Offset = "0x7BB4940", VA = "0x187BB5540")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PDAGHPCAEPO DCNDBKKAIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3940", Offset = "0x7BB2D40", VA = "0x187BB3940")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BB55B0", Offset = "0x7BB49B0", VA = "0x187BB55B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PDAGHPCAEPO IJCFEOLPONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3A90", Offset = "0x7BB2E90", VA = "0x187BB3A90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5700", Offset = "0x7BB4B00", VA = "0x187BB5700")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3A20", Offset = "0x7BB2E20", VA = "0x187BB3A20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5690", Offset = "0x7BB4A90", VA = "0x187BB5690")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PDAGHPCAEPO KKEBDCGNJKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3B00", Offset = "0x7BB2F00", VA = "0x187BB3B00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5770", Offset = "0x7BB4B70", VA = "0x187BB5770")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PDAGHPCAEPO IPDCHNHKBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB3BE0", Offset = "0x7BB2FE0", VA = "0x187BB3BE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5850", Offset = "0x7BB4C50", VA = "0x187BB5850")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PDAGHPCAEPO HIGJAJALGPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB39B0", Offset = "0x7BB2DB0", VA = "0x187BB39B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5620", Offset = "0x7BB4A20", VA = "0x187BB5620")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00", Slot = "8")]
		private void PHDJFCBGLAD(ALGKOANMNJA AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2480", Offset = "0x7BB1880", VA = "0x187BB2480", Slot = "9")]
		public OLOMKIEJIDK GetData()
		{
			return default(OLOMKIEJIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB28E0", Offset = "0x7BB1CE0", VA = "0x187BB28E0")]
		internal void NPIBHIOBABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3600", Offset = "0x7BB2A00", VA = "0x187BB3600")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OLLDADPKNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB21D0", Offset = "0x7BB15D0", VA = "0x187BB21D0")]
		public DOJENFHJKGB GetChild(int EAHKFAJBNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3260", Offset = "0x7BB2660", VA = "0x187BB3260")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1BE0", Offset = "0x7BB0FE0", VA = "0x187BB1BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB34F0", Offset = "0x7BB28F0", VA = "0x187BB34F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2110", Offset = "0x7BB1510", VA = "0x187BB2110")]
		private ALGKOANMNJA NCONEJJLEBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1DB0", Offset = "0x7BB11B0", VA = "0x187BB1DB0")]
		private void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2A30", Offset = "0x7BB1E30", VA = "0x187BB2A30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2970", Offset = "0x7BB1D70", VA = "0x187BB2970")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BB28E0", Offset = "0x7BB1CE0", VA = "0x187BB28E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BB29D0", Offset = "0x7BB1DD0", VA = "0x187BB29D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2A90", Offset = "0x7BB1E90", VA = "0x187BB2A90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BB11D0", Offset = "0x7BB05D0", VA = "0x187BB11D0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2AF0", Offset = "0x7BB1EF0", VA = "0x187BB2AF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BB20B0", Offset = "0x7BB14B0", VA = "0x187BB20B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2880", Offset = "0x7BB1C80", VA = "0x187BB2880")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BB33C0", Offset = "0x7BB27C0", VA = "0x187BB33C0")]
		public void SetParent(RigidbodyEx KBGCCIOIGBD, bool GAMHFCBCJBI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E00", Offset = "0x7BB2200", VA = "0x187BB2E00")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2510", Offset = "0x7BB1910", VA = "0x187BB2510")]
		public bool IsRigidbodyAncestor(RigidbodyEx HENCFIBHGPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2610", Offset = "0x7BB1A10", VA = "0x187BB2610")]
		public bool IsRigidbodyDescendant(RigidbodyEx AKGDAPECEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1440", Offset = "0x7BB0840", VA = "0x187BB1440")]
		public void AddInterpolationRestriction(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2B60", Offset = "0x7BB1F60", VA = "0x187BB2B60")]
		public void RemoveInterpolationRestriction(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB14B0", Offset = "0x7BB08B0", VA = "0x187BB14B0")]
		public void AddKinematic(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2BD0", Offset = "0x7BB1FD0", VA = "0x187BB2BD0")]
		public void RemoveKinematic(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3340", Offset = "0x7BB2740", VA = "0x187BB3340")]
		public void SetKinematic(object LAAJFAFNFCN, bool OCMDPMDMEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3160", Offset = "0x7BB2560", VA = "0x187BB3160")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NMOENKJNINF, Quaternion GJHDMIEGGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3060", Offset = "0x7BB2460", VA = "0x187BB3060")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EKNIMOGELNJ, Quaternion MPPGEACKGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2370", Offset = "0x7BB1770", VA = "0x187BB2370")]
		public Vector3 GetConstrainedVelocity(Vector3 PGIPNLMJJCH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2260", Offset = "0x7BB1660", VA = "0x187BB2260")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 GNFIJOGHJJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1350", Offset = "0x7BB0750", VA = "0x187BB1350")]
		public void AddForce(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1240", Offset = "0x7BB0640", VA = "0x187BB1240")]
		public void AddForceAtPosition(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1680", Offset = "0x7BB0A80", VA = "0x187BB1680")]
		public void AddTorque(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1520", Offset = "0x7BB0920", VA = "0x187BB1520")]
		public void AddRelativeTorque(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BB36D0", Offset = "0x7BB2AD0", VA = "0x187BB36D0")]
		public Vector3 WorldToLocalVelocity(Vector3 DBLIJGKPLMN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2770", Offset = "0x7BB1B70", VA = "0x187BB2770")]
		public Vector3 LocalToWorldVelocity(Vector3 HGIAGFCHLPB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2050", Offset = "0x7BB1450", VA = "0x187BB2050")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1FF0", Offset = "0x7BB13F0", VA = "0x187BB1FF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1F90", Offset = "0x7BB1390", VA = "0x187BB1F90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1F30", Offset = "0x7BB1330", VA = "0x187BB1F30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2F60", Offset = "0x7BB2360", VA = "0x187BB2F60")]
		public void ResetVelocityWorldSpace(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E60", Offset = "0x7BB2260", VA = "0x187BB2E60")]
		public void ResetVelocityLocalSpace(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2D20", Offset = "0x7BB2120", VA = "0x187BB2D20")]
		public void ResetLinearVelocityLocalSpace(Vector3 AFAALGOINNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3500", Offset = "0x7BB2900", VA = "0x187BB3500")]
		public bool SweepTest(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2710", Offset = "0x7BB1B10", VA = "0x187BB2710")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3490", Offset = "0x7BB2890", VA = "0x187BB3490")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3670", Offset = "0x7BB2A70", VA = "0x187BB3670")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1610", Offset = "0x7BB0A10", VA = "0x187BB1610")]
		public void AddShouldHaveUnityRigidbodyToken(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2C40", Offset = "0x7BB2040", VA = "0x187BB2C40")]
		public void RemoveShouldHaveUnityRigidbodyToken(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1A10", Offset = "0x7BB0E10", VA = "0x187BB1A10")]
		public void ApplyForceVelocityChange(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1910", Offset = "0x7BB0D10", VA = "0x187BB1910")]
		public void ApplyAngularVelocityChange(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1AD0", Offset = "0x7BB0ED0", VA = "0x187BB1AD0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1840", Offset = "0x7BB0C40", VA = "0x187BB1840")]
		public bool AllowedScaleChange(float AJFLFDACHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1770", Offset = "0x7BB0B70", VA = "0x187BB1770")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx ANNFJIHMGGG, object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2CB0", Offset = "0x7BB20B0", VA = "0x187BB2CB0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB21C0", Offset = "0x7BB15C0", VA = "0x187BB21C0", Slot = "12")]
		private void EGJMLFHHLME(DBGGEFBGBDL BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB3870", Offset = "0x7BB2C70", VA = "0x187BB3870")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D350", Offset = "0xA5C750", VA = "0x180A5D350", Slot = "4")]
		private GameObject MNLDCPAIODF()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x976B50", Offset = "0x975F50", VA = "0x180976B50", Slot = "10")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class ENILHHCNJLG
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA16E0", Offset = "0x7BA0AE0", VA = "0x187BA16E0")]
	public static ALGKOANMNJA NBIHMNBOAEA(this RigidbodyEx AMDJMIBOJED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(FFKDIAAHIOB), new string[] { })]
public class FHJKEHCNIGN : FFKDIAAHIOB, GMBJCCNEDOA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NMDEHMBBDLG MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MEJIGNOFMAH MNKIHKKHLKM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NMDEHMBBDLG MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MEJIGNOFMAH EEHLNOJBBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA29C0", Offset = "0x7BA1DC0", VA = "0x187BA29C0", Slot = "7")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA27F0", Offset = "0x7BA1BF0", VA = "0x187BA27F0", Slot = "6")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FHJKEHCNIGN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static FKDOIPNGGAF UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HAGPOEIHNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int PPDICOMJNIJ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1030", Offset = "0x7BB0430", VA = "0x187BB1030")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1070", Offset = "0x7BB0470", VA = "0x187BB1070")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1050", Offset = "0x7BB0450", VA = "0x187BB1050")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string MIALAMIFNLM, [Optional] UnityEngine.Object BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string MIALAMIFNLM, [Optional] UnityEngine.Object BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB1180", Offset = "0x7BB0580", VA = "0x187BB1180")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CFBBMONHKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IHGENAHHKOH : OPMGDNEPOAI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x95AB80", Offset = "0x959F80", VA = "0x18095AB80", Slot = "4")]
		public Vector3 LIDPKMGBHFK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x95AB80", Offset = "0x959F80", VA = "0x18095AB80", Slot = "5")]
		public Vector3 HMPAHDJCAJF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "6")]
		public bool LOAHDELBHEB(float OAJECFFFKCD, float OPIKHPHPKLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IHGENAHHKOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OPMGDNEPOAI GELNJJKINLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0770", Offset = "0x7B9FB70", VA = "0x187BA0770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGPDLEDPGHD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode HAFEJEBADGB
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
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIFEOPLDOFA(bool FCBHBKAKIGO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFAHPBKDGLO(bool FCBHBKAKIGO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MNIFLAKIKFD : IDisposable, BOJOEJKGENO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GPBDIJCMDDB IDGNDNBMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEGNBCCGJEM();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface MEJIGNOFMAH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HNAPDNDPDEC
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCBPOCEDEKA(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OECNNFBAOPC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PNKJPKBKDJE
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
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHBBPCHJGOC(Rigidbody JAPHJPDIABO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HFPCMCDIGDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ALGKOANMNJA> AFEPIFHKMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PDAGHPCAEPO JMNJMHPELEN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PDAGHPCAEPO DCNDBKKAIHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PEAKMKHCICL CHGIDFLHNNP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PCBDMKIAEGP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LILBICELHPA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ALGKOANMNJA> EPDOGELDIEF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ALGKOANMNJA> FOBPLFCKGBB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action HGAJECLCBLM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ALGKOANMNJA> BDDMLCJHKBM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PDMHANMAJFJ(ALGKOANMNJA DFDGPBFKIGC, bool GAMHFCBCJBI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JPBCNBPDNII
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHNCEMIGEMO(ALGKOANMNJA LDIAONMHHPK, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBFOEHMHJLL(object LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NEGEFAGJMPC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 KOANBGPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PDAGHPCAEPO OBABFJNKMAK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KOIKIBIHFIN();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFHAHFFIBGO();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HPCMKGLGOFK();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PHBBPCHJGOC(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FPFPICGMACE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NMKEJPNDHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPOLAKLIPNH(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLEIILMBFHD(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJLKKIAJPNI(ALGKOANMNJA AMDJMIBOJED);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EHGBOAJBFNF(ALGKOANMNJA AMDJMIBOJED);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CELBMMGMGLA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MPDKEAHEBIN
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PDAGHPCAEPO MEOEMMEMNAM;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFNOFHOCLDI(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEFJJODOBMP(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CPBGHEOJGIH(Rigidbody HFMGHKAPEPN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHBBPCHJGOC(Rigidbody JAPHJPDIABO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NOKJKNKOCID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PDAGHPCAEPO DCJADKAAFCA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLLDKAONAAD(ALGKOANMNJA LDIAONMHHPK);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void POKHBIJHKFC(ALGKOANMNJA LDIAONMHHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LDLGKDDJEDN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NFOMOHIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DFKMHMKEPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints LCLBBGJJKEL
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
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHBBPCHJGOC(Rigidbody JAPHJPDIABO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBHLGAFNGFA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float DBCBEFOFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PFCBECDMHDJ
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
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHBBPCHJGOC(Rigidbody JAPHJPDIABO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GHPGCABFHCD
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool LKBMKKICADF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PDAGHPCAEPO LCGOPILANPJ;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMIKMKKIIKN();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PALFGIPOJAO();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIIIELNBPIF();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFMMEKFFJEP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DDBCJGGLELC();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGIGJFPHGFA(bool JNPMBCFKKND);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHACHHIJHKA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HLOIJECJGIM
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ECIIKGAPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLDEHJLFKFN(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBAOIBANCHE(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNMNONHOMCM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CBHHLDALOCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	OPMGDNEPOAI APEKLIAHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AEGNBCCGJEM();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KMFINJOGAMG(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NJADJDABIDO();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EJOHHKODEHE();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PEPAHFAOHLH();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EDJHAMEFIIB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CPBGHEOJGIH(Rigidbody JAPHJPDIABO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PHAGPDAFEDM(Vector3 PGIPNLMJJCH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EFPPDPPKOLG(object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GEGDBMJAFCD(Vector3 MJMCMBGBGHN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface NMDEHMBBDLG
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DKDKPMLLNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFGELCAPEBH(string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EDKOAAKGLHG(RigidbodyEx AMDJMIBOJED, Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HIMACGGEFAK EHNEALAIGLI(int AKEABKFDOFG);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMPNKEOCNGL(Vector3 AFGAKBBGKJM, float CKGCFLBICAB, Color NHCBHMJDLHA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface FFKDIAAHIOB
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NMDEHMBBDLG MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	MEJIGNOFMAH EEHLNOJBBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NFCFPGHPKJP : ALGKOANMNJA, IDisposable, JAPKCJCIDCN
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool PDCLHPDAOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly FFKDIAAHIOB JEIEGFHFIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HFPCMCDIGDG PNMHGOHNFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NMKEJPNDHIN PADEEHMDIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal NOKJKNKOCID LLDKBOFNBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal CBHHLDALOCI PGIPNLMJJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal JPBCNBPDNII FLHEFCNMOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal NEGEFAGJMPC IDODKPLKAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal CBHLGAFNGFA JJBENFCADAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal OECNNFBAOPC LDDKKDHBHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal GHPGCABFHCD MBJMPLFOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal MNIFLAKIKFD NFEABLAIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal MPDKEAHEBIN EGJBPCIKFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal HNAPDNDPDEC MHOOEDPKADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal LDLGKDDJEDN PFBPLOAMLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HLOIJECJGIM JAPHJPDIABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal MGPDLEDPGHD OPNFJHJIJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable DEJOMLDNLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool FNNLHNJJEBF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public FHNHGOPNICC HHDEJABBJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "22")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public DOJENFHJKGB ABOOBHLFACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xCDF050", Offset = "0xCDE450", VA = "0x180CDF050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x94E950", Offset = "0x94DD50", VA = "0x18094E950", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x94E910", Offset = "0x94DD10", VA = "0x18094E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF2030", VA = "0x180CF2C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEA70", Offset = "0x7BADE70", VA = "0x187BAEA70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB830", Offset = "0x7BAAC30", VA = "0x187BAB830", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD160", Offset = "0x7BAC560", VA = "0x187BAD160", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KIIPMJCADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB07A0", Offset = "0x7BAFBA0", VA = "0x187BB07A0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7BAAAE0", Offset = "0x7BA9EE0", VA = "0x187BAAAE0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BABB70", Offset = "0x7BAAF70", VA = "0x187BABB70", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0EB0", Offset = "0x7BB02B0", VA = "0x187BB0EB0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE9C0", Offset = "0x7BADDC0", VA = "0x187BAE9C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public OPMGDNEPOAI APEKLIAHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7BACF90", Offset = "0x7BAC390", VA = "0x187BACF90", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE3A0", Offset = "0x7BAD7A0", VA = "0x187BAE3A0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEB30", Offset = "0x7BADF30", VA = "0x187BAEB30", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD910", Offset = "0x7BACD10", VA = "0x187BAD910", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD580", Offset = "0x7BAC980", VA = "0x187BAD580", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB1C0", Offset = "0x7BAA5C0", VA = "0x187BAB1C0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7BADF80", Offset = "0x7BAD380", VA = "0x187BADF80", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD7E0", Offset = "0x7BACBE0", VA = "0x187BAD7E0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFCC0", Offset = "0x7BAF0C0", VA = "0x187BAFCC0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFF00", Offset = "0x7BAF300", VA = "0x187BAFF00", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF6F0", Offset = "0x7BAEAF0", VA = "0x187BAF6F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE7A0", Offset = "0x7BADBA0", VA = "0x187BAE7A0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0810", Offset = "0x7BAFC10", VA = "0x187BB0810", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7BABA90", Offset = "0x7BAAE90", VA = "0x187BABA90", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BFIFIOEMIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF5F0", Offset = "0x7BAE9F0", VA = "0x187BAF5F0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KDNCHPOIPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF7D0", Offset = "0x7BAEBD0", VA = "0x187BAF7D0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool HFNDMANAEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF460", Offset = "0x7BAE860", VA = "0x187BAF460", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC880", Offset = "0x7BABC80", VA = "0x187BAC880", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BABBD0", Offset = "0x7BAAFD0", VA = "0x187BABBD0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD700", Offset = "0x7BACB00", VA = "0x187BAD700", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 KOANBGPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD970", Offset = "0x7BACD70", VA = "0x187BAD970", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFA60", Offset = "0x7BAEE60", VA = "0x187BAFA60", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC120", Offset = "0x7BAB520", VA = "0x187BAC120", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB520", Offset = "0x7BAA920", VA = "0x187BAB520", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BACCF0", Offset = "0x7BAC0F0", VA = "0x187BACCF0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BABFF0", Offset = "0x7BAB3F0", VA = "0x187BABFF0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE8E0", Offset = "0x7BADCE0", VA = "0x187BAE8E0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC050", Offset = "0x7BAB450", VA = "0x187BAC050", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float DBCBEFOFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0A20", Offset = "0x7BAFE20", VA = "0x187BB0A20", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE280", Offset = "0x7BAD680", VA = "0x187BAE280", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PFCBECDMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFDA0", Offset = "0x7BAF1A0", VA = "0x187BAFDA0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEA10", Offset = "0x7BADE10", VA = "0x187BAEA10", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PNKJPKBKDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF540", Offset = "0x7BAE940", VA = "0x187BAF540", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB880", Offset = "0x7BAAC80", VA = "0x187BAB880", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GPBDIJCMDDB IDGNDNBMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD8C0", Offset = "0x7BACCC0", VA = "0x187BAD8C0", Slot = "70")]
		get
		{
			return default(GPBDIJCMDDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF910", Offset = "0x7BAED10", VA = "0x187BAF910", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFFE0", Offset = "0x7BAF3E0", VA = "0x187BAFFE0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IEAFPNGLCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 LEEAOGLADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BACC40", Offset = "0x7BAC040", VA = "0x187BACC40", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD2A0", Offset = "0x7BAC6A0", VA = "0x187BAD2A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JBJGLOCLKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE190", Offset = "0x7BAD590", VA = "0x187BAE190", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEFD0", Offset = "0x7BAE3D0", VA = "0x187BAEFD0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float BBPBPOAPNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEB20", Offset = "0x7BADF20", VA = "0x187BAEB20", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE6C0", Offset = "0x7BADAC0", VA = "0x187BAE6C0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion PEKONLBNMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE620", Offset = "0x7BADA20", VA = "0x187BAE620", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE4F0", Offset = "0x7BAD8F0", VA = "0x187BAE4F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB180", Offset = "0x7BAA580", VA = "0x187BAB180", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF0A0", Offset = "0x7BAE4A0", VA = "0x187BAF0A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion NDNJPIJMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB5C0", Offset = "0x7BAA9C0", VA = "0x187BAB5C0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF830", Offset = "0x7BAEC30", VA = "0x187BAF830", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints LCLBBGJJKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEBD0", Offset = "0x7BADFD0", VA = "0x187BAEBD0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF400", Offset = "0x7BAE800", VA = "0x187BAF400", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NFOMOHIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC600", Offset = "0x7BABA00", VA = "0x187BAC600", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC470", Offset = "0x7BAB870", VA = "0x187BAC470", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode HAFEJEBADGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF350", Offset = "0x7BAE750", VA = "0x187BAF350", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0740", Offset = "0x7BAFB40", VA = "0x187BB0740", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB330", Offset = "0x7BAA730", VA = "0x187BAB330", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MCIMPKMOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BACFE0", Offset = "0x7BAC3E0", VA = "0x187BACFE0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PDAGHPCAEPO JMNJMHPELEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE490", Offset = "0x7BAD890", VA = "0x187BAE490", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEAC0", Offset = "0x7BADEC0", VA = "0x187BAEAC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PDAGHPCAEPO DCNDBKKAIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC8D0", Offset = "0x7BABCD0", VA = "0x187BAC8D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE2E0", Offset = "0x7BAD6E0", VA = "0x187BAE2E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PEAKMKHCICL CHGIDFLHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA960", Offset = "0x7BA9D60", VA = "0x187BAA960", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF590", Offset = "0x7BAE990", VA = "0x187BAF590", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PDAGHPCAEPO DCJADKAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0120", Offset = "0x7BAF520", VA = "0x187BB0120", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF3A0", Offset = "0x7BAE7A0", VA = "0x187BAF3A0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PDAGHPCAEPO IJCFEOLPONG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB08F0", Offset = "0x7BAFCF0", VA = "0x187BB08F0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BACEE0", Offset = "0x7BAC2E0", VA = "0x187BACEE0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PDAGHPCAEPO LCGOPILANPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF8B0", Offset = "0x7BAECB0", VA = "0x187BAF8B0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB0180", Offset = "0x7BAF580", VA = "0x187BB0180", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC3B0", Offset = "0x7BAB7B0", VA = "0x187BAC3B0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE340", Offset = "0x7BAD740", VA = "0x187BAE340", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PDAGHPCAEPO MEOEMMEMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BADF20", Offset = "0x7BAD320", VA = "0x187BADF20", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB7D0", Offset = "0x7BAABD0", VA = "0x187BAB7D0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PDAGHPCAEPO HIGJAJALGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB470", Offset = "0x7BAA870", VA = "0x187BAB470", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BACD40", Offset = "0x7BAC140", VA = "0x187BACD40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0F40", Offset = "0x7BB0340", VA = "0x187BB0F40")]
	public NFCFPGHPKJP(GameObject HHDLNMHBJJD, RigidbodyEx BLKFLPPAAFI, FFKDIAAHIOB JEIEGFHFIPA, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BAEC20", Offset = "0x7BAE020", VA = "0x187BAEC20", Slot = "139")]
	protected virtual void LADCGODDCBD(FFKDIAAHIOB JEIEGFHFIPA, OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC200", Offset = "0x7BAB600", VA = "0x187BAC200", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA820", Offset = "0x7BA9C20", VA = "0x187BAA820", Slot = "93")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFDF0", Offset = "0x7BAF1F0", VA = "0x187BAFDF0", Slot = "94")]
	public void OMNCAKKNONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE880", Offset = "0x7BADC80", VA = "0x187BAE880", Slot = "95")]
	public void KEEBHJFCMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA9C0", Offset = "0x7BA9DC0", VA = "0x187BAA9C0", Slot = "96")]
	public void AOOFEJBFDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7BABCA0", Offset = "0x7BAB0A0", VA = "0x187BABCA0")]
	private void DGIGJFPHGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFE80", Offset = "0x7BAF280", VA = "0x187BAFE80")]
	private void ONNEKCLEOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7BABA30", Offset = "0x7BAAE30", VA = "0x187BABA30")]
	private void DDBCJGGLELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7BACDF0", Offset = "0x7BAC1F0", VA = "0x187BACDF0", Slot = "30")]
	public ALGKOANMNJA FODDECJFNCE(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0370", Offset = "0x7BAF770", VA = "0x187BB0370", Slot = "98")]
	public void PDMHANMAJFJ(ALGKOANMNJA KBGCCIOIGBD, bool GAMHFCBCJBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF640", Offset = "0x7BAEA40", VA = "0x187BAF640", Slot = "99")]
	public void MMKPBALBOBB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7BB01E0", Offset = "0x7BAF5E0", VA = "0x187BB01E0", Slot = "100")]
	public void PAMIHHDAFMA(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA9E0", Offset = "0x7BA9DE0", VA = "0x187BAA9E0", Slot = "101")]
	public Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC780", Offset = "0x7BABB80", VA = "0x187BAC780", Slot = "102")]
	public Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC360", Offset = "0x7BAB760", VA = "0x187BAC360", Slot = "103")]
	public void EDJHAMEFIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC730", Offset = "0x7BABB30", VA = "0x187BAC730", Slot = "104")]
	public void EJOHHKODEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF860", Offset = "0x7BAEC60", VA = "0x187BAF860", Slot = "105")]
	public void NJADJDABIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0030", Offset = "0x7BAF430", VA = "0x187BB0030", Slot = "106")]
	public void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF970", Offset = "0x7BAED70", VA = "0x187BAF970", Slot = "107")]
	public void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD1C0", Offset = "0x7BAC5C0", VA = "0x187BAD1C0", Slot = "108")]
	public void GEGDBMJAFCD(Vector3 MJMCMBGBGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BAEF10", Offset = "0x7BAE310", VA = "0x187BAEF10", Slot = "109")]
	public void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD350", Offset = "0x7BAC750", VA = "0x187BAD350", Slot = "110")]
	public void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0430", Offset = "0x7BAF830", VA = "0x187BB0430", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0640", Offset = "0x7BAFA40", VA = "0x187BB0640", Slot = "112")]
	public Vector3 PHAGPDAFEDM(Vector3 KBGCCIOIGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0540", Offset = "0x7BAF940", VA = "0x187BB0540", Slot = "113")]
	public Vector3 PGECOLEOIDJ(Vector3 KBGCCIOIGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BB03E0", Offset = "0x7BAF7E0", VA = "0x187BB03E0", Slot = "114")]
	public void PEPAHFAOHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF2E0", Offset = "0x7BAE6E0", VA = "0x187BAF2E0", Slot = "115")]
	public void LKGIAHIOKLN(ALGKOANMNJA ANNFJIHMGGG, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BACA30", Offset = "0x7BABE30", VA = "0x187BACA30", Slot = "116")]
	public void ENLMECHGGAL(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE1A0", Offset = "0x7BAD5A0", VA = "0x187BAE1A0", Slot = "63")]
	public void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB570", Offset = "0x7BAA970", VA = "0x187BAB570", Slot = "117")]
	public void CFHAHFFIBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BAEB80", Offset = "0x7BADF80", VA = "0x187BAEB80", Slot = "118")]
	public void KOIKIBIHFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE060", Offset = "0x7BAD460", VA = "0x187BAE060", Slot = "119")]
	public void HPCMKGLGOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD450", Offset = "0x7BAC850", VA = "0x187BAD450", Slot = "120")]
	public bool GMIKMKKIIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE5D0", Offset = "0x7BAD9D0", VA = "0x187BAE5D0", Slot = "97")]
	public void JIIIELNBPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFC50", Offset = "0x7BAF050", VA = "0x187BAFC50", Slot = "121")]
	public void OHACHHIJHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF040", Offset = "0x7BAE440", VA = "0x187BAF040", Slot = "122")]
	public void LFNOFHOCLDI(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC410", Offset = "0x7BAB810", VA = "0x187BAC410", Slot = "123")]
	public void EEFJJODOBMP(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BACE70", Offset = "0x7BAC270", VA = "0x187BACE70", Slot = "124")]
	public void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF0E0", Offset = "0x7BAE4E0", VA = "0x187BAF0E0", Slot = "125")]
	public void LHBJMNBGGEB(Vector3 NMOENKJNINF, Quaternion GJHDMIEGGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0240", Offset = "0x7BAF640", VA = "0x187BB0240", Slot = "126")]
	public void PDJDLOAJIPC(Vector3 EKNIMOGELNJ, Quaternion MPPGEACKGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF6A0", Offset = "0x7BAEAA0", VA = "0x187BAF6A0", Slot = "127")]
	public bool MOKCDOPFMIO(float AJFLFDACHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BADA50", Offset = "0x7BACE50", VA = "0x187BADA50", Slot = "128")]
	public void HHMPELEDFFM(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB770", Offset = "0x7BAAB70", VA = "0x187BAB770", Slot = "129")]
	public void CKHCOJLGKJB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BADEC0", Offset = "0x7BAD2C0", VA = "0x187BADEC0", Slot = "130")]
	public void HLDEHJLFKFN(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC300", Offset = "0x7BAB700", VA = "0x187BAC300", Slot = "131")]
	public void EBAOIBANCHE(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC650", Offset = "0x7BABA50", VA = "0x187BAC650", Slot = "132")]
	public void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFB40", Offset = "0x7BAEF40", VA = "0x187BAFB40", Slot = "133")]
	public void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BAE0B0", Offset = "0x7BAD4B0", VA = "0x187BAE0B0", Slot = "134")]
	public void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BAAEB0", Offset = "0x7BAA2B0", VA = "0x187BAAEB0", Slot = "135")]
	public void BCBPOCEDEKA(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC930", Offset = "0x7BABD30", VA = "0x187BAC930", Slot = "136")]
	public bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BACF40", Offset = "0x7BAC340", VA = "0x187BACF40", Slot = "137")]
	public void FPFPICGMACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0F00", Offset = "0x7BB0300", VA = "0x187BB0F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD4A0", Offset = "0x7BAC8A0", VA = "0x187BAD4A0")]
	private void GNEHOOEEBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB220", Offset = "0x7BAA620", VA = "0x187BAB220")]
	private void BHEBIJCIPLH(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BAAF90", Offset = "0x7BAA390", VA = "0x187BAAF90")]
	private void BDJADPDHIPF(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BADAB0", Offset = "0x7BACEB0", VA = "0x187BADAB0")]
	private void HIPPFLFBOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BAD5D0", Offset = "0x7BAC9D0", VA = "0x187BAD5D0")]
	private void HBCMHHOJJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BACA90", Offset = "0x7BABE90", VA = "0x187BACA90")]
	private void ENMGMKIBMGN(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BABF20", Offset = "0x7BAB320", VA = "0x187BABF20")]
	private void DLLDKAONAAD(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0950", Offset = "0x7BAFD50", VA = "0x187BB0950")]
	private void POKHBIJHKFC(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB8E0", Offset = "0x7BAACE0", VA = "0x187BAB8E0")]
	private void DCIFNNNJAPH(DOJENFHJKGB LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0A70", Offset = "0x7BAFE70", VA = "0x187BB0A70", Slot = "142")]
	protected virtual void POOENMAFAMA(DOJENFHJKGB AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BADB60", Offset = "0x7BACF60", VA = "0x187BADB60")]
	protected void HKILALOAMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BAAB30", Offset = "0x7BA9F30", VA = "0x187BAAB30")]
	protected void BBPCMDFMHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BAC4D0", Offset = "0x7BAB8D0", VA = "0x187BAC4D0")]
	private void EIDNAKJLAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB600", Offset = "0x7BAAA00", VA = "0x187BAB600")]
	private void CJNHEOEFGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class IEIIFLMBMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6BE0", Offset = "0x7BA5FE0", VA = "0x187BA6BE0")]
	public static ALGKOANMNJA HMPLIGKAHJF(this ALGKOANMNJA AMDJMIBOJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6CA0", Offset = "0x7BA60A0", VA = "0x187BA6CA0")]
	public static bool IBEPPNDMEIP(this ALGKOANMNJA AMDJMIBOJED, ALGKOANMNJA HENCFIBHGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6AC0", Offset = "0x7BA5EC0", VA = "0x187BA6AC0")]
	public static bool CEJKJIMBLOM(this ALGKOANMNJA AMDJMIBOJED, ALGKOANMNJA AKGDAPECEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6D40", Offset = "0x7BA6140", VA = "0x187BA6D40")]
	public static DOJENFHJKGB NCGFHGFAAHB(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6B60", Offset = "0x7BA5F60", VA = "0x187BA6B60")]
	public static NFCFPGHPKJP FFAMOGBNMDJ(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DBECPJDNILJ : MEJIGNOFMAH
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F90", Offset = "0x7BA0390", VA = "0x187BA0F90", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public DBECPJDNILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "18")]
	private LDLGKDDJEDN IHBCKBGEILD(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(MEJIGNOFMAH), new string[] { })]
public class BBAPPCBKANO : MEJIGNOFMAH, GMBJCCNEDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MEJIGNOFMAH MBEPDNCJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MEJIGNOFMAH NBECHPHNOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PEPCDDOCDNO BEMCOKKNHBO;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private MEJIGNOFMAH EEHLNOJBBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA03C0", Offset = "0x7B9F7C0", VA = "0x187BA03C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0180", Offset = "0x7B9F580", VA = "0x187BA0180", Slot = "20")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0320", Offset = "0x7B9F720", VA = "0x187BA0320", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FAF0", Offset = "0x7B9EEF0", VA = "0x187B9FAF0", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FA50", Offset = "0x7B9EE50", VA = "0x187B9FA50", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7BA00E0", Offset = "0x7B9F4E0", VA = "0x187BA00E0", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FD90", Offset = "0x7B9F190", VA = "0x187B9FD90", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0280", Offset = "0x7B9F680", VA = "0x187BA0280", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0560", Offset = "0x7B9F960", VA = "0x187BA0560", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0420", Offset = "0x7B9F820", VA = "0x187BA0420", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7BA04C0", Offset = "0x7B9F8C0", VA = "0x187BA04C0", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FB90", Offset = "0x7B9EF90", VA = "0x187B9FB90", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7BA01D0", Offset = "0x7B9F5D0", VA = "0x187BA01D0")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FCE0", Offset = "0x7B9F0E0", VA = "0x187B9FCE0")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0030", Offset = "0x7B9F430", VA = "0x187BA0030")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FF80", Offset = "0x7B9F380", VA = "0x187B9FF80")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FC30", Offset = "0x7B9F030", VA = "0x187B9FC30")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FE30", Offset = "0x7B9F230", VA = "0x187B9FE30", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0600", Offset = "0x7B9FA00", VA = "0x187BA0600")]
	public BBAPPCBKANO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA01D0", Offset = "0x7B9F5D0", VA = "0x187BA01D0", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FCE0", Offset = "0x7B9F0E0", VA = "0x187B9FCE0", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0030", Offset = "0x7B9F430", VA = "0x187BA0030", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FF80", Offset = "0x7B9F380", VA = "0x187B9FF80", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FC30", Offset = "0x7B9F030", VA = "0x187B9FC30", Slot = "18")]
	private LDLGKDDJEDN IHBCKBGEILD(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HFLPIHNBNBH : HFPCMCDIGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCMEIMELBLA(ALGKOANMNJA AMDJMIBOJED);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCPCDKKDOMN(ALGKOANMNJA AMDJMIBOJED);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKHEFLJIIBD(ALGKOANMNJA FIHALPBMNML);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFBKCOABFBF(ALGKOANMNJA FIHALPBMNML);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DLMJHKGNACE : JPBCNBPDNII
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	JLDABEMCGKB<ALGKOANMNJA> FEEEJEGJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ALGKOANMNJA PNAILCLDKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JOLMOJAEINA : NEGEFAGJMPC
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JPCDLJJOAAI(Rigidbody IIKDCJPONNB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BCOHMJJAODE : NOKJKNKOCID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView AFFLOGFACDF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CPMEOLLNAEC : MGPDLEDPGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode ILCMKGGAAMD;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0D30", Offset = "0x7BA0130", VA = "0x187BA0D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode HAFEJEBADGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0D80", Offset = "0x7BA0180", VA = "0x187BA0D80", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0E90", Offset = "0x7BA0290", VA = "0x187BA0E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F00", Offset = "0x7BA0300", VA = "0x187BA0F00")]
	public CPMEOLLNAEC(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0900", Offset = "0x7B9FD00", VA = "0x187BA0900", Slot = "6")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0A30", Offset = "0x7B9FE30", VA = "0x187BA0A30", Slot = "9")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0A20", Offset = "0x7B9FE20", VA = "0x187BA0A20", Slot = "7")]
	public void BIFEOPLDOFA(bool FCBHBKAKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0A10", Offset = "0x7B9FE10", VA = "0x187BA0A10", Slot = "8")]
	public void BFAHPBKDGLO(bool FCBHBKAKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0AB0", Offset = "0x7B9FEB0", VA = "0x187BA0AB0", Slot = "10")]
	public bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0C10", Offset = "0x7BA0010", VA = "0x187BA0C10")]
	private void KHJJDFAGMIK(bool FCBHBKAKIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NBGHDAPJEJK : MNIFLAKIKFD, IDisposable, BOJOEJKGENO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GPBDIJCMDDB FLDBHAHHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private HIMACGGEFAK EJJOACMGLDK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GPBDIJCMDDB IDGNDNBMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA4C0", Offset = "0x7BA98C0", VA = "0x187BAA4C0", Slot = "6")]
		get
		{
			return default(GPBDIJCMDDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA6C0", Offset = "0x7BA9AC0", VA = "0x187BAA6C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform OLKDPFIALOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB6D230", Offset = "0xB6C630", VA = "0x180B6D230", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA410", Offset = "0x7BA9810", VA = "0x187BAA410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA610", Offset = "0x7BA9A10", VA = "0x187BAA610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA790", Offset = "0x7BA9B90", VA = "0x187BAA790")]
	public NBGHDAPJEJK(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA150", Offset = "0x7BA9550", VA = "0x187BAA150", Slot = "8")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA3C0", Offset = "0x7BA97C0", VA = "0x187BAA3C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFCD5A0", Offset = "0xFCC9A0", VA = "0x180FCD5A0", Slot = "11")]
	private void PALKAJEHKDG(OINJBHOKJEJ AGJLPBJDELI, OINJBHOKJEJ JONIHAOOOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "12")]
	private void AKJJOCDLKJI(bool IGJKIMIMKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FACPMIJGNCO : MEJIGNOFMAH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2460", Offset = "0x7BA1860", VA = "0x187BA2460", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1880", Offset = "0x7BA0C80", VA = "0x187BA1880", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1750", Offset = "0x7BA0B50", VA = "0x187BA1750", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7BA21D0", Offset = "0x7BA15D0", VA = "0x187BA21D0", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1CE0", Offset = "0x7BA10E0", VA = "0x187BA1CE0", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2390", Offset = "0x7BA1790", VA = "0x187BA2390", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7BA26D0", Offset = "0x7BA1AD0", VA = "0x187BA26D0", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2550", Offset = "0x7BA1950", VA = "0x187BA2550", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2610", Offset = "0x7BA1A10", VA = "0x187BA2610", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7BA19B0", Offset = "0x7BA0DB0", VA = "0x187BA19B0", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2250", Offset = "0x7BA1650", VA = "0x187BA2250")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1B50", Offset = "0x7BA0F50", VA = "0x187BA1B50")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA20A0", Offset = "0x7BA14A0", VA = "0x187BA20A0")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1F00", Offset = "0x7BA1300", VA = "0x187BA1F00")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1A70", Offset = "0x7BA0E70", VA = "0x187BA1A70")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1DB0", Offset = "0x7BA11B0", VA = "0x187BA1DB0", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FACPMIJGNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2250", Offset = "0x7BA1650", VA = "0x187BA2250", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1B50", Offset = "0x7BA0F50", VA = "0x187BA1B50", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7BA20A0", Offset = "0x7BA14A0", VA = "0x187BA20A0", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1F00", Offset = "0x7BA1300", VA = "0x187BA1F00", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1A70", Offset = "0x7BA0E70", VA = "0x187BA1A70", Slot = "18")]
	private LDLGKDDJEDN IHBCKBGEILD(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class IIIEHOIMLMG : HNAPDNDPDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0D30", Offset = "0x7BA0130", VA = "0x187BA0D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7AB0", Offset = "0x7BA6EB0", VA = "0x187BA7AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BA72B0", Offset = "0x7BA66B0", VA = "0x187BA72B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7BA7250", Offset = "0x7BA6650", VA = "0x187BA7250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F00", Offset = "0x7BA0300", VA = "0x187BA0F00")]
	public IIIEHOIMLMG(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7310", Offset = "0x7BA6710", VA = "0x187BA7310", Slot = "4")]
	public void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6D90", Offset = "0x7BA6190", VA = "0x187BA6D90")]
	private void AKOJCGKEIGA(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7830", Offset = "0x7BA6C30", VA = "0x187BA7830", Slot = "5")]
	public void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7470", Offset = "0x7BA6870", VA = "0x187BA7470", Slot = "6")]
	public void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA75D0", Offset = "0x7BA69D0", VA = "0x187BA75D0")]
	private void MBECDPPECEE(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6FF0", Offset = "0x7BA63F0", VA = "0x187BA6FF0", Slot = "7")]
	public void BCBPOCEDEKA(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class DFNPNLEJKEH : OECNNFBAOPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IICABGONHCK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PNKJPKBKDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1060", Offset = "0x7BA0460", VA = "0x187BA1060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0F00", Offset = "0x7BA0300", VA = "0x187BA0F00")]
	public DFNPNLEJKEH(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1030", Offset = "0x7BA0430", VA = "0x187BA1030", Slot = "6")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1170", Offset = "0x7BA0570", VA = "0x187BA1170", Slot = "7")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ABEKEJBKHII : HFLPIHNBNBH, HFPCMCDIGDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ALGKOANMNJA AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<ALGKOANMNJA> ADHMJMHCFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ALGKOANMNJA JGHOOBNHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ALGKOANMNJA LDIAONMHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform CKEJBFHGECF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EDF0", Offset = "0x7B9E1F0", VA = "0x187B9EDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x94FD00", Offset = "0x94F100", VA = "0x18094FD00", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E310", Offset = "0x7B9D710", VA = "0x187B9E310", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x94FD90", Offset = "0x94F190", VA = "0x18094FD90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ALGKOANMNJA> AFEPIFHKMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x951C60", Offset = "0x951060", VA = "0x180951C60", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PDAGHPCAEPO JMNJMHPELEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E660", Offset = "0x7B9DA60", VA = "0x187B9E660", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EA40", Offset = "0x7B9DE40", VA = "0x187B9EA40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PDAGHPCAEPO DCNDBKKAIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E0B0", Offset = "0x7B9D4B0", VA = "0x187B9E0B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E520", Offset = "0x7B9D920", VA = "0x187B9E520", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PEAKMKHCICL CHGIDFLHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DB00", Offset = "0x7B9CF00", VA = "0x187B9DB00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EE50", Offset = "0x7B9E250", VA = "0x187B9EE50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PCBDMKIAEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F2B0", Offset = "0x7B9E6B0", VA = "0x187B9F2B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E8F0", Offset = "0x7B9DCF0", VA = "0x187B9E8F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action LILBICELHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EEF0", Offset = "0x7B9E2F0", VA = "0x187B9EEF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EAE0", Offset = "0x7B9DEE0", VA = "0x187B9EAE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ALGKOANMNJA> EPDOGELDIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E000", Offset = "0x7B9D400", VA = "0x187B9E000", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E990", Offset = "0x7B9DD90", VA = "0x187B9E990", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ALGKOANMNJA> FOBPLFCKGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B9EF90", Offset = "0x7B9E390", VA = "0x187B9EF90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E470", Offset = "0x7B9D870", VA = "0x187B9E470", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action HGAJECLCBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DF60", Offset = "0x7B9D360", VA = "0x187B9DF60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E320", Offset = "0x7B9D720", VA = "0x187B9E320", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ALGKOANMNJA> BDDMLCJHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E260", Offset = "0x7B9D660", VA = "0x187B9E260", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E3C0", Offset = "0x7B9D7C0", VA = "0x187B9E3C0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F8D0", Offset = "0x7B9ECD0", VA = "0x187B9F8D0")]
	public ABEKEJBKHII(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9DEC0", Offset = "0x7B9D2C0", VA = "0x187B9DEC0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F350", Offset = "0x7B9E750", VA = "0x187B9F350", Slot = "30")]
	public void PDMHANMAJFJ(ALGKOANMNJA DFDGPBFKIGC, bool GAMHFCBCJBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F040", Offset = "0x7B9E440", VA = "0x187B9F040", Slot = "6")]
	public void NKHEFLJIIBD(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7B9DC40", Offset = "0x7B9D040", VA = "0x187B9DC40", Slot = "7")]
	public void CFBKCOABFBF(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7B9E150", Offset = "0x7B9D550", VA = "0x187B9E150", Slot = "4")]
	public void FCMEIMELBLA(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7B9E5C0", Offset = "0x7B9D9C0", VA = "0x187B9E5C0", Slot = "5")]
	public void JCPCDKKDOMN(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7B9DBA0", Offset = "0x7B9CFA0", VA = "0x187B9DBA0")]
	private void BECJIHFLKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7B9DAC0", Offset = "0x7B9CEC0", VA = "0x187B9DAC0")]
	private void ABAPOJGEKAH(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7B9ECB0", Offset = "0x7B9E0B0", VA = "0x187B9ECB0")]
	private void LJBCHNKJAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7B9E700", Offset = "0x7B9DB00", VA = "0x187B9E700")]
	private void KDHDMOBLHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7B9EB80", Offset = "0x7B9DF80", VA = "0x187B9EB80")]
	private void LBNOAIPGGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7B9E830", Offset = "0x7B9DC30", VA = "0x187B9E830")]
	[CompilerGenerated]
	private object KHNNLAJGACO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class KEMAMIHMLJI
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9D40", Offset = "0x7BA9140", VA = "0x187BA9D40")]
	public static HFLPIHNBNBH FLDIKFAONCC(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KELFPOPDBFE : DLMJHKGNACE, JPBCNBPDNII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JLDABEMCGKB<ALGKOANMNJA> DMEJMFJDFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool MHEIAPFFFAF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JLDABEMCGKB<ALGKOANMNJA> FEEEJEGJELG
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA94A0", Offset = "0x7BA88A0", VA = "0x187BA94A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA94D0", Offset = "0x7BA88D0", VA = "0x187BA94D0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9B50", Offset = "0x7BA8F50", VA = "0x187BA9B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ALGKOANMNJA PNAILCLDKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9A30", Offset = "0x7BA8E30", VA = "0x187BA9A30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9C40", Offset = "0x7BA9040", VA = "0x187BA9C40")]
	public KELFPOPDBFE(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9AE0", Offset = "0x7BA8EE0", VA = "0x187BA9AE0", Slot = "8")]
	public void LHNCEMIGEMO(ALGKOANMNJA LDIAONMHHPK, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9440", Offset = "0x7BA8840", VA = "0x187BA9440", Slot = "9")]
	public void CBFOEHMHJLL(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9690", Offset = "0x7BA8A90", VA = "0x187BA9690")]
	private Vector3 IPJPAJIJLLD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA90B0", Offset = "0x7BA84B0", VA = "0x187BA90B0")]
	private void BPHMBLDGDNA(ALGKOANMNJA JBOJOAABDKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class CCGFLDJJPDP
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA06B0", Offset = "0x7B9FAB0", VA = "0x187BA06B0")]
	public static DLMJHKGNACE CBDINKEDBIH(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class GDDFJFNACIA : JOLMOJAEINA, NEGEFAGJMPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 OHLHGJJLLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 AIPKHFOBLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GLMFLGEIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float IIEANAFKKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 ABIGCEEDGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? MJODOEGLMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? KMLKLHHAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool EKOKLMAHJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool DLBABGNALJC;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 KOANBGPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x13EF2D0", Offset = "0x13EE6D0", VA = "0x1813EF2D0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3630", Offset = "0x7BA2A30", VA = "0x187BA3630", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA32D0", Offset = "0x7BA26D0", VA = "0x187BA32D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xB90AC0", Offset = "0xB8FEC0", VA = "0x180B90AC0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2F90", Offset = "0x7BA2390", VA = "0x187BA2F90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA928E0", Offset = "0xA91CE0", VA = "0x180A928E0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA30A0", Offset = "0x7BA24A0", VA = "0x187BA30A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4E60", Offset = "0x7BA4260", VA = "0x187BA4E60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3150", Offset = "0x7BA2550", VA = "0x187BA3150", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4FF0", Offset = "0x7BA43F0", VA = "0x187BA4FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PDAGHPCAEPO OBABFJNKMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA52C0", Offset = "0x7BA46C0", VA = "0x187BA52C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA36E0", Offset = "0x7BA2AE0", VA = "0x187BA36E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5540", Offset = "0x7BA4940", VA = "0x187BA5540")]
	public GDDFJFNACIA(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2D90", Offset = "0x7BA2190", VA = "0x187BA2D90", Slot = "17")]
	public void CFHAHFFIBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5040", Offset = "0x7BA4440", VA = "0x187BA5040", Slot = "16")]
	public void KOIKIBIHFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2EB0", Offset = "0x7BA22B0", VA = "0x187BA2EB0", Slot = "19")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5360", Offset = "0x7BA4760", VA = "0x187BA5360", Slot = "20")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3C10", Offset = "0x7BA3010", VA = "0x187BA3C10", Slot = "18")]
	public void HPCMKGLGOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3780", Offset = "0x7BA2B80", VA = "0x187BA3780", Slot = "21")]
	public void FPFPICGMACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3630", Offset = "0x7BA2A30", VA = "0x187BA3630")]
	private void FAFLJIKPMNB(Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BA33C0", Offset = "0x7BA27C0", VA = "0x187BA33C0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EHFFCHPKGOE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2F90", Offset = "0x7BA2390", VA = "0x187BA2F90")]
	private void DBCGPPMLBKP(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA30A0", Offset = "0x7BA24A0", VA = "0x187BA30A0")]
	private void NJLNNEAIIML(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5120", Offset = "0x7BA4520", VA = "0x187BA5120")]
	private Vector3 LMHNLDOIDBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3DC0", Offset = "0x7BA31C0", VA = "0x187BA3DC0", Slot = "15")]
	public void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BA34B0", Offset = "0x7BA28B0", VA = "0x187BA34B0")]
	private Quaternion EINJMEKMLEM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4D90", Offset = "0x7BA4190", VA = "0x187BA4D90")]
	public void JPCDLJJOAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3FF0", Offset = "0x7BA33F0", VA = "0x187BA3FF0", Slot = "4")]
	public (float, Vector3) JPCDLJJOAAI(Rigidbody IIKDCJPONNB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class ABIJCHKGLEE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B9F990", Offset = "0x7B9ED90", VA = "0x187B9F990")]
	public static JOLMOJAEINA GPGCFJAOELA(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class GILCNJKDDHC : NMKEJPNDHIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IFFCOANOBGF FKEGBNNJPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FALLENFFJHK BHLDBBEMKKJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool ELGPKEJAPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x157C5A0", Offset = "0x157B9A0", VA = "0x18157C5A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FALLENFFJHK ENIBFKGGOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0", Slot = "11")]
		get
		{
			return default(FALLENFFJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5CD0", Offset = "0x7BA50D0", VA = "0x187BA5CD0")]
	public GILCNJKDDHC(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA56A0", Offset = "0x7BA4AA0", VA = "0x187BA56A0", Slot = "4")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5770", Offset = "0x7BA4B70", VA = "0x187BA5770")]
	private bool AOIDHFFEAJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA59D0", Offset = "0x7BA4DD0", VA = "0x187BA59D0", Slot = "5")]
	public void EPOLAKLIPNH(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5CA0", Offset = "0x7BA50A0", VA = "0x187BA5CA0", Slot = "6")]
	public void OLEIILMBFHD(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5810", Offset = "0x7BA4C10", VA = "0x187BA5810", Slot = "9")]
	public void CELBMMGMGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5A00", Offset = "0x7BA4E00", VA = "0x187BA5A00")]
	private void FNCFHAAFOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5B20", Offset = "0x7BA4F20", VA = "0x187BA5B20")]
	private void LOIOLNFHLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5990", Offset = "0x7BA4D90", VA = "0x187BA5990", Slot = "8")]
	public void EHGBOAJBFNF(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5950", Offset = "0x7BA4D50", VA = "0x187BA5950", Slot = "7")]
	public void DJLKKIAJPNI(ALGKOANMNJA AMDJMIBOJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EGILINDDLDP : MPDKEAHEBIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IFFCOANOBGF DPOPFBJBCGC;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1510", Offset = "0x7BA0910", VA = "0x187BA1510", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PDAGHPCAEPO MEOEMMEMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1460", Offset = "0x7BA0860", VA = "0x187BA1460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1220", Offset = "0x7BA0620", VA = "0x187BA1220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BA15F0", Offset = "0x7BA09F0", VA = "0x187BA15F0")]
	public EGILINDDLDP(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1500", Offset = "0x7BA0900", VA = "0x187BA1500", Slot = "7")]
	public void LFNOFHOCLDI(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1340", Offset = "0x7BA0740", VA = "0x187BA1340", Slot = "8")]
	public void EEFJJODOBMP(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1350", Offset = "0x7BA0750", VA = "0x187BA1350", Slot = "9")]
	public void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA11E0", Offset = "0x7BA05E0", VA = "0x187BA11E0", Slot = "12")]
	public void ACMIEOOIOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BA12C0", Offset = "0x7BA06C0", VA = "0x187BA12C0", Slot = "10")]
	public void CPBGHEOJGIH(Rigidbody HFMGHKAPEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BA15C0", Offset = "0x7BA09C0", VA = "0x187BA15C0", Slot = "11")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JGOPMIJBHCD : BCOHMJJAODE, NOKJKNKOCID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView MAHGMLPJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LHBIFNEECLC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView AFFLOGFACDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8680", Offset = "0x7BA7A80", VA = "0x187BA8680", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PDAGHPCAEPO DCJADKAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8320", Offset = "0x7BA7720", VA = "0x187BA8320", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8280", Offset = "0x7BA7680", VA = "0x187BA8280", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA86A0", Offset = "0x7BA7AA0", VA = "0x187BA86A0")]
	public JGOPMIJBHCD(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7B00", Offset = "0x7BA6F00", VA = "0x187BA7B00", Slot = "9")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7F10", Offset = "0x7BA7310", VA = "0x187BA7F10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7DA0", Offset = "0x7BA71A0", VA = "0x187BA7DA0", Slot = "10")]
	public void DLLDKAONAAD(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8510", Offset = "0x7BA7910", VA = "0x187BA8510", Slot = "11")]
	public void POKHBIJHKFC(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7C30", Offset = "0x7BA7030", VA = "0x187BA7C30")]
	private void DEJOHMKAIMC(PhotonView FDNIIGIIDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BA83C0", Offset = "0x7BA77C0", VA = "0x187BA83C0")]
	private void PGOBIBHOJJJ(DOJENFHJKGB IGJPHMCAOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8010", Offset = "0x7BA7410", VA = "0x187BA8010")]
	private void MAILKIHHMIN(PhotonView ENNIPFDIPEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CJMPFMLPOKF
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0840", Offset = "0x7B9FC40", VA = "0x187BA0840")]
	public static BCOHMJJAODE KFHBLOKIBAL(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MIJPOPPGCDE : LDLGKDDJEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints MPLKFGNDEDG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NFOMOHIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB22D80", Offset = "0xB22180", VA = "0x180B22D80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xBA7E30", Offset = "0xBA7230", VA = "0x180BA7E30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DFKMHMKEPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xBA7930", Offset = "0xBA6D30", VA = "0x180BA7930", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xBA7E20", Offset = "0xBA7220", VA = "0x180BA7E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints LCLBBGJJKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9F40", Offset = "0x7BA9340", VA = "0x187BA9F40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA0A0", Offset = "0x7BA94A0", VA = "0x187BAA0A0")]
	public MIJPOPPGCDE(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA9F10", Offset = "0x7BA9310", VA = "0x187BA9F10", Slot = "9")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BAA070", Offset = "0x7BA9470", VA = "0x187BAA070", Slot = "10")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GCNCIPDFNBD : CBHLGAFNGFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ALGKOANMNJA AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float AOJLFKPPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float NPJINIJDOIG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float DBCBEFOFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xD6B510", Offset = "0xD6A910", VA = "0x180D6B510", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2B10", Offset = "0x7BA1F10", VA = "0x187BA2B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PFCBECDMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xBDA170", Offset = "0xBD9570", VA = "0x180BDA170", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2BE0", Offset = "0x7BA1FE0", VA = "0x187BA2BE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2D50", Offset = "0x7BA2150", VA = "0x187BA2D50")]
	public GCNCIPDFNBD(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2AC0", Offset = "0x7BA1EC0", VA = "0x187BA2AC0", Slot = "8")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2CB0", Offset = "0x7BA20B0", VA = "0x187BA2CB0", Slot = "9")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HNPAPLCMHDE : GHPGCABFHCD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IBCMILIKEJG FCBNPJAHLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool LEFGDFCMBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool CNDEMBCBDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int GHDJKEPFCEC;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4FF0", Offset = "0x7BA43F0", VA = "0x187BA4FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5E60", Offset = "0x7BA5260", VA = "0x187BA5E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6010", Offset = "0x7BA5410", VA = "0x187BA6010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6130", Offset = "0x7BA5530", VA = "0x187BA6130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PDAGHPCAEPO LCGOPILANPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA67B0", Offset = "0x7BA5BB0", VA = "0x187BA67B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA6900", Offset = "0x7BA5D00", VA = "0x187BA6900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6A30", Offset = "0x7BA5E30", VA = "0x187BA6A30")]
	public HNPAPLCMHDE(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5DD0", Offset = "0x7BA51D0", VA = "0x187BA5DD0", Slot = "6")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BA68F0", Offset = "0x7BA5CF0", VA = "0x187BA68F0", Slot = "8")]
	public void PALFGIPOJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7BA62C0", Offset = "0x7BA56C0", VA = "0x187BA62C0", Slot = "7")]
	public bool GMIKMKKIIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7BA66A0", Offset = "0x7BA5AA0", VA = "0x187BA66A0", Slot = "9")]
	public void JIIIELNBPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6850", Offset = "0x7BA5C50", VA = "0x187BA6850", Slot = "13")]
	public void OHACHHIJHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6190", Offset = "0x7BA5590", VA = "0x187BA6190", Slot = "12")]
	public void DGIGJFPHGFA(bool JNPMBCFKKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6740", Offset = "0x7BA5B40", VA = "0x187BA6740", Slot = "10")]
	public bool MFMMEKFFJEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6070", Offset = "0x7BA5470", VA = "0x187BA6070", Slot = "11")]
	public bool DDBCJGGLELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6410", Offset = "0x7BA5810", VA = "0x187BA6410")]
	private bool HJHHKECKDLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5E80", Offset = "0x7BA5280", VA = "0x187BA5E80")]
	private void BPGFPNOABLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JONPOKHHNOL : HLOIJECJGIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IFFCOANOBGF AENBONMAGAA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA72B0", Offset = "0x7BA66B0", VA = "0x187BA72B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool ECIIKGAPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x157C5A0", Offset = "0x157B9A0", VA = "0x18157C5A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8FA0", Offset = "0x7BA83A0", VA = "0x187BA8FA0")]
	public JONPOKHHNOL(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8800", Offset = "0x7BA7C00", VA = "0x187BA8800", Slot = "5")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA88D0", Offset = "0x7BA7CD0", VA = "0x187BA88D0", Slot = "7")]
	public void HLDEHJLFKFN(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7BA88A0", Offset = "0x7BA7CA0", VA = "0x187BA88A0", Slot = "8")]
	public void EBAOIBANCHE(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8C70", Offset = "0x7BA8070", VA = "0x187BA8C70", Slot = "9")]
	public void NNMNONHOMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8A80", Offset = "0x7BA7E80", VA = "0x187BA8A80", Slot = "10")]
	public void JEILLEEBNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8900", Offset = "0x7BA7D00", VA = "0x187BA8900", Slot = "11")]
	public void IOEJADJAMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AAFBKNPPPFG : CBHHLDALOCI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NFCFPGHPKJP AMDJMIBOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IFFCOANOBGF FMMHKAPJEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float HNCMMPBIENH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OPMGDNEPOAI APEKLIAHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CAD0", Offset = "0x7B9BED0", VA = "0x187B9CAD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7B9C3B0", Offset = "0x7B9B7B0", VA = "0x187B9C3B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BCE0", Offset = "0x7B9B0E0", VA = "0x187B9BCE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9BC00", Offset = "0x7B9B000", VA = "0x187B9BC00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D870", Offset = "0x7B9CC70", VA = "0x187B9D870", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7B9ADC0", Offset = "0x7B9A1C0", VA = "0x187B9ADC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CE80", Offset = "0x7B9C280", VA = "0x187B9CE80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CFA0", Offset = "0x7B9C3A0", VA = "0x187B9CFA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE938D0", Offset = "0xE92CD0", VA = "0x180E938D0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7B9AB60", Offset = "0x7B99F60", VA = "0x187B9AB60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1EAE1B0", Offset = "0x1EAD5B0", VA = "0x181EAE1B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HNAPDNDPDEC BECEKBLDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7259F10", Offset = "0x7259310", VA = "0x187259F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7B9AC70", Offset = "0x7B9A070", VA = "0x187B9AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D9D0", Offset = "0x7B9CDD0", VA = "0x187B9D9D0")]
	public AAFBKNPPPFG(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A8D0", Offset = "0x7B99CD0", VA = "0x187B9A8D0", Slot = "19")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AE80", Offset = "0x7B9A280", VA = "0x187B9AE80", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AC90", Offset = "0x7B9A090", VA = "0x187B9AC90", Slot = "28")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x13A4810", Offset = "0x13A3C10", VA = "0x1813A4810", Slot = "20")]
	public void KMFINJOGAMG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x13A5CA0", Offset = "0x13A50A0", VA = "0x1813A5CA0", Slot = "30")]
	public void EFPPDPPKOLG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A980", Offset = "0x7B99D80", VA = "0x187B9A980", Slot = "35")]
	public Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AF40", Offset = "0x7B9A340", VA = "0x187B9AF40", Slot = "34")]
	public Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A8D0", Offset = "0x7B99CD0", VA = "0x187B9A8D0", Slot = "27")]
	public void EDJHAMEFIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AEE0", Offset = "0x7B9A2E0", VA = "0x187B9AEE0", Slot = "25")]
	public void EJOHHKODEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CC20", Offset = "0x7B9C020", VA = "0x187B9CC20", Slot = "24")]
	public void NJADJDABIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CFD0", Offset = "0x7B9C3D0", VA = "0x187B9CFD0", Slot = "33")]
	public void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CE20", Offset = "0x7B9C220", VA = "0x187B9CE20", Slot = "32")]
	public void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B6B0", Offset = "0x7B9AAB0", VA = "0x187B9B6B0", Slot = "31")]
	public void GEGDBMJAFCD(Vector3 MJMCMBGBGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7B9C470", Offset = "0x7B9B870", VA = "0x187B9C470", Slot = "22")]
	public void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B970", Offset = "0x7B9AD70", VA = "0x187B9B970", Slot = "21")]
	public void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D3A0", Offset = "0x7B9C7A0", VA = "0x187B9D3A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x14C23C0", Offset = "0x14C17C0", VA = "0x1814C23C0")]
	private static void MAHOINBPHIB(Vector3 PGIPNLMJJCH, Vector3 FGKLFPNFOKI, [Out] Vector3 OKHKMPGFDHO, [Out] Vector3 MKILBJAADNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D790", Offset = "0x7B9CB90", VA = "0x187B9D790", Slot = "29")]
	public Vector3 PHAGPDAFEDM(Vector3 PGIPNLMJJCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7B9D210", Offset = "0x7B9C610", VA = "0x187B9D210", Slot = "26")]
	public void PEPAHFAOHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7B9AB60", Offset = "0x7B99F60", VA = "0x187B9AB60")]
	private void BLLEBGOJPCD(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9CC80", Offset = "0x7B9C080", VA = "0x187B9CC80")]
	private void NPPCCOLCDPP(Vector3 FHCLGDCLCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B850", Offset = "0x7B9AC50", VA = "0x187B9B850")]
	private Vector3 GHICIFHINMK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A440", Offset = "0x7B99840", VA = "0x187B9A440")]
	private void ABLPNJPLMJP(Vector3 HGIAGFCHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BE00", Offset = "0x7B9B200", VA = "0x187B9BE00")]
	private Vector3 HMPAHDJCAJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BF20", Offset = "0x7B9B320", VA = "0x187B9BF20")]
	private void IDAHIFFDILO(Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7B9B100", Offset = "0x7B9A500", VA = "0x187B9B100")]
	private void FIKEPJPDGKH(Vector3 HGIAGFCHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B9BC30", Offset = "0x7B9B030", VA = "0x187B9BC30")]
	private void HLJKNEJBAOG()
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
