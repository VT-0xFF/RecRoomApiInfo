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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x843E0F0", Offset = "0x843D2F0", VA = "0x18843E0F0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2085180", Offset = "0x2084380", VA = "0x182085180", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8445B10", Offset = "0x8444D10", VA = "0x188445B10")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8445E10", Offset = "0x8445010", VA = "0x188445E10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8445E70", Offset = "0x8445070", VA = "0x188445E70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FLECLLPEPCA, PFFMGCANADG, KKHGLPKGNNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FODGIOKBGBI FFDJLHPELAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool CEKGPCMIBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private IOEJADJKHIM PPFHDLNHEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[BMOELPNDLIH(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[BMOELPNDLIH(HJNEPGJJFOF.SelfAndParent, true, false, false)]
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
		private IAGAFLNEHEJ physicsInterpolation;

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
		private Transform BOIECFFPLJG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal IOEJADJKHIM KIJPEEFIAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8440550", Offset = "0x843F750", VA = "0x188440550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IOEJADJKHIM CHGMIEOILDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int ODGEPMGANEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8443020", Offset = "0x8442220", VA = "0x188443020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ODOJGHLAGFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8443380", Offset = "0x8442580", VA = "0x188443380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ADHDCGIKAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84432C0", Offset = "0x84424C0", VA = "0x1884432C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NJHDJGHEICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8443F80", Offset = "0x8443180", VA = "0x188443F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8445480", Offset = "0x8444680", VA = "0x188445480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HMKFKLBGGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x809CA80", Offset = "0x809BC80", VA = "0x18809CA80", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x809A640", Offset = "0x8099840", VA = "0x18809A640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform PMPOHKBNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1EB57A0", Offset = "0x1EB49A0", VA = "0x181EB57A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CEGGLBECLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1EB57A0", Offset = "0x1EB49A0", VA = "0x181EB57A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform POKNNEEEMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1EB57A0", Offset = "0x1EB49A0", VA = "0x181EB57A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PKLBDOAGHDH CKKIPNGAOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8443080", Offset = "0x8442280", VA = "0x188443080")]
			get
			{
				return default(PKLBDOAGHDH);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8444C30", Offset = "0x8443E30", VA = "0x188444C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EAJMLDDJJDP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8443690", Offset = "0x8442890", VA = "0x188443690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HCBJHJGLDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84431A0", Offset = "0x84423A0", VA = "0x1884431A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LNPGGOONBDB LLFMKIHDNDK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84435D0", Offset = "0x84427D0", VA = "0x1884435D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8444DF0", Offset = "0x8443FF0", VA = "0x188444DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MFLENIHFHJN LAPBMFOBBME
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8443570", Offset = "0x8442770", VA = "0x188443570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8444D80", Offset = "0x8443F80", VA = "0x188444D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ECPHJGKPCNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84434C0", Offset = "0x84426C0", VA = "0x1884434C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LGIHCHPLMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8443520", Offset = "0x8442720", VA = "0x188443520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CIHILCEEJAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8443200", Offset = "0x8442400", VA = "0x188443200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8444CA0", Offset = "0x8443EA0", VA = "0x188444CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IAHADEGNFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x16A8BB0", Offset = "0x16A7DB0", VA = "0x1816A8BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HPBMAOGLCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8443F20", Offset = "0x8443120", VA = "0x188443F20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ICNFBBBPHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8443EC0", Offset = "0x84430C0", VA = "0x188443EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8445410", Offset = "0x8444610", VA = "0x188445410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KANBCHFHAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84438F0", Offset = "0x8442AF0", VA = "0x1884438F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8445090", Offset = "0x8444290", VA = "0x188445090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float DNCIBLPJEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84436F0", Offset = "0x84428F0", VA = "0x1884436F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8444E60", Offset = "0x8444060", VA = "0x188444E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OGKPKCCHMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84444D0", Offset = "0x84436D0", VA = "0x1884444D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84459C0", Offset = "0x8444BC0", VA = "0x1884459C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KIKAAPHKOHP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8443CA0", Offset = "0x8442EA0", VA = "0x188443CA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84451E0", Offset = "0x84443E0", VA = "0x1884451E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 NCFLDHAGLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8444610", Offset = "0x8443810", VA = "0x188444610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode DGLJNKJFKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8443830", Offset = "0x8442A30", VA = "0x188443830")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8444FB0", Offset = "0x84441B0", VA = "0x188444FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float BDHDMNIBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8443260", Offset = "0x8442460", VA = "0x188443260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8444D10", Offset = "0x8443F10", VA = "0x188444D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OALBEPLKKHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8443890", Offset = "0x8442A90", VA = "0x188443890")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8445020", Offset = "0x8444220", VA = "0x188445020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BOJJOFOFIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8444040", Offset = "0x8443240", VA = "0x188444040")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 BNLADNJCIOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8444040", Offset = "0x8443240", VA = "0x188444040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84457A0", Offset = "0x84449A0", VA = "0x1884457A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float AHAJKIHFAHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8443D80", Offset = "0x8442F80", VA = "0x188443D80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84452C0", Offset = "0x84444C0", VA = "0x1884452C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float IEAOFPEOPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8444470", Offset = "0x8443670", VA = "0x188444470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8445950", Offset = "0x8444B50", VA = "0x188445950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CMKHBBLJBEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8444120", Offset = "0x8443320", VA = "0x188444120")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8445520", Offset = "0x8444720", VA = "0x188445520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion BMGOOJLNKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x84443A0", Offset = "0x84435A0", VA = "0x1884443A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8445880", Offset = "0x8444A80", VA = "0x188445880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HGODIAEEEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x84441F0", Offset = "0x84433F0", VA = "0x1884441F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x84455F0", Offset = "0x84447F0", VA = "0x1884455F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion MFBKGPLMLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84442D0", Offset = "0x84434D0", VA = "0x1884442D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84456D0", Offset = "0x84448D0", VA = "0x1884456D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 JONPFBFHNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8444530", Offset = "0x8443730", VA = "0x188444530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8445A30", Offset = "0x8444C30", VA = "0x188445A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CELELBKKFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8443DE0", Offset = "0x8442FE0", VA = "0x188443DE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8445330", Offset = "0x8444530", VA = "0x188445330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HNMBFFBJHEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8443750", Offset = "0x8442950", VA = "0x188443750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8444ED0", Offset = "0x84440D0", VA = "0x188444ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NHECMEGPDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8443BC0", Offset = "0x8442DC0", VA = "0x188443BC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8445100", Offset = "0x8444300", VA = "0x188445100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CHDEGPGGKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8443A80", Offset = "0x8442C80", VA = "0x188443A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MACGMLFPELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84439B0", Offset = "0x8442BB0", VA = "0x1884439B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 OLLIMJKJNPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x84447D0", Offset = "0x84439D0", VA = "0x1884447D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 LANNMPAPAEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x84446F0", Offset = "0x84438F0", VA = "0x1884446F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JEJJBAALCIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8443B60", Offset = "0x8442D60", VA = "0x188443B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LOCPPNIGPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8443630", Offset = "0x8442830", VA = "0x188443630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EHNMDGKDFFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8443140", Offset = "0x8442340", VA = "0x188443140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AHOMCOHBDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84430E0", Offset = "0x84422E0", VA = "0x1884430E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HMBJJPECPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8442FC0", Offset = "0x84421C0", VA = "0x188442FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EEICIMJFDOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8443950", Offset = "0x8442B50", VA = "0x188443950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DBBHGEKFDEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2396770", Offset = "0x2395970", VA = "0x182396770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KHDGNNMJLLN BLPOFNCJOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8442EE0", Offset = "0x84420E0", VA = "0x188442EE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8444B50", Offset = "0x8443D50", VA = "0x188444B50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EIGFFHGOEIP MKKMLGMNILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8442C50", Offset = "0x8441E50", VA = "0x188442C50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84448B0", Offset = "0x8443AB0", VA = "0x1884448B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EIGFFHGOEIP FGJPKDEFFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8442CB0", Offset = "0x8441EB0", VA = "0x188442CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8444920", Offset = "0x8443B20", VA = "0x188444920")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EIGFFHGOEIP GONDBPBAOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8442E00", Offset = "0x8442000", VA = "0x188442E00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8444A70", Offset = "0x8443C70", VA = "0x188444A70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MIPMLGOBAHP, MIPMLGOBAHP> HFJCODFCPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8442D90", Offset = "0x8441F90", VA = "0x188442D90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8444A00", Offset = "0x8443C00", VA = "0x188444A00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event EIGFFHGOEIP NJFPKNKEMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8442E70", Offset = "0x8442070", VA = "0x188442E70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8444AE0", Offset = "0x8443CE0", VA = "0x188444AE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EIGFFHGOEIP GKOAALACNGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8442F50", Offset = "0x8442150", VA = "0x188442F50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8444BC0", Offset = "0x8443DC0", VA = "0x188444BC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EIGFFHGOEIP HFKNPDAIAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8442D20", Offset = "0x8441F20", VA = "0x188442D20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8444990", Offset = "0x8443B90", VA = "0x188444990")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0", Slot = "8")]
		private void ODIJAIKCFKE(IOEJADJKHIM AHLPFPPNCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8441680", Offset = "0x8440880", VA = "0x188441680", Slot = "9")]
		public FAECONBOANN GetData()
		{
			return default(FAECONBOANN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8441C00", Offset = "0x8440E00", VA = "0x188441C00")]
		internal void MNMPIGIEDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8442980", Offset = "0x8441B80", VA = "0x188442980")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody KKOLBCMIGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84413D0", Offset = "0x84405D0", VA = "0x1884413D0")]
		public FLECLLPEPCA GetChild(int NIBICIJAIGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84425E0", Offset = "0x84417E0", VA = "0x1884425E0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) LCCOOECAKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8441010", Offset = "0x8440210", VA = "0x188441010")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8442870", Offset = "0x8441A70", VA = "0x188442870")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8440550", Offset = "0x843F750", VA = "0x188440550")]
		private IOEJADJKHIM ACCBMGNANGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8441A80", Offset = "0x8440C80", VA = "0x188441A80")]
		private void MNFKMEBPDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8441DB0", Offset = "0x8440FB0", VA = "0x188441DB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8441CF0", Offset = "0x8440EF0", VA = "0x188441CF0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8441C00", Offset = "0x8440E00", VA = "0x188441C00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8441D50", Offset = "0x8440F50", VA = "0x188441D50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8441E10", Offset = "0x8441010", VA = "0x188441E10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8440600", Offset = "0x843F800", VA = "0x188440600")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8441E70", Offset = "0x8441070", VA = "0x188441E70")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8441360", Offset = "0x8440560", VA = "0x188441360")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8441C90", Offset = "0x8440E90", VA = "0x188441C90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8442740", Offset = "0x8441940", VA = "0x188442740")]
		public void SetParent(RigidbodyEx MLCDCHNOCFI, bool JPKNJNJLHOB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8442180", Offset = "0x8441380", VA = "0x188442180")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8441710", Offset = "0x8440910", VA = "0x188441710")]
		public bool IsRigidbodyAncestor(RigidbodyEx BEEGJLCIAJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8441810", Offset = "0x8440A10", VA = "0x188441810")]
		public bool IsRigidbodyDescendant(RigidbodyEx MFCGAPDBHBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8440870", Offset = "0x843FA70", VA = "0x188440870")]
		public void AddInterpolationRestriction(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8441EE0", Offset = "0x84410E0", VA = "0x188441EE0")]
		public void RemoveInterpolationRestriction(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84408E0", Offset = "0x843FAE0", VA = "0x1884408E0")]
		public void AddKinematic(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8441F50", Offset = "0x8441150", VA = "0x188441F50")]
		public void RemoveKinematic(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84426C0", Offset = "0x84418C0", VA = "0x1884426C0")]
		public void SetKinematic(object PPOILDCNBFL, bool BJEEFLICPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84424E0", Offset = "0x84416E0", VA = "0x1884424E0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LKKAKBHJDDH, Quaternion IHKFAJHNMBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84423E0", Offset = "0x84415E0", VA = "0x1884423E0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JJLEJJBGLEO, Quaternion CPBHBDHBHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8441570", Offset = "0x8440770", VA = "0x188441570")]
		public Vector3 GetConstrainedVelocity(Vector3 JONPFBFHNDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8441460", Offset = "0x8440660", VA = "0x188441460")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HNMBFFBJHEC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8440780", Offset = "0x843F980", VA = "0x188440780")]
		public void AddForce(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8440670", Offset = "0x843F870", VA = "0x188440670")]
		public void AddForceAtPosition(Vector3 LIEHHNOLAGC, Vector3 BJHAAAPCKLC, ForceMode IDGMGBABBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8440AB0", Offset = "0x843FCB0", VA = "0x188440AB0")]
		public void AddTorque(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8440950", Offset = "0x843FB50", VA = "0x188440950")]
		public void AddRelativeTorque(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8442A50", Offset = "0x8441C50", VA = "0x188442A50")]
		public Vector3 WorldToLocalVelocity(Vector3 NIBHLBJHDHN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8441970", Offset = "0x8440B70", VA = "0x188441970")]
		public Vector3 LocalToWorldVelocity(Vector3 CELELBKKFCP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8441300", Offset = "0x8440500", VA = "0x188441300")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84412A0", Offset = "0x84404A0", VA = "0x1884412A0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8441240", Offset = "0x8440440", VA = "0x188441240")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84411E0", Offset = "0x84403E0", VA = "0x1884411E0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84422E0", Offset = "0x84414E0", VA = "0x1884422E0")]
		public void ResetVelocityWorldSpace(Vector3 OEOLHIOPIKF, Vector3 FDDFJFKIJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84421E0", Offset = "0x84413E0", VA = "0x1884421E0")]
		public void ResetVelocityLocalSpace(Vector3 ACONPCMHOEF, Vector3 NHECMEGPDAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84420A0", Offset = "0x84412A0", VA = "0x1884420A0")]
		public void ResetLinearVelocityLocalSpace(Vector3 ACONPCMHOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8442880", Offset = "0x8441A80", VA = "0x188442880")]
		public bool SweepTest(Vector3 ACBMNMFGAEN, [Out] RaycastHit PIKNPKBEJMD, float BMKHJPOEOBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8441910", Offset = "0x8440B10", VA = "0x188441910")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8442810", Offset = "0x8441A10", VA = "0x188442810")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84429F0", Offset = "0x8441BF0", VA = "0x1884429F0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8440A40", Offset = "0x843FC40", VA = "0x188440A40")]
		public void AddShouldHaveUnityRigidbodyToken(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8441FC0", Offset = "0x84411C0", VA = "0x188441FC0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8440E40", Offset = "0x8440040", VA = "0x188440E40")]
		public void ApplyForceVelocityChange(FCNAHGFPEBI PPLPNFAKIBE, Vector3 LNKNHOEJOPG, float MMDBNDOLIFK, float CLNJJNGJGFF = 8f, float DPJEKAKHGMH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8440D40", Offset = "0x843FF40", VA = "0x188440D40")]
		public void ApplyAngularVelocityChange(CIDMDLJNANB CJDMOKLIONI, Vector3 FCLIKHAFLJH, float JDPMGDPHLAK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8440F00", Offset = "0x8440100", VA = "0x188440F00")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CIDMDLJNANB CJDMOKLIONI, Vector3 PANMBKPFLFA, float HLHGFNIDNBM = 7f, float KEEEAEPGIHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8440C70", Offset = "0x843FE70", VA = "0x188440C70")]
		public bool AllowedScaleChange(float PFEJJJDICMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8440BA0", Offset = "0x843FDA0", VA = "0x188440BA0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FMOFGFOJLHA, object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8442030", Offset = "0x8441230", VA = "0x188442030")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84413C0", Offset = "0x84405C0", VA = "0x1884413C0", Slot = "12")]
		private void FLADHDJOEKC(IFLFAPHLPOC OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8442BE0", Offset = "0x8441DE0", VA = "0x188442BE0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBD84B0", Offset = "0xBD76B0", VA = "0x180BD84B0", Slot = "4")]
		private GameObject PGDHLGPGNOI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1CDE0", Offset = "0xA1BFE0", VA = "0x180A1CDE0", Slot = "10")]
		private bool IPNNAEAJLGL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class DAHIILFKHFO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8434CF0", Offset = "0x8433EF0", VA = "0x188434CF0")]
	public static IOEJADJKHIM KIJPEEFIAAH(this RigidbodyEx EACFJGMBJAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LNLPLDAEGFF), new string[] { })]
public class EOHBMNENNGL : LNLPLDAEGFF, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PINFFKGFPPI OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BBGOEKIKJFL PCPLHHACHKI;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PINFFKGFPPI LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public BBGOEKIKJFL EOPKGHCCLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8439D90", Offset = "0x8438F90", VA = "0x188439D90", Slot = "7")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8439E00", Offset = "0x8439000", VA = "0x188439E00", Slot = "6")]
	public IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EOHBMNENNGL()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static JGNOJICCDHE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int CCAIBNKCLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CECJHKMIFOF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84403D0", Offset = "0x843F5D0", VA = "0x1884403D0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8440410", Offset = "0x843F610", VA = "0x188440410")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84403F0", Offset = "0x843F5F0", VA = "0x1884403F0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BDAAPBJEHGD, [Optional] UnityEngine.Object OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BDAAPBJEHGD, [Optional] UnityEngine.Object OPJOIGJBJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8440500", Offset = "0x843F700", VA = "0x188440500")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KKOILENDDPK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EJCDOHIKPJD : LNPGGOONBDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA009E0", Offset = "0x9FFBE0", VA = "0x180A009E0", Slot = "4")]
		public Vector3 BHFEFKOODAF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA009E0", Offset = "0x9FFBE0", VA = "0x180A009E0", Slot = "5")]
		public Vector3 BKCGGGIDGAO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "6")]
		public bool DMAMNAFMCPM(float GFLLOEDMCMO, float AHHFOCKIKGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EJCDOHIKPJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LNPGGOONBDB HGJNMJKIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x843B5B0", Offset = "0x843A7B0", VA = "0x18843B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DLGIPAIMENP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PCOGNLHGBKE
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
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHLPFDMACPP(bool JEJJBAALCIG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBBJJHBJMDK(bool JEJJBAALCIG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NIJKCKLHCPD(Vector3 ACBMNMFGAEN, [Out] RaycastHit PIKNPKBEJMD, float BMKHJPOEOBG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CJIHPHLLFHL : IDisposable, CLCFMGGCEKG
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PKLBDOAGHDH CKKIPNGAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MIPMLGOBAHP, MIPMLGOBAHP> HFJCODFCPBJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FONBPOKANLB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface BBGOEKIKJFL
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKFOJIEPGHF GDIAOLADMAP(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMMEGBJJKKF DIHHPKOPNIH(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAEGBEOHPOI MCEBOMPGNGC(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCKDDLCHBOL IBILNLEEHAE(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BMKJDOOBDEI NMKIOFONFFN(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CJIHPHLLFHL FNBNAMKMPDP(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IIKFLAOJBIG EEDFOJFAFDB(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EMKGODFHGBE BEHFHDEADOP(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DLGIPAIMENP BLEAIDMIEJP(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PKPLCDBICFA FDODEMLMFKM(IOEJADJKHIM AHLPFPPNCPD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GBGHMBPPLHH CEBPBGCKKNJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ECBHEFGLPIO JMKPJPACNFH(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JIOAMNOBENH ANAIOJNIFEC(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LCMOKKNJACH DLAHAMOCBHJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HIBPHBNJHFB KEHLFDPKIOJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK, FAECONBOANN DHAOEHNLNON, LNLPLDAEGFF MHGFNMBGACA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EMKGODFHGBE
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNHPBKDAHHL(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBIPFJCNLHO(Vector3 LIEHHNOLAGC, Vector3 BJHAAAPCKLC, ForceMode IDGMGBABBBG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODDCNNEBHFM(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKLADBDBBHB(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PKPLCDBICFA
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool GDBPPNLFOBF
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
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CKFOJIEPGHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<IOEJADJKHIM> KBJENBFEEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	IOEJADJKHIM ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EIGFFHGOEIP MKKMLGMNILH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EIGFFHGOEIP FGJPKDEFFGC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event KHDGNNMJLLN DPDJNLLKPGD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IJPFMGHJBFH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action KIOLBGCDPBE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<IOEJADJKHIM> FPEKDFEGPBI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<IOEJADJKHIM> FPAEKJPIPDK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action MABPJGKCNLL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<IOEJADJKHIM> EBKILBGMCON;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GDFLKEKMOMJ(IOEJADJKHIM LMLNPPNKKKE, bool JPKNJNJLHOB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NAEGBEOHPOI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CMOGEHDGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 HOPNPANBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBOKFGIMFHP(IOEJADJKHIM NJHDJGHEICO, object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNFKIJHIMKL(object PPOILDCNBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LCMOKKNJACH
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 PCJFBMFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 KOIANDHHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float NHHPNGBFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float KCAEEJECADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 FGIKKMKKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion JAACGHDJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event EIGFFHGOEIP BONEJGLJJBO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BIALOFJJKHE((Quaternion rot, Vector3 moments) LCCOOECAKAD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PELLEGGGNPC();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFOJHLOAKEF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NBFFMCPABNI();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGGOFILANBN();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JIOAMNOBENH
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOMCMFGPJLD(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKJHFKPFDEL(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMBAABBNBLK(IOEJADJKHIM EACFJGMBJAK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCDBIBAJNFP(IOEJADJKHIM EACFJGMBJAK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFOFIANHFBH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IIKFLAOJBIG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool IOIGNCIKONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EIGFFHGOEIP EDAFALFGLEC;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOAFKIMAEBB(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOAIHPMGJDP(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAPHJDIBONG(object PPOILDCNBFL, bool BJEEFLICPDC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BIMNKOIEEJG(Rigidbody CIIHNEDACOI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ECBHEFGLPIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EAJMLDDJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HCBJHJGLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EIGFFHGOEIP DFPFHJBACON;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGOMHDGNAHO(IOEJADJKHIM NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFOFAPABEPI(IOEJADJKHIM NJHDJGHEICO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HIBPHBNJHFB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CIHILCEEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JKHJNEKGJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints OCLDFLBEGCJ
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
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FCKDDLCHBOL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float HIPJLBHAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float FJJIGHIFJFM
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
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BMKJDOOBDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool DKINMGNDEDD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EIGFFHGOEIP JJLAFANPKPP;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHEGMEICAOK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPCCHLFHIEA();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AODFOMLHKAI();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KDPMNDHBKDP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKDGHONFKFN();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GIOBCAAJBMC(bool IELANCIGGMP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FEFEDEJJBJD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GBGHMBPPLHH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IMEEBJCGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKDMJAENEOD(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEGFLKADKBI(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOAMKJACGLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LMMEGBJJKKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	LNPGGOONBDB LLFMKIHDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MFLENIHFHJN LAPBMFOBBME
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LPALLCKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AMMDCCBOLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 GBGAMCCIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 LPCHJEJKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float BDHDMNIBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ECPHJGKPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FONBPOKANLB();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KDCJNHPFPJJ(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LOGJHOACDLH(CIDMDLJNANB CJDMOKLIONI, Vector3 FCLIKHAFLJH, float JDPMGDPHLAK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JFBMLFMNAON(FCNAHGFPEBI PPLPNFAKIBE, Vector3 LNKNHOEJOPG, float MMDBNDOLIFK, float CLNJJNGJGFF = 8f, float DPJEKAKHGMH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NEAPMHMINOA(CIDMDLJNANB CJDMOKLIONI, Vector3 PANMBKPFLFA, float HLHGFNIDNBM = 7f, float KEEEAEPGIHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EOCBMDGKKCN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CCMNCCFIEHH();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void POOMNEKLGFC();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FIPMIKDFOCJ();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JPJDLLDKEFD(Vector3 JONPFBFHNDO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MLFAGIACCJH(object PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HDJGNLFLNBD(Vector3 HJDDMJLLONP);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EDJIPLHEOHA(Vector3 ACONPCMHOEF, Vector3 NHECMEGPDAP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void APJAJKJBHBB(Vector3 OEOLHIOPIKF, Vector3 FDDFJFKIJPO);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GIHEBMGCAIP(Vector3 CELELBKKFCP);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OHBLLPPHBCB(Vector3 NIBHLBJHDHN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface PINFFKGFPPI
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GLGOPFOIKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPHOEMHPEEA(string KOIHEPAFBFG);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLPIICPAABE(RigidbodyEx EACFJGMBJAK, Action HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ILEMBOPEPIL EACPIHEFKOH(int NNDOJNPKHNP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEKAAIFFBLE(Vector3 NCFLDHAGLEN, float AGIAOHGHBAJ, Color EKKMKLFENBL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LNLPLDAEGFF
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PINFFKGFPPI LMBINNBIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	BBGOEKIKJFL EOPKGHCCLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CCKNPAPJHML : IOEJADJKHIM, IDisposable, DNPCLJCGFDL
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool KAACMNFBEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LNLPLDAEGFF MHGFNMBGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal CKFOJIEPGHF PGJKOLBGJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JIOAMNOBENH OICNCAEGELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ECBHEFGLPIO EMIEKNEJODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal LMMEGBJJKKF JONPFBFHNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NAEGBEOHPOI KHJFLMEILFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LCMOKKNJACH BMICFALOFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal FCKDDLCHBOL GHKFAHEIKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PKPLCDBICFA PCPOLLKKMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BMKJDOOBDEI PEHDLIBJOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal CJIHPHLLFHL JFINHPJEGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal IIKFLAOJBIG NKLPJPPMCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal EMKGODFHGBE LIEHHNOLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal HIBPHBNJHFB KBOEKFBJKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal GBGHMBPPLHH ECNEPHPGPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DLGIPAIMENP BMEIBKMHJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HOALKHMHEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool MDDOCCAMEKD;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public HAONCNNABLP NKKBBKFEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "22")]
		get
		{
			return default(HAONCNNABLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FLECLLPEPCA OPDCLENIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCDF180", Offset = "0xCDE380", VA = "0x180CDF180", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE62E80", Offset = "0xE62080", VA = "0x180E62E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject FMNMJJFPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AD0", Offset = "0x9F7CD0", VA = "0x1809F8AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE70820", Offset = "0xE6FA20", VA = "0x180E70820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8432740", Offset = "0x8431940", VA = "0x188432740", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84331B0", Offset = "0x84323B0", VA = "0x1884331B0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x84316E0", Offset = "0x84308E0", VA = "0x1884316E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int ODGEPMGANEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84336A0", Offset = "0x84328A0", VA = "0x1884336A0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public IOEJADJKHIM ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8432950", Offset = "0x8431B50", VA = "0x188432950", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool MFLKPIINKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84340E0", Offset = "0x84332E0", VA = "0x1884340E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool EAJMLDDJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8431400", Offset = "0x8430600", VA = "0x188431400", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool HCBJHJGLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8434730", Offset = "0x8433930", VA = "0x188434730", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LNPGGOONBDB LLFMKIHDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8433940", Offset = "0x8432B40", VA = "0x188433940", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8433990", Offset = "0x8432B90", VA = "0x188433990", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MFLENIHFHJN LAPBMFOBBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x842FD90", Offset = "0x842EF90", VA = "0x18842FD90", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x842E550", Offset = "0x842D750", VA = "0x18842E550", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float BDHDMNIBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8430330", Offset = "0x842F530", VA = "0x188430330", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8431880", Offset = "0x8430A80", VA = "0x188431880", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 AMMDCCBOLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x842E730", Offset = "0x842D930", VA = "0x18842E730", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x842E220", Offset = "0x842D420", VA = "0x18842E220", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 LPCHJEJKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x84317A0", Offset = "0x84309A0", VA = "0x1884317A0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8431450", Offset = "0x8430650", VA = "0x188431450", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LPALLCKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8433070", Offset = "0x8432270", VA = "0x188433070", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x842EF60", Offset = "0x842E160", VA = "0x18842EF60", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 GBGAMCCIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x842FDE0", Offset = "0x842EFE0", VA = "0x18842FDE0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8433F40", Offset = "0x8433140", VA = "0x188433F40", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool EHNMDGKDFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x842E500", Offset = "0x842D700", VA = "0x18842E500", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool AHOMCOHBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x84310C0", Offset = "0x84302C0", VA = "0x1884310C0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool HMBJJPECPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x84312D0", Offset = "0x84304D0", VA = "0x1884312D0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ECPHJGKPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8430B70", Offset = "0x842FD70", VA = "0x188430B70", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 CMOGEHDGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84337C0", Offset = "0x84329C0", VA = "0x1884337C0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 HOPNPANBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x842F180", Offset = "0x842E380", VA = "0x18842F180", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 PCJFBMFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8433310", Offset = "0x8432510", VA = "0x188433310", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x84315F0", Offset = "0x84307F0", VA = "0x1884315F0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 KOIANDHHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8432280", Offset = "0x8431480", VA = "0x188432280", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float NHHPNGBFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x842F2C0", Offset = "0x842E4C0", VA = "0x18842F2C0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float KCAEEJECADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x84300C0", Offset = "0x842F2C0", VA = "0x1884300C0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8430D50", Offset = "0x842FF50", VA = "0x188430D50", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 FGIKKMKKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x842F570", Offset = "0x842E770", VA = "0x18842F570", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion JAACGHDJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x84306C0", Offset = "0x842F8C0", VA = "0x1884306C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float HIPJLBHAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x84301C0", Offset = "0x842F3C0", VA = "0x1884301C0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x842E8F0", Offset = "0x842DAF0", VA = "0x18842E8F0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float FJJIGHIFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8433EA0", Offset = "0x84330A0", VA = "0x188433EA0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x84326E0", Offset = "0x84318E0", VA = "0x1884326E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool GDBPPNLFOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x842E810", Offset = "0x842DA10", VA = "0x18842E810", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8431D70", Offset = "0x8430F70", VA = "0x188431D70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PKLBDOAGHDH CKKIPNGAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x842EF10", Offset = "0x842E110", VA = "0x18842EF10", Slot = "70")]
		get
		{
			return default(PKLBDOAGHDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8434780", Offset = "0x8433980", VA = "0x188434780", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool IOIGNCIKONB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8430DB0", Offset = "0x842FFB0", VA = "0x188430DB0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform POKNNEEEMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 NGDJNNKBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x842E110", Offset = "0x842D310", VA = "0x18842E110", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8433890", Offset = "0x8432A90", VA = "0x188433890", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float EBHAPFBFHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8430CE0", Offset = "0x842FEE0", VA = "0x188430CE0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x842F090", Offset = "0x842E290", VA = "0x18842F090", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float BPIFKBIOOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x84316D0", Offset = "0x84308D0", VA = "0x1884316D0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x842EE10", Offset = "0x842E010", VA = "0x18842EE10", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion LPOBAHMNGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x842E690", Offset = "0x842D890", VA = "0x18842E690", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8432D00", Offset = "0x8431F00", VA = "0x188432D00", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 DPCPIKHAIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8430610", Offset = "0x842F810", VA = "0x188430610", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8430BC0", Offset = "0x842FDC0", VA = "0x188430BC0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion PKAGPKPGINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x842F650", Offset = "0x842E850", VA = "0x18842F650", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x84318E0", Offset = "0x8430AE0", VA = "0x1884318E0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints OCLDFLBEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8433EF0", Offset = "0x84330F0", VA = "0x188433EF0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8433BC0", Offset = "0x8432DC0", VA = "0x188433BC0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CIHILCEEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x84313B0", Offset = "0x84305B0", VA = "0x1884313B0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8430790", Offset = "0x842F990", VA = "0x188430790", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode PCOGNLHGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8430280", Offset = "0x842F480", VA = "0x188430280", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x84328F0", Offset = "0x8431AF0", VA = "0x1884328F0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EPJLGBHPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x842FC50", Offset = "0x842EE50", VA = "0x18842FC50", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool LOCPPNIGPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8433D20", Offset = "0x8432F20", VA = "0x188433D20", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EIGFFHGOEIP MKKMLGMNILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x842E360", Offset = "0x842D560", VA = "0x18842E360", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8430CF0", Offset = "0x842FEF0", VA = "0x188430CF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event EIGFFHGOEIP FGJPKDEFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x842F380", Offset = "0x842E580", VA = "0x18842F380", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8431590", Offset = "0x8430790", VA = "0x188431590", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event KHDGNNMJLLN DPDJNLLKPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8431740", Offset = "0x8430940", VA = "0x188431740", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8433150", Offset = "0x8432350", VA = "0x188433150", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EIGFFHGOEIP DFPFHJBACON
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x842FB00", Offset = "0x842ED00", VA = "0x18842FB00", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x842E300", Offset = "0x842D500", VA = "0x18842E300", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EIGFFHGOEIP GONDBPBAOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x842E1C0", Offset = "0x842D3C0", VA = "0x18842E1C0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x84302D0", Offset = "0x842F4D0", VA = "0x1884302D0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event EIGFFHGOEIP JJLAFANPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x842F120", Offset = "0x842E320", VA = "0x18842F120", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84329A0", Offset = "0x8431BA0", VA = "0x1884329A0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MIPMLGOBAHP, MIPMLGOBAHP> HFJCODFCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x842FAA0", Offset = "0x842ECA0", VA = "0x18842FAA0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8431DD0", Offset = "0x8430FD0", VA = "0x188431DD0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EIGFFHGOEIP EDAFALFGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8434080", Offset = "0x8433280", VA = "0x188434080", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8433B60", Offset = "0x8432D60", VA = "0x188433B60", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EIGFFHGOEIP HFKNPDAIAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8431910", Offset = "0x8430B10", VA = "0x188431910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8433710", Offset = "0x8432910", VA = "0x188433710", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8434870", Offset = "0x8433A70", VA = "0x188434870")]
	public CCKNPAPJHML(GameObject GNOLFLMODHC, RigidbodyEx GCELGGFODPP, LNLPLDAEGFF MHGFNMBGACA, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84319C0", Offset = "0x8430BC0", VA = "0x1884319C0", Slot = "139")]
	protected virtual void JCGHLPIBHHG(LNLPLDAEGFF MHGFNMBGACA, FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x842F9A0", Offset = "0x842EBA0", VA = "0x18842F9A0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x84304D0", Offset = "0x842F6D0", VA = "0x1884304D0", Slot = "93")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x842E860", Offset = "0x842DA60", VA = "0x18842E860", Slot = "94")]
	public void BPGFCOKPKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8432790", Offset = "0x8431990", VA = "0x188432790", Slot = "95")]
	public void LDFMGEFGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x84303D0", Offset = "0x842F5D0", VA = "0x1884303D0", Slot = "96")]
	public void FKEGBOAKPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x84308F0", Offset = "0x842FAF0", VA = "0x1884308F0")]
	private void GIOBCAAJBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8432870", Offset = "0x8431A70", VA = "0x188432870")]
	private void LGAADFGKHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8432CA0", Offset = "0x8431EA0", VA = "0x188432CA0")]
	private void MKDGHONFKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x84327F0", Offset = "0x84319F0", VA = "0x1884327F0", Slot = "30")]
	public IOEJADJKHIM LFDADDKHJDM(int NIBICIJAIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8430650", Offset = "0x842F850", VA = "0x188430650", Slot = "98")]
	public void GDFLKEKMOMJ(IOEJADJKHIM MLCDCHNOCFI, bool JPKNJNJLHOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x842F3E0", Offset = "0x842E5E0", VA = "0x18842F3E0", Slot = "99")]
	public void CNOAADKGBAA(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84346D0", Offset = "0x84338D0", VA = "0x1884346D0", Slot = "100")]
	public void PGMGICPELAL(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8433C20", Offset = "0x8432E20", VA = "0x188433C20", Slot = "101")]
	public Vector3 OHBLLPPHBCB(Vector3 NIBHLBJHDHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x84307F0", Offset = "0x842F9F0", VA = "0x1884307F0", Slot = "102")]
	public Vector3 GIHEBMGCAIP(Vector3 CELELBKKFCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8430380", Offset = "0x842F580", VA = "0x188430380", Slot = "103")]
	public void FIPMIKDFOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x842E950", Offset = "0x842DB50", VA = "0x18842E950", Slot = "104")]
	public void CCMNCCFIEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8430170", Offset = "0x842F370", VA = "0x188430170", Slot = "105")]
	public void EOCBMDGKKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x842E410", Offset = "0x842D610", VA = "0x18842E410", Slot = "106")]
	public void APJAJKJBHBB(Vector3 OEOLHIOPIKF, Vector3 FDDFJFKIJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x842FB60", Offset = "0x842ED60", VA = "0x18842FB60", Slot = "107")]
	public void EDJIPLHEOHA(Vector3 ACONPCMHOEF, Vector3 NHECMEGPDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8430F10", Offset = "0x8430110", VA = "0x188430F10", Slot = "108")]
	public void HDJGNLFLNBD(Vector3 HJDDMJLLONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8431CB0", Offset = "0x8430EB0", VA = "0x188431CB0", Slot = "109")]
	public void JFBMLFMNAON(FCNAHGFPEBI PPLPNFAKIBE, Vector3 LNKNHOEJOPG, float MMDBNDOLIFK, float CLNJJNGJGFF = 8f, float DPJEKAKHGMH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8432A00", Offset = "0x8431C00", VA = "0x188432A00", Slot = "110")]
	public void LOGJHOACDLH(CIDMDLJNANB CJDMOKLIONI, Vector3 FCLIKHAFLJH, float JDPMGDPHLAK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8433200", Offset = "0x8432400", VA = "0x188433200", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NEAPMHMINOA(CIDMDLJNANB CJDMOKLIONI, Vector3 PANMBKPFLFA, float HLHGFNIDNBM = 7f, float KEEEAEPGIHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8431FC0", Offset = "0x84311C0", VA = "0x188431FC0", Slot = "112")]
	public Vector3 JPJDLLDKEFD(Vector3 MLCDCHNOCFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8434140", Offset = "0x8433340", VA = "0x188434140", Slot = "113")]
	public Vector3 PDOMIDNHFOL(Vector3 MLCDCHNOCFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x84347E0", Offset = "0x84339E0", VA = "0x1884347E0", Slot = "114")]
	public void POOMNEKLGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x842F310", Offset = "0x842E510", VA = "0x18842F310", Slot = "115")]
	public void CMLLNFFMAEP(IOEJADJKHIM FMOFGFOJLHA, object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8431E80", Offset = "0x8431080", VA = "0x188431E80", Slot = "116")]
	public void JMMKHPLIFCI(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x842E5B0", Offset = "0x842D7B0", VA = "0x18842E5B0", Slot = "63")]
	public void BIALOFJJKHE((Quaternion rot, Vector3 moments) LCCOOECAKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x842F040", Offset = "0x842E240", VA = "0x18842F040", Slot = "117")]
	public void CFOJHLOAKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8434680", Offset = "0x8433880", VA = "0x188434680", Slot = "118")]
	public void PELLEGGGNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8432F10", Offset = "0x8432110", VA = "0x188432F10", Slot = "119")]
	public void NBFFMCPABNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x84320C0", Offset = "0x84312C0", VA = "0x1884320C0", Slot = "120")]
	public bool KHEGMEICAOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x842E3C0", Offset = "0x842D5C0", VA = "0x18842E3C0", Slot = "97")]
	public void AODFOMLHKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8430210", Offset = "0x842F410", VA = "0x188430210", Slot = "121")]
	public void FEFEDEJJBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8430110", Offset = "0x842F310", VA = "0x188430110", Slot = "122")]
	public void EOAFKIMAEBB(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8431270", Offset = "0x8430470", VA = "0x188431270", Slot = "123")]
	public void HOAIHPMGJDP(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8432B00", Offset = "0x8431D00", VA = "0x188432B00", Slot = "124")]
	public void MAPHJDIBONG(object PPOILDCNBFL, bool BJEEFLICPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x842FEC0", Offset = "0x842F0C0", VA = "0x18842FEC0", Slot = "125")]
	public void EGOJNHGIALK(Vector3 LKKAKBHJDDH, Quaternion IHKFAJHNMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8432B70", Offset = "0x8431D70", VA = "0x188432B70", Slot = "126")]
	public void MDELKKGDENB(Vector3 JJLEJJBGLEO, Quaternion CPBHBDHBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8431E30", Offset = "0x8431030", VA = "0x188431E30", Slot = "127")]
	public bool JIDCNDJFGCI(float PFEJJJDICMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8434020", Offset = "0x8433220", VA = "0x188434020", Slot = "128")]
	public void PCAEBMGKNEO(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x842E9A0", Offset = "0x842DBA0", VA = "0x18842E9A0", Slot = "129")]
	public void CCNFEACHLPL(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x842F260", Offset = "0x842E460", VA = "0x18842F260", Slot = "130")]
	public void CKDMJAENEOD(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8431530", Offset = "0x8430730", VA = "0x188431530", Slot = "131")]
	public void IEGFLKADKBI(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8431EE0", Offset = "0x84310E0", VA = "0x188431EE0", Slot = "132")]
	public void JNHPBKDAHHL(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8432F60", Offset = "0x8432160", VA = "0x188432F60", Slot = "133")]
	public void NBIPFJCNLHO(Vector3 LIEHHNOLAGC, Vector3 BJHAAAPCKLC, ForceMode IDGMGBABBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8433A80", Offset = "0x8432C80", VA = "0x188433A80", Slot = "134")]
	public void ODDCNNEBHFM(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8430C00", Offset = "0x842FE00", VA = "0x188430C00", Slot = "135")]
	public void GKLADBDBBHB(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x84335A0", Offset = "0x84327A0", VA = "0x1884335A0", Slot = "136")]
	public bool NIJKCKLHCPD(Vector3 ACBMNMFGAEN, [Out] RaycastHit PIKNPKBEJMD, float BMKHJPOEOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x842F760", Offset = "0x842E960", VA = "0x18842F760", Slot = "137")]
	public void DGGOFILANBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8434830", Offset = "0x8433A30", VA = "0x188434830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x84303F0", Offset = "0x842F5F0", VA = "0x1884303F0")]
	private void FMEHFAAAEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8430E00", Offset = "0x8430000", VA = "0x188430E00")]
	private void HBCAAGBFPLC(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x842F7B0", Offset = "0x842E9B0", VA = "0x18842F7B0")]
	private void DKLLDNLMPPA(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x842ED60", Offset = "0x842DF60", VA = "0x18842ED60")]
	private void CEKBAAIPLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x842F440", Offset = "0x842E640", VA = "0x18842F440")]
	private void CNOKDPFCNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x84333F0", Offset = "0x84325F0", VA = "0x1884333F0")]
	private void NIJFIDKKEMB(IOEJADJKHIM GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8430FF0", Offset = "0x84301F0", VA = "0x188430FF0")]
	private void HGOMHDGNAHO(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x842F690", Offset = "0x842E890", VA = "0x18842F690")]
	private void DFOFAPABEPI(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8431120", Offset = "0x8430320", VA = "0x188431120")]
	private void HHKHJECBEGA(FLECLLPEPCA NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8434240", Offset = "0x8433440", VA = "0x188434240", Slot = "142")]
	protected virtual void PEIMJKLEOHM(FLECLLPEPCA EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x842EA00", Offset = "0x842DC00", VA = "0x18842EA00")]
	protected void CDEKOJAONNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8432360", Offset = "0x8431560", VA = "0x188432360")]
	protected void KPOKLCABAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8432DE0", Offset = "0x8431FE0", VA = "0x188432DE0")]
	private void MKNMGHBNJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8432110", Offset = "0x8431310", VA = "0x188432110")]
	private void KJLGCOEBCFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class NLCNMEMJAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x843F440", Offset = "0x843E640", VA = "0x18843F440")]
	public static IOEJADJKHIM GLFNIAIGILD(this IOEJADJKHIM EACFJGMBJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x843F580", Offset = "0x843E780", VA = "0x18843F580")]
	public static bool NHIKHDFCKPM(this IOEJADJKHIM EACFJGMBJAK, IOEJADJKHIM BEEGJLCIAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x843F3A0", Offset = "0x843E5A0", VA = "0x18843F3A0")]
	public static bool EKGDNFHDMJB(this IOEJADJKHIM EACFJGMBJAK, IOEJADJKHIM MFCGAPDBHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x843F350", Offset = "0x843E550", VA = "0x18843F350")]
	public static FLECLLPEPCA DGACLLHLCOP(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x843F500", Offset = "0x843E700", VA = "0x18843F500")]
	public static CCKNPAPJHML LBLHJBILAJO(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JIPNDNAIEJH : BBGOEKIKJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x843B510", Offset = "0x843A710", VA = "0x18843B510", Slot = "19")]
	public IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK, FAECONBOANN DHAOEHNLNON, LNLPLDAEGFF MHGFNMBGACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "4")]
	public CKFOJIEPGHF GDIAOLADMAP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "5")]
	public LMMEGBJJKKF DIHHPKOPNIH(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
	public NAEGBEOHPOI MCEBOMPGNGC(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "7")]
	public FCKDDLCHBOL IBILNLEEHAE(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "8")]
	public BMKJDOOBDEI NMKIOFONFFN(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "9")]
	public CJIHPHLLFHL FNBNAMKMPDP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "10")]
	public IIKFLAOJBIG EEDFOJFAFDB(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "11")]
	public EMKGODFHGBE BEHFHDEADOP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "12")]
	public DLGIPAIMENP BLEAIDMIEJP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "13")]
	public PKPLCDBICFA FDODEMLMFKM(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	public GBGHMBPPLHH CEBPBGCKKNJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	public ECBHEFGLPIO JMKPJPACNFH(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	public JIOAMNOBENH ANAIOJNIFEC(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	public LCMOKKNJACH DLAHAMOCBHJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	public HIBPHBNJHFB KEHLFDPKIOJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JIPNDNAIEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "14")]
	private GBGHMBPPLHH GECHFILNBFD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "15")]
	private ECBHEFGLPIO MEANNNDJFBD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "16")]
	private JIOAMNOBENH ADLEGFBFFCJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "17")]
	private LCMOKKNJACH PIBOACIBEHB(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "18")]
	private HIBPHBNJHFB DINIGNEOKAF(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(BBGOEKIKJFL), new string[] { })]
public class AEAFBHFGJGJ : BBGOEKIKJFL, IELLFNEFJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BBGOEKIKJFL LJKLIEIACBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly BBGOEKIKJFL HDNKLDNKOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CGJALIPCGDB EEFPAKJGJLL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private BBGOEKIKJFL EOPKGHCCLJI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x842A2C0", Offset = "0x84294C0", VA = "0x18842A2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8429FD0", Offset = "0x84291D0", VA = "0x188429FD0", Slot = "20")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8429E90", Offset = "0x8429090", VA = "0x188429E90", Slot = "4")]
	public CKFOJIEPGHF GDIAOLADMAP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8429AB0", Offset = "0x8428CB0", VA = "0x188429AB0", Slot = "5")]
	public LMMEGBJJKKF DIHHPKOPNIH(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x842A220", Offset = "0x8429420", VA = "0x18842A220", Slot = "6")]
	public NAEGBEOHPOI MCEBOMPGNGC(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8429F30", Offset = "0x8429130", VA = "0x188429F30", Slot = "7")]
	public FCKDDLCHBOL IBILNLEEHAE(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x842A320", Offset = "0x8429520", VA = "0x18842A320", Slot = "8")]
	public BMKJDOOBDEI NMKIOFONFFN(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8429DF0", Offset = "0x8428FF0", VA = "0x188429DF0", Slot = "9")]
	public CJIHPHLLFHL FNBNAMKMPDP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8429CB0", Offset = "0x8428EB0", VA = "0x188429CB0", Slot = "10")]
	public IIKFLAOJBIG EEDFOJFAFDB(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x84298C0", Offset = "0x8428AC0", VA = "0x1884298C0", Slot = "11")]
	public EMKGODFHGBE BEHFHDEADOP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8429960", Offset = "0x8428B60", VA = "0x188429960", Slot = "12")]
	public DLGIPAIMENP BLEAIDMIEJP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8429D50", Offset = "0x8428F50", VA = "0x188429D50", Slot = "13")]
	public PKPLCDBICFA FDODEMLMFKM(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8429A00", Offset = "0x8428C00", VA = "0x188429A00")]
	public GBGHMBPPLHH CEBPBGCKKNJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x842A020", Offset = "0x8429220", VA = "0x18842A020")]
	public ECBHEFGLPIO JMKPJPACNFH(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8429810", Offset = "0x8428A10", VA = "0x188429810")]
	public JIOAMNOBENH ANAIOJNIFEC(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8429C00", Offset = "0x8428E00", VA = "0x188429C00")]
	public LCMOKKNJACH DLAHAMOCBHJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8429B50", Offset = "0x8428D50", VA = "0x188429B50")]
	public HIBPHBNJHFB KEHLFDPKIOJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x842A0D0", Offset = "0x84292D0", VA = "0x18842A0D0", Slot = "19")]
	public IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK, FAECONBOANN DHAOEHNLNON, LNLPLDAEGFF MHGFNMBGACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x842A3C0", Offset = "0x84295C0", VA = "0x18842A3C0")]
	public AEAFBHFGJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8429A00", Offset = "0x8428C00", VA = "0x188429A00", Slot = "14")]
	private GBGHMBPPLHH GECHFILNBFD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x842A020", Offset = "0x8429220", VA = "0x18842A020", Slot = "15")]
	private ECBHEFGLPIO MEANNNDJFBD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8429810", Offset = "0x8428A10", VA = "0x188429810", Slot = "16")]
	private JIOAMNOBENH ADLEGFBFFCJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8429C00", Offset = "0x8428E00", VA = "0x188429C00", Slot = "17")]
	private LCMOKKNJACH PIBOACIBEHB(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8429B50", Offset = "0x8428D50", VA = "0x188429B50", Slot = "18")]
	private HIBPHBNJHFB DINIGNEOKAF(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HLJIMAIKKHB : CKFOJIEPGHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPBOLFEOHNB(IOEJADJKHIM EACFJGMBJAK);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADPCOKHPOPN(IOEJADJKHIM EACFJGMBJAK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFLDOPANMDM(IOEJADJKHIM GLLHECMHDGK);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHMPECAHANH(IOEJADJKHIM GLLHECMHDGK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NIPHPBKOMEL : NAEGBEOHPOI
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CDJLKMPKJAG<IOEJADJKHIM> KHKIFIHFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	IOEJADJKHIM IMJBEMJCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FGPJMJICGND : LCMOKKNJACH
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NPKDFKNNMEE(Rigidbody INLICGPIBGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KKIPHNOPKPI : ECBHEFGLPIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView FDJCLPKDEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GEJDHEJJCDL : DLGIPAIMENP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode IPFHOMPHHKD;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x842D2E0", Offset = "0x842C4E0", VA = "0x18842D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode PCOGNLHGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x843A1F0", Offset = "0x84393F0", VA = "0x18843A1F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x843A430", Offset = "0x8439630", VA = "0x18843A430", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x842D7D0", Offset = "0x842C9D0", VA = "0x18842D7D0")]
	public GEJDHEJJCDL(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x843A300", Offset = "0x8439500", VA = "0x18843A300", Slot = "6")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x843A170", Offset = "0x8439370", VA = "0x18843A170", Slot = "9")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x843A410", Offset = "0x8439610", VA = "0x18843A410", Slot = "7")]
	public void HHLPFDMACPP(bool JEJJBAALCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x843A420", Offset = "0x8439620", VA = "0x18843A420", Slot = "8")]
	public void LBBJJHBJMDK(bool JEJJBAALCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x843A4A0", Offset = "0x84396A0", VA = "0x18843A4A0", Slot = "10")]
	public bool NIJKCKLHCPD(Vector3 ACBMNMFGAEN, [Out] RaycastHit PIKNPKBEJMD, float BMKHJPOEOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x843A050", Offset = "0x8439250", VA = "0x18843A050")]
	private void ADPBCINBFPI(bool JEJJBAALCIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ANEJBFLJJAM : CJIHPHLLFHL, IDisposable, CLCFMGGCEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private PKLBDOAGHDH EMHDCKLINAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ILEMBOPEPIL JHHLAHHFFFO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PKLBDOAGHDH CKKIPNGAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x842C340", Offset = "0x842B540", VA = "0x18842C340", Slot = "6")]
		get
		{
			return default(PKLBDOAGHDH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x842C8B0", Offset = "0x842BAB0", VA = "0x18842C8B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform OBLKBEMGCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xCC7850", Offset = "0xCC6A50", VA = "0x180CC7850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MIPMLGOBAHP, MIPMLGOBAHP> HFJCODFCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x842C4E0", Offset = "0x842B6E0", VA = "0x18842C4E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x842C800", Offset = "0x842BA00", VA = "0x18842C800", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x842C980", Offset = "0x842BB80", VA = "0x18842C980")]
	public ANEJBFLJJAM(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x842C590", Offset = "0x842B790", VA = "0x18842C590", Slot = "8")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x842C490", Offset = "0x842B690", VA = "0x18842C490", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x11C1B80", Offset = "0x11C0D80", VA = "0x1811C1B80", Slot = "11")]
	private void JDIOIHCBHLM(MIPMLGOBAHP NHBOLBJANJI, MIPMLGOBAHP GFJPEKBBFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "12")]
	private void GADALKHPFFC(bool MNPKGGBNMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MOCLEKINMPG : BBGOEKIKJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x843EC40", Offset = "0x843DE40", VA = "0x18843EC40", Slot = "4")]
	public CKFOJIEPGHF GDIAOLADMAP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x843E5F0", Offset = "0x843D7F0", VA = "0x18843E5F0", Slot = "5")]
	public LMMEGBJJKKF DIHHPKOPNIH(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x843F090", Offset = "0x843E290", VA = "0x18843F090", Slot = "6")]
	public NAEGBEOHPOI MCEBOMPGNGC(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x843ED30", Offset = "0x843DF30", VA = "0x18843ED30", Slot = "7")]
	public FCKDDLCHBOL IBILNLEEHAE(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x843F1C0", Offset = "0x843E3C0", VA = "0x18843F1C0", Slot = "8")]
	public BMKJDOOBDEI NMKIOFONFFN(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x843EB70", Offset = "0x843DD70", VA = "0x18843EB70", Slot = "9")]
	public CJIHPHLLFHL FNBNAMKMPDP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x843E990", Offset = "0x843DB90", VA = "0x18843E990", Slot = "10")]
	public IIKFLAOJBIG EEDFOJFAFDB(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x843E330", Offset = "0x843D530", VA = "0x18843E330", Slot = "11")]
	public EMKGODFHGBE BEHFHDEADOP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x843E3F0", Offset = "0x843D5F0", VA = "0x18843E3F0", Slot = "12")]
	public DLGIPAIMENP BLEAIDMIEJP(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x843EAB0", Offset = "0x843DCB0", VA = "0x18843EAB0", Slot = "13")]
	public PKPLCDBICFA FDODEMLMFKM(IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x843E4B0", Offset = "0x843D6B0", VA = "0x18843E4B0")]
	public GBGHMBPPLHH CEBPBGCKKNJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x843EDB0", Offset = "0x843DFB0", VA = "0x18843EDB0")]
	public ECBHEFGLPIO JMKPJPACNFH(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x843E200", Offset = "0x843D400", VA = "0x18843E200")]
	public JIOAMNOBENH ANAIOJNIFEC(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x843E800", Offset = "0x843DA00", VA = "0x18843E800")]
	public LCMOKKNJACH DLAHAMOCBHJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x843E720", Offset = "0x843D920", VA = "0x18843E720")]
	public HIBPHBNJHFB KEHLFDPKIOJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x843EF40", Offset = "0x843E140", VA = "0x18843EF40", Slot = "19")]
	public IOEJADJKHIM KEAACMKLNFM(RigidbodyEx EACFJGMBJAK, FAECONBOANN DHAOEHNLNON, LNLPLDAEGFF MHGFNMBGACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MOCLEKINMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x843E4B0", Offset = "0x843D6B0", VA = "0x18843E4B0", Slot = "14")]
	private GBGHMBPPLHH GECHFILNBFD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x843EDB0", Offset = "0x843DFB0", VA = "0x18843EDB0", Slot = "15")]
	private ECBHEFGLPIO MEANNNDJFBD(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x843E200", Offset = "0x843D400", VA = "0x18843E200", Slot = "16")]
	private JIOAMNOBENH ADLEGFBFFCJ(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x843E800", Offset = "0x843DA00", VA = "0x18843E800", Slot = "17")]
	private LCMOKKNJACH PIBOACIBEHB(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x843E720", Offset = "0x843D920", VA = "0x18843E720", Slot = "18")]
	private HIBPHBNJHFB DINIGNEOKAF(IOEJADJKHIM AHLPFPPNCPD, [In] FAECONBOANN DHAOEHNLNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class ANHPHAPDIFL : EMKGODFHGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x842D2E0", Offset = "0x842C4E0", VA = "0x18842D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool IOIGNCIKONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x842CED0", Offset = "0x842C0D0", VA = "0x18842CED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool MFLKPIINKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x842D770", Offset = "0x842C970", VA = "0x18842D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x842D5B0", Offset = "0x842C7B0", VA = "0x18842D5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x842D7D0", Offset = "0x842C9D0", VA = "0x18842D7D0")]
	public ANHPHAPDIFL(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x842D180", Offset = "0x842C380", VA = "0x18842D180", Slot = "4")]
	public void JNHPBKDAHHL(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x842CA10", Offset = "0x842BC10", VA = "0x18842CA10")]
	private void FACHFKDMADI(Vector3 LIEHHNOLAGC, ForceMode IDGMGBABBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x842D330", Offset = "0x842C530", VA = "0x18842D330", Slot = "5")]
	public void NBIPFJCNLHO(Vector3 LIEHHNOLAGC, Vector3 BJHAAAPCKLC, ForceMode IDGMGBABBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x842D610", Offset = "0x842C810", VA = "0x18842D610", Slot = "6")]
	public void ODDCNNEBHFM(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x842CF20", Offset = "0x842C120", VA = "0x18842CF20")]
	private void IKAJCHJKFCE(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x842CC70", Offset = "0x842BE70", VA = "0x18842CC70", Slot = "7")]
	public void GKLADBDBBHB(Vector3 NBMEFCPFMNK, ForceMode IDGMGBABBBG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class KPCGFIENNDA : PKPLCDBICFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OGKPKCCHMFE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GDBPPNLFOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x843B720", Offset = "0x843A920", VA = "0x18843B720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x842D7D0", Offset = "0x842C9D0", VA = "0x18842D7D0")]
	public KPCGFIENNDA(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x843B680", Offset = "0x843A880", VA = "0x18843B680", Slot = "6")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x843B6B0", Offset = "0x843A8B0", VA = "0x18843B6B0", Slot = "7")]
	public void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class AKDCGOBCJLJ : HLJIMAIKKHB, CKFOJIEPGHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IOEJADJKHIM EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<IOEJADJKHIM> MGLEGFEFPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private IOEJADJKHIM FHPKLENNKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private IOEJADJKHIM NJHDJGHEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform GPHOCDBOKEN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x842BD30", Offset = "0x842AF30", VA = "0x18842BD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x842B940", Offset = "0x842AB40", VA = "0x18842B940", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IOEJADJKHIM ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<IOEJADJKHIM> KBJENBFEEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EIGFFHGOEIP MKKMLGMNILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x842A510", Offset = "0x8429710", VA = "0x18842A510", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x842B580", Offset = "0x842A780", VA = "0x18842B580", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EIGFFHGOEIP FGJPKDEFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x842A8F0", Offset = "0x8429AF0", VA = "0x18842A8F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x842B8A0", Offset = "0x842AAA0", VA = "0x18842B8A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KHDGNNMJLLN DPDJNLLKPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x842B950", Offset = "0x842AB50", VA = "0x18842B950", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x842BF50", Offset = "0x842B150", VA = "0x18842BF50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IJPFMGHJBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x842A5F0", Offset = "0x84297F0", VA = "0x18842A5F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x842B4E0", Offset = "0x842A6E0", VA = "0x18842B4E0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action KIOLBGCDPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x842BBF0", Offset = "0x842ADF0", VA = "0x18842BBF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x842BC90", Offset = "0x842AE90", VA = "0x18842BC90", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<IOEJADJKHIM> FPEKDFEGPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x842ADF0", Offset = "0x8429FF0", VA = "0x18842ADF0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x842C1D0", Offset = "0x842B3D0", VA = "0x18842C1D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<IOEJADJKHIM> FPAEKJPIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x842ACA0", Offset = "0x8429EA0", VA = "0x18842ACA0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x842BA90", Offset = "0x842AC90", VA = "0x18842BA90", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action MABPJGKCNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x842BFF0", Offset = "0x842B1F0", VA = "0x18842BFF0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x842B9F0", Offset = "0x842ABF0", VA = "0x18842B9F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<IOEJADJKHIM> EBKILBGMCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x842BB40", Offset = "0x842AD40", VA = "0x18842BB40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x842BEA0", Offset = "0x842B0A0", VA = "0x18842BEA0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x842C280", Offset = "0x842B480", VA = "0x18842C280")]
	public AKDCGOBCJLJ(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x842AD50", Offset = "0x8429F50", VA = "0x18842AD50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x842AF60", Offset = "0x842A160", VA = "0x18842AF60", Slot = "30")]
	public void GDFLKEKMOMJ(IOEJADJKHIM LMLNPPNKKKE, bool JPKNJNJLHOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x842AA30", Offset = "0x8429C30", VA = "0x18842AA30", Slot = "6")]
	public void DFLDOPANMDM(IOEJADJKHIM GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x842B620", Offset = "0x842A820", VA = "0x18842B620", Slot = "7")]
	public void HHMPECAHANH(IOEJADJKHIM GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x842BD90", Offset = "0x842AF90", VA = "0x18842BD90", Slot = "4")]
	public void LPBOLFEOHNB(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x842A470", Offset = "0x8429670", VA = "0x18842A470", Slot = "5")]
	public void ADPCOKHPOPN(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x842A990", Offset = "0x8429B90", VA = "0x18842A990")]
	private void DCOMMAACKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x842A5B0", Offset = "0x84297B0", VA = "0x18842A5B0")]
	private void APBPCDAAEGH(IOEJADJKHIM GLLHECMHDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x842C090", Offset = "0x842B290", VA = "0x18842C090")]
	private void OFHNELPJBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x842A7C0", Offset = "0x84299C0", VA = "0x18842A7C0")]
	private void CLDPMJJCABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x842A690", Offset = "0x8429890", VA = "0x18842A690")]
	private void CKCAAGIAGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x842AEA0", Offset = "0x842A0A0", VA = "0x18842AEA0")]
	[CompilerGenerated]
	private object FNMEOBMDGBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CNEJCKGNCGE
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8434C30", Offset = "0x8433E30", VA = "0x188434C30")]
	public static HLJIMAIKKHB GAFOONPBFLA(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DCEGJPNEMLF : NIPHPBKOMEL, NAEGBEOHPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CDJLKMPKJAG<IOEJADJKHIM> EOEPBIPEFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool IICJKJMFPFE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CDJLKMPKJAG<IOEJADJKHIM> KHKIFIHFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CMOGEHDGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8435530", Offset = "0x8434730", VA = "0x188435530", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 HOPNPANBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8435100", Offset = "0x8434300", VA = "0x188435100", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LPALLCKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8435440", Offset = "0x8434640", VA = "0x188435440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IOEJADJKHIM IMJBEMJCDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8435390", Offset = "0x8434590", VA = "0x188435390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x84358F0", Offset = "0x8434AF0", VA = "0x1884358F0")]
	public DCEGJPNEMLF(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x84352C0", Offset = "0x84344C0", VA = "0x1884352C0", Slot = "8")]
	public void JBOKFGIMFHP(IOEJADJKHIM NJHDJGHEICO, object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8435330", Offset = "0x8434530", VA = "0x188435330", Slot = "9")]
	public void JNFKIJHIMKL(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8434D60", Offset = "0x8433F60", VA = "0x188434D60")]
	private Vector3 AEEAIHKHBKF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8435560", Offset = "0x8434760", VA = "0x188435560")]
	private void PNELDFKFJKJ(IOEJADJKHIM COICIHEGHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class OLAFPJLGGGB
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8440310", Offset = "0x843F510", VA = "0x188440310")]
	public static NIPHPBKOMEL LNFHFLAMIEA(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LDAIFNLNPLM : FGPJMJICGND, LCMOKKNJACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 FMDFCPBCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 NIFOKABFMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float ICNFBBBPHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float HPBMAOGLCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KIKAAPHKOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? CHDEGPGGKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? MACGMLFPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool IAGAOFABEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool EGBMOPDFJNF;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 PCJFBMFFBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x162FF30", Offset = "0x162F130", VA = "0x18162FF30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x843CA20", Offset = "0x843BC20", VA = "0x18843CA20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 KOIANDHHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x843CCB0", Offset = "0x843BEB0", VA = "0x18843CCB0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float NHHPNGBFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCEB7F0", Offset = "0xCEA9F0", VA = "0x180CEB7F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x843C6E0", Offset = "0x843B8E0", VA = "0x18843C6E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float KCAEEJECADE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC079B0", Offset = "0xC06BB0", VA = "0x180C079B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x843C970", Offset = "0x843BB70", VA = "0x18843C970", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 FGIKKMKKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x843BEA0", Offset = "0x843B0A0", VA = "0x18843BEA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion JAACGHDJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x843C7F0", Offset = "0x843B9F0", VA = "0x18843C7F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x84361E0", Offset = "0x84353E0", VA = "0x1884361E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EIGFFHGOEIP BONEJGLJJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x843B830", Offset = "0x843AA30", VA = "0x18843B830", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x843C640", Offset = "0x843B840", VA = "0x18843C640", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x843DF90", Offset = "0x843D190", VA = "0x18843DF90")]
	public LDAIFNLNPLM(IOEJADJKHIM EACFJGMBJAK, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x843BD80", Offset = "0x843AF80", VA = "0x18843BD80", Slot = "17")]
	public void CFOJHLOAKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x843DDC0", Offset = "0x843CFC0", VA = "0x18843DDC0", Slot = "16")]
	public void PELLEGGGNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x843BB00", Offset = "0x843AD00", VA = "0x18843BB00", Slot = "19")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x843CAD0", Offset = "0x843BCD0", VA = "0x18843CAD0", Slot = "20")]
	public void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x843CDA0", Offset = "0x843BFA0", VA = "0x18843CDA0", Slot = "18")]
	public void NBFFMCPABNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x843C030", Offset = "0x843B230", VA = "0x18843C030", Slot = "21")]
	public void DGGOFILANBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x843CA20", Offset = "0x843BC20", VA = "0x18843CA20")]
	private void MNDGCFCPKFN(Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x843DEA0", Offset = "0x843D0A0", VA = "0x18843DEA0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 POBEOEIMPHM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x843C6E0", Offset = "0x843B8E0", VA = "0x18843C6E0")]
	private void HDIGGOCGNFM(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x843C970", Offset = "0x843BB70", VA = "0x18843C970")]
	private void GHMOIBHMFPF(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x843BBE0", Offset = "0x843ADE0", VA = "0x18843BBE0")]
	private Vector3 CBLFFPBLPOO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x843B8D0", Offset = "0x843AAD0", VA = "0x18843B8D0", Slot = "15")]
	public void BIALOFJJKHE((Quaternion rot, Vector3 moments) LCCOOECAKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x843C4C0", Offset = "0x843B6C0", VA = "0x18843C4C0")]
	private Quaternion DGOIHDFPCBD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x843DCF0", Offset = "0x843CEF0", VA = "0x18843DCF0")]
	public void NPKDFKNNMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x843CF50", Offset = "0x843C150", VA = "0x18843CF50", Slot = "4")]
	public (float, Vector3) NPKDFKNNMEE(Rigidbody INLICGPIBGJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class NBPJNCHOBCJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x843F290", Offset = "0x843E490", VA = "0x18843F290")]
	public static FGPJMJICGND FNHIICEKNMP(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class GJKPMNKEMOJ : JIOAMNOBENH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IHHCNLCAMGC BNLHEALIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IAGAFLNEHEJ IFBOOMJGNNP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool EEDADPBLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x17D3DE0", Offset = "0x17D2FE0", VA = "0x1817D3DE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IAGAFLNEHEJ LLEGIEGKNBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "11")]
		get
		{
			return default(IAGAFLNEHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x843AC10", Offset = "0x8439E10", VA = "0x18843AC10")]
	public GJKPMNKEMOJ(IOEJADJKHIM EACFJGMBJAK, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x843A9D0", Offset = "0x8439BD0", VA = "0x18843A9D0", Slot = "4")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x843A820", Offset = "0x8439A20", VA = "0x18843A820")]
	private bool FLBMKPBGNAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x843A7F0", Offset = "0x84399F0", VA = "0x18843A7F0", Slot = "5")]
	public void EOMCMFGPJLD(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x843A600", Offset = "0x8439800", VA = "0x18843A600", Slot = "6")]
	public void AKJHFKPFDEL(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x843AAA0", Offset = "0x8439CA0", VA = "0x18843AAA0", Slot = "9")]
	public void JFOFIANHFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x843A8C0", Offset = "0x8439AC0", VA = "0x18843A8C0")]
	private void FLHIOFKKFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x843A670", Offset = "0x8439870", VA = "0x18843A670")]
	private void EEJMAIIDPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x843A630", Offset = "0x8439830", VA = "0x18843A630", Slot = "8")]
	public void DCDBIBAJNFP(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x843ABD0", Offset = "0x8439DD0", VA = "0x18843ABD0", Slot = "7")]
	public void MMBAABBNBLK(IOEJADJKHIM EACFJGMBJAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IACANCJMLIA : IIKFLAOJBIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IHHCNLCAMGC ODIFNCMPLCF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool IOIGNCIKONB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x843B0A0", Offset = "0x843A2A0", VA = "0x18843B0A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EIGFFHGOEIP EDAFALFGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x843B380", Offset = "0x843A580", VA = "0x18843B380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x843B2E0", Offset = "0x843A4E0", VA = "0x18843B2E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x843B420", Offset = "0x843A620", VA = "0x18843B420")]
	public IACANCJMLIA(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x843B090", Offset = "0x843A290", VA = "0x18843B090", Slot = "7")]
	public void EOAFKIMAEBB(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x843B150", Offset = "0x843A350", VA = "0x18843B150", Slot = "8")]
	public void HOAIHPMGJDP(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x843B1D0", Offset = "0x843A3D0", VA = "0x18843B1D0", Slot = "9")]
	public void MAPHJDIBONG(object PPOILDCNBFL, bool BJEEFLICPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x843B190", Offset = "0x843A390", VA = "0x18843B190", Slot = "12")]
	public void KMMPNDLEJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x843B010", Offset = "0x843A210", VA = "0x18843B010", Slot = "10")]
	public void BIMNKOIEEJG(Rigidbody CIIHNEDACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x843B160", Offset = "0x843A360", VA = "0x18843B160", Slot = "11")]
	public void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OEIFBLBBKCC : KKIPHNOPKPI, ECBHEFGLPIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView EADLIFECOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HOCAKDGEPCC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView FDJCLPKDEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool EAJMLDDJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x843FDC0", Offset = "0x843EFC0", VA = "0x18843FDC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HCBJHJGLDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EIGFFHGOEIP DFPFHJBACON
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x843F930", Offset = "0x843EB30", VA = "0x18843F930", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x843F620", Offset = "0x843E820", VA = "0x18843F620", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x84401B0", Offset = "0x843F3B0", VA = "0x1884401B0")]
	public OEIFBLBBKCC(IOEJADJKHIM EACFJGMBJAK, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x843F9D0", Offset = "0x843EBD0", VA = "0x18843F9D0", Slot = "9")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x843F830", Offset = "0x843EA30", VA = "0x18843F830", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x843FC50", Offset = "0x843EE50", VA = "0x18843FC50", Slot = "10")]
	public void HGOMHDGNAHO(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x843F6C0", Offset = "0x843E8C0", VA = "0x18843F6C0", Slot = "11")]
	public void DFOFAPABEPI(IOEJADJKHIM NJHDJGHEICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x843FDD0", Offset = "0x843EFD0", VA = "0x18843FDD0")]
	private void NBPEHNKMPHO(RRNetworkView HGLJPJGOIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x843FB00", Offset = "0x843ED00", VA = "0x18843FB00")]
	private void GHCHBCCIKGE(FLECLLPEPCA FJIGCJGAHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x843FF40", Offset = "0x843F140", VA = "0x18843FF40")]
	private void ODNBINOOKFE(RRNetworkView MFFHLGGLMKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class HMBNFDGAKGG
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x843AF50", Offset = "0x843A150", VA = "0x18843AF50")]
	public static KKIPHNOPKPI ONBHMOEMJEG(this IOEJADJKHIM AHLPFPPNCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class GOLPBJPDGND : HIBPHBNJHFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints OALBEPLKKHF;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CIHILCEEJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA54630", Offset = "0xA53830", VA = "0x180A54630", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD21BB0", Offset = "0xD20DB0", VA = "0x180D21BB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JKHJNEKGJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD21D00", Offset = "0xD20F00", VA = "0x180D21D00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD224C0", Offset = "0xD216C0", VA = "0x180D224C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints OCLDFLBEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x843AD70", Offset = "0x8439F70", VA = "0x18843AD70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x843AEA0", Offset = "0x843A0A0", VA = "0x18843AEA0")]
	public GOLPBJPDGND(IOEJADJKHIM EACFJGMBJAK, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x843AD10", Offset = "0x8439F10", VA = "0x18843AD10", Slot = "9")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x843AD40", Offset = "0x8439F40", VA = "0x18843AD40", Slot = "10")]
	public void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CEPKEIEKHNI : FCKDDLCHBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IOEJADJKHIM EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float KANBCHFHAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float DNCIBLPJEBK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float HIPJLBHAJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B50", Offset = "0xEE7D50", VA = "0x180EE8B50", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x84349B0", Offset = "0x8433BB0", VA = "0x1884349B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float FJJIGHIFJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD407C0", Offset = "0xD3F9C0", VA = "0x180D407C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8434B20", Offset = "0x8433D20", VA = "0x188434B20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8434BF0", Offset = "0x8433DF0", VA = "0x188434BF0")]
	public CEPKEIEKHNI(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8434960", Offset = "0x8433B60", VA = "0x188434960", Slot = "8")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8434A80", Offset = "0x8433C80", VA = "0x188434A80", Slot = "9")]
	public void ILBJDLMCNOF(Rigidbody ECNEPHPGPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DDMDKJINBBD : BMKJDOOBDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly FODGIOKBGBI PDBKKJJKGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool AFAGNNKALLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool AKIKNODDAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int CDBJCHNNEKD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84361E0", Offset = "0x84353E0", VA = "0x1884361E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EPJLGBHPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8435B30", Offset = "0x8434D30", VA = "0x188435B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IOEJADJKHIM EKNHDPMCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x84363A0", Offset = "0x84355A0", VA = "0x1884363A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MFLKPIINKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8436400", Offset = "0x8435600", VA = "0x188436400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EIGFFHGOEIP JJLAFANPKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8435A90", Offset = "0x8434C90", VA = "0x188435A90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8436230", Offset = "0x8435430", VA = "0x188436230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8436670", Offset = "0x8435870", VA = "0x188436670")]
	public DDMDKJINBBD(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8435BF0", Offset = "0x8434DF0", VA = "0x188435BF0", Slot = "6")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x84362D0", Offset = "0x84354D0", VA = "0x1884362D0", Slot = "8")]
	public void LPCCHLFHIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8436090", Offset = "0x8435290", VA = "0x188436090", Slot = "7")]
	public bool KHEGMEICAOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x84359F0", Offset = "0x8434BF0", VA = "0x1884359F0", Slot = "9")]
	public void AODFOMLHKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8435B50", Offset = "0x8434D50", VA = "0x188435B50", Slot = "13")]
	public void FEFEDEJJBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8435F00", Offset = "0x8435100", VA = "0x188435F00", Slot = "12")]
	public void GIOBCAAJBMC(bool IELANCIGGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8436020", Offset = "0x8435220", VA = "0x188436020", Slot = "10")]
	public bool KDPMNDHBKDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x84362E0", Offset = "0x84354E0", VA = "0x1884362E0", Slot = "11")]
	public bool MKDGHONFKFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8435C80", Offset = "0x8434E80", VA = "0x188435C80")]
	private bool GHHFMJPOBPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8436460", Offset = "0x8435660", VA = "0x188436460")]
	private void PNJBLAMICNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BDKMELLOBIL : GBGHMBPPLHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IHHCNLCAMGC AECKMLICNKH;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody LGIHCHPLMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool MFLKPIINKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x842D770", Offset = "0x842C970", VA = "0x18842D770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool IMEEBJCGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x17D3DE0", Offset = "0x17D2FE0", VA = "0x1817D3DE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x842E000", Offset = "0x842D200", VA = "0x18842E000")]
	public BDKMELLOBIL(IOEJADJKHIM EACFJGMBJAK, [In] FAECONBOANN DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x842DDB0", Offset = "0x842CFB0", VA = "0x18842DDB0", Slot = "5")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x842DB90", Offset = "0x842CD90", VA = "0x18842DB90", Slot = "7")]
	public void CKDMJAENEOD(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x842DE50", Offset = "0x842D050", VA = "0x18842DE50", Slot = "8")]
	public void IEGFLKADKBI(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x842D860", Offset = "0x842CA60", VA = "0x18842D860", Slot = "9")]
	public void BOAMKJACGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x842DBC0", Offset = "0x842CDC0", VA = "0x18842DBC0", Slot = "10")]
	public void DDFDPLCKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x842DE80", Offset = "0x842D080", VA = "0x18842DE80", Slot = "11")]
	public void POANCDALDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class DGCKCAPIAEB : LMMEGBJJKKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CCKNPAPJHML EACFJGMBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IHHCNLCAMGC NFNBECNIJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float MJCECBELNNP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LNPGGOONBDB LLFMKIHDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MFLENIHFHJN LAPBMFOBBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LPALLCKFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x84392A0", Offset = "0x84384A0", VA = "0x1884392A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8436D40", Offset = "0x8435F40", VA = "0x188436D40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AMMDCCBOLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8436BC0", Offset = "0x8435DC0", VA = "0x188436BC0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8436700", Offset = "0x8435900", VA = "0x188436700", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 GBGAMCCIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8437480", Offset = "0x8436680", VA = "0x188437480", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8439A50", Offset = "0x8438C50", VA = "0x188439A50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 LPCHJEJKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8437B10", Offset = "0x8436D10", VA = "0x188437B10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8437AE0", Offset = "0x8436CE0", VA = "0x188437AE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float BDHDMNIBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEEC4A0", Offset = "0xEEB6A0", VA = "0x180EEC4A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8437C30", Offset = "0x8436E30", VA = "0x188437C30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ECPHJGKPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x210C080", Offset = "0x210B280", VA = "0x18210C080", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private EMKGODFHGBE ALNOMIGNLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F940", Offset = "0x7A2EB40", VA = "0x187A2F940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool EPJLGBHPMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8437460", Offset = "0x8436660", VA = "0x188437460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8439CA0", Offset = "0x8438EA0", VA = "0x188439CA0")]
	public DGCKCAPIAEB(IOEJADJKHIM EACFJGMBJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8437630", Offset = "0x8436830", VA = "0x188437630", Slot = "19")]
	public void FONBPOKANLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x84373A0", Offset = "0x84365A0", VA = "0x1884373A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8436970", Offset = "0x8435B70", VA = "0x188436970", Slot = "28")]
	public void BIMNKOIEEJG(Rigidbody ECNEPHPGPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x15E68C0", Offset = "0x15E5AC0", VA = "0x1815E68C0", Slot = "20")]
	public void KDCJNHPFPJJ(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x15E68E0", Offset = "0x15E5AE0", VA = "0x1815E68E0", Slot = "30")]
	public void MLFAGIACCJH(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8439870", Offset = "0x8438A70", VA = "0x188439870", Slot = "35")]
	public Vector3 OHBLLPPHBCB(Vector3 NIBHLBJHDHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8437780", Offset = "0x8436980", VA = "0x188437780", Slot = "34")]
	public Vector3 GIHEBMGCAIP(Vector3 CELELBKKFCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8437630", Offset = "0x8436830", VA = "0x188437630", Slot = "27")]
	public void FIPMIKDFOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8436CE0", Offset = "0x8435EE0", VA = "0x188436CE0", Slot = "25")]
	public void CCMNCCFIEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x84375D0", Offset = "0x84367D0", VA = "0x1884375D0", Slot = "24")]
	public void EOCBMDGKKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8436730", Offset = "0x8435930", VA = "0x188436730", Slot = "33")]
	public void APJAJKJBHBB(Vector3 OEOLHIOPIKF, Vector3 FDDFJFKIJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8437400", Offset = "0x8436600", VA = "0x188437400", Slot = "32")]
	public void EDJIPLHEOHA(Vector3 ACONPCMHOEF, Vector3 NHECMEGPDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8437940", Offset = "0x8436B40", VA = "0x188437940", Slot = "31")]
	public void HDJGNLFLNBD(Vector3 HJDDMJLLONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8437EE0", Offset = "0x84370E0", VA = "0x188437EE0", Slot = "22")]
	public void JFBMLFMNAON(FCNAHGFPEBI PPLPNFAKIBE, Vector3 LNKNHOEJOPG, float MMDBNDOLIFK, float CLNJJNGJGFF = 8f, float DPJEKAKHGMH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8438BA0", Offset = "0x8437DA0", VA = "0x188438BA0", Slot = "21")]
	public void LOGJHOACDLH(CIDMDLJNANB CJDMOKLIONI, Vector3 FCLIKHAFLJH, float JDPMGDPHLAK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x84393F0", Offset = "0x84385F0", VA = "0x1884393F0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NEAPMHMINOA(CIDMDLJNANB CJDMOKLIONI, Vector3 PANMBKPFLFA, float HLHGFNIDNBM = 7f, float KEEEAEPGIHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x171F580", Offset = "0x171E780", VA = "0x18171F580")]
	private static void PFGBNBHPHMJ(Vector3 JONPFBFHNDO, Vector3 PLEIILPBIGD, [Out] Vector3 MGPDEAJKGEM, [Out] Vector3 LOLLANPLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x84389B0", Offset = "0x8437BB0", VA = "0x1884389B0", Slot = "29")]
	public Vector3 JPJDLLDKEFD(Vector3 JONPFBFHNDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8439B10", Offset = "0x8438D10", VA = "0x188439B10", Slot = "26")]
	public void POOMNEKLGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8437C30", Offset = "0x8436E30", VA = "0x188437C30")]
	private void OGEPEKCOFGG(float MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8437D40", Offset = "0x8436F40", VA = "0x188437D40")]
	private void INFHMJJGEDI(Vector3 FCLIKHAFLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8438A90", Offset = "0x8437C90", VA = "0x188438A90")]
	private Vector3 LDIAKHBNPFN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8438530", Offset = "0x8437730", VA = "0x188438530")]
	private void JGEALHCMAJN(Vector3 CELELBKKFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8436AA0", Offset = "0x8435CA0", VA = "0x188436AA0")]
	private Vector3 BKCGGGIDGAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8438E20", Offset = "0x8438020", VA = "0x188438E20")]
	private void MCEKKFADGAI(Vector3 MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8436E00", Offset = "0x8436000", VA = "0x188436E00")]
	private void DDBBHCCNDNC(Vector3 CELELBKKFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x84376D0", Offset = "0x84368D0", VA = "0x1884376D0")]
	private void FJAEBJCNCPK()
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
