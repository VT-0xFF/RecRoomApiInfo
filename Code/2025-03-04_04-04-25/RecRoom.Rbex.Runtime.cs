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
		[Cpp2IlInjected.Address(RVA = "0x7C4E490", Offset = "0x7C4CA90", VA = "0x187C4E490", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E286B0", Offset = "0x1E26CB0", VA = "0x181E286B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AE30", Offset = "0x7C59430", VA = "0x187C5AE30")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B130", Offset = "0x7C59730", VA = "0x187C5B130", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B190", Offset = "0x7C59790", VA = "0x187C5B190")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C567A0", Offset = "0x7C54DA0", VA = "0x187C567A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ALGKOANMNJA DGDEFGEGLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KIIPMJCADCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7C58340", Offset = "0x7C56940", VA = "0x187C58340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FJKLIKAMMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7C586A0", Offset = "0x7C56CA0", VA = "0x187C586A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HAMMPINBCBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7C585E0", Offset = "0x7C56BE0", VA = "0x187C585E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LDIAONMHHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7C592A0", Offset = "0x7C578A0", VA = "0x187C592A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A7A0", Offset = "0x7C58DA0", VA = "0x187C5A7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7C1ECE0", Offset = "0x7C1D2E0", VA = "0x187C1ECE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C20DA0", Offset = "0x7C1F3A0", VA = "0x187C20DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform EJNLPEDOMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1C69A20", Offset = "0x1C68020", VA = "0x181C69A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OBNPHIMIBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1C69A20", Offset = "0x1C68020", VA = "0x181C69A20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IEAFPNGLCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1C69A20", Offset = "0x1C68020", VA = "0x181C69A20", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GPBDIJCMDDB IDGNDNBMKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7C583A0", Offset = "0x7C569A0", VA = "0x187C583A0")]
			get
			{
				return default(GPBDIJCMDDB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C59F50", Offset = "0x7C58550", VA = "0x187C59F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BFGJHJKGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C589B0", Offset = "0x7C56FB0", VA = "0x187C589B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EGPMEMMIMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C584C0", Offset = "0x7C56AC0", VA = "0x187C584C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OPMGDNEPOAI APEKLIAHFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C588F0", Offset = "0x7C56EF0", VA = "0x187C588F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A110", Offset = "0x7C58710", VA = "0x187C5A110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HHKIIOIPKEL JFPFGLNJMAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C58890", Offset = "0x7C56E90", VA = "0x187C58890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A0A0", Offset = "0x7C586A0", VA = "0x187C5A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EFAJKHNIDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7C587E0", Offset = "0x7C56DE0", VA = "0x187C587E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody EFGIGFEGANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C58840", Offset = "0x7C56E40", VA = "0x187C58840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NFOMOHIOLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C58520", Offset = "0x7C56B20", VA = "0x187C58520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7C59FC0", Offset = "0x7C585C0", VA = "0x187C59FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DNABDOIEBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x13BD460", Offset = "0x13BBA60", VA = "0x1813BD460", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IIEANAFKKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7C59240", Offset = "0x7C57840", VA = "0x187C59240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GLMFLGEIELN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C591E0", Offset = "0x7C577E0", VA = "0x187C591E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A730", Offset = "0x7C58D30", VA = "0x187C5A730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float AOJLFKPPHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C58C10", Offset = "0x7C57210", VA = "0x187C58C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A3B0", Offset = "0x7C589B0", VA = "0x187C5A3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NPJINIJDOIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C58A10", Offset = "0x7C57010", VA = "0x187C58A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A180", Offset = "0x7C58780", VA = "0x187C5A180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IICABGONHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C597F0", Offset = "0x7C57DF0", VA = "0x187C597F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5ACE0", Offset = "0x7C592E0", VA = "0x187C5ACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 ABIGCEEDGFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7C58FC0", Offset = "0x7C575C0", VA = "0x187C58FC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A500", Offset = "0x7C58B00", VA = "0x187C5A500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 AFGAKBBGKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7C59930", Offset = "0x7C57F30", VA = "0x187C59930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode KNEHMJFBMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7C58B50", Offset = "0x7C57150", VA = "0x187C58B50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A2D0", Offset = "0x7C588D0", VA = "0x187C5A2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float POMMCKJPGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C58580", Offset = "0x7C56B80", VA = "0x187C58580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A030", Offset = "0x7C58630", VA = "0x187C5A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints MPLKFGNDEDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7C58BB0", Offset = "0x7C571B0", VA = "0x187C58BB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A340", Offset = "0x7C58940", VA = "0x187C5A340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 IOELABKCDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7C59360", Offset = "0x7C57960", VA = "0x187C59360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 JAMGPAENPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C59360", Offset = "0x7C57960", VA = "0x187C59360")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AAC0", Offset = "0x7C590C0", VA = "0x187C5AAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float OPPJBCDKOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7C590A0", Offset = "0x7C576A0", VA = "0x187C590A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A5E0", Offset = "0x7C58BE0", VA = "0x187C5A5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PHCEMLFIAPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7C59790", Offset = "0x7C57D90", VA = "0x187C59790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC70", Offset = "0x7C59270", VA = "0x187C5AC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion APHPDOAEDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C59440", Offset = "0x7C57A40", VA = "0x187C59440")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A840", Offset = "0x7C58E40", VA = "0x187C5A840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion ELHCBGJDCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C596C0", Offset = "0x7C57CC0", VA = "0x187C596C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C5ABA0", Offset = "0x7C591A0", VA = "0x187C5ABA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ODKNMCDFNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7C59510", Offset = "0x7C57B10", VA = "0x187C59510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A910", Offset = "0x7C58F10", VA = "0x187C5A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IBABBGFIAKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7C595F0", Offset = "0x7C57BF0", VA = "0x187C595F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A9F0", Offset = "0x7C58FF0", VA = "0x187C5A9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PGIPNLMJJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7C59850", Offset = "0x7C57E50", VA = "0x187C59850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AD50", Offset = "0x7C59350", VA = "0x187C5AD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HGIAGFCHLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7C59100", Offset = "0x7C57700", VA = "0x187C59100")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A650", Offset = "0x7C58C50", VA = "0x187C5A650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 GNFIJOGHJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7C58A70", Offset = "0x7C57070", VA = "0x187C58A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A1F0", Offset = "0x7C587F0", VA = "0x187C5A1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 PMBLIKDJDDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7C58EE0", Offset = "0x7C574E0", VA = "0x187C58EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A420", Offset = "0x7C58A20", VA = "0x187C5A420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MJODOEGLMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7C58DA0", Offset = "0x7C573A0", VA = "0x187C58DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion KMLKLHHAONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7C58CD0", Offset = "0x7C572D0", VA = "0x187C58CD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 ELCFJGJNPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7C59AF0", Offset = "0x7C580F0", VA = "0x187C59AF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 KJNCPIJEKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7C59A10", Offset = "0x7C58010", VA = "0x187C59A10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FCBHBKAKIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7C58E80", Offset = "0x7C57480", VA = "0x187C58E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MCIMPKMOLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C58950", Offset = "0x7C56F50", VA = "0x187C58950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BFIFIOEMIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7C58460", Offset = "0x7C56A60", VA = "0x187C58460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KDNCHPOIPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C58400", Offset = "0x7C56A00", VA = "0x187C58400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HFNDMANAEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C582E0", Offset = "0x7C568E0", VA = "0x187C582E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IKMPMKPFCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7C58C70", Offset = "0x7C57270", VA = "0x187C58C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KFMLNKJFEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x20F7810", Offset = "0x20F5E10", VA = "0x1820F7810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PEAKMKHCICL EIPEDEOGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C58200", Offset = "0x7C56800", VA = "0x187C58200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C59E70", Offset = "0x7C58470", VA = "0x187C59E70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PDAGHPCAEPO JMNJMHPELEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7C57F70", Offset = "0x7C56570", VA = "0x187C57F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C59BD0", Offset = "0x7C581D0", VA = "0x187C59BD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PDAGHPCAEPO DCNDBKKAIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7C57FD0", Offset = "0x7C565D0", VA = "0x187C57FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7C59C40", Offset = "0x7C58240", VA = "0x187C59C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PDAGHPCAEPO IJCFEOLPONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7C58120", Offset = "0x7C56720", VA = "0x187C58120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7C59D90", Offset = "0x7C58390", VA = "0x187C59D90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C580B0", Offset = "0x7C566B0", VA = "0x187C580B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7C59D20", Offset = "0x7C58320", VA = "0x187C59D20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PDAGHPCAEPO KKEBDCGNJKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7C58190", Offset = "0x7C56790", VA = "0x187C58190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7C59E00", Offset = "0x7C58400", VA = "0x187C59E00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PDAGHPCAEPO IPDCHNHKBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7C58270", Offset = "0x7C56870", VA = "0x187C58270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C59EE0", Offset = "0x7C584E0", VA = "0x187C59EE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PDAGHPCAEPO HIGJAJALGPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C58040", Offset = "0x7C56640", VA = "0x187C58040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C59CB0", Offset = "0x7C582B0", VA = "0x187C59CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00", Slot = "8")]
		private void PHDJFCBGLAD(ALGKOANMNJA AAMBBOLAGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C56B10", Offset = "0x7C55110", VA = "0x187C56B10", Slot = "9")]
		public OLOMKIEJIDK GetData()
		{
			return default(OLOMKIEJIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C56F70", Offset = "0x7C55570", VA = "0x187C56F70")]
		internal void NPIBHIOBABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C57C90", Offset = "0x7C56290", VA = "0x187C57C90")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OLLDADPKNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C56860", Offset = "0x7C54E60", VA = "0x187C56860")]
		public DOJENFHJKGB GetChild(int EAHKFAJBNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C578F0", Offset = "0x7C55EF0", VA = "0x187C578F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C56270", Offset = "0x7C54870", VA = "0x187C56270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C57B80", Offset = "0x7C56180", VA = "0x187C57B80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C567A0", Offset = "0x7C54DA0", VA = "0x187C567A0")]
		private ALGKOANMNJA NCONEJJLEBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C56440", Offset = "0x7C54A40", VA = "0x187C56440")]
		private void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C570C0", Offset = "0x7C556C0", VA = "0x187C570C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C57000", Offset = "0x7C55600", VA = "0x187C57000")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C56F70", Offset = "0x7C55570", VA = "0x187C56F70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C57060", Offset = "0x7C55660", VA = "0x187C57060")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C57120", Offset = "0x7C55720", VA = "0x187C57120")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C55860", Offset = "0x7C53E60", VA = "0x187C55860")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C57180", Offset = "0x7C55780", VA = "0x187C57180")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C56740", Offset = "0x7C54D40", VA = "0x187C56740")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C56F10", Offset = "0x7C55510", VA = "0x187C56F10")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7C57A50", Offset = "0x7C56050", VA = "0x187C57A50")]
		public void SetParent(RigidbodyEx KBGCCIOIGBD, bool GAMHFCBCJBI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7C57490", Offset = "0x7C55A90", VA = "0x187C57490")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C56BA0", Offset = "0x7C551A0", VA = "0x187C56BA0")]
		public bool IsRigidbodyAncestor(RigidbodyEx HENCFIBHGPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C56CA0", Offset = "0x7C552A0", VA = "0x187C56CA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx AKGDAPECEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7C55AD0", Offset = "0x7C540D0", VA = "0x187C55AD0")]
		public void AddInterpolationRestriction(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C571F0", Offset = "0x7C557F0", VA = "0x187C571F0")]
		public void RemoveInterpolationRestriction(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C55B40", Offset = "0x7C54140", VA = "0x187C55B40")]
		public void AddKinematic(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C57260", Offset = "0x7C55860", VA = "0x187C57260")]
		public void RemoveKinematic(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C579D0", Offset = "0x7C55FD0", VA = "0x187C579D0")]
		public void SetKinematic(object LAAJFAFNFCN, bool OCMDPMDMEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C577F0", Offset = "0x7C55DF0", VA = "0x187C577F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NMOENKJNINF, Quaternion GJHDMIEGGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C576F0", Offset = "0x7C55CF0", VA = "0x187C576F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EKNIMOGELNJ, Quaternion MPPGEACKGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C56A00", Offset = "0x7C55000", VA = "0x187C56A00")]
		public Vector3 GetConstrainedVelocity(Vector3 PGIPNLMJJCH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C568F0", Offset = "0x7C54EF0", VA = "0x187C568F0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 GNFIJOGHJJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C559E0", Offset = "0x7C53FE0", VA = "0x187C559E0")]
		public void AddForce(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C558D0", Offset = "0x7C53ED0", VA = "0x187C558D0")]
		public void AddForceAtPosition(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C55D10", Offset = "0x7C54310", VA = "0x187C55D10")]
		public void AddTorque(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C55BB0", Offset = "0x7C541B0", VA = "0x187C55BB0")]
		public void AddRelativeTorque(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C57D60", Offset = "0x7C56360", VA = "0x187C57D60")]
		public Vector3 WorldToLocalVelocity(Vector3 DBLIJGKPLMN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C56E00", Offset = "0x7C55400", VA = "0x187C56E00")]
		public Vector3 LocalToWorldVelocity(Vector3 HGIAGFCHLPB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C566E0", Offset = "0x7C54CE0", VA = "0x187C566E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C56680", Offset = "0x7C54C80", VA = "0x187C56680")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C56620", Offset = "0x7C54C20", VA = "0x187C56620")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C565C0", Offset = "0x7C54BC0", VA = "0x187C565C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C575F0", Offset = "0x7C55BF0", VA = "0x187C575F0")]
		public void ResetVelocityWorldSpace(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C574F0", Offset = "0x7C55AF0", VA = "0x187C574F0")]
		public void ResetVelocityLocalSpace(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7C573B0", Offset = "0x7C559B0", VA = "0x187C573B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 AFAALGOINNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7C57B90", Offset = "0x7C56190", VA = "0x187C57B90")]
		public bool SweepTest(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C56DA0", Offset = "0x7C553A0", VA = "0x187C56DA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C57B20", Offset = "0x7C56120", VA = "0x187C57B20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C57D00", Offset = "0x7C56300", VA = "0x187C57D00")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7C55CA0", Offset = "0x7C542A0", VA = "0x187C55CA0")]
		public void AddShouldHaveUnityRigidbodyToken(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7C572D0", Offset = "0x7C558D0", VA = "0x187C572D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C560A0", Offset = "0x7C546A0", VA = "0x187C560A0")]
		public void ApplyForceVelocityChange(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C55FA0", Offset = "0x7C545A0", VA = "0x187C55FA0")]
		public void ApplyAngularVelocityChange(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C56160", Offset = "0x7C54760", VA = "0x187C56160")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C55ED0", Offset = "0x7C544D0", VA = "0x187C55ED0")]
		public bool AllowedScaleChange(float AJFLFDACHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E00", Offset = "0x7C54400", VA = "0x187C55E00")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx ANNFJIHMGGG, object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C57340", Offset = "0x7C55940", VA = "0x187C57340")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C56850", Offset = "0x7C54E50", VA = "0x187C56850", Slot = "12")]
		private void EGJMLFHHLME(DBGGEFBGBDL BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C57F00", Offset = "0x7C56500", VA = "0x187C57F00")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA65A60", Offset = "0xA64060", VA = "0x180A65A60", Slot = "4")]
		private GameObject MNLDCPAIODF()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C45D70", Offset = "0x7C44370", VA = "0x187C45D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MEJIGNOFMAH EEHLNOJBBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C47050", Offset = "0x7C45650", VA = "0x187C47050", Slot = "7")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C46E80", Offset = "0x7C45480", VA = "0x187C46E80", Slot = "6")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C556C0", Offset = "0x7C53CC0", VA = "0x187C556C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C55700", Offset = "0x7C53D00", VA = "0x187C55700")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C556E0", Offset = "0x7C53CE0", VA = "0x187C556E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string MIALAMIFNLM, [Optional] UnityEngine.Object BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string MIALAMIFNLM, [Optional] UnityEngine.Object BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C55810", Offset = "0x7C53E10", VA = "0x187C55810")]
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
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x961B80", Offset = "0x960180", VA = "0x180961B80", Slot = "4")]
		public Vector3 LIDPKMGBHFK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x961B80", Offset = "0x960180", VA = "0x180961B80", Slot = "5")]
		public Vector3 HMPAHDJCAJF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "6")]
		public bool LOAHDELBHEB(float OAJECFFFKCD, float OPIKHPHPKLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IHGENAHHKOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OPMGDNEPOAI GELNJJKINLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C44E00", Offset = "0x7C43400", VA = "0x187C44E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "22")]
		get
		{
			return default(FHNHGOPNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public DOJENFHJKGB ABOOBHLFACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB8B630", Offset = "0xB89C30", VA = "0x180B8B630", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xCEE8F0", Offset = "0xCECEF0", VA = "0x180CEE8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x955950", Offset = "0x953F50", VA = "0x180955950", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x955910", Offset = "0x953F10", VA = "0x180955910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xABD020", Offset = "0xABB620", VA = "0x180ABD020", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xD04D20", Offset = "0xD03320", VA = "0x180D04D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C53100", Offset = "0x7C51700", VA = "0x187C53100", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FEC0", Offset = "0x7C4E4C0", VA = "0x187C4FEC0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C517F0", Offset = "0x7C4FDF0", VA = "0x187C517F0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KIIPMJCADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54E30", Offset = "0x7C53430", VA = "0x187C54E30", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F170", Offset = "0x7C4D770", VA = "0x187C4F170", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C50200", Offset = "0x7C4E800", VA = "0x187C50200", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7C55540", Offset = "0x7C53B40", VA = "0x187C55540", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7C53050", Offset = "0x7C51650", VA = "0x187C53050", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public OPMGDNEPOAI APEKLIAHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7C51620", Offset = "0x7C4FC20", VA = "0x187C51620", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7C52A30", Offset = "0x7C51030", VA = "0x187C52A30", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7C531C0", Offset = "0x7C517C0", VA = "0x187C531C0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7C51FA0", Offset = "0x7C505A0", VA = "0x187C51FA0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C10", Offset = "0x7C50210", VA = "0x187C51C10", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F850", Offset = "0x7C4DE50", VA = "0x187C4F850", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7C52610", Offset = "0x7C50C10", VA = "0x187C52610", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7C51E70", Offset = "0x7C50470", VA = "0x187C51E70", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54350", Offset = "0x7C52950", VA = "0x187C54350", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54590", Offset = "0x7C52B90", VA = "0x187C54590", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C53D80", Offset = "0x7C52380", VA = "0x187C53D80", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C52E30", Offset = "0x7C51430", VA = "0x187C52E30", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7C54EA0", Offset = "0x7C534A0", VA = "0x187C54EA0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7C50120", Offset = "0x7C4E720", VA = "0x187C50120", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BFIFIOEMIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7C53C80", Offset = "0x7C52280", VA = "0x187C53C80", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KDNCHPOIPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7C53E60", Offset = "0x7C52460", VA = "0x187C53E60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool HFNDMANAEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7C53AF0", Offset = "0x7C520F0", VA = "0x187C53AF0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7C50F10", Offset = "0x7C4F510", VA = "0x187C50F10", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C50260", Offset = "0x7C4E860", VA = "0x187C50260", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C51D90", Offset = "0x7C50390", VA = "0x187C51D90", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 KOANBGPJFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C52000", Offset = "0x7C50600", VA = "0x187C52000", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C540F0", Offset = "0x7C526F0", VA = "0x187C540F0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C507B0", Offset = "0x7C4EDB0", VA = "0x187C507B0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FBB0", Offset = "0x7C4E1B0", VA = "0x187C4FBB0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C51380", Offset = "0x7C4F980", VA = "0x187C51380", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C50680", Offset = "0x7C4EC80", VA = "0x187C50680", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C52F70", Offset = "0x7C51570", VA = "0x187C52F70", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C506E0", Offset = "0x7C4ECE0", VA = "0x187C506E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float DBCBEFOFKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C550B0", Offset = "0x7C536B0", VA = "0x187C550B0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C52910", Offset = "0x7C50F10", VA = "0x187C52910", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PFCBECDMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C54430", Offset = "0x7C52A30", VA = "0x187C54430", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C530A0", Offset = "0x7C516A0", VA = "0x187C530A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PNKJPKBKDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C53BD0", Offset = "0x7C521D0", VA = "0x187C53BD0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FF10", Offset = "0x7C4E510", VA = "0x187C4FF10", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GPBDIJCMDDB IDGNDNBMKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C51F50", Offset = "0x7C50550", VA = "0x187C51F50", Slot = "70")]
		get
		{
			return default(GPBDIJCMDDB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C53FA0", Offset = "0x7C525A0", VA = "0x187C53FA0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C54670", Offset = "0x7C52C70", VA = "0x187C54670", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IEAFPNGLCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xABD020", Offset = "0xABB620", VA = "0x180ABD020", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 LEEAOGLADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C512D0", Offset = "0x7C4F8D0", VA = "0x187C512D0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C51930", Offset = "0x7C4FF30", VA = "0x187C51930", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JBJGLOCLKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C52820", Offset = "0x7C50E20", VA = "0x187C52820", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C53660", Offset = "0x7C51C60", VA = "0x187C53660", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float BBPBPOAPNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C531B0", Offset = "0x7C517B0", VA = "0x187C531B0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C52D50", Offset = "0x7C51350", VA = "0x187C52D50", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion PEKONLBNMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C52CB0", Offset = "0x7C512B0", VA = "0x187C52CB0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C52B80", Offset = "0x7C51180", VA = "0x187C52B80", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 KOHIGCEHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F810", Offset = "0x7C4DE10", VA = "0x187C4F810", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C53730", Offset = "0x7C51D30", VA = "0x187C53730", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion NDNJPIJMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FC50", Offset = "0x7C4E250", VA = "0x187C4FC50", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C53EC0", Offset = "0x7C524C0", VA = "0x187C53EC0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints LCLBBGJJKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C53260", Offset = "0x7C51860", VA = "0x187C53260", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C53A90", Offset = "0x7C52090", VA = "0x187C53A90", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NFOMOHIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C50C90", Offset = "0x7C4F290", VA = "0x187C50C90", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C50B00", Offset = "0x7C4F100", VA = "0x187C50B00", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode HAFEJEBADGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C539E0", Offset = "0x7C51FE0", VA = "0x187C539E0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C54DD0", Offset = "0x7C533D0", VA = "0x187C54DD0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F9C0", Offset = "0x7C4DFC0", VA = "0x187C4F9C0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MCIMPKMOLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C51670", Offset = "0x7C4FC70", VA = "0x187C51670", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PDAGHPCAEPO JMNJMHPELEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7C52B20", Offset = "0x7C51120", VA = "0x187C52B20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C53150", Offset = "0x7C51750", VA = "0x187C53150", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PDAGHPCAEPO DCNDBKKAIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7C50F60", Offset = "0x7C4F560", VA = "0x187C50F60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C52970", Offset = "0x7C50F70", VA = "0x187C52970", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PEAKMKHCICL CHGIDFLHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EFF0", Offset = "0x7C4D5F0", VA = "0x187C4EFF0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7C53C20", Offset = "0x7C52220", VA = "0x187C53C20", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PDAGHPCAEPO DCJADKAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C547B0", Offset = "0x7C52DB0", VA = "0x187C547B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7C53A30", Offset = "0x7C52030", VA = "0x187C53A30", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PDAGHPCAEPO IJCFEOLPONG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F80", Offset = "0x7C53580", VA = "0x187C54F80", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C51570", Offset = "0x7C4FB70", VA = "0x187C51570", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PDAGHPCAEPO LCGOPILANPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C53F40", Offset = "0x7C52540", VA = "0x187C53F40", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54810", Offset = "0x7C52E10", VA = "0x187C54810", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C50A40", Offset = "0x7C4F040", VA = "0x187C50A40", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C529D0", Offset = "0x7C50FD0", VA = "0x187C529D0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PDAGHPCAEPO MEOEMMEMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C525B0", Offset = "0x7C50BB0", VA = "0x187C525B0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FE60", Offset = "0x7C4E460", VA = "0x187C4FE60", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PDAGHPCAEPO HIGJAJALGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FB00", Offset = "0x7C4E100", VA = "0x187C4FB00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C513D0", Offset = "0x7C4F9D0", VA = "0x187C513D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7C555D0", Offset = "0x7C53BD0", VA = "0x187C555D0")]
	public NFCFPGHPKJP(GameObject HHDLNMHBJJD, RigidbodyEx BLKFLPPAAFI, FFKDIAAHIOB JEIEGFHFIPA, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C532B0", Offset = "0x7C518B0", VA = "0x187C532B0", Slot = "139")]
	protected virtual void LADCGODDCBD(FFKDIAAHIOB JEIEGFHFIPA, OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C50890", Offset = "0x7C4EE90", VA = "0x187C50890", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EEB0", Offset = "0x7C4D4B0", VA = "0x187C4EEB0", Slot = "93")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54480", Offset = "0x7C52A80", VA = "0x187C54480", Slot = "94")]
	public void OMNCAKKNONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C52F10", Offset = "0x7C51510", VA = "0x187C52F10", Slot = "95")]
	public void KEEBHJFCMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F050", Offset = "0x7C4D650", VA = "0x187C4F050", Slot = "96")]
	public void AOOFEJBFDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7C50330", Offset = "0x7C4E930", VA = "0x187C50330")]
	private void DGIGJFPHGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C54510", Offset = "0x7C52B10", VA = "0x187C54510")]
	private void ONNEKCLEOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C500C0", Offset = "0x7C4E6C0", VA = "0x187C500C0")]
	private void DDBCJGGLELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7C51480", Offset = "0x7C4FA80", VA = "0x187C51480", Slot = "30")]
	public ALGKOANMNJA FODDECJFNCE(int EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7C54A00", Offset = "0x7C53000", VA = "0x187C54A00", Slot = "98")]
	public void PDMHANMAJFJ(ALGKOANMNJA KBGCCIOIGBD, bool GAMHFCBCJBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C53CD0", Offset = "0x7C522D0", VA = "0x187C53CD0", Slot = "99")]
	public void MMKPBALBOBB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C54870", Offset = "0x7C52E70", VA = "0x187C54870", Slot = "100")]
	public void PAMIHHDAFMA(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F070", Offset = "0x7C4D670", VA = "0x187C4F070", Slot = "101")]
	public Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7C50E10", Offset = "0x7C4F410", VA = "0x187C50E10", Slot = "102")]
	public Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C509F0", Offset = "0x7C4EFF0", VA = "0x187C509F0", Slot = "103")]
	public void EDJHAMEFIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C50DC0", Offset = "0x7C4F3C0", VA = "0x187C50DC0", Slot = "104")]
	public void EJOHHKODEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C53EF0", Offset = "0x7C524F0", VA = "0x187C53EF0", Slot = "105")]
	public void NJADJDABIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C546C0", Offset = "0x7C52CC0", VA = "0x187C546C0", Slot = "106")]
	public void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54000", Offset = "0x7C52600", VA = "0x187C54000", Slot = "107")]
	public void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C51850", Offset = "0x7C4FE50", VA = "0x187C51850", Slot = "108")]
	public void GEGDBMJAFCD(Vector3 MJMCMBGBGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C535A0", Offset = "0x7C51BA0", VA = "0x187C535A0", Slot = "109")]
	public void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C519E0", Offset = "0x7C4FFE0", VA = "0x187C519E0", Slot = "110")]
	public void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C54AC0", Offset = "0x7C530C0", VA = "0x187C54AC0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C54CD0", Offset = "0x7C532D0", VA = "0x187C54CD0", Slot = "112")]
	public Vector3 PHAGPDAFEDM(Vector3 KBGCCIOIGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C54BD0", Offset = "0x7C531D0", VA = "0x187C54BD0", Slot = "113")]
	public Vector3 PGECOLEOIDJ(Vector3 KBGCCIOIGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C54A70", Offset = "0x7C53070", VA = "0x187C54A70", Slot = "114")]
	public void PEPAHFAOHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C53970", Offset = "0x7C51F70", VA = "0x187C53970", Slot = "115")]
	public void LKGIAHIOKLN(ALGKOANMNJA ANNFJIHMGGG, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C510C0", Offset = "0x7C4F6C0", VA = "0x187C510C0", Slot = "116")]
	public void ENLMECHGGAL(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C52830", Offset = "0x7C50E30", VA = "0x187C52830", Slot = "63")]
	public void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FC00", Offset = "0x7C4E200", VA = "0x187C4FC00", Slot = "117")]
	public void CFHAHFFIBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C53210", Offset = "0x7C51810", VA = "0x187C53210", Slot = "118")]
	public void KOIKIBIHFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C526F0", Offset = "0x7C50CF0", VA = "0x187C526F0", Slot = "119")]
	public void HPCMKGLGOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C51AE0", Offset = "0x7C500E0", VA = "0x187C51AE0", Slot = "120")]
	public bool GMIKMKKIIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C52C60", Offset = "0x7C51260", VA = "0x187C52C60", Slot = "97")]
	public void JIIIELNBPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C542E0", Offset = "0x7C528E0", VA = "0x187C542E0", Slot = "121")]
	public void OHACHHIJHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C536D0", Offset = "0x7C51CD0", VA = "0x187C536D0", Slot = "122")]
	public void LFNOFHOCLDI(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C50AA0", Offset = "0x7C4F0A0", VA = "0x187C50AA0", Slot = "123")]
	public void EEFJJODOBMP(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C51500", Offset = "0x7C4FB00", VA = "0x187C51500", Slot = "124")]
	public void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C53770", Offset = "0x7C51D70", VA = "0x187C53770", Slot = "125")]
	public void LHBJMNBGGEB(Vector3 NMOENKJNINF, Quaternion GJHDMIEGGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C548D0", Offset = "0x7C52ED0", VA = "0x187C548D0", Slot = "126")]
	public void PDJDLOAJIPC(Vector3 EKNIMOGELNJ, Quaternion MPPGEACKGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C53D30", Offset = "0x7C52330", VA = "0x187C53D30", Slot = "127")]
	public bool MOKCDOPFMIO(float AJFLFDACHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C520E0", Offset = "0x7C506E0", VA = "0x187C520E0", Slot = "128")]
	public void HHMPELEDFFM(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FE00", Offset = "0x7C4E400", VA = "0x187C4FE00", Slot = "129")]
	public void CKHCOJLGKJB(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C52550", Offset = "0x7C50B50", VA = "0x187C52550", Slot = "130")]
	public void HLDEHJLFKFN(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C50990", Offset = "0x7C4EF90", VA = "0x187C50990", Slot = "131")]
	public void EBAOIBANCHE(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C50CE0", Offset = "0x7C4F2E0", VA = "0x187C50CE0", Slot = "132")]
	public void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C541D0", Offset = "0x7C527D0", VA = "0x187C541D0", Slot = "133")]
	public void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C52740", Offset = "0x7C50D40", VA = "0x187C52740", Slot = "134")]
	public void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F540", Offset = "0x7C4DB40", VA = "0x187C4F540", Slot = "135")]
	public void BCBPOCEDEKA(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C50FC0", Offset = "0x7C4F5C0", VA = "0x187C50FC0", Slot = "136")]
	public bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C515D0", Offset = "0x7C4FBD0", VA = "0x187C515D0", Slot = "137")]
	public void FPFPICGMACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C55590", Offset = "0x7C53B90", VA = "0x187C55590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C51B30", Offset = "0x7C50130", VA = "0x187C51B30")]
	private void GNEHOOEEBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F8B0", Offset = "0x7C4DEB0", VA = "0x187C4F8B0")]
	private void BHEBIJCIPLH(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F620", Offset = "0x7C4DC20", VA = "0x187C4F620")]
	private void BDJADPDHIPF(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C52140", Offset = "0x7C50740", VA = "0x187C52140")]
	private void HIPPFLFBOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C51C60", Offset = "0x7C50260", VA = "0x187C51C60")]
	private void HBCMHHOJJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C51120", Offset = "0x7C4F720", VA = "0x187C51120")]
	private void ENMGMKIBMGN(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C505B0", Offset = "0x7C4EBB0", VA = "0x187C505B0")]
	private void DLLDKAONAAD(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C54FE0", Offset = "0x7C535E0", VA = "0x187C54FE0")]
	private void POKHBIJHKFC(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FF70", Offset = "0x7C4E570", VA = "0x187C4FF70")]
	private void DCIFNNNJAPH(DOJENFHJKGB LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C55100", Offset = "0x7C53700", VA = "0x187C55100", Slot = "142")]
	protected virtual void POOENMAFAMA(DOJENFHJKGB AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C521F0", Offset = "0x7C507F0", VA = "0x187C521F0")]
	protected void HKILALOAMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F1C0", Offset = "0x7C4D7C0", VA = "0x187C4F1C0")]
	protected void BBPCMDFMHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C50B60", Offset = "0x7C4F160", VA = "0x187C50B60")]
	private void EIDNAKJLAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FC90", Offset = "0x7C4E290", VA = "0x187C4FC90")]
	private void CJNHEOEFGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class IEIIFLMBMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B270", Offset = "0x7C49870", VA = "0x187C4B270")]
	public static ALGKOANMNJA HMPLIGKAHJF(this ALGKOANMNJA AMDJMIBOJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B330", Offset = "0x7C49930", VA = "0x187C4B330")]
	public static bool IBEPPNDMEIP(this ALGKOANMNJA AMDJMIBOJED, ALGKOANMNJA HENCFIBHGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B150", Offset = "0x7C49750", VA = "0x187C4B150")]
	public static bool CEJKJIMBLOM(this ALGKOANMNJA AMDJMIBOJED, ALGKOANMNJA AKGDAPECEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B3D0", Offset = "0x7C499D0", VA = "0x187C4B3D0")]
	public static DOJENFHJKGB NCGFHGFAAHB(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B1F0", Offset = "0x7C497F0", VA = "0x187C4B1F0")]
	public static NFCFPGHPKJP FFAMOGBNMDJ(this ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DBECPJDNILJ : MEJIGNOFMAH
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C45620", Offset = "0x7C43C20", VA = "0x187C45620", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public DBECPJDNILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C44A50", Offset = "0x7C43050", VA = "0x187C44A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7C44810", Offset = "0x7C42E10", VA = "0x187C44810", Slot = "20")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7C449B0", Offset = "0x7C42FB0", VA = "0x187C449B0", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C44180", Offset = "0x7C42780", VA = "0x187C44180", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7C440E0", Offset = "0x7C426E0", VA = "0x187C440E0", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7C44770", Offset = "0x7C42D70", VA = "0x187C44770", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7C44420", Offset = "0x7C42A20", VA = "0x187C44420", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7C44910", Offset = "0x7C42F10", VA = "0x187C44910", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7C44BF0", Offset = "0x7C431F0", VA = "0x187C44BF0", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7C44AB0", Offset = "0x7C430B0", VA = "0x187C44AB0", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7C44B50", Offset = "0x7C43150", VA = "0x187C44B50", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7C44220", Offset = "0x7C42820", VA = "0x187C44220", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7C44860", Offset = "0x7C42E60", VA = "0x187C44860")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7C44370", Offset = "0x7C42970", VA = "0x187C44370")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7C446C0", Offset = "0x7C42CC0", VA = "0x187C446C0")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7C44610", Offset = "0x7C42C10", VA = "0x187C44610")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7C442C0", Offset = "0x7C428C0", VA = "0x187C442C0")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7C444C0", Offset = "0x7C42AC0", VA = "0x187C444C0", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7C44C90", Offset = "0x7C43290", VA = "0x187C44C90")]
	public BBAPPCBKANO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7C44860", Offset = "0x7C42E60", VA = "0x187C44860", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7C44370", Offset = "0x7C42970", VA = "0x187C44370", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7C446C0", Offset = "0x7C42CC0", VA = "0x187C446C0", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7C44610", Offset = "0x7C42C10", VA = "0x187C44610", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7C442C0", Offset = "0x7C428C0", VA = "0x187C442C0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C453C0", Offset = "0x7C439C0", VA = "0x187C453C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode HAFEJEBADGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7C45410", Offset = "0x7C43A10", VA = "0x187C45410", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7C45520", Offset = "0x7C43B20", VA = "0x187C45520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7C45590", Offset = "0x7C43B90", VA = "0x187C45590")]
	public CPMEOLLNAEC(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7C44F90", Offset = "0x7C43590", VA = "0x187C44F90", Slot = "6")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7C450C0", Offset = "0x7C436C0", VA = "0x187C450C0", Slot = "9")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7C450B0", Offset = "0x7C436B0", VA = "0x187C450B0", Slot = "7")]
	public void BIFEOPLDOFA(bool FCBHBKAKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7C450A0", Offset = "0x7C436A0", VA = "0x187C450A0", Slot = "8")]
	public void BFAHPBKDGLO(bool FCBHBKAKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7C45140", Offset = "0x7C43740", VA = "0x187C45140", Slot = "10")]
	public bool ENBOKHHPFMD(Vector3 BNCGOADGBEC, [Out] RaycastHit OLEHNOEJHML, float HIAAOMCAGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7C452A0", Offset = "0x7C438A0", VA = "0x187C452A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C4EB50", Offset = "0x7C4D150", VA = "0x187C4EB50", Slot = "6")]
		get
		{
			return default(GPBDIJCMDDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7C4ED50", Offset = "0x7C4D350", VA = "0x187C4ED50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform OLKDPFIALOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB73D20", Offset = "0xB72320", VA = "0x180B73D20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OINJBHOKJEJ, OINJBHOKJEJ> HDINLCLOKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EAA0", Offset = "0x7C4D0A0", VA = "0x187C4EAA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7C4ECA0", Offset = "0x7C4D2A0", VA = "0x187C4ECA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EE20", Offset = "0x7C4D420", VA = "0x187C4EE20")]
	public NBGHDAPJEJK(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E7E0", Offset = "0x7C4CDE0", VA = "0x187C4E7E0", Slot = "8")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EA50", Offset = "0x7C4D050", VA = "0x187C4EA50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFE0AA0", Offset = "0xFDF0A0", VA = "0x180FE0AA0", Slot = "11")]
	private void PALKAJEHKDG(OINJBHOKJEJ AGJLPBJDELI, OINJBHOKJEJ JONIHAOOOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "12")]
	private void AKJJOCDLKJI(bool IGJKIMIMKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FACPMIJGNCO : MEJIGNOFMAH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7C46AF0", Offset = "0x7C450F0", VA = "0x187C46AF0", Slot = "4")]
	public HFPCMCDIGDG MMEAMJNAPAN(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7C45F10", Offset = "0x7C44510", VA = "0x187C45F10", Slot = "5")]
	public CBHHLDALOCI BIIKNNMEOMA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7C45DE0", Offset = "0x7C443E0", VA = "0x187C45DE0", Slot = "6")]
	public JPBCNBPDNII BAMDMOIIHKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7C46860", Offset = "0x7C44E60", VA = "0x187C46860", Slot = "7")]
	public CBHLGAFNGFA IIPJLAGLDGC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7C46370", Offset = "0x7C44970", VA = "0x187C46370", Slot = "8")]
	public GHPGCABFHCD EMGFPJGEJDC(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7C46A20", Offset = "0x7C45020", VA = "0x187C46A20", Slot = "9")]
	public MNIFLAKIKFD KGLDJFCOMIM(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7C46D60", Offset = "0x7C45360", VA = "0x187C46D60", Slot = "10")]
	public MPDKEAHEBIN PNEHFGFBLGE(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7C46BE0", Offset = "0x7C451E0", VA = "0x187C46BE0", Slot = "11")]
	public HNAPDNDPDEC OKFCKIMKIJO(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7C46CA0", Offset = "0x7C452A0", VA = "0x187C46CA0", Slot = "12")]
	public MGPDLEDPGHD PBDDLCDMIKD(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7C46040", Offset = "0x7C44640", VA = "0x187C46040", Slot = "13")]
	public OECNNFBAOPC BJBJMAHMEOA(ALGKOANMNJA AAMBBOLAGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7C468E0", Offset = "0x7C44EE0", VA = "0x187C468E0")]
	public HLOIJECJGIM JMLFHKGLJLM(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7C461E0", Offset = "0x7C447E0", VA = "0x187C461E0")]
	public NOKJKNKOCID CNACNCIAHDH(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7C46730", Offset = "0x7C44D30", VA = "0x187C46730")]
	public NMKEJPNDHIN MHEBBDBMEFK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7C46590", Offset = "0x7C44B90", VA = "0x187C46590")]
	public NEGEFAGJMPC KNJDKFFNIKK(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7C46100", Offset = "0x7C44700", VA = "0x187C46100")]
	public LDLGKDDJEDN CCOOPGCIDID(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7C46440", Offset = "0x7C44A40", VA = "0x187C46440", Slot = "19")]
	public ALGKOANMNJA FPAOGIFCENF(RigidbodyEx AMDJMIBOJED, OLOMKIEJIDK GIDGOODJFLJ, FFKDIAAHIOB JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public FACPMIJGNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7C468E0", Offset = "0x7C44EE0", VA = "0x187C468E0", Slot = "14")]
	private HLOIJECJGIM KICDIMGPODJ(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7C461E0", Offset = "0x7C447E0", VA = "0x187C461E0", Slot = "15")]
	private NOKJKNKOCID DEIMIMEEFNO(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7C46730", Offset = "0x7C44D30", VA = "0x187C46730", Slot = "16")]
	private NMKEJPNDHIN GOGCLJLFIND(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7C46590", Offset = "0x7C44B90", VA = "0x187C46590", Slot = "17")]
	private NEGEFAGJMPC GDMMAEDEKGP(ALGKOANMNJA AAMBBOLAGCO, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7C46100", Offset = "0x7C44700", VA = "0x187C46100", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C453C0", Offset = "0x7C439C0", VA = "0x187C453C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OAHEBJFIIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C140", Offset = "0x7C4A740", VA = "0x187C4C140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B940", Offset = "0x7C49F40", VA = "0x187C4B940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B8E0", Offset = "0x7C49EE0", VA = "0x187C4B8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7C45590", Offset = "0x7C43B90", VA = "0x187C45590")]
	public IIIEHOIMLMG(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B9A0", Offset = "0x7C49FA0", VA = "0x187C4B9A0", Slot = "4")]
	public void EJNPIADIJKL(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B420", Offset = "0x7C49A20", VA = "0x187C4B420")]
	private void AKOJCGKEIGA(Vector3 MHOOEDPKADD, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BEC0", Offset = "0x7C4A4C0", VA = "0x187C4BEC0", Slot = "5")]
	public void OFPILGCEHPI(Vector3 MHOOEDPKADD, Vector3 NDADPNJPMFO, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BB00", Offset = "0x7C4A100", VA = "0x187C4BB00", Slot = "6")]
	public void IBHONFEMPKJ(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BC60", Offset = "0x7C4A260", VA = "0x187C4BC60")]
	private void MBECDPPECEE(Vector3 KGNOGLDDKGP, ForceMode CFFKAOJCDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B680", Offset = "0x7C49C80", VA = "0x187C4B680", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7C456F0", Offset = "0x7C43CF0", VA = "0x187C456F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7C45590", Offset = "0x7C43B90", VA = "0x187C45590")]
	public DFNPNLEJKEH(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7C456C0", Offset = "0x7C43CC0", VA = "0x187C456C0", Slot = "6")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7C45800", Offset = "0x7C43E00", VA = "0x187C45800", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C43480", Offset = "0x7C41A80", VA = "0x187C43480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x956D00", Offset = "0x955300", VA = "0x180956D00", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7C429A0", Offset = "0x7C40FA0", VA = "0x187C429A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ALGKOANMNJA HAMMPINBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x956D90", Offset = "0x955390", VA = "0x180956D90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ALGKOANMNJA> AFEPIFHKMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957260", VA = "0x180958C60", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PDAGHPCAEPO JMNJMHPELEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7C42CF0", Offset = "0x7C412F0", VA = "0x187C42CF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7C430D0", Offset = "0x7C416D0", VA = "0x187C430D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PDAGHPCAEPO DCNDBKKAIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7C42740", Offset = "0x7C40D40", VA = "0x187C42740", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7C42BB0", Offset = "0x7C411B0", VA = "0x187C42BB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PEAKMKHCICL CHGIDFLHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7C42190", Offset = "0x7C40790", VA = "0x187C42190", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7C434E0", Offset = "0x7C41AE0", VA = "0x187C434E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PCBDMKIAEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C43940", Offset = "0x7C41F40", VA = "0x187C43940", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7C42F80", Offset = "0x7C41580", VA = "0x187C42F80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action LILBICELHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7C43580", Offset = "0x7C41B80", VA = "0x187C43580", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7C43170", Offset = "0x7C41770", VA = "0x187C43170", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ALGKOANMNJA> EPDOGELDIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C42690", Offset = "0x7C40C90", VA = "0x187C42690", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C43020", Offset = "0x7C41620", VA = "0x187C43020", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ALGKOANMNJA> FOBPLFCKGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C43620", Offset = "0x7C41C20", VA = "0x187C43620", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7C42B00", Offset = "0x7C41100", VA = "0x187C42B00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action HGAJECLCBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7C425F0", Offset = "0x7C40BF0", VA = "0x187C425F0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7C429B0", Offset = "0x7C40FB0", VA = "0x187C429B0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ALGKOANMNJA> BDDMLCJHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7C428F0", Offset = "0x7C40EF0", VA = "0x187C428F0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7C42A50", Offset = "0x7C41050", VA = "0x187C42A50", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7C43F60", Offset = "0x7C42560", VA = "0x187C43F60")]
	public ABEKEJBKHII(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7C42550", Offset = "0x7C40B50", VA = "0x187C42550", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7C439E0", Offset = "0x7C41FE0", VA = "0x187C439E0", Slot = "30")]
	public void PDMHANMAJFJ(ALGKOANMNJA DFDGPBFKIGC, bool GAMHFCBCJBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7C436D0", Offset = "0x7C41CD0", VA = "0x187C436D0", Slot = "6")]
	public void NKHEFLJIIBD(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7C422D0", Offset = "0x7C408D0", VA = "0x187C422D0", Slot = "7")]
	public void CFBKCOABFBF(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7C427E0", Offset = "0x7C40DE0", VA = "0x187C427E0", Slot = "4")]
	public void FCMEIMELBLA(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7C42C50", Offset = "0x7C41250", VA = "0x187C42C50", Slot = "5")]
	public void JCPCDKKDOMN(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7C42230", Offset = "0x7C40830", VA = "0x187C42230")]
	private void BECJIHFLKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7C42150", Offset = "0x7C40750", VA = "0x187C42150")]
	private void ABAPOJGEKAH(ALGKOANMNJA FIHALPBMNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7C43340", Offset = "0x7C41940", VA = "0x187C43340")]
	private void LJBCHNKJAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7C42D90", Offset = "0x7C41390", VA = "0x187C42D90")]
	private void KDHDMOBLHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7C43210", Offset = "0x7C41810", VA = "0x187C43210")]
	private void LBNOAIPGGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7C42EC0", Offset = "0x7C414C0", VA = "0x187C42EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C4E3D0", Offset = "0x7C4C9D0", VA = "0x187C4E3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CECEIGEKICD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DB30", Offset = "0x7C4C130", VA = "0x187C4DB30", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 IJMJINEDEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DB60", Offset = "0x7C4C160", VA = "0x187C4DB60", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E1E0", Offset = "0x7C4C7E0", VA = "0x187C4E1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ALGKOANMNJA PNAILCLDKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E0C0", Offset = "0x7C4C6C0", VA = "0x187C4E0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E2D0", Offset = "0x7C4C8D0", VA = "0x187C4E2D0")]
	public KELFPOPDBFE(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E170", Offset = "0x7C4C770", VA = "0x187C4E170", Slot = "8")]
	public void LHNCEMIGEMO(ALGKOANMNJA LDIAONMHHPK, object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DAD0", Offset = "0x7C4C0D0", VA = "0x187C4DAD0", Slot = "9")]
	public void CBFOEHMHJLL(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DD20", Offset = "0x7C4C320", VA = "0x187C4DD20")]
	private Vector3 IPJPAJIJLLD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D740", Offset = "0x7C4BD40", VA = "0x187C4D740")]
	private void BPHMBLDGDNA(ALGKOANMNJA JBOJOAABDKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class CCGFLDJJPDP
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C44D40", Offset = "0x7C43340", VA = "0x187C44D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x1408B80", Offset = "0x1407180", VA = "0x181408B80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C47CC0", Offset = "0x7C462C0", VA = "0x187C47CC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 AJFFEJMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C47960", Offset = "0x7C45F60", VA = "0x187C47960", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OMDIFBBGKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xB99990", Offset = "0xB97F90", VA = "0x180B99990", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C47620", Offset = "0x7C45C20", VA = "0x187C47620")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float DENPBICKFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA9A800", Offset = "0xA98E00", VA = "0x180A9A800", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C47730", Offset = "0x7C45D30", VA = "0x187C47730", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 BAJNCDKBLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C494F0", Offset = "0x7C47AF0", VA = "0x187C494F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion OCCAONDPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C477E0", Offset = "0x7C45DE0", VA = "0x187C477E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody EFGIGFEGANB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C49680", Offset = "0x7C47C80", VA = "0x187C49680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PDAGHPCAEPO OBABFJNKMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C49950", Offset = "0x7C47F50", VA = "0x187C49950", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C47D70", Offset = "0x7C46370", VA = "0x187C47D70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C49BD0", Offset = "0x7C481D0", VA = "0x187C49BD0")]
	public GDDFJFNACIA(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C47420", Offset = "0x7C45A20", VA = "0x187C47420", Slot = "17")]
	public void CFHAHFFIBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C496D0", Offset = "0x7C47CD0", VA = "0x187C496D0", Slot = "16")]
	public void KOIKIBIHFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C47540", Offset = "0x7C45B40", VA = "0x187C47540", Slot = "19")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C499F0", Offset = "0x7C47FF0", VA = "0x187C499F0", Slot = "20")]
	public void PHBBPCHJGOC(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C482A0", Offset = "0x7C468A0", VA = "0x187C482A0", Slot = "18")]
	public void HPCMKGLGOFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C47E10", Offset = "0x7C46410", VA = "0x187C47E10", Slot = "21")]
	public void FPFPICGMACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C47CC0", Offset = "0x7C462C0", VA = "0x187C47CC0")]
	private void FAFLJIKPMNB(Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C47A50", Offset = "0x7C46050", VA = "0x187C47A50")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EHFFCHPKGOE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C47620", Offset = "0x7C45C20", VA = "0x187C47620")]
	private void DBCGPPMLBKP(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C47730", Offset = "0x7C45D30", VA = "0x187C47730")]
	private void NJLNNEAIIML(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C497B0", Offset = "0x7C47DB0", VA = "0x187C497B0")]
	private Vector3 LMHNLDOIDBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C48450", Offset = "0x7C46A50", VA = "0x187C48450", Slot = "15")]
	public void IGDPPDADKPC((Quaternion rot, Vector3 moments) BDGCMKHKJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C47B40", Offset = "0x7C46140", VA = "0x187C47B40")]
	private Quaternion EINJMEKMLEM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C49420", Offset = "0x7C47A20", VA = "0x187C49420")]
	public void JPCDLJJOAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C48680", Offset = "0x7C46C80", VA = "0x187C48680", Slot = "4")]
	public (float, Vector3) JPCDLJJOAAI(Rigidbody IIKDCJPONNB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class ABIJCHKGLEE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C44020", Offset = "0x7C42620", VA = "0x187C44020")]
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
		[Cpp2IlInjected.Address(RVA = "0x158EFF0", Offset = "0x158D5F0", VA = "0x18158EFF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FALLENFFJHK ENIBFKGGOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580", Slot = "11")]
		get
		{
			return default(FALLENFFJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A360", Offset = "0x7C48960", VA = "0x187C4A360")]
	public GILCNJKDDHC(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D30", Offset = "0x7C48330", VA = "0x187C49D30", Slot = "4")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C49E00", Offset = "0x7C48400", VA = "0x187C49E00")]
	private bool AOIDHFFEAJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A060", Offset = "0x7C48660", VA = "0x187C4A060", Slot = "5")]
	public void EPOLAKLIPNH(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A330", Offset = "0x7C48930", VA = "0x187C4A330", Slot = "6")]
	public void OLEIILMBFHD(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C49EA0", Offset = "0x7C484A0", VA = "0x187C49EA0", Slot = "9")]
	public void CELBMMGMGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A090", Offset = "0x7C48690", VA = "0x187C4A090")]
	private void FNCFHAAFOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A1B0", Offset = "0x7C487B0", VA = "0x187C4A1B0")]
	private void LOIOLNFHLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A020", Offset = "0x7C48620", VA = "0x187C4A020", Slot = "8")]
	public void EHGBOAJBFNF(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C49FE0", Offset = "0x7C485E0", VA = "0x187C49FE0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C45BA0", Offset = "0x7C441A0", VA = "0x187C45BA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PDAGHPCAEPO MEOEMMEMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AF0", Offset = "0x7C440F0", VA = "0x187C45AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C458B0", Offset = "0x7C43EB0", VA = "0x187C458B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C45C80", Offset = "0x7C44280", VA = "0x187C45C80")]
	public EGILINDDLDP(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C45B90", Offset = "0x7C44190", VA = "0x187C45B90", Slot = "7")]
	public void LFNOFHOCLDI(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C459D0", Offset = "0x7C43FD0", VA = "0x187C459D0", Slot = "8")]
	public void EEFJJODOBMP(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C459E0", Offset = "0x7C43FE0", VA = "0x187C459E0", Slot = "9")]
	public void FPBIFIJGBOB(object LAAJFAFNFCN, bool OCMDPMDMEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C45870", Offset = "0x7C43E70", VA = "0x187C45870", Slot = "12")]
	public void ACMIEOOIOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C45950", Offset = "0x7C43F50", VA = "0x187C45950", Slot = "10")]
	public void CPBGHEOJGIH(Rigidbody HFMGHKAPEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C45C50", Offset = "0x7C44250", VA = "0x187C45C50", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BFGJHJKGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CD10", Offset = "0x7C4B310", VA = "0x187C4CD10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool EGPMEMMIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PDAGHPCAEPO DCJADKAAFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C9B0", Offset = "0x7C4AFB0", VA = "0x187C4C9B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C910", Offset = "0x7C4AF10", VA = "0x187C4C910", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CD30", Offset = "0x7C4B330", VA = "0x187C4CD30")]
	public JGOPMIJBHCD(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C190", Offset = "0x7C4A790", VA = "0x187C4C190", Slot = "9")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C5A0", Offset = "0x7C4ABA0", VA = "0x187C4C5A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C430", Offset = "0x7C4AA30", VA = "0x187C4C430", Slot = "10")]
	public void DLLDKAONAAD(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CBA0", Offset = "0x7C4B1A0", VA = "0x187C4CBA0", Slot = "11")]
	public void POKHBIJHKFC(ALGKOANMNJA LDIAONMHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C2C0", Offset = "0x7C4A8C0", VA = "0x187C4C2C0")]
	private void DEJOHMKAIMC(PhotonView FDNIIGIIDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CA50", Offset = "0x7C4B050", VA = "0x187C4CA50")]
	private void PGOBIBHOJJJ(DOJENFHJKGB IGJPHMCAOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C6A0", Offset = "0x7C4ACA0", VA = "0x187C4C6A0")]
	private void MAILKIHHMIN(PhotonView ENNIPFDIPEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CJMPFMLPOKF
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C44ED0", Offset = "0x7C434D0", VA = "0x187C44ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2AD20", Offset = "0xB29320", VA = "0x180B2AD20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xBAEAF0", Offset = "0xBAD0F0", VA = "0x180BAEAF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DFKMHMKEPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xBAE5F0", Offset = "0xBACBF0", VA = "0x180BAE5F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xBAEAE0", Offset = "0xBAD0E0", VA = "0x180BAEAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints LCLBBGJJKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E5D0", Offset = "0x7C4CBD0", VA = "0x187C4E5D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E730", Offset = "0x7C4CD30", VA = "0x187C4E730")]
	public MIJPOPPGCDE(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E5A0", Offset = "0x7C4CBA0", VA = "0x187C4E5A0", Slot = "9")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E700", Offset = "0x7C4CD00", VA = "0x187C4E700", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0xD791D0", Offset = "0xD777D0", VA = "0x180D791D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C471A0", Offset = "0x7C457A0", VA = "0x187C471A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PFCBECDMHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBDFEB0", VA = "0x180BE18B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C47270", Offset = "0x7C45870", VA = "0x187C47270", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C473E0", Offset = "0x7C459E0", VA = "0x187C473E0")]
	public GCNCIPDFNBD(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C47150", Offset = "0x7C45750", VA = "0x187C47150", Slot = "8")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C47340", Offset = "0x7C45940", VA = "0x187C47340", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C49680", Offset = "0x7C47C80", VA = "0x187C49680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A4F0", Offset = "0x7C48AF0", VA = "0x187C4A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ALGKOANMNJA IACMILFIJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A6A0", Offset = "0x7C48CA0", VA = "0x187C4A6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A7C0", Offset = "0x7C48DC0", VA = "0x187C4A7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PDAGHPCAEPO LCGOPILANPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AE40", Offset = "0x7C49440", VA = "0x187C4AE40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AF90", Offset = "0x7C49590", VA = "0x187C4AF90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B0C0", Offset = "0x7C496C0", VA = "0x187C4B0C0")]
	public HNPAPLCMHDE(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A460", Offset = "0x7C48A60", VA = "0x187C4A460", Slot = "6")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AF80", Offset = "0x7C49580", VA = "0x187C4AF80", Slot = "8")]
	public void PALFGIPOJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A950", Offset = "0x7C48F50", VA = "0x187C4A950", Slot = "7")]
	public bool GMIKMKKIIKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AD30", Offset = "0x7C49330", VA = "0x187C4AD30", Slot = "9")]
	public void JIIIELNBPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AEE0", Offset = "0x7C494E0", VA = "0x187C4AEE0", Slot = "13")]
	public void OHACHHIJHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A820", Offset = "0x7C48E20", VA = "0x187C4A820", Slot = "12")]
	public void DGIGJFPHGFA(bool JNPMBCFKKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7C4ADD0", Offset = "0x7C493D0", VA = "0x187C4ADD0", Slot = "10")]
	public bool MFMMEKFFJEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A700", Offset = "0x7C48D00", VA = "0x187C4A700", Slot = "11")]
	public bool DDBCJGGLELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AAA0", Offset = "0x7C490A0", VA = "0x187C4AAA0")]
	private bool HJHHKECKDLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A510", Offset = "0x7C48B10", VA = "0x187C4A510")]
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
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool DDBFPNBFMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B940", Offset = "0x7C49F40", VA = "0x187C4B940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool ECIIKGAPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x158EFF0", Offset = "0x158D5F0", VA = "0x18158EFF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D630", Offset = "0x7C4BC30", VA = "0x187C4D630")]
	public JONPOKHHNOL(ALGKOANMNJA AMDJMIBOJED, [In] OLOMKIEJIDK GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CE90", Offset = "0x7C4B490", VA = "0x187C4CE90", Slot = "5")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CF60", Offset = "0x7C4B560", VA = "0x187C4CF60", Slot = "7")]
	public void HLDEHJLFKFN(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CF30", Offset = "0x7C4B530", VA = "0x187C4CF30", Slot = "8")]
	public void EBAOIBANCHE(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D300", Offset = "0x7C4B900", VA = "0x187C4D300", Slot = "9")]
	public void NNMNONHOMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D110", Offset = "0x7C4B710", VA = "0x187C4D110", Slot = "10")]
	public void JEILLEEBNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CF90", Offset = "0x7C4B590", VA = "0x187C4CF90", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HHKIIOIPKEL JFPFGLNJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LMLKLDELBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7C41160", Offset = "0x7C3F760", VA = "0x187C41160", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7C40A40", Offset = "0x7C3F040", VA = "0x187C40A40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 LIJIPPGHPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7C40370", Offset = "0x7C3E970", VA = "0x187C40370", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7C40290", Offset = "0x7C3E890", VA = "0x187C40290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 GMGNGJFELMM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7C41F00", Offset = "0x7C40500", VA = "0x187C41F00", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F450", Offset = "0x7C3DA50", VA = "0x187C3F450", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 LMCBCFBPCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7C41510", Offset = "0x7C3FB10", VA = "0x187C41510", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7C41630", Offset = "0x7C3FC30", VA = "0x187C41630", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float POMMCKJPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEA5F50", Offset = "0xEA4550", VA = "0x180EA5F50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F1F0", Offset = "0x7C3D7F0", VA = "0x187C3F1F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool EFAJKHNIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1ECF950", Offset = "0x1ECDF50", VA = "0x181ECF950", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HNAPDNDPDEC BECEKBLDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x72CC390", Offset = "0x72CA990", VA = "0x1872CC390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool KAMEILCECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F300", Offset = "0x7C3D900", VA = "0x187C3F300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7C42060", Offset = "0x7C40660", VA = "0x187C42060")]
	public AAFBKNPPPFG(ALGKOANMNJA AMDJMIBOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EF60", Offset = "0x7C3D560", VA = "0x187C3EF60", Slot = "19")]
	public void AEGNBCCGJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F510", Offset = "0x7C3DB10", VA = "0x187C3F510", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F320", Offset = "0x7C3D920", VA = "0x187C3F320", Slot = "28")]
	public void CPBGHEOJGIH(Rigidbody JAPHJPDIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x13B8BC0", Offset = "0x13B71C0", VA = "0x1813B8BC0", Slot = "20")]
	public void KMFINJOGAMG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x13BA050", Offset = "0x13B8650", VA = "0x1813BA050", Slot = "30")]
	public void EFPPDPPKOLG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F010", Offset = "0x7C3D610", VA = "0x187C3F010", Slot = "35")]
	public Vector3 BAFJFDPAAGM(Vector3 DBLIJGKPLMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F5D0", Offset = "0x7C3DBD0", VA = "0x187C3F5D0", Slot = "34")]
	public Vector3 EKENBHPHKOJ(Vector3 HGIAGFCHLPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EF60", Offset = "0x7C3D560", VA = "0x187C3EF60", Slot = "27")]
	public void EDJHAMEFIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F570", Offset = "0x7C3DB70", VA = "0x187C3F570", Slot = "25")]
	public void EJOHHKODEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7C412B0", Offset = "0x7C3F8B0", VA = "0x187C412B0", Slot = "24")]
	public void NJADJDABIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7C41660", Offset = "0x7C3FC60", VA = "0x187C41660", Slot = "33")]
	public void OOJJBIHGABB(Vector3 IOGHHNAIODM, Vector3 GKDEKLKFMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7C414B0", Offset = "0x7C3FAB0", VA = "0x187C414B0", Slot = "32")]
	public void OCNELKPIIEL(Vector3 AFAALGOINNG, Vector3 PMBLIKDJDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FD40", Offset = "0x7C3E340", VA = "0x187C3FD40", Slot = "31")]
	public void GEGDBMJAFCD(Vector3 MJMCMBGBGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7C40B00", Offset = "0x7C3F100", VA = "0x187C40B00", Slot = "22")]
	public void LBJEHICKFOF(FFOJPNNBINM CIJGAJPJOGK, Vector3 FMNAADBCOPL, float EFHIEALGFPF, float NEKEGLHIFON = 8f, float IIPFNMPOOEO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7C40000", Offset = "0x7C3E600", VA = "0x187C40000", Slot = "21")]
	public void GHMFILLJBFH(PKKKNPNJAHH GAIPBHPLCOO, Vector3 FHCLGDCLCNG, float MMNFGNNBPMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7C41A30", Offset = "0x7C40030", VA = "0x187C41A30", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void PFFMPEONJID(PKKKNPNJAHH GAIPBHPLCOO, Vector3 MLMNPOCKAAE, float BLKFPBEEMHA = 7f, float CIDODHEEICJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x14EC3A0", Offset = "0x14EA9A0", VA = "0x1814EC3A0")]
	private static void MAHOINBPHIB(Vector3 PGIPNLMJJCH, Vector3 FGKLFPNFOKI, [Out] Vector3 OKHKMPGFDHO, [Out] Vector3 MKILBJAADNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7C41E20", Offset = "0x7C40420", VA = "0x187C41E20", Slot = "29")]
	public Vector3 PHAGPDAFEDM(Vector3 PGIPNLMJJCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C418A0", Offset = "0x7C3FEA0", VA = "0x187C418A0", Slot = "26")]
	public void PEPAHFAOHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F1F0", Offset = "0x7C3D7F0", VA = "0x187C3F1F0")]
	private void BLLEBGOJPCD(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7C41310", Offset = "0x7C3F910", VA = "0x187C41310")]
	private void NPPCCOLCDPP(Vector3 FHCLGDCLCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FEE0", Offset = "0x7C3E4E0", VA = "0x187C3FEE0")]
	private Vector3 GHICIFHINMK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3EAD0", Offset = "0x7C3D0D0", VA = "0x187C3EAD0")]
	private void ABLPNJPLMJP(Vector3 HGIAGFCHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7C40490", Offset = "0x7C3EA90", VA = "0x187C40490")]
	private Vector3 HMPAHDJCAJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7C405B0", Offset = "0x7C3EBB0", VA = "0x187C405B0")]
	private void IDAHIFFDILO(Vector3 KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F790", Offset = "0x7C3DD90", VA = "0x187C3F790")]
	private void FIKEPJPDGKH(Vector3 HGIAGFCHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7C402C0", Offset = "0x7C3E8C0", VA = "0x187C402C0")]
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
