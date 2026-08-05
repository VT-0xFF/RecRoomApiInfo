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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D40740", Offset = "0x8D3ED40", VA = "0x188D40740", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86C1170", Offset = "0x86BF770", VA = "0x1886C1170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D49430", Offset = "0x8D47A30", VA = "0x188D49430")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D49740", Offset = "0x8D47D40", VA = "0x188D49740", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D497A0", Offset = "0x8D47DA0", VA = "0x188D497A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, OCHLPLCDEOP, AKDIJPFDGAK, LAHJHLNIINP
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IPHNFELODMJ OPDCOOCLNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool BOCJJGGDPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AFLINHCECMA EPANJENKOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.SelfAndParent, true, false, false)]
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
		private FMEBMDLLDAA physicsInterpolation;

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
		private Transform GKMKOPPOHCE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal AFLINHCECMA EELLHBOICKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D44CD0", Offset = "0x8D432D0", VA = "0x188D44CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AFLINHCECMA EMDOCFFHHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LABGDFIOJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D46900", Offset = "0x8D44F00", VA = "0x188D46900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OAJBKLHCIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D46C60", Offset = "0x8D45260", VA = "0x188D46C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HMJJONKLDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D46BA0", Offset = "0x8D451A0", VA = "0x188D46BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BEBONNCPGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D47870", Offset = "0x8D45E70", VA = "0x188D47870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D48DA0", Offset = "0x8D473A0", VA = "0x188D48DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MEGELOEHMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8968E40", Offset = "0x8967440", VA = "0x188968E40", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8967E10", Offset = "0x8966410", VA = "0x188967E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform CCHLCEHOKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2595A30", Offset = "0x2594030", VA = "0x182595A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform JGFBEFFPIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2595A30", Offset = "0x2594030", VA = "0x182595A30", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IMKDKMLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2595A30", Offset = "0x2594030", VA = "0x182595A30", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FLIFMIOEKDE IDNCNDEILKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D46960", Offset = "0x8D44F60", VA = "0x188D46960")]
			get
			{
				return default(FLIFMIOEKDE);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D48550", Offset = "0x8D46B50", VA = "0x188D48550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CJKCNKHINOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D46F70", Offset = "0x8D45570", VA = "0x188D46F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HMDJDGHDCBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8D46A80", Offset = "0x8D45080", VA = "0x188D46A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LDOJJNLFMJG IDJEEBDMJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D46EB0", Offset = "0x8D454B0", VA = "0x188D46EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8D48710", Offset = "0x8D46D10", VA = "0x188D48710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KNMODGMCAEJ PHHGNNEFNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8D46E50", Offset = "0x8D45450", VA = "0x188D46E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8D486A0", Offset = "0x8D46CA0", VA = "0x188D486A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GOFMMIKMJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D46DA0", Offset = "0x8D453A0", VA = "0x188D46DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody MNPLGLEODBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8D46E00", Offset = "0x8D45400", VA = "0x188D46E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DCJNAJFFGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D46AE0", Offset = "0x8D450E0", VA = "0x188D46AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D485C0", Offset = "0x8D46BC0", VA = "0x188D485C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GANEOLNJPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x18D1AA0", Offset = "0x18D00A0", VA = "0x1818D1AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BIIEIOBLBJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D47810", Offset = "0x8D45E10", VA = "0x188D47810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MJMKGABGKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8D477B0", Offset = "0x8D45DB0", VA = "0x188D477B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D48D30", Offset = "0x8D47330", VA = "0x188D48D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float DOJNFLMGJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D471D0", Offset = "0x8D457D0", VA = "0x188D471D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D489B0", Offset = "0x8D46FB0", VA = "0x188D489B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float MNJJHIIOEMF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8D46FD0", Offset = "0x8D455D0", VA = "0x188D46FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8D48780", Offset = "0x8D46D80", VA = "0x188D48780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GGFIGBKCBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8D47DF0", Offset = "0x8D463F0", VA = "0x188D47DF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D492E0", Offset = "0x8D478E0", VA = "0x188D492E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 COLJECJNFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D47590", Offset = "0x8D45B90", VA = "0x188D47590")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8D48B00", Offset = "0x8D47100", VA = "0x188D48B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 KFDFIPMLLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8D47F30", Offset = "0x8D46530", VA = "0x188D47F30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode AENPCBHHDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D47110", Offset = "0x8D45710", VA = "0x188D47110")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D488D0", Offset = "0x8D46ED0", VA = "0x188D488D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MEHMIOIICDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D46B40", Offset = "0x8D45140", VA = "0x188D46B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D48630", Offset = "0x8D46C30", VA = "0x188D48630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints NMHLAJBHIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D47170", Offset = "0x8D45770", VA = "0x188D47170")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D48940", Offset = "0x8D46F40", VA = "0x188D48940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 LHNDPPNIMHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D47930", Offset = "0x8D45F30", VA = "0x188D47930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 JBLICLEPIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D47930", Offset = "0x8D45F30", VA = "0x188D47930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D490C0", Offset = "0x8D476C0", VA = "0x188D490C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BJNPNLJGPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8D47670", Offset = "0x8D45C70", VA = "0x188D47670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D48BE0", Offset = "0x8D471E0", VA = "0x188D48BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float CAEJJPPNLFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8D47D90", Offset = "0x8D46390", VA = "0x188D47D90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D49270", Offset = "0x8D47870", VA = "0x188D49270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion GEEMJLGNELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D47A10", Offset = "0x8D46010", VA = "0x188D47A10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D48E40", Offset = "0x8D47440", VA = "0x188D48E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion AFBGPKKHDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D47CB0", Offset = "0x8D462B0", VA = "0x188D47CB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D491A0", Offset = "0x8D477A0", VA = "0x188D491A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 KJNPCBMAKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D47AF0", Offset = "0x8D460F0", VA = "0x188D47AF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D48F10", Offset = "0x8D47510", VA = "0x188D48F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BJMDFBCBEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D47BD0", Offset = "0x8D461D0", VA = "0x188D47BD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D48FF0", Offset = "0x8D475F0", VA = "0x188D48FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EJLBFNGBOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D47E50", Offset = "0x8D46450", VA = "0x188D47E50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8D49350", Offset = "0x8D47950", VA = "0x188D49350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BDPHNFIHANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D476D0", Offset = "0x8D45CD0", VA = "0x188D476D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8D48C50", Offset = "0x8D47250", VA = "0x188D48C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 PCNHEAPIMMO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8D47030", Offset = "0x8D45630", VA = "0x188D47030")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8D487F0", Offset = "0x8D46DF0", VA = "0x188D487F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 DDMPBEFKBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8D474B0", Offset = "0x8D45AB0", VA = "0x188D474B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8D48A20", Offset = "0x8D47020", VA = "0x188D48A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OPHOLPNMGIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8D47370", Offset = "0x8D45970", VA = "0x188D47370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion OBIDNALIIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8D47290", Offset = "0x8D45890", VA = "0x188D47290")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 NIPDFLMPDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8D480F0", Offset = "0x8D466F0", VA = "0x188D480F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 CHIHBPMFCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D48010", Offset = "0x8D46610", VA = "0x188D48010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AGJPJFLIFBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8D47450", Offset = "0x8D45A50", VA = "0x188D47450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NIMGFGNGKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D46F10", Offset = "0x8D45510", VA = "0x188D46F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OAJMEEFOCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8D46A20", Offset = "0x8D45020", VA = "0x188D46A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PHHANJFHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8D469C0", Offset = "0x8D44FC0", VA = "0x188D469C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool GCMINIMGNIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8D468A0", Offset = "0x8D44EA0", VA = "0x188D468A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool JOELIHDPJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8D47230", Offset = "0x8D45830", VA = "0x188D47230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool NMKMFLCMAEH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2786A20", Offset = "0x2785020", VA = "0x182786A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ICCJKBLNFCN BNLKKOLGBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D467C0", Offset = "0x8D44DC0", VA = "0x188D467C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D48470", Offset = "0x8D46A70", VA = "0x188D48470")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GJMCCLEBNCH PNNGFLPGHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D46530", Offset = "0x8D44B30", VA = "0x188D46530")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D481D0", Offset = "0x8D467D0", VA = "0x188D481D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GJMCCLEBNCH FEHEPNOPKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D46590", Offset = "0x8D44B90", VA = "0x188D46590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D48240", Offset = "0x8D46840", VA = "0x188D48240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event GJMCCLEBNCH HHHEHFDFCBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D466E0", Offset = "0x8D44CE0", VA = "0x188D466E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D48390", Offset = "0x8D46990", VA = "0x188D48390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<AHNGGBKKFOE, AHNGGBKKFOE> JDMNGFPHFAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D46670", Offset = "0x8D44C70", VA = "0x188D46670")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D48320", Offset = "0x8D46920", VA = "0x188D48320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event GJMCCLEBNCH PIFDDLLCCMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D46750", Offset = "0x8D44D50", VA = "0x188D46750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D48400", Offset = "0x8D46A00", VA = "0x188D48400")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event GJMCCLEBNCH JKGMIANEDIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D46830", Offset = "0x8D44E30", VA = "0x188D46830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D484E0", Offset = "0x8D46AE0", VA = "0x188D484E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event GJMCCLEBNCH PMDGDLGHLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D46600", Offset = "0x8D44C00", VA = "0x188D46600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D482B0", Offset = "0x8D468B0", VA = "0x188D482B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0", Slot = "8")]
		private void HAMHAIDGNEH(AFLINHCECMA MFNKIFOCMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D45030", Offset = "0x8D43630", VA = "0x188D45030", Slot = "9")]
		public BMAKNOKMAHD GetData()
		{
			return default(BMAKNOKMAHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D44C40", Offset = "0x8D43240", VA = "0x188D44C40")]
		internal void FHJBIANODPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D46250", Offset = "0x8D44850", VA = "0x188D46250")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody BBBGKMHBFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D44D80", Offset = "0x8D43380", VA = "0x188D44D80")]
		public OCHLPLCDEOP GetChild(int PMIGBJGNLLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D45F10", Offset = "0x8D44510", VA = "0x188D45F10")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FGMFIOKLJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D44890", Offset = "0x8D42E90", VA = "0x188D44890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D461A0", Offset = "0x8D447A0", VA = "0x188D461A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D44CD0", Offset = "0x8D432D0", VA = "0x188D44CD0")]
		private AFLINHCECMA LOLALNHLKIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D450C0", Offset = "0x8D436C0", VA = "0x188D450C0")]
		private void HAKAIDJFGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D456E0", Offset = "0x8D43CE0", VA = "0x188D456E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D45620", Offset = "0x8D43C20", VA = "0x188D45620")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D44C40", Offset = "0x8D43240", VA = "0x188D44C40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D45680", Offset = "0x8D43C80", VA = "0x188D45680")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D45740", Offset = "0x8D43D40", VA = "0x188D45740")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D43F40", Offset = "0x8D42540", VA = "0x188D43F40")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D457A0", Offset = "0x8D43DA0", VA = "0x188D457A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D44BE0", Offset = "0x8D431E0", VA = "0x188D44BE0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D455C0", Offset = "0x8D43BC0", VA = "0x188D455C0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D46070", Offset = "0x8D44670", VA = "0x188D46070")]
		public void SetParent(RigidbodyEx KOPHBHGIACG, bool NNOFAGIMANK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D45AB0", Offset = "0x8D440B0", VA = "0x188D45AB0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D45240", Offset = "0x8D43840", VA = "0x188D45240")]
		public bool IsRigidbodyAncestor(RigidbodyEx MGMICADJKBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D45340", Offset = "0x8D43940", VA = "0x188D45340")]
		public bool IsRigidbodyDescendant(RigidbodyEx HOHKLHNNBDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D441B0", Offset = "0x8D427B0", VA = "0x188D441B0")]
		public void AddInterpolationRestriction(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D45810", Offset = "0x8D43E10", VA = "0x188D45810")]
		public void RemoveInterpolationRestriction(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D44220", Offset = "0x8D42820", VA = "0x188D44220")]
		public void AddKinematic(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D45880", Offset = "0x8D43E80", VA = "0x188D45880")]
		public void RemoveKinematic(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D45FF0", Offset = "0x8D445F0", VA = "0x188D45FF0")]
		public void SetKinematic(object INEEADCBMPK, bool KLPLCNHJGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D45E10", Offset = "0x8D44410", VA = "0x188D45E10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BAEGEJDEFCC, Quaternion DEPHFBPLKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D45D10", Offset = "0x8D44310", VA = "0x188D45D10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 BMEDECNGGHD, Quaternion BDEAMIJGHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D44F20", Offset = "0x8D43520", VA = "0x188D44F20")]
		public Vector3 GetConstrainedVelocity(Vector3 EJLBFNGBOJC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D44E10", Offset = "0x8D43410", VA = "0x188D44E10")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 PCNHEAPIMMO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D440C0", Offset = "0x8D426C0", VA = "0x188D440C0")]
		public void AddForce(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D43FB0", Offset = "0x8D425B0", VA = "0x188D43FB0")]
		public void AddForceAtPosition(Vector3 AKKFOJDOENB, Vector3 APHHGJIDDCM, ForceMode HBOKLBGANOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D443F0", Offset = "0x8D429F0", VA = "0x188D443F0")]
		public void AddTorque(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D44290", Offset = "0x8D42890", VA = "0x188D44290")]
		public void AddRelativeTorque(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D46320", Offset = "0x8D44920", VA = "0x188D46320")]
		public Vector3 WorldToLocalVelocity(Vector3 INOKLOLKDMF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D454B0", Offset = "0x8D43AB0", VA = "0x188D454B0")]
		public Vector3 LocalToWorldVelocity(Vector3 BDPHNFIHANA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D44B80", Offset = "0x8D43180", VA = "0x188D44B80")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D44B20", Offset = "0x8D43120", VA = "0x188D44B20")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D44AC0", Offset = "0x8D430C0", VA = "0x188D44AC0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D44A60", Offset = "0x8D43060", VA = "0x188D44A60")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D45C10", Offset = "0x8D44210", VA = "0x188D45C10")]
		public void ResetVelocityWorldSpace(Vector3 JDNMLAKNLHJ, Vector3 OPOBMLOHGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D45B10", Offset = "0x8D44110", VA = "0x188D45B10")]
		public void ResetVelocityLocalSpace(Vector3 KKAOBCBGFIM, Vector3 DDMPBEFKBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D459D0", Offset = "0x8D43FD0", VA = "0x188D459D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 KKAOBCBGFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D461B0", Offset = "0x8D447B0", VA = "0x188D461B0")]
		public bool SweepTest(Vector3 JPDMHOCEDGB, [Out] RaycastHit ACFNAAGLOLN, float AHKHODDOFPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D45440", Offset = "0x8D43A40", VA = "0x188D45440")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D46140", Offset = "0x8D44740", VA = "0x188D46140")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8D462C0", Offset = "0x8D448C0", VA = "0x188D462C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8D44380", Offset = "0x8D42980", VA = "0x188D44380")]
		public void AddShouldHaveUnityRigidbodyToken(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8D458F0", Offset = "0x8D43EF0", VA = "0x188D458F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8D44720", Offset = "0x8D42D20", VA = "0x188D44720")]
		public void ApplyForceVelocityChange(JKCJIHCAFND CJJGBDBIKNK, Vector3 JGCOGMBGAIE, float JCMCABMDPDI, float JNJGMIJAPBG = 8f, float FGEMNCHJAOE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D44680", Offset = "0x8D42C80", VA = "0x188D44680")]
		public void ApplyAngularVelocityChange(AGKPFFONCGI BOIEPIHDFOA, Vector3 DEFJCKCMJLK, float LPGBJACEOGH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D447E0", Offset = "0x8D42DE0", VA = "0x188D447E0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AGKPFFONCGI BOIEPIHDFOA, Vector3 LDAEEKEKDJC, float FGNDKKHAFBJ = 7f, float JDPKNMPDEGH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D445B0", Offset = "0x8D42BB0", VA = "0x188D445B0")]
		public bool AllowedScaleChange(float PFDEEHBMFHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D444E0", Offset = "0x8D42AE0", VA = "0x188D444E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx AGCHBDHDAAA, object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D45960", Offset = "0x8D43F60", VA = "0x188D45960")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D454A0", Offset = "0x8D43AA0", VA = "0x188D454A0", Slot = "13")]
		private void JEGMIIJEICE(AIJJICHNHLM JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D464C0", Offset = "0x8D44AC0", VA = "0x188D464C0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB5D7F0", Offset = "0xB5BDF0", VA = "0x180B5D7F0", Slot = "4")]
		private GameObject APKKOOOAEAB()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAD3D60", Offset = "0xAD2360", VA = "0x180AD3D60", Slot = "10")]
		private bool IPGDOMHPEAO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FIHPGIMFIHF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D35910", Offset = "0x8D33F10", VA = "0x188D35910")]
	public static AFLINHCECMA EELLHBOICKF(this RigidbodyEx JDPJJGMMDGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(CHIJNEIHLIH), new string[] { })]
public class JPFPKCPKEGH : CHIJNEIHLIH, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private MBLCDFIPIEA OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DGEFOKDFJMI PKDIGOJFFKL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MBLCDFIPIEA GAAHLJMPLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DGEFOKDFJMI MPMKBPELMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D40450", Offset = "0x8D3EA50", VA = "0x188D40450", Slot = "7")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8D404C0", Offset = "0x8D3EAC0", VA = "0x188D404C0", Slot = "6")]
	public AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JPFPKCPKEGH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static HLLOFHFLNHG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MPNJOEPFEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CEFFLKCCAMD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D43DA0", Offset = "0x8D423A0", VA = "0x188D43DA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D43DE0", Offset = "0x8D423E0", VA = "0x188D43DE0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D43DC0", Offset = "0x8D423C0", VA = "0x188D43DC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string GKNICJPCIJJ, [Optional] UnityEngine.Object JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string GKNICJPCIJJ, [Optional] UnityEngine.Object JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D43EF0", Offset = "0x8D424F0", VA = "0x188D43EF0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FIMKFGJLFLC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KLOCONJFGON : LDOJJNLFMJG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6A10", Offset = "0xAB5010", VA = "0x180AB6A10", Slot = "4")]
		public Vector3 HGAOGEFMHAK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAB6A10", Offset = "0xAB5010", VA = "0x180AB6A10", Slot = "5")]
		public Vector3 IOMIGILDBJN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "6")]
		public bool OPKOIOHCOIH(float JEHLLHNJMME, float OEBLFGNLCLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KLOCONJFGON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LDOJJNLFMJG DFOCLOFAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D35980", Offset = "0x8D33F80", VA = "0x188D35980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HMJOLGOHPLI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode JCMCAJOOFBJ
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
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBINHFLPJNJ(bool AGJPJFLIFBN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFGALNPBOMN(bool AGJPJFLIFBN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LKLOFHEOALP(Vector3 JPDMHOCEDGB, [Out] RaycastHit ACFNAAGLOLN, float AHKHODDOFPB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GLIHDDLGOLD : IDisposable, JCEDEPBPGKA
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FLIFMIOEKDE IDNCNDEILKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<AHNGGBKKFOE, AHNGGBKKFOE> JDMNGFPHFAH;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIEDMCCENPN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DGEFOKDFJMI
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JHBNJICCPFH COOGKKFGILH(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEJAOFLHAHB OBOALCDOPIG(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AGPODNOGBEO KKBINGMCCGC(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EEDAHLHGLOO OPNGHLOFNEA(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CKOJGNCNGLP MFPLKLJHLKF(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GLIHDDLGOLD NDLMBJPCJLD(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GNLGEBAHDOI MAHIJLFNCKE(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PPFBLMBBEHG PHBEPKIIDAD(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HMJOLGOHPLI BALOIKMPFHA(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LCPFBFJHACP ABGFGNDEEKM(AFLINHCECMA MFNKIFOCMAO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FIPKFJJEKKB OGENIDNJPHP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LMCCBONHFOL PMJIDNMNMHB(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FNKMPHIMIPO GGKBELKAEAC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EMALMEEDIMM EGLLCABHBEL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NHHBKDJMHMC FNOPBEPKMPL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH, BMAKNOKMAHD CDDIADBJAOB, CHIJNEIHLIH IHEHADIIJNO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PPFBLMBBEHG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKCPPCHDIAC(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCACIKMAHBF(Vector3 AKKFOJDOENB, Vector3 APHHGJIDDCM, ForceMode HBOKLBGANOG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLJENLHDNIF(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDOPEKBCKFP(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LCPFBFJHACP
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HCJDFMGBPGD
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
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHBNJICCPFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<AFLINHCECMA> IGALLKDJPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AFLINHCECMA HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GJMCCLEBNCH PNNGFLPGHEM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event GJMCCLEBNCH FEHEPNOPKBH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event ICCJKBLNFCN KOFKLAGLDEL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BNEIOEENBJE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PFMCIIDJLGO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AFLINHCECMA> KMHPFLLGHBM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AFLINHCECMA> LBLJHHGHING;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action NPCJCACMGLJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AFLINHCECMA> LIJFGLHBBGL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NMLEEMHPCCP(AFLINHCECMA JBFCMKMBEEK, bool NNOFAGIMANK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AGPODNOGBEO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 HEAGGCAOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 HPAFKOFENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDDJPKCBPJJ(AFLINHCECMA BEBONNCPGLF, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPJAJDLDJOP(object INEEADCBMPK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EMALMEEDIMM
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BFICBHNPEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LMILABLNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float HABFFBAPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float PINPEFDKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 DHPHCJHJBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion ACMFNIJMGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event GJMCCLEBNCH KFOFECGMLGP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIECIPFBALB((Quaternion rot, Vector3 moments) FGMFIOKLJLO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void COHAPIBFEDH();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JDNBIEICPCF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OEELEHNGNFM();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CIPNHALDNGO();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FNKMPHIMIPO
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNOAKOEBBJM(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNNMLGIEPNK(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENLGDLMNPGB(AFLINHCECMA JDPJJGMMDGH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDMBMPCLPOF(AFLINHCECMA JDPJJGMMDGH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGKAEGMMNFC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GNLGEBAHDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool IKOEBPFPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GJMCCLEBNCH OOFEDCIOEJP;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMBCKCPHKFB(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJOEMODIGHA(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MPFLAILIPIP(object INEEADCBMPK, bool KLPLCNHJGCO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IEOOHAANKJL(Rigidbody CCIMPGNIBAH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LMCCBONHFOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CJKCNKHINOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HMDJDGHDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event GJMCCLEBNCH FFFKAKAOPAE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGMIEHNLLDN(AFLINHCECMA BEBONNCPGLF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNPGFMJKNMK(AFLINHCECMA BEBONNCPGLF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NHHBKDJMHMC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DCJNAJFFGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FONLEKHJPKM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints LDAPKPBEMFN
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
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EEDAHLHGLOO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float JGDNBFMPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float GFDHAKAPLDG
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
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CKOJGNCNGLP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool HKFDPDFNLLF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GJMCCLEBNCH GOBHAOBFLON;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IODAFJKJAHN();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKGBMBHNLBM();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPODJONCDKD();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CBEBAOPAHFB();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OCKPLEAEBCI();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCAAPHLKHLL(bool HIOLHHOABKP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEDHHOOPBPI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FIPKFJJEKKB
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool DCOIPPIJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFONOONJCJH(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCNECMLDKIA(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHPCCBLIIFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JEJAOFLHAHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	LDOJJNLFMJG IDJEEBDMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	KNMODGMCAEJ PHHGNNEFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 JCHIBDNJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 KMMLNNKOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LFKDPNAGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 MJABHHPDODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MEHMIOIICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GOFMMIKMJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GIEDMCCENPN();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FACPGEKHDGG(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MPLEJJCMNFI(AGKPFFONCGI BOIEPIHDFOA, Vector3 DEFJCKCMJLK, float LPGBJACEOGH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FDLKOHMMCIM(JKCJIHCAFND CJJGBDBIKNK, Vector3 JGCOGMBGAIE, float JCMCABMDPDI, float JNJGMIJAPBG = 8f, float FGEMNCHJAOE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DKOOOOCKALH(AGKPFFONCGI BOIEPIHDFOA, Vector3 LDAEEKEKDJC, float FGNDKKHAFBJ = 7f, float JDPKNMPDEGH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LEOEAJLLKJJ();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void COGKDECNKAF();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GAOBPBHIPGN();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CJOABAEICMK();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IEOOHAANKJL(Rigidbody MLPKEKPNOAB);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 OHDPDACBGEN(Vector3 EJLBFNGBOJC);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MGAHEPHLPMM(object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AKCHLEGEPLL(Vector3 AADGBMGBAIC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AINIGLNJFBJ(Vector3 KKAOBCBGFIM, Vector3 DDMPBEFKBLL);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HHGODEJMCCE(Vector3 JDNMLAKNLHJ, Vector3 OPOBMLOHGFE);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 DMDGMFGGIAE(Vector3 BDPHNFIHANA);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KHBKHPNFBEC(Vector3 INOKLOLKDMF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface MBLCDFIPIEA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PNHKMBJKKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBEOLCEABKC(string DAANGKEHOHD);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLPAGNFGDFB(RigidbodyEx JDPJJGMMDGH, Action PMBBLAOPHON);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MDOCJAJDFJB JFOEIEPGKFJ(int LGMLIJJLBOE);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANODBMHECNF(Vector3 KFDFIPMLLPM, float ONBGIMPJGIH, Color FPHNLEHIJEM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface CHIJNEIHLIH
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	MBLCDFIPIEA GAAHLJMPLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DGEFOKDFJMI MPMKBPELMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FONBAMECPJK : AFLINHCECMA, IDisposable, JCAJMJFHOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal readonly CHIJNEIHLIH IHEHADIIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal JHBNJICCPFH KBGMGHOLOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FNKMPHIMIPO IFOFJDILHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LMCCBONHFOL JEDMNGNCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JEJAOFLHAHB EJLBFNGBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal AGPODNOGBEO EPGKHHFEBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EMALMEEDIMM AINMEMFPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal EEDAHLHGLOO DFGDBDPENGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal LCPFBFJHACP APMCFDHCNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CKOJGNCNGLP GGLANEMMFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal GLIHDDLGOLD EHAHCJNGPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal GNLGEBAHDOI FCDIPGPFJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal PPFBLMBBEHG AKKFOJDOENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal NHHBKDJMHMC CGECMMCGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal FIPKFJJEKKB MLPKEKPNOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HMJOLGOHPLI EJBOKHOBICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal IDisposable MFEJHBBJNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool GMPGEEIPNEJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NLPLHJLLGBB MBOFOMHLNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "22")]
		get
		{
			return default(NLPLHJLLGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public OCHLPLCDEOP MCFNJCKFPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB78B30", Offset = "0xB77130", VA = "0x180B78B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject HPNHKENLPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAAEE90", Offset = "0xAAD490", VA = "0x180AAEE90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAAEF10", Offset = "0xAAD510", VA = "0x180AAEF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB78B50", Offset = "0xB77150", VA = "0x180B78B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D38A60", Offset = "0x8D37060", VA = "0x188D38A60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BF50", Offset = "0x8D3A550", VA = "0x188D3BF50", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B510", Offset = "0x8D39B10", VA = "0x188D3B510", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LABGDFIOJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A410", Offset = "0x8D38A10", VA = "0x188D3A410", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AFLINHCECMA HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D394E0", Offset = "0x8D37AE0", VA = "0x188D394E0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool JGJIPHIDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D36610", Offset = "0x8D34C10", VA = "0x188D36610", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CJKCNKHINOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D39180", Offset = "0x8D37780", VA = "0x188D39180", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool HMDJDGHDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8D37360", Offset = "0x8D35960", VA = "0x188D37360", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LDOJJNLFMJG IDJEEBDMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D39220", Offset = "0x8D37820", VA = "0x188D39220", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D380D0", Offset = "0x8D366D0", VA = "0x188D380D0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KNMODGMCAEJ PHHGNNEFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D36DE0", Offset = "0x8D353E0", VA = "0x188D36DE0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D383B0", Offset = "0x8D369B0", VA = "0x188D383B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MEHMIOIICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D39490", Offset = "0x8D37A90", VA = "0x188D39490", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D39730", Offset = "0x8D37D30", VA = "0x188D39730", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KMMLNNKOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8D39040", Offset = "0x8D37640", VA = "0x188D39040", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D36BA0", Offset = "0x8D351A0", VA = "0x188D36BA0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MJABHHPDODG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8D37FF0", Offset = "0x8D365F0", VA = "0x188D37FF0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A480", Offset = "0x8D38A80", VA = "0x188D3A480", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 JCHIBDNJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8D38410", Offset = "0x8D36A10", VA = "0x188D38410", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B2D0", Offset = "0x8D398D0", VA = "0x188D3B2D0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 LFKDPNAGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D376C0", Offset = "0x8D35CC0", VA = "0x188D376C0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8D36EE0", Offset = "0x8D354E0", VA = "0x188D36EE0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool OAJMEEFOCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8D365C0", Offset = "0x8D34BC0", VA = "0x188D365C0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool PHHANJFHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A130", Offset = "0x8D38730", VA = "0x188D3A130", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool GCMINIMGNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D38210", Offset = "0x8D36810", VA = "0x188D38210", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool GOFMMIKMJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8D36670", Offset = "0x8D34C70", VA = "0x188D36670", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 HEAGGCAOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D37F20", Offset = "0x8D36520", VA = "0x188D37F20", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 HPAFKOFENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B610", Offset = "0x8D39C10", VA = "0x188D3B610", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 BFICBHNPEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A190", Offset = "0x8D38790", VA = "0x188D3A190", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D393B0", Offset = "0x8D379B0", VA = "0x188D393B0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 LMILABLNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D399B0", Offset = "0x8D37FB0", VA = "0x188D399B0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float HABFFBAPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B3B0", Offset = "0x8D399B0", VA = "0x188D3B3B0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float PINPEFDKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A720", Offset = "0x8D38D20", VA = "0x188D3A720", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D35B90", Offset = "0x8D34190", VA = "0x188D35B90", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 DHPHCJHJBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AB80", Offset = "0x8D39180", VA = "0x188D3AB80", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion ACMFNIJMGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D36AD0", Offset = "0x8D350D0", VA = "0x188D36AD0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float JGDNBFMPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D39EC0", Offset = "0x8D384C0", VA = "0x188D39EC0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D378A0", Offset = "0x8D35EA0", VA = "0x188D378A0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float GFDHAKAPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D38E00", Offset = "0x8D37400", VA = "0x188D38E00", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D396D0", Offset = "0x8D37CD0", VA = "0x188D396D0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool HCJDFMGBPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A3C0", Offset = "0x8D389C0", VA = "0x188D3A3C0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D37EC0", Offset = "0x8D364C0", VA = "0x188D37EC0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FLIFMIOEKDE IDNCNDEILKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B570", Offset = "0x8D39B70", VA = "0x188D3B570", Slot = "70")]
		get
		{
			return default(FLIFMIOEKDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D39670", Offset = "0x8D37C70", VA = "0x188D39670", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool IKOEBPFPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B5C0", Offset = "0x8D39BC0", VA = "0x188D3B5C0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IMKDKMLBCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GLHHDIBFIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D36E30", Offset = "0x8D35430", VA = "0x188D36E30", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BCB0", Offset = "0x8D3A2B0", VA = "0x188D3BCB0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float PCAINAIAGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D38CC0", Offset = "0x8D372C0", VA = "0x188D38CC0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A690", Offset = "0x8D38C90", VA = "0x188D3A690", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float BMBFLPIKNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D38F50", Offset = "0x8D37550", VA = "0x188D38F50", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D377A0", Offset = "0x8D35DA0", VA = "0x188D377A0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CEJBPPBLEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A050", Offset = "0x8D38650", VA = "0x188D3A050", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AA40", Offset = "0x8D39040", VA = "0x188D3AA40", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 KNGNNNLEBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D397F0", Offset = "0x8D37DF0", VA = "0x188D397F0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A0F0", Offset = "0x8D386F0", VA = "0x188D3A0F0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion OGKNMPEPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B220", Offset = "0x8D39820", VA = "0x188D3B220", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B990", Offset = "0x8D39F90", VA = "0x188D3B990", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints LDAPKPBEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D381C0", Offset = "0x8D367C0", VA = "0x188D381C0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C000", Offset = "0x8D3A600", VA = "0x188D3C000", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool DCJNAJFFGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D391D0", Offset = "0x8D377D0", VA = "0x188D391D0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A880", Offset = "0x8D38E80", VA = "0x188D3A880", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode JCMCAJOOFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D35BF0", Offset = "0x8D341F0", VA = "0x188D35BF0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D37B00", Offset = "0x8D36100", VA = "0x188D37B00", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool FIMKCJLMKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D37900", Offset = "0x8D35F00", VA = "0x188D37900", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool NIMGFGNGKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D39830", Offset = "0x8D37E30", VA = "0x188D39830", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GJMCCLEBNCH PNNGFLPGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BEF0", Offset = "0x8D3A4F0", VA = "0x188D3BEF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B6F0", Offset = "0x8D39CF0", VA = "0x188D3B6F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event GJMCCLEBNCH FEHEPNOPKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B750", Offset = "0x8D39D50", VA = "0x188D3B750", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D35AE0", Offset = "0x8D340E0", VA = "0x188D35AE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event ICCJKBLNFCN KOFKLAGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AD40", Offset = "0x8D39340", VA = "0x188D3AD40", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D382F0", Offset = "0x8D368F0", VA = "0x188D382F0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GJMCCLEBNCH FFFKAKAOPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D36A70", Offset = "0x8D35070", VA = "0x188D36A70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D39120", Offset = "0x8D37720", VA = "0x188D39120", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event GJMCCLEBNCH HHHEHFDFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D36D80", Offset = "0x8D35380", VA = "0x188D36D80", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B880", Offset = "0x8D39E80", VA = "0x188D3B880", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event GJMCCLEBNCH GOBHAOBFLON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A270", Offset = "0x8D38870", VA = "0x188D3A270", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D38FE0", Offset = "0x8D375E0", VA = "0x188D38FE0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<AHNGGBKKFOE, AHNGGBKKFOE> JDMNGFPHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D38350", Offset = "0x8D36950", VA = "0x188D38350", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BFA0", Offset = "0x8D3A5A0", VA = "0x188D3BFA0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event GJMCCLEBNCH OOFEDCIOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D39E60", Offset = "0x8D38460", VA = "0x188D39E60", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D37300", Offset = "0x8D35900", VA = "0x188D37300", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event GJMCCLEBNCH PMDGDLGHLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BD60", Offset = "0x8D3A360", VA = "0x188D3BD60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D37B60", Offset = "0x8D36160", VA = "0x188D37B60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C0A0", Offset = "0x8D3A6A0", VA = "0x188D3C0A0")]
	public FONBAMECPJK(GameObject JJEACKINPOJ, RigidbodyEx PACJHOIGNKI, CHIJNEIHLIH IHEHADIIJNO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8D373B0", Offset = "0x8D359B0", VA = "0x188D373B0", Slot = "139")]
	protected virtual void DCBJLKMPHDC(CHIJNEIHLIH IHEHADIIJNO, BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8D37DC0", Offset = "0x8D363C0", VA = "0x188D37DC0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8D39270", Offset = "0x8D37870", VA = "0x188D39270", Slot = "93")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8D35A50", Offset = "0x8D34050", VA = "0x188D35A50", Slot = "94")]
	public void AAOGDOMHBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A8E0", Offset = "0x8D38EE0", VA = "0x188D3A8E0", Slot = "95")]
	public void KGIFKDJGHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8D376A0", Offset = "0x8D35CA0", VA = "0x188D376A0", Slot = "96")]
	public void DCHKGAFMEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8D366C0", Offset = "0x8D34CC0", VA = "0x188D366C0")]
	private void BCAAPHLKHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8D38F60", Offset = "0x8D37560", VA = "0x188D38F60")]
	private void GCFADPHNBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B8E0", Offset = "0x8D39EE0", VA = "0x188D3B8E0")]
	private void OCKPLEAEBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AE50", Offset = "0x8D39450", VA = "0x188D3AE50", Slot = "30")]
	public AFLINHCECMA LFBIIEDDKCD(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B810", Offset = "0x8D39E10", VA = "0x188D3B810", Slot = "98")]
	public void NMLEEMHPCCP(AFLINHCECMA KOPHBHGIACG, bool NNOFAGIMANK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AED0", Offset = "0x8D394D0", VA = "0x188D3AED0", Slot = "99")]
	public void LGJJPMHGHPB(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8D39C50", Offset = "0x8D38250", VA = "0x188D39C50", Slot = "100")]
	public void HHPDEAMMEOL(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A940", Offset = "0x8D38F40", VA = "0x188D3A940", Slot = "101")]
	public Vector3 KHBKHPNFBEC(Vector3 INOKLOLKDMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8D37CC0", Offset = "0x8D362C0", VA = "0x188D37CC0", Slot = "102")]
	public Vector3 DMDGMFGGIAE(Vector3 BDPHNFIHANA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8D37010", Offset = "0x8D35610", VA = "0x188D37010", Slot = "103")]
	public void CJOABAEICMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8D37260", Offset = "0x8D35860", VA = "0x188D37260", Slot = "104")]
	public void COGKDECNKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AE00", Offset = "0x8D39400", VA = "0x188D3AE00", Slot = "105")]
	public void LEOEAJLLKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8D39B60", Offset = "0x8D38160", VA = "0x188D39B60", Slot = "106")]
	public void HHGODEJMCCE(Vector3 JDNMLAKNLHJ, Vector3 OPOBMLOHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34240", VA = "0x188D35C40", Slot = "107")]
	public void AINIGLNJFBJ(Vector3 KKAOBCBGFIM, Vector3 DDMPBEFKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D36180", Offset = "0x8D34780", VA = "0x188D36180", Slot = "108")]
	public void AKCHLEGEPLL(Vector3 AADGBMGBAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8D38AB0", Offset = "0x8D370B0", VA = "0x188D38AB0", Slot = "109")]
	public void FDLKOHMMCIM(JKCJIHCAFND CJJGBDBIKNK, Vector3 JGCOGMBGAIE, float JCMCABMDPDI, float JNJGMIJAPBG = 8f, float FGEMNCHJAOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B470", Offset = "0x8D39A70", VA = "0x188D3B470", Slot = "110")]
	public void MPLEJJCMNFI(AGKPFFONCGI BOIEPIHDFOA, Vector3 DEFJCKCMJLK, float LPGBJACEOGH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D37C10", Offset = "0x8D36210", VA = "0x188D37C10", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DKOOOOCKALH(AGKPFFONCGI BOIEPIHDFOA, Vector3 LDAEEKEKDJC, float FGNDKKHAFBJ = 7f, float JDPKNMPDEGH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B9C0", Offset = "0x8D39FC0", VA = "0x188D3B9C0", Slot = "112")]
	public Vector3 OHDPDACBGEN(Vector3 KOPHBHGIACG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8D36C80", Offset = "0x8D35280", VA = "0x188D36C80", Slot = "113")]
	public Vector3 BIGOJHBNDIA(Vector3 KOPHBHGIACG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D38F00", Offset = "0x8D37500", VA = "0x188D38F00", Slot = "114")]
	public void GAOBPBHIPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8D39600", Offset = "0x8D37C00", VA = "0x188D39600", Slot = "115")]
	public void GOCAMMAIKFO(AFLINHCECMA AGCHBDHDAAA, object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8D37AA0", Offset = "0x8D360A0", VA = "0x188D37AA0", Slot = "116")]
	public void DHIDEPCMGHN(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BBD0", Offset = "0x8D3A1D0", VA = "0x188D3BBD0", Slot = "63")]
	public void OIECIPFBALB((Quaternion rot, Vector3 moments) FGMFIOKLJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A370", Offset = "0x8D38970", VA = "0x188D3A370", Slot = "117")]
	public void JDNBIEICPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D372B0", Offset = "0x8D358B0", VA = "0x188D372B0", Slot = "118")]
	public void COHAPIBFEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B940", Offset = "0x8D39F40", VA = "0x188D3B940", Slot = "119")]
	public void OEELEHNGNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A2D0", Offset = "0x8D388D0", VA = "0x188D3A2D0", Slot = "120")]
	public bool IODAFJKJAHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A320", Offset = "0x8D38920", VA = "0x188D3A320", Slot = "97")]
	public void IPODJONCDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B260", Offset = "0x8D39860", VA = "0x188D3B260", Slot = "121")]
	public void MEDHHOOPBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D39FF0", Offset = "0x8D385F0", VA = "0x188D39FF0", Slot = "122")]
	public void HMBCKCPHKFB(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AB20", Offset = "0x8D39120", VA = "0x188D3AB20", Slot = "123")]
	public void KJOEMODIGHA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B400", Offset = "0x8D39A00", VA = "0x188D3B400", Slot = "124")]
	public void MPFLAILIPIP(object INEEADCBMPK, bool KLPLCNHJGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8D37060", Offset = "0x8D35660", VA = "0x188D37060", Slot = "125")]
	public void CNICEBFNLID(Vector3 BAEGEJDEFCC, Quaternion DEPHFBPLKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A560", Offset = "0x8D38B60", VA = "0x188D3A560", Slot = "126")]
	public void JIENMCCNBGF(Vector3 BMEDECNGGHD, Quaternion BDEAMIJGHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8D35B40", Offset = "0x8D34140", VA = "0x188D35B40", Slot = "127")]
	public bool AGDEGLOOOAA(float PFDEEHBMFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B7B0", Offset = "0x8D39DB0", VA = "0x188D3B7B0", Slot = "128")]
	public void NMBILEBPAHH(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3ADA0", Offset = "0x8D393A0", VA = "0x188D3ADA0", Slot = "129")]
	public void LEEFGEKGAFI(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8D37A40", Offset = "0x8D36040", VA = "0x188D37A40", Slot = "130")]
	public void DFONOONJCJH(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8D39790", Offset = "0x8D37D90", VA = "0x188D39790", Slot = "131")]
	public void HCNECMLDKIA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BE10", Offset = "0x8D3A410", VA = "0x188D3BE10", Slot = "132")]
	public void OKCPPCHDIAC(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A770", Offset = "0x8D38D70", VA = "0x188D3A770", Slot = "133")]
	public void KCACIKMAHBF(Vector3 AKKFOJDOENB, Vector3 APHHGJIDDCM, ForceMode HBOKLBGANOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8D39F10", Offset = "0x8D38510", VA = "0x188D39F10", Slot = "134")]
	public void HLJENLHDNIF(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AC60", Offset = "0x8D39260", VA = "0x188D3AC60", Slot = "135")]
	public void LDOPEKBCKFP(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AF30", Offset = "0x8D39530", VA = "0x188D3AF30", Slot = "136")]
	public bool LKLOFHEOALP(Vector3 JPDMHOCEDGB, [Out] RaycastHit ACFNAAGLOLN, float AHKHODDOFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8D36FC0", Offset = "0x8D355C0", VA = "0x188D36FC0", Slot = "137")]
	public void CIPNHALDNGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C060", Offset = "0x8D3A660", VA = "0x188D3C060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B140", Offset = "0x8D39740", VA = "0x188D3B140")]
	private void LPBHAGAEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BAC0", Offset = "0x8D3A0C0", VA = "0x188D3BAC0")]
	private void OHOPEPJHGBO(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8D384F0", Offset = "0x8D36AF0", VA = "0x188D384F0")]
	private void FBGBNAKAEFO(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D38E50", Offset = "0x8D37450", VA = "0x188D38E50")]
	private void GAAJGDGFGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8D36940", Offset = "0x8D34F40", VA = "0x188D36940")]
	private void BCDFAFKNILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8D39CB0", Offset = "0x8D382B0", VA = "0x188D39CB0")]
	private void HJGCHACHPKO(AFLINHCECMA MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8D39A90", Offset = "0x8D38090", VA = "0x188D39A90")]
	private void HGMIEHNLLDN(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8D39530", Offset = "0x8D37B30", VA = "0x188D39530")]
	private void GNPGFMJKNMK(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8D38B70", Offset = "0x8D37170", VA = "0x188D38B70")]
	private void FDOJIHPLJBI(OCHLPLCDEOP BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8D35D30", Offset = "0x8D34330", VA = "0x188D35D30", Slot = "142")]
	protected virtual void AJAKHMPNBFP(OCHLPLCDEOP JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8D36260", Offset = "0x8D34860", VA = "0x188D36260")]
	protected void AKLOMBJCLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8D386E0", Offset = "0x8D36CE0", VA = "0x188D386E0")]
	protected void FBLPDLFAFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8D38CD0", Offset = "0x8D372D0", VA = "0x188D38CD0")]
	private void FHNDPPAMEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AFD0", Offset = "0x8D395D0", VA = "0x188D3AFD0")]
	private void LKMBJBKJJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class OAFAIMCHEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8D423F0", Offset = "0x8D409F0", VA = "0x188D423F0")]
	public static AFLINHCECMA BGLDDNHIHKH(this AFLINHCECMA JDPJJGMMDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8D424B0", Offset = "0x8D40AB0", VA = "0x188D424B0")]
	public static bool DEMDAFGHPPC(this AFLINHCECMA JDPJJGMMDGH, AFLINHCECMA MGMICADJKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8D42550", Offset = "0x8D40B50", VA = "0x188D42550")]
	public static bool DMGFBBODMJN(this AFLINHCECMA JDPJJGMMDGH, AFLINHCECMA HOHKLHNNBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8D425F0", Offset = "0x8D40BF0", VA = "0x188D425F0")]
	public static OCHLPLCDEOP IFACEINAIFG(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8D42640", Offset = "0x8D40C40", VA = "0x188D42640")]
	public static FONBAMECPJK KJIFKOFDJDJ(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CLDOPEHAAOL : DGEFOKDFJMI
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FFC0", Offset = "0x8D2E5C0", VA = "0x188D2FFC0", Slot = "19")]
	public AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH, BMAKNOKMAHD CDDIADBJAOB, CHIJNEIHLIH IHEHADIIJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "4")]
	public JHBNJICCPFH COOGKKFGILH(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "5")]
	public JEJAOFLHAHB OBOALCDOPIG(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "6")]
	public AGPODNOGBEO KKBINGMCCGC(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "7")]
	public EEDAHLHGLOO OPNGHLOFNEA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "8")]
	public CKOJGNCNGLP MFPLKLJHLKF(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "9")]
	public GLIHDDLGOLD NDLMBJPCJLD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "10")]
	public GNLGEBAHDOI MAHIJLFNCKE(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "11")]
	public PPFBLMBBEHG PHBEPKIIDAD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "12")]
	public HMJOLGOHPLI BALOIKMPFHA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "13")]
	public LCPFBFJHACP ABGFGNDEEKM(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public FIPKFJJEKKB OGENIDNJPHP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public LMCCBONHFOL PMJIDNMNMHB(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public FNKMPHIMIPO GGKBELKAEAC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public EMALMEEDIMM EGLLCABHBEL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	public NHHBKDJMHMC FNOPBEPKMPL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CLDOPEHAAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "14")]
	private FIPKFJJEKKB IICAPKKDHMH(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "15")]
	private LMCCBONHFOL MNDMJCGEDKE(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "16")]
	private FNKMPHIMIPO GHMBALAMAPC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "17")]
	private EMALMEEDIMM BJDLDLAHAOP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "18")]
	private NHHBKDJMHMC CMLOCMCPCEC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(DGEFOKDFJMI), new string[] { })]
public class EDGEACILAHA : DGEFOKDFJMI, MOLBKPMFEIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DGEFOKDFJMI JJOOHLGJJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DGEFOKDFJMI ALEMNOAOHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private AOGHPIKHELF DDOHGPEJNLK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private DGEFOKDFJMI MPMKBPELMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8D34050", Offset = "0x8D32650", VA = "0x188D34050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8D34360", Offset = "0x8D32960", VA = "0x188D34360", Slot = "20")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8D34160", Offset = "0x8D32760", VA = "0x188D34160", Slot = "4")]
	public JHBNJICCPFH COOGKKFGILH(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8D347C0", Offset = "0x8D32DC0", VA = "0x188D347C0", Slot = "5")]
	public JEJAOFLHAHB OBOALCDOPIG(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8D343B0", Offset = "0x8D329B0", VA = "0x188D343B0", Slot = "6")]
	public AGPODNOGBEO KKBINGMCCGC(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8D34860", Offset = "0x8D32E60", VA = "0x188D34860", Slot = "7")]
	public EEDAHLHGLOO OPNGHLOFNEA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8D345D0", Offset = "0x8D32BD0", VA = "0x188D345D0", Slot = "8")]
	public CKOJGNCNGLP MFPLKLJHLKF(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8D34720", Offset = "0x8D32D20", VA = "0x188D34720", Slot = "9")]
	public GLIHDDLGOLD NDLMBJPCJLD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8D34530", Offset = "0x8D32B30", VA = "0x188D34530", Slot = "10")]
	public GNLGEBAHDOI MAHIJLFNCKE(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8D34900", Offset = "0x8D32F00", VA = "0x188D34900", Slot = "11")]
	public PPFBLMBBEHG PHBEPKIIDAD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8D33F00", Offset = "0x8D32500", VA = "0x188D33F00", Slot = "12")]
	public HMJOLGOHPLI BALOIKMPFHA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8D33E60", Offset = "0x8D32460", VA = "0x188D33E60", Slot = "13")]
	public LCPFBFJHACP ABGFGNDEEKM(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8D342B0", Offset = "0x8D328B0", VA = "0x188D342B0")]
	public FIPKFJJEKKB OGENIDNJPHP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8D34670", Offset = "0x8D32C70", VA = "0x188D34670")]
	public LMCCBONHFOL PMJIDNMNMHB(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8D34200", Offset = "0x8D32800", VA = "0x188D34200")]
	public FNKMPHIMIPO GGKBELKAEAC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8D33FA0", Offset = "0x8D325A0", VA = "0x188D33FA0")]
	public EMALMEEDIMM EGLLCABHBEL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8D340B0", Offset = "0x8D326B0", VA = "0x188D340B0")]
	public NHHBKDJMHMC FNOPBEPKMPL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8D34450", Offset = "0x8D32A50", VA = "0x188D34450", Slot = "19")]
	public AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH, BMAKNOKMAHD CDDIADBJAOB, CHIJNEIHLIH IHEHADIIJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8D349A0", Offset = "0x8D32FA0", VA = "0x188D349A0")]
	public EDGEACILAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8D342B0", Offset = "0x8D328B0", VA = "0x188D342B0", Slot = "14")]
	private FIPKFJJEKKB IICAPKKDHMH(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8D34670", Offset = "0x8D32C70", VA = "0x188D34670", Slot = "15")]
	private LMCCBONHFOL MNDMJCGEDKE(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8D34200", Offset = "0x8D32800", VA = "0x188D34200", Slot = "16")]
	private FNKMPHIMIPO GHMBALAMAPC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8D33FA0", Offset = "0x8D325A0", VA = "0x188D33FA0", Slot = "17")]
	private EMALMEEDIMM BJDLDLAHAOP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8D340B0", Offset = "0x8D326B0", VA = "0x188D340B0", Slot = "18")]
	private NHHBKDJMHMC CMLOCMCPCEC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KCADJGFDDFO : JHBNJICCPFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANIDMLCEDFO(AFLINHCECMA JDPJJGMMDGH);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FILMOPDAIOE(AFLINHCECMA JDPJJGMMDGH);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPNCEEKNJAK(AFLINHCECMA MDCDIDODDBB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKLJCBFPALL(AFLINHCECMA MDCDIDODDBB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LCHBIGMBMJK : AGPODNOGBEO
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	FGOBJNPBLOO<AFLINHCECMA> BLMKDBKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	AFLINHCECMA KOKPFJKFDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PDMCOFACPJK : EMALMEEDIMM
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NKNJIFALHGL(Rigidbody ILKLGJBBFLK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KDINAHCFEMA : LMCCBONHFOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView LKBABOBJFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NCIGPICMKMC : HMJOLGOHPLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CollisionDetectionMode CEOKCFELEHI;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8D41000", Offset = "0x8D3F600", VA = "0x188D41000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode JCMCAJOOFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8D40D60", Offset = "0x8D3F360", VA = "0x188D40D60", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8D40F90", Offset = "0x8D3F590", VA = "0x188D40F90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FC90", Offset = "0x8D3E290", VA = "0x188D3FC90")]
	public NCIGPICMKMC(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8D41050", Offset = "0x8D3F650", VA = "0x188D41050", Slot = "6")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8D41160", Offset = "0x8D3F760", VA = "0x188D41160", Slot = "9")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8D411E0", Offset = "0x8D3F7E0", VA = "0x188D411E0", Slot = "7")]
	public void KBINHFLPJNJ(bool AGJPJFLIFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8D40D50", Offset = "0x8D3F350", VA = "0x188D40D50", Slot = "8")]
	public void AFGALNPBOMN(bool AGJPJFLIFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8D411F0", Offset = "0x8D3F7F0", VA = "0x188D411F0", Slot = "10")]
	public bool LKLOFHEOALP(Vector3 JPDMHOCEDGB, [Out] RaycastHit ACFNAAGLOLN, float AHKHODDOFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8D40E70", Offset = "0x8D3F470", VA = "0x188D40E70")]
	private void AMJJIOHHJAC(bool AGJPJFLIFBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DIBOLIPOGAN : GLIHDDLGOLD, IDisposable, JCEDEPBPGKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FLIFMIOEKDE MDNMDBFDADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private MDOCJAJDFJB CJGPABPPAKO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FLIFMIOEKDE IDNCNDEILKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D30560", Offset = "0x8D2EB60", VA = "0x188D30560", Slot = "6")]
		get
		{
			return default(FLIFMIOEKDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8D30490", Offset = "0x8D2EA90", VA = "0x188D30490", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform MNCGFNBPICI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE689C0", Offset = "0xE66FC0", VA = "0x180E689C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<AHNGGBKKFOE, AHNGGBKKFOE> JDMNGFPHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8D30170", Offset = "0x8D2E770", VA = "0x188D30170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8D306B0", Offset = "0x8D2ECB0", VA = "0x188D306B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8D30760", Offset = "0x8D2ED60", VA = "0x188D30760")]
	public DIBOLIPOGAN(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8D30220", Offset = "0x8D2E820", VA = "0x188D30220", Slot = "8")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8D30120", Offset = "0x8D2E720", VA = "0x188D30120", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x13C3370", Offset = "0x13C1970", VA = "0x1813C3370", Slot = "11")]
	private void DILBGEPCIKF(AHNGGBKKFOE EAPJKOLGGJL, AHNGGBKKFOE KNILLMPDFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
	private void CPCDPKABBLP(bool IOELFDJBDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NNPOKMADHDI : DGEFOKDFJMI
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8D41750", Offset = "0x8D3FD50", VA = "0x188D41750", Slot = "4")]
	public JHBNJICCPFH COOGKKFGILH(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8D42180", Offset = "0x8D40780", VA = "0x188D42180", Slot = "5")]
	public JEJAOFLHAHB OBOALCDOPIG(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8D41AB0", Offset = "0x8D400B0", VA = "0x188D41AB0", Slot = "6")]
	public AGPODNOGBEO KKBINGMCCGC(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8D422B0", Offset = "0x8D408B0", VA = "0x188D422B0", Slot = "7")]
	public EEDAHLHGLOO OPNGHLOFNEA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8D41E50", Offset = "0x8D40450", VA = "0x188D41E50", Slot = "8")]
	public CKOJGNCNGLP MFPLKLJHLKF(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8D420B0", Offset = "0x8D406B0", VA = "0x188D420B0", Slot = "9")]
	public GLIHDDLGOLD NDLMBJPCJLD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8D41D30", Offset = "0x8D40330", VA = "0x188D41D30", Slot = "10")]
	public GNLGEBAHDOI MAHIJLFNCKE(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8D42330", Offset = "0x8D40930", VA = "0x188D42330", Slot = "11")]
	public PPFBLMBBEHG PHBEPKIIDAD(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8D41410", Offset = "0x8D3FA10", VA = "0x188D41410", Slot = "12")]
	public HMJOLGOHPLI BALOIKMPFHA(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8D41350", Offset = "0x8D3F950", VA = "0x188D41350", Slot = "13")]
	public LCPFBFJHACP ABGFGNDEEKM(AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8D41970", Offset = "0x8D3FF70", VA = "0x188D41970")]
	public FIPKFJJEKKB OGENIDNJPHP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8D41F20", Offset = "0x8D40520", VA = "0x188D41F20")]
	public LMCCBONHFOL PMJIDNMNMHB(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8D41840", Offset = "0x8D3FE40", VA = "0x188D41840")]
	public FNKMPHIMIPO GGKBELKAEAC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8D414D0", Offset = "0x8D3FAD0", VA = "0x188D414D0")]
	public EMALMEEDIMM EGLLCABHBEL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8D41670", Offset = "0x8D3FC70", VA = "0x188D41670")]
	public NHHBKDJMHMC FNOPBEPKMPL(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8D41BE0", Offset = "0x8D401E0", VA = "0x188D41BE0", Slot = "19")]
	public AFLINHCECMA LAFGMOCPEPI(RigidbodyEx JDPJJGMMDGH, BMAKNOKMAHD CDDIADBJAOB, CHIJNEIHLIH IHEHADIIJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public NNPOKMADHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8D41970", Offset = "0x8D3FF70", VA = "0x188D41970", Slot = "14")]
	private FIPKFJJEKKB IICAPKKDHMH(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8D41F20", Offset = "0x8D40520", VA = "0x188D41F20", Slot = "15")]
	private LMCCBONHFOL MNDMJCGEDKE(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8D41840", Offset = "0x8D3FE40", VA = "0x188D41840", Slot = "16")]
	private FNKMPHIMIPO GHMBALAMAPC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8D414D0", Offset = "0x8D3FAD0", VA = "0x188D414D0", Slot = "17")]
	private EMALMEEDIMM BJDLDLAHAOP(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8D41670", Offset = "0x8D3FC70", VA = "0x188D41670", Slot = "18")]
	private NHHBKDJMHMC CMLOCMCPCEC(AFLINHCECMA MFNKIFOCMAO, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OEPCJMAADPD : PPFBLMBBEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8D41000", Offset = "0x8D3F600", VA = "0x188D41000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool IKOEBPFPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8D43220", Offset = "0x8D41820", VA = "0x188D43220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool JGJIPHIDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8D426C0", Offset = "0x8D40CC0", VA = "0x188D426C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8D433D0", Offset = "0x8D419D0", VA = "0x188D433D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FC90", Offset = "0x8D3E290", VA = "0x188D3FC90")]
	public OEPCJMAADPD(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8D43270", Offset = "0x8D41870", VA = "0x188D43270", Slot = "4")]
	public void OKCPPCHDIAC(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8D42AE0", Offset = "0x8D410E0", VA = "0x188D42AE0")]
	private void JFHFPFLBBEE(Vector3 AKKFOJDOENB, ForceMode HBOKLBGANOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8D42D40", Offset = "0x8D41340", VA = "0x188D42D40", Slot = "5")]
	public void KCACIKMAHBF(Vector3 AKKFOJDOENB, Vector3 APHHGJIDDCM, ForceMode HBOKLBGANOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8D42980", Offset = "0x8D40F80", VA = "0x188D42980", Slot = "6")]
	public void HLJENLHDNIF(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8D42720", Offset = "0x8D40D20", VA = "0x188D42720")]
	private void HEJNAINDCMH(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8D42FC0", Offset = "0x8D415C0", VA = "0x188D42FC0", Slot = "7")]
	public void LDOPEKBCKFP(Vector3 LFDFEGCBLBM, ForceMode HBOKLBGANOG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ILNPEAKCLGA : LCPFBFJHACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool GGFIGBKCBLF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool HCJDFMGBPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB24ED0", VA = "0x180B268D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FAE0", Offset = "0x8D3E0E0", VA = "0x188D3FAE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FC90", Offset = "0x8D3E290", VA = "0x188D3FC90")]
	public ILNPEAKCLGA(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FBF0", Offset = "0x8D3E1F0", VA = "0x188D3FBF0", Slot = "6")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FC20", Offset = "0x8D3E220", VA = "0x188D3FC20", Slot = "7")]
	public void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ANNPHNEOOMF : KCADJGFDDFO, JHBNJICCPFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly AFLINHCECMA JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<AFLINHCECMA> PAICHDGKDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private AFLINHCECMA BOCNDANOLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AFLINHCECMA BEBONNCPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Transform LPNPKGAPJIA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform JJKHGJPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F170", Offset = "0x8D2D770", VA = "0x188D2F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5730", Offset = "0xAA3D30", VA = "0x180AA5730", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F460", Offset = "0x8D2DA60", VA = "0x188D2F460", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public AFLINHCECMA HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<AFLINHCECMA> IGALLKDJPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event GJMCCLEBNCH PNNGFLPGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FDB0", Offset = "0x8D2E3B0", VA = "0x188D2FDB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F470", Offset = "0x8D2DA70", VA = "0x188D2F470", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event GJMCCLEBNCH FEHEPNOPKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F510", Offset = "0x8D2DB10", VA = "0x188D2F510", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E2E0", Offset = "0x8D2C8E0", VA = "0x188D2E2E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ICCJKBLNFCN KOFKLAGLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F310", Offset = "0x8D2D910", VA = "0x188D2F310", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E740", Offset = "0x8D2CD40", VA = "0x188D2E740", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action BNEIOEENBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E110", Offset = "0x8D2C710", VA = "0x188D2E110", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E470", Offset = "0x8D2CA70", VA = "0x188D2E470", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action PFMCIIDJLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EF80", Offset = "0x8D2D580", VA = "0x188D2EF80", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EA50", Offset = "0x8D2D050", VA = "0x188D2EA50", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AFLINHCECMA> KMHPFLLGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F0C0", Offset = "0x8D2D6C0", VA = "0x188D2F0C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E510", Offset = "0x8D2CB10", VA = "0x188D2E510", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AFLINHCECMA> LBLJHHGHING
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F3B0", Offset = "0x8D2D9B0", VA = "0x188D2F3B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EED0", Offset = "0x8D2D4D0", VA = "0x188D2EED0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action NPCJCACMGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E6A0", Offset = "0x8D2CCA0", VA = "0x188D2E6A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FC60", Offset = "0x8D2E260", VA = "0x188D2FC60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AFLINHCECMA> LIJFGLHBBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FD00", Offset = "0x8D2E300", VA = "0x188D2FD00", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE50", Offset = "0x8D2E450", VA = "0x188D2FE50", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FF00", Offset = "0x8D2E500", VA = "0x188D2FF00")]
	public ANNPHNEOOMF(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E600", Offset = "0x8D2CC00", VA = "0x188D2E600", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F6E0", Offset = "0x8D2DCE0", VA = "0x188D2F6E0", Slot = "30")]
	public void NMLEEMHPCCP(AFLINHCECMA JBFCMKMBEEK, bool NNOFAGIMANK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E7E0", Offset = "0x8D2CDE0", VA = "0x188D2E7E0", Slot = "6")]
	public void EPNCEEKNJAK(AFLINHCECMA MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8D2EB90", Offset = "0x8D2D190", VA = "0x188D2EB90", Slot = "7")]
	public void FKLJCBFPALL(AFLINHCECMA MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E380", Offset = "0x8D2C980", VA = "0x188D2E380", Slot = "4")]
	public void ANIDMLCEDFO(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8D2EAF0", Offset = "0x8D2D0F0", VA = "0x188D2EAF0", Slot = "5")]
	public void FILMOPDAIOE(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F020", Offset = "0x8D2D620", VA = "0x188D2F020")]
	private void KEPNHKCKLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E5C0", Offset = "0x8D2CBC0", VA = "0x188D2E5C0")]
	private void DJEMLOBFICC(AFLINHCECMA MDCDIDODDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F1D0", Offset = "0x8D2D7D0", VA = "0x188D2F1D0")]
	private void LCNGEOBOFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F5B0", Offset = "0x8D2DBB0", VA = "0x188D2F5B0")]
	private void NMDCIIKEOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E1B0", Offset = "0x8D2C7B0", VA = "0x188D2E1B0")]
	private void AEALEJMLNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8D2EE10", Offset = "0x8D2D410", VA = "0x188D2EE10")]
	[CompilerGenerated]
	private object FMKDIDFHCOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CMILCBAAIEH
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8D30060", Offset = "0x8D2E660", VA = "0x188D30060")]
	public static KCADJGFDDFO NHMEMMHBOAI(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class AMBBHOMMNBI : LCHBIGMBMJK, AGPODNOGBEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FGOBJNPBLOO<AFLINHCECMA> HKNJOLJMEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool AMOPHCDPBKL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FGOBJNPBLOO<AFLINHCECMA> BLMKDBKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HEAGGCAOIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D5A0", Offset = "0x8D2BBA0", VA = "0x188D2D5A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 HPAFKOFENJE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DE50", Offset = "0x8D2C450", VA = "0x188D2DE50", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 JCHIBDNJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D5D0", Offset = "0x8D2BBD0", VA = "0x188D2D5D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AFLINHCECMA KOKPFJKFDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D480", Offset = "0x8D2BA80", VA = "0x188D2D480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E010", Offset = "0x8D2C610", VA = "0x188D2E010")]
	public AMBBHOMMNBI(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D530", Offset = "0x8D2BB30", VA = "0x188D2D530", Slot = "8")]
	public void CDDJPKCBPJJ(AFLINHCECMA BEBONNCPGLF, object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DDF0", Offset = "0x8D2C3F0", VA = "0x188D2DDF0", Slot = "9")]
	public void HPJAJDLDJOP(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D6C0", Offset = "0x8D2BCC0", VA = "0x188D2D6C0")]
	private Vector3 GGKMOJJGLBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DA60", Offset = "0x8D2C060", VA = "0x188D2DA60")]
	private void GKAJDFDLLDL(AFLINHCECMA EHOPBGHFDII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LHFCICDIAKH
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8D40680", Offset = "0x8D3EC80", VA = "0x188D40680")]
	public static LCHBIGMBMJK MOAKJADMGPD(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HBPGIDCPEOJ : PDMCOFACPJK, EMALMEEDIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OverridableVector3 HGPMPPHFMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 CADNMDCAAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float MJMKGABGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float BIIEIOBLBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Vector3 COLJECJNFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3? OPHOLPNMGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Quaternion? OBIDNALIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool JLMFDBGHNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool KDKPBAODBNI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 BFICBHNPEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1965A30", Offset = "0x1964030", VA = "0x181965A30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CCA0", Offset = "0x8D3B2A0", VA = "0x188D3CCA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 LMILABLNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CEF0", Offset = "0x8D3B4F0", VA = "0x188D3CEF0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float HABFFBAPBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE8F460", Offset = "0xE8DA60", VA = "0x180E8F460", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0C0", Offset = "0x8D3B6C0", VA = "0x188D3D0C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float PINPEFDKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD7C160", Offset = "0xD7A760", VA = "0x180D7C160", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C460", Offset = "0x8D3AA60", VA = "0x188D3C460", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DHPHCJHJBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D2F0", Offset = "0x8D3B8F0", VA = "0x188D3D2F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion ACMFNIJMGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C510", Offset = "0x8D3AB10", VA = "0x188D3C510", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D34E40", Offset = "0x8D33440", VA = "0x188D34E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event GJMCCLEBNCH KFOFECGMLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CC00", Offset = "0x8D3B200", VA = "0x188D3CC00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EB30", Offset = "0x8D3D130", VA = "0x188D3EB30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8D3EBD0", Offset = "0x8D3D1D0", VA = "0x188D3EBD0")]
	public HBPGIDCPEOJ(AFLINHCECMA JDPJJGMMDGH, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D1D0", Offset = "0x8D3B7D0", VA = "0x188D3D1D0", Slot = "17")]
	public void JDNBIEICPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CB20", Offset = "0x8D3B120", VA = "0x188D3CB20", Slot = "16")]
	public void COHAPIBFEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CFE0", Offset = "0x8D3B5E0", VA = "0x188D3CFE0", Slot = "19")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D480", Offset = "0x8D3BA80", VA = "0x188D3D480", Slot = "20")]
	public void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3E660", Offset = "0x8D3CC60", VA = "0x188D3E660", Slot = "18")]
	public void OEELEHNGNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C690", Offset = "0x8D3AC90", VA = "0x188D3C690", Slot = "21")]
	public void CIPNHALDNGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CCA0", Offset = "0x8D3B2A0", VA = "0x188D3CCA0")]
	private void EGNDEIBEMOP(Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8D3EA40", Offset = "0x8D3D040", VA = "0x188D3EA40")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PDHOHICGDAE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D0C0", Offset = "0x8D3B6C0", VA = "0x188D3D0C0")]
	private void IFMLFHOFFNA(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C460", Offset = "0x8D3AA60", VA = "0x188D3C460")]
	private void CAOBBELIHND(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CD50", Offset = "0x8D3B350", VA = "0x188D3CD50")]
	private Vector3 FHJMDHAADJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3E810", Offset = "0x8D3CE10", VA = "0x188D3E810", Slot = "15")]
	public void OIECIPFBALB((Quaternion rot, Vector3 moments) FGMFIOKLJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D660", Offset = "0x8D3BC60", VA = "0x188D3D660")]
	private Quaternion MEPOIAIGEPM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D7E0", Offset = "0x8D3BDE0", VA = "0x188D3D7E0")]
	public void NKNJIFALHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D8B0", Offset = "0x8D3BEB0", VA = "0x188D3D8B0", Slot = "4")]
	public (float, Vector3) NKNJIFALHGL(Rigidbody ILKLGJBBFLK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class HDLDHKHFMPD
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3ED30", Offset = "0x8D3D330", VA = "0x188D3ED30")]
	public static PDMCOFACPJK GMOABBHHPCD(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JPBGBBKJPIC : FNKMPHIMIPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PBCNGJENIAB EGKJHKEJLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly FMEBMDLLDAA ECFMGNDDOAN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool JKKLGDPMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1B32130", Offset = "0x1B30730", VA = "0x181B32130", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FMEBMDLLDAA CHOHNONGBII
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970", Slot = "11")]
		get
		{
			return default(FMEBMDLLDAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8D40350", Offset = "0x8D3E950", VA = "0x188D40350")]
	public JPBGBBKJPIC(AFLINHCECMA JDPJJGMMDGH, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FFF0", Offset = "0x8D3E5F0", VA = "0x188D3FFF0", Slot = "4")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8D402B0", Offset = "0x8D3E8B0", VA = "0x188D402B0")]
	private bool MKDFMLPGBLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FFC0", Offset = "0x8D3E5C0", VA = "0x188D3FFC0", Slot = "5")]
	public void FNOAKOEBBJM(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8D400C0", Offset = "0x8D3E6C0", VA = "0x188D400C0", Slot = "6")]
	public void HNNMLGIEPNK(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FD20", Offset = "0x8D3E320", VA = "0x188D3FD20", Slot = "9")]
	public void DGKAEGMMNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FE60", Offset = "0x8D3E460", VA = "0x188D3FE60")]
	private void DLHFKBANNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D400F0", Offset = "0x8D3E6F0", VA = "0x188D400F0")]
	private void JNGBEJLNOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D40270", Offset = "0x8D3E870", VA = "0x188D40270", Slot = "8")]
	public void LDMBMPCLPOF(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FF80", Offset = "0x8D3E580", VA = "0x188D3FF80", Slot = "7")]
	public void ENLGDLMNPGB(AFLINHCECMA JDPJJGMMDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MLHHAHALCPH : GNLGEBAHDOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PBCNGJENIAB IDGGBHPDOLJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool IKOEBPFPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D40BB0", Offset = "0x8D3F1B0", VA = "0x188D40BB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event GJMCCLEBNCH OOFEDCIOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D408F0", Offset = "0x8D3EEF0", VA = "0x188D408F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D40850", Offset = "0x8D3EE50", VA = "0x188D40850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8D40C60", Offset = "0x8D3F260", VA = "0x188D40C60")]
	public MLHHAHALCPH(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8D40990", Offset = "0x8D3EF90", VA = "0x188D40990", Slot = "7")]
	public void HMBCKCPHKFB(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8D40A20", Offset = "0x8D3F020", VA = "0x188D40A20", Slot = "8")]
	public void KJOEMODIGHA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8D40AA0", Offset = "0x8D3F0A0", VA = "0x188D40AA0", Slot = "9")]
	public void MPFLAILIPIP(object INEEADCBMPK, bool KLPLCNHJGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8D40A30", Offset = "0x8D3F030", VA = "0x188D40A30", Slot = "12")]
	public void LELIIIOCICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8D409A0", Offset = "0x8D3EFA0", VA = "0x188D409A0", Slot = "10")]
	public void IEOOHAANKJL(Rigidbody CCIMPGNIBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8D40A70", Offset = "0x8D3F070", VA = "0x188D40A70", Slot = "11")]
	public void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class IBNGHBNKOPO : KDINAHCFEMA, LMCCBONHFOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RRNetworkView DOJBOEGBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool LNCHDNCGKHG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView LKBABOBJFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CJKCNKHINOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F3F0", Offset = "0x8D3D9F0", VA = "0x188D3F3F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HMDJDGHDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event GJMCCLEBNCH FFFKAKAOPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F1B0", Offset = "0x8D3D7B0", VA = "0x188D3F1B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F350", Offset = "0x8D3D950", VA = "0x188D3F350", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F980", Offset = "0x8D3DF80", VA = "0x188D3F980")]
	public IBNGHBNKOPO(AFLINHCECMA JDPJJGMMDGH, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F400", Offset = "0x8D3DA00", VA = "0x188D3F400", Slot = "9")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F250", Offset = "0x8D3D850", VA = "0x188D3F250", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F6A0", Offset = "0x8D3DCA0", VA = "0x188D3F6A0", Slot = "10")]
	public void HGMIEHNLLDN(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F530", Offset = "0x8D3DB30", VA = "0x188D3F530", Slot = "11")]
	public void GNPGFMJKNMK(AFLINHCECMA BEBONNCPGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F810", Offset = "0x8D3DE10", VA = "0x188D3F810")]
	private void KMJMMCAEHBB(RRNetworkView MHMLNIAGNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F060", Offset = "0x8D3D660", VA = "0x188D3F060")]
	private void AMBOODJKDEJ(OCHLPLCDEOP KMHEHPLENNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3EDF0", Offset = "0x8D3D3F0", VA = "0x188D3EDF0")]
	private void AJFPGBPIHOM(RRNetworkView KMBMNBFEKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PJECFLHHEAC
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8D43CE0", Offset = "0x8D422E0", VA = "0x188D43CE0")]
	public static KDINAHCFEMA OCPONBAECJP(this AFLINHCECMA MFNKIFOCMAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FEEFJIIKNLB : NHHBKDJMHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private RigidbodyConstraints NMHLAJBHIIC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool DCJNAJFFGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB76A30", Offset = "0xB75030", VA = "0x180B76A30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xEC44B0", Offset = "0xEC2AB0", VA = "0x180EC44B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FONLEKHJPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xEC39E0", Offset = "0xEC1FE0", VA = "0x180EC39E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints LDAPKPBEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D35730", Offset = "0x8D33D30", VA = "0x188D35730", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8D35860", Offset = "0x8D33E60", VA = "0x188D35860")]
	public FEEFJIIKNLB(AFLINHCECMA JDPJJGMMDGH, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8D356D0", Offset = "0x8D33CD0", VA = "0x188D356D0", Slot = "9")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8D35700", Offset = "0x8D33D00", VA = "0x188D35700", Slot = "10")]
	public void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GCENOCBKPMN : EEDAHLHGLOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AFLINHCECMA JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float DOJNFLMGJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float MNJJHIIOEMF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float JGDNBFMPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB02260", Offset = "0xB00860", VA = "0x180B02260", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C190", Offset = "0x8D3A790", VA = "0x188D3C190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float GFDHAKAPLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xB02540", Offset = "0xB00B40", VA = "0x180B02540", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C260", Offset = "0x8D3A860", VA = "0x188D3C260", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C420", Offset = "0x8D3AA20", VA = "0x188D3C420")]
	public GCENOCBKPMN(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C330", Offset = "0x8D3A930", VA = "0x188D3C330", Slot = "8")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C380", Offset = "0x8D3A980", VA = "0x188D3C380", Slot = "9")]
	public void MDAOLJNAJFG(Rigidbody MLPKEKPNOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ELCAPOMDDFE : CKOJGNCNGLP
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly IPHNFELODMJ NCHPKKNAJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private bool PIBMMDEKOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool GOJIOLFBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int CABAPDGFOOE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D34E40", Offset = "0x8D33440", VA = "0x188D34E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool FIMKCJLMKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D34E20", Offset = "0x8D33420", VA = "0x188D34E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private AFLINHCECMA IFNCNLOFOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D35540", Offset = "0x8D33B40", VA = "0x188D35540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool JGJIPHIDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D34C20", Offset = "0x8D33220", VA = "0x188D34C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GJMCCLEBNCH GOBHAOBFLON
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D35150", Offset = "0x8D33750", VA = "0x188D35150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D34E90", Offset = "0x8D33490", VA = "0x188D34E90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8D35640", Offset = "0x8D33C40", VA = "0x188D35640")]
	public ELCAPOMDDFE(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8D34F30", Offset = "0x8D33530", VA = "0x188D34F30", Slot = "6")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8D355A0", Offset = "0x8D33BA0", VA = "0x188D355A0", Slot = "8")]
	public void PKGBMBHNLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8D351F0", Offset = "0x8D337F0", VA = "0x188D351F0", Slot = "7")]
	public bool IODAFJKJAHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8D35340", Offset = "0x8D33940", VA = "0x188D35340", Slot = "9")]
	public void IPODJONCDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8D353E0", Offset = "0x8D339E0", VA = "0x188D353E0", Slot = "13")]
	public void MEDHHOOPBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8D34C80", Offset = "0x8D33280", VA = "0x188D34C80", Slot = "12")]
	public void BCAAPHLKHLL(bool HIOLHHOABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8D34DB0", Offset = "0x8D333B0", VA = "0x188D34DB0", Slot = "10")]
	public bool CBEBAOPAHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8D35480", Offset = "0x8D33A80", VA = "0x188D35480", Slot = "11")]
	public bool OCKPLEAEBCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8D34A50", Offset = "0x8D33050", VA = "0x188D34A50")]
	private bool ACJBFJIAKIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8D34FC0", Offset = "0x8D335C0", VA = "0x188D34FC0")]
	private void GNOLKKBCHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class PGBLGAEJHAF : FIPKFJJEKKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PBCNGJENIAB DKJMIBCMJPH;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody MNPLGLEODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool JGJIPHIDAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8D426C0", Offset = "0x8D40CC0", VA = "0x188D426C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DCOIPPIJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1B32130", Offset = "0x1B30730", VA = "0x181B32130", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8D43BD0", Offset = "0x8D421D0", VA = "0x188D43BD0")]
	public PGBLGAEJHAF(AFLINHCECMA JDPJJGMMDGH, [In] BMAKNOKMAHD CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8D43650", Offset = "0x8D41C50", VA = "0x188D43650", Slot = "5")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8D43620", Offset = "0x8D41C20", VA = "0x188D43620", Slot = "7")]
	public void DFONOONJCJH(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8D436F0", Offset = "0x8D41CF0", VA = "0x188D436F0", Slot = "8")]
	public void HCNECMLDKIA(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8D43720", Offset = "0x8D41D20", VA = "0x188D43720", Slot = "9")]
	public void KHPCCBLIIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8D43430", Offset = "0x8D41A30", VA = "0x188D43430", Slot = "10")]
	public void AFDEOOAGJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8D43A50", Offset = "0x8D42050", VA = "0x188D43A50", Slot = "11")]
	public void LJCAPCMMHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class DMNMBJKCLEN : JEJAOFLHAHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FONBAMECPJK JDPJJGMMDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PBCNGJENIAB AEKAFIGKPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private float KJOOMDLGCPL;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LDOJJNLFMJG IDJEEBDMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KNMODGMCAEJ PHHGNNEFNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 JCHIBDNJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8D31640", Offset = "0x8D2FC40", VA = "0x188D31640", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D33390", Offset = "0x8D31990", VA = "0x188D33390", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 KMMLNNKOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8D32630", Offset = "0x8D30C30", VA = "0x188D32630", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8D309F0", Offset = "0x8D2EFF0", VA = "0x188D309F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 LFKDPNAGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8D30BF0", Offset = "0x8D2F1F0", VA = "0x188D30BF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D30A20", Offset = "0x8D2F020", VA = "0x188D30A20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 MJABHHPDODG
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D31520", Offset = "0x8D2FB20", VA = "0x188D31520", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8D32BE0", Offset = "0x8D311E0", VA = "0x188D32BE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MEHMIOIICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xB02270", Offset = "0xB00870", VA = "0x180B02270", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8D31DF0", Offset = "0x8D303F0", VA = "0x188D31DF0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GOFMMIKMJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x258F240", Offset = "0x258D840", VA = "0x18258F240", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PPFBLMBBEHG BDHPJFLFPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8247AB0", Offset = "0x82460B0", VA = "0x188247AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool FIMKCJLMKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8D30D50", Offset = "0x8D2F350", VA = "0x188D30D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8D33D70", Offset = "0x8D32370", VA = "0x188D33D70")]
	public DMNMBJKCLEN(AFLINHCECMA JDPJJGMMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8D30AE0", Offset = "0x8D2F0E0", VA = "0x188D30AE0", Slot = "19")]
	public void GIEDMCCENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8D314C0", Offset = "0x8D2FAC0", VA = "0x188D314C0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8D32990", Offset = "0x8D30F90", VA = "0x188D32990", Slot = "28")]
	public void IEOOHAANKJL(Rigidbody MLPKEKPNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x18E6580", Offset = "0x18E4B80", VA = "0x1818E6580", Slot = "20")]
	public void FACPGEKHDGG(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x18E8CB0", Offset = "0x18E72B0", VA = "0x1818E8CB0", Slot = "30")]
	public void MGAHEPHLPMM(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8D32C10", Offset = "0x8D31210", VA = "0x188D32C10", Slot = "35")]
	public Vector3 KHBKHPNFBEC(Vector3 INOKLOLKDMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8D31300", Offset = "0x8D2F900", VA = "0x188D31300", Slot = "34")]
	public Vector3 DMDGMFGGIAE(Vector3 BDPHNFIHANA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8D30AE0", Offset = "0x8D2F0E0", VA = "0x188D30AE0", Slot = "27")]
	public void CJOABAEICMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8D30B90", Offset = "0x8D2F190", VA = "0x188D30B90", Slot = "25")]
	public void COGKDECNKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8D32DF0", Offset = "0x8D313F0", VA = "0x188D32DF0", Slot = "24")]
	public void LEOEAJLLKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8D32750", Offset = "0x8D30D50", VA = "0x188D32750", Slot = "33")]
	public void HHGODEJMCCE(Vector3 JDNMLAKNLHJ, Vector3 OPOBMLOHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8D307F0", Offset = "0x8D2EDF0", VA = "0x188D307F0", Slot = "32")]
	public void AINIGLNJFBJ(Vector3 KKAOBCBGFIM, Vector3 DDMPBEFKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8D30850", Offset = "0x8D2EE50", VA = "0x188D30850", Slot = "31")]
	public void AKCHLEGEPLL(Vector3 AADGBMGBAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8D31790", Offset = "0x8D2FD90", VA = "0x188D31790", Slot = "22")]
	public void FDLKOHMMCIM(JKCJIHCAFND CJJGBDBIKNK, Vector3 JGCOGMBGAIE, float JCMCABMDPDI, float JNJGMIJAPBG = 8f, float FGEMNCHJAOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8D33450", Offset = "0x8D31A50", VA = "0x188D33450", Slot = "21")]
	public void MPLEJJCMNFI(AGKPFFONCGI BOIEPIHDFOA, Vector3 DEFJCKCMJLK, float LPGBJACEOGH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8D30F10", Offset = "0x8D2F510", VA = "0x188D30F10", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DKOOOOCKALH(AGKPFFONCGI BOIEPIHDFOA, Vector3 LDAEEKEKDJC, float FGNDKKHAFBJ = 7f, float JDPKNMPDEGH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1A43760", Offset = "0x1A41D60", VA = "0x181A43760")]
	private static void JNCPPMBFHLA(Vector3 EJLBFNGBOJC, Vector3 EPCDDFCHPMD, [Out] Vector3 FLCEDBCKDJK, [Out] Vector3 EKOGFCFLLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8D33C90", Offset = "0x8D32290", VA = "0x188D33C90", Slot = "29")]
	public Vector3 OHDPDACBGEN(Vector3 EJLBFNGBOJC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8D324A0", Offset = "0x8D30AA0", VA = "0x188D324A0", Slot = "26")]
	public void GAOBPBHIPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8D31DF0", Offset = "0x8D303F0", VA = "0x188D31DF0")]
	private void FJNAHCCGCMA(float KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8D30D70", Offset = "0x8D2F370", VA = "0x188D30D70")]
	private void DEJHGMDMLPG(Vector3 DEFJCKCMJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8D33B70", Offset = "0x8D32170", VA = "0x188D33B70")]
	private Vector3 NOJFJOHJFLJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8D336E0", Offset = "0x8D31CE0", VA = "0x188D336E0")]
	private void NOHOOILFJIA(Vector3 BDPHNFIHANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8D32AC0", Offset = "0x8D310C0", VA = "0x188D32AC0")]
	private Vector3 IOMIGILDBJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8D32E50", Offset = "0x8D31450", VA = "0x188D32E50")]
	private void MBEPDPFNHOB(Vector3 KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8D31F00", Offset = "0x8D30500", VA = "0x188D31F00")]
	private void FPJIFKNGIAH(Vector3 BDPHNFIHANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8D332E0", Offset = "0x8D318E0", VA = "0x188D332E0")]
	private void MHHGFFDAPIO()
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
