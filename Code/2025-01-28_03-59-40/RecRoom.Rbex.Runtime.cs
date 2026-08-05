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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x790CE80", Offset = "0x790C080", VA = "0x18790CE80", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0C10", Offset = "0x1DDFE10", VA = "0x181DE0C10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79132E0", Offset = "0x79124E0", VA = "0x1879132E0")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79135E0", Offset = "0x79127E0", VA = "0x1879135E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7913640", Offset = "0x7912840", VA = "0x187913640")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, ELOCKNMGHMD, ONOIHDMEOKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly KJMCEDJMPPA BOCPNNMBNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool NFFHJNHELNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GPODHFNGINM IJOKMENMKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HMLBDBMBBPE(FFILGMALDDB.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HMLBDBMBBPE(FFILGMALDDB.SelfAndParent, true, false, false)]
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
		private DCBINGCLJFB physicsInterpolation;

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
		private Transform FGKHLIDOOPC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GPODHFNGINM ONHFMDHDOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x790F3A0", Offset = "0x790E5A0", VA = "0x18790F3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GPODHFNGINM EBNNLHOLBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PFBNKEEHFCP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x79107F0", Offset = "0x790F9F0", VA = "0x1879107F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NHDEDFCDPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7910B50", Offset = "0x790FD50", VA = "0x187910B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KMOBICEOLNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7910A90", Offset = "0x790FC90", VA = "0x187910A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DBEHKFODEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7911750", Offset = "0x7910950", VA = "0x187911750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7912C50", Offset = "0x7911E50", VA = "0x187912C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AJJHDKJICFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x78D8F40", Offset = "0x78D8140", VA = "0x1878D8F40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x78D7D40", Offset = "0x78D6F40", VA = "0x1878D7D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MCPAEAAAAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x10EB070", Offset = "0x10EA270", VA = "0x1810EB070", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform BMEIOJFGCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x10EB070", Offset = "0x10EA270", VA = "0x1810EB070", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform JGFGNIJOCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x10EB070", Offset = "0x10EA270", VA = "0x1810EB070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NEGICDPELDL FHNLLHPDPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7910850", Offset = "0x790FA50", VA = "0x187910850")]
			get
			{
				return default(NEGICDPELDL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7912400", Offset = "0x7911600", VA = "0x187912400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CDGJNGKBODD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7910E60", Offset = "0x7910060", VA = "0x187910E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NGMOEHIJKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7910970", Offset = "0x790FB70", VA = "0x187910970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NBAEIOPIALM ANCCMGOONMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7910DA0", Offset = "0x790FFA0", VA = "0x187910DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x79125C0", Offset = "0x79117C0", VA = "0x1879125C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PPIGDFPOOHP BHIKJHJICOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7910D40", Offset = "0x790FF40", VA = "0x187910D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7912550", Offset = "0x7911750", VA = "0x187912550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ABPMBIIOFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7910C90", Offset = "0x790FE90", VA = "0x187910C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody CBOGJJMPNFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7910CF0", Offset = "0x790FEF0", VA = "0x187910CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HKGLPHFJHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x79109D0", Offset = "0x790FBD0", VA = "0x1879109D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7912470", Offset = "0x7911670", VA = "0x187912470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MOILGINCIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x75BB640", Offset = "0x75BA840", VA = "0x1875BB640", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BDJPIEGPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x79116F0", Offset = "0x79108F0", VA = "0x1879116F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GOGOOMKLMHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7911690", Offset = "0x7910890", VA = "0x187911690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7912BE0", Offset = "0x7911DE0", VA = "0x187912BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PLJIBPHCHLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x79110C0", Offset = "0x79102C0", VA = "0x1879110C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7912860", Offset = "0x7911A60", VA = "0x187912860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PJDGNNPGGJH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7910EC0", Offset = "0x79100C0", VA = "0x187910EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7912630", Offset = "0x7911830", VA = "0x187912630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KKMCCHCGBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7911CA0", Offset = "0x7910EA0", VA = "0x187911CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7913190", Offset = "0x7912390", VA = "0x187913190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 LLIIAJAIFDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7911470", Offset = "0x7910670", VA = "0x187911470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x79129B0", Offset = "0x7911BB0", VA = "0x1879129B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 ALKLDEOFNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7911DE0", Offset = "0x7910FE0", VA = "0x187911DE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode HABINDHFJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7911000", Offset = "0x7910200", VA = "0x187911000")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7912780", Offset = "0x7911980", VA = "0x187912780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float DDDMPMDMEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7910A30", Offset = "0x790FC30", VA = "0x187910A30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79124E0", Offset = "0x79116E0", VA = "0x1879124E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints AOGKGEKOLBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7911060", Offset = "0x7910260", VA = "0x187911060")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x79127F0", Offset = "0x79119F0", VA = "0x1879127F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FNNCDNCLDAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7911810", Offset = "0x7910A10", VA = "0x187911810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 CMABMBNOHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7911810", Offset = "0x7910A10", VA = "0x187911810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7912F70", Offset = "0x7912170", VA = "0x187912F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float KCJANBMNMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7911550", Offset = "0x7910750", VA = "0x187911550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7912A90", Offset = "0x7911C90", VA = "0x187912A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HPGIIFMOPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7911C40", Offset = "0x7910E40", VA = "0x187911C40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7913120", Offset = "0x7912320", VA = "0x187913120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PNNNBIGCLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x79118F0", Offset = "0x7910AF0", VA = "0x1879118F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7912CF0", Offset = "0x7911EF0", VA = "0x187912CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GBCIPCKNBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7911B70", Offset = "0x7910D70", VA = "0x187911B70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7913050", Offset = "0x7912250", VA = "0x187913050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EIDFPHBFBFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x79119C0", Offset = "0x7910BC0", VA = "0x1879119C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7912DC0", Offset = "0x7911FC0", VA = "0x187912DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BEAMMKLPHMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7911AA0", Offset = "0x7910CA0", VA = "0x187911AA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7912EA0", Offset = "0x79120A0", VA = "0x187912EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BEIJOKHFPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7911D00", Offset = "0x7910F00", VA = "0x187911D00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7913200", Offset = "0x7912400", VA = "0x187913200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BDFPPBAJEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x79115B0", Offset = "0x79107B0", VA = "0x1879115B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7912B00", Offset = "0x7911D00", VA = "0x187912B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HGECGPDEJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7910F20", Offset = "0x7910120", VA = "0x187910F20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x79126A0", Offset = "0x79118A0", VA = "0x1879126A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 EDPKEMKJOLD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7911390", Offset = "0x7910590", VA = "0x187911390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x79128D0", Offset = "0x7911AD0", VA = "0x1879128D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FIGDPMEJCDO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7911250", Offset = "0x7910450", VA = "0x187911250")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion CKFDGHNJDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7911180", Offset = "0x7910380", VA = "0x187911180")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EBEFGEGHEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7911FA0", Offset = "0x79111A0", VA = "0x187911FA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 NJEFJCLJCDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7911EC0", Offset = "0x79110C0", VA = "0x187911EC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GCHPMODOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7911330", Offset = "0x7910530", VA = "0x187911330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool FCCELNGFEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7910E00", Offset = "0x7910000", VA = "0x187910E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CGFDNHECKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7910910", Offset = "0x790FB10", VA = "0x187910910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FPGBADHJKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x79108B0", Offset = "0x790FAB0", VA = "0x1879108B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool IOKBCEGNDNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7910790", Offset = "0x790F990", VA = "0x187910790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool NODEAOEMKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7911120", Offset = "0x7910320", VA = "0x187911120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EHPNJBGMJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x209C980", Offset = "0x209BB80", VA = "0x18209C980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PEPIOKEAOLL KHFAOOOMEEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x79106B0", Offset = "0x790F8B0", VA = "0x1879106B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7912320", Offset = "0x7911520", VA = "0x187912320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KDJOAOJNEEJ FFIJIDFLGGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7910420", Offset = "0x790F620", VA = "0x187910420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7912080", Offset = "0x7911280", VA = "0x187912080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KDJOAOJNEEJ MJIPJIICMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7910480", Offset = "0x790F680", VA = "0x187910480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x79120F0", Offset = "0x79112F0", VA = "0x1879120F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KDJOAOJNEEJ IKJIFBALHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x79105D0", Offset = "0x790F7D0", VA = "0x1879105D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7912240", Offset = "0x7911440", VA = "0x187912240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MICCOKKHGKO, MICCOKKHGKO> CCLEFPPHOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7910560", Offset = "0x790F760", VA = "0x187910560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x79121D0", Offset = "0x79113D0", VA = "0x1879121D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event KDJOAOJNEEJ MIBNEPBGGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7910640", Offset = "0x790F840", VA = "0x187910640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x79122B0", Offset = "0x79114B0", VA = "0x1879122B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KDJOAOJNEEJ LCKHNDAACNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7910720", Offset = "0x790F920", VA = "0x187910720")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7912390", Offset = "0x7911590", VA = "0x187912390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KDJOAOJNEEJ GECOOCJHPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x79104F0", Offset = "0x790F6F0", VA = "0x1879104F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7912160", Offset = "0x7911360", VA = "0x187912160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490", Slot = "8")]
		private void IJHLLNOCCJJ(GPODHFNGINM CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x790EAE0", Offset = "0x790DCE0", VA = "0x18790EAE0")]
		internal void GKJEHPODBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7910140", Offset = "0x790F340", VA = "0x187910140")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody GJKFPPGHDPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x790EB70", Offset = "0x790DD70", VA = "0x18790EB70")]
		public ELOCKNMGHMD GetChild(int CPLNODNGKGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x790FDA0", Offset = "0x790EFA0", VA = "0x18790FDA0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MKOKFACDBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x790E890", Offset = "0x790DA90", VA = "0x18790E890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7910030", Offset = "0x790F230", VA = "0x187910030")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x790F3A0", Offset = "0x790E5A0", VA = "0x18790F3A0")]
		private GPODHFNGINM NEDLNHLCCBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x790F190", Offset = "0x790E390", VA = "0x18790F190")]
		private void MDPAGNEJHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x790F570", Offset = "0x790E770", VA = "0x18790F570")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x790F4B0", Offset = "0x790E6B0", VA = "0x18790F4B0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x790EAE0", Offset = "0x790DCE0", VA = "0x18790EAE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x790F510", Offset = "0x790E710", VA = "0x18790F510")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x790F5D0", Offset = "0x790E7D0", VA = "0x18790F5D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x790DE80", Offset = "0x790D080", VA = "0x18790DE80")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x790F630", Offset = "0x790E830", VA = "0x18790F630")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x790EA80", Offset = "0x790DC80", VA = "0x18790EA80")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x790F450", Offset = "0x790E650", VA = "0x18790F450")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x790FF00", Offset = "0x790F100", VA = "0x18790FF00")]
		public void SetParent(RigidbodyEx OMEFCJCOLII, bool OAPIJHCEDGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x790F940", Offset = "0x790EB40", VA = "0x18790F940")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x790EE20", Offset = "0x790E020", VA = "0x18790EE20")]
		public bool IsRigidbodyAncestor(RigidbodyEx EGEKCOILHLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x790EF20", Offset = "0x790E120", VA = "0x18790EF20")]
		public bool IsRigidbodyDescendant(RigidbodyEx AKBBBDGIJIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x790E0F0", Offset = "0x790D2F0", VA = "0x18790E0F0")]
		public void AddInterpolationRestriction(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x790F6A0", Offset = "0x790E8A0", VA = "0x18790F6A0")]
		public void RemoveInterpolationRestriction(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x790E160", Offset = "0x790D360", VA = "0x18790E160")]
		public void AddKinematic(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x790F710", Offset = "0x790E910", VA = "0x18790F710")]
		public void RemoveKinematic(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x790FE80", Offset = "0x790F080", VA = "0x18790FE80")]
		public void SetKinematic(object BCOHKLCJCPM, bool EEJHBJOAMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x790FCA0", Offset = "0x790EEA0", VA = "0x18790FCA0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EBFOEOCLHGJ, Quaternion MFCDNHAADAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x790FBA0", Offset = "0x790EDA0", VA = "0x18790FBA0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 DKEJLDLNJBE, Quaternion GFIIPINEBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x790ED10", Offset = "0x790DF10", VA = "0x18790ED10")]
		public Vector3 GetConstrainedVelocity(Vector3 BEIJOKHFPBB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x790EC00", Offset = "0x790DE00", VA = "0x18790EC00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HGECGPDEJMF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x790E000", Offset = "0x790D200", VA = "0x18790E000")]
		public void AddForce(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x790DEF0", Offset = "0x790D0F0", VA = "0x18790DEF0")]
		public void AddForceAtPosition(Vector3 DCOODACAFGM, Vector3 FCKJMOMOHAE, ForceMode POEIPILMDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x790E330", Offset = "0x790D530", VA = "0x18790E330")]
		public void AddTorque(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x790E1D0", Offset = "0x790D3D0", VA = "0x18790E1D0")]
		public void AddRelativeTorque(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7910210", Offset = "0x790F410", VA = "0x187910210")]
		public Vector3 WorldToLocalVelocity(Vector3 OBJBFFGONOB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x790F080", Offset = "0x790E280", VA = "0x18790F080")]
		public Vector3 LocalToWorldVelocity(Vector3 BDFPPBAJEKP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x790EA20", Offset = "0x790DC20", VA = "0x18790EA20")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x790E9C0", Offset = "0x790DBC0", VA = "0x18790E9C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x790E960", Offset = "0x790DB60", VA = "0x18790E960")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x790E900", Offset = "0x790DB00", VA = "0x18790E900")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x790FAA0", Offset = "0x790ECA0", VA = "0x18790FAA0")]
		public void ResetVelocityWorldSpace(Vector3 DDEHOJMJKFE, Vector3 PBACHNIDMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x790F9A0", Offset = "0x790EBA0", VA = "0x18790F9A0")]
		public void ResetVelocityLocalSpace(Vector3 MNIOOCMEKFF, Vector3 EDPKEMKJOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x790F860", Offset = "0x790EA60", VA = "0x18790F860")]
		public void ResetLinearVelocityLocalSpace(Vector3 MNIOOCMEKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7910040", Offset = "0x790F240", VA = "0x187910040")]
		public bool SweepTest(Vector3 BDIPLNMOFCC, [Out] RaycastHit FIAPOMAPPID, float ABBGAHJHLCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x790F020", Offset = "0x790E220", VA = "0x18790F020")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x790FFD0", Offset = "0x790F1D0", VA = "0x18790FFD0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79101B0", Offset = "0x790F3B0", VA = "0x1879101B0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x790E2C0", Offset = "0x790D4C0", VA = "0x18790E2C0")]
		public void AddShouldHaveUnityRigidbodyToken(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x790F780", Offset = "0x790E980", VA = "0x18790F780")]
		public void RemoveShouldHaveUnityRigidbodyToken(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x790E6C0", Offset = "0x790D8C0", VA = "0x18790E6C0")]
		public void ApplyForceVelocityChange(BCFMLJKNNCD DJDEEKAABAM, Vector3 AFILDHPCPMP, float APGCJNOHJED, float MJCEINCCACJ = 8f, float JCCODJMCPLL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x790E5C0", Offset = "0x790D7C0", VA = "0x18790E5C0")]
		public void ApplyAngularVelocityChange(IEAEOEGIAFO PAKJIFKAIDO, Vector3 IBABFPJEHLF, float CJDFGFLAADO = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x790E780", Offset = "0x790D980", VA = "0x18790E780")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IEAEOEGIAFO PAKJIFKAIDO, Vector3 EGIHDGHICMO, float ECJPGOHLCGO = 7f, float KJLDKEIPCJB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x790E4F0", Offset = "0x790D6F0", VA = "0x18790E4F0")]
		public bool AllowedScaleChange(float DDDEDIGFCFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x790E420", Offset = "0x790D620", VA = "0x18790E420")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HCDEEFMCLII, object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x790F7F0", Offset = "0x790E9F0", VA = "0x18790F7F0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object BCOHKLCJCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79103B0", Offset = "0x790F5B0", VA = "0x1879103B0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA522E0", Offset = "0xA514E0", VA = "0x180A522E0", Slot = "4")]
		private GameObject HGELEMLJGJJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x920810", Offset = "0x91FA10", VA = "0x180920810", Slot = "9")]
		private bool LCNMGJMBHCF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class OGNEEPPGNJL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x790CF90", Offset = "0x790C190", VA = "0x18790CF90")]
	public static GPODHFNGINM ONHFMDHDOEK(this RigidbodyEx MNIAPDGOICH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(HCOJLELJMPJ), new string[] { })]
public class GJFBFODMOCI : HCOJLELJMPJ, AFDHOICPIPH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EKANBBOODKL GNCDPNENPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FFFOMHELMBA CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PPIHJHBKDDK OMLEEHAPDFA;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FFFOMHELMBA FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PPIHJHBKDDK PJOJPDCIBII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79088E0", Offset = "0x7907AE0", VA = "0x1879088E0", Slot = "7")]
	public void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7908970", Offset = "0x7907B70", VA = "0x187908970", Slot = "6")]
	public GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public GJFBFODMOCI()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static AEJLNDNFINA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int INHBMDBMKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int GMNJMBNLNMN;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x790DCE0", Offset = "0x790CEE0", VA = "0x18790DCE0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x790DD20", Offset = "0x790CF20", VA = "0x18790DD20")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x790DD00", Offset = "0x790CF00", VA = "0x18790DD00")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CBCJFCINKPJ, [Optional] UnityEngine.Object GCGNIOHLIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CBCJFCINKPJ, [Optional] UnityEngine.Object GCGNIOHLIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x790DE30", Offset = "0x790D030", VA = "0x18790DE30")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CJMNMCFCPCO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MIKELCNEBLM : NBAEIOPIALM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9039E0", Offset = "0x902BE0", VA = "0x1809039E0", Slot = "4")]
		public Vector3 ANNBLCAKDAM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9039E0", Offset = "0x902BE0", VA = "0x1809039E0", Slot = "5")]
		public Vector3 KIJCJCMDGHJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MIKELCNEBLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static NBAEIOPIALM BNOODAAKMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7903C80", Offset = "0x7902E80", VA = "0x187903C80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface APKANICDOFA
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode HNEGELGLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNEHIFHJLDG(bool GCHPMODOAFE);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEENJHOPMFN(bool GCHPMODOAFE);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CLHJEHDCPKJ(Vector3 BDIPLNMOFCC, [Out] RaycastHit FIAPOMAPPID, float ABBGAHJHLCA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IPNHIHLCPLD : IDisposable, AADLJHJNJJK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NEGICDPELDL FHNLLHPDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MICCOKKHGKO, MICCOKKHGKO> CCLEFPPHOHC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPOIMAMNCED();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PPIHJHBKDDK
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKCDKMKCLOJ IKGOCLDDLKB(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJACBJOHKFD JEKMIABJDEG(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DLOAEDALFLB NDCMFFFIELE(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOEGJPLKGMO OPCHMEACBGD(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKDCECCBNKF OMDJPCCIOLD(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IPNHIHLCPLD ALHIBFCCCIK(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPDENLEMHGI BNBPJNLMJIO(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PNNPIJIGHHA DCBKKLOBGFF(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	APKANICDOFA IBFADHOEMOC(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PKGBGFBGHAN MJDKAKMKFNK(GPODHFNGINM CMFHMEJHOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KADCMIGDHPD GAJJGFKHBCL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCIFPMGOGCL HBKNNKMOGAK(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HLLCMNODPMO KJCFDBPBPDL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PKEMFPDBFMB GDABHCPBEOP(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CJDPLBKKDCB JABOOAKCFEG(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP, HCOJLELJMPJ ODPBGAGOMOC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PNNPIJIGHHA
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCCCNLIILHO(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BODMKGKEOCI(Vector3 DCOODACAFGM, Vector3 FCKJMOMOHAE, ForceMode POEIPILMDFG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEPGKDELPKB(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPJFNBALGHE(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PKGBGFBGHAN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool DECKNFKFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDGOEKADJHE(Rigidbody DKODMFMIHHE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NKCDKMKCLOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<GPODHFNGINM> NICENMMMNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GPODHFNGINM KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KDJOAOJNEEJ FFIJIDFLGGH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KDJOAOJNEEJ MJIPJIICMAC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PEPIOKEAOLL OIMNOMEFLGG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action FJKIDHEOBJL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EMBJGLNEAAJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GPODHFNGINM> FKLCLKHCJII;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GPODHFNGINM> IENPJIHGHFN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action HPNLIJLPDOL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GPODHFNGINM> PJMIOHGHLBD;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HIDFBJMELPN(GPODHFNGINM BCPOGOCDLFM, bool OAPIJHCEDGK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DLOAEDALFLB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 BGLIEPHCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FEIHJPDIJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDDDHFKGLMK(GPODHFNGINM DBEHKFODEEL, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMJGDJIDDDP(object BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PKEMFPDBFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BOMNJPLGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 KDDCIOBPFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float MHFOCONJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float KCGMIHMMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 BHMICBBNMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion PNEPICKOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KDJOAOJNEEJ KAOBEHPJPLC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IDKDLMIKDGJ((Quaternion rot, Vector3 moments) MKOKFACDBAF);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PENJBFJGOBG();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PDHIFPIEOIE();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDPMPMKEGEM();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LDGOEKADJHE(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MPIJFJILGIL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HLLCMNODPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKNADPIGHOJ(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJKFBDOIMDE(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBPAGEAFEIB(GPODHFNGINM MNIAPDGOICH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOMGCNKNCCA(GPODHFNGINM MNIAPDGOICH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMOMBCKCPIG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GPDENLEMHGI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NENADNLDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KDJOAOJNEEJ GCMCIAGJEFF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKPIKGGLDIE(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OONALJJEKJP(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKPMOCNLHAD(object BCOHKLCJCPM, bool EEJHBJOAMHG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMOHDOPDJEA(Rigidbody MHCBGAAMHGE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDGOEKADJHE(Rigidbody DKODMFMIHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DCIFPMGOGCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CDGJNGKBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NGMOEHIJKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KDJOAOJNEEJ GILNHIDCMGH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFLPDOLHOFC(GPODHFNGINM DBEHKFODEEL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BEPELMIMBBM(GPODHFNGINM DBEHKFODEEL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CJDPLBKKDCB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HKGLPHFJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ELNLGNBLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints DFENNLLJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDGOEKADJHE(Rigidbody DKODMFMIHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DOEGJPLKGMO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float KPFLLIFAFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float CGJJNJKHIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LDGOEKADJHE(Rigidbody DKODMFMIHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NKDCECCBNKF
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	static bool BOHGMAIDGDF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KDJOAOJNEEJ IDCOKMCLOLB;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPCOCGEBANM();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCHLLDBAMED();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POBEMAFBMNG();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EADNODBECID();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MCACDEJHMFF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNEJAJFGDLG(bool JPBJILNOAPO);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HILANGOBFJK();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KADCMIGDHPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool HFNLMDDOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCBPMNODKFL(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFABOKLMNDF(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGKBLJCPEEL();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EJACBJOHKFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	NBAEIOPIALM ANCCMGOONMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PPIGDFPOOHP BHIKJHJICOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 DIFJPKIBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JGGPFBFLABC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 KGPGDELOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 GEOOMBNALKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float DDDMPMDMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ABPMBIIOFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NIDOOLBAHOH(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LEOKIPACBIJ(IEAEOEGIAFO PAKJIFKAIDO, Vector3 IBABFPJEHLF, float CJDFGFLAADO = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KDALCBEOLGH(BCFMLJKNNCD DJDEEKAABAM, Vector3 AFILDHPCPMP, float APGCJNOHJED, float MJCEINCCACJ = 8f, float JCCODJMCPLL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LKMEOLGJABC(IEAEOEGIAFO PAKJIFKAIDO, Vector3 EGIHDGHICMO, float ECJPGOHLCGO = 7f, float KJLDKEIPCJB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AEIJIEGLGCB();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DIMNJEAJCJN();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IPMCPJFIIDP();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DIMCELBBHIA();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KMOHDOPDJEA(Rigidbody DKODMFMIHHE);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FEIPGENEBFC(Vector3 BEIJOKHFPBB);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MKOFAFPELCH(object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ALFKLFMKHGI(Vector3 MODNMCMOGLE);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BCPOLNFJONJ(Vector3 MNIOOCMEKFF, Vector3 EDPKEMKJOLD);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CFEJJDMIMHC(Vector3 DDEHOJMJKFE, Vector3 PBACHNIDMAE);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LABHOECDIAM(Vector3 BDFPPBAJEKP);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PNNMIOGPOAO(Vector3 OBJBFFGONOB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface FFFOMHELMBA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KPPDCGBLENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKLFGLNEPCA(string GILNIHGCEJO);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJBELEKDCPO(RigidbodyEx MNIAPDGOICH, Action KOMGLJOLBFC);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNBLBCIINCH LDLCHCIDGNO(int BPDAHGHOJBI);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIIKDHMAGEE(Vector3 ALKLDEOFNHC, float CMFCLDCKDHM, Color HCHFCFNLIAI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface HCOJLELJMPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	FFFOMHELMBA FFGEEHIBEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	PPIHJHBKDDK PJOJPDCIBII
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CBPFBOFIOEF : GPODHFNGINM, IDisposable, JMGBFNPIPGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HCOJLELJMPJ ODPBGAGOMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NKCDKMKCLOJ FIBCOOGKMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HLLCMNODPMO CILBKCOEPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal DCIFPMGOGCL BGLNCPCCEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EJACBJOHKFD BEIJOKHFPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal DLOAEDALFLB PBJFDGDJFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal PKEMFPDBFMB FENCEBEFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal DOEGJPLKGMO LHMOPAEPKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal PKGBGFBGHAN KJCJDOODOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal NKDCECCBNKF CAAAKCEOACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal IPNHIHLCPLD JBLEHHBBAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal GPDENLEMHGI OCJBOJFJAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal PNNPIJIGHHA DCOODACAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal CJDPLBKKDCB MKGCONKEDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal KADCMIGDHPD DKODMFMIHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal APKANICDOFA KBIEGNIGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable FPEGMFCMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool ENJOCDEFMIG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "22")]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public ELOCKNMGHMD GKOEGMCBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCEA770", Offset = "0xCE9970", VA = "0x180CEA770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject EBDEMNLMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8F7850", Offset = "0x8F6A50", VA = "0x1808F7850", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAB89E0", Offset = "0xAB7BE0", VA = "0x180AB89E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xCF3C60", Offset = "0xCF2E60", VA = "0x180CF3C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x78FE610", Offset = "0x78FD810", VA = "0x1878FE610", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x78FF8A0", Offset = "0x78FEAA0", VA = "0x1878FF8A0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7902710", Offset = "0x7901910", VA = "0x187902710", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int PFBNKEEHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7901960", Offset = "0x7900B60", VA = "0x187901960", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GPODHFNGINM KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x79004F0", Offset = "0x78FF6F0", VA = "0x1879004F0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool CICFKLPBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7900900", Offset = "0x78FFB00", VA = "0x187900900", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CDGJNGKBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x78FF630", Offset = "0x78FE830", VA = "0x1878FF630", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool NGMOEHIJKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x78FF4B0", Offset = "0x78FE6B0", VA = "0x1878FF4B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NBAEIOPIALM ANCCMGOONMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x78FF5E0", Offset = "0x78FE7E0", VA = "0x1878FF5E0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x78FFB40", Offset = "0x78FED40", VA = "0x1878FFB40", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PPIGDFPOOHP BHIKJHJICOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7901370", Offset = "0x7900570", VA = "0x187901370", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x78FD780", Offset = "0x78FC980", VA = "0x1878FD780", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float DDDMPMDMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x78FFAA0", Offset = "0x78FECA0", VA = "0x1878FFAA0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x78FD720", Offset = "0x78FC920", VA = "0x1878FD720", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JGGPFBFLABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x79007D0", Offset = "0x78FF9D0", VA = "0x1879007D0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x78FE2E0", Offset = "0x78FD4E0", VA = "0x1878FE2E0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 GEOOMBNALKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x78FDBF0", Offset = "0x78FCDF0", VA = "0x1878FDBF0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x78FF6E0", Offset = "0x78FE8E0", VA = "0x1878FF6E0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 DIFJPKIBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7902F80", Offset = "0x7902180", VA = "0x187902F80", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7902EA0", Offset = "0x79020A0", VA = "0x187902EA0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 KGPGDELOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x78FF280", Offset = "0x78FE480", VA = "0x1878FF280", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x79023A0", Offset = "0x79015A0", VA = "0x1879023A0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool CGFDNHECKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x78FFD80", Offset = "0x78FEF80", VA = "0x1878FFD80", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool FPGBADHJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7902480", Offset = "0x7901680", VA = "0x187902480", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool IOKBCEGNDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x78FE710", Offset = "0x78FD910", VA = "0x1878FE710", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ABPMBIIOFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x78FF360", Offset = "0x78FE560", VA = "0x1878FF360", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 BGLIEPHCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7901440", Offset = "0x7900640", VA = "0x187901440", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FEIHJPDIJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x78FEA10", Offset = "0x78FDC10", VA = "0x1878FEA10", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 BOMNJPLGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7902980", Offset = "0x7901B80", VA = "0x187902980", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7900960", Offset = "0x78FFB60", VA = "0x187900960", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 KDDCIOBPFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x78FEC50", Offset = "0x78FDE50", VA = "0x1878FEC50", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float MHFOCONJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x78FFAF0", Offset = "0x78FECF0", VA = "0x1878FFAF0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float KCGMIHMMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x78FD9A0", Offset = "0x78FCBA0", VA = "0x1878FD9A0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7903380", Offset = "0x7902580", VA = "0x187903380", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 BHMICBBNMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x79005F0", Offset = "0x78FF7F0", VA = "0x1879005F0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion PNEPICKOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7900A40", Offset = "0x78FFC40", VA = "0x187900A40", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float KPFLLIFAFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x79006D0", Offset = "0x78FF8D0", VA = "0x1879006D0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x78FE9B0", Offset = "0x78FDBB0", VA = "0x1878FE9B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float CGJJNJKHIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x79036E0", Offset = "0x79028E0", VA = "0x1879036E0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x78FEFC0", Offset = "0x78FE1C0", VA = "0x1878FEFC0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool DECKNFKFENI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x78FE7F0", Offset = "0x78FD9F0", VA = "0x1878FE7F0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x79026B0", Offset = "0x79018B0", VA = "0x1879026B0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NEGICDPELDL FHNLLHPDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7902350", Offset = "0x7901550", VA = "0x187902350", Slot = "70")]
		get
		{
			return default(NEGICDPELDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x79002E0", Offset = "0x78FF4E0", VA = "0x1879002E0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool NENADNLDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x79019D0", Offset = "0x7900BD0", VA = "0x1879019D0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform JGFGNIJOCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAB89E0", Offset = "0xAB7BE0", VA = "0x180AB89E0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 HPOCEBIKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x78FE660", Offset = "0x78FD860", VA = "0x1878FE660", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x78FE130", Offset = "0x78FD330", VA = "0x1878FE130", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float HCLEOEMBEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x78FEAF0", Offset = "0x78FDCF0", VA = "0x1878FEAF0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x78FF120", Offset = "0x78FE320", VA = "0x1878FF120", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float KNFGAKJFNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x79033E0", Offset = "0x79025E0", VA = "0x1879033E0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7903860", Offset = "0x7902A60", VA = "0x187903860", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion OKAKNFFOGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x78FFCE0", Offset = "0x78FEEE0", VA = "0x1878FFCE0", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7900DF0", Offset = "0x78FFFF0", VA = "0x187900DF0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 MLGLPLALOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x78FFFD0", Offset = "0x78FF1D0", VA = "0x1878FFFD0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x79000D0", Offset = "0x78FF2D0", VA = "0x1879000D0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion FPDDOGEDCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x78FE1E0", Offset = "0x78FD3E0", VA = "0x1878FE1E0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x78FF190", Offset = "0x78FE390", VA = "0x1878FF190", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints DFENNLLJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7900720", Offset = "0x78FF920", VA = "0x187900720", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7903120", Offset = "0x7902320", VA = "0x187903120", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool HKGLPHFJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7902930", Offset = "0x7901B30", VA = "0x187902930", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7901510", Offset = "0x7900710", VA = "0x187901510", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode HNEGELGLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x79008B0", Offset = "0x78FFAB0", VA = "0x1879008B0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7900280", Offset = "0x78FF480", VA = "0x187900280", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EGOBIGBDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7901C30", Offset = "0x7900E30", VA = "0x187901C30", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool FCCELNGFEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x78FD5A0", Offset = "0x78FC7A0", VA = "0x1878FD5A0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KDJOAOJNEEJ FFIJIDFLGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x79024E0", Offset = "0x79016E0", VA = "0x1879024E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7900010", Offset = "0x78FF210", VA = "0x187900010", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event KDJOAOJNEEJ MJIPJIICMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x78FE280", Offset = "0x78FD480", VA = "0x1878FE280", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x79028D0", Offset = "0x7901AD0", VA = "0x1879028D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PEPIOKEAOLL OIMNOMEFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7903940", Offset = "0x7902B40", VA = "0x187903940", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x78FFF10", Offset = "0x78FF110", VA = "0x1878FFF10", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KDJOAOJNEEJ GILNHIDCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x79030C0", Offset = "0x79022C0", VA = "0x1879030C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x78FF8F0", Offset = "0x78FEAF0", VA = "0x1878FF8F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KDJOAOJNEEJ IKJIFBALHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x78FFEB0", Offset = "0x78FF0B0", VA = "0x1878FFEB0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x78FF680", Offset = "0x78FE880", VA = "0x1878FF680", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event KDJOAOJNEEJ IDCOKMCLOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x78FFF70", Offset = "0x78FF170", VA = "0x1878FFF70", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7900540", Offset = "0x78FF740", VA = "0x187900540", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MICCOKKHGKO, MICCOKKHGKO> CCLEFPPHOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7900070", Offset = "0x78FF270", VA = "0x187900070", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7900D90", Offset = "0x78FFF90", VA = "0x187900D90", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KDJOAOJNEEJ GCMCIAGJEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x78FFC30", Offset = "0x78FEE30", VA = "0x1878FFC30", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7903440", Offset = "0x7902640", VA = "0x187903440", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KDJOAOJNEEJ GECOOCJHPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7901B80", Offset = "0x7900D80", VA = "0x187901B80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x78FEB00", Offset = "0x78FDD00", VA = "0x1878FEB00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7903B90", Offset = "0x7902D90", VA = "0x187903B90")]
	public CBPFBOFIOEF(GameObject GBMEGJCINPI, RigidbodyEx BNLOKBIMGAN, HCOJLELJMPJ ODPBGAGOMOC, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7901570", Offset = "0x7900770", VA = "0x187901570", Slot = "139")]
	protected virtual void KOEEODICPKO(HCOJLELJMPJ ODPBGAGOMOC, ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x78FF020", Offset = "0x78FE220", VA = "0x1878FF020", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7903240", Offset = "0x7902440", VA = "0x187903240", Slot = "93")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7900110", Offset = "0x78FF310", VA = "0x187900110", Slot = "94")]
	public void ICCGKJEINBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x78FE220", Offset = "0x78FD420", VA = "0x1878FE220", Slot = "95")]
	public void CALOAJDDJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x78FFA80", Offset = "0x78FEC80", VA = "0x1878FFA80", Slot = "96")]
	public void GHAHEGACDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7900B10", Offset = "0x78FFD10", VA = "0x187900B10")]
	private void JNEJAJFGDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x78FE3C0", Offset = "0x78FD5C0", VA = "0x1878FE3C0")]
	private void CEEGNFGMJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7902290", Offset = "0x7901490", VA = "0x187902290")]
	private void MCACDEJHMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x79013C0", Offset = "0x79005C0", VA = "0x1879013C0", Slot = "30")]
	public GPODHFNGINM KHGACFDDFNM(int CPLNODNGKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x78FFDD0", Offset = "0x78FEFD0", VA = "0x1878FFDD0", Slot = "98")]
	public void HIDFBJMELPN(GPODHFNGINM OMEFCJCOLII, bool OAPIJHCEDGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7901A20", Offset = "0x7900C20", VA = "0x187901A20", Slot = "99")]
	public void LCLEBDMCNJH(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7901310", Offset = "0x7900510", VA = "0x187901310", Slot = "100")]
	public void KDANOPNNNBM(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7903A00", Offset = "0x7902C00", VA = "0x187903A00", Slot = "101")]
	public Vector3 PNNMIOGPOAO(Vector3 OBJBFFGONOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7901860", Offset = "0x7900A60", VA = "0x187901860", Slot = "102")]
	public Vector3 LABHOECDIAM(Vector3 BDFPPBAJEKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x78FEBB0", Offset = "0x78FDDB0", VA = "0x1878FEBB0", Slot = "103")]
	public void DIMCELBBHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x78FEC00", Offset = "0x78FDE00", VA = "0x1878FEC00", Slot = "104")]
	public void DIMNJEAJCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x78FD470", Offset = "0x78FC670", VA = "0x1878FD470", Slot = "105")]
	public void AEIJIEGLGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x78FE520", Offset = "0x78FD720", VA = "0x1878FE520", Slot = "106")]
	public void CFEJJDMIMHC(Vector3 DDEHOJMJKFE, Vector3 PBACHNIDMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x78FD7E0", Offset = "0x78FC9E0", VA = "0x1878FD7E0", Slot = "107")]
	public void BCPOLNFJONJ(Vector3 MNIOOCMEKFF, Vector3 EDPKEMKJOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x78FD4C0", Offset = "0x78FC6C0", VA = "0x1878FD4C0", Slot = "108")]
	public void ALFKLFMKHGI(Vector3 MODNMCMOGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7901250", Offset = "0x7900450", VA = "0x187901250", Slot = "109")]
	public void KDALCBEOLGH(BCFMLJKNNCD DJDEEKAABAM, Vector3 AFILDHPCPMP, float APGCJNOHJED, float MJCEINCCACJ = 8f, float JCCODJMCPLL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7901A80", Offset = "0x7900C80", VA = "0x187901A80", Slot = "110")]
	public void LEOKIPACBIJ(IEAEOEGIAFO PAKJIFKAIDO, Vector3 IBABFPJEHLF, float CJDFGFLAADO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7901D70", Offset = "0x7900F70", VA = "0x187901D70", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LKMEOLGJABC(IEAEOEGIAFO PAKJIFKAIDO, Vector3 EGIHDGHICMO, float ECJPGOHLCGO = 7f, float KJLDKEIPCJB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x78FF3B0", Offset = "0x78FE5B0", VA = "0x1878FF3B0", Slot = "112")]
	public Vector3 FEIPGENEBFC(Vector3 OMEFCJCOLII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x78FED30", Offset = "0x78FDF30", VA = "0x1878FED30", Slot = "113")]
	public Vector3 DKCGHJIBDNM(Vector3 OMEFCJCOLII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79005A0", Offset = "0x78FF7A0", VA = "0x1879005A0", Slot = "114")]
	public void IPMCPJFIIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x78FE840", Offset = "0x78FDA40", VA = "0x1878FE840", Slot = "115")]
	public void CKKGFPNCCLI(GPODHFNGINM HCDEEFMCLII, object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x78FEE30", Offset = "0x78FE030", VA = "0x1878FEE30", Slot = "116")]
	public void DMLJBCCJFNC(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x79001A0", Offset = "0x78FF3A0", VA = "0x1879001A0", Slot = "63")]
	public void IDKDLMIKDGJ((Quaternion rot, Vector3 moments) MKOKFACDBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x79033F0", Offset = "0x79025F0", VA = "0x1879033F0", Slot = "117")]
	public void PDHIFPIEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x79034A0", Offset = "0x79026A0", VA = "0x1879034A0", Slot = "118")]
	public void PENJBFJGOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x78FFC90", Offset = "0x78FEE90", VA = "0x1878FFC90", Slot = "119")]
	public void HDPMPMKEGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x78FEE90", Offset = "0x78FE090", VA = "0x1878FEE90", Slot = "120")]
	public bool DPCOCGEBANM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7903B00", Offset = "0x7902D00", VA = "0x187903B00", Slot = "97")]
	public void POBEMAFBMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x78FFE40", Offset = "0x78FF040", VA = "0x1878FFE40", Slot = "121")]
	public void HILANGOBFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x79039A0", Offset = "0x7902BA0", VA = "0x1879039A0", Slot = "122")]
	public void PKPIKGGLDIE(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7903180", Offset = "0x7902380", VA = "0x187903180", Slot = "123")]
	public void OONALJJEKJP(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x78FF1C0", Offset = "0x78FE3C0", VA = "0x1878FF1C0", Slot = "124")]
	public void EKPMOCNLHAD(object BCOHKLCJCPM, bool EEJHBJOAMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x78FDCD0", Offset = "0x78FCED0", VA = "0x1878FDCD0", Slot = "125")]
	public void BMKDLIBFKMC(Vector3 EBFOEOCLHGJ, Quaternion MFCDNHAADAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7903730", Offset = "0x7902930", VA = "0x187903730", Slot = "126")]
	public void PIKILGLOGDG(Vector3 DKEJLDLNJBE, Quaternion GFIIPINEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x78FF230", Offset = "0x78FE430", VA = "0x1878FF230", Slot = "127")]
	public bool ELFECLJNMED(float DDDEDIGFCFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x79031E0", Offset = "0x79023E0", VA = "0x1879031E0", Slot = "128")]
	public void OOOLBHPAIEO(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7903060", Offset = "0x7902260", VA = "0x187903060", Slot = "129")]
	public void OGHBFEGPNEK(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x79022F0", Offset = "0x79014F0", VA = "0x1879022F0", Slot = "130")]
	public void MCBPMNODKFL(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7900770", Offset = "0x78FF970", VA = "0x187900770", Slot = "131")]
	public void JFABOKLMNDF(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x78FF7C0", Offset = "0x78FE9C0", VA = "0x1878FF7C0", Slot = "132")]
	public void GCCCNLIILHO(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x78FDED0", Offset = "0x78FD0D0", VA = "0x1878FDED0", Slot = "133")]
	public void BODMKGKEOCI(Vector3 DCOODACAFGM, Vector3 FCKJMOMOHAE, ForceMode POEIPILMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x78FE440", Offset = "0x78FD640", VA = "0x1878FE440", Slot = "134")]
	public void CEPGKDELPKB(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x78FEEE0", Offset = "0x78FE0E0", VA = "0x1878FEEE0", Slot = "135")]
	public void DPJFNBALGHE(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x78FE8B0", Offset = "0x78FDAB0", VA = "0x1878FE8B0", Slot = "136")]
	public bool CLHJEHDCPKJ(Vector3 BDIPLNMOFCC, [Out] RaycastHit FIAPOMAPPID, float ABBGAHJHLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7902770", Offset = "0x7901970", VA = "0x187902770", Slot = "137")]
	public void MPIJFJILGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7903B50", Offset = "0x7902D50", VA = "0x187903B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x78FF500", Offset = "0x78FE700", VA = "0x1878FF500")]
	private void FHJMLLCFILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x79027C0", Offset = "0x79019C0", VA = "0x1879027C0")]
	private void NBLHPPEMAKP(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x79034F0", Offset = "0x79026F0", VA = "0x1879034F0")]
	private void PHKKAPKGKKE(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x79021E0", Offset = "0x79013E0", VA = "0x1879021E0")]
	private void MBJMMBCCLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x78FF950", Offset = "0x78FEB50", VA = "0x1878FF950")]
	private void GEKNAPCAHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7900340", Offset = "0x78FF540", VA = "0x187900340")]
	private void IJCCJIKFOGF(GPODHFNGINM PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x78FD9F0", Offset = "0x78FCBF0", VA = "0x1878FD9F0")]
	private void BFLPDOLHOFC(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x78FD8D0", Offset = "0x78FCAD0", VA = "0x1878FD8D0")]
	private void BEPELMIMBBM(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x78FDFE0", Offset = "0x78FD1E0", VA = "0x1878FDFE0")]
	private void BOGEKJFGMJE(ELOCKNMGHMD DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7902A60", Offset = "0x7901C60", VA = "0x187902A60", Slot = "142")]
	protected virtual void OADNOOMDNFK(ELOCKNMGHMD MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7901E80", Offset = "0x7901080", VA = "0x187901E80")]
	protected void LLCHKJDDHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7900ED0", Offset = "0x79000D0", VA = "0x187900ED0")]
	protected void KAEJGIOGIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x78FDAC0", Offset = "0x78FCCC0", VA = "0x1878FDAC0")]
	private void BJADFEAMDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7902540", Offset = "0x7901740", VA = "0x187902540")]
	private void MLPNAONCGEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class BFADBPPHICG
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x78FBF80", Offset = "0x78FB180", VA = "0x1878FBF80")]
	public static GPODHFNGINM GFOIGMCEIDI(this GPODHFNGINM MNIAPDGOICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x78FC0E0", Offset = "0x78FB2E0", VA = "0x1878FC0E0")]
	public static bool JDKBMAIFPGE(this GPODHFNGINM MNIAPDGOICH, GPODHFNGINM EGEKCOILHLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x78FC040", Offset = "0x78FB240", VA = "0x1878FC040")]
	public static bool HFKOENODOIC(this GPODHFNGINM MNIAPDGOICH, GPODHFNGINM AKBBBDGIJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x78FC180", Offset = "0x78FB380", VA = "0x1878FC180")]
	public static ELOCKNMGHMD JIKILFJEECD(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x78FC1D0", Offset = "0x78FB3D0", VA = "0x1878FC1D0")]
	public static CBPFBOFIOEF KKICCIANDJP(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ICHINDLEEJP : PPIHJHBKDDK
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x79091D0", Offset = "0x79083D0", VA = "0x1879091D0", Slot = "19")]
	public GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP, HCOJLELJMPJ ODPBGAGOMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "4")]
	public NKCDKMKCLOJ IKGOCLDDLKB(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "5")]
	public EJACBJOHKFD JEKMIABJDEG(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "6")]
	public DLOAEDALFLB NDCMFFFIELE(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "7")]
	public DOEGJPLKGMO OPCHMEACBGD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "8")]
	public NKDCECCBNKF OMDJPCCIOLD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "9")]
	public IPNHIHLCPLD ALHIBFCCCIK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "10")]
	public GPDENLEMHGI BNBPJNLMJIO(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "11")]
	public PNNPIJIGHHA DCBKKLOBGFF(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "12")]
	public APKANICDOFA IBFADHOEMOC(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "13")]
	public PKGBGFBGHAN MJDKAKMKFNK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	public KADCMIGDHPD GAJJGFKHBCL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	public DCIFPMGOGCL HBKNNKMOGAK(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	public HLLCMNODPMO KJCFDBPBPDL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	public PKEMFPDBFMB GDABHCPBEOP(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	public CJDPLBKKDCB JABOOAKCFEG(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ICHINDLEEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "14")]
	private KADCMIGDHPD JILPKHDPMKD(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "15")]
	private DCIFPMGOGCL DKGIOHJIOPM(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "16")]
	private HLLCMNODPMO EBEEFLGDAKC(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "17")]
	private PKEMFPDBFMB DODGCPHNMFN(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "18")]
	private CJDPLBKKDCB GHIEIILNKFA(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(PPIHJHBKDDK), new string[] { })]
public class BJCIAKCLJFK : PPIHJHBKDDK, AFDHOICPIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PPIHJHBKDDK DPIPGEFPHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PPIHJHBKDDK DBLPOFJMIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EKANBBOODKL GNCDPNENPOJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private PPIHJHBKDDK PJOJPDCIBII
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x78FD160", Offset = "0x78FC360", VA = "0x1878FD160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x78FCDE0", Offset = "0x78FBFE0", VA = "0x1878FCDE0", Slot = "20")]
	public void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x78FCD40", Offset = "0x78FBF40", VA = "0x1878FCD40", Slot = "4")]
	public NKCDKMKCLOJ IKGOCLDDLKB(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x78FCE30", Offset = "0x78FC030", VA = "0x1878FCE30", Slot = "5")]
	public EJACBJOHKFD JEKMIABJDEG(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x78FD0C0", Offset = "0x78FC2C0", VA = "0x1878FD0C0", Slot = "6")]
	public DLOAEDALFLB NDCMFFFIELE(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x78FD260", Offset = "0x78FC460", VA = "0x1878FD260", Slot = "7")]
	public DOEGJPLKGMO OPCHMEACBGD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x78FD1C0", Offset = "0x78FC3C0", VA = "0x1878FD1C0", Slot = "8")]
	public NKDCECCBNKF OMDJPCCIOLD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x78FC750", Offset = "0x78FB950", VA = "0x1878FC750", Slot = "9")]
	public IPNHIHLCPLD ALHIBFCCCIK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x78FC7F0", Offset = "0x78FB9F0", VA = "0x1878FC7F0", Slot = "10")]
	public GPDENLEMHGI BNBPJNLMJIO(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x78FC890", Offset = "0x78FBA90", VA = "0x1878FC890", Slot = "11")]
	public PNNPIJIGHHA DCBKKLOBGFF(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x78FCCA0", Offset = "0x78FBEA0", VA = "0x1878FCCA0", Slot = "12")]
	public APKANICDOFA IBFADHOEMOC(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x78FD020", Offset = "0x78FC220", VA = "0x1878FD020", Slot = "13")]
	public PKGBGFBGHAN MJDKAKMKFNK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x78FCB40", Offset = "0x78FBD40", VA = "0x1878FCB40")]
	public KADCMIGDHPD GAJJGFKHBCL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x78FC930", Offset = "0x78FBB30", VA = "0x1878FC930")]
	public DCIFPMGOGCL HBKNNKMOGAK(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x78FCA90", Offset = "0x78FBC90", VA = "0x1878FCA90")]
	public HLLCMNODPMO KJCFDBPBPDL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x78FC9E0", Offset = "0x78FBBE0", VA = "0x1878FC9E0")]
	public PKEMFPDBFMB GDABHCPBEOP(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x78FCBF0", Offset = "0x78FBDF0", VA = "0x1878FCBF0")]
	public CJDPLBKKDCB JABOOAKCFEG(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x78FCED0", Offset = "0x78FC0D0", VA = "0x1878FCED0", Slot = "19")]
	public GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP, HCOJLELJMPJ ODPBGAGOMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x78FD300", Offset = "0x78FC500", VA = "0x1878FD300")]
	public BJCIAKCLJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x78FCB40", Offset = "0x78FBD40", VA = "0x1878FCB40", Slot = "14")]
	private KADCMIGDHPD JILPKHDPMKD(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x78FC930", Offset = "0x78FBB30", VA = "0x1878FC930", Slot = "15")]
	private DCIFPMGOGCL DKGIOHJIOPM(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x78FCA90", Offset = "0x78FBC90", VA = "0x1878FCA90", Slot = "16")]
	private HLLCMNODPMO EBEEFLGDAKC(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x78FC9E0", Offset = "0x78FBBE0", VA = "0x1878FC9E0", Slot = "17")]
	private PKEMFPDBFMB DODGCPHNMFN(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x78FCBF0", Offset = "0x78FBDF0", VA = "0x1878FCBF0", Slot = "18")]
	private CJDPLBKKDCB GHIEIILNKFA(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JJJFBACIGMO : NKCDKMKCLOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHJIJLKPAKP(GPODHFNGINM MNIAPDGOICH);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEHAKIHJFLL(GPODHFNGINM MNIAPDGOICH);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENOBMOAGGEK(GPODHFNGINM PMFJAKONNCF);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAIEOHFHIAJ(GPODHFNGINM PMFJAKONNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OKGDGMDPBBG : DLOAEDALFLB
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	NCAPDKFFCEO<GPODHFNGINM> PHHEKNCPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GPODHFNGINM KLBLFEMPJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BBAGFHLJGFK : PKEMFPDBFMB
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LNJGMNJBNHH(Rigidbody KCBIGHJEAJH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NKIMLPIDDKN : DCIFPMGOGCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView GBFPCKBOHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OOJBANCCGDM : APKANICDOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode IBFDHPIELJJ;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7907EF0", Offset = "0x79070F0", VA = "0x187907EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode HNEGELGLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x790D310", Offset = "0x790C510", VA = "0x18790D310", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x790D180", Offset = "0x790C380", VA = "0x18790D180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7903FC0", Offset = "0x79031C0", VA = "0x187903FC0")]
	public OOJBANCCGDM(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x790D4A0", Offset = "0x790C6A0", VA = "0x18790D4A0", Slot = "6")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x790D420", Offset = "0x790C620", VA = "0x18790D420", Slot = "9")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x790D160", Offset = "0x790C360", VA = "0x18790D160", Slot = "7")]
	public void DNEHIFHJLDG(bool GCHPMODOAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x790D170", Offset = "0x790C370", VA = "0x18790D170", Slot = "8")]
	public void EEENJHOPMFN(bool GCHPMODOAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x790D000", Offset = "0x790C200", VA = "0x18790D000", Slot = "10")]
	public bool CLHJEHDCPKJ(Vector3 BDIPLNMOFCC, [Out] RaycastHit FIAPOMAPPID, float ABBGAHJHLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x790D1F0", Offset = "0x790C3F0", VA = "0x18790D1F0")]
	private void JBDEOGHGBPO(bool GCHPMODOAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HMBIHALBMIE : IPNHIHLCPLD, IDisposable, AADLJHJNJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private NEGICDPELDL BBCNLCBEMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FNBLBCIINCH IFJPGLDOEFE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public NEGICDPELDL FHNLLHPDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7908D80", Offset = "0x7907F80", VA = "0x187908D80", Slot = "6")]
		get
		{
			return default(NEGICDPELDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7908C00", Offset = "0x7907E00", VA = "0x187908C00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform GDDCBCPBNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xB62950", Offset = "0xB61B50", VA = "0x180B62950", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MICCOKKHGKO, MICCOKKHGKO> CCLEFPPHOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7908B50", Offset = "0x7907D50", VA = "0x187908B50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7908CD0", Offset = "0x7907ED0", VA = "0x187908CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7909140", Offset = "0x7908340", VA = "0x187909140")]
	public HMBIHALBMIE(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7908ED0", Offset = "0x79080D0", VA = "0x187908ED0", Slot = "8")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7908B00", Offset = "0x7907D00", VA = "0x187908B00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xFC8C00", Offset = "0xFC7E00", VA = "0x180FC8C00", Slot = "11")]
	private void OPICCGANPIE(MICCOKKHGKO FEFDOAKPMBJ, MICCOKKHGKO DAEFLBNGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "12")]
	private void AKCCOGNHNDJ(bool DGANKCELALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LFPOHLMCOOA : PPIHJHBKDDK
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x790C7D0", Offset = "0x790B9D0", VA = "0x18790C7D0", Slot = "4")]
	public NKCDKMKCLOJ IKGOCLDDLKB(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x790C8C0", Offset = "0x790BAC0", VA = "0x18790C8C0", Slot = "5")]
	public EJACBJOHKFD JEKMIABJDEG(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x790CC00", Offset = "0x790BE00", VA = "0x18790CC00", Slot = "6")]
	public DLOAEDALFLB NDCMFFFIELE(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x790CE00", Offset = "0x790C000", VA = "0x18790CE00", Slot = "7")]
	public DOEGJPLKGMO OPCHMEACBGD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x790CD30", Offset = "0x790BF30", VA = "0x18790CD30", Slot = "8")]
	public NKDCECCBNKF OMDJPCCIOLD(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x790BDE0", Offset = "0x790AFE0", VA = "0x18790BDE0", Slot = "9")]
	public IPNHIHLCPLD ALHIBFCCCIK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x790BEB0", Offset = "0x790B0B0", VA = "0x18790BEB0", Slot = "10")]
	public GPDENLEMHGI BNBPJNLMJIO(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x790BFD0", Offset = "0x790B1D0", VA = "0x18790BFD0", Slot = "11")]
	public PNNPIJIGHHA DCBKKLOBGFF(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x790C710", Offset = "0x790B910", VA = "0x18790C710", Slot = "12")]
	public APKANICDOFA IBFADHOEMOC(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x790CB40", Offset = "0x790BD40", VA = "0x18790CB40", Slot = "13")]
	public PKGBGFBGHAN MJDKAKMKFNK(GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x790C4F0", Offset = "0x790B6F0", VA = "0x18790C4F0")]
	public KADCMIGDHPD GAJJGFKHBCL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x790C090", Offset = "0x790B290", VA = "0x18790C090")]
	public DCIFPMGOGCL HBKNNKMOGAK(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x790C3C0", Offset = "0x790B5C0", VA = "0x18790C3C0")]
	public HLLCMNODPMO KJCFDBPBPDL(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x790C220", Offset = "0x790B420", VA = "0x18790C220")]
	public PKEMFPDBFMB GDABHCPBEOP(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x790C630", Offset = "0x790B830", VA = "0x18790C630")]
	public CJDPLBKKDCB JABOOAKCFEG(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x790C9F0", Offset = "0x790BBF0", VA = "0x18790C9F0", Slot = "19")]
	public GPODHFNGINM KDDKBMDFDMG(RigidbodyEx MNIAPDGOICH, ENALNGMJFGO LFDKFEEPNFP, HCOJLELJMPJ ODPBGAGOMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public LFPOHLMCOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x790C4F0", Offset = "0x790B6F0", VA = "0x18790C4F0", Slot = "14")]
	private KADCMIGDHPD JILPKHDPMKD(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x790C090", Offset = "0x790B290", VA = "0x18790C090", Slot = "15")]
	private DCIFPMGOGCL DKGIOHJIOPM(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x790C3C0", Offset = "0x790B5C0", VA = "0x18790C3C0", Slot = "16")]
	private HLLCMNODPMO EBEEFLGDAKC(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x790C220", Offset = "0x790B420", VA = "0x18790C220", Slot = "17")]
	private PKEMFPDBFMB DODGCPHNMFN(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x790C630", Offset = "0x790B830", VA = "0x18790C630", Slot = "18")]
	private CJDPLBKKDCB GHIEIILNKFA(GPODHFNGINM CMFHMEJHOAJ, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class FJIMJIGGHKG : PNNPIJIGHHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7907EF0", Offset = "0x79070F0", VA = "0x187907EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool NENADNLDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x79085C0", Offset = "0x79077C0", VA = "0x1879085C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool CICFKLPBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x78FBD40", Offset = "0x78FAF40", VA = "0x1878FBD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7908300", Offset = "0x7907500", VA = "0x187908300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7903FC0", Offset = "0x79031C0", VA = "0x187903FC0")]
	public FJIMJIGGHKG(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x79081A0", Offset = "0x79073A0", VA = "0x1879081A0", Slot = "4")]
	public void GCCCNLIILHO(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x79078B0", Offset = "0x7906AB0", VA = "0x1879078B0")]
	private void AOFPJIAOAIF(Vector3 DCOODACAFGM, ForceMode POEIPILMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7907B10", Offset = "0x7906D10", VA = "0x187907B10", Slot = "5")]
	public void BODMKGKEOCI(Vector3 DCOODACAFGM, Vector3 FCKJMOMOHAE, ForceMode POEIPILMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7907D90", Offset = "0x7906F90", VA = "0x187907D90", Slot = "6")]
	public void CEPGKDELPKB(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7908360", Offset = "0x7907560", VA = "0x187908360")]
	private void HNNOPHDMLJI(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7907F40", Offset = "0x7907140", VA = "0x187907F40", Slot = "7")]
	public void DPJFNBALGHE(Vector3 KDCKDOGBGNN, ForceMode POEIPILMDFG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class DKAGBGBDALP : PKGBGFBGHAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KKMCCHCGBLL;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DECKNFKFENI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7903EB0", Offset = "0x79030B0", VA = "0x187903EB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7903FC0", Offset = "0x79031C0", VA = "0x187903FC0")]
	public DKAGBGBDALP(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7903E10", Offset = "0x7903010", VA = "0x187903E10", Slot = "6")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7903E40", Offset = "0x7903040", VA = "0x187903E40", Slot = "7")]
	public void LDGOEKADJHE(Rigidbody DKODMFMIHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class AKINHHPIEJA : JJJFBACIGMO, NKCDKMKCLOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GPODHFNGINM MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<GPODHFNGINM> OLIOHFAJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GPODHFNGINM DONMCNODAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private GPODHFNGINM DBEHKFODEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform HOKEOFJIANM;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x78FA820", Offset = "0x78F9A20", VA = "0x1878FA820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8F21C0", Offset = "0x8F13C0", VA = "0x1808F21C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x78FA620", Offset = "0x78F9820", VA = "0x1878FA620", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GPODHFNGINM KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<GPODHFNGINM> NICENMMMNDO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8F21E0", Offset = "0x8F13E0", VA = "0x1808F21E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KDJOAOJNEEJ FFIJIDFLGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x78FA450", Offset = "0x78F9650", VA = "0x1878FA450", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x78F9D30", Offset = "0x78F8F30", VA = "0x1878F9D30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KDJOAOJNEEJ MJIPJIICMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x78F8E60", Offset = "0x78F8060", VA = "0x1878F8E60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x78FA6D0", Offset = "0x78F98D0", VA = "0x1878FA6D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PEPIOKEAOLL OIMNOMEFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x78FA880", Offset = "0x78F9A80", VA = "0x1878FA880", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x78F9C90", Offset = "0x78F8E90", VA = "0x1878F9C90", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action FJKIDHEOBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x78F9670", Offset = "0x78F8870", VA = "0x1878F9670", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x78F95D0", Offset = "0x78F87D0", VA = "0x1878F95D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EMBJGLNEAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x78FA630", Offset = "0x78F9830", VA = "0x1878FA630", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x78F8F00", Offset = "0x78F8100", VA = "0x1878F8F00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<GPODHFNGINM> FKLCLKHCJII
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x78F8DB0", Offset = "0x78F7FB0", VA = "0x1878F8DB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x78F9040", Offset = "0x78F8240", VA = "0x1878F9040", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GPODHFNGINM> IENPJIHGHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x78FA770", Offset = "0x78F9970", VA = "0x1878FA770", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x78F8C40", Offset = "0x78F7E40", VA = "0x1878F8C40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action HPNLIJLPDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x78F9DD0", Offset = "0x78F8FD0", VA = "0x1878F9DD0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x78FA3B0", Offset = "0x78F95B0", VA = "0x1878FA3B0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<GPODHFNGINM> PJMIOHGHLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x78F9360", Offset = "0x78F8560", VA = "0x1878F9360", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x78F9520", Offset = "0x78F8720", VA = "0x1878F9520", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x78FA920", Offset = "0x78F9B20", VA = "0x1878FA920")]
	public AKINHHPIEJA(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x78F8FA0", Offset = "0x78F81A0", VA = "0x1878F8FA0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x78F9710", Offset = "0x78F8910", VA = "0x1878F9710", Slot = "30")]
	public void HIDFBJMELPN(GPODHFNGINM BCPOGOCDLFM, bool OAPIJHCEDGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x78F90F0", Offset = "0x78F82F0", VA = "0x1878F90F0", Slot = "6")]
	public void ENOBMOAGGEK(GPODHFNGINM PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x78F9E70", Offset = "0x78F9070", VA = "0x1878F9E70", Slot = "7")]
	public void JAIEOHFHIAJ(GPODHFNGINM PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x78F9410", Offset = "0x78F8610", VA = "0x1878F9410", Slot = "4")]
	public void FHJIJLKPAKP(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x78FA310", Offset = "0x78F9510", VA = "0x1878FA310", Slot = "5")]
	public void LEHAKIHJFLL(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x78FA230", Offset = "0x78F9430", VA = "0x1878FA230")]
	private void KDDMFANMNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x78FA2D0", Offset = "0x78F94D0", VA = "0x1878FA2D0")]
	private void KNGCFBAHNAL(GPODHFNGINM PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x78FA0F0", Offset = "0x78F92F0", VA = "0x1878FA0F0")]
	private void JDFDFGIKOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x78F8B10", Offset = "0x78F7D10", VA = "0x1878F8B10")]
	private void AIANCDJFLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x78FA4F0", Offset = "0x78F96F0", VA = "0x1878FA4F0")]
	private void MMFLAJIDMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x78F8CF0", Offset = "0x78F7EF0", VA = "0x1878F8CF0")]
	[CompilerGenerated]
	private object AMNFPCNDOJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DHKEJMCMJJD
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7903D50", Offset = "0x7902F50", VA = "0x187903D50")]
	public static JJJFBACIGMO GKLKJFNCMJJ(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class AGKNJAGKNHB : OKGDGMDPBBG, DLOAEDALFLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NCAPDKFFCEO<GPODHFNGINM> HPGDOOMCFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EIENJIJOECG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NCAPDKFFCEO<GPODHFNGINM> PHHEKNCPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 BGLIEPHCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x78F88A0", Offset = "0x78F7AA0", VA = "0x1878F88A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FEIHJPDIJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x78F7DC0", Offset = "0x78F6FC0", VA = "0x1878F7DC0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 DIFJPKIBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x78F8930", Offset = "0x78F7B30", VA = "0x1878F8930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GPODHFNGINM KLBLFEMPJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x78F80C0", Offset = "0x78F72C0", VA = "0x1878F80C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x78F8A10", Offset = "0x78F7C10", VA = "0x1878F8A10")]
	public AGKNJAGKNHB(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x78F7D50", Offset = "0x78F6F50", VA = "0x1878F7D50", Slot = "8")]
	public void CDDDHFKGLMK(GPODHFNGINM DBEHKFODEEL, object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x78F88D0", Offset = "0x78F7AD0", VA = "0x1878F88D0", Slot = "9")]
	public void KMJGDJIDDDP(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x78F8500", Offset = "0x78F7700", VA = "0x1878F8500")]
	private Vector3 GFCFHKJLKDI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x78F8170", Offset = "0x78F7370", VA = "0x1878F8170")]
	private void ENHODMCCECK(GPODHFNGINM GAJGCJHCMIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EHMAOKADACC
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x79077F0", Offset = "0x79069F0", VA = "0x1879077F0")]
	public static OKGDGMDPBBG KCCGOGHBNKF(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JNDOOAFFJHG : BBAGFHLJGFK, PKEMFPDBFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 BAKALIDCPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JBBMMGPDEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GOGOOMKLMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BDJPIEGPIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 LLIIAJAIFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? FIGDPMEJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? CKFDGHNJDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool NCIGEECNPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool AKGALCKEJDI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 BOMNJPLGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x13CFCD0", Offset = "0x13CEED0", VA = "0x1813CFCD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x790A210", Offset = "0x7909410", VA = "0x18790A210", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 KDDCIOBPFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x79098D0", Offset = "0x7908AD0", VA = "0x1879098D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float MHFOCONJJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xB88350", Offset = "0xB87550", VA = "0x180B88350", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x79097C0", Offset = "0x79089C0", VA = "0x1879097C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float KCGMIHMMMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA2980", Offset = "0xAA1B80", VA = "0x180AA2980", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x79099C0", Offset = "0x7908BC0", VA = "0x1879099C0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 BHMICBBNMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x790A080", Offset = "0x7909280", VA = "0x18790A080", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion PNEPICKOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x790A2C0", Offset = "0x79094C0", VA = "0x18790A2C0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x78FA9F0", Offset = "0x78F9BF0", VA = "0x1878FA9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event KDJOAOJNEEJ KAOBEHPJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7909630", Offset = "0x7908830", VA = "0x187909630", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7909C10", Offset = "0x7908E10", VA = "0x187909C10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x790BC80", Offset = "0x790AE80", VA = "0x18790BC80")]
	public JNDOOAFFJHG(GPODHFNGINM MNIAPDGOICH, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x790B9F0", Offset = "0x790ABF0", VA = "0x18790B9F0", Slot = "17")]
	public void PDHIFPIEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x790BBA0", Offset = "0x790ADA0", VA = "0x18790BBA0", Slot = "16")]
	public void PENJBFJGOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x790A440", Offset = "0x7909640", VA = "0x18790A440", Slot = "19")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x790A520", Offset = "0x7909720", VA = "0x18790A520", Slot = "20")]
	public void LDGOEKADJHE(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7909CB0", Offset = "0x7908EB0", VA = "0x187909CB0", Slot = "18")]
	public void HDPMPMKEGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x790B570", Offset = "0x790A770", VA = "0x18790B570", Slot = "21")]
	public void MPIJFJILGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x790A210", Offset = "0x7909410", VA = "0x18790A210")]
	private void PKEJIDAMEGL(Vector3 OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x79096D0", Offset = "0x79088D0", VA = "0x1879096D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CFBKADNADPP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x79097C0", Offset = "0x79089C0", VA = "0x1879097C0")]
	private void DJPEJIPNNEA(float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x79099C0", Offset = "0x7908BC0", VA = "0x1879099C0")]
	private void GJIHEAOBHBL(float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7909A70", Offset = "0x7908C70", VA = "0x187909A70")]
	private Vector3 GLDABDGPIHB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7909E50", Offset = "0x7909050", VA = "0x187909E50", Slot = "15")]
	public void IDKDLMIKDGJ((Quaternion rot, Vector3 moments) MKOKFACDBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x79094B0", Offset = "0x79086B0", VA = "0x1879094B0")]
	private Quaternion ANBCIEEFLDK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x790A700", Offset = "0x7909900", VA = "0x18790A700")]
	public void LNJGMNJBNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x790A7D0", Offset = "0x79099D0", VA = "0x18790A7D0", Slot = "4")]
	public (float, Vector3) LNJGMNJBNHH(Rigidbody KCBIGHJEAJH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class BPPLNMEDEFJ
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x78FD3B0", Offset = "0x78FC5B0", VA = "0x1878FD3B0")]
	public static BBAGFHLJGFK FDFCHGJNCID(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PAFNCGEPJHE : HLLCMNODPMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PNEMCEGHFHA DKMLENLBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DCBINGCLJFB KNCGOCBINPC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CAENBGFCGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x155B590", Offset = "0x155A790", VA = "0x18155B590", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public DCBINGCLJFB MGKAEFACEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0", Slot = "11")]
		get
		{
			return default(DCBINGCLJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x790DBE0", Offset = "0x790CDE0", VA = "0x18790DBE0")]
	public PAFNCGEPJHE(GPODHFNGINM MNIAPDGOICH, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x790D950", Offset = "0x790CB50", VA = "0x18790D950", Slot = "4")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x790D8B0", Offset = "0x790CAB0", VA = "0x18790D8B0")]
	private bool OKGALPLOHDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x790D850", Offset = "0x790CA50", VA = "0x18790D850", Slot = "5")]
	public void NKNADPIGHOJ(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x790D880", Offset = "0x790CA80", VA = "0x18790D880", Slot = "6")]
	public void OJKFBDOIMDE(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x790D710", Offset = "0x790C910", VA = "0x18790D710", Slot = "9")]
	public void KMOMBCKCPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x790D5B0", Offset = "0x790C7B0", VA = "0x18790D5B0")]
	private void COMCMHLMNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x790DA60", Offset = "0x790CC60", VA = "0x18790DA60")]
	private void PPNJGLJCHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x790D6D0", Offset = "0x790C8D0", VA = "0x18790D6D0", Slot = "8")]
	public void JOMGCNKNCCA(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x790DA20", Offset = "0x790CC20", VA = "0x18790DA20", Slot = "7")]
	public void PBPAGEAFEIB(GPODHFNGINM MNIAPDGOICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BFEMMCAHCFP : GPDENLEMHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PNEMCEGHFHA JEKIIBKKEFH;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool NENADNLDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x78FC4C0", Offset = "0x78FB6C0", VA = "0x1878FC4C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KDJOAOJNEEJ GCMCIAGJEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x78FC3A0", Offset = "0x78FB5A0", VA = "0x1878FC3A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x78FC5B0", Offset = "0x78FB7B0", VA = "0x1878FC5B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x78FC660", Offset = "0x78FB860", VA = "0x1878FC660")]
	public BFEMMCAHCFP(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x78FC650", Offset = "0x78FB850", VA = "0x1878FC650", Slot = "7")]
	public void PKPIKGGLDIE(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x78FC5A0", Offset = "0x78FB7A0", VA = "0x1878FC5A0", Slot = "8")]
	public void OONALJJEKJP(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x78FC290", Offset = "0x78FB490", VA = "0x1878FC290", Slot = "9")]
	public void EKPMOCNLHAD(object BCOHKLCJCPM, bool EEJHBJOAMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x78FC250", Offset = "0x78FB450", VA = "0x1878FC250", Slot = "12")]
	public void AJFLJLFOBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x78FC440", Offset = "0x78FB640", VA = "0x1878FC440", Slot = "10")]
	public void KMOHDOPDJEA(Rigidbody MHCBGAAMHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x78FC570", Offset = "0x78FB770", VA = "0x1878FC570", Slot = "11")]
	public void LDGOEKADJHE(Rigidbody DKODMFMIHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class ADHPBLIPNJP : NKIMLPIDDKN, DCIFPMGOGCL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView CEPBBDKEOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HMLEOINKPMG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView GBFPCKBOHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool CDGJNGKBODD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x78F7580", Offset = "0x78F6780", VA = "0x1878F7580", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool NGMOEHIJKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KDJOAOJNEEJ GILNHIDCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x78F7A20", Offset = "0x78F6C20", VA = "0x1878F7A20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x78F75A0", Offset = "0x78F67A0", VA = "0x1878F75A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x78F7BF0", Offset = "0x78F6DF0", VA = "0x1878F7BF0")]
	public ADHPBLIPNJP(GPODHFNGINM MNIAPDGOICH, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x78F7AC0", Offset = "0x78F6CC0", VA = "0x1878F7AC0", Slot = "9")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x78F7480", Offset = "0x78F6680", VA = "0x1878F7480", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x78F7310", Offset = "0x78F6510", VA = "0x1878F7310", Slot = "10")]
	public void BFLPDOLHOFC(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x78F71A0", Offset = "0x78F63A0", VA = "0x1878F71A0", Slot = "11")]
	public void BEPELMIMBBM(GPODHFNGINM DBEHKFODEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x78F78B0", Offset = "0x78F6AB0", VA = "0x1878F78B0")]
	private void ODLMPPOCONH(PhotonView FHBNPKHBBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x78F7050", Offset = "0x78F6250", VA = "0x1878F7050")]
	private void APPDPAHAKNN(ELOCKNMGHMD PENJHIDBPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x78F7640", Offset = "0x78F6840", VA = "0x1878F7640")]
	private void KEPPFAIBEPB(PhotonView EGMGAPNEJDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class ABCOOFCDIJN
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x78F6F90", Offset = "0x78F6190", VA = "0x1878F6F90")]
	public static NKIMLPIDDKN CJEDBFAHFHL(this GPODHFNGINM CMFHMEJHOAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JFNOGHIEJEC : CJDPLBKKDCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints AOGKGEKOLBE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HKGLPHFJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xADD730", Offset = "0xADC930", VA = "0x180ADD730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBC1D70", Offset = "0xBC0F70", VA = "0x180BC1D70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool ELNLGNBLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xBC2520", Offset = "0xBC1720", VA = "0x180BC2520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xBC1D60", Offset = "0xBC0F60", VA = "0x180BC1D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints DFENNLLJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x79092D0", Offset = "0x79084D0", VA = "0x1879092D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7909400", Offset = "0x7908600", VA = "0x187909400")]
	public JFNOGHIEJEC(GPODHFNGINM MNIAPDGOICH, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7909270", Offset = "0x7908470", VA = "0x187909270", Slot = "9")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x79092A0", Offset = "0x79084A0", VA = "0x1879092A0", Slot = "10")]
	public void LDGOEKADJHE(Rigidbody DKODMFMIHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GDCKJMECFNA : DOEGJPLKGMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GPODHFNGINM MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float PLJIBPHCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float PJDGNNPGGJH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KPFLLIFAFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xD59F40", Offset = "0xD59140", VA = "0x180D59F40", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7908610", Offset = "0x7907810", VA = "0x187908610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float CGJJNJKHIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xBCFDE0", Offset = "0xBCEFE0", VA = "0x180BCFDE0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x79086E0", Offset = "0x79078E0", VA = "0x1879086E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x79088A0", Offset = "0x7907AA0", VA = "0x1879088A0")]
	public GDCKJMECFNA(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x79087B0", Offset = "0x79079B0", VA = "0x1879087B0", Slot = "8")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7908800", Offset = "0x7907A00", VA = "0x187908800", Slot = "9")]
	public void LDGOEKADJHE(Rigidbody DKODMFMIHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ALBOPKJBKII : NKDCECCBNKF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KJMCEDJMPPA GBEGAJCDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool KBICFKPANMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool FOHDDCPLNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int BDEHFOACKBD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x78FA9F0", Offset = "0x78F9BF0", VA = "0x1878FA9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EGOBIGBDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x78FB160", Offset = "0x78FA360", VA = "0x1878FB160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GPODHFNGINM ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x78FAC00", Offset = "0x78F9E00", VA = "0x1878FAC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool CICFKLPBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x78FAFD0", Offset = "0x78FA1D0", VA = "0x1878FAFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KDJOAOJNEEJ IDCOKMCLOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x78FAE90", Offset = "0x78FA090", VA = "0x1878FAE90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x78FAF30", Offset = "0x78FA130", VA = "0x1878FAF30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x78FB5E0", Offset = "0x78FA7E0", VA = "0x1878FB5E0")]
	public ALBOPKJBKII(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x78FB420", Offset = "0x78FA620", VA = "0x1878FB420", Slot = "6")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x78FA9E0", Offset = "0x78F9BE0", VA = "0x1878FA9E0", Slot = "8")]
	public void CCHLLDBAMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x78FAA40", Offset = "0x78F9C40", VA = "0x1878FAA40", Slot = "7")]
	public bool DPCOCGEBANM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x78FB4B0", Offset = "0x78FA6B0", VA = "0x1878FB4B0", Slot = "9")]
	public void POBEMAFBMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x78FADF0", Offset = "0x78F9FF0", VA = "0x1878FADF0", Slot = "13")]
	public void HILANGOBFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x78FB030", Offset = "0x78FA230", VA = "0x1878FB030", Slot = "12")]
	public void JNEJAJFGDLG(bool JPBJILNOAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x78FAB90", Offset = "0x78F9D90", VA = "0x1878FAB90", Slot = "10")]
	public bool EADNODBECID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x78FB180", Offset = "0x78FA380", VA = "0x1878FB180", Slot = "11")]
	public bool MCACDEJHMFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x78FB240", Offset = "0x78FA440", VA = "0x1878FB240")]
	private bool NJCFIFJECMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x78FAC60", Offset = "0x78F9E60", VA = "0x1878FAC60")]
	private void GGFBOGOOEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class AOKPGBMEPKA : KADCMIGDHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PNEMCEGHFHA GIMIIMBBOEK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody CBOGJJMPNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool CICFKLPBGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x78FBD40", Offset = "0x78FAF40", VA = "0x1878FBD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool HFNLMDDOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x155B590", Offset = "0x155A790", VA = "0x18155B590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x78FBE70", Offset = "0x78FB070", VA = "0x1878FBE70")]
	public AOKPGBMEPKA(GPODHFNGINM MNIAPDGOICH, [In] ENALNGMJFGO LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x78FBDD0", Offset = "0x78FAFD0", VA = "0x1878FBDD0", Slot = "5")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x78FBDA0", Offset = "0x78FAFA0", VA = "0x1878FBDA0", Slot = "7")]
	public void MCBPMNODKFL(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x78FBD10", Offset = "0x78FAF10", VA = "0x1878FBD10", Slot = "8")]
	public void JFABOKLMNDF(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x78FB9E0", Offset = "0x78FABE0", VA = "0x1878FB9E0", Slot = "9")]
	public void CGKBLJCPEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x78FB670", Offset = "0x78FA870", VA = "0x1878FB670", Slot = "10")]
	public void AFPFFMCHCNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x78FB860", Offset = "0x78FAA60", VA = "0x1878FB860", Slot = "11")]
	public void BJGEAIEOINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class ECGBJGOCMHM : EJACBJOHKFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CBPFBOFIOEF MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PNEMCEGHFHA GFDBIGCCAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float BIADNHCEEAK;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NBAEIOPIALM ANCCMGOONMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PPIGDFPOOHP BHIKJHJICOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 DIFJPKIBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7907360", Offset = "0x7906560", VA = "0x187907360", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x79072A0", Offset = "0x79064A0", VA = "0x1879072A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JGGPFBFLABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7906000", Offset = "0x7905200", VA = "0x187906000", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7904AF0", Offset = "0x7903CF0", VA = "0x187904AF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 KGPGDELOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7905880", Offset = "0x7904A80", VA = "0x187905880", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x79071E0", Offset = "0x79063E0", VA = "0x1879071E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 GEOOMBNALKG
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7904960", Offset = "0x7903B60", VA = "0x187904960", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7905E40", Offset = "0x7905040", VA = "0x187905E40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float DDDMPMDMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE8C840", Offset = "0xE8BA40", VA = "0x180E8C840", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x79047F0", Offset = "0x79039F0", VA = "0x1879047F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ABPMBIIOFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1E80090", Offset = "0x1E7F290", VA = "0x181E80090", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private PNNPIJIGHHA LHBJIJONMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7031E20", Offset = "0x7031020", VA = "0x187031E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool EGOBIGBDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7906DD0", Offset = "0x7905FD0", VA = "0x187906DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7907700", Offset = "0x7906900", VA = "0x187907700")]
	public ECGBJGOCMHM(GPODHFNGINM MNIAPDGOICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x79051E0", Offset = "0x79043E0", VA = "0x1879051E0", Slot = "19")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x79052F0", Offset = "0x79044F0", VA = "0x1879052F0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7906860", Offset = "0x7905A60", VA = "0x187906860", Slot = "28")]
	public void KMOHDOPDJEA(Rigidbody DKODMFMIHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1374570", Offset = "0x1373770", VA = "0x181374570", Slot = "20")]
	public void NIDOOLBAHOH(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1373840", Offset = "0x1372A40", VA = "0x181373840", Slot = "30")]
	public void MKOFAFPELCH(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7907520", Offset = "0x7906720", VA = "0x187907520", Slot = "35")]
	public Vector3 PNNMIOGPOAO(Vector3 OBJBFFGONOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7906990", Offset = "0x7905B90", VA = "0x187906990", Slot = "34")]
	public Vector3 LABHOECDIAM(Vector3 BDFPPBAJEKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x79051E0", Offset = "0x79043E0", VA = "0x1879051E0", Slot = "27")]
	public void DIMCELBBHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7905290", Offset = "0x7904490", VA = "0x187905290", Slot = "25")]
	public void DIMNJEAJCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7904050", Offset = "0x7903250", VA = "0x187904050", Slot = "24")]
	public void AEIJIEGLGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7904B20", Offset = "0x7903D20", VA = "0x187904B20", Slot = "33")]
	public void CFEJJDMIMHC(Vector3 DDEHOJMJKFE, Vector3 PBACHNIDMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7904900", Offset = "0x7903B00", VA = "0x187904900", Slot = "32")]
	public void BCPOLNFJONJ(Vector3 MNIOOCMEKFF, Vector3 EDPKEMKJOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7904650", Offset = "0x7903850", VA = "0x187904650", Slot = "31")]
	public void ALFKLFMKHGI(Vector3 MODNMCMOGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7906180", Offset = "0x7905380", VA = "0x187906180", Slot = "22")]
	public void KDALCBEOLGH(BCFMLJKNNCD DJDEEKAABAM, Vector3 AFILDHPCPMP, float APGCJNOHJED, float MJCEINCCACJ = 8f, float JCCODJMCPLL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7906B50", Offset = "0x7905D50", VA = "0x187906B50", Slot = "21")]
	public void LEOKIPACBIJ(IEAEOEGIAFO PAKJIFKAIDO, Vector3 IBABFPJEHLF, float CJDFGFLAADO = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7906DF0", Offset = "0x7905FF0", VA = "0x187906DF0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LKMEOLGJABC(IEAEOEGIAFO PAKJIFKAIDO, Vector3 EGIHDGHICMO, float ECJPGOHLCGO = 7f, float KJLDKEIPCJB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x14951D0", Offset = "0x14943D0", VA = "0x1814951D0")]
	private static void ELNBODFFLOC(Vector3 BEIJOKHFPBB, Vector3 LAOLFCMCDHJ, [Out] Vector3 PFDGFICAHDD, [Out] Vector3 MNNBMDDDHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7905BE0", Offset = "0x7904DE0", VA = "0x187905BE0", Slot = "29")]
	public Vector3 FEIPGENEBFC(Vector3 BEIJOKHFPBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7905E70", Offset = "0x7905070", VA = "0x187905E70", Slot = "26")]
	public void IPMCPJFIIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x79047F0", Offset = "0x79039F0", VA = "0x1879047F0")]
	private void MKHNDOHEOPG(float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7905A40", Offset = "0x7904C40", VA = "0x187905A40")]
	private void FDMEGNKOHCJ(Vector3 IBABFPJEHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7905CC0", Offset = "0x7904EC0", VA = "0x187905CC0")]
	private Vector3 FMCCEBBFLOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7904D60", Offset = "0x7903F60", VA = "0x187904D60")]
	private void CHONDDFNELM(Vector3 BDFPPBAJEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x79066D0", Offset = "0x79058D0", VA = "0x1879066D0")]
	private Vector3 KIJCJCMDGHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7905350", Offset = "0x7904550", VA = "0x187905350")]
	private void EAGLEDBELIH(Vector3 OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x79040B0", Offset = "0x79032B0", VA = "0x1879040B0")]
	private void ALFGIFINKCA(Vector3 BDFPPBAJEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x79057D0", Offset = "0x79049D0", VA = "0x1879057D0")]
	private void EKHPAOKBHMN()
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
