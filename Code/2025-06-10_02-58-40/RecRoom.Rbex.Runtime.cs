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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8433850", Offset = "0x8432A50", VA = "0x188433850", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E08C50", Offset = "0x7E07E50", VA = "0x187E08C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x843F720", Offset = "0x843E920", VA = "0x18843F720")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x843FA30", Offset = "0x843EC30", VA = "0x18843FA30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x843FA90", Offset = "0x843EC90", VA = "0x18843FA90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, NIJLAPDBAHE, DJNFGEJICJL, FCCLCKGFKHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly KEPOMIIOHBM LLJHICPJODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PDLBGOBHJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private PHNCFOGEOOF NHPKMJMDCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[GOJJDCGGJEB(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GOJJDCGGJEB(CFJMFGLCHFI.SelfAndParent, true, false, false)]
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
		private JOHOKOFPFMP physicsInterpolation;

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
		private Transform AHPNCLLHAME;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal PHNCFOGEOOF MPAGGOAONBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x843A240", Offset = "0x8439440", VA = "0x18843A240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PHNCFOGEOOF OCHGMDCBFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NPDGKKLDGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x843CBF0", Offset = "0x843BDF0", VA = "0x18843CBF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx OAEFDJPLLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x843CF50", Offset = "0x843C150", VA = "0x18843CF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LHGFIGHCCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x843CE90", Offset = "0x843C090", VA = "0x18843CE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx FLKKOCNDECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x843DB60", Offset = "0x843CD60", VA = "0x18843DB60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x843F090", Offset = "0x843E290", VA = "0x18843F090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GNLOCEOGNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8071220", Offset = "0x8070420", VA = "0x188071220", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x806E360", Offset = "0x806D560", VA = "0x18806E360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JGOMLHGOKKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2334030", Offset = "0x2333230", VA = "0x182334030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform HKFHMLJEHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2334030", Offset = "0x2333230", VA = "0x182334030", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform GLBJHHBHCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2334030", Offset = "0x2333230", VA = "0x182334030", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CMFBMPLFPMI IIKKDFEMLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x843CC50", Offset = "0x843BE50", VA = "0x18843CC50")]
			get
			{
				return default(CMFBMPLFPMI);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x843E840", Offset = "0x843DA40", VA = "0x18843E840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PABGIEGOABI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x843D260", Offset = "0x843C460", VA = "0x18843D260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FNNFICHJMJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x843CD70", Offset = "0x843BF70", VA = "0x18843CD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AMBDNINENEN LMPICKEHJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x843D1A0", Offset = "0x843C3A0", VA = "0x18843D1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x843EA00", Offset = "0x843DC00", VA = "0x18843EA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ICKNPKALBAM ONDPGDGBCOA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x843D140", Offset = "0x843C340", VA = "0x18843D140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x843E990", Offset = "0x843DB90", VA = "0x18843E990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LICAOAJPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x843D090", Offset = "0x843C290", VA = "0x18843D090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody MKLKACPEPHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x843D0F0", Offset = "0x843C2F0", VA = "0x18843D0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BEGLONAEOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x843CDD0", Offset = "0x843BFD0", VA = "0x18843CDD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x843E8B0", Offset = "0x843DAB0", VA = "0x18843E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OBCEPIDFABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1793DA0", Offset = "0x1792FA0", VA = "0x181793DA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HOCEGBAIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x843DB00", Offset = "0x843CD00", VA = "0x18843DB00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KEPKOEINOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x843DAA0", Offset = "0x843CCA0", VA = "0x18843DAA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x843F020", Offset = "0x843E220", VA = "0x18843F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float LOIIKFBOEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x843D4C0", Offset = "0x843C6C0", VA = "0x18843D4C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x843ECA0", Offset = "0x843DEA0", VA = "0x18843ECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NBMGNKBIKAP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x843D2C0", Offset = "0x843C4C0", VA = "0x18843D2C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x843EA70", Offset = "0x843DC70", VA = "0x18843EA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool DLPKHNCEOAL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x843E0E0", Offset = "0x843D2E0", VA = "0x18843E0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x843F5D0", Offset = "0x843E7D0", VA = "0x18843F5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 DIJBOHNAHDA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x843D880", Offset = "0x843CA80", VA = "0x18843D880")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x843EDF0", Offset = "0x843DFF0", VA = "0x18843EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 DPKPPPDKBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x843E220", Offset = "0x843D420", VA = "0x18843E220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode ACKHDMHLGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x843D400", Offset = "0x843C600", VA = "0x18843D400")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x843EBC0", Offset = "0x843DDC0", VA = "0x18843EBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MAJPAAENDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x843CE30", Offset = "0x843C030", VA = "0x18843CE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x843E920", Offset = "0x843DB20", VA = "0x18843E920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints EJJDBFLMEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x843D460", Offset = "0x843C660", VA = "0x18843D460")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x843EC30", Offset = "0x843DE30", VA = "0x18843EC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GAMBELBKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x843DC20", Offset = "0x843CE20", VA = "0x18843DC20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 CHGGIEIKBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x843DC20", Offset = "0x843CE20", VA = "0x18843DC20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x843F3B0", Offset = "0x843E5B0", VA = "0x18843F3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float LINGFBEKMDG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x843D960", Offset = "0x843CB60", VA = "0x18843D960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x843EED0", Offset = "0x843E0D0", VA = "0x18843EED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NOBHDDIHACE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x843E080", Offset = "0x843D280", VA = "0x18843E080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x843F560", Offset = "0x843E760", VA = "0x18843F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion FDABDOCOOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x843DD00", Offset = "0x843CF00", VA = "0x18843DD00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x843F130", Offset = "0x843E330", VA = "0x18843F130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion BJKLBKAGMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x843DFA0", Offset = "0x843D1A0", VA = "0x18843DFA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x843F490", Offset = "0x843E690", VA = "0x18843F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GMEANDLONKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x843DDE0", Offset = "0x843CFE0", VA = "0x18843DDE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x843F200", Offset = "0x843E400", VA = "0x18843F200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion NIMCOODCEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x843DEC0", Offset = "0x843D0C0", VA = "0x18843DEC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x843F2E0", Offset = "0x843E4E0", VA = "0x18843F2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AJNMLFPKEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x843E140", Offset = "0x843D340", VA = "0x18843E140")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x843F640", Offset = "0x843E840", VA = "0x18843F640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HEBMKEEGADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x843D9C0", Offset = "0x843CBC0", VA = "0x18843D9C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x843EF40", Offset = "0x843E140", VA = "0x18843EF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MKIIBLHCBDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x843D320", Offset = "0x843C520", VA = "0x18843D320")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x843EAE0", Offset = "0x843DCE0", VA = "0x18843EAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MDOMAAAPHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x843D7A0", Offset = "0x843C9A0", VA = "0x18843D7A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x843ED10", Offset = "0x843DF10", VA = "0x18843ED10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FPNINKIFPEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x843D660", Offset = "0x843C860", VA = "0x18843D660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion IHLDOPLBHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x843D580", Offset = "0x843C780", VA = "0x18843D580")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 KGBJEINLNML
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x843E3E0", Offset = "0x843D5E0", VA = "0x18843E3E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ALFJOJICJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x843E300", Offset = "0x843D500", VA = "0x18843E300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IJKMKNOAIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x843D740", Offset = "0x843C940", VA = "0x18843D740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CIEBCPPNCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x843D200", Offset = "0x843C400", VA = "0x18843D200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ONJCPCNOAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x843CD10", Offset = "0x843BF10", VA = "0x18843CD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EBBNLNKCIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x843CCB0", Offset = "0x843BEB0", VA = "0x18843CCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FOGFOLBEPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x843CB90", Offset = "0x843BD90", VA = "0x18843CB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool DGEBMJDABAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x843D520", Offset = "0x843C720", VA = "0x18843D520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool CFMEGCKFFEH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x24DD4C0", Offset = "0x24DC6C0", VA = "0x1824DD4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EEPFMKEJJPJ BDBPCJBLPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x843CAB0", Offset = "0x843BCB0", VA = "0x18843CAB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x843E760", Offset = "0x843D960", VA = "0x18843E760")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LGEMEOCGCEJ KONBLHNACOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x843C820", Offset = "0x843BA20", VA = "0x18843C820")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x843E4C0", Offset = "0x843D6C0", VA = "0x18843E4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LGEMEOCGCEJ GKGJNCINCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x843C880", Offset = "0x843BA80", VA = "0x18843C880")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x843E530", Offset = "0x843D730", VA = "0x18843E530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event LGEMEOCGCEJ DHHEGKEOJJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x843C9D0", Offset = "0x843BBD0", VA = "0x18843C9D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x843E680", Offset = "0x843D880", VA = "0x18843E680")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<DLGGNNMFNFI, DLGGNNMFNFI> CBKINBMILBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x843C960", Offset = "0x843BB60", VA = "0x18843C960")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x843E610", Offset = "0x843D810", VA = "0x18843E610")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event LGEMEOCGCEJ DBPHCMKFDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x843CA40", Offset = "0x843BC40", VA = "0x18843CA40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x843E6F0", Offset = "0x843D8F0", VA = "0x18843E6F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event LGEMEOCGCEJ NFMOIDAODJB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x843CB20", Offset = "0x843BD20", VA = "0x18843CB20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x843E7D0", Offset = "0x843D9D0", VA = "0x18843E7D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event LGEMEOCGCEJ NNBCBJDJPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x843C8F0", Offset = "0x843BAF0", VA = "0x18843C8F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x843E5A0", Offset = "0x843D7A0", VA = "0x18843E5A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190", Slot = "8")]
		private void KCDEDNOENIJ(PHNCFOGEOOF IBLPGPPBNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x843B2A0", Offset = "0x843A4A0", VA = "0x18843B2A0", Slot = "9")]
		public JJJNBIJGPDG GetData()
		{
			return default(JJJNBIJGPDG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x843B720", Offset = "0x843A920", VA = "0x18843B720")]
		internal void KPLAFNJCDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x843C550", Offset = "0x843B750", VA = "0x18843C550")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EPELOGPFGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x843AFF0", Offset = "0x843A1F0", VA = "0x18843AFF0")]
		public NIJLAPDBAHE GetChild(int CMDFFDAPDIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x843C210", Offset = "0x843B410", VA = "0x18843C210")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) PLBDLBHPJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x843AC40", Offset = "0x8439E40", VA = "0x18843AC40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x843C4A0", Offset = "0x843B6A0", VA = "0x18843C4A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x843A240", Offset = "0x8439440", VA = "0x18843A240")]
		private PHNCFOGEOOF CPABEOCODND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x843B330", Offset = "0x843A530", VA = "0x18843B330")]
		private void IJDFNMPLFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x843B9E0", Offset = "0x843ABE0", VA = "0x18843B9E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x843B920", Offset = "0x843AB20", VA = "0x18843B920")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x843B720", Offset = "0x843A920", VA = "0x18843B720")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x843B980", Offset = "0x843AB80", VA = "0x18843B980")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x843BA40", Offset = "0x843AC40", VA = "0x18843BA40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x843A2F0", Offset = "0x84394F0", VA = "0x18843A2F0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x843BAA0", Offset = "0x843ACA0", VA = "0x18843BAA0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x843AF90", Offset = "0x843A190", VA = "0x18843AF90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x843B8C0", Offset = "0x843AAC0", VA = "0x18843B8C0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x843C370", Offset = "0x843B570", VA = "0x18843C370")]
		public void SetParent(RigidbodyEx KJIOHKMJAPE, bool PEMCPPNLJOK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x843BDB0", Offset = "0x843AFB0", VA = "0x18843BDB0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x843B4B0", Offset = "0x843A6B0", VA = "0x18843B4B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx CHIAOJJGKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x843B5B0", Offset = "0x843A7B0", VA = "0x18843B5B0")]
		public bool IsRigidbodyDescendant(RigidbodyEx JPIEDBAELIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x843A560", Offset = "0x8439760", VA = "0x18843A560")]
		public void AddInterpolationRestriction(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x843BB10", Offset = "0x843AD10", VA = "0x18843BB10")]
		public void RemoveInterpolationRestriction(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x843A5D0", Offset = "0x84397D0", VA = "0x18843A5D0")]
		public void AddKinematic(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x843BB80", Offset = "0x843AD80", VA = "0x18843BB80")]
		public void RemoveKinematic(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x843C2F0", Offset = "0x843B4F0", VA = "0x18843C2F0")]
		public void SetKinematic(object CCLFNPCGNED, bool JEHOOBEDLAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x843C110", Offset = "0x843B310", VA = "0x18843C110")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JEFKJIMPADK, Quaternion JLMCFEOBFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x843C010", Offset = "0x843B210", VA = "0x18843C010")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ALIFNAHGJDF, Quaternion DCBHDPNLHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x843B190", Offset = "0x843A390", VA = "0x18843B190")]
		public Vector3 GetConstrainedVelocity(Vector3 AJNMLFPKEJH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x843B080", Offset = "0x843A280", VA = "0x18843B080")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 MKIIBLHCBDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x843A470", Offset = "0x8439670", VA = "0x18843A470")]
		public void AddForce(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x843A360", Offset = "0x8439560", VA = "0x18843A360")]
		public void AddForceAtPosition(Vector3 IKLDNLEDLAC, Vector3 FICCENLPJEL, ForceMode BIMCLGPPPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x843A7A0", Offset = "0x84399A0", VA = "0x18843A7A0")]
		public void AddTorque(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x843A640", Offset = "0x8439840", VA = "0x18843A640")]
		public void AddRelativeTorque(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x843C620", Offset = "0x843B820", VA = "0x18843C620")]
		public Vector3 WorldToLocalVelocity(Vector3 IFPOFGCJIOC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x843B7B0", Offset = "0x843A9B0", VA = "0x18843B7B0")]
		public Vector3 LocalToWorldVelocity(Vector3 HEBMKEEGADP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x843AF30", Offset = "0x843A130", VA = "0x18843AF30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x843AED0", Offset = "0x843A0D0", VA = "0x18843AED0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x843AE70", Offset = "0x843A070", VA = "0x18843AE70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x843AE10", Offset = "0x843A010", VA = "0x18843AE10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x843BF10", Offset = "0x843B110", VA = "0x18843BF10")]
		public void ResetVelocityWorldSpace(Vector3 OLNMJECJIHN, Vector3 KONENOOPMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x843BE10", Offset = "0x843B010", VA = "0x18843BE10")]
		public void ResetVelocityLocalSpace(Vector3 IOEEHPMHLON, Vector3 MDOMAAAPHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x843BCD0", Offset = "0x843AED0", VA = "0x18843BCD0")]
		public void ResetLinearVelocityLocalSpace(Vector3 IOEEHPMHLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x843C4B0", Offset = "0x843B6B0", VA = "0x18843C4B0")]
		public bool SweepTest(Vector3 JBACNGDELHL, [Out] RaycastHit LAPIKELMKEJ, float ADBCFFBIBMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x843B6B0", Offset = "0x843A8B0", VA = "0x18843B6B0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x843C440", Offset = "0x843B640", VA = "0x18843C440")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x843C5C0", Offset = "0x843B7C0", VA = "0x18843C5C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x843A730", Offset = "0x8439930", VA = "0x18843A730")]
		public void AddShouldHaveUnityRigidbodyToken(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x843BBF0", Offset = "0x843ADF0", VA = "0x18843BBF0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x843AAD0", Offset = "0x8439CD0", VA = "0x18843AAD0")]
		public void ApplyForceVelocityChange(FOFJEBJADLK CKGKMBNIHEB, Vector3 FLKIJPNGFFJ, float HGBMIGEGDNO, float CJLCLIAJNED = 8f, float MLLIAHIMCBD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x843AA30", Offset = "0x8439C30", VA = "0x18843AA30")]
		public void ApplyAngularVelocityChange(IKMHDDEODBJ PLGEODGNDIP, Vector3 EGAKJMHBNCA, float PNDDEFAPACE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x843AB90", Offset = "0x8439D90", VA = "0x18843AB90")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IKMHDDEODBJ PLGEODGNDIP, Vector3 NDOBKEDDJAJ, float FGPLLNDELCJ = 7f, float ALNDLCNCPII = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x843A960", Offset = "0x8439B60", VA = "0x18843A960")]
		public bool AllowedScaleChange(float CHCCCCJIGOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x843A890", Offset = "0x8439A90", VA = "0x18843A890")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PIKCGJKMBFP, object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x843BC60", Offset = "0x843AE60", VA = "0x18843BC60")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x843B710", Offset = "0x843A910", VA = "0x18843B710", Slot = "13")]
		private void JBEIGHADEMH(FDMFIFPHKJP BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x843C7B0", Offset = "0x843B9B0", VA = "0x18843C7B0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA79C10", Offset = "0xA78E10", VA = "0x180A79C10", Slot = "4")]
		private GameObject HACFHPKJOAN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA2DEE0", Offset = "0xA2D0E0", VA = "0x180A2DEE0", Slot = "10")]
		private bool DEFMALGKJBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HLEBBJNNJMK
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8430FB0", Offset = "0x84301B0", VA = "0x188430FB0")]
	public static PHNCFOGEOOF MPAGGOAONBN(this RigidbodyEx MCFDCNGFCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LJAKHMOMFFF), new string[] { })]
public class MPECIMDKEPN : LJAKHMOMFFF, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KMFBNFJBEDH PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ELGBPJDCILP JIGEBIJNNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KMFBNFJBEDH ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ELGBPJDCILP JHLAIJNEJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8435700", Offset = "0x8434900", VA = "0x188435700", Slot = "7")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84355D0", Offset = "0x84347D0", VA = "0x1884355D0", Slot = "6")]
	public PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public MPECIMDKEPN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static EPHHEFDKGKL UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int FMFAIPKJLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int KOFKEJGIPHF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x843A0C0", Offset = "0x84392C0", VA = "0x18843A0C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x843A100", Offset = "0x8439300", VA = "0x18843A100")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x843A0E0", Offset = "0x84392E0", VA = "0x18843A0E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NPEJLHCJPAI, [Optional] UnityEngine.Object BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NPEJLHCJPAI, [Optional] UnityEngine.Object BKDMJHGCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x843A1F0", Offset = "0x84393F0", VA = "0x18843A1F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GGAGOJMCPKO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FIJAGKALOOI : AMBDNINENEN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA11A10", Offset = "0xA10C10", VA = "0x180A11A10", Slot = "4")]
		public Vector3 FEKDDENKDJG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA11A10", Offset = "0xA10C10", VA = "0x180A11A10", Slot = "5")]
		public Vector3 LHNKIIGFDFF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "6")]
		public bool HAFDAELGLDK(float MBEIIICALJN, float NPFICCAIELL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FIJAGKALOOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static AMBDNINENEN EDEBHJOPEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x842D610", Offset = "0x842C810", VA = "0x18842D610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OOGMFIKJPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode FLLNAGFOKCC
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
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIDICJEJHNO(bool IJKMKNOAIIP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADNGLLPBJPF(bool IJKMKNOAIIP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PDKMELOHKJD(Vector3 JBACNGDELHL, [Out] RaycastHit LAPIKELMKEJ, float ADBCFFBIBMG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PMLPKBOMJFN : IDisposable, DNCJIBHBDAC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CMFBMPLFPMI IIKKDFEMLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<DLGGNNMFNFI, DLGGNNMFNFI> CBKINBMILBF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDADFJBFCMK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface ELGBPJDCILP
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMKLCKJEIOA JHOMIGHFJGO(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIKDEFJGLDC MAJEAJIPGOA(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFAMJOEKPNI PPAHGLNMIDO(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KEMLPLAEJKD DCILDCLMAFI(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMMBIKFDAKI KGONBKDCBJJ(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PMLPKBOMJFN CNAGMPDGPJE(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GAPJIKMIOME EKMOIILLNMJ(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GGGOHCKBGKD JPHPLKAJKPK(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OOGMFIKJPAM GAANHCBMPLI(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JBGALMMJIKH FMDBONILKHL(PHNCFOGEOOF IBLPGPPBNHF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HFOJIIPFDGF FMBFPIELIPK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NMMHPIHNPCC AIGNNGLJBNE(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ADIHGAEPOCM DEIKEBCDGFA(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LMIHLCKIIJI AAKAJFEAPEK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MENLNIPELDL CBLHGCOJOFC(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI, JJJNBIJGPDG CAIGHLKIDBF, LJAKHMOMFFF OBHJPIMFHEM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GGGOHCKBGKD
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCCKIOHFPJB(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHPNIOLBLCN(Vector3 IKLDNLEDLAC, Vector3 FICCENLPJEL, ForceMode BIMCLGPPPMH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLHBKCIMMGL(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBCDHOGAELK(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JBGALMMJIKH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OIDDBDAGPAG
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
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGLPBDFAJJO(Rigidbody MFFGACBHHHG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EMKLCKJEIOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<PHNCFOGEOOF> ALCPIDFAMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PHNCFOGEOOF LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LGEMEOCGCEJ KONBLHNACOM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LGEMEOCGCEJ GKGJNCINCAH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EEPFMKEJJPJ NAFACMHLIAH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action CKIGFGNIKKO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CNEACKLAMML;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PHNCFOGEOOF> ABNBECEHEAA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PHNCFOGEOOF> LEOFOJIDDPF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action PEJGBLCFAPC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<PHNCFOGEOOF> JODHGHLEFAF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KMHANLPIIHA(PHNCFOGEOOF DAFAJHDHOLC, bool PEMCPPNLJOK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BFAMJOEKPNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 OFPEANCCINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 PGCDCJNGEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBDFIEPGHAI(PHNCFOGEOOF FLKKOCNDECC, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANKINBHHNPP(object CCLFNPCGNED);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LMIHLCKIIJI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 PJPAOHGANHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 HEJFILFCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float MKFGMFLBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float PHAKCFCOGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 BALPJDKAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion JCNFCLBJBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event LGEMEOCGCEJ JNHKJONJMGO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AKLNNGGKMIH((Quaternion rot, Vector3 moments) PLBDLBHPJFE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GEMMKEPNPNH();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLJPLAPNPNH();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DLMHNBAPCLO();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGLPBDFAJJO(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PJLJKNEDMJP();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ADIHGAEPOCM
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFNLAIJIILK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIBDIEONHML(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLFFFLBJMPP(PHNCFOGEOOF MCFDCNGFCOI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKCOLABOPIP(PHNCFOGEOOF MCFDCNGFCOI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGHDGJCKKPA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GAPJIKMIOME
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JNAFLDCOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LGEMEOCGCEJ BNOICKDILLH;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOJJPDINDLK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHPLJAPEBNK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIELPKBDIGM(object CCLFNPCGNED, bool JEHOOBEDLAD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKNFNCAAAEN(Rigidbody CCNFPPEFCMI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGLPBDFAJJO(Rigidbody MFFGACBHHHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMMHPIHNPCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PABGIEGOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FNNFICHJMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event LGEMEOCGCEJ DPJEAPGBMHC;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDJBPIKOCGI(PHNCFOGEOOF FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPPNACNIEBO(PHNCFOGEOOF FLKKOCNDECC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MENLNIPELDL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BEGLONAEOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool AMINFAJDJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints FIIBEJBGGDN
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
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGLPBDFAJJO(Rigidbody MFFGACBHHHG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KEMLPLAEJKD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float MPIGHGHEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ONCIEDPNPJN
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
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGLPBDFAJJO(Rigidbody MFFGACBHHHG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CMMBIKFDAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool OGMPBKHLAPO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LGEMEOCGCEJ INCNFIELLHI;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEKINICHOKM();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCICGFJLKGH();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMBAJAMHHAB();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GGKAAMGGGNJ();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PFANNEJOFFG();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LACFGAGOOIH(bool BCODKBLOGCG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BDCLNOEFNCL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HFOJIIPFDGF
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GJEPLOOKELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNGNFEOJBBF(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JADKGBEPFDN(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDBPIMHHIAC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HIKDEFJGLDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	AMBDNINENEN LMPICKEHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	ICKNPKALBAM ONDPGDGBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LDKHAFPEALE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 BIFDABBKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 EJNNDMKJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 FLINLHJIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MAJPAAENDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LICAOAJPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDADFJBFCMK();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BBBPOOABNKK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OCDBEAPHLLH(IKMHDDEODBJ PLGEODGNDIP, Vector3 EGAKJMHBNCA, float PNDDEFAPACE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FEGKFKJFNOI(FOFJEBJADLK CKGKMBNIHEB, Vector3 FLKIJPNGFFJ, float HGBMIGEGDNO, float CJLCLIAJNED = 8f, float MLLIAHIMCBD = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EFMBABIFDMP(IKMHDDEODBJ PLGEODGNDIP, Vector3 NDOBKEDDJAJ, float FGPLLNDELCJ = 7f, float ALNDLCNCPII = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ELOFIACINEH();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LDFHNJAJBEG();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KPIKCEGFCFP();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NLGMCMODFPP();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IKNFNCAAAEN(Rigidbody MFFGACBHHHG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 ADDCGGECPML(Vector3 AJNMLFPKEJH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OOMKBPMLFHK(object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DKICKCIFEFD(Vector3 FDMJBKNIFKE);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AHALKHHCKGK(Vector3 IOEEHPMHLON, Vector3 MDOMAAAPHIC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FCAMJGNDKLE(Vector3 OLNMJECJIHN, Vector3 KONENOOPMNL);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KJFKNNAOPPF(Vector3 HEBMKEEGADP);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 NIJFNJGENME(Vector3 IFPOFGCJIOC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface KMFBNFJBEDH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool IMDMODMMLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MALKJKHCOIA(string HKIJLMNBOAG);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIPGINAFHNA(RigidbodyEx MCFDCNGFCOI, Action CJLPDLONOLK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPIDDDBCPEO ONNIDPFHHOL(int PCAHHEENFEH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAIMGPGKGEK(Vector3 DPKPPPDKBDP, float GMIGGIHFDOB, Color NEMIFEKMDAI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LJAKHMOMFFF
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	KMFBNFJBEDH ONPPLLOGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	ELGBPJDCILP JHLAIJNEJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DBHGBEPAPMD : PHNCFOGEOOF, IDisposable, AMPNAGGHBCI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool KMFHOLEMHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LJAKHMOMFFF OBHJPIMFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal EMKLCKJEIOA OPMMMGOPKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ADIHGAEPOCM ONCJHLLNJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal NMMHPIHNPCC AEONDPHEAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HIKDEFJGLDC AJNMLFPKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal BFAMJOEKPNI GBJLEKLPLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LMIHLCKIIJI FIFBJNHKGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal KEMLPLAEJKD DCBLODAOFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal JBGALMMJIKH CINIDHHMPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal CMMBIKFDAKI AMPMECIMBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PMLPKBOMJFN OKIBEPNOFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal GAPJIKMIOME GLOBJBGEMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal GGGOHCKBGKD IKLDNLEDLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal MENLNIPELDL NGFDJIOFJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HFOJIIPFDGF MFFGACBHHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal OOGMFIKJPAM PEKFBPEJHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable OLOJNHHKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool OHNNMGFBNHC;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EBBGNAFIMFG NPCNMGPIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "22")]
		get
		{
			return default(EBBGNAFIMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NIJLAPDBAHE LKKIJBANEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xD54F00", Offset = "0xD54100", VA = "0x180D54F00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xEBEEA0", Offset = "0xEBE0A0", VA = "0x180EBEEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA07240", Offset = "0xA06440", VA = "0x180A07240", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA071B0", Offset = "0xA063B0", VA = "0x180A071B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xDC9B70", Offset = "0xDC8D70", VA = "0x180DC9B70", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECDFD0", VA = "0x180ECEDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8425E20", Offset = "0x8425020", VA = "0x188425E20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x842BFB0", Offset = "0x842B1B0", VA = "0x18842BFB0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8426670", Offset = "0x8425870", VA = "0x188426670", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NPDGKKLDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84264C0", Offset = "0x84256C0", VA = "0x1884264C0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public PHNCFOGEOOF LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x84283A0", Offset = "0x84275A0", VA = "0x1884283A0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EEFKKNIEIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84272E0", Offset = "0x84264E0", VA = "0x1884272E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PABGIEGOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x842BC70", Offset = "0x842AE70", VA = "0x18842BC70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool FNNFICHJMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x842C0B0", Offset = "0x842B2B0", VA = "0x18842C0B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AMBDNINENEN LMPICKEHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8425E70", Offset = "0x8425070", VA = "0x188425E70", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8426EB0", Offset = "0x84260B0", VA = "0x188426EB0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public ICKNPKALBAM ONDPGDGBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x842B9D0", Offset = "0x842ABD0", VA = "0x18842B9D0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8428B90", Offset = "0x8427D90", VA = "0x188428B90", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MAJPAAENDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x842AB70", Offset = "0x8429D70", VA = "0x18842AB70", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8426C60", Offset = "0x8425E60", VA = "0x188426C60", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 BIFDABBKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8428510", Offset = "0x8427710", VA = "0x188428510", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8429320", Offset = "0x8428520", VA = "0x188429320", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 FLINLHJIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8428120", Offset = "0x8427320", VA = "0x188428120", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x842A0B0", Offset = "0x84292B0", VA = "0x18842A0B0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 LDKHAFPEALE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8428780", Offset = "0x8427980", VA = "0x188428780", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x842B790", Offset = "0x842A990", VA = "0x18842B790", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 EJNNDMKJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8426260", Offset = "0x8425460", VA = "0x188426260", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8428CD0", Offset = "0x8427ED0", VA = "0x188428CD0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool ONJCPCNOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8429640", Offset = "0x8428840", VA = "0x188429640", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool EBBNLNKCIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x84289F0", Offset = "0x8427BF0", VA = "0x1884289F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FOGFOLBEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x84260B0", Offset = "0x84252B0", VA = "0x1884260B0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LICAOAJPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x842AAB0", Offset = "0x8429CB0", VA = "0x18842AAB0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 OFPEANCCINF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8429690", Offset = "0x8428890", VA = "0x188429690", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 PGCDCJNGEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x84271B0", Offset = "0x84263B0", VA = "0x1884271B0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 PJPAOHGANHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8428F00", Offset = "0x8428100", VA = "0x188428F00", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8428AB0", Offset = "0x8427CB0", VA = "0x188428AB0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 HEJFILFCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8429180", Offset = "0x8428380", VA = "0x188429180", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float MKFGMFLBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x84294C0", Offset = "0x84286C0", VA = "0x1884294C0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float PHAKCFCOGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8427FC0", Offset = "0x84271C0", VA = "0x188427FC0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8428990", Offset = "0x8427B90", VA = "0x188428990", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 BALPJDKAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8428FE0", Offset = "0x84281E0", VA = "0x188428FE0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion JCNFCLBJBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x842BEE0", Offset = "0x842B0E0", VA = "0x18842BEE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float MPIGHGHEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8426E60", Offset = "0x8426060", VA = "0x188426E60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x84282E0", Offset = "0x84274E0", VA = "0x1884282E0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float ONCIEDPNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8428BF0", Offset = "0x8427DF0", VA = "0x188428BF0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8429400", Offset = "0x8428600", VA = "0x188429400", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool OIDDBDAGPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8426800", Offset = "0x8425A00", VA = "0x188426800", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x842AB00", Offset = "0x8429D00", VA = "0x18842AB00", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CMFBMPLFPMI IIKKDFEMLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x842B0C0", Offset = "0x842A2C0", VA = "0x18842B0C0", Slot = "70")]
		get
		{
			return default(CMFBMPLFPMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x842B8D0", Offset = "0x842AAD0", VA = "0x18842B8D0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool JNAFLDCOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8428650", Offset = "0x8427850", VA = "0x188428650", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform GLBJHHBHCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xDC9B70", Offset = "0xDC8D70", VA = "0x180DC9B70", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 GABCDCKCPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x84297C0", Offset = "0x84289C0", VA = "0x1884297C0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x84288E0", Offset = "0x8427AE0", VA = "0x1884288E0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float DMLBOIHBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x842AB60", Offset = "0x8429D60", VA = "0x18842AB60", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8426340", Offset = "0x8425540", VA = "0x188426340", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float NELECBAJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x842AFD0", Offset = "0x842A1D0", VA = "0x18842AFD0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8426850", Offset = "0x8425A50", VA = "0x188426850", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion ENFOLGOEPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8426B60", Offset = "0x8425D60", VA = "0x188426B60", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x842AFE0", Offset = "0x842A1E0", VA = "0x18842AFE0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 DPCDBEOOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x842B520", Offset = "0x842A720", VA = "0x18842B520", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x84278E0", Offset = "0x8426AE0", VA = "0x1884278E0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion BDNOGOADCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8427840", Offset = "0x8426A40", VA = "0x188427840", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x842B4A0", Offset = "0x842A6A0", VA = "0x18842B4A0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints FIIBEJBGGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x842AA60", Offset = "0x8429C60", VA = "0x18842AA60", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8426C00", Offset = "0x8425E00", VA = "0x188426C00", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BEGLONAEOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8427970", Offset = "0x8426B70", VA = "0x188427970", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8428A50", Offset = "0x8427C50", VA = "0x188428A50", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode FLLNAGFOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8428070", Offset = "0x8427270", VA = "0x188428070", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8427880", Offset = "0x8426A80", VA = "0x188427880", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool HKLMJPKBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8426530", Offset = "0x8425730", VA = "0x188426530", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CIEBCPPNCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x842B5B0", Offset = "0x842A7B0", VA = "0x18842B5B0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LGEMEOCGCEJ KONBLHNACOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8429260", Offset = "0x8428460", VA = "0x188429260", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8429460", Offset = "0x8428660", VA = "0x188429460", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event LGEMEOCGCEJ GKGJNCINCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x842B270", Offset = "0x842A470", VA = "0x18842B270", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8426190", Offset = "0x8425390", VA = "0x188426190", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EEPFMKEJJPJ NAFACMHLIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x842BB30", Offset = "0x842AD30", VA = "0x18842BB30", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84280C0", Offset = "0x84272C0", VA = "0x1884280C0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LGEMEOCGCEJ DPJEAPGBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8426440", Offset = "0x8425640", VA = "0x188426440", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x842B730", Offset = "0x842A930", VA = "0x18842B730", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LGEMEOCGCEJ DHHEGKEOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x842B870", Offset = "0x842AA70", VA = "0x18842B870", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8427730", Offset = "0x8426930", VA = "0x188427730", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event LGEMEOCGCEJ INCNFIELLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x842C000", Offset = "0x842B200", VA = "0x18842C000", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x842A670", Offset = "0x8429870", VA = "0x18842A670", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<DLGGNNMFNFI, DLGGNNMFNFI> CBKINBMILBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x842B210", Offset = "0x842A410", VA = "0x18842B210", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8426050", Offset = "0x8425250", VA = "0x188426050", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LGEMEOCGCEJ BNOICKDILLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8429760", Offset = "0x8428960", VA = "0x188429760", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x842A840", Offset = "0x8429A40", VA = "0x18842A840", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LGEMEOCGCEJ NNBCBJDJPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8425EC0", Offset = "0x84250C0", VA = "0x188425EC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x842ABC0", Offset = "0x8429DC0", VA = "0x18842ABC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x842C140", Offset = "0x842B340", VA = "0x18842C140")]
	public DBHGBEPAPMD(GameObject LBBGHAOMHLO, RigidbodyEx DABPEKAOOIL, LJAKHMOMFFF OBHJPIMFHEM, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8427440", Offset = "0x8426640", VA = "0x188427440", Slot = "139")]
	protected virtual void EBEHAMIGIMN(LJAKHMOMFFF OBHJPIMFHEM, JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8427340", Offset = "0x8426540", VA = "0x188427340", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8426D20", Offset = "0x8425F20", VA = "0x188426D20", Slot = "93")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8428C40", Offset = "0x8427E40", VA = "0x188428C40", Slot = "94")]
	public void IEHFFCCKIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8428340", Offset = "0x8427540", VA = "0x188428340", Slot = "95")]
	public void GCBJAJLNEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x84264A0", Offset = "0x84256A0", VA = "0x1884264A0", Slot = "96")]
	public void BJDNDFNPIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8429A30", Offset = "0x8428C30", VA = "0x188429A30")]
	private void LACFGAGOOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x842A030", Offset = "0x8429230", VA = "0x18842A030")]
	private void LCEMLDKDKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x842BE80", Offset = "0x842B080", VA = "0x18842BE80")]
	private void PFANNEJOFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8428860", Offset = "0x8427A60", VA = "0x188428860", Slot = "30")]
	public PHNCFOGEOOF HAGMMKGFPCK(int CMDFFDAPDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8429970", Offset = "0x8428B70", VA = "0x188429970", Slot = "98")]
	public void KMHANLPIIHA(PHNCFOGEOOF KJIOHKMJAPE, bool PEMCPPNLJOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x842B340", Offset = "0x842A540", VA = "0x18842B340", Slot = "99")]
	public void NIFOGPHDDLL(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84290C0", Offset = "0x84282C0", VA = "0x1884290C0", Slot = "100")]
	public void IMNMMHIGOGN(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x842B3A0", Offset = "0x842A5A0", VA = "0x18842B3A0", Slot = "101")]
	public Vector3 NIJFNJGENME(Vector3 IFPOFGCJIOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8429870", Offset = "0x8428A70", VA = "0x188429870", Slot = "102")]
	public Vector3 KJFKNNAOPPF(Vector3 HEBMKEEGADP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x842B4D0", Offset = "0x842A6D0", VA = "0x18842B4D0", Slot = "103")]
	public void NLGMCMODFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x842A190", Offset = "0x8429390", VA = "0x18842A190", Slot = "104")]
	public void LDFHNJAJBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8427920", Offset = "0x8426B20", VA = "0x188427920", Slot = "105")]
	public void ELOFIACINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8427E10", Offset = "0x8427010", VA = "0x188427E10", Slot = "106")]
	public void FCAMJGNDKLE(Vector3 OLNMJECJIHN, Vector3 KONENOOPMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8425D30", Offset = "0x8424F30", VA = "0x188425D30", Slot = "107")]
	public void AHALKHHCKGK(Vector3 IOEEHPMHLON, Vector3 MDOMAAAPHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x84270D0", Offset = "0x84262D0", VA = "0x1884270D0", Slot = "108")]
	public void DKICKCIFEFD(Vector3 FDMJBKNIFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8427F00", Offset = "0x8427100", VA = "0x188427F00", Slot = "109")]
	public void FEGKFKJFNOI(FOFJEBJADLK CKGKMBNIHEB, Vector3 FLKIJPNGFFJ, float HGBMIGEGDNO, float CJLCLIAJNED = 8f, float MLLIAHIMCBD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x842B930", Offset = "0x842AB30", VA = "0x18842B930", Slot = "110")]
	public void OCDBEAPHLLH(IKMHDDEODBJ PLGEODGNDIP, Vector3 EGAKJMHBNCA, float PNDDEFAPACE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8427790", Offset = "0x8426990", VA = "0x188427790", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void EFMBABIFDMP(IKMHDDEODBJ PLGEODGNDIP, Vector3 NDOBKEDDJAJ, float FGPLLNDELCJ = 7f, float ALNDLCNCPII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8425C30", Offset = "0x8424E30", VA = "0x188425C30", Slot = "112")]
	public Vector3 ADDCGGECPML(Vector3 KJIOHKMJAPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x842B110", Offset = "0x842A310", VA = "0x18842B110", Slot = "113")]
	public Vector3 NECICHEEPNF(Vector3 KJIOHKMJAPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x84299E0", Offset = "0x8428BE0", VA = "0x1884299E0", Slot = "114")]
	public void KPIKCEGFCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x84263D0", Offset = "0x84255D0", VA = "0x1884263D0", Slot = "115")]
	public void BIIEGOMNBEO(PHNCFOGEOOF PIKCGJKMBFP, object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8426950", Offset = "0x8425B50", VA = "0x188426950", Slot = "116")]
	public void CJGDCAAPMNN(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8425F70", Offset = "0x8425170", VA = "0x188425F70", Slot = "63")]
	public void AKLNNGGKMIH((Quaternion rot, Vector3 moments) PLBDLBHPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x842B560", Offset = "0x842A760", VA = "0x18842B560", Slot = "117")]
	public void NLJPLAPNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x84284C0", Offset = "0x84276C0", VA = "0x1884284C0", Slot = "118")]
	public void GEMMKEPNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8427290", Offset = "0x8426490", VA = "0x188427290", Slot = "119")]
	public void DLMHNBAPCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x842BE30", Offset = "0x842B030", VA = "0x18842BE30", Slot = "120")]
	public bool PEKINICHOKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x842A8A0", Offset = "0x8429AA0", VA = "0x18842A8A0", Slot = "97")]
	public void LMBAJAMHHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x84261F0", Offset = "0x84253F0", VA = "0x1884261F0", Slot = "121")]
	public void BDCLNOEFNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x84266D0", Offset = "0x84258D0", VA = "0x1884266D0", Slot = "122")]
	public void BOJJPDINDLK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8428010", Offset = "0x8427210", VA = "0x188428010", Slot = "123")]
	public void FHPLJAPEBNK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x842B2D0", Offset = "0x842A4D0", VA = "0x18842B2D0", Slot = "124")]
	public void NIELPKBDIGM(object CCLFNPCGNED, bool JEHOOBEDLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x842A1E0", Offset = "0x84293E0", VA = "0x18842A1E0", Slot = "125")]
	public void LJADLBMGHJF(Vector3 JEFKJIMPADK, Quaternion JLMCFEOBFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8426FA0", Offset = "0x84261A0", VA = "0x188426FA0", Slot = "126")]
	public void DKBNHJKJAAD(Vector3 ALIFNAHGJDF, Quaternion DCBHDPNLHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x842A7F0", Offset = "0x84299F0", VA = "0x18842A7F0", Slot = "127")]
	public bool LLJJMFGBMNL(float CHCCCCJIGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x84285F0", Offset = "0x84277F0", VA = "0x1884285F0", Slot = "128")]
	public void GGPJBGPKFKG(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8426CC0", Offset = "0x8425EC0", VA = "0x188426CC0", Slot = "129")]
	public void DBHHLGKHBEE(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x84292C0", Offset = "0x84284C0", VA = "0x1884292C0", Slot = "130")]
	public void JNGNFEOJBBF(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8429120", Offset = "0x8428320", VA = "0x188429120", Slot = "131")]
	public void JADKGBEPFDN(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x842BB90", Offset = "0x842AD90", VA = "0x18842BB90", Slot = "132")]
	public void PCCKIOHFPJB(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x842BA20", Offset = "0x842AC20", VA = "0x18842BA20", Slot = "133")]
	public void OHPNIOLBLCN(Vector3 IKLDNLEDLAC, Vector3 FICCENLPJEL, ForceMode BIMCLGPPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x84286A0", Offset = "0x84278A0", VA = "0x1884286A0", Slot = "134")]
	public void GLHBKCIMMGL(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8428200", Offset = "0x8427400", VA = "0x188428200", Slot = "135")]
	public void GBCDHOGAELK(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x842BD90", Offset = "0x842AF90", VA = "0x18842BD90", Slot = "136")]
	public bool PDKMELOHKJD(Vector3 JBACNGDELHL, [Out] RaycastHit LAPIKELMKEJ, float ADBCFFBIBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x842C060", Offset = "0x842B260", VA = "0x18842C060", Slot = "137")]
	public void PJLJKNEDMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x842C100", Offset = "0x842B300", VA = "0x18842C100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x84283F0", Offset = "0x84275F0", VA = "0x1884283F0")]
	private void GDHIEFEMCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8425B20", Offset = "0x8424D20", VA = "0x188425B20")]
	private void AAFBDHLGHDB(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x842A490", Offset = "0x8429690", VA = "0x18842A490")]
	private void LJMNMNDHMAK(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x842A3E0", Offset = "0x84295E0", VA = "0x18842A3E0")]
	private void LJBJKLCBILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x842A6D0", Offset = "0x84298D0", VA = "0x18842A6D0")]
	private void LLDCBKMEGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x84269B0", Offset = "0x8425BB0", VA = "0x1884269B0")]
	private void CMFIHHOKLJM(PHNCFOGEOOF LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x842BCC0", Offset = "0x842AEC0", VA = "0x18842BCC0")]
	private void PDJBPIKOCGI(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8426730", Offset = "0x8425930", VA = "0x188426730")]
	private void BPPNACNIEBO(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8428DB0", Offset = "0x8427FB0", VA = "0x188428DB0")]
	private void IJLIBHFGMLB(NIJLAPDBAHE FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x84279C0", Offset = "0x8426BC0", VA = "0x1884279C0", Slot = "142")]
	protected virtual void EPGBPJIBNIO(NIJLAPDBAHE MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x842AC70", Offset = "0x8429E70", VA = "0x18842AC70")]
	protected void MMJMIOHHLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8429CB0", Offset = "0x8428EB0", VA = "0x188429CB0")]
	protected void LALKFPGJDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8429510", Offset = "0x8428710", VA = "0x188429510")]
	private void KDJMKAOJJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x842A8F0", Offset = "0x8429AF0", VA = "0x18842A8F0")]
	private void LPHCOHMOMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EFCHIPJEAJM
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x842D490", Offset = "0x842C690", VA = "0x18842D490")]
	public static PHNCFOGEOOF MOHCABGPBDI(this PHNCFOGEOOF MCFDCNGFCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x842D350", Offset = "0x842C550", VA = "0x18842D350")]
	public static bool LMBPJKAOKJB(this PHNCFOGEOOF MCFDCNGFCOI, PHNCFOGEOOF CHIAOJJGKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x842D3F0", Offset = "0x842C5F0", VA = "0x18842D3F0")]
	public static bool MDOIEHANCKK(this PHNCFOGEOOF MCFDCNGFCOI, PHNCFOGEOOF JPIEDBAELIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x842D300", Offset = "0x842C500", VA = "0x18842D300")]
	public static NIJLAPDBAHE HFINCNAGHGC(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x842D290", Offset = "0x842C490", VA = "0x18842D290")]
	public static DBHGBEPAPMD FIONJMNFEAB(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NIGMNIABNAK : ELGBPJDCILP
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x84357F0", Offset = "0x84349F0", VA = "0x1884357F0", Slot = "19")]
	public PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI, JJJNBIJGPDG CAIGHLKIDBF, LJAKHMOMFFF OBHJPIMFHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "4")]
	public EMKLCKJEIOA JHOMIGHFJGO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "5")]
	public HIKDEFJGLDC MAJEAJIPGOA(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "6")]
	public BFAMJOEKPNI PPAHGLNMIDO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "7")]
	public KEMLPLAEJKD DCILDCLMAFI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "8")]
	public CMMBIKFDAKI KGONBKDCBJJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "9")]
	public PMLPKBOMJFN CNAGMPDGPJE(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "10")]
	public GAPJIKMIOME EKMOIILLNMJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "11")]
	public GGGOHCKBGKD JPHPLKAJKPK(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "12")]
	public OOGMFIKJPAM GAANHCBMPLI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "13")]
	public JBGALMMJIKH FMDBONILKHL(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public HFOJIIPFDGF FMBFPIELIPK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public NMMHPIHNPCC AIGNNGLJBNE(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public ADIHGAEPOCM DEIKEBCDGFA(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public LMIHLCKIIJI AAKAJFEAPEK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	public MENLNIPELDL CBLHGCOJOFC(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NIGMNIABNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "14")]
	private HFOJIIPFDGF IPMNPKDMJPN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "15")]
	private NMMHPIHNPCC CKKDCJAIAFH(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "16")]
	private ADIHGAEPOCM HGEAFJLHPID(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "17")]
	private LMIHLCKIIJI LMHKECDLPEN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "18")]
	private MENLNIPELDL HNCPECIBHBD(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(ELGBPJDCILP), new string[] { })]
public class MAFCGEDPPAP : ELGBPJDCILP, HGIOMKPLONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly ELGBPJDCILP NFHLMDBPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ELGBPJDCILP LKPOMCFEMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IGOOJKBPJMB CJNAOIFLGHO;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private ELGBPJDCILP JHLAIJNEJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8433D60", Offset = "0x8432F60", VA = "0x188433D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8434130", Offset = "0x8433330", VA = "0x188434130", Slot = "20")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8434180", Offset = "0x8433380", VA = "0x188434180", Slot = "4")]
	public EMKLCKJEIOA JHOMIGHFJGO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8434360", Offset = "0x8433560", VA = "0x188434360", Slot = "5")]
	public HIKDEFJGLDC MAJEAJIPGOA(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8434400", Offset = "0x8433600", VA = "0x188434400", Slot = "6")]
	public BFAMJOEKPNI PPAHGLNMIDO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8433C10", Offset = "0x8432E10", VA = "0x188433C10", Slot = "7")]
	public KEMLPLAEJKD DCILDCLMAFI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x84342C0", Offset = "0x84334C0", VA = "0x1884342C0", Slot = "8")]
	public CMMBIKFDAKI KGONBKDCBJJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8433B70", Offset = "0x8432D70", VA = "0x188433B70", Slot = "9")]
	public PMLPKBOMJFN CNAGMPDGPJE(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8433EA0", Offset = "0x84330A0", VA = "0x188433EA0", Slot = "10")]
	public GAPJIKMIOME EKMOIILLNMJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8434220", Offset = "0x8433420", VA = "0x188434220", Slot = "11")]
	public GGGOHCKBGKD JPHPLKAJKPK(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8434090", Offset = "0x8433290", VA = "0x188434090", Slot = "12")]
	public OOGMFIKJPAM GAANHCBMPLI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8433FF0", Offset = "0x84331F0", VA = "0x188433FF0", Slot = "13")]
	public JBGALMMJIKH FMDBONILKHL(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8433F40", Offset = "0x8433140", VA = "0x188433F40")]
	public HFOJIIPFDGF FMBFPIELIPK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8433A10", Offset = "0x8432C10", VA = "0x188433A10")]
	public NMMHPIHNPCC AIGNNGLJBNE(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8433CB0", Offset = "0x8432EB0", VA = "0x188433CB0")]
	public ADIHGAEPOCM DEIKEBCDGFA(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8433960", Offset = "0x8432B60", VA = "0x188433960")]
	public LMIHLCKIIJI AAKAJFEAPEK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8433AC0", Offset = "0x8432CC0", VA = "0x188433AC0")]
	public MENLNIPELDL CBLHGCOJOFC(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8433DC0", Offset = "0x8432FC0", VA = "0x188433DC0", Slot = "19")]
	public PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI, JJJNBIJGPDG CAIGHLKIDBF, LJAKHMOMFFF OBHJPIMFHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x84344A0", Offset = "0x84336A0", VA = "0x1884344A0")]
	public MAFCGEDPPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8433F40", Offset = "0x8433140", VA = "0x188433F40", Slot = "14")]
	private HFOJIIPFDGF IPMNPKDMJPN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8433A10", Offset = "0x8432C10", VA = "0x188433A10", Slot = "15")]
	private NMMHPIHNPCC CKKDCJAIAFH(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8433CB0", Offset = "0x8432EB0", VA = "0x188433CB0", Slot = "16")]
	private ADIHGAEPOCM HGEAFJLHPID(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8433960", Offset = "0x8432B60", VA = "0x188433960", Slot = "17")]
	private LMIHLCKIIJI LMHKECDLPEN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8433AC0", Offset = "0x8432CC0", VA = "0x188433AC0", Slot = "18")]
	private MENLNIPELDL HNCPECIBHBD(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DAOHAAKEFIG : EMKLCKJEIOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBPGDPFHMMN(PHNCFOGEOOF MCFDCNGFCOI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMNGHOIELBP(PHNCFOGEOOF MCFDCNGFCOI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGNOBDIJDIA(PHNCFOGEOOF LCNCFEHAGKF);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFGOMDKFICN(PHNCFOGEOOF LCNCFEHAGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EOMENBMIGLJ : BFAMJOEKPNI
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PJNINDLEAAN<PHNCFOGEOOF> KPBCNFALAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	PHNCFOGEOOF EJMFOBBKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EPKBBCAICKH : LMIHLCKIIJI
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DOBJFGHGACB(Rigidbody AFODKIOCFIH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HCNPLMOEPMN : NMMHPIHNPCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView NJLNHPCFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EBENNEEOLBA : OOGMFIKJPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode EAGNKJBBBFL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x842C300", Offset = "0x842B500", VA = "0x18842C300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode FLLNAGFOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x842C4D0", Offset = "0x842B6D0", VA = "0x18842C4D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x842C460", Offset = "0x842B660", VA = "0x18842C460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x842C8F0", Offset = "0x842BAF0", VA = "0x18842C8F0")]
	public EBENNEEOLBA(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x842C350", Offset = "0x842B550", VA = "0x18842C350", Slot = "6")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x842C5E0", Offset = "0x842B7E0", VA = "0x18842C5E0", Slot = "9")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x842C660", Offset = "0x842B860", VA = "0x18842C660", Slot = "7")]
	public void LIDICJEJHNO(bool IJKMKNOAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x842C2F0", Offset = "0x842B4F0", VA = "0x18842C2F0", Slot = "8")]
	public void ADNGLLPBJPF(bool IJKMKNOAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x842C790", Offset = "0x842B990", VA = "0x18842C790", Slot = "10")]
	public bool PDKMELOHKJD(Vector3 JBACNGDELHL, [Out] RaycastHit LAPIKELMKEJ, float ADBCFFBIBMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x842C670", Offset = "0x842B870", VA = "0x18842C670")]
	private void LIHLJLNHDEB(bool IJKMKNOAIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CMLINLPAELG : PMLPKBOMJFN, IDisposable, DNCJIBHBDAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CMFBMPLFPMI KKJBFOEIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private JPIDDDBCPEO BKMHAFDKHBK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CMFBMPLFPMI IIKKDFEMLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x84257D0", Offset = "0x84249D0", VA = "0x1884257D0", Slot = "6")]
		get
		{
			return default(CMFBMPLFPMI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x84259C0", Offset = "0x8424BC0", VA = "0x1884259C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform JFKGPELPPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD3D4F0", Offset = "0xD3C6F0", VA = "0x180D3D4F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DLGGNNMFNFI, DLGGNNMFNFI> CBKINBMILBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8425910", Offset = "0x8424B10", VA = "0x188425910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8425460", Offset = "0x8424660", VA = "0x188425460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8425A90", Offset = "0x8424C90", VA = "0x188425A90")]
	public CMLINLPAELG(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8425510", Offset = "0x8424710", VA = "0x188425510", Slot = "8")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8425780", Offset = "0x8424980", VA = "0x188425780", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x11FF150", Offset = "0x11FE350", VA = "0x1811FF150", Slot = "11")]
	private void LPMLFJBMCOD(DLGGNNMFNFI JNHOBJPEMBA, DLGGNNMFNFI CMNOOBANDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "12")]
	private void LMFLOMMJAHG(bool PEMMPDNFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MCMJFHJHOJC : ELGBPJDCILP
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8435100", Offset = "0x8434300", VA = "0x188435100", Slot = "4")]
	public EMKLCKJEIOA JHOMIGHFJGO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8435380", Offset = "0x8434580", VA = "0x188435380", Slot = "5")]
	public HIKDEFJGLDC MAJEAJIPGOA(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x84354A0", Offset = "0x84346A0", VA = "0x1884354A0", Slot = "6")]
	public BFAMJOEKPNI PPAHGLNMIDO(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8434A20", Offset = "0x8433C20", VA = "0x188434A20", Slot = "7")]
	public KEMLPLAEJKD DCILDCLMAFI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x84352B0", Offset = "0x84344B0", VA = "0x1884352B0", Slot = "8")]
	public CMMBIKFDAKI KGONBKDCBJJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8434950", Offset = "0x8433B50", VA = "0x188434950", Slot = "9")]
	public PMLPKBOMJFN CNAGMPDGPJE(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8434D20", Offset = "0x8433F20", VA = "0x188434D20", Slot = "10")]
	public GAPJIKMIOME EKMOIILLNMJ(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x84351F0", Offset = "0x84343F0", VA = "0x1884351F0", Slot = "11")]
	public GGGOHCKBGKD JPHPLKAJKPK(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8435040", Offset = "0x8434240", VA = "0x188435040", Slot = "12")]
	public OOGMFIKJPAM GAANHCBMPLI(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8434F80", Offset = "0x8434180", VA = "0x188434F80", Slot = "13")]
	public JBGALMMJIKH FMDBONILKHL(PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8434E40", Offset = "0x8434040", VA = "0x188434E40")]
	public HFOJIIPFDGF FMBFPIELIPK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x84346E0", Offset = "0x84338E0", VA = "0x1884346E0")]
	public NMMHPIHNPCC AIGNNGLJBNE(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8434AA0", Offset = "0x8433CA0", VA = "0x188434AA0")]
	public ADIHGAEPOCM DEIKEBCDGFA(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8434550", Offset = "0x8433750", VA = "0x188434550")]
	public LMIHLCKIIJI AAKAJFEAPEK(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8434870", Offset = "0x8433A70", VA = "0x188434870")]
	public MENLNIPELDL CBLHGCOJOFC(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8434BD0", Offset = "0x8433DD0", VA = "0x188434BD0", Slot = "19")]
	public PHNCFOGEOOF EHMNFHCMGPB(RigidbodyEx MCFDCNGFCOI, JJJNBIJGPDG CAIGHLKIDBF, LJAKHMOMFFF OBHJPIMFHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public MCMJFHJHOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8434E40", Offset = "0x8434040", VA = "0x188434E40", Slot = "14")]
	private HFOJIIPFDGF IPMNPKDMJPN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x84346E0", Offset = "0x84338E0", VA = "0x1884346E0", Slot = "15")]
	private NMMHPIHNPCC CKKDCJAIAFH(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8434AA0", Offset = "0x8433CA0", VA = "0x188434AA0", Slot = "16")]
	private ADIHGAEPOCM HGEAFJLHPID(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8434550", Offset = "0x8433750", VA = "0x188434550", Slot = "17")]
	private LMIHLCKIIJI LMHKECDLPEN(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8434870", Offset = "0x8433A70", VA = "0x188434870", Slot = "18")]
	private MENLNIPELDL HNCPECIBHBD(PHNCFOGEOOF IBLPGPPBNHF, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class JMOJGHIHKNB : GGGOHCKBGKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x842C300", Offset = "0x842B500", VA = "0x18842C300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JNAFLDCOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x84318F0", Offset = "0x8430AF0", VA = "0x1884318F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool EEFKKNIEIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x842CBA0", Offset = "0x842BDA0", VA = "0x18842CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8431E80", Offset = "0x8431080", VA = "0x188431E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x842C8F0", Offset = "0x842BAF0", VA = "0x18842C8F0")]
	public JMOJGHIHKNB(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8431D20", Offset = "0x8430F20", VA = "0x188431D20", Slot = "4")]
	public void PCCKIOHFPJB(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8431430", Offset = "0x8430630", VA = "0x188431430")]
	private void DDGMPCLCCMG(Vector3 IKLDNLEDLAC, ForceMode BIMCLGPPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8431AA0", Offset = "0x8430CA0", VA = "0x188431AA0", Slot = "5")]
	public void OHPNIOLBLCN(Vector3 IKLDNLEDLAC, Vector3 FICCENLPJEL, ForceMode BIMCLGPPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8431940", Offset = "0x8430B40", VA = "0x188431940", Slot = "6")]
	public void GLHBKCIMMGL(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x84311D0", Offset = "0x84303D0", VA = "0x1884311D0")]
	private void CJMAIKCJCHB(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8431690", Offset = "0x8430890", VA = "0x188431690", Slot = "7")]
	public void GBCDHOGAELK(Vector3 AEMMDDFMGIP, ForceMode BIMCLGPPPMH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class JAPOBNJKJLM : JBGALMMJIKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool DLPKHNCEOAL;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OIDDBDAGPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB16990", Offset = "0xB15B90", VA = "0x180B16990", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x84310C0", Offset = "0x84302C0", VA = "0x1884310C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x842C8F0", Offset = "0x842BAF0", VA = "0x18842C8F0")]
	public JAPOBNJKJLM(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8431090", Offset = "0x8430290", VA = "0x188431090", Slot = "6")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8431020", Offset = "0x8430220", VA = "0x188431020", Slot = "7")]
	public void FGLPBDFAJJO(Rigidbody MFFGACBHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class OALONOFDIDB : DAOHAAKEFIG, EMKLCKJEIOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PHNCFOGEOOF MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<PHNCFOGEOOF> JJEDAAFOLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PHNCFOGEOOF OLEJNEHCCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private PHNCFOGEOOF FLKKOCNDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform MIMEIPHOGEJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x84383A0", Offset = "0x84375A0", VA = "0x1884383A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA003C0", Offset = "0x9FF5C0", VA = "0x180A003C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8438400", Offset = "0x8437600", VA = "0x188438400", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PHNCFOGEOOF LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<PHNCFOGEOOF> ALCPIDFAMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA00390", Offset = "0x9FF590", VA = "0x180A00390", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event LGEMEOCGCEJ KONBLHNACOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8439140", Offset = "0x8438340", VA = "0x188439140", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8439290", Offset = "0x8438490", VA = "0x188439290", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event LGEMEOCGCEJ GKGJNCINCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8439B70", Offset = "0x8438D70", VA = "0x188439B70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8438300", Offset = "0x8437500", VA = "0x188438300", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EEPFMKEJJPJ NAFACMHLIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8439F60", Offset = "0x8439160", VA = "0x188439F60", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8438D70", Offset = "0x8437F70", VA = "0x188438D70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action CKIGFGNIKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8438AF0", Offset = "0x8437CF0", VA = "0x188438AF0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8438CD0", Offset = "0x8437ED0", VA = "0x188438CD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CNEACKLAMML
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8438410", Offset = "0x8437610", VA = "0x188438410", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8438E10", Offset = "0x8438010", VA = "0x188438E10", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<PHNCFOGEOOF> ABNBECEHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x84391E0", Offset = "0x84383E0", VA = "0x1884391E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8438550", Offset = "0x8437750", VA = "0x188438550", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<PHNCFOGEOOF> LEOFOJIDDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8439AC0", Offset = "0x8438CC0", VA = "0x188439AC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x84393D0", Offset = "0x84385D0", VA = "0x1884393D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action PEJGBLCFAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8439330", Offset = "0x8438530", VA = "0x188439330", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8438920", Offset = "0x8437B20", VA = "0x188438920", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<PHNCFOGEOOF> JODHGHLEFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8438F60", Offset = "0x8438160", VA = "0x188438F60", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8438EB0", Offset = "0x84380B0", VA = "0x188438EB0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x843A000", Offset = "0x8439200", VA = "0x18843A000")]
	public OALONOFDIDB(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8438600", Offset = "0x8437800", VA = "0x188438600", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8439480", Offset = "0x8438680", VA = "0x188439480", Slot = "30")]
	public void KMHANLPIIHA(PHNCFOGEOOF DAFAJHDHOLC, bool PEMCPPNLJOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8439CF0", Offset = "0x8438EF0", VA = "0x188439CF0", Slot = "6")]
	public void OGNOBDIJDIA(PHNCFOGEOOF LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84386A0", Offset = "0x84378A0", VA = "0x1884386A0", Slot = "7")]
	public void EFGOMDKFICN(PHNCFOGEOOF LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8438210", Offset = "0x8437410", VA = "0x188438210", Slot = "4")]
	public void BBPGDPFHMMN(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8439C10", Offset = "0x8438E10", VA = "0x188439C10", Slot = "5")]
	public void NMNGHOIELBP(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x84384B0", Offset = "0x84376B0", VA = "0x1884384B0")]
	private void DJIGJBBHLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8439CB0", Offset = "0x8438EB0", VA = "0x188439CB0")]
	private void OCHIDPACBEO(PHNCFOGEOOF LCNCFEHAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8438B90", Offset = "0x8437D90", VA = "0x188438B90")]
	private void FCAOKOEFLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8439010", Offset = "0x8438210", VA = "0x188439010")]
	private void HGOIKDFNFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x84389C0", Offset = "0x8437BC0", VA = "0x1884389C0")]
	private void ELJMHKEMINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8439A00", Offset = "0x8438C00", VA = "0x188439A00")]
	[CompilerGenerated]
	private object LNHJOLAMJIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class NLFIHDPNPHL
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8438150", Offset = "0x8437350", VA = "0x188438150")]
	public static DAOHAAKEFIG IGGAGMHAOOC(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LPOOABOIIKN : EOMENBMIGLJ, BFAMJOEKPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly PJNINDLEAAN<PHNCFOGEOOF> JILBMMJGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool FELKFBEHIJN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PJNINDLEAAN<PHNCFOGEOOF> KPBCNFALAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 OFPEANCCINF
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8433320", Offset = "0x8432520", VA = "0x188433320", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 PGCDCJNGEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8432CD0", Offset = "0x8431ED0", VA = "0x188432CD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 LDKHAFPEALE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8432E90", Offset = "0x8432090", VA = "0x188432E90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PHNCFOGEOOF EJMFOBBKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8432C20", Offset = "0x8431E20", VA = "0x188432C20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8433750", Offset = "0x8432950", VA = "0x188433750")]
	public LPOOABOIIKN(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8433350", Offset = "0x8432550", VA = "0x188433350", Slot = "8")]
	public void LBDFIEPGHAI(PHNCFOGEOOF FLKKOCNDECC, object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8432BC0", Offset = "0x8431DC0", VA = "0x188432BC0", Slot = "9")]
	public void ANKINBHHNPP(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8432F80", Offset = "0x8432180", VA = "0x188432F80")]
	private Vector3 JHPHIECFOAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x84333C0", Offset = "0x84325C0", VA = "0x1884333C0")]
	private void MCGJFBPIPKE(PHNCFOGEOOF BDMDJJBOEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class FLACNHIJOFO
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x842D550", Offset = "0x842C750", VA = "0x18842D550")]
	public static EOMENBMIGLJ APAEJHLHICG(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class NLBGMJPDJDF : EPKBBCAICKH, LMIHLCKIIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 AFEMOKLBAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 BGJHDLDOPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float KEPKOEINOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float HOCEGBAIPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 DIJBOHNAHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? FPNINKIFPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? IHLDOPLBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool DNLMKBMJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool MJECOMIKNJE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 PJPAOHGANHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1716670", Offset = "0x1715870", VA = "0x181716670", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8437060", Offset = "0x8436260", VA = "0x188437060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 HEJFILFCLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8437510", Offset = "0x8436710", VA = "0x188437510", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float MKFGMFLBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xD619F0", Offset = "0xD60BF0", VA = "0x180D619F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8435C60", Offset = "0x8434E60", VA = "0x188435C60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float PHAKCFCOGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC56110", Offset = "0xC55310", VA = "0x180C56110", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x84371F0", Offset = "0x84363F0", VA = "0x1884371F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 BALPJDKAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8437380", Offset = "0x8436580", VA = "0x188437380", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion JCNFCLBJBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x84379E0", Offset = "0x8436BE0", VA = "0x1884379E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8424750", Offset = "0x8423950", VA = "0x188424750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event LGEMEOCGCEJ JNHKJONJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8437940", Offset = "0x8436B40", VA = "0x188437940", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8437600", Offset = "0x8436800", VA = "0x188437600", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8437FF0", Offset = "0x84371F0", VA = "0x188437FF0")]
	public NLBGMJPDJDF(PHNCFOGEOOF MCFDCNGFCOI, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8437820", Offset = "0x8436A20", VA = "0x188437820", Slot = "17")]
	public void NLJPLAPNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8437110", Offset = "0x8436310", VA = "0x188437110", Slot = "16")]
	public void GEMMKEPNPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x84372A0", Offset = "0x84364A0", VA = "0x1884372A0", Slot = "19")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8436D90", Offset = "0x8435F90", VA = "0x188436D90", Slot = "20")]
	public void FGLPBDFAJJO(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8435D70", Offset = "0x8434F70", VA = "0x188435D70", Slot = "18")]
	public void DLMHNBAPCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8437B60", Offset = "0x8436D60", VA = "0x188437B60", Slot = "21")]
	public void PJLJKNEDMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8437060", Offset = "0x8436260", VA = "0x188437060")]
	private void FKOCLCCFGJG(Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8436F70", Offset = "0x8436170", VA = "0x188436F70")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FHDNBLCFLGM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8435C60", Offset = "0x8434E60", VA = "0x188435C60")]
	private void DDGKNCCJJPN(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x84371F0", Offset = "0x84363F0", VA = "0x1884371F0")]
	private void NEMGBBHIJJP(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8435AC0", Offset = "0x8434CC0", VA = "0x188435AC0")]
	private Vector3 ANIFKBAEJAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8435890", Offset = "0x8434A90", VA = "0x188435890", Slot = "15")]
	public void AKLNNGGKMIH((Quaternion rot, Vector3 moments) PLBDLBHPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x84376A0", Offset = "0x84368A0", VA = "0x1884376A0")]
	private Quaternion LHCKJIELLDL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8435F20", Offset = "0x8435120", VA = "0x188435F20")]
	public void DOBJFGHGACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8435FF0", Offset = "0x84351F0", VA = "0x188435FF0", Slot = "4")]
	public (float, Vector3) DOBJFGHGACB(Rigidbody AFODKIOCFIH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class APOCGIILNEH
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8423F80", Offset = "0x8423180", VA = "0x188423F80")]
	public static EPKBBCAICKH DJFGKHBJLJP(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BDEHIMADNGA : ADIHGAEPOCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PPOFIDCPAOP BDIGALPHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JOHOKOFPFMP OJDGNKGODEN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AJDKMFHAOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x18F41F0", Offset = "0x18F33F0", VA = "0x1818F41F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JOHOKOFPFMP LAJMHHDELAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480", Slot = "11")]
		get
		{
			return default(JOHOKOFPFMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8424650", Offset = "0x8423850", VA = "0x188424650")]
	public BDEHIMADNGA(PHNCFOGEOOF MCFDCNGFCOI, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8424080", Offset = "0x8423280", VA = "0x188424080", Slot = "4")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8424150", Offset = "0x8423350", VA = "0x188424150")]
	private bool GNBOADGLABH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8424460", Offset = "0x8423660", VA = "0x188424460", Slot = "5")]
	public void LFNLAIJIILK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8424320", Offset = "0x8423520", VA = "0x188424320", Slot = "6")]
	public void HIBDIEONHML(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x84241F0", Offset = "0x84233F0", VA = "0x1884241F0", Slot = "9")]
	public void HGHDGJCKKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8424350", Offset = "0x8423550", VA = "0x188424350")]
	private void LEJDKJEHNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8424490", Offset = "0x8423690", VA = "0x188424490")]
	private void NOLCDJCBJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8424040", Offset = "0x8423240", VA = "0x188424040", Slot = "8")]
	public void CKCOLABOPIP(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8424610", Offset = "0x8423810", VA = "0x188424610", Slot = "7")]
	public void PLFFFLBJMPP(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AFIKJKNKJCK : GAPJIKMIOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PPOFIDCPAOP GIJIFFLNDHB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JNAFLDCOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8423AD0", Offset = "0x8422CD0", VA = "0x188423AD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event LGEMEOCGCEJ BNOICKDILLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8423C00", Offset = "0x8422E00", VA = "0x188423C00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8423CA0", Offset = "0x8422EA0", VA = "0x188423CA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8423E90", Offset = "0x8423090", VA = "0x188423E90")]
	public AFIKJKNKJCK(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8423A80", Offset = "0x8422C80", VA = "0x188423A80", Slot = "7")]
	public void BOJJPDINDLK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8423AC0", Offset = "0x8422CC0", VA = "0x188423AC0", Slot = "8")]
	public void FHPLJAPEBNK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8423D80", Offset = "0x8422F80", VA = "0x188423D80", Slot = "9")]
	public void NIELPKBDIGM(object CCLFNPCGNED, bool JEHOOBEDLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8423D40", Offset = "0x8422F40", VA = "0x188423D40", Slot = "12")]
	public void NAEFNJNBJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8423B80", Offset = "0x8422D80", VA = "0x188423B80", Slot = "10")]
	public void IKNFNCAAAEN(Rigidbody CCNFPPEFCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8423A90", Offset = "0x8422C90", VA = "0x188423A90", Slot = "11")]
	public void FGLPBDFAJJO(Rigidbody MFFGACBHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class LIKPDNDDJKG : HCNPLMOEPMN, NMMHPIHNPCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView FKBPAPGLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool OAPFJEMMLHF;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView NJLNHPCFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool PABGIEGOABI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x84328F0", Offset = "0x8431AF0", VA = "0x1884328F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FNNFICHJMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event LGEMEOCGCEJ DPJEAPGBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8431EE0", Offset = "0x84310E0", VA = "0x188431EE0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8432850", Offset = "0x8431A50", VA = "0x188432850", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8432A70", Offset = "0x8431C70", VA = "0x188432A70")]
	public LIKPDNDDJKG(PHNCFOGEOOF MCFDCNGFCOI, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x84320F0", Offset = "0x84312F0", VA = "0x1884320F0", Slot = "9")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8432390", Offset = "0x8431590", VA = "0x188432390", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8432900", Offset = "0x8431B00", VA = "0x188432900", Slot = "10")]
	public void PDJBPIKOCGI(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8431F80", Offset = "0x8431180", VA = "0x188431F80", Slot = "11")]
	public void BPPNACNIEBO(PHNCFOGEOOF FLKKOCNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8432220", Offset = "0x8431420", VA = "0x188432220")]
	private void DKGCOHDHLDO(RRNetworkView LFNCLDFBOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8432700", Offset = "0x8431900", VA = "0x188432700")]
	private void NOFOCKNLIOH(NIJLAPDBAHE GPBCGNEFDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8432490", Offset = "0x8431690", VA = "0x188432490")]
	private void EDADKHLGBPN(RRNetworkView LPLDGIDPNAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class DCDLACGODPL
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x842C230", Offset = "0x842B430", VA = "0x18842C230")]
	public static HCNPLMOEPMN AMPAHCOHIOA(this PHNCFOGEOOF IBLPGPPBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class GKEHNOEFMPK : MENLNIPELDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints EJJDBFLMEOO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BEGLONAEOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA52350", Offset = "0xA51550", VA = "0x180A52350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD7FF60", Offset = "0xD7F160", VA = "0x180D7FF60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool AMINFAJDJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA758C0", Offset = "0xA74AC0", VA = "0x180A758C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD7F9E0", Offset = "0xD7EBE0", VA = "0x180D7F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints FIIBEJBGGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x842D6E0", Offset = "0x842C8E0", VA = "0x18842D6E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x842D870", Offset = "0x842CA70", VA = "0x18842D870")]
	public GKEHNOEFMPK(PHNCFOGEOOF MCFDCNGFCOI, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x842D840", Offset = "0x842CA40", VA = "0x18842D840", Slot = "9")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x842D810", Offset = "0x842CA10", VA = "0x18842D810", Slot = "10")]
	public void FGLPBDFAJJO(Rigidbody MFFGACBHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class AFDBLMBGCNE : KEMLPLAEJKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PHNCFOGEOOF MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float LOIIKFBOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float NBMGNKBIKAP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float MPIGHGHEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1104F70", Offset = "0x1104170", VA = "0x181104F70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8423850", Offset = "0x8422A50", VA = "0x188423850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float ONCIEDPNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xDAC160", Offset = "0xDAB360", VA = "0x180DAC160", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8423970", Offset = "0x8422B70", VA = "0x188423970", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8423A40", Offset = "0x8422C40", VA = "0x188423A40")]
	public AFDBLMBGCNE(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8423920", Offset = "0x8422B20", VA = "0x188423920", Slot = "8")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x84237B0", Offset = "0x84229B0", VA = "0x1884237B0", Slot = "9")]
	public void FGLPBDFAJJO(Rigidbody MFFGACBHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BOKKHDNMPNN : CMMBIKFDAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly KEPOMIIOHBM DBNBCLNPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool PBGNICEIKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool COFAIODKGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int LFCJGCMMCCB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8424750", Offset = "0x8423950", VA = "0x188424750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool HKLMJPKBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8424850", Offset = "0x8423A50", VA = "0x188424850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private PHNCFOGEOOF MBPBJNDLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8425250", Offset = "0x8424450", VA = "0x188425250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool EEFKKNIEIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8424900", Offset = "0x8423B00", VA = "0x188424900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LGEMEOCGCEJ INCNFIELLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x84252B0", Offset = "0x84244B0", VA = "0x1884252B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8424D70", Offset = "0x8423F70", VA = "0x188424D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x84253D0", Offset = "0x84245D0", VA = "0x1884253D0")]
	public BOKKHDNMPNN(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8424870", Offset = "0x8423A70", VA = "0x188424870", Slot = "6")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x84247A0", Offset = "0x84239A0", VA = "0x1884247A0", Slot = "8")]
	public void BCICGFJLKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8425040", Offset = "0x8424240", VA = "0x188425040", Slot = "7")]
	public bool PEKINICHOKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8424E10", Offset = "0x8424010", VA = "0x188424E10", Slot = "9")]
	public void LMBAJAMHHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x84247B0", Offset = "0x84239B0", VA = "0x1884247B0", Slot = "13")]
	public void BDCLNOEFNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8424C50", Offset = "0x8423E50", VA = "0x188424C50", Slot = "12")]
	public void LACFGAGOOIH(bool BCODKBLOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8424960", Offset = "0x8423B60", VA = "0x188424960", Slot = "10")]
	public bool GGKAAMGGGNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8425190", Offset = "0x8424390", VA = "0x188425190", Slot = "11")]
	public bool PFANNEJOFFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x84249D0", Offset = "0x8423BD0", VA = "0x1884249D0")]
	private bool JOJGOEFBNBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8424EB0", Offset = "0x84240B0", VA = "0x188424EB0")]
	private void OEKOAFLAHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EDMCDHPOOJJ : HFOJIIPFDGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PPOFIDCPAOP JMIPMDAANEK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody MKLKACPEPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool EEFKKNIEIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x842CBA0", Offset = "0x842BDA0", VA = "0x18842CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GJEPLOOKELD
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x18F41F0", Offset = "0x18F33F0", VA = "0x1818F41F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x842D180", Offset = "0x842C380", VA = "0x18842D180")]
	public EDMCDHPOOJJ(PHNCFOGEOOF MCFDCNGFCOI, [In] JJJNBIJGPDG CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x842C980", Offset = "0x842BB80", VA = "0x18842C980", Slot = "5")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x842D150", Offset = "0x842C350", VA = "0x18842D150", Slot = "7")]
	public void JNGNFEOJBBF(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x842D120", Offset = "0x842C320", VA = "0x18842D120", Slot = "8")]
	public void JADKGBEPFDN(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x842CDF0", Offset = "0x842BFF0", VA = "0x18842CDF0", Slot = "9")]
	public void HDBPIMHHIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x842CC00", Offset = "0x842BE00", VA = "0x18842CC00", Slot = "10")]
	public void EILAHHJDIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x842CA20", Offset = "0x842BC20", VA = "0x18842CA20", Slot = "11")]
	public void DFIAECJBAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HILDJNCOEEC : HIKDEFJGLDC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DBHGBEPAPMD MCFDCNGFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PPOFIDCPAOP EAMJJDNAGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float JCIDHECHMEG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public AMBDNINENEN LMPICKEHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public ICKNPKALBAM ONDPGDGBCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 LDKHAFPEALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x842F9C0", Offset = "0x842EBC0", VA = "0x18842F9C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8430B80", Offset = "0x842FD80", VA = "0x188430B80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 BIFDABBKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x842F8A0", Offset = "0x842EAA0", VA = "0x18842F8A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x842FE10", Offset = "0x842F010", VA = "0x18842FE10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 EJNNDMKJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x842DA50", Offset = "0x842CC50", VA = "0x18842DA50", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x842FC20", Offset = "0x842EE20", VA = "0x18842FC20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 FLINLHJIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x842F780", Offset = "0x842E980", VA = "0x18842F780", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8430740", Offset = "0x842F940", VA = "0x188430740", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MAJPAAENDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA65A40", Offset = "0xA64C40", VA = "0x180A65A40", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x842E040", Offset = "0x842D240", VA = "0x18842E040", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LICAOAJPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x21EB860", Offset = "0x21EAA60", VA = "0x1821EB860", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private GGGOHCKBGKD NPOCMPKNBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x79DC100", Offset = "0x79DB300", VA = "0x1879DC100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool HKLMJPKBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x842DBA0", Offset = "0x842CDA0", VA = "0x18842DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8430EC0", Offset = "0x84300C0", VA = "0x188430EC0")]
	public HILDJNCOEEC(PHNCFOGEOOF MCFDCNGFCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x842E150", Offset = "0x842D350", VA = "0x18842E150", Slot = "19")]
	public void DDADFJBFCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x842E530", Offset = "0x842D730", VA = "0x18842E530", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x842FCE0", Offset = "0x842EEE0", VA = "0x18842FCE0", Slot = "28")]
	public void IKNFNCAAAEN(Rigidbody MFFGACBHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x16B54C0", Offset = "0x16B46C0", VA = "0x1816B54C0", Slot = "20")]
	public void BBBPOOABNKK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x16B6F80", Offset = "0x16B6180", VA = "0x1816B6F80", Slot = "30")]
	public void OOMKBPMLFHK(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x84308F0", Offset = "0x842FAF0", VA = "0x1884308F0", Slot = "35")]
	public Vector3 NIJFNJGENME(Vector3 IFPOFGCJIOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x84303F0", Offset = "0x842F5F0", VA = "0x1884303F0", Slot = "34")]
	public Vector3 KJFKNNAOPPF(Vector3 HEBMKEEGADP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x842E150", Offset = "0x842D350", VA = "0x18842E150", Slot = "27")]
	public void NLGMCMODFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8430770", Offset = "0x842F970", VA = "0x188430770", Slot = "25")]
	public void LDFHNJAJBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x842EE90", Offset = "0x842E090", VA = "0x18842EE90", Slot = "24")]
	public void ELOFIACINEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x842EEF0", Offset = "0x842E0F0", VA = "0x18842EEF0", Slot = "33")]
	public void FCAMJGNDKLE(Vector3 OLNMJECJIHN, Vector3 KONENOOPMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x842D9F0", Offset = "0x842CBF0", VA = "0x18842D9F0", Slot = "32")]
	public void AHALKHHCKGK(Vector3 IOEEHPMHLON, Vector3 MDOMAAAPHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x842E390", Offset = "0x842D590", VA = "0x18842E390", Slot = "31")]
	public void DKICKCIFEFD(Vector3 FDMJBKNIFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x842F130", Offset = "0x842E330", VA = "0x18842F130", Slot = "22")]
	public void FEGKFKJFNOI(FOFJEBJADLK CKGKMBNIHEB, Vector3 FLKIJPNGFFJ, float HGBMIGEGDNO, float CJLCLIAJNED = 8f, float MLLIAHIMCBD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8430C40", Offset = "0x842FE40", VA = "0x188430C40", Slot = "21")]
	public void OCDBEAPHLLH(IKMHDDEODBJ PLGEODGNDIP, Vector3 EGAKJMHBNCA, float PNDDEFAPACE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x842EA10", Offset = "0x842DC10", VA = "0x18842EA10", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void EFMBABIFDMP(IKMHDDEODBJ PLGEODGNDIP, Vector3 NDOBKEDDJAJ, float FGPLLNDELCJ = 7f, float ALNDLCNCPII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x17EF1F0", Offset = "0x17EE3F0", VA = "0x1817EF1F0")]
	private static void MFIFHJIOGCA(Vector3 AJNMLFPKEJH, Vector3 BNGNHOGLPHP, [Out] Vector3 EBAAOOBKINJ, [Out] Vector3 EHADBNEKCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x842D910", Offset = "0x842CB10", VA = "0x18842D910", Slot = "29")]
	public Vector3 ADDCGGECPML(Vector3 AJNMLFPKEJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x84305B0", Offset = "0x842F7B0", VA = "0x1884305B0", Slot = "26")]
	public void KPIKCEGFCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x842E040", Offset = "0x842D240", VA = "0x18842E040")]
	private void EKGHOKOJHHE(float KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x842E1F0", Offset = "0x842D3F0", VA = "0x18842E1F0")]
	private void DHCJHODOABN(Vector3 EGAKJMHBNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x842FB10", Offset = "0x842ED10", VA = "0x18842FB10")]
	private Vector3 HBBLPPPAJIL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x842E590", Offset = "0x842D790", VA = "0x18842E590")]
	private void ECADJGMPFHF(Vector3 HEBMKEEGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x84307D0", Offset = "0x842F9D0", VA = "0x1884307D0")]
	private Vector3 LHNKIIGFDFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x842DBC0", Offset = "0x842CDC0", VA = "0x18842DBC0")]
	private void CILEMAKAHGO(Vector3 KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x842FE40", Offset = "0x842F040", VA = "0x18842FE40")]
	private void KEMCKFKMFKD(Vector3 HEBMKEEGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8430AD0", Offset = "0x842FCD0", VA = "0x188430AD0")]
	private void NJGLOPEIDNO()
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
