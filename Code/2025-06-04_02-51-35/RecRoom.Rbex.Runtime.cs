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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87800D0", Offset = "0x877E8D0", VA = "0x1887800D0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8157C30", Offset = "0x8156430", VA = "0x188157C30", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87874C0", Offset = "0x8785CC0", VA = "0x1887874C0")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87877C0", Offset = "0x8785FC0", VA = "0x1887877C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8787820", Offset = "0x8786020", VA = "0x188787820")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, LHDELCHFOJE, GKEGMHGFIBN, PJJHFEPBJLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly BMELPJIFPCL DELDOLFIEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KICCELHDOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BNECIELGDHO MGAIHGMAGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[GFEALGLPKIM(CGAFHOMJNOP.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GFEALGLPKIM(CGAFHOMJNOP.SelfAndParent, true, false, false)]
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
		private CAKMKKHPGOG physicsInterpolation;

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
		private Transform KIDGNKPGBKA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal BNECIELGDHO IPLLMCHLCPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8783210", Offset = "0x8781A10", VA = "0x188783210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BNECIELGDHO IHDEONGGEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NBPKJKBPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x87849D0", Offset = "0x87831D0", VA = "0x1887849D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GGOFOMPEJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8784D30", Offset = "0x8783530", VA = "0x188784D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LCHPFLHNGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8784C70", Offset = "0x8783470", VA = "0x188784C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MJNLMOPPION
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8785930", Offset = "0x8784130", VA = "0x188785930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8786E30", Offset = "0x8785630", VA = "0x188786E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NPBENHPKCNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x83BFDD0", Offset = "0x83BE5D0", VA = "0x1883BFDD0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x83BED00", Offset = "0x83BD500", VA = "0x1883BED00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KCODNJGBFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2328860", Offset = "0x2327060", VA = "0x182328860", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform PINPEOGHKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2328860", Offset = "0x2327060", VA = "0x182328860", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform ECALKHMOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2328860", Offset = "0x2327060", VA = "0x182328860", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LHKNHJGBEJF BOBAFFPNPGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8784A30", Offset = "0x8783230", VA = "0x188784A30")]
			get
			{
				return default(LHKNHJGBEJF);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x87865E0", Offset = "0x8784DE0", VA = "0x1887865E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CKMFIGLLOKN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8785040", Offset = "0x8783840", VA = "0x188785040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CFKGHHENCNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8784B50", Offset = "0x8783350", VA = "0x188784B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KBEKBNCLGHN FNOJKPPCACE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8784F80", Offset = "0x8783780", VA = "0x188784F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x87867A0", Offset = "0x8784FA0", VA = "0x1887867A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EEDPJNEGGND ILKLIPOPHHP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8784F20", Offset = "0x8783720", VA = "0x188784F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8786730", Offset = "0x8784F30", VA = "0x188786730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MGCPGJHDFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8784E70", Offset = "0x8783670", VA = "0x188784E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody POPJLLBILII
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8784ED0", Offset = "0x87836D0", VA = "0x188784ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LENKKJOJBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8784BB0", Offset = "0x87833B0", VA = "0x188784BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8786650", Offset = "0x8784E50", VA = "0x188786650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LHPEIHEDLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x17A33F0", Offset = "0x17A1BF0", VA = "0x1817A33F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float AEBEBDHOJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x87858D0", Offset = "0x87840D0", VA = "0x1887858D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BBKPNBIPFIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8785870", Offset = "0x8784070", VA = "0x188785870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8786DC0", Offset = "0x87855C0", VA = "0x188786DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HEODOPIDKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x87852A0", Offset = "0x8783AA0", VA = "0x1887852A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8786A40", Offset = "0x8785240", VA = "0x188786A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float HOMLIBAIFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x87850A0", Offset = "0x87838A0", VA = "0x1887850A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8786810", Offset = "0x8785010", VA = "0x188786810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool PKGHLLLGFDM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8785E80", Offset = "0x8784680", VA = "0x188785E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8787370", Offset = "0x8785B70", VA = "0x188787370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 FGFLPKJDAON
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8785650", Offset = "0x8783E50", VA = "0x188785650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8786B90", Offset = "0x8785390", VA = "0x188786B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 OFKLEIBLHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8785FC0", Offset = "0x87847C0", VA = "0x188785FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode JOHOGLNAJLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x87851E0", Offset = "0x87839E0", VA = "0x1887851E0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8786960", Offset = "0x8785160", VA = "0x188786960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FJJCCFGDGID
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8784C10", Offset = "0x8783410", VA = "0x188784C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x87866C0", Offset = "0x8784EC0", VA = "0x1887866C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints HGDOLNEPPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8785240", Offset = "0x8783A40", VA = "0x188785240")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87869D0", Offset = "0x87851D0", VA = "0x1887869D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GDNIJIILMFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x87859F0", Offset = "0x87841F0", VA = "0x1887859F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 AEIIIEBLJIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x87859F0", Offset = "0x87841F0", VA = "0x1887859F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8787150", Offset = "0x8785950", VA = "0x188787150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GGCNJHLPPIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8785730", Offset = "0x8783F30", VA = "0x188785730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8786C70", Offset = "0x8785470", VA = "0x188786C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OCHMLPOABHI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8785E20", Offset = "0x8784620", VA = "0x188785E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8787300", Offset = "0x8785B00", VA = "0x188787300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LOOAPLKMKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8785AD0", Offset = "0x87842D0", VA = "0x188785AD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8786ED0", Offset = "0x87856D0", VA = "0x188786ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MLOJGNMFDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8785D50", Offset = "0x8784550", VA = "0x188785D50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8787230", Offset = "0x8785A30", VA = "0x188787230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BAIAILBCLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8785BA0", Offset = "0x87843A0", VA = "0x188785BA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8786FA0", Offset = "0x87857A0", VA = "0x188786FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion PIMJKOEDGBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8785C80", Offset = "0x8784480", VA = "0x188785C80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8787080", Offset = "0x8785880", VA = "0x188787080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 KFKKLCCOCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8785EE0", Offset = "0x87846E0", VA = "0x188785EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87873E0", Offset = "0x8785BE0", VA = "0x1887873E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FJMKECGDEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8785790", Offset = "0x8783F90", VA = "0x188785790")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8786CE0", Offset = "0x87854E0", VA = "0x188786CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 CGCEKAJGJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8785100", Offset = "0x8783900", VA = "0x188785100")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8786880", Offset = "0x8785080", VA = "0x188786880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FGJALIKHFNI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8785570", Offset = "0x8783D70", VA = "0x188785570")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8786AB0", Offset = "0x87852B0", VA = "0x188786AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DFHJECEIBFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8785430", Offset = "0x8783C30", VA = "0x188785430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MHOHCLIPGIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8785360", Offset = "0x8783B60", VA = "0x188785360")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BMCNNBKPHPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8786180", Offset = "0x8784980", VA = "0x188786180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 NLELCFPIGBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x87860A0", Offset = "0x87848A0", VA = "0x1887860A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DKDNJLFGJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8785510", Offset = "0x8783D10", VA = "0x188785510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BKLEDBPBJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8784FE0", Offset = "0x87837E0", VA = "0x188784FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AGMJNELEPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8784AF0", Offset = "0x87832F0", VA = "0x188784AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PDNJONMGPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8784A90", Offset = "0x8783290", VA = "0x188784A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PHCNJGABGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8784970", Offset = "0x8783170", VA = "0x188784970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool LDJAAFJBBEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8785300", Offset = "0x8783B00", VA = "0x188785300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HFNFNBOGCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x24AD020", Offset = "0x24AB820", VA = "0x1824AD020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DFMABCKBGFJ PMBOEBLOIKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8784890", Offset = "0x8783090", VA = "0x188784890")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8786500", Offset = "0x8784D00", VA = "0x188786500")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ABCFNANMJEH DLGCBHGBIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8784600", Offset = "0x8782E00", VA = "0x188784600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8786260", Offset = "0x8784A60", VA = "0x188786260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ABCFNANMJEH AMPKBFPIGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8784660", Offset = "0x8782E60", VA = "0x188784660")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87862D0", Offset = "0x8784AD0", VA = "0x1887862D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ABCFNANMJEH HLNBJJEAFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87847B0", Offset = "0x8782FB0", VA = "0x1887847B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8786420", Offset = "0x8784C20", VA = "0x188786420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KEIJGPDJMGG, KEIJGPDJMGG> GFFKNFIOBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8784740", Offset = "0x8782F40", VA = "0x188784740")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x87863B0", Offset = "0x8784BB0", VA = "0x1887863B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ABCFNANMJEH KGEAHODFIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8784820", Offset = "0x8783020", VA = "0x188784820")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8786490", Offset = "0x8784C90", VA = "0x188786490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ABCFNANMJEH IALJJENLBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8784900", Offset = "0x8783100", VA = "0x188784900")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8786570", Offset = "0x8784D70", VA = "0x188786570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ABCFNANMJEH LJLJHKPHCPE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x87846D0", Offset = "0x8782ED0", VA = "0x1887846D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8786340", Offset = "0x8784B40", VA = "0x188786340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970", Slot = "8")]
		private void EHOGCGBOMAM(BNECIELGDHO DIIOBAFKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8783000", Offset = "0x8781800", VA = "0x188783000", Slot = "9")]
		public FEENKBGNJLG GetData()
		{
			return default(FEENKBGNJLG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8782C60", Offset = "0x8781460", VA = "0x188782C60")]
		internal void DNCJNKMAFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8784330", Offset = "0x8782B30", VA = "0x188784330")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody FAFFCENHANK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8782D50", Offset = "0x8781550", VA = "0x188782D50")]
		public LHDELCHFOJE GetChild(int PNJCJGEIDHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8783F90", Offset = "0x8782790", VA = "0x188783F90")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MCEDHANOLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8782920", Offset = "0x8781120", VA = "0x188782920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8784220", Offset = "0x8782A20", VA = "0x188784220")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8783210", Offset = "0x8781A10", VA = "0x188783210")]
		private BNECIELGDHO IBHDOHMEMMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8783090", Offset = "0x8781890", VA = "0x188783090")]
		private void HNPKBJNJFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8783760", Offset = "0x8781F60", VA = "0x188783760")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x87836A0", Offset = "0x8781EA0", VA = "0x1887836A0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8782C60", Offset = "0x8781460", VA = "0x188782C60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8783700", Offset = "0x8781F00", VA = "0x188783700")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87837C0", Offset = "0x8781FC0", VA = "0x1887837C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8781F10", Offset = "0x8780710", VA = "0x188781F10")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8783820", Offset = "0x8782020", VA = "0x188783820")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8782CF0", Offset = "0x87814F0", VA = "0x188782CF0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8783640", Offset = "0x8781E40", VA = "0x188783640")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87840F0", Offset = "0x87828F0", VA = "0x1887840F0")]
		public void SetParent(RigidbodyEx MGONBEDEDON, bool FMFJOLALOHP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8783B30", Offset = "0x8782330", VA = "0x188783B30")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87832C0", Offset = "0x8781AC0", VA = "0x1887832C0")]
		public bool IsRigidbodyAncestor(RigidbodyEx FBAMKCIKNNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x87833C0", Offset = "0x8781BC0", VA = "0x1887833C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx OFOONBJBJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8782180", Offset = "0x8780980", VA = "0x188782180")]
		public void AddInterpolationRestriction(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8783890", Offset = "0x8782090", VA = "0x188783890")]
		public void RemoveInterpolationRestriction(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x87821F0", Offset = "0x87809F0", VA = "0x1887821F0")]
		public void AddKinematic(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8783900", Offset = "0x8782100", VA = "0x188783900")]
		public void RemoveKinematic(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8784070", Offset = "0x8782870", VA = "0x188784070")]
		public void SetKinematic(object KAJENDFCCBJ, bool MANNIEELCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8783E90", Offset = "0x8782690", VA = "0x188783E90")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OJLODNLPIPG, Quaternion CCMCEGFNOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8783D90", Offset = "0x8782590", VA = "0x188783D90")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JGIAKOLAGIC, Quaternion NJIJACEFFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8782EF0", Offset = "0x87816F0", VA = "0x188782EF0")]
		public Vector3 GetConstrainedVelocity(Vector3 KFKKLCCOCPA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8782DE0", Offset = "0x87815E0", VA = "0x188782DE0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 CGCEKAJGJHA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8782090", Offset = "0x8780890", VA = "0x188782090")]
		public void AddForce(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8781F80", Offset = "0x8780780", VA = "0x188781F80")]
		public void AddForceAtPosition(Vector3 IBCIAMDAPFE, Vector3 KKEEFCOJJFM, ForceMode BHFCPGJKENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87823C0", Offset = "0x8780BC0", VA = "0x1887823C0")]
		public void AddTorque(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8782260", Offset = "0x8780A60", VA = "0x188782260")]
		public void AddRelativeTorque(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8784400", Offset = "0x8782C00", VA = "0x188784400")]
		public Vector3 WorldToLocalVelocity(Vector3 EJOPPMIDHIG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8783530", Offset = "0x8781D30", VA = "0x188783530")]
		public Vector3 LocalToWorldVelocity(Vector3 FJMKECGDEHL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8782C00", Offset = "0x8781400", VA = "0x188782C00")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8782BA0", Offset = "0x87813A0", VA = "0x188782BA0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8782B40", Offset = "0x8781340", VA = "0x188782B40")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8782AE0", Offset = "0x87812E0", VA = "0x188782AE0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8783C90", Offset = "0x8782490", VA = "0x188783C90")]
		public void ResetVelocityWorldSpace(Vector3 LICAIPLHADH, Vector3 IEEFOOJGDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8783B90", Offset = "0x8782390", VA = "0x188783B90")]
		public void ResetVelocityLocalSpace(Vector3 DMGPMFJCFAD, Vector3 FGJALIKHFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8783A50", Offset = "0x8782250", VA = "0x188783A50")]
		public void ResetLinearVelocityLocalSpace(Vector3 DMGPMFJCFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8784230", Offset = "0x8782A30", VA = "0x188784230")]
		public bool SweepTest(Vector3 LONBCENHPHO, [Out] RaycastHit CLGLGLNJAHH, float IOEOMGELKJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x87834C0", Offset = "0x8781CC0", VA = "0x1887834C0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x87841C0", Offset = "0x87829C0", VA = "0x1887841C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x87843A0", Offset = "0x8782BA0", VA = "0x1887843A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8782350", Offset = "0x8780B50", VA = "0x188782350")]
		public void AddShouldHaveUnityRigidbodyToken(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8783970", Offset = "0x8782170", VA = "0x188783970")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8782750", Offset = "0x8780F50", VA = "0x188782750")]
		public void ApplyForceVelocityChange(AILNCLJHELL IAIOELIFIPI, Vector3 MKHKJGAKHCA, float NOAIONKJIBJ, float EKAEALFGBGP = 8f, float PPFLELGLCLE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8782650", Offset = "0x8780E50", VA = "0x188782650")]
		public void ApplyAngularVelocityChange(HGKMNDKCDJL GGIOLKEGMJK, Vector3 DIFGALLBNBL, float OIKLFIKCAKB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8782810", Offset = "0x8781010", VA = "0x188782810")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HGKMNDKCDJL GGIOLKEGMJK, Vector3 FENAGHBAFHI, float LDHDGMKHGLA = 7f, float ADJPAMDCLMJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8782580", Offset = "0x8780D80", VA = "0x188782580")]
		public bool AllowedScaleChange(float KEPHKFOICBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87824B0", Offset = "0x8780CB0", VA = "0x1887824B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HKGJBJLGAIL, object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x87839E0", Offset = "0x87821E0", VA = "0x1887839E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8783520", Offset = "0x8781D20", VA = "0x188783520", Slot = "13")]
		private void JDAHGMHDEFF(HDJJIILNIDG MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8784590", Offset = "0x8782D90", VA = "0x188784590")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA0A90", Offset = "0xA9F290", VA = "0x180AA0A90", Slot = "4")]
		private GameObject HGEMIHOADNL()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC0", Offset = "0xA542C0", VA = "0x180A55AC0", Slot = "10")]
		private bool LNOMDLNGNMA()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BCFODOAMKEN
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x876AFE0", Offset = "0x87697E0", VA = "0x18876AFE0")]
	public static BNECIELGDHO IPLLMCHLCPB(this RigidbodyEx ACGABOLDOKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LFMOBCIOCKI), new string[] { })]
public class NGOKLCIFAKB : LFMOBCIOCKI, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IEKLBHCPFKA PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DGFONGCELHO ILMICIECHIG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEKLBHCPFKA COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DGFONGCELHO OJMHNPBCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8780680", Offset = "0x877EE80", VA = "0x188780680", Slot = "7")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x87804B0", Offset = "0x877ECB0", VA = "0x1887804B0", Slot = "6")]
	public BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NGOKLCIFAKB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static KECNPIDOCPH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MPANFBCAFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int HELEBODAPMG;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8781D90", Offset = "0x8780590", VA = "0x188781D90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8781DD0", Offset = "0x87805D0", VA = "0x188781DD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8781DB0", Offset = "0x87805B0", VA = "0x188781DB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ILBALOOKKCP, [Optional] UnityEngine.Object MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ILBALOOKKCP, [Optional] UnityEngine.Object MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8781EC0", Offset = "0x87806C0", VA = "0x188781EC0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CIFDCMOBHBD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IAOLFMFHILE : KBEKBNCLGHN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA38840", Offset = "0xA37040", VA = "0x180A38840", Slot = "4")]
		public Vector3 BEELMBEPLJJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA38840", Offset = "0xA37040", VA = "0x180A38840", Slot = "5")]
		public Vector3 ECLENGGGJIB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "6")]
		public bool KECDCMOIKJJ(float NJGMPBOKJKF, float FOIANHBCDBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IAOLFMFHILE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static KBEKBNCLGHN DBHEFPOIOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x876C220", Offset = "0x876AA20", VA = "0x18876C220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PCNOGBPJOGL
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode AHJBBDPMKKG
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
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFPMBMNNJIE(bool DKDNJLFGJCB);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFKPPFNLNJC(bool DKDNJLFGJCB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IJOONHLEMGL(Vector3 LONBCENHPHO, [Out] RaycastHit CLGLGLNJAHH, float IOEOMGELKJC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OIHINPNFBOE : IDisposable, FFMEMGNEFKM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LHKNHJGBEJF BOBAFFPNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KEIJGPDJMGG, KEIJGPDJMGG> GFFKNFIOBDA;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPGBEHCLMLG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DGFONGCELHO
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMLNALDFNON HIBOMEIIIJH(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODMGPPDKOEO FGENDFJFKCK(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKBJEBPOCFC GKGMOFNLNNN(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EGGHPHHOHDO LHOFGGALJAL(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNMNGHLBCMM IGJCOJLEOIF(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OIHINPNFBOE GKHNBHGHMBA(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EKMKKMBMIOL AIJNAHGKHEE(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CGAIEMNKGNN AFBLGGJGCKP(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PCNOGBPJOGL KGCOGCNEHDD(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CECBOCOENOD ILNABLODPBN(BNECIELGDHO DIIOBAFKCCH);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OMPNOJCAJBN OGEPCMJELBO(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PIGNLCDEFND CJCDLNGEKOF(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BNGDOEIOEDE IBBEHPJDDCG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AMNGACEPCCE CNFDEFJCHFG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LIBIHIMBJEM KLFEIHJLNPE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP, FEENKBGNJLG IMINNNCPCJF, LFMOBCIOCKI EGOJLGMOLFK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CGAIEMNKGNN
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKNADNFGPJB(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPGMEKBHFNN(Vector3 IBCIAMDAPFE, Vector3 KKEEFCOJJFM, ForceMode BHFCPGJKENA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCGENJMAGII(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFHPBIDEFKL(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CECBOCOENOD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EEHEIGJJHBN
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
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IMLNALDFNON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<BNECIELGDHO> IBEDELCOKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BNECIELGDHO LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ABCFNANMJEH DLGCBHGBIGD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ABCFNANMJEH AMPKBFPIGMC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DFMABCKBGFJ MKGNAFDKGNB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IJEKFEDFMLA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GNPNPLNIKKL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BNECIELGDHO> FOEBIOEDHDO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BNECIELGDHO> EHBFOPGDAFN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action AOFFLKEJODG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BNECIELGDHO> NOOBONDIFJG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KBJIKDOEMIH(BNECIELGDHO OOBPPDKPNFF, bool FMFJOLALOHP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JKBJEBPOCFC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IHHGKFNOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GFGBHLMKMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHHCGGPLCNG(BNECIELGDHO MJNLMOPPION, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNJHGMFKEOM(object KAJENDFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AMNGACEPCCE
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 LEEOAJNGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 IOFFILBCPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float JENDPKCADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float MKFFGCDCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 GMKLHNOOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion IMBCPLCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event ABCFNANMJEH ECJFJDIBAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OLOEKKEFKGH((Quaternion rot, Vector3 moments) MCEDHANOLMG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGCHGOHEDMC();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void COMFHGOINGI();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OJPJFPODHEH();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ILNDMFOFEJK();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BNGDOEIOEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPELNHJMLAP(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAFAOMFGAOL(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFDHFOAKGBI(BNECIELGDHO ACGABOLDOKP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AONEKCIEFCO(BNECIELGDHO ACGABOLDOKP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPBINGDBDFN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EKMKKMBMIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JAGALNHALBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ABCFNANMJEH HIKFKADFDIM;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEPCAHFKKDG(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGOMBCGABON(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHHFHBOFPJB(object KAJENDFCCBJ, bool MANNIEELCNM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABMEAMKNONH(Rigidbody HNPNGMHGBOO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PIGNLCDEFND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CKMFIGLLOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CFKGHHENCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ABCFNANMJEH EJNDOJMAFEC;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJPOOHCDNJF(BNECIELGDHO MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GILEONICMMC(BNECIELGDHO MJNLMOPPION);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LIBIHIMBJEM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LENKKJOJBED
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DMEHFAINMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints OOOJOFPCOHC
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
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EGGHPHHOHDO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float HFKLAHKFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PNDGOKFEDJB
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
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JNMNGHLBCMM
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool KFDNDDFPNLI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ABCFNANMJEH GGGKEGBLLDN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DKICDGBHGLB();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDNAOGIDGAG();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNIJGPOBDBF();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BNJPMIDKMJF();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MEMDPJPCNDB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CPCHMKGCDFN(bool KMJDHPCOMGM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCNEDMICAHL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OMPNOJCAJBN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KDBKCMBGFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFINFFPHJDI(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGCMGOGPNMJ(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNGBKDEJFAG();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ODMGPPDKOEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KBEKBNCLGHN FNOJKPPCACE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	EEDPJNEGGND ILKLIPOPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 KGIKDNLAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 BNHFKFNPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 MPJHCFFFBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 CMEMCAJMCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float FJJCCFGDGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MGCPGJHDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPGBEHCLMLG();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ABJIJCKPLEG(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BJIGIBPLKMN(HGKMNDKCDJL GGIOLKEGMJK, Vector3 DIFGALLBNBL, float OIKLFIKCAKB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KONLEDECMEO(AILNCLJHELL IAIOELIFIPI, Vector3 MKHKJGAKHCA, float NOAIONKJIBJ, float EKAEALFGBGP = 8f, float PPFLELGLCLE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CDPCCFBHJHB(HGKMNDKCDJL GGIOLKEGMJK, Vector3 FENAGHBAFHI, float LDHDGMKHGLA = 7f, float ADJPAMDCLMJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GLJPEOPHCGP();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GCKOGNPMGDN();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FFGFFHNGODE();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EPFKJKBLHNI();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ABMEAMKNONH(Rigidbody JGLNBKCPMAM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JKPEHNKINEK(Vector3 KFKKLCCOCPA);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EEHFCIMPBIF(object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EPAEGBNKPOH(Vector3 PCHFPENLEBH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PLLMCGPENGI(Vector3 DMGPMFJCFAD, Vector3 FGJALIKHFNI);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FAFALCKHNNJ(Vector3 LICAIPLHADH, Vector3 IEEFOOJGDGH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 COMNIPFJHDC(Vector3 FJMKECGDEHL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OGCMCOEJLOF(Vector3 EJOPPMIDHIG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface IEKLBHCPFKA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool JDNMDDFMEML
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIIKNPPEIIE(string MEBFHJECJFA);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALOINCAKAGG(RigidbodyEx ACGABOLDOKP, Action AMNCPNDDCLP);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MAFINHHDDBC COCAELFKNFG(int POIEEMPDPOG);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBPIJGBCBPM(Vector3 OFKLEIBLHOK, float GHBJBLMGGEP, Color BIKIHAKPCIG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LFMOBCIOCKI
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IEKLBHCPFKA COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DGFONGCELHO OJMHNPBCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GNFLMDKHDJN : BNECIELGDHO, IDisposable, IDABENNIGNP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool JMCFJKLEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LFMOBCIOCKI EGOJLGMOLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal IMLNALDFNON DPFNGOIDMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BNGDOEIOEDE INPHNHLILAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal PIGNLCDEFND LCLDOPDEHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal ODMGPPDKOEO KFKKLCCOCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal JKBJEBPOCFC BFDGAKPABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal AMNGACEPCCE MAIEKCAMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal EGGHPHHOHDO KODILJAJBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CECBOCOENOD FCJEKJDIIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal JNMNGHLBCMM GKFHLEJCPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal OIHINPNFBOE KDNDJFKJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal EKMKKMBMIOL ACOGEGGKNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal CGAIEMNKGNN IBCIAMDAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal LIBIHIMBJEM EJEDFFOICAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal OMPNOJCAJBN JGLNBKCPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal PCNOGBPJOGL OLLBKPHGCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HBINEBGPAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool PGPLEBJJNNM;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public BMGFKKCFMCO CANELEOPJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "22")]
		get
		{
			return default(BMGFKKCFMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LHDELCHFOJE MPEDHOEMJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xEEFE60", Offset = "0xEEE660", VA = "0x180EEFE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject CBMGDPANAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7E0", Offset = "0xA29FE0", VA = "0x180A2B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xEF9690", Offset = "0xEF7E90", VA = "0x180EF9690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8778570", Offset = "0x8776D70", VA = "0x188778570", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8779EC0", Offset = "0x87786C0", VA = "0x188779EC0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8777550", Offset = "0x8775D50", VA = "0x188777550", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NBPKJKBPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8776EB0", Offset = "0x87756B0", VA = "0x188776EB0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BNECIELGDHO LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8773EF0", Offset = "0x87726F0", VA = "0x188773EF0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool NAMPEJNDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8778200", Offset = "0x8776A00", VA = "0x188778200", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CKMFIGLLOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8775650", Offset = "0x8773E50", VA = "0x188775650", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool CFKGHHENCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8779CD0", Offset = "0x87784D0", VA = "0x188779CD0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KBEKBNCLGHN FNOJKPPCACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x87796B0", Offset = "0x8777EB0", VA = "0x1887796B0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8776C30", Offset = "0x8775430", VA = "0x188776C30", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EEDPJNEGGND ILKLIPOPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x87782C0", Offset = "0x8776AC0", VA = "0x1887782C0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x87775B0", Offset = "0x8775DB0", VA = "0x1887775B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float FJJCCFGDGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8773EA0", Offset = "0x87726A0", VA = "0x188773EA0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8779600", Offset = "0x8777E00", VA = "0x188779600", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 BNHFKFNPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8777910", Offset = "0x8776110", VA = "0x188777910", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8774000", Offset = "0x8772800", VA = "0x188774000", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 CMEMCAJMCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8775170", Offset = "0x8773970", VA = "0x188775170", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8777350", Offset = "0x8775B50", VA = "0x188777350", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 KGIKDNLAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8777050", Offset = "0x8775850", VA = "0x188777050", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8779300", Offset = "0x8777B00", VA = "0x188779300", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 MPJHCFFFBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8775940", Offset = "0x8774140", VA = "0x188775940", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8774AC0", Offset = "0x87732C0", VA = "0x188774AC0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool AGMJNELEPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8776D20", Offset = "0x8775520", VA = "0x188776D20", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool PDNJONMGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8779490", Offset = "0x8777C90", VA = "0x188779490", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool PHCNJGABGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8774660", Offset = "0x8772E60", VA = "0x188774660", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MGCPGJHDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8775FB0", Offset = "0x87747B0", VA = "0x188775FB0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IHHGKFNOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8777480", Offset = "0x8775C80", VA = "0x188777480", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GFGBHLMKMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8775250", Offset = "0x8773A50", VA = "0x188775250", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 LEEOAJNGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8775800", Offset = "0x8774000", VA = "0x188775800", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8777A90", Offset = "0x8776290", VA = "0x188777A90", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 IOFFILBCPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8776AA0", Offset = "0x87752A0", VA = "0x188776AA0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float JENDPKCADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8777CF0", Offset = "0x87764F0", VA = "0x188777CF0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float MKFFGCDCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8776380", Offset = "0x8774B80", VA = "0x188776380", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8778130", Offset = "0x8776930", VA = "0x188778130", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 GMKLHNOOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8778F30", Offset = "0x8777730", VA = "0x188778F30", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion IMBCPLCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8779010", Offset = "0x8777810", VA = "0x188779010", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float HFKLAHKFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8775F60", Offset = "0x8774760", VA = "0x188775F60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8777B70", Offset = "0x8776370", VA = "0x188777B70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PNDGOKFEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8776490", Offset = "0x8774C90", VA = "0x188776490", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8776430", Offset = "0x8774C30", VA = "0x188776430", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EEHEIGJJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8775550", Offset = "0x8773D50", VA = "0x188775550", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8773F40", Offset = "0x8772740", VA = "0x188773F40", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LHKNHJGBEJF BOBAFFPNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8777430", Offset = "0x8775C30", VA = "0x188777430", Slot = "70")]
		get
		{
			return default(LHKNHJGBEJF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8775AD0", Offset = "0x87742D0", VA = "0x188775AD0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool JAGALNHALBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8775B90", Offset = "0x8774390", VA = "0x188775B90", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform ECALKHMOCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 FJAGBNIPGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8779250", Offset = "0x8777A50", VA = "0x188779250", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87790E0", Offset = "0x87778E0", VA = "0x1887790E0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float MOEIMOPHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8777A80", Offset = "0x8776280", VA = "0x188777A80", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87779F0", Offset = "0x87761F0", VA = "0x1887779F0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float FMFFGMIBDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8779A20", Offset = "0x8778220", VA = "0x188779A20", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8777610", Offset = "0x8775E10", VA = "0x188777610", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion KGOJCBJLFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8775BE0", Offset = "0x87743E0", VA = "0x188775BE0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8774E10", Offset = "0x8773610", VA = "0x188774E10", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 IDFHMANDJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8779790", Offset = "0x8777F90", VA = "0x188779790", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x877A3B0", Offset = "0x8778BB0", VA = "0x18877A3B0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion AFGCAICPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8778AD0", Offset = "0x87772D0", VA = "0x188778AD0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x87794F0", Offset = "0x8777CF0", VA = "0x1887794F0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints OOOJOFPCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8778310", Offset = "0x8776B10", VA = "0x188778310", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8777BD0", Offset = "0x87763D0", VA = "0x188777BD0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool LENKKJOJBED
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8779660", Offset = "0x8777E60", VA = "0x188779660", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87744F0", Offset = "0x8772CF0", VA = "0x1887744F0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode AHJBBDPMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8777300", Offset = "0x8775B00", VA = "0x188777300", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8776BD0", Offset = "0x87753D0", VA = "0x188776BD0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PJIKGPAKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x87764E0", Offset = "0x8774CE0", VA = "0x1887764E0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool BKLEDBPBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8774370", Offset = "0x8772B70", VA = "0x188774370", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ABCFNANMJEH DLGCBHGBIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x87795A0", Offset = "0x8777DA0", VA = "0x1887795A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8775F00", Offset = "0x8774700", VA = "0x188775F00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event ABCFNANMJEH AMPKBFPIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x87758E0", Offset = "0x87740E0", VA = "0x1887758E0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x87766D0", Offset = "0x8774ED0", VA = "0x1887766D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DFMABCKBGFJ MKGNAFDKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8778ED0", Offset = "0x87776D0", VA = "0x188778ED0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x87741C0", Offset = "0x87729C0", VA = "0x1887741C0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ABCFNANMJEH EJNDOJMAFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8778E70", Offset = "0x8777670", VA = "0x188778E70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8778430", Offset = "0x8776C30", VA = "0x188778430", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ABCFNANMJEH HLNBJJEAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x87763D0", Offset = "0x8774BD0", VA = "0x1887763D0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8777C30", Offset = "0x8776430", VA = "0x188777C30", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ABCFNANMJEH GGGKEGBLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8775A70", Offset = "0x8774270", VA = "0x188775A70", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8776730", Offset = "0x8774F30", VA = "0x188776730", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<KEIJGPDJMGG, KEIJGPDJMGG> GFFKNFIOBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x87791F0", Offset = "0x87779F0", VA = "0x1887791F0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x87756A0", Offset = "0x8773EA0", VA = "0x1887756A0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ABCFNANMJEH HIKFKADFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8776970", Offset = "0x8775170", VA = "0x188776970", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8779DD0", Offset = "0x87785D0", VA = "0x188779DD0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ABCFNANMJEH LJLJHKPHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x877A4E0", Offset = "0x8778CE0", VA = "0x18877A4E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8779D20", Offset = "0x8778520", VA = "0x188779D20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x877A5D0", Offset = "0x8778DD0", VA = "0x18877A5D0")]
	public GNFLMDKHDJN(GameObject EMOLHEPHCGI, RigidbodyEx FBFFNGMLCDF, LFMOBCIOCKI EGOJLGMOLFK, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8778680", Offset = "0x8776E80", VA = "0x188778680", Slot = "139")]
	protected virtual void LBLFOEIDNHM(LFMOBCIOCKI EGOJLGMOLFK, FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8775700", Offset = "0x8773F00", VA = "0x188775700", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8776D70", Offset = "0x8775570", VA = "0x188776D70", Slot = "93")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8779E30", Offset = "0x8778630", VA = "0x188779E30", Slot = "94")]
	public void PFGBIFMDMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8775EA0", Offset = "0x87746A0", VA = "0x188775EA0", Slot = "95")]
	public void FBMIFNPDOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8779700", Offset = "0x8777F00", VA = "0x188779700", Slot = "96")]
	public void NNOLKKHFMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8774EF0", Offset = "0x87736F0", VA = "0x188774EF0")]
	private void CPCHMKGCDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8777210", Offset = "0x8775A10", VA = "0x188777210")]
	private void HGEIKHFMIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8779190", Offset = "0x8777990", VA = "0x188779190")]
	private void MEMDPJPCNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8779520", Offset = "0x8777D20", VA = "0x188779520", Slot = "30")]
	public BNECIELGDHO MODBIOGMKLN(int PNJCJGEIDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8778190", Offset = "0x8776990", VA = "0x188778190", Slot = "98")]
	public void KBJIKDOEMIH(BNECIELGDHO MGONBEDEDON, bool FMFJOLALOHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8775B30", Offset = "0x8774330", VA = "0x188775B30", Slot = "99")]
	public void ELAMCHIGAIP(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8776670", Offset = "0x8774E70", VA = "0x188776670", Slot = "100")]
	public void GCPOGAIPMCD(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x87797D0", Offset = "0x8777FD0", VA = "0x1887797D0", Slot = "101")]
	public Vector3 OGCMCOEJLOF(Vector3 EJOPPMIDHIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8774BF0", Offset = "0x87733F0", VA = "0x188774BF0", Slot = "102")]
	public Vector3 COMNIPFJHDC(Vector3 FJMKECGDEHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8775D60", Offset = "0x8774560", VA = "0x188775D60", Slot = "103")]
	public void EPFKJKBLHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8776620", Offset = "0x8774E20", VA = "0x188776620", Slot = "104")]
	public void GCKOGNPMGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8776B80", Offset = "0x8775380", VA = "0x188776B80", Slot = "105")]
	public void GLJPEOPHCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8775DB0", Offset = "0x87745B0", VA = "0x188775DB0", Slot = "106")]
	public void FAFALCKHNNJ(Vector3 LICAIPLHADH, Vector3 IEEFOOJGDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x877A3F0", Offset = "0x8778BF0", VA = "0x18877A3F0", Slot = "107")]
	public void PLLMCGPENGI(Vector3 DMGPMFJCFAD, Vector3 FGJALIKHFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8775C80", Offset = "0x8774480", VA = "0x188775C80", Slot = "108")]
	public void EPAEGBNKPOH(Vector3 PCHFPENLEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x87785C0", Offset = "0x8776DC0", VA = "0x1887785C0", Slot = "109")]
	public void KONLEDECMEO(AILNCLJHELL IAIOELIFIPI, Vector3 MKHKJGAKHCA, float NOAIONKJIBJ, float EKAEALFGBGP = 8f, float PPFLELGLCLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8774220", Offset = "0x8772A20", VA = "0x188774220", Slot = "110")]
	public void BJIGIBPLKMN(HGKMNDKCDJL GGIOLKEGMJK, Vector3 DIFGALLBNBL, float OIKLFIKCAKB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8774550", Offset = "0x8772D50", VA = "0x188774550", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CDPCCFBHJHB(HGKMNDKCDJL GGIOLKEGMJK, Vector3 FENAGHBAFHI, float LDHDGMKHGLA = 7f, float ADJPAMDCLMJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8777D40", Offset = "0x8776540", VA = "0x188777D40", Slot = "112")]
	public Vector3 JKPEHNKINEK(Vector3 MGONBEDEDON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x87789D0", Offset = "0x87771D0", VA = "0x1887789D0", Slot = "113")]
	public Vector3 LEPJJJAHEIP(Vector3 MGONBEDEDON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8776000", Offset = "0x8774800", VA = "0x188776000", Slot = "114")]
	public void FFGFFHNGODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x87754E0", Offset = "0x8773CE0", VA = "0x1887754E0", Slot = "115")]
	public void DGICNDPJFON(BNECIELGDHO HKGJBJLGAIL, object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8777860", Offset = "0x8776060", VA = "0x188777860", Slot = "116")]
	public void ILIMMABEMNH(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8779A80", Offset = "0x8778280", VA = "0x188779A80", Slot = "63")]
	public void OLOEKKEFKGH((Quaternion rot, Vector3 moments) MCEDHANOLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8774BA0", Offset = "0x87733A0", VA = "0x188774BA0", Slot = "117")]
	public void COMFHGOINGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8777710", Offset = "0x8775F10", VA = "0x188777710", Slot = "118")]
	public void IGCHGOHEDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8779A30", Offset = "0x8778230", VA = "0x188779A30", Slot = "119")]
	public void OJPJFPODHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x87755A0", Offset = "0x8773DA0", VA = "0x1887755A0", Slot = "120")]
	public bool DKICDGBHGLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8774320", Offset = "0x8772B20", VA = "0x188774320", Slot = "97")]
	public void BNIJGPOBDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8779720", Offset = "0x8777F20", VA = "0x188779720", Slot = "121")]
	public void OCNEDMICAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8778970", Offset = "0x8777170", VA = "0x188778970", Slot = "122")]
	public void LEPCAHFKKDG(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8777C90", Offset = "0x8776490", VA = "0x188777C90", Slot = "123")]
	public void JGOMBCGABON(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8777290", Offset = "0x8775A90", VA = "0x188777290", Slot = "124")]
	public void HHHFHBOFPJB(object KAJENDFCCBJ, bool MANNIEELCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8776050", Offset = "0x8774850", VA = "0x188776050", Slot = "125")]
	public void FHCCDOBKNOB(Vector3 OJLODNLPIPG, Quaternion CCMCEGFNOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8776F20", Offset = "0x8775720", VA = "0x188776F20", Slot = "126")]
	public void HCGODMOIKEE(Vector3 JGIAKOLAGIC, Quaternion NJIJACEFFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8775A20", Offset = "0x8774220", VA = "0x188775A20", Slot = "127")]
	public bool EICFPPPAGPJ(float KEPHKFOICBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x87755F0", Offset = "0x8773DF0", VA = "0x1887755F0", Slot = "128")]
	public void DLFKPGKOFKI(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8773FA0", Offset = "0x87727A0", VA = "0x188773FA0", Slot = "129")]
	public void BAILKOABOHO(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8778260", Offset = "0x8776A60", VA = "0x188778260", Slot = "130")]
	public void KFINFFPHJDI(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8779F10", Offset = "0x8778710", VA = "0x188779F10", Slot = "131")]
	public void PGCMGOGPNMJ(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8778490", Offset = "0x8776C90", VA = "0x188778490", Slot = "132")]
	public void KKNADNFGPJB(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8778020", Offset = "0x8776820", VA = "0x188778020", Slot = "133")]
	public void JPGMEKBHFNN(Vector3 IBCIAMDAPFE, Vector3 KKEEFCOJJFM, ForceMode BHFCPGJKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x87740E0", Offset = "0x87728E0", VA = "0x1887740E0", Slot = "134")]
	public void BCGENJMAGII(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8777130", Offset = "0x8775930", VA = "0x188777130", Slot = "135")]
	public void HFHPBIDEFKL(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8777760", Offset = "0x8775F60", VA = "0x188777760", Slot = "136")]
	public bool IJOONHLEMGL(Vector3 LONBCENHPHO, [Out] RaycastHit CLGLGLNJAHH, float IOEOMGELKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x87778C0", Offset = "0x87760C0", VA = "0x1887778C0", Slot = "137")]
	public void ILNDMFOFEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x877A590", Offset = "0x8778D90", VA = "0x18877A590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8778360", Offset = "0x8776B60", VA = "0x188778360")]
	private void KIOPBPBNIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8776790", Offset = "0x8774F90", VA = "0x188776790")]
	private void GHOPDMCABJF(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8777E40", Offset = "0x8776640", VA = "0x188777E40")]
	private void JNLLOOLBOGA(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x87793E0", Offset = "0x8777BE0", VA = "0x1887793E0")]
	private void MIOMFJMMHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8774CF0", Offset = "0x87734F0", VA = "0x188774CF0")]
	private void CONGCJPMGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8775330", Offset = "0x8773B30", VA = "0x188775330")]
	private void DCIFJBLNFIJ(BNECIELGDHO OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x87769D0", Offset = "0x87751D0", VA = "0x1887769D0")]
	private void GJPOOHCDNJF(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x87768A0", Offset = "0x87750A0", VA = "0x1887768A0")]
	private void GILEONICMMC(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x87798D0", Offset = "0x87780D0", VA = "0x1887798D0")]
	private void OIGKCKHLAIP(LHDELCHFOJE MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8779F70", Offset = "0x8778770", VA = "0x188779F70", Slot = "142")]
	protected virtual void PHLDDNMCPNL(LHDELCHFOJE ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8778B10", Offset = "0x8777310", VA = "0x188778B10")]
	protected void LKLCJNCCNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8774740", Offset = "0x8772F40", VA = "0x188774740")]
	protected void CKAODFGLLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8776250", Offset = "0x8774A50", VA = "0x188776250")]
	private void FJHFGHIPKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8779B60", Offset = "0x8778360", VA = "0x188779B60")]
	private void OODJHIBKPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class CCNDICPIOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x876C160", Offset = "0x876A960", VA = "0x18876C160")]
	public static BNECIELGDHO OOKHNAHILCK(this BNECIELGDHO ACGABOLDOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x876C0C0", Offset = "0x876A8C0", VA = "0x18876C0C0")]
	public static bool NOGNHFIIPAG(this BNECIELGDHO ACGABOLDOKP, BNECIELGDHO FBAMKCIKNNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x876BFD0", Offset = "0x876A7D0", VA = "0x18876BFD0")]
	public static bool ENAPFIJGLLA(this BNECIELGDHO ACGABOLDOKP, BNECIELGDHO OFOONBJBJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x876C070", Offset = "0x876A870", VA = "0x18876C070")]
	public static LHDELCHFOJE IEDCGPNAMOB(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x876BF60", Offset = "0x876A760", VA = "0x18876BF60")]
	public static GNFLMDKHDJN AIFAPOFMKPH(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OMMOFHDPECG : DGFONGCELHO
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8781440", Offset = "0x877FC40", VA = "0x188781440", Slot = "19")]
	public BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP, FEENKBGNJLG IMINNNCPCJF, LFMOBCIOCKI EGOJLGMOLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "4")]
	public IMLNALDFNON HIBOMEIIIJH(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "5")]
	public ODMGPPDKOEO FGENDFJFKCK(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "6")]
	public JKBJEBPOCFC GKGMOFNLNNN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "7")]
	public EGGHPHHOHDO LHOFGGALJAL(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "8")]
	public JNMNGHLBCMM IGJCOJLEOIF(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "9")]
	public OIHINPNFBOE GKHNBHGHMBA(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "10")]
	public EKMKKMBMIOL AIJNAHGKHEE(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "11")]
	public CGAIEMNKGNN AFBLGGJGCKP(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "12")]
	public PCNOGBPJOGL KGCOGCNEHDD(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "13")]
	public CECBOCOENOD ILNABLODPBN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public OMPNOJCAJBN OGEPCMJELBO(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public PIGNLCDEFND CJCDLNGEKOF(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public BNGDOEIOEDE IBBEHPJDDCG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public AMNGACEPCCE CNFDEFJCHFG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	public LIBIHIMBJEM KLFEIHJLNPE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OMMOFHDPECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "14")]
	private OMPNOJCAJBN OMCPEGBNIDJ(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "15")]
	private PIGNLCDEFND JGPDKMNBJAC(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "16")]
	private BNGDOEIOEDE IPPOCIOMHMD(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "17")]
	private AMNGACEPCCE EINFOINOHJH(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "18")]
	private LIBIHIMBJEM HCOOINKEODE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(DGFONGCELHO), new string[] { })]
public class JFBMDIFBKLA : DGFONGCELHO, FHLMMIDFMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DGFONGCELHO OGGDDEOBNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DGFONGCELHO GDJKBGMMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IEFIELEPDPK BGBJBPNHGOP;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private DGFONGCELHO OJMHNPBCBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x877C750", Offset = "0x877AF50", VA = "0x18877C750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x877C660", Offset = "0x877AE60", VA = "0x18877C660", Slot = "20")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x877C3D0", Offset = "0x877ABD0", VA = "0x18877C3D0", Slot = "4")]
	public IMLNALDFNON HIBOMEIIIJH(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x877C140", Offset = "0x877A940", VA = "0x18877C140", Slot = "5")]
	public ODMGPPDKOEO FGENDFJFKCK(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x877C1E0", Offset = "0x877A9E0", VA = "0x18877C1E0", Slot = "6")]
	public JKBJEBPOCFC GKGMOFNLNNN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x877C7B0", Offset = "0x877AFB0", VA = "0x18877C7B0", Slot = "7")]
	public EGGHPHHOHDO LHOFGGALJAL(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x877C520", Offset = "0x877AD20", VA = "0x18877C520", Slot = "8")]
	public JNMNGHLBCMM IGJCOJLEOIF(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x877C280", Offset = "0x877AA80", VA = "0x18877C280", Slot = "9")]
	public OIHINPNFBOE GKHNBHGHMBA(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x877BDF0", Offset = "0x877A5F0", VA = "0x18877BDF0", Slot = "10")]
	public EKMKKMBMIOL AIJNAHGKHEE(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x877BD50", Offset = "0x877A550", VA = "0x18877BD50", Slot = "11")]
	public CGAIEMNKGNN AFBLGGJGCKP(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x877C6B0", Offset = "0x877AEB0", VA = "0x18877C6B0", Slot = "12")]
	public PCNOGBPJOGL KGCOGCNEHDD(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x877C5C0", Offset = "0x877ADC0", VA = "0x18877C5C0", Slot = "13")]
	public CECBOCOENOD ILNABLODPBN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x877C850", Offset = "0x877B050", VA = "0x18877C850")]
	public OMPNOJCAJBN OGEPCMJELBO(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x877BE90", Offset = "0x877A690", VA = "0x18877BE90")]
	public PIGNLCDEFND CJCDLNGEKOF(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x877C470", Offset = "0x877AC70", VA = "0x18877C470")]
	public BNGDOEIOEDE IBBEHPJDDCG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x877BF40", Offset = "0x877A740", VA = "0x18877BF40")]
	public AMNGACEPCCE CNFDEFJCHFG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x877C320", Offset = "0x877AB20", VA = "0x18877C320")]
	public LIBIHIMBJEM KLFEIHJLNPE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x877BFF0", Offset = "0x877A7F0", VA = "0x18877BFF0", Slot = "19")]
	public BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP, FEENKBGNJLG IMINNNCPCJF, LFMOBCIOCKI EGOJLGMOLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x877C900", Offset = "0x877B100", VA = "0x18877C900")]
	public JFBMDIFBKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x877C850", Offset = "0x877B050", VA = "0x18877C850", Slot = "14")]
	private OMPNOJCAJBN OMCPEGBNIDJ(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x877BE90", Offset = "0x877A690", VA = "0x18877BE90", Slot = "15")]
	private PIGNLCDEFND JGPDKMNBJAC(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x877C470", Offset = "0x877AC70", VA = "0x18877C470", Slot = "16")]
	private BNGDOEIOEDE IPPOCIOMHMD(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x877BF40", Offset = "0x877A740", VA = "0x18877BF40", Slot = "17")]
	private AMNGACEPCCE EINFOINOHJH(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x877C320", Offset = "0x877AB20", VA = "0x18877C320", Slot = "18")]
	private LIBIHIMBJEM HCOOINKEODE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HDECGGKCMHB : IMLNALDFNON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFNMONPOGNP(BNECIELGDHO ACGABOLDOKP);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLIKHCJLJOA(BNECIELGDHO ACGABOLDOKP);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNDBIJDMBMI(BNECIELGDHO OCDACCBEEAO);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGDDFEOHPPB(BNECIELGDHO OCDACCBEEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PEBFAIEPFDC : JKBJEBPOCFC
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	OMIJJPJLHCC<BNECIELGDHO> HKOOKKIDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	BNECIELGDHO NINOPBANKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LALCAMEHHDG : AMNGACEPCCE
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) CLGHJDFLEAI(Rigidbody LAENDKEGMDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KEBONPHFCJA : PIGNLCDEFND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView GIIPFCINNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class DMPPJMBEEFC : PCNOGBPJOGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode DBJLGBMEDMD;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x876B960", Offset = "0x876A160", VA = "0x18876B960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode AHJBBDPMKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x876FE10", Offset = "0x876E610", VA = "0x18876FE10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x876FC90", Offset = "0x876E490", VA = "0x18876FC90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x876BED0", Offset = "0x876A6D0", VA = "0x18876BED0")]
	public DMPPJMBEEFC(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x876FD00", Offset = "0x876E500", VA = "0x18876FD00", Slot = "6")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x876FAE0", Offset = "0x876E2E0", VA = "0x18876FAE0", Slot = "9")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8770080", Offset = "0x876E880", VA = "0x188770080", Slot = "7")]
	public void LFPMBMNNJIE(bool DKDNJLFGJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x876FB60", Offset = "0x876E360", VA = "0x18876FB60", Slot = "8")]
	public void CFKPPFNLNJC(bool DKDNJLFGJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x876FF20", Offset = "0x876E720", VA = "0x18876FF20", Slot = "10")]
	public bool IJOONHLEMGL(Vector3 LONBCENHPHO, [Out] RaycastHit CLGLGLNJAHH, float IOEOMGELKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x876FB70", Offset = "0x876E370", VA = "0x18876FB70")]
	private void DAMMPFGGCLK(bool DKDNJLFGJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JAEEPKGJBOK : OIHINPNFBOE, IDisposable, FFMEMGNEFKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private LHKNHJGBEJF PIEHGGCNNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private MAFINHHDDBC BLCOKHMNDPA;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LHKNHJGBEJF BOBAFFPNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x877BAD0", Offset = "0x877A2D0", VA = "0x18877BAD0", Slot = "6")]
		get
		{
			return default(LHKNHJGBEJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x877B790", Offset = "0x8779F90", VA = "0x18877B790", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform NLDDLOFJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD656A0", Offset = "0xD63EA0", VA = "0x180D656A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KEIJGPDJMGG, KEIJGPDJMGG> GFFKNFIOBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x877BC10", Offset = "0x877A410", VA = "0x18877BC10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x877B690", Offset = "0x8779E90", VA = "0x18877B690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x877BCC0", Offset = "0x877A4C0", VA = "0x18877BCC0")]
	public JAEEPKGJBOK(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x877B860", Offset = "0x877A060", VA = "0x18877B860", Slot = "8")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x877B740", Offset = "0x8779F40", VA = "0x18877B740", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x12187B0", Offset = "0x1216FB0", VA = "0x1812187B0", Slot = "11")]
	private void GDMLCDAKMKM(KEIJGPDJMGG OPICACCPKDF, KEIJGPDJMGG MLCOHGNCKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "12")]
	private void BCKEBINIJPL(bool EIHIBPCMLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FEGFFONNJPP : DGFONGCELHO
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8773870", Offset = "0x8772070", VA = "0x188773870", Slot = "4")]
	public IMLNALDFNON HIBOMEIIIJH(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8773470", Offset = "0x8771C70", VA = "0x188773470", Slot = "5")]
	public ODMGPPDKOEO FGENDFJFKCK(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8773590", Offset = "0x8771D90", VA = "0x188773590", Slot = "6")]
	public JKBJEBPOCFC GKGMOFNLNNN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8773CE0", Offset = "0x87724E0", VA = "0x188773CE0", Slot = "7")]
	public EGGHPHHOHDO LHOFGGALJAL(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8773A90", Offset = "0x8772290", VA = "0x188773A90", Slot = "8")]
	public JNMNGHLBCMM IGJCOJLEOIF(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x87736C0", Offset = "0x8771EC0", VA = "0x1887736C0", Slot = "9")]
	public OIHINPNFBOE GKHNBHGHMBA(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8772EE0", Offset = "0x87716E0", VA = "0x188772EE0", Slot = "10")]
	public EKMKKMBMIOL AIJNAHGKHEE(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8772E20", Offset = "0x8771620", VA = "0x188772E20", Slot = "11")]
	public CGAIEMNKGNN AFBLGGJGCKP(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8773C20", Offset = "0x8772420", VA = "0x188773C20", Slot = "12")]
	public PCNOGBPJOGL KGCOGCNEHDD(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8773B60", Offset = "0x8772360", VA = "0x188773B60", Slot = "13")]
	public CECBOCOENOD ILNABLODPBN(BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8773D60", Offset = "0x8772560", VA = "0x188773D60")]
	public OMPNOJCAJBN OGEPCMJELBO(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8773000", Offset = "0x8771800", VA = "0x188773000")]
	public PIGNLCDEFND CJCDLNGEKOF(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8773960", Offset = "0x8772160", VA = "0x188773960")]
	public BNGDOEIOEDE IBBEHPJDDCG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8773190", Offset = "0x8771990", VA = "0x188773190")]
	public AMNGACEPCCE CNFDEFJCHFG(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8773790", Offset = "0x8771F90", VA = "0x188773790")]
	public LIBIHIMBJEM KLFEIHJLNPE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8773320", Offset = "0x8771B20", VA = "0x188773320", Slot = "19")]
	public BNECIELGDHO COACNMLLAPN(RigidbodyEx ACGABOLDOKP, FEENKBGNJLG IMINNNCPCJF, LFMOBCIOCKI EGOJLGMOLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FEGFFONNJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8773D60", Offset = "0x8772560", VA = "0x188773D60", Slot = "14")]
	private OMPNOJCAJBN OMCPEGBNIDJ(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8773000", Offset = "0x8771800", VA = "0x188773000", Slot = "15")]
	private PIGNLCDEFND JGPDKMNBJAC(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8773960", Offset = "0x8772160", VA = "0x188773960", Slot = "16")]
	private BNGDOEIOEDE IPPOCIOMHMD(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8773190", Offset = "0x8771990", VA = "0x188773190", Slot = "17")]
	private AMNGACEPCCE EINFOINOHJH(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8773790", Offset = "0x8771F90", VA = "0x188773790", Slot = "18")]
	private LIBIHIMBJEM HCOOINKEODE(BNECIELGDHO DIIOBAFKCCH, [In] FEENKBGNJLG IMINNNCPCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class CBPMKJBOAEJ : CGAIEMNKGNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x876B960", Offset = "0x876A160", VA = "0x18876B960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JAGALNHALBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x876B270", Offset = "0x8769A70", VA = "0x18876B270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool NAMPEJNDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x876B7A0", Offset = "0x8769FA0", VA = "0x18876B7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x876BC10", Offset = "0x876A410", VA = "0x18876BC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x876BED0", Offset = "0x876A6D0", VA = "0x18876BED0")]
	public CBPMKJBOAEJ(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x876B800", Offset = "0x876A000", VA = "0x18876B800", Slot = "4")]
	public void KKNADNFGPJB(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x876B9B0", Offset = "0x876A1B0", VA = "0x18876B9B0")]
	private void LCEKDJDEFBH(Vector3 IBCIAMDAPFE, ForceMode BHFCPGJKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x876B520", Offset = "0x8769D20", VA = "0x18876B520", Slot = "5")]
	public void JPGMEKBHFNN(Vector3 IBCIAMDAPFE, Vector3 KKEEFCOJJFM, ForceMode BHFCPGJKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x876B110", Offset = "0x8769910", VA = "0x18876B110", Slot = "6")]
	public void BCGENJMAGII(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x876BC70", Offset = "0x876A470", VA = "0x18876BC70")]
	private void PMHKGMEJDOK(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x876B2C0", Offset = "0x8769AC0", VA = "0x18876B2C0", Slot = "7")]
	public void HFHPBIDEFKL(Vector3 MEBPAMBPAPG, ForceMode BHFCPGJKENA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EOJNEKMPKGP : CECBOCOENOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PKGHLLLGFDM;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EEHEIGJJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8772CA0", Offset = "0x87714A0", VA = "0x188772CA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x876BED0", Offset = "0x876A6D0", VA = "0x18876BED0")]
	public EOJNEKMPKGP(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8772C70", Offset = "0x8771470", VA = "0x188772C70", Slot = "6")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8772DB0", Offset = "0x87715B0", VA = "0x188772DB0", Slot = "7")]
	public void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class EGNFMDEIDDL : HDECGGKCMHB, IMLNALDFNON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BNECIELGDHO ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<BNECIELGDHO> EDADLPODKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BNECIELGDHO MJAMEBJFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private BNECIELGDHO MJNLMOPPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform JGPHILDJACP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8771D90", Offset = "0x8770590", VA = "0x188771D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8770D50", Offset = "0x876F550", VA = "0x188770D50", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BNECIELGDHO LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<BNECIELGDHO> IBEDELCOKII
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ABCFNANMJEH DLGCBHGBIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8771B10", Offset = "0x8770310", VA = "0x188771B10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87709D0", Offset = "0x876F1D0", VA = "0x1887709D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ABCFNANMJEH AMPKBFPIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8770930", Offset = "0x876F130", VA = "0x188770930", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8770B20", Offset = "0x876F320", VA = "0x188770B20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event DFMABCKBGFJ MKGNAFDKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8771A70", Offset = "0x8770270", VA = "0x188771A70", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87701E0", Offset = "0x876E9E0", VA = "0x1887701E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IJEKFEDFMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8771760", Offset = "0x876FF60", VA = "0x188771760", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87704D0", Offset = "0x876ECD0", VA = "0x1887704D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GNPNPLNIKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8771BB0", Offset = "0x87703B0", VA = "0x188771BB0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8770430", Offset = "0x876EC30", VA = "0x188770430", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BNECIELGDHO> FOEBIOEDHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8770A70", Offset = "0x876F270", VA = "0x188770A70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8770C00", Offset = "0x876F400", VA = "0x188770C00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BNECIELGDHO> EHBFOPGDAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8770130", Offset = "0x876E930", VA = "0x188770130", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8771DF0", Offset = "0x87705F0", VA = "0x188771DF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action AOFFLKEJODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8770390", Offset = "0x876EB90", VA = "0x188770390", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8770090", Offset = "0x876E890", VA = "0x188770090", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BNECIELGDHO> NOOBONDIFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x87716B0", Offset = "0x876FEB0", VA = "0x1887716B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8770D60", Offset = "0x876F560", VA = "0x188770D60", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8771EA0", Offset = "0x87706A0", VA = "0x188771EA0")]
	public EGNFMDEIDDL(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8770890", Offset = "0x876F090", VA = "0x188770890", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8771130", Offset = "0x876F930", VA = "0x188771130", Slot = "30")]
	public void KBJIKDOEMIH(BNECIELGDHO OOBPPDKPNFF, bool FMFJOLALOHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8771800", Offset = "0x8770000", VA = "0x188771800", Slot = "6")]
	public void LNDBIJDMBMI(BNECIELGDHO OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8770EB0", Offset = "0x876F6B0", VA = "0x188770EB0", Slot = "7")]
	public void JGDDFEOHPPB(BNECIELGDHO OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8770280", Offset = "0x876EA80", VA = "0x188770280", Slot = "4")]
	public void BFNMONPOGNP(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8770CB0", Offset = "0x876F4B0", VA = "0x188770CB0", Slot = "5")]
	public void HLIKHCJLJOA(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8770E10", Offset = "0x876F610", VA = "0x188770E10")]
	private void JFMLNNIPKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8770BC0", Offset = "0x876F3C0", VA = "0x188770BC0")]
	private void GMCPIENKLHE(BNECIELGDHO OCDACCBEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8771C50", Offset = "0x8770450", VA = "0x188771C50")]
	private void NOPMCPDHHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8770630", Offset = "0x876EE30", VA = "0x188770630")]
	private void CPNKDNIEMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8770760", Offset = "0x876EF60", VA = "0x188770760")]
	private void DNPEDFMNDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8770570", Offset = "0x876ED70", VA = "0x188770570")]
	[CompilerGenerated]
	private object CPNBLNEFKEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class ICKFJGLABHA
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x877B5D0", Offset = "0x8779DD0", VA = "0x18877B5D0")]
	public static HDECGGKCMHB MAINJBKECJH(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class JPEBDJPPNOO : PEBFAIEPFDC, JKBJEBPOCFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OMIJJPJLHCC<BNECIELGDHO> MBDAGHLBFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool HAABOCKJMNN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public OMIJJPJLHCC<BNECIELGDHO> HKOOKKIDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 IHHGKFNOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x877FDC0", Offset = "0x877E5C0", VA = "0x18877FDC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 GFGBHLMKMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x877F5F0", Offset = "0x877DDF0", VA = "0x18877F5F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 KGIKDNLAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x877FCE0", Offset = "0x877E4E0", VA = "0x18877FCE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BNECIELGDHO NINOPBANKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x877FE60", Offset = "0x877E660", VA = "0x18877FE60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x877FF10", Offset = "0x877E710", VA = "0x18877FF10")]
	public JPEBDJPPNOO(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x877FDF0", Offset = "0x877E5F0", VA = "0x18877FDF0", Slot = "8")]
	public void OHHCGGPLCNG(BNECIELGDHO MJNLMOPPION, object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x877F8F0", Offset = "0x877E0F0", VA = "0x18877F8F0", Slot = "9")]
	public void DNJHGMFKEOM(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x877F250", Offset = "0x877DA50", VA = "0x18877F250")]
	private Vector3 BAKPALPMBJI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x877F950", Offset = "0x877E150", VA = "0x18877F950")]
	private void HBMIBLANJAF(BNECIELGDHO BACJEKKPNIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NPNFHBPMDMJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8781380", Offset = "0x877FB80", VA = "0x188781380")]
	public static PEBFAIEPFDC ILEDDJPFGCO(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JJDCKPDKGGM : LALCAMEHHDG, AMNGACEPCCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 EHOBMIPPFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 ENANGLGEIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float BBKPNBIPFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float AEBEBDHOJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 FGFLPKJDAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? DFHJECEIBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? MHOHCLIPGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool BKCHLJDGOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool PKGIDFGPJGB;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 LEEOAJNGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1715010", Offset = "0x1713810", VA = "0x181715010", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x877E040", Offset = "0x877C840", VA = "0x18877E040", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 IOFFILBCPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x877DF50", Offset = "0x877C750", VA = "0x18877DF50", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float JENDPKCADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xD8A220", Offset = "0xD88A20", VA = "0x180D8A220", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x877DD90", Offset = "0x877C590", VA = "0x18877DD90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float MKFFGCDCLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC860B0", Offset = "0xC848B0", VA = "0x180C860B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x877DEA0", Offset = "0x877C6A0", VA = "0x18877DEA0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 GMKLHNOOCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x877E650", Offset = "0x877CE50", VA = "0x18877E650", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion IMBCPLCGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x877E7E0", Offset = "0x877CFE0", VA = "0x18877E7E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x87727C0", Offset = "0x8770FC0", VA = "0x1887727C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ABCFNANMJEH ECJFJDIBAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x877F050", Offset = "0x877D850", VA = "0x18877F050", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x877DCF0", Offset = "0x877C4F0", VA = "0x18877DCF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x877F0F0", Offset = "0x877D8F0", VA = "0x18877F0F0")]
	public JJDCKPDKGGM(BNECIELGDHO ACGABOLDOKP, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x877DBD0", Offset = "0x877C3D0", VA = "0x18877DBD0", Slot = "17")]
	public void COMFHGOINGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x877E0F0", Offset = "0x877C8F0", VA = "0x18877E0F0", Slot = "16")]
	public void IGCHGOHEDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x877C9B0", Offset = "0x877B1B0", VA = "0x18877C9B0", Slot = "19")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x877CB80", Offset = "0x877B380", VA = "0x18877CB80", Slot = "20")]
	public void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x877EC80", Offset = "0x877D480", VA = "0x18877EC80", Slot = "18")]
	public void OJPJFPODHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x877E1D0", Offset = "0x877C9D0", VA = "0x18877E1D0", Slot = "21")]
	public void ILNDMFOFEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x877E040", Offset = "0x877C840", VA = "0x18877E040")]
	private void GOPNKOHDOAK(Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x877CA90", Offset = "0x877B290", VA = "0x18877CA90")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BCHNFIFPDGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x877DD90", Offset = "0x877C590", VA = "0x18877DD90")]
	private void OJPEOLOJHHF(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x877DEA0", Offset = "0x877C6A0", VA = "0x18877DEA0")]
	private void FABFIHBIJCN(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x877EAE0", Offset = "0x877D2E0", VA = "0x18877EAE0")]
	private Vector3 OCDKALFBBKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x877EE20", Offset = "0x877D620", VA = "0x18877EE20", Slot = "15")]
	public void OLOEKKEFKGH((Quaternion rot, Vector3 moments) MCEDHANOLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x877E960", Offset = "0x877D160", VA = "0x18877E960")]
	private Quaternion OABFFIKIDKG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x877CD60", Offset = "0x877B560", VA = "0x18877CD60")]
	public void CLGHJDFLEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x877CE30", Offset = "0x877B630", VA = "0x18877CE30", Slot = "4")]
	public (float, Vector3) CLGHJDFLEAI(Rigidbody LAENDKEGMDJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KLEACGALJCE
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8780010", Offset = "0x877E810", VA = "0x188780010")]
	public static LALCAMEHHDG MNEPLCJHCID(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NPKLCECEMNC : BNGDOEIOEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BFPHHCAGGHH KDNJCFCAMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CAKMKKHPGOG CKOJAFBCIHC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NPOHNBCOJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x18F99A0", Offset = "0x18F81A0", VA = "0x1818F99A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CAKMKKHPGOG NGLHCFCPFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0", Slot = "11")]
		get
		{
			return default(CAKMKKHPGOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8781280", Offset = "0x877FA80", VA = "0x188781280")]
	public NPKLCECEMNC(BNECIELGDHO ACGABOLDOKP, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8781070", Offset = "0x877F870", VA = "0x188781070", Slot = "4")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8781170", Offset = "0x877F970", VA = "0x188781170")]
	private bool JIIKBDGEOGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8781140", Offset = "0x877F940", VA = "0x188781140", Slot = "5")]
	public void HPELNHJMLAP(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8781210", Offset = "0x877FA10", VA = "0x188781210", Slot = "6")]
	public void NAFAOMFGAOL(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8780DC0", Offset = "0x877F5C0", VA = "0x188780DC0", Slot = "9")]
	public void DPBINGDBDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8780C70", Offset = "0x877F470", VA = "0x188780C70")]
	private void AKHPOIFCOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8780EF0", Offset = "0x877F6F0", VA = "0x188780EF0")]
	private void EOCJPJIAAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8780D80", Offset = "0x877F580", VA = "0x188780D80", Slot = "8")]
	public void AONEKCIEFCO(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8781240", Offset = "0x877FA40", VA = "0x188781240", Slot = "7")]
	public void PFDHFOAKGBI(BNECIELGDHO ACGABOLDOKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NPFKNIJFCOM : EKMKKMBMIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BFPHHCAGGHH EMEPBAKFCPC;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JAGALNHALBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8780820", Offset = "0x877F020", VA = "0x188780820", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ABCFNANMJEH HIKFKADFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x87808D0", Offset = "0x877F0D0", VA = "0x1887808D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8780AE0", Offset = "0x877F2E0", VA = "0x188780AE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8780B80", Offset = "0x877F380", VA = "0x188780B80")]
	public NPFKNIJFCOM(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8780A90", Offset = "0x877F290", VA = "0x188780A90", Slot = "7")]
	public void LEPCAHFKKDG(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8780A80", Offset = "0x877F280", VA = "0x188780A80", Slot = "8")]
	public void JGOMBCGABON(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8780970", Offset = "0x877F170", VA = "0x188780970", Slot = "9")]
	public void HHHFHBOFPJB(object KAJENDFCCBJ, bool MANNIEELCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8780AA0", Offset = "0x877F2A0", VA = "0x188780AA0", Slot = "12")]
	public void LIBKLENFFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8780770", Offset = "0x877EF70", VA = "0x188780770", Slot = "10")]
	public void ABMEAMKNONH(Rigidbody HNPNGMHGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x87807F0", Offset = "0x877EFF0", VA = "0x1887807F0", Slot = "11")]
	public void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class HKLMKJDCDBG : KEBONPHFCJA, PIGNLCDEFND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView AMHLEGGNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool OILPJMOPNGI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView GIIPFCINNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CKMFIGLLOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x877A980", Offset = "0x8779180", VA = "0x18877A980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CFKGHHENCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ABCFNANMJEH EJNDOJMAFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x877B1B0", Offset = "0x87799B0", VA = "0x18877B1B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x877B110", Offset = "0x8779910", VA = "0x18877B110", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x877B250", Offset = "0x8779A50", VA = "0x18877B250")]
	public HKLMKJDCDBG(BNECIELGDHO ACGABOLDOKP, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x877AFE0", Offset = "0x87797E0", VA = "0x18877AFE0", Slot = "9")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x877A990", Offset = "0x8779190", VA = "0x18877A990", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x877AE70", Offset = "0x8779670", VA = "0x18877AE70", Slot = "10")]
	public void GJPOOHCDNJF(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x877AD00", Offset = "0x8779500", VA = "0x18877AD00", Slot = "11")]
	public void GILEONICMMC(BNECIELGDHO MJNLMOPPION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x877A810", Offset = "0x8779010", VA = "0x18877A810")]
	private void CLFABNPFJIO(RRNetworkView IEIPEJMBGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x877A6C0", Offset = "0x8778EC0", VA = "0x18877A6C0")]
	private void BEKPOHLDDBB(LHDELCHFOJE CLPABJJGDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x877AA90", Offset = "0x8779290", VA = "0x18877AA90")]
	private void FALHKMPHGNI(RRNetworkView EFADGMIBBFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BKDLPEGAMFO
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x876B050", Offset = "0x8769850", VA = "0x18876B050")]
	public static KEBONPHFCJA EKGAPOJKGKA(this BNECIELGDHO DIIOBAFKCCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IABHKJMNAGG : LIBIHIMBJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints HGDOLNEPPLK;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LENKKJOJBED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA78BE0", Offset = "0xA773E0", VA = "0x180A78BE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD9DF30", Offset = "0xD9C730", VA = "0x180D9DF30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DMEHFAINMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE10", Offset = "0xA9D610", VA = "0x180A9EE10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD9E0C0", Offset = "0xD9C8C0", VA = "0x180D9E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints OOOJOFPCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x877B400", Offset = "0x8779C00", VA = "0x18877B400", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x877B530", Offset = "0x8779D30", VA = "0x18877B530")]
	public IABHKJMNAGG(BNECIELGDHO ACGABOLDOKP, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x877B3A0", Offset = "0x8779BA0", VA = "0x18877B3A0", Slot = "9")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x877B3D0", Offset = "0x8779BD0", VA = "0x18877B3D0", Slot = "10")]
	public void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MEDGNPCBLCL : EGGHPHHOHDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BNECIELGDHO ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float HEODOPIDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float HOMLIBAIFBF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float HFKLAHKFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x87803A0", Offset = "0x877EBA0", VA = "0x1887803A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PNDGOKFEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xDD27A0", Offset = "0xDD0FA0", VA = "0x180DD27A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x87802D0", Offset = "0x877EAD0", VA = "0x1887802D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8780470", Offset = "0x877EC70", VA = "0x188780470")]
	public MEDGNPCBLCL(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x87801E0", Offset = "0x877E9E0", VA = "0x1887801E0", Slot = "8")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8780230", Offset = "0x877EA30", VA = "0x188780230", Slot = "9")]
	public void CHJFOLLCFJO(Rigidbody JGLNBKCPMAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class EJHPMACIMCN : JNMNGHLBCMM
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly BMELPJIFPCL EKAHGHGKHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool COHGHCOLOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool NBPDFGCDNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int LGIFIGKGPPJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x87727C0", Offset = "0x8770FC0", VA = "0x1887727C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PJIKGPAKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8772380", Offset = "0x8770B80", VA = "0x188772380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BNECIELGDHO IFICPJBFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8772B00", Offset = "0x8771300", VA = "0x188772B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool NAMPEJNDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8772760", Offset = "0x8770F60", VA = "0x188772760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ABCFNANMJEH GGGKEGBLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x87722E0", Offset = "0x8770AE0", VA = "0x1887722E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8772620", Offset = "0x8770E20", VA = "0x188772620", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8772BE0", Offset = "0x87713E0", VA = "0x188772BE0")]
	public EJHPMACIMCN(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x87726C0", Offset = "0x8770EC0", VA = "0x1887726C0", Slot = "6")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8772750", Offset = "0x8770F50", VA = "0x188772750", Slot = "8")]
	public void HDNAOGIDGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8772190", Offset = "0x8770990", VA = "0x188772190", Slot = "7")]
	public bool DKICDGBHGLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8771F60", Offset = "0x8770760", VA = "0x188771F60", Slot = "9")]
	public void BNIJGPOBDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8772A60", Offset = "0x8771260", VA = "0x188772A60", Slot = "13")]
	public void OCNEDMICAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8772070", Offset = "0x8770870", VA = "0x188772070", Slot = "12")]
	public void CPCHMKGCDFN(bool KMJDHPCOMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8772000", Offset = "0x8770800", VA = "0x188772000", Slot = "10")]
	public bool BNJPMIDKMJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x87729A0", Offset = "0x87711A0", VA = "0x1887729A0", Slot = "11")]
	public bool MEMDPJPCNDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x87723A0", Offset = "0x8770BA0", VA = "0x1887723A0")]
	private bool GFJJBOIKKFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8772810", Offset = "0x8771010", VA = "0x188772810")]
	private void MAGBGCBJJGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class POJCMAPODGG : OMPNOJCAJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BFPHHCAGGHH EMHNKJJBKMA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody POPJLLBILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool NAMPEJNDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x876B7A0", Offset = "0x8769FA0", VA = "0x18876B7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KDBKCMBGFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x18F99A0", Offset = "0x18F81A0", VA = "0x1818F99A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8781C80", Offset = "0x8780480", VA = "0x188781C80")]
	public POJCMAPODGG(BNECIELGDHO ACGABOLDOKP, [In] FEENKBGNJLG IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8781810", Offset = "0x8780010", VA = "0x188781810", Slot = "5")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8781A30", Offset = "0x8780230", VA = "0x188781A30", Slot = "7")]
	public void KFINFFPHJDI(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8781C50", Offset = "0x8780450", VA = "0x188781C50", Slot = "8")]
	public void PGCMGOGPNMJ(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x87814E0", Offset = "0x877FCE0", VA = "0x1887814E0", Slot = "9")]
	public void BNGBKDEJFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8781A60", Offset = "0x8780260", VA = "0x188781A60", Slot = "10")]
	public void LCJGDABHLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x87818B0", Offset = "0x87800B0", VA = "0x1887818B0", Slot = "11")]
	public void JEJPDLDHNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CLHFBBKIDDP : ODMGPPDKOEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GNFLMDKHDJN ACGABOLDOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BFPHHCAGGHH PDGNOIHOIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float JMBACJNCEKP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public KBEKBNCLGHN FNOJKPPCACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EEDPJNEGGND ILKLIPOPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 KGIKDNLAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x876E950", Offset = "0x876D150", VA = "0x18876E950", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x876F440", Offset = "0x876DC40", VA = "0x18876F440", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 BNHFKFNPDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x876ECB0", Offset = "0x876D4B0", VA = "0x18876ECB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x876C8A0", Offset = "0x876B0A0", VA = "0x18876C8A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 MPJHCFFFBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x876D680", Offset = "0x876BE80", VA = "0x18876D680", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x876D080", Offset = "0x876B880", VA = "0x18876D080", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 CMEMCAJMCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x876D300", Offset = "0x876BB00", VA = "0x18876D300", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x876EC80", Offset = "0x876D480", VA = "0x18876EC80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float FJJCCFGDGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA75240", Offset = "0xA73A40", VA = "0x180A75240", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x876F500", Offset = "0x876DD00", VA = "0x18876F500", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MGCPGJHDFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2319C40", Offset = "0x2318440", VA = "0x182319C40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private CGAIEMNKGNN OIBCFDBNNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7D30E40", Offset = "0x7D2F640", VA = "0x187D30E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PJIKGPAKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x876E3F0", Offset = "0x876CBF0", VA = "0x18876E3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x876F9F0", Offset = "0x876E1F0", VA = "0x18876F9F0")]
	public CLHFBBKIDDP(BNECIELGDHO ACGABOLDOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x876D9E0", Offset = "0x876C1E0", VA = "0x18876D9E0", Slot = "19")]
	public void GPGBEHCLMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x876D490", Offset = "0x876BC90", VA = "0x18876D490", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x876C2F0", Offset = "0x876AAF0", VA = "0x18876C2F0", Slot = "28")]
	public void ABMEAMKNONH(Rigidbody JGLNBKCPMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x16C13E0", Offset = "0x16BFBE0", VA = "0x1816C13E0", Slot = "20")]
	public void ABJIJCKPLEG(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x16C0450", Offset = "0x16BEC50", VA = "0x1816C0450", Slot = "30")]
	public void EEHFCIMPBIF(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x876F610", Offset = "0x876DE10", VA = "0x18876F610", Slot = "35")]
	public Vector3 OGCMCOEJLOF(Vector3 EJOPPMIDHIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x876D140", Offset = "0x876B940", VA = "0x18876D140", Slot = "34")]
	public Vector3 COMNIPFJHDC(Vector3 FJMKECGDEHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x876D9E0", Offset = "0x876C1E0", VA = "0x18876D9E0", Slot = "27")]
	public void EPFKJKBLHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x876E410", Offset = "0x876CC10", VA = "0x18876E410", Slot = "25")]
	public void GCKOGNPMGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x876E470", Offset = "0x876CC70", VA = "0x18876E470", Slot = "24")]
	public void GLJPEOPHCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x876DA80", Offset = "0x876C280", VA = "0x18876DA80", Slot = "33")]
	public void FAFALCKHNNJ(Vector3 LICAIPLHADH, Vector3 IEEFOOJGDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x876F990", Offset = "0x876E190", VA = "0x18876F990", Slot = "32")]
	public void PLLMCGPENGI(Vector3 DMGPMFJCFAD, Vector3 FGJALIKHFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x876D840", Offset = "0x876C040", VA = "0x18876D840", Slot = "31")]
	public void EPAEGBNKPOH(Vector3 PCHFPENLEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x876EF10", Offset = "0x876D710", VA = "0x18876EF10", Slot = "22")]
	public void KONLEDECMEO(AILNCLJHELL IAIOELIFIPI, Vector3 MKHKJGAKHCA, float NOAIONKJIBJ, float EKAEALFGBGP = 8f, float PPFLELGLCLE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x876C980", Offset = "0x876B180", VA = "0x18876C980", Slot = "21")]
	public void BJIGIBPLKMN(HGKMNDKCDJL GGIOLKEGMJK, Vector3 DIFGALLBNBL, float OIKLFIKCAKB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x876CC00", Offset = "0x876B400", VA = "0x18876CC00", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CDPCCFBHJHB(HGKMNDKCDJL GGIOLKEGMJK, Vector3 FENAGHBAFHI, float LDHDGMKHGLA = 7f, float ADJPAMDCLMJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x17E9B80", Offset = "0x17E8380", VA = "0x1817E9B80")]
	private static void CABIMPKEDGB(Vector3 KFKKLCCOCPA, Vector3 IILAMILCBNH, [Out] Vector3 ILPBCMJMDFP, [Out] Vector3 LJJLDELBGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x876EE30", Offset = "0x876D630", VA = "0x18876EE30", Slot = "29")]
	public Vector3 JKPEHNKINEK(Vector3 KFKKLCCOCPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x876DCC0", Offset = "0x876C4C0", VA = "0x18876DCC0", Slot = "26")]
	public void FFGFFHNGODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x876F500", Offset = "0x876DD00", VA = "0x18876F500")]
	private void OPKCEIPMMNH(float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x876F7F0", Offset = "0x876DFF0", VA = "0x18876F7F0")]
	private void OMCEFMONLHE(Vector3 DIFGALLBNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x876EB00", Offset = "0x876D300", VA = "0x18876EB00")]
	private Vector3 HHIIPGKAPMB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x876E4D0", Offset = "0x876CCD0", VA = "0x18876E4D0")]
	private void GLONCCKNHEO(Vector3 FJMKECGDEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x876D4F0", Offset = "0x876BCF0", VA = "0x18876D4F0")]
	private Vector3 ECLENGGGJIB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x876C420", Offset = "0x876AC20", VA = "0x18876C420")]
	private void AMKJDHAKAAG(Vector3 MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x876DE50", Offset = "0x876C650", VA = "0x18876DE50")]
	private void FGBLLCLJHEC(Vector3 FJMKECGDEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x876C8D0", Offset = "0x876B0D0", VA = "0x18876C8D0")]
	private void BGCNLAIDHNC()
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
