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
	public class LogRegistrationIndex : AHNNEHLOHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x675F980", Offset = "0x675ED80", VA = "0x18675F980", Slot = "4")]
		public override void GPKLHHLKJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
	public class _AssemblyIndex : LHJJEIDOJLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private IPMDCNDONNF bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private IPMDCNDONNF bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x612C260", Offset = "0x612B660", VA = "0x18612C260", Slot = "5")]
		public override void EPIKBAOIJJD(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67720F0", Offset = "0x67714F0", VA = "0x1867720F0")]
		private void LCMBPGOKGFP(MKELEIBDMMM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6772260", Offset = "0x6771660", VA = "0x186772260")]
		private void MDCKLCKJGGE(MKELEIBDMMM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6771F00", Offset = "0x6771300", VA = "0x186771F00", Slot = "6")]
		public override void HDPKBLFAOGN(MKELEIBDMMM registry, [In] CHMHKFPJJIN filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
		public override void AOEHIAAJNNJ(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6772690", Offset = "0x6771A90", VA = "0x186772690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void HPHIGNDJBNG(RigidbodyEx PDNHOBAJGED);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PHHNAHNBNEN(RigidbodyEx PDNHOBAJGED, bool IFGJAJEKPIJ = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LNMPNHNJFFJ
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
public enum DOGKOGLLBOO
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GDFENKOOKGK
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[JGOEIFPBJFO(typeof(FIHENCDIKMF), new string[] { "Ignore", "Mock" })]
public class MGKKHKBMILN : FIHENCDIKMF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NNHDIDNGCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x811020", Offset = "0x810420", VA = "0x180811020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
	public void FHBPMPNEMDB(string NBDBHDLNPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
	public void KFICFBPICPL(RigidbodyEx GEGOPKKJAFB, Action PNAPELFIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "7")]
	public AHOONNCGJKF MHJOGAFPIBJ(int BAMDLBDCGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
	public void NENKAAILJON(Vector3 EMBFMGOGDMD, float BCEBEBFACMM, Color MAOKDDLICOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public MGKKHKBMILN()
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
		private static readonly GFLOJPOFOAD GINCKOGFKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool ANCNBGIPEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CEPMNDNBGMD PJJNPBAHBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[APNJDFGDCGH(FMDIPNBCKBB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[APNJDFGDCGH(FMDIPNBCKBB.SelfAndParent, true, false, false)]
		[SerializeField]
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
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private DOGKOGLLBOO physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal CEPMNDNBGMD KICPMODEHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x676DBD0", Offset = "0x676CFD0", VA = "0x18676DBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> JNEPNPFHGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CHPKPDJMCEA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x676F5E0", Offset = "0x676E9E0", VA = "0x18676F5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DHEBBLCLMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x676F540", Offset = "0x676E940", VA = "0x18676F540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx NCGFJMKBOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6770200", Offset = "0x676F600", VA = "0x186770200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6771780", Offset = "0x6770B80", VA = "0x186771780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform CCCAONBNACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E71A0", Offset = "0x7E65A0", VA = "0x1807E71A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform DMMGLAOMEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7E71A0", Offset = "0x7E65A0", VA = "0x1807E71A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ELAPLOIAPPA MCEPPCEEPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x676F300", Offset = "0x676E700", VA = "0x18676F300")]
			get
			{
				return default(ELAPLOIAPPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6770F30", Offset = "0x6770330", VA = "0x186770F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PDPPNOANCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x676F890", Offset = "0x676EC90", VA = "0x18676F890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool KAENJMIDEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x676F420", Offset = "0x676E820", VA = "0x18676F420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IIEEDGINFNK MADJLAKFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x676F7D0", Offset = "0x676EBD0", VA = "0x18676F7D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67710F0", Offset = "0x67704F0", VA = "0x1867710F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FKCADLHCKCE JOHKMGKIEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x676F770", Offset = "0x676EB70", VA = "0x18676F770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6771080", Offset = "0x6770480", VA = "0x186771080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JJKOGDNPKJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x676F6C0", Offset = "0x676EAC0", VA = "0x18676F6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody IOMJFIEMJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x676F720", Offset = "0x676EB20", VA = "0x18676F720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IEENGDPKGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x676F480", Offset = "0x676E880", VA = "0x18676F480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6770FA0", Offset = "0x67703A0", VA = "0x186770FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OEAMOAFKHID
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5F30120", Offset = "0x5F2F520", VA = "0x185F30120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5F2FC70", Offset = "0x5F2F070", VA = "0x185F2FC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float ACDPKOOAAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x67701A0", Offset = "0x676F5A0", VA = "0x1867701A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float IGEEMABBOMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6770140", Offset = "0x676F540", VA = "0x186770140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6771710", Offset = "0x6770B10", VA = "0x186771710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float PGOFDFJFBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x676FAF0", Offset = "0x676EEF0", VA = "0x18676FAF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6771390", Offset = "0x6770790", VA = "0x186771390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GAFIOIMHEDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x676F8F0", Offset = "0x676ECF0", VA = "0x18676F8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6771160", Offset = "0x6770560", VA = "0x186771160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IBBFHAFJPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6770760", Offset = "0x676FB60", VA = "0x186770760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6771CE0", Offset = "0x67710E0", VA = "0x186771CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 NPMGEACAMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x676FF20", Offset = "0x676F320", VA = "0x18676FF20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67714E0", Offset = "0x67708E0", VA = "0x1867714E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 EMBFMGOGDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x67708A0", Offset = "0x676FCA0", VA = "0x1867708A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode OLJBJPIAHEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x676FA30", Offset = "0x676EE30", VA = "0x18676FA30")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67712B0", Offset = "0x67706B0", VA = "0x1867712B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LCJPOGDHEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x676F4E0", Offset = "0x676E8E0", VA = "0x18676F4E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6771010", Offset = "0x6770410", VA = "0x186771010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints NFANHHJMFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x676FA90", Offset = "0x676EE90", VA = "0x18676FA90")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6771320", Offset = "0x6770720", VA = "0x186771320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 OLNJANHKMEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x67702A0", Offset = "0x676F6A0", VA = "0x1867702A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 KFIKMGPCMPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x67702A0", Offset = "0x676F6A0", VA = "0x1867702A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6771AC0", Offset = "0x6770EC0", VA = "0x186771AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ABFKJDMBAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6770000", Offset = "0x676F400", VA = "0x186770000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x67715C0", Offset = "0x67709C0", VA = "0x1867715C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float HDPLDFIJEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6770700", Offset = "0x676FB00", VA = "0x186770700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6771C70", Offset = "0x6771070", VA = "0x186771C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion PMILPOBBLBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6770380", Offset = "0x676F780", VA = "0x186770380")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6771840", Offset = "0x6770C40", VA = "0x186771840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KKGMPONNBDA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6770620", Offset = "0x676FA20", VA = "0x186770620")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6771BA0", Offset = "0x6770FA0", VA = "0x186771BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 BNAPIBPFKFC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6770460", Offset = "0x676F860", VA = "0x186770460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6771910", Offset = "0x6770D10", VA = "0x186771910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion FOGBBLMCKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6770540", Offset = "0x676F940", VA = "0x186770540")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x67719F0", Offset = "0x6770DF0", VA = "0x1867719F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BBCGBJMODNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x67707C0", Offset = "0x676FBC0", VA = "0x1867707C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6771D50", Offset = "0x6771150", VA = "0x186771D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PCLIKLHGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6770060", Offset = "0x676F460", VA = "0x186770060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6771630", Offset = "0x6770A30", VA = "0x186771630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NMPMAICHKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x676F950", Offset = "0x676ED50", VA = "0x18676F950")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67711D0", Offset = "0x67705D0", VA = "0x1867711D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LPOJPCGLALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x676FE40", Offset = "0x676F240", VA = "0x18676FE40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6771400", Offset = "0x6770800", VA = "0x186771400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IAPOJJFMDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x676FD00", Offset = "0x676F100", VA = "0x18676FD00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion EIIBHBPLOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x676FC20", Offset = "0x676F020", VA = "0x18676FC20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 DKNGPKPLAHC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6770A60", Offset = "0x676FE60", VA = "0x186770A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 OLCFCPIFHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6770980", Offset = "0x676FD80", VA = "0x186770980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OMKCPNFFKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x676FDE0", Offset = "0x676F1E0", VA = "0x18676FDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JALEGENKDFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x676F830", Offset = "0x676EC30", VA = "0x18676F830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PNJJJJHHCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x676F3C0", Offset = "0x676E7C0", VA = "0x18676F3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LNINMEIPCOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x676F360", Offset = "0x676E760", VA = "0x18676F360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NKJPHLBBJNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x676F2A0", Offset = "0x676E6A0", VA = "0x18676F2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AJLMAJCCPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x676FB50", Offset = "0x676EF50", VA = "0x18676FB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PEJFPPKJLCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5295350", Offset = "0x5294750", VA = "0x185295350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HPHIGNDJBNG BOOAELPDPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x676F1C0", Offset = "0x676E5C0", VA = "0x18676F1C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6770E50", Offset = "0x6770250", VA = "0x186770E50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PHHNAHNBNEN MJPKBPMNICH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x676F150", Offset = "0x676E550", VA = "0x18676F150")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6770DE0", Offset = "0x67701E0", VA = "0x186770DE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HPHIGNDJBNG NHDABODMFGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x676EEB0", Offset = "0x676E2B0", VA = "0x18676EEB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6770B40", Offset = "0x676FF40", VA = "0x186770B40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HPHIGNDJBNG PCMIJELEFPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x676EF20", Offset = "0x676E320", VA = "0x18676EF20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6770BB0", Offset = "0x676FFB0", VA = "0x186770BB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HPHIGNDJBNG OECAJPNBAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x676F070", Offset = "0x676E470", VA = "0x18676F070")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6770D00", Offset = "0x6770100", VA = "0x186770D00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x676F000", Offset = "0x676E400", VA = "0x18676F000")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6770C90", Offset = "0x6770090", VA = "0x186770C90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HPHIGNDJBNG GLJMDLHAMEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x676F0E0", Offset = "0x676E4E0", VA = "0x18676F0E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6770D70", Offset = "0x6770170", VA = "0x186770D70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HPHIGNDJBNG NENOJLLELEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x676F230", Offset = "0x676E630", VA = "0x18676F230")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6770EC0", Offset = "0x67702C0", VA = "0x186770EC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event HPHIGNDJBNG JLIJDLJOCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x676EF90", Offset = "0x676E390", VA = "0x18676EF90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6770C20", Offset = "0x6770020", VA = "0x186770C20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		internal void CKNBANDDEGF(CEPMNDNBGMD OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x676D3B0", Offset = "0x676C7B0", VA = "0x18676D3B0")]
		internal void CDPJKJJMJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x676EBD0", Offset = "0x676DFD0", VA = "0x18676EBD0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody DIBGGLJCMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x676E8A0", Offset = "0x676DCA0", VA = "0x18676E8A0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) MGBBEDLICFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x676D2E0", Offset = "0x676C6E0", VA = "0x18676D2E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x676DBD0", Offset = "0x676CFD0", VA = "0x18676DBD0")]
		private CEPMNDNBGMD POKOAGBLPLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x676DDA0", Offset = "0x676D1A0", VA = "0x18676DDA0")]
		private void PJKLBDDMIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x676DCE0", Offset = "0x676D0E0", VA = "0x18676DCE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x676D3B0", Offset = "0x676C7B0", VA = "0x18676D3B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x676DC80", Offset = "0x676D080", VA = "0x18676DC80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x676DD40", Offset = "0x676D140", VA = "0x18676DD40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x676C990", Offset = "0x676BD90", VA = "0x18676C990")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x676E130", Offset = "0x676D530", VA = "0x18676E130")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x676D5C0", Offset = "0x676C9C0", VA = "0x18676D5C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x676DB70", Offset = "0x676CF70", VA = "0x18676DB70")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x676EA00", Offset = "0x676DE00", VA = "0x18676EA00")]
		public void SetParent(RigidbodyEx PCGOHCLJAPN, bool IFGJAJEKPIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x676E440", Offset = "0x676D840", VA = "0x18676E440")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x676D840", Offset = "0x676CC40", VA = "0x18676D840")]
		public bool IsRigidbodyAncestor(RigidbodyEx MMCJKNKIIKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x676D920", Offset = "0x676CD20", VA = "0x18676D920")]
		public bool IsRigidbodyDescendant(RigidbodyEx CLKEFOCLBIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x676CC00", Offset = "0x676C000", VA = "0x18676CC00")]
		public void AddInterpolationRestriction(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x676E1A0", Offset = "0x676D5A0", VA = "0x18676E1A0")]
		public void RemoveInterpolationRestriction(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x676D350", Offset = "0x676C750", VA = "0x18676D350")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x676CC70", Offset = "0x676C070", VA = "0x18676CC70")]
		public void AddKinematic(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x676E210", Offset = "0x676D610", VA = "0x18676E210")]
		public void RemoveKinematic(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x676E980", Offset = "0x676DD80", VA = "0x18676E980")]
		public void SetKinematic(object ICNJFMMNIKL, bool COONFMMKHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x676E7A0", Offset = "0x676DBA0", VA = "0x18676E7A0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IMKHAKGPJAO, Quaternion FMIEMEPPPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x676E6A0", Offset = "0x676DAA0", VA = "0x18676E6A0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 OPICOCKBJBP, Quaternion MKMMAOLBFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x676D730", Offset = "0x676CB30", VA = "0x18676D730")]
		public Vector3 GetConstrainedVelocity(Vector3 BBCGBJMODNE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x676D620", Offset = "0x676CA20", VA = "0x18676D620")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NMPMAICHKMC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x676CB10", Offset = "0x676BF10", VA = "0x18676CB10")]
		public void AddForce(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x676CA00", Offset = "0x676BE00", VA = "0x18676CA00")]
		public void AddForceAtPosition(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x676CE40", Offset = "0x676C240", VA = "0x18676CE40")]
		public void AddTorque(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x676CCE0", Offset = "0x676C0E0", VA = "0x18676CCE0")]
		public void AddRelativeTorque(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x676ECA0", Offset = "0x676E0A0", VA = "0x18676ECA0")]
		public Vector3 WorldToLocalVelocity(Vector3 LEGMFGGOFOO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x676DA60", Offset = "0x676CE60", VA = "0x18676DA60")]
		public Vector3 LocalToWorldVelocity(Vector3 PCLIKLHGPPH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x676D560", Offset = "0x676C960", VA = "0x18676D560")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x676D500", Offset = "0x676C900", VA = "0x18676D500")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x676D4A0", Offset = "0x676C8A0", VA = "0x18676D4A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x676D440", Offset = "0x676C840", VA = "0x18676D440")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x676E5A0", Offset = "0x676D9A0", VA = "0x18676E5A0")]
		public void ResetVelocityWorldSpace(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x676E4A0", Offset = "0x676D8A0", VA = "0x18676E4A0")]
		public void ResetVelocityLocalSpace(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x676E360", Offset = "0x676D760", VA = "0x18676E360")]
		public void ResetLinearVelocityLocalSpace(Vector3 GBGIPMBFGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x676EB30", Offset = "0x676DF30", VA = "0x18676EB30")]
		public bool SweepTest(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x676DA00", Offset = "0x676CE00", VA = "0x18676DA00")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x676EAD0", Offset = "0x676DED0", VA = "0x18676EAD0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x676EC40", Offset = "0x676E040", VA = "0x18676EC40")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x676CDD0", Offset = "0x676C1D0", VA = "0x18676CDD0")]
		public void AddShouldHaveUnityRigidbodyToken(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x676E280", Offset = "0x676D680", VA = "0x18676E280")]
		public void RemoveShouldHaveUnityRigidbodyToken(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x676D170", Offset = "0x676C570", VA = "0x18676D170")]
		public void ApplyForceVelocityChange(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x676D0D0", Offset = "0x676C4D0", VA = "0x18676D0D0")]
		public void ApplyAngularVelocityChange(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x676D230", Offset = "0x676C630", VA = "0x18676D230")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x676D000", Offset = "0x676C400", VA = "0x18676D000")]
		public bool AllowedScaleChange(float NHGFEEIKBPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x676CF30", Offset = "0x676C330", VA = "0x18676CF30")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx BKHEPLIKHBN, object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x676E2F0", Offset = "0x676D6F0", VA = "0x18676E2F0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x676EE40", Offset = "0x676E240", VA = "0x18676EE40")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class JIDBLMIHMIN
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x675AB70", Offset = "0x6759F70", VA = "0x18675AB70")]
	public static CEPMNDNBGMD KICPMODEHIL(this RigidbodyEx GEGOPKKJAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PLIDDIKOIFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody JLPFJOLEFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView GDOBDAGLNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 HEMIPMNIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 NIBFJMPDCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public DOGKOGLLBOO EDKMJMLNODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool NBFOJKKMDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool ANLAHNNHCAI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JGOEIFPBJFO(typeof(GHDMNJOELMD), new string[] { })]
public class BNIMNMCIFHM : GHDMNJOELMD, KJACJMOCMBM
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MCADBNIAAFA AKEOPEJBMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private FIHENCDIKMF ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ALBBBBGHPGI IIIAAFPDEMP;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FIHENCDIKMF JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ALBBBBGHPGI OCLOBCLPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x674A3F0", Offset = "0x67497F0", VA = "0x18674A3F0", Slot = "8")]
	public void InitReferences(IMFGMFPAOFH PHINOHCBOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x674A140", Offset = "0x6749540", VA = "0x18674A140", Slot = "6")]
	public IAKELPIHEBB HOJFPILMONM(RigidbodyEx GEGOPKKJAFB)
	{
		return default(IAKELPIHEBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x674A480", Offset = "0x6749880", VA = "0x18674A480")]
	private static IAKELPIHEBB JOHDPGHJBGE(RigidbodyEx GEGOPKKJAFB)
	{
		return default(IAKELPIHEBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x674A550", Offset = "0x6749950", VA = "0x18674A550", Slot = "7")]
	public CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BNIMNMCIFHM()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static DGHHAMKHKGM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int PCAFJHFFKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int DPDKJGPKIII;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x676C7F0", Offset = "0x676BBF0", VA = "0x18676C7F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x676C830", Offset = "0x676BC30", VA = "0x18676C830")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x676C810", Offset = "0x676BC10", VA = "0x18676C810")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JEBCFBFPEMG, [Optional] UnityEngine.Object APOKKKDAFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JEBCFBFPEMG, [Optional] UnityEngine.Object APOKKKDAFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x676C940", Offset = "0x676BD40", VA = "0x18676C940")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BEJJPLEEADO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6749830", Offset = "0x6748C30", VA = "0x186749830")]
	public static void CKEMFOCBJIM(this Rigidbody DIBGGLJCMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6749700", Offset = "0x6748B00", VA = "0x186749700")]
	public static void CKEMFOCBJIM(this Rigidbody DIBGGLJCMIC, Vector3 IGOFDIDGMLC, Quaternion EIIBHBPLOBM, Vector3 BMJGAFKCNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xCBC780", Offset = "0xCBBB80", VA = "0x180CBC780")]
	public static void GLGIKEPHHEH(Vector3 BBCGBJMODNE, Vector3 GCPIJELMKHI, [Out] Vector3 LIDFHBABLBH, [Out] Vector3 KIEPLLOGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MLGBKLKNKKP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class MOIOKMNBKBB : IIEEDGINFNK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CD990", Offset = "0x7CCD90", VA = "0x1807CD990", Slot = "4")]
		public Vector3 DKPMNCBKAKL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CD990", Offset = "0x7CCD90", VA = "0x1807CD990", Slot = "5")]
		public Vector3 INAPBELDCBG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MOIOKMNBKBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static IIEEDGINFNK GLGPHCFMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67606F0", Offset = "0x675FAF0", VA = "0x1867606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DIOJAKMPEID
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNDMLGJLOIF(bool OMKCPNFFKMN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGFMKGDAIHC(bool OMKCPNFFKMN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DLNEKELHMPF : IDisposable, MGLBENKAKCI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDKMMINMGFL();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
public interface ALBBBBGHPGI
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPAAABFEFAL PKCFBNMPCBK(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLHLHCLMBKF ECEDMPFIEOD(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADIMGFHHFBG MIEGGKMKNDJ(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ODEDNHPDPBN GDLAHMFMBKG(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCMOJEPOJEG NEFKDPNEAJM(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DLNEKELHMPF JFKDNCEHOEP(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHGBGHBKKFI BLHENODGIEA(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EEAHBLACECN JNBALBNDMMF(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DIOJAKMPEID DOFHMDDNEIH(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HHNDEEPJDOM HPECNGFGKPE(CEPMNDNBGMD OOANNHIADDH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PEEJJANOIFH GDFMJHGKAAF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HJIFDFCEKAC GKACBEHGAPO(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ELHLAKJEHGP AJNPMHPLPDN(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ICDAGNHDDBM LGDIDBBIGBM(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MEFADKBNONK DFNCLLGJJIL(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF, GHDMNJOELMD BJMBJJIMGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EEAHBLACECN
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HHNDEEPJDOM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HPAAABFEFAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HPHIGNDJBNG NHDABODMFGD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HPHIGNDJBNG PCMIJELEFPC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event PHHNAHNBNEN CBBEAPEJLKP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GEJOGGLNHJP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action OMDBNKAFFLI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CEPMNDNBGMD> NDINGFFANFG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<CEPMNDNBGMD> IIENBBKIOPE;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action LOEFJNMIPBK;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<CEPMNDNBGMD> BBLLODKDGML;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LAMLBLPGIEN(CEPMNDNBGMD FANLJCAEFCA, bool IFGJAJEKPIJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ADIMGFHHFBG
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFJFKMGAKHN(CEPMNDNBGMD NCGFJMKBOIN, object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJDPDCOOPJI(object ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ICDAGNHDDBM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HPHIGNDJBNG IPLOBDAHBPI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KFCGHDKMPGP();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PAAPKOGBENA();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GHCNKMMFANL();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IKPOFDMCJCN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ELHLAKJEHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NINIHMHJIOH(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGEEIHONFLM(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOAOEJBHDCI(CEPMNDNBGMD GEGOPKKJAFB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIOFEBHDIAB(CEPMNDNBGMD GEGOPKKJAFB);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFJKGHBLEGE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JHGBGHBKKFI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HPHIGNDJBNG BBFKLNECANA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPICPHOKBNI();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIELBKJBLAM(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKMDLEMOEHL(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GNMLCADBJPH();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MKPMILMLBOM(Rigidbody DOBGLDLBPEG);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HJIFDFCEKAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HPHIGNDJBNG ANIBELMENJF;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMHJPLOGOCP(CEPMNDNBGMD NCGFJMKBOIN);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPLPOBAICIK(CEPMNDNBGMD NCGFJMKBOIN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MEFADKBNONK
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BMKEOKJJENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ODEDNHPDPBN
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CFAGLPCLMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NHGEPPDKAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CCMOJEPOJEG
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event HPHIGNDJBNG BEDMPFHDNPG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAGBCCPAPGN();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLEGNPKNGAE();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBACNHHPHHK();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCKPLMNDBHF();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNMJHMLNMCF();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BAKIIAICJJI(bool NHAFDJKECIH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PEEJJANOIFH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EJMAKBOFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENAPHPMNHJC(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBIEBNGMCJD(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FOODCFBEADE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LONAEEMKGAM();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MLHLHCLMBKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DHDFJEDLJPJ(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MOMBLLKLGCF();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NHCLIFEGMIN();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FFIHLFPCKLH();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NHAGINDEKMF();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MKPMILMLBOM(Rigidbody JLPFJOLEFBA);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JMJBOGLLJKL(Vector3 BBCGBJMODNE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EDFJEMJINGH(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DCFEFBIOGFI(Vector3 JCCFJHCOEJE);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
public interface FIHENCDIKMF
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NNHDIDNGCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHBPMPNEMDB(string NBDBHDLNPOA);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFICFBPICPL(RigidbodyEx GEGOPKKJAFB, Action PNAPELFIIEJ);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHOONNCGJKF MHJOGAFPIBJ(int BAMDLBDCGBJ);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NENKAAILJON(Vector3 EMBFMGOGDMD, float BCEBEBFACMM, Color MAOKDDLICOE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
public interface GHDMNJOELMD
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	FIHENCDIKMF JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	ALBBBBGHPGI OCLOBCLPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAKELPIHEBB HOJFPILMONM(RigidbodyEx GEGOPKKJAFB);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FKCADLHCKCE
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBOAPHGDADI(Vector3 IKODJBHPDJM);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APJEAENPLLG(Vector3 NMPMAICHKMC);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHEDEMMKMMA(Vector3 IKODJBHPDJM);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLPMDLDEHPK(Vector3 NMPMAICHKMC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IIEEDGINFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DKPMNCBKAKL();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 INAPBELDCBG();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CEPMNDNBGMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx JNOOPBIIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool LNINMEIPCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NKJPHLBBJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform DMMGLAOMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 ELBCFGCNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float LDIBAJAAJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float HBDKBLLNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion OPLHNIOLKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 LEEADPCABEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion DIGMIJLMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool JALEGENKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event HPHIGNDJBNG NHDABODMFGD;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event HPHIGNDJBNG PCMIJELEFPC;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event PHHNAHNBNEN CBBEAPEJLKP;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event HPHIGNDJBNG ANIBELMENJF;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event HPHIGNDJBNG OECAJPNBAEJ;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event HPHIGNDJBNG BEDMPFHDNPG;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event HPHIGNDJBNG BBFKLNECANA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event HPHIGNDJBNG JLIJDLJOCAH;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void OKCHHCMNNMD();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NHGNOJBCKHD();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void HBACNHHPHHK();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void LAMLBLPGIEN(CEPMNDNBGMD PCGOHCLJAPN, bool IFGJAJEKPIJ = false);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void AGOFHLPIPJG(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void IFEBIIPNIBA(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void NHAGINDEKMF();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void NHCLIFEGMIN();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void MOMBLLKLGCF();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DCFEFBIOGFI(Vector3 JCCFJHCOEJE);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 JMJBOGLLJKL(Vector3 PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 BNLNJMPOIMJ(Vector3 PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void FFIHLFPCKLH();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CPDMALGCMJH(CEPMNDNBGMD BKHEPLIKHBN, object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void INKCPECHBPC(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PAAPKOGBENA();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KFCGHDKMPGP();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GHCNKMMFANL();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DAGBCCPAPGN();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void NNMJHMLNMCF();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable GNMLCADBJPH();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PIELBKJBLAM(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void JKMDLEMOEHL(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void CADFLFFEFOJ(Vector3 IMKHAKGPJAO, Quaternion FMIEMEPPPDM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LBIMBILHGEM(Vector3 OPICOCKBJBP, Quaternion MKMMAOLBFMM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool AOHBHDHLANI(float NHGFEEIKBPI);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void BACNNHPKBBP(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void ILNLDNBHBGO(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void ENAPHPMNHJC(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void PBIEBNGMCJD(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IKPOFDMCJCN();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DLOGELIDANB : CEPMNDNBGMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly GHDMNJOELMD BJMBJJIMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal HPAAABFEFAL KFDGKIEOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal ELHLAKJEHGP JJOKJOHNKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HJIFDFCEKAC FDINMLLKPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MLHLHCLMBKF BBCGBJMODNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal ADIMGFHHFBG DFJEOJCCCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal ICDAGNHDDBM NPGBMKCMKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal ODEDNHPDPBN GKPFLCONKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal HHNDEEPJDOM FHLPGJINPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal CCMOJEPOJEG OMFHPGOHDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DLNEKELHMPF BLFOONJPOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal JHGBGHBKKFI KCBIDNBHEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EEAHBLACECN DOPMCGBECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal MEFADKBNONK AEALOKFEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal PEEJJANOIFH JLPFJOLEFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal DIOJAKMPEID FKGEJJENEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable EENDPCPAGPO;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx JNOOPBIIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5510", Offset = "0x7C4910", VA = "0x1807C5510", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C55A0", Offset = "0x7C49A0", VA = "0x1807C55A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8841D0", Offset = "0x8835D0", VA = "0x1808841D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8842F0", Offset = "0x8836F0", VA = "0x1808842F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x67535A0", Offset = "0x67529A0", VA = "0x1867535A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x67542E0", Offset = "0x67536E0", VA = "0x1867542E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6756940", Offset = "0x6755D40", VA = "0x186756940", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6756830", Offset = "0x6755C30", VA = "0x186756830", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x67526F0", Offset = "0x6751AF0", VA = "0x1867526F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6757BF0", Offset = "0x6756FF0", VA = "0x186757BF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x67568E0", Offset = "0x6755CE0", VA = "0x1867568E0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6754130", Offset = "0x6753530", VA = "0x186754130", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6757C40", Offset = "0x6757040", VA = "0x186757C40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6751F20", Offset = "0x6751320", VA = "0x186751F20", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6756E70", Offset = "0x6756270", VA = "0x186756E70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x67560F0", Offset = "0x67554F0", VA = "0x1867560F0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6751E60", Offset = "0x6751260", VA = "0x186751E60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6752500", Offset = "0x6751900", VA = "0x186752500", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6756590", Offset = "0x6755990", VA = "0x186756590", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6756010", Offset = "0x6755410", VA = "0x186756010", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6751FD0", Offset = "0x67513D0", VA = "0x186751FD0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6756650", Offset = "0x6755A50", VA = "0x186756650", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6753630", Offset = "0x6752A30", VA = "0x186753630", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6755810", Offset = "0x6754C10", VA = "0x186755810", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6754AA0", Offset = "0x6753EA0", VA = "0x186754AA0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6756CE0", Offset = "0x67560E0", VA = "0x186756CE0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6754FF0", Offset = "0x67543F0", VA = "0x186754FF0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PNJJJJHHCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x67521C0", Offset = "0x67515C0", VA = "0x1867521C0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LNINMEIPCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6757B90", Offset = "0x6756F90", VA = "0x186757B90", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NKJPHLBBJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6752820", Offset = "0x6751C20", VA = "0x186752820", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x67578F0", Offset = "0x6756CF0", VA = "0x1867578F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6753710", Offset = "0x6752B10", VA = "0x186753710", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6757990", Offset = "0x6756D90", VA = "0x186757990", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x67550D0", Offset = "0x67544D0", VA = "0x1867550D0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x67561B0", Offset = "0x67555B0", VA = "0x1867561B0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6753840", Offset = "0x6752C40", VA = "0x186753840", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x67533D0", Offset = "0x67527D0", VA = "0x1867533D0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x67534F0", Offset = "0x67528F0", VA = "0x1867534F0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6752B00", Offset = "0x6751F00", VA = "0x186752B00", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x67549C0", Offset = "0x6753DC0", VA = "0x1867549C0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x67563E0", Offset = "0x67557E0", VA = "0x1867563E0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6753980", Offset = "0x6752D80", VA = "0x186753980", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6757830", Offset = "0x6756C30", VA = "0x186757830", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6756890", Offset = "0x6755C90", VA = "0x186756890", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6753540", Offset = "0x6752940", VA = "0x186753540", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x67577E0", Offset = "0x6756BE0", VA = "0x1867577E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6753F90", Offset = "0x6753390", VA = "0x186753F90", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6751E10", Offset = "0x6751210", VA = "0x186751E10", Slot = "48")]
		get
		{
			return default(FCPGOCNJIBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6753160", Offset = "0x6752560", VA = "0x186753160", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6755E00", Offset = "0x6755200", VA = "0x186755E00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform DMMGLAOMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6752270", Offset = "0x6751670", VA = "0x186752270", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 ELBCFGCNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6754480", Offset = "0x6753880", VA = "0x186754480", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x67573D0", Offset = "0x67567D0", VA = "0x1867573D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float LDIBAJAAJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x67531C0", Offset = "0x67525C0", VA = "0x1867531C0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6755E50", Offset = "0x6755250", VA = "0x186755E50", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float HBDKBLLNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6754530", Offset = "0x6753930", VA = "0x186754530", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6756ED0", Offset = "0x67562D0", VA = "0x186756ED0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion OPLHNIOLKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6755D50", Offset = "0x6755150", VA = "0x186755D50", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6754040", Offset = "0x6753440", VA = "0x186754040", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 LEEADPCABEK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6754DB0", Offset = "0x67541B0", VA = "0x186754DB0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x67575F0", Offset = "0x67569F0", VA = "0x1867575F0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion DIGMIJLMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6753BE0", Offset = "0x6752FE0", VA = "0x186753BE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6754920", Offset = "0x6753D20", VA = "0x186754920", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6753A20", Offset = "0x6752E20", VA = "0x186753A20", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6752B60", Offset = "0x6751F60", VA = "0x186752B60", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6755D00", Offset = "0x6755100", VA = "0x186755D00", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6752280", Offset = "0x6751680", VA = "0x186752280", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6754330", Offset = "0x6753730", VA = "0x186754330", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x67524A0", Offset = "0x67518A0", VA = "0x1867524A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MCGIPNELNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6757640", Offset = "0x6756A40", VA = "0x186757640", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JALEGENKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6755B30", Offset = "0x6754F30", VA = "0x186755B30", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool IDPKNHAGFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x67555B0", Offset = "0x67549B0", VA = "0x1867555B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool BGHPFGKEAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x67572F0", Offset = "0x67566F0", VA = "0x1867572F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HPHIGNDJBNG NHDABODMFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x67565F0", Offset = "0x67559F0", VA = "0x1867565F0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6752D90", Offset = "0x6752190", VA = "0x186752D90", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HPHIGNDJBNG PCMIJELEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6755EC0", Offset = "0x67552C0", VA = "0x186755EC0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6752FC0", Offset = "0x67523C0", VA = "0x186752FC0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event PHHNAHNBNEN CBBEAPEJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6757890", Offset = "0x6756C90", VA = "0x186757890", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6751F70", Offset = "0x6751370", VA = "0x186751F70", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event HPHIGNDJBNG ANIBELMENJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6756E10", Offset = "0x6756210", VA = "0x186756E10", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6757780", Offset = "0x6756B80", VA = "0x186757780", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event HPHIGNDJBNG OECAJPNBAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6753A70", Offset = "0x6752E70", VA = "0x186753A70", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x67537E0", Offset = "0x6752BE0", VA = "0x1867537E0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event HPHIGNDJBNG BEDMPFHDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6754D50", Offset = "0x6754150", VA = "0x186754D50", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6757370", Offset = "0x6756770", VA = "0x186757370", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6754960", Offset = "0x6753D60", VA = "0x186754960", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6754550", Offset = "0x6753950", VA = "0x186754550", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event HPHIGNDJBNG BBFKLNECANA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6754280", Offset = "0x6753680", VA = "0x186754280", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6757AD0", Offset = "0x6756ED0", VA = "0x186757AD0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event HPHIGNDJBNG JLIJDLJOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x67551B0", Offset = "0x67545B0", VA = "0x1867551B0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6757540", Offset = "0x6756940", VA = "0x186757540", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6751210", Offset = "0x6750610", VA = "0x186751210")]
	public DLOGELIDANB(GameObject LMKHHJAKBGC, RigidbodyEx BPFDCFPPIED, GHDMNJOELMD BJMBJJIMGHO, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6755260", Offset = "0x6754660", VA = "0x186755260", Slot = "135")]
	protected virtual void JIMBAJCMCOP(GHDMNJOELMD BJMBJJIMGHO, PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6753420", Offset = "0x6752820", VA = "0x186753420", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6753020", Offset = "0x6752420", VA = "0x186753020", Slot = "71")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6756FD0", Offset = "0x67563D0", VA = "0x186756FD0", Slot = "72")]
	public void OKCHHCMNNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6757070", Offset = "0x6756470", VA = "0x186757070", Slot = "73")]
	public void NHGNOJBCKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6757490", Offset = "0x6756890", VA = "0x186757490")]
	private void NOGINBHHBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6756140", Offset = "0x6755540", VA = "0x186756140", Slot = "81")]
	public void LAMLBLPGIEN(CEPMNDNBGMD PCGOHCLJAPN, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6751EC0", Offset = "0x67512C0", VA = "0x186751EC0", Slot = "84")]
	public void AGOFHLPIPJG(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6754B80", Offset = "0x6753F80", VA = "0x186754B80", Slot = "85")]
	public void IFEBIIPNIBA(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6754BE0", Offset = "0x6753FE0", VA = "0x186754BE0", Slot = "86")]
	public Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6754380", Offset = "0x6753780", VA = "0x186754380", Slot = "87")]
	public Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6756FD0", Offset = "0x67563D0", VA = "0x186756FD0", Slot = "88")]
	public void NHAGINDEKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6757020", Offset = "0x6756420", VA = "0x186757020", Slot = "89")]
	public void NHCLIFEGMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6756DC0", Offset = "0x67561C0", VA = "0x186756DC0", Slot = "90")]
	public void MOMBLLKLGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6752ED0", Offset = "0x67522D0", VA = "0x186752ED0", Slot = "91")]
	public void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6755F20", Offset = "0x6755320", VA = "0x186755F20", Slot = "92")]
	public void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6752DF0", Offset = "0x67521F0", VA = "0x186752DF0", Slot = "93")]
	public void DCFEFBIOGFI(Vector3 JCCFJHCOEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6755650", Offset = "0x6754A50", VA = "0x186755650", Slot = "94")]
	public void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6752650", Offset = "0x6751A50", VA = "0x186752650", Slot = "95")]
	public void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6754180", Offset = "0x6753580", VA = "0x186754180", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6755710", Offset = "0x6754B10", VA = "0x186755710", Slot = "97")]
	public Vector3 JMJBOGLLJKL(Vector3 PCGOHCLJAPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6752550", Offset = "0x6751950", VA = "0x186752550", Slot = "98")]
	public Vector3 BNLNJMPOIMJ(Vector3 PCGOHCLJAPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x67539D0", Offset = "0x6752DD0", VA = "0x1867539D0", Slot = "99")]
	public void FFIHLFPCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6752BC0", Offset = "0x6751FC0", VA = "0x186752BC0", Slot = "100")]
	public void CPDMALGCMJH(CEPMNDNBGMD BKHEPLIKHBN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6754F90", Offset = "0x6754390", VA = "0x186754F90", Slot = "101")]
	public void INKCPECHBPC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x67522E0", Offset = "0x67516E0", VA = "0x1867522E0", Slot = "41")]
	public void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6757940", Offset = "0x6756D40", VA = "0x186757940", Slot = "104")]
	public void PAAPKOGBENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6755CB0", Offset = "0x67550B0", VA = "0x186755CB0", Slot = "105")]
	public void KFCGHDKMPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6753C20", Offset = "0x6753020", VA = "0x186753C20", Slot = "106")]
	public void GHCNKMMFANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6752D40", Offset = "0x6752140", VA = "0x186752D40", Slot = "109")]
	public bool DAGBCCPAPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6754230", Offset = "0x6753630", VA = "0x186754230", Slot = "74")]
	public void HBACNHHPHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6757320", Offset = "0x6756720", VA = "0x186757320", Slot = "110")]
	public void NNMJHMLNMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6753FF0", Offset = "0x67533F0", VA = "0x186753FF0", Slot = "115")]
	public IDisposable GNMLCADBJPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6757B30", Offset = "0x6756F30", VA = "0x186757B30", Slot = "116")]
	public void PIELBKJBLAM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6755550", Offset = "0x6754950", VA = "0x186755550", Slot = "117")]
	public void JKMDLEMOEHL(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6754CE0", Offset = "0x67540E0", VA = "0x186754CE0", Slot = "118")]
	public void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6752900", Offset = "0x6751D00", VA = "0x186752900", Slot = "121")]
	public void CADFLFFEFOJ(Vector3 IMKHAKGPJAO, Quaternion FMIEMEPPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6756290", Offset = "0x6755690", VA = "0x186756290", Slot = "122")]
	public void LBIMBILHGEM(Vector3 OPICOCKBJBP, Quaternion MKMMAOLBFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6752160", Offset = "0x6751560", VA = "0x186752160", Slot = "123")]
	public bool AOHBHDHLANI(float NHGFEEIKBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6752210", Offset = "0x6751610", VA = "0x186752210", Slot = "124")]
	public void BACNNHPKBBP(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6754E50", Offset = "0x6754250", VA = "0x186754E50", Slot = "125")]
	public void ILNLDNBHBGO(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6753920", Offset = "0x6752D20", VA = "0x186753920", Slot = "126")]
	public void ENAPHPMNHJC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6757A70", Offset = "0x6756E70", VA = "0x186757A70", Slot = "127")]
	public void PBIEBNGMCJD(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6754EB0", Offset = "0x67542B0", VA = "0x186754EB0", Slot = "128")]
	public void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6752C30", Offset = "0x6752030", VA = "0x186752C30", Slot = "129")]
	public void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6752740", Offset = "0x6751B40", VA = "0x186752740", Slot = "130")]
	public void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x67523C0", Offset = "0x67517C0", VA = "0x1867523C0", Slot = "131")]
	public void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6757090", Offset = "0x6756490", VA = "0x186757090", Slot = "132")]
	public bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6754E00", Offset = "0x6754200", VA = "0x186754E00", Slot = "133")]
	public void IKPOFDMCJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6757C90", Offset = "0x6757090", VA = "0x186757C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x67564B0", Offset = "0x67558B0", VA = "0x1867564B0")]
	private void LDGOJDHGIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6753AD0", Offset = "0x6752ED0", VA = "0x186753AD0")]
	private void FMPPDDBEDMO(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x67531E0", Offset = "0x67525E0", VA = "0x1867531E0")]
	private void DIMMBBKFLMG(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x67520B0", Offset = "0x67514B0", VA = "0x1867520B0")]
	private void AMJFIFPBIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6756730", Offset = "0x6755B30", VA = "0x186756730")]
	private void LIIICKDDHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6756990", Offset = "0x6755D90", VA = "0x186756990")]
	private void MKBBMLBEGMD(CEPMNDNBGMD EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6756B70", Offset = "0x6755F70", VA = "0x186756B70")]
	private void MMHJPLOGOCP(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6755A60", Offset = "0x6754E60", VA = "0x186755A60")]
	private void JPLPOBAICIK(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x67558F0", Offset = "0x6754CF0", VA = "0x1867558F0")]
	private void JMNNNAFFPMN(RigidbodyEx NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6757130", Offset = "0x6756530", VA = "0x186757130", Slot = "140")]
	protected virtual void NJNHNBLEGHF(RigidbodyEx GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6753C70", Offset = "0x6753070", VA = "0x186753C70")]
	protected void GJKJNGDFEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x67545B0", Offset = "0x67539B0", VA = "0x1867545B0")]
	protected void HMADFPPCLLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6756C40", Offset = "0x6756040", VA = "0x186756C40", Slot = "141")]
	protected virtual IDisposable MNMAMKNAAAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OHMMPLAAHJL
{
	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x67656E0", Offset = "0x6764AE0", VA = "0x1867656E0")]
	public static CEPMNDNBGMD IGOBGKMEFAA(this CEPMNDNBGMD GEGOPKKJAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6765860", Offset = "0x6764C60", VA = "0x186765860")]
	public static bool KKBLNEDJPEC(this CEPMNDNBGMD GEGOPKKJAFB, CEPMNDNBGMD MMCJKNKIIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x67657E0", Offset = "0x6764BE0", VA = "0x1867657E0")]
	public static bool KJKHEDBNAME(this CEPMNDNBGMD GEGOPKKJAFB, CEPMNDNBGMD CLKEFOCLBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6765790", Offset = "0x6764B90", VA = "0x186765790")]
	public static RigidbodyEx JNOOPBIIAPB(this CEPMNDNBGMD KICPMODEHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6765660", Offset = "0x6764A60", VA = "0x186765660")]
	public static DLOGELIDANB DOJOPPJHJOA(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class AIGHDKIKAOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x67486D0", Offset = "0x6747AD0", VA = "0x1867486D0")]
	public AIGHDKIKAOD(DLOGELIDANB ODIMBMMGNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6748670", Offset = "0x6747A70", VA = "0x186748670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class PNPPMLKCOGL : KPFDDFIJLNI, DIOJAKMPEID
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode MNDLDKLACHM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x676C100", Offset = "0x676B500", VA = "0x18676C100")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x676C3C0", Offset = "0x676B7C0", VA = "0x18676C3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x676C2B0", Offset = "0x676B6B0", VA = "0x18676C2B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x676C040", Offset = "0x676B440", VA = "0x18676C040", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public PNPPMLKCOGL(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x676C160", Offset = "0x676B560", VA = "0x18676C160", Slot = "6")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x676C5A0", Offset = "0x676B9A0", VA = "0x18676C5A0", Slot = "9")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x676C7E0", Offset = "0x676BBE0", VA = "0x18676C7E0", Slot = "7")]
	public void PNDMLGJLOIF(bool OMKCPNFFKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x676C030", Offset = "0x676B430", VA = "0x18676C030", Slot = "8")]
	public void BGFMKGDAIHC(bool OMKCPNFFKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x676C680", Offset = "0x676BA80", VA = "0x18676C680", Slot = "10")]
	public bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x676C430", Offset = "0x676B830", VA = "0x18676C430")]
	private void JMPHIDEKCBJ(bool OMKCPNFFKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HJMMGKKGCPM : KPFDDFIJLNI, DLNEKELHMPF, IDisposable, MGLBENKAKCI
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public FCPGOCNJIBG OLPEKLJMEON
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x67593F0", Offset = "0x67587F0", VA = "0x1867593F0")]
		get
		{
			return default(FCPGOCNJIBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x67591A0", Offset = "0x67585A0", VA = "0x1867591A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6758FA0", Offset = "0x67583A0", VA = "0x186758FA0", Slot = "6")]
		get
		{
			return default(FCPGOCNJIBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x67591A0", Offset = "0x67585A0", VA = "0x1867591A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform HNDNDDANMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6759340", Offset = "0x6758740", VA = "0x186759340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6759290", Offset = "0x6758690", VA = "0x186759290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public HJMMGKKGCPM(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x67594D0", Offset = "0x67588D0", VA = "0x1867594D0", Slot = "11")]
	public void OnChangedDistanceBand(NBPFHEAGOPH NPHEJPFOCLG, NBPFHEAGOPH EAMIDELOEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "12")]
	public void OnChangedVisibility(bool NHBIJGNKDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class CJJNMGLOAPI : KPFDDFIJLNI, EEAHBLACECN
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x674C2E0", Offset = "0x674B6E0", VA = "0x18674C2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x674B6C0", Offset = "0x674AAC0", VA = "0x18674B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x674C330", Offset = "0x674B730", VA = "0x18674C330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public CJJNMGLOAPI(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x674C180", Offset = "0x674B580", VA = "0x18674C180", Slot = "4")]
	public void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x674BC20", Offset = "0x674B020", VA = "0x18674BC20")]
	private void CMFJPHINLPN(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x674BF00", Offset = "0x674B300", VA = "0x18674BF00", Slot = "5")]
	public void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x674BAC0", Offset = "0x674AEC0", VA = "0x18674BAC0", Slot = "6")]
	public void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x674C390", Offset = "0x674B790", VA = "0x18674C390")]
	private void NFMAOENIMAC(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x674B860", Offset = "0x674AC60", VA = "0x18674B860", Slot = "7")]
	public void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x674C5F0", Offset = "0x674B9F0", VA = "0x18674C5F0")]
	private void OMAIFAPDBID(string JEBCFBFPEMG, UnityEngine.Object APOKKKDAFKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PALEMDNFEPE : KPFDDFIJLNI, HHNDEEPJDOM
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x67687B0", Offset = "0x6767BB0", VA = "0x1867687B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x67685D0", Offset = "0x67679D0", VA = "0x1867685D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public PALEMDNFEPE(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6768720", Offset = "0x6767B20", VA = "0x186768720", Slot = "6")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x67585B0", Offset = "0x67579B0", VA = "0x1867585B0", Slot = "7")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JLNIAFIKAGA : KPFDDFIJLNI, HPAAABFEFAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly GFLOJPOFOAD JDNBHOOODOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly HLMKCPGJDOA OLDLKBFPGJL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x675B360", Offset = "0x675A760", VA = "0x18675B360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IAKELPIHEBB CLHKKPLCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x675CA40", Offset = "0x675BE40", VA = "0x18675CA40")]
		get
		{
			return default(IAKELPIHEBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x675B590", Offset = "0x675A990", VA = "0x18675B590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x675C730", Offset = "0x675BB30", VA = "0x18675C730", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x675C530", Offset = "0x675B930", VA = "0x18675C530", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IAKELPIHEBB HEJAEHBBLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x675B090", Offset = "0x675A490", VA = "0x18675B090")]
		get
		{
			return default(IAKELPIHEBB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x675BC80", Offset = "0x675B080", VA = "0x18675BC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x675CC90", Offset = "0x675C090", VA = "0x18675CC90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HPHIGNDJBNG NHDABODMFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x675C490", Offset = "0x675B890", VA = "0x18675C490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x675B0F0", Offset = "0x675A4F0", VA = "0x18675B0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HPHIGNDJBNG PCMIJELEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x675C280", Offset = "0x675B680", VA = "0x18675C280", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x675B190", Offset = "0x675A590", VA = "0x18675B190", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PHHNAHNBNEN CBBEAPEJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x675CBF0", Offset = "0x675BFF0", VA = "0x18675CBF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x675AEB0", Offset = "0x675A2B0", VA = "0x18675AEB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action GEJOGGLNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x675AFF0", Offset = "0x675A3F0", VA = "0x18675AFF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x675CAA0", Offset = "0x675BEA0", VA = "0x18675CAA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action OMDBNKAFFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x675C320", Offset = "0x675B720", VA = "0x18675C320", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x675B440", Offset = "0x675A840", VA = "0x18675B440", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<CEPMNDNBGMD> NDINGFFANFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x675CB40", Offset = "0x675BF40", VA = "0x18675CB40", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x675B4E0", Offset = "0x675A8E0", VA = "0x18675B4E0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<CEPMNDNBGMD> IIENBBKIOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x675B390", Offset = "0x675A790", VA = "0x18675B390", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x675B6B0", Offset = "0x675AAB0", VA = "0x18675B6B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action LOEFJNMIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x675C690", Offset = "0x675BA90", VA = "0x18675C690", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x675C7A0", Offset = "0x675BBA0", VA = "0x18675C7A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<CEPMNDNBGMD> BBLLODKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x675BED0", Offset = "0x675B2D0", VA = "0x18675BED0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x675BF80", Offset = "0x675B380", VA = "0x18675BF80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x675CD90", Offset = "0x675C190", VA = "0x18675CD90")]
	public JLNIAFIKAGA(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x675B230", Offset = "0x675A630", VA = "0x18675B230", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x675C3C0", Offset = "0x675B7C0", VA = "0x18675C3C0", Slot = "26")]
	public void LAMLBLPGIEN(CEPMNDNBGMD FANLJCAEFCA, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x675C440", Offset = "0x675B840", VA = "0x18675C440")]
	private void LAMLBLPGIEN(DIFJMOOCNJF FANLJCAEFCA, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x675B760", Offset = "0x675AB60", VA = "0x18675B760")]
	private void HFEOMPNPIOE(DIFJMOOCNJF FANLJCAEFCA, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x675C030", Offset = "0x675B430", VA = "0x18675C030")]
	private void KFMOLNGPIIN(DIFJMOOCNJF EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x675C840", Offset = "0x675BC40", VA = "0x18675C840")]
	private void NCFDKADEHGE(DIFJMOOCNJF EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x675BCF0", Offset = "0x675B0F0", VA = "0x18675BCF0")]
	private void IFEOCOLBHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x675B600", Offset = "0x675AA00", VA = "0x18675B600")]
	private void FLDGKACJIKH(DIFJMOOCNJF EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x675C5A0", Offset = "0x675B9A0", VA = "0x18675C5A0")]
	private void LLOHKJPIIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x675BBE0", Offset = "0x675AFE0", VA = "0x18675BBE0")]
	private void HFLJCFEFFHN(DIFJMOOCNJF GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x675AF50", Offset = "0x675A350", VA = "0x18675AF50")]
	private void BCIFPANODDD(DIFJMOOCNJF GEGOPKKJAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class NFKFFANAIMP
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x67619A0", Offset = "0x6760DA0", VA = "0x1867619A0")]
	public static JLNIAFIKAGA ELKGJKKMDPG(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class INPOLCKKNEJ : KPFDDFIJLNI, ADIMGFHHFBG
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6759830", Offset = "0x6758C30", VA = "0x186759830", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6759F30", Offset = "0x6759330", VA = "0x186759F30", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6759CE0", Offset = "0x67590E0", VA = "0x186759CE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private CEPMNDNBGMD FJJDGFJKFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6759DD0", Offset = "0x67591D0", VA = "0x186759DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public INPOLCKKNEJ(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x675A270", Offset = "0x6759670", VA = "0x18675A270", Slot = "6")]
	public void PFJFKMGAKHN(CEPMNDNBGMD NCGFJMKBOIN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x675A160", Offset = "0x6759560", VA = "0x18675A160")]
	private void PFJFKMGAKHN(DIFJMOOCNJF NCGFJMKBOIN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6759860", Offset = "0x6758C60", VA = "0x186759860", Slot = "7")]
	public void GJDPDCOOPJI(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x67598D0", Offset = "0x6758CD0", VA = "0x1867598D0")]
	private Vector3 GNBLNOFNNIK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class ILJCHNJJDBO
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x67597A0", Offset = "0x6758BA0", VA = "0x1867597A0")]
	public static INPOLCKKNEJ ELEJKBAPIJK(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CKFFFFOIJLD : KPFDDFIJLNI, ICDAGNHDDBM
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x674F000", Offset = "0x674E400", VA = "0x18674F000", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x674CBE0", Offset = "0x674BFE0", VA = "0x18674CBE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 EAJLNMGIGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x674F150", Offset = "0x674E550", VA = "0x18674F150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 DKEMNKGCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x674D5A0", Offset = "0x674C9A0", VA = "0x18674D5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x674CEE0", Offset = "0x674C2E0", VA = "0x18674CEE0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x674CE20", Offset = "0x674C220", VA = "0x18674CE20", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float LLHNHAMJONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x674D4C0", Offset = "0x674C8C0", VA = "0x18674D4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x674CE80", Offset = "0x674C280", VA = "0x18674CE80", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x674CD60", Offset = "0x674C160", VA = "0x18674CD60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x674D770", Offset = "0x674CB70", VA = "0x18674D770", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x674F550", Offset = "0x674E950", VA = "0x18674F550", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event HPHIGNDJBNG IPLOBDAHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x674F0B0", Offset = "0x674E4B0", VA = "0x18674F0B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x674D6D0", Offset = "0x674CAD0", VA = "0x18674D6D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x674FE40", Offset = "0x674F240", VA = "0x18674FE40")]
	public CKFFFFOIJLD(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x674FD20", Offset = "0x674F120", VA = "0x18674FD20")]
	public float3 PCEEJMNEDAO()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x674C950", Offset = "0x674BD50", VA = "0x18674C950", Slot = "14")]
	public void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x674FB30", Offset = "0x674EF30", VA = "0x18674FB30", Slot = "16")]
	public void PAAPKOGBENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x674F200", Offset = "0x674E600", VA = "0x18674F200", Slot = "15")]
	public void KFCGHDKMPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x674F800", Offset = "0x674EC00", VA = "0x18674F800", Slot = "18")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x674D0D0", Offset = "0x674C4D0", VA = "0x18674D0D0", Slot = "19")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x674D540", Offset = "0x674C940", VA = "0x18674D540", Slot = "17")]
	public void GHCNKMMFANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x674D7A0", Offset = "0x674CBA0", VA = "0x18674D7A0", Slot = "20")]
	public void IKPOFDMCJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x674F580", Offset = "0x674E980", VA = "0x18674F580")]
	public void LLMPFDMKJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x674CBE0", Offset = "0x674BFE0", VA = "0x18674CBE0")]
	private void BMGHHHEEFGD(Vector3 PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x674C770", Offset = "0x674BB70", VA = "0x18674C770")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 BDAIFELEKBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x674CD60", Offset = "0x674C160", VA = "0x18674CD60")]
	private void MDMPMGJHAKL(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x674F8D0", Offset = "0x674ECD0", VA = "0x18674F8D0")]
	private Vector3 OHBGIAAIPOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x674F5C0", Offset = "0x674E9C0", VA = "0x18674F5C0")]
	private Quaternion MFIOEMKMMKE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x674DDA0", Offset = "0x674D1A0", VA = "0x18674DDA0")]
	internal (float, Vector3) INEGGBMDAOK(Rigidbody PHLAKEIILHD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class JFDFLDKDIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x675A3C0", Offset = "0x67597C0", VA = "0x18675A3C0")]
	public static CKFFFFOIJLD NLIKFKHAMJM(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LGOIMIKHDAD : KPFDDFIJLNI, ELHLAKJEHGP
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool LKAOHJKEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x675F810", Offset = "0x675EC10", VA = "0x18675F810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public AIOJKDBCCGB HLDGHGNJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x675EF60", Offset = "0x675E360", VA = "0x18675EF60", Slot = "11")]
		get
		{
			return default(AIOJKDBCCGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private AIOJKDBCCGB HNOIGCNHFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x675EF60", Offset = "0x675E360", VA = "0x18675EF60")]
		get
		{
			return default(AIOJKDBCCGB);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x675F620", Offset = "0x675EA20", VA = "0x18675F620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x675F870", Offset = "0x675EC70", VA = "0x18675F870")]
	public LGOIMIKHDAD(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x675EFC0", Offset = "0x675E3C0", VA = "0x18675EFC0", Slot = "4")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x675F0C0", Offset = "0x675E4C0", VA = "0x18675F0C0")]
	private bool DPBBGBFPFNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x675F690", Offset = "0x675EA90", VA = "0x18675F690", Slot = "5")]
	public void NINIHMHJIOH(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x675F790", Offset = "0x675EB90", VA = "0x18675F790", Slot = "6")]
	public void OGEEIHONFLM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x675F3C0", Offset = "0x675E7C0", VA = "0x18675F3C0", Slot = "9")]
	public void JFJKGHBLEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x675F520", Offset = "0x675E920", VA = "0x18675F520")]
	private void LGGNLDNIMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x675F1A0", Offset = "0x675E5A0", VA = "0x18675F1A0")]
	private void HGJMDHADJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x675F340", Offset = "0x675E740", VA = "0x18675F340", Slot = "8")]
	public void HIOFEBHDIAB(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x675F710", Offset = "0x675EB10", VA = "0x18675F710", Slot = "7")]
	public void NOAOEJBHDCI(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LBHBCGJEBOB : KPFDDFIJLNI, JHGBGHBKKFI
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x675ECB0", Offset = "0x675E0B0", VA = "0x18675ECB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool AJFECPPLJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x675EB40", Offset = "0x675DF40", VA = "0x18675EB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event HPHIGNDJBNG BBFKLNECANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x675EAA0", Offset = "0x675DEA0", VA = "0x18675EAA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x675EDF0", Offset = "0x675E1F0", VA = "0x18675EDF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public LBHBCGJEBOB(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x675EA30", Offset = "0x675DE30", VA = "0x18675EA30", Slot = "11")]
	public IDisposable GNMLCADBJPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x675EE90", Offset = "0x675E290", VA = "0x18675EE90", Slot = "8")]
	public void PIELBKJBLAM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x675ECA0", Offset = "0x675E0A0", VA = "0x18675ECA0", Slot = "9")]
	public void JKMDLEMOEHL(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x675EBA0", Offset = "0x675DFA0", VA = "0x18675EBA0", Slot = "10")]
	public void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x675ED10", Offset = "0x675E110", VA = "0x18675ED10", Slot = "12")]
	public void MKPMILMLBOM(Rigidbody DOBGLDLBPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x675E950", Offset = "0x675DD50", VA = "0x18675E950", Slot = "13")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x674F580", Offset = "0x674E980", VA = "0x18674F580", Slot = "6")]
	public void JPICPHOKBNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OMNCCGHMJOJ : KPFDDFIJLNI, HJIFDFCEKAC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView GDOBDAGLNKI;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x675E260", Offset = "0x675D660", VA = "0x18675E260", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6768480", Offset = "0x6767880", VA = "0x186768480", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event HPHIGNDJBNG ANIBELMENJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x67681F0", Offset = "0x67675F0", VA = "0x1867681F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6768290", Offset = "0x6767690", VA = "0x186768290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6768510", Offset = "0x6767910", VA = "0x186768510")]
	public OMNCCGHMJOJ(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6767980", Offset = "0x6766D80", VA = "0x186767980", Slot = "8")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6767C90", Offset = "0x6767090", VA = "0x186767C90", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6767FF0", Offset = "0x67673F0", VA = "0x186767FF0", Slot = "9")]
	public void MMHJPLOGOCP(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6767DF0", Offset = "0x67671F0", VA = "0x186767DF0", Slot = "10")]
	public void JPLPOBAICIK(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6767AB0", Offset = "0x6766EB0", VA = "0x186767AB0")]
	private void DJJBJCAKAKJ(PhotonView ACLIPCEIMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6768330", Offset = "0x6767730", VA = "0x186768330")]
	private void PDJPNGMNBLB(RigidbodyEx PLIMGLBNJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x67677C0", Offset = "0x6766BC0", VA = "0x1867677C0")]
	private void BOJJANOFCIL(PhotonView HAGIJJCNEAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class JMOOKDHJODA
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x675CF70", Offset = "0x675C370", VA = "0x18675CF70")]
	public static OMNCCGHMJOJ HILLKKMKFEK(this DLOGELIDANB OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HAKDCGJEAGM : KPFDDFIJLNI, MEFADKBNONK
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6758CD0", Offset = "0x67580D0", VA = "0x186758CD0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x67589A0", Offset = "0x6757DA0", VA = "0x1867589A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool BMKEOKJJENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6758C70", Offset = "0x6758070", VA = "0x186758C70", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6758D30", Offset = "0x6758130", VA = "0x186758D30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6758C10", Offset = "0x6758010", VA = "0x186758C10", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6758A10", Offset = "0x6757E10", VA = "0x186758A10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6758E30", Offset = "0x6758230", VA = "0x186758E30")]
	public HAKDCGJEAGM(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6758DA0", Offset = "0x67581A0", VA = "0x186758DA0", Slot = "9")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6758B90", Offset = "0x6757F90", VA = "0x186758B90", Slot = "10")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class MOHJJDDGHAN : KPFDDFIJLNI, ODEDNHPDPBN
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x67616A0", Offset = "0x6760AA0", VA = "0x1867616A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6761850", Offset = "0x6760C50", VA = "0x186761850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6761700", Offset = "0x6760B00", VA = "0x186761700", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6761480", Offset = "0x6760880", VA = "0x186761480", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public MOHJJDDGHAN(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6761760", Offset = "0x6760B60", VA = "0x186761760", Slot = "8")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x67615D0", Offset = "0x67609D0", VA = "0x1867615D0", Slot = "9")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[JGOEIFPBJFO(typeof(BDEEGLHDJMO), new string[] { })]
public sealed class EIHIBMKHHMA : KJACJMOCMBM, BDEEGLHDJMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[LGIDMEDGIGK]
	private JCELFKOBFCK GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6758050", Offset = "0x6757450", VA = "0x186758050", Slot = "4")]
	public void InitReferences(IMFGMFPAOFH PHINOHCBOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6757F00", Offset = "0x6757300", VA = "0x186757F00", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6757F30", Offset = "0x6757330", VA = "0x186757F30", Slot = "6")]
	public void INEGGBMDAOK(IAKELPIHEBB KIPEPOENGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x67582D0", Offset = "0x67576D0", VA = "0x1867582D0", Slot = "7")]
	public void PCNPMBCDKJI(IAKELPIHEBB KIPEPOENGME, bool PHKABHAKDFK, bool BFLPNEPKJJG, bool BGAMHHACFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6757DC0", Offset = "0x67571C0", VA = "0x186757DC0", Slot = "8")]
	public void BGJGJBJCIJE(IAKELPIHEBB KIPEPOENGME, float3 PCLIKLHGPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x67580A0", Offset = "0x67574A0", VA = "0x1867580A0", Slot = "9")]
	public void JKEDMKHHFOH(IAKELPIHEBB KIPEPOENGME, float3 LPOJPCGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x67584F0", Offset = "0x67578F0", VA = "0x1867584F0")]
	private bool PFFGBOBFHAP(IAKELPIHEBB KIPEPOENGME, [Out] DIFJMOOCNJF OOANNHIADDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x67581E0", Offset = "0x67575E0", VA = "0x1867581E0")]
	private bool JMMMCODCBIF(IAKELPIHEBB KIPEPOENGME, [Out] CKFFFFOIJLD MKCNJDBFPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6757CD0", Offset = "0x67570D0", VA = "0x186757CD0")]
	private bool ANCANMMIDGO(IAKELPIHEBB KIPEPOENGME, [Out] NOCMPKBKJLC BCPPOILBJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public EIHIBMKHHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class DLJCNMKCOBK : KPFDDFIJLNI, CCMOJEPOJEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool MCGIPNELNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6751C60", Offset = "0x6751060", VA = "0x186751C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x67519B0", Offset = "0x6750DB0", VA = "0x1867519B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6751950", Offset = "0x6750D50", VA = "0x186751950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool KNJLDCPKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6751C80", Offset = "0x6751080", VA = "0x186751C80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6751880", Offset = "0x6750C80", VA = "0x186751880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool MEBEIONLMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x67518F0", Offset = "0x6750CF0", VA = "0x1867518F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6751530", Offset = "0x6750930", VA = "0x186751530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int CAMHBJKLODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6751A10", Offset = "0x6750E10", VA = "0x186751A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event HPHIGNDJBNG BEDMPFHDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6751690", Offset = "0x6750A90", VA = "0x186751690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6751BC0", Offset = "0x6750FC0", VA = "0x186751BC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6751CE0", Offset = "0x67510E0", VA = "0x186751CE0")]
	public DLJCNMKCOBK(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6751480", Offset = "0x6750880", VA = "0x186751480", Slot = "6")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6751810", Offset = "0x6750C10", VA = "0x186751810", Slot = "8")]
	public void JLEGNPKNGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x67512E0", Offset = "0x67506E0", VA = "0x1867512E0", Slot = "7")]
	public bool DAGBCCPAPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x67515A0", Offset = "0x67509A0", VA = "0x1867515A0", Slot = "9")]
	public void HBACNHHPHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x674F580", Offset = "0x674E980", VA = "0x18674F580", Slot = "12")]
	public void BAKIIAICJJI(bool NHAFDJKECIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6751A80", Offset = "0x6750E80", VA = "0x186751A80", Slot = "11")]
	public void NNMJHMLNMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "10")]
	public void CCKPLMNDBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6751730", Offset = "0x6750B30", VA = "0x186751730")]
	private void JEOFGPLBEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CFMHMHEKFNE : KPFDDFIJLNI, PEEJJANOIFH
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x674B5E0", Offset = "0x674A9E0", VA = "0x18674B5E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x674ADC0", Offset = "0x674A1C0", VA = "0x18674ADC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x674B6C0", Offset = "0x674AAC0", VA = "0x18674B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool EJMAKBOFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x674AEB0", Offset = "0x674A2B0", VA = "0x18674AEB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x674B7A0", Offset = "0x674ABA0", VA = "0x18674B7A0")]
	public CFMHMHEKFNE(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x674AD10", Offset = "0x674A110", VA = "0x18674AD10", Slot = "5")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x674AF10", Offset = "0x674A310", VA = "0x18674AF10", Slot = "7")]
	public void ENAPHPMNHJC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x674B720", Offset = "0x674AB20", VA = "0x18674B720", Slot = "8")]
	public void PBIEBNGMCJD(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x674B1F0", Offset = "0x674A5F0", VA = "0x18674B1F0", Slot = "9")]
	public void FOODCFBEADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x674AF90", Offset = "0x674A390", VA = "0x18674AF90", Slot = "11")]
	public void FCELADEKNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x674B410", Offset = "0x674A810", VA = "0x18674B410", Slot = "12")]
	public void GCABGNIGINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "10")]
	public void LONAEEMKGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class NOCMPKBKJLC : KPFDDFIJLNI, MLHLHCLMBKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6761B60", Offset = "0x6760F60", VA = "0x186761B60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x67654D0", Offset = "0x67648D0", VA = "0x1867654D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6764BE0", Offset = "0x6763FE0", VA = "0x186764BE0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6761AF0", Offset = "0x6760EF0", VA = "0x186761AF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6764AF0", Offset = "0x6763EF0", VA = "0x186764AF0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6763E00", Offset = "0x6763200", VA = "0x186763E00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6764BB0", Offset = "0x6763FB0", VA = "0x186764BB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6761C10", Offset = "0x6761010", VA = "0x186761C10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6765410", Offset = "0x6764810", VA = "0x186765410", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x67643E0", Offset = "0x67637E0", VA = "0x1867643E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6764C90", Offset = "0x6764090", VA = "0x186764C90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x67634A0", Offset = "0x67628A0", VA = "0x1867634A0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6762760", Offset = "0x6761B60", VA = "0x186762760", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6762A70", Offset = "0x6761E70", VA = "0x186762A70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6765600", Offset = "0x6764A00", VA = "0x186765600", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private EEAHBLACECN LOOAHAKJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x6066D00", Offset = "0x6066100", VA = "0x186066D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool MCGIPNELNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6751C60", Offset = "0x6751060", VA = "0x186751C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public NOCMPKBKJLC(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6763300", Offset = "0x6762700", VA = "0x186763300", Slot = "20")]
	public void DHDFJEDLJPJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6763430", Offset = "0x6762830", VA = "0x186763430", Slot = "30")]
	public void EDFJEMJINGH(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6763250", Offset = "0x6762650", VA = "0x186763250", Slot = "19")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6763370", Offset = "0x6762770", VA = "0x186763370", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x67652A0", Offset = "0x67646A0", VA = "0x1867652A0", Slot = "28")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6763EC0", Offset = "0x67632C0", VA = "0x186763EC0", Slot = "35")]
	public Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6763C40", Offset = "0x6763040", VA = "0x186763C40", Slot = "34")]
	public Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6763250", Offset = "0x6762650", VA = "0x186763250", Slot = "27")]
	public void NHAGINDEKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6765540", Offset = "0x6764940", VA = "0x186765540", Slot = "25")]
	public void NHCLIFEGMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6765470", Offset = "0x6764870", VA = "0x186765470", Slot = "24")]
	public void MOMBLLKLGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6763010", Offset = "0x6762410", VA = "0x186763010", Slot = "33")]
	public void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6764B50", Offset = "0x6763F50", VA = "0x186764B50", Slot = "32")]
	public void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6762E40", Offset = "0x6762240", VA = "0x186762E40", Slot = "31")]
	public void DCFEFBIOGFI(Vector3 JCCFJHCOEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x67644A0", Offset = "0x67638A0", VA = "0x1867644A0", Slot = "22")]
	public void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x67627C0", Offset = "0x6761BC0", VA = "0x1867627C0", Slot = "21")]
	public void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6763830", Offset = "0x6762C30", VA = "0x186763830", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6764A10", Offset = "0x6763E10", VA = "0x186764A10", Slot = "29")]
	public Vector3 JMJBOGLLJKL(Vector3 BBCGBJMODNE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x67636A0", Offset = "0x6762AA0", VA = "0x1867636A0", Slot = "26")]
	public void FFIHLFPCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6762A70", Offset = "0x6761E70", VA = "0x186762A70")]
	private void CMLFFMIHHIO(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x67634D0", Offset = "0x67628D0", VA = "0x1867634D0")]
	private void EOJCMHIPCDK(Vector3 DOEONMFFPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6762BC0", Offset = "0x6761FC0", VA = "0x186762BC0")]
	private Vector3 DAIAIKEEEMM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6764D20", Offset = "0x6764120", VA = "0x186764D20")]
	private void MIHNDHDPBFK(Vector3 PCLIKLHGPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6764150", Offset = "0x6763550", VA = "0x186764150")]
	private Vector3 INAPBELDCBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x67621F0", Offset = "0x67615F0", VA = "0x1867621F0")]
	private void APJEAENPLLG(Vector3 PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6764CC0", Offset = "0x67640C0", VA = "0x186764CC0")]
	private void MBJBLMOILGK(Vector3 BBCGBJMODNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x67655A0", Offset = "0x67649A0", VA = "0x1867655A0")]
	private void OBPHBFCBCFK(Vector3 NMPMAICHKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6761C40", Offset = "0x6761040", VA = "0x186761C40")]
	private void ALEMAMMHDNC(string BKCGLIJFOCD, Vector3 PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x67640A0", Offset = "0x67634A0", VA = "0x1867640A0")]
	private void ILBFLBKOKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class KPFDDFIJLNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly DIFJMOOCNJF GEGOPKKJAFB;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected JCELFKOBFCK KCFAKJEDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x581DB60", Offset = "0x581CF60", VA = "0x18581DB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected IAKELPIHEBB GJKJKLOPDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x581DBA0", Offset = "0x581CFA0", VA = "0x18581DBA0")]
		get
		{
			return default(IAKELPIHEBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x674C6D0", Offset = "0x674BAD0", VA = "0x18674C6D0")]
	public KPFDDFIJLNI(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x675E8B0", Offset = "0x675DCB0", VA = "0x18675E8B0")]
	protected CEPMNDNBGMD FNDAHJBOELL(IAKELPIHEBB DNDHIPHFOEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AIPKFDLDKOC : ALBBBBGHPGI
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6749650", Offset = "0x6748A50", VA = "0x186749650", Slot = "4")]
	public HPAAABFEFAL PKCFBNMPCBK(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6748BF0", Offset = "0x6747FF0", VA = "0x186748BF0", Slot = "5")]
	public MLHLHCLMBKF ECEDMPFIEOD(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6749400", Offset = "0x6748800", VA = "0x186749400", Slot = "6")]
	public ADIMGFHHFBG MIEGGKMKNDJ(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6748DD0", Offset = "0x67481D0", VA = "0x186748DD0", Slot = "7")]
	public ODEDNHPDPBN GDLAHMFMBKG(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x67494E0", Offset = "0x67488E0", VA = "0x1867494E0", Slot = "8")]
	public CCMOJEPOJEG NEFKDPNEAJM(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x67490A0", Offset = "0x67484A0", VA = "0x1867490A0", Slot = "9")]
	public DLNEKELHMPF JFKDNCEHOEP(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6748890", Offset = "0x6747C90", VA = "0x186748890", Slot = "10")]
	public JHGBGHBKKFI BLHENODGIEA(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6749180", Offset = "0x6748580", VA = "0x186749180", Slot = "11")]
	public EEAHBLACECN JNBALBNDMMF(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6748B10", Offset = "0x6747F10", VA = "0x186748B10", Slot = "12")]
	public DIOJAKMPEID DOFHMDDNEIH(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6748FC0", Offset = "0x67483C0", VA = "0x186748FC0", Slot = "13")]
	public HHNDEEPJDOM HPECNGFGKPE(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6748CD0", Offset = "0x67480D0", VA = "0x186748CD0")]
	public PEEJJANOIFH GDFMJHGKAAF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6748EC0", Offset = "0x67482C0", VA = "0x186748EC0")]
	public HJIFDFCEKAC GKACBEHGAPO(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6748750", Offset = "0x6747B50", VA = "0x186748750")]
	public ELHLAKJEHGP AJNPMHPLPDN(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6749260", Offset = "0x6748660", VA = "0x186749260")]
	public ICDAGNHDDBM LGDIDBBIGBM(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6748970", Offset = "0x6747D70", VA = "0x186748970")]
	public MEFADKBNONK DFNCLLGJJIL(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x67492D0", Offset = "0x67486D0", VA = "0x1867492D0", Slot = "19")]
	public CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF, GHDMNJOELMD BJMBJJIMGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public AIPKFDLDKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6748CD0", Offset = "0x67480D0", VA = "0x186748CD0", Slot = "14")]
	private PEEJJANOIFH LEKNIEFMHKB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6748EC0", Offset = "0x67482C0", VA = "0x186748EC0", Slot = "15")]
	private HJIFDFCEKAC KILKEAAEEIB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6748750", Offset = "0x6747B50", VA = "0x186748750", Slot = "16")]
	private ELHLAKJEHGP JLMJGODCGMH(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6749260", Offset = "0x6748660", VA = "0x186749260", Slot = "17")]
	private ICDAGNHDDBM PIOPHLCNMJJ(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6748EB0", Offset = "0x67482B0", VA = "0x186748EB0", Slot = "18")]
	private MEFADKBNONK GEOGCJNDJBF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class HLMKCPGJDOA : IReadOnlyList<CEPMNDNBGMD>, IEnumerable<CEPMNDNBGMD>, IEnumerable, IReadOnlyCollection<CEPMNDNBGMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly IAKELPIHEBB DNDHIPHFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly JCELFKOBFCK HJJCMPJNNLD;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6759750", Offset = "0x6758B50", VA = "0x186759750", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public CEPMNDNBGMD BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x67594F0", Offset = "0x67588F0", VA = "0x1867594F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x358B3E0", Offset = "0x358A7E0", VA = "0x18358B3E0")]
	public HLMKCPGJDOA(IAKELPIHEBB DNDHIPHFOEE, JCELFKOBFCK HJJCMPJNNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6759640", Offset = "0x6758A40", VA = "0x186759640", Slot = "6")]
	public IEnumerator<CEPMNDNBGMD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6759640", Offset = "0x6758A40", VA = "0x186759640", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x67594F0", Offset = "0x67588F0", VA = "0x1867594F0")]
	[CompilerGenerated]
	private CEPMNDNBGMD CIJHMHBFNKB(int DJKFAHMDLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[JGOEIFPBJFO(typeof(ALBBBBGHPGI), new string[] { })]
public class PKDKFNONKKG : ALBBBBGHPGI, KJACJMOCMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ALBBBBGHPGI AHBFFEHMBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ALBBBBGHPGI MIDHDCAOAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MCADBNIAAFA AKEOPEJBMIG;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private ALBBBBGHPGI OCLOBCLPCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x676BD40", Offset = "0x676B140", VA = "0x18676BD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x676BA10", Offset = "0x676AE10", VA = "0x18676BA10", Slot = "20")]
	public void InitReferences(IMFGMFPAOFH PHINOHCBOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x676BEE0", Offset = "0x676B2E0", VA = "0x18676BEE0", Slot = "4")]
	public HPAAABFEFAL PKCFBNMPCBK(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x676B6D0", Offset = "0x676AAD0", VA = "0x18676B6D0", Slot = "5")]
	public MLHLHCLMBKF ECEDMPFIEOD(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x676BDA0", Offset = "0x676B1A0", VA = "0x18676BDA0", Slot = "6")]
	public ADIMGFHHFBG MIEGGKMKNDJ(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x676B820", Offset = "0x676AC20", VA = "0x18676B820", Slot = "7")]
	public ODEDNHPDPBN GDLAHMFMBKG(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x676BE40", Offset = "0x676B240", VA = "0x18676BE40", Slot = "8")]
	public CCMOJEPOJEG NEFKDPNEAJM(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x676BA60", Offset = "0x676AE60", VA = "0x18676BA60", Slot = "9")]
	public DLNEKELHMPF JFKDNCEHOEP(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x676B4E0", Offset = "0x676A8E0", VA = "0x18676B4E0", Slot = "10")]
	public JHGBGHBKKFI BLHENODGIEA(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x676BB00", Offset = "0x676AF00", VA = "0x18676BB00", Slot = "11")]
	public EEAHBLACECN JNBALBNDMMF(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x676B630", Offset = "0x676AA30", VA = "0x18676B630", Slot = "12")]
	public DIOJAKMPEID DOFHMDDNEIH(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x676B970", Offset = "0x676AD70", VA = "0x18676B970", Slot = "13")]
	public HHNDEEPJDOM HPECNGFGKPE(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x676B770", Offset = "0x676AB70", VA = "0x18676B770")]
	public PEEJJANOIFH GDFMJHGKAAF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x676B8C0", Offset = "0x676ACC0", VA = "0x18676B8C0")]
	public HJIFDFCEKAC GKACBEHGAPO(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x676B430", Offset = "0x676A830", VA = "0x18676B430")]
	public ELHLAKJEHGP AJNPMHPLPDN(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x676BBA0", Offset = "0x676AFA0", VA = "0x18676BBA0")]
	public ICDAGNHDDBM LGDIDBBIGBM(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x676B580", Offset = "0x676A980", VA = "0x18676B580")]
	public MEFADKBNONK DFNCLLGJJIL(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x676BC50", Offset = "0x676B050", VA = "0x18676BC50", Slot = "19")]
	public CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF, GHDMNJOELMD BJMBJJIMGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x676BF80", Offset = "0x676B380", VA = "0x18676BF80")]
	public PKDKFNONKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x676B770", Offset = "0x676AB70", VA = "0x18676B770", Slot = "14")]
	private PEEJJANOIFH LEKNIEFMHKB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x676B8C0", Offset = "0x676ACC0", VA = "0x18676B8C0", Slot = "15")]
	private HJIFDFCEKAC KILKEAAEEIB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x676B430", Offset = "0x676A830", VA = "0x18676B430", Slot = "16")]
	private ELHLAKJEHGP JLMJGODCGMH(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x676BBA0", Offset = "0x676AFA0", VA = "0x18676BBA0", Slot = "17")]
	private ICDAGNHDDBM PIOPHLCNMJJ(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x676B580", Offset = "0x676A980", VA = "0x18676B580", Slot = "18")]
	private MEFADKBNONK GEOGCJNDJBF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class AIEIBPBIENJ : CEPMNDNBGMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly AIEIBPBIENJ GDCHCCJBKDM;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx JNOOPBIIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8835C0", VA = "0x1808841C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x808680", Offset = "0x807A80", VA = "0x180808680", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF00", Offset = "0xA7A300", VA = "0x180A7AF00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9440D0", Offset = "0x9434D0", VA = "0x1809440D0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1C368F0", Offset = "0x1C35CF0", VA = "0x181C368F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3773CC0", Offset = "0x37730C0", VA = "0x183773CC0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x48441D0", Offset = "0x48435D0", VA = "0x1848441D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4842AA0", Offset = "0x4841EA0", VA = "0x184842AA0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2890", Offset = "0x3FE1C90", VA = "0x183FE2890", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3FE28B0", Offset = "0x3FE1CB0", VA = "0x183FE28B0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool LNINMEIPCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9D99A0", Offset = "0x9D8DA0", VA = "0x1809D99A0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NKJPHLBBJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x185BC70", Offset = "0x185B070", VA = "0x18185BC70", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC51B0", Offset = "0x5FC45B0", VA = "0x185FC51B0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1710", Offset = "0x3FE0B10", VA = "0x183FE1710", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x98C4F0", Offset = "0x98B8F0", VA = "0x18098C4F0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x67485B0", Offset = "0x67479B0", VA = "0x1867485B0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B53C60", Offset = "0x1B53060", VA = "0x181B53C60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x810F70", Offset = "0x810370", VA = "0x180810F70", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "48")]
		get
		{
			return default(FCPGOCNJIBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x128A150", Offset = "0x1289550", VA = "0x18128A150", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform DMMGLAOMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x96C8E0", Offset = "0x96BCE0", VA = "0x18096C8E0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 ELBCFGCNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float LDIBAJAAJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float HBDKBLLNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBB0", Offset = "0x8CDFB0", VA = "0x1808CEBB0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion OPLHNIOLKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA1B6A0", Offset = "0xA1AAA0", VA = "0x180A1B6A0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 LEEADPCABEK
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion DIGMIJLMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B6A0", Offset = "0xA1AAA0", VA = "0x180A1B6A0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool JALEGENKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x952110", Offset = "0x951510", VA = "0x180952110", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event HPHIGNDJBNG NHDABODMFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event HPHIGNDJBNG PCMIJELEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event PHHNAHNBNEN CBBEAPEJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event HPHIGNDJBNG ANIBELMENJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event HPHIGNDJBNG OECAJPNBAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event HPHIGNDJBNG BEDMPFHDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event HPHIGNDJBNG BBFKLNECANA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event HPHIGNDJBNG JLIJDLJOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "41")]
	public void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "71")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "72")]
	public void OKCHHCMNNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "73")]
	public void NHGNOJBCKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "74")]
	public void HBACNHHPHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "81")]
	public void LAMLBLPGIEN(CEPMNDNBGMD PCGOHCLJAPN, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "84")]
	public void AGOFHLPIPJG(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "85")]
	public void IFEBIIPNIBA(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "86")]
	public Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "87")]
	public Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "88")]
	public void NHAGINDEKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "89")]
	public void NHCLIFEGMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "90")]
	public void MOMBLLKLGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "91")]
	public void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "92")]
	public void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "93")]
	public void DCFEFBIOGFI(Vector3 JCCFJHCOEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "94")]
	public void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "95")]
	public void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "96")]
	public void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "97")]
	public Vector3 JMJBOGLLJKL(Vector3 PCGOHCLJAPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xBA0AB0", VA = "0x180BA16B0", Slot = "98")]
	public Vector3 BNLNJMPOIMJ(Vector3 PCGOHCLJAPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "99")]
	public void FFIHLFPCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "100")]
	public void CPDMALGCMJH(CEPMNDNBGMD BKHEPLIKHBN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "101")]
	public void INKCPECHBPC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "104")]
	public void PAAPKOGBENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "105")]
	public void KFCGHDKMPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "106")]
	public void GHCNKMMFANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "109")]
	public bool DAGBCCPAPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "110")]
	public void NNMJHMLNMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "115")]
	public IDisposable GNMLCADBJPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "116")]
	public void PIELBKJBLAM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "117")]
	public void JKMDLEMOEHL(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "118")]
	public void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "121")]
	public void CADFLFFEFOJ(Vector3 IMKHAKGPJAO, Quaternion FMIEMEPPPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "122")]
	public void LBIMBILHGEM(Vector3 OPICOCKBJBP, Quaternion MKMMAOLBFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "123")]
	public bool AOHBHDHLANI(float NHGFEEIKBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "124")]
	public void BACNNHPKBBP(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "125")]
	public void ILNLDNBHBGO(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "126")]
	public void ENAPHPMNHJC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "127")]
	public void PBIEBNGMCJD(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "128")]
	public void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "129")]
	public void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "130")]
	public void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "131")]
	public void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x67485D0", Offset = "0x67479D0", VA = "0x1867485D0", Slot = "132")]
	public bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "133")]
	public void IKPOFDMCJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public AIEIBPBIENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class DIFJMOOCNJF : DLOGELIDANB, NJFMHODFEFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal IAKELPIHEBB DNDHIPHFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal JCELFKOBFCK HIANKGFONFM;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6751210", Offset = "0x6750610", VA = "0x186751210")]
	public DIFJMOOCNJF(GameObject LMKHHJAKBGC, RigidbodyEx BPFDCFPPIED, GHDMNJOELMD BJMBJJIMGHO, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6750E80", Offset = "0x6750280", VA = "0x186750E80", Slot = "135")]
	protected override void JIMBAJCMCOP(GHDMNJOELMD BJMBJJIMGHO, PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "141")]
	protected override IDisposable MNMAMKNAAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6750A20", Offset = "0x674FE20", VA = "0x186750A20", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6750950", Offset = "0x674FD50", VA = "0x186750950", Slot = "142")]
	public void CGGJKIKCEKB(IKOBMPEJDCL NPHEJPFOCLG, IKOBMPEJDCL EAMIDELOEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6750B90", Offset = "0x674FF90", VA = "0x186750B90", Slot = "143")]
	public void FNDHEBBHIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x67510F0", Offset = "0x67504F0", VA = "0x1867510F0", Slot = "144")]
	public void KEHAJPEMHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6750760", Offset = "0x674FB60", VA = "0x186750760", Slot = "145")]
	public void BAKIIAICJJI(bool NHAFDJKECIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x67507C0", Offset = "0x674FBC0", VA = "0x1867507C0", Slot = "146")]
	public bool BKICEAAJJGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x67511B0", Offset = "0x67505B0", VA = "0x1867511B0", Slot = "147")]
	public void LIKMPAHBIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "140")]
	protected override void NJNHNBLEGHF(RigidbodyEx OBMKPHNOIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6750C50", Offset = "0x6750050", VA = "0x186750C50")]
	private void JDMOINGDMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class BDPNCKJHKKI
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x67496B0", Offset = "0x6748AB0", VA = "0x1867496B0")]
	public static DLOGELIDANB CJJOMHPKBMA(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface AMKDGEKLDKH : HPAAABFEFAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFLJCFEFFHN(CEPMNDNBGMD GEGOPKKJAFB);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCIFPANODDD(CEPMNDNBGMD GEGOPKKJAFB);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFMOLNGPIIN(CEPMNDNBGMD EDCMCCHKNKP);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCFDKADEHGE(CEPMNDNBGMD EDCMCCHKNKP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DDNBGMKMEMA : ADIMGFHHFBG
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	FCEBEFBJKEA<CEPMNDNBGMD> NFOGMFFEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	CEPMNDNBGMD FJJDGFJKFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface IIDNLOMAHHH : ICDAGNHDDBM
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) INEGGBMDAOK(Rigidbody PHLAKEIILHD);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface ALPJLNHMCEA : HJIFDFCEKAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView DLODABALOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class CBDKKICHHDH : DIOJAKMPEID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode NBBMDCPNMEI;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode GBGDPJGONGP
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x674A860", Offset = "0x6749C60", VA = "0x18674A860", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x674A690", Offset = "0x6749A90", VA = "0x18674A690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x674AC80", Offset = "0x674A080", VA = "0x18674AC80")]
	public CBDKKICHHDH(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x674A700", Offset = "0x6749B00", VA = "0x18674A700", Slot = "6")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x674AA90", Offset = "0x6749E90", VA = "0x18674AA90", Slot = "9")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x674AC70", Offset = "0x674A070", VA = "0x18674AC70", Slot = "7")]
	public void PNDMLGJLOIF(bool OMKCPNFFKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x674A680", Offset = "0x6749A80", VA = "0x18674A680", Slot = "8")]
	public void BGFMKGDAIHC(bool OMKCPNFFKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x674AB10", Offset = "0x6749F10", VA = "0x18674AB10", Slot = "10")]
	public bool NIHLOLOABNP(Vector3 FOKNCLAMPPK, [Out] RaycastHit LFKCKKJAFEE, float KNAMMKAAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x674A970", Offset = "0x6749D70", VA = "0x18674A970")]
	private void JMPHIDEKCBJ(bool OMKCPNFFKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class BKLNOANGLIF : DLNEKELHMPF, IDisposable, MGLBENKAKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private FCPGOCNJIBG JMOFLBAFMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AHOONNCGJKF NPEJNHLMGCK;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public FCPGOCNJIBG MCEPPCEEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x67499C0", Offset = "0x6748DC0", VA = "0x1867499C0", Slot = "6")]
		get
		{
			return default(FCPGOCNJIBG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6749E10", Offset = "0x6749210", VA = "0x186749E10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform HNDNDDANMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6749F30", Offset = "0x6749330", VA = "0x186749F30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<NBPFHEAGOPH, NBPFHEAGOPH> JANPIJIHJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x674A000", Offset = "0x6749400", VA = "0x18674A000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6749F50", Offset = "0x6749350", VA = "0x186749F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x674A0B0", Offset = "0x67494B0", VA = "0x18674A0B0")]
	public BKLNOANGLIF(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6749B10", Offset = "0x6748F10", VA = "0x186749B10", Slot = "8")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6749EE0", Offset = "0x67492E0", VA = "0x186749EE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x833740", Offset = "0x832B40", VA = "0x180833740", Slot = "11")]
	private void MGKPCJEFPMD(NBPFHEAGOPH EHCILKPBPDE, NBPFHEAGOPH IBPDPPGDMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "12")]
	private void BPNLCHBKDND(bool NHBIJGNKDPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class MNGJDPILHJJ : EEAHBLACECN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x674A810", Offset = "0x6749C10", VA = "0x18674A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x674C2E0", Offset = "0x674B6E0", VA = "0x18674C2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x674B6C0", Offset = "0x674AAC0", VA = "0x18674B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x67611C0", Offset = "0x67605C0", VA = "0x1867611C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x674AC80", Offset = "0x674A080", VA = "0x18674AC80")]
	public MNGJDPILHJJ(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6761060", Offset = "0x6760460", VA = "0x186761060", Slot = "4")]
	public void INDHIHAELAA(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6760B80", Offset = "0x675FF80", VA = "0x186760B80")]
	private void CMFJPHINLPN(Vector3 DOPMCGBECME, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6760DE0", Offset = "0x67601E0", VA = "0x186760DE0", Slot = "5")]
	public void DAADHBPIBNK(Vector3 DOPMCGBECME, Vector3 CJBHLOLHNJP, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6760A20", Offset = "0x675FE20", VA = "0x186760A20", Slot = "6")]
	public void BPMLOMNGGLM(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6761220", Offset = "0x6760620", VA = "0x186761220")]
	private void NFMAOENIMAC(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x67607C0", Offset = "0x675FBC0", VA = "0x1867607C0", Slot = "7")]
	public void BGEKIDBGGBH(Vector3 CJCNJCHABFF, ForceMode OGNJLPOLOKF = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class FBPHLBOIABG : HHNDEEPJDOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool IBBFHAFJPEG;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool LDLOHJNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6758620", Offset = "0x6757A20", VA = "0x186758620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x674AC80", Offset = "0x674A080", VA = "0x18674AC80")]
	public FBPHLBOIABG(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6758730", Offset = "0x6757B30", VA = "0x186758730", Slot = "6")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x67585B0", Offset = "0x67579B0", VA = "0x1867585B0", Slot = "7")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class OLEAODIDONF : AMKDGEKLDKH, HPAAABFEFAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CEPMNDNBGMD GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<CEPMNDNBGMD> BFGJPBMMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CEPMNDNBGMD BEOJJJNJFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private CEPMNDNBGMD NCGFJMKBOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform KMNCJNNFGCP;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6765EC0", Offset = "0x67652C0", VA = "0x186765EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6767010", Offset = "0x6766410", VA = "0x186767010", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public CEPMNDNBGMD DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<CEPMNDNBGMD> BOCOIHGOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event HPHIGNDJBNG NHDABODMFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6766F70", Offset = "0x6766370", VA = "0x186766F70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6765BB0", Offset = "0x6764FB0", VA = "0x186765BB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event HPHIGNDJBNG PCMIJELEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x67668B0", Offset = "0x6765CB0", VA = "0x1867668B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6765C50", Offset = "0x6765050", VA = "0x186765C50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event PHHNAHNBNEN CBBEAPEJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6767660", Offset = "0x6766A60", VA = "0x186767660", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x67659D0", Offset = "0x6764DD0", VA = "0x1867659D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action GEJOGGLNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6765B10", Offset = "0x6764F10", VA = "0x186765B10", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6767510", Offset = "0x6766910", VA = "0x186767510", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action OMDBNKAFFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6766950", Offset = "0x6765D50", VA = "0x186766950", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6765FD0", Offset = "0x67653D0", VA = "0x186765FD0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<CEPMNDNBGMD> NDINGFFANFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x67675B0", Offset = "0x67669B0", VA = "0x1867675B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x67661B0", Offset = "0x67655B0", VA = "0x1867661B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<CEPMNDNBGMD> IIENBBKIOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6765F20", Offset = "0x6765320", VA = "0x186765F20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x67662A0", Offset = "0x67656A0", VA = "0x1867662A0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action LOEFJNMIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6767150", Offset = "0x6766550", VA = "0x186767150", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x67671F0", Offset = "0x67665F0", VA = "0x1867671F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<CEPMNDNBGMD> BBLLODKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x67664E0", Offset = "0x67658E0", VA = "0x1867664E0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6766590", Offset = "0x6765990", VA = "0x186766590", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6767700", Offset = "0x6766B00", VA = "0x186767700")]
	public OLEAODIDONF(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6765E20", Offset = "0x6765220", VA = "0x186765E20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x67669F0", Offset = "0x6765DF0", VA = "0x1867669F0", Slot = "30")]
	public void LAMLBLPGIEN(CEPMNDNBGMD FANLJCAEFCA, bool IFGJAJEKPIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6766640", Offset = "0x6765A40", VA = "0x186766640", Slot = "6")]
	public void KFMOLNGPIIN(CEPMNDNBGMD EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6767290", Offset = "0x6766690", VA = "0x186767290", Slot = "7")]
	public void NCFDKADEHGE(CEPMNDNBGMD EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6766350", Offset = "0x6765750", VA = "0x186766350", Slot = "4")]
	public void HFLJCFEFFHN(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6765A70", Offset = "0x6764E70", VA = "0x186765A70", Slot = "5")]
	public void BCIFPANODDD(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6766440", Offset = "0x6765840", VA = "0x186766440")]
	private void IFEOCOLBHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6766260", Offset = "0x6765660", VA = "0x186766260")]
	private void FLDGKACJIKH(CEPMNDNBGMD EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6766070", Offset = "0x6765470", VA = "0x186766070")]
	private void EMAPAGODKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6767020", Offset = "0x6766420", VA = "0x186767020")]
	private void LLOHKJPIIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6765CF0", Offset = "0x67650F0", VA = "0x186765CF0")]
	private void DPCCILEDAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x67658E0", Offset = "0x6764CE0", VA = "0x1867658E0")]
	[CompilerGenerated]
	private object ACFDNFNEJJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MCDFPIDJMBH
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x675FA90", Offset = "0x675EE90", VA = "0x18675FA90")]
	public static AMKDGEKLDKH ELKGJKKMDPG(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class KKOKOOIEBFA : DDNBGMKMEMA, ADIMGFHHFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FCEBEFBJKEA<CEPMNDNBGMD> EPOPOCDENBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool LAKGLLHBDFK;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public FCEBEFBJKEA<CEPMNDNBGMD> NFOGMFFEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 ILHBGHPILCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x675CFD0", Offset = "0x675C3D0", VA = "0x18675CFD0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 PKIKJMJIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x675D920", Offset = "0x675CD20", VA = "0x18675D920", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x675D3F0", Offset = "0x675C7F0", VA = "0x18675D3F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public CEPMNDNBGMD FJJDGFJKFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x675D4E0", Offset = "0x675C8E0", VA = "0x18675D4E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x675DB50", Offset = "0x675CF50", VA = "0x18675DB50")]
	public KKOKOOIEBFA(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x675DAE0", Offset = "0x675CEE0", VA = "0x18675DAE0", Slot = "8")]
	public void PFJFKMGAKHN(CEPMNDNBGMD NCGFJMKBOIN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x675D000", Offset = "0x675C400", VA = "0x18675D000", Slot = "9")]
	public void GJDPDCOOPJI(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x675D060", Offset = "0x675C460", VA = "0x18675D060")]
	private Vector3 GNBLNOFNNIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x675D590", Offset = "0x675C990", VA = "0x18675D590")]
	private void NONHPKEMCKH(CEPMNDNBGMD BGMMODOBGEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class COEHGINAGJK
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6750130", Offset = "0x674F530", VA = "0x186750130")]
	public static DDNBGMKMEMA ELEJKBAPIJK(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class PHIKMGEEJPH : IIDNLOMAHHH, ICDAGNHDDBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 HEMIPMNIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 NIBFJMPDCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float IGEEMABBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float ACDPKOOAAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 NPMGEACAMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? IAPOJJFMDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? EIIBHBPLOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool AKGPIGFIKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool GCCNLEGCPMM;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 IGILEPOAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xBDD710", Offset = "0xBDCB10", VA = "0x180BDD710", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6768DE0", Offset = "0x67681E0", VA = "0x186768DE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 OEELKGEDMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6768CE0", Offset = "0x67680E0", VA = "0x186768CE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float BIACGGABCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1206CA0", Offset = "0x12060A0", VA = "0x181206CA0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x676AE00", Offset = "0x676A200", VA = "0x18676AE00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float KKCHMEGJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xC6F020", Offset = "0xC6E420", VA = "0x180C6F020", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6768C30", Offset = "0x6768030", VA = "0x186768C30", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 NPCCEAMCLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6769330", Offset = "0x6768730", VA = "0x186769330", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion IJNHIPPHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x676AB00", Offset = "0x6769F00", VA = "0x18676AB00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x675FFD0", Offset = "0x675F3D0", VA = "0x18675FFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event HPHIGNDJBNG IPLOBDAHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x676A980", Offset = "0x6769D80", VA = "0x18676A980", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6769290", Offset = "0x6768690", VA = "0x186769290", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x676B340", Offset = "0x676A740", VA = "0x18676B340")]
	public PHIKMGEEJPH(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x676B190", Offset = "0x676A590", VA = "0x18676B190", Slot = "17")]
	public void PAAPKOGBENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x676AA20", Offset = "0x6769E20", VA = "0x18676AA20", Slot = "16")]
	public void KFCGHDKMPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x676AF10", Offset = "0x676A310", VA = "0x18676AF10", Slot = "19")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6768E90", Offset = "0x6768290", VA = "0x186768E90", Slot = "20")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6769120", Offset = "0x6768520", VA = "0x186769120", Slot = "18")]
	public void GHCNKMMFANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x67694C0", Offset = "0x67688C0", VA = "0x1867694C0", Slot = "21")]
	public void IKPOFDMCJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6768DE0", Offset = "0x67681E0", VA = "0x186768DE0")]
	private void ENFLAAEJELC(Vector3 PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6768910", Offset = "0x6767D10", VA = "0x186768910")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BDAIFELEKBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x676AE00", Offset = "0x676A200", VA = "0x18676AE00")]
	private void MJCGLFKPKBH(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6768C30", Offset = "0x6768030", VA = "0x186768C30")]
	private void MDMPMGJHAKL(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x676AFF0", Offset = "0x676A3F0", VA = "0x18676AFF0")]
	private Vector3 OHBGIAAIPOL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6768A00", Offset = "0x6767E00", VA = "0x186768A00", Slot = "15")]
	public void BEKMKKIDDPI((Quaternion rot, Vector3 moments) MGBBEDLICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x676AC80", Offset = "0x676A080", VA = "0x18676AC80")]
	private Quaternion MFIOEMKMMKE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6769960", Offset = "0x6768D60", VA = "0x186769960")]
	public void INEGGBMDAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6769A30", Offset = "0x6768E30", VA = "0x186769A30", Slot = "4")]
	public (float, Vector3) INEGGBMDAOK(Rigidbody PHLAKEIILHD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class NNJDPKCMEDE
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6761A30", Offset = "0x6760E30", VA = "0x186761A30")]
	public static IIDNLOMAHHH NLIKFKHAMJM(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JHLPLEOJDMF : ELHLAKJEHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LEPMAMFFPJF MDDHNAPLIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly AIOJKDBCCGB EDKMJMLNODM;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool LKAOHJKEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xD67440", Offset = "0xD66840", VA = "0x180D67440", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public AIOJKDBCCGB HLDGHGNJJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0", Slot = "11")]
		get
		{
			return default(AIOJKDBCCGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x675AA70", Offset = "0x6759E70", VA = "0x18675AA70")]
	public JHLPLEOJDMF(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x675A450", Offset = "0x6759850", VA = "0x18675A450", Slot = "4")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x675A520", Offset = "0x6759920", VA = "0x18675A520")]
	private bool DPBBGBFPFNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x675A9D0", Offset = "0x6759DD0", VA = "0x18675A9D0", Slot = "5")]
	public void NINIHMHJIOH(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x675AA40", Offset = "0x6759E40", VA = "0x18675AA40", Slot = "6")]
	public void OGEEIHONFLM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x675A770", Offset = "0x6759B70", VA = "0x18675A770", Slot = "9")]
	public void JFJKGHBLEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x675A8B0", Offset = "0x6759CB0", VA = "0x18675A8B0")]
	private void LGGNLDNIMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x675A5C0", Offset = "0x67599C0", VA = "0x18675A5C0")]
	private void HGJMDHADJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x675A730", Offset = "0x6759B30", VA = "0x18675A730", Slot = "8")]
	public void HIOFEBHDIAB(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x675AA00", Offset = "0x6759E00", VA = "0x18675AA00", Slot = "7")]
	public void NOAOEJBHDCI(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class DEKNFDPNPEC : JHGBGHBKKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LEPMAMFFPJF HPKEFNAJPND;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool HFJKPMFIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6750490", Offset = "0x674F890", VA = "0x186750490", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event HPHIGNDJBNG BBFKLNECANA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x6750290", Offset = "0x674F690", VA = "0x186750290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x67505C0", Offset = "0x674F9C0", VA = "0x1867505C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6750670", Offset = "0x674FA70", VA = "0x186750670")]
	public DEKNFDPNPEC(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6750220", Offset = "0x674F620", VA = "0x186750220", Slot = "11")]
	public IDisposable GNMLCADBJPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6750660", Offset = "0x674FA60", VA = "0x186750660", Slot = "8")]
	public void PIELBKJBLAM(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6750440", Offset = "0x674F840", VA = "0x186750440", Slot = "9")]
	public void JKMDLEMOEHL(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6750330", Offset = "0x674F730", VA = "0x186750330", Slot = "10")]
	public void IIMKCJDAKNM(object ICNJFMMNIKL, bool COONFMMKHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6750450", Offset = "0x674F850", VA = "0x186750450", Slot = "6")]
	public void JPICPHOKBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6750540", Offset = "0x674F940", VA = "0x186750540", Slot = "12")]
	public void MKPMILMLBOM(Rigidbody DOBGLDLBPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x67501F0", Offset = "0x674F5F0", VA = "0x1867501F0", Slot = "13")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class KOFDMFDDGGB : ALPJLNHMCEA, HJIFDFCEKAC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView GDOBDAGLNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool JMCAHCPKDMI;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView DLODABALOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool PDPPNOANCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x675E260", Offset = "0x675D660", VA = "0x18675E260", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool KAENJMIDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x900930", Offset = "0x8FFD30", VA = "0x180900930", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event HPHIGNDJBNG ANIBELMENJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x675E560", Offset = "0x675D960", VA = "0x18675E560", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x675E600", Offset = "0x675DA00", VA = "0x18675E600", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x675E800", Offset = "0x675DC00", VA = "0x18675E800")]
	public KOFDMFDDGGB(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x675DEC0", Offset = "0x675D2C0", VA = "0x18675DEC0", Slot = "9")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x675E160", Offset = "0x675D560", VA = "0x18675E160", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x675E3F0", Offset = "0x675D7F0", VA = "0x18675E3F0", Slot = "10")]
	public void MMHJPLOGOCP(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x675E280", Offset = "0x675D680", VA = "0x18675E280", Slot = "11")]
	public void JPLPOBAICIK(CEPMNDNBGMD NCGFJMKBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x675DFF0", Offset = "0x675D3F0", VA = "0x18675DFF0")]
	private void DJJBJCAKAKJ(PhotonView ACLIPCEIMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x675E6A0", Offset = "0x675DAA0", VA = "0x18675E6A0")]
	private void PDJPNGMNBLB(RigidbodyEx PLIMGLBNJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x675DC50", Offset = "0x675D050", VA = "0x18675DC50")]
	private void BOJJANOFCIL(PhotonView HAGIJJCNEAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class LFGDNJHHEJB
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x675EEA0", Offset = "0x675E2A0", VA = "0x18675EEA0")]
	public static ALPJLNHMCEA HILLKKMKFEK(this CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class GNBLHAJCOMO : MEFADKBNONK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints NFANHHJMFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool IEENGDPKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xB7C990", Offset = "0xB7BD90", VA = "0x180B7C990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3F61740", Offset = "0x3F60B40", VA = "0x183F61740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool BMKEOKJJENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDF1880", Offset = "0xDF0C80", VA = "0x180DF1880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3F61730", Offset = "0x3F60B30", VA = "0x183F61730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints LFKCBGKMBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6758760", Offset = "0x6757B60", VA = "0x186758760", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x67588F0", Offset = "0x6757CF0", VA = "0x1867588F0")]
	public GNBLHAJCOMO(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x67588C0", Offset = "0x6757CC0", VA = "0x1867588C0", Slot = "9")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6758890", Offset = "0x6757C90", VA = "0x186758890", Slot = "10")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JJGEJPPJKBE : ODEDNHPDPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CEPMNDNBGMD GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float PGOFDFJFBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float GAFIOIMHEDD;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float MNENNIEMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x944730", Offset = "0x943B30", VA = "0x180944730", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x675ADA0", Offset = "0x675A1A0", VA = "0x18675ADA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float KIEPBKJGIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9FAB00", Offset = "0x9F9F00", VA = "0x1809FAB00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x675ABE0", Offset = "0x6759FE0", VA = "0x18675ABE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x675AE70", Offset = "0x675A270", VA = "0x18675AE70")]
	public JJGEJPPJKBE(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x675AD50", Offset = "0x675A150", VA = "0x18675AD50", Slot = "8")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x675ACB0", Offset = "0x675A0B0", VA = "0x18675ACB0", Slot = "9")]
	public void FEJGKAFHPOG(Rigidbody JLPFJOLEFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class MGOIIJHEGKC : CCMOJEPOJEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool LIJHBNFNMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool CHDPINJPNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int APPOEEGLMPF;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x675FFD0", Offset = "0x675F3D0", VA = "0x18675FFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool MCGIPNELNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6760640", Offset = "0x675FA40", VA = "0x186760640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private CEPMNDNBGMD PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x67604A0", Offset = "0x675F8A0", VA = "0x1867604A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6760440", Offset = "0x675F840", VA = "0x186760440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event HPHIGNDJBNG BEDMPFHDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6760200", Offset = "0x675F600", VA = "0x186760200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x67605A0", Offset = "0x675F9A0", VA = "0x1867605A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6760660", Offset = "0x675FA60", VA = "0x186760660")]
	public MGOIIJHEGKC(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x675FEA0", Offset = "0x675F2A0", VA = "0x18675FEA0", Slot = "6")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6760430", Offset = "0x675F830", VA = "0x186760430", Slot = "8")]
	public void JLEGNPKNGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x675FD50", Offset = "0x675F150", VA = "0x18675FD50", Slot = "7")]
	public bool DAGBCCPAPGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x675FF30", Offset = "0x675F330", VA = "0x18675FF30", Slot = "9")]
	public void HBACNHHPHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6760500", Offset = "0x675F900", VA = "0x186760500", Slot = "11")]
	public void NNMJHMLNMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x675FB50", Offset = "0x675EF50", VA = "0x18675FB50", Slot = "12")]
	public void BAKIIAICJJI(bool NHAFDJKECIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x675FBA0", Offset = "0x675EFA0", VA = "0x18675FBA0", Slot = "10")]
	public void CCKPLMNDBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6760020", Offset = "0x675F420", VA = "0x186760020")]
	private bool HIODHEIPHEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x67602A0", Offset = "0x675F6A0", VA = "0x1867602A0")]
	private void JEOFGPLBEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class ABCOGNEMNJO : PEEJJANOIFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly LEPMAMFFPJF BBCGEKHGECJ;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody IOMJFIEMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool GFHKNECPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x67737C0", Offset = "0x6772BC0", VA = "0x1867737C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool EJMAKBOFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xD67440", Offset = "0xD66840", VA = "0x180D67440", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6773810", Offset = "0x6772C10", VA = "0x186773810")]
	public ABCOGNEMNJO(CEPMNDNBGMD GEGOPKKJAFB, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6772A20", Offset = "0x6771E20", VA = "0x186772A20", Slot = "5")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6772C40", Offset = "0x6772040", VA = "0x186772C40", Slot = "7")]
	public void ENAPHPMNHJC(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x67737E0", Offset = "0x6772BE0", VA = "0x1867737E0", Slot = "8")]
	public void PBIEBNGMCJD(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6772E60", Offset = "0x6772260", VA = "0x186772E60", Slot = "9")]
	public void FOODCFBEADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x6772C70", Offset = "0x6772070", VA = "0x186772C70", Slot = "11")]
	public void FCELADEKNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x6773130", Offset = "0x6772530", VA = "0x186773130", Slot = "12")]
	public void GCABGNIGINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x67732B0", Offset = "0x67726B0", VA = "0x1867732B0", Slot = "10")]
	public void LONAEEMKGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6772AC0", Offset = "0x6771EC0", VA = "0x186772AC0")]
	private void DLHLIOHCFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x67728A0", Offset = "0x6771CA0", VA = "0x1867728A0")]
	private void BKCPKDCGCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class KOMLNJMILKO : MLHLHCLMBKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly DLOGELIDANB GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly LEPMAMFFPJF CCBJFGHMKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float PIHMBBMGCEO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public IIEEDGINFNK MADJLAKFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public FKCADLHCKCE JOHKMGKIEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 FEKMJAHBGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x67760F0", Offset = "0x67754F0", VA = "0x1867760F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x67754E0", Offset = "0x67748E0", VA = "0x1867754E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 PCMKAHBDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6776270", Offset = "0x6775670", VA = "0x186776270", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6774070", Offset = "0x6773470", VA = "0x186774070", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 OKEHEDEPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6776E10", Offset = "0x6776210", VA = "0x186776E10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x67758A0", Offset = "0x6774CA0", VA = "0x1867758A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 FNHPIOFIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6776360", Offset = "0x6775760", VA = "0x186776360", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6774D20", Offset = "0x6774120", VA = "0x186774D20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float LCJPOGDHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x9811C0", Offset = "0x9805C0", VA = "0x1809811C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6774770", Offset = "0x6773B70", VA = "0x186774770", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool JJKOGDNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x17208A0", Offset = "0x171FCA0", VA = "0x1817208A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private EEAHBLACECN LOOAHAKJBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6066D00", Offset = "0x6066100", VA = "0x186066D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool MCGIPNELNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x6751C60", Offset = "0x6751060", VA = "0x186751C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6776FF0", Offset = "0x67763F0", VA = "0x186776FF0")]
	public KOMLNJMILKO(CEPMNDNBGMD GEGOPKKJAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6774C10", Offset = "0x6774010", VA = "0x186774C10", Slot = "19")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6774CC0", Offset = "0x67740C0", VA = "0x186774CC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6776D40", Offset = "0x6776140", VA = "0x186776D40", Slot = "28")]
	public void MKPMILMLBOM(Rigidbody JLPFJOLEFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xBBC580", Offset = "0xBBB980", VA = "0x180BBC580", Slot = "20")]
	public void DHDFJEDLJPJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xBBB400", Offset = "0xBBA800", VA = "0x180BBB400", Slot = "30")]
	public void EDFJEMJINGH(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x67755A0", Offset = "0x67749A0", VA = "0x1867755A0", Slot = "35")]
	public Vector3 IILGPMDCDBH(Vector3 LEGMFGGOFOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6775390", Offset = "0x6774790", VA = "0x186775390", Slot = "34")]
	public Vector3 HHCPNEEDGFO(Vector3 PCLIKLHGPPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6774C10", Offset = "0x6774010", VA = "0x186774C10", Slot = "27")]
	public void NHAGINDEKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6776F90", Offset = "0x6776390", VA = "0x186776F90", Slot = "25")]
	public void NHCLIFEGMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6776F30", Offset = "0x6776330", VA = "0x186776F30", Slot = "24")]
	public void MOMBLLKLGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6774A70", Offset = "0x6773E70", VA = "0x186774A70", Slot = "33")]
	public void DCNDCGGAFAN(Vector3 NBFDHLEEHGK, Vector3 PPIBMBALJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6776210", Offset = "0x6775610", VA = "0x186776210", Slot = "32")]
	public void KJMODIOPJOC(Vector3 GBGIPMBFGEE, Vector3 LPOJPCGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6774900", Offset = "0x6773D00", VA = "0x186774900", Slot = "31")]
	public void DCFEFBIOGFI(Vector3 JCCFJHCOEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6775960", Offset = "0x6774D60", VA = "0x186775960", Slot = "22")]
	public void JLKCKCMLAEN(LNMPNHNJFFJ ADHJLPBFMLL, Vector3 IKEHHPAAKCE, float EJMMMDJDDBA, float KHKILFHGGGB = 8f, float EPCBJLLHBMO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x67744E0", Offset = "0x67738E0", VA = "0x1867744E0", Slot = "21")]
	public void BOKCBFKNNJB(GDFENKOOKGK GEDJHEKCAPD, Vector3 DOEONMFFPIJ, float LMDIHGHLDLK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6774FF0", Offset = "0x67743F0", VA = "0x186774FF0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HAIIDKPCKAL(GDFENKOOKGK GEDJHEKCAPD, Vector3 APMJJPLCLEP, float IKAAONCAOLN = 7f, float LDBDEPKNNII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6775F90", Offset = "0x6775390", VA = "0x186775F90", Slot = "29")]
	public Vector3 JMJBOGLLJKL(Vector3 BBCGBJMODNE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6774EC0", Offset = "0x67742C0", VA = "0x186774EC0", Slot = "26")]
	public void FFIHLFPCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6774770", Offset = "0x6773B70", VA = "0x186774770")]
	private void CMLFFMIHHIO(float PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6774D50", Offset = "0x6774150", VA = "0x186774D50")]
	private void EOJCMHIPCDK(Vector3 DOEONMFFPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6774820", Offset = "0x6773C20", VA = "0x186774820")]
	private Vector3 DAIAIKEEEMM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x67768E0", Offset = "0x6775CE0", VA = "0x1867768E0")]
	private void MIHNDHDPBFK(Vector3 PCLIKLHGPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x67757C0", Offset = "0x6774BC0", VA = "0x1867757C0")]
	private Vector3 INAPBELDCBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x67740A0", Offset = "0x67734A0", VA = "0x1867740A0")]
	private void APJEAENPLLG(Vector3 PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6776450", Offset = "0x6775850", VA = "0x186776450")]
	private void MBJBLMOILGK(Vector3 PCLIKLHGPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6775710", Offset = "0x6774B10", VA = "0x186775710")]
	private void ILBFLBKOKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ACGHHKNCINC : ALBBBBGHPGI
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6774010", Offset = "0x6773410", VA = "0x186774010", Slot = "4")]
	public HPAAABFEFAL PKCFBNMPCBK(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6773A70", Offset = "0x6772E70", VA = "0x186773A70", Slot = "5")]
	public MLHLHCLMBKF ECEDMPFIEOD(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6773F50", Offset = "0x6773350", VA = "0x186773F50", Slot = "6")]
	public ADIMGFHHFBG MIEGGKMKNDJ(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6773C40", Offset = "0x6773040", VA = "0x186773C40", Slot = "7")]
	public ODEDNHPDPBN GDLAHMFMBKG(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6773FB0", Offset = "0x67733B0", VA = "0x186773FB0", Slot = "8")]
	public CCMOJEPOJEG NEFKDPNEAJM(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6773D70", Offset = "0x6773170", VA = "0x186773D70", Slot = "9")]
	public DLNEKELHMPF JFKDNCEHOEP(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6773940", Offset = "0x6772D40", VA = "0x186773940", Slot = "10")]
	public JHGBGHBKKFI BLHENODGIEA(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6773DD0", Offset = "0x67731D0", VA = "0x186773DD0", Slot = "11")]
	public EEAHBLACECN JNBALBNDMMF(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6773A10", Offset = "0x6772E10", VA = "0x186773A10", Slot = "12")]
	public DIOJAKMPEID DOFHMDDNEIH(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6773D10", Offset = "0x6773110", VA = "0x186773D10", Slot = "13")]
	public HHNDEEPJDOM HPECNGFGKPE(CEPMNDNBGMD OOANNHIADDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6773B50", Offset = "0x6772F50", VA = "0x186773B50")]
	public PEEJJANOIFH GDFMJHGKAAF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6773CA0", Offset = "0x67730A0", VA = "0x186773CA0")]
	public HJIFDFCEKAC GKACBEHGAPO(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x67738D0", Offset = "0x6772CD0", VA = "0x1867738D0")]
	public ELHLAKJEHGP AJNPMHPLPDN(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6773E30", Offset = "0x6773230", VA = "0x186773E30")]
	public ICDAGNHDDBM LGDIDBBIGBM(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x67739A0", Offset = "0x6772DA0", VA = "0x1867739A0")]
	public MEFADKBNONK DFNCLLGJJIL(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6773EA0", Offset = "0x67732A0", VA = "0x186773EA0", Slot = "19")]
	public CEPMNDNBGMD MBJAIEFPEDA(RigidbodyEx GEGOPKKJAFB, PLIDDIKOIFE FLKOGFDGJDF, GHDMNJOELMD BJMBJJIMGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public ACGHHKNCINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6773B50", Offset = "0x6772F50", VA = "0x186773B50", Slot = "14")]
	private PEEJJANOIFH LEKNIEFMHKB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6773CA0", Offset = "0x67730A0", VA = "0x186773CA0", Slot = "15")]
	private HJIFDFCEKAC KILKEAAEEIB(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x67738D0", Offset = "0x6772CD0", VA = "0x1867738D0", Slot = "16")]
	private ELHLAKJEHGP JLMJGODCGMH(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6773E30", Offset = "0x6773230", VA = "0x186773E30", Slot = "17")]
	private ICDAGNHDDBM PIOPHLCNMJJ(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x67739A0", Offset = "0x6772DA0", VA = "0x1867739A0", Slot = "18")]
	private MEFADKBNONK GEOGCJNDJBF(CEPMNDNBGMD OOANNHIADDH, [In] PLIDDIKOIFE FLKOGFDGJDF)
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
