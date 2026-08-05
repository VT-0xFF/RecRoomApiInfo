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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85B45B0", Offset = "0x85B31B0", VA = "0x1885B45B0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F81230", Offset = "0x7F7FE30", VA = "0x187F81230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85C4130", Offset = "0x85C2D30", VA = "0x1885C4130")]
		private void HNLBFOBJPNI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85C4430", Offset = "0x85C3030", VA = "0x1885C4430", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85C4490", Offset = "0x85C3090", VA = "0x1885C4490")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, IODHBDFJLPB, MIGNIEJDGMD, PPEMHOCDPPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly JPIBGNDAFKP PCHMIECJBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KIMMJFNDLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private EADBHHGHCOL DKNLNFGOMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[MHLPBMEFLGC(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MHLPBMEFLGC(EBAHNMNBCJP.SelfAndParent, true, false, false)]
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
		private GKDEPMMONOP physicsInterpolation;

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
		private Transform DBOLCANJDOK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal EADBHHGHCOL KIEIIBLKGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85BFE80", Offset = "0x85BEA80", VA = "0x1885BFE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private EADBHHGHCOL EDOMFPFLGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KAHKOGIKFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x85C1640", Offset = "0x85C0240", VA = "0x1885C1640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx KHOICOLFHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x85C19A0", Offset = "0x85C05A0", VA = "0x1885C19A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx MMGGJKMBNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85C18E0", Offset = "0x85C04E0", VA = "0x1885C18E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx LIPFJJEAFCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85C25A0", Offset = "0x85C11A0", VA = "0x1885C25A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x85C3AA0", Offset = "0x85C26A0", VA = "0x1885C3AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FOFOENEBAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x81EF050", Offset = "0x81EDC50", VA = "0x1881EF050", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x81EDF20", Offset = "0x81ECB20", VA = "0x1881EDF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NMIBCHFJGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x23AEB90", Offset = "0x23AD790", VA = "0x1823AEB90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform GCADGIEGBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x23AEB90", Offset = "0x23AD790", VA = "0x1823AEB90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform KPEKEICBDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x23AEB90", Offset = "0x23AD790", VA = "0x1823AEB90", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FDCMEMEDMHG BAIEILCIPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85C16A0", Offset = "0x85C02A0", VA = "0x1885C16A0")]
			get
			{
				return default(FDCMEMEDMHG);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85C3250", Offset = "0x85C1E50", VA = "0x1885C3250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KAAEIICEOJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85C1CB0", Offset = "0x85C08B0", VA = "0x1885C1CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool CNLFLMDCNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x85C17C0", Offset = "0x85C03C0", VA = "0x1885C17C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LMAIOBGFFMJ DBNNHGCNHAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85C1BF0", Offset = "0x85C07F0", VA = "0x1885C1BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85C3410", Offset = "0x85C2010", VA = "0x1885C3410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JKCAKHJBMFN PDHGEMIBIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85C1B90", Offset = "0x85C0790", VA = "0x1885C1B90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85C33A0", Offset = "0x85C1FA0", VA = "0x1885C33A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OCLDBLJLAGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x85C1AE0", Offset = "0x85C06E0", VA = "0x1885C1AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody FIMACPMLNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x85C1B40", Offset = "0x85C0740", VA = "0x1885C1B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NFJJJKKIPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85C1820", Offset = "0x85C0420", VA = "0x1885C1820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85C32C0", Offset = "0x85C1EC0", VA = "0x1885C32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MNLIIJNIENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x81EF0E0", Offset = "0x81EDCE0", VA = "0x1881EF0E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BAJCHNMLGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85C2540", Offset = "0x85C1140", VA = "0x1885C2540")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ANMIDDLBPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x85C24E0", Offset = "0x85C10E0", VA = "0x1885C24E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x85C3A30", Offset = "0x85C2630", VA = "0x1885C3A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OFPPMINECCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85C1F10", Offset = "0x85C0B10", VA = "0x1885C1F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x85C36B0", Offset = "0x85C22B0", VA = "0x1885C36B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float DCMEDBFEGHF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D10", Offset = "0x85C0910", VA = "0x1885C1D10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x85C3480", Offset = "0x85C2080", VA = "0x1885C3480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NOCCNBOCIDC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x85C2AF0", Offset = "0x85C16F0", VA = "0x1885C2AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x85C3FE0", Offset = "0x85C2BE0", VA = "0x1885C3FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 HCICGPGCKNH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x85C22C0", Offset = "0x85C0EC0", VA = "0x1885C22C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x85C3800", Offset = "0x85C2400", VA = "0x1885C3800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 LPPOFOKOPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x85C2C30", Offset = "0x85C1830", VA = "0x1885C2C30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode APFILKCKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x85C1E50", Offset = "0x85C0A50", VA = "0x1885C1E50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x85C35D0", Offset = "0x85C21D0", VA = "0x1885C35D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FMNHKGBBGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x85C1880", Offset = "0x85C0480", VA = "0x1885C1880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x85C3330", Offset = "0x85C1F30", VA = "0x1885C3330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints JJDIIFPJODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85C1EB0", Offset = "0x85C0AB0", VA = "0x1885C1EB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85C3640", Offset = "0x85C2240", VA = "0x1885C3640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 LDFDCAOFICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x85C2660", Offset = "0x85C1260", VA = "0x1885C2660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 APELEAMNEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x85C2660", Offset = "0x85C1260", VA = "0x1885C2660")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x85C3DC0", Offset = "0x85C29C0", VA = "0x1885C3DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HKEPCDNIKBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x85C23A0", Offset = "0x85C0FA0", VA = "0x1885C23A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85C38E0", Offset = "0x85C24E0", VA = "0x1885C38E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float DAGNBILGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85C2A90", Offset = "0x85C1690", VA = "0x1885C2A90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x85C3F70", Offset = "0x85C2B70", VA = "0x1885C3F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NBGOGAPFMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x85C2740", Offset = "0x85C1340", VA = "0x1885C2740")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85C3B40", Offset = "0x85C2740", VA = "0x1885C3B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion HBMMMHHEJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85C29C0", Offset = "0x85C15C0", VA = "0x1885C29C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x85C3EA0", Offset = "0x85C2AA0", VA = "0x1885C3EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 MGAJHKODOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x85C2810", Offset = "0x85C1410", VA = "0x1885C2810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x85C3C10", Offset = "0x85C2810", VA = "0x1885C3C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BEGGLEDNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x85C28F0", Offset = "0x85C14F0", VA = "0x1885C28F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x85C3CF0", Offset = "0x85C28F0", VA = "0x1885C3CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PLOBHHEKGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x85C2B50", Offset = "0x85C1750", VA = "0x1885C2B50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x85C4050", Offset = "0x85C2C50", VA = "0x1885C4050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KHCAEECDNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85C2400", Offset = "0x85C1000", VA = "0x1885C2400")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85C3950", Offset = "0x85C2550", VA = "0x1885C3950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NOBIPBDPLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D70", Offset = "0x85C0970", VA = "0x1885C1D70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85C34F0", Offset = "0x85C20F0", VA = "0x1885C34F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FAFGAPDLINP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85C21E0", Offset = "0x85C0DE0", VA = "0x1885C21E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x85C3720", Offset = "0x85C2320", VA = "0x1885C3720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CEKIKLAHOOP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85C20A0", Offset = "0x85C0CA0", VA = "0x1885C20A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion PPICPDJMKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85C1FD0", Offset = "0x85C0BD0", VA = "0x1885C1FD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EPLDJEKLCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x85C2DF0", Offset = "0x85C19F0", VA = "0x1885C2DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 AELGFPDHFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85C2D10", Offset = "0x85C1910", VA = "0x1885C2D10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HGHHIPDEAMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85C2180", Offset = "0x85C0D80", VA = "0x1885C2180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BLGIDELGDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85C1C50", Offset = "0x85C0850", VA = "0x1885C1C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GKOFIHHONPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85C1760", Offset = "0x85C0360", VA = "0x1885C1760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool IHGINKKDLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85C1700", Offset = "0x85C0300", VA = "0x1885C1700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CIKKFEDDEPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85C15E0", Offset = "0x85C01E0", VA = "0x1885C15E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool GIAMJFDILBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85C1F70", Offset = "0x85C0B70", VA = "0x1885C1F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PPEBHELAIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x256EB60", Offset = "0x256D760", VA = "0x18256EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NKGOBEKODPF CAKACDMFDLE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85C1500", Offset = "0x85C0100", VA = "0x1885C1500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x85C3170", Offset = "0x85C1D70", VA = "0x1885C3170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LNOEFCDNOHA GDJBBFNCKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85C1270", Offset = "0x85BFE70", VA = "0x1885C1270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85C2ED0", Offset = "0x85C1AD0", VA = "0x1885C2ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LNOEFCDNOHA MMLABBPOMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85C12D0", Offset = "0x85BFED0", VA = "0x1885C12D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x85C2F40", Offset = "0x85C1B40", VA = "0x1885C2F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event LNOEFCDNOHA PDNDHCJJDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x85C1420", Offset = "0x85C0020", VA = "0x1885C1420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85C3090", Offset = "0x85C1C90", VA = "0x1885C3090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<OEENMKMDDDK, OEENMKMDDDK> FENHDBEDJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85C13B0", Offset = "0x85BFFB0", VA = "0x1885C13B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85C3020", Offset = "0x85C1C20", VA = "0x1885C3020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event LNOEFCDNOHA DIFIHJBJEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85C1490", Offset = "0x85C0090", VA = "0x1885C1490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85C3100", Offset = "0x85C1D00", VA = "0x1885C3100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event LNOEFCDNOHA DLMBHHLIDHF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85C1570", Offset = "0x85C0170", VA = "0x1885C1570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85C31E0", Offset = "0x85C1DE0", VA = "0x1885C31E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event LNOEFCDNOHA KJEFEAPCMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85C1340", Offset = "0x85BFF40", VA = "0x1885C1340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85C2FB0", Offset = "0x85C1BB0", VA = "0x1885C2FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0", Slot = "8")]
		private void MOHDENKCIBK(EADBHHGHCOL JCPBJCFMJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85BFDF0", Offset = "0x85BE9F0", VA = "0x1885BFDF0", Slot = "9")]
		public EOOCHJMGNCA GetData()
		{
			return default(EOOCHJMGNCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF930", Offset = "0x85BE530", VA = "0x1885BF930")]
		internal void ECBGBOGMMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85C0FA0", Offset = "0x85BFBA0", VA = "0x1885C0FA0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CEEGPENJFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB40", Offset = "0x85BE740", VA = "0x1885BFB40")]
		public IODHBDFJLPB GetChild(int EMMACFPOKFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85C0C00", Offset = "0x85BF800", VA = "0x1885C0C00")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) LKNPLOMJHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85BF580", Offset = "0x85BE180", VA = "0x1885BF580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85C0E90", Offset = "0x85BFA90", VA = "0x1885C0E90")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85BFE80", Offset = "0x85BEA80", VA = "0x1885BFE80")]
		private EADBHHGHCOL HBMNMPALOGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85BF9C0", Offset = "0x85BE5C0", VA = "0x1885BF9C0")]
		private void GFFHNKPMBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85C03C0", Offset = "0x85BEFC0", VA = "0x1885C03C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85C0300", Offset = "0x85BEF00", VA = "0x1885C0300")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85BF930", Offset = "0x85BE530", VA = "0x1885BF930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85C0360", Offset = "0x85BEF60", VA = "0x1885C0360")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85C0420", Offset = "0x85BF020", VA = "0x1885C0420")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85BEB70", Offset = "0x85BD770", VA = "0x1885BEB70")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85C0490", Offset = "0x85BF090", VA = "0x1885C0490")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85BF8D0", Offset = "0x85BE4D0", VA = "0x1885BF8D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85C02A0", Offset = "0x85BEEA0", VA = "0x1885C02A0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85C0D60", Offset = "0x85BF960", VA = "0x1885C0D60")]
		public void SetParent(RigidbodyEx OOHGFGHCOAJ, bool KIEEDBDBNHO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85C07A0", Offset = "0x85BF3A0", VA = "0x1885C07A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85BFF30", Offset = "0x85BEB30", VA = "0x1885BFF30")]
		public bool IsRigidbodyAncestor(RigidbodyEx EPHPNLHEOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85C0030", Offset = "0x85BEC30", VA = "0x1885C0030")]
		public bool IsRigidbodyDescendant(RigidbodyEx FMFOAHDOMBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85BEDE0", Offset = "0x85BD9E0", VA = "0x1885BEDE0")]
		public void AddInterpolationRestriction(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85C0500", Offset = "0x85BF100", VA = "0x1885C0500")]
		public void RemoveInterpolationRestriction(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85BEE50", Offset = "0x85BDA50", VA = "0x1885BEE50")]
		public void AddKinematic(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85C0570", Offset = "0x85BF170", VA = "0x1885C0570")]
		public void RemoveKinematic(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85C0CE0", Offset = "0x85BF8E0", VA = "0x1885C0CE0")]
		public void SetKinematic(object HEDGIMBCGHA, bool CBMPLHDBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85C0B00", Offset = "0x85BF700", VA = "0x1885C0B00")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MMDDGEEAFDM, Quaternion PKHGEFEODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85C0A00", Offset = "0x85BF600", VA = "0x1885C0A00")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NBPBOJNOCJM, Quaternion EGIHCMJEEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85BFCE0", Offset = "0x85BE8E0", VA = "0x1885BFCE0")]
		public Vector3 GetConstrainedVelocity(Vector3 PLOBHHEKGDJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85BFBD0", Offset = "0x85BE7D0", VA = "0x1885BFBD0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NOBIPBDPLMJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85BECF0", Offset = "0x85BD8F0", VA = "0x1885BECF0")]
		public void AddForce(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85BEBE0", Offset = "0x85BD7E0", VA = "0x1885BEBE0")]
		public void AddForceAtPosition(Vector3 JMDCPKFBLOI, Vector3 IIBJECFMAJC, ForceMode KHLACBHAFGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85BF020", Offset = "0x85BDC20", VA = "0x1885BF020")]
		public void AddTorque(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85BEEC0", Offset = "0x85BDAC0", VA = "0x1885BEEC0")]
		public void AddRelativeTorque(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85C1070", Offset = "0x85BFC70", VA = "0x1885C1070")]
		public Vector3 WorldToLocalVelocity(Vector3 MKKLJCLAENJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85C0190", Offset = "0x85BED90", VA = "0x1885C0190")]
		public Vector3 LocalToWorldVelocity(Vector3 KHCAEECDNDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85BF870", Offset = "0x85BE470", VA = "0x1885BF870")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF810", Offset = "0x85BE410", VA = "0x1885BF810")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85BF7B0", Offset = "0x85BE3B0", VA = "0x1885BF7B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85BF750", Offset = "0x85BE350", VA = "0x1885BF750")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85C0900", Offset = "0x85BF500", VA = "0x1885C0900")]
		public void ResetVelocityWorldSpace(Vector3 AABFLGNECOB, Vector3 FHPBADOOCKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x85C0800", Offset = "0x85BF400", VA = "0x1885C0800")]
		public void ResetVelocityLocalSpace(Vector3 PDOEEHIABID, Vector3 FAFGAPDLINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85C06C0", Offset = "0x85BF2C0", VA = "0x1885C06C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 PDOEEHIABID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85C0EA0", Offset = "0x85BFAA0", VA = "0x1885C0EA0")]
		public bool SweepTest(Vector3 HLIFPOIPBBB, [Out] RaycastHit AAJGGMIMFEH, float KNLGCBPGFKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85C0130", Offset = "0x85BED30", VA = "0x1885C0130")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85C0E30", Offset = "0x85BFA30", VA = "0x1885C0E30")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85C1010", Offset = "0x85BFC10", VA = "0x1885C1010")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x85BEFB0", Offset = "0x85BDBB0", VA = "0x1885BEFB0")]
		public void AddShouldHaveUnityRigidbodyToken(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85C05E0", Offset = "0x85BF1E0", VA = "0x1885C05E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85BF3B0", Offset = "0x85BDFB0", VA = "0x1885BF3B0")]
		public void ApplyForceVelocityChange(IBAPNPEDNNP GFBHFNJFEGM, Vector3 JIIHIAGFIGK, float HHKBILOIFPE, float ADBHMBMIDLI = 8f, float DKOCDAOHKFH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x85BF2B0", Offset = "0x85BDEB0", VA = "0x1885BF2B0")]
		public void ApplyAngularVelocityChange(MPBEDBOENLK BKMICPMKELA, Vector3 BLLAOHANMCE, float HKDLPFFMCIB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85BF470", Offset = "0x85BE070", VA = "0x1885BF470")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MPBEDBOENLK BKMICPMKELA, Vector3 BFEELDCLMGM, float IOPBCCGPEBC = 7f, float NNKGFLBDMBK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85BF1E0", Offset = "0x85BDDE0", VA = "0x1885BF1E0")]
		public bool AllowedScaleChange(float NPEKDNBDINN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF110", Offset = "0x85BDD10", VA = "0x1885BF110")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GOFCONACJJP, object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x85C0650", Offset = "0x85BF250", VA = "0x1885C0650")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85C0480", Offset = "0x85BF080", VA = "0x1885C0480", Slot = "13")]
		private void PKKLJMNNJGE(GJAKMMJKIGI CBLPKFIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85C1200", Offset = "0x85BFE00", VA = "0x1885C1200")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB0B80", Offset = "0xAAF780", VA = "0x180AB0B80", Slot = "4")]
		private GameObject ANDNJGEFFOJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1A0", Offset = "0xA49DA0", VA = "0x180A4B1A0", Slot = "10")]
		private bool PNAGGHBGEHF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class IGHFCEMIPMB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x85AF900", Offset = "0x85AE500", VA = "0x1885AF900")]
	public static EADBHHGHCOL KIEIIBLKGLI(this RigidbodyEx KBHNLJCJFLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LJECABOPODM), new string[] { })]
public class HJMKOAGCJBM : LJECABOPODM, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NDEMNJMPOBA ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GBNMABGGGEH KDIMDKGFHDD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NDEMNJMPOBA KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GBNMABGGGEH PNGDLEDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x85AD4D0", Offset = "0x85AC0D0", VA = "0x1885AD4D0", Slot = "7")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x85AD540", Offset = "0x85AC140", VA = "0x1885AD540", Slot = "6")]
	public EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public HJMKOAGCJBM()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static HBAAEHCBNNO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GMNABHIFMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int PDKCCKBCIKO;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85BE9F0", Offset = "0x85BD5F0", VA = "0x1885BE9F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85BEA30", Offset = "0x85BD630", VA = "0x1885BEA30")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85BEA10", Offset = "0x85BD610", VA = "0x1885BEA10")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FNFIPKNHEOF, [Optional] UnityEngine.Object CBLPKFIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FNFIPKNHEOF, [Optional] UnityEngine.Object CBLPKFIJGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85BEB20", Offset = "0x85BD720", VA = "0x1885BEB20")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ELDCBFGHKJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HPAGEONICAJ : LMAIOBGFFMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D870", Offset = "0xA2C470", VA = "0x180A2D870", Slot = "4")]
		public Vector3 PACLJIPJLOI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D870", Offset = "0xA2C470", VA = "0x180A2D870", Slot = "5")]
		public Vector3 FDDEGKCDOAD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "6")]
		public bool COGOEEHJMIE(float APFNPNDPMLP, float PAJIBFEJOBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HPAGEONICAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LMAIOBGFFMJ MJCOPPEAAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85AB0C0", Offset = "0x85A9CC0", VA = "0x1885AB0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NACFLKDGALI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode CFOLMFCLIOL
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
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHOPMDEKPIM(bool HGHHIPDEAMM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBNDNDFFPJK(bool HGHHIPDEAMM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NJOBNDEIHPK(Vector3 HLIFPOIPBBB, [Out] RaycastHit AAJGGMIMFEH, float KNLGCBPGFKL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BAIBCOFPBLI : IDisposable, CBIBIMNKCPL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FDCMEMEDMHG BAIEILCIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<OEENMKMDDDK, OEENMKMDDDK> FENHDBEDJNN;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJGFNKKBNHD();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface GBNMABGGGEH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGNHLDJELGI HKDGBMMGBBF(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DOJEKCBNICP AOBFJNHDNKC(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMOADJHJMNI KDAJLHLHIDC(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PDPIAFFLMKA OIMMEBBECNA(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IMIBDLFEBNK BAMJBIDGINH(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BAIBCOFPBLI CDJENMOPPGH(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HOHOIJLLJDP IPAFCDDMFDK(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENHGOHHABGE PFOAJBFKPGB(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NACFLKDGALI GBANEIEDOBO(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BJGJNADCIOH HNMBNLJILGE(EADBHHGHCOL JCPBJCFMJCO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JHHHHBDOGEM CDIPFBHKEFA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JHEIOEFBHBO LMFBFAKHNDG(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LKOEFGPOGPN EFDOHMAMBFL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CNDNEGHHBDA MLLEPNCCONM(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LFNBKAKDNJB OGHJPOOOJGA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC, EOOCHJMGNCA PEDMEJIDLNB, LJECABOPODM GMBCCEAGHDM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ENHGOHHABGE
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGJDCKNOFFI(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADEILJPAOFF(Vector3 JMDCPKFBLOI, Vector3 IIBJECFMAJC, ForceMode KHLACBHAFGM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGOMMKCIOLJ(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGEFMEIPEAO(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BJGJNADCIOH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MKKEOHFAMDK
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
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGNHLDJELGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<EADBHHGHCOL> DEDOJLIGOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EADBHHGHCOL MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LNOEFCDNOHA GDJBBFNCKDJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LNOEFCDNOHA MMLABBPOMIO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event NKGOBEKODPF KFPKMMEILIC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KLDBGBDBJMD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action IBHDIPKEKAO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<EADBHHGHCOL> GCBDADDKBMM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EADBHHGHCOL> GMHBFFBIDKN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IJMCKLENMLJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<EADBHHGHCOL> LLBGHBHMBGM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OAAMBAOIOOB(EADBHHGHCOL JHPFPLHIKAH, bool KIEEDBDBNHO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IMOADJHJMNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 OICBDALMHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 KJFFFNKHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBDNMOAAAJH(EADBHHGHCOL LIPFJJEAFCE, object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJKNMCBIMJI(object HEDGIMBCGHA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CNDNEGHHBDA
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 AEFNNECIPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ICOHFDFCKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float ICALMNBIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float HPNIPIHDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 MAABGALEAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion APNHJPBPEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event LNOEFCDNOHA EDHODKKGLLG;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BBNNMDLBGEI((Quaternion rot, Vector3 moments) LKNPLOMJHIG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLBFKBLGOAA();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ODDOIBMGJEC();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MNKHFAMJDOF();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OOBJPHFMIEL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LKOEFGPOGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDFGOJABFBK(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFNOBAOJAJG(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBADDNBIOJP(EADBHHGHCOL KBHNLJCJFLC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIBLLBBIMDB(EADBHHGHCOL KBHNLJCJFLC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CBLJNKOJEEH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HOHOIJLLJDP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HMCGEPBNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LNOEFCDNOHA PCFMOPPLHIH;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHGHFDPHKOH(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LONBJOKABJH(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKAJJOGPHOE(object HEDGIMBCGHA, bool CBMPLHDBDAJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNNHILOOMPM(Rigidbody LCBHJGJGEAD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JHEIOEFBHBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KAAEIICEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CNLFLMDCNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event LNOEFCDNOHA CNAOKDDACNB;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHOGGIKLDCM(EADBHHGHCOL LIPFJJEAFCE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJKHJLIONPC(EADBHHGHCOL LIPFJJEAFCE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LFNBKAKDNJB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NFJJJKKIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FIIIGNLJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints OKGCBBPILDK
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
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PDPIAFFLMKA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float OJDACIDBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float JDMNGAIEPNB
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
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IMIBDLFEBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool KADEDHGKOPO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LNOEFCDNOHA AMDDALDADAE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIBBMJGICDL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHBGNGCHEII();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOHFJLBKODA();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MBMDPKNBGIP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FPPMFBMODBC();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FFGOGFFAIFA(bool JKCLEMBHHLB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFHJKHNNKDK();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JHHHHBDOGEM
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool INFECABBEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHMOAFKJOHK(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFBDGKKPEKB(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJFKCOFEOP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DOJEKCBNICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	LMAIOBGFFMJ DBNNHGCNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	JKCAKHJBMFN PDHGEMIBIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 ODPIFACDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 KHFBCHDFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LELBJFGMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 BFIGAHMHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float FMNHKGBBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OCLDBLJLAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NOACDPBHKHI(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GDAPFOMNLMF(MPBEDBOENLK BKMICPMKELA, Vector3 BLLAOHANMCE, float HKDLPFFMCIB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MCNBCNIBGFA(IBAPNPEDNNP GFBHFNJFEGM, Vector3 JIIHIAGFIGK, float HHKBILOIFPE, float ADBHMBMIDLI = 8f, float DKOCDAOHKFH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LIGIGFIECDM(MPBEDBOENLK BKMICPMKELA, Vector3 BFEELDCLMGM, float IOPBCCGPEBC = 7f, float NNKGFLBDMBK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KHCNKJLJKHG();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PAJKABDAGFJ();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IHHGJKMLHPI();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EGLFPKADDFB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MNNHILOOMPM(Rigidbody KOGOAMNMHNP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 INAHMCMAAEB(Vector3 PLOBHHEKGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BABDHBILMNA(object HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MDJPOAOCGKP(Vector3 FBDGFEEKAPH);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LBFNJIDNBOD(Vector3 PDOEEHIABID, Vector3 FAFGAPDLINP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KFGOBBOADCN(Vector3 AABFLGNECOB, Vector3 FHPBADOOCKG);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LBPADMLAJPO(Vector3 KHCAEECDNDM);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 AHAHEAFAIOM(Vector3 MKKLJCLAENJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface NDEMNJMPOBA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool GKJBOJKFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIKEJBHBLGA(string AJLIMPCCGHB);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNJKGFLNLMK(RigidbodyEx KBHNLJCJFLC, Action IFDCDCHOGGB);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDEAHNEBJHO PJNGEAMBFFE(int BEBHIMMJFPB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJNFDJIHEIH(Vector3 LPPOFOKOPON, float GFAEHJHPDJJ, Color GCKOLKABAJC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LJECABOPODM
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NDEMNJMPOBA KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GBNMABGGGEH PNGDLEDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PFKDEFEEHLJ : EADBHHGHCOL, IDisposable, EBBFPPDKBKK
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool NKIDDCAGDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LJECABOPODM GMBCCEAGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JGNHLDJELGI GNNAEMCNMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LKOEFGPOGPN MHECNGJNLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JHEIOEFBHBO HCFPGDIDJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DOJEKCBNICP PLOBHHEKGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal IMOADJHJMNI PBHHFCAABLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal CNDNEGHHBDA GHJBOLKCBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal PDPIAFFLMKA BABAGFMFJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal BJGJNADCIOH JDFFMMLPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal IMIBDLFEBNK CEMHHOEGMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal BAIBCOFPBLI OMLFGDANLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HOHOIJLLJDP AJLLNPEEABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal ENHGOHHABGE JMDCPKFBLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal LFNBKAKDNJB NMMPKNMGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal JHHHHBDOGEM KOGOAMNMHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal NACFLKDGALI BHMPPHEHEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable IDEOEAGDNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LLCFNMKMOFA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "22")]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IODHBDFJLPB DDADIEEDCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA839C0", Offset = "0xA825C0", VA = "0x180A839C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0B0", Offset = "0xA98CB0", VA = "0x180A9A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4A0", Offset = "0xA290A0", VA = "0x180A2A4A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4D0", Offset = "0xA290D0", VA = "0x180A2A4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA9A080", Offset = "0xA98C80", VA = "0x180A9A080", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA9A030", Offset = "0xA98C30", VA = "0x180A9A030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85BB790", Offset = "0x85BA390", VA = "0x1885BB790", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x85BDDF0", Offset = "0x85BC9F0", VA = "0x1885BDDF0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85BC6E0", Offset = "0x85BB2E0", VA = "0x1885BC6E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KAHKOGIKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x85B8B60", Offset = "0x85B7760", VA = "0x1885B8B60", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EADBHHGHCOL MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x85BC3A0", Offset = "0x85BAFA0", VA = "0x1885BC3A0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool DGGJALNGJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x85BC740", Offset = "0x85BB340", VA = "0x1885BC740", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool KAAEIICEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x85B8CE0", Offset = "0x85B78E0", VA = "0x1885B8CE0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool CNLFLMDCNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85BBBD0", Offset = "0x85BA7D0", VA = "0x1885BBBD0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LMAIOBGFFMJ DBNNHGCNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85BD8C0", Offset = "0x85BC4C0", VA = "0x1885BD8C0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85BAFE0", Offset = "0x85B9BE0", VA = "0x1885BAFE0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JKCAKHJBMFN PDHGEMIBIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85BDCC0", Offset = "0x85BC8C0", VA = "0x1885BDCC0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x85BD9F0", Offset = "0x85BC5F0", VA = "0x1885BD9F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float FMNHKGBBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x85BE6B0", Offset = "0x85BD2B0", VA = "0x1885BE6B0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85BE700", Offset = "0x85BD300", VA = "0x1885BE700", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KHFBCHDFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x85B8110", Offset = "0x85B6D10", VA = "0x1885B8110", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x85BD4E0", Offset = "0x85BC0E0", VA = "0x1885BD4E0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 BFIGAHMHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB00", Offset = "0x85BC700", VA = "0x1885BDB00", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x85BC8B0", Offset = "0x85BB4B0", VA = "0x1885BC8B0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 ODPIFACDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85BC3F0", Offset = "0x85BAFF0", VA = "0x1885BC3F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85BB7E0", Offset = "0x85BA3E0", VA = "0x1885BB7E0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 LELBJFGMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x85BCCA0", Offset = "0x85BB8A0", VA = "0x1885BCCA0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x85BE580", Offset = "0x85BD180", VA = "0x1885BE580", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool GKOFIHHONPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x85BCE90", Offset = "0x85BBA90", VA = "0x1885BCE90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool IHGINKKDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x85BBC20", Offset = "0x85BA820", VA = "0x1885BBC20", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CIKKFEDDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x85B9390", Offset = "0x85B7F90", VA = "0x1885B9390", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool OCLDBLJLAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85BC4D0", Offset = "0x85BB0D0", VA = "0x1885BC4D0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 OICBDALMHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85BA050", Offset = "0x85B8C50", VA = "0x1885BA050", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 KJFFFNKHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x85BCBC0", Offset = "0x85BB7C0", VA = "0x1885BCBC0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 AEFNNECIPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85BA570", Offset = "0x85B9170", VA = "0x1885BA570", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x85BDD10", Offset = "0x85BC910", VA = "0x1885BDD10", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 ICOHFDFCKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x85B9520", Offset = "0x85B8120", VA = "0x1885B9520", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ICALMNBIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x85BA520", Offset = "0x85B9120", VA = "0x1885BA520", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float HPNIPIHDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x85BAB20", Offset = "0x85B9720", VA = "0x1885BAB20", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x85BE380", Offset = "0x85BCF80", VA = "0x1885BE380", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 MAABGALEAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x85BB0D0", Offset = "0x85B9CD0", VA = "0x1885BB0D0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion APNHJPBPEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x85BBFC0", Offset = "0x85BABC0", VA = "0x1885BBFC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float OJDACIDBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85B94D0", Offset = "0x85B80D0", VA = "0x1885B94D0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x85B84B0", Offset = "0x85B70B0", VA = "0x1885B84B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float JDMNGAIEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85BA120", Offset = "0x85B8D20", VA = "0x1885BA120", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x85BBF60", Offset = "0x85BAB60", VA = "0x1885BBF60", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool MKKEOHFAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x85B8920", Offset = "0x85B7520", VA = "0x1885B8920", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x85BC9F0", Offset = "0x85BB5F0", VA = "0x1885BC9F0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FDCMEMEDMHG BAIEILCIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x85BAAD0", Offset = "0x85B96D0", VA = "0x1885BAAD0", Slot = "70")]
		get
		{
			return default(FDCMEMEDMHG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x85BC850", Offset = "0x85BB450", VA = "0x1885BC850", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HMCGEPBNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x85BA2E0", Offset = "0x85B8EE0", VA = "0x1885BA2E0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform KPEKEICBDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA9A080", Offset = "0xA98C80", VA = "0x180A9A080", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 OMJNPDPKPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x85BC7A0", Offset = "0x85BB3A0", VA = "0x1885BC7A0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x85B8970", Offset = "0x85B7570", VA = "0x1885B8970", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float KBFPPGJADNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x85BAED0", Offset = "0x85B9AD0", VA = "0x1885BAED0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85BA390", Offset = "0x85B8F90", VA = "0x1885BA390", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float AFACDHALJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85BC9E0", Offset = "0x85BB5E0", VA = "0x1885BC9E0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x85BD7C0", Offset = "0x85BC3C0", VA = "0x1885BD7C0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion AMOOKIJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x85BE490", Offset = "0x85BD090", VA = "0x1885BE490", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x85BDBE0", Offset = "0x85BC7E0", VA = "0x1885BDBE0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 GKIMFBHMEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x85BE760", Offset = "0x85BD360", VA = "0x1885BE760", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x85BAEE0", Offset = "0x85B9AE0", VA = "0x1885BAEE0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion DINJLOEPCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x85BB210", Offset = "0x85B9E10", VA = "0x1885BB210", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x85BC090", Offset = "0x85BAC90", VA = "0x1885BC090", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints OKGCBBPILDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x85BC1F0", Offset = "0x85BADF0", VA = "0x1885BC1F0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85BD140", Offset = "0x85BBD40", VA = "0x1885BD140", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NFJJJKKIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85BDF40", Offset = "0x85BCB40", VA = "0x1885BDF40", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD80", Offset = "0x85BB980", VA = "0x1885BCD80", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode CFOLMFCLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x85B98B0", Offset = "0x85B84B0", VA = "0x1885B98B0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85BAF20", Offset = "0x85B9B20", VA = "0x1885BAF20", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LDHNLIEOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x85BA990", Offset = "0x85B9590", VA = "0x1885BA990", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool BLGIDELGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x85BD360", Offset = "0x85BBF60", VA = "0x1885BD360", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LNOEFCDNOHA GDJBBFNCKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85B8D30", Offset = "0x85B7930", VA = "0x1885B8D30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x85BC0C0", Offset = "0x85BACC0", VA = "0x1885BC0C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event LNOEFCDNOHA MMLABBPOMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x85BC620", Offset = "0x85BB220", VA = "0x1885BC620", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x85BD300", Offset = "0x85BBF00", VA = "0x1885BD300", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NKGOBEKODPF KFPKMMEILIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85BA330", Offset = "0x85B8F30", VA = "0x1885BA330", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x85B8FD0", Offset = "0x85B7BD0", VA = "0x1885B8FD0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LNOEFCDNOHA CNAOKDDACNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x85BCA70", Offset = "0x85BB670", VA = "0x1885BCA70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x85B8D90", Offset = "0x85B7990", VA = "0x1885B8D90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LNOEFCDNOHA PDNDHCJJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A20", Offset = "0x85B7620", VA = "0x1885B8A20", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x85BBC80", Offset = "0x85BA880", VA = "0x1885BBC80", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LNOEFCDNOHA AMDDALDADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x85B8850", Offset = "0x85B7450", VA = "0x1885B8850", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B8510", Offset = "0x85B7110", VA = "0x1885B8510", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<OEENMKMDDDK, OEENMKMDDDK> FENHDBEDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x85BAF80", Offset = "0x85B9B80", VA = "0x1885BAF80", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x85BCE30", Offset = "0x85BBA30", VA = "0x1885BCE30", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LNOEFCDNOHA PCFMOPPLHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x85BC680", Offset = "0x85BB280", VA = "0x1885BC680", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x85BB1B0", Offset = "0x85B9DB0", VA = "0x1885BB1B0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LNOEFCDNOHA KJEFEAPCMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x85BE3E0", Offset = "0x85BCFE0", VA = "0x1885BE3E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x85B87A0", Offset = "0x85B73A0", VA = "0x1885B87A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x85BE840", Offset = "0x85BD440", VA = "0x1885BE840")]
	public PFKDEFEEHLJ(GameObject AOALCMHDOFP, RigidbodyEx CEFLBKCOONH, LJECABOPODM GMBCCEAGHDM, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x85BA650", Offset = "0x85B9250", VA = "0x1885BA650", Slot = "139")]
	protected virtual void EFBMKCDJGPO(LJECABOPODM GMBCCEAGHDM, EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x85BA420", Offset = "0x85B9020", VA = "0x1885BA420", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x85B9E90", Offset = "0x85B8A90", VA = "0x1885B9E90", Slot = "93")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x85B9600", Offset = "0x85B8200", VA = "0x1885B9600", Slot = "94")]
	public void CGFIMGKAOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB70", Offset = "0x85BA770", VA = "0x1885BBB70", Slot = "95")]
	public void GPJOGNDFODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x85BCA50", Offset = "0x85BB650", VA = "0x1885BCA50", Slot = "96")]
	public void KEJHPEIBPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x85BAB70", Offset = "0x85B9770", VA = "0x1885BAB70")]
	private void FFGOGFFAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x85B8320", Offset = "0x85B6F20", VA = "0x1885B8320")]
	private void ACPHNBCPGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x85BB250", Offset = "0x85B9E50", VA = "0x1885BB250")]
	private void FPPMFBMODBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x85B9FD0", Offset = "0x85B8BD0", VA = "0x1885B9FD0", Slot = "30")]
	public EADBHHGHCOL DKBHGBNCHJL(int EMMACFPOKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x85BDF90", Offset = "0x85BCB90", VA = "0x1885BDF90", Slot = "98")]
	public void OAAMBAOIOOB(EADBHHGHCOL OOHGFGHCOAJ, bool KIEEDBDBNHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x85B8670", Offset = "0x85B7270", VA = "0x1885B8670", Slot = "99")]
	public void AHMMNBBFFPD(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x85B8C80", Offset = "0x85B7880", VA = "0x1885B8C80", Slot = "100")]
	public void BECDFCMJLME(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x85B8570", Offset = "0x85B7170", VA = "0x1885B8570", Slot = "101")]
	public Vector3 AHAHEAFAIOM(Vector3 MKKLJCLAENJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x85BCFD0", Offset = "0x85BBBD0", VA = "0x1885BCFD0", Slot = "102")]
	public Vector3 LBPADMLAJPO(Vector3 KHCAEECDNDM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x85BA940", Offset = "0x85B9540", VA = "0x1885BA940", Slot = "103")]
	public void EGLFPKADDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x85BE660", Offset = "0x85BD260", VA = "0x1885BE660", Slot = "104")]
	public void PAJKABDAGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x85BCDE0", Offset = "0x85BB9E0", VA = "0x1885BCDE0", Slot = "105")]
	public void KHCNKJLJKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x85BCAD0", Offset = "0x85BB6D0", VA = "0x1885BCAD0", Slot = "106")]
	public void KFGOBBOADCN(Vector3 AABFLGNECOB, Vector3 FHPBADOOCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x85BCEE0", Offset = "0x85BBAE0", VA = "0x1885BCEE0", Slot = "107")]
	public void LBFNJIDNBOD(Vector3 PDOEEHIABID, Vector3 FAFGAPDLINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x85BD6E0", Offset = "0x85BC2E0", VA = "0x1885BD6E0", Slot = "108")]
	public void MDJPOAOCGKP(Vector3 FBDGFEEKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x85BD620", Offset = "0x85BC220", VA = "0x1885BD620", Slot = "109")]
	public void MCNBCNIBGFA(IBAPNPEDNNP GFBHFNJFEGM, Vector3 JIIHIAGFIGK, float HHKBILOIFPE, float ADBHMBMIDLI = 8f, float DKOCDAOHKFH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x85BB690", Offset = "0x85BA290", VA = "0x1885BB690", Slot = "110")]
	public void GDAPFOMNLMF(MPBEDBOENLK BKMICPMKELA, Vector3 BLLAOHANMCE, float HKDLPFFMCIB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x85BD1A0", Offset = "0x85BBDA0", VA = "0x1885BD1A0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LIGIGFIECDM(MPBEDBOENLK BKMICPMKELA, Vector3 BFEELDCLMGM, float IOPBCCGPEBC = 7f, float NNKGFLBDMBK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x85BC520", Offset = "0x85BB120", VA = "0x1885BC520", Slot = "112")]
	public Vector3 INAHMCMAAEB(Vector3 OOHGFGHCOAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x85B9D40", Offset = "0x85B8940", VA = "0x1885B9D40", Slot = "113")]
	public Vector3 DFCLMIJOBFA(Vector3 OOHGFGHCOAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x85BC240", Offset = "0x85BAE40", VA = "0x1885BC240", Slot = "114")]
	public void IHHGJKMLHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x85B88B0", Offset = "0x85B74B0", VA = "0x1885B88B0", Slot = "115")]
	public void AOPEPADOBLM(EADBHHGHCOL GOFCONACJJP, object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x85BB630", Offset = "0x85BA230", VA = "0x1885BB630", Slot = "116")]
	public void GCPHLBALOGF(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x85B8A80", Offset = "0x85B7680", VA = "0x1885B8A80", Slot = "63")]
	public void BBNNMDLBGEI((Quaternion rot, Vector3 moments) LKNPLOMJHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85BE000", Offset = "0x85BCC00", VA = "0x1885BE000", Slot = "117")]
	public void ODDOIBMGJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB20", Offset = "0x85BA720", VA = "0x1885BBB20", Slot = "118")]
	public void GLBFKBLGOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x85BDAB0", Offset = "0x85BC6B0", VA = "0x1885BDAB0", Slot = "119")]
	public void MNKHFAMJDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x85B9E40", Offset = "0x85B8A40", VA = "0x1885B9E40", Slot = "120")]
	public bool DIBBMJGICDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x85BC990", Offset = "0x85BB590", VA = "0x1885BC990", Slot = "97")]
	public void JOHFJLBKODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x85BD0D0", Offset = "0x85BBCD0", VA = "0x1885BD0D0", Slot = "121")]
	public void LFHJKHNNKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x85BE320", Offset = "0x85BCF20", VA = "0x1885BE320", Slot = "122")]
	public void OHGHFDPHKOH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x85BD5C0", Offset = "0x85BC1C0", VA = "0x1885BD5C0", Slot = "123")]
	public void LONBJOKABJH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x85B9840", Offset = "0x85B8440", VA = "0x1885B9840", Slot = "124")]
	public void CKAJJOGPHOE(object HEDGIMBCGHA, bool CBMPLHDBDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x85BB8C0", Offset = "0x85BA4C0", VA = "0x1885BB8C0", Slot = "125")]
	public void GGFKBKNJDGE(Vector3 MMDDGEEAFDM, Quaternion PKHGEFEODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x85B81F0", Offset = "0x85B6DF0", VA = "0x1885B81F0", Slot = "126")]
	public void ACBPHDHLGCE(Vector3 NBPBOJNOCJM, Quaternion EGIHCMJEEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x85BD2B0", Offset = "0x85BBEB0", VA = "0x1885BD2B0", Slot = "127")]
	public bool LKHCIBDJBIA(float NPEKDNBDINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x85BE7A0", Offset = "0x85BD3A0", VA = "0x1885BE7A0", Slot = "128")]
	public void PHBLPACBAAK(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x85BDA50", Offset = "0x85BC650", VA = "0x1885BDA50", Slot = "129")]
	public void MNJENCMHICP(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x85BBAC0", Offset = "0x85BA6C0", VA = "0x1885BBAC0", Slot = "130")]
	public void GHMOAFKJOHK(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x85B9470", Offset = "0x85B8070", VA = "0x1885B9470", Slot = "131")]
	public void CFBDGKKPEKB(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x85BADF0", Offset = "0x85B99F0", VA = "0x1885BADF0", Slot = "132")]
	public void FGJDCKNOFFI(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x85B83A0", Offset = "0x85B6FA0", VA = "0x1885B83A0", Slot = "133")]
	public void ADEILJPAOFF(Vector3 JMDCPKFBLOI, Vector3 IIBJECFMAJC, ForceMode KHLACBHAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x85B9690", Offset = "0x85B8290", VA = "0x1885B9690", Slot = "134")]
	public void CGOMMKCIOLJ(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x85BD910", Offset = "0x85BC510", VA = "0x1885BD910", Slot = "135")]
	public void MGEFMEIPEAO(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x85BDE40", Offset = "0x85BCA40", VA = "0x1885BDE40", Slot = "136")]
	public bool NJOBNDEIHPK(Vector3 HLIFPOIPBBB, [Out] RaycastHit AAJGGMIMFEH, float KNLGCBPGFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x85BE530", Offset = "0x85BD130", VA = "0x1885BE530", Slot = "137")]
	public void OOBJPHFMIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x85BE800", Offset = "0x85BD400", VA = "0x1885BE800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x85BC120", Offset = "0x85BAD20", VA = "0x1885BC120")]
	private void IEFGINLPAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x85BC290", Offset = "0x85BAE90", VA = "0x1885BC290")]
	private void IIAGICJFFKB(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x85B8DF0", Offset = "0x85B79F0", VA = "0x1885B8DF0")]
	private void BIDMCDGINFB(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x85B8BD0", Offset = "0x85B77D0", VA = "0x1885B8BD0")]
	private void BDJJJMMGGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x85BE200", Offset = "0x85BCE00", VA = "0x1885BE200")]
	private void OEJJEGGAFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x85BE050", Offset = "0x85BCC50", VA = "0x1885BE050")]
	private void OEGFANPPPFB(EADBHHGHCOL GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x85B86D0", Offset = "0x85B72D0", VA = "0x1885B86D0")]
	private void AHOGGIKLDCM(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x85B9770", Offset = "0x85B8370", VA = "0x1885B9770")]
	private void CJKHJLIONPC(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x85BBE10", Offset = "0x85BAA10", VA = "0x1885BBE10")]
	private void HLLMKDIEKFJ(IODHBDFJLPB LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x85B9900", Offset = "0x85B8500", VA = "0x1885B9900", Slot = "142")]
	protected virtual void DCOFDFFGDKN(IODHBDFJLPB KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x85B9030", Offset = "0x85B7C30", VA = "0x1885B9030")]
	protected void BPBEEIFIDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x85BB2B0", Offset = "0x85B9EB0", VA = "0x1885BB2B0")]
	protected void GBHKEFLFPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x85BBCE0", Offset = "0x85BA8E0", VA = "0x1885BBCE0")]
	private void HGBNLDJHEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x85BA170", Offset = "0x85B8D70", VA = "0x1885BA170")]
	private void DNDADLIBHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class IFNLHOKGHFA
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x85AF640", Offset = "0x85AE240", VA = "0x1885AF640")]
	public static EADBHHGHCOL ABHMCFONNLF(this EADBHHGHCOL KBHNLJCJFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85AF860", Offset = "0x85AE460", VA = "0x1885AF860")]
	public static bool PLEEKNEOHEF(this EADBHHGHCOL KBHNLJCJFLC, EADBHHGHCOL EPHPNLHEOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x85AF750", Offset = "0x85AE350", VA = "0x1885AF750")]
	public static bool CJCLCAIHLAB(this EADBHHGHCOL KBHNLJCJFLC, EADBHHGHCOL FMFOAHDOMBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85AF700", Offset = "0x85AE300", VA = "0x1885AF700")]
	public static IODHBDFJLPB BGJIDNMNNKL(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x85AF7F0", Offset = "0x85AE3F0", VA = "0x1885AF7F0")]
	public static PFKDEFEEHLJ GLDCGICLIMG(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LMHIMJMFJDB : GBNMABGGGEH
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x85B4510", Offset = "0x85B3110", VA = "0x1885B4510", Slot = "19")]
	public EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC, EOOCHJMGNCA PEDMEJIDLNB, LJECABOPODM GMBCCEAGHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "4")]
	public JGNHLDJELGI HKDGBMMGBBF(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "5")]
	public DOJEKCBNICP AOBFJNHDNKC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
	public IMOADJHJMNI KDAJLHLHIDC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "7")]
	public PDPIAFFLMKA OIMMEBBECNA(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "8")]
	public IMIBDLFEBNK BAMJBIDGINH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "9")]
	public BAIBCOFPBLI CDJENMOPPGH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "10")]
	public HOHOIJLLJDP IPAFCDDMFDK(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "11")]
	public ENHGOHHABGE PFOAJBFKPGB(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "12")]
	public NACFLKDGALI GBANEIEDOBO(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "13")]
	public BJGJNADCIOH HNMBNLJILGE(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public JHHHHBDOGEM CDIPFBHKEFA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public JHEIOEFBHBO LMFBFAKHNDG(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public LKOEFGPOGPN EFDOHMAMBFL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public CNDNEGHHBDA MLLEPNCCONM(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public LFNBKAKDNJB OGHJPOOOJGA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LMHIMJMFJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "14")]
	private JHHHHBDOGEM MHEFOFHLBHH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "15")]
	private JHEIOEFBHBO BJDJMOECEMI(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "16")]
	private LKOEFGPOGPN MMGMPIFKLIB(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "17")]
	private CNDNEGHHBDA DFMGILAICLH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "18")]
	private LFNBKAKDNJB NLDMDANDBHL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(GBNMABGGGEH), new string[] { })]
public class KCKPOCFBGDI : GBNMABGGGEH, OMNICACBHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GBNMABGGGEH IJHGAONCJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GBNMABGGGEH LHDEGMCKBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CLJEBCIFPND HDCBFMLDHJM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private GBNMABGGGEH PNGDLEDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x85B0C30", Offset = "0x85AF830", VA = "0x1885B0C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x85B0940", Offset = "0x85AF540", VA = "0x1885B0940", Slot = "20")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x85B0760", Offset = "0x85AF360", VA = "0x1885B0760", Slot = "4")]
	public JGNHLDJELGI HKDGBMMGBBF(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x85B0220", Offset = "0x85AEE20", VA = "0x1885B0220", Slot = "5")]
	public DOJEKCBNICP AOBFJNHDNKC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x85B0990", Offset = "0x85AF590", VA = "0x1885B0990", Slot = "6")]
	public IMOADJHJMNI KDAJLHLHIDC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x85B0C90", Offset = "0x85AF890", VA = "0x1885B0C90", Slot = "7")]
	public PDPIAFFLMKA OIMMEBBECNA(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x85B02C0", Offset = "0x85AEEC0", VA = "0x1885B02C0", Slot = "8")]
	public IMIBDLFEBNK BAMJBIDGINH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85B04C0", Offset = "0x85AF0C0", VA = "0x1885B04C0", Slot = "9")]
	public BAIBCOFPBLI CDJENMOPPGH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x85B08A0", Offset = "0x85AF4A0", VA = "0x1885B08A0", Slot = "10")]
	public HOHOIJLLJDP IPAFCDDMFDK(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x85B0D30", Offset = "0x85AF930", VA = "0x1885B0D30", Slot = "11")]
	public ENHGOHHABGE PFOAJBFKPGB(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x85B06C0", Offset = "0x85AF2C0", VA = "0x1885B06C0", Slot = "12")]
	public NACFLKDGALI GBANEIEDOBO(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x85B0800", Offset = "0x85AF400", VA = "0x1885B0800", Slot = "13")]
	public BJGJNADCIOH HNMBNLJILGE(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x85B0410", Offset = "0x85AF010", VA = "0x1885B0410")]
	public JHHHHBDOGEM CDIPFBHKEFA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x85B0360", Offset = "0x85AEF60", VA = "0x1885B0360")]
	public JHEIOEFBHBO LMFBFAKHNDG(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x85B0610", Offset = "0x85AF210", VA = "0x1885B0610")]
	public LKOEFGPOGPN EFDOHMAMBFL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x85B0560", Offset = "0x85AF160", VA = "0x1885B0560")]
	public CNDNEGHHBDA MLLEPNCCONM(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x85B0A30", Offset = "0x85AF630", VA = "0x1885B0A30")]
	public LFNBKAKDNJB OGHJPOOOJGA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x85B0AE0", Offset = "0x85AF6E0", VA = "0x1885B0AE0", Slot = "19")]
	public EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC, EOOCHJMGNCA PEDMEJIDLNB, LJECABOPODM GMBCCEAGHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x85B0DD0", Offset = "0x85AF9D0", VA = "0x1885B0DD0")]
	public KCKPOCFBGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x85B0410", Offset = "0x85AF010", VA = "0x1885B0410", Slot = "14")]
	private JHHHHBDOGEM MHEFOFHLBHH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x85B0360", Offset = "0x85AEF60", VA = "0x1885B0360", Slot = "15")]
	private JHEIOEFBHBO BJDJMOECEMI(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x85B0610", Offset = "0x85AF210", VA = "0x1885B0610", Slot = "16")]
	private LKOEFGPOGPN MMGMPIFKLIB(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x85B0560", Offset = "0x85AF160", VA = "0x1885B0560", Slot = "17")]
	private CNDNEGHHBDA DFMGILAICLH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x85B0A30", Offset = "0x85AF630", VA = "0x1885B0A30", Slot = "18")]
	private LFNBKAKDNJB NLDMDANDBHL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JCLNIFOMOOG : JGNHLDJELGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LAIHPFGHOIE(EADBHHGHCOL KBHNLJCJFLC);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJOBPMGGNMC(EADBHHGHCOL KBHNLJCJFLC);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKFBNIBLEHH(EADBHHGHCOL GPGDAHNKOCH);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCEKGNANHOC(EADBHHGHCOL GPGDAHNKOCH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PNIEEBAPONH : IMOADJHJMNI
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	ANHMNNEGMOL<EADBHHGHCOL> OFFOEDCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	EADBHHGHCOL HGMKPPFLONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BHPAJOIMNIN : CNDNEGHHBDA
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KOCHIMCMKPF(Rigidbody IDBKEINOJPK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ELLFEGNMCID : JHEIOEFBHBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView HIOICNEJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GDCHDIGIHIG : NACFLKDGALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JFCHPDAJNNC;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x85AC510", Offset = "0x85AB110", VA = "0x1885AC510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode CFOLMFCLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x85AC160", Offset = "0x85AAD60", VA = "0x1885AC160", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x85AC4A0", Offset = "0x85AB0A0", VA = "0x1885AC4A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x85AC0D0", Offset = "0x85AACD0", VA = "0x1885AC0D0")]
	public GDCHDIGIHIG(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x85AC270", Offset = "0x85AAE70", VA = "0x1885AC270", Slot = "6")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x85AC560", Offset = "0x85AB160", VA = "0x1885AC560", Slot = "9")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x85AC740", Offset = "0x85AB340", VA = "0x1885AC740", Slot = "7")]
	public void OHOPMDEKPIM(bool HGHHIPDEAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x85AC750", Offset = "0x85AB350", VA = "0x1885AC750", Slot = "8")]
	public void PBNDNDFFPJK(bool HGHHIPDEAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x85AC5E0", Offset = "0x85AB1E0", VA = "0x1885AC5E0", Slot = "10")]
	public bool NJOBNDEIHPK(Vector3 HLIFPOIPBBB, [Out] RaycastHit AAJGGMIMFEH, float KNLGCBPGFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x85AC380", Offset = "0x85AAF80", VA = "0x1885AC380")]
	private void EBGMGKGICFG(bool HGHHIPDEAMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BBJMMBJFDJC : BAIBCOFPBLI, IDisposable, CBIBIMNKCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private FDCMEMEDMHG AKDKCOOJADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private NDEAHNEBJHO CCDNCEPPLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FDCMEMEDMHG BAIEILCIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x85A8250", Offset = "0x85A6E50", VA = "0x1885A8250", Slot = "6")]
		get
		{
			return default(FDCMEMEDMHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x85A8440", Offset = "0x85A7040", VA = "0x1885A8440", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform IDJCJONMDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD7BCE0", Offset = "0xD7A8E0", VA = "0x180D7BCE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OEENMKMDDDK, OEENMKMDDDK> FENHDBEDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85A8390", Offset = "0x85A6F90", VA = "0x1885A8390", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x85A8510", Offset = "0x85A7110", VA = "0x1885A8510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x85A85C0", Offset = "0x85A71C0", VA = "0x1885A85C0")]
	public BBJMMBJFDJC(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x85A7F90", Offset = "0x85A6B90", VA = "0x1885A7F90", Slot = "8")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x85A8200", Offset = "0x85A6E00", VA = "0x1885A8200", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x124B730", Offset = "0x124A330", VA = "0x18124B730", Slot = "11")]
	private void JBPMDDGOAEC(OEENMKMDDDK ABLDLIKEDBP, OEENMKMDDDK MBGHCHMLFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "12")]
	private void HLOJDFAELJA(bool IBOKCFEKOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DAHBFPAKEDC : GBNMABGGGEH
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x85AA950", Offset = "0x85A9550", VA = "0x1885AA950", Slot = "4")]
	public JGNHLDJELGI HKDGBMMGBBF(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x85AA040", Offset = "0x85A8C40", VA = "0x1885AA040", Slot = "5")]
	public DOJEKCBNICP AOBFJNHDNKC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x85AAC20", Offset = "0x85A9820", VA = "0x1885AAC20", Slot = "6")]
	public IMOADJHJMNI KDAJLHLHIDC(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x85AAF80", Offset = "0x85A9B80", VA = "0x1885AAF80", Slot = "7")]
	public PDPIAFFLMKA OIMMEBBECNA(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x85AA160", Offset = "0x85A8D60", VA = "0x1885AA160", Slot = "8")]
	public IMIBDLFEBNK BAMJBIDGINH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x85AA500", Offset = "0x85A9100", VA = "0x1885AA500", Slot = "9")]
	public BAIBCOFPBLI CDJENMOPPGH(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x85AAB00", Offset = "0x85A9700", VA = "0x1885AAB00", Slot = "10")]
	public HOHOIJLLJDP IPAFCDDMFDK(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x85AB000", Offset = "0x85A9C00", VA = "0x1885AB000", Slot = "11")]
	public ENHGOHHABGE PFOAJBFKPGB(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x85AA890", Offset = "0x85A9490", VA = "0x1885AA890", Slot = "12")]
	public NACFLKDGALI GBANEIEDOBO(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x85AAA40", Offset = "0x85A9640", VA = "0x1885AAA40", Slot = "13")]
	public BJGJNADCIOH HNMBNLJILGE(EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x85AA3C0", Offset = "0x85A8FC0", VA = "0x1885AA3C0")]
	public JHHHHBDOGEM CDIPFBHKEFA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x85AA230", Offset = "0x85A8E30", VA = "0x1885AA230")]
	public JHEIOEFBHBO LMFBFAKHNDG(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x85AA760", Offset = "0x85A9360", VA = "0x1885AA760")]
	public LKOEFGPOGPN EFDOHMAMBFL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x85AA5D0", Offset = "0x85A91D0", VA = "0x1885AA5D0")]
	public CNDNEGHHBDA MLLEPNCCONM(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x85AAD50", Offset = "0x85A9950", VA = "0x1885AAD50")]
	public LFNBKAKDNJB OGHJPOOOJGA(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x85AAE30", Offset = "0x85A9A30", VA = "0x1885AAE30", Slot = "19")]
	public EADBHHGHCOL NLLBBLAIELE(RigidbodyEx KBHNLJCJFLC, EOOCHJMGNCA PEDMEJIDLNB, LJECABOPODM GMBCCEAGHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DAHBFPAKEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x85AA3C0", Offset = "0x85A8FC0", VA = "0x1885AA3C0", Slot = "14")]
	private JHHHHBDOGEM MHEFOFHLBHH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x85AA230", Offset = "0x85A8E30", VA = "0x1885AA230", Slot = "15")]
	private JHEIOEFBHBO BJDJMOECEMI(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x85AA760", Offset = "0x85A9360", VA = "0x1885AA760", Slot = "16")]
	private LKOEFGPOGPN MMGMPIFKLIB(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x85AA5D0", Offset = "0x85A91D0", VA = "0x1885AA5D0", Slot = "17")]
	private CNDNEGHHBDA DFMGILAICLH(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x85AAD50", Offset = "0x85A9950", VA = "0x1885AAD50", Slot = "18")]
	private LFNBKAKDNJB NLDMDANDBHL(EADBHHGHCOL JCPBJCFMJCO, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class GHGPAMEBDIO : ENHGOHHABGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x85AC510", Offset = "0x85AB110", VA = "0x1885AC510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HMCGEPBNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x85ACDA0", Offset = "0x85AB9A0", VA = "0x1885ACDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool DGGJALNGJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x85AD1B0", Offset = "0x85ABDB0", VA = "0x1885AD1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x85AD470", Offset = "0x85AC070", VA = "0x1885AD470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x85AC0D0", Offset = "0x85AACD0", VA = "0x1885AC0D0")]
	public GHGPAMEBDIO(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x85ACDF0", Offset = "0x85AB9F0", VA = "0x1885ACDF0", Slot = "4")]
	public void FGJDCKNOFFI(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x85ACF50", Offset = "0x85ABB50", VA = "0x1885ACF50")]
	private void HOAFPIKPIOL(Vector3 JMDCPKFBLOI, ForceMode KHLACBHAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x85AC760", Offset = "0x85AB360", VA = "0x1885AC760", Slot = "5")]
	public void ADEILJPAOFF(Vector3 JMDCPKFBLOI, Vector3 IIBJECFMAJC, ForceMode KHLACBHAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x85ACC40", Offset = "0x85AB840", VA = "0x1885ACC40", Slot = "6")]
	public void CGOMMKCIOLJ(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x85AC9E0", Offset = "0x85AB5E0", VA = "0x1885AC9E0")]
	private void CDHMOPLPOKB(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x85AD210", Offset = "0x85ABE10", VA = "0x1885AD210", Slot = "7")]
	public void MGEFMEIPEAO(Vector3 LCCBDJMIEBH, ForceMode KHLACBHAFGM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class GAAEDHCEFOA : BJGJNADCIOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NOCCNBOCIDC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MKKEOHFAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85ABF20", Offset = "0x85AAB20", VA = "0x1885ABF20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x85AC0D0", Offset = "0x85AACD0", VA = "0x1885AC0D0")]
	public GAAEDHCEFOA(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x85AC030", Offset = "0x85AAC30", VA = "0x1885AC030", Slot = "6")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x85AC060", Offset = "0x85AAC60", VA = "0x1885AC060", Slot = "7")]
	public void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HLEFMKJLJPO : JCLNIFOMOOG, JGNHLDJELGI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EADBHHGHCOL KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<EADBHHGHCOL> LJIGLNBHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EADBHHGHCOL HMGDINOCJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EADBHHGHCOL LIPFJJEAFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform BGFOMLFHGJC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x85AF480", Offset = "0x85AE080", VA = "0x1885AF480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA1FDD0", Offset = "0xA1E9D0", VA = "0x180A1FDD0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x85ADF60", Offset = "0x85ACB60", VA = "0x1885ADF60", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EADBHHGHCOL MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<EADBHHGHCOL> DEDOJLIGOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B2C0", VA = "0x180A1C6C0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event LNOEFCDNOHA GDJBBFNCKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x85AD790", Offset = "0x85AC390", VA = "0x1885AD790", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x85ADD70", Offset = "0x85AC970", VA = "0x1885ADD70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event LNOEFCDNOHA MMLABBPOMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x85ADEC0", Offset = "0x85ACAC0", VA = "0x1885ADEC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x85AE3C0", Offset = "0x85ACFC0", VA = "0x1885AE3C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event NKGOBEKODPF KFPKMMEILIC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD8D0", Offset = "0x85AC4D0", VA = "0x1885AD8D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD830", Offset = "0x85AC430", VA = "0x1885AD830", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action KLDBGBDBJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x85AE7A0", Offset = "0x85AD3A0", VA = "0x1885AE7A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x85ADF70", Offset = "0x85ACB70", VA = "0x1885ADF70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action IBHDIPKEKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85AE1F0", Offset = "0x85ACDF0", VA = "0x1885AE1F0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD970", Offset = "0x85AC570", VA = "0x1885AD970", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<EADBHHGHCOL> GCBDADDKBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x85ADE10", Offset = "0x85ACA10", VA = "0x1885ADE10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x85AE010", Offset = "0x85ACC10", VA = "0x1885AE010", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EADBHHGHCOL> GMHBFFBIDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85ADAB0", Offset = "0x85AC6B0", VA = "0x1885ADAB0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x85AE650", Offset = "0x85AD250", VA = "0x1885AE650", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IJMCKLENMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x85AF170", Offset = "0x85ADD70", VA = "0x1885AF170", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x85AF4E0", Offset = "0x85AE0E0", VA = "0x1885AF4E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<EADBHHGHCOL> LLBGHBHMBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85AE5A0", Offset = "0x85AD1A0", VA = "0x1885AE5A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x85ADC20", Offset = "0x85AC820", VA = "0x1885ADC20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x85AF580", Offset = "0x85AE180", VA = "0x1885AF580")]
	public HLEFMKJLJPO(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x85ADA10", Offset = "0x85AC610", VA = "0x1885ADA10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x85AE970", Offset = "0x85AD570", VA = "0x1885AE970", Slot = "30")]
	public void OAAMBAOIOOB(EADBHHGHCOL JHPFPLHIKAH, bool KIEEDBDBNHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x85AF210", Offset = "0x85ADE10", VA = "0x1885AF210", Slot = "6")]
	public void OKFBNIBLEHH(EADBHHGHCOL GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x85AEEF0", Offset = "0x85ADAF0", VA = "0x1885AEEF0", Slot = "7")]
	public void OCEKGNANHOC(EADBHHGHCOL GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x85AE2D0", Offset = "0x85ACED0", VA = "0x1885AE2D0", Slot = "4")]
	public void LAIHPFGHOIE(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x85AE700", Offset = "0x85AD300", VA = "0x1885AE700", Slot = "5")]
	public void MJOBPMGGNMC(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x85ADCD0", Offset = "0x85AC8D0", VA = "0x1885ADCD0")]
	private void HGJECIIJCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x85AE290", Offset = "0x85ACE90", VA = "0x1885AE290")]
	private void KDOLAHJBCDA(EADBHHGHCOL GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x85AE460", Offset = "0x85AD060", VA = "0x1885AE460")]
	private void LMAIIMHCBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x85AE840", Offset = "0x85AD440", VA = "0x1885AE840")]
	private void NKJCOLNMGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x85AE0C0", Offset = "0x85ACCC0", VA = "0x1885AE0C0")]
	private void KDJHNNHKOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x85ADB60", Offset = "0x85AC760", VA = "0x1885ADB60")]
	[CompilerGenerated]
	private object EHAKGBGNILN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class ALJCAEOAGMG
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85A7ED0", Offset = "0x85A6AD0", VA = "0x1885A7ED0")]
	public static JCLNIFOMOOG BILKCCFOPBP(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MEAANBKNILH : PNIEEBAPONH, IMOADJHJMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ANHMNNEGMOL<EADBHHGHCOL> AONDJECEFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool ACFCOANJNKD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public ANHMNNEGMOL<EADBHHGHCOL> OFFOEDCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 OICBDALMHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x85B46C0", Offset = "0x85B32C0", VA = "0x1885B46C0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 KJFFFNKHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C90", Offset = "0x85B3890", VA = "0x1885B4C90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 ODPIFACDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x85B4AF0", Offset = "0x85B36F0", VA = "0x1885B4AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EADBHHGHCOL HGMKPPFLONC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x85B4BE0", Offset = "0x85B37E0", VA = "0x1885B4BE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x85B5250", Offset = "0x85B3E50", VA = "0x1885B5250")]
	public MEAANBKNILH(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x85B46F0", Offset = "0x85B32F0", VA = "0x1885B46F0", Slot = "8")]
	public void EBDNMOAAAJH(EADBHHGHCOL LIPFJJEAFCE, object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x85B4E50", Offset = "0x85B3A50", VA = "0x1885B4E50", Slot = "9")]
	public void KJKNMCBIMJI(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x85B4EB0", Offset = "0x85B3AB0", VA = "0x1885B4EB0")]
	private Vector3 PBIFNFOPFLD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x85B4760", Offset = "0x85B3360", VA = "0x1885B4760")]
	private void EGOICIJDDNE(EADBHHGHCOL PGKHEIGFLAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class POOENPKBKPG
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x85BE930", Offset = "0x85BD530", VA = "0x1885BE930")]
	public static PNIEEBAPONH DMPODOPDLOL(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MJDIPDJNDFF : BHPAJOIMNIN, CNDNEGHHBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 KDJGBALEEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 JFPJINJILLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float ANMIDDLBPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float BAJCHNMLGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 HCICGPGCKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? CEKIKLAHOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? PPICPDJMKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool CJLKCDPIPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool GOACCCDOAOD;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 AEFNNECIPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1789DD0", Offset = "0x17889D0", VA = "0x181789DD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x85B56D0", Offset = "0x85B42D0", VA = "0x1885B56D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 ICOHFDFCKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B5820", Offset = "0x85B4420", VA = "0x1885B5820", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ICALMNBIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xDA08D0", Offset = "0xD9F4D0", VA = "0x180DA08D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B5E10", Offset = "0x85B4A10", VA = "0x1885B5E10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float HPNIPIHDNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC99B40", Offset = "0xC98740", VA = "0x180C99B40", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x85B5620", Offset = "0x85B4220", VA = "0x1885B5620", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 MAABGALEAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x85B5BA0", Offset = "0x85B47A0", VA = "0x1885B5BA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion APNHJPBPEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x85B5F20", Offset = "0x85B4B20", VA = "0x1885B5F20", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x85A8D00", Offset = "0x85A7900", VA = "0x1885A8D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event LNOEFCDNOHA EDHODKKGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x85B5780", Offset = "0x85B4380", VA = "0x1885B5780", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x85B5350", Offset = "0x85B3F50", VA = "0x1885B5350", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x85B7AB0", Offset = "0x85B66B0", VA = "0x1885B7AB0")]
	public MJDIPDJNDFF(EADBHHGHCOL KBHNLJCJFLC, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x85B7500", Offset = "0x85B6100", VA = "0x1885B7500", Slot = "17")]
	public void ODDOIBMGJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D30", Offset = "0x85B4930", VA = "0x1885B5D30", Slot = "16")]
	public void GLBFKBLGOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x85B7240", Offset = "0x85B5E40", VA = "0x1885B7240", Slot = "19")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x85B7320", Offset = "0x85B5F20", VA = "0x1885B7320", Slot = "20")]
	public void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x85B7090", Offset = "0x85B5C90", VA = "0x1885B7090", Slot = "18")]
	public void MNKHFAMJDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x85B7620", Offset = "0x85B6220", VA = "0x1885B7620", Slot = "21")]
	public void OOBJPHFMIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x85B56D0", Offset = "0x85B42D0", VA = "0x1885B56D0")]
	private void BFCBEBOPLLH(Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x85B5910", Offset = "0x85B4510", VA = "0x1885B5910")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DEFBJCIBFJB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85B5E10", Offset = "0x85B4A10", VA = "0x1885B5E10")]
	private void GOAELADBFIN(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x85B5620", Offset = "0x85B4220", VA = "0x1885B5620")]
	private void BFCAIIJOJLF(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x85B5A00", Offset = "0x85B4600", VA = "0x1885B5A00")]
	private Vector3 FDOHMDALGAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x85B53F0", Offset = "0x85B3FF0", VA = "0x1885B53F0", Slot = "15")]
	public void BBNNMDLBGEI((Quaternion rot, Vector3 moments) LKNPLOMJHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x85B60A0", Offset = "0x85B4CA0", VA = "0x1885B60A0")]
	private Quaternion KHEKFAJBFNM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x85B6220", Offset = "0x85B4E20", VA = "0x1885B6220")]
	public void KOCHIMCMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x85B62F0", Offset = "0x85B4EF0", VA = "0x1885B62F0", Slot = "4")]
	public (float, Vector3) KOCHIMCMKPF(Rigidbody IDBKEINOJPK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class FMIIDGNBHIC
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x85ABE60", Offset = "0x85AAA60", VA = "0x1885ABE60")]
	public static BHPAJOIMNIN CDHOOCMJNOA(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FJIHMBODMBG : LKOEFGPOGPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MAHLEDFAIAJ DFLFNDCCFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GKDEPMMONOP EOGPMCJGNGN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool DJAJAKDBHII
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x195CC90", Offset = "0x195B890", VA = "0x18195CC90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GKDEPMMONOP FLCFCMKJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0", Slot = "11")]
		get
		{
			return default(GKDEPMMONOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x85ABD60", Offset = "0x85AA960", VA = "0x1885ABD60")]
	public FJIHMBODMBG(EADBHHGHCOL KBHNLJCJFLC, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x85ABA30", Offset = "0x85AA630", VA = "0x1885ABA30", Slot = "4")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x85ABB80", Offset = "0x85AA780", VA = "0x1885ABB80")]
	private bool KCEHEOIMDGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x85ABC20", Offset = "0x85AA820", VA = "0x1885ABC20", Slot = "5")]
	public void LDFGOJABFBK(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x85AB750", Offset = "0x85AA350", VA = "0x1885AB750", Slot = "6")]
	public void AFNOBAOJAJG(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x85AB780", Offset = "0x85AA380", VA = "0x1885AB780", Slot = "9")]
	public void CBLJNKOJEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x85ABC50", Offset = "0x85AA850", VA = "0x1885ABC50")]
	private void LHMKLGFBAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85AB8B0", Offset = "0x85AA4B0", VA = "0x1885AB8B0")]
	private void CFLPAJEJKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x85ABB40", Offset = "0x85AA740", VA = "0x1885ABB40", Slot = "8")]
	public void JIBLLBBIMDB(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x85ABB00", Offset = "0x85AA700", VA = "0x1885ABB00", Slot = "7")]
	public void JBADDNBIOJP(EADBHHGHCOL KBHNLJCJFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ELFHNFKPLNM : HOHOIJLLJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MAHLEDFAIAJ HAFPDGJOJOL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HMCGEPBNCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x85AB2E0", Offset = "0x85A9EE0", VA = "0x1885AB2E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event LNOEFCDNOHA PCFMOPPLHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85AB430", Offset = "0x85AA030", VA = "0x1885AB430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x85AB390", Offset = "0x85A9F90", VA = "0x1885AB390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x85AB5A0", Offset = "0x85AA1A0", VA = "0x1885AB5A0")]
	public ELFHNFKPLNM(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x85AB590", Offset = "0x85AA190", VA = "0x1885AB590", Slot = "7")]
	public void OHGHFDPHKOH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x85AB4D0", Offset = "0x85AA0D0", VA = "0x1885AB4D0", Slot = "8")]
	public void LONBJOKABJH(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x85AB1D0", Offset = "0x85A9DD0", VA = "0x1885AB1D0", Slot = "9")]
	public void CKAJJOGPHOE(object HEDGIMBCGHA, bool CBMPLHDBDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x85AB190", Offset = "0x85A9D90", VA = "0x1885AB190", Slot = "12")]
	public void BGIJBGNLNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x85AB4E0", Offset = "0x85AA0E0", VA = "0x1885AB4E0", Slot = "10")]
	public void MNNHILOOMPM(Rigidbody LCBHJGJGEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x85AB560", Offset = "0x85AA160", VA = "0x1885AB560", Slot = "11")]
	public void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CGKPBBNLFEI : ELLFEGNMCID, JHEIOEFBHBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView NFBECNGMMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool MIGLGMGMMDK;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView HIOICNEJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool KAAEIICEOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x85A94D0", Offset = "0x85A80D0", VA = "0x1885A94D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CNLFLMDCNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event LNOEFCDNOHA CNAOKDDACNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x85A9BE0", Offset = "0x85A87E0", VA = "0x1885A9BE0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x85A94E0", Offset = "0x85A80E0", VA = "0x1885A94E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x85A9EF0", Offset = "0x85A8AF0", VA = "0x1885A9EF0")]
	public CGKPBBNLFEI(EADBHHGHCOL KBHNLJCJFLC, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85A99B0", Offset = "0x85A85B0", VA = "0x1885A99B0", Slot = "9")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x85A9AE0", Offset = "0x85A86E0", VA = "0x1885A9AE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x85A9360", Offset = "0x85A7F60", VA = "0x1885A9360", Slot = "10")]
	public void AHOGGIKLDCM(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x85A96D0", Offset = "0x85A82D0", VA = "0x1885A96D0", Slot = "11")]
	public void CJKHJLIONPC(EADBHHGHCOL LIPFJJEAFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x85A9840", Offset = "0x85A8440", VA = "0x1885A9840")]
	private void DDNGHBFFNPM(RRNetworkView KBGJMMBAFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x85A9580", Offset = "0x85A8180", VA = "0x1885A9580")]
	private void CAOPJGDCKNH(IODHBDFJLPB ONNEGCJILCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x85A9C80", Offset = "0x85A8880", VA = "0x1885A9C80")]
	private void PKLHEMDKNDG(RRNetworkView BPDCKDBCGLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class EPCHAABMOOK
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x85AB690", Offset = "0x85AA290", VA = "0x1885AB690")]
	public static ELLFEGNMCID PDIBADJACND(this EADBHHGHCOL JCPBJCFMJCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OBHCEAKKFCI : LFNBKAKDNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints JJDIIFPJODM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NFJJJKKIPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6510", Offset = "0xAA5110", VA = "0x180AA6510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xDC7F30", Offset = "0xDC6B30", VA = "0x180DC7F30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FIIIGNLJHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA66D0", Offset = "0xAA52D0", VA = "0x180AA66D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xDC7730", Offset = "0xDC6330", VA = "0x180DC7730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints OKGCBBPILDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x85B7C10", Offset = "0x85B6810", VA = "0x1885B7C10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x85B7DA0", Offset = "0x85B69A0", VA = "0x1885B7DA0")]
	public OBHCEAKKFCI(EADBHHGHCOL KBHNLJCJFLC, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x85B7D40", Offset = "0x85B6940", VA = "0x1885B7D40", Slot = "9")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x85B7D70", Offset = "0x85B6970", VA = "0x1885B7D70", Slot = "10")]
	public void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PELIOEKIJAL : PDPIAFFLMKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EADBHHGHCOL KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float OFPPMINECCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float DCMEDBFEGHF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float OJDACIDBFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA70670", Offset = "0xA6F270", VA = "0x180A70670", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x85B7E40", Offset = "0x85B6A40", VA = "0x1885B7E40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float JDMNGAIEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA70940", Offset = "0xA6F540", VA = "0x180A70940", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F10", Offset = "0x85B6B10", VA = "0x1885B7F10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x85B80D0", Offset = "0x85B6CD0", VA = "0x1885B80D0")]
	public PELIOEKIJAL(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x85B7FE0", Offset = "0x85B6BE0", VA = "0x1885B7FE0", Slot = "8")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x85B8030", Offset = "0x85B6C30", VA = "0x1885B8030", Slot = "9")]
	public void OCDEFBJIEHG(Rigidbody KOGOAMNMHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BHNOPINNEEL : IMIBDLFEBNK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly JPIBGNDAFKP ECKBMPEGJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool DICCABGJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool ADEHPNFBECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int LEDECIJODNN;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85A8D00", Offset = "0x85A7900", VA = "0x1885A8D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool LDHNLIEOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x85A8B00", Offset = "0x85A7700", VA = "0x1885A8B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private EADBHHGHCOL AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x85A91F0", Offset = "0x85A7DF0", VA = "0x1885A91F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DGGJALNGJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x85A8FD0", Offset = "0x85A7BD0", VA = "0x1885A8FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LNOEFCDNOHA AMDDALDADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x85A86F0", Offset = "0x85A72F0", VA = "0x1885A86F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x85A8650", Offset = "0x85A7250", VA = "0x1885A8650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x85A92D0", Offset = "0x85A7ED0", VA = "0x1885A92D0")]
	public BHNOPINNEEL(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x85A8A70", Offset = "0x85A7670", VA = "0x1885A8A70", Slot = "6")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x85A90D0", Offset = "0x85A7CD0", VA = "0x1885A90D0", Slot = "8")]
	public void KHBGNGCHEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x85A8920", Offset = "0x85A7520", VA = "0x1885A8920", Slot = "7")]
	public bool DIBBMJGICDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x85A9030", Offset = "0x85A7C30", VA = "0x1885A9030", Slot = "9")]
	public void JOHFJLBKODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x85A90E0", Offset = "0x85A7CE0", VA = "0x1885A90E0", Slot = "13")]
	public void LFHJKHNNKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85A8B20", Offset = "0x85A7720", VA = "0x1885A8B20", Slot = "12")]
	public void FFGOGFFAIFA(bool JKCLEMBHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x85A9180", Offset = "0x85A7D80", VA = "0x1885A9180", Slot = "10")]
	public bool MBMDPKNBGIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x85A8C40", Offset = "0x85A7840", VA = "0x1885A8C40", Slot = "11")]
	public bool FPPMFBMODBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x85A8D50", Offset = "0x85A7950", VA = "0x1885A8D50")]
	private bool IBFKKMDMKCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x85A8790", Offset = "0x85A7390", VA = "0x1885A8790")]
	private void CAMKDJJKOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JPODAJIKAGH : JHHHHBDOGEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MAHLEDFAIAJ ODLDNEGKKBJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody FIMACPMLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool DGGJALNGJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD1B0", Offset = "0x85ABDB0", VA = "0x1885AD1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool INFECABBEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x195CC90", Offset = "0x195B890", VA = "0x18195CC90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x85B0110", Offset = "0x85AED10", VA = "0x1885B0110")]
	public JPODAJIKAGH(EADBHHGHCOL KBHNLJCJFLC, [In] EOOCHJMGNCA PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x85AFE50", Offset = "0x85AEA50", VA = "0x1885AFE50", Slot = "5")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85B00E0", Offset = "0x85AECE0", VA = "0x1885B00E0", Slot = "7")]
	public void GHMOAFKJOHK(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x85AF970", Offset = "0x85AE570", VA = "0x1885AF970", Slot = "8")]
	public void CFBDGKKPEKB(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x85AF9A0", Offset = "0x85AE5A0", VA = "0x1885AF9A0", Slot = "9")]
	public void CIJFKCOFEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x85AFEF0", Offset = "0x85AEAF0", VA = "0x1885AFEF0", Slot = "10")]
	public void EOFJHGHICBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x85AFCD0", Offset = "0x85AE8D0", VA = "0x1885AFCD0", Slot = "11")]
	public void CMLJKOFLNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LIFCMJBNHGE : DOJEKCBNICP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PFKDEFEEHLJ KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MAHLEDFAIAJ IDMOKAGFINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float EHHFCBJCHCE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LMAIOBGFFMJ DBNNHGCNHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public JKCAKHJBMFN PDHGEMIBIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 ODPIFACDMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x85B2610", Offset = "0x85B1210", VA = "0x1885B2610", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x85B2220", Offset = "0x85B0E20", VA = "0x1885B2220", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 KHFBCHDFOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E80", Offset = "0x85AFA80", VA = "0x1885B0E80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3300", Offset = "0x85B1F00", VA = "0x1885B3300", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 LELBJFGMPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x85B2AB0", Offset = "0x85B16B0", VA = "0x1885B2AB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85B3E80", Offset = "0x85B2A80", VA = "0x1885B3E80", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 BFIGAHMHCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x85B3C50", Offset = "0x85B2850", VA = "0x1885B3C50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x85B2840", Offset = "0x85B1440", VA = "0x1885B2840", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float FMNHKGBBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA70660", Offset = "0xA6F260", VA = "0x180A70660", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x85B17D0", Offset = "0x85B03D0", VA = "0x1885B17D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool OCLDBLJLAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x23A8310", Offset = "0x23A6F10", VA = "0x1823A8310", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ENHGOHHABGE ICMFIADEAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7B42250", Offset = "0x7B40E50", VA = "0x187B42250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool LDHNLIEOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x85B19E0", Offset = "0x85B05E0", VA = "0x1885B19E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x85B4420", Offset = "0x85B3020", VA = "0x1885B4420")]
	public LIFCMJBNHGE(EADBHHGHCOL KBHNLJCJFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85B18E0", Offset = "0x85B04E0", VA = "0x1885B18E0", Slot = "19")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85B1980", Offset = "0x85B0580", VA = "0x1885B1980", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x85B3B20", Offset = "0x85B2720", VA = "0x1885B3B20", Slot = "28")]
	public void MNNHILOOMPM(Rigidbody KOGOAMNMHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1741990", Offset = "0x1740590", VA = "0x181741990", Slot = "20")]
	public void NOACDPBHKHI(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1741340", Offset = "0x173FF40", VA = "0x181741340", Slot = "30")]
	public void BABDHBILMNA(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x85B0FA0", Offset = "0x85AFBA0", VA = "0x1885B0FA0", Slot = "35")]
	public Vector3 AHAHEAFAIOM(Vector3 MKKLJCLAENJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x85B2CC0", Offset = "0x85B18C0", VA = "0x1885B2CC0", Slot = "34")]
	public Vector3 LBPADMLAJPO(Vector3 KHCAEECDNDM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x85B18E0", Offset = "0x85B04E0", VA = "0x1885B18E0", Slot = "27")]
	public void EGLFPKADDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x85B3F40", Offset = "0x85B2B40", VA = "0x1885B3F40", Slot = "25")]
	public void PAJKABDAGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C00", Offset = "0x85B1800", VA = "0x1885B2C00", Slot = "24")]
	public void KHCNKJLJKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x85B2870", Offset = "0x85B1470", VA = "0x1885B2870", Slot = "33")]
	public void KFGOBBOADCN(Vector3 AABFLGNECOB, Vector3 FHPBADOOCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C60", Offset = "0x85B1860", VA = "0x1885B2C60", Slot = "32")]
	public void LBFNJIDNBOD(Vector3 PDOEEHIABID, Vector3 FAFGAPDLINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x85B3980", Offset = "0x85B2580", VA = "0x1885B3980", Slot = "31")]
	public void MDJPOAOCGKP(Vector3 FBDGFEEKAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85B3330", Offset = "0x85B1F30", VA = "0x1885B3330", Slot = "22")]
	public void MCNBCNIBGFA(IBAPNPEDNNP GFBHFNJFEGM, Vector3 JIIHIAGFIGK, float HHKBILOIFPE, float ADBHMBMIDLI = 8f, float DKOCDAOHKFH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x85B1FA0", Offset = "0x85B0BA0", VA = "0x1885B1FA0", Slot = "21")]
	public void GDAPFOMNLMF(MPBEDBOENLK BKMICPMKELA, Vector3 BLLAOHANMCE, float HKDLPFFMCIB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x85B2E80", Offset = "0x85B1A80", VA = "0x1885B2E80", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LIGIGFIECDM(MPBEDBOENLK BKMICPMKELA, Vector3 BFEELDCLMGM, float IOPBCCGPEBC = 7f, float NNKGFLBDMBK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x188C5E0", Offset = "0x188B1E0", VA = "0x18188C5E0")]
	private static void DOMEKJBCFDF(Vector3 PLOBHHEKGDJ, Vector3 AKLPJIPJBIP, [Out] Vector3 HAAFLLBJNCG, [Out] Vector3 IAMJHDIEKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x85B2760", Offset = "0x85B1360", VA = "0x1885B2760", Slot = "29")]
	public Vector3 INAHMCMAAEB(Vector3 PLOBHHEKGDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x85B22E0", Offset = "0x85B0EE0", VA = "0x1885B22E0", Slot = "26")]
	public void IHHGJKMLHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x85B17D0", Offset = "0x85B03D0", VA = "0x1885B17D0")]
	private void DDPCAOGGEMI(float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x85B2470", Offset = "0x85B1070", VA = "0x1885B2470")]
	private void IILCEOGKCAB(Vector3 BLLAOHANMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x85B3D70", Offset = "0x85B2970", VA = "0x1885B3D70")]
	private Vector3 NIIMIPPACLH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x85B3FA0", Offset = "0x85B2BA0", VA = "0x1885B3FA0")]
	private void PPBDFCELFHF(Vector3 KHCAEECDNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x85B1A00", Offset = "0x85B0600", VA = "0x1885B1A00")]
	private Vector3 FDDEGKCDOAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x85B1B20", Offset = "0x85B0720", VA = "0x1885B1B20")]
	private void FKEOEBIOMKE(Vector3 OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x85B1230", Offset = "0x85AFE30", VA = "0x1885B1230")]
	private void CNCAPINENPD(Vector3 KHCAEECDNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x85B1180", Offset = "0x85AFD80", VA = "0x1885B1180")]
	private void BACEOEDKDEC()
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
