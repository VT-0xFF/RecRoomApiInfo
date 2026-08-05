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
		[Cpp2IlInjected.Address(RVA = "0x64B54D0", Offset = "0x64B48D0", VA = "0x1864B54D0", Slot = "4")]
		public override void LIBHGHNAKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0C80", Offset = "0x5EC0080", VA = "0x185EC0C80", Slot = "5")]
		public override void PMAEKCHOEDI(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64C46C0", Offset = "0x64C3AC0", VA = "0x1864C46C0")]
		private void LOBKKIADICI(MHIODLNIGAP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64C40A0", Offset = "0x64C34A0", VA = "0x1864C40A0")]
		private void DNPLPBJENID(MHIODLNIGAP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64C44D0", Offset = "0x64C38D0", VA = "0x1864C44D0", Slot = "6")]
		public override void HEEEGKLIMAL(MHIODLNIGAP registry, [In] AMKBBHPMMAE filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "8")]
		public override void NHPGLMFECNH(JNDAGNIJMBN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64C4830", Offset = "0x64C3C30", VA = "0x1864C4830")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA420", Offset = "0x7E9820", VA = "0x1807EA420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
	public void FFGMDKMMMOO(string JKDHCOHJJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
	public void GHHJKOFJKFA(RigidbodyEx EIDKMOICLKH, Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "7")]
	public ALKOPEINFBL PEJDIJPIGGI(int JHHPMAEAOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "8")]
	public void DIOJCLDNHGL(Vector3 JAMFNBOJDGB, float FIBJEALACJJ, Color IKNGOAKEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BF730", Offset = "0x64BEB30", VA = "0x1864BF730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> DNIIMHNKHNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2D30", Offset = "0x7A2130", VA = "0x1807A2D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FDGNIACFHOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64C1780", Offset = "0x64C0B80", VA = "0x1864C1780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx MMJFNLDGOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x64C16E0", Offset = "0x64C0AE0", VA = "0x1864C16E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BBCCHMIJNJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x64C23A0", Offset = "0x64C17A0", VA = "0x1864C23A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x64C3920", Offset = "0x64C2D20", VA = "0x1864C3920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CHLICCLJPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7C62E0", Offset = "0x7C56E0", VA = "0x1807C62E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AEBPFLDNGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7C62E0", Offset = "0x7C56E0", VA = "0x1807C62E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CALKAHELOOG JOKNAEJDLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64C14A0", Offset = "0x64C08A0", VA = "0x1864C14A0")]
			get
			{
				return default(CALKAHELOOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x64C30D0", Offset = "0x64C24D0", VA = "0x1864C30D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool POAPHBBHPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x64C1A30", Offset = "0x64C0E30", VA = "0x1864C1A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool INBELOMJCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x64C15C0", Offset = "0x64C09C0", VA = "0x1864C15C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IMLGNNNEIMH PDNJEHPNAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x64C1970", Offset = "0x64C0D70", VA = "0x1864C1970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x64C3290", Offset = "0x64C2690", VA = "0x1864C3290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PGFDCBPILFN IPDDHLLCKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x64C1910", Offset = "0x64C0D10", VA = "0x1864C1910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x64C3220", Offset = "0x64C2620", VA = "0x1864C3220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BHCMGGOOJGA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x64C1860", Offset = "0x64C0C60", VA = "0x1864C1860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody EGEJNIHCGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x64C18C0", Offset = "0x64C0CC0", VA = "0x1864C18C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JGCCOPIFNEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x64C1620", Offset = "0x64C0A20", VA = "0x1864C1620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x64C3140", Offset = "0x64C2540", VA = "0x1864C3140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GPKFPBEJMJN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2D20", Offset = "0x5CC2120", VA = "0x185CC2D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5CC1F40", Offset = "0x5CC1340", VA = "0x185CC1F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float CDEFDGMAIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x64C2340", Offset = "0x64C1740", VA = "0x1864C2340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CMIMLEJAPOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x64C22E0", Offset = "0x64C16E0", VA = "0x1864C22E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x64C38B0", Offset = "0x64C2CB0", VA = "0x1864C38B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ONCKKCMOCFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x64C1C90", Offset = "0x64C1090", VA = "0x1864C1C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x64C3530", Offset = "0x64C2930", VA = "0x1864C3530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float APHJOBCNCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x64C1A90", Offset = "0x64C0E90", VA = "0x1864C1A90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x64C3300", Offset = "0x64C2700", VA = "0x1864C3300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IPFPGDCNONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x64C2900", Offset = "0x64C1D00", VA = "0x1864C2900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x64C3E80", Offset = "0x64C3280", VA = "0x1864C3E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 MIBOIJDALHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x64C20C0", Offset = "0x64C14C0", VA = "0x1864C20C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x64C3680", Offset = "0x64C2A80", VA = "0x1864C3680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 JAMFNBOJDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64C2A40", Offset = "0x64C1E40", VA = "0x1864C2A40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode HKDLINHPEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x64C1BD0", Offset = "0x64C0FD0", VA = "0x1864C1BD0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x64C3450", Offset = "0x64C2850", VA = "0x1864C3450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NPDJFEPCKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x64C1680", Offset = "0x64C0A80", VA = "0x1864C1680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x64C31B0", Offset = "0x64C25B0", VA = "0x1864C31B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints BADIBLOLFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x64C1C30", Offset = "0x64C1030", VA = "0x1864C1C30")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x64C34C0", Offset = "0x64C28C0", VA = "0x1864C34C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 BLEHANPPMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x64C2440", Offset = "0x64C1840", VA = "0x1864C2440")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 GBCCCCPACMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x64C2440", Offset = "0x64C1840", VA = "0x1864C2440")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x64C3C60", Offset = "0x64C3060", VA = "0x1864C3C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMBCMGGBIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x64C21A0", Offset = "0x64C15A0", VA = "0x1864C21A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x64C3760", Offset = "0x64C2B60", VA = "0x1864C3760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PKGPFMCHHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x64C28A0", Offset = "0x64C1CA0", VA = "0x1864C28A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x64C3E10", Offset = "0x64C3210", VA = "0x1864C3E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LHHKODAEPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x64C2520", Offset = "0x64C1920", VA = "0x1864C2520")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64C39E0", Offset = "0x64C2DE0", VA = "0x1864C39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion GFPKBNCOCLC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x64C27C0", Offset = "0x64C1BC0", VA = "0x1864C27C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x64C3D40", Offset = "0x64C3140", VA = "0x1864C3D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 GCOENHEEFDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x64C2600", Offset = "0x64C1A00", VA = "0x1864C2600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x64C3AB0", Offset = "0x64C2EB0", VA = "0x1864C3AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NBCOACICKNN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x64C26E0", Offset = "0x64C1AE0", VA = "0x1864C26E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x64C3B90", Offset = "0x64C2F90", VA = "0x1864C3B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HLPPLJDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x64C2960", Offset = "0x64C1D60", VA = "0x1864C2960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x64C3EF0", Offset = "0x64C32F0", VA = "0x1864C3EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HFNNPPNDKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x64C2200", Offset = "0x64C1600", VA = "0x1864C2200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64C37D0", Offset = "0x64C2BD0", VA = "0x1864C37D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 JHBLCBJMNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x64C1AF0", Offset = "0x64C0EF0", VA = "0x1864C1AF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x64C3370", Offset = "0x64C2770", VA = "0x1864C3370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HOFIFLHLIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x64C1FE0", Offset = "0x64C13E0", VA = "0x1864C1FE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x64C35A0", Offset = "0x64C29A0", VA = "0x1864C35A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 DMBPOMMOKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x64C1EA0", Offset = "0x64C12A0", VA = "0x1864C1EA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion FPNPHFLOFDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x64C1DC0", Offset = "0x64C11C0", VA = "0x1864C1DC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HDOFEDPPKBF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x64C2C00", Offset = "0x64C2000", VA = "0x1864C2C00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 EKNAMMPOGFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x64C2B20", Offset = "0x64C1F20", VA = "0x1864C2B20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CABPGJOBHPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x64C1F80", Offset = "0x64C1380", VA = "0x1864C1F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CHLEIHFIDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x64C19D0", Offset = "0x64C0DD0", VA = "0x1864C19D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HNCBAAEKKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x64C1560", Offset = "0x64C0960", VA = "0x1864C1560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NBEHJKEPLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x64C1500", Offset = "0x64C0900", VA = "0x1864C1500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MCIBCBADMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x64C1440", Offset = "0x64C0840", VA = "0x1864C1440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KNHNBHHLAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x64C1CF0", Offset = "0x64C10F0", VA = "0x1864C1CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool FEJBNDKBHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5079740", Offset = "0x5078B40", VA = "0x185079740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DNJOPMKHNNE MKLGPHHCKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x64C1360", Offset = "0x64C0760", VA = "0x1864C1360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x64C2FF0", Offset = "0x64C23F0", VA = "0x1864C2FF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OLEKAPALJOK HLFALCJODHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x64C12F0", Offset = "0x64C06F0", VA = "0x1864C12F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x64C2F80", Offset = "0x64C2380", VA = "0x1864C2F80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DNJOPMKHNNE ANHHBDLOAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64C1050", Offset = "0x64C0450", VA = "0x1864C1050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x64C2CE0", Offset = "0x64C20E0", VA = "0x1864C2CE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DNJOPMKHNNE GGABJDLKIJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x64C10C0", Offset = "0x64C04C0", VA = "0x1864C10C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x64C2D50", Offset = "0x64C2150", VA = "0x1864C2D50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event DNJOPMKHNNE GFGINGLKOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x64C1210", Offset = "0x64C0610", VA = "0x1864C1210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x64C2EA0", Offset = "0x64C22A0", VA = "0x1864C2EA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64C11A0", Offset = "0x64C05A0", VA = "0x1864C11A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64C2E30", Offset = "0x64C2230", VA = "0x1864C2E30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DNJOPMKHNNE IJODEKGABOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64C1280", Offset = "0x64C0680", VA = "0x1864C1280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64C2F10", Offset = "0x64C2310", VA = "0x1864C2F10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DNJOPMKHNNE AFNNCLCOPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x64C13D0", Offset = "0x64C07D0", VA = "0x1864C13D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64C3060", Offset = "0x64C2460", VA = "0x1864C3060")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event DNJOPMKHNNE MEDPIFKLBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64C1130", Offset = "0x64C0530", VA = "0x1864C1130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x64C2DC0", Offset = "0x64C21C0", VA = "0x1864C2DC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60")]
		internal void IOAMFEMHJPP(MAJKPDGOFIP CEBGEIIIEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64BFD90", Offset = "0x64BF190", VA = "0x1864BFD90")]
		internal void ODEIEEIGJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64C0D70", Offset = "0x64C0170", VA = "0x1864C0D70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody PBGMKFLGGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64C0A40", Offset = "0x64BFE40", VA = "0x1864C0A40")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) HBDDADMDMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64BF480", Offset = "0x64BE880", VA = "0x1864BF480")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64BF730", Offset = "0x64BEB30", VA = "0x1864BF730")]
		private MAJKPDGOFIP OIGIKDHHFGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64BFE20", Offset = "0x64BF220", VA = "0x1864BFE20")]
		private void OHCMDEDMAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64C0210", Offset = "0x64BF610", VA = "0x1864C0210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64BFD90", Offset = "0x64BF190", VA = "0x1864BFD90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64C01B0", Offset = "0x64BF5B0", VA = "0x1864C01B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64C0270", Offset = "0x64BF670", VA = "0x1864C0270")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64BEB30", Offset = "0x64BDF30", VA = "0x1864BEB30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64C02D0", Offset = "0x64BF6D0", VA = "0x1864C02D0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64BF6D0", Offset = "0x64BEAD0", VA = "0x1864BF6D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64BFD30", Offset = "0x64BF130", VA = "0x1864BFD30")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64C0BA0", Offset = "0x64BFFA0", VA = "0x1864C0BA0")]
		public void SetParent(RigidbodyEx FDFHGIHHGHO, bool GPFHCOLIHFH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64C05E0", Offset = "0x64BF9E0", VA = "0x1864C05E0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64BFA00", Offset = "0x64BEE00", VA = "0x1864BFA00")]
		public bool IsRigidbodyAncestor(RigidbodyEx CEOKLDNCPDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64BFAE0", Offset = "0x64BEEE0", VA = "0x1864BFAE0")]
		public bool IsRigidbodyDescendant(RigidbodyEx DCIOCCFCEKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64BEDA0", Offset = "0x64BE1A0", VA = "0x1864BEDA0")]
		public void AddInterpolationRestriction(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64C0340", Offset = "0x64BF740", VA = "0x1864C0340")]
		public void RemoveInterpolationRestriction(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64BF4F0", Offset = "0x64BE8F0", VA = "0x1864BF4F0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64BEE10", Offset = "0x64BE210", VA = "0x1864BEE10")]
		public void AddKinematic(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64C03B0", Offset = "0x64BF7B0", VA = "0x1864C03B0")]
		public void RemoveKinematic(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64C0B20", Offset = "0x64BFF20", VA = "0x1864C0B20")]
		public void SetKinematic(object FACMOGNGACN, bool GMDNHEMEOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64C0940", Offset = "0x64BFD40", VA = "0x1864C0940")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64C0840", Offset = "0x64BFC40", VA = "0x1864C0840")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64BF8F0", Offset = "0x64BECF0", VA = "0x1864BF8F0")]
		public Vector3 GetConstrainedVelocity(Vector3 HLPPLJDPLMM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64BF7E0", Offset = "0x64BEBE0", VA = "0x1864BF7E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JHBLCBJMNGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64BECB0", Offset = "0x64BE0B0", VA = "0x1864BECB0")]
		public void AddForce(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x64BEBA0", Offset = "0x64BDFA0", VA = "0x1864BEBA0")]
		public void AddForceAtPosition(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x64BEFE0", Offset = "0x64BE3E0", VA = "0x1864BEFE0")]
		public void AddTorque(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64BEE80", Offset = "0x64BE280", VA = "0x1864BEE80")]
		public void AddRelativeTorque(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64C0E40", Offset = "0x64C0240", VA = "0x1864C0E40")]
		public Vector3 WorldToLocalVelocity(Vector3 OEPKEFKPOKK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64BFC20", Offset = "0x64BF020", VA = "0x1864BFC20")]
		public Vector3 LocalToWorldVelocity(Vector3 HFNNPPNDKLE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64BF670", Offset = "0x64BEA70", VA = "0x1864BF670")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64BF610", Offset = "0x64BEA10", VA = "0x1864BF610")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64BF5B0", Offset = "0x64BE9B0", VA = "0x1864BF5B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x64BF550", Offset = "0x64BE950", VA = "0x1864BF550")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64C0740", Offset = "0x64BFB40", VA = "0x1864C0740")]
		public void ResetVelocityWorldSpace(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64C0640", Offset = "0x64BFA40", VA = "0x1864C0640")]
		public void ResetVelocityLocalSpace(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x64C0500", Offset = "0x64BF900", VA = "0x1864C0500")]
		public void ResetLinearVelocityLocalSpace(Vector3 HHEKLKDCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64C0CD0", Offset = "0x64C00D0", VA = "0x1864C0CD0")]
		public bool SweepTest(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x64BFBC0", Offset = "0x64BEFC0", VA = "0x1864BFBC0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x64C0C70", Offset = "0x64C0070", VA = "0x1864C0C70")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x64C0DE0", Offset = "0x64C01E0", VA = "0x1864C0DE0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64BEF70", Offset = "0x64BE370", VA = "0x1864BEF70")]
		public void AddShouldHaveUnityRigidbodyToken(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x64C0420", Offset = "0x64BF820", VA = "0x1864C0420")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x64BF310", Offset = "0x64BE710", VA = "0x1864BF310")]
		public void ApplyForceVelocityChange(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x64BF270", Offset = "0x64BE670", VA = "0x1864BF270")]
		public void ApplyAngularVelocityChange(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x64BF3D0", Offset = "0x64BE7D0", VA = "0x1864BF3D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x64BF1A0", Offset = "0x64BE5A0", VA = "0x1864BF1A0")]
		public bool AllowedScaleChange(float NJPICGCBCBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64BF0D0", Offset = "0x64BE4D0", VA = "0x1864BF0D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PCNBBBLPPLP, object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64C0490", Offset = "0x64BF890", VA = "0x1864C0490")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FACMOGNGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64C0FE0", Offset = "0x64C03E0", VA = "0x1864C0FE0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class AALMABJBCFG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x649A750", Offset = "0x6499B50", VA = "0x18649A750")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AMEIAGNIEIL FDNKIEIEOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x64B16F0", Offset = "0x64B0AF0", VA = "0x1864B16F0", Slot = "8")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x64B1820", Offset = "0x64B0C20", VA = "0x1864B1820", Slot = "6")]
	public GKGLPFGLEMO NPLNPFGFAOD(RigidbodyEx EIDKMOICLKH)
	{
		return default(GKGLPFGLEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x64B1AD0", Offset = "0x64B0ED0", VA = "0x1864B1AD0")]
	private static GKGLPFGLEMO PBBBLNHDJJA(RigidbodyEx EIDKMOICLKH)
	{
		return default(GKGLPFGLEMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x64B1780", Offset = "0x64B0B80", VA = "0x1864B1780", Slot = "7")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BE990", Offset = "0x64BDD90", VA = "0x1864BE990")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x64BE9D0", Offset = "0x64BDDD0", VA = "0x1864BE9D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x64BE9B0", Offset = "0x64BDDB0", VA = "0x1864BE9B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DCKDMGKGDFN, [Optional] UnityEngine.Object PEHINKLIDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DCKDMGKGDFN, [Optional] UnityEngine.Object PEHINKLIDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64BEAE0", Offset = "0x64BDEE0", VA = "0x1864BEAE0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PHBMBCFJDBM
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x64BE250", Offset = "0x64BD650", VA = "0x1864BE250")]
	public static void EEONGMFAEEI(this Rigidbody PBGMKFLGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x64BE120", Offset = "0x64BD520", VA = "0x1864BE120")]
	public static void EEONGMFAEEI(this Rigidbody PBGMKFLGGGN, Vector3 HLGHDMDJOJE, Quaternion FPNPHFLOFDM, Vector3 FLCIEPHEJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xC35920", Offset = "0xC34D20", VA = "0x180C35920")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AD990", Offset = "0x7ACD90", VA = "0x1807AD990", Slot = "4")]
		public Vector3 FLCHLGHOPBB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD990", Offset = "0x7ACD90", VA = "0x1807AD990", Slot = "5")]
		public Vector3 COMDNKHKCIA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ODALAEICMIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static IMLGNNNEIMH LGPFKAOGGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64AEF20", Offset = "0x64AE320", VA = "0x1864AEF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A8840", VA = "0x1807A9440", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A9470", Offset = "0x7A8870", VA = "0x1807A9470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject NGFNCNCFJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x85D990", Offset = "0x85CD90", VA = "0x18085D990", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x85D950", Offset = "0x85CD50", VA = "0x18085D950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x649E1A0", Offset = "0x649D5A0", VA = "0x18649E1A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x649C460", Offset = "0x649B860", VA = "0x18649C460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x649E980", Offset = "0x649DD80", VA = "0x18649E980", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x649ECA0", Offset = "0x649E0A0", VA = "0x18649ECA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x649B510", Offset = "0x649A910", VA = "0x18649B510", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x649C800", Offset = "0x649BC00", VA = "0x18649C800", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x649FF90", Offset = "0x649F390", VA = "0x18649FF90", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x649BFE0", Offset = "0x649B3E0", VA = "0x18649BFE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x649EA80", Offset = "0x649DE80", VA = "0x18649EA80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IMLGNNNEIMH PDNJEHPNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x64A0480", Offset = "0x649F880", VA = "0x1864A0480", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x649F460", Offset = "0x649E860", VA = "0x18649F460", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x649B890", Offset = "0x649AC90", VA = "0x18649B890", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x649B320", Offset = "0x649A720", VA = "0x18649B320", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x649BC30", Offset = "0x649B030", VA = "0x18649BC30", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x649C250", Offset = "0x649B650", VA = "0x18649C250", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x649D120", Offset = "0x649C520", VA = "0x18649D120", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x64A05F0", Offset = "0x649F9F0", VA = "0x1864A05F0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x649CCD0", Offset = "0x649C0D0", VA = "0x18649CCD0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x649FC30", Offset = "0x649F030", VA = "0x18649FC30", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x649F4C0", Offset = "0x649E8C0", VA = "0x18649F4C0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x649B750", Offset = "0x649AB50", VA = "0x18649B750", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x649FB50", Offset = "0x649EF50", VA = "0x18649FB50", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x649B430", Offset = "0x649A830", VA = "0x18649B430", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HNCBAAEKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x649DCE0", Offset = "0x649D0E0", VA = "0x18649DCE0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NBEHJKEPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x649C8B0", Offset = "0x649BCB0", VA = "0x18649C8B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MCIBCBADMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x649E0C0", Offset = "0x649D4C0", VA = "0x18649E0C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x649CB10", Offset = "0x649BF10", VA = "0x18649CB10", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x64A03B0", Offset = "0x649F7B0", VA = "0x1864A03B0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x649FD10", Offset = "0x649F110", VA = "0x18649FD10", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 FNCHPDKGGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x649B0A0", Offset = "0x649A4A0", VA = "0x18649B0A0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x649D5A0", Offset = "0x649C9A0", VA = "0x18649D5A0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x649FDF0", Offset = "0x649F1F0", VA = "0x18649FDF0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x649C150", Offset = "0x649B550", VA = "0x18649C150", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x649FED0", Offset = "0x649F2D0", VA = "0x18649FED0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x649F6E0", Offset = "0x649EAE0", VA = "0x18649F6E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x649DEF0", Offset = "0x649D2F0", VA = "0x18649DEF0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x649D7C0", Offset = "0x649CBC0", VA = "0x18649D7C0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x649C6E0", Offset = "0x649BAE0", VA = "0x18649C6E0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x649C850", Offset = "0x649BC50", VA = "0x18649C850", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x649DDE0", Offset = "0x649D1E0", VA = "0x18649DDE0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x649EF30", Offset = "0x649E330", VA = "0x18649EF30", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x649B180", Offset = "0x649A580", VA = "0x18649B180", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x649AD30", Offset = "0x649A130", VA = "0x18649AD30", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x649D070", Offset = "0x649C470", VA = "0x18649D070", Slot = "48")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x649C0F0", Offset = "0x649B4F0", VA = "0x18649C0F0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x649CF70", Offset = "0x649C370", VA = "0x18649CF70", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform AEBPFLDNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x649EFE0", Offset = "0x649E3E0", VA = "0x18649EFE0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 EJHPLDIOGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x649D200", Offset = "0x649C600", VA = "0x18649D200", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x649E870", Offset = "0x649DC70", VA = "0x18649E870", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float EKKBIDCLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x649D750", Offset = "0x649CB50", VA = "0x18649D750", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x649FF20", Offset = "0x649F320", VA = "0x18649FF20", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float BCBNNPNHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x649D8E0", Offset = "0x649CCE0", VA = "0x18649D8E0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x649CA10", Offset = "0x649BE10", VA = "0x18649CA10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion BNPPAIPFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x649EB90", Offset = "0x649DF90", VA = "0x18649EB90", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x649E480", Offset = "0x649D880", VA = "0x18649E480", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 CMOOOBHDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x649D890", Offset = "0x649CC90", VA = "0x18649D890", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x649DAF0", Offset = "0x649CEF0", VA = "0x18649DAF0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion KFNAMDFIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x649B060", Offset = "0x649A460", VA = "0x18649B060", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x649BFA0", Offset = "0x649B3A0", VA = "0x18649BFA0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x649F7E0", Offset = "0x649EBE0", VA = "0x18649F7E0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x649F9F0", Offset = "0x649EDF0", VA = "0x18649F9F0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x649DB40", Offset = "0x649CF40", VA = "0x18649DB40", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x649E280", Offset = "0x649D680", VA = "0x18649E280", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x649CFC0", Offset = "0x649C3C0", VA = "0x18649CFC0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x649E6B0", Offset = "0x649DAB0", VA = "0x18649E6B0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x649B8E0", Offset = "0x649ACE0", VA = "0x18649B8E0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CHLEIHFIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x649FFF0", Offset = "0x649F3F0", VA = "0x18649FFF0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DBBIGMIPKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x649F740", Offset = "0x649EB40", VA = "0x18649F740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool CEALBENFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x649ADF0", Offset = "0x649A1F0", VA = "0x18649ADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x649D0C0", Offset = "0x649C4C0", VA = "0x18649D0C0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x649C030", Offset = "0x649B430", VA = "0x18649C030", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x649D900", Offset = "0x649CD00", VA = "0x18649D900", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x649BA80", Offset = "0x649AE80", VA = "0x18649BA80", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x649ED00", Offset = "0x649E100", VA = "0x18649ED00", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x649B000", Offset = "0x649A400", VA = "0x18649B000", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x649B830", Offset = "0x649AC30", VA = "0x18649B830", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x649D010", Offset = "0x649C410", VA = "0x18649D010", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event DNJOPMKHNNE GFGINGLKOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x649ED60", Offset = "0x649E160", VA = "0x18649ED60", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x649C4B0", Offset = "0x649B8B0", VA = "0x18649C4B0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x649E2E0", Offset = "0x649D6E0", VA = "0x18649E2E0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x64A04D0", Offset = "0x649F8D0", VA = "0x1864A04D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x649E570", Offset = "0x649D970", VA = "0x18649E570", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x64A0730", Offset = "0x649FB30", VA = "0x1864A0730", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x649BA20", Offset = "0x649AE20", VA = "0x18649BA20", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x649B3D0", Offset = "0x649A7D0", VA = "0x18649B3D0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event DNJOPMKHNNE MEDPIFKLBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x649E9D0", Offset = "0x649DDD0", VA = "0x18649E9D0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x649C1A0", Offset = "0x649B5A0", VA = "0x18649C1A0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x64A0BF0", Offset = "0x649FFF0", VA = "0x1864A0BF0")]
	public AILGKJKAAEF(GameObject IPBNGJILMJD, RigidbodyEx NDNJKOKFFPH, GJHHKNJJGHJ FKFIJGNHDJN, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x649D2B0", Offset = "0x649C6B0", VA = "0x18649D2B0", Slot = "135")]
	protected virtual void FGDICDGKAOC(GJHHKNJJGHJ FKFIJGNHDJN, DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x649C730", Offset = "0x649BB30", VA = "0x18649C730", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x649E340", Offset = "0x649D740", VA = "0x18649E340", Slot = "71")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x649BBE0", Offset = "0x649AFE0", VA = "0x18649BBE0", Slot = "72")]
	public void DIOOOFBHOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64A05D0", Offset = "0x649F9D0", VA = "0x1864A05D0", Slot = "73")]
	public void PAGPBFBNJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x649DD30", Offset = "0x649D130", VA = "0x18649DD30")]
	private void GOMIOHKPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x649F5A0", Offset = "0x649E9A0", VA = "0x18649F5A0", Slot = "81")]
	public void LHFBBPLCKMM(MAJKPDGOFIP FDFHGIHHGHO, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x649EB30", Offset = "0x649DF30", VA = "0x18649EB30", Slot = "84")]
	public void KFAFHPPMDDC(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x64A0170", Offset = "0x649F570", VA = "0x1864A0170", Slot = "85")]
	public void NMKMPKOOKND(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x649BAE0", Offset = "0x649AEE0", VA = "0x18649BAE0", Slot = "86")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x649B220", Offset = "0x649A620", VA = "0x18649B220", Slot = "87")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x649BBE0", Offset = "0x649AFE0", VA = "0x18649BBE0", Slot = "88")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x64A01D0", Offset = "0x649F5D0", VA = "0x1864A01D0", Slot = "89")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x649C2B0", Offset = "0x649B6B0", VA = "0x18649C2B0", Slot = "90")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x64A0A70", Offset = "0x649FE70", VA = "0x1864A0A70", Slot = "91")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x649DFD0", Offset = "0x649D3D0", VA = "0x18649DFD0", Slot = "92")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x649F910", Offset = "0x649ED10", VA = "0x18649F910", Slot = "93")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x649DE30", Offset = "0x649D230", VA = "0x18649DE30", Slot = "94")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x64A0530", Offset = "0x649F930", VA = "0x1864A0530", Slot = "95")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x64A0220", Offset = "0x649F620", VA = "0x1864A0220", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x649C910", Offset = "0x649BD10", VA = "0x18649C910", Slot = "97")]
	public Vector3 EIHCMHAJKJG(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x649F360", Offset = "0x649E760", VA = "0x18649F360", Slot = "98")]
	public Vector3 LGEBFJGHFCF(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x649E7B0", Offset = "0x649DBB0", VA = "0x18649E7B0", Slot = "99")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x649C570", Offset = "0x649B970", VA = "0x18649C570", Slot = "100")]
	public void DNEAKKOPNPN(MAJKPDGOFIP PCNBBBLPPLP, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x649C510", Offset = "0x649B910", VA = "0x18649C510", Slot = "101")]
	public void DNAHEDKPNGN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x649F830", Offset = "0x649EC30", VA = "0x18649F830", Slot = "41")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x649C300", Offset = "0x649B700", VA = "0x18649C300", Slot = "104")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x649E230", Offset = "0x649D630", VA = "0x18649E230", Slot = "105")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x649D770", Offset = "0x649CB70", VA = "0x18649D770", Slot = "106")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x649E930", Offset = "0x649DD30", VA = "0x18649E930", Slot = "109")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x649B1D0", Offset = "0x649A5D0", VA = "0x18649B1D0", Slot = "74")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x64A0B60", Offset = "0x649FF60", VA = "0x1864A0B60", Slot = "110")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x649B380", Offset = "0x649A780", VA = "0x18649B380", Slot = "115")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x649FA50", Offset = "0x649EE50", VA = "0x18649FA50", Slot = "116")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x649EC40", Offset = "0x649E040", VA = "0x18649EC40", Slot = "117")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x649E800", Offset = "0x649DC00", VA = "0x18649E800", Slot = "118")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x64A0870", Offset = "0x649FC70", VA = "0x1864A0870", Slot = "121")]
	public void PGOJGMBCEIJ(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x649DB90", Offset = "0x649CF90", VA = "0x18649DB90", Slot = "122")]
	public void GJOLMILDMFJ(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x649EAD0", Offset = "0x649DED0", VA = "0x18649EAD0", Slot = "123")]
	public bool KDDIFOEDMNO(float NJPICGCBCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x649CC70", Offset = "0x649C070", VA = "0x18649CC70", Slot = "124")]
	public void EPAHJGAPKEL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x649AD90", Offset = "0x649A190", VA = "0x18649AD90", Slot = "125")]
	public void AEPMFPNLHJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x649C090", Offset = "0x649B490", VA = "0x18649C090", Slot = "126")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x64A06D0", Offset = "0x649FAD0", VA = "0x1864A06D0", Slot = "127")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x649E5D0", Offset = "0x649D9D0", VA = "0x18649E5D0", Slot = "128")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x649CB60", Offset = "0x649BF60", VA = "0x18649CB60", Slot = "129")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x64A0790", Offset = "0x649FB90", VA = "0x1864A0790", Slot = "130")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x64A02D0", Offset = "0x649F6D0", VA = "0x1864A02D0", Slot = "131")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x649FAB0", Offset = "0x649EEB0", VA = "0x18649FAB0", Slot = "132")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x649EF90", Offset = "0x649E390", VA = "0x18649EF90", Slot = "133")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x64A0BB0", Offset = "0x649FFB0", VA = "0x1864A0BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x649D960", Offset = "0x649CD60", VA = "0x18649D960")]
	private void GBKMMJFCEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x649C350", Offset = "0x649B750", VA = "0x18649C350")]
	private void DJCBBOGLEFL(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x649B560", Offset = "0x649A960", VA = "0x18649B560")]
	private void BMODNBGNLDI(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x649DA40", Offset = "0x649CE40", VA = "0x18649DA40")]
	private void GFPKNACPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x649C5E0", Offset = "0x649B9E0", VA = "0x18649C5E0")]
	private void DNINOAMJFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x649AE20", Offset = "0x649A220", VA = "0x18649AE20")]
	private void AHLNMJPJNJE(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x649D680", Offset = "0x649CA80", VA = "0x18649D680")]
	private void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x649F610", Offset = "0x649EA10", VA = "0x18649F610")]
	private void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x649EDC0", Offset = "0x649E1C0", VA = "0x18649EDC0")]
	private void KMCAJNHCAFK(RigidbodyEx BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x649CDB0", Offset = "0x649C1B0", VA = "0x18649CDB0", Slot = "140")]
	protected virtual void FADAJDJBGKJ(RigidbodyEx EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x649BC80", Offset = "0x649B080", VA = "0x18649BC80")]
	protected void CKBELDMGOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x649EFF0", Offset = "0x649E3F0", VA = "0x18649EFF0")]
	protected void LCAHOHMKPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x649E710", Offset = "0x649DB10", VA = "0x18649E710", Slot = "141")]
	protected virtual IDisposable JCBNBIEHPJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OJNMAIHDCLH
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x64B9D40", Offset = "0x64B9140", VA = "0x1864B9D40")]
	public static MAJKPDGOFIP IOCFJOIMBIE(this MAJKPDGOFIP EIDKMOICLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x64B9E70", Offset = "0x64B9270", VA = "0x1864B9E70")]
	public static bool KADKDBFBMCH(this MAJKPDGOFIP EIDKMOICLKH, MAJKPDGOFIP CEOKLDNCPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x64B9DF0", Offset = "0x64B91F0", VA = "0x1864B9DF0")]
	public static bool JCHIKJPBCEL(this MAJKPDGOFIP EIDKMOICLKH, MAJKPDGOFIP DCIOCCFCEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x64B9CF0", Offset = "0x64B90F0", VA = "0x1864B9CF0")]
	public static RigidbodyEx IBGHAOFBCML(this MAJKPDGOFIP EFMEBNACKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x64B9EF0", Offset = "0x64B92F0", VA = "0x1864B9EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64B3600", Offset = "0x64B2A00", VA = "0x1864B3600")]
	public KLBLBHKPANP(AILGKJKAAEF FEDGKNJBNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x64B35A0", Offset = "0x64B29A0", VA = "0x1864B35A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A9CE0", Offset = "0x64A90E0", VA = "0x1864A9CE0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x64A9530", Offset = "0x64A8930", VA = "0x1864A9530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x64A95F0", Offset = "0x64A89F0", VA = "0x1864A95F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x64A9860", Offset = "0x64A8C60", VA = "0x1864A9860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public ELNKMDFGKPN(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x64A9710", Offset = "0x64A8B10", VA = "0x1864A9710", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x64A9920", Offset = "0x64A8D20", VA = "0x1864A9920", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x64A9A00", Offset = "0x64A8E00", VA = "0x1864A9A00", Slot = "7")]
	public void JLKFIBOGPPC(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x64A9700", Offset = "0x64A8B00", VA = "0x1864A9700", Slot = "8")]
	public void FDDBKGEBAAG(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x64A9A10", Offset = "0x64A8E10", VA = "0x1864A9A10", Slot = "10")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x64A9B70", Offset = "0x64A8F70", VA = "0x1864A9B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B4FE0", Offset = "0x64B43E0", VA = "0x1864B4FE0")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x64B4EF0", Offset = "0x64B42F0", VA = "0x1864B4EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x64B50C0", Offset = "0x64B44C0", VA = "0x1864B50C0", Slot = "6")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x64B4EF0", Offset = "0x64B42F0", VA = "0x1864B4EF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform ALHIKPNAMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x64B52C0", Offset = "0x64B46C0", VA = "0x1864B52C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x64B5390", Offset = "0x64B4790", VA = "0x1864B5390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public LHPAIDOCAPF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x64B5370", Offset = "0x64B4770", VA = "0x1864B5370", Slot = "11")]
	public void OnChangedDistanceBand(FOIDAKOAIBK LBLICGCEGPF, FOIDAKOAIBK BOJOHLNAOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "12")]
	public void OnChangedVisibility(bool MFCCDKLMMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x64BC430", Offset = "0x64BB830", VA = "0x1864BC430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x64A62F0", Offset = "0x64A56F0", VA = "0x1864A62F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x64BDD00", Offset = "0x64BD100", VA = "0x1864BDD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public PDKBAFLPOJM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x64BDBA0", Offset = "0x64BCFA0", VA = "0x1864BDBA0", Slot = "4")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x64BD8C0", Offset = "0x64BCCC0", VA = "0x1864BD8C0")]
	private void FGLGDIKCEBD(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x64BD640", Offset = "0x64BCA40", VA = "0x1864BD640", Slot = "5")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x64BDFC0", Offset = "0x64BD3C0", VA = "0x1864BDFC0", Slot = "6")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x64BD3E0", Offset = "0x64BC7E0", VA = "0x1864BD3E0")]
	private void CLOOBCLMBBL(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x64BDD60", Offset = "0x64BD160", VA = "0x1864BDD60", Slot = "7")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x64BD300", Offset = "0x64BC700", VA = "0x1864BD300")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A0E70", Offset = "0x64A0270", VA = "0x1864A0E70", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x64A0D20", Offset = "0x64A0120", VA = "0x1864A0D20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public APHKPALJIFJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x64A0F40", Offset = "0x64A0340", VA = "0x1864A0F40", Slot = "6")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x64A0ED0", Offset = "0x64A02D0", VA = "0x1864A0ED0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A7DB0", Offset = "0x64A71B0", VA = "0x1864A7DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GKGLPFGLEMO NEJLNNHDLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x64A8280", Offset = "0x64A7680", VA = "0x1864A8280")]
		get
		{
			return default(GKGLPFGLEMO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x64A79F0", Offset = "0x64A6DF0", VA = "0x1864A79F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x64A7F80", Offset = "0x64A7380", VA = "0x1864A7F80", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x64A80A0", Offset = "0x64A74A0", VA = "0x1864A80A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public GKGLPFGLEMO KJLCEPDJECK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x64A7CB0", Offset = "0x64A70B0", VA = "0x1864A7CB0")]
		get
		{
			return default(GKGLPFGLEMO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x64A7C40", Offset = "0x64A7040", VA = "0x1864A7C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x64A78E0", Offset = "0x64A6CE0", VA = "0x1864A78E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x64A7A60", Offset = "0x64A6E60", VA = "0x1864A7A60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x64A7500", Offset = "0x64A6900", VA = "0x1864A7500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x64A7BA0", Offset = "0x64A6FA0", VA = "0x1864A7BA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x64A7160", Offset = "0x64A6560", VA = "0x1864A7160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x64A8110", Offset = "0x64A7510", VA = "0x1864A8110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x64A6EE0", Offset = "0x64A62E0", VA = "0x1864A6EE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PKJCEJABLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x64A82E0", Offset = "0x64A76E0", VA = "0x1864A82E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x64A70C0", Offset = "0x64A64C0", VA = "0x1864A70C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action CMPLOJBIIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x64A7950", Offset = "0x64A6D50", VA = "0x1864A7950", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x64A8560", Offset = "0x64A7960", VA = "0x1864A8560", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<MAJKPDGOFIP> OFCPNIALKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x64A75A0", Offset = "0x64A69A0", VA = "0x1864A75A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x64A7DE0", Offset = "0x64A71E0", VA = "0x1864A7DE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<MAJKPDGOFIP> AGODGBDNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x64A7200", Offset = "0x64A6600", VA = "0x1864A7200", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x64A7650", Offset = "0x64A6A50", VA = "0x1864A7650", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JGHIJKFKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x64A7B00", Offset = "0x64A6F00", VA = "0x1864A7B00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x64A7D10", Offset = "0x64A7110", VA = "0x1864A7D10", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<MAJKPDGOFIP> LIMPBIPJFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x64A7FF0", Offset = "0x64A73F0", VA = "0x1864A7FF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x64A7700", Offset = "0x64A6B00", VA = "0x1864A7700", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x64A8690", Offset = "0x64A7A90", VA = "0x1864A8690")]
	public DHOEGCPHLHK(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x64A77B0", Offset = "0x64A6BB0", VA = "0x1864A77B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x64A8200", Offset = "0x64A7600", VA = "0x1864A8200", Slot = "26")]
	public void LHFBBPLCKMM(MAJKPDGOFIP ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x64A81B0", Offset = "0x64A75B0", VA = "0x1864A81B0")]
	private void LHFBBPLCKMM(JBKHFACBNGN ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x64A6A60", Offset = "0x64A5E60", VA = "0x1864A6A60")]
	private void AHOIJLKJGCO(JBKHFACBNGN ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x64A72B0", Offset = "0x64A66B0", VA = "0x1864A72B0")]
	private void CLBHIGEBNEK(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x64A6860", Offset = "0x64A5C60", VA = "0x1864A6860")]
	private void ABKMGAGMHCJ(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x64A8380", Offset = "0x64A7780", VA = "0x1864A8380")]
	private void OBNHKAHBGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x64A67B0", Offset = "0x64A5BB0", VA = "0x1864A67B0")]
	private void AAEABLPOAPB(JBKHFACBNGN DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x64A7E90", Offset = "0x64A7290", VA = "0x1864A7E90")]
	private void IMKPOOHCDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x64A7020", Offset = "0x64A6420", VA = "0x1864A7020")]
	private void AMKDDMPMJOF(JBKHFACBNGN EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x64A6F80", Offset = "0x64A6380", VA = "0x1864A6F80")]
	private void AJCPOEFKKBF(JBKHFACBNGN EIDKMOICLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LPCPCNBGBOM
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x64B5440", Offset = "0x64B4840", VA = "0x1864B5440")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B16C0", Offset = "0x64B0AC0", VA = "0x1864B16C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x64B1490", Offset = "0x64B0890", VA = "0x1864B1490", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x64B13A0", Offset = "0x64B07A0", VA = "0x1864B13A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private MAJKPDGOFIP JIHACKDFFND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x64B1240", Offset = "0x64B0640", VA = "0x1864B1240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public JEHAJPJFEJM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x64B0BD0", Offset = "0x64AFFD0", VA = "0x1864B0BD0", Slot = "6")]
	public void HMADCOJHFBN(MAJKPDGOFIP BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x64B0D20", Offset = "0x64B0120", VA = "0x1864B0D20")]
	private void HMADCOJHFBN(JBKHFACBNGN BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x64B0B60", Offset = "0x64AFF60", VA = "0x1864B0B60", Slot = "7")]
	public void CLGAMCCOJJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x64B0E30", Offset = "0x64B0230", VA = "0x1864B0E30")]
	private Vector3 IOOBHAOLFBD()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class FCEKGHHHOKD
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x64AD700", Offset = "0x64ACB00", VA = "0x1864AD700")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A9D40", Offset = "0x64A9140", VA = "0x1864A9D40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x64AA650", Offset = "0x64A9A50", VA = "0x1864AA650", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 ANJOAJCDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x64AA990", Offset = "0x64A9D90", VA = "0x1864AA990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 HBCMEOBPOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x64AA7D0", Offset = "0x64A9BD0", VA = "0x1864AA7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x64ABE40", Offset = "0x64AB240", VA = "0x1864ABE40", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64AA1E0", Offset = "0x64A95E0", VA = "0x1864AA1E0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HFLJMKGNHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x64ABD20", Offset = "0x64AB120", VA = "0x1864ABD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x64AC030", Offset = "0x64AB430", VA = "0x1864AC030", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x64AB790", Offset = "0x64AAB90", VA = "0x1864AB790", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x64AAA40", Offset = "0x64A9E40", VA = "0x1864AAA40", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x64AA960", Offset = "0x64A9D60", VA = "0x1864AA960", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event DNJOPMKHNNE KHEKPLMFOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x64ABDA0", Offset = "0x64AB1A0", VA = "0x1864ABDA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x64AADC0", Offset = "0x64AA1C0", VA = "0x1864AADC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x64AD410", Offset = "0x64AC810", VA = "0x1864AD410")]
	public FBJDABJMEFO(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x64AC090", Offset = "0x64AB490", VA = "0x1864AC090")]
	public float3 NOKGIHFBGHA()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x64ABA90", Offset = "0x64AAE90", VA = "0x1864ABA90", Slot = "14")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x64AA240", Offset = "0x64A9640", VA = "0x1864AA240", Slot = "16")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x64AAA70", Offset = "0x64A9E70", VA = "0x1864AAA70", Slot = "15")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x64AAE60", Offset = "0x64AA260", VA = "0x1864AAE60", Slot = "18")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x64A9DF0", Offset = "0x64A91F0", VA = "0x1864A9DF0", Slot = "19")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x64AA900", Offset = "0x64A9D00", VA = "0x1864AA900", Slot = "17")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x64AAF30", Offset = "0x64AA330", VA = "0x1864AAF30", Slot = "20")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x64AA610", Offset = "0x64A9A10", VA = "0x1864AA610")]
	public void EHMJHLMKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x64AA650", Offset = "0x64A9A50", VA = "0x1864AA650")]
	private void KPOINAHOGEO(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x64AA430", Offset = "0x64A9830", VA = "0x1864AA430")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 EEOIDLAPKIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x64AB790", Offset = "0x64AAB90", VA = "0x1864AB790")]
	private void NIKGHCLKAIL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x64AB530", Offset = "0x64AA930", VA = "0x1864AB530")]
	private Vector3 KPOEDKBLEDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x64AB850", Offset = "0x64AAC50", VA = "0x1864AB850")]
	private Quaternion LOBMBBFJGFI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x64AC1B0", Offset = "0x64AB5B0", VA = "0x1864AC1B0")]
	internal (float, Vector3) PIIOGOHJCCF(Rigidbody OLBBNJBKMLC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class KMCODNPMNEK
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x64B3680", Offset = "0x64B2A80", VA = "0x1864B3680")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B3BF0", Offset = "0x64B2FF0", VA = "0x1864B3BF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DPMKPOINNGM KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x64B3A30", Offset = "0x64B2E30", VA = "0x1864B3A30", Slot = "11")]
		get
		{
			return default(DPMKPOINNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private DPMKPOINNGM PKDOAGKIFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x64B3A30", Offset = "0x64B2E30", VA = "0x1864B3A30")]
		get
		{
			return default(DPMKPOINNGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x64B39C0", Offset = "0x64B2DC0", VA = "0x1864B39C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x64B42D0", Offset = "0x64B36D0", VA = "0x1864B42D0")]
	public LFOGHHGBHAG(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x64B3DD0", Offset = "0x64B31D0", VA = "0x1864B3DD0", Slot = "4")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x64B4170", Offset = "0x64B3570", VA = "0x1864B4170")]
	private bool OCIHJNLKONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x64B4250", Offset = "0x64B3650", VA = "0x1864B4250", Slot = "5")]
	public void PFDPGHHPDCI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x64B40F0", Offset = "0x64B34F0", VA = "0x1864B40F0", Slot = "6")]
	public void NECCIEDFAJN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x64B3A90", Offset = "0x64B2E90", VA = "0x1864B3A90", Slot = "9")]
	public void FNPLNNGPHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x64B3C50", Offset = "0x64B3050", VA = "0x1864B3C50")]
	private void HBGHIFEGEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x64B3F50", Offset = "0x64B3350", VA = "0x1864B3F50")]
	private void KLBKGKOABLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x64B3ED0", Offset = "0x64B32D0", VA = "0x1864B3ED0", Slot = "8")]
	public void JNOGIAHPMMB(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x64B3D50", Offset = "0x64B3150", VA = "0x1864B3D50", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x64AEC00", Offset = "0x64AE000", VA = "0x1864AEC00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool OKJLKBAKGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x64AE910", Offset = "0x64ADD10", VA = "0x1864AE910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x64AEA80", Offset = "0x64ADE80", VA = "0x1864AEA80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x64AE9E0", Offset = "0x64ADDE0", VA = "0x1864AE9E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public GIBOGHJHHEP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x64AE970", Offset = "0x64ADD70", VA = "0x1864AE970", Slot = "11")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x64AEE50", Offset = "0x64AE250", VA = "0x1864AEE50", Slot = "8")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x64AEE40", Offset = "0x64AE240", VA = "0x1864AEE40", Slot = "9")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x64AED40", Offset = "0x64AE140", VA = "0x1864AED40", Slot = "10")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x64AEC60", Offset = "0x64AE060", VA = "0x1864AEC60", Slot = "12")]
	public void JFLFNNOBHDI(Rigidbody HELFJOICHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x64AEB20", Offset = "0x64ADF20", VA = "0x1864AEB20", Slot = "13")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x64AA610", Offset = "0x64A9A10", VA = "0x1864AA610", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x64AD830", Offset = "0x64ACC30", VA = "0x1864AD830", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x64B9580", Offset = "0x64B8980", VA = "0x1864B9580", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x64B8CA0", Offset = "0x64B80A0", VA = "0x1864B8CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x64B9060", Offset = "0x64B8460", VA = "0x1864B9060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x64B99F0", Offset = "0x64B8DF0", VA = "0x1864B99F0")]
	public MOMLHHOMBHD(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x64B9450", Offset = "0x64B8850", VA = "0x1864B9450", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x64B8F00", Offset = "0x64B8300", VA = "0x1864B8F00", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x64B9100", Offset = "0x64B8500", VA = "0x1864B9100", Slot = "9")]
	public void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x64B9610", Offset = "0x64B8A10", VA = "0x1864B9610", Slot = "10")]
	public void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x64B9810", Offset = "0x64B8C10", VA = "0x1864B9810")]
	private void LMIMMMDKBPG(PhotonView INLELPGOKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x64B9300", Offset = "0x64B8700", VA = "0x1864B9300")]
	private void FNBDCNCNNLC(RigidbodyEx FFLMFPGCDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x64B8D40", Offset = "0x64B8140", VA = "0x1864B8D40")]
	private void CMOEOOFMHIA(PhotonView IMEOGBMMBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class AKHMPBODLBJ
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x64A0CC0", Offset = "0x64A00C0", VA = "0x1864A0CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BCDE0", Offset = "0x64BC1E0", VA = "0x1864BCDE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x64BCE40", Offset = "0x64BC240", VA = "0x1864BCE40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IBOKPHKBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x64BCD00", Offset = "0x64BC100", VA = "0x1864BCD00", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x64BD120", Offset = "0x64BC520", VA = "0x1864BD120")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x64BCF40", Offset = "0x64BC340", VA = "0x1864BCF40", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x64BCFA0", Offset = "0x64BC3A0", VA = "0x1864BCFA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x64BD190", Offset = "0x64BC590", VA = "0x1864BD190")]
	public PAGKAIEHDFN(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x64BCEB0", Offset = "0x64BC2B0", VA = "0x1864BCEB0", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x64BCD60", Offset = "0x64BC160", VA = "0x1864BCD60", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64AE4C0", Offset = "0x64AD8C0", VA = "0x1864AE4C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x64AE520", Offset = "0x64AD920", VA = "0x1864AE520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x64AE670", Offset = "0x64ADA70", VA = "0x1864AE670", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x64AE7C0", Offset = "0x64ADBC0", VA = "0x1864AE7C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public GHICOPBMLEK(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x64AE6D0", Offset = "0x64ADAD0", VA = "0x1864AE6D0", Slot = "8")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x64AE3F0", Offset = "0x64AD7F0", VA = "0x1864AE3F0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x64AF110", Offset = "0x64AE510", VA = "0x1864AF110", Slot = "4")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x64AF0E0", Offset = "0x64AE4E0", VA = "0x1864AF0E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x64AF7B0", Offset = "0x64AEBB0", VA = "0x1864AF7B0", Slot = "6")]
	public void PIIOGOHJCCF(GKGLPFGLEMO MJOMEKCECMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x64AF390", Offset = "0x64AE790", VA = "0x1864AF390", Slot = "7")]
	public void MOEJMPLFKJO(GKGLPFGLEMO MJOMEKCECMJ, bool PGNIJNCMLPK, bool GGNNAADIEJI, bool MGLBFLAIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x64AF5B0", Offset = "0x64AE9B0", VA = "0x1864AF5B0", Slot = "8")]
	public void NDEKBMEPGPM(GKGLPFGLEMO MJOMEKCECMJ, float3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x64AF160", Offset = "0x64AE560", VA = "0x1864AF160", Slot = "9")]
	public void JPJAPLNIABH(GKGLPFGLEMO MJOMEKCECMJ, float3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x64AF6F0", Offset = "0x64AEAF0", VA = "0x1864AF6F0")]
	private bool NHGHBHIAGFM(GKGLPFGLEMO MJOMEKCECMJ, [Out] JBKHFACBNGN CEBGEIIIEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x64AEFF0", Offset = "0x64AE3F0", VA = "0x1864AEFF0")]
	private bool AKCAIAFEMID(GKGLPFGLEMO MJOMEKCECMJ, [Out] FBJDABJMEFO DOCACHDOLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x64AF2A0", Offset = "0x64AE6A0", VA = "0x1864AF2A0")]
	private bool MIGKNELEKOO(GKGLPFGLEMO MJOMEKCECMJ, [Out] BDOPMCMEHIO MIEAGJGKPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x64A15F0", Offset = "0x64A09F0", VA = "0x1864A15F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x64B4A40", Offset = "0x64B3E40", VA = "0x1864B4A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x64B4B10", Offset = "0x64B3F10", VA = "0x1864B4B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool LILIFKJCNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x64B43E0", Offset = "0x64B37E0", VA = "0x1864B43E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x64B4610", Offset = "0x64B3A10", VA = "0x1864B4610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool PLADKMOGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x64B46F0", Offset = "0x64B3AF0", VA = "0x1864B46F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x64B4680", Offset = "0x64B3A80", VA = "0x1864B4680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int CMIPKFCFKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x64B4AA0", Offset = "0x64B3EA0", VA = "0x1864B4AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x64B4750", Offset = "0x64B3B50", VA = "0x1864B4750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x64B4BE0", Offset = "0x64B3FE0", VA = "0x1864B4BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x64B4DC0", Offset = "0x64B41C0", VA = "0x1864B4DC0")]
	public LGBIPDKEGPM(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x64B47F0", Offset = "0x64B3BF0", VA = "0x1864B47F0", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x64B4B70", Offset = "0x64B3F70", VA = "0x1864B4B70", Slot = "8")]
	public void NNKNDHMONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x64B48A0", Offset = "0x64B3CA0", VA = "0x1864B48A0", Slot = "7")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x64B4440", Offset = "0x64B3840", VA = "0x1864B4440", Slot = "9")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64AA610", Offset = "0x64A9A10", VA = "0x1864AA610", Slot = "12")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x64B4C80", Offset = "0x64B4080", VA = "0x1864B4C80", Slot = "11")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "10")]
	public void IAGIIJPJGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x64B4530", Offset = "0x64B3930", VA = "0x1864B4530")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A59C0", Offset = "0x64A4DC0", VA = "0x1864A59C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x64A61A0", Offset = "0x64A55A0", VA = "0x1864A61A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x64A62F0", Offset = "0x64A56F0", VA = "0x1864A62F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool IKKIFPPLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x64A6290", Offset = "0x64A5690", VA = "0x1864A6290", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x64A63D0", Offset = "0x64A57D0", VA = "0x1864A63D0")]
	public CPMLGDJNGCE(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x64A5E90", Offset = "0x64A5290", VA = "0x1864A5E90", Slot = "5")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x64A5940", Offset = "0x64A4D40", VA = "0x1864A5940", Slot = "7")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x64A6350", Offset = "0x64A5750", VA = "0x1864A6350", Slot = "8")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x64A5C70", Offset = "0x64A5070", VA = "0x1864A5C70", Slot = "9")]
	public void HEECMNKNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x64A5F40", Offset = "0x64A5340", VA = "0x1864A5F40", Slot = "11")]
	public void LBENDJNHIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x64A5AA0", Offset = "0x64A4EA0", VA = "0x1864A5AA0", Slot = "12")]
	public void GEGBCJPHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A46F0", Offset = "0x64A3AF0", VA = "0x1864A46F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x64A3E80", Offset = "0x64A3280", VA = "0x1864A3E80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x64A1540", Offset = "0x64A0940", VA = "0x1864A1540", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x64A1350", Offset = "0x64A0750", VA = "0x1864A1350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x64A3EF0", Offset = "0x64A32F0", VA = "0x1864A3EF0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x64A1480", Offset = "0x64A0880", VA = "0x1864A1480", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x64A2DD0", Offset = "0x64A21D0", VA = "0x1864A2DD0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x64A4A50", Offset = "0x64A3E50", VA = "0x1864A4A50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x64A4190", Offset = "0x64A3590", VA = "0x1864A4190", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x64A13C0", Offset = "0x64A07C0", VA = "0x1864A13C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x64A2DA0", Offset = "0x64A21A0", VA = "0x1864A2DA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x64A41F0", Offset = "0x64A35F0", VA = "0x1864A41F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x64A18A0", Offset = "0x64A0CA0", VA = "0x1864A18A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x64A2140", Offset = "0x64A1540", VA = "0x1864A2140", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x64A2AC0", Offset = "0x64A1EC0", VA = "0x1864A2AC0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private HPCAIPJONDJ HGNCDNNOBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5E50", Offset = "0x5DF5250", VA = "0x185DF5E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x64A15F0", Offset = "0x64A09F0", VA = "0x1864A15F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public BDOPMCMEHIO(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x64A3F50", Offset = "0x64A3350", VA = "0x1864A3F50", Slot = "20")]
	public void MGENLKFCOPL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x64A3370", Offset = "0x64A2770", VA = "0x1864A3370", Slot = "30")]
	public void HKALPDNOFGF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x64A17F0", Offset = "0x64A0BF0", VA = "0x1864A17F0", Slot = "19")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x64A2870", Offset = "0x64A1C70", VA = "0x1864A2870", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x64A3B40", Offset = "0x64A2F40", VA = "0x1864A3B40", Slot = "28")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x64A1610", Offset = "0x64A0A10", VA = "0x1864A1610", Slot = "35")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x64A1130", Offset = "0x64A0530", VA = "0x1864A1130", Slot = "34")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x64A17F0", Offset = "0x64A0BF0", VA = "0x1864A17F0", Slot = "27")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x64A4220", Offset = "0x64A3620", VA = "0x1864A4220", Slot = "25")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x64A2290", Offset = "0x64A1690", VA = "0x1864A2290", Slot = "24")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x64A4A80", Offset = "0x64A3E80", VA = "0x1864A4A80", Slot = "33")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x64A33E0", Offset = "0x64A27E0", VA = "0x1864A33E0", Slot = "32")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x64A3FC0", Offset = "0x64A33C0", VA = "0x1864A3FC0", Slot = "31")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x64A2E00", Offset = "0x64A2200", VA = "0x1864A2E00", Slot = "22")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x64A47A0", Offset = "0x64A3BA0", VA = "0x1864A47A0", Slot = "21")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x64A42E0", Offset = "0x64A36E0", VA = "0x1864A42E0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x64A29E0", Offset = "0x64A1DE0", VA = "0x1864A29E0", Slot = "29")]
	public Vector3 EIHCMHAJKJG(Vector3 HLPPLJDPLMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x64A39B0", Offset = "0x64A2DB0", VA = "0x1864A39B0", Slot = "26")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x64A2140", Offset = "0x64A1540", VA = "0x1864A2140")]
	private void GMKAMDEIKLJ(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x64A3CB0", Offset = "0x64A30B0", VA = "0x1864A3CB0")]
	private void LDFNFKHOCFM(Vector3 HOAINBKFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x64A2B20", Offset = "0x64A1F20", VA = "0x1864A2B20")]
	private Vector3 ENABOCDHLAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x64A22F0", Offset = "0x64A16F0", VA = "0x1864A22F0")]
	private void DHLCFCLNLBP(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x64A1EB0", Offset = "0x64A12B0", VA = "0x1864A1EB0")]
	private Vector3 COMDNKHKCIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x64A3440", Offset = "0x64A2840", VA = "0x1864A3440")]
	private void IBBJPBFGACI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x64A12F0", Offset = "0x64A06F0", VA = "0x1864A12F0")]
	private void BHFFIHFMHLA(Vector3 HLPPLJDPLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x64A4280", Offset = "0x64A3680", VA = "0x1864A4280")]
	private void NNPPGONHLPL(Vector3 JHBLCBJMNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x64A1900", Offset = "0x64A0D00", VA = "0x1864A1900")]
	private void CJEKDGJPDEH(string HFFACCPGHJD, Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x64A2930", Offset = "0x64A1D30", VA = "0x1864A2930")]
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
		[Cpp2IlInjected.Address(RVA = "0x55C5D00", Offset = "0x55C5100", VA = "0x1855C5D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected GKGLPFGLEMO KENHLMBDPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x55C5D40", Offset = "0x55C5140", VA = "0x1855C5D40")]
		get
		{
			return default(GKGLPFGLEMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x64A0FD0", Offset = "0x64A03D0", VA = "0x1864A0FD0")]
	public OPGABMIFKAJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x64BCC60", Offset = "0x64BC060", VA = "0x1864BCC60")]
	protected MAJKPDGOFIP BDPMIFOJKOL(GKGLPFGLEMO LMIDHGHBOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KFCCKLEKCMP : AMEIAGNIEIL
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x64B2E40", Offset = "0x64B2240", VA = "0x1864B2E40", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x64B2D60", Offset = "0x64B2160", VA = "0x1864B2D60", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x64B2660", Offset = "0x64B1A60", VA = "0x1864B2660", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x64B30C0", Offset = "0x64B24C0", VA = "0x1864B30C0", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x64B31A0", Offset = "0x64B25A0", VA = "0x1864B31A0", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x64B2740", Offset = "0x64B1B40", VA = "0x1864B2740", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x64B29C0", Offset = "0x64B1DC0", VA = "0x1864B29C0", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x64B2AA0", Offset = "0x64B1EA0", VA = "0x1864B2AA0", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x64B2B80", Offset = "0x64B1F80", VA = "0x1864B2B80", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x64B2FE0", Offset = "0x64B23E0", VA = "0x1864B2FE0", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x64B2C60", Offset = "0x64B2060", VA = "0x1864B2C60")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x64B2420", Offset = "0x64B1820", VA = "0x1864B2420")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x64B2520", Offset = "0x64B1920", VA = "0x1864B2520")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x64B23B0", Offset = "0x64B17B0", VA = "0x1864B23B0")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x64B2820", Offset = "0x64B1C20", VA = "0x1864B2820")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x64B2EA0", Offset = "0x64B22A0", VA = "0x1864B2EA0", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public KFCCKLEKCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x64B2C60", Offset = "0x64B2060", VA = "0x1864B2C60", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x64B2420", Offset = "0x64B1820", VA = "0x1864B2420", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x64B2520", Offset = "0x64B1920", VA = "0x1864B2520", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x64B23B0", Offset = "0x64B17B0", VA = "0x1864B23B0", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x64B2FD0", Offset = "0x64B23D0", VA = "0x1864B2FD0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B3970", Offset = "0x64B2D70", VA = "0x1864B3970", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public MAJKPDGOFIP BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x64B3820", Offset = "0x64B2C20", VA = "0x1864B3820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3357870", Offset = "0x3356C70", VA = "0x183357870")]
	public KMPLEPCMLIJ(GKGLPFGLEMO LMIDHGHBOHD, OJOJEPMKJLM CJAFMNMHIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x64B3710", Offset = "0x64B2B10", VA = "0x1864B3710", Slot = "6")]
	public IEnumerator<MAJKPDGOFIP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x64B3710", Offset = "0x64B2B10", VA = "0x1864B3710", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x64B3820", Offset = "0x64B2C20", VA = "0x1864B3820")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A90B0", Offset = "0x64A84B0", VA = "0x1864A90B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x64A9060", Offset = "0x64A8460", VA = "0x1864A9060", Slot = "20")]
	public void InitReferences(IAMNBDNNMOM COLLKIJPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x64A9110", Offset = "0x64A8510", VA = "0x1864A9110", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x64A8FC0", Offset = "0x64A83C0", VA = "0x1864A8FC0", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x64A8B40", Offset = "0x64A7F40", VA = "0x1864A8B40", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x64A9340", Offset = "0x64A8740", VA = "0x1864A9340", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x64A93E0", Offset = "0x64A87E0", VA = "0x1864A93E0", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x64A8BE0", Offset = "0x64A7FE0", VA = "0x1864A8BE0", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x64A8D30", Offset = "0x64A8130", VA = "0x1864A8D30", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x64A8DD0", Offset = "0x64A81D0", VA = "0x1864A8DD0", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x64A8E70", Offset = "0x64A8270", VA = "0x1864A8E70", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x64A92A0", Offset = "0x64A86A0", VA = "0x1864A92A0", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x64A8F10", Offset = "0x64A8310", VA = "0x1864A8F10")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x64A89E0", Offset = "0x64A7DE0", VA = "0x1864A89E0")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x64A8A90", Offset = "0x64A7E90", VA = "0x1864A8A90")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x64A8930", Offset = "0x64A7D30", VA = "0x1864A8930")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x64A8C80", Offset = "0x64A8080", VA = "0x1864A8C80")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x64A91B0", Offset = "0x64A85B0", VA = "0x1864A91B0", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x64A9480", Offset = "0x64A8880", VA = "0x1864A9480")]
	public EJOBDGADALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x64A8F10", Offset = "0x64A8310", VA = "0x1864A8F10", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x64A89E0", Offset = "0x64A7DE0", VA = "0x1864A89E0", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x64A8A90", Offset = "0x64A7E90", VA = "0x1864A8A90", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x64A8930", Offset = "0x64A7D30", VA = "0x1864A8930", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x64A8C80", Offset = "0x64A8080", VA = "0x1864A8C80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F150", Offset = "0x79E550", VA = "0x18079F150", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x80B900", Offset = "0x80AD00", VA = "0x18080B900", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E83C0", Offset = "0x7E77C0", VA = "0x1807E83C0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1A0", Offset = "0x79E5A0", VA = "0x18079F1A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x79F190", Offset = "0x79E590", VA = "0x18079F190", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x79F160", Offset = "0x79E560", VA = "0x18079F160", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x79F0F0", Offset = "0x79E4F0", VA = "0x18079F0F0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2E0", Offset = "0x9EC6E0", VA = "0x1809ED2E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8BA660", VA = "0x1808BB260", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1B4E5A0", Offset = "0x1B4D9A0", VA = "0x181B4E5A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D080", Offset = "0x3D6C480", VA = "0x183D6D080", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4632670", Offset = "0x4631A70", VA = "0x184632670", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4630E50", Offset = "0x4630250", VA = "0x184630E50", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD860", Offset = "0x4EACC60", VA = "0x184EAD860", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD250", Offset = "0x4EAC650", VA = "0x184EAD250", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool NBEHJKEPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x930FF0", Offset = "0x9303F0", VA = "0x180930FF0", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0x1762110", Offset = "0x1761510", VA = "0x181762110", Slot = "29")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D585C0", Offset = "0x5D579C0", VA = "0x185D585C0", Slot = "30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EAB8A0", Offset = "0x4EAACA0", VA = "0x184EAB8A0", Slot = "31")]
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
		[Cpp2IlInjected.Address(RVA = "0x95F540", Offset = "0x95E940", VA = "0x18095F540", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x64AEE80", Offset = "0x64AE280", VA = "0x1864AEE80", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A53350", Offset = "0x1A52750", VA = "0x181A53350", Slot = "36")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8EF5D0", Offset = "0x8EE9D0", VA = "0x1808EF5D0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float DGGCDGCEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BOOLBCIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public EOKKCCNABNA JOKNAEJDLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "48")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xCD30B0", Offset = "0xCD24B0", VA = "0x180CD30B0", Slot = "50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D120", Offset = "0x99C520", VA = "0x18099D120", Slot = "51")]
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
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float EKKBIDCLNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float BCBNNPNHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDC0", Offset = "0x7EB1C0", VA = "0x1807EBDC0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion BNPPAIPFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9A01D0", Offset = "0x99F5D0", VA = "0x1809A01D0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 CMOOOBHDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion KFNAMDFIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x9A01D0", Offset = "0x99F5D0", VA = "0x1809A01D0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool JGCCOPIFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool CHLEIHFIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C78F0", VA = "0x1808C84F0", Slot = "70")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event DNJOPMKHNNE GFGINGLKOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event DNJOPMKHNNE MEDPIFKLBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "41")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "71")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "72")]
	public void DIOOOFBHOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "73")]
	public void PAGPBFBNJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "74")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "81")]
	public void LHFBBPLCKMM(MAJKPDGOFIP FDFHGIHHGHO, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "84")]
	public void KFAFHPPMDDC(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "85")]
	public void NMKMPKOOKND(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "86")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "87")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "88")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "89")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "90")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "91")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "92")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "93")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "94")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "95")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "96")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "97")]
	public Vector3 EIHCMHAJKJG(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "98")]
	public Vector3 LGEBFJGHFCF(Vector3 FDFHGIHHGHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "99")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "100")]
	public void DNEAKKOPNPN(MAJKPDGOFIP PCNBBBLPPLP, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "101")]
	public void DNAHEDKPNGN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "104")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "105")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "106")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "109")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "110")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "115")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "116")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "117")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "118")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "121")]
	public void PGOJGMBCEIJ(Vector3 ELIALHGIFMD, Quaternion HHKLDNEHFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "122")]
	public void GJOLMILDMFJ(Vector3 DONACJKIEHM, Quaternion NOFHGIMADEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "123")]
	public bool KDDIFOEDMNO(float NJPICGCBCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "124")]
	public void EPAHJGAPKEL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "125")]
	public void AEPMFPNLHJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "126")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "127")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "128")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "129")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "130")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "131")]
	public void ODIHICNDDHJ(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x64AEE60", Offset = "0x64AE260", VA = "0x1864AEE60", Slot = "132")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "133")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A0BF0", Offset = "0x649FFF0", VA = "0x1864A0BF0")]
	public JBKHFACBNGN(GameObject IPBNGJILMJD, RigidbodyEx NDNJKOKFFPH, GJHHKNJJGHJ FKFIJGNHDJN, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x64B0410", Offset = "0x64AF810", VA = "0x1864B0410", Slot = "135")]
	protected override void FGDICDGKAOC(GJHHKNJJGHJ FKFIJGNHDJN, DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "141")]
	protected override IDisposable JCBNBIEHPJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x64B01D0", Offset = "0x64AF5D0", VA = "0x1864B01D0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x64B0340", Offset = "0x64AF740", VA = "0x1864B0340", Slot = "142")]
	public void EODIDENHFFD(FBGBOJPDDPL LBLICGCEGPF, FBGBOJPDDPL BOJOHLNAOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x64B0AA0", Offset = "0x64AFEA0", VA = "0x1864B0AA0", Slot = "143")]
	public void OJFEIJEODBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x64B0110", Offset = "0x64AF510", VA = "0x1864B0110", Slot = "144")]
	public void DJBDPDNHELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x64B00B0", Offset = "0x64AF4B0", VA = "0x1864B00B0", Slot = "145")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x64B0680", Offset = "0x64AFA80", VA = "0x1864B0680", Slot = "146")]
	public bool HAKGICMHJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x64B0810", Offset = "0x64AFC10", VA = "0x1864B0810", Slot = "147")]
	public void NGBCENGGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "140")]
	protected override void FADAJDJBGKJ(RigidbodyEx JHEMNDMHNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x64B0870", Offset = "0x64AFC70", VA = "0x1864B0870")]
	private void NLFHFCPDHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class DGHGBALACAG
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x64A6490", Offset = "0x64A5890", VA = "0x1864A6490")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode PBHLHDNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x64BE3E0", Offset = "0x64BD7E0", VA = "0x1864BE3E0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x64BE610", Offset = "0x64BDA10", VA = "0x1864BE610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x64B3450", Offset = "0x64B2850", VA = "0x1864B3450")]
	public PMHFNJDMNDO(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x64BE500", Offset = "0x64BD900", VA = "0x1864BE500", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x64BE680", Offset = "0x64BDA80", VA = "0x1864BE680", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x64BE700", Offset = "0x64BDB00", VA = "0x1864BE700", Slot = "7")]
	public void JLKFIBOGPPC(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x64BE4F0", Offset = "0x64BD8F0", VA = "0x1864BE4F0", Slot = "8")]
	public void FDDBKGEBAAG(bool CABPGJOBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x64BE710", Offset = "0x64BDB10", VA = "0x1864BE710", Slot = "10")]
	public bool MOBKNCGCKPN(Vector3 HLJLNEHEKPN, [Out] RaycastHit NMKFGEGKNKL, float KHEIIGEIBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x64BE870", Offset = "0x64BDC70", VA = "0x1864BE870")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B1D50", Offset = "0x64B1150", VA = "0x1864B1D50", Slot = "6")]
		get
		{
			return default(EOKKCCNABNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x64B1C30", Offset = "0x64B1030", VA = "0x1864B1C30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform ALHIKPNAMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x64B2250", Offset = "0x64B1650", VA = "0x1864B2250", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FOIDAKOAIBK, FOIDAKOAIBK> AEDCFDMBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x64B21A0", Offset = "0x64B15A0", VA = "0x1864B21A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x64B2270", Offset = "0x64B1670", VA = "0x1864B2270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x64B2320", Offset = "0x64B1720", VA = "0x1864B2320")]
	public JGDFMBNBMHE(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x64B1EA0", Offset = "0x64B12A0", VA = "0x1864B1EA0", Slot = "8")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x64B1D00", Offset = "0x64B1100", VA = "0x1864B1D00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1BD2920", Offset = "0x1BD1D20", VA = "0x181BD2920", Slot = "11")]
	private void PKKAOOMBMDO(FOIDAKOAIBK DOFFEAJCHKC, FOIDAKOAIBK DFEJJMNJAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A95A0", Offset = "0x64A89A0", VA = "0x1864A95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool JNKCLNAMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x64BC430", Offset = "0x64BB830", VA = "0x1864BC430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x64A62F0", Offset = "0x64A56F0", VA = "0x1864A62F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x64BC840", Offset = "0x64BBC40", VA = "0x1864BC840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x64B3450", Offset = "0x64B2850", VA = "0x1864B3450")]
	public ONJAMPHHNLJ(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x64BC6E0", Offset = "0x64BBAE0", VA = "0x1864BC6E0", Slot = "4")]
	public void JAFBFEPPPPN(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x64BC480", Offset = "0x64BB880", VA = "0x1864BC480")]
	private void FGLGDIKCEBD(Vector3 DBCFABNBIEE, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x64BC1B0", Offset = "0x64BB5B0", VA = "0x1864BC1B0", Slot = "5")]
	public void EOAKELEIPNN(Vector3 DBCFABNBIEE, Vector3 HGKJDOIPDNM, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x64BCB00", Offset = "0x64BBF00", VA = "0x1864BCB00", Slot = "6")]
	public void PFJKCKOBHIC(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x64BBF50", Offset = "0x64BB350", VA = "0x1864BBF50")]
	private void CLOOBCLMBBL(Vector3 CEKLCAJCKLL, ForceMode CJKGMAAGHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x64BC8A0", Offset = "0x64BBCA0", VA = "0x1864BC8A0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80CBC0", VA = "0x18080D7C0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x64B3310", Offset = "0x64B2710", VA = "0x1864B3310", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x64B3450", Offset = "0x64B2850", VA = "0x1864B3450")]
	public KFEADJINFBD(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x64B3420", Offset = "0x64B2820", VA = "0x1864B3420", Slot = "6")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x64A0ED0", Offset = "0x64A02D0", VA = "0x1864A0ED0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB160", Offset = "0x64BA560", VA = "0x1864BB160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x79F130", Offset = "0x79E530", VA = "0x18079F130", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x64BB540", Offset = "0x64BA940", VA = "0x1864BB540", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public MAJKPDGOFIP MMJFNLDGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x79F310", Offset = "0x79E710", VA = "0x18079F310", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<MAJKPDGOFIP> PCEHAKBFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event DNJOPMKHNNE ANHHBDLOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x64BAEE0", Offset = "0x64BA2E0", VA = "0x1864BAEE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x64BAAF0", Offset = "0x64B9EF0", VA = "0x1864BAAF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event DNJOPMKHNNE GGABJDLKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x64BB020", Offset = "0x64BA420", VA = "0x1864BB020", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x64BA730", Offset = "0x64B9B30", VA = "0x1864BA730", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event OLEKAPALJOK OHGHMLDHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x64BB550", Offset = "0x64BA950", VA = "0x1864BB550", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x64BA330", Offset = "0x64B9730", VA = "0x1864BA330", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PKJCEJABLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x64BBCB0", Offset = "0x64BB0B0", VA = "0x1864BBCB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x64BA560", Offset = "0x64B9960", VA = "0x1864BA560", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action CMPLOJBIIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x64BAE40", Offset = "0x64BA240", VA = "0x1864BAE40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x64BBDF0", Offset = "0x64BB1F0", VA = "0x1864BBDF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<MAJKPDGOFIP> OFCPNIALKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x64BAB90", Offset = "0x64B9F90", VA = "0x1864BAB90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x64BB1C0", Offset = "0x64BA5C0", VA = "0x1864BB1C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<MAJKPDGOFIP> AGODGBDNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x64BA7D0", Offset = "0x64B9BD0", VA = "0x1864BA7D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC40", Offset = "0x64BA040", VA = "0x1864BAC40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JGHIJKFKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x64BAF80", Offset = "0x64BA380", VA = "0x1864BAF80", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x64BB0C0", Offset = "0x64BA4C0", VA = "0x1864BB0C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<MAJKPDGOFIP> LIMPBIPJFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x64BB490", Offset = "0x64BA890", VA = "0x1864BB490", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x64BACF0", Offset = "0x64BA0F0", VA = "0x1864BACF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x64BBE90", Offset = "0x64BB290", VA = "0x1864BBE90")]
	public OMLPHINDMJP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x64BADA0", Offset = "0x64BA1A0", VA = "0x1864BADA0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x64BB730", Offset = "0x64BAB30", VA = "0x1864BB730", Slot = "30")]
	public void LHFBBPLCKMM(MAJKPDGOFIP ANPHHFMKKBG, bool GPFHCOLIHFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x64BA880", Offset = "0x64B9C80", VA = "0x1864BA880", Slot = "6")]
	public void CLBHIGEBNEK(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x64BA0B0", Offset = "0x64B94B0", VA = "0x1864BA0B0", Slot = "7")]
	public void ABKMGAGMHCJ(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x64BA470", Offset = "0x64B9870", VA = "0x1864BA470", Slot = "4")]
	public void AMKDDMPMJOF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x64BA3D0", Offset = "0x64B97D0", VA = "0x1864BA3D0", Slot = "5")]
	public void AJCPOEFKKBF(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x64BBD50", Offset = "0x64BB150", VA = "0x1864BBD50")]
	private void OBNHKAHBGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x64BA070", Offset = "0x64B9470", VA = "0x1864BA070")]
	private void AAEABLPOAPB(MAJKPDGOFIP DCOAKJNKHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB5F0", Offset = "0x64BA9F0", VA = "0x1864BB5F0")]
	private void LDOLOMCEGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x64BB270", Offset = "0x64BA670", VA = "0x1864BB270")]
	private void IMKPOOHCDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x64BA600", Offset = "0x64B9A00", VA = "0x1864BA600")]
	private void CBLLMLKAABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x64BB3A0", Offset = "0x64BA7A0", VA = "0x1864BB3A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A1070", Offset = "0x64A0470", VA = "0x1864A1070")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 NCJOILBPNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x64A5810", Offset = "0x64A4C10", VA = "0x1864A5810", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 AALKHDOCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x64A52C0", Offset = "0x64A46C0", VA = "0x1864A52C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x64A51D0", Offset = "0x64A45D0", VA = "0x1864A51D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MAJKPDGOFIP JIHACKDFFND
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x64A5120", Offset = "0x64A4520", VA = "0x1864A5120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x64A5840", Offset = "0x64A4C40", VA = "0x1864A5840")]
	public CCCJIBJPGDC(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x64A4D20", Offset = "0x64A4120", VA = "0x1864A4D20", Slot = "8")]
	public void HMADCOJHFBN(MAJKPDGOFIP BBCCHMIJNJG, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x64A4CC0", Offset = "0x64A40C0", VA = "0x1864A4CC0", Slot = "9")]
	public void CLGAMCCOJJD(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x64A4D90", Offset = "0x64A4190", VA = "0x1864A4D90")]
	private Vector3 IOOBHAOLFBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x64A5480", Offset = "0x64A4880", VA = "0x1864A5480")]
	private void NIBOJCMPOKE(MAJKPDGOFIP PEBMHMPLAHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class KKPJFOIHODP
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x64B34E0", Offset = "0x64B28E0", VA = "0x1864B34E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x107D6D0", Offset = "0x107CAD0", VA = "0x18107D6D0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x64B5C70", Offset = "0x64B5070", VA = "0x1864B5C70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 CAAFMLKJJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x64B6F40", Offset = "0x64B6340", VA = "0x1864B6F40", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float GOCLGEHHPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11136B0", Offset = "0x1112AB0", VA = "0x1811136B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x64B55E0", Offset = "0x64B49E0", VA = "0x1864B55E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float DECFALGIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xBA3EF0", Offset = "0xBA32F0", VA = "0x180BA3EF0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x64B6A40", Offset = "0x64B5E40", VA = "0x1864B6A40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 JNAJELEMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x64B6010", Offset = "0x64B5410", VA = "0x1864B6010", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion LEGHDDBPANH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x64B5E90", Offset = "0x64B5290", VA = "0x1864B5E90", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody EGEJNIHCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x64B5B30", Offset = "0x64B4F30", VA = "0x1864B5B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event DNJOPMKHNNE KHEKPLMFOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x64B6EA0", Offset = "0x64B62A0", VA = "0x1864B6EA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x64B6280", Offset = "0x64B5680", VA = "0x1864B6280", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x64B8060", Offset = "0x64B7460", VA = "0x1864B8060")]
	public MAFNHPMHFNP(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x64B5980", Offset = "0x64B4D80", VA = "0x1864B5980", Slot = "17")]
	public void DHKHEHMAMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x64B61A0", Offset = "0x64B55A0", VA = "0x1864B61A0", Slot = "16")]
	public void ICGFIJLDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x64B6320", Offset = "0x64B5720", VA = "0x1864B6320", Slot = "19")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x64B56F0", Offset = "0x64B4AF0", VA = "0x1864B56F0", Slot = "20")]
	public void CIBCMBIHCOB(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x64B5D20", Offset = "0x64B5120", VA = "0x1864B5D20", Slot = "18")]
	public void FNHGPHNGPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x64B6400", Offset = "0x64B5800", VA = "0x1864B6400", Slot = "21")]
	public void KPLJMGBPKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x64B5C70", Offset = "0x64B5070", VA = "0x1864B5C70")]
	private void KFDNCHBDDCI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x64B5B80", Offset = "0x64B4F80", VA = "0x1864B5B80")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 EEOIDLAPKIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x64B55E0", Offset = "0x64B49E0", VA = "0x1864B55E0")]
	private void EGHAEIHPODL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x64B6A40", Offset = "0x64B5E40", VA = "0x1864B6A40")]
	private void NIKGHCLKAIL(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x64B68A0", Offset = "0x64B5CA0", VA = "0x1864B68A0")]
	private Vector3 KPOEDKBLEDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x64B6C70", Offset = "0x64B6070", VA = "0x1864B6C70", Slot = "15")]
	public void MGLLADICDDO((Quaternion rot, Vector3 moments) HBDDADMDMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x64B6AF0", Offset = "0x64B5EF0", VA = "0x1864B6AF0")]
	private Quaternion LOBMBBFJGFI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x64B7040", Offset = "0x64B6440", VA = "0x1864B7040")]
	public void PIIOGOHJCCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x64B7110", Offset = "0x64B6510", VA = "0x1864B7110", Slot = "4")]
	public (float, Vector3) PIIOGOHJCCF(Rigidbody OLBBNJBKMLC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class IJELHFPLOPK
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x64AFFF0", Offset = "0x64AF3F0", VA = "0x1864AFFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE0900", Offset = "0xCDFD00", VA = "0x180CE0900", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DPMKPOINNGM KEGPHBBKBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500", Slot = "11")]
		get
		{
			return default(DPMKPOINNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x64AFEF0", Offset = "0x64AF2F0", VA = "0x1864AFEF0")]
	public HOJNGHNHMHJ(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x64AFB70", Offset = "0x64AEF70", VA = "0x1864AFB70", Slot = "4")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x64AFE20", Offset = "0x64AF220", VA = "0x1864AFE20")]
	private bool OCIHJNLKONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x64AFEC0", Offset = "0x64AF2C0", VA = "0x1864AFEC0", Slot = "5")]
	public void PFDPGHHPDCI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x64AFDF0", Offset = "0x64AF1F0", VA = "0x1864AFDF0", Slot = "6")]
	public void NECCIEDFAJN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x64AF8D0", Offset = "0x64AECD0", VA = "0x1864AF8D0", Slot = "9")]
	public void FNPLNNGPHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x64AFA10", Offset = "0x64AEE10", VA = "0x1864AFA10")]
	private void HBGHIFEGEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x64AFC80", Offset = "0x64AF080", VA = "0x1864AFC80")]
	private void KLBKGKOABLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x64AFC40", Offset = "0x64AF040", VA = "0x1864AFC40", Slot = "8")]
	public void JNOGIAHPMMB(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x64AFB30", Offset = "0x64AEF30", VA = "0x1864AFB30", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x649A9A0", Offset = "0x6499DA0", VA = "0x18649A9A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event DNJOPMKHNNE EFKNBDCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x649A8D0", Offset = "0x6499CD0", VA = "0x18649A8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x649A830", Offset = "0x6499C30", VA = "0x18649A830", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x649AC40", Offset = "0x649A040", VA = "0x18649AC40")]
	public AENCFDJJFJD(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x649A7C0", Offset = "0x6499BC0", VA = "0x18649A7C0", Slot = "11")]
	public IDisposable BLPPEKMIDDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x649AC30", Offset = "0x649A030", VA = "0x18649AC30", Slot = "8")]
	public void MNKJNICMDDE(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x649ABE0", Offset = "0x6499FE0", VA = "0x18649ABE0", Slot = "9")]
	public void KFNALHDIDCF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x649AAD0", Offset = "0x6499ED0", VA = "0x18649AAD0", Slot = "10")]
	public void JHAFEEFAPMD(object FACMOGNGACN, bool GMDNHEMEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x649ABF0", Offset = "0x6499FF0", VA = "0x18649ABF0", Slot = "6")]
	public void MGGJGJFHMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x649AA50", Offset = "0x6499E50", VA = "0x18649AA50", Slot = "12")]
	public void JFLFNNOBHDI(Rigidbody HELFJOICHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x649A970", Offset = "0x6499D70", VA = "0x18649A970", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool POAPHBBHPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x64AD830", Offset = "0x64ACC30", VA = "0x1864AD830", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool INBELOMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x87A940", Offset = "0x879D40", VA = "0x18087A940", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event DNJOPMKHNNE LPFAMJOLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x64AD790", Offset = "0x64ACB90", VA = "0x1864AD790", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x64ADBC0", Offset = "0x64ACFC0", VA = "0x1864ADBC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x64AE340", Offset = "0x64AD740", VA = "0x1864AE340")]
	public FPJIGKPIFFA(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x64ADF30", Offset = "0x64AD330", VA = "0x1864ADF30", Slot = "9")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x64ADAC0", Offset = "0x64ACEC0", VA = "0x1864ADAC0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x64ADC60", Offset = "0x64AD060", VA = "0x1864ADC60", Slot = "10")]
	public void FIPKOAHLFPG(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x64AE060", Offset = "0x64AD460", VA = "0x1864AE060", Slot = "11")]
	public void LHFMEAHBGMK(MAJKPDGOFIP BBCCHMIJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x64AE1D0", Offset = "0x64AD5D0", VA = "0x1864AE1D0")]
	private void LMIMMMDKBPG(PhotonView INLELPGOKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x64ADDD0", Offset = "0x64AD1D0", VA = "0x1864ADDD0")]
	private void FNBDCNCNNLC(RigidbodyEx FFLMFPGCDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x64AD850", Offset = "0x64ACC50", VA = "0x1864AD850")]
	private void CMOEOOFMHIA(PhotonView IMEOGBMMBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class ECBHGGOMLEK
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x64A8870", Offset = "0x64A7C70", VA = "0x1864A8870")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF4760", Offset = "0xAF3B60", VA = "0x180AF4760", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7300", Offset = "0x3DD6700", VA = "0x183DD7300", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool IBOKPHKBNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xD38420", Offset = "0xD37820", VA = "0x180D38420", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3DD72F0", Offset = "0x3DD66F0", VA = "0x183DD72F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints CKMJBPCPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x64B9B10", Offset = "0x64B8F10", VA = "0x1864B9B10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x64B9C40", Offset = "0x64B9040", VA = "0x1864B9C40")]
	public NLEOFHBIGHJ(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x64B9AE0", Offset = "0x64B8EE0", VA = "0x1864B9AE0", Slot = "9")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x64B9AB0", Offset = "0x64B8EB0", VA = "0x1864B9AB0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BB7D0", Offset = "0x8BABD0", VA = "0x1808BB7D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x64A6580", Offset = "0x64A5980", VA = "0x1864A6580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float JANKJFBFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x938010", Offset = "0x937410", VA = "0x180938010", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x64A66A0", Offset = "0x64A5AA0", VA = "0x1864A66A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x64A6770", Offset = "0x64A5B70", VA = "0x1864A6770")]
	public DGJJLNJAHOI(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x64A6650", Offset = "0x64A5A50", VA = "0x1864A6650", Slot = "8")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x64A64E0", Offset = "0x64A58E0", VA = "0x1864A64E0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B5B30", Offset = "0x64B4F30", VA = "0x1864B5B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x64B8420", Offset = "0x64B7820", VA = "0x1864B8420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private MAJKPDGOFIP NMNOBPOLLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x64B8A00", Offset = "0x64B7E00", VA = "0x1864B8A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x64B8A60", Offset = "0x64B7E60", VA = "0x1864B8A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event DNJOPMKHNNE DFMFIOEILLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x64B8780", Offset = "0x64B7B80", VA = "0x1864B8780", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x64B8AD0", Offset = "0x64B7ED0", VA = "0x1864B8AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x64B8C10", Offset = "0x64B8010", VA = "0x1864B8C10")]
	public MGNGNMFOFOP(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x64B8820", Offset = "0x64B7C20", VA = "0x1864B8820", Slot = "6")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x64B8AC0", Offset = "0x64B7EC0", VA = "0x1864B8AC0", Slot = "8")]
	public void NNKNDHMONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x64B88B0", Offset = "0x64B7CB0", VA = "0x1864B88B0", Slot = "7")]
	public bool JIEBNDKPCIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x64B81A0", Offset = "0x64B75A0", VA = "0x1864B81A0", Slot = "9")]
	public void BFFAIFELDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x64B8B70", Offset = "0x64B7F70", VA = "0x1864B8B70", Slot = "11")]
	public void PNGBAFMBDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x64B8150", Offset = "0x64B7550", VA = "0x1864B8150", Slot = "12")]
	public void AOEPFNFEKGK(bool DPOOEGCHNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x64B85D0", Offset = "0x64B79D0", VA = "0x1864B85D0", Slot = "10")]
	public void IAGIIJPJGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x64B8240", Offset = "0x64B7640", VA = "0x1864B8240")]
	private bool BMPMKDPNPLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x64B8440", Offset = "0x64B7840", VA = "0x1864B8440")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool NKDNIGFDBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x64C6100", Offset = "0x64C5500", VA = "0x1864C6100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool IKKIFPPLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xCE0900", Offset = "0xCDFD00", VA = "0x180CE0900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x64C6150", Offset = "0x64C5550", VA = "0x1864C6150")]
	public EJAJJNFFOKH(MAJKPDGOFIP EIDKMOICLKH, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x64C5CF0", Offset = "0x64C50F0", VA = "0x1864C5CF0", Slot = "5")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x64C51E0", Offset = "0x64C45E0", VA = "0x1864C51E0", Slot = "7")]
	public void COOOLPDEOPN(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x64C6120", Offset = "0x64C5520", VA = "0x1864C6120", Slot = "8")]
	public void PBKDDMGPGGI(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x64C5A20", Offset = "0x64C4E20", VA = "0x1864C5A20", Slot = "9")]
	public void HEECMNKNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x64C5D90", Offset = "0x64C5190", VA = "0x1864C5D90", Slot = "11")]
	public void LBENDJNHIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x64C58A0", Offset = "0x64C4CA0", VA = "0x1864C58A0", Slot = "12")]
	public void GEGBCJPHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x64C5210", Offset = "0x64C4610", VA = "0x1864C5210", Slot = "10")]
	public void DKEFNDGCGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x64C5F80", Offset = "0x64C5380", VA = "0x1864C5F80")]
	private void NACMONJIMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x64C5720", Offset = "0x64C4B20", VA = "0x1864C5720")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public PGFDCBPILFN IPDDHLLCKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 PPPONEDDGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x64C8550", Offset = "0x64C7950", VA = "0x1864C8550", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x64C68B0", Offset = "0x64C5CB0", VA = "0x1864C68B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 HJJNLMGOINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x64C7620", Offset = "0x64C6A20", VA = "0x1864C7620", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x64C8FC0", Offset = "0x64C83C0", VA = "0x1864C8FC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 EGALGMODBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x64C87E0", Offset = "0x64C7BE0", VA = "0x1864C87E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x64C67F0", Offset = "0x64C5BF0", VA = "0x1864C67F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 GDEFKICBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x64C7530", Offset = "0x64C6930", VA = "0x1864C7530", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x64C8900", Offset = "0x64C7D00", VA = "0x1864C8900", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float NPDJFEPCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F10", Offset = "0x7F3310", VA = "0x1807F3F10", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x64C6C70", Offset = "0x64C6070", VA = "0x1864C6C70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool BHCMGGOOJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1680D10", Offset = "0x1680110", VA = "0x181680D10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private HPCAIPJONDJ HGNCDNNOBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5E50", Offset = "0x5DF5250", VA = "0x185DF5E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool MFHBHCLBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x64A15F0", Offset = "0x64A09F0", VA = "0x1864A15F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x64C9190", Offset = "0x64C8590", VA = "0x1864C9190")]
	public ODOMMIDAGLG(MAJKPDGOFIP EIDKMOICLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x64C6AE0", Offset = "0x64C5EE0", VA = "0x1864C6AE0", Slot = "19")]
	public void IOLMLAFHNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x64C71E0", Offset = "0x64C65E0", VA = "0x1864C71E0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x64C8310", Offset = "0x64C7710", VA = "0x1864C8310", Slot = "28")]
	public void JFLFNNOBHDI(Rigidbody HKMBLJLNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xB21DE0", Offset = "0xB211E0", VA = "0x180B21DE0", Slot = "20")]
	public void MGENLKFCOPL(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xB23FA0", Offset = "0xB233A0", VA = "0x180B23FA0", Slot = "30")]
	public void HKALPDNOFGF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x64C6970", Offset = "0x64C5D70", VA = "0x1864C6970", Slot = "35")]
	public Vector3 CIKBPHILGGI(Vector3 OEPKEFKPOKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x64C6210", Offset = "0x64C5610", VA = "0x1864C6210", Slot = "34")]
	public Vector3 BFFJJMHPIPF(Vector3 HFNNPPNDKLE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x64C6AE0", Offset = "0x64C5EE0", VA = "0x1864C6AE0", Slot = "27")]
	public void CILJINMIBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x64C8930", Offset = "0x64C7D30", VA = "0x1864C8930", Slot = "25")]
	public void NMOLEBIGNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x64C6D20", Offset = "0x64C6120", VA = "0x1864C6D20", Slot = "24")]
	public void DGKDLJKIJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x64C8FF0", Offset = "0x64C83F0", VA = "0x1864C8FF0", Slot = "33")]
	public void PMEKGCOPMKK(Vector3 ECODBEBAMAO, Vector3 DOEFLFIPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x64C7D40", Offset = "0x64C7140", VA = "0x1864C7D40", Slot = "32")]
	public void HKKGJNCABJI(Vector3 HHEKLKDCANL, Vector3 HOFIFLHLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x64C8670", Offset = "0x64C7A70", VA = "0x1864C8670", Slot = "31")]
	public void MHOENHCKHCH(Vector3 JLIEMLPIBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x64C7710", Offset = "0x64C6B10", VA = "0x1864C7710", Slot = "22")]
	public void HBIGPIHOLKI(DOMKELDFKDD KDCDCLEINIH, Vector3 CPBHBCHPIPP, float LFNIEOFBBNJ, float DJOAKPAJMPP = 8f, float DNNOFNMOAIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x64C8D30", Offset = "0x64C8130", VA = "0x1864C8D30", Slot = "21")]
	public void OOOFHCLCIBC(CABKKAHINFM DHKMOCAJAOI, Vector3 HOAINBKFNAP, float MABPOCICDPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x64C8990", Offset = "0x64C7D90", VA = "0x1864C8990", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OAMHDEAAJDN(CABKKAHINFM DHKMOCAJAOI, Vector3 PGPLGEJKHLI, float COCNMBIDOOL = 7f, float HKNLANNMLHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x64C72F0", Offset = "0x64C66F0", VA = "0x1864C72F0", Slot = "29")]
	public Vector3 EIHCMHAJKJG(Vector3 HLPPLJDPLMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x64C81E0", Offset = "0x64C75E0", VA = "0x1864C81E0", Slot = "26")]
	public void JFDEHDLFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x64C6C70", Offset = "0x64C6070", VA = "0x1864C6C70")]
	private void GMKAMDEIKLJ(float FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x64C83E0", Offset = "0x64C77E0", VA = "0x1864C83E0")]
	private void LDFNFKHOCFM(Vector3 HOAINBKFNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x64C7450", Offset = "0x64C6850", VA = "0x1864C7450")]
	private Vector3 ENABOCDHLAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x64C6D80", Offset = "0x64C6180", VA = "0x1864C6D80")]
	private void DHLCFCLNLBP(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x64C6B90", Offset = "0x64C5F90", VA = "0x1864C6B90")]
	private Vector3 COMDNKHKCIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x64C7DA0", Offset = "0x64C71A0", VA = "0x1864C7DA0")]
	private void IBBJPBFGACI(Vector3 FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x64C6360", Offset = "0x64C5760", VA = "0x1864C6360")]
	private void BHFFIHFMHLA(Vector3 HFNNPPNDKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x64C7240", Offset = "0x64C6640", VA = "0x1864C7240")]
	private void EAEJKAFDAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DLPDJGNFKNP : AMEIAGNIEIL
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x64C4FB0", Offset = "0x64C43B0", VA = "0x1864C4FB0", Slot = "4")]
	public CJEGMDCLHOD MFIIIJONPOK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x64C4ED0", Offset = "0x64C42D0", VA = "0x1864C4ED0", Slot = "5")]
	public KGNHMKIAAOB ILIMKMGADII(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x64C4B90", Offset = "0x64C3F90", VA = "0x1864C4B90", Slot = "6")]
	public NMGBIJGEMFE DCKJELKFIIC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x64C5120", Offset = "0x64C4520", VA = "0x1864C5120", Slot = "7")]
	public JFMHMMBLNJE OLNCDFAMEFE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x64C5180", Offset = "0x64C4580", VA = "0x1864C5180", Slot = "8")]
	public AHGGNJHECFJ OMBIHOJGOJA(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x64C4BF0", Offset = "0x64C3FF0", VA = "0x1864C4BF0", Slot = "9")]
	public HKELBIKPBAP DLIMFOMGBFO(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x64C4CC0", Offset = "0x64C40C0", VA = "0x1864C4CC0", Slot = "10")]
	public OPKDBPCBAEB FOMAMNCNFDK(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x64C4D20", Offset = "0x64C4120", VA = "0x1864C4D20", Slot = "11")]
	public HPCAIPJONDJ GAJIKHLFILC(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x64C4D80", Offset = "0x64C4180", VA = "0x1864C4D80", Slot = "12")]
	public HIEMKEHDCPH HKDOILIIFGE(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x64C50C0", Offset = "0x64C44C0", VA = "0x1864C50C0", Slot = "13")]
	public LBHOHABHMBK OIOILBJJIAD(MAJKPDGOFIP CEBGEIIIEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x64C4DE0", Offset = "0x64C41E0", VA = "0x1864C4DE0")]
	public GGBKAKCBEGF IAKDJJPJFGL(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x64C4AB0", Offset = "0x64C3EB0", VA = "0x1864C4AB0")]
	public OMPHGPEJHNI CNEAMMPMLHE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x64C4B20", Offset = "0x64C3F20", VA = "0x1864C4B20")]
	public GKJMGGNMBBN CPJNHGBNGOM(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x64C4A40", Offset = "0x64C3E40", VA = "0x1864C4A40")]
	public EHICGHNDAFI GADNIGGKDDA(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x64C4C50", Offset = "0x64C4050", VA = "0x1864C4C50")]
	public CDKPFJBLKKB FCMJPLIHMCE(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x64C5010", Offset = "0x64C4410", VA = "0x1864C5010", Slot = "19")]
	public MAJKPDGOFIP NHCBCFDIMLG(RigidbodyEx EIDKMOICLKH, DAMEEEKAOEJ MFNOAEFOKBK, GJHHKNJJGHJ FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DLPDJGNFKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x64C4DE0", Offset = "0x64C41E0", VA = "0x1864C4DE0", Slot = "14")]
	private GGBKAKCBEGF LMGNHJDFFLD(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x64C4AB0", Offset = "0x64C3EB0", VA = "0x1864C4AB0", Slot = "15")]
	private OMPHGPEJHNI OPDDLBLKHKB(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x64C4B20", Offset = "0x64C3F20", VA = "0x1864C4B20", Slot = "16")]
	private GKJMGGNMBBN IJLMJPEHKNC(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x64C4A40", Offset = "0x64C3E40", VA = "0x1864C4A40", Slot = "17")]
	private EHICGHNDAFI AAGOFDHIPFN(MAJKPDGOFIP CEBGEIIIEAM, [In] DAMEEEKAOEJ MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x64C4C50", Offset = "0x64C4050", VA = "0x1864C4C50", Slot = "18")]
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
