using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PKEBHBDMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x652F6F0", Offset = "0x652E0F0", VA = "0x18652F6F0", Slot = "4")]
		public override void LIBHGHNAKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AGLLOOBOLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private CCHCHOBPBAK bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private CCHCHOBPBAK bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F39F80", Offset = "0x5F38980", VA = "0x185F39F80", Slot = "5")]
		public override void PMAEKCHOEDI(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x653E8E0", Offset = "0x653D2E0", VA = "0x18653E8E0")]
		private void LOBKKIADICI(MHIODLNIGAP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x653E2C0", Offset = "0x653CCC0", VA = "0x18653E2C0")]
		private void DNPLPBJENID(MHIODLNIGAP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x653E6F0", Offset = "0x653D0F0", VA = "0x18653E6F0", Slot = "6")]
		public override void HEEEGKLIMAL(MHIODLNIGAP registry, [In] AMKBBHPMMAE filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "8")]
		public override void NHPGLMFECNH(JNDAGNIJMBN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x653EA50", Offset = "0x653D450", VA = "0x18653EA50")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void DNJOPMKHNNE(RigidbodyEx GHELGEBMBHI);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void OLEKAPALJOK(RigidbodyEx GHELGEBMBHI, bool GPFHCOLIHFH = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DOMKELDFKDD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BDDDPOKPAMG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CABKKAHINFM
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MKBJKEDFLPH(typeof(NLOCKEEMPIE), new string[] { "Ignore", "Mock" })]
public class CJCGHDDGBMA : NLOCKEEMPIE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MKHKMCIIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
	public void FFGMDKMMMOO(string JKDHCOHJJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "6")]
	public void GHHJKOFJKFA(RigidbodyEx EIDKMOICLKH, Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "7")]
	public ALKOPEINFBL PEJDIJPIGGI(int JHHPMAEAOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "8")]
	public void DIOJCLDNHGL(Vector3 JAMFNBOJDGB, float FIBJEALACJJ, Color IKNGOAKEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public CJCGHDDGBMA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly AMCJMMGFCLE FIOFCEHLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool KKOKOCEKJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MAJKPDGOFIP DCHMPFMFNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[PHOLIPFOFDP(DOCALCFNJLI.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[PHOLIPFOFDP(DOCALCFNJLI.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private BDDDPOKPAMG physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal MAJKPDGOFIP EFMEBNACKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6539950", Offset = "0x6538350", VA = "0x186539950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> DNIIMHNKHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD20", Offset = "0x7AB720", VA = "0x1807ACD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7ACD30", Offset = "0x7AB730", VA = "0x1807ACD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FDGNIACFHOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x653B9A0", Offset = "0x653A3A0", VA = "0x18653B9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx MMJFNLDGOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x653B900", Offset = "0x653A300", VA = "0x18653B900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BBCCHMIJNJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x653C5C0", Offset = "0x653AFC0", VA = "0x18653C5C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x653DB40", Offset = "0x653C540", VA = "0x18653DB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CHLICCLJPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D02E0", Offset = "0x7CECE0", VA = "0x1807D02E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AEBPFLDNGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D02E0", Offset = "0x7CECE0", VA = "0x1807D02E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CALKAHELOOG JOKNAEJDLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x653B6C0", Offset = "0x653A0C0", VA = "0x18653B6C0")]
			get
			{
				return default(CALKAHELOOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x653D2F0", Offset = "0x653BCF0", VA = "0x18653D2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool POAPHBBHPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x653BC50", Offset = "0x653A650", VA = "0x18653BC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool INBELOMJCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x653B7E0", Offset = "0x653A1E0", VA = "0x18653B7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IMLGNNNEIMH PDNJEHPNAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x653BB90", Offset = "0x653A590", VA = "0x18653BB90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x653D4B0", Offset = "0x653BEB0", VA = "0x18653D4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PGFDCBPILFN IPDDHLLCKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x653BB30", Offset = "0x653A530", VA = "0x18653BB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x653D440", Offset = "0x653BE40", VA = "0x18653D440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BHCMGGOOJGA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x653BA80", Offset = "0x653A480", VA = "0x18653BA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody EGEJNIHCGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x653BAE0", Offset = "0x653A4E0", VA = "0x18653BAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JGCCOPIFNEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x653B840", Offset = "0x653A240", VA = "0x18653B840")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x653D360", Offset = "0x653BD60", VA = "0x18653D360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GPKFPBEJMJN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5D3A7C0", Offset = "0x5D391C0", VA = "0x185D3A7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D399E0", Offset = "0x5D383E0", VA = "0x185D399E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float CDEFDGMAIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x653C560", Offset = "0x653AF60", VA = "0x18653C560")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CMIMLEJAPOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x653C500", Offset = "0x653AF00", VA = "0x18653C500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x653DAD0", Offset = "0x653C4D0", VA = "0x18653DAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ONCKKCMOCFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x653BEB0", Offset = "0x653A8B0", VA = "0x18653BEB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x653D750", Offset = "0x653C150", VA = "0x18653D750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float APHJOBCNCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x653BCB0", Offset = "0x653A6B0", VA = "0x18653BCB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x653D520", Offset = "0x653BF20", VA = "0x18653D520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IPFPGDCNONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x653CB20", Offset = "0x653B520", VA = "0x18653CB20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x653E0A0", Offset = "0x653CAA0", VA = "0x18653E0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 MIBOIJDALHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x653C2E0", Offset = "0x653ACE0", VA = "0x18653C2E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x653D8A0", Offset = "0x653C2A0", VA = "0x18653D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 JAMFNBOJDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x653CC60", Offset = "0x653B660", VA = "0x18653CC60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode HKDLINHPEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x653BDF0", Offset = "0x653A7F0", VA = "0x18653BDF0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x653D670", Offset = "0x653C070", VA = "0x18653D670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NPDJFEPCKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x653B8A0", Offset = "0x653A2A0", VA = "0x18653B8A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x653D3D0", Offset = "0x653BDD0", VA = "0x18653D3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints BADIBLOLFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x653BE50", Offset = "0x653A850", VA = "0x18653BE50")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x653D6E0", Offset = "0x653C0E0", VA = "0x18653D6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 BLEHANPPMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x653C660", Offset = "0x653B060", VA = "0x18653C660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 GBCCCCPACMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x653C660", Offset = "0x653B060", VA = "0x18653C660")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x653DE80", Offset = "0x653C880", VA = "0x18653DE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMBCMGGBIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x653C3C0", Offset = "0x653ADC0", VA = "0x18653C3C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x653D980", Offset = "0x653C380", VA = "0x18653D980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PKGPFMCHHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x653CAC0", Offset = "0x653B4C0", VA = "0x18653CAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x653E030", Offset = "0x653CA30", VA = "0x18653E030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LHHKODAEPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x653C740", Offset = "0x653B140", VA = "0x18653C740")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x653DC00", Offset = "0x653C600", VA = "0x18653DC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion GFPKBNCOCLC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x653C9E0", Offset = "0x653B3E0", VA = "0x18653C9E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x653DF60", Offset = "0x653C960", VA = "0x18653DF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 GCOENHEEFDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x653C820", Offset = "0x653B220", VA = "0x18653C820")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x653DCD0", Offset = "0x653C6D0", VA = "0x18653DCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NBCOACICKNN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x653C900", Offset = "0x653B300", VA = "0x18653C900")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x653DDB0", Offset = "0x653C7B0", VA = "0x18653DDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HLPPLJDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x653CB80", Offset = "0x653B580", VA = "0x18653CB80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x653E110", Offset = "0x653CB10", VA = "0x18653E110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HFNNPPNDKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x653C420", Offset = "0x653AE20", VA = "0x18653C420")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x653D9F0", Offset = "0x653C3F0", VA = "0x18653D9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 JHBLCBJMNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x653BD10", Offset = "0x653A710", VA = "0x18653BD10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x653D590", Offset = "0x653BF90", VA = "0x18653D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HOFIFLHLIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x653C200", Offset = "0x653AC00", VA = "0x18653C200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x653D7C0", Offset = "0x653C1C0", VA = "0x18653D7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 DMBPOMMOKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x653C0C0", Offset = "0x653AAC0", VA = "0x18653C0C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion FPNPHFLOFDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x653BFE0", Offset = "0x653A9E0", VA = "0x18653BFE0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HDOFEDPPKBF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x653CE20", Offset = "0x653B820", VA = "0x18653CE20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 EKNAMMPOGFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x653CD40", Offset = "0x653B740", VA = "0x18653CD40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CABPGJOBHPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x653C1A0", Offset = "0x653ABA0", VA = "0x18653C1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CHLEIHFIDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x653BBF0", Offset = "0x653A5F0", VA = "0x18653BBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HNCBAAEKKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x653B780", Offset = "0x653A180", VA = "0x18653B780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NBEHJKEPLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x653B720", Offset = "0x653A120", VA = "0x18653B720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MCIBCBADMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x653B660", Offset = "0x653A060", VA = "0x18653B660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KNHNBHHLAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x653BF10", Offset = "0x653A910", VA = "0x18653BF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FEJBNDKBHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x50E17B0", Offset = "0x50E01B0", VA = "0x1850E17B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DNJOPMKHNNE MKLGPHHCKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x653B580", Offset = "0x6539F80", VA = "0x18653B580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x653D210", Offset = "0x653BC10", VA = "0x18653D210")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OLEKAPALJOK HLFALCJODHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x653B510", Offset = "0x6539F10", VA = "0x18653B510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x653D1A0", Offset = "0x653BBA0", VA = "0x18653D1A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DNJOPMKHNNE ANHHBDLOAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x653B270", Offset = "0x6539C70", VA = "0x18653B270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x653CF00", Offset = "0x653B900", VA = "0x18653CF00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DNJOPMKHNNE GGABJDLKIJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x653B2E0", Offset = "0x6539CE0", VA = "0x18653B2E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x653CF70", Offset = "0x653B970", VA = "0x18653CF70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event DNJOPMKHNNE GFGINGLKOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x653B430", Offset = "0x6539E30", VA = "0x18653B430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x653D0C0", Offset = "0x653BAC0", VA = "0x18653D0C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x653B3C0", Offset = "0x6539DC0", VA = "0x18653B3C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x653D050", Offset = "0x653BA50", VA = "0x18653D050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DNJOPMKHNNE IJODEKGABOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x653B4A0", Offset = "0x6539EA0", VA = "0x18653B4A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x653D130", Offset = "0x653BB30", VA = "0x18653D130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DNJOPMKHNNE AFNNCLCOPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x653B5F0", Offset = "0x6539FF0", VA = "0x18653B5F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x653D280", Offset = "0x653BC80", VA = "0x18653D280")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event DNJOPMKHNNE MEDPIFKLBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x653B350", Offset = "0x6539D50", VA = "0x18653B350")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x653CFE0", Offset = "0x653B9E0", VA = "0x18653CFE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		internal void IOAMFEMHJPP(MAJKPDGOFIP CEBGEIIIEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6539FB0", Offset = "0x65389B0", VA = "0x186539FB0")]
		internal void ODEIEEIGJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x653AF90", Offset = "0x6539990", VA = "0x18653AF90")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody PBGMKFLGGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x653AC60", Offset = "0x6539660", VA = "0x18653AC60")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) HBDDADMDMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65396A0", Offset = "0x65380A0", VA = "0x1865396A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6539950", Offset = "0x6538350", VA = "0x186539950")]
		private MAJKPDGOFIP OIGIKDHHFGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x653A040", Offset = "0x6538A40", VA = "0x18653A040")]
		private void OHCMDEDMAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x653A430", Offset = "0x6538E30", VA = "0x18653A430")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6539FB0", Offset = "0x65389B0", VA = "0x186539FB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x653A3D0", Offset = "0x6538DD0", VA = "0x18653A3D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x653A490", Offset = "0x6538E90", VA = "0x18653A490")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6538D50", Offset = "0x6537750", VA = "0x186538D50")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x653A4F0", Offset = "0x6538EF0", VA = "0x18653A4F0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65398F0", Offset = "0x65382F0", VA = "0x1865398F0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6539F50", Offset = "0x6538950", VA = "0x186539F50")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x653ADC0", Offset = "0x65397C0", VA = "0x18653ADC0")]
		public void SetParent(RigidbodyEx FDFHGIHHGHO, bool GPFHCOLIHFH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x653A800", Offset = "0x6539200", VA = "0x18653A800")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6539C20", Offset = "0x6538620", VA = "0x186539C20")]
		public bool IsRigidbodyAncestor(RigidbodyEx CEOKLDNCPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6539D00", Offset = "0x6538700", VA = "0x186539D00")]
		public bool IsRigidbodyDescendant(RigidbodyEx DCIOCCFCEKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6538FC0", Offset = "0x65379C0", VA = "0x186538FC0")]
		public void AddInterpolationRestriction(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x653A560", Offset = "0x6538F60", VA = "0x18653A560")]
		public void RemoveInterpolationRestriction(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6539710", Offset = "0x6538110", VA = "0x186539710")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6539030", Offset = "0x6537A30", VA = "0x186539030")]
		public void AddKinematic(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x653A5D0", Offset = "0x6538FD0", VA = "0x18653A5D0")]
		public void RemoveKinematic(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x653AD40", Offset = "0x6539740", VA = "0x18653AD40")]
		public void SetKinematic(object FACMOGNGACN, bool GMDNHEMEOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x653AB60", Offset = "0x6539560", VA = "0x18653AB60")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x653AA60", Offset = "0x6539460", VA = "0x18653AA60")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6539B10", Offset = "0x6538510", VA = "0x186539B10")]
		public Vector3 GetConstrainedVelocity(Vector3 HLPPLJDPLMM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6539A00", Offset = "0x6538400", VA = "0x186539A00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JHBLCBJMNGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6538ED0", Offset = "0x65378D0", VA = "0x186538ED0")]
		public void AddForce(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6538DC0", Offset = "0x65377C0", VA = "0x186538DC0")]
		public void AddForceAtPosition(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6539200", Offset = "0x6537C00", VA = "0x186539200")]
		public void AddTorque(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65390A0", Offset = "0x6537AA0", VA = "0x1865390A0")]
		public void AddRelativeTorque(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x653B060", Offset = "0x6539A60", VA = "0x18653B060")]
		public Vector3 WorldToLocalVelocity(Vector3 OEPKEFKPOKK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6539E40", Offset = "0x6538840", VA = "0x186539E40")]
		public Vector3 LocalToWorldVelocity(Vector3 HFNNPPNDKLE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6539890", Offset = "0x6538290", VA = "0x186539890")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6539830", Offset = "0x6538230", VA = "0x186539830")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x65397D0", Offset = "0x65381D0", VA = "0x1865397D0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6539770", Offset = "0x6538170", VA = "0x186539770")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x653A960", Offset = "0x6539360", VA = "0x18653A960")]
		public void ResetVelocityWorldSpace(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x653A860", Offset = "0x6539260", VA = "0x18653A860")]
		public void ResetVelocityLocalSpace(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x653A720", Offset = "0x6539120", VA = "0x18653A720")]
		public void ResetLinearVelocityLocalSpace(Vector3 HHEKLKDCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x653AEF0", Offset = "0x65398F0", VA = "0x18653AEF0")]
		public bool SweepTest(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6539DE0", Offset = "0x65387E0", VA = "0x186539DE0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x653AE90", Offset = "0x6539890", VA = "0x18653AE90")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x653B000", Offset = "0x6539A00", VA = "0x18653B000")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6539190", Offset = "0x6537B90", VA = "0x186539190")]
		public void AddShouldHaveUnityRigidbodyToken(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x653A640", Offset = "0x6539040", VA = "0x18653A640")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6539530", Offset = "0x6537F30", VA = "0x186539530")]
		public void ApplyForceVelocityChange(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6539490", Offset = "0x6537E90", VA = "0x186539490")]
		public void ApplyAngularVelocityChange(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x65395F0", Offset = "0x6537FF0", VA = "0x1865395F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x65393C0", Offset = "0x6537DC0", VA = "0x1865393C0")]
		public bool AllowedScaleChange(float NJPICGCBCBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65392F0", Offset = "0x6537CF0", VA = "0x1865392F0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PCNBBBLPPLP, object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x653A6B0", Offset = "0x65390B0", VA = "0x18653A6B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x653B200", Offset = "0x6539C00", VA = "0x18653B200")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class AALMABJBCFG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6514970", Offset = "0x6513370", VA = "0x186514970")]
	public static MAJKPDGOFIP EFMEBNACKAL(this RigidbodyEx EIDKMOICLKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DAMEEEKAOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody HKMBLJLNGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView FPJLAILHNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 GGNNFEKGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 GOGCFEMIGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public BDDDPOKPAMG KKJFENMGLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool EMBDNPFABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool AAAAFGFAMGN;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MKBJKEDFLPH(typeof(GJHHKNJJGHJ), new string[] { })]
public class JELOAOKJPJA : GJHHKNJJGHJ, EAPECHFGBLC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HIGFOECECEA GOEPFHPEIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NLOCKEEMPIE CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private AMEIAGNIEIL FEIBLIDBJKO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NLOCKEEMPIE GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AMEIAGNIEIL FDNKIEIEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x652B910", Offset = "0x652A310", VA = "0x18652B910", Slot = "8")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x652BA40", Offset = "0x652A440", VA = "0x18652BA40", Slot = "6")]
	public GKGLPFGLEMO NPLNPFGFAOD(RigidbodyEx EIDKMOICLKH)
	{
		return default(GKGLPFGLEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x652BCF0", Offset = "0x652A6F0", VA = "0x18652BCF0")]
	private static GKGLPFGLEMO PBBBLNHDJJA(RigidbodyEx EIDKMOICLKH)
	{
		return default(GKGLPFGLEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x652B9A0", Offset = "0x652A3A0", VA = "0x18652B9A0", Slot = "7")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public JELOAOKJPJA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static KKEEGFAPLDK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BIKFBLMNKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int GDKOPNLNAPP;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6538BB0", Offset = "0x65375B0", VA = "0x186538BB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6538BF0", Offset = "0x65375F0", VA = "0x186538BF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6538BD0", Offset = "0x65375D0", VA = "0x186538BD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DCKDMGKGDFN, [Optional] UnityEngine.Object PEHINKLIDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DCKDMGKGDFN, [Optional] UnityEngine.Object PEHINKLIDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6538D00", Offset = "0x6537700", VA = "0x186538D00")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PHBMBCFJDBM
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6538470", Offset = "0x6536E70", VA = "0x186538470")]
	public static void EEONGMFAEEI(this Rigidbody PBGMKFLGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6538340", Offset = "0x6536D40", VA = "0x186538340")]
	public static void EEONGMFAEEI(this Rigidbody PBGMKFLGGGN, Vector3 HLGHDMDJOJE, Quaternion FPNPHFLOFDM, Vector3 FLCIEPHEJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xC420E0", Offset = "0xC40AE0", VA = "0x180C420E0")]
	public static void GMFGFHOPFPL(Vector3 HLPPLJDPLMM, Vector3 GKJEHHDBDOI, [Out] Vector3 BHLBCJMCJAF, [Out] Vector3 KDAIFOMNGIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HAFLNALPNNO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class ODALAEICMIP : IMLGNNNEIMH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6390", VA = "0x1807B7990", Slot = "4")]
		public Vector3 FLCHLGHOPBB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6390", VA = "0x1807B7990", Slot = "5")]
		public Vector3 COMDNKHKCIA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ODALAEICMIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static IMLGNNNEIMH LGPFKAOGGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6529140", Offset = "0x6527B40", VA = "0x186529140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HIEMKEHDCPH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLKFIBOGPPC(bool CABPGJOBHPE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDDBKGEBAAG(bool CABPGJOBHPE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKELBIKPBAP : IDisposable, ONOFPFCCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOLMLAFHNKE();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IIGCGPIMGCK(KFBFODEPEJI.Application)]
public interface AMEIAGNIEIL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HPCAIPJONDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LBHOHABHMBK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CJEGMDCLHOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DNJOPMKHNNE ANHHBDLOAEA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DNJOPMKHNNE GGABJDLKIJD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event OLEKAPALJOK OHGHMLDHGPP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PKJCEJABLBD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action CMPLOJBIIAD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MAJKPDGOFIP> OFCPNIALKOL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MAJKPDGOFIP> AGODGBDNEGN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action JGHIJKFKKEJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<MAJKPDGOFIP> LIMPBIPJFDP;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LHFBBPLCKMM(MAJKPDGOFIP ANPHHFMKKBG, bool GPFHCOLIHFH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NMGBIJGEMFE
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMADCOJHFBN(MAJKPDGOFIP BBCCHMIJNJG, object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CLGAMCCOJJD(object FACMOGNGACN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EHICGHNDAFI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DNJOPMKHNNE KHEKPLMFOPE;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ICGFIJLDJAO();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DHKHEHMAMGM();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FNHGPHNGPMP();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KPLJMGBPKBJ();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GKJMGGNMBBN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFDPGHHPDCI(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NECCIEDFAJN(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKJBAKDPBDA(MAJKPDGOFIP EIDKMOICLKH);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNOGIAHPMMB(MAJKPDGOFIP EIDKMOICLKH);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNPLNNGPHIM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OPKDBPCBAEB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DNJOPMKHNNE EFKNBDCENPO;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGGJGJFHMNJ();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNKJNICMDDE(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFNALHDIDCF(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable BLPPEKMIDDB();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFLFNNOBHDI(Rigidbody HELFJOICHKE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OMPHGPEJHNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DNJOPMKHNNE LPFAMJOLOMI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CDKPFJBLKKB
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool IBOKPHKBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JFMHMMBLNJE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GGHIGAPFGDE
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx EMBPICLAHNG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AHGGNJHECFJ
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DNJOPMKHNNE DFMFIOEILLD;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JIEBNDKPCIK();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNKNDHMONAI();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFFAIFELDCM();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAGIIJPJGNJ();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PNGBAFMBDIE();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOEPFNFEKGK(bool DPOOEGCHNAG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GGBKAKCBEGF
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool IKKIFPPLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COOOLPDEOPN(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBKDDMGPGGI(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEECMNKNEMF();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKEFNDGCGPO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KGNHMKIAAOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGENLKFCOPL(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DGKDLJKIJOP();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NMOLEBIGNIL();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JFDEHDLFEPP();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void CILJINMIBHC();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EIHCMHAJKJG(Vector3 HLPPLJDPLMM);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HKALPDNOFGF(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MHOENHCKHCH(Vector3 JLIEMLPIBEN);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IIGCGPIMGCK(KFBFODEPEJI.Application)]
public interface NLOCKEEMPIE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool MKHKMCIIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFGMDKMMMOO(string JKDHCOHJJFE);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHHJKOFJKFA(RigidbodyEx EIDKMOICLKH, Action MCLCEMNNOFC);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALKOPEINFBL PEJDIJPIGGI(int JHHPMAEAOJH);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIOJCLDNHGL(Vector3 JAMFNBOJDGB, float FIBJEALACJJ, Color IKNGOAKEJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IIGCGPIMGCK(KFBFODEPEJI.Application)]
public interface GJHHKNJJGHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NLOCKEEMPIE GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	AMEIAGNIEIL FDNKIEIEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKGLPFGLEMO NPLNPFGFAOD(RigidbodyEx EIDKMOICLKH);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PGFDCBPILFN
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPJCCJELGCF(Vector3 HHGKOKKPIIK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBBJPBFGACI(Vector3 JHBLCBJMNGM);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKGLCGCLAGA(Vector3 HHGKOKKPIIK);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFGNOOGFDDN(Vector3 JHBLCBJMNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IMLGNNNEIMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FLCHLGHOPBB();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 COMDNKHKCIA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MAJKPDGOFIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx IBGHAOFBCML
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject NGFNCNCFJID
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool NBEHJKEPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool MCIBCBADMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform AEBPFLDNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 EJHPLDIOGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float EKKBIDCLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float BCBNNPNHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion BNPPAIPFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 CMOOOBHDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion KFNAMDFIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool CHLEIHFIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event DNJOPMKHNNE ANHHBDLOAEA;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event DNJOPMKHNNE GGABJDLKIJD;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event OLEKAPALJOK OHGHMLDHGPP;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event DNJOPMKHNNE LPFAMJOLOMI;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event DNJOPMKHNNE GFGINGLKOCH;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event DNJOPMKHNNE DFMFIOEILLD;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event DNJOPMKHNNE EFKNBDCENPO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event DNJOPMKHNNE MEDPIFKLBDD;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void IOLMLAFHNKE();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DIOOOFBHOAD();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PAGPBFBNJBC();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void BFFAIFELDCM();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void LHFBBPLCKMM(MAJKPDGOFIP FDFHGIHHGHO, bool GPFHCOLIHFH = false);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void KFAFHPPMDDC(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void NMKMPKOOKND(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void CILJINMIBHC();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void NMOLEBIGNIL();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void DGKDLJKIJOP();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MHOENHCKHCH(Vector3 JLIEMLPIBEN);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 EIHCMHAJKJG(Vector3 FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 LGEBFJGHFCF(Vector3 FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void JFDEHDLFEPP();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void DNEAKKOPNPN(MAJKPDGOFIP PCNBBBLPPLP, object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void DNAHEDKPNGN(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void DHKHEHMAMGM();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void ICGFIJLDJAO();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FNHGPHNGPMP();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool JIEBNDKPCIK();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void PNGBAFMBDIE();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable BLPPEKMIDDB();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void MNKJNICMDDE(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void KFNALHDIDCF(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PGOJGMBCEIJ(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void GJOLMILDMFJ(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool KDDIFOEDMNO(float NJPICGCBCBG);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void EPAHJGAPKEL(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void AEPMFPNLHJD(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void COOOLPDEOPN(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void PBKDDMGPGGI(object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KPLJMGBPKBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AILGKJKAAEF : MAJKPDGOFIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly GJHHKNJJGHJ FKFIJGNHDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal CJEGMDCLHOD NNGACLBBHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal GKJMGGNMBBN HECKLICGJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal OMPHGPEJHNI APMOPJDEAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal KGNHMKIAAOB HLPPLJDPLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NMGBIJGEMFE GLJOELHBFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal EHICGHNDAFI ENHJPHJFFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal JFMHMMBLNJE AAPALHEKLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal LBHOHABHMBK JHOGDLBGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal AHGGNJHECFJ PLOGLIGPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal HKELBIKPBAP NEFJHIILFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal OPKDBPCBAEB KDHLPFDFJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HPCAIPJONDJ DBCFABNBIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CDKPFJBLKKB KHKJMLCNBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal GGBKAKCBEGF HKMBLJLNGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal HIEMKEHDCPH CAPAHCOHICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable IDAOLHHJABL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx IBGHAOFBCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B3440", Offset = "0x7B1E40", VA = "0x1807B3440", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B3470", Offset = "0x7B1E70", VA = "0x1807B3470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject NGFNCNCFJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x868000", Offset = "0x866A00", VA = "0x180868000", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x867FC0", Offset = "0x8669C0", VA = "0x180867FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x65183C0", Offset = "0x6516DC0", VA = "0x1865183C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6516680", Offset = "0x6515080", VA = "0x186516680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6518BA0", Offset = "0x65175A0", VA = "0x186518BA0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6518EC0", Offset = "0x65178C0", VA = "0x186518EC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6515730", Offset = "0x6514130", VA = "0x186515730", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6516A20", Offset = "0x6515420", VA = "0x186516A20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x651A1B0", Offset = "0x6518BB0", VA = "0x18651A1B0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6516200", Offset = "0x6514C00", VA = "0x186516200", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6518CA0", Offset = "0x65176A0", VA = "0x186518CA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x651A6A0", Offset = "0x65190A0", VA = "0x18651A6A0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6519680", Offset = "0x6518080", VA = "0x186519680", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6515AB0", Offset = "0x65144B0", VA = "0x186515AB0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6515540", Offset = "0x6513F40", VA = "0x186515540", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6515E50", Offset = "0x6514850", VA = "0x186515E50", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6516470", Offset = "0x6514E70", VA = "0x186516470", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6517340", Offset = "0x6515D40", VA = "0x186517340", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x651A810", Offset = "0x6519210", VA = "0x18651A810", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6516EF0", Offset = "0x65158F0", VA = "0x186516EF0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6519E50", Offset = "0x6518850", VA = "0x186519E50", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x65196E0", Offset = "0x65180E0", VA = "0x1865196E0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6515970", Offset = "0x6514370", VA = "0x186515970", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6519D70", Offset = "0x6518770", VA = "0x186519D70", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6515650", Offset = "0x6514050", VA = "0x186515650", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HNCBAAEKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6517F00", Offset = "0x6516900", VA = "0x186517F00", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NBEHJKEPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6516AD0", Offset = "0x65154D0", VA = "0x186516AD0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MCIBCBADMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x65182E0", Offset = "0x6516CE0", VA = "0x1865182E0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6516D30", Offset = "0x6515730", VA = "0x186516D30", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x651A5D0", Offset = "0x6518FD0", VA = "0x18651A5D0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6519F30", Offset = "0x6518930", VA = "0x186519F30", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x65152C0", Offset = "0x6513CC0", VA = "0x1865152C0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x65177C0", Offset = "0x65161C0", VA = "0x1865177C0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x651A010", Offset = "0x6518A10", VA = "0x18651A010", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6516370", Offset = "0x6514D70", VA = "0x186516370", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x651A0F0", Offset = "0x6518AF0", VA = "0x18651A0F0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6519900", Offset = "0x6518300", VA = "0x186519900", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6518110", Offset = "0x6516B10", VA = "0x186518110", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x65179E0", Offset = "0x65163E0", VA = "0x1865179E0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6516900", Offset = "0x6515300", VA = "0x186516900", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6516A70", Offset = "0x6515470", VA = "0x186516A70", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6518000", Offset = "0x6516A00", VA = "0x186518000", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6519150", Offset = "0x6517B50", VA = "0x186519150", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x65153A0", Offset = "0x6513DA0", VA = "0x1865153A0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6514F50", Offset = "0x6513950", VA = "0x186514F50", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6517290", Offset = "0x6515C90", VA = "0x186517290", Slot = "48")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6516310", Offset = "0x6514D10", VA = "0x186516310", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6517190", Offset = "0x6515B90", VA = "0x186517190", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform AEBPFLDNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6519200", Offset = "0x6517C00", VA = "0x186519200", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 EJHPLDIOGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6517420", Offset = "0x6515E20", VA = "0x186517420", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6518A90", Offset = "0x6517490", VA = "0x186518A90", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float EKKBIDCLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6517970", Offset = "0x6516370", VA = "0x186517970", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x651A140", Offset = "0x6518B40", VA = "0x18651A140", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float BCBNNPNHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6517B00", Offset = "0x6516500", VA = "0x186517B00", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6516C30", Offset = "0x6515630", VA = "0x186516C30", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion BNPPAIPFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6518DB0", Offset = "0x65177B0", VA = "0x186518DB0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x65186A0", Offset = "0x65170A0", VA = "0x1865186A0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 CMOOOBHDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6517AB0", Offset = "0x65164B0", VA = "0x186517AB0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6517D10", Offset = "0x6516710", VA = "0x186517D10", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion KFNAMDFIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6515280", Offset = "0x6513C80", VA = "0x186515280", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x65161C0", Offset = "0x6514BC0", VA = "0x1865161C0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6519A00", Offset = "0x6518400", VA = "0x186519A00", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6519C10", Offset = "0x6518610", VA = "0x186519C10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6517D60", Offset = "0x6516760", VA = "0x186517D60", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x65184A0", Offset = "0x6516EA0", VA = "0x1865184A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x65171E0", Offset = "0x6515BE0", VA = "0x1865171E0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x65188D0", Offset = "0x65172D0", VA = "0x1865188D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6515B00", Offset = "0x6514500", VA = "0x186515B00", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CHLEIHFIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x651A210", Offset = "0x6518C10", VA = "0x18651A210", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DBBIGMIPKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6519960", Offset = "0x6518360", VA = "0x186519960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool CEALBENFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6515010", Offset = "0x6513A10", VA = "0x186515010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x65172E0", Offset = "0x6515CE0", VA = "0x1865172E0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6516250", Offset = "0x6514C50", VA = "0x186516250", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6517B20", Offset = "0x6516520", VA = "0x186517B20", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6515CA0", Offset = "0x65146A0", VA = "0x186515CA0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6518F20", Offset = "0x6517920", VA = "0x186518F20", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6515220", Offset = "0x6513C20", VA = "0x186515220", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6515A50", Offset = "0x6514450", VA = "0x186515A50", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6517230", Offset = "0x6515C30", VA = "0x186517230", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event DNJOPMKHNNE GFGINGLKOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6518F80", Offset = "0x6517980", VA = "0x186518F80", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x65166D0", Offset = "0x65150D0", VA = "0x1865166D0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6518500", Offset = "0x6516F00", VA = "0x186518500", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x651A6F0", Offset = "0x65190F0", VA = "0x18651A6F0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6518790", Offset = "0x6517190", VA = "0x186518790", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x651A950", Offset = "0x6519350", VA = "0x18651A950", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6515C40", Offset = "0x6514640", VA = "0x186515C40", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x65155F0", Offset = "0x6513FF0", VA = "0x1865155F0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event DNJOPMKHNNE MEDPIFKLBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6518BF0", Offset = "0x65175F0", VA = "0x186518BF0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x65163C0", Offset = "0x6514DC0", VA = "0x1865163C0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x651AE10", Offset = "0x6519810", VA = "0x18651AE10")]
	public AILGKJKAAEF(GameObject IPBNGJILMJD, RigidbodyEx NDNJKOKFFPH, GJHHKNJJGHJ FKFIJGNHDJN, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x65174D0", Offset = "0x6515ED0", VA = "0x1865174D0", Slot = "135")]
	protected virtual void FGDICDGKAOC(GJHHKNJJGHJ FKFIJGNHDJN, DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6516950", Offset = "0x6515350", VA = "0x186516950", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6518560", Offset = "0x6516F60", VA = "0x186518560", Slot = "71")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6515E00", Offset = "0x6514800", VA = "0x186515E00", Slot = "72")]
	public void DIOOOFBHOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x651A7F0", Offset = "0x65191F0", VA = "0x18651A7F0", Slot = "73")]
	public void PAGPBFBNJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6517F50", Offset = "0x6516950", VA = "0x186517F50")]
	private void GOMIOHKPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x65197C0", Offset = "0x65181C0", VA = "0x1865197C0", Slot = "81")]
	public void LHFBBPLCKMM(MAJKPDGOFIP FDFHGIHHGHO, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6518D50", Offset = "0x6517750", VA = "0x186518D50", Slot = "84")]
	public void KFAFHPPMDDC(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x651A390", Offset = "0x6518D90", VA = "0x18651A390", Slot = "85")]
	public void NMKMPKOOKND(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6515D00", Offset = "0x6514700", VA = "0x186515D00", Slot = "86")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6515440", Offset = "0x6513E40", VA = "0x186515440", Slot = "87")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6515E00", Offset = "0x6514800", VA = "0x186515E00", Slot = "88")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x651A3F0", Offset = "0x6518DF0", VA = "0x18651A3F0", Slot = "89")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x65164D0", Offset = "0x6514ED0", VA = "0x1865164D0", Slot = "90")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x651AC90", Offset = "0x6519690", VA = "0x18651AC90", Slot = "91")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x65181F0", Offset = "0x6516BF0", VA = "0x1865181F0", Slot = "92")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6519B30", Offset = "0x6518530", VA = "0x186519B30", Slot = "93")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6518050", Offset = "0x6516A50", VA = "0x186518050", Slot = "94")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x651A750", Offset = "0x6519150", VA = "0x18651A750", Slot = "95")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x651A440", Offset = "0x6518E40", VA = "0x18651A440", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6516B30", Offset = "0x6515530", VA = "0x186516B30", Slot = "97")]
	public Vector3 EIHCMHAJKJG(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6519580", Offset = "0x6517F80", VA = "0x186519580", Slot = "98")]
	public Vector3 LGEBFJGHFCF(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x65189D0", Offset = "0x65173D0", VA = "0x1865189D0", Slot = "99")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6516790", Offset = "0x6515190", VA = "0x186516790", Slot = "100")]
	public void DNEAKKOPNPN(MAJKPDGOFIP PCNBBBLPPLP, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6516730", Offset = "0x6515130", VA = "0x186516730", Slot = "101")]
	public void DNAHEDKPNGN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6519A50", Offset = "0x6518450", VA = "0x186519A50", Slot = "41")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6516520", Offset = "0x6514F20", VA = "0x186516520", Slot = "104")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6518450", Offset = "0x6516E50", VA = "0x186518450", Slot = "105")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6517990", Offset = "0x6516390", VA = "0x186517990", Slot = "106")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6518B50", Offset = "0x6517550", VA = "0x186518B50", Slot = "109")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x65153F0", Offset = "0x6513DF0", VA = "0x1865153F0", Slot = "74")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x651AD80", Offset = "0x6519780", VA = "0x18651AD80", Slot = "110")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x65155A0", Offset = "0x6513FA0", VA = "0x1865155A0", Slot = "115")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6519C70", Offset = "0x6518670", VA = "0x186519C70", Slot = "116")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6518E60", Offset = "0x6517860", VA = "0x186518E60", Slot = "117")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6518A20", Offset = "0x6517420", VA = "0x186518A20", Slot = "118")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x651AA90", Offset = "0x6519490", VA = "0x18651AA90", Slot = "121")]
	public void PGOJGMBCEIJ(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6517DB0", Offset = "0x65167B0", VA = "0x186517DB0", Slot = "122")]
	public void GJOLMILDMFJ(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6518CF0", Offset = "0x65176F0", VA = "0x186518CF0", Slot = "123")]
	public bool KDDIFOEDMNO(float NJPICGCBCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6516E90", Offset = "0x6515890", VA = "0x186516E90", Slot = "124")]
	public void EPAHJGAPKEL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6514FB0", Offset = "0x65139B0", VA = "0x186514FB0", Slot = "125")]
	public void AEPMFPNLHJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x65162B0", Offset = "0x6514CB0", VA = "0x1865162B0", Slot = "126")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x651A8F0", Offset = "0x65192F0", VA = "0x18651A8F0", Slot = "127")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x65187F0", Offset = "0x65171F0", VA = "0x1865187F0", Slot = "128")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6516D80", Offset = "0x6515780", VA = "0x186516D80", Slot = "129")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x651A9B0", Offset = "0x65193B0", VA = "0x18651A9B0", Slot = "130")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x651A4F0", Offset = "0x6518EF0", VA = "0x18651A4F0", Slot = "131")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6519CD0", Offset = "0x65186D0", VA = "0x186519CD0", Slot = "132")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65191B0", Offset = "0x6517BB0", VA = "0x1865191B0", Slot = "133")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x651ADD0", Offset = "0x65197D0", VA = "0x18651ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6517B80", Offset = "0x6516580", VA = "0x186517B80")]
	private void GBKMMJFCEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6516570", Offset = "0x6514F70", VA = "0x186516570")]
	private void DJCBBOGLEFL(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6515780", Offset = "0x6514180", VA = "0x186515780")]
	private void BMODNBGNLDI(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6517C60", Offset = "0x6516660", VA = "0x186517C60")]
	private void GFPKNACPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6516800", Offset = "0x6515200", VA = "0x186516800")]
	private void DNINOAMJFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6515040", Offset = "0x6513A40", VA = "0x186515040")]
	private void AHLNMJPJNJE(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x65178A0", Offset = "0x65162A0", VA = "0x1865178A0")]
	private void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6519830", Offset = "0x6518230", VA = "0x186519830")]
	private void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6518FE0", Offset = "0x65179E0", VA = "0x186518FE0")]
	private void KMCAJNHCAFK(RigidbodyEx BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6516FD0", Offset = "0x65159D0", VA = "0x186516FD0", Slot = "140")]
	protected virtual void FADAJDJBGKJ(RigidbodyEx EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6515EA0", Offset = "0x65148A0", VA = "0x186515EA0")]
	protected void CKBELDMGOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6519210", Offset = "0x6517C10", VA = "0x186519210")]
	protected void LCAHOHMKPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6518930", Offset = "0x6517330", VA = "0x186518930", Slot = "141")]
	protected virtual IDisposable JCBNBIEHPJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OJNMAIHDCLH
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6533F60", Offset = "0x6532960", VA = "0x186533F60")]
	public static MAJKPDGOFIP IOCFJOIMBIE(this MAJKPDGOFIP EIDKMOICLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6534090", Offset = "0x6532A90", VA = "0x186534090")]
	public static bool KADKDBFBMCH(this MAJKPDGOFIP EIDKMOICLKH, MAJKPDGOFIP CEOKLDNCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6534010", Offset = "0x6532A10", VA = "0x186534010")]
	public static bool JCHIKJPBCEL(this MAJKPDGOFIP EIDKMOICLKH, MAJKPDGOFIP DCIOCCFCEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6533F10", Offset = "0x6532910", VA = "0x186533F10")]
	public static RigidbodyEx IBGHAOFBCML(this MAJKPDGOFIP EFMEBNACKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6534110", Offset = "0x6532B10", VA = "0x186534110")]
	public static AILGKJKAAEF PFCOPFCCKIO(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class KLBLBHKPANP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x652D820", Offset = "0x652C220", VA = "0x18652D820")]
	public KLBLBHKPANP(AILGKJKAAEF FEDGKNJBNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x652D7C0", Offset = "0x652C1C0", VA = "0x18652D7C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ELNKMDFGKPN : OPGABMIFKAJ, HIEMKEHDCPH
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode NMPOINFJMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6523F00", Offset = "0x6522900", VA = "0x186523F00")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6523750", Offset = "0x6522150", VA = "0x186523750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6523810", Offset = "0x6522210", VA = "0x186523810", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6523A80", Offset = "0x6522480", VA = "0x186523A80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public ELNKMDFGKPN(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6523930", Offset = "0x6522330", VA = "0x186523930", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6523B40", Offset = "0x6522540", VA = "0x186523B40", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6523C20", Offset = "0x6522620", VA = "0x186523C20", Slot = "7")]
	public void JLKFIBOGPPC(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6523920", Offset = "0x6522320", VA = "0x186523920", Slot = "8")]
	public void FDDBKGEBAAG(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6523C30", Offset = "0x6522630", VA = "0x186523C30", Slot = "10")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6523D90", Offset = "0x6522790", VA = "0x186523D90")]
	private void NMCDOADJDOO(bool CABPGJOBHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LHPAIDOCAPF : OPGABMIFKAJ, HKELBIKPBAP, IDisposable, ONOFPFCCGPJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EOKKCCNABNA BMDOPEIDAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x652F200", Offset = "0x652DC00", VA = "0x18652F200")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x652F110", Offset = "0x652DB10", VA = "0x18652F110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x652F2E0", Offset = "0x652DCE0", VA = "0x18652F2E0", Slot = "6")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x652F110", Offset = "0x652DB10", VA = "0x18652F110", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform ALHIKPNAMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x652F4E0", Offset = "0x652DEE0", VA = "0x18652F4E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x652F5B0", Offset = "0x652DFB0", VA = "0x18652F5B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public LHPAIDOCAPF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x652F590", Offset = "0x652DF90", VA = "0x18652F590", Slot = "11")]
	public void OnChangedDistanceBand(FOIDAKOAIBK LBLICGCEGPF, FOIDAKOAIBK BOJOHLNAOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "12")]
	public void OnChangedVisibility(bool MFCCDKLMMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class PDKBAFLPOJM : OPGABMIFKAJ, HPCAIPJONDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6536650", Offset = "0x6535050", VA = "0x186536650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6520510", Offset = "0x651EF10", VA = "0x186520510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6537F20", Offset = "0x6536920", VA = "0x186537F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public PDKBAFLPOJM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6537DC0", Offset = "0x65367C0", VA = "0x186537DC0", Slot = "4")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6537AE0", Offset = "0x65364E0", VA = "0x186537AE0")]
	private void FGLGDIKCEBD(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6537860", Offset = "0x6536260", VA = "0x186537860", Slot = "5")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x65381E0", Offset = "0x6536BE0", VA = "0x1865381E0", Slot = "6")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6537600", Offset = "0x6536000", VA = "0x186537600")]
	private void CLOOBCLMBBL(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6537F80", Offset = "0x6536980", VA = "0x186537F80", Slot = "7")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6537520", Offset = "0x6535F20", VA = "0x186537520")]
	private void BDAJDFAFKKC(string DCKDMGKGDFN, UnityEngine.Object PEHINKLIDNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class APHKPALJIFJ : OPGABMIFKAJ, LBHOHABHMBK
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x651B090", Offset = "0x6519A90", VA = "0x18651B090", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x651AF40", Offset = "0x6519940", VA = "0x18651AF40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public APHKPALJIFJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x651B160", Offset = "0x6519B60", VA = "0x18651B160", Slot = "6")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x651B0F0", Offset = "0x6519AF0", VA = "0x18651B0F0", Slot = "7")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DHOEGCPHLHK : OPGABMIFKAJ, CJEGMDCLHOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly AMCJMMGFCLE CDCJGGOMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KMPLEPCMLIJ OOEOBDPFODB;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6521FD0", Offset = "0x65209D0", VA = "0x186521FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GKGLPFGLEMO NEJLNNHDLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x65224A0", Offset = "0x6520EA0", VA = "0x1865224A0")]
		get
		{
			return default(GKGLPFGLEMO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6521C10", Offset = "0x6520610", VA = "0x186521C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x65221A0", Offset = "0x6520BA0", VA = "0x1865221A0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x65222C0", Offset = "0x6520CC0", VA = "0x1865222C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public GKGLPFGLEMO KJLCEPDJECK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6521ED0", Offset = "0x65208D0", VA = "0x186521ED0")]
		get
		{
			return default(GKGLPFGLEMO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6521E60", Offset = "0x6520860", VA = "0x186521E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6521B00", Offset = "0x6520500", VA = "0x186521B00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD20", Offset = "0x7AB720", VA = "0x1807ACD20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6521C80", Offset = "0x6520680", VA = "0x186521C80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6521720", Offset = "0x6520120", VA = "0x186521720", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6521DC0", Offset = "0x65207C0", VA = "0x186521DC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6521380", Offset = "0x651FD80", VA = "0x186521380", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6522330", Offset = "0x6520D30", VA = "0x186522330", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6521100", Offset = "0x651FB00", VA = "0x186521100", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PKJCEJABLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6522500", Offset = "0x6520F00", VA = "0x186522500", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x65212E0", Offset = "0x651FCE0", VA = "0x1865212E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action CMPLOJBIIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6521B70", Offset = "0x6520570", VA = "0x186521B70", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6522780", Offset = "0x6521180", VA = "0x186522780", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<MAJKPDGOFIP> OFCPNIALKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x65217C0", Offset = "0x65201C0", VA = "0x1865217C0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6522000", Offset = "0x6520A00", VA = "0x186522000", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<MAJKPDGOFIP> AGODGBDNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6521420", Offset = "0x651FE20", VA = "0x186521420", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6521870", Offset = "0x6520270", VA = "0x186521870", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JGHIJKFKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6521D20", Offset = "0x6520720", VA = "0x186521D20", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6521F30", Offset = "0x6520930", VA = "0x186521F30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<MAJKPDGOFIP> LIMPBIPJFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6522210", Offset = "0x6520C10", VA = "0x186522210", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6521920", Offset = "0x6520320", VA = "0x186521920", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x65228B0", Offset = "0x65212B0", VA = "0x1865228B0")]
	public DHOEGCPHLHK(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x65219D0", Offset = "0x65203D0", VA = "0x1865219D0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6522420", Offset = "0x6520E20", VA = "0x186522420", Slot = "26")]
	public void LHFBBPLCKMM(MAJKPDGOFIP ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x65223D0", Offset = "0x6520DD0", VA = "0x1865223D0")]
	private void LHFBBPLCKMM(JBKHFACBNGN ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6520C80", Offset = "0x651F680", VA = "0x186520C80")]
	private void AHOIJLKJGCO(JBKHFACBNGN ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x65214D0", Offset = "0x651FED0", VA = "0x1865214D0")]
	private void CLBHIGEBNEK(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6520A80", Offset = "0x651F480", VA = "0x186520A80")]
	private void ABKMGAGMHCJ(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x65225A0", Offset = "0x6520FA0", VA = "0x1865225A0")]
	private void OBNHKAHBGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x65209D0", Offset = "0x651F3D0", VA = "0x1865209D0")]
	private void AAEABLPOAPB(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x65220B0", Offset = "0x6520AB0", VA = "0x1865220B0")]
	private void IMKPOOHCDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6521240", Offset = "0x651FC40", VA = "0x186521240")]
	private void AMKDDMPMJOF(JBKHFACBNGN EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x65211A0", Offset = "0x651FBA0", VA = "0x1865211A0")]
	private void AJCPOEFKKBF(JBKHFACBNGN EIDKMOICLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LPCPCNBGBOM
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x652F660", Offset = "0x652E060", VA = "0x18652F660")]
	public static DHOEGCPHLHK PPJCPGCPNCI(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class JEHAJPJFEJM : OPGABMIFKAJ, NMGBIJGEMFE
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x652B8E0", Offset = "0x652A2E0", VA = "0x18652B8E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x652B6B0", Offset = "0x652A0B0", VA = "0x18652B6B0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x652B5C0", Offset = "0x6529FC0", VA = "0x18652B5C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private MAJKPDGOFIP JIHACKDFFND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x652B460", Offset = "0x6529E60", VA = "0x18652B460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public JEHAJPJFEJM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x652ADF0", Offset = "0x65297F0", VA = "0x18652ADF0", Slot = "6")]
	public void HMADCOJHFBN(MAJKPDGOFIP BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x652AF40", Offset = "0x6529940", VA = "0x18652AF40")]
	private void HMADCOJHFBN(JBKHFACBNGN BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x652AD80", Offset = "0x6529780", VA = "0x18652AD80", Slot = "7")]
	public void CLGAMCCOJJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x652B050", Offset = "0x6529A50", VA = "0x18652B050")]
	private Vector3 IOOBHAOLFBD()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class FCEKGHHHOKD
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6527920", Offset = "0x6526320", VA = "0x186527920")]
	public static JEHAJPJFEJM JIHEPOGDHGE(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FBJDABJMEFO : OPGABMIFKAJ, EHICGHNDAFI
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6523F60", Offset = "0x6522960", VA = "0x186523F60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6524870", Offset = "0x6523270", VA = "0x186524870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 ANJOAJCDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6524BB0", Offset = "0x65235B0", VA = "0x186524BB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 HBCMEOBPOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x65249F0", Offset = "0x65233F0", VA = "0x1865249F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6526060", Offset = "0x6524A60", VA = "0x186526060", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6524400", Offset = "0x6522E00", VA = "0x186524400", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HFLJMKGNHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6525F40", Offset = "0x6524940", VA = "0x186525F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x6526250", Offset = "0x6524C50", VA = "0x186526250", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x65259B0", Offset = "0x65243B0", VA = "0x1865259B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6524C60", Offset = "0x6523660", VA = "0x186524C60", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6524B80", Offset = "0x6523580", VA = "0x186524B80", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event DNJOPMKHNNE KHEKPLMFOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6525FC0", Offset = "0x65249C0", VA = "0x186525FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6524FE0", Offset = "0x65239E0", VA = "0x186524FE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6527630", Offset = "0x6526030", VA = "0x186527630")]
	public FBJDABJMEFO(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65262B0", Offset = "0x6524CB0", VA = "0x1865262B0")]
	public float3 NOKGIHFBGHA()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6525CB0", Offset = "0x65246B0", VA = "0x186525CB0", Slot = "14")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6524460", Offset = "0x6522E60", VA = "0x186524460", Slot = "16")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6524C90", Offset = "0x6523690", VA = "0x186524C90", Slot = "15")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6525080", Offset = "0x6523A80", VA = "0x186525080", Slot = "18")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6524010", Offset = "0x6522A10", VA = "0x186524010", Slot = "19")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6524B20", Offset = "0x6523520", VA = "0x186524B20", Slot = "17")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6525150", Offset = "0x6523B50", VA = "0x186525150", Slot = "20")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6524830", Offset = "0x6523230", VA = "0x186524830")]
	public void EHMJHLMKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6524870", Offset = "0x6523270", VA = "0x186524870")]
	private void KPOINAHOGEO(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6524650", Offset = "0x6523050", VA = "0x186524650")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 EEOIDLAPKIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x65259B0", Offset = "0x65243B0", VA = "0x1865259B0")]
	private void NIKGHCLKAIL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6525750", Offset = "0x6524150", VA = "0x186525750")]
	private Vector3 KPOEDKBLEDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6525A70", Offset = "0x6524470", VA = "0x186525A70")]
	private Quaternion LOBMBBFJGFI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x65263D0", Offset = "0x6524DD0", VA = "0x1865263D0")]
	internal (float, Vector3) PIIOGOHJCCF(Rigidbody OLBBNJBKMLC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class KMCODNPMNEK
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x652D8A0", Offset = "0x652C2A0", VA = "0x18652D8A0")]
	public static FBJDABJMEFO NCJDLFJPAPN(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LFOGHHGBHAG : OPGABMIFKAJ, GKJMGGNMBBN
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool BNDANPMLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x652DE10", Offset = "0x652C810", VA = "0x18652DE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DPMKPOINNGM KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x652DC50", Offset = "0x652C650", VA = "0x18652DC50", Slot = "11")]
		get
		{
			return default(DPMKPOINNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private DPMKPOINNGM PKDOAGKIFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x652DC50", Offset = "0x652C650", VA = "0x18652DC50")]
		get
		{
			return default(DPMKPOINNGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x652DBE0", Offset = "0x652C5E0", VA = "0x18652DBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x652E4F0", Offset = "0x652CEF0", VA = "0x18652E4F0")]
	public LFOGHHGBHAG(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x652DFF0", Offset = "0x652C9F0", VA = "0x18652DFF0", Slot = "4")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x652E390", Offset = "0x652CD90", VA = "0x18652E390")]
	private bool OCIHJNLKONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x652E470", Offset = "0x652CE70", VA = "0x18652E470", Slot = "5")]
	public void PFDPGHHPDCI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x652E310", Offset = "0x652CD10", VA = "0x18652E310", Slot = "6")]
	public void NECCIEDFAJN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x652DCB0", Offset = "0x652C6B0", VA = "0x18652DCB0", Slot = "9")]
	public void FNPLNNGPHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x652DE70", Offset = "0x652C870", VA = "0x18652DE70")]
	private void HBGHIFEGEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x652E170", Offset = "0x652CB70", VA = "0x18652E170")]
	private void KLBKGKOABLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x652E0F0", Offset = "0x652CAF0", VA = "0x18652E0F0", Slot = "8")]
	public void JNOGIAHPMMB(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x652DF70", Offset = "0x652C970", VA = "0x18652DF70", Slot = "7")]
	public void IKJBAKDPBDA(MAJKPDGOFIP EIDKMOICLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GIBOGHJHHEP : OPGABMIFKAJ, OPKDBPCBAEB
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6528E20", Offset = "0x6527820", VA = "0x186528E20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool OKJLKBAKGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6528B30", Offset = "0x6527530", VA = "0x186528B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6528CA0", Offset = "0x65276A0", VA = "0x186528CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6528C00", Offset = "0x6527600", VA = "0x186528C00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public GIBOGHJHHEP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6528B90", Offset = "0x6527590", VA = "0x186528B90", Slot = "11")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6529070", Offset = "0x6527A70", VA = "0x186529070", Slot = "8")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6529060", Offset = "0x6527A60", VA = "0x186529060", Slot = "9")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6528F60", Offset = "0x6527960", VA = "0x186528F60", Slot = "10")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6528E80", Offset = "0x6527880", VA = "0x186528E80", Slot = "12")]
	public void JFLFNNOBHDI(Rigidbody HELFJOICHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6528D40", Offset = "0x6527740", VA = "0x186528D40", Slot = "13")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6524830", Offset = "0x6523230", VA = "0x186524830", Slot = "6")]
	public void MGGJGJFHMNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MOMLHHOMBHD : OPGABMIFKAJ, OMPHGPEJHNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView FPJLAILHNIO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6527A50", Offset = "0x6526450", VA = "0x186527A50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x65337A0", Offset = "0x65321A0", VA = "0x1865337A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6532EC0", Offset = "0x65318C0", VA = "0x186532EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6533280", Offset = "0x6531C80", VA = "0x186533280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6533C10", Offset = "0x6532610", VA = "0x186533C10")]
	public MOMLHHOMBHD(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6533670", Offset = "0x6532070", VA = "0x186533670", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6533120", Offset = "0x6531B20", VA = "0x186533120", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6533320", Offset = "0x6531D20", VA = "0x186533320", Slot = "9")]
	public void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6533830", Offset = "0x6532230", VA = "0x186533830", Slot = "10")]
	public void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6533A30", Offset = "0x6532430", VA = "0x186533A30")]
	private void LMIMMMDKBPG(PhotonView INLELPGOKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6533520", Offset = "0x6531F20", VA = "0x186533520")]
	private void FNBDCNCNNLC(RigidbodyEx FFLMFPGCDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6532F60", Offset = "0x6531960", VA = "0x186532F60")]
	private void CMOEOOFMHIA(PhotonView IMEOGBMMBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class AKHMPBODLBJ
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x651AEE0", Offset = "0x65198E0", VA = "0x18651AEE0")]
	public static MOMLHHOMBHD KEKPHNHNGMB(this AILGKJKAAEF CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class PAGKAIEHDFN : OPGABMIFKAJ, CDKPFJBLKKB
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6537000", Offset = "0x6535A00", VA = "0x186537000", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6537060", Offset = "0x6535A60", VA = "0x186537060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IBOKPHKBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6536F20", Offset = "0x6535920", VA = "0x186536F20", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6537340", Offset = "0x6535D40", VA = "0x186537340")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6537160", Offset = "0x6535B60", VA = "0x186537160", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x65371C0", Offset = "0x6535BC0", VA = "0x1865371C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x65373B0", Offset = "0x6535DB0", VA = "0x1865373B0")]
	public PAGKAIEHDFN(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x65370D0", Offset = "0x6535AD0", VA = "0x1865370D0", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6536F80", Offset = "0x6535980", VA = "0x186536F80", Slot = "10")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class GHICOPBMLEK : OPGABMIFKAJ, JFMHMMBLNJE
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x65286E0", Offset = "0x65270E0", VA = "0x1865286E0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6528740", Offset = "0x6527140", VA = "0x186528740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6528890", Offset = "0x6527290", VA = "0x186528890", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x65289E0", Offset = "0x65273E0", VA = "0x1865289E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public GHICOPBMLEK(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x65288F0", Offset = "0x65272F0", VA = "0x1865288F0", Slot = "8")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6528610", Offset = "0x6527010", VA = "0x186528610", Slot = "9")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[MKBJKEDFLPH(typeof(DBODIIBLILI), new string[] { })]
public sealed class HLKLOICOCAE : EAPECHFGBLC, DBODIIBLILI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[DOLEFBPELHN]
	private OJOJEPMKJLM EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool CAHFEKLEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6529330", Offset = "0x6527D30", VA = "0x186529330", Slot = "4")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6529300", Offset = "0x6527D00", VA = "0x186529300", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x65299D0", Offset = "0x65283D0", VA = "0x1865299D0", Slot = "6")]
	public void PIIOGOHJCCF(GKGLPFGLEMO MJOMEKCECMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x65295B0", Offset = "0x6527FB0", VA = "0x1865295B0", Slot = "7")]
	public void MOEJMPLFKJO(GKGLPFGLEMO MJOMEKCECMJ, bool PGNIJNCMLPK, bool GGNNAADIEJI, bool MGLBFLAIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x65297D0", Offset = "0x65281D0", VA = "0x1865297D0", Slot = "8")]
	public void NDEKBMEPGPM(GKGLPFGLEMO MJOMEKCECMJ, float3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6529380", Offset = "0x6527D80", VA = "0x186529380", Slot = "9")]
	public void JPJAPLNIABH(GKGLPFGLEMO MJOMEKCECMJ, float3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6529910", Offset = "0x6528310", VA = "0x186529910")]
	private bool NHGHBHIAGFM(GKGLPFGLEMO MJOMEKCECMJ, [Out] JBKHFACBNGN CEBGEIIIEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6529210", Offset = "0x6527C10", VA = "0x186529210")]
	private bool AKCAIAFEMID(GKGLPFGLEMO MJOMEKCECMJ, [Out] FBJDABJMEFO DOCACHDOLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65294C0", Offset = "0x6527EC0", VA = "0x1865294C0")]
	private bool MIGKNELEKOO(GKGLPFGLEMO MJOMEKCECMJ, [Out] BDOPMCMEHIO MIEAGJGKPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public HLKLOICOCAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class LGBIPDKEGPM : OPGABMIFKAJ, AHGGNJHECFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x651B810", Offset = "0x651A210", VA = "0x18651B810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x652EC60", Offset = "0x652D660", VA = "0x18652EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x652ED30", Offset = "0x652D730", VA = "0x18652ED30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool LILIFKJCNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x652E600", Offset = "0x652D000", VA = "0x18652E600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x652E830", Offset = "0x652D230", VA = "0x18652E830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool PLADKMOGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x652E910", Offset = "0x652D310", VA = "0x18652E910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x652E8A0", Offset = "0x652D2A0", VA = "0x18652E8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int CMIPKFCFKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x652ECC0", Offset = "0x652D6C0", VA = "0x18652ECC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x652E970", Offset = "0x652D370", VA = "0x18652E970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x652EE00", Offset = "0x652D800", VA = "0x18652EE00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x652EFE0", Offset = "0x652D9E0", VA = "0x18652EFE0")]
	public LGBIPDKEGPM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x652EA10", Offset = "0x652D410", VA = "0x18652EA10", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x652ED90", Offset = "0x652D790", VA = "0x18652ED90", Slot = "8")]
	public void NNKNDHMONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x652EAC0", Offset = "0x652D4C0", VA = "0x18652EAC0", Slot = "7")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x652E660", Offset = "0x652D060", VA = "0x18652E660", Slot = "9")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6524830", Offset = "0x6523230", VA = "0x186524830", Slot = "12")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x652EEA0", Offset = "0x652D8A0", VA = "0x18652EEA0", Slot = "11")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "10")]
	public void IAGIIJPJGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x652E750", Offset = "0x652D150", VA = "0x18652E750")]
	private void CIIMDJNDCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CPMLGDJNGCE : OPGABMIFKAJ, GGBKAKCBEGF
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x651FBE0", Offset = "0x651E5E0", VA = "0x18651FBE0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x65203C0", Offset = "0x651EDC0", VA = "0x1865203C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6520510", Offset = "0x651EF10", VA = "0x186520510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool IKKIFPPLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x65204B0", Offset = "0x651EEB0", VA = "0x1865204B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x65205F0", Offset = "0x651EFF0", VA = "0x1865205F0")]
	public CPMLGDJNGCE(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x65200B0", Offset = "0x651EAB0", VA = "0x1865200B0", Slot = "5")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x651FB60", Offset = "0x651E560", VA = "0x18651FB60", Slot = "7")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6520570", Offset = "0x651EF70", VA = "0x186520570", Slot = "8")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x651FE90", Offset = "0x651E890", VA = "0x18651FE90", Slot = "9")]
	public void HEECMNKNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6520160", Offset = "0x651EB60", VA = "0x186520160", Slot = "11")]
	public void LBENDJNHIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x651FCC0", Offset = "0x651E6C0", VA = "0x18651FCC0", Slot = "12")]
	public void GEGBCJPHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "10")]
	public void DKEFNDGCGPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class BDOPMCMEHIO : OPGABMIFKAJ, KGNHMKIAAOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x651E910", Offset = "0x651D310", VA = "0x18651E910", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x651E0A0", Offset = "0x651CAA0", VA = "0x18651E0A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x651B760", Offset = "0x651A160", VA = "0x18651B760", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x651B570", Offset = "0x6519F70", VA = "0x18651B570", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x651E110", Offset = "0x651CB10", VA = "0x18651E110", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x651B6A0", Offset = "0x651A0A0", VA = "0x18651B6A0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x651CFF0", Offset = "0x651B9F0", VA = "0x18651CFF0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x651EC70", Offset = "0x651D670", VA = "0x18651EC70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x651E3B0", Offset = "0x651CDB0", VA = "0x18651E3B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x651B5E0", Offset = "0x6519FE0", VA = "0x18651B5E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x651CFC0", Offset = "0x651B9C0", VA = "0x18651CFC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x651E410", Offset = "0x651CE10", VA = "0x18651E410", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x651BAC0", Offset = "0x651A4C0", VA = "0x18651BAC0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x651C360", Offset = "0x651AD60", VA = "0x18651C360", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x651CCE0", Offset = "0x651B6E0", VA = "0x18651CCE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private HPCAIPJONDJ HGNCDNNOBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EF60", Offset = "0x5E6D960", VA = "0x185E6EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x651B810", Offset = "0x651A210", VA = "0x18651B810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public BDOPMCMEHIO(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x651E170", Offset = "0x651CB70", VA = "0x18651E170", Slot = "20")]
	public void MGENLKFCOPL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x651D590", Offset = "0x651BF90", VA = "0x18651D590", Slot = "30")]
	public void HKALPDNOFGF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x651BA10", Offset = "0x651A410", VA = "0x18651BA10", Slot = "19")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x651CA90", Offset = "0x651B490", VA = "0x18651CA90", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x651DD60", Offset = "0x651C760", VA = "0x18651DD60", Slot = "28")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x651B830", Offset = "0x651A230", VA = "0x18651B830", Slot = "35")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x651B350", Offset = "0x6519D50", VA = "0x18651B350", Slot = "34")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x651BA10", Offset = "0x651A410", VA = "0x18651BA10", Slot = "27")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x651E440", Offset = "0x651CE40", VA = "0x18651E440", Slot = "25")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x651C4B0", Offset = "0x651AEB0", VA = "0x18651C4B0", Slot = "24")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x651ECA0", Offset = "0x651D6A0", VA = "0x18651ECA0", Slot = "33")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x651D600", Offset = "0x651C000", VA = "0x18651D600", Slot = "32")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x651E1E0", Offset = "0x651CBE0", VA = "0x18651E1E0", Slot = "31")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x651D020", Offset = "0x651BA20", VA = "0x18651D020", Slot = "22")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x651E9C0", Offset = "0x651D3C0", VA = "0x18651E9C0", Slot = "21")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x651E500", Offset = "0x651CF00", VA = "0x18651E500", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x651CC00", Offset = "0x651B600", VA = "0x18651CC00", Slot = "29")]
	public Vector3 EIHCMHAJKJG(Vector3 HLPPLJDPLMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x651DBD0", Offset = "0x651C5D0", VA = "0x18651DBD0", Slot = "26")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x651C360", Offset = "0x651AD60", VA = "0x18651C360")]
	private void GMKAMDEIKLJ(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x651DED0", Offset = "0x651C8D0", VA = "0x18651DED0")]
	private void LDFNFKHOCFM(Vector3 HOAINBKFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x651CD40", Offset = "0x651B740", VA = "0x18651CD40")]
	private Vector3 ENABOCDHLAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x651C510", Offset = "0x651AF10", VA = "0x18651C510")]
	private void DHLCFCLNLBP(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x651C0D0", Offset = "0x651AAD0", VA = "0x18651C0D0")]
	private Vector3 COMDNKHKCIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x651D660", Offset = "0x651C060", VA = "0x18651D660")]
	private void IBBJPBFGACI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x651B510", Offset = "0x6519F10", VA = "0x18651B510")]
	private void BHFFIHFMHLA(Vector3 HLPPLJDPLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x651E4A0", Offset = "0x651CEA0", VA = "0x18651E4A0")]
	private void NNPPGONHLPL(Vector3 JHBLCBJMNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x651BB20", Offset = "0x651A520", VA = "0x18651BB20")]
	private void CJEKDGJPDEH(string HFFACCPGHJD, Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x651CB50", Offset = "0x651B550", VA = "0x18651CB50")]
	private void EAEJKAFDAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class OPGABMIFKAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly JBKHFACBNGN EIDKMOICLKH;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected OJOJEPMKJLM MLHEFGEKGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x563B1D0", Offset = "0x5639BD0", VA = "0x18563B1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected GKGLPFGLEMO KENHLMBDPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x563B210", Offset = "0x5639C10", VA = "0x18563B210")]
		get
		{
			return default(GKGLPFGLEMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x651B1F0", Offset = "0x6519BF0", VA = "0x18651B1F0")]
	public OPGABMIFKAJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6536E80", Offset = "0x6535880", VA = "0x186536E80")]
	protected MAJKPDGOFIP BDPMIFOJKOL(GKGLPFGLEMO LMIDHGHBOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KFCCKLEKCMP : AMEIAGNIEIL
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x652D060", Offset = "0x652BA60", VA = "0x18652D060", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x652CF80", Offset = "0x652B980", VA = "0x18652CF80", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x652C880", Offset = "0x652B280", VA = "0x18652C880", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x652D2E0", Offset = "0x652BCE0", VA = "0x18652D2E0", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x652D3C0", Offset = "0x652BDC0", VA = "0x18652D3C0", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x652C960", Offset = "0x652B360", VA = "0x18652C960", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x652CBE0", Offset = "0x652B5E0", VA = "0x18652CBE0", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x652CCC0", Offset = "0x652B6C0", VA = "0x18652CCC0", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x652CDA0", Offset = "0x652B7A0", VA = "0x18652CDA0", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x652D200", Offset = "0x652BC00", VA = "0x18652D200", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x652CE80", Offset = "0x652B880", VA = "0x18652CE80")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x652C640", Offset = "0x652B040", VA = "0x18652C640")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x652C740", Offset = "0x652B140", VA = "0x18652C740")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x652C5D0", Offset = "0x652AFD0", VA = "0x18652C5D0")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x652CA40", Offset = "0x652B440", VA = "0x18652CA40")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x652D0C0", Offset = "0x652BAC0", VA = "0x18652D0C0", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public KFCCKLEKCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x652CE80", Offset = "0x652B880", VA = "0x18652CE80", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x652C640", Offset = "0x652B040", VA = "0x18652C640", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x652C740", Offset = "0x652B140", VA = "0x18652C740", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x652C5D0", Offset = "0x652AFD0", VA = "0x18652C5D0", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x652D1F0", Offset = "0x652BBF0", VA = "0x18652D1F0", Slot = "18")]
	private CDKPFJBLKKB OHKAABCHFLG(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class KMPLEPCMLIJ : IReadOnlyList<MAJKPDGOFIP>, IEnumerable<MAJKPDGOFIP>, IEnumerable, IReadOnlyCollection<MAJKPDGOFIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly GKGLPFGLEMO LMIDHGHBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly OJOJEPMKJLM CJAFMNMHIKG;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x652DB90", Offset = "0x652C590", VA = "0x18652DB90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public MAJKPDGOFIP BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x652DA40", Offset = "0x652C440", VA = "0x18652DA40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x34C48E0", Offset = "0x34C32E0", VA = "0x1834C48E0")]
	public KMPLEPCMLIJ(GKGLPFGLEMO LMIDHGHBOHD, OJOJEPMKJLM CJAFMNMHIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x652D930", Offset = "0x652C330", VA = "0x18652D930", Slot = "6")]
	public IEnumerator<MAJKPDGOFIP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x652D930", Offset = "0x652C330", VA = "0x18652D930", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x652DA40", Offset = "0x652C440", VA = "0x18652DA40")]
	[CompilerGenerated]
	private MAJKPDGOFIP IBCNBNLJEHM(int CCNHOKJIGCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[MKBJKEDFLPH(typeof(AMEIAGNIEIL), new string[] { })]
public class EJOBDGADALJ : AMEIAGNIEIL, EAPECHFGBLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly AMEIAGNIEIL CEAJHOIMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AMEIAGNIEIL JNEOIJJFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private HIGFOECECEA GOEPFHPEIFG;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private AMEIAGNIEIL FDNKIEIEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x65232D0", Offset = "0x6521CD0", VA = "0x1865232D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6523280", Offset = "0x6521C80", VA = "0x186523280", Slot = "20")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6523330", Offset = "0x6521D30", VA = "0x186523330", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x65231E0", Offset = "0x6521BE0", VA = "0x1865231E0", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6522D60", Offset = "0x6521760", VA = "0x186522D60", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6523560", Offset = "0x6521F60", VA = "0x186523560", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6523600", Offset = "0x6522000", VA = "0x186523600", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6522E00", Offset = "0x6521800", VA = "0x186522E00", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6522F50", Offset = "0x6521950", VA = "0x186522F50", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6522FF0", Offset = "0x65219F0", VA = "0x186522FF0", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6523090", Offset = "0x6521A90", VA = "0x186523090", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x65234C0", Offset = "0x6521EC0", VA = "0x1865234C0", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6523130", Offset = "0x6521B30", VA = "0x186523130")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6522C00", Offset = "0x6521600", VA = "0x186522C00")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6522CB0", Offset = "0x65216B0", VA = "0x186522CB0")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6522B50", Offset = "0x6521550", VA = "0x186522B50")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6522EA0", Offset = "0x65218A0", VA = "0x186522EA0")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x65233D0", Offset = "0x6521DD0", VA = "0x1865233D0", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x65236A0", Offset = "0x65220A0", VA = "0x1865236A0")]
	public EJOBDGADALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6523130", Offset = "0x6521B30", VA = "0x186523130", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6522C00", Offset = "0x6521600", VA = "0x186522C00", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6522CB0", Offset = "0x65216B0", VA = "0x186522CB0", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6522B50", Offset = "0x6521550", VA = "0x186522B50", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6522EA0", Offset = "0x65218A0", VA = "0x186522EA0", Slot = "18")]
	private CDKPFJBLKKB OHKAABCHFLG(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class GPLKLIGHILM : MAJKPDGOFIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly GPLKLIGHILM MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx IBGHAOFBCML
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject NGFNCNCFJID
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8156B0", Offset = "0x8140B0", VA = "0x1808156B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F23C0", Offset = "0x7F0DC0", VA = "0x1807F23C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A91A0", Offset = "0x7A7BA0", VA = "0x1807A91A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A9190", Offset = "0x7A7B90", VA = "0x1807A9190", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A9160", Offset = "0x7A7B60", VA = "0x1807A9160", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7A90F0", Offset = "0x7A7AF0", VA = "0x1807A90F0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9F89A0", Offset = "0x9F73A0", VA = "0x1809F89A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E30", Offset = "0x8C4830", VA = "0x1808C5E30", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1B67F10", Offset = "0x1B66910", VA = "0x181B67F10", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3490", Offset = "0x3DA1E90", VA = "0x183DA3490", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4676020", Offset = "0x4674A20", VA = "0x184676020", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4674800", Offset = "0x4673200", VA = "0x184674800", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4F18100", Offset = "0x4F16B00", VA = "0x184F18100", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4F17A60", Offset = "0x4F16460", VA = "0x184F17A60", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool NBEHJKEPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x93C6B0", Offset = "0x93B0B0", VA = "0x18093C6B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool MCIBCBADMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1777450", Offset = "0x1775E50", VA = "0x181777450", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1490", Offset = "0x5DCFE90", VA = "0x185DD1490", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4F15DC0", Offset = "0x4F147C0", VA = "0x184F15DC0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x96AC00", Offset = "0x969600", VA = "0x18096AC00", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x65290A0", Offset = "0x6527AA0", VA = "0x1865290A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1A6C070", Offset = "0x1A6AA70", VA = "0x181A6C070", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB60", Offset = "0x8F9560", VA = "0x1808FAB60", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "48")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xCFB620", Offset = "0xCFA020", VA = "0x180CFB620", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform AEBPFLDNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9A87E0", Offset = "0x9A71E0", VA = "0x1809A87E0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 EJHPLDIOGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float EKKBIDCLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float BCBNNPNHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion BNPPAIPFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9AB890", Offset = "0x9AA290", VA = "0x1809AB890", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 CMOOOBHDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion KFNAMDFIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB890", Offset = "0x9AA290", VA = "0x1809AB890", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool CHLEIHFIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A80", Offset = "0x8D2480", VA = "0x1808D3A80", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event DNJOPMKHNNE GFGINGLKOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event DNJOPMKHNNE MEDPIFKLBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "41")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "71")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "72")]
	public void DIOOOFBHOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "73")]
	public void PAGPBFBNJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "74")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "81")]
	public void LHFBBPLCKMM(MAJKPDGOFIP FDFHGIHHGHO, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "84")]
	public void KFAFHPPMDDC(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "85")]
	public void NMKMPKOOKND(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "86")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "87")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "88")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "89")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "90")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "91")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "92")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "93")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "94")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "95")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "96")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "97")]
	public Vector3 EIHCMHAJKJG(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xB235E0", Offset = "0xB21FE0", VA = "0x180B235E0", Slot = "98")]
	public Vector3 LGEBFJGHFCF(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "99")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "100")]
	public void DNEAKKOPNPN(MAJKPDGOFIP PCNBBBLPPLP, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "101")]
	public void DNAHEDKPNGN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "104")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "105")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "106")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "109")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "110")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "115")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "116")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "117")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "118")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "121")]
	public void PGOJGMBCEIJ(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "122")]
	public void GJOLMILDMFJ(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "123")]
	public bool KDDIFOEDMNO(float NJPICGCBCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "124")]
	public void EPAHJGAPKEL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "125")]
	public void AEPMFPNLHJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "126")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "127")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "128")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "129")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "130")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "131")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6529080", Offset = "0x6527A80", VA = "0x186529080", Slot = "132")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "133")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public GPLKLIGHILM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class JBKHFACBNGN : AILGKJKAAEF, FPCCLLKIMJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal GKGLPFGLEMO LMIDHGHBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal OJOJEPMKJLM NHJEICJOBPL;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x651AE10", Offset = "0x6519810", VA = "0x18651AE10")]
	public JBKHFACBNGN(GameObject IPBNGJILMJD, RigidbodyEx NDNJKOKFFPH, GJHHKNJJGHJ FKFIJGNHDJN, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x652A630", Offset = "0x6529030", VA = "0x18652A630", Slot = "135")]
	protected override void FGDICDGKAOC(GJHHKNJJGHJ FKFIJGNHDJN, DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "141")]
	protected override IDisposable JCBNBIEHPJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x652A3F0", Offset = "0x6528DF0", VA = "0x18652A3F0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x652A560", Offset = "0x6528F60", VA = "0x18652A560", Slot = "142")]
	public void EODIDENHFFD(FBGBOJPDDPL LBLICGCEGPF, FBGBOJPDDPL BOJOHLNAOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x652ACC0", Offset = "0x65296C0", VA = "0x18652ACC0", Slot = "143")]
	public void OJFEIJEODBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x652A330", Offset = "0x6528D30", VA = "0x18652A330", Slot = "144")]
	public void DJBDPDNHELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x652A2D0", Offset = "0x6528CD0", VA = "0x18652A2D0", Slot = "145")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x652A8A0", Offset = "0x65292A0", VA = "0x18652A8A0", Slot = "146")]
	public bool HAKGICMHJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x652AA30", Offset = "0x6529430", VA = "0x18652AA30", Slot = "147")]
	public void NGBCENGGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "140")]
	protected override void FADAJDJBGKJ(RigidbodyEx JHEMNDMHNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x652AA90", Offset = "0x6529490", VA = "0x18652AA90")]
	private void NLFHFCPDHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class DGHGBALACAG
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x65206B0", Offset = "0x651F0B0", VA = "0x1865206B0")]
	public static AILGKJKAAEF LLDOIHNNBLM(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NMJCODELKIP : CJEGMDCLHOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMKDDMPMJOF(MAJKPDGOFIP EIDKMOICLKH);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCPOEFKKBF(MAJKPDGOFIP EIDKMOICLKH);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLBHIGEBNEK(MAJKPDGOFIP DCOAKJNKHHB);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABKMGAGMHCJ(MAJKPDGOFIP DCOAKJNKHHB);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PNBBAGECFKN : NMGBIJGEMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	IGLHFMCOLGL<MAJKPDGOFIP> OEKIFBMCAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	MAJKPDGOFIP JIHACKDFFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface PBKHCFAONLN : EHICGHNDAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PIIOGOHJCCF(Rigidbody OLBBNJBKMLC);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OIBBONPLHNI : OMPHGPEJHNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView KMGHADLEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class PMHFNJDMNDO : HIEMKEHDCPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode PAMMOHEDAPI;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6538600", Offset = "0x6537000", VA = "0x186538600", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6538830", Offset = "0x6537230", VA = "0x186538830", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x652D670", Offset = "0x652C070", VA = "0x18652D670")]
	public PMHFNJDMNDO(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6538720", Offset = "0x6537120", VA = "0x186538720", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x65388A0", Offset = "0x65372A0", VA = "0x1865388A0", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6538920", Offset = "0x6537320", VA = "0x186538920", Slot = "7")]
	public void JLKFIBOGPPC(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6538710", Offset = "0x6537110", VA = "0x186538710", Slot = "8")]
	public void FDDBKGEBAAG(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6538930", Offset = "0x6537330", VA = "0x186538930", Slot = "10")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6538A90", Offset = "0x6537490", VA = "0x186538A90")]
	private void NMCDOADJDOO(bool CABPGJOBHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JGDFMBNBMHE : HKELBIKPBAP, IDisposable, ONOFPFCCGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EOKKCCNABNA BOIICAFPHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private ALKOPEINFBL MMFOFDJGLKH;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x652BF70", Offset = "0x652A970", VA = "0x18652BF70", Slot = "6")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x652BE50", Offset = "0x652A850", VA = "0x18652BE50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform ALHIKPNAMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x652C470", Offset = "0x652AE70", VA = "0x18652C470", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x652C3C0", Offset = "0x652ADC0", VA = "0x18652C3C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x652C490", Offset = "0x652AE90", VA = "0x18652C490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x652C540", Offset = "0x652AF40", VA = "0x18652C540")]
	public JGDFMBNBMHE(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x652C0C0", Offset = "0x652AAC0", VA = "0x18652C0C0", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x652BF20", Offset = "0x652A920", VA = "0x18652BF20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1BEBFD0", Offset = "0x1BEA9D0", VA = "0x181BEBFD0", Slot = "11")]
	private void PKKAOOMBMDO(FOIDAKOAIBK DOFFEAJCHKC, FOIDAKOAIBK DFEJJMNJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "12")]
	private void PBCJNDLLJML(bool MFCCDKLMMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class ONJAMPHHNLJ : HPCAIPJONDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x65237C0", Offset = "0x65221C0", VA = "0x1865237C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6536650", Offset = "0x6535050", VA = "0x186536650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x6520510", Offset = "0x651EF10", VA = "0x186520510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6536A60", Offset = "0x6535460", VA = "0x186536A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x652D670", Offset = "0x652C070", VA = "0x18652D670")]
	public ONJAMPHHNLJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6536900", Offset = "0x6535300", VA = "0x186536900", Slot = "4")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65366A0", Offset = "0x65350A0", VA = "0x1865366A0")]
	private void FGLGDIKCEBD(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65363D0", Offset = "0x6534DD0", VA = "0x1865363D0", Slot = "5")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6536D20", Offset = "0x6535720", VA = "0x186536D20", Slot = "6")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6536170", Offset = "0x6534B70", VA = "0x186536170")]
	private void CLOOBCLMBBL(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6536AC0", Offset = "0x65354C0", VA = "0x186536AC0", Slot = "7")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class KFEADJINFBD : LBHOHABHMBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool IPFPGDCNONO;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x652D530", Offset = "0x652BF30", VA = "0x18652D530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x652D670", Offset = "0x652C070", VA = "0x18652D670")]
	public KFEADJINFBD(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x652D640", Offset = "0x652C040", VA = "0x18652D640", Slot = "6")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x651B0F0", Offset = "0x6519AF0", VA = "0x18651B0F0", Slot = "7")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class OMLPHINDMJP : NMJCODELKIP, CJEGMDCLHOD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MAJKPDGOFIP EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<MAJKPDGOFIP> PEMKNLONOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private MAJKPDGOFIP LMAHFBOHCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private MAJKPDGOFIP BBCCHMIJNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform FKJLEIHNGII;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6535380", Offset = "0x6533D80", VA = "0x186535380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9130", Offset = "0x7A7B30", VA = "0x1807A9130", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6535760", Offset = "0x6534160", VA = "0x186535760", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A9310", Offset = "0x7A7D10", VA = "0x1807A9310", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD20", Offset = "0x7AB720", VA = "0x1807ACD20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6535100", Offset = "0x6533B00", VA = "0x186535100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6534D10", Offset = "0x6533710", VA = "0x186534D10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6535240", Offset = "0x6533C40", VA = "0x186535240", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6534950", Offset = "0x6533350", VA = "0x186534950", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6535770", Offset = "0x6534170", VA = "0x186535770", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6534550", Offset = "0x6532F50", VA = "0x186534550", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PKJCEJABLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6535ED0", Offset = "0x65348D0", VA = "0x186535ED0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6534780", Offset = "0x6533180", VA = "0x186534780", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action CMPLOJBIIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6535060", Offset = "0x6533A60", VA = "0x186535060", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6536010", Offset = "0x6534A10", VA = "0x186536010", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<MAJKPDGOFIP> OFCPNIALKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6534DB0", Offset = "0x65337B0", VA = "0x186534DB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x65353E0", Offset = "0x6533DE0", VA = "0x1865353E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<MAJKPDGOFIP> AGODGBDNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x65349F0", Offset = "0x65333F0", VA = "0x1865349F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6534E60", Offset = "0x6533860", VA = "0x186534E60", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JGHIJKFKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x65351A0", Offset = "0x6533BA0", VA = "0x1865351A0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x65352E0", Offset = "0x6533CE0", VA = "0x1865352E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<MAJKPDGOFIP> LIMPBIPJFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x65356B0", Offset = "0x65340B0", VA = "0x1865356B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6534F10", Offset = "0x6533910", VA = "0x186534F10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65360B0", Offset = "0x6534AB0", VA = "0x1865360B0")]
	public OMLPHINDMJP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6534FC0", Offset = "0x65339C0", VA = "0x186534FC0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6535950", Offset = "0x6534350", VA = "0x186535950", Slot = "30")]
	public void LHFBBPLCKMM(MAJKPDGOFIP ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6534AA0", Offset = "0x65334A0", VA = "0x186534AA0", Slot = "6")]
	public void CLBHIGEBNEK(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65342D0", Offset = "0x6532CD0", VA = "0x1865342D0", Slot = "7")]
	public void ABKMGAGMHCJ(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6534690", Offset = "0x6533090", VA = "0x186534690", Slot = "4")]
	public void AMKDDMPMJOF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65345F0", Offset = "0x6532FF0", VA = "0x1865345F0", Slot = "5")]
	public void AJCPOEFKKBF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6535F70", Offset = "0x6534970", VA = "0x186535F70")]
	private void OBNHKAHBGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6534290", Offset = "0x6532C90", VA = "0x186534290")]
	private void AAEABLPOAPB(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6535810", Offset = "0x6534210", VA = "0x186535810")]
	private void LDOLOMCEGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6535490", Offset = "0x6533E90", VA = "0x186535490")]
	private void IMKPOOHCDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6534820", Offset = "0x6533220", VA = "0x186534820")]
	private void CBLLMLKAABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x65355C0", Offset = "0x6533FC0", VA = "0x1865355C0")]
	[CompilerGenerated]
	private object JEICMIMPNIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class BDGLFOBIBMN
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x651B290", Offset = "0x6519C90", VA = "0x18651B290")]
	public static NMJCODELKIP PPJCPGCPNCI(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class CCCJIBJPGDC : PNBBAGECFKN, NMGBIJGEMFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IGLHFMCOLGL<MAJKPDGOFIP> JGFEHHONOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool JNDJCJPJBAE;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public IGLHFMCOLGL<MAJKPDGOFIP> OEKIFBMCAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x651FA30", Offset = "0x651E430", VA = "0x18651FA30", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x651F4E0", Offset = "0x651DEE0", VA = "0x18651F4E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x651F3F0", Offset = "0x651DDF0", VA = "0x18651F3F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MAJKPDGOFIP JIHACKDFFND
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x651F340", Offset = "0x651DD40", VA = "0x18651F340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x651FA60", Offset = "0x651E460", VA = "0x18651FA60")]
	public CCCJIBJPGDC(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x651EF40", Offset = "0x651D940", VA = "0x18651EF40", Slot = "8")]
	public void HMADCOJHFBN(MAJKPDGOFIP BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x651EEE0", Offset = "0x651D8E0", VA = "0x18651EEE0", Slot = "9")]
	public void CLGAMCCOJJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x651EFB0", Offset = "0x651D9B0", VA = "0x18651EFB0")]
	private Vector3 IOOBHAOLFBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x651F6A0", Offset = "0x651E0A0", VA = "0x18651F6A0")]
	private void NIBOJCMPOKE(MAJKPDGOFIP PEBMHMPLAHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class KKPJFOIHODP
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x652D700", Offset = "0x652C100", VA = "0x18652D700")]
	public static PNBBAGECFKN JIHEPOGDHGE(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class MAFNHPMHFNP : PBKHCFAONLN, EHICGHNDAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 GGNNFEKGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 GOGCFEMIGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float CMIMLEJAPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float CDEFDGMAIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 MIBOIJDALHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? DMBPOMMOKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? FPNPHFLOFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool MEABJJAGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool GIKLEEAFDBM;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1090930", Offset = "0x108F330", VA = "0x181090930", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x652FE90", Offset = "0x652E890", VA = "0x18652FE90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x6531160", Offset = "0x652FB60", VA = "0x186531160", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11282B0", Offset = "0x1126CB0", VA = "0x1811282B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x652F800", Offset = "0x652E200", VA = "0x18652F800")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xBAFD60", Offset = "0xBAE760", VA = "0x180BAFD60", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6530C60", Offset = "0x652F660", VA = "0x186530C60", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6530230", Offset = "0x652EC30", VA = "0x186530230", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x65300B0", Offset = "0x652EAB0", VA = "0x1865300B0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x652FD50", Offset = "0x652E750", VA = "0x18652FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event DNJOPMKHNNE KHEKPLMFOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x65310C0", Offset = "0x652FAC0", VA = "0x1865310C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x65304A0", Offset = "0x652EEA0", VA = "0x1865304A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6532280", Offset = "0x6530C80", VA = "0x186532280")]
	public MAFNHPMHFNP(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x652FBA0", Offset = "0x652E5A0", VA = "0x18652FBA0", Slot = "17")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x65303C0", Offset = "0x652EDC0", VA = "0x1865303C0", Slot = "16")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6530540", Offset = "0x652EF40", VA = "0x186530540", Slot = "19")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x652F910", Offset = "0x652E310", VA = "0x18652F910", Slot = "20")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x652FF40", Offset = "0x652E940", VA = "0x18652FF40", Slot = "18")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6530620", Offset = "0x652F020", VA = "0x186530620", Slot = "21")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x652FE90", Offset = "0x652E890", VA = "0x18652FE90")]
	private void KFDNCHBDDCI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x652FDA0", Offset = "0x652E7A0", VA = "0x18652FDA0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EEOIDLAPKIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x652F800", Offset = "0x652E200", VA = "0x18652F800")]
	private void EGHAEIHPODL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6530C60", Offset = "0x652F660", VA = "0x186530C60")]
	private void NIKGHCLKAIL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6530AC0", Offset = "0x652F4C0", VA = "0x186530AC0")]
	private Vector3 KPOEDKBLEDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6530E90", Offset = "0x652F890", VA = "0x186530E90", Slot = "15")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6530D10", Offset = "0x652F710", VA = "0x186530D10")]
	private Quaternion LOBMBBFJGFI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6531260", Offset = "0x652FC60", VA = "0x186531260")]
	public void PIIOGOHJCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6531330", Offset = "0x652FD30", VA = "0x186531330", Slot = "4")]
	public (float, Vector3) PIIOGOHJCCF(Rigidbody OLBBNJBKMLC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class IJELHFPLOPK
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x652A210", Offset = "0x6528C10", VA = "0x18652A210")]
	public static PBKHCFAONLN NCJDLFJPAPN(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class HOJNGHNHMHJ : GKJMGGNMBBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly CIADAKDIJIG MHCJFKMGFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly DPMKPOINNGM KKJFENMGLMK;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool BNDANPMLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xCE9870", Offset = "0xCE8270", VA = "0x180CE9870", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DPMKPOINNGM KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0", Slot = "11")]
		get
		{
			return default(DPMKPOINNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x652A110", Offset = "0x6528B10", VA = "0x18652A110")]
	public HOJNGHNHMHJ(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6529D90", Offset = "0x6528790", VA = "0x186529D90", Slot = "4")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x652A040", Offset = "0x6528A40", VA = "0x18652A040")]
	private bool OCIHJNLKONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x652A0E0", Offset = "0x6528AE0", VA = "0x18652A0E0", Slot = "5")]
	public void PFDPGHHPDCI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x652A010", Offset = "0x6528A10", VA = "0x18652A010", Slot = "6")]
	public void NECCIEDFAJN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6529AF0", Offset = "0x65284F0", VA = "0x186529AF0", Slot = "9")]
	public void FNPLNNGPHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6529C30", Offset = "0x6528630", VA = "0x186529C30")]
	private void HBGHIFEGEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6529EA0", Offset = "0x65288A0", VA = "0x186529EA0")]
	private void KLBKGKOABLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6529E60", Offset = "0x6528860", VA = "0x186529E60", Slot = "8")]
	public void JNOGIAHPMMB(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6529D50", Offset = "0x6528750", VA = "0x186529D50", Slot = "7")]
	public void IKJBAKDPBDA(MAJKPDGOFIP EIDKMOICLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class AENCFDJJFJD : OPKDBPCBAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly CIADAKDIJIG EAFDAPKKLAM;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6514BC0", Offset = "0x65135C0", VA = "0x186514BC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6514AF0", Offset = "0x65134F0", VA = "0x186514AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6514A50", Offset = "0x6513450", VA = "0x186514A50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6514E60", Offset = "0x6513860", VA = "0x186514E60")]
	public AENCFDJJFJD(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x65149E0", Offset = "0x65133E0", VA = "0x1865149E0", Slot = "11")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6514E50", Offset = "0x6513850", VA = "0x186514E50", Slot = "8")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6514E00", Offset = "0x6513800", VA = "0x186514E00", Slot = "9")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6514CF0", Offset = "0x65136F0", VA = "0x186514CF0", Slot = "10")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6514E10", Offset = "0x6513810", VA = "0x186514E10", Slot = "6")]
	public void MGGJGJFHMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6514C70", Offset = "0x6513670", VA = "0x186514C70", Slot = "12")]
	public void JFLFNNOBHDI(Rigidbody HELFJOICHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6514B90", Offset = "0x6513590", VA = "0x186514B90", Slot = "13")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class FPJIGKPIFFA : OIBBONPLHNI, OMPHGPEJHNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView FPJLAILHNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool EMELAFJBAAI;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView KMGHADLEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6527A50", Offset = "0x6526450", VA = "0x186527A50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x884340", Offset = "0x882D40", VA = "0x180884340", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x65279B0", Offset = "0x65263B0", VA = "0x1865279B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6527DE0", Offset = "0x65267E0", VA = "0x186527DE0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x6528560", Offset = "0x6526F60", VA = "0x186528560")]
	public FPJIGKPIFFA(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x6528150", Offset = "0x6526B50", VA = "0x186528150", Slot = "9")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x6527CE0", Offset = "0x65266E0", VA = "0x186527CE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6527E80", Offset = "0x6526880", VA = "0x186527E80", Slot = "10")]
	public void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x6528280", Offset = "0x6526C80", VA = "0x186528280", Slot = "11")]
	public void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x65283F0", Offset = "0x6526DF0", VA = "0x1865283F0")]
	private void LMIMMMDKBPG(PhotonView INLELPGOKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x6527FF0", Offset = "0x65269F0", VA = "0x186527FF0")]
	private void FNBDCNCNNLC(RigidbodyEx FFLMFPGCDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x6527A70", Offset = "0x6526470", VA = "0x186527A70")]
	private void CMOEOOFMHIA(PhotonView IMEOGBMMBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class ECBHGGOMLEK
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x6522A90", Offset = "0x6521490", VA = "0x186522A90")]
	public static OIBBONPLHNI KEKPHNHNGMB(this MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class NLEOFHBIGHJ : CDKPFJBLKKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints BADIBLOLFPI;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xB000D0", Offset = "0xAFEAD0", VA = "0x180B000D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D700", Offset = "0x3E0C100", VA = "0x183E0D700", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool IBOKPHKBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xD41110", Offset = "0xD3FB10", VA = "0x180D41110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D6F0", Offset = "0x3E0C0F0", VA = "0x183E0D6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6533D30", Offset = "0x6532730", VA = "0x186533D30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6533E60", Offset = "0x6532860", VA = "0x186533E60")]
	public NLEOFHBIGHJ(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6533D00", Offset = "0x6532700", VA = "0x186533D00", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6533CD0", Offset = "0x65326D0", VA = "0x186533CD0", Slot = "10")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DGJJLNJAHOI : JFMHMMBLNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly MAJKPDGOFIP EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float ONCKKCMOCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float APHJOBCNCLL;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8C63A0", Offset = "0x8C4DA0", VA = "0x1808C63A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x65207A0", Offset = "0x651F1A0", VA = "0x1865207A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9436D0", Offset = "0x9420D0", VA = "0x1809436D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x65208C0", Offset = "0x651F2C0", VA = "0x1865208C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6520990", Offset = "0x651F390", VA = "0x186520990")]
	public DGJJLNJAHOI(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6520870", Offset = "0x651F270", VA = "0x186520870", Slot = "8")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6520700", Offset = "0x651F100", VA = "0x186520700", Slot = "9")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class MGNGNMFOFOP : AHGGNJHECFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool LGGIBOHIEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool CADCPLJALLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int DMNDKJBEKDG;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x652FD50", Offset = "0x652E750", VA = "0x18652FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6532640", Offset = "0x6531040", VA = "0x186532640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6532C20", Offset = "0x6531620", VA = "0x186532C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6532C80", Offset = "0x6531680", VA = "0x186532C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x65329A0", Offset = "0x65313A0", VA = "0x1865329A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6532CF0", Offset = "0x65316F0", VA = "0x186532CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6532E30", Offset = "0x6531830", VA = "0x186532E30")]
	public MGNGNMFOFOP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6532A40", Offset = "0x6531440", VA = "0x186532A40", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6532CE0", Offset = "0x65316E0", VA = "0x186532CE0", Slot = "8")]
	public void NNKNDHMONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6532AD0", Offset = "0x65314D0", VA = "0x186532AD0", Slot = "7")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x65323C0", Offset = "0x6530DC0", VA = "0x1865323C0", Slot = "9")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6532D90", Offset = "0x6531790", VA = "0x186532D90", Slot = "11")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6532370", Offset = "0x6530D70", VA = "0x186532370", Slot = "12")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65327F0", Offset = "0x65311F0", VA = "0x1865327F0", Slot = "10")]
	public void IAGIIJPJGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6532460", Offset = "0x6530E60", VA = "0x186532460")]
	private bool BMPMKDPNPLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6532660", Offset = "0x6531060", VA = "0x186532660")]
	private void CIIMDJNDCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class EJAJJNFFOKH : GGBKAKCBEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly CIADAKDIJIG ENODFAGNLHH;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6540320", Offset = "0x653ED20", VA = "0x186540320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool IKKIFPPLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xCE9870", Offset = "0xCE8270", VA = "0x180CE9870", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6540370", Offset = "0x653ED70", VA = "0x186540370")]
	public EJAJJNFFOKH(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x653FF10", Offset = "0x653E910", VA = "0x18653FF10", Slot = "5")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x653F400", Offset = "0x653DE00", VA = "0x18653F400", Slot = "7")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6540340", Offset = "0x653ED40", VA = "0x186540340", Slot = "8")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x653FC40", Offset = "0x653E640", VA = "0x18653FC40", Slot = "9")]
	public void HEECMNKNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x653FFB0", Offset = "0x653E9B0", VA = "0x18653FFB0", Slot = "11")]
	public void LBENDJNHIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x653FAC0", Offset = "0x653E4C0", VA = "0x18653FAC0", Slot = "12")]
	public void GEGBCJPHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x653F430", Offset = "0x653DE30", VA = "0x18653F430", Slot = "10")]
	public void DKEFNDGCGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x65401A0", Offset = "0x653EBA0", VA = "0x1865401A0")]
	private void NACMONJIMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x653F940", Offset = "0x653E340", VA = "0x18653F940")]
	private void GDKPJPOHHIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ODOMMIDAGLG : KGNHMKIAAOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly AILGKJKAAEF EIDKMOICLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly CIADAKDIJIG LEPDNGOBCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float CFFACJBEAFK;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6542770", Offset = "0x6541170", VA = "0x186542770", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6540AD0", Offset = "0x653F4D0", VA = "0x186540AD0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6541840", Offset = "0x6540240", VA = "0x186541840", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x65431E0", Offset = "0x6541BE0", VA = "0x1865431E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x6542A00", Offset = "0x6541400", VA = "0x186542A00", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6540A10", Offset = "0x653F410", VA = "0x186540A10", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6541750", Offset = "0x6540150", VA = "0x186541750", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x6542B20", Offset = "0x6541520", VA = "0x186542B20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCC0", Offset = "0x7FC6C0", VA = "0x1807FDCC0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6540E90", Offset = "0x653F890", VA = "0x186540E90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1696A40", Offset = "0x1695440", VA = "0x181696A40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private HPCAIPJONDJ HGNCDNNOBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EF60", Offset = "0x5E6D960", VA = "0x185E6EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x651B810", Offset = "0x651A210", VA = "0x18651B810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x65433B0", Offset = "0x6541DB0", VA = "0x1865433B0")]
	public ODOMMIDAGLG(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6540D00", Offset = "0x653F700", VA = "0x186540D00", Slot = "19")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6541400", Offset = "0x653FE00", VA = "0x186541400", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6542530", Offset = "0x6540F30", VA = "0x186542530", Slot = "28")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xB2D880", Offset = "0xB2C280", VA = "0x180B2D880", Slot = "20")]
	public void MGENLKFCOPL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xB2FA40", Offset = "0xB2E440", VA = "0x180B2FA40", Slot = "30")]
	public void HKALPDNOFGF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6540B90", Offset = "0x653F590", VA = "0x186540B90", Slot = "35")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6540430", Offset = "0x653EE30", VA = "0x186540430", Slot = "34")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6540D00", Offset = "0x653F700", VA = "0x186540D00", Slot = "27")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6542B50", Offset = "0x6541550", VA = "0x186542B50", Slot = "25")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6540F40", Offset = "0x653F940", VA = "0x186540F40", Slot = "24")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6543210", Offset = "0x6541C10", VA = "0x186543210", Slot = "33")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6541F60", Offset = "0x6540960", VA = "0x186541F60", Slot = "32")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6542890", Offset = "0x6541290", VA = "0x186542890", Slot = "31")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6541930", Offset = "0x6540330", VA = "0x186541930", Slot = "22")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6542F50", Offset = "0x6541950", VA = "0x186542F50", Slot = "21")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6542BB0", Offset = "0x65415B0", VA = "0x186542BB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6541510", Offset = "0x653FF10", VA = "0x186541510", Slot = "29")]
	public Vector3 EIHCMHAJKJG(Vector3 HLPPLJDPLMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6542400", Offset = "0x6540E00", VA = "0x186542400", Slot = "26")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6540E90", Offset = "0x653F890", VA = "0x186540E90")]
	private void GMKAMDEIKLJ(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6542600", Offset = "0x6541000", VA = "0x186542600")]
	private void LDFNFKHOCFM(Vector3 HOAINBKFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6541670", Offset = "0x6540070", VA = "0x186541670")]
	private Vector3 ENABOCDHLAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6540FA0", Offset = "0x653F9A0", VA = "0x186540FA0")]
	private void DHLCFCLNLBP(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6540DB0", Offset = "0x653F7B0", VA = "0x186540DB0")]
	private Vector3 COMDNKHKCIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6541FC0", Offset = "0x65409C0", VA = "0x186541FC0")]
	private void IBBJPBFGACI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6540580", Offset = "0x653EF80", VA = "0x186540580")]
	private void BHFFIHFMHLA(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6541460", Offset = "0x653FE60", VA = "0x186541460")]
	private void EAEJKAFDAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DLPDJGNFKNP : AMEIAGNIEIL
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x653F1D0", Offset = "0x653DBD0", VA = "0x18653F1D0", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x653F0F0", Offset = "0x653DAF0", VA = "0x18653F0F0", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x653EDB0", Offset = "0x653D7B0", VA = "0x18653EDB0", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x653F340", Offset = "0x653DD40", VA = "0x18653F340", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x653F3A0", Offset = "0x653DDA0", VA = "0x18653F3A0", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x653EE10", Offset = "0x653D810", VA = "0x18653EE10", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x653EEE0", Offset = "0x653D8E0", VA = "0x18653EEE0", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x653EF40", Offset = "0x653D940", VA = "0x18653EF40", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x653EFA0", Offset = "0x653D9A0", VA = "0x18653EFA0", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x653F2E0", Offset = "0x653DCE0", VA = "0x18653F2E0", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x653F000", Offset = "0x653DA00", VA = "0x18653F000")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x653ECD0", Offset = "0x653D6D0", VA = "0x18653ECD0")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x653ED40", Offset = "0x653D740", VA = "0x18653ED40")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x653EC60", Offset = "0x653D660", VA = "0x18653EC60")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x653EE70", Offset = "0x653D870", VA = "0x18653EE70")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x653F230", Offset = "0x653DC30", VA = "0x18653F230", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public DLPDJGNFKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x653F000", Offset = "0x653DA00", VA = "0x18653F000", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x653ECD0", Offset = "0x653D6D0", VA = "0x18653ECD0", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x653ED40", Offset = "0x653D740", VA = "0x18653ED40", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x653EC60", Offset = "0x653D660", VA = "0x18653EC60", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x653EE70", Offset = "0x653D870", VA = "0x18653EE70", Slot = "18")]
	private CDKPFJBLKKB OHKAABCHFLG(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
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
