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
	public class LogRegistrationIndex : DBDHBFHEAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66BE160", Offset = "0x66BD360", VA = "0x1866BE160", Slot = "4")]
		public override void MPIFNDMAGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
	public class _AssemblyIndex : AMNHIIEBCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private OJGDPFKAHDB bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private OJGDPFKAHDB bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60C3260", Offset = "0x60C2460", VA = "0x1860C3260", Slot = "5")]
		public override void APEIOLGPCIE(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66CA5F0", Offset = "0x66C97F0", VA = "0x1866CA5F0")]
		private void KEDGCOJNHLP(KDIFPPHEFOM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66CA1C0", Offset = "0x66C93C0", VA = "0x1866CA1C0")]
		private void EKFAEJONIPL(KDIFPPHEFOM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66C9FD0", Offset = "0x66C91D0", VA = "0x1866C9FD0", Slot = "6")]
		public override void CJKBHHFMNOL(KDIFPPHEFOM registry, [In] NFFDBJIPBDD filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "8")]
		public override void ILDOOKAPLMG(LNNICLBDLGC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66CA760", Offset = "0x66C9960", VA = "0x1866CA760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void EIGGMKBCEMC(RigidbodyEx GHOKNAHJIHE);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NICIGNFICLC(RigidbodyEx GHOKNAHJIHE, bool OACHBGFPODN = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CBGMHAPIEJC
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
public enum KJKPFOPHGBD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum EFDPHABCCPF
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[KGDBDLGNBOK(typeof(PEMPDFNPLIG), new string[] { "Ignore", "Mock" })]
public class EBAAIOBANIJ : PEMPDFNPLIG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LDCFEJEIACE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80DD00", Offset = "0x80CF00", VA = "0x18080DD00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
	public void LEIPBPAIJNO(string PLLLDOCFAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
	public void MPOICLGPFPO(RigidbodyEx DMHIFOLACBC, Action CEBHNDLCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "7")]
	public AMGCCPCIEKH LIFODKENINA(int CHLGEKOCBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "8")]
	public void HODLFKCHDBA(Vector3 NPJPGBOOHHM, float MILMMGCFNDP, Color DKDNEEAJCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public EBAAIOBANIJ()
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
		private static readonly DNCJPFEBFGD LLOMIIGLPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool DLOMMJBKDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private AAMLDJKKPKC KLIPKGBJMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[FNMOBJNDEPF(DOGHHGCAALN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[FNMOBJNDEPF(DOGHHGCAALN.SelfAndParent, true, false, false)]
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
		private KJKPFOPHGBD physicsInterpolation;

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
		internal AAMLDJKKPKC EPECBIPPACC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x66C5880", Offset = "0x66C4A80", VA = "0x1866C5880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> OHCDJJMBAHD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDFD0", Offset = "0x7BD1D0", VA = "0x1807BDFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDFA0", Offset = "0x7BD1A0", VA = "0x1807BDFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DOGBFIJNDJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66C76B0", Offset = "0x66C68B0", VA = "0x1866C76B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx EJPDLJOMEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x66C7610", Offset = "0x66C6810", VA = "0x1866C7610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DMKJLMNBOME
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x66C82D0", Offset = "0x66C74D0", VA = "0x1866C82D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x66C9850", Offset = "0x66C8A50", VA = "0x1866C9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform LKKILMPIKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E4B70", Offset = "0x7E3D70", VA = "0x1807E4B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform BAFFLMDJODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7E4B70", Offset = "0x7E3D70", VA = "0x1807E4B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HIMOPMHMMMP LCEIFNIHNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x66C73D0", Offset = "0x66C65D0", VA = "0x1866C73D0")]
			get
			{
				return default(HIMOPMHMMMP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x66C9000", Offset = "0x66C8200", VA = "0x1866C9000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PGJJNGCCIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x66C7960", Offset = "0x66C6B60", VA = "0x1866C7960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BNGPLJJMCFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66C74F0", Offset = "0x66C66F0", VA = "0x1866C74F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PIHLMFDNIMC ALDDBBMLNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x66C78A0", Offset = "0x66C6AA0", VA = "0x1866C78A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66C91C0", Offset = "0x66C83C0", VA = "0x1866C91C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NIDNKMLFNEL NMBGKHEEHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x66C7840", Offset = "0x66C6A40", VA = "0x1866C7840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66C9150", Offset = "0x66C8350", VA = "0x1866C9150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MJCMPOCKHMF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x66C7790", Offset = "0x66C6990", VA = "0x1866C7790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody GNPHPEMEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x66C77F0", Offset = "0x66C69F0", VA = "0x1866C77F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CEEMPIKGKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x66C7550", Offset = "0x66C6750", VA = "0x1866C7550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x66C9070", Offset = "0x66C8270", VA = "0x1866C9070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DPAJPGPIPEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDA0D0", Offset = "0x5ED92D0", VA = "0x185EDA0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5ED8F40", Offset = "0x5ED8140", VA = "0x185ED8F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float PGHCGBCABEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x66C8270", Offset = "0x66C7470", VA = "0x1866C8270")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CLFEOAKKOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x66C8210", Offset = "0x66C7410", VA = "0x1866C8210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x66C97E0", Offset = "0x66C89E0", VA = "0x1866C97E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KLNHJFKNGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x66C7BC0", Offset = "0x66C6DC0", VA = "0x1866C7BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x66C9460", Offset = "0x66C8660", VA = "0x1866C9460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FMHMPJKMLFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x66C79C0", Offset = "0x66C6BC0", VA = "0x1866C79C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x66C9230", Offset = "0x66C8430", VA = "0x1866C9230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LAABPJCENLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x66C8830", Offset = "0x66C7A30", VA = "0x1866C8830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66C9DB0", Offset = "0x66C8FB0", VA = "0x1866C9DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OGNOJJJOJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x66C7FF0", Offset = "0x66C71F0", VA = "0x1866C7FF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x66C95B0", Offset = "0x66C87B0", VA = "0x1866C95B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 NPJPGBOOHHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x66C8970", Offset = "0x66C7B70", VA = "0x1866C8970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode PKGHOLEMEHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x66C7B00", Offset = "0x66C6D00", VA = "0x1866C7B00")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66C9380", Offset = "0x66C8580", VA = "0x1866C9380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float OGMJFAKDMBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x66C75B0", Offset = "0x66C67B0", VA = "0x1866C75B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x66C90E0", Offset = "0x66C82E0", VA = "0x1866C90E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints IGCLOJGKDJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x66C7B60", Offset = "0x66C6D60", VA = "0x1866C7B60")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x66C93F0", Offset = "0x66C85F0", VA = "0x1866C93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 BADJFDIDHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x66C8370", Offset = "0x66C7570", VA = "0x1866C8370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 EOCDKGLAKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x66C8370", Offset = "0x66C7570", VA = "0x1866C8370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x66C9B90", Offset = "0x66C8D90", VA = "0x1866C9B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float HAOEDLHEEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x66C80D0", Offset = "0x66C72D0", VA = "0x1866C80D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x66C9690", Offset = "0x66C8890", VA = "0x1866C9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BNHAODCHBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66C87D0", Offset = "0x66C79D0", VA = "0x1866C87D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66C9D40", Offset = "0x66C8F40", VA = "0x1866C9D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion PGDGIOCMFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66C8450", Offset = "0x66C7650", VA = "0x1866C8450")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x66C9910", Offset = "0x66C8B10", VA = "0x1866C9910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion JIPOGPBKKFD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x66C86F0", Offset = "0x66C78F0", VA = "0x1866C86F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66C9C70", Offset = "0x66C8E70", VA = "0x1866C9C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 CCCHNMCNHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x66C8530", Offset = "0x66C7730", VA = "0x1866C8530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x66C99E0", Offset = "0x66C8BE0", VA = "0x1866C99E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JMFAIKIFMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x66C8610", Offset = "0x66C7810", VA = "0x1866C8610")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x66C9AC0", Offset = "0x66C8CC0", VA = "0x1866C9AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 KEMDGEPABAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x66C8890", Offset = "0x66C7A90", VA = "0x1866C8890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x66C9E20", Offset = "0x66C9020", VA = "0x1866C9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HGIFAPNFCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x66C8130", Offset = "0x66C7330", VA = "0x1866C8130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x66C9700", Offset = "0x66C8900", VA = "0x1866C9700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CLIOBNEJAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x66C7A20", Offset = "0x66C6C20", VA = "0x1866C7A20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66C92A0", Offset = "0x66C84A0", VA = "0x1866C92A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 GOKBIGLBBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x66C7F10", Offset = "0x66C7110", VA = "0x1866C7F10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x66C94D0", Offset = "0x66C86D0", VA = "0x1866C94D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 OJJCMJGBEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x66C7DD0", Offset = "0x66C6FD0", VA = "0x1866C7DD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PMIAEMCEJBN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x66C7CF0", Offset = "0x66C6EF0", VA = "0x1866C7CF0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 MGDBJNDEEJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x66C8B30", Offset = "0x66C7D30", VA = "0x1866C8B30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 KPIAEJGMOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x66C8A50", Offset = "0x66C7C50", VA = "0x1866C8A50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KIEBCEKHBFD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66C7EB0", Offset = "0x66C70B0", VA = "0x1866C7EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OHAMAMLBOAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x66C7900", Offset = "0x66C6B00", VA = "0x1866C7900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EMKLPIGGJBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66C7490", Offset = "0x66C6690", VA = "0x1866C7490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LDPHOKCKEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x66C7430", Offset = "0x66C6630", VA = "0x1866C7430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CLMLEGFFJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66C7370", Offset = "0x66C6570", VA = "0x1866C7370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JGPHAKLKPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x66C7C20", Offset = "0x66C6E20", VA = "0x1866C7C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NHGADOFHDEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x524BF20", Offset = "0x524B120", VA = "0x18524BF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EIGGMKBCEMC ECCKLLPKOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66C7290", Offset = "0x66C6490", VA = "0x1866C7290")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x66C8F20", Offset = "0x66C8120", VA = "0x1866C8F20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NICIGNFICLC IPBCLNPPINH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x66C7220", Offset = "0x66C6420", VA = "0x1866C7220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x66C8EB0", Offset = "0x66C80B0", VA = "0x1866C8EB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EIGGMKBCEMC EMIACKFKMHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66C6F80", Offset = "0x66C6180", VA = "0x1866C6F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x66C8C10", Offset = "0x66C7E10", VA = "0x1866C8C10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EIGGMKBCEMC DACGLNGCBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x66C6FF0", Offset = "0x66C61F0", VA = "0x1866C6FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x66C8C80", Offset = "0x66C7E80", VA = "0x1866C8C80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EIGGMKBCEMC KPDPNDEFHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66C7140", Offset = "0x66C6340", VA = "0x1866C7140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x66C8DD0", Offset = "0x66C7FD0", VA = "0x1866C8DD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66C70D0", Offset = "0x66C62D0", VA = "0x1866C70D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66C8D60", Offset = "0x66C7F60", VA = "0x1866C8D60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EIGGMKBCEMC FJHLLHINFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66C71B0", Offset = "0x66C63B0", VA = "0x1866C71B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66C8E40", Offset = "0x66C8040", VA = "0x1866C8E40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EIGGMKBCEMC LCDECKKBJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x66C7300", Offset = "0x66C6500", VA = "0x1866C7300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66C8F90", Offset = "0x66C8190", VA = "0x1866C8F90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event EIGGMKBCEMC MMBNEHCMHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x66C7060", Offset = "0x66C6260", VA = "0x1866C7060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x66C8CF0", Offset = "0x66C7EF0", VA = "0x1866C8CF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		internal void NJLPALMCBNP(AAMLDJKKPKC BFLJLPICFCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66C5B50", Offset = "0x66C4D50", VA = "0x1866C5B50")]
		internal void KBOLPBDPAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66C6CA0", Offset = "0x66C5EA0", VA = "0x1866C6CA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody BLKLLJOIABB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x66C6970", Offset = "0x66C5B70", VA = "0x1866C6970")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MHDHIIEFABD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66C53B0", Offset = "0x66C45B0", VA = "0x1866C53B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66C5880", Offset = "0x66C4A80", VA = "0x1866C5880")]
		private AAMLDJKKPKC HHIFNJEDBHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x66C5E70", Offset = "0x66C5070", VA = "0x1866C5E70")]
		private void PIODBADEDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66C5DB0", Offset = "0x66C4FB0", VA = "0x1866C5DB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66C5B50", Offset = "0x66C4D50", VA = "0x1866C5B50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66C5D50", Offset = "0x66C4F50", VA = "0x1866C5D50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66C5E10", Offset = "0x66C5010", VA = "0x1866C5E10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66C4A60", Offset = "0x66C3C60", VA = "0x1866C4A60")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66C6200", Offset = "0x66C5400", VA = "0x1866C6200")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66C5600", Offset = "0x66C4800", VA = "0x1866C5600")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66C5CF0", Offset = "0x66C4EF0", VA = "0x1866C5CF0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x66C6AD0", Offset = "0x66C5CD0", VA = "0x1866C6AD0")]
		public void SetParent(RigidbodyEx AFCGKMGKPEF, bool OACHBGFPODN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x66C6510", Offset = "0x66C5710", VA = "0x1866C6510")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x66C5930", Offset = "0x66C4B30", VA = "0x1866C5930")]
		public bool IsRigidbodyAncestor(RigidbodyEx NKEEBDONOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x66C5A10", Offset = "0x66C4C10", VA = "0x1866C5A10")]
		public bool IsRigidbodyDescendant(RigidbodyEx AHJGELJCHPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x66C4CD0", Offset = "0x66C3ED0", VA = "0x1866C4CD0")]
		public void AddInterpolationRestriction(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66C6270", Offset = "0x66C5470", VA = "0x1866C6270")]
		public void RemoveInterpolationRestriction(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x66C5420", Offset = "0x66C4620", VA = "0x1866C5420")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x66C4D40", Offset = "0x66C3F40", VA = "0x1866C4D40")]
		public void AddKinematic(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x66C62E0", Offset = "0x66C54E0", VA = "0x1866C62E0")]
		public void RemoveKinematic(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x66C6A50", Offset = "0x66C5C50", VA = "0x1866C6A50")]
		public void SetKinematic(object COAGHPOILPB, bool JOEBDDLLKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x66C6870", Offset = "0x66C5A70", VA = "0x1866C6870")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MEALJKKBLCG, Quaternion JGOFMGKMNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x66C6770", Offset = "0x66C5970", VA = "0x1866C6770")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JNPCHGBMBBO, Quaternion JKJIMIMLIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66C5770", Offset = "0x66C4970", VA = "0x1866C5770")]
		public Vector3 GetConstrainedVelocity(Vector3 KEMDGEPABAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x66C5660", Offset = "0x66C4860", VA = "0x1866C5660")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 CLIOBNEJAAB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66C4BE0", Offset = "0x66C3DE0", VA = "0x1866C4BE0")]
		public void AddForce(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66C4AD0", Offset = "0x66C3CD0", VA = "0x1866C4AD0")]
		public void AddForceAtPosition(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66C4F10", Offset = "0x66C4110", VA = "0x1866C4F10")]
		public void AddTorque(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66C4DB0", Offset = "0x66C3FB0", VA = "0x1866C4DB0")]
		public void AddRelativeTorque(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66C6D70", Offset = "0x66C5F70", VA = "0x1866C6D70")]
		public Vector3 WorldToLocalVelocity(Vector3 MLLOGDKELNO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66C5BE0", Offset = "0x66C4DE0", VA = "0x1866C5BE0")]
		public Vector3 LocalToWorldVelocity(Vector3 HGIFAPNFCJG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66C55A0", Offset = "0x66C47A0", VA = "0x1866C55A0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66C5540", Offset = "0x66C4740", VA = "0x1866C5540")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66C54E0", Offset = "0x66C46E0", VA = "0x1866C54E0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x66C5480", Offset = "0x66C4680", VA = "0x1866C5480")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66C6670", Offset = "0x66C5870", VA = "0x1866C6670")]
		public void ResetVelocityWorldSpace(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66C6570", Offset = "0x66C5770", VA = "0x1866C6570")]
		public void ResetVelocityLocalSpace(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66C6430", Offset = "0x66C5630", VA = "0x1866C6430")]
		public void ResetLinearVelocityLocalSpace(Vector3 HCOMCEMBCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66C6C00", Offset = "0x66C5E00", VA = "0x1866C6C00")]
		public bool SweepTest(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66C5AF0", Offset = "0x66C4CF0", VA = "0x1866C5AF0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x66C6BA0", Offset = "0x66C5DA0", VA = "0x1866C6BA0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x66C6D10", Offset = "0x66C5F10", VA = "0x1866C6D10")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x66C4EA0", Offset = "0x66C40A0", VA = "0x1866C4EA0")]
		public void AddShouldHaveUnityRigidbodyToken(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x66C6350", Offset = "0x66C5550", VA = "0x1866C6350")]
		public void RemoveShouldHaveUnityRigidbodyToken(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x66C5240", Offset = "0x66C4440", VA = "0x1866C5240")]
		public void ApplyForceVelocityChange(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x66C51A0", Offset = "0x66C43A0", VA = "0x1866C51A0")]
		public void ApplyAngularVelocityChange(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x66C5300", Offset = "0x66C4500", VA = "0x1866C5300")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x66C50D0", Offset = "0x66C42D0", VA = "0x1866C50D0")]
		public bool AllowedScaleChange(float KCFKDECNACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x66C5000", Offset = "0x66C4200", VA = "0x1866C5000")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CFJMMDBBHEN, object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66C63C0", Offset = "0x66C55C0", VA = "0x1866C63C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object COAGHPOILPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x66C6F10", Offset = "0x66C6110", VA = "0x1866C6F10")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class MCINHHIELMC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x66BE4F0", Offset = "0x66BD6F0", VA = "0x1866BE4F0")]
	public static AAMLDJKKPKC EPECBIPPACC(this RigidbodyEx DMHIFOLACBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DJKKNABJKJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody BAGPDHKCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView JJDFLLPKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 HIJPCOCMPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 AGFBIEEGBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public KJKPFOPHGBD BPILJBAMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool LHPEBHEKEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool OGOIAPJGLOH;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KGDBDLGNBOK(typeof(FAHMOEHBCEC), new string[] { })]
public class DBLDIPCHAMB : FAHMOEHBCEC, IMCONFKMEBH
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly DNCJPFEBFGD COBKBPPCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MKEOHMFACBN HFKBKHJLEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private PEMPDFNPLIG NJKFJGHCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EIMFGMBBGEG HMHKKELLDMB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PEMPDFNPLIG CMLLGLPPPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EIMFGMBBGEG MNIKGFKFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x66AAF90", Offset = "0x66AA190", VA = "0x1866AAF90", Slot = "8")]
	public void InitReferences(JPALHOCNDEE IKNBEMPINKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66AACE0", Offset = "0x66A9EE0", VA = "0x1866AACE0", Slot = "6")]
	public HOKEHDIBKGC ELAFDKOGGEO(RigidbodyEx DMHIFOLACBC)
	{
		return default(HOKEHDIBKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x66AAC10", Offset = "0x66A9E10", VA = "0x1866AAC10")]
	private static HOKEHDIBKGC EIJBCJLNLBC(RigidbodyEx DMHIFOLACBC)
	{
		return default(HOKEHDIBKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x66AB020", Offset = "0x66AA220", VA = "0x1866AB020", Slot = "7")]
	public AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DBLDIPCHAMB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static DIKKIJJDOON UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BFAPFOIIPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int LDPAOJHGCGC;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x66C48C0", Offset = "0x66C3AC0", VA = "0x1866C48C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66C4900", Offset = "0x66C3B00", VA = "0x1866C4900")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x66C48E0", Offset = "0x66C3AE0", VA = "0x1866C48E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LFMFEFFGFLH, [Optional] UnityEngine.Object HFFDKMJEBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LFMFEFFGFLH, [Optional] UnityEngine.Object HFFDKMJEBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x66C4A10", Offset = "0x66C3C10", VA = "0x1866C4A10")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OCDCNIENFAL
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x66C4600", Offset = "0x66C3800", VA = "0x1866C4600")]
	public static void DKKJEEFDGFI(this Rigidbody BLKLLJOIABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x66C4790", Offset = "0x66C3990", VA = "0x1866C4790")]
	public static void DKKJEEFDGFI(this Rigidbody BLKLLJOIABB, Vector3 GNMNKEJEJNB, Quaternion PMIAEMCEJBN, Vector3 JIENFPDEJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xCAE5F0", Offset = "0xCAD7F0", VA = "0x180CAE5F0")]
	public static void AKLKIPPFIBP(Vector3 KEMDGEPABAD, Vector3 NNFMJLGEBBE, [Out] Vector3 JFOIGCFBKPP, [Out] Vector3 OJJLMALEFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AOGPPMCLEJE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class BDGJJFECHLD : PIHLMFDNIMC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CAB90", VA = "0x1807CB990", Slot = "4")]
		public Vector3 MLHENBPGNFJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CAB90", VA = "0x1807CB990", Slot = "5")]
		public Vector3 HGJPIPFIOFP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public BDGJJFECHLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static PIHLMFDNIMC FHFHCHKEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x66A31F0", Offset = "0x66A23F0", VA = "0x1866A31F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PBONIJCKOHB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode IAJFNJHMJEN
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
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCIFEJPNLJP(bool KIEBCEKHBFD);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHFEDDGHOJN(bool KIEBCEKHBFD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FFCINEEMPFK : IDisposable, FACFHHGFGIB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADDAPIJFNFE();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CLCNDOBGJIN(EFJALHABEDM.Application)]
public interface EIMFGMBBGEG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCAHLNBGKAP EBLDMJMLPML(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCHDLDIOOGL KGLJINLMINO(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPPEKLELCNC GECLMHBIMNA(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJFGBDMANDP ODKOFKNMOAC(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HJJOEOPBEBP HHBACEOBNIK(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FFCINEEMPFK JFJFHIDKLFM(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KLKLJHDBGCJ IHJMIMGNGJI(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NEEBFDJPBHJ MKOJCLLCPKF(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PBONIJCKOHB HEBFKPILLPH(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EHEBJDCJENF OGGNHODOGLL(AAMLDJKKPKC BFLJLPICFCB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OAGLJJPDCEO IGMMNIELFEI(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BBMGGMPAAMA KFKINNEHMHN(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NOBMICLGHLL ALPADPFMNOA(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DAAADMHPHOE ECDPDOLOELO(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NKCGLECIEKE CGMKKHFHJKC(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH, FAHMOEHBCEC HOHFFEHOKPA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NEEBFDJPBHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EHEBJDCJENF
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MOLEGGHOFEJ
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
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NCAHLNBGKAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EIGGMKBCEMC EMIACKFKMHG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EIGGMKBCEMC DACGLNGCBEF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event NICIGNFICLC LCNAIINCNKB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PPEFDCGLHOO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action FPLGCFLNLIG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AAMLDJKKPKC> OHIBMHKBCFN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<AAMLDJKKPKC> OKAEFEFFLIO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action HGMIJKGKKJG;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<AAMLDJKKPKC> LGFPMGPJHME;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CFGCOMIMMEO(AAMLDJKKPKC IKEECPHGAFL, bool OACHBGFPODN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DPPEKLELCNC
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEBDJNKKPEE(AAMLDJKKPKC DMKJLMNBOME, object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJELAEKBBKP(object COAGHPOILPB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DAAADMHPHOE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EIGGMKBCEMC FKAOKLALAOE;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FCBGHAAPDEB();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NPPDHJCFGOC();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PHECOPHNJED();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AGGMGFNLAJP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NOBMICLGHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJLFJCLKDGC(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJNHHILMCOF(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHMKFOHHPPB(AAMLDJKKPKC DMHIFOLACBC);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDPNJKECJJL(AAMLDJKKPKC DMHIFOLACBC);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFADBGBKGJE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KLKLJHDBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EIGGMKBCEMC LMFFNALGNOO;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POGJPAONAEG();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGBEIHFOEIF(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECEPEBKKFPM(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable IPGPELOKJHB();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PEKCMKANOMI(Rigidbody MILIHKPJLEL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BBMGGMPAAMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EIGGMKBCEMC KDNNHFAAFMD;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCGCEEIAHEE(AAMLDJKKPKC DMKJLMNBOME);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBPAEDGMLDP(AAMLDJKKPKC DMKJLMNBOME);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NKCGLECIEKE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool PHNFCDHLEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints IJCFALMLMDM
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
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EJFGBDMANDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float MBNMMFHJGAE
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
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HCDONADAFPN
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NAJMEBPGFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HJJOEOPBEBP
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event EIGGMKBCEMC CHGKGHFFBPO;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBGEFFHKJJD();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADJANKLFOCD();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEOIHFENJKO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNFBBHPJKCJ();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAOFHJDNAOP();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EOAEEJGIECN(bool AGBMHBNNBPK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OAGLJJPDCEO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool AANDPPBFIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGIFMIPBMCG(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHOEMINDDPB(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFBDGIPOEHN();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBCAJOHGAJO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KCHDLDIOOGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EMCOAFNNMII(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EFKPGIBJLDG();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BJIBPBEKAFI();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PGDDJEMFPOM();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KIPKCJPGOKP();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PEKCMKANOMI(Rigidbody BAGPDHKCDEP);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 LACKBFIAPMI(Vector3 KEMDGEPABAD);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCKLKJJCDDP(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AMGNNLGHPLH(Vector3 GFJMONNBKII);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CLCNDOBGJIN(EFJALHABEDM.Application)]
public interface PEMPDFNPLIG
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LDCFEJEIACE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEIPBPAIJNO(string PLLLDOCFAPI);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPOICLGPFPO(RigidbodyEx DMHIFOLACBC, Action CEBHNDLCHED);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMGCCPCIEKH LIFODKENINA(int CHLGEKOCBOE);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HODLFKCHDBA(Vector3 NPJPGBOOHHM, float MILMMGCFNDP, Color DKDNEEAJCMI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CLCNDOBGJIN(EFJALHABEDM.Application)]
public interface FAHMOEHBCEC
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	PEMPDFNPLIG CMLLGLPPPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	EIMFGMBBGEG MNIKGFKFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOKEHDIBKGC ELAFDKOGGEO(RigidbodyEx DMHIFOLACBC);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NIDNKMLFNEL
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALGCKBMNEMN(Vector3 IPBNIBCGODG);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKHDGHKNKMO(Vector3 CLIOBNEJAAB);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMJDIGGLBJ(Vector3 IPBNIBCGODG);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKBCOFOMNFD(Vector3 CLIOBNEJAAB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PIHLMFDNIMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 MLHENBPGNFJ();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HGJPIPFIOFP();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AAMLDJKKPKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx BFFGIBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject DECAMNDLNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool LDPHOKCKEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool CLMLEGFFJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float MBNMMFHJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool MOLEGGHOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform BAFFLMDJODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 KHECFLGNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float ANEKOLEADHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float JJPGCNPBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion JNNEOFNBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 PIJKGFEDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion DANCMHBIDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints IJCFALMLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode IAJFNJHMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool OHAMAMLBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EIGGMKBCEMC EMIACKFKMHG;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EIGGMKBCEMC DACGLNGCBEF;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event NICIGNFICLC LCNAIINCNKB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event EIGGMKBCEMC KDNNHFAAFMD;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event EIGGMKBCEMC KPDPNDEFHLN;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event EIGGMKBCEMC CHGKGHFFBPO;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event EIGGMKBCEMC LMFFNALGNOO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event EIGGMKBCEMC MMBNEHCMHBM;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void PEOOPPBFKGF();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AEFGKNAJAHF();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void EEOIHFENJKO();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void CFGCOMIMMEO(AAMLDJKKPKC AFCGKMGKPEF, bool OACHBGFPODN = false);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void EBFIEKBFDNO(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void CJMHOBHCLJB(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void KIPKCJPGOKP();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void BJIBPBEKAFI();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void EFKPGIBJLDG();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void AMGNNLGHPLH(Vector3 GFJMONNBKII);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 LACKBFIAPMI(Vector3 AFCGKMGKPEF);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JLDFCEPACMP(Vector3 AFCGKMGKPEF);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PGDDJEMFPOM();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void NIIKMKFLHNC(AAMLDJKKPKC CFJMMDBBHEN, object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KGDFNKJPOGP(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NPPDHJCFGOC();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FCBGHAAPDEB();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PHECOPHNJED();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool PBGEFFHKJJD();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void BAOFHJDNAOP();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable IPGPELOKJHB();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LGBEIHFOEIF(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void ECEPEBKKFPM(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MJCKLFPJLPL(Vector3 MEALJKKBLCG, Quaternion JGOFMGKMNEJ);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void NGEELJMCNEA(Vector3 JNPCHGBMBBO, Quaternion JKJIMIMLIIO);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool AJHNOKPMMIM(float KCFKDECNACC);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void KIMPLBOBPJJ(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void DIJALPMHIBF(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void DGIFMIPBMCG(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void BHOEMINDDPB(object COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void AGGMGFNLAJP();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MDMDMAGHOPK : AAMLDJKKPKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly FAHMOEHBCEC HOHFFEHOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal NCAHLNBGKAP ILIHAOMANEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal NOBMICLGHLL BHIPDJMCNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal BBMGGMPAAMA GHODAKPHDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal KCHDLDIOOGL KEMDGEPABAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal DPPEKLELCNC JACDCGIKNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DAAADMHPHOE HOEEGIAAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal EJFGBDMANDP DABBLLHDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal EHEBJDCJENF LEMNHIPEGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal HJJOEOPBEBP FMLJFOEPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal FFCINEEMPFK EPMMEGKFFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal KLKLJHDBGCJ IKALFPMGFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal NEEBFDJPBHJ DBMLIHEKMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NKCGLECIEKE LONODJMIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal OAGLJJPDCEO BAGPDHKCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal PBONIJCKOHB KKOLAHJFPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable EGDPHJIIFLL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx BFFGIBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C93A0", Offset = "0x7C85A0", VA = "0x1807C93A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C93E0", Offset = "0x7C85E0", VA = "0x1807C93E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject DECAMNDLNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8847D0", Offset = "0x8839D0", VA = "0x1808847D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8848F0", Offset = "0x883AF0", VA = "0x1808848F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66BED10", Offset = "0x66BDF10", VA = "0x1866BED10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x66BF650", Offset = "0x66BE850", VA = "0x1866BF650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x66BE7D0", Offset = "0x66BD9D0", VA = "0x1866BE7D0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x66C4000", Offset = "0x66C3200", VA = "0x1866C4000", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x66BFA40", Offset = "0x66BEC40", VA = "0x1866BFA40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x66C07E0", Offset = "0x66BF9E0", VA = "0x1866C07E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x66C0290", Offset = "0x66BF490", VA = "0x1866C0290", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x66BF2B0", Offset = "0x66BE4B0", VA = "0x1866BF2B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x66C0DC0", Offset = "0x66BFFC0", VA = "0x1866C0DC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x66C10E0", Offset = "0x66C02E0", VA = "0x1866C10E0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x66BF030", Offset = "0x66BE230", VA = "0x1866BF030", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x66C0540", Offset = "0x66BF740", VA = "0x1866C0540", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x66C1860", Offset = "0x66C0A60", VA = "0x1866C1860", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x66C40B0", Offset = "0x66C32B0", VA = "0x1866C40B0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x66BE710", Offset = "0x66BD910", VA = "0x1866BE710", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x66C2520", Offset = "0x66C1720", VA = "0x1866C2520", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x66C3E40", Offset = "0x66C3040", VA = "0x1866C3E40", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66C3CB0", Offset = "0x66C2EB0", VA = "0x1866C3CB0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x66C4100", Offset = "0x66C3300", VA = "0x1866C4100", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x66BF3C0", Offset = "0x66BE5C0", VA = "0x1866BF3C0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x66C3330", Offset = "0x66C2530", VA = "0x1866C3330", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x66C1CA0", Offset = "0x66C0EA0", VA = "0x1866C1CA0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x66C1780", Offset = "0x66C0980", VA = "0x1866C1780", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool EMKLPIGGJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x66C29D0", Offset = "0x66C1BD0", VA = "0x1866C29D0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LDPHOKCKEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x66C0830", Offset = "0x66BFA30", VA = "0x1866C0830", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CLMLEGFFJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x66C0CE0", Offset = "0x66BFEE0", VA = "0x1866C0CE0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x66C2F00", Offset = "0x66C2100", VA = "0x1866C2F00", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x66C2A20", Offset = "0x66C1C20", VA = "0x1866C2A20", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x66C3F20", Offset = "0x66C3120", VA = "0x1866C3F20", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x66C0400", Offset = "0x66BF600", VA = "0x1866C0400", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x66C3410", Offset = "0x66C2610", VA = "0x1866C3410", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x66C08F0", Offset = "0x66BFAF0", VA = "0x1866C08F0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x66BFF50", Offset = "0x66BF150", VA = "0x1866BFF50", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x66C41E0", Offset = "0x66C33E0", VA = "0x1866C41E0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x66C1080", Offset = "0x66C0280", VA = "0x1866C1080", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x66BF090", Offset = "0x66BE290", VA = "0x1866BF090", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x66C0F60", Offset = "0x66C0160", VA = "0x1866C0F60", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x66C2D50", Offset = "0x66C1F50", VA = "0x1866C2D50", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x66BEFD0", Offset = "0x66BE1D0", VA = "0x1866BEFD0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float MBNMMFHJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x66C1030", Offset = "0x66C0230", VA = "0x1866C1030", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x66C0590", Offset = "0x66BF790", VA = "0x1866C0590", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool MOLEGGHOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x66C0F10", Offset = "0x66C0110", VA = "0x1866C0F10", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x66C2EA0", Offset = "0x66C20A0", VA = "0x1866C2EA0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x66C0A30", Offset = "0x66BFC30", VA = "0x1866C0A30", Slot = "48")]
		get
		{
			return default(CDNENJJICFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x66C4330", Offset = "0x66C3530", VA = "0x1866C4330", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x66BF5A0", Offset = "0x66BE7A0", VA = "0x1866BF5A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform BAFFLMDJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x66BF2A0", Offset = "0x66BE4A0", VA = "0x1866BF2A0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 KHECFLGNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x66BE820", Offset = "0x66BDA20", VA = "0x1866BE820", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x66C0B20", Offset = "0x66BFD20", VA = "0x1866C0B20", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float ANEKOLEADHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x66C1C80", Offset = "0x66C0E80", VA = "0x1866C1C80", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x66C01D0", Offset = "0x66BF3D0", VA = "0x1866C01D0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float JJPGCNPBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x66BEC80", Offset = "0x66BDE80", VA = "0x1866BEC80", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x66BF4A0", Offset = "0x66BE6A0", VA = "0x1866BF4A0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion JNNEOFNBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x66BFA90", Offset = "0x66BEC90", VA = "0x1866BFA90", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x66C1EC0", Offset = "0x66C10C0", VA = "0x1866C1EC0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 PIJKGFEDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66C4390", Offset = "0x66C3590", VA = "0x1866C4390", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x66BEDA0", Offset = "0x66BDFA0", VA = "0x1866BEDA0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion DANCMHBIDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x66C0AE0", Offset = "0x66BFCE0", VA = "0x1866C0AE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x66C3820", Offset = "0x66C2A20", VA = "0x1866C3820", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints IJCFALMLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x66BF7C0", Offset = "0x66BE9C0", VA = "0x1866BF7C0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x66C0A80", Offset = "0x66BFC80", VA = "0x1866C0A80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x66C0240", Offset = "0x66BF440", VA = "0x1866C0240", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x66C0C80", Offset = "0x66BFE80", VA = "0x1866C0C80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode IAJFNJHMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x66C1B30", Offset = "0x66C0D30", VA = "0x1866C1B30", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x66C2AF0", Offset = "0x66C1CF0", VA = "0x1866C2AF0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool AHIHKHMIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x66C2380", Offset = "0x66C1580", VA = "0x1866C2380", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OHAMAMLBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x66BEDF0", Offset = "0x66BDFF0", VA = "0x1866BEDF0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JJKKOGGOPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x66C0BE0", Offset = "0x66BFDE0", VA = "0x1866C0BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool NJCJMDGAJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x66C3C20", Offset = "0x66C2E20", VA = "0x1866C3C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EIGGMKBCEMC EMIACKFKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x66BF5F0", Offset = "0x66BE7F0", VA = "0x1866BF5F0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x66C24C0", Offset = "0x66C16C0", VA = "0x1866C24C0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EIGGMKBCEMC DACGLNGCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x66BF240", Offset = "0x66BE440", VA = "0x1866BF240", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x66C04E0", Offset = "0x66BF6E0", VA = "0x1866C04E0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event NICIGNFICLC LCNAIINCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x66C06A0", Offset = "0x66BF8A0", VA = "0x1866C06A0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x66C18C0", Offset = "0x66C0AC0", VA = "0x1866C18C0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event EIGGMKBCEMC KDNNHFAAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x66C3C50", Offset = "0x66C2E50", VA = "0x1866C3C50", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x66C1920", Offset = "0x66C0B20", VA = "0x1866C1920", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event EIGGMKBCEMC KPDPNDEFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x66C0890", Offset = "0x66BFA90", VA = "0x1866C0890", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x66BF6A0", Offset = "0x66BE8A0", VA = "0x1866BF6A0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event EIGGMKBCEMC CHGKGHFFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x66BF700", Offset = "0x66BE900", VA = "0x1866BF700", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x66C1D80", Offset = "0x66C0F80", VA = "0x1866C1D80", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x66C4280", Offset = "0x66C3480", VA = "0x1866C4280", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x66BF760", Offset = "0x66BE960", VA = "0x1866BF760", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event EIGGMKBCEMC LMFFNALGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x66C09D0", Offset = "0x66BFBD0", VA = "0x1866C09D0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x66C2190", Offset = "0x66C1390", VA = "0x1866C2190", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event EIGGMKBCEMC MMBNEHCMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x66C3D90", Offset = "0x66C2F90", VA = "0x1866C3D90", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x66C3130", Offset = "0x66C2330", VA = "0x1866C3130", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x66B5780", Offset = "0x66B4980", VA = "0x1866B5780")]
	public MDMDMAGHOPK(GameObject JLBELLDLMIF, RigidbodyEx FIMHFGAEEIE, FAHMOEHBCEC HOHFFEHOKPA, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66BFB40", Offset = "0x66BED40", VA = "0x1866BFB40", Slot = "135")]
	protected virtual void ENEACFFBFJC(FAHMOEHBCEC HOHFFEHOKPA, DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x66BF810", Offset = "0x66BEA10", VA = "0x1866BF810", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x66BE560", Offset = "0x66BD760", VA = "0x1866BE560", Slot = "71")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66C1AE0", Offset = "0x66C0CE0", VA = "0x1866C1AE0", Slot = "72")]
	public void PEOOPPBFKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x66BE6A0", Offset = "0x66BD8A0", VA = "0x1866BE6A0", Slot = "73")]
	public void AEFGKNAJAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x66C2920", Offset = "0x66C1B20", VA = "0x1866C2920")]
	private void MAKJOECJKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BDEA0", VA = "0x1866BECA0", Slot = "81")]
	public void CFGCOMIMMEO(AAMLDJKKPKC AFCGKMGKPEF, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x66BF8E0", Offset = "0x66BEAE0", VA = "0x1866BF8E0", Slot = "84")]
	public void EBFIEKBFDNO(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x66BEF70", Offset = "0x66BE170", VA = "0x1866BEF70", Slot = "85")]
	public void CJMHOBHCLJB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x66C15A0", Offset = "0x66C07A0", VA = "0x1866C15A0", Slot = "86")]
	public Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x66C3720", Offset = "0x66C2920", VA = "0x1866C3720", Slot = "87")]
	public Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x66C1AE0", Offset = "0x66C0CE0", VA = "0x1866C1AE0", Slot = "88")]
	public void KIPKCJPGOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x66BEC30", Offset = "0x66BDE30", VA = "0x1866BEC30", Slot = "89")]
	public void BJIBPBEKAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x66BF9F0", Offset = "0x66BEBF0", VA = "0x1866BF9F0", Slot = "90")]
	public void EFKPGIBJLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x66C21F0", Offset = "0x66C13F0", VA = "0x1866C21F0", Slot = "91")]
	public void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x66BEAE0", Offset = "0x66BDCE0", VA = "0x1866BEAE0", Slot = "92")]
	public void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x66BE8D0", Offset = "0x66BDAD0", VA = "0x1866BE8D0", Slot = "93")]
	public void AMGNNLGHPLH(Vector3 GFJMONNBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x66C0110", Offset = "0x66BF310", VA = "0x1866C0110", Slot = "94")]
	public void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x66C19E0", Offset = "0x66C0BE0", VA = "0x1866C19E0", Slot = "95")]
	public void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x66C0E60", Offset = "0x66C0060", VA = "0x1866C0E60", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x66C1B80", Offset = "0x66C0D80", VA = "0x1866C1B80", Slot = "97")]
	public Vector3 LACKBFIAPMI(Vector3 AFCGKMGKPEF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x66C1130", Offset = "0x66C0330", VA = "0x1866C1130", Slot = "98")]
	public Vector3 JLDFCEPACMP(Vector3 AFCGKMGKPEF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x66C4230", Offset = "0x66C3430", VA = "0x1866C4230", Slot = "99")]
	public void PGDDJEMFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x66C36B0", Offset = "0x66C28B0", VA = "0x1866C36B0", Slot = "100")]
	public void NIIKMKFLHNC(AAMLDJKKPKC CFJMMDBBHEN, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x66C1980", Offset = "0x66C0B80", VA = "0x1866C1980", Slot = "101")]
	public void KGDFNKJPOGP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x66C0700", Offset = "0x66BF900", VA = "0x1866C0700", Slot = "41")]
	public void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x66C3BD0", Offset = "0x66C2DD0", VA = "0x1866C3BD0", Slot = "104")]
	public void NPPDHJCFGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x66BFF00", Offset = "0x66BF100", VA = "0x1866BFF00", Slot = "105")]
	public void FCBGHAAPDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x66C42E0", Offset = "0x66C34E0", VA = "0x1866C42E0", Slot = "106")]
	public void PHECOPHNJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x66C4060", Offset = "0x66C3260", VA = "0x1866C4060", Slot = "109")]
	public bool PBGEFFHKJJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x66BF9A0", Offset = "0x66BEBA0", VA = "0x1866BF9A0", Slot = "74")]
	public void EEOIHFENJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x66BEA90", Offset = "0x66BDC90", VA = "0x1866BEA90", Slot = "110")]
	public void BAOFHJDNAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x66C0E10", Offset = "0x66C0010", VA = "0x1866C0E10", Slot = "115")]
	public IDisposable IPGPELOKJHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x66C2090", Offset = "0x66C1290", VA = "0x1866C2090", Slot = "116")]
	public void LGBEIHFOEIF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x66BF940", Offset = "0x66BEB40", VA = "0x1866BF940", Slot = "117")]
	public void ECEPEBKKFPM(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x66C3860", Offset = "0x66C2A60", VA = "0x1866C3860", Slot = "118")]
	public void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x66C2B50", Offset = "0x66C1D50", VA = "0x1866C2B50", Slot = "121")]
	public void MJCKLFPJLPL(Vector3 MEALJKKBLCG, Quaternion JGOFMGKMNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x66C31E0", Offset = "0x66C23E0", VA = "0x1866C31E0", Slot = "122")]
	public void NGEELJMCNEA(Vector3 JNPCHGBMBBO, Quaternion JKJIMIMLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x66BE770", Offset = "0x66BD970", VA = "0x1866BE770", Slot = "123")]
	public bool AJHNOKPMMIM(float KCFKDECNACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x66C1A80", Offset = "0x66C0C80", VA = "0x1866C1A80", Slot = "124")]
	public void KIMPLBOBPJJ(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x66BF360", Offset = "0x66BE560", VA = "0x1866BF360", Slot = "125")]
	public void DIJALPMHIBF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x66BF300", Offset = "0x66BE500", VA = "0x1866BF300", Slot = "126")]
	public void DGIFMIPBMCG(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x66BEBD0", Offset = "0x66BDDD0", VA = "0x1866BEBD0", Slot = "127")]
	public void BHOEMINDDPB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x66C1DE0", Offset = "0x66C0FE0", VA = "0x1866C1DE0", Slot = "128")]
	public void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x66C3AC0", Offset = "0x66C2CC0", VA = "0x1866C3AC0", Slot = "129")]
	public void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x66BE9B0", Offset = "0x66BDBB0", VA = "0x1866BE9B0", Slot = "130")]
	public void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x66C1FB0", Offset = "0x66C11B0", VA = "0x1866C1FB0", Slot = "131")]
	public void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x66C20F0", Offset = "0x66C12F0", VA = "0x1866C20F0", Slot = "132")]
	public bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x66BE6C0", Offset = "0x66BD8C0", VA = "0x1866BE6C0", Slot = "133")]
	public void AGGMGFNLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x66C43E0", Offset = "0x66C35E0", VA = "0x1866C43E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x66C16A0", Offset = "0x66C08A0", VA = "0x1866C16A0")]
	private void JOGKHKDAJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x66C02F0", Offset = "0x66BF4F0", VA = "0x1866C02F0")]
	private void FNCBLLIEDMN(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x66C38D0", Offset = "0x66C2AD0", VA = "0x1866C38D0")]
	private void NNPFDHHIFPD(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x66C05F0", Offset = "0x66BF7F0", VA = "0x1866C05F0")]
	private void GIBAIFDKOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x66C2DA0", Offset = "0x66C1FA0", VA = "0x1866C2DA0")]
	private void MOPHCIFMAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x66C2F50", Offset = "0x66C2150", VA = "0x1866C2F50")]
	private void NCPKPBJCONJ(AAMLDJKKPKC IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x66BF170", Offset = "0x66BE370", VA = "0x1866BF170")]
	private void DCGCEEIAHEE(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x66BFE30", Offset = "0x66BF030", VA = "0x1866BFE30")]
	private void FBPAEDGMLDP(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x66BFFA0", Offset = "0x66BF1A0", VA = "0x1866BFFA0")]
	private void FDPMEJLKENG(RigidbodyEx DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x66C34F0", Offset = "0x66C26F0", VA = "0x1866C34F0", Slot = "140")]
	protected virtual void NHJFCFOJCFA(RigidbodyEx DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x66C2600", Offset = "0x66C1800", VA = "0x1866C2600")]
	protected void MAFIGAAPKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x66C1230", Offset = "0x66C0430", VA = "0x1866C1230")]
	protected void JNJMMLMAOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x66C22E0", Offset = "0x66C14E0", VA = "0x1866C22E0", Slot = "141")]
	protected virtual IDisposable LMPKFPLIDFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class MCEMICKAJPD
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x66BE340", Offset = "0x66BD540", VA = "0x1866BE340")]
	public static AAMLDJKKPKC FANNGOHEPKB(this AAMLDJKKPKC DMHIFOLACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x66BE470", Offset = "0x66BD670", VA = "0x1866BE470")]
	public static bool OIOICFAGLGG(this AAMLDJKKPKC DMHIFOLACBC, AAMLDJKKPKC NKEEBDONOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x66BE270", Offset = "0x66BD470", VA = "0x1866BE270")]
	public static bool BCBDHHDHOAA(this AAMLDJKKPKC DMHIFOLACBC, AAMLDJKKPKC AHJGELJCHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x66BE2F0", Offset = "0x66BD4F0", VA = "0x1866BE2F0")]
	public static RigidbodyEx BFFGIBJAJFM(this AAMLDJKKPKC EPECBIPPACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x66BE3F0", Offset = "0x66BD5F0", VA = "0x1866BE3F0")]
	public static MDMDMAGHOPK MMHJCPAIHCP(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class NJCKPHLECJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool OLAHAMNIKKD;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x66C4580", Offset = "0x66C3780", VA = "0x1866C4580")]
	public NJCKPHLECJA(MDMDMAGHOPK PGPFOODFIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x66C4520", Offset = "0x66C3720", VA = "0x1866C4520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class LHADBPMACEG : EBEDLFBNCPI, PBONIJCKOHB
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode PFMAKDCKMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x66B9610", Offset = "0x66B8810", VA = "0x1866B9610")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x66B9670", Offset = "0x66B8870", VA = "0x1866B9670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode IAJFNJHMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x66B9860", Offset = "0x66B8A60", VA = "0x1866B9860", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x66B9AD0", Offset = "0x66B8CD0", VA = "0x1866B9AD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public LHADBPMACEG(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x66B94B0", Offset = "0x66B86B0", VA = "0x1866B94B0", Slot = "6")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x66B9B90", Offset = "0x66B8D90", VA = "0x1866B9B90", Slot = "9")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x66B9850", Offset = "0x66B8A50", VA = "0x1866B9850", Slot = "7")]
	public void KCIFEJPNLJP(bool KIEBCEKHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x66B9600", Offset = "0x66B8800", VA = "0x1866B9600", Slot = "8")]
	public void BHFEDDGHOJN(bool KIEBCEKHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66B9970", Offset = "0x66B8B70", VA = "0x1866B9970", Slot = "10")]
	public bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x66B96E0", Offset = "0x66B88E0", VA = "0x1866B96E0")]
	private void HMHGCPJIDCM(bool KIEBCEKHBFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LNJPJMPFPIF : EBEDLFBNCPI, FFCINEEMPFK, IDisposable, FACFHHGFGIB
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CDNENJJICFO CNKGPAEOMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x66BBEF0", Offset = "0x66BB0F0", VA = "0x1866BBEF0")]
		get
		{
			return default(CDNENJJICFO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x66BBC00", Offset = "0x66BAE00", VA = "0x1866BBC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x66BBCF0", Offset = "0x66BAEF0", VA = "0x1866BBCF0", Slot = "6")]
		get
		{
			return default(CDNENJJICFO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x66BBC00", Offset = "0x66BAE00", VA = "0x1866BBC00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform NAKHPFOBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x66BBFF0", Offset = "0x66BB1F0", VA = "0x1866BBFF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x66BBB50", Offset = "0x66BAD50", VA = "0x1866BBB50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public LNJPJMPFPIF(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x66BBFD0", Offset = "0x66BB1D0", VA = "0x1866BBFD0", Slot = "11")]
	public void OnChangedDistanceBand(OCINGNKOJDN NLOPLOLDAHH, OCINGNKOJDN DDFNLJOOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "12")]
	public void OnChangedVisibility(bool MEDFHLPAELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "8")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class KGPLBCOBNLD : EBEDLFBNCPI, NEEBFDJPBHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x66A82E0", Offset = "0x66A74E0", VA = "0x1866A82E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x66A8330", Offset = "0x66A7530", VA = "0x1866A8330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x66B72E0", Offset = "0x66B64E0", VA = "0x1866B72E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public KGPLBCOBNLD(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x66B7860", Offset = "0x66B6A60", VA = "0x1866B7860", Slot = "4")]
	public void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x66B7580", Offset = "0x66B6780", VA = "0x1866B7580")]
	private void HGAENGCMAPB(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x66B7C20", Offset = "0x66B6E20", VA = "0x1866B7C20", Slot = "5")]
	public void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x66B7340", Offset = "0x66B6540", VA = "0x1866B7340", Slot = "6")]
	public void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x66B7EA0", Offset = "0x66B70A0", VA = "0x1866B7EA0")]
	private void PPMHPBJAGGD(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x66B79C0", Offset = "0x66B6BC0", VA = "0x1866B79C0", Slot = "7")]
	public void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x66B74A0", Offset = "0x66B66A0", VA = "0x1866B74A0")]
	private void BHODMEFJDOG(string LFMFEFFGFLH, UnityEngine.Object HFFDKMJEBIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DOAACBNDCFH : EBEDLFBNCPI, EHEBJDCJENF
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MOLEGGHOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x66AD390", Offset = "0x66AC590", VA = "0x1866AD390", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x66AD3F0", Offset = "0x66AC5F0", VA = "0x1866AD3F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public DOAACBNDCFH(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x66AD540", Offset = "0x66AC740", VA = "0x1866AD540", Slot = "6")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x66AD320", Offset = "0x66AC520", VA = "0x1866AD320", Slot = "7")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LOPLILNLGIE : EBEDLFBNCPI, NCAHLNBGKAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly DNCJPFEBFGD JGFABAJDCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KPDODDMAALK KJEKNCNLFKH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x66BC570", Offset = "0x66BB770", VA = "0x1866BC570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public HOKEHDIBKGC KJKOLEEIAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x66BC440", Offset = "0x66BB640", VA = "0x1866BC440")]
		get
		{
			return default(HOKEHDIBKGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x66BCD50", Offset = "0x66BBF50", VA = "0x1866BCD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x66BC140", Offset = "0x66BB340", VA = "0x1866BC140", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x66BDBD0", Offset = "0x66BCDD0", VA = "0x1866BDBD0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public HOKEHDIBKGC KFAPGJFLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x66BD880", Offset = "0x66BCA80", VA = "0x1866BD880")]
		get
		{
			return default(HOKEHDIBKGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x66BD8E0", Offset = "0x66BCAE0", VA = "0x1866BD8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x66BCE60", Offset = "0x66BC060", VA = "0x1866BCE60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFD0", Offset = "0x7BD1D0", VA = "0x1807BDFD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EIGGMKBCEMC EMIACKFKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x66BC830", Offset = "0x66BBA30", VA = "0x1866BC830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x66BD9F0", Offset = "0x66BCBF0", VA = "0x1866BD9F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EIGGMKBCEMC DACGLNGCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x66BC790", Offset = "0x66BB990", VA = "0x1866BC790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x66BCCB0", Offset = "0x66BBEB0", VA = "0x1866BCCB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NICIGNFICLC LCNAIINCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x66BCDC0", Offset = "0x66BBFC0", VA = "0x1866BCDC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x66BD7E0", Offset = "0x66BC9E0", VA = "0x1866BD7E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PPEFDCGLHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5A0", Offset = "0x66BB7A0", VA = "0x1866BC5A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x66BC0A0", Offset = "0x66BB2A0", VA = "0x1866BC0A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action FPLGCFLNLIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x66BCC10", Offset = "0x66BBE10", VA = "0x1866BCC10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x66BDB30", Offset = "0x66BCD30", VA = "0x1866BDB30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<AAMLDJKKPKC> OHIBMHKBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x66BC6E0", Offset = "0x66BB8E0", VA = "0x1866BC6E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x66BCB60", Offset = "0x66BBD60", VA = "0x1866BCB60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<AAMLDJKKPKC> OKAEFEFFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x66BC8D0", Offset = "0x66BBAD0", VA = "0x1866BC8D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x66BD440", Offset = "0x66BC640", VA = "0x1866BD440", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HGMIJKGKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x66BD4F0", Offset = "0x66BC6F0", VA = "0x1866BD4F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x66BC640", Offset = "0x66BB840", VA = "0x1866BC640", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<AAMLDJKKPKC> LGFPMGPJHME
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x66BC390", Offset = "0x66BB590", VA = "0x1866BC390", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x66BDE40", Offset = "0x66BD040", VA = "0x1866BDE40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x66BDF80", Offset = "0x66BD180", VA = "0x1866BDF80")]
	public LOPLILNLGIE(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x66BC980", Offset = "0x66BBB80", VA = "0x1866BC980", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x66BC4F0", Offset = "0x66BB6F0", VA = "0x1866BC4F0", Slot = "26")]
	public void CFGCOMIMMEO(AAMLDJKKPKC IKEECPHGAFL, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x66BC4A0", Offset = "0x66BB6A0", VA = "0x1866BC4A0")]
	private void CFGCOMIMMEO(IDAPKFDEAHA IKEECPHGAFL, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x66BCFC0", Offset = "0x66BC1C0", VA = "0x1866BCFC0")]
	private void HPOFHMMNGLG(IDAPKFDEAHA IKEECPHGAFL, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x66BD590", Offset = "0x66BC790", VA = "0x1866BD590")]
	private void KALLGKPIBKN(IDAPKFDEAHA IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x66BDC40", Offset = "0x66BCE40", VA = "0x1866BDC40")]
	private void PEPIGOHALLG(IDAPKFDEAHA IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x66BC1B0", Offset = "0x66BB3B0", VA = "0x1866BC1B0")]
	private void BGAEBOGDJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x66BCAB0", Offset = "0x66BBCB0", VA = "0x1866BCAB0")]
	private void EBAFCBEDOFE(IDAPKFDEAHA IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x66BCED0", Offset = "0x66BC0D0", VA = "0x1866BCED0")]
	private void HIBEIGGJODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x66BD950", Offset = "0x66BCB50", VA = "0x1866BD950")]
	private void LNMODEGKMKK(IDAPKFDEAHA DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x66BDA90", Offset = "0x66BCC90", VA = "0x1866BDA90")]
	private void MKOGKBDJAAK(IDAPKFDEAHA DMHIFOLACBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JBCMDEJPPDG
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x66B5E00", Offset = "0x66B5000", VA = "0x1866B5E00")]
	public static LOPLILNLGIE PLHOOJFIBBL(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class CJPPGOIELBJ : EBEDLFBNCPI, DPPEKLELCNC
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x66A96F0", Offset = "0x66A88F0", VA = "0x1866A96F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x66A9880", Offset = "0x66A8A80", VA = "0x1866A9880", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x66A8F20", Offset = "0x66A8120", VA = "0x1866A8F20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private AAMLDJKKPKC NBNOJPPOLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x66A9720", Offset = "0x66A8920", VA = "0x1866A9720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public CJPPGOIELBJ(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x66A9490", Offset = "0x66A8690", VA = "0x1866A9490", Slot = "6")]
	public void MEBDJNKKPEE(AAMLDJKKPKC DMKJLMNBOME, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x66A95E0", Offset = "0x66A87E0", VA = "0x1866A95E0")]
	private void MEBDJNKKPEE(IDAPKFDEAHA DMKJLMNBOME, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x66A9420", Offset = "0x66A8620", VA = "0x1866A9420", Slot = "7")]
	public void JJELAEKBBKP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x66A9010", Offset = "0x66A8210", VA = "0x1866A9010")]
	private Vector3 FACOJIILAOC()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class FNFOPJJOGGP
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x66B21B0", Offset = "0x66B13B0", VA = "0x1866B21B0")]
	public static CJPPGOIELBJ KMPJJCOFMMH(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CDAHHILDFDM : EBEDLFBNCPI, DAAADMHPHOE
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x66A5C60", Offset = "0x66A4E60", VA = "0x1866A5C60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x66A7540", Offset = "0x66A6740", VA = "0x1866A7540", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 NCHKEEHGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x66A5740", Offset = "0x66A4940", VA = "0x1866A5740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 MIIILPHAKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x66A76C0", Offset = "0x66A68C0", VA = "0x1866A76C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x66A7320", Offset = "0x66A6520", VA = "0x1866A7320", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x66A5B40", Offset = "0x66A4D40", VA = "0x1866A5B40", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float FFCBBIMOCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x66A4F70", Offset = "0x66A4170", VA = "0x1866A4F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x66A7AC0", Offset = "0x66A6CC0", VA = "0x1866A7AC0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x66A5BA0", Offset = "0x66A4DA0", VA = "0x1866A5BA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x66A4FF0", Offset = "0x66A41F0", VA = "0x1866A4FF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x66A7510", Offset = "0x66A6710", VA = "0x1866A7510", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event EIGGMKBCEMC FKAOKLALAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x66A77F0", Offset = "0x66A69F0", VA = "0x1866A77F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x66A56A0", Offset = "0x66A48A0", VA = "0x1866A56A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x66A7E30", Offset = "0x66A7030", VA = "0x1866A7E30")]
	public CDAHHILDFDM(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x66A5FA0", Offset = "0x66A51A0", VA = "0x1866A5FA0")]
	public float3 HGCCINHHFCE()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x66A5D10", Offset = "0x66A4F10", VA = "0x1866A5D10", Slot = "14")]
	public void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x66A7890", Offset = "0x66A6A90", VA = "0x1866A7890", Slot = "16")]
	public void NPPDHJCFGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x66A57F0", Offset = "0x66A49F0", VA = "0x1866A57F0", Slot = "15")]
	public void FCBGHAAPDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x66A7B20", Offset = "0x66A6D20", VA = "0x1866A7B20", Slot = "18")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x66A52B0", Offset = "0x66A44B0", VA = "0x1866A52B0", Slot = "19")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x66A7BF0", Offset = "0x66A6DF0", VA = "0x1866A7BF0", Slot = "17")]
	public void PHECOPHNJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x66A4710", Offset = "0x66A3910", VA = "0x1866A4710", Slot = "20")]
	public void AGGMGFNLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x66A7A80", Offset = "0x66A6C80", VA = "0x1866A7A80")]
	public void OHEPABOHCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x66A7540", Offset = "0x66A6740", VA = "0x1866A7540")]
	private void KNDPOLKOOIC(Vector3 AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x66A7C50", Offset = "0x66A6E50", VA = "0x1866A7C50")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 PJLGNOIBGGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x66A5BA0", Offset = "0x66A4DA0", VA = "0x1866A5BA0")]
	private void FHDKBOAHBCL(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x66A4D10", Offset = "0x66A3F10", VA = "0x1866A4D10")]
	private Vector3 ANONJCGCPOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x66A5070", Offset = "0x66A4270", VA = "0x1866A5070")]
	private Quaternion DOOFBNCFDOM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x66A60C0", Offset = "0x66A52C0", VA = "0x1866A60C0")]
	internal (float, Vector3) HGFFJHLKNDD(Rigidbody FOHBGACELDD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class KMGFOBODHLM
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x66B8150", Offset = "0x66B7350", VA = "0x1866B8150")]
	public static CDAHHILDFDM BCBONFHHEPH(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LCBBNEPANNM : EBEDLFBNCPI, NOBMICLGHLL
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool JIEILAHJDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x66B8610", Offset = "0x66B7810", VA = "0x1866B8610", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PMDABCIAEAH AKDDLKKPGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x66B89E0", Offset = "0x66B7BE0", VA = "0x1866B89E0", Slot = "11")]
		get
		{
			return default(PMDABCIAEAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private PMDABCIAEAH NLJIPINGJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x66B89E0", Offset = "0x66B7BE0", VA = "0x1866B89E0")]
		get
		{
			return default(PMDABCIAEAH);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x66B88F0", Offset = "0x66B7AF0", VA = "0x1866B88F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x66B8DA0", Offset = "0x66B7FA0", VA = "0x1866B8DA0")]
	public LCBBNEPANNM(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x66B8490", Offset = "0x66B7690", VA = "0x1866B8490", Slot = "4")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x66B8670", Offset = "0x66B7870", VA = "0x1866B8670")]
	private bool EEFHACKHGFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x66B8960", Offset = "0x66B7B60", VA = "0x1866B8960", Slot = "5")]
	public void FJLFJCLKDGC(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x66B8D20", Offset = "0x66B7F20", VA = "0x1866B8D20", Slot = "6")]
	public void NJNHHILMCOF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x66B8B40", Offset = "0x66B7D40", VA = "0x1866B8B40", Slot = "9")]
	public void MFADBGBKGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x66B8A40", Offset = "0x66B7C40", VA = "0x1866B8A40")]
	private void KLBDLKOPNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x66B8750", Offset = "0x66B7950", VA = "0x1866B8750")]
	private void FAMNJDIECGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x66B8CA0", Offset = "0x66B7EA0", VA = "0x1866B8CA0", Slot = "8")]
	public void NDPNJKECJJL(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x66B8590", Offset = "0x66B7790", VA = "0x1866B8590", Slot = "7")]
	public void CHMKFOHHPPB(AAMLDJKKPKC DMHIFOLACBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JJINEMONGMO : EBEDLFBNCPI, KLKLJHDBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x66B5FB0", Offset = "0x66B51B0", VA = "0x1866B5FB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool DIKAMINAIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x66B5F50", Offset = "0x66B5150", VA = "0x1866B5F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event EIGGMKBCEMC LMFFNALGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x66B6100", Offset = "0x66B5300", VA = "0x1866B6100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x66B6220", Offset = "0x66B5420", VA = "0x1866B6220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public JJINEMONGMO(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x66B61A0", Offset = "0x66B53A0", VA = "0x1866B61A0", Slot = "11")]
	public IDisposable IPGPELOKJHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x66B6210", Offset = "0x66B5410", VA = "0x1866B6210", Slot = "8")]
	public void LGBEIHFOEIF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x66B6010", Offset = "0x66B5210", VA = "0x1866B6010", Slot = "9")]
	public void ECEPEBKKFPM(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x66B62C0", Offset = "0x66B54C0", VA = "0x1866B62C0", Slot = "10")]
	public void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x66B63C0", Offset = "0x66B55C0", VA = "0x1866B63C0", Slot = "12")]
	public void PEKCMKANOMI(Rigidbody MILIHKPJLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x66B6020", Offset = "0x66B5220", VA = "0x1866B6020", Slot = "13")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x66A7A80", Offset = "0x66A6C80", VA = "0x1866A7A80", Slot = "6")]
	public void POGJPAONAEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class FCBIHGGHNJJ : EBEDLFBNCPI, BBMGGMPAAMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView JJDFLLPKHMB;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x66B19C0", Offset = "0x66B0BC0", VA = "0x1866B19C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x66B1D40", Offset = "0x66B0F40", VA = "0x1866B1D40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event EIGGMKBCEMC KDNNHFAAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x66B2050", Offset = "0x66B1250", VA = "0x1866B2050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x66B1FB0", Offset = "0x66B11B0", VA = "0x1866B1FB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x66B20F0", Offset = "0x66B12F0", VA = "0x1866B20F0")]
	public FCBIHGGHNJJ(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x66B1380", Offset = "0x66B0580", VA = "0x1866B1380", Slot = "8")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x66B19E0", Offset = "0x66B0BE0", VA = "0x1866B19E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x66B17C0", Offset = "0x66B09C0", VA = "0x1866B17C0", Slot = "9")]
	public void DCGCEEIAHEE(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x66B1B40", Offset = "0x66B0D40", VA = "0x1866B1B40", Slot = "10")]
	public void FBPAEDGMLDP(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x66B1DD0", Offset = "0x66B0FD0", VA = "0x1866B1DD0")]
	private void JNLOOFLKAFN(PhotonView GFKJEFBENCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x66B1670", Offset = "0x66B0870", VA = "0x1866B1670")]
	private void CBNMGJPKFHC(RigidbodyEx CAEKHECDJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x66B14B0", Offset = "0x66B06B0", VA = "0x1866B14B0")]
	private void BPKHABKKCPB(PhotonView FMGKMADFFHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class GKOKPKBKCII
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x66B2D50", Offset = "0x66B1F50", VA = "0x1866B2D50")]
	public static FCBIHGGHNJJ BFEKEJOHKMH(this MDMDMAGHOPK BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class LDAIEMOPGNN : EBEDLFBNCPI, NKCGLECIEKE
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x66B9000", Offset = "0x66B8200", VA = "0x1866B9000", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x66B91E0", Offset = "0x66B83E0", VA = "0x1866B91E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool PHNFCDHLEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x66B9250", Offset = "0x66B8450", VA = "0x1866B9250", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x66B8EB0", Offset = "0x66B80B0", VA = "0x1866B8EB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints IJCFALMLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x66B8F20", Offset = "0x66B8120", VA = "0x1866B8F20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x66B9060", Offset = "0x66B8260", VA = "0x1866B9060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x66B9340", Offset = "0x66B8540", VA = "0x1866B9340")]
	public LDAIEMOPGNN(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x66B92B0", Offset = "0x66B84B0", VA = "0x1866B92B0", Slot = "9")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x66B8F80", Offset = "0x66B8180", VA = "0x1866B8F80", Slot = "10")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HAILNGHOIDN : EBEDLFBNCPI, EJFGBDMANDP
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x66B3180", Offset = "0x66B2380", VA = "0x1866B3180", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x66B2DB0", Offset = "0x66B1FB0", VA = "0x1866B2DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float MBNMMFHJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x66B3120", Offset = "0x66B2320", VA = "0x1866B3120", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x66B2FD0", Offset = "0x66B21D0", VA = "0x1866B2FD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public HAILNGHOIDN(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x66B31E0", Offset = "0x66B23E0", VA = "0x1866B31E0", Slot = "8")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x66B2F00", Offset = "0x66B2100", VA = "0x1866B2F00", Slot = "9")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[KGDBDLGNBOK(typeof(PLIGDHLBJFL), new string[] { })]
public sealed class CNDBAEKPMCB : IMCONFKMEBH, PLIGDHLBJFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[MKKNIMGKFBH]
	private OEHNEHNNLKH DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool OLAHAMNIKKD;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x66AA3E0", Offset = "0x66A95E0", VA = "0x1866AA3E0", Slot = "4")]
	public void InitReferences(JPALHOCNDEE IKNBEMPINKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x66AA0B0", Offset = "0x66A92B0", VA = "0x1866AA0B0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x66AA2C0", Offset = "0x66A94C0", VA = "0x1866AA2C0", Slot = "6")]
	public void HGFFJHLKNDD(HOKEHDIBKGC EJFJDAKPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x66A9E90", Offset = "0x66A9090", VA = "0x1866A9E90", Slot = "7")]
	public void DLAKDNNKLFJ(HOKEHDIBKGC EJFJDAKPAHL, bool ANFGNIFOGCN, bool IFBALCEFAGD, bool PMPCCNNFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x66A9C10", Offset = "0x66A8E10", VA = "0x1866A9C10", Slot = "8")]
	public void ANNBAPHJOCE(HOKEHDIBKGC EJFJDAKPAHL, float3 HGIFAPNFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x66A9D50", Offset = "0x66A8F50", VA = "0x1866A9D50", Slot = "9")]
	public void CEJIPHNHGIB(HOKEHDIBKGC EJFJDAKPAHL, float3 GOKBIGLBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x66AA430", Offset = "0x66A9630", VA = "0x1866AA430")]
	private bool OHHHBMHGHGE(HOKEHDIBKGC EJFJDAKPAHL, [Out] IDAPKFDEAHA BFLJLPICFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x66AA0E0", Offset = "0x66A92E0", VA = "0x1866AA0E0")]
	private bool EFBPLPJCADE(HOKEHDIBKGC EJFJDAKPAHL, [Out] CDAHHILDFDM ABHCJLFMCJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x66AA1D0", Offset = "0x66A93D0", VA = "0x1866AA1D0")]
	private bool GHILHIFFKKM(HOKEHDIBKGC EJFJDAKPAHL, [Out] EHKDNMKAOJF PCDHEIIACAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CNDBAEKPMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GFGIEPMAFGG : EBEDLFBNCPI, HJJOEOPBEBP
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool AHIHKHMIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x66B0550", Offset = "0x66AF750", VA = "0x1866B0550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x66B2360", Offset = "0x66B1560", VA = "0x1866B2360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x66B2840", Offset = "0x66B1A40", VA = "0x1866B2840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool BMEJHBJDPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x66B2570", Offset = "0x66B1770", VA = "0x1866B2570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x66B27D0", Offset = "0x66B19D0", VA = "0x1866B27D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool LKBLKOBEJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x66B2A20", Offset = "0x66B1C20", VA = "0x1866B2A20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x66B2500", Offset = "0x66B1700", VA = "0x1866B2500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int NLEKAIKPAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x66B25D0", Offset = "0x66B17D0", VA = "0x1866B25D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event EIGGMKBCEMC CHGKGHFFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x66B2640", Offset = "0x66B1840", VA = "0x1866B2640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x66B2980", Offset = "0x66B1B80", VA = "0x1866B2980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x66B2C20", Offset = "0x66B1E20", VA = "0x1866B2C20")]
	public GFGIEPMAFGG(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x66B2240", Offset = "0x66B1440", VA = "0x1866B2240", Slot = "6")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x66B22F0", Offset = "0x66B14F0", VA = "0x1866B22F0", Slot = "8")]
	public void ADJANKLFOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x66B2A80", Offset = "0x66B1C80", VA = "0x1866B2A80", Slot = "7")]
	public bool PBGEFFHKJJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x66B26E0", Offset = "0x66B18E0", VA = "0x1866B26E0", Slot = "9")]
	public void EEOIHFENJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x66A7A80", Offset = "0x66A6C80", VA = "0x1866A7A80", Slot = "12")]
	public void EOAEEJGIECN(bool AGBMHBNNBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x66B23C0", Offset = "0x66B15C0", VA = "0x1866B23C0", Slot = "11")]
	public void BAOFHJDNAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "10")]
	public void MNFBBHPJKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x66B28A0", Offset = "0x66B1AA0", VA = "0x1866B28A0")]
	private void IPMDKENEDKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class DLHKCBBOMPK : EBEDLFBNCPI, OAGLJJPDCEO
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x66AC260", Offset = "0x66AB460", VA = "0x1866AC260", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x66AC9F0", Offset = "0x66ABBF0", VA = "0x1866AC9F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x66A8330", Offset = "0x66A7530", VA = "0x1866A8330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool AANDPPBFIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x66AC560", Offset = "0x66AB760", VA = "0x1866AC560", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x66ACAE0", Offset = "0x66ABCE0", VA = "0x1866ACAE0")]
	public DLHKCBBOMPK(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x66AC0B0", Offset = "0x66AB2B0", VA = "0x1866AC0B0", Slot = "5")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x66AC1E0", Offset = "0x66AB3E0", VA = "0x1866AC1E0", Slot = "7")]
	public void DGIFMIPBMCG(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x66AC160", Offset = "0x66AB360", VA = "0x1866AC160", Slot = "8")]
	public void BHOEMINDDPB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x66AC340", Offset = "0x66AB540", VA = "0x1866AC340", Slot = "9")]
	public void GFBDGIPOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x66AC790", Offset = "0x66AB990", VA = "0x1866AC790", Slot = "11")]
	public void NAFEAAJLFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x66AC5C0", Offset = "0x66AB7C0", VA = "0x1866AC5C0", Slot = "12")]
	public void KFHLNNEDPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "10")]
	public void FBCAJOHGAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EHKDNMKAOJF : EBEDLFBNCPI, KCHDLDIOOGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x66AF8E0", Offset = "0x66AEAE0", VA = "0x1866AF8E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x66ADEA0", Offset = "0x66AD0A0", VA = "0x1866ADEA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x66AEC20", Offset = "0x66ADE20", VA = "0x1866AEC20", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x66AFC30", Offset = "0x66AEE30", VA = "0x1866AFC30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x66ADF10", Offset = "0x66AD110", VA = "0x1866ADF10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x66B0670", Offset = "0x66AF870", VA = "0x1866B0670", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x66B0570", Offset = "0x66AF770", VA = "0x1866B0570", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x66B0920", Offset = "0x66AFB20", VA = "0x1866B0920", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x66B02B0", Offset = "0x66AF4B0", VA = "0x1866B02B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x66AFB70", Offset = "0x66AED70", VA = "0x1866AFB70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x66B08F0", Offset = "0x66AFAF0", VA = "0x1866B08F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x66B0F30", Offset = "0x66B0130", VA = "0x1866B0F30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x66B0ED0", Offset = "0x66B00D0", VA = "0x1866B0ED0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x66ADA60", Offset = "0x66ACC60", VA = "0x1866ADA60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x66B05A0", Offset = "0x66AF7A0", VA = "0x1866B05A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private NEEBFDJPBHJ CMGGLOOFFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5FFE590", Offset = "0x5FFD790", VA = "0x185FFE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool AHIHKHMIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x66B0550", Offset = "0x66AF750", VA = "0x1866B0550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public EHKDNMKAOJF(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x66AE640", Offset = "0x66AD840", VA = "0x1866AE640", Slot = "20")]
	public void EMCOAFNNMII(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x66B0600", Offset = "0x66AF800", VA = "0x1866B0600", Slot = "30")]
	public void NCKLKJJCDDP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x66AD730", Offset = "0x66AC930", VA = "0x1866AD730", Slot = "19")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x66ADF70", Offset = "0x66AD170", VA = "0x1866ADF70", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x66B0FC0", Offset = "0x66B01C0", VA = "0x1866B0FC0", Slot = "28")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x66AF990", Offset = "0x66AEB90", VA = "0x1866AF990", Slot = "35")]
	public Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x66B0730", Offset = "0x66AF930", VA = "0x1866B0730", Slot = "34")]
	public Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x66AD730", Offset = "0x66AC930", VA = "0x1866AD730", Slot = "27")]
	public void KIPKCJPGOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x66ADDE0", Offset = "0x66ACFE0", VA = "0x1866ADDE0", Slot = "25")]
	public void BJIBPBEKAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x66AE030", Offset = "0x66AD230", VA = "0x1866AE030", Slot = "24")]
	public void EFKPGIBJLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x66B0310", Offset = "0x66AF510", VA = "0x1866B0310", Slot = "33")]
	public void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x66ADD80", Offset = "0x66ACF80", VA = "0x1866ADD80", Slot = "32")]
	public void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x66ADBB0", Offset = "0x66ACDB0", VA = "0x1866ADBB0", Slot = "31")]
	public void AMGNNLGHPLH(Vector3 GFJMONNBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x66AE6B0", Offset = "0x66AD8B0", VA = "0x1866AE6B0", Slot = "22")]
	public void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x66AFD50", Offset = "0x66AEF50", VA = "0x1866AFD50", Slot = "21")]
	public void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x66AEF60", Offset = "0x66AE160", VA = "0x1866AEF60", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x66B01D0", Offset = "0x66AF3D0", VA = "0x1866B01D0", Slot = "29")]
	public Vector3 LACKBFIAPMI(Vector3 KEMDGEPABAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x66B1130", Offset = "0x66B0330", VA = "0x1866B1130", Slot = "26")]
	public void PGDDJEMFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x66ADA60", Offset = "0x66ACC60", VA = "0x1866ADA60")]
	private void AOAMECFIAFE(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x66B0000", Offset = "0x66AF200", VA = "0x1866B0000")]
	private void KNMBJPJLEGN(Vector3 EALLIHELMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x66AD7E0", Offset = "0x66AC9E0", VA = "0x1866AD7E0")]
	private Vector3 AGMCPPEILCG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x66B0950", Offset = "0x66AFB50", VA = "0x1866B0950")]
	private void OPGNLJEHOAN(Vector3 HGIFAPNFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x66AECD0", Offset = "0x66ADED0", VA = "0x1866AECD0")]
	private Vector3 HGJPIPFIOFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x66AF370", Offset = "0x66AE570", VA = "0x1866AF370")]
	private void JKHDGHKNKMO(Vector3 AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x66B0F60", Offset = "0x66B0160", VA = "0x1866B0F60")]
	private void PDHOLFBMAIO(Vector3 KEMDGEPABAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x66ADE40", Offset = "0x66AD040", VA = "0x1866ADE40")]
	private void BPIFICHBIPH(Vector3 CLIOBNEJAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x66AE090", Offset = "0x66AD290", VA = "0x1866AE090")]
	private void EIKEBJEOEAE(string IDFOPMHLKEG, Vector3 AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x66AFCA0", Offset = "0x66AEEA0", VA = "0x1866AFCA0")]
	private void KGGAAEBACBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class EBEDLFBNCPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly IDAPKFDEAHA DMHIFOLACBC;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected OEHNEHNNLKH JCLAPKLNBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x57B7270", Offset = "0x57B6470", VA = "0x1857B7270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected HOKEHDIBKGC LBCEOFPCMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x57B72B0", Offset = "0x57B64B0", VA = "0x1857B72B0")]
		get
		{
			return default(HOKEHDIBKGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x66A9AB0", Offset = "0x66A8CB0", VA = "0x1866A9AB0")]
	public EBEDLFBNCPI(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x66AD690", Offset = "0x66AC890", VA = "0x1866AD690")]
	protected AAMLDJKKPKC POCNCBOMOKC(HOKEHDIBKGC BBAGHOBJDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DGJMPCMADMC : EIMFGMBBGEG
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x66AB430", Offset = "0x66AA630", VA = "0x1866AB430", Slot = "4")]
	public NCAHLNBGKAP EBLDMJMLPML(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x66ABD20", Offset = "0x66AAF20", VA = "0x1866ABD20", Slot = "5")]
	public KCHDLDIOOGL KGLJINLMINO(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x66AB500", Offset = "0x66AA700", VA = "0x1866AB500", Slot = "6")]
	public DPPEKLELCNC GECLMHBIMNA(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x66ABEE0", Offset = "0x66AB0E0", VA = "0x1866ABEE0", Slot = "7")]
	public EJFGBDMANDP ODKOFKNMOAC(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x66AB6C0", Offset = "0x66AA8C0", VA = "0x1866AB6C0", Slot = "8")]
	public HJJOEOPBEBP HHBACEOBNIK(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x66ABB10", Offset = "0x66AAD10", VA = "0x1866ABB10", Slot = "9")]
	public FFCINEEMPFK JFJFHIDKLFM(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x66ABA30", Offset = "0x66AAC30", VA = "0x1866ABA30", Slot = "10")]
	public KLKLJHDBGCJ IHJMIMGNGJI(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x66ABE00", Offset = "0x66AB000", VA = "0x1866ABE00", Slot = "11")]
	public NEEBFDJPBHJ MKOJCLLCPKF(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x66AB5E0", Offset = "0x66AA7E0", VA = "0x1866AB5E0", Slot = "12")]
	public PBONIJCKOHB HEBFKPILLPH(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x66ABFC0", Offset = "0x66AB1C0", VA = "0x1866ABFC0", Slot = "13")]
	public EHEBJDCJENF OGGNHODOGLL(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x66AB930", Offset = "0x66AAB30", VA = "0x1866AB930")]
	public OAGLJJPDCEO IGMMNIELFEI(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x66AB830", Offset = "0x66AAA30", VA = "0x1866AB830")]
	public BBMGGMPAAMA KFKINNEHMHN(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x66AB150", Offset = "0x66AA350", VA = "0x1866AB150")]
	public NOBMICLGHLL ALPADPFMNOA(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x66AB490", Offset = "0x66AA690", VA = "0x1866AB490")]
	public DAAADMHPHOE ECDPDOLOELO(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x66AB290", Offset = "0x66AA490", VA = "0x1866AB290")]
	public NKCGLECIEKE CGMKKHFHJKC(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x66ABBF0", Offset = "0x66AADF0", VA = "0x1866ABBF0", Slot = "19")]
	public AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH, FAHMOEHBCEC HOHFFEHOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DGJMPCMADMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x66AB930", Offset = "0x66AAB30", VA = "0x1866AB930", Slot = "14")]
	private OAGLJJPDCEO OCOENKMENKK(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x66AB830", Offset = "0x66AAA30", VA = "0x1866AB830", Slot = "15")]
	private BBMGGMPAAMA ICGHFAADCEF(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x66AB150", Offset = "0x66AA350", VA = "0x1866AB150", Slot = "16")]
	private NOBMICLGHLL KIHLCPAKBJE(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x66AB490", Offset = "0x66AA690", VA = "0x1866AB490", Slot = "17")]
	private DAAADMHPHOE GDNMLEIFGMD(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x66AC0A0", Offset = "0x66AB2A0", VA = "0x1866AC0A0", Slot = "18")]
	private NKCGLECIEKE OJPOOKBLAPB(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class KPDODDMAALK : IReadOnlyList<AAMLDJKKPKC>, IEnumerable<AAMLDJKKPKC>, IEnumerable, IReadOnlyCollection<AAMLDJKKPKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly HOKEHDIBKGC BBAGHOBJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly OEHNEHNNLKH CBPMHBPLNIE;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x66B8440", Offset = "0x66B7640", VA = "0x1866B8440", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public AAMLDJKKPKC ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x66B81E0", Offset = "0x66B73E0", VA = "0x1866B81E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x35621C0", Offset = "0x35613C0", VA = "0x1835621C0")]
	public KPDODDMAALK(HOKEHDIBKGC BBAGHOBJDIB, OEHNEHNNLKH CBPMHBPLNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x66B8330", Offset = "0x66B7530", VA = "0x1866B8330", Slot = "6")]
	public IEnumerator<AAMLDJKKPKC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x66B8330", Offset = "0x66B7530", VA = "0x1866B8330", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x66B81E0", Offset = "0x66B73E0", VA = "0x1866B81E0")]
	[CompilerGenerated]
	private AAMLDJKKPKC FLGCEBGNMAP(int ABHDANNAKPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KGDBDLGNBOK(typeof(EIMFGMBBGEG), new string[] { })]
public class KBKJFMLBNEF : EIMFGMBBGEG, IMCONFKMEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EIMFGMBBGEG NIEJCCOPKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly EIMFGMBBGEG BGAAEIPKAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MKEOHMFACBN HFKBKHJLEAK;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EIMFGMBBGEG MNIKGFKFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x66B6840", Offset = "0x66B5A40", VA = "0x1866B6840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x66B6DD0", Offset = "0x66B5FD0", VA = "0x1866B6DD0", Slot = "20")]
	public void InitReferences(JPALHOCNDEE IKNBEMPINKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x66B68A0", Offset = "0x66B5AA0", VA = "0x1866B68A0", Slot = "4")]
	public NCAHLNBGKAP EBLDMJMLPML(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x66B6FB0", Offset = "0x66B61B0", VA = "0x1866B6FB0", Slot = "5")]
	public KCHDLDIOOGL KGLJINLMINO(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x66B69F0", Offset = "0x66B5BF0", VA = "0x1866B69F0", Slot = "6")]
	public DPPEKLELCNC GECLMHBIMNA(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x66B70F0", Offset = "0x66B62F0", VA = "0x1866B70F0", Slot = "7")]
	public EJFGBDMANDP ODKOFKNMOAC(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x66B6B30", Offset = "0x66B5D30", VA = "0x1866B6B30", Slot = "8")]
	public HJJOEOPBEBP HHBACEOBNIK(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x66B6E20", Offset = "0x66B6020", VA = "0x1866B6E20", Slot = "9")]
	public FFCINEEMPFK JFJFHIDKLFM(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x66B6D30", Offset = "0x66B5F30", VA = "0x1866B6D30", Slot = "10")]
	public KLKLJHDBGCJ IHJMIMGNGJI(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x66B7050", Offset = "0x66B6250", VA = "0x1866B7050", Slot = "11")]
	public NEEBFDJPBHJ MKOJCLLCPKF(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x66B6A90", Offset = "0x66B5C90", VA = "0x1866B6A90", Slot = "12")]
	public PBONIJCKOHB HEBFKPILLPH(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x66B7190", Offset = "0x66B6390", VA = "0x1866B7190", Slot = "13")]
	public EHEBJDCJENF OGGNHODOGLL(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x66B6C80", Offset = "0x66B5E80", VA = "0x1866B6C80")]
	public OAGLJJPDCEO IGMMNIELFEI(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x66B6BD0", Offset = "0x66B5DD0", VA = "0x1866B6BD0")]
	public BBMGGMPAAMA KFKINNEHMHN(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x66B66E0", Offset = "0x66B58E0", VA = "0x1866B66E0")]
	public NOBMICLGHLL ALPADPFMNOA(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x66B6940", Offset = "0x66B5B40", VA = "0x1866B6940")]
	public DAAADMHPHOE ECDPDOLOELO(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x66B6790", Offset = "0x66B5990", VA = "0x1866B6790")]
	public NKCGLECIEKE CGMKKHFHJKC(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x66B6EC0", Offset = "0x66B60C0", VA = "0x1866B6EC0", Slot = "19")]
	public AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH, FAHMOEHBCEC HOHFFEHOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x66B7230", Offset = "0x66B6430", VA = "0x1866B7230")]
	public KBKJFMLBNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x66B6C80", Offset = "0x66B5E80", VA = "0x1866B6C80", Slot = "14")]
	private OAGLJJPDCEO OCOENKMENKK(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x66B6BD0", Offset = "0x66B5DD0", VA = "0x1866B6BD0", Slot = "15")]
	private BBMGGMPAAMA ICGHFAADCEF(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x66B66E0", Offset = "0x66B58E0", VA = "0x1866B66E0", Slot = "16")]
	private NOBMICLGHLL KIHLCPAKBJE(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x66B6940", Offset = "0x66B5B40", VA = "0x1866B6940", Slot = "17")]
	private DAAADMHPHOE GDNMLEIFGMD(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x66B6790", Offset = "0x66B5990", VA = "0x1866B6790", Slot = "18")]
	private NKCGLECIEKE OJPOOKBLAPB(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class EAIINKHILBD : AAMLDJKKPKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly EAIINKHILBD MJANIPKLNPJ;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx BFFGIBJAJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject DECAMNDLNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D60", Offset = "0x7C0F60", VA = "0x1807C1D60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8847C0", Offset = "0x8839C0", VA = "0x1808847C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x8065F0", Offset = "0x8057F0", VA = "0x1808065F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFB0", Offset = "0x7BD1B0", VA = "0x1807BDFB0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFF0", Offset = "0x7BD1F0", VA = "0x1807BDFF0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF60", Offset = "0x7BD160", VA = "0x1807BDF60", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE0", Offset = "0x7BD1E0", VA = "0x1807BDFE0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA10", Offset = "0xA79C10", VA = "0x180A7AA10", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9438E0", Offset = "0x942AE0", VA = "0x1809438E0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1C19E10", Offset = "0x1C19010", VA = "0x181C19E10", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3737F60", Offset = "0x3737160", VA = "0x183737F60", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x47D37D0", Offset = "0x47D29D0", VA = "0x1847D37D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x47D2230", Offset = "0x47D1430", VA = "0x1847D2230", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3B90F60", Offset = "0x3B90160", VA = "0x183B90F60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3B97140", Offset = "0x3B96340", VA = "0x183B97140", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LDPHOKCKEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9DA190", Offset = "0x9D9390", VA = "0x1809DA190", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CLMLEGFFJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1834E10", Offset = "0x1834010", VA = "0x181834E10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BF70", Offset = "0x5F6B170", VA = "0x185F6BF70", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3B96000", Offset = "0x3B95200", VA = "0x183B96000", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x98C220", Offset = "0x98B420", VA = "0x18098C220", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x66AD5D0", Offset = "0x66AC7D0", VA = "0x1866AD5D0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1B3A280", Offset = "0x1B39480", VA = "0x181B3A280", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB70", Offset = "0x8CDD70", VA = "0x1808CEB70", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x80DC50", Offset = "0x80CE50", VA = "0x18080DC50", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB70", Offset = "0x8CDD70", VA = "0x1808CEB70", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float MBNMMFHJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB70", Offset = "0x8CDD70", VA = "0x1808CEB70", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool MOLEGGHOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "48")]
		get
		{
			return default(CDNENJJICFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xD6E230", Offset = "0xD6D430", VA = "0x180D6E230", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform BAFFLMDJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA2A9F0", Offset = "0xA29BF0", VA = "0x180A2A9F0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 KHECFLGNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float ANEKOLEADHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB70", Offset = "0x8CDD70", VA = "0x1808CEB70", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float JJPGCNPBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB70", Offset = "0x8CDD70", VA = "0x1808CEB70", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion JNNEOFNBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5A0", Offset = "0xA2A7A0", VA = "0x180A2B5A0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 PIJKGFEDPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion DANCMHBIDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B5A0", Offset = "0xA2A7A0", VA = "0x180A2B5A0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints IJCFALMLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode IAJFNJHMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool OHAMAMLBOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x951D40", Offset = "0x950F40", VA = "0x180951D40", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event EIGGMKBCEMC EMIACKFKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event EIGGMKBCEMC DACGLNGCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event NICIGNFICLC LCNAIINCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event EIGGMKBCEMC KDNNHFAAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event EIGGMKBCEMC KPDPNDEFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event EIGGMKBCEMC CHGKGHFFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event EIGGMKBCEMC LMFFNALGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event EIGGMKBCEMC MMBNEHCMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "41")]
	public void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "71")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "72")]
	public void PEOOPPBFKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "73")]
	public void AEFGKNAJAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "74")]
	public void EEOIHFENJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "81")]
	public void CFGCOMIMMEO(AAMLDJKKPKC AFCGKMGKPEF, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "84")]
	public void EBFIEKBFDNO(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "85")]
	public void CJMHOBHCLJB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "86")]
	public Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "87")]
	public Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "88")]
	public void KIPKCJPGOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "89")]
	public void BJIBPBEKAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "90")]
	public void EFKPGIBJLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "91")]
	public void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "92")]
	public void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "93")]
	public void AMGNNLGHPLH(Vector3 GFJMONNBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "94")]
	public void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "95")]
	public void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "96")]
	public void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "97")]
	public Vector3 LACKBFIAPMI(Vector3 AFCGKMGKPEF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xBA2C00", Offset = "0xBA1E00", VA = "0x180BA2C00", Slot = "98")]
	public Vector3 JLDFCEPACMP(Vector3 AFCGKMGKPEF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "99")]
	public void PGDDJEMFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "100")]
	public void NIIKMKFLHNC(AAMLDJKKPKC CFJMMDBBHEN, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "101")]
	public void KGDFNKJPOGP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "104")]
	public void NPPDHJCFGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "105")]
	public void FCBGHAAPDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "106")]
	public void PHECOPHNJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "109")]
	public bool PBGEFFHKJJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "110")]
	public void BAOFHJDNAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "115")]
	public IDisposable IPGPELOKJHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "116")]
	public void LGBEIHFOEIF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "117")]
	public void ECEPEBKKFPM(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "118")]
	public void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "121")]
	public void MJCKLFPJLPL(Vector3 MEALJKKBLCG, Quaternion JGOFMGKMNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "122")]
	public void NGEELJMCNEA(Vector3 JNPCHGBMBBO, Quaternion JKJIMIMLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "123")]
	public bool AJHNOKPMMIM(float KCFKDECNACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "124")]
	public void KIMPLBOBPJJ(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "125")]
	public void DIJALPMHIBF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "126")]
	public void DGIFMIPBMCG(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "127")]
	public void BHOEMINDDPB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "128")]
	public void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "129")]
	public void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "130")]
	public void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "131")]
	public void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x66AD5F0", Offset = "0x66AC7F0", VA = "0x1866AD5F0", Slot = "132")]
	public bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "133")]
	public void AGGMGFNLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public EAIINKHILBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class IDAPKFDEAHA : MDMDMAGHOPK, HKJDEMHDADA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal HOKEHDIBKGC BBAGHOBJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal OEHNEHNNLKH AFENLMEHBBF;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x66B5780", Offset = "0x66B4980", VA = "0x1866B5780")]
	public IDAPKFDEAHA(GameObject JLBELLDLMIF, RigidbodyEx FIMHFGAEEIE, FAHMOEHBCEC HOHFFEHOKPA, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x66B52C0", Offset = "0x66B44C0", VA = "0x1866B52C0", Slot = "135")]
	protected override void ENEACFFBFJC(FAHMOEHBCEC HOHFFEHOKPA, DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "141")]
	protected override IDisposable LMPKFPLIDFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x66B5150", Offset = "0x66B4350", VA = "0x1866B5150", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x66B56B0", Offset = "0x66B48B0", VA = "0x1866B56B0", Slot = "142")]
	public void NJEMKLOBFCO(JKDPHHAOMCD NLOPLOLDAHH, JKDPHHAOMCD DDFNLJOOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x66B55F0", Offset = "0x66B47F0", VA = "0x1866B55F0", Slot = "143")]
	public void NAEFJNBHBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x66B5090", Offset = "0x66B4290", VA = "0x1866B5090", Slot = "144")]
	public void DOKFHMGKFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x66B5530", Offset = "0x66B4730", VA = "0x1866B5530", Slot = "145")]
	public void EOAEEJGIECN(bool AGBMHBNNBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x66B4F00", Offset = "0x66B4100", VA = "0x1866B4F00", Slot = "146")]
	public bool DGBHHDFIMIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x66B5590", Offset = "0x66B4790", VA = "0x1866B5590", Slot = "147")]
	public void FHOAJKCCPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "140")]
	protected override void NHJFCFOJCFA(RigidbodyEx BBEDKDLIKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x66B4CD0", Offset = "0x66B3ED0", VA = "0x1866B4CD0")]
	private void DDDNAJHCJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class KJDAKCCCKME
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x66B8100", Offset = "0x66B7300", VA = "0x1866B8100")]
	public static MDMDMAGHOPK LOJONGPLEFP(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BIBLIPGFMKC : NCAHLNBGKAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNMODEGKMKK(AAMLDJKKPKC DMHIFOLACBC);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKOGKBDJAAK(AAMLDJKKPKC DMHIFOLACBC);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KALLGKPIBKN(AAMLDJKKPKC IPCGHMHOPBO);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEPIGOHALLG(AAMLDJKKPKC IPCGHMHOPBO);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface CDFDIADELPE : DPPEKLELCNC
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	GBBEFNPDLGB<AAMLDJKKPKC> PKLNAGFOOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	AAMLDJKKPKC NBNOJPPOLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MJHMKLMHHIN : DAAADMHPHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HGFFJHLKNDD(Rigidbody FOHBGACELDD);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KBCMOKBPDAD : BBMGGMPAAMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView HEOFJGFGCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class IKNOIAJALMB : PBONIJCKOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode EGBDJLMLAJN;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode IAJFNJHMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x66B5AA0", Offset = "0x66B4CA0", VA = "0x1866B5AA0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x66B5D10", Offset = "0x66B4F10", VA = "0x1866B5D10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x66A8E90", Offset = "0x66A8090", VA = "0x1866A8E90")]
	public IKNOIAJALMB(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x66B5850", Offset = "0x66B4A50", VA = "0x1866B5850", Slot = "6")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x66B5D80", Offset = "0x66B4F80", VA = "0x1866B5D80", Slot = "9")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x66B5A90", Offset = "0x66B4C90", VA = "0x1866B5A90", Slot = "7")]
	public void KCIFEJPNLJP(bool KIEBCEKHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x66B5960", Offset = "0x66B4B60", VA = "0x1866B5960", Slot = "8")]
	public void BHFEDDGHOJN(bool KIEBCEKHBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x66B5BB0", Offset = "0x66B4DB0", VA = "0x1866B5BB0", Slot = "10")]
	public bool LHGHGGECEDH(Vector3 LFOLBKGLLGP, [Out] RaycastHit CBKIODDDCGI, float IIGADGFPKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x66B5970", Offset = "0x66B4B70", VA = "0x1866B5970")]
	private void HMHGCPJIDCM(bool KIEBCEKHBFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DNOLAAIPFCL : FFCINEEMPFK, IDisposable, FACFHHGFGIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private CDNENJJICFO AGBNAIBNOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AMGCCPCIEKH CMLDADGFLBM;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public CDNENJJICFO LCEIFNIHNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x66ACFA0", Offset = "0x66AC1A0", VA = "0x1866ACFA0", Slot = "6")]
		get
		{
			return default(CDNENJJICFO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x66AD1C0", Offset = "0x66AC3C0", VA = "0x1866AD1C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform NAKHPFOBEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x66AD0F0", Offset = "0x66AC2F0", VA = "0x1866AD0F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<OCINGNKOJDN, OCINGNKOJDN> AIMMLLKNFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x66AD110", Offset = "0x66AC310", VA = "0x1866AD110", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x66ACEA0", Offset = "0x66AC0A0", VA = "0x1866ACEA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x66AD290", Offset = "0x66AC490", VA = "0x1866AD290")]
	public DNOLAAIPFCL(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x66ACBA0", Offset = "0x66ABDA0", VA = "0x1866ACBA0", Slot = "8")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x66ACF50", Offset = "0x66AC150", VA = "0x1866ACF50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x8293F0", Offset = "0x8285F0", VA = "0x1808293F0", Slot = "11")]
	private void IHCBCFDHPMH(OCINGNKOJDN AADGLEEKKEE, OCINGNKOJDN IKOMCBPPDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "12")]
	private void ENPDFJMIMHA(bool MEDFHLPAELI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class CFPCNHIGDIE : NEEBFDJPBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x66A5020", Offset = "0x66A4220", VA = "0x1866A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x66A82E0", Offset = "0x66A74E0", VA = "0x1866A82E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x66A8330", Offset = "0x66A7530", VA = "0x1866A8330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x66A8120", Offset = "0x66A7320", VA = "0x1866A8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x66A8E90", Offset = "0x66A8090", VA = "0x1866A8E90")]
	public CFPCNHIGDIE(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x66A85F0", Offset = "0x66A77F0", VA = "0x1866A85F0", Slot = "4")]
	public void LDMKGIOHBDC(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x66A8390", Offset = "0x66A7590", VA = "0x1866A8390")]
	private void HGAENGCMAPB(Vector3 DBMLIHEKMKO, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x66A89B0", Offset = "0x66A7BB0", VA = "0x1866A89B0", Slot = "5")]
	public void NPGKFPFOICP(Vector3 DBMLIHEKMKO, Vector3 HBEJPCPOKJI, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66A8180", Offset = "0x66A7380", VA = "0x1866A8180", Slot = "6")]
	public void APALEOGKMDM(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x66A8C30", Offset = "0x66A7E30", VA = "0x1866A8C30")]
	private void PPMHPBJAGGD(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x66A8750", Offset = "0x66A7950", VA = "0x1866A8750", Slot = "7")]
	public void LFGEJJLAPKJ(Vector3 JODNPCGLCNK, ForceMode KEOKANJLDND = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class HMFKCMNNMDM : EHEBJDCJENF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool LAABPJCENLC;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool MOLEGGHOFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x66B4B90", Offset = "0x66B3D90", VA = "0x1866B4B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x66A8E90", Offset = "0x66A8090", VA = "0x1866A8E90")]
	public HMFKCMNNMDM(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x66B4CA0", Offset = "0x66B3EA0", VA = "0x1866B4CA0", Slot = "6")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x66AD320", Offset = "0x66AC520", VA = "0x1866AD320", Slot = "7")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class LIJBIKKICGD : BIBLIPGFMKC, NCAHLNBGKAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly AAMLDJKKPKC DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<AAMLDJKKPKC> KNECNLICDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private AAMLDJKKPKC EAMCHADGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AAMLDJKKPKC DMKJLMNBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform HHOBFLNFBEE;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x66BA510", Offset = "0x66B9710", VA = "0x1866BA510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF80", Offset = "0x7BD180", VA = "0x1807BDF80", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x66BB750", Offset = "0x66BA950", VA = "0x1866BB750", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public AAMLDJKKPKC EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF70", Offset = "0x7BD170", VA = "0x1807BDF70", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<AAMLDJKKPKC> AFIBBGNJIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFD0", Offset = "0x7BD1D0", VA = "0x1807BDFD0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event EIGGMKBCEMC EMIACKFKMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x66BA800", Offset = "0x66B9A00", VA = "0x1866BA800", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x66BB430", Offset = "0x66BA630", VA = "0x1866BB430", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event EIGGMKBCEMC DACGLNGCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x66BA760", Offset = "0x66B9960", VA = "0x1866BA760", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x66BAC70", Offset = "0x66B9E70", VA = "0x1866BAC70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event NICIGNFICLC LCNAIINCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x66BAD10", Offset = "0x66B9F10", VA = "0x1866BAD10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x66BB2A0", Offset = "0x66BA4A0", VA = "0x1866BB2A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PPEFDCGLHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x66BA570", Offset = "0x66B9770", VA = "0x1866BA570", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x66B9C70", Offset = "0x66B8E70", VA = "0x1866B9C70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action FPLGCFLNLIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x66BABD0", Offset = "0x66B9DD0", VA = "0x1866BABD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x66BB570", Offset = "0x66BA770", VA = "0x1866BB570", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<AAMLDJKKPKC> OHIBMHKBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x66BA6B0", Offset = "0x66B98B0", VA = "0x1866BA6B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x66BAA30", Offset = "0x66B9C30", VA = "0x1866BAA30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<AAMLDJKKPKC> OKAEFEFFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x66BA8A0", Offset = "0x66B9AA0", VA = "0x1866BA8A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x66BAEE0", Offset = "0x66BA0E0", VA = "0x1866BAEE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HGMIJKGKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x66BAF90", Offset = "0x66BA190", VA = "0x1866BAF90", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x66BA610", Offset = "0x66B9810", VA = "0x1866BA610", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<AAMLDJKKPKC> LGFPMGPJHME
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x66B9EE0", Offset = "0x66B90E0", VA = "0x1866B9EE0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x66BB9E0", Offset = "0x66BABE0", VA = "0x1866BB9E0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x66BBA90", Offset = "0x66BAC90", VA = "0x1866BBA90")]
	public LIJBIKKICGD(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x66BA950", Offset = "0x66B9B50", VA = "0x1866BA950", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x66B9F90", Offset = "0x66B9190", VA = "0x1866B9F90", Slot = "30")]
	public void CFGCOMIMMEO(AAMLDJKKPKC IKEECPHGAFL, bool OACHBGFPODN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x66BB030", Offset = "0x66BA230", VA = "0x1866BB030", Slot = "6")]
	public void KALLGKPIBKN(AAMLDJKKPKC IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x66BB760", Offset = "0x66BA960", VA = "0x1866BB760", Slot = "7")]
	public void PEPIGOHALLG(AAMLDJKKPKC IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x66BB340", Offset = "0x66BA540", VA = "0x1866BB340", Slot = "4")]
	public void LNMODEGKMKK(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x66BB4D0", Offset = "0x66BA6D0", VA = "0x1866BB4D0", Slot = "5")]
	public void MKOGKBDJAAK(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x66B9E40", Offset = "0x66B9040", VA = "0x1866B9E40")]
	private void BGAEBOGDJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x66BA9F0", Offset = "0x66B9BF0", VA = "0x1866BA9F0")]
	private void EBAFCBEDOFE(AAMLDJKKPKC IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x66BB610", Offset = "0x66BA810", VA = "0x1866BB610")]
	private void OLDLCBGKILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x66BADB0", Offset = "0x66B9FB0", VA = "0x1866BADB0")]
	private void HIBEIGGJODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x66B9D10", Offset = "0x66B8F10", VA = "0x1866B9D10")]
	private void ALIHJMCDNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x66BAAE0", Offset = "0x66B9CE0", VA = "0x1866BAAE0")]
	[CompilerGenerated]
	private object FFLFCOOLHNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class JHBOBHDKBJP
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x66B5E90", Offset = "0x66B5090", VA = "0x1866B5E90")]
	public static BIBLIPGFMKC PLHOOJFIBBL(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class HLFFMDFDJKA : CDFDIADELPE, DPPEKLELCNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GBBEFNPDLGB<AAMLDJKKPKC> GDBDCBKMGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool FICOOGMLEOE;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public GBBEFNPDLGB<AAMLDJKKPKC> PKLNAGFOOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 OEMNLIILDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x66B47F0", Offset = "0x66B39F0", VA = "0x1866B47F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 NHPJNFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x66B48D0", Offset = "0x66B3AD0", VA = "0x1866B48D0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x66B3F10", Offset = "0x66B3110", VA = "0x1866B3F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public AAMLDJKKPKC NBNOJPPOLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x66B4820", Offset = "0x66B3A20", VA = "0x1866B4820", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x66B4A90", Offset = "0x66B3C90", VA = "0x1866B4A90")]
	public HLFFMDFDJKA(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x66B4780", Offset = "0x66B3980", VA = "0x1866B4780", Slot = "8")]
	public void MEBDJNKKPEE(AAMLDJKKPKC DMKJLMNBOME, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x66B4720", Offset = "0x66B3920", VA = "0x1866B4720", Slot = "9")]
	public void JJELAEKBBKP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x66B4000", Offset = "0x66B3200", VA = "0x1866B4000")]
	private Vector3 FACOJIILAOC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x66B4390", Offset = "0x66B3590", VA = "0x1866B4390")]
	private void JDLCECPHOJN(AAMLDJKKPKC IMFGMCGCHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class CKFFFJLJLHE
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x66A9B50", Offset = "0x66A8D50", VA = "0x1866A9B50")]
	public static CDFDIADELPE KMPJJCOFMMH(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class ABFJCPIDIMO : MJHMKLMHHIN, DAAADMHPHOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 HIJPCOCMPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 AGFBIEEGBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float CLFEOAKKOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float PGHCGBCABEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 OGNOJJJOJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? OJJCMJGBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? PMIAEMCEJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool CFFNPBGFFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool KMIEOIEONLM;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 AFGKKMHPIED
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xBE6350", Offset = "0xBE5550", VA = "0x180BE6350", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x66A2AC0", Offset = "0x66A1CC0", VA = "0x1866A2AC0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 CLECDKPJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x66A2840", Offset = "0x66A1A40", VA = "0x1866A2840", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float BOOBAHBOAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11ECD60", Offset = "0x11EBF60", VA = "0x1811ECD60", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x66A14E0", Offset = "0x66A06E0", VA = "0x1866A14E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float NPMKLOKGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xC4FB90", Offset = "0xC4ED90", VA = "0x180C4FB90", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x66A1430", Offset = "0x66A0630", VA = "0x1866A1430", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 HIOLMLOPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x66A0CC0", Offset = "0x669FEC0", VA = "0x1866A0CC0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion MFMKBJOAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x66A2940", Offset = "0x66A1B40", VA = "0x1866A2940", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x66A0E50", Offset = "0x66A0050", VA = "0x1866A0E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event EIGGMKBCEMC FKAOKLALAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x66A2B70", Offset = "0x66A1D70", VA = "0x1866A2B70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x66A12B0", Offset = "0x66A04B0", VA = "0x1866A12B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x66A3100", Offset = "0x66A2300", VA = "0x1866A3100")]
	public ABFJCPIDIMO(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x66A2C10", Offset = "0x66A1E10", VA = "0x1866A2C10", Slot = "17")]
	public void NPPDHJCFGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x66A1350", Offset = "0x66A0550", VA = "0x1866A1350", Slot = "16")]
	public void FCBGHAAPDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x66A2DC0", Offset = "0x66A1FC0", VA = "0x1866A2DC0", Slot = "19")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x66A1020", Offset = "0x66A0220", VA = "0x1866A1020", Slot = "20")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x66A2EA0", Offset = "0x66A20A0", VA = "0x1866A2EA0", Slot = "18")]
	public void PHECOPHNJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x66A0680", Offset = "0x669F880", VA = "0x1866A0680", Slot = "21")]
	public void AGGMGFNLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x66A2AC0", Offset = "0x66A1CC0", VA = "0x1866A2AC0")]
	private void KJFFADNCGIP(Vector3 AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x66A3010", Offset = "0x66A2210", VA = "0x1866A3010")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PJLGNOIBGGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x66A14E0", Offset = "0x66A06E0", VA = "0x1866A14E0")]
	private void NCGBBBEJAFP(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x66A1430", Offset = "0x66A0630", VA = "0x1866A1430")]
	private void FHDKBOAHBCL(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x66A0B20", Offset = "0x669FD20", VA = "0x1866A0B20")]
	private Vector3 ANONJCGCPOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x66A15F0", Offset = "0x66A07F0", VA = "0x1866A15F0", Slot = "15")]
	public void GKMELCMJBAO((Quaternion rot, Vector3 moments) MHDHIIEFABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x66A0EA0", Offset = "0x66A00A0", VA = "0x1866A0EA0")]
	private Quaternion DOOFBNCFDOM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x66A1820", Offset = "0x66A0A20", VA = "0x1866A1820")]
	public void HGFFJHLKNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x66A18F0", Offset = "0x66A0AF0", VA = "0x1866A18F0", Slot = "4")]
	public (float, Vector3) HGFFJHLKNDD(Rigidbody FOHBGACELDD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EPFLKNKJMBD
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x66B12C0", Offset = "0x66B04C0", VA = "0x1866B12C0")]
	public static MJHMKLMHHIN BCBONFHHEPH(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class COMCDOLNCDK : NOBMICLGHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly COECADDMBED DLGGKOJBIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PMDABCIAEAH BPILJBAMGFI;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool JIEILAHJDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xD69B90", Offset = "0xD68D90", VA = "0x180D69B90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public PMDABCIAEAH AKDDLKKPGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0", Slot = "11")]
		get
		{
			return default(PMDABCIAEAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x66AAB10", Offset = "0x66A9D10", VA = "0x1866AAB10")]
	public COMCDOLNCDK(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x66AA4F0", Offset = "0x66A96F0", VA = "0x1866AA4F0", Slot = "4")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x66AA600", Offset = "0x66A9800", VA = "0x1866AA600")]
	private bool EEFHACKHGFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x66AA810", Offset = "0x66A9A10", VA = "0x1866AA810", Slot = "5")]
	public void FJLFJCLKDGC(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x66AAAE0", Offset = "0x66A9CE0", VA = "0x1866AAAE0", Slot = "6")]
	public void NJNHHILMCOF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x66AA960", Offset = "0x66A9B60", VA = "0x1866AA960", Slot = "9")]
	public void MFADBGBKGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x66AA840", Offset = "0x66A9A40", VA = "0x1866AA840")]
	private void KLBDLKOPNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x66AA6A0", Offset = "0x66A98A0", VA = "0x1866AA6A0")]
	private void FAMNJDIECGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x66AAAA0", Offset = "0x66A9CA0", VA = "0x1866AAAA0", Slot = "8")]
	public void NDPNJKECJJL(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x66AA5C0", Offset = "0x66A97C0", VA = "0x1866AA5C0", Slot = "7")]
	public void CHMKFOHHPPB(AAMLDJKKPKC DMHIFOLACBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class BINMAOHHHJM : KLKLJHDBGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly COECADDMBED EJMIGFDOCGP;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool HNBBEPCGPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x66A40E0", Offset = "0x66A32E0", VA = "0x1866A40E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event EIGGMKBCEMC LMFFNALGNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x66A41D0", Offset = "0x66A33D0", VA = "0x1866A41D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x66A42F0", Offset = "0x66A34F0", VA = "0x1866A42F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x66A4560", Offset = "0x66A3760", VA = "0x1866A4560")]
	public BINMAOHHHJM(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x66A4270", Offset = "0x66A3470", VA = "0x1866A4270", Slot = "11")]
	public IDisposable IPGPELOKJHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x66A42E0", Offset = "0x66A34E0", VA = "0x1866A42E0", Slot = "8")]
	public void LGBEIHFOEIF(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x66A4190", Offset = "0x66A3390", VA = "0x1866A4190", Slot = "9")]
	public void ECEPEBKKFPM(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x66A4390", Offset = "0x66A3590", VA = "0x1866A4390", Slot = "10")]
	public void NMMOKCIHFKL(object COAGHPOILPB, bool JOEBDDLLKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x66A4520", Offset = "0x66A3720", VA = "0x1866A4520", Slot = "6")]
	public void POGJPAONAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x66A44A0", Offset = "0x66A36A0", VA = "0x1866A44A0", Slot = "12")]
	public void PEKCMKANOMI(Rigidbody MILIHKPJLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x66A41A0", Offset = "0x66A33A0", VA = "0x1866A41A0", Slot = "13")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class HIJDPFCNBFE : KBCMOKBPDAD, BBMGGMPAAMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView JJDFLLPKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool EFHMEKPCPOE;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView HEOFJGFGCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool PGJJNGCCIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x66B19C0", Offset = "0x66B0BC0", VA = "0x1866B19C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool BNGPLJJMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x901D10", Offset = "0x900F10", VA = "0x180901D10", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event EIGGMKBCEMC KDNNHFAAFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x66B3DC0", Offset = "0x66B2FC0", VA = "0x1866B3DC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x66B3D20", Offset = "0x66B2F20", VA = "0x1866B3D20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x66B3E60", Offset = "0x66B3060", VA = "0x1866B3E60")]
	public HIJDPFCNBFE(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x66B32D0", Offset = "0x66B24D0", VA = "0x1866B32D0", Slot = "9")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x66B3940", Offset = "0x66B2B40", VA = "0x1866B3940", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x66B37D0", Offset = "0x66B29D0", VA = "0x1866B37D0", Slot = "10")]
	public void DCGCEEIAHEE(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x66B3A40", Offset = "0x66B2C40", VA = "0x1866B3A40", Slot = "11")]
	public void FBPAEDGMLDP(AAMLDJKKPKC DMKJLMNBOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x66B3BB0", Offset = "0x66B2DB0", VA = "0x1866B3BB0")]
	private void JNLOOFLKAFN(PhotonView GFKJEFBENCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x66B3670", Offset = "0x66B2870", VA = "0x1866B3670")]
	private void CBNMGJPKFHC(RigidbodyEx CAEKHECDJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x66B3400", Offset = "0x66B2600", VA = "0x1866B3400")]
	private void BPKHABKKCPB(PhotonView FMGKMADFFHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class CCPLLIFHCDK
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x66A4650", Offset = "0x66A3850", VA = "0x1866A4650")]
	public static KBCMOKBPDAD BFEKEJOHKMH(this AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JJKHDJFPBDF : NKCGLECIEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints IGCLOJGKDJN;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool CEEMPIKGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xB7D390", Offset = "0xB7C590", VA = "0x180B7D390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC4A0", Offset = "0x3EDB6A0", VA = "0x183EDC4A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool PHNFCDHLEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDE34D0", Offset = "0xDE26D0", VA = "0x180DE34D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC490", Offset = "0x3EDB690", VA = "0x183EDC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints IJCFALMLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x66B64D0", Offset = "0x66B56D0", VA = "0x1866B64D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x66B6630", Offset = "0x66B5830", VA = "0x1866B6630")]
	public JJKHDJFPBDF(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x66B6600", Offset = "0x66B5800", VA = "0x1866B6600", Slot = "9")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x66B64A0", Offset = "0x66B56A0", VA = "0x1866B64A0", Slot = "10")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class BDLBJPPBFLN : EJFGBDMANDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly AAMLDJKKPKC DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float KLNHJFKNGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float FMHMPJKMLFK;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float HOFDABDFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x943DF0", Offset = "0x942FF0", VA = "0x180943DF0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x66A32C0", Offset = "0x66A24C0", VA = "0x1866A32C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float MBNMMFHJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1A0", Offset = "0x9FA3A0", VA = "0x1809FB1A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x66A3430", Offset = "0x66A2630", VA = "0x1866A3430", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x66A3550", Offset = "0x66A2750", VA = "0x1866A3550")]
	public BDLBJPPBFLN(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x66A3500", Offset = "0x66A2700", VA = "0x1866A3500", Slot = "8")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x66A3390", Offset = "0x66A2590", VA = "0x1866A3390", Slot = "9")]
	public void EDBPGGLHNEB(Rigidbody BAGPDHKCDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class BGMBAFFHJMC : HJJOEOPBEBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool KCDPJDDINGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool LPPOIJOINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NKJNCKONFCP;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x66A0E50", Offset = "0x66A0050", VA = "0x1866A0E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool AHIHKHMIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x66A3D30", Offset = "0x66A2F30", VA = "0x1866A3D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private AAMLDJKKPKC KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x66A3630", Offset = "0x66A2830", VA = "0x1866A3630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x66A3AA0", Offset = "0x66A2CA0", VA = "0x1866A3AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event EIGGMKBCEMC CHGKGHFFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x66A3910", Offset = "0x66A2B10", VA = "0x1866A3910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x66A3C90", Offset = "0x66A2E90", VA = "0x1866A3C90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x66A4050", Offset = "0x66A3250", VA = "0x1866A4050")]
	public BGMBAFFHJMC(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x66A3590", Offset = "0x66A2790", VA = "0x1866A3590", Slot = "6")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x66A3620", Offset = "0x66A2820", VA = "0x1866A3620", Slot = "8")]
	public void ADJANKLFOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x66A3F00", Offset = "0x66A3100", VA = "0x1866A3F00", Slot = "7")]
	public bool PBGEFFHKJJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x66A39B0", Offset = "0x66A2BB0", VA = "0x1866A39B0", Slot = "9")]
	public void EEOIHFENJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x66A3690", Offset = "0x66A2890", VA = "0x1866A3690", Slot = "11")]
	public void BAOFHJDNAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x66A3A50", Offset = "0x66A2C50", VA = "0x1866A3A50", Slot = "12")]
	public void EOAEEJGIECN(bool AGBMHBNNBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x66A3D50", Offset = "0x66A2F50", VA = "0x1866A3D50", Slot = "10")]
	public void MNFBBHPJKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x66A3730", Offset = "0x66A2930", VA = "0x1866A3730")]
	private bool BCPPNEMFGLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x66A3B00", Offset = "0x66A2D00", VA = "0x1866A3B00")]
	private void IPMDKENEDKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class OKCHNAENJEP : OAGLJJPDCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly COECADDMBED JEKPAOPNOIA;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody GNPHPEMEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool OJPJMKEIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x66CE8C0", Offset = "0x66CDAC0", VA = "0x1866CE8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool AANDPPBFIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xD69B90", Offset = "0xD68D90", VA = "0x180D69B90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x66CF0A0", Offset = "0x66CE2A0", VA = "0x1866CF0A0")]
	public OKCHNAENJEP(AAMLDJKKPKC DMHIFOLACBC, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x66CE130", Offset = "0x66CD330", VA = "0x1866CE130", Slot = "5")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x66CE380", Offset = "0x66CD580", VA = "0x1866CE380", Slot = "7")]
	public void DGIFMIPBMCG(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x66CE1D0", Offset = "0x66CD3D0", VA = "0x1866CE1D0", Slot = "8")]
	public void BHOEMINDDPB(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x66CE8E0", Offset = "0x66CDAE0", VA = "0x1866CE8E0", Slot = "9")]
	public void GFBDGIPOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x66CEEB0", Offset = "0x66CE0B0", VA = "0x1866CEEB0", Slot = "11")]
	public void NAFEAAJLFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x66CED30", Offset = "0x66CDF30", VA = "0x1866CED30", Slot = "12")]
	public void KFHLNNEDPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x66CE3B0", Offset = "0x66CD5B0", VA = "0x1866CE3B0", Slot = "10")]
	public void FBCAJOHGAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x66CE200", Offset = "0x66CD400", VA = "0x1866CE200")]
	private void DEDBAFDDHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x66CEBB0", Offset = "0x66CDDB0", VA = "0x1866CEBB0")]
	private void JCFBLBJONJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LBLIMGOHAGD : KCHDLDIOOGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly MDMDMAGHOPK DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly COECADDMBED LMDLFDNENDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float LNKOGOHPEKM;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public PIHLMFDNIMC ALDDBBMLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3F0", Offset = "0x7B95F0", VA = "0x1807BA3F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public NIDNKMLFNEL NMBGKHEEHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 EJOLFNMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x66CB580", Offset = "0x66CA780", VA = "0x1866CB580", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x66CD240", Offset = "0x66CC440", VA = "0x1866CD240", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 NOACGPENDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x66CD150", Offset = "0x66CC350", VA = "0x1866CD150", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x66CD540", Offset = "0x66CC740", VA = "0x1866CD540", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 PKMJIKKJMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x66CCE90", Offset = "0x66CC090", VA = "0x1866CCE90", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x66CC7C0", Offset = "0x66CB9C0", VA = "0x1866CC7C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 DNLOMKEGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x66CD450", Offset = "0x66CC650", VA = "0x1866CD450", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x66CD9D0", Offset = "0x66CCBD0", VA = "0x1866CD9D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float OGMJFAKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x97B5F0", Offset = "0x97A7F0", VA = "0x18097B5F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x66CB2A0", Offset = "0x66CA4A0", VA = "0x1866CB2A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool MJCMPOCKHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x1708B40", Offset = "0x1707D40", VA = "0x181708B40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private NEEBFDJPBHJ CMGGLOOFFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5FFE590", Offset = "0x5FFD790", VA = "0x185FFE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool AHIHKHMIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x66B0550", Offset = "0x66AF750", VA = "0x1866B0550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x66CE090", Offset = "0x66CD290", VA = "0x1866CE090")]
	public LBLIMGOHAGD(AAMLDJKKPKC DMHIFOLACBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x66CB110", Offset = "0x66CA310", VA = "0x1866CB110", Slot = "19")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x66CB6A0", Offset = "0x66CA8A0", VA = "0x1866CB6A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x66CDE90", Offset = "0x66CD090", VA = "0x1866CDE90", Slot = "28")]
	public void PEKCMKANOMI(Rigidbody BAGPDHKCDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xBBD290", Offset = "0xBBC490", VA = "0x180BBD290", Slot = "20")]
	public void EMCOAFNNMII(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xBBC2E0", Offset = "0xBBB4E0", VA = "0x180BBC2E0", Slot = "30")]
	public void NCKLKJJCDDP(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x66CC650", Offset = "0x66CB850", VA = "0x1866CC650", Slot = "35")]
	public Vector3 JOAJBBOKHKC(Vector3 MLLOGDKELNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x66CD300", Offset = "0x66CC500", VA = "0x1866CD300", Slot = "34")]
	public Vector3 NIPLMILOOEC(Vector3 HGIFAPNFCJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x66CB110", Offset = "0x66CA310", VA = "0x1866CB110", Slot = "27")]
	public void KIPKCJPGOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x66CB520", Offset = "0x66CA720", VA = "0x1866CB520", Slot = "25")]
	public void BJIBPBEKAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x66CB700", Offset = "0x66CA900", VA = "0x1866CB700", Slot = "24")]
	public void EFKPGIBJLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x66CCFB0", Offset = "0x66CC1B0", VA = "0x1866CCFB0", Slot = "33")]
	public void LLLMOKJFLIL(Vector3 CIKPJMIIKLN, Vector3 KPJKLAKAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x66CB4C0", Offset = "0x66CA6C0", VA = "0x1866CB4C0", Slot = "32")]
	public void BHMMFBKMCBO(Vector3 HCOMCEMBCJO, Vector3 GOKBIGLBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x66CB350", Offset = "0x66CA550", VA = "0x1866CB350", Slot = "31")]
	public void AMGNNLGHPLH(Vector3 GFJMONNBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x66CB760", Offset = "0x66CA960", VA = "0x1866CB760", Slot = "22")]
	public void FFECFLIDJKG(CBGMHAPIEJC JKMOAKGCPOM, Vector3 HPGFPAAGAGA, float BDPHICAFDBP, float CLPAGOINNKP = 8f, float HCINILFKINF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x66CC930", Offset = "0x66CBB30", VA = "0x1866CC930", Slot = "21")]
	public void KHHELACFBNF(EFDPHABCCPF DFBMJOOFLCE, Vector3 EALLIHELMNN, float EHEPBGDLGEM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x66CBE70", Offset = "0x66CB070", VA = "0x1866CBE70", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void IPIDJFOENDP(EFDPHABCCPF DFBMJOOFLCE, Vector3 KIIONLKEIBO, float BDIMIHADCID = 7f, float JCJDEIGOHJJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x66CCD30", Offset = "0x66CBF30", VA = "0x1866CCD30", Slot = "29")]
	public Vector3 LACKBFIAPMI(Vector3 KEMDGEPABAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x66CDF60", Offset = "0x66CD160", VA = "0x1866CDF60", Slot = "26")]
	public void PGDDJEMFPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x66CB2A0", Offset = "0x66CA4A0", VA = "0x1866CB2A0")]
	private void AOAMECFIAFE(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x66CCBC0", Offset = "0x66CBDC0", VA = "0x1866CCBC0")]
	private void KNMBJPJLEGN(Vector3 EALLIHELMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x66CB1C0", Offset = "0x66CA3C0", VA = "0x1866CB1C0")]
	private Vector3 AGMCPPEILCG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x66CD570", Offset = "0x66CC770", VA = "0x1866CD570")]
	private void OPGNLJEHOAN(Vector3 HGIFAPNFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x66CBD90", Offset = "0x66CAF90", VA = "0x1866CBD90")]
	private Vector3 HGJPIPFIOFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x66CC210", Offset = "0x66CB410", VA = "0x1866CC210")]
	private void JKHDGHKNKMO(Vector3 AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x66CDA00", Offset = "0x66CCC00", VA = "0x1866CDA00")]
	private void PDHOLFBMAIO(Vector3 HGIFAPNFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x66CC880", Offset = "0x66CBA80", VA = "0x1866CC880")]
	private void KGGAAEBACBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DELPNPLAFNC : EIMFGMBBGEG
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x66CAA50", Offset = "0x66C9C50", VA = "0x1866CAA50", Slot = "4")]
	public NCAHLNBGKAP EBLDMJMLPML(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x66CAF10", Offset = "0x66CA110", VA = "0x1866CAF10", Slot = "5")]
	public KCHDLDIOOGL KGLJINLMINO(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x66CAB20", Offset = "0x66C9D20", VA = "0x1866CAB20", Slot = "6")]
	public DPPEKLELCNC GECLMHBIMNA(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x66CB050", Offset = "0x66CA250", VA = "0x1866CB050", Slot = "7")]
	public EJFGBDMANDP ODKOFKNMOAC(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x66CABE0", Offset = "0x66C9DE0", VA = "0x1866CABE0", Slot = "8")]
	public HJJOEOPBEBP HHBACEOBNIK(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x66CAE00", Offset = "0x66CA000", VA = "0x1866CAE00", Slot = "9")]
	public FFCINEEMPFK JFJFHIDKLFM(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x66CADA0", Offset = "0x66C9FA0", VA = "0x1866CADA0", Slot = "10")]
	public KLKLJHDBGCJ IHJMIMGNGJI(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x66CAFF0", Offset = "0x66CA1F0", VA = "0x1866CAFF0", Slot = "11")]
	public NEEBFDJPBHJ MKOJCLLCPKF(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x66CAB80", Offset = "0x66C9D80", VA = "0x1866CAB80", Slot = "12")]
	public PBONIJCKOHB HEBFKPILLPH(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x66CB0B0", Offset = "0x66CA2B0", VA = "0x1866CB0B0", Slot = "13")]
	public EHEBJDCJENF OGGNHODOGLL(AAMLDJKKPKC BFLJLPICFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x66CACB0", Offset = "0x66C9EB0", VA = "0x1866CACB0")]
	public OAGLJJPDCEO IGMMNIELFEI(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x66CAC40", Offset = "0x66C9E40", VA = "0x1866CAC40")]
	public BBMGGMPAAMA KFKINNEHMHN(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x66CA970", Offset = "0x66C9B70", VA = "0x1866CA970")]
	public NOBMICLGHLL ALPADPFMNOA(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x66CAAB0", Offset = "0x66C9CB0", VA = "0x1866CAAB0")]
	public DAAADMHPHOE ECDPDOLOELO(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x66CA9E0", Offset = "0x66C9BE0", VA = "0x1866CA9E0")]
	public NKCGLECIEKE CGMKKHFHJKC(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x66CAE60", Offset = "0x66CA060", VA = "0x1866CAE60", Slot = "19")]
	public AAMLDJKKPKC JKDGHLKJNIO(RigidbodyEx DMHIFOLACBC, DJKKNABJKJA GKNJGNIHLDH, FAHMOEHBCEC HOHFFEHOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DELPNPLAFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x66CACB0", Offset = "0x66C9EB0", VA = "0x1866CACB0", Slot = "14")]
	private OAGLJJPDCEO OCOENKMENKK(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x66CAC40", Offset = "0x66C9E40", VA = "0x1866CAC40", Slot = "15")]
	private BBMGGMPAAMA ICGHFAADCEF(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x66CA970", Offset = "0x66C9B70", VA = "0x1866CA970", Slot = "16")]
	private NOBMICLGHLL KIHLCPAKBJE(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x66CAAB0", Offset = "0x66C9CB0", VA = "0x1866CAAB0", Slot = "17")]
	private DAAADMHPHOE GDNMLEIFGMD(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x66CA9E0", Offset = "0x66C9BE0", VA = "0x1866CA9E0", Slot = "18")]
	private NKCGLECIEKE OJPOOKBLAPB(AAMLDJKKPKC BFLJLPICFCB, [In] DJKKNABJKJA GKNJGNIHLDH)
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
