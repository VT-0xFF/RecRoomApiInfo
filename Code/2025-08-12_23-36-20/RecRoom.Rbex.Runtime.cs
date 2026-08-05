using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE730", Offset = "0x8BAD530", VA = "0x188BAE730", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8543CB0", Offset = "0x8542AB0", VA = "0x188543CB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5F00", Offset = "0x8BB4D00", VA = "0x188BB5F00")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6210", Offset = "0x8BB5010", VA = "0x188BB6210", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6270", Offset = "0x8BB5070", VA = "0x188BB6270")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HJAKPLGAOLP, HNBEDMLJAOM, DNAFFEFDHCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ALMLLDBPKBM FBCNJMGBGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LCMECJALCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ICIJOOIDPLO ICCDNBLKPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[EOAEGKJKCPD(FBMDOBLPJCI.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[EOAEGKJKCPD(FBMDOBLPJCI.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

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
		private PBNGAEFDFBE physicsInterpolation;

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
		private Transform AAOBOGCCCPN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ICIJOOIDPLO CMGHMGMKFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1540", Offset = "0x8BB0340", VA = "0x188BB1540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ICIJOOIDPLO DDKFENBPHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int BNKCOIOMPEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB33D0", Offset = "0x8BB21D0", VA = "0x188BB33D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BEDCHDMHBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3730", Offset = "0x8BB2530", VA = "0x188BB3730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx CNGEAHLGPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3670", Offset = "0x8BB2470", VA = "0x188BB3670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PJGOIMBEKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4340", Offset = "0x8BB3140", VA = "0x188BB4340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5870", Offset = "0x8BB4670", VA = "0x188BB5870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GFIKDCHCPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x87D3BF0", Offset = "0x87D29F0", VA = "0x1887D3BF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87D5D30", Offset = "0x87D4B30", VA = "0x1887D5D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DNNOOFELIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2525830", Offset = "0x2524630", VA = "0x182525830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform HDIADDHEFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2525830", Offset = "0x2524630", VA = "0x182525830", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform ANGJBFBLBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2525830", Offset = "0x2524630", VA = "0x182525830", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CNIFHCNMKAP LPOKCMGFPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3430", Offset = "0x8BB2230", VA = "0x188BB3430")]
			get
			{
				return default(CNIFHCNMKAP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5020", Offset = "0x8BB3E20", VA = "0x188BB5020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool AOICDAFDFKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3A40", Offset = "0x8BB2840", VA = "0x188BB3A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CIGHLHEBGMA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3550", Offset = "0x8BB2350", VA = "0x188BB3550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HJKHHJEKPOI PLGKPLEHELN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3980", Offset = "0x8BB2780", VA = "0x188BB3980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB51E0", Offset = "0x8BB3FE0", VA = "0x188BB51E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HDEDPMNNDDA ILJDLEKNLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3920", Offset = "0x8BB2720", VA = "0x188BB3920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5170", Offset = "0x8BB3F70", VA = "0x188BB5170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HEFAALIBAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3870", Offset = "0x8BB2670", VA = "0x188BB3870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody JODPDMKLEFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8BB38D0", Offset = "0x8BB26D0", VA = "0x188BB38D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LMPIKOEOANH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8BB35B0", Offset = "0x8BB23B0", VA = "0x188BB35B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5090", Offset = "0x8BB3E90", VA = "0x188BB5090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AINHEIIGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1060F90", Offset = "0x105FD90", VA = "0x181060F90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HGDMGJMLPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8BB42E0", Offset = "0x8BB30E0", VA = "0x188BB42E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CFKHBHGNEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4280", Offset = "0x8BB3080", VA = "0x188BB4280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5800", Offset = "0x8BB4600", VA = "0x188BB5800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float NMDCFBMFJBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3CA0", Offset = "0x8BB2AA0", VA = "0x188BB3CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5480", Offset = "0x8BB4280", VA = "0x188BB5480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FBHEPOLIKPM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3AA0", Offset = "0x8BB28A0", VA = "0x188BB3AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5250", Offset = "0x8BB4050", VA = "0x188BB5250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AIEMDDHGAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB48C0", Offset = "0x8BB36C0", VA = "0x188BB48C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5DB0", Offset = "0x8BB4BB0", VA = "0x188BB5DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 HKFDLKHDMON
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4060", Offset = "0x8BB2E60", VA = "0x188BB4060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8BB55D0", Offset = "0x8BB43D0", VA = "0x188BB55D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 HMFFBAEIADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4A00", Offset = "0x8BB3800", VA = "0x188BB4A00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode DJBOCLCJKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3BE0", Offset = "0x8BB29E0", VA = "0x188BB3BE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8BB53A0", Offset = "0x8BB41A0", VA = "0x188BB53A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FCMKJAKFOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3610", Offset = "0x8BB2410", VA = "0x188BB3610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5100", Offset = "0x8BB3F00", VA = "0x188BB5100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints BFJLBEFIMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3C40", Offset = "0x8BB2A40", VA = "0x188BB3C40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5410", Offset = "0x8BB4210", VA = "0x188BB5410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 KKGOPHEGLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4400", Offset = "0x8BB3200", VA = "0x188BB4400")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 BIMFFLNNGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4400", Offset = "0x8BB3200", VA = "0x188BB4400")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5B90", Offset = "0x8BB4990", VA = "0x188BB5B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GONFABNGNBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4140", Offset = "0x8BB2F40", VA = "0x188BB4140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB56B0", Offset = "0x8BB44B0", VA = "0x188BB56B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float BMCOIKPNDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4860", Offset = "0x8BB3660", VA = "0x188BB4860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5D40", Offset = "0x8BB4B40", VA = "0x188BB5D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion KONDDFGKFKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB44E0", Offset = "0x8BB32E0", VA = "0x188BB44E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5910", Offset = "0x8BB4710", VA = "0x188BB5910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion PEGNMJDADJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4780", Offset = "0x8BB3580", VA = "0x188BB4780")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5C70", Offset = "0x8BB4A70", VA = "0x188BB5C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IHMENAHECAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8BB45C0", Offset = "0x8BB33C0", VA = "0x188BB45C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8BB59E0", Offset = "0x8BB47E0", VA = "0x188BB59E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion GENDBINKDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8BB46A0", Offset = "0x8BB34A0", VA = "0x188BB46A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5AC0", Offset = "0x8BB48C0", VA = "0x188BB5AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 ILLMOMMKCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4920", Offset = "0x8BB3720", VA = "0x188BB4920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5E20", Offset = "0x8BB4C20", VA = "0x188BB5E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KNLLFEKJGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8BB41A0", Offset = "0x8BB2FA0", VA = "0x188BB41A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB5720", Offset = "0x8BB4520", VA = "0x188BB5720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IGFPHPPALII
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3B00", Offset = "0x8BB2900", VA = "0x188BB3B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB52C0", Offset = "0x8BB40C0", VA = "0x188BB52C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MJIMOFHAOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3F80", Offset = "0x8BB2D80", VA = "0x188BB3F80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB54F0", Offset = "0x8BB42F0", VA = "0x188BB54F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DIDMKINGNJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3E40", Offset = "0x8BB2C40", VA = "0x188BB3E40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion BCOBPHBPFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3D60", Offset = "0x8BB2B60", VA = "0x188BB3D60")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EDOODAAFLAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4BC0", Offset = "0x8BB39C0", VA = "0x188BB4BC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 KALLGINFKLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4AE0", Offset = "0x8BB38E0", VA = "0x188BB4AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CHKCIMHGOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3F20", Offset = "0x8BB2D20", VA = "0x188BB3F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FPCJOBDJJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BB39E0", Offset = "0x8BB27E0", VA = "0x188BB39E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EFEEAPHEIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BB34F0", Offset = "0x8BB22F0", VA = "0x188BB34F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GHHJDIOAJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3490", Offset = "0x8BB2290", VA = "0x188BB3490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ACOJDDNGACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3370", Offset = "0x8BB2170", VA = "0x188BB3370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MODLOLCILPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3D00", Offset = "0x8BB2B00", VA = "0x188BB3D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KOBMDGOKJFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2705C70", Offset = "0x2704A70", VA = "0x182705C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FECAAPMBKPL CJLLCICPFKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3290", Offset = "0x8BB2090", VA = "0x188BB3290")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4F40", Offset = "0x8BB3D40", VA = "0x188BB4F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JMEGBAKHEFO JHHNDEAFDBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3000", Offset = "0x8BB1E00", VA = "0x188BB3000")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4CA0", Offset = "0x8BB3AA0", VA = "0x188BB4CA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JMEGBAKHEFO LCDCJFBNGAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3060", Offset = "0x8BB1E60", VA = "0x188BB3060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4D10", Offset = "0x8BB3B10", VA = "0x188BB4D10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JMEGBAKHEFO NFDAPPGLIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BB31B0", Offset = "0x8BB1FB0", VA = "0x188BB31B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4E60", Offset = "0x8BB3C60", VA = "0x188BB4E60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MJNFJJNDMDN, MJNFJJNDMDN> LCLBMAAGGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3140", Offset = "0x8BB1F40", VA = "0x188BB3140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4DF0", Offset = "0x8BB3BF0", VA = "0x188BB4DF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event JMEGBAKHEFO DACBLAIBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3220", Offset = "0x8BB2020", VA = "0x188BB3220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4ED0", Offset = "0x8BB3CD0", VA = "0x188BB4ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JMEGBAKHEFO IBMGCOCKKAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB3300", Offset = "0x8BB2100", VA = "0x188BB3300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4FB0", Offset = "0x8BB3DB0", VA = "0x188BB4FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JMEGBAKHEFO NIDNOEDNDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB30D0", Offset = "0x8BB1ED0", VA = "0x188BB30D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB4D80", Offset = "0x8BB3B80", VA = "0x188BB4D80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50", Slot = "8")]
		private void FKFOJJHHNEP(ICIJOOIDPLO ICNBLBLHJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1B10", Offset = "0x8BB0910", VA = "0x188BB1B10", Slot = "9")]
		public OMBFMDMEAGH GetData()
		{
			return default(OMBFMDMEAGH);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB17D0", Offset = "0x8BB05D0", VA = "0x188BB17D0")]
		internal void FNLKNGHGOAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2D30", Offset = "0x8BB1B30", VA = "0x188BB2D30")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PEIADFDMPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1860", Offset = "0x8BB0660", VA = "0x188BB1860")]
		public HJAKPLGAOLP GetChild(int JJJJBEGKNIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8BB29F0", Offset = "0x8BB17F0", VA = "0x188BB29F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FFGEJMBOODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1370", Offset = "0x8BB0170", VA = "0x188BB1370")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2C80", Offset = "0x8BB1A80", VA = "0x188BB2C80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1540", Offset = "0x8BB0340", VA = "0x188BB1540")]
		private ICIJOOIDPLO CJEOJCMEHOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1F20", Offset = "0x8BB0D20", VA = "0x188BB1F20")]
		private void MHDKBDCHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB21C0", Offset = "0x8BB0FC0", VA = "0x188BB21C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2100", Offset = "0x8BB0F00", VA = "0x188BB2100")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BB17D0", Offset = "0x8BB05D0", VA = "0x188BB17D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2160", Offset = "0x8BB0F60", VA = "0x188BB2160")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2220", Offset = "0x8BB1020", VA = "0x188BB2220")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0A20", Offset = "0x8BAF820", VA = "0x188BB0A20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2280", Offset = "0x8BB1080", VA = "0x188BB2280")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1770", Offset = "0x8BB0570", VA = "0x188BB1770")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8BB20A0", Offset = "0x8BB0EA0", VA = "0x188BB20A0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2B50", Offset = "0x8BB1950", VA = "0x188BB2B50")]
		public void SetParent(RigidbodyEx HGMAIPELJHM, bool DJFEPAFCLJM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2590", Offset = "0x8BB1390", VA = "0x188BB2590")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1BA0", Offset = "0x8BB09A0", VA = "0x188BB1BA0")]
		public bool IsRigidbodyAncestor(RigidbodyEx MGCCLFGPDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1CA0", Offset = "0x8BB0AA0", VA = "0x188BB1CA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx DMFICEDLLPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0C90", Offset = "0x8BAFA90", VA = "0x188BB0C90")]
		public void AddInterpolationRestriction(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB22F0", Offset = "0x8BB10F0", VA = "0x188BB22F0")]
		public void RemoveInterpolationRestriction(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D00", Offset = "0x8BAFB00", VA = "0x188BB0D00")]
		public void AddKinematic(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2360", Offset = "0x8BB1160", VA = "0x188BB2360")]
		public void RemoveKinematic(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2AD0", Offset = "0x8BB18D0", VA = "0x188BB2AD0")]
		public void SetKinematic(object OBGCPOCPFIJ, bool BOENCBCIEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BB28F0", Offset = "0x8BB16F0", VA = "0x188BB28F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CBHDFFLGHBJ, Quaternion JMFCAFDNPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BB27F0", Offset = "0x8BB15F0", VA = "0x188BB27F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 GEGNJDBBONG, Quaternion PAMHEICLBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1A00", Offset = "0x8BB0800", VA = "0x188BB1A00")]
		public Vector3 GetConstrainedVelocity(Vector3 ILLMOMMKCAB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BB18F0", Offset = "0x8BB06F0", VA = "0x188BB18F0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 IGFPHPPALII)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0BA0", Offset = "0x8BAF9A0", VA = "0x188BB0BA0")]
		public void AddForce(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0A90", Offset = "0x8BAF890", VA = "0x188BB0A90")]
		public void AddForceAtPosition(Vector3 PPPGPLMAHNI, Vector3 FLAPAOJCDCM, ForceMode CIFCFDNDJDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0ED0", Offset = "0x8BAFCD0", VA = "0x188BB0ED0")]
		public void AddTorque(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0D70", Offset = "0x8BAFB70", VA = "0x188BB0D70")]
		public void AddRelativeTorque(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2E00", Offset = "0x8BB1C00", VA = "0x188BB2E00")]
		public Vector3 WorldToLocalVelocity(Vector3 IOMNICHLECK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1E10", Offset = "0x8BB0C10", VA = "0x188BB1E10")]
		public Vector3 LocalToWorldVelocity(Vector3 KNLLFEKJGLJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1710", Offset = "0x8BB0510", VA = "0x188BB1710")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB16B0", Offset = "0x8BB04B0", VA = "0x188BB16B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1650", Offset = "0x8BB0450", VA = "0x188BB1650")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB15F0", Offset = "0x8BB03F0", VA = "0x188BB15F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB26F0", Offset = "0x8BB14F0", VA = "0x188BB26F0")]
		public void ResetVelocityWorldSpace(Vector3 DKBAGIDMLLA, Vector3 JOAHJHGIBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BB25F0", Offset = "0x8BB13F0", VA = "0x188BB25F0")]
		public void ResetVelocityLocalSpace(Vector3 HHPOLKLJIOE, Vector3 MJIMOFHAOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BB24B0", Offset = "0x8BB12B0", VA = "0x188BB24B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HHPOLKLJIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2C90", Offset = "0x8BB1A90", VA = "0x188BB2C90")]
		public bool SweepTest(Vector3 GHKIAFFJCCO, [Out] RaycastHit IBOKBOJEINI, float AGKOFMHMOAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1DA0", Offset = "0x8BB0BA0", VA = "0x188BB1DA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2C20", Offset = "0x8BB1A20", VA = "0x188BB2C20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2DA0", Offset = "0x8BB1BA0", VA = "0x188BB2DA0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0E60", Offset = "0x8BAFC60", VA = "0x188BB0E60")]
		public void AddShouldHaveUnityRigidbodyToken(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BB23D0", Offset = "0x8BB11D0", VA = "0x188BB23D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1200", Offset = "0x8BB0000", VA = "0x188BB1200")]
		public void ApplyForceVelocityChange(EIALNCDFAED JIFAODPPPFE, Vector3 OMELNKHNHFK, float MNOEJMMHLIN, float HCBJLIFMPGL = 8f, float FBOCAAAJEPC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1160", Offset = "0x8BAFF60", VA = "0x188BB1160")]
		public void ApplyAngularVelocityChange(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 JDMHDKLLHAP, float EDENKKIACIM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB12C0", Offset = "0x8BB00C0", VA = "0x188BB12C0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 GKEKGHNHKDP, float NBICOHADIBA = 7f, float IFFFGOPNNJH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1090", Offset = "0x8BAFE90", VA = "0x188BB1090")]
		public bool AllowedScaleChange(float IMDFPOKEEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0FC0", Offset = "0x8BAFDC0", VA = "0x188BB0FC0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KPFALAKOKCP, object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2440", Offset = "0x8BB1240", VA = "0x188BB2440")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OBGCPOCPFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB1E00", Offset = "0x8BB0C00", VA = "0x188BB1E00", Slot = "13")]
		private void KOAOGEELDGE(LDEHODDHNKL KKBNGKDBMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2F90", Offset = "0x8BB1D90", VA = "0x188BB2F90")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB49750", Offset = "0xB48550", VA = "0x180B49750", Slot = "4")]
		private GameObject KNIELBOOLLA()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "10")]
		private bool DOPDOPHOHMN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class GOAPBCALDJC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA870", Offset = "0x8BA9670", VA = "0x188BAA870")]
	public static ICIJOOIDPLO CMGHMGMKFJI(this RigidbodyEx HFFACBJLEBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(CEAFBFBKBFP), new string[] { })]
public class GBEPJBMFFOF : CEAFBFBKBFP, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OLKMHDFCDKJ OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GHCODGMGHKD IDHENFKMHDG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OLKMHDFCDKJ NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GHCODGMGHKD IJGICKDFBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA590", Offset = "0x8BA9390", VA = "0x188BAA590", Slot = "7")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA600", Offset = "0x8BA9400", VA = "0x188BAA600", Slot = "6")]
	public ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GBEPJBMFFOF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static MKAEDPHCCBC UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int EMOIHPIFFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int DADBMOOBCLI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB08A0", Offset = "0x8BAF6A0", VA = "0x188BB08A0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB08E0", Offset = "0x8BAF6E0", VA = "0x188BB08E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB08C0", Offset = "0x8BAF6C0", VA = "0x188BB08C0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JDFCBBCKOGJ, [Optional] UnityEngine.Object KKBNGKDBMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JDFCBBCKOGJ, [Optional] UnityEngine.Object KKBNGKDBMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB09D0", Offset = "0x8BAF7D0", VA = "0x188BB09D0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ENGADKELGMK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ECOGHNLHMAO : HJKHHJEKPOI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA4850", Offset = "0xAA3650", VA = "0x180AA4850", Slot = "4")]
		public Vector3 BAFAGHONHJM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA4850", Offset = "0xAA3650", VA = "0x180AA4850", Slot = "5")]
		public Vector3 PBCDICPKOAA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "6")]
		public bool PEGGKDAKCJO(float OOPEEIEHOEL, float BKIGJNHHIKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ECOGHNLHMAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static HJKHHJEKPOI AJMBFKOEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA4C0", Offset = "0x8BA92C0", VA = "0x188BAA4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DFKGODCJLIP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode OCDLLLIFNHO
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
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEIGHFAEBGB(bool CHKCIMHGOED);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJMAOEMPBAA(bool CHKCIMHGOED);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NFLLFJDNNBJ(Vector3 GHKIAFFJCCO, [Out] RaycastHit IBOKBOJEINI, float AGKOFMHMOAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AGBOLNAPJIF : IDisposable, MNPDKOKJDGI
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CNIFHCNMKAP LPOKCMGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MJNFJJNDMDN, MJNFJJNDMDN> LCLBMAAGGLJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IODAHCPKPHJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface GHCODGMGHKD
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFIKPKKHIMD ALMHEPEHGHO(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCFJDCDKIGJ CGPGDKACIEI(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FIGGMLLJLDH OKGNPAPJHAN(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPLDALMFIIN LMCEFOGGEOD(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKGINNNKGNN MBJABFCMFAN(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AGBOLNAPJIF CEAHBNFKDED(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIOEILEBAFI PKJJBHDPKOK(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NIADBHINKFK EBNLBEPDJPI(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DFKGODCJLIP ILJCHIGOGPM(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GCEPNBLCKJI CDLNGBNIKFA(ICIJOOIDPLO ICNBLBLHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OBMGPGPMFCG PECABPIKDLA(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ABAGIEDIAHN PDKDKNGECDD(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DONMCAIBHCA NKDPAHJOJDB(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PGOPGGJIJBC EIDDGIPKBCJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IGHJFFBEDLO HKNAHKKCACJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ, OMBFMDMEAGH KANAIIDGHCH, CEAFBFBKBFP EKOKCFOMOOD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIADBHINKFK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHGBMKOPJGJ(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EINLMJIPMHP(Vector3 PPPGPLMAHNI, Vector3 FLAPAOJCDCM, ForceMode CIFCFDNDJDB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJLPLBGHBLO(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAPLNIAAFCA(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GCEPNBLCKJI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OGHHPJAHPGM
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
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PFIKPKKHIMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ICIJOOIDPLO> NENGKJJAAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICIJOOIDPLO CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JMEGBAKHEFO JHHNDEAFDBM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event JMEGBAKHEFO LCDCJFBNGAN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FECAAPMBKPL CGPEGJKMJAH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HAMNLLGBKJD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CFIIAKPMKCH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ICIJOOIDPLO> KIJHKKKBBDN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ICIJOOIDPLO> ELPFLAOIOJD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action CGDBGIPCEKF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ICIJOOIDPLO> KNOLOFHPILM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CPHNKAAPMCL(ICIJOOIDPLO HNDFKDHDHKN, bool DJFEPAFCLJM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FIGGMLLJLDH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KMFNAFPIADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GCPHINBANOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJKIOHPFNK(ICIJOOIDPLO PJGOIMBEKPK, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEPMNIIGPPN(object OBGCPOCPFIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PGOPGGJIJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 GELFIBKHDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 DONGLEPOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float OIMKFACPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float HGBFFNEBENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 KGHHKCPMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion JABJILNIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JMEGBAKHEFO MMOBFHNIEEB;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IIABJNALIAE((Quaternion rot, Vector3 moments) FFGEJMBOODN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FBDIEOIMINN();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LBJDPALFFDD();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GOKOCGBDLAN();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void APBNNHFDBAH();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DONMCAIBHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFBLDAMLOHA(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIBOFFANELO(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJKPEAHAPHK(ICIJOOIDPLO HFFACBJLEBJ);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCGJMBOEAOM(ICIJOOIDPLO HFFACBJLEBJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GCALPCPLJKN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AIOEILEBAFI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MMHELOIBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JMEGBAKHEFO LJIIBIIGEMA;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEECNOBFPAD(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLHEGDMHMJB(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGGKMJIFAEK(object OBGCPOCPFIJ, bool BOENCBCIEDN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCAHAFKMMDD(Rigidbody BKNONEHIOEE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ABAGIEDIAHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AOICDAFDFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CIGHLHEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JMEGBAKHEFO CGEGEONHKCN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFEKCNDJNHO(ICIJOOIDPLO PJGOIMBEKPK);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COBAABADAKB(ICIJOOIDPLO PJGOIMBEKPK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IGHJFFBEDLO
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LMPIKOEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KJPAJACDMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints DNCDKBPLHKO
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
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CPLDALMFIIN
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float FEKALCDLCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float CLLEGFGGHPA
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
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IKGINNNKGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool DOFKLALNMFF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JMEGBAKHEFO HPLGMEHICDJ;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BMOPIGAAFGK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBILIHICDAB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFNAGEOMFHF();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DLAJFDDJNJC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OCJMFJICPMH();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BJMOKBLNGIL(bool IAHHNPMOKEI);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKCHJGAFNFD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBMGPGPMFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool OJINKDHDJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKIIELENDBN(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPMHAGFBAHA(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAFCMLBJAEC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KCFJDCDKIGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	HJKHHJEKPOI PLGKPLEHELN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	HDEDPMNNDDA ILJDLEKNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 CAGGGBMOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 FDHPBGDOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 FJGNNHBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 MNCHFCFEIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float FCMKJAKFOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool HEFAALIBAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IODAHCPKPHJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LPAGIEHMLAH(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JPLOGPCODMP(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 JDMHDKLLHAP, float EDENKKIACIM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OFPMGDLCIOE(EIALNCDFAED JIFAODPPPFE, Vector3 OMELNKHNHFK, float MNOEJMMHLIN, float HCBJLIFMPGL = 8f, float FBOCAAAJEPC = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OJCFFIOELDH(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 GKEKGHNHKDP, float NBICOHADIBA = 7f, float IFFFGOPNNJH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LLDDJIOAAIN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MODAEGGGNDJ();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LFHCDCJMDHL();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PEGMHEODBFG();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KCLENONKJJK(Vector3 ILLMOMMKCAB);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCDGFOFPAOJ(object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DNJACAMCJPF(Vector3 MLKGMLAMDCD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CELGCOPHAIP(Vector3 HHPOLKLJIOE, Vector3 MJIMOFHAOMF);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GDLIHAANJDK(Vector3 DKBAGIDMLLA, Vector3 JOAHJHGIBFJ);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FPBOIOAPFGJ(Vector3 KNLLFEKJGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FMJOKGDDFLD(Vector3 IOMNICHLECK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface OLKMHDFCDKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DMDBMEHEMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMKHAKIJNPB(string DFOJBJDIKPM);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNBFEMDGLAJ(RigidbodyEx HFFACBJLEBJ, Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CABGLNELPPL OGEKGNMEFKM(int LCHMNBIIPHC);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOCJICNEHFB(Vector3 HMFFBAEIADG, float JFJICKGELNG, Color BGBIPHDMBPB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface CEAFBFBKBFP
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	OLKMHDFCDKJ NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GHCODGMGHKD IJGICKDFBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CHMGFLEKPPI : ICIJOOIDPLO, IDisposable, NLFKPJNKOEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool ODEGIACFLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly CEAFBFBKBFP EKOKCFOMOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal PFIKPKKHIMD PMABOMPCCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DONMCAIBHCA MBDPAPMMDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ABAGIEDIAHN FIKBMLHDOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal KCFJDCDKIGJ ILLMOMMKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FIGGMLLJLDH BCEHDEGBHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal PGOPGGJIJBC EEHOPGBHGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal CPLDALMFIIN KEJKHEGAODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal GCEPNBLCKJI MKAJDFNLJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal IKGINNNKGNN JPGGFGNJFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal AGBOLNAPJIF ABBCCHNEPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal AIOEILEBAFI ADFBDGNKGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal NIADBHINKFK PPPGPLMAHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IGHJFFBEDLO KBPHGJMBOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal OBMGPGPMFCG HPBIMOMPCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DFKGODCJLIP NANEEHPMLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable JPNGBHGIMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LFHNCCEMOPO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public CLPADLABDGI FEMENMLHDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "22")]
		get
		{
			return default(CLPADLABDGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HJAKPLGAOLP ONODMNHNEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject AHIOLNHEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA1F20", VA = "0x180AA3120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BA05A0", Offset = "0x8B9F3A0", VA = "0x188BA05A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA24F0", Offset = "0x8BA12F0", VA = "0x188BA24F0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FAE0", Offset = "0x8B9E8E0", VA = "0x188B9FAE0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BNKCOIOMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA29B0", Offset = "0x8BA17B0", VA = "0x188BA29B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ICIJOOIDPLO CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA39B0", Offset = "0x8BA27B0", VA = "0x188BA39B0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DIDGIOCFILP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FDA0", Offset = "0x8B9EBA0", VA = "0x188B9FDA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool AOICDAFDFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1900", Offset = "0x8BA0700", VA = "0x188BA1900", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool CIGHLHEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8BA34C0", Offset = "0x8BA22C0", VA = "0x188BA34C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HJKHHJEKPOI PLGKPLEHELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E990", Offset = "0x8B9D790", VA = "0x188B9E990", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3380", Offset = "0x8BA2180", VA = "0x188BA3380", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HDEDPMNNDDA ILJDLEKNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8BA16D0", Offset = "0x8BA04D0", VA = "0x188BA16D0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4580", Offset = "0x8BA3380", VA = "0x188BA4580", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float FCMKJAKFOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FCA0", Offset = "0x8B9EAA0", VA = "0x188B9FCA0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E6B0", Offset = "0x8B9D4B0", VA = "0x188B9E6B0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 FDHPBGDOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3570", Offset = "0x8BA2370", VA = "0x188BA3570", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA26F0", Offset = "0x8BA14F0", VA = "0x188BA26F0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MNCHFCFEIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2F20", Offset = "0x8BA1D20", VA = "0x188BA2F20", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0CA0", Offset = "0x8B9FAA0", VA = "0x188BA0CA0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 CAGGGBMOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EEF0", Offset = "0x8B9DCF0", VA = "0x188B9EEF0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FFB0", Offset = "0x8B9EDB0", VA = "0x188B9FFB0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 FJGNNHBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2A70", Offset = "0x8BA1870", VA = "0x188BA2A70", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8BA28D0", Offset = "0x8BA16D0", VA = "0x188BA28D0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EFEEAPHEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2D30", Offset = "0x8BA1B30", VA = "0x188BA2D30", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool GHHJDIOAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2540", Offset = "0x8BA1340", VA = "0x188BA2540", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool ACOJDDNGACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B40", Offset = "0x8BA2940", VA = "0x188BA3B40", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool HEFAALIBAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8BA26A0", Offset = "0x8BA14A0", VA = "0x188BA26A0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 KMFNAFPIADI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3C20", Offset = "0x8BA2A20", VA = "0x188BA3C20", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GCPHINBANOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA19B0", Offset = "0x8BA07B0", VA = "0x188BA19B0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 GELFIBKHDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA02C0", Offset = "0x8B9F0C0", VA = "0x188BA02C0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3F10", Offset = "0x8BA2D10", VA = "0x188BA3F10", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 DONGLEPOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1CF0", Offset = "0x8BA0AF0", VA = "0x188BA1CF0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OIMKFACPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0100", Offset = "0x8B9EF00", VA = "0x188BA0100", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float HGBFFNEBENA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1A90", Offset = "0x8BA0890", VA = "0x188BA1A90", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3A90", Offset = "0x8BA2890", VA = "0x188BA3A90", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 KGHHKCPMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3070", Offset = "0x8BA1E70", VA = "0x188BA3070", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion JABJILNIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2C10", Offset = "0x8BA1A10", VA = "0x188BA2C10", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float FEKALCDLCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4920", Offset = "0x8BA3720", VA = "0x188BA4920", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0C40", Offset = "0x8B9FA40", VA = "0x188BA0C40", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float CLLEGFGGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1BC0", Offset = "0x8BA09C0", VA = "0x188BA1BC0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3EB0", Offset = "0x8BA2CB0", VA = "0x188BA3EB0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool OGHHPJAHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA36A0", Offset = "0x8BA24A0", VA = "0x188BA36A0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EE30", Offset = "0x8B9DC30", VA = "0x188B9EE30", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CNIFHCNMKAP LPOKCMGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4820", Offset = "0x8BA3620", VA = "0x188BA4820", Slot = "70")]
		get
		{
			return default(CNIFHCNMKAP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4970", Offset = "0x8BA3770", VA = "0x188BA4970", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool MMHELOIBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3AF0", Offset = "0x8BA28F0", VA = "0x188BA3AF0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform ANGJBFBLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 HFBGBKOKOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4770", Offset = "0x8BA3570", VA = "0x188BA4770", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0210", Offset = "0x8B9F010", VA = "0x188BA0210", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float CGECDOCGIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2BB0", Offset = "0x8BA19B0", VA = "0x188BA2BB0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3A00", Offset = "0x8BA2800", VA = "0x188BA3A00", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FABENJOFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3060", Offset = "0x8BA1E60", VA = "0x188BA3060", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3CF0", Offset = "0x8BA2AF0", VA = "0x188BA3CF0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MNHIMFBCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA07C0", Offset = "0x8B9F5C0", VA = "0x188BA07C0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA15F0", Offset = "0x8BA03F0", VA = "0x188BA15F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 FEDOCAEMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA17B0", Offset = "0x8BA05B0", VA = "0x188BA17B0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1720", Offset = "0x8BA0520", VA = "0x188BA1720", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion DILMENNOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA38D0", Offset = "0x8BA26D0", VA = "0x188BA38D0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA17F0", Offset = "0x8BA05F0", VA = "0x188BA17F0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints DNCDKBPLHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA06F0", Offset = "0x8B9F4F0", VA = "0x188BA06F0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1060", Offset = "0x8B9FE60", VA = "0x188BA1060", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool LMPIKOEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EFD0", Offset = "0x8B9DDD0", VA = "0x188B9EFD0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA25A0", Offset = "0x8BA13A0", VA = "0x188BA25A0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode OCDLLLIFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2A20", Offset = "0x8BA1820", VA = "0x188BA2A20", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BA48C0", Offset = "0x8BA36C0", VA = "0x188BA48C0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LONGAAOILIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1E30", Offset = "0x8BA0C30", VA = "0x188BA1E30", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool FPCJOBDJJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F020", Offset = "0x8B9DE20", VA = "0x188B9F020", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event JMEGBAKHEFO JHHNDEAFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1DD0", Offset = "0x8BA0BD0", VA = "0x188BA1DD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E930", Offset = "0x8B9D730", VA = "0x188B9E930", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event JMEGBAKHEFO LCDCJFBNGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8BA01B0", Offset = "0x8B9EFB0", VA = "0x188BA01B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4BD0", Offset = "0x8BA39D0", VA = "0x188BA4BD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FECAAPMBKPL CGPEGJKMJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3000", Offset = "0x8BA1E00", VA = "0x188BA3000", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EE90", Offset = "0x8B9DC90", VA = "0x188B9EE90", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event JMEGBAKHEFO CGEGEONHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2B50", Offset = "0x8BA1950", VA = "0x188BA2B50", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3510", Offset = "0x8BA2310", VA = "0x188BA3510", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event JMEGBAKHEFO NFDAPPGLIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1950", Offset = "0x8BA0750", VA = "0x188BA1950", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3290", Offset = "0x8BA2090", VA = "0x188BA3290", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event JMEGBAKHEFO HPLGMEHICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4110", Offset = "0x8BA2F10", VA = "0x188BA4110", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E650", Offset = "0x8B9D450", VA = "0x188B9E650", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MJNFJJNDMDN, MJNFJJNDMDN> LCLBMAAGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA40B0", Offset = "0x8BA2EB0", VA = "0x188BA40B0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0BE0", Offset = "0x8B9F9E0", VA = "0x188BA0BE0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event JMEGBAKHEFO LJIIBIIGEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2370", Offset = "0x8BA1170", VA = "0x188BA2370", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0150", Offset = "0x8B9EF50", VA = "0x188BA0150", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event JMEGBAKHEFO NIDNOEDNDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0410", Offset = "0x8B9F210", VA = "0x188BA0410", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3820", Offset = "0x8BA2620", VA = "0x188BA3820", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4C70", Offset = "0x8BA3A70", VA = "0x188BA4C70")]
	public CHMGFLEKPPI(GameObject DFFAMKHOIDB, RigidbodyEx HPOKMIJOFPG, CEAFBFBKBFP EKOKCFOMOOD, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F520", Offset = "0x8B9E320", VA = "0x188B9F520", Slot = "139")]
	protected virtual void BJGBINPOJGP(CEAFBFBKBFP EKOKCFOMOOD, OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA05F0", Offset = "0x8B9F3F0", VA = "0x188BA05F0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1FD0", Offset = "0x8BA0DD0", VA = "0x188BA1FD0", Slot = "93")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA32F0", Offset = "0x8BA20F0", VA = "0x188BA32F0", Slot = "94")]
	public void MDBAGKDBGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA14C0", Offset = "0x8BA02C0", VA = "0x188BA14C0", Slot = "95")]
	public void GEOHBDNPMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4BB0", Offset = "0x8BA39B0", VA = "0x188BA4BB0", Slot = "96")]
	public void PMIBHIGFNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F810", Offset = "0x8B9E610", VA = "0x188B9F810")]
	private void BJMOKBLNGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0740", Offset = "0x8B9F540", VA = "0x188BA0740")]
	private void EFCCLCHMKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3E50", Offset = "0x8BA2C50", VA = "0x188BA3E50")]
	private void OCJMFJICPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FE00", Offset = "0x8B9EC00", VA = "0x188B9FE00", Slot = "30")]
	public ICIJOOIDPLO CLANCDICICN(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0090", Offset = "0x8B9EE90", VA = "0x188BA0090", Slot = "98")]
	public void CPHNKAAPMCL(ICIJOOIDPLO HGMAIPELJHM, bool DJFEPAFCLJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3DF0", Offset = "0x8BA2BF0", VA = "0x188BA3DF0", Slot = "99")]
	public void OAKHHFBPMOG(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1370", Offset = "0x8BA0170", VA = "0x188BA1370", Slot = "100")]
	public void GAFLLKMHKBI(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0F60", Offset = "0x8B9FD60", VA = "0x188BA0F60", Slot = "101")]
	public Vector3 FMJOKGDDFLD(Vector3 IOMNICHLECK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1270", Offset = "0x8BA0070", VA = "0x188BA1270", Slot = "102")]
	public Vector3 FPBOIOAPFGJ(Vector3 KNLLFEKJGLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4870", Offset = "0x8BA3670", VA = "0x188BA4870", Slot = "103")]
	public void PEGMHEODBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3650", Offset = "0x8BA2450", VA = "0x188BA3650", Slot = "104")]
	public void MODAEGGGNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2ED0", Offset = "0x8BA1CD0", VA = "0x188BA2ED0", Slot = "105")]
	public void LLDDJIOAAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA13D0", Offset = "0x8BA01D0", VA = "0x188BA13D0", Slot = "106")]
	public void GDLIHAANJDK(Vector3 DKBAGIDMLLA, Vector3 JOAHJHGIBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FBB0", Offset = "0x8B9E9B0", VA = "0x188B9FBB0", Slot = "107")]
	public void CELGCOPHAIP(Vector3 HHPOLKLJIOE, Vector3 MJIMOFHAOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8BA04C0", Offset = "0x8B9F2C0", VA = "0x188BA04C0", Slot = "108")]
	public void DNJACAMCJPF(Vector3 MLKGMLAMDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3FF0", Offset = "0x8BA2DF0", VA = "0x188BA3FF0", Slot = "109")]
	public void OFPMGDLCIOE(EIALNCDFAED JIFAODPPPFE, Vector3 OMELNKHNHFK, float MNOEJMMHLIN, float HCBJLIFMPGL = 8f, float FBOCAAAJEPC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2600", Offset = "0x8BA1400", VA = "0x188BA2600", Slot = "110")]
	public void JPLOGPCODMP(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 JDMHDKLLHAP, float EDENKKIACIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4170", Offset = "0x8BA2F70", VA = "0x188BA4170", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OJCFFIOELDH(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 GKEKGHNHKDP, float NBICOHADIBA = 7f, float IFFFGOPNNJH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA27D0", Offset = "0x8BA15D0", VA = "0x188BA27D0", Slot = "112")]
	public Vector3 KCLENONKJJK(Vector3 HGMAIPELJHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2D80", Offset = "0x8BA1B80", VA = "0x188BA2D80", Slot = "113")]
	public Vector3 LCJGHOEKEGG(Vector3 HGMAIPELJHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2E80", Offset = "0x8BA1C80", VA = "0x188BA2E80", Slot = "114")]
	public void LFHCDCJMDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FB40", Offset = "0x8B9E940", VA = "0x188B9FB40", Slot = "115")]
	public void CDHBCLGNKJL(ICIJOOIDPLO KPFALAKOKCP, object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FE80", Offset = "0x8B9EC80", VA = "0x188B9FE80", Slot = "116")]
	public void CNBLGEABPFP(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1C10", Offset = "0x8BA0A10", VA = "0x188BA1C10", Slot = "63")]
	public void IIABJNALIAE((Quaternion rot, Vector3 moments) FFGEJMBOODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2CE0", Offset = "0x8BA1AE0", VA = "0x188BA2CE0", Slot = "117")]
	public void LBJDPALFFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0D80", Offset = "0x8B9FB80", VA = "0x188BA0D80", Slot = "118")]
	public void FBDIEOIMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1760", Offset = "0x8BA0560", VA = "0x188BA1760", Slot = "119")]
	public void GOKOCGBDLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FA90", Offset = "0x8B9E890", VA = "0x188B9FA90", Slot = "120")]
	public bool BMOPIGAAFGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3470", Offset = "0x8BA2270", VA = "0x188BA3470", Slot = "97")]
	public void MFNAGEOMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA03A0", Offset = "0x8B9F1A0", VA = "0x188BA03A0", Slot = "121")]
	public void DKCHJGAFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0DD0", Offset = "0x8B9FBD0", VA = "0x188BA0DD0", Slot = "122")]
	public void FEECNOBFPAD(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BA45E0", Offset = "0x8BA33E0", VA = "0x188BA45E0", Slot = "123")]
	public void OLHEGDMHMJB(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0860", Offset = "0x8B9F660", VA = "0x188BA0860", Slot = "124")]
	public void EGGKMJIFAEK(object OBGCPOCPFIJ, bool BOENCBCIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA09E0", Offset = "0x8B9F7E0", VA = "0x188BA09E0", Slot = "125")]
	public void EKAGGIGKOMD(Vector3 CBHDFFLGHBJ, Quaternion JMFCAFDNPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4640", Offset = "0x8BA3440", VA = "0x188BA4640", Slot = "126")]
	public void OLNCKEDFOOO(Vector3 GEGNJDBBONG, Quaternion PAMHEICLBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2BC0", Offset = "0x8BA19C0", VA = "0x188BA2BC0", Slot = "127")]
	public bool KNNBJPPMOOF(float IMDFPOKEEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1F70", Offset = "0x8BA0D70", VA = "0x188BA1F70", Slot = "128")]
	public void INEHOCHMNLA(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0F00", Offset = "0x8B9FD00", VA = "0x188BA0F00", Slot = "129")]
	public void FFDKKHOAIPO(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E880", Offset = "0x8B9D680", VA = "0x188B9E880", Slot = "130")]
	public void AKIIELENDBN(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3150", Offset = "0x8BA1F50", VA = "0x188BA3150", Slot = "131")]
	public void LPMHAGFBAHA(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1AE0", Offset = "0x8BA08E0", VA = "0x188BA1AE0", Slot = "132")]
	public void IHGBMKOPJGJ(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8BA08D0", Offset = "0x8B9F6D0", VA = "0x188BA08D0", Slot = "133")]
	public void EINLMJIPMHP(Vector3 PPPGPLMAHNI, Vector3 FLAPAOJCDCM, ForceMode CIFCFDNDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1820", Offset = "0x8BA0620", VA = "0x188BA1820", Slot = "134")]
	public void HJLPLBGHBLO(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA31B0", Offset = "0x8BA1FB0", VA = "0x188BA31B0", Slot = "135")]
	public void MAPLNIAAFCA(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3910", Offset = "0x8BA2710", VA = "0x188BA3910", Slot = "136")]
	public bool NFLLFJDNNBJ(Vector3 GHKIAFFJCCO, [Out] RaycastHit IBOKBOJEINI, float AGKOFMHMOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E8E0", Offset = "0x8B9D6E0", VA = "0x188B9E8E0", Slot = "137")]
	public void APBNNHFDBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4C30", Offset = "0x8BA3A30", VA = "0x188BA4C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA0E30", Offset = "0x8B9FC30", VA = "0x188BA0E30")]
	private void FFCLDCLKCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2260", Offset = "0x8BA1060", VA = "0x188BA2260")]
	private void JCHFNODFAAO(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA49D0", Offset = "0x8BA37D0", VA = "0x188BA49D0")]
	private void PLAIMDGAGGA(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FCF0", Offset = "0x8B9EAF0", VA = "0x188B9FCF0")]
	private void CIBCAFFONNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA23D0", Offset = "0x8BA11D0", VA = "0x188BA23D0")]
	private void JJOJJOEJGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA10C0", Offset = "0x8B9FEC0", VA = "0x188BA10C0")]
	private void FOGALEPAONJ(ICIJOOIDPLO POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8BA1520", Offset = "0x8BA0320", VA = "0x188BA1520")]
	private void GFEKCNDJNHO(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8B9FEE0", Offset = "0x8B9ECE0", VA = "0x188B9FEE0")]
	private void COBAABADAKB(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA2110", Offset = "0x8BA0F10", VA = "0x188BA2110")]
	private void JAKOFFCOAMG(HJAKPLGAOLP PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E9E0", Offset = "0x8B9D7E0", VA = "0x188B9E9E0", Slot = "142")]
	protected virtual void BBJCBPKPDDK(HJAKPLGAOLP HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4220", Offset = "0x8BA3020", VA = "0x188BA4220")]
	protected void OJDKDNMHKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8B9F1A0", Offset = "0x8B9DFA0", VA = "0x188B9F1A0")]
	protected void BGIKNEIKJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8BA36F0", Offset = "0x8BA24F0", VA = "0x188BA36F0")]
	private void NBFNNJNONAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E710", Offset = "0x8B9D510", VA = "0x188B9E710")]
	private void AIFCLNPPIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class NOEKFLHBODM
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFEB0", Offset = "0x8BAECB0", VA = "0x188BAFEB0")]
	public static ICIJOOIDPLO EBHLCKNPBHH(this ICIJOOIDPLO HFFACBJLEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFF70", Offset = "0x8BAED70", VA = "0x188BAFF70")]
	public static bool NBODMHPIOAI(this ICIJOOIDPLO HFFACBJLEBJ, ICIJOOIDPLO MGCCLFGPDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFDC0", Offset = "0x8BAEBC0", VA = "0x188BAFDC0")]
	public static bool BNJBAIPAMJH(this ICIJOOIDPLO HFFACBJLEBJ, ICIJOOIDPLO DMFICEDLLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFE60", Offset = "0x8BAEC60", VA = "0x188BAFE60")]
	public static HJAKPLGAOLP CJKCGDEAOGA(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0010", Offset = "0x8BAEE10", VA = "0x188BB0010")]
	public static CHMGFLEKPPI PAKJBGDONEG(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PHABIHOONKC : GHCODGMGHKD
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0800", Offset = "0x8BAF600", VA = "0x188BB0800", Slot = "19")]
	public ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ, OMBFMDMEAGH KANAIIDGHCH, CEAFBFBKBFP EKOKCFOMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "4")]
	public PFIKPKKHIMD ALMHEPEHGHO(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "5")]
	public KCFJDCDKIGJ CGPGDKACIEI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
	public FIGGMLLJLDH OKGNPAPJHAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "7")]
	public CPLDALMFIIN LMCEFOGGEOD(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "8")]
	public IKGINNNKGNN MBJABFCMFAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "9")]
	public AGBOLNAPJIF CEAHBNFKDED(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "10")]
	public AIOEILEBAFI PKJJBHDPKOK(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "11")]
	public NIADBHINKFK EBNLBEPDJPI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "12")]
	public DFKGODCJLIP ILJCHIGOGPM(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "13")]
	public GCEPNBLCKJI CDLNGBNIKFA(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public OBMGPGPMFCG PECABPIKDLA(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public ABAGIEDIAHN PDKDKNGECDD(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public DONMCAIBHCA NKDPAHJOJDB(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public PGOPGGJIJBC EIDDGIPKBCJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public IGHJFFBEDLO HKNAHKKCACJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PHABIHOONKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "14")]
	private OBMGPGPMFCG GJKCLOKMCEK(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "15")]
	private ABAGIEDIAHN DLOLJLHCLEJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "16")]
	private DONMCAIBHCA BMLBBBKMEKG(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "17")]
	private PGOPGGJIJBC JALGBONBJNM(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "18")]
	private IGHJFFBEDLO GOAANOLLACF(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(GHCODGMGHKD), new string[] { })]
public class KJGBJGGHFOF : GHCODGMGHKD, CMKJLANCAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GHCODGMGHKD KOHIFJADDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GHCODGMGHKD OJHLMPGNBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private FCPFAFNBCNH EAMJDLHKFFI;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private GHCODGMGHKD IJGICKDFBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD630", Offset = "0x8BAC430", VA = "0x188BAD630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD5E0", Offset = "0x8BAC3E0", VA = "0x188BAD5E0", Slot = "20")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8BACEB0", Offset = "0x8BABCB0", VA = "0x188BACEB0", Slot = "4")]
	public PFIKPKKHIMD ALMHEPEHGHO(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD140", Offset = "0x8BABF40", VA = "0x188BAD140", Slot = "5")]
	public KCFJDCDKIGJ CGPGDKACIEI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD8B0", Offset = "0x8BAC6B0", VA = "0x188BAD8B0", Slot = "6")]
	public FIGGMLLJLDH OKGNPAPJHAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD690", Offset = "0x8BAC490", VA = "0x188BAD690", Slot = "7")]
	public CPLDALMFIIN LMCEFOGGEOD(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD730", Offset = "0x8BAC530", VA = "0x188BAD730", Slot = "8")]
	public IKGINNNKGNN MBJABFCMFAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD0A0", Offset = "0x8BABEA0", VA = "0x188BAD0A0", Slot = "9")]
	public AGBOLNAPJIF CEAHBNFKDED(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD950", Offset = "0x8BAC750", VA = "0x188BAD950", Slot = "10")]
	public AIOEILEBAFI PKJJBHDPKOK(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD290", Offset = "0x8BAC090", VA = "0x188BAD290", Slot = "11")]
	public NIADBHINKFK EBNLBEPDJPI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD540", Offset = "0x8BAC340", VA = "0x188BAD540", Slot = "12")]
	public DFKGODCJLIP ILJCHIGOGPM(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD000", Offset = "0x8BABE00", VA = "0x188BAD000", Slot = "13")]
	public GCEPNBLCKJI CDLNGBNIKFA(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD3E0", Offset = "0x8BAC1E0", VA = "0x188BAD3E0")]
	public OBMGPGPMFCG PECABPIKDLA(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD1E0", Offset = "0x8BABFE0", VA = "0x188BAD1E0")]
	public ABAGIEDIAHN PDKDKNGECDD(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8BACF50", Offset = "0x8BABD50", VA = "0x188BACF50")]
	public DONMCAIBHCA NKDPAHJOJDB(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD330", Offset = "0x8BAC130", VA = "0x188BAD330")]
	public PGOPGGJIJBC EIDDGIPKBCJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD490", Offset = "0x8BAC290", VA = "0x188BAD490")]
	public IGHJFFBEDLO HKNAHKKCACJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD7D0", Offset = "0x8BAC5D0", VA = "0x188BAD7D0", Slot = "19")]
	public ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ, OMBFMDMEAGH KANAIIDGHCH, CEAFBFBKBFP EKOKCFOMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD9F0", Offset = "0x8BAC7F0", VA = "0x188BAD9F0")]
	public KJGBJGGHFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD3E0", Offset = "0x8BAC1E0", VA = "0x188BAD3E0", Slot = "14")]
	private OBMGPGPMFCG GJKCLOKMCEK(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD1E0", Offset = "0x8BABFE0", VA = "0x188BAD1E0", Slot = "15")]
	private ABAGIEDIAHN DLOLJLHCLEJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8BACF50", Offset = "0x8BABD50", VA = "0x188BACF50", Slot = "16")]
	private DONMCAIBHCA BMLBBBKMEKG(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD330", Offset = "0x8BAC130", VA = "0x188BAD330", Slot = "17")]
	private PGOPGGJIJBC JALGBONBJNM(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD490", Offset = "0x8BAC290", VA = "0x188BAD490", Slot = "18")]
	private IGHJFFBEDLO GOAANOLLACF(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NIAMNMIOLLP : PFIKPKKHIMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGFALDPOFMH(ICIJOOIDPLO HFFACBJLEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKLNKCOCMLJ(ICIJOOIDPLO HFFACBJLEBJ);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADCPDPCLEHG(ICIJOOIDPLO POAGCKPNEPL);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNPDLPKDMLJ(ICIJOOIDPLO POAGCKPNEPL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GPOPOINMFHL : FIGGMLLJLDH
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	AKJJENAIBLI<ICIJOOIDPLO> APPBBJOLBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ICIJOOIDPLO FEJOHBPGMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NMNBBBJBMFB : PGOPGGJIJBC
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PBCGFCJDPBH(Rigidbody LLGKCAHHIDO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BEDEMKMAHHI : ABAGIEDIAHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView KBGFIGKELPK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MHNGGGMFPIG : DFKGODCJLIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode CMLEFPAIKHE;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4D60", Offset = "0x8BA3B60", VA = "0x188BA4D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode OCDLLLIFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEBC0", Offset = "0x8BAD9C0", VA = "0x188BAEBC0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEE40", Offset = "0x8BADC40", VA = "0x188BAEE40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5AC0", Offset = "0x8BA48C0", VA = "0x188BA5AC0")]
	public MHNGGGMFPIG(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAEA30", Offset = "0x8BAD830", VA = "0x188BAEA30", Slot = "6")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAEB40", Offset = "0x8BAD940", VA = "0x188BAEB40", Slot = "9")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8BAECD0", Offset = "0x8BADAD0", VA = "0x188BAECD0", Slot = "7")]
	public void NEIGHFAEBGB(bool CHKCIMHGOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE900", Offset = "0x8BAD700", VA = "0x188BAE900", Slot = "8")]
	public void BJMAOEMPBAA(bool CHKCIMHGOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8BAECE0", Offset = "0x8BADAE0", VA = "0x188BAECE0", Slot = "10")]
	public bool NFLLFJDNNBJ(Vector3 GHKIAFFJCCO, [Out] RaycastHit IBOKBOJEINI, float AGKOFMHMOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE910", Offset = "0x8BAD710", VA = "0x188BAE910")]
	private void INKJAGHJANN(bool CHKCIMHGOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ONBGLPGDELJ : AGBOLNAPJIF, IDisposable, MNPDKOKJDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CNIFHCNMKAP OKBCJKIDBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private CABGLNELPPL DPLHENMJKML;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CNIFHCNMKAP LPOKCMGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0560", Offset = "0x8BAF360", VA = "0x188BB0560", Slot = "6")]
		get
		{
			return default(CNIFHCNMKAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8BB06A0", Offset = "0x8BAF4A0", VA = "0x188BB06A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform MLGLAMMCOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE48D40", Offset = "0xE47B40", VA = "0x180E48D40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MJNFJJNDMDN, MJNFJJNDMDN> LCLBMAAGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8BB04B0", Offset = "0x8BAF2B0", VA = "0x188BB04B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0190", Offset = "0x8BAEF90", VA = "0x188BB0190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0770", Offset = "0x8BAF570", VA = "0x188BB0770")]
	public ONBGLPGDELJ(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0240", Offset = "0x8BAF040", VA = "0x188BB0240", Slot = "8")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0140", Offset = "0x8BAEF40", VA = "0x188BB0140", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1363990", Offset = "0x1362790", VA = "0x181363990", Slot = "11")]
	private void AKNCMHFGAHJ(MJNFJJNDMDN PDIFOFGFMHL, MJNFJJNDMDN BBLONHDPPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
	private void HLJCLPBPKHK(bool KNNGNJNFEBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KBPIEIANIFE : GHCODGMGHKD
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB930", Offset = "0x8BAA730", VA = "0x188BAB930", Slot = "4")]
	public PFIKPKKHIMD ALMHEPEHGHO(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8BABCE0", Offset = "0x8BAAAE0", VA = "0x188BABCE0", Slot = "5")]
	public KCFJDCDKIGJ CGPGDKACIEI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC760", Offset = "0x8BAB560", VA = "0x188BAC760", Slot = "6")]
	public FIGGMLLJLDH OKGNPAPJHAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC4C0", Offset = "0x8BAB2C0", VA = "0x188BAC4C0", Slot = "7")]
	public CPLDALMFIIN LMCEFOGGEOD(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC540", Offset = "0x8BAB340", VA = "0x188BAC540", Slot = "8")]
	public IKGINNNKGNN MBJABFCMFAN(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8BABC10", Offset = "0x8BAAA10", VA = "0x188BABC10", Slot = "9")]
	public AGBOLNAPJIF CEAHBNFKDED(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC890", Offset = "0x8BAB690", VA = "0x188BAC890", Slot = "10")]
	public AIOEILEBAFI PKJJBHDPKOK(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8BABF90", Offset = "0x8BAAD90", VA = "0x188BABF90", Slot = "11")]
	public NIADBHINKFK EBNLBEPDJPI(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC400", Offset = "0x8BAB200", VA = "0x188BAC400", Slot = "12")]
	public DFKGODCJLIP ILJCHIGOGPM(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8BABB50", Offset = "0x8BAA950", VA = "0x188BABB50", Slot = "13")]
	public GCEPNBLCKJI CDLNGBNIKFA(ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC1E0", Offset = "0x8BAAFE0", VA = "0x188BAC1E0")]
	public OBMGPGPMFCG PECABPIKDLA(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8BABE00", Offset = "0x8BAAC00", VA = "0x188BABE00")]
	public ABAGIEDIAHN PDKDKNGECDD(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8BABA20", Offset = "0x8BAA820", VA = "0x188BABA20")]
	public DONMCAIBHCA NKDPAHJOJDB(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC050", Offset = "0x8BAAE50", VA = "0x188BAC050")]
	public PGOPGGJIJBC EIDDGIPKBCJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC320", Offset = "0x8BAB120", VA = "0x188BAC320")]
	public IGHJFFBEDLO HKNAHKKCACJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC610", Offset = "0x8BAB410", VA = "0x188BAC610", Slot = "19")]
	public ICIJOOIDPLO MIEIOAGELFD(RigidbodyEx HFFACBJLEBJ, OMBFMDMEAGH KANAIIDGHCH, CEAFBFBKBFP EKOKCFOMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KBPIEIANIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC1E0", Offset = "0x8BAAFE0", VA = "0x188BAC1E0", Slot = "14")]
	private OBMGPGPMFCG GJKCLOKMCEK(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8BABE00", Offset = "0x8BAAC00", VA = "0x188BABE00", Slot = "15")]
	private ABAGIEDIAHN DLOLJLHCLEJ(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8BABA20", Offset = "0x8BAA820", VA = "0x188BABA20", Slot = "16")]
	private DONMCAIBHCA BMLBBBKMEKG(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC050", Offset = "0x8BAAE50", VA = "0x188BAC050", Slot = "17")]
	private PGOPGGJIJBC JALGBONBJNM(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC320", Offset = "0x8BAB120", VA = "0x188BAC320", Slot = "18")]
	private IGHJFFBEDLO GOAANOLLACF(ICIJOOIDPLO ICNBLBLHJLK, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class DEMFMNOANCK : NIADBHINKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4D60", Offset = "0x8BA3B60", VA = "0x188BA4D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool MMHELOIBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5A70", Offset = "0x8BA4870", VA = "0x188BA5A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool DIDGIOCFILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A6E0", Offset = "0x8B994E0", VA = "0x188B9A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8BA52F0", Offset = "0x8BA40F0", VA = "0x188BA52F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5AC0", Offset = "0x8BA48C0", VA = "0x188BA5AC0")]
	public DEMFMNOANCK(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5190", Offset = "0x8BA3F90", VA = "0x188BA5190", Slot = "4")]
	public void IHGBMKOPJGJ(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5810", Offset = "0x8BA4610", VA = "0x188BA5810")]
	private void NFGJIAADKKP(Vector3 PPPGPLMAHNI, ForceMode CIFCFDNDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4DB0", Offset = "0x8BA3BB0", VA = "0x188BA4DB0", Slot = "5")]
	public void EINLMJIPMHP(Vector3 PPPGPLMAHNI, Vector3 FLAPAOJCDCM, ForceMode CIFCFDNDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5030", Offset = "0x8BA3E30", VA = "0x188BA5030", Slot = "6")]
	public void HJLPLBGHBLO(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5350", Offset = "0x8BA4150", VA = "0x188BA5350")]
	private void KJEHDNLBOAN(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8BA55B0", Offset = "0x8BA43B0", VA = "0x188BA55B0", Slot = "7")]
	public void MAPLNIAAFCA(Vector3 KKOEFOMCALN, ForceMode CIFCFDNDJDB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EMIAKADFLKJ : GCEPNBLCKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool AIEMDDHGAOF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OGHHPJAHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8460", Offset = "0x8BA7260", VA = "0x188BA8460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5AC0", Offset = "0x8BA48C0", VA = "0x188BA5AC0")]
	public EMIAKADFLKJ(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8570", Offset = "0x8BA7370", VA = "0x188BA8570", Slot = "6")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8BA85A0", Offset = "0x8BA73A0", VA = "0x188BA85A0", Slot = "7")]
	public void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ENCHGKBEAPL : NIAMNMIOLLP, PFIKPKKHIMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ICIJOOIDPLO HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<ICIJOOIDPLO> DPOHIAJFNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ICIJOOIDPLO MMENCBNBOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ICIJOOIDPLO PJGOIMBEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform OOHLDHBHIIL;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9C30", Offset = "0x8BA8A30", VA = "0x188BA9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8B00", Offset = "0x8BA7900", VA = "0x188BA8B00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ICIJOOIDPLO CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ICIJOOIDPLO> NENGKJJAAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event JMEGBAKHEFO JHHNDEAFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9DD0", Offset = "0x8BA8BD0", VA = "0x188BA9DD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8920", Offset = "0x8BA7720", VA = "0x188BA8920", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event JMEGBAKHEFO LCDCJFBNGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9440", Offset = "0x8BA8240", VA = "0x188BA9440", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA360", Offset = "0x8BA9160", VA = "0x188BAA360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FECAAPMBKPL CGPEGJKMJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9FA0", Offset = "0x8BA8DA0", VA = "0x188BA9FA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA89C0", Offset = "0x8BA77C0", VA = "0x188BA89C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action HAMNLLGBKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA2C0", Offset = "0x8BA90C0", VA = "0x188BAA2C0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA96D0", Offset = "0x8BA84D0", VA = "0x188BA96D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CFIIAKPMKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8A60", Offset = "0x8BA7860", VA = "0x188BA8A60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9820", Offset = "0x8BA8620", VA = "0x188BA9820", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ICIJOOIDPLO> KIJHKKKBBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA210", Offset = "0x8BA9010", VA = "0x188BAA210", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9B80", Offset = "0x8BA8980", VA = "0x188BA9B80", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ICIJOOIDPLO> ELPFLAOIOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8BA94E0", Offset = "0x8BA82E0", VA = "0x188BA94E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9A10", Offset = "0x8BA8810", VA = "0x188BA9A10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action CGDBGIPCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA170", Offset = "0x8BA8F70", VA = "0x188BAA170", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8BA98C0", Offset = "0x8BA86C0", VA = "0x188BA98C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ICIJOOIDPLO> KNOLOFHPILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9960", Offset = "0x8BA8760", VA = "0x188BA9960", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9770", Offset = "0x8BA8570", VA = "0x188BA9770", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA400", Offset = "0x8BA9200", VA = "0x188BAA400")]
	public ENCHGKBEAPL(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9630", Offset = "0x8BA8430", VA = "0x188BA9630", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8EC0", Offset = "0x8BA7CC0", VA = "0x188BA8EC0", Slot = "30")]
	public void CPHNKAAPMCL(ICIJOOIDPLO HNDFKDHDHKN, bool DJFEPAFCLJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8610", Offset = "0x8BA7410", VA = "0x188BA8610", Slot = "6")]
	public void ADCPDPCLEHG(ICIJOOIDPLO POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8C40", Offset = "0x8BA7A40", VA = "0x188BA8C40", Slot = "7")]
	public void CNPDLPKDMLJ(ICIJOOIDPLO POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9E70", Offset = "0x8BA8C70", VA = "0x188BA9E70", Slot = "4")]
	public void JGFALDPOFMH(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9590", Offset = "0x8BA8390", VA = "0x188BA9590", Slot = "5")]
	public void DKLNKCOCMLJ(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8880", Offset = "0x8BA7680", VA = "0x188BA8880")]
	private void AJNDLCBPPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9F60", Offset = "0x8BA8D60", VA = "0x188BA9F60")]
	private void KBPNFDAPBMH(ICIJOOIDPLO POAGCKPNEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9C90", Offset = "0x8BA8A90", VA = "0x188BA9C90")]
	private void ICMAJDMMOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA040", Offset = "0x8BA8E40", VA = "0x188BAA040")]
	private void MCLBJGNJABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8B10", Offset = "0x8BA7910", VA = "0x188BA8B10")]
	private void CCALNCCHCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9AC0", Offset = "0x8BA88C0", VA = "0x188BA9AC0")]
	[CompilerGenerated]
	private object HLHNOPJPEEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class HMBDJOGDAFB
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8BAABB0", Offset = "0x8BA99B0", VA = "0x188BAABB0")]
	public static NIAMNMIOLLP FMDMLHKGGPG(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LFLMHNODDIL : GPOPOINMFHL, FIGGMLLJLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly AKJJENAIBLI<ICIJOOIDPLO> ECKJOMDHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool OBOIDDHONDD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public AKJJENAIBLI<ICIJOOIDPLO> APPBBJOLBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 KMFNAFPIADI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE590", Offset = "0x8BAD390", VA = "0x188BAE590", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 GCPHINBANOM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE040", Offset = "0x8BACE40", VA = "0x188BAE040", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 CAGGGBMOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BADAA0", Offset = "0x8BAC8A0", VA = "0x188BADAA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ICIJOOIDPLO FEJOHBPGMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BADF90", Offset = "0x8BACD90", VA = "0x188BADF90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE630", Offset = "0x8BAD430", VA = "0x188BAE630")]
	public LFLMHNODDIL(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE5C0", Offset = "0x8BAD3C0", VA = "0x188BAE5C0", Slot = "8")]
	public void PBJKIOHPFNK(ICIJOOIDPLO PJGOIMBEKPK, object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB90", Offset = "0x8BAC990", VA = "0x188BADB90", Slot = "9")]
	public void GEPMNIIGPPN(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BADBF0", Offset = "0x8BAC9F0", VA = "0x188BADBF0")]
	private Vector3 HCAMLBEANDI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE200", Offset = "0x8BAD000", VA = "0x188BAE200")]
	private void JPELOHCCCCA(ICIJOOIDPLO ELPKDLOMJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class MBEJEHFPKEO
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE840", Offset = "0x8BAD640", VA = "0x188BAE840")]
	public static GPOPOINMFHL OGIFBHAAODN(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class EFAINDLHIDI : NMNBBBJBMFB, PGOPGGJIJBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 PCJOIKEHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 GABJAKCPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float CFKHBHGNEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float HGDMGJMLPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 HKFDLKHDMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? DIDMKINGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? BCOBPHBPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool OGIIAPADMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool DLKPBAJJMAB;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 GELFIBKHDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1907CB0", Offset = "0x1906AB0", VA = "0x181907CB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5FE0", Offset = "0x8BA4DE0", VA = "0x188BA5FE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 DONGLEPOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6960", Offset = "0x8BA5760", VA = "0x188BA6960", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OIMKFACPPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE6D8E0", Offset = "0xE6C6E0", VA = "0x180E6D8E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6CB0", Offset = "0x8BA5AB0", VA = "0x188BA6CB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float HGBFFNEBENA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD5B910", Offset = "0xD5A710", VA = "0x180D5B910", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6260", Offset = "0x8BA5060", VA = "0x188BA6260", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 KGHHKCPMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6EE0", Offset = "0x8BA5CE0", VA = "0x188BA6EE0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion JABJILNIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6B30", Offset = "0x8BA5930", VA = "0x188BA6B30", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6130", Offset = "0x8BA4F30", VA = "0x188BA6130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event JMEGBAKHEFO MMOBFHNIEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7070", Offset = "0x8BA5E70", VA = "0x188BA7070", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6090", Offset = "0x8BA4E90", VA = "0x188BA6090", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8300", Offset = "0x8BA7100", VA = "0x188BA8300")]
	public EFAINDLHIDI(ICIJOOIDPLO HFFACBJLEBJ, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6DC0", Offset = "0x8BA5BC0", VA = "0x188BA6DC0", Slot = "17")]
	public void LBJDPALFFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6180", Offset = "0x8BA4F80", VA = "0x188BA6180", Slot = "16")]
	public void FBDIEOIMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6A50", Offset = "0x8BA5850", VA = "0x188BA6A50", Slot = "19")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7110", Offset = "0x8BA5F10", VA = "0x188BA7110", Slot = "20")]
	public void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6310", Offset = "0x8BA5110", VA = "0x188BA6310", Slot = "18")]
	public void GOKOCGBDLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5B50", Offset = "0x8BA4950", VA = "0x188BA5B50", Slot = "21")]
	public void APBNNHFDBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5FE0", Offset = "0x8BA4DE0", VA = "0x188BA5FE0")]
	private void BHILGOBLGAD(Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6640", Offset = "0x8BA5440", VA = "0x188BA6640")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 HHKJNGALAND()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6CB0", Offset = "0x8BA5AB0", VA = "0x188BA6CB0")]
	private void OKCGOHAGOLF(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6260", Offset = "0x8BA5060", VA = "0x188BA6260")]
	private void FMHHMBIFFKM(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA72F0", Offset = "0x8BA60F0", VA = "0x188BA72F0")]
	private Vector3 NJLGOEFDEGM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA6730", Offset = "0x8BA5530", VA = "0x188BA6730", Slot = "15")]
	public void IIABJNALIAE((Quaternion rot, Vector3 moments) FFGEJMBOODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8BA64C0", Offset = "0x8BA52C0", VA = "0x188BA64C0")]
	private Quaternion HALMABGIKIN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8230", Offset = "0x8BA7030", VA = "0x188BA8230")]
	public void PBCGFCJDPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7490", Offset = "0x8BA6290", VA = "0x188BA7490", Slot = "4")]
	public (float, Vector3) PBCGFCJDPBH(Rigidbody LLGKCAHHIDO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class GMALFIGBIEG
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA7B0", Offset = "0x8BA95B0", VA = "0x188BAA7B0")]
	public static NMNBBBJBMFB ADEOBHHNKBJ(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BDFKODKPAFM : DONMCAIBHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly LKAPBLPAEMI MHKBJKCAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PBNGAEFDFBE HCJLODBPDNJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AHNONOOFHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBDE0", Offset = "0x1ACABE0", VA = "0x181ACBDE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PBNGAEFDFBE NPBANGNPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "11")]
		get
		{
			return default(PBNGAEFDFBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A5B0", Offset = "0x8B993B0", VA = "0x188B9A5B0")]
	public BDFKODKPAFM(ICIJOOIDPLO HFFACBJLEBJ, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A210", Offset = "0x8B99010", VA = "0x188B9A210", Slot = "4")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A170", Offset = "0x8B98F70", VA = "0x188B9A170")]
	private bool IFPPCPFGEFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B99FD0", Offset = "0x8B98DD0", VA = "0x188B99FD0", Slot = "5")]
	public void FFBLDAMLOHA(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8B99FA0", Offset = "0x8B98DA0", VA = "0x188B99FA0", Slot = "6")]
	public void DIBOFFANELO(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A000", Offset = "0x8B98E00", VA = "0x188B9A000", Slot = "9")]
	public void GCALPCPLJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A2E0", Offset = "0x8B990E0", VA = "0x188B9A2E0")]
	private void JBKFCIAJCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A3F0", Offset = "0x8B991F0", VA = "0x188B9A3F0")]
	private void MBGONOLKMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A570", Offset = "0x8B99370", VA = "0x188B9A570", Slot = "8")]
	public void MCGJMBOEAOM(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A130", Offset = "0x8B98F30", VA = "0x188B9A130", Slot = "7")]
	public void GJKPEAHAPHK(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class KIJMPPKFOJB : AIOEILEBAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LKAPBLPAEMI DEKHKNKOPLB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MMHELOIBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BACD00", Offset = "0x8BABB00", VA = "0x188BACD00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JMEGBAKHEFO LJIIBIIGEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BACBB0", Offset = "0x8BAB9B0", VA = "0x188BACBB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BAC9F0", Offset = "0x8BAB7F0", VA = "0x188BAC9F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8BACDC0", Offset = "0x8BABBC0", VA = "0x188BACDC0")]
	public KIJMPPKFOJB(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8BACBA0", Offset = "0x8BAB9A0", VA = "0x188BACBA0", Slot = "7")]
	public void FEECNOBFPAD(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8BACDB0", Offset = "0x8BABBB0", VA = "0x188BACDB0", Slot = "8")]
	public void OLHEGDMHMJB(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8BACA90", Offset = "0x8BAB890", VA = "0x188BACA90", Slot = "9")]
	public void EGGKMJIFAEK(object OBGCPOCPFIJ, bool BOENCBCIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC9B0", Offset = "0x8BAB7B0", VA = "0x188BAC9B0", Slot = "12")]
	public void CKIGOPKLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8BACC50", Offset = "0x8BABA50", VA = "0x188BACC50", Slot = "10")]
	public void KCAHAFKMMDD(Rigidbody BKNONEHIOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BACCD0", Offset = "0x8BABAD0", VA = "0x188BACCD0", Slot = "11")]
	public void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NJJLFBNDLPA : BEDEMKMAHHI, ABAGIEDIAHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView IOPMDOAOFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool OLEPJAPKBNF;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView KBGFIGKELPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AOICDAFDFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF400", Offset = "0x8BAE200", VA = "0x188BAF400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CIGHLHEBGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JMEGBAKHEFO CGEGEONHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF7B0", Offset = "0x8BAE5B0", VA = "0x188BAF7B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF850", Offset = "0x8BAE650", VA = "0x188BAF850", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFA40", Offset = "0x8BAE840", VA = "0x188BAFA40")]
	public NJJLFBNDLPA(ICIJOOIDPLO HFFACBJLEBJ, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF410", Offset = "0x8BAE210", VA = "0x188BAF410", Slot = "9")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF190", Offset = "0x8BADF90", VA = "0x188BAF190", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF290", Offset = "0x8BAE090", VA = "0x188BAF290", Slot = "10")]
	public void GFEKCNDJNHO(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF020", Offset = "0x8BADE20", VA = "0x188BAF020", Slot = "11")]
	public void COBAABADAKB(ICIJOOIDPLO PJGOIMBEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8BAEEB0", Offset = "0x8BADCB0", VA = "0x188BAEEB0")]
	private void CEFPFOACMDH(RRNetworkView FCEJBLOMCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF8F0", Offset = "0x8BAE6F0", VA = "0x188BAF8F0")]
	private void PDNIKPIFCNJ(HJAKPLGAOLP DMKKJJMGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF540", Offset = "0x8BAE340", VA = "0x188BAF540")]
	private void JBHBPGAFMLP(RRNetworkView DJOELPOLBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OCKAFGFGKBE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0080", Offset = "0x8BAEE80", VA = "0x188BB0080")]
	public static BEDEMKMAHHI KCJKLMHOEHO(this ICIJOOIDPLO ICNBLBLHJLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NLAAEAGIGHL : IGHJFFBEDLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints BFJLBEFIMPC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LMPIKOEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB62D30", Offset = "0xB61B30", VA = "0x180B62D30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6C0", Offset = "0xE8C4C0", VA = "0x180E8D6C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KJPAJACDMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB62DA0", Offset = "0xB61BA0", VA = "0x180B62DA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE8D6D0", Offset = "0xE8C4D0", VA = "0x180E8D6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints DNCDKBPLHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFB90", Offset = "0x8BAE990", VA = "0x188BAFB90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFD20", Offset = "0x8BAEB20", VA = "0x188BAFD20")]
	public NLAAEAGIGHL(ICIJOOIDPLO HFFACBJLEBJ, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFCC0", Offset = "0x8BAEAC0", VA = "0x188BAFCC0", Slot = "9")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFCF0", Offset = "0x8BAEAF0", VA = "0x188BAFCF0", Slot = "10")]
	public void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HIEGOLKKMPF : CPLDALMFIIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ICIJOOIDPLO HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float NMDCFBMFJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float FBHEPOLIKPM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FEKALCDLCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA8E0", Offset = "0x8BA96E0", VA = "0x188BAA8E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float CLLEGFGGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAAA0", Offset = "0x8BA98A0", VA = "0x188BAAAA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAB70", Offset = "0x8BA9970", VA = "0x188BAAB70")]
	public HIEGOLKKMPF(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8BAA9B0", Offset = "0x8BA97B0", VA = "0x188BAA9B0", Slot = "8")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAA00", Offset = "0x8BA9800", VA = "0x188BAAA00", Slot = "9")]
	public void MHOJLAFDJOB(Rigidbody HPBIMOMPCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HMOICDNBLPN : IKGINNNKGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly ALMLLDBPKBM EHJHFKCMJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool MPDDEDPCPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool MAEJCLKPOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int KPNKIAOHLBD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6130", Offset = "0x8BA4F30", VA = "0x188BA6130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LONGAAOILIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB0F0", Offset = "0x8BA9EF0", VA = "0x188BAB0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ICIJOOIDPLO PJMJBHEBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB1A0", Offset = "0x8BA9FA0", VA = "0x188BAB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DIDGIOCFILP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAF80", Offset = "0x8BA9D80", VA = "0x188BAAF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event JMEGBAKHEFO HPLGMEHICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB4F0", Offset = "0x8BAA2F0", VA = "0x188BAB4F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC70", Offset = "0x8BA9A70", VA = "0x188BAAC70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB8A0", Offset = "0x8BAA6A0", VA = "0x188BAB8A0")]
	public HMOICDNBLPN(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB110", Offset = "0x8BA9F10", VA = "0x188BAB110", Slot = "6")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB590", Offset = "0x8BAA390", VA = "0x188BAB590", Slot = "8")]
	public void PBILIHICDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAE30", Offset = "0x8BA9C30", VA = "0x188BAAE30", Slot = "7")]
	public bool BMOPIGAAFGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB390", Offset = "0x8BAA190", VA = "0x188BAB390", Slot = "9")]
	public void MFNAGEOMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAFE0", Offset = "0x8BA9DE0", VA = "0x188BAAFE0", Slot = "13")]
	public void DKCHJGAFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAD10", Offset = "0x8BA9B10", VA = "0x188BAAD10", Slot = "12")]
	public void BJMOKBLNGIL(bool IAHHNPMOKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB080", Offset = "0x8BA9E80", VA = "0x188BAB080", Slot = "10")]
	public bool DLAJFDDJNJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB430", Offset = "0x8BAA230", VA = "0x188BAB430", Slot = "11")]
	public bool OCJMFJICPMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB5A0", Offset = "0x8BAA3A0", VA = "0x188BAB5A0")]
	private bool PPPFBMNNIKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB200", Offset = "0x8BAA000", VA = "0x188BAB200")]
	private void LDAKGNDHBAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BKMMNGMMLCK : OBMGPGPMFCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LKAPBLPAEMI LNMOFHIEBJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody JODPDMKLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool DIDGIOCFILP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9A6E0", Offset = "0x8B994E0", VA = "0x188B9A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OJINKDHDJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBDE0", Offset = "0x1ACABE0", VA = "0x181ACBDE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8B9AEB0", Offset = "0x8B99CB0", VA = "0x188B9AEB0")]
	public BKMMNGMMLCK(ICIJOOIDPLO HFFACBJLEBJ, [In] OMBFMDMEAGH KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A740", Offset = "0x8B99540", VA = "0x188B9A740", Slot = "5")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A6B0", Offset = "0x8B994B0", VA = "0x188B9A6B0", Slot = "7")]
	public void AKIIELENDBN(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A7E0", Offset = "0x8B995E0", VA = "0x188B9A7E0", Slot = "8")]
	public void LPMHAGFBAHA(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A990", Offset = "0x8B99790", VA = "0x188B9A990", Slot = "9")]
	public void PAFCMLBJAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8B9ACC0", Offset = "0x8B99AC0", VA = "0x188B9ACC0", Slot = "10")]
	public void PBFNDOKEMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8B9A810", Offset = "0x8B99610", VA = "0x188B9A810", Slot = "11")]
	public void MAJOJCEFHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CEGGHOEDKBK : KCFJDCDKIGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CHMGFLEKPPI HFFACBJLEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LKAPBLPAEMI EGBIAAODOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float MFEIKFCPFEL;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HJKHHJEKPOI PLGKPLEHELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HDEDPMNNDDA ILJDLEKNLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 CAGGGBMOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B0D0", Offset = "0x8B99ED0", VA = "0x188B9B0D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B280", Offset = "0x8B9A080", VA = "0x188B9B280", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 FDHPBGDOGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CFA0", Offset = "0x8B9BDA0", VA = "0x188B9CFA0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C4F0", Offset = "0x8B9B2F0", VA = "0x188B9C4F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 FJGNNHBIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C6C0", Offset = "0x8B9B4C0", VA = "0x188B9C6C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C600", Offset = "0x8B9B400", VA = "0x188B9C600", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 MNCHFCFEIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9CE80", Offset = "0x8B9BC80", VA = "0x188B9CE80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B540", Offset = "0x8B9A340", VA = "0x188B9B540", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float FCMKJAKFOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAE79F0", Offset = "0xAE67F0", VA = "0x180AE79F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AFC0", Offset = "0x8B99DC0", VA = "0x188B9AFC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool HEFAALIBAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2518820", Offset = "0x2517620", VA = "0x182518820", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NIADBHINKFK GIAOBFHMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x80EA890", Offset = "0x80E9690", VA = "0x1880EA890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool LONGAAOILIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BFD0", Offset = "0x8B9ADD0", VA = "0x188B9BFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E560", Offset = "0x8B9D360", VA = "0x188B9E560")]
	public CEGGHOEDKBK(ICIJOOIDPLO HFFACBJLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BFF0", Offset = "0x8B9ADF0", VA = "0x188B9BFF0", Slot = "19")]
	public void IODAHCPKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B4E0", Offset = "0x8B9A2E0", VA = "0x188B9B4E0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C3C0", Offset = "0x8B9B1C0", VA = "0x188B9C3C0", Slot = "28")]
	public void KCAHAFKMMDD(Rigidbody HPBIMOMPCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x18893C0", Offset = "0x18881C0", VA = "0x1818893C0", Slot = "20")]
	public void LPAGIEHMLAH(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1889C80", Offset = "0x1888A80", VA = "0x181889C80", Slot = "30")]
	public void NCDGFOFPAOJ(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B9F0", Offset = "0x8B9A7F0", VA = "0x188B9B9F0", Slot = "35")]
	public Vector3 FMJOKGDDFLD(Vector3 IOMNICHLECK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BBD0", Offset = "0x8B9A9D0", VA = "0x188B9BBD0", Slot = "34")]
	public Vector3 FPBOIOAPFGJ(Vector3 KNLLFEKJGLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BFF0", Offset = "0x8B9ADF0", VA = "0x188B9BFF0", Slot = "27")]
	public void PEGMHEODBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8B9D0C0", Offset = "0x8B9BEC0", VA = "0x188B9D0C0", Slot = "25")]
	public void MODAEGGGNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9CE20", Offset = "0x8B9BC20", VA = "0x188B9CE20", Slot = "24")]
	public void LLDDJIOAAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BD90", Offset = "0x8B9AB90", VA = "0x188B9BD90", Slot = "33")]
	public void GDLIHAANJDK(Vector3 DKBAGIDMLLA, Vector3 JOAHJHGIBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B220", Offset = "0x8B9A020", VA = "0x188B9B220", Slot = "32")]
	public void CELGCOPHAIP(Vector3 HHPOLKLJIOE, Vector3 MJIMOFHAOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B340", Offset = "0x8B9A140", VA = "0x188B9B340", Slot = "31")]
	public void DNJACAMCJPF(Vector3 MLKGMLAMDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8B9D7D0", Offset = "0x8B9C5D0", VA = "0x188B9D7D0", Slot = "22")]
	public void OFPMGDLCIOE(EIALNCDFAED JIFAODPPPFE, Vector3 OMELNKHNHFK, float MNOEJMMHLIN, float HCBJLIFMPGL = 8f, float FBOCAAAJEPC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C140", Offset = "0x8B9AF40", VA = "0x188B9C140", Slot = "21")]
	public void JPLOGPCODMP(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 JDMHDKLLHAP, float EDENKKIACIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8B9DE20", Offset = "0x8B9CC20", VA = "0x188B9DE20", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OJCFFIOELDH(LJAIKEBCGJJ CFCDLCNIEAJ, Vector3 GKEKGHNHKDP, float NBICOHADIBA = 7f, float IFFFGOPNNJH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x19E51A0", Offset = "0x19E3FA0", VA = "0x1819E51A0")]
	private static void MGFEAICKGEH(Vector3 ILLMOMMKCAB, Vector3 INIBGDOOLID, [Out] Vector3 PAEJOCGDAEM, [Out] Vector3 IKDDBBLAEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C520", Offset = "0x8B9B320", VA = "0x188B9C520", Slot = "29")]
	public Vector3 KCLENONKJJK(Vector3 ILLMOMMKCAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C810", Offset = "0x8B9B610", VA = "0x188B9C810", Slot = "26")]
	public void LFHCDCJMDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8B9AFC0", Offset = "0x8B99DC0", VA = "0x188B9AFC0")]
	private void JGHOGNAPLOC(float HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E3C0", Offset = "0x8B9D1C0", VA = "0x188B9E3C0")]
	private void PNNMLGDDDAI(Vector3 JDMHDKLLHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9D6C0", Offset = "0x8B9C4C0", VA = "0x188B9D6C0")]
	private Vector3 ODKCCMLONKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C9A0", Offset = "0x8B9B7A0", VA = "0x188B9C9A0")]
	private void LKOMLFAHLCM(Vector3 KNLLFEKJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9E2A0", Offset = "0x8B9D0A0", VA = "0x188B9E2A0")]
	private Vector3 PBCDICPKOAA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B570", Offset = "0x8B9A370", VA = "0x188B9B570")]
	private void FAFPMPKNPJL(Vector3 HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8B9D120", Offset = "0x8B9BF20", VA = "0x188B9D120")]
	private void NOHDAHILNBE(Vector3 KNLLFEKJGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C090", Offset = "0x8B9AE90", VA = "0x188B9C090")]
	private void JDENPNIMMNK()
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
