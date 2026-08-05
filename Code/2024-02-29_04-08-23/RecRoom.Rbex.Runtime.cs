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
	public class LogRegistrationIndex : KBDNGCLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6560340", Offset = "0x655F140", VA = "0x186560340", Slot = "4")]
		public override void NLHDMBJLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
	public class _AssemblyIndex : MLJNMKFIGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EENLKAGMGJE bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EENLKAGMGJE bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A100", Offset = "0x5F68F00", VA = "0x185F6A100", Slot = "5")]
		public override void JHOHBHCKFCE(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x656ED00", Offset = "0x656DB00", VA = "0x18656ED00")]
		private void PHCLPOGNBJN(JIGNBFODIDF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x656E8D0", Offset = "0x656D6D0", VA = "0x18656E8D0")]
		private void HKHMGINCELK(JIGNBFODIDF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x656EE70", Offset = "0x656DC70", VA = "0x18656EE70", Slot = "6")]
		public override void PPJLFIMLGNK(JIGNBFODIDF registry, [In] LCAIGHCIJNG filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
		public override void MFEEKKLICMI(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x656F060", Offset = "0x656DE60", VA = "0x18656F060")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MIKBECLFJBF(RigidbodyEx ENJGHAAIIMD);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ICEFHJCPMAE(RigidbodyEx ENJGHAAIIMD, bool JEJBEBJPFDD = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DPLOONIGBAD
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
public enum BODECPAEPFD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AEFHKHEJCCM
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HLLKJAAFIAG(typeof(MGHOBDFLPBO), new string[] { "Ignore", "Mock" })]
public class LAEOPGOBIAH : MGHOBDFLPBO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ONNLNLMBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
	public void KOOLCNALBJL(string OLGJDMIGDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	public void LHAPCCEDIPK(RigidbodyEx NPOMGMGDKBM, Action ENHEBPDFNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "7")]
	public AFLEKNEEHDF LONMJGKAJDK(int DAJCGFDJPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
	public void NCBANBDDNCP(Vector3 IJDLLHOBIAB, float AAHOBJDEOGE, Color OLDELFAHHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LAEOPGOBIAH()
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
		private static readonly KNPFMNBIIDA MDBEOLBOLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool NKENPHOPHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JNIFIKAJIFG IIGBGDHIPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[KNLLPIHNEKK(ONGLIIBHLOO.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[KNLLPIHNEKK(ONGLIIBHLOO.SelfAndParent, true, false, false)]
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
		private BODECPAEPFD physicsInterpolation;

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
		internal JNIFIKAJIFG AJLKPLFIPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x656A1A0", Offset = "0x6568FA0", VA = "0x18656A1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> CGEECCJFLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FADKFJCKILG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x656BFB0", Offset = "0x656ADB0", VA = "0x18656BFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx CGOAPMHKIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x656BF10", Offset = "0x656AD10", VA = "0x18656BF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx AJKCELPHOFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x656CBD0", Offset = "0x656B9D0", VA = "0x18656CBD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x656E150", Offset = "0x656CF50", VA = "0x18656E150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform HKLHNMNIMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D24A0", Offset = "0x7D12A0", VA = "0x1807D24A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform GDAKNEOILHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D24A0", Offset = "0x7D12A0", VA = "0x1807D24A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FHGPIDLFGGI PHPFHPOLJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x656BCD0", Offset = "0x656AAD0", VA = "0x18656BCD0")]
			get
			{
				return default(FHGPIDLFGGI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x656D900", Offset = "0x656C700", VA = "0x18656D900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AAIJLENGLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x656C260", Offset = "0x656B060", VA = "0x18656C260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool JIGCIEEMIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x656BDF0", Offset = "0x656ABF0", VA = "0x18656BDF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MABPGHFPKBK DHCEONLHDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x656C1A0", Offset = "0x656AFA0", VA = "0x18656C1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x656DAC0", Offset = "0x656C8C0", VA = "0x18656DAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FBNLPKHODPC GIGEDMEPAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x656C140", Offset = "0x656AF40", VA = "0x18656C140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x656DA50", Offset = "0x656C850", VA = "0x18656DA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool FALJHNAANJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x656C090", Offset = "0x656AE90", VA = "0x18656C090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody CDDBDMLICLE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x656C0F0", Offset = "0x656AEF0", VA = "0x18656C0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EIMCIHBKPGK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x656BE50", Offset = "0x656AC50", VA = "0x18656BE50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x656D970", Offset = "0x656C770", VA = "0x18656D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CKGOPFHBCCE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5D5BBE0", Offset = "0x5D5A9E0", VA = "0x185D5BBE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D5C2A0", Offset = "0x5D5B0A0", VA = "0x185D5C2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float IBABECJCJBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x656CB70", Offset = "0x656B970", VA = "0x18656CB70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float LPCAAJKDNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x656CB10", Offset = "0x656B910", VA = "0x18656CB10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x656E0E0", Offset = "0x656CEE0", VA = "0x18656E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ALMIPBGDHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x656C4C0", Offset = "0x656B2C0", VA = "0x18656C4C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x656DD60", Offset = "0x656CB60", VA = "0x18656DD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LGAMILJNGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x656C2C0", Offset = "0x656B0C0", VA = "0x18656C2C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x656DB30", Offset = "0x656C930", VA = "0x18656DB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ILFNPMHJDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x656D130", Offset = "0x656BF30", VA = "0x18656D130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x656E6B0", Offset = "0x656D4B0", VA = "0x18656E6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 KBCJHMLOEGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x656C8F0", Offset = "0x656B6F0", VA = "0x18656C8F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x656DEB0", Offset = "0x656CCB0", VA = "0x18656DEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 IJDLLHOBIAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x656D270", Offset = "0x656C070", VA = "0x18656D270")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode DDPAMDIACOM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x656C400", Offset = "0x656B200", VA = "0x18656C400")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x656DC80", Offset = "0x656CA80", VA = "0x18656DC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float BGIBBCLOEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x656BEB0", Offset = "0x656ACB0", VA = "0x18656BEB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x656D9E0", Offset = "0x656C7E0", VA = "0x18656D9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints CAJIGFCNKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x656C460", Offset = "0x656B260", VA = "0x18656C460")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x656DCF0", Offset = "0x656CAF0", VA = "0x18656DCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 JNMINHGDCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x656CC70", Offset = "0x656BA70", VA = "0x18656CC70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 DKAPNKJKEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x656CC70", Offset = "0x656BA70", VA = "0x18656CC70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x656E490", Offset = "0x656D290", VA = "0x18656E490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FIDHJLMONDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x656C9D0", Offset = "0x656B7D0", VA = "0x18656C9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x656DF90", Offset = "0x656CD90", VA = "0x18656DF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DEIPEIDFAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x656D0D0", Offset = "0x656BED0", VA = "0x18656D0D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x656E640", Offset = "0x656D440", VA = "0x18656E640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion GAKKNFAIEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x656CD50", Offset = "0x656BB50", VA = "0x18656CD50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x656E210", Offset = "0x656D010", VA = "0x18656E210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion IKFEFBOKAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x656CFF0", Offset = "0x656BDF0", VA = "0x18656CFF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x656E570", Offset = "0x656D370", VA = "0x18656E570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 GGKDICMFBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x656CE30", Offset = "0x656BC30", VA = "0x18656CE30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x656E2E0", Offset = "0x656D0E0", VA = "0x18656E2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion AEKPJOFMPME
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x656CF10", Offset = "0x656BD10", VA = "0x18656CF10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x656E3C0", Offset = "0x656D1C0", VA = "0x18656E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 FEAOCKEGNIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x656D190", Offset = "0x656BF90", VA = "0x18656D190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x656E720", Offset = "0x656D520", VA = "0x18656E720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 MECEBMJGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x656CA30", Offset = "0x656B830", VA = "0x18656CA30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x656E000", Offset = "0x656CE00", VA = "0x18656E000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NDNOKJPALDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x656C320", Offset = "0x656B120", VA = "0x18656C320")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x656DBA0", Offset = "0x656C9A0", VA = "0x18656DBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DIPOODJFJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x656C810", Offset = "0x656B610", VA = "0x18656C810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x656DDD0", Offset = "0x656CBD0", VA = "0x18656DDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IDFMLECGHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x656C6D0", Offset = "0x656B4D0", VA = "0x18656C6D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion DGLAGKBNNOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x656C5F0", Offset = "0x656B3F0", VA = "0x18656C5F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JCPKKCIHIFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x656D430", Offset = "0x656C230", VA = "0x18656D430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 JDCBGOLBDEC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x656D350", Offset = "0x656C150", VA = "0x18656D350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GLJMFCDGBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x656C7B0", Offset = "0x656B5B0", VA = "0x18656C7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IHJAGFDOKOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x656C200", Offset = "0x656B000", VA = "0x18656C200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JHBAMFHNOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x656BD90", Offset = "0x656AB90", VA = "0x18656BD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool COBNBGFHHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x656BD30", Offset = "0x656AB30", VA = "0x18656BD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GEJKBIJMFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x656BC70", Offset = "0x656AA70", VA = "0x18656BC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FEKEAPJIHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x656C520", Offset = "0x656B320", VA = "0x18656C520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LICKKMNBHJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x510F0E0", Offset = "0x510DEE0", VA = "0x18510F0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MIKBECLFJBF JNHHOPOBCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656A990", VA = "0x18656BB90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x656D820", Offset = "0x656C620", VA = "0x18656D820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ICEFHJCPMAE LAPOCEOFECA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x656BB20", Offset = "0x656A920", VA = "0x18656BB20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x656D7B0", Offset = "0x656C5B0", VA = "0x18656D7B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MIKBECLFJBF NGEJMPGOPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x656B880", Offset = "0x656A680", VA = "0x18656B880")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x656D510", Offset = "0x656C310", VA = "0x18656D510")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MIKBECLFJBF CPAAPFDLPHA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x656B8F0", Offset = "0x656A6F0", VA = "0x18656B8F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x656D580", Offset = "0x656C380", VA = "0x18656D580")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event MIKBECLFJBF OKNKKIHCEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x656BA40", Offset = "0x656A840", VA = "0x18656BA40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x656D6D0", Offset = "0x656C4D0", VA = "0x18656D6D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x656B9D0", Offset = "0x656A7D0", VA = "0x18656B9D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x656D660", Offset = "0x656C460", VA = "0x18656D660")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MIKBECLFJBF BCFLOCEPKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656A8B0", VA = "0x18656BAB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x656D740", Offset = "0x656C540", VA = "0x18656D740")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MIKBECLFJBF JAHAEMADGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x656BC00", Offset = "0x656AA00", VA = "0x18656BC00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x656D890", Offset = "0x656C690", VA = "0x18656D890")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event MIKBECLFJBF COGENIEGILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x656B960", Offset = "0x656A760", VA = "0x18656B960")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x656D5F0", Offset = "0x656C3F0", VA = "0x18656D5F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		internal void FDKAAPKEKOD(JNIFIKAJIFG HBHLLIKFPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x656A0B0", Offset = "0x6568EB0", VA = "0x18656A0B0")]
		internal void BHBOKCHIKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x656B5A0", Offset = "0x656A3A0", VA = "0x18656B5A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody EHEFPDCPNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x656B270", Offset = "0x656A070", VA = "0x18656B270")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) JDFPGJKLCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x656A040", Offset = "0x6568E40", VA = "0x18656A040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x656A1A0", Offset = "0x6568FA0", VA = "0x18656A1A0")]
		private JNIFIKAJIFG JJKLGOEJJPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6569360", Offset = "0x6568160", VA = "0x186569360")]
		private void AFGFMMMFKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x656AA40", Offset = "0x6569840", VA = "0x18656AA40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x656A0B0", Offset = "0x6568EB0", VA = "0x18656A0B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x656A9E0", Offset = "0x65697E0", VA = "0x18656A9E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x656AAA0", Offset = "0x65698A0", VA = "0x18656AAA0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65696F0", Offset = "0x65684F0", VA = "0x1865696F0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x656AB00", Offset = "0x6569900", VA = "0x18656AB00")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x656A3D0", Offset = "0x65691D0", VA = "0x18656A3D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x656A980", Offset = "0x6569780", VA = "0x18656A980")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x656B3D0", Offset = "0x656A1D0", VA = "0x18656B3D0")]
		public void SetParent(RigidbodyEx NKKIECLCEML, bool JEJBEBJPFDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x656AE10", Offset = "0x6569C10", VA = "0x18656AE10")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x656A650", Offset = "0x6569450", VA = "0x18656A650")]
		public bool IsRigidbodyAncestor(RigidbodyEx AEJDINJFCOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x656A730", Offset = "0x6569530", VA = "0x18656A730")]
		public bool IsRigidbodyDescendant(RigidbodyEx DMOPJMMPEPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6569960", Offset = "0x6568760", VA = "0x186569960")]
		public void AddInterpolationRestriction(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x656AB70", Offset = "0x6569970", VA = "0x18656AB70")]
		public void RemoveInterpolationRestriction(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x656A140", Offset = "0x6568F40", VA = "0x18656A140")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x65699D0", Offset = "0x65687D0", VA = "0x1865699D0")]
		public void AddKinematic(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x656ABE0", Offset = "0x65699E0", VA = "0x18656ABE0")]
		public void RemoveKinematic(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x656B350", Offset = "0x656A150", VA = "0x18656B350")]
		public void SetKinematic(object NBGOKNOECBH, bool DDKFBELPPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x656B170", Offset = "0x6569F70", VA = "0x18656B170")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EPFLHJDIJPA, Quaternion GGDMCPJFCEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x656B070", Offset = "0x6569E70", VA = "0x18656B070")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 HFDFKBBEJAO, Quaternion GCOLCIFOCEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x656A540", Offset = "0x6569340", VA = "0x18656A540")]
		public Vector3 GetConstrainedVelocity(Vector3 FEAOCKEGNIC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x656A430", Offset = "0x6569230", VA = "0x18656A430")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NDNOKJPALDK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6569870", Offset = "0x6568670", VA = "0x186569870")]
		public void AddForce(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6569760", Offset = "0x6568560", VA = "0x186569760")]
		public void AddForceAtPosition(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6569BA0", Offset = "0x65689A0", VA = "0x186569BA0")]
		public void AddTorque(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6569A40", Offset = "0x6568840", VA = "0x186569A40")]
		public void AddRelativeTorque(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x656B670", Offset = "0x656A470", VA = "0x18656B670")]
		public Vector3 WorldToLocalVelocity(Vector3 MBJMJHACAHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x656A870", Offset = "0x6569670", VA = "0x18656A870")]
		public Vector3 LocalToWorldVelocity(Vector3 MECEBMJGHLN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x656A370", Offset = "0x6569170", VA = "0x18656A370")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x656A310", Offset = "0x6569110", VA = "0x18656A310")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x656A2B0", Offset = "0x65690B0", VA = "0x18656A2B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x656A250", Offset = "0x6569050", VA = "0x18656A250")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x656AF70", Offset = "0x6569D70", VA = "0x18656AF70")]
		public void ResetVelocityWorldSpace(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x656AE70", Offset = "0x6569C70", VA = "0x18656AE70")]
		public void ResetVelocityLocalSpace(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x656AD30", Offset = "0x6569B30", VA = "0x18656AD30")]
		public void ResetLinearVelocityLocalSpace(Vector3 OJMLAIAEILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x656B500", Offset = "0x656A300", VA = "0x18656B500")]
		public bool SweepTest(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x656A810", Offset = "0x6569610", VA = "0x18656A810")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x656B4A0", Offset = "0x656A2A0", VA = "0x18656B4A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x656B610", Offset = "0x656A410", VA = "0x18656B610")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6569B30", Offset = "0x6568930", VA = "0x186569B30")]
		public void AddShouldHaveUnityRigidbodyToken(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x656AC50", Offset = "0x6569A50", VA = "0x18656AC50")]
		public void RemoveShouldHaveUnityRigidbodyToken(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6569ED0", Offset = "0x6568CD0", VA = "0x186569ED0")]
		public void ApplyForceVelocityChange(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6569E30", Offset = "0x6568C30", VA = "0x186569E30")]
		public void ApplyAngularVelocityChange(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6569F90", Offset = "0x6568D90", VA = "0x186569F90")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6569D60", Offset = "0x6568B60", VA = "0x186569D60")]
		public bool AllowedScaleChange(float HPMOKOMLGDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6569C90", Offset = "0x6568A90", VA = "0x186569C90")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx IMFBHLANEHI, object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x656ACC0", Offset = "0x6569AC0", VA = "0x18656ACC0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x656B810", Offset = "0x656A610", VA = "0x18656B810")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class BEGCLAEDLGD
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6548B60", Offset = "0x6547960", VA = "0x186548B60")]
	public static JNIFIKAJIFG AJLKPLFIPKM(this RigidbodyEx NPOMGMGDKBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HINAIMEEDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody EDIBDMMLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView FBKOKGALPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 AJAKDEHIKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 FBHFCMIJCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public BODECPAEPFD PNBIKGIPGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool NJHAJBBOPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool PGCPKDDCKAI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HLLKJAAFIAG(typeof(KPGKLAGMOGC), new string[] { })]
public class MALDOGDJNLD : KPGKLAGMOGC, JOMLNLBCPPN
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CNFJBICKGLP NLDBEEDMOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MGHOBDFLPBO ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HPOENFLBIFL IAPEEMLNNGE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MGHOBDFLPBO CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HPOENFLBIFL IEIFONJGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6560450", Offset = "0x655F250", VA = "0x186560450", Slot = "8")]
	public void InitReferences(IIHLCNFMGKJ AOLJGMLHFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x65604E0", Offset = "0x655F2E0", VA = "0x1865604E0", Slot = "6")]
	public MIGCCDNHDEL KFPBOCPGCMO(RigidbodyEx NPOMGMGDKBM)
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6560790", Offset = "0x655F590", VA = "0x186560790")]
	private static MIGCCDNHDEL NOFOMPAEMAE(RigidbodyEx NPOMGMGDKBM)
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6560860", Offset = "0x655F660", VA = "0x186560860", Slot = "7")]
	public JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public MALDOGDJNLD()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static BHHPLLLFBGO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int FMHJLAKHPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int GDIGBDMEABI;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x65691C0", Offset = "0x6567FC0", VA = "0x1865691C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6569200", Offset = "0x6568000", VA = "0x186569200")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x65691E0", Offset = "0x6567FE0", VA = "0x1865691E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EMKENBOOEOH, [Optional] UnityEngine.Object HOLFPPNPJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EMKENBOOEOH, [Optional] UnityEngine.Object HOLFPPNPJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6569310", Offset = "0x6568110", VA = "0x186569310")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HBMADAPDKKG
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6559500", Offset = "0x6558300", VA = "0x186559500")]
	public static void FAOJGCIFFBB(this Rigidbody EHEFPDCPNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x65593D0", Offset = "0x65581D0", VA = "0x1865593D0")]
	public static void FAOJGCIFFBB(this Rigidbody EHEFPDCPNNM, Vector3 AOBGAFKBCCC, Quaternion DGLAGKBNNOF, Vector3 HFMBNFJPECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xC51B80", Offset = "0xC50980", VA = "0x180C51B80")]
	public static void OCLLFDGIKJM(Vector3 FEAOCKEGNIC, Vector3 NPJIMHPPOGG, [Out] Vector3 LFFBOOAIDDC, [Out] Vector3 OAFODOBEOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JLKGIFIMCEB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LKOENNLGKEI : MABPGHFPKBK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B9990", Offset = "0x7B8790", VA = "0x1807B9990", Slot = "4")]
		public Vector3 ILINIKJOGPI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B9990", Offset = "0x7B8790", VA = "0x1807B9990", Slot = "5")]
		public Vector3 DADKEEPOLFE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LKOENNLGKEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static MABPGHFPKBK MNGAJAFMGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x655E750", Offset = "0x655D550", VA = "0x18655E750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NPDBKMIPJOC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode KCBKNHGILJP
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
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKKFOMFAGJD(bool GLJMFCDGBNN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFELFNOKNLK(bool GLJMFCDGBNN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IHHOELGMLAK : IDisposable, FMFFPEPNOGI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PALKBNKHAGA();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface HPOENFLBIFL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHGIDJKNFAL NGGFAGEODLD(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DHMGNKBAAIH HONOCMLKCDN(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEHGAGDGEEE PPKGHGBAIBP(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PNFIGMNBOMO DOPJDLCHCJD(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGNODMAJMMG IAPPHAAABGE(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHHOELGMLAK KNLFGIOFOLP(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APKMGJGILDJ BECJEBOKJNJ(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EHKMCJIAECG HJJDBKFKEPJ(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NPDBKMIPJOC MIJIMEHMLON(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GGDAMBMLLEL INNJHDKJDAI(JNIFIKAJIFG HBHLLIKFPMD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DJOGEADPCGL EOGLBPAPFMD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GPDAHBNNHMD CGDDJPODGFD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CGLADKHONPG PIFPPOGIOPO(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BHFAAMLNOOH MAMAMLLMFJH(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OEOFLJMCEFM FMDAGBDDHCJ(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA, KPGKLAGMOGC IEHBMNBOFCL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EHKMCJIAECG
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GGDAMBMLLEL
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GNKJKEDOMDM
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
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NHGIDJKNFAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MIKBECLFJBF NGEJMPGOPMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MIKBECLFJBF CPAAPFDLPHA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event ICEFHJCPMAE MNFACJLLLBG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action OCBLGNGLGHN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action MOBCICGAPGL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JNIFIKAJIFG> FJDOGJLHLHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<JNIFIKAJIFG> GEHJDPEKAJC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action BGCHCONHCKN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JNIFIKAJIFG> PJJFLOLOHGN;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IEJEABLOHEA(JNIFIKAJIFG PKMANOIKNOC, bool JEJBEBJPFDD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JEHGAGDGEEE
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGGGFPLIMLB(JNIFIKAJIFG AJKCELPHOFC, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKLPCNMLODL(object NBGOKNOECBH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BHFAAMLNOOH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MIKBECLFJBF KKKGFKCKBJJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FMODEPOJMPH();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FJGFMBGMDBF();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICOLGPNACMI();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DKJFEKKPLBL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CGLADKHONPG
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MALJJLCCGAE(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIMFMPJJDIE(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEAOOBJOGCE(JNIFIKAJIFG NPOMGMGDKBM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPIJINNJCDF(JNIFIKAJIFG NPOMGMGDKBM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDCOBMKCEIB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface APKMGJGILDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MIKBECLFJBF CIBDNBIBNIE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGNLJNEHDIB();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPNMGIKCEGB(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EANHACBLKGI(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable IJGPGHCGMLL();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LCBGGHBAEAG(Rigidbody EMNDMNOMIMH);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GPDAHBNNHMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MIKBECLFJBF NGAOOEACHLC;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGGJIKHOGOI(JNIFIKAJIFG AJKCELPHOFC);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFIKMONJEFJ(JNIFIKAJIFG AJKCELPHOFC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OEOFLJMCEFM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LONMNADJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints KJDGFBCFFCM
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
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PNFIGMNBOMO
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float FBLPIJCIMHG
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
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MFOOOABHJKH
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx CMAPMPDDHAP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OGNODMAJMMG
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event MIKBECLFJBF DPIPNOEPNFP;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DCLANEKGGIJ();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGNIGEKKLOO();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHLPCGAAGAL();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJFJCGEHNFD();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIHEPGKOBMD();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGCBDINGOMK(bool KFHMHOFNHOL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DJOGEADPCGL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MDOIIMOBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CDPAFGMHMDL(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEKAPPHPEHP(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKDLEPKDEAD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPOIENHIAAN();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DHMGNKBAAIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AGKPFNNAENP(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PJGEDJCLCKC();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KNJOKJCMBAB();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AMIJBFNEEGD();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KBEKNHHPGGD();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BIHBJCCIEAK(Vector3 FEAOCKEGNIC);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GKGKPIEJHCF(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LKFKPMIHMME(Vector3 DKBFOCHMODB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface MGHOBDFLPBO
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool ONNLNLMBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOOLCNALBJL(string OLGJDMIGDKI);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHAPCCEDIPK(RigidbodyEx NPOMGMGDKBM, Action ENHEBPDFNME);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AFLEKNEEHDF LONMJGKAJDK(int DAJCGFDJPCJ);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCBANBDDNCP(Vector3 IJDLLHOBIAB, float AAHOBJDEOGE, Color OLDELFAHHJB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface KPGKLAGMOGC
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MGHOBDFLPBO CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HPOENFLBIFL IEIFONJGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MIGCCDNHDEL KFPBOCPGCMO(RigidbodyEx NPOMGMGDKBM);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FBNLPKHODPC
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLGOIDFEPBD(Vector3 OBPLOOMBOBK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBCGABLLHJC(Vector3 NDNOKJPALDK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPCIDGJFOMP(Vector3 OBPLOOMBOBK);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHBIDGCNALJ(Vector3 NDNOKJPALDK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MABPGHFPKBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ILINIKJOGPI();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DADKEEPOLFE();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JNIFIKAJIFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx FFLEDHGNBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool COBNBGFHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool GEJKBIJMFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float FBLPIJCIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool GNKJKEDOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform GDAKNEOILHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 CHHOCLKGNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float AEBHJKHKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float NAACHPNFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion DCJMENCHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 FGMHAIMGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion LMICPFEIIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints KJDGFBCFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode KCBKNHGILJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool IHJAGFDOKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event MIKBECLFJBF NGEJMPGOPMJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event MIKBECLFJBF CPAAPFDLPHA;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ICEFHJCPMAE MNFACJLLLBG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event MIKBECLFJBF NGAOOEACHLC;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event MIKBECLFJBF OKNKKIHCEMO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event MIKBECLFJBF DPIPNOEPNFP;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event MIKBECLFJBF CIBDNBIBNIE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event MIKBECLFJBF COGENIEGILN;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void JMHOODKNNBF();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void EIEMBELJJOB();

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void PHLPCGAAGAL();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void IEJEABLOHEA(JNIFIKAJIFG NKKIECLCEML, bool JEJBEBJPFDD = false);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void GBKIGGDPOAB(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void BFLIOOMGNAM(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void KBEKNHHPGGD();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void KNJOKJCMBAB();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void PJGEDJCLCKC();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void LKFKPMIHMME(Vector3 DKBFOCHMODB);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 BIHBJCCIEAK(Vector3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JMHBKLNLJGK(Vector3 NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void AMIJBFNEEGD();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KPHAFHBKKPC(JNIFIKAJIFG IMFBHLANEHI, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void OBNPKECIFCB(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FJGFMBGMDBF();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FMODEPOJMPH();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void ICOLGPNACMI();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DCLANEKGGIJ();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void KIHEPGKOBMD();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable IJGPGHCGMLL();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void JPNMGIKCEGB(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void EANHACBLKGI(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JNILHPKPLOE(Vector3 EPFLHJDIJPA, Quaternion GGDMCPJFCEL);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void ENKOLCJJHON(Vector3 HFDFKBBEJAO, Quaternion GCOLCIFOCEP);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool OACEGBPIMAF(float HPMOKOMLGDA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AKCCMFJJEKK(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void KHACCLGPDBK(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void CDPAFGMHMDL(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MEKAPPHPEHP(object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void DKJFEKKPLBL();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BHJLHMHCLMK : JNIFIKAJIFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly KPGKLAGMOGC IEHBMNBOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal NHGIDJKNFAL BIBHPACHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal CGLADKHONPG HAMCMNJFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal GPDAHBNNHMD GHAPNLANMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal DHMGNKBAAIH FEAOCKEGNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal JEHGAGDGEEE PMLJDNEBBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal BHFAAMLNOOH AEJFCOAFAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal PNFIGMNBOMO BNLOAMNCEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal GGDAMBMLLEL GEHJLIHGNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal OGNODMAJMMG EGKNIJIDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal IHHOELGMLAK CDHDBNOBHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal APKMGJGILDJ CFNACGCCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EHKMCJIAECG KCOHBBNEOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OEOFLJMCEFM DAOENGPGJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal DJOGEADPCGL EDIBDMMLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal NPDBKMIPJOC FDIOJIKODCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable GCMMPHOPMDH;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx FFLEDHGNBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F00", Offset = "0x7B4D00", VA = "0x1807B5F00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E00", Offset = "0x7B4C00", VA = "0x1807B5E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8716B0", Offset = "0x8704B0", VA = "0x1808716B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x871C10", Offset = "0x870A10", VA = "0x180871C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x654EEC0", Offset = "0x654DCC0", VA = "0x18654EEC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x654DF60", Offset = "0x654CD60", VA = "0x18654DF60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x654B490", Offset = "0x654A290", VA = "0x18654B490", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x654BF00", Offset = "0x654AD00", VA = "0x18654BF00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6549CF0", Offset = "0x6548AF0", VA = "0x186549CF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x654ABD0", Offset = "0x65499D0", VA = "0x18654ABD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x654A290", Offset = "0x6549090", VA = "0x18654A290", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6549B80", Offset = "0x6548980", VA = "0x186549B80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x654E350", Offset = "0x654D150", VA = "0x18654E350", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x654EBC0", Offset = "0x654D9C0", VA = "0x18654EBC0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x654BB80", Offset = "0x654A980", VA = "0x18654BB80", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x654A890", Offset = "0x6549690", VA = "0x18654A890", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x654E190", Offset = "0x654CF90", VA = "0x18654E190", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x654C490", Offset = "0x654B290", VA = "0x18654C490", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x654D8C0", Offset = "0x654C6C0", VA = "0x18654D8C0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x654B910", Offset = "0x654A710", VA = "0x18654B910", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x654A7B0", Offset = "0x65495B0", VA = "0x18654A7B0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6549AA0", Offset = "0x65488A0", VA = "0x186549AA0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x654AAF0", Offset = "0x65498F0", VA = "0x18654AAF0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x65498C0", Offset = "0x65486C0", VA = "0x1865498C0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x654BA40", Offset = "0x654A840", VA = "0x18654BA40", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x654C1D0", Offset = "0x654AFD0", VA = "0x18654C1D0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x654B830", Offset = "0x654A630", VA = "0x18654B830", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JHBAMFHNOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x654C180", Offset = "0x654AF80", VA = "0x18654C180", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool COBNBGFHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x654DBE0", Offset = "0x654C9E0", VA = "0x18654DBE0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GEJKBIJMFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x654AC20", Offset = "0x6549A20", VA = "0x18654AC20", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x654CC90", Offset = "0x654BA90", VA = "0x18654CC90", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6549C20", Offset = "0x6548A20", VA = "0x186549C20", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x654D610", Offset = "0x654C410", VA = "0x18654D610", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x654E7C0", Offset = "0x654D5C0", VA = "0x18654E7C0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6549E70", Offset = "0x6548C70", VA = "0x186549E70", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x654DD70", Offset = "0x654CB70", VA = "0x18654DD70", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x654C4E0", Offset = "0x654B2E0", VA = "0x18654C4E0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x654CAD0", Offset = "0x654B8D0", VA = "0x18654CAD0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x654CC30", Offset = "0x654BA30", VA = "0x18654CC30", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x654D190", Offset = "0x654BF90", VA = "0x18654D190", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x654DCA0", Offset = "0x654CAA0", VA = "0x18654DCA0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x654C900", Offset = "0x654B700", VA = "0x18654C900", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x654A610", Offset = "0x6549410", VA = "0x18654A610", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float FBLPIJCIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x654CCE0", Offset = "0x654BAE0", VA = "0x18654CCE0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x654D330", Offset = "0x654C130", VA = "0x18654D330", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool GNKJKEDOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x654C130", Offset = "0x654AF30", VA = "0x18654C130", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x654EFB0", Offset = "0x654DDB0", VA = "0x18654EFB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x654E2B0", Offset = "0x654D0B0", VA = "0x18654E2B0", Slot = "48")]
		get
		{
			return default(OIIAKGKODFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x654C530", Offset = "0x654B330", VA = "0x18654C530", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x654C590", Offset = "0x654B390", VA = "0x18654C590", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform GDAKNEOILHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x654A280", Offset = "0x6549080", VA = "0x18654A280", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 CHHOCLKGNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6549350", Offset = "0x6548150", VA = "0x186549350", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x654AA30", Offset = "0x6549830", VA = "0x18654AA30", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float AEBHJKHKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x654F150", Offset = "0x654DF50", VA = "0x18654F150", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x654EB50", Offset = "0x654D950", VA = "0x18654EB50", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float NAACHPNFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x65498A0", Offset = "0x65486A0", VA = "0x1865498A0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x654E3A0", Offset = "0x654D1A0", VA = "0x18654E3A0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion DCJMENCHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x654D740", Offset = "0x654C540", VA = "0x18654D740", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x654DFB0", Offset = "0x654CDB0", VA = "0x18654DFB0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 FGMHAIMGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x654D9D0", Offset = "0x654C7D0", VA = "0x18654D9D0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6549BD0", Offset = "0x65489D0", VA = "0x186549BD0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion LMICPFEIIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x654C2B0", Offset = "0x654B0B0", VA = "0x18654C2B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x654A340", Offset = "0x6549140", VA = "0x18654A340", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints KJDGFBCFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x654D0E0", Offset = "0x654BEE0", VA = "0x18654D0E0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x654B430", Offset = "0x654A230", VA = "0x18654B430", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x654B9F0", Offset = "0x654A7F0", VA = "0x18654B9F0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x65496E0", Offset = "0x65484E0", VA = "0x1865496E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode KCBKNHGILJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x654E300", Offset = "0x654D100", VA = "0x18654E300", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x654EF50", Offset = "0x654DD50", VA = "0x18654EF50", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool IBBFCHGPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x654AD00", Offset = "0x6549B00", VA = "0x18654AD00", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IHJAGFDOKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x654C950", Offset = "0x654B750", VA = "0x18654C950", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GGJIBADEMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x654E950", Offset = "0x654D750", VA = "0x18654E950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool BMEBHMLPOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x654D390", Offset = "0x654C190", VA = "0x18654D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MIKBECLFJBF NGEJMPGOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6549620", Offset = "0x6548420", VA = "0x186549620", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x654BB20", Offset = "0x654A920", VA = "0x18654BB20", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MIKBECLFJBF CPAAPFDLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x65492F0", Offset = "0x65480F0", VA = "0x1865492F0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x654E550", Offset = "0x654D350", VA = "0x18654E550", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ICEFHJCPMAE MNFACJLLLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x654E1F0", Offset = "0x654CFF0", VA = "0x18654E1F0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x654D7F0", Offset = "0x654C5F0", VA = "0x18654D7F0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event MIKBECLFJBF NGAOOEACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x654A480", Offset = "0x6549280", VA = "0x18654A480", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x654A4E0", Offset = "0x65492E0", VA = "0x18654A4E0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event MIKBECLFJBF OKNKKIHCEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x654D270", Offset = "0x654C070", VA = "0x18654D270", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x654D130", Offset = "0x654BF30", VA = "0x18654D130", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event MIKBECLFJBF DPIPNOEPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x654D2D0", Offset = "0x654C0D0", VA = "0x18654D2D0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x654E250", Offset = "0x654D050", VA = "0x18654E250", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x654A670", Offset = "0x6549470", VA = "0x18654A670", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x654A730", Offset = "0x6549530", VA = "0x18654A730", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event MIKBECLFJBF CIBDNBIBNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x654DC40", Offset = "0x654CA40", VA = "0x18654DC40", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6549680", Offset = "0x6548480", VA = "0x186549680", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event MIKBECLFJBF COGENIEGILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x654A110", Offset = "0x6548F10", VA = "0x18654A110", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x654E4A0", Offset = "0x654D2A0", VA = "0x18654E4A0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x654F1B0", Offset = "0x654DFB0", VA = "0x18654F1B0")]
	public BHJLHMHCLMK(GameObject IPHCMOEHILB, RigidbodyEx HHGAHJIEKDO, KPGKLAGMOGC IEHBMNBOFCL, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x654B4E0", Offset = "0x654A2E0", VA = "0x18654B4E0", Slot = "135")]
	protected virtual void GALJJDFNOBB(KPGKLAGMOGC IEHBMNBOFCL, HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x654A540", Offset = "0x6549340", VA = "0x18654A540", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x654ED80", Offset = "0x654DB80", VA = "0x18654ED80", Slot = "71")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x654CE30", Offset = "0x654BC30", VA = "0x18654CE30", Slot = "72")]
	public void JMHOODKNNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x654A790", Offset = "0x6549590", VA = "0x18654A790", Slot = "73")]
	public void EIEMBELJJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x654DE50", Offset = "0x654CC50", VA = "0x18654DE50")]
	private void MBMAKNJPLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x654C340", Offset = "0x654B140", VA = "0x18654C340", Slot = "81")]
	public void IEJEABLOHEA(JNIFIKAJIFG NKKIECLCEML, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x654B7D0", Offset = "0x654A5D0", VA = "0x18654B7D0", Slot = "84")]
	public void GBKIGGDPOAB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6549840", Offset = "0x6548640", VA = "0x186549840", Slot = "85")]
	public void BFLIOOMGNAM(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x654A380", Offset = "0x6549180", VA = "0x18654A380", Slot = "86")]
	public Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x654E5B0", Offset = "0x654D3B0", VA = "0x18654E5B0", Slot = "87")]
	public Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x654CE30", Offset = "0x654BC30", VA = "0x18654CE30", Slot = "88")]
	public void KBEKNHHPGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x654D6F0", Offset = "0x654C4F0", VA = "0x18654D6F0", Slot = "89")]
	public void KNJOKJCMBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x654F060", Offset = "0x654DE60", VA = "0x18654F060", Slot = "90")]
	public void PJGEDJCLCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x654BF60", Offset = "0x654AD60", VA = "0x18654BF60", Slot = "91")]
	public void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x654E0A0", Offset = "0x654CEA0", VA = "0x18654E0A0", Slot = "92")]
	public void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x654DA20", Offset = "0x654C820", VA = "0x18654DA20", Slot = "93")]
	public void LKFKPMIHMME(Vector3 DKBFOCHMODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x654D3C0", Offset = "0x654C1C0", VA = "0x18654D3C0", Slot = "94")]
	public void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x654ECE0", Offset = "0x654DAE0", VA = "0x18654ECE0", Slot = "95")]
	public void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x654E8A0", Offset = "0x654D6A0", VA = "0x18654E8A0", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x65499A0", Offset = "0x65487A0", VA = "0x1865499A0", Slot = "97")]
	public Vector3 BIHBJCCIEAK(Vector3 NKKIECLCEML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x654CD30", Offset = "0x654BB30", VA = "0x18654CD30", Slot = "98")]
	public Vector3 JMHBKLNLJGK(Vector3 NKKIECLCEML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x65495D0", Offset = "0x65483D0", VA = "0x1865495D0", Slot = "99")]
	public void AMIJBFNEEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x654D850", Offset = "0x654C650", VA = "0x18654D850", Slot = "100")]
	public void KPHAFHBKKPC(JNIFIKAJIFG IMFBHLANEHI, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x654EAF0", Offset = "0x654D8F0", VA = "0x18654EAF0", Slot = "101")]
	public void OBNPKECIFCB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x654DB00", Offset = "0x654C900", VA = "0x18654DB00", Slot = "41")]
	public void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x654AE40", Offset = "0x6549C40", VA = "0x18654AE40", Slot = "104")]
	public void FJGFMBGMDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x654B3E0", Offset = "0x654A1E0", VA = "0x18654B3E0", Slot = "105")]
	public void FMODEPOJMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x654C2F0", Offset = "0x654B0F0", VA = "0x18654C2F0", Slot = "106")]
	public void ICOLGPNACMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x654A1C0", Offset = "0x6548FC0", VA = "0x18654A1C0", Slot = "109")]
	public bool DCLANEKGGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x654F010", Offset = "0x654DE10", VA = "0x18654F010", Slot = "74")]
	public void PHLPCGAAGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x654D4E0", Offset = "0x654C2E0", VA = "0x18654D4E0", Slot = "110")]
	public void KIHEPGKOBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x654C7D0", Offset = "0x654B5D0", VA = "0x18654C7D0", Slot = "115")]
	public IDisposable IJGPGHCGMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x654D080", Offset = "0x654BE80", VA = "0x18654D080", Slot = "116")]
	public void JPNMGIKCEGB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x654A6D0", Offset = "0x65494D0", VA = "0x18654A6D0", Slot = "117")]
	public void EANHACBLKGI(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x654A210", Offset = "0x6549010", VA = "0x18654A210", Slot = "118")]
	public void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x654CE80", Offset = "0x654BC80", VA = "0x18654CE80", Slot = "121")]
	public void JNILHPKPLOE(Vector3 EPFLHJDIJPA, Quaternion GGDMCPJFCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x654A8E0", Offset = "0x65496E0", VA = "0x18654A8E0", Slot = "122")]
	public void ENKOLCJJHON(Vector3 HFDFKBBEJAO, Quaternion GCOLCIFOCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x654EA90", Offset = "0x654D890", VA = "0x18654EA90", Slot = "123")]
	public bool OACEGBPIMAF(float HPMOKOMLGDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6549570", Offset = "0x6548370", VA = "0x186549570", Slot = "124")]
	public void AKCCMFJJEKK(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x654D480", Offset = "0x654C280", VA = "0x18654D480", Slot = "125")]
	public void KHACCLGPDBK(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6549D40", Offset = "0x6548B40", VA = "0x186549D40", Slot = "126")]
	public void CDPAFGMHMDL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x654DF00", Offset = "0x654CD00", VA = "0x18654DF00", Slot = "127")]
	public void MEKAPPHPEHP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x654C3B0", Offset = "0x654B1B0", VA = "0x18654C3B0", Slot = "128")]
	public void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x654E6B0", Offset = "0x654D4B0", VA = "0x18654E6B0", Slot = "129")]
	public void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x654C050", Offset = "0x654AE50", VA = "0x18654C050", Slot = "130")]
	public void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x654D530", Offset = "0x654C330", VA = "0x18654D530", Slot = "131")]
	public void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x654F0B0", Offset = "0x654DEB0", VA = "0x18654F0B0", Slot = "132")]
	public bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x654A2F0", Offset = "0x65490F0", VA = "0x18654A2F0", Slot = "133")]
	public void DKJFEKKPLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x654F170", Offset = "0x654DF70", VA = "0x18654F170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x654C820", Offset = "0x654B620", VA = "0x18654C820")]
	private void IPCEONBMGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x654CB20", Offset = "0x654B920", VA = "0x18654CB20")]
	private void JELBFBMDPJA(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x654C5E0", Offset = "0x654B3E0", VA = "0x18654C5E0")]
	private void IJGHDKEHKGM(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x654D920", Offset = "0x654C720", VA = "0x18654D920")]
	private void LHCPLNFFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6549740", Offset = "0x6548540", VA = "0x186549740")]
	private void BEBACGNDCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x654B200", Offset = "0x654A000", VA = "0x18654B200")]
	private void FMAGAHAFOPL(JNIFIKAJIFG BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x654EC10", Offset = "0x654DA10", VA = "0x18654EC10")]
	private void OGGJIKHOGOI(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6549DA0", Offset = "0x6548BA0", VA = "0x186549DA0")]
	private void CFIKMONJEFJ(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6549400", Offset = "0x6548200", VA = "0x186549400")]
	private void AHGLKDANLCN(RigidbodyEx AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6549F50", Offset = "0x6548D50", VA = "0x186549F50", Slot = "140")]
	protected virtual void DBALEKPPCMM(RigidbodyEx NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x654BBE0", Offset = "0x654A9E0", VA = "0x18654BBE0")]
	protected void HFMBFPDFCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x654AE90", Offset = "0x6549C90", VA = "0x18654AE90")]
	protected void FLOLBOLLBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x654E9F0", Offset = "0x654D7F0", VA = "0x18654E9F0", Slot = "141")]
	protected virtual IDisposable OACCLACJMAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DOHLBCCFCHP
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6554E70", Offset = "0x6553C70", VA = "0x186554E70")]
	public static JNIFIKAJIFG MJHNKABBNDP(this JNIFIKAJIFG NPOMGMGDKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6554F20", Offset = "0x6553D20", VA = "0x186554F20")]
	public static bool MMIFBLJLKFJ(this JNIFIKAJIFG NPOMGMGDKBM, JNIFIKAJIFG AEJDINJFCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6554DF0", Offset = "0x6553BF0", VA = "0x186554DF0")]
	public static bool KFCAEJJPEGB(this JNIFIKAJIFG NPOMGMGDKBM, JNIFIKAJIFG DMOPJMMPEPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6554DA0", Offset = "0x6553BA0", VA = "0x186554DA0")]
	public static RigidbodyEx FFLEDHGNBGH(this JNIFIKAJIFG AJLKPLFIPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6554D20", Offset = "0x6553B20", VA = "0x186554D20")]
	public static BHJLHMHCLMK DGOAOKHBCPO(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class MDGFFGLLPML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x65609F0", Offset = "0x655F7F0", VA = "0x1865609F0")]
	public MDGFFGLLPML(BHJLHMHCLMK KEGMCPHLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6560990", Offset = "0x655F790", VA = "0x186560990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class DODLNKOGDHO : GIFAIPINCAG, NPDBKMIPJOC
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode MIJDAHOPAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6554840", Offset = "0x6553640", VA = "0x186554840")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x65546F0", Offset = "0x65534F0", VA = "0x1865546F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode KCBKNHGILJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x65548A0", Offset = "0x65536A0", VA = "0x1865548A0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6554B00", Offset = "0x6553900", VA = "0x186554B00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public DODLNKOGDHO(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x65549B0", Offset = "0x65537B0", VA = "0x1865549B0", Slot = "6")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6554760", Offset = "0x6553560", VA = "0x186554760", Slot = "9")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6554560", Offset = "0x6553360", VA = "0x186554560", Slot = "7")]
	public void AKKFOMFAGJD(bool GLJMFCDGBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6554570", Offset = "0x6553370", VA = "0x186554570", Slot = "8")]
	public void CFELFNOKNLK(bool GLJMFCDGBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6554BC0", Offset = "0x65539C0", VA = "0x186554BC0", Slot = "10")]
	public bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6554580", Offset = "0x6553380", VA = "0x186554580")]
	private void ILLAJOIHIOE(bool GLJMFCDGBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PCJFIOPBMPP : GIFAIPINCAG, IHHOELGMLAK, IDisposable, FMFFPEPNOGI
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public OIIAKGKODFP COIHIBEAHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6565450", Offset = "0x6564250", VA = "0x186565450")]
		get
		{
			return default(OIIAKGKODFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6565530", Offset = "0x6564330", VA = "0x186565530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6565620", Offset = "0x6564420", VA = "0x186565620", Slot = "6")]
		get
		{
			return default(OIIAKGKODFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6565530", Offset = "0x6564330", VA = "0x186565530", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform DDBBPCOFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x65652F0", Offset = "0x65640F0", VA = "0x1865652F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x65653A0", Offset = "0x65641A0", VA = "0x1865653A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public PCJFIOPBMPP(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6565820", Offset = "0x6564620", VA = "0x186565820", Slot = "11")]
	public void OnChangedDistanceBand(AMOHOHNPBGH HPFNNCFAOFH, AMOHOHNPBGH FLONDMFIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "12")]
	public void OnChangedVisibility(bool MAAMCGOAHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HFGKNNDDMIE : GIFAIPINCAG, EHKMCJIAECG
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6552A90", Offset = "0x6551890", VA = "0x186552A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6551CF0", Offset = "0x6550AF0", VA = "0x186551CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6559A50", Offset = "0x6558850", VA = "0x186559A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public HFGKNNDDMIE(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6559C10", Offset = "0x6558A10", VA = "0x186559C10", Slot = "4")]
	public void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6559690", Offset = "0x6558490", VA = "0x186559690")]
	private void EBBLHMLIHPJ(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x655A230", Offset = "0x6559030", VA = "0x18655A230", Slot = "5")]
	public void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6559AB0", Offset = "0x65588B0", VA = "0x186559AB0", Slot = "6")]
	public void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6559D70", Offset = "0x6558B70", VA = "0x186559D70")]
	private void JEJMCKPAPKJ(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6559FD0", Offset = "0x6558DD0", VA = "0x186559FD0", Slot = "7")]
	public void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6559970", Offset = "0x6558770", VA = "0x186559970")]
	private void FDPKAFHEJCK(string EMKENBOOEOH, UnityEngine.Object HOLFPPNPJAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MFANFFHNGBM : GIFAIPINCAG, GGDAMBMLLEL
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool GNKJKEDOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6560B30", Offset = "0x655F930", VA = "0x186560B30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6560C20", Offset = "0x655FA20", VA = "0x186560C20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public MFANFFHNGBM(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6560B90", Offset = "0x655F990", VA = "0x186560B90", Slot = "6")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6545CC0", Offset = "0x6544AC0", VA = "0x186545CC0", Slot = "7")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class APOOPIGBPCM : GIFAIPINCAG, NHGIDJKNFAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly KNPFMNBIIDA BJAOLIGCJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly NGFPPENEEFL POODEGLIHNC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6548630", Offset = "0x6547430", VA = "0x186548630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MIGCCDNHDEL BGEJPFHDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x65482C0", Offset = "0x65470C0", VA = "0x1865482C0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x65474B0", Offset = "0x65462B0", VA = "0x1865474B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6547A60", Offset = "0x6546860", VA = "0x186547A60", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6547C60", Offset = "0x6546A60", VA = "0x186547C60", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public MIGCCDNHDEL EPEOCABJEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x65483D0", Offset = "0x65471D0", VA = "0x1865483D0")]
		get
		{
			return default(MIGCCDNHDEL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6547980", Offset = "0x6546780", VA = "0x186547980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x65479F0", Offset = "0x65467F0", VA = "0x1865479F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MIKBECLFJBF NGEJMPGOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6546B40", Offset = "0x6545940", VA = "0x186546B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6547BC0", Offset = "0x65469C0", VA = "0x186547BC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MIKBECLFJBF CPAAPFDLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6546AA0", Offset = "0x65458A0", VA = "0x186546AA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6548220", Offset = "0x6547020", VA = "0x186548220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ICEFHJCPMAE MNFACJLLLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6548180", Offset = "0x6546F80", VA = "0x186548180", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6547F80", Offset = "0x6546D80", VA = "0x186547F80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action OCBLGNGLGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6547DA0", Offset = "0x6546BA0", VA = "0x186547DA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6547E40", Offset = "0x6546C40", VA = "0x186547E40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action MOBCICGAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6547EE0", Offset = "0x6546CE0", VA = "0x186547EE0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6547520", Offset = "0x6546320", VA = "0x186547520", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<JNIFIKAJIFG> FJDOGJLHLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x65480D0", Offset = "0x6546ED0", VA = "0x1865480D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x65478D0", Offset = "0x65466D0", VA = "0x1865478D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<JNIFIKAJIFG> GEHJDPEKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6548320", Offset = "0x6547120", VA = "0x186548320", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6547060", Offset = "0x6545E60", VA = "0x186547060", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action BGCHCONHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6548710", Offset = "0x6547510", VA = "0x186548710", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6547110", Offset = "0x6545F10", VA = "0x186547110", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<JNIFIKAJIFG> PJJFLOLOHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6548660", Offset = "0x6547460", VA = "0x186548660", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6547400", Offset = "0x6546200", VA = "0x186547400", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6548980", Offset = "0x6547780", VA = "0x186548980")]
	public APOOPIGBPCM(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x65475C0", Offset = "0x65463C0", VA = "0x1865475C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6547D20", Offset = "0x6546B20", VA = "0x186547D20", Slot = "26")]
	public void IEJEABLOHEA(JNIFIKAJIFG PKMANOIKNOC, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6547CD0", Offset = "0x6546AD0", VA = "0x186547CD0")]
	private void IEJEABLOHEA(DNGCHFDPOCD PKMANOIKNOC, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6546BE0", Offset = "0x65459E0", VA = "0x186546BE0")]
	private void APKBHDNOAOF(DNGCHFDPOCD PKMANOIKNOC, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x65471B0", Offset = "0x6545FB0", VA = "0x1865471B0")]
	private void BNGFIEBANEK(DNGCHFDPOCD BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6548430", Offset = "0x6547230", VA = "0x186548430")]
	private void OLAIIEJIEFF(DNGCHFDPOCD BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x65476F0", Offset = "0x65464F0", VA = "0x1865476F0")]
	private void EFGCBNFCNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6548020", Offset = "0x6546E20", VA = "0x186548020")]
	private void LICAJNAPINP(DNGCHFDPOCD BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6547AD0", Offset = "0x65468D0", VA = "0x186547AD0")]
	private void GLJGLMFNCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6548850", Offset = "0x6547650", VA = "0x186548850")]
	private void POLLOHFPCNE(DNGCHFDPOCD NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x65487B0", Offset = "0x65475B0", VA = "0x1865487B0")]
	private void PJHLAHADDHF(DNGCHFDPOCD NPOMGMGDKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EPAIEFIBKLB
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6555650", Offset = "0x6554450", VA = "0x186555650")]
	public static APOOPIGBPCM GNCIEAAOHHD(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class CJLAKNDPJJB : GIFAIPINCAG, JEHGAGDGEEE
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6550BB0", Offset = "0x654F9B0", VA = "0x186550BB0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6550EB0", Offset = "0x654FCB0", VA = "0x186550EB0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6550AC0", Offset = "0x654F8C0", VA = "0x186550AC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private JNIFIKAJIFG JOIGBJDFBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x65510E0", Offset = "0x654FEE0", VA = "0x1865510E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public CJLAKNDPJJB(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6550C50", Offset = "0x654FA50", VA = "0x186550C50", Slot = "6")]
	public void IGGGFPLIMLB(JNIFIKAJIFG AJKCELPHOFC, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6550DA0", Offset = "0x654FBA0", VA = "0x186550DA0")]
	private void IGGGFPLIMLB(DNGCHFDPOCD AJKCELPHOFC, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6550BE0", Offset = "0x654F9E0", VA = "0x186550BE0", Slot = "7")]
	public void DKLPCNMLODL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6551240", Offset = "0x6550040", VA = "0x186551240")]
	private Vector3 ONOPBHGCOKI()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KOMCOFLBBLN
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x655EA60", Offset = "0x655D860", VA = "0x18655EA60")]
	public static CJLAKNDPJJB EGOFFHPPHDH(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PHNIKFNMEGP : GIFAIPINCAG, BHFAAMLNOOH
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6568C40", Offset = "0x6567A40", VA = "0x186568C40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6565D50", Offset = "0x6564B50", VA = "0x186565D50", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 PFJPMGIHBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6566A70", Offset = "0x6565870", VA = "0x186566A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 BDCKJEEFHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6566F00", Offset = "0x6565D00", VA = "0x186566F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x65675B0", Offset = "0x65663B0", VA = "0x1865675B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6566D80", Offset = "0x6565B80", VA = "0x186566D80", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float FHEBHICGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6565CD0", Offset = "0x6564AD0", VA = "0x186565CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x6566DE0", Offset = "0x6565BE0", VA = "0x186566DE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x6566E40", Offset = "0x6565C40", VA = "0x186566E40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6567030", Offset = "0x6565E30", VA = "0x186567030", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6567580", Offset = "0x6566380", VA = "0x186567580", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event MIKBECLFJBF KKKGFKCKBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6565840", Offset = "0x6564640", VA = "0x186565840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6567060", Offset = "0x6565E60", VA = "0x186567060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6568ED0", Offset = "0x6567CD0", VA = "0x186568ED0")]
	public PHNIKFNMEGP(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6567100", Offset = "0x6565F00", VA = "0x186567100")]
	public float3 KDKDCJHIPHL()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x65672F0", Offset = "0x65660F0", VA = "0x1865672F0", Slot = "14")]
	public void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65664D0", Offset = "0x65652D0", VA = "0x1865664D0", Slot = "16")]
	public void FJGFMBGMDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65666C0", Offset = "0x65654C0", VA = "0x1865666C0", Slot = "15")]
	public void FMODEPOJMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6567220", Offset = "0x6566020", VA = "0x186567220", Slot = "18")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65658E0", Offset = "0x65646E0", VA = "0x1865658E0", Slot = "19")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6566A10", Offset = "0x6565810", VA = "0x186566A10", Slot = "17")]
	public void ICOLGPNACMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6565ED0", Offset = "0x6564CD0", VA = "0x186565ED0", Slot = "20")]
	public void DKJFEKKPLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6555120", Offset = "0x6553F20", VA = "0x186555120")]
	public void IOHMPJFHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6565D50", Offset = "0x6564B50", VA = "0x186565D50")]
	private void IPPIMLLGJJO(Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6568CF0", Offset = "0x6567AF0", VA = "0x186568CF0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 OFFCKMGPHOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6566E40", Offset = "0x6565C40", VA = "0x186566E40")]
	private void PNGEOPILNMJ(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6566B20", Offset = "0x6565920", VA = "0x186566B20")]
	private Vector3 IFHMGLOFNPJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x65677A0", Offset = "0x65665A0", VA = "0x1865677A0")]
	private Quaternion MALLHLCEMAC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x65679E0", Offset = "0x65667E0", VA = "0x1865679E0")]
	internal (float, Vector3) NFIMNMGPDKG(Rigidbody ELNCLJFODKM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class IMPICMNIPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x655DB60", Offset = "0x655C960", VA = "0x18655DB60")]
	public static PHNIKFNMEGP JHCCADPMKDA(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LENJOHKGLGC : GIFAIPINCAG, CGLADKHONPG
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool GJOKPCPMHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x655FA70", Offset = "0x655E870", VA = "0x18655FA70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PMOKGNOEINJ PKLBAHNBPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x655F9A0", Offset = "0x655E7A0", VA = "0x18655F9A0", Slot = "11")]
		get
		{
			return default(PMOKGNOEINJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private PMOKGNOEINJ PIKFEDNGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x655F9A0", Offset = "0x655E7A0", VA = "0x18655F9A0")]
		get
		{
			return default(PMOKGNOEINJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x655FA00", Offset = "0x655E800", VA = "0x18655FA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6560230", Offset = "0x655F030", VA = "0x186560230")]
	public LENJOHKGLGC(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x655FFD0", Offset = "0x655EDD0", VA = "0x18655FFD0", Slot = "4")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x655FBD0", Offset = "0x655E9D0", VA = "0x18655FBD0")]
	private bool NOJNKOIEDBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x655FAD0", Offset = "0x655E8D0", VA = "0x18655FAD0", Slot = "5")]
	public void MALJJLCCGAE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x655F920", Offset = "0x655E720", VA = "0x18655F920", Slot = "6")]
	public void AIMFMPJJDIE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x65600D0", Offset = "0x655EED0", VA = "0x1865600D0", Slot = "9")]
	public void PDCOBMKCEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x655FCB0", Offset = "0x655EAB0", VA = "0x18655FCB0")]
	private void ODPEGIFODFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x655FE30", Offset = "0x655EC30", VA = "0x18655FE30")]
	private void OMAGDFLPEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x655FB50", Offset = "0x655E950", VA = "0x18655FB50", Slot = "8")]
	public void MPIJINNJCDF(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x655FDB0", Offset = "0x655EBB0", VA = "0x18655FDB0", Slot = "7")]
	public void OEAOOBJOGCE(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class EAHGPGAHCAG : GIFAIPINCAG, APKMGJGILDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x65552D0", Offset = "0x65540D0", VA = "0x1865552D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool BDDGDPJNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6555270", Offset = "0x6554070", VA = "0x186555270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event MIKBECLFJBF CIBDNBIBNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6555490", Offset = "0x6554290", VA = "0x186555490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6554FA0", Offset = "0x6553DA0", VA = "0x186554FA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public EAHGPGAHCAG(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6555330", Offset = "0x6554130", VA = "0x186555330", Slot = "11")]
	public IDisposable IJGPGHCGMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x65553A0", Offset = "0x65541A0", VA = "0x1865553A0", Slot = "8")]
	public void JPNMGIKCEGB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6555260", Offset = "0x6554060", VA = "0x186555260", Slot = "9")]
	public void EANHACBLKGI(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6555160", Offset = "0x6553F60", VA = "0x186555160", Slot = "10")]
	public void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x65553B0", Offset = "0x65541B0", VA = "0x1865553B0", Slot = "12")]
	public void LCBGGHBAEAG(Rigidbody EMNDMNOMIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6555040", Offset = "0x6553E40", VA = "0x186555040", Slot = "13")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6555120", Offset = "0x6553F20", VA = "0x186555120", Slot = "6")]
	public void BGNLJNEHDIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class LAOALPMKIEA : GIFAIPINCAG, GPDAHBNNHMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView FBKOKGALPPO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x655EAF0", Offset = "0x655D8F0", VA = "0x18655EAF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x655F4A0", Offset = "0x655E2A0", VA = "0x18655F4A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event MIKBECLFJBF NGAOOEACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x655EED0", Offset = "0x655DCD0", VA = "0x18655EED0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x655EF70", Offset = "0x655DD70", VA = "0x18655EF70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x655F860", Offset = "0x655E660", VA = "0x18655F860")]
	public LAOALPMKIEA(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x655F730", Offset = "0x655E530", VA = "0x18655F730", Slot = "8")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x655F010", Offset = "0x655DE10", VA = "0x18655F010", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x655F530", Offset = "0x655E330", VA = "0x18655F530", Slot = "9")]
	public void OGGJIKHOGOI(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x655EB10", Offset = "0x655D910", VA = "0x18655EB10", Slot = "10")]
	public void CFIKMONJEFJ(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x655F2C0", Offset = "0x655E0C0", VA = "0x18655F2C0")]
	private void MIOAGIONDFI(PhotonView FACPIADECOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x655F170", Offset = "0x655DF70", VA = "0x18655F170")]
	private void IICACPLMNDJ(RigidbodyEx LNLEJFPPNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x655ED10", Offset = "0x655DB10", VA = "0x18655ED10")]
	private void CKEJFPKHGAJ(PhotonView OGFOBDFKFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class EOFOEJAOEBM
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x65555F0", Offset = "0x65543F0", VA = "0x1865555F0")]
	public static LAOALPMKIEA KFCNCBOPMEG(this BHJLHMHCLMK HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class NNAKKPILANH : GIFAIPINCAG, OEOFLJMCEFM
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6562B30", Offset = "0x6561930", VA = "0x186562B30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6562860", Offset = "0x6561660", VA = "0x186562860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LONMNADJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6562950", Offset = "0x6561750", VA = "0x186562950", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6562C80", Offset = "0x6561A80", VA = "0x186562C80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints KJDGFBCFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6562B90", Offset = "0x6561990", VA = "0x186562B90", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x65629B0", Offset = "0x65617B0", VA = "0x1865629B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6562CF0", Offset = "0x6561AF0", VA = "0x186562CF0")]
	public NNAKKPILANH(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6562BF0", Offset = "0x65619F0", VA = "0x186562BF0", Slot = "9")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x65628D0", Offset = "0x65616D0", VA = "0x1865628D0", Slot = "10")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IAEHIEMHNEB : GIFAIPINCAG, PNFIGMNBOMO
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x655D760", Offset = "0x655C560", VA = "0x18655D760", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x655D610", Offset = "0x655C410", VA = "0x18655D610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float FBLPIJCIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x655D7C0", Offset = "0x655C5C0", VA = "0x18655D7C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x655D820", Offset = "0x655C620", VA = "0x18655D820", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public IAEHIEMHNEB(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x655D970", Offset = "0x655C770", VA = "0x18655D970", Slot = "8")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x655D540", Offset = "0x655C340", VA = "0x18655D540", Slot = "9")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[HLLKJAAFIAG(typeof(KNFKJECPPJO), new string[] { })]
public sealed class CFJJINPMCNH : JOMLNLBCPPN, KNFKJECPPJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[PIIHNFKILAB]
	private HEGJMPEONPB NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x65505F0", Offset = "0x654F3F0", VA = "0x1865505F0", Slot = "4")]
	public void InitReferences(IIHLCNFMGKJ AOLJGMLHFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6550390", Offset = "0x654F190", VA = "0x186550390", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x65509A0", Offset = "0x654F7A0", VA = "0x1865509A0", Slot = "6")]
	public void NFIMNMGPDKG(MIGCCDNHDEL IOGJGBJCGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6550780", Offset = "0x654F580", VA = "0x186550780", Slot = "7")]
	public void LIMLDMPNEFF(MIGCCDNHDEL IOGJGBJCGKK, bool EOHGHPMOIIE, bool PIMANLFJONN, bool DKPCEIDIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x65503C0", Offset = "0x654F1C0", VA = "0x1865503C0", Slot = "8")]
	public void EDAFJPAHDLE(MIGCCDNHDEL IOGJGBJCGKK, float3 MECEBMJGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6550640", Offset = "0x654F440", VA = "0x186550640", Slot = "9")]
	public void KDMPNOEJLEF(MIGCCDNHDEL IOGJGBJCGKK, float3 DIPOODJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x65501E0", Offset = "0x654EFE0", VA = "0x1865501E0")]
	private bool BJEENENMDDJ(MIGCCDNHDEL IOGJGBJCGKK, [Out] DNGCHFDPOCD HBHLLIKFPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6550500", Offset = "0x654F300", VA = "0x186550500")]
	private bool GADKHBIENDA(MIGCCDNHDEL IOGJGBJCGKK, [Out] PHNIKFNMEGP ABPMDGOKICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65502A0", Offset = "0x654F0A0", VA = "0x1865502A0")]
	private bool DNCLPPFLKJI(MIGCCDNHDEL IOGJGBJCGKK, [Out] GFAJFEOCDFC KKPGIFDPHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CFJJINPMCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JBOACLLAPHM : GIFAIPINCAG, OGNODMAJMMG
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool IBBFCHGPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6556730", Offset = "0x6555530", VA = "0x186556730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x655DFA0", Offset = "0x655CDA0", VA = "0x18655DFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x655DE60", Offset = "0x655CC60", VA = "0x18655DE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool HDCOECKPFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x655DBF0", Offset = "0x655C9F0", VA = "0x18655DBF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x655E000", Offset = "0x655CE00", VA = "0x18655E000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool MNBBCEOODCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x655E570", Offset = "0x655D370", VA = "0x18655E570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x655DEC0", Offset = "0x655CCC0", VA = "0x18655DEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int KNCKEEHGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x655DC50", Offset = "0x655CA50", VA = "0x18655DC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event MIKBECLFJBF DPIPNOEPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x655E070", Offset = "0x655CE70", VA = "0x18655E070", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x655E250", Offset = "0x655D050", VA = "0x18655E250", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x655E5D0", Offset = "0x655D3D0", VA = "0x18655E5D0")]
	public JBOACLLAPHM(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x655E3D0", Offset = "0x655D1D0", VA = "0x18655E3D0", Slot = "6")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x655DF30", Offset = "0x655CD30", VA = "0x18655DF30", Slot = "8")]
	public void FGNIGEKKLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x655DCC0", Offset = "0x655CAC0", VA = "0x18655DCC0", Slot = "7")]
	public bool DCLANEKGGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x655E480", Offset = "0x655D280", VA = "0x18655E480", Slot = "9")]
	public void PHLPCGAAGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6555120", Offset = "0x6553F20", VA = "0x186555120", Slot = "12")]
	public void GGCBDINGOMK(bool KFHMHOFNHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x655E110", Offset = "0x655CF10", VA = "0x18655E110", Slot = "11")]
	public void KIHEPGKOBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "10")]
	public void LJFJCGEHNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x655E2F0", Offset = "0x655D0F0", VA = "0x18655E2F0")]
	private void NEMJDEEGLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class CLIBLJJKIPJ : GIFAIPINCAG, DJOGEADPCGL
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6551DD0", Offset = "0x6550BD0", VA = "0x186551DD0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6551750", Offset = "0x6550550", VA = "0x186551750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6551CF0", Offset = "0x6550AF0", VA = "0x186551CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool MDOIIMOBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x65516F0", Offset = "0x65504F0", VA = "0x1865516F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6552180", Offset = "0x6550F80", VA = "0x186552180")]
	public CLIBLJJKIPJ(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6551EB0", Offset = "0x6550CB0", VA = "0x186551EB0", Slot = "5")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6551840", Offset = "0x6550640", VA = "0x186551840", Slot = "7")]
	public void CDPAFGMHMDL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6551D50", Offset = "0x6550B50", VA = "0x186551D50", Slot = "8")]
	public void MEKAPPHPEHP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6551F60", Offset = "0x6550D60", VA = "0x186551F60", Slot = "9")]
	public void PKDLEPKDEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x65518C0", Offset = "0x65506C0", VA = "0x1865518C0", Slot = "11")]
	public void CEJGAHDHJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6551B20", Offset = "0x6550920", VA = "0x186551B20", Slot = "12")]
	public void CJJPHHOIMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "10")]
	public void KPOIENHIAAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class GFAJFEOCDFC : GIFAIPINCAG, DHMGNKBAAIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6558F70", Offset = "0x6557D70", VA = "0x186558F70", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6556970", Offset = "0x6555770", VA = "0x186556970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6556650", Offset = "0x6555450", VA = "0x186556650", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x65586B0", Offset = "0x65574B0", VA = "0x1865586B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x65559A0", Offset = "0x65547A0", VA = "0x1865559A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x65568B0", Offset = "0x65556B0", VA = "0x1865568B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6556810", Offset = "0x6555610", VA = "0x186556810", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6556620", Offset = "0x6555420", VA = "0x186556620", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6556C20", Offset = "0x6555A20", VA = "0x186556C20", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6556750", Offset = "0x6555550", VA = "0x186556750", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6555AE0", Offset = "0x65548E0", VA = "0x186555AE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6556700", Offset = "0x6555500", VA = "0x186556700", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6556C80", Offset = "0x6555A80", VA = "0x186556C80", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6556FC0", Offset = "0x6555DC0", VA = "0x186556FC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6556F60", Offset = "0x6555D60", VA = "0x186556F60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private EHKMCJIAECG GAFHNIHPIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA990", Offset = "0x5EA9790", VA = "0x185EAA990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool IBBFCHGPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6556730", Offset = "0x6555530", VA = "0x186556730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public GFAJFEOCDFC(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x65557A0", Offset = "0x65545A0", VA = "0x1865557A0", Slot = "20")]
	public void AGKPFNNAENP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6556840", Offset = "0x6555640", VA = "0x186556840", Slot = "30")]
	public void GKGKPIEJHCF(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6557110", Offset = "0x6555F10", VA = "0x186557110", Slot = "19")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6556560", Offset = "0x6555360", VA = "0x186556560", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6557D60", Offset = "0x6556B60", VA = "0x186557D60", Slot = "28")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6556380", Offset = "0x6555180", VA = "0x186556380", Slot = "35")]
	public Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6558720", Offset = "0x6557520", VA = "0x186558720", Slot = "34")]
	public Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6557110", Offset = "0x6555F10", VA = "0x186557110", Slot = "27")]
	public void KBEKNHHPGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6557790", Offset = "0x6556590", VA = "0x186557790", Slot = "25")]
	public void KNJOKJCMBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x65592D0", Offset = "0x65580D0", VA = "0x1865592D0", Slot = "24")]
	public void PJGEDJCLCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x65569E0", Offset = "0x65557E0", VA = "0x1865569E0", Slot = "33")]
	public void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6558650", Offset = "0x6557450", VA = "0x186558650", Slot = "32")]
	public void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6557ED0", Offset = "0x6556CD0", VA = "0x186557ED0", Slot = "31")]
	public void LKFKPMIHMME(Vector3 DKBFOCHMODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65571C0", Offset = "0x6555FC0", VA = "0x1865571C0", Slot = "22")]
	public void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6559020", Offset = "0x6557E20", VA = "0x186559020", Slot = "21")]
	public void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x65588E0", Offset = "0x65576E0", VA = "0x1865588E0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6555A00", Offset = "0x6554800", VA = "0x186555A00", Slot = "29")]
	public Vector3 BIHBJCCIEAK(Vector3 FEAOCKEGNIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6555810", Offset = "0x6554610", VA = "0x186555810", Slot = "26")]
	public void AMIJBFNEEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6556FC0", Offset = "0x6555DC0", VA = "0x186556FC0")]
	private void JNLJIFONGKG(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6556CE0", Offset = "0x6555AE0", VA = "0x186556CE0")]
	private void IKHEHALIBPL(Vector3 FNICFFEJGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6558CF0", Offset = "0x6557AF0", VA = "0x186558CF0")]
	private Vector3 NPKJPOIMEHE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6555E00", Offset = "0x6554C00", VA = "0x186555E00")]
	private void DGNPHHGFPIM(Vector3 MECEBMJGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6555B70", Offset = "0x6554970", VA = "0x186555B70")]
	private Vector3 DADKEEPOLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x65577F0", Offset = "0x65565F0", VA = "0x1865577F0")]
	private void LBCGABLLHJC(Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6557730", Offset = "0x6556530", VA = "0x186557730")]
	private void KNFLIHGLEFF(Vector3 FEAOCKEGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6555B10", Offset = "0x6554910", VA = "0x186555B10")]
	private void BOIGKHPBOBN(Vector3 NDNOKJPALDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x65580A0", Offset = "0x6556EA0", VA = "0x1865580A0")]
	private void MDNBLJLPEMB(string KEOEHAJBDEC, Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6556EB0", Offset = "0x6555CB0", VA = "0x186556EB0")]
	private void JHKNGNFBLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class GIFAIPINCAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly DNGCHFDPOCD NPOMGMGDKBM;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected HEGJMPEONPB FCBIJNHGCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5668AD0", Offset = "0x56678D0", VA = "0x185668AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5668B10", Offset = "0x5667910", VA = "0x185668B10")]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6551650", Offset = "0x6550450", VA = "0x186551650")]
	public GIFAIPINCAG(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6559330", Offset = "0x6558130", VA = "0x186559330")]
	protected JNIFIKAJIFG LJAKLCLLANI(MIGCCDNHDEL GDLGHGPGIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CANPEBKMMHP : HPOENFLBIFL
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x654FF70", Offset = "0x654ED70", VA = "0x18654FF70", Slot = "4")]
	public NHGIDJKNFAL NGGFAGEODLD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x654FA10", Offset = "0x654E810", VA = "0x18654FA10", Slot = "5")]
	public DHMGNKBAAIH HONOCMLKCDN(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6550100", Offset = "0x654EF00", VA = "0x186550100", Slot = "6")]
	public JEHGAGDGEEE PPKGHGBAIBP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x654F6B0", Offset = "0x654E4B0", VA = "0x18654F6B0", Slot = "7")]
	public PNFIGMNBOMO DOPJDLCHCJD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x654FAF0", Offset = "0x654E8F0", VA = "0x18654FAF0", Slot = "8")]
	public OGNODMAJMMG IAPPHAAABGE(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x654FDB0", Offset = "0x654EBB0", VA = "0x18654FDB0", Slot = "9")]
	public IHHOELGMLAK KNLFGIOFOLP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x654F4C0", Offset = "0x654E2C0", VA = "0x18654F4C0", Slot = "10")]
	public APKMGJGILDJ BECJEBOKJNJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x654F930", Offset = "0x654E730", VA = "0x18654F930", Slot = "11")]
	public EHKMCJIAECG HJJDBKFKEPJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x654FE90", Offset = "0x654EC90", VA = "0x18654FE90", Slot = "12")]
	public NPDBKMIPJOC MIJIMEHMLON(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x654FC60", Offset = "0x654EA60", VA = "0x18654FC60", Slot = "13")]
	public GGDAMBMLLEL INNJHDKJDAI(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x654F5A0", Offset = "0x654E3A0", VA = "0x18654F5A0")]
	public DJOGEADPCGL EOGLBPAPFMD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x654F280", Offset = "0x654E080", VA = "0x18654F280")]
	public GPDAHBNNHMD CGDDJPODGFD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x654F380", Offset = "0x654E180", VA = "0x18654F380")]
	public CGLADKHONPG PIFPPOGIOPO(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x654FD40", Offset = "0x654EB40", VA = "0x18654FD40")]
	public BHFAAMLNOOH MAMAMLLMFJH(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x654F790", Offset = "0x654E590", VA = "0x18654F790")]
	public OEOFLJMCEFM FMDAGBDDHCJ(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x654FFD0", Offset = "0x654EDD0", VA = "0x18654FFD0", Slot = "19")]
	public JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA, KPGKLAGMOGC IEHBMNBOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CANPEBKMMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x654F5A0", Offset = "0x654E3A0", VA = "0x18654F5A0", Slot = "14")]
	private DJOGEADPCGL BMNPFLCGBKP(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x654F280", Offset = "0x654E080", VA = "0x18654F280", Slot = "15")]
	private GPDAHBNNHMD AILHMKPGMFI(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x654F380", Offset = "0x654E180", VA = "0x18654F380", Slot = "16")]
	private CGLADKHONPG ANEFEFGEEOB(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x654FD40", Offset = "0x654EB40", VA = "0x18654FD40", Slot = "17")]
	private BHFAAMLNOOH KFMKMDIKOMK(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x654F6A0", Offset = "0x654E4A0", VA = "0x18654F6A0", Slot = "18")]
	private OEOFLJMCEFM CKBJEJPGPKG(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class NGFPPENEEFL : IReadOnlyList<JNIFIKAJIFG>, IEnumerable<JNIFIKAJIFG>, IEnumerable, IReadOnlyCollection<JNIFIKAJIFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly HEGJMPEONPB AMBIOCKKGLI;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6561C10", Offset = "0x6560A10", VA = "0x186561C10", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public JNIFIKAJIFG LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x65619B0", Offset = "0x65607B0", VA = "0x1865619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x34ECFA0", Offset = "0x34EBDA0", VA = "0x1834ECFA0")]
	public NGFPPENEEFL(MIGCCDNHDEL GDLGHGPGIOA, HEGJMPEONPB AMBIOCKKGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6561B00", Offset = "0x6560900", VA = "0x186561B00", Slot = "6")]
	public IEnumerator<JNIFIKAJIFG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6561B00", Offset = "0x6560900", VA = "0x186561B00", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x65619B0", Offset = "0x65607B0", VA = "0x1865619B0")]
	[CompilerGenerated]
	private JNIFIKAJIFG FMMCNJCEMCK(int PGCIMAABPAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HLLKJAAFIAG(typeof(HPOENFLBIFL), new string[] { })]
public class NIABFPHAFOJ : HPOENFLBIFL, JOMLNLBCPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HPOENFLBIFL PAOKAJCEMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HPOENFLBIFL NHEKDGNCFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private CNFJBICKGLP NLDBEEDMOMA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private HPOENFLBIFL IEIFONJGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x6562240", Offset = "0x6561040", VA = "0x186562240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6562340", Offset = "0x6561140", VA = "0x186562340", Slot = "20")]
	public void InitReferences(IIHLCNFMGKJ AOLJGMLHFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6562580", Offset = "0x6561380", VA = "0x186562580", Slot = "4")]
	public NHGIDJKNFAL NGGFAGEODLD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6562100", Offset = "0x6560F00", VA = "0x186562100", Slot = "5")]
	public DHMGNKBAAIH HONOCMLKCDN(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6562710", Offset = "0x6561510", VA = "0x186562710", Slot = "6")]
	public JEHGAGDGEEE PPKGHGBAIBP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6561FC0", Offset = "0x6560DC0", VA = "0x186561FC0", Slot = "7")]
	public PNFIGMNBOMO DOPJDLCHCJD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65621A0", Offset = "0x6560FA0", VA = "0x1865621A0", Slot = "8")]
	public OGNODMAJMMG IAPPHAAABGE(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6562440", Offset = "0x6561240", VA = "0x186562440", Slot = "9")]
	public IHHOELGMLAK KNLFGIOFOLP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6561DC0", Offset = "0x6560BC0", VA = "0x186561DC0", Slot = "10")]
	public APKMGJGILDJ BECJEBOKJNJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6562060", Offset = "0x6560E60", VA = "0x186562060", Slot = "11")]
	public EHKMCJIAECG HJJDBKFKEPJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x65624E0", Offset = "0x65612E0", VA = "0x1865624E0", Slot = "12")]
	public NPDBKMIPJOC MIJIMEHMLON(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x65622A0", Offset = "0x65610A0", VA = "0x1865622A0", Slot = "13")]
	public GGDAMBMLLEL INNJHDKJDAI(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6561E60", Offset = "0x6560C60", VA = "0x186561E60")]
	public DJOGEADPCGL EOGLBPAPFMD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6561C60", Offset = "0x6560A60", VA = "0x186561C60")]
	public GPDAHBNNHMD CGDDJPODGFD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6561D10", Offset = "0x6560B10", VA = "0x186561D10")]
	public CGLADKHONPG PIFPPOGIOPO(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6562390", Offset = "0x6561190", VA = "0x186562390")]
	public BHFAAMLNOOH MAMAMLLMFJH(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6561F10", Offset = "0x6560D10", VA = "0x186561F10")]
	public OEOFLJMCEFM FMDAGBDDHCJ(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6562620", Offset = "0x6561420", VA = "0x186562620", Slot = "19")]
	public JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA, KPGKLAGMOGC IEHBMNBOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x65627B0", Offset = "0x65615B0", VA = "0x1865627B0")]
	public NIABFPHAFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6561E60", Offset = "0x6560C60", VA = "0x186561E60", Slot = "14")]
	private DJOGEADPCGL BMNPFLCGBKP(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6561C60", Offset = "0x6560A60", VA = "0x186561C60", Slot = "15")]
	private GPDAHBNNHMD AILHMKPGMFI(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6561D10", Offset = "0x6560B10", VA = "0x186561D10", Slot = "16")]
	private CGLADKHONPG ANEFEFGEEOB(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6562390", Offset = "0x6561190", VA = "0x186562390", Slot = "17")]
	private BHFAAMLNOOH KFMKMDIKOMK(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6561F10", Offset = "0x6560D10", VA = "0x186561F10", Slot = "18")]
	private OEOFLJMCEFM CKBJEJPGPKG(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class DCENOFFEFPJ : JNIFIKAJIFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly DCENOFFEFPJ AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx FFLEDHGNBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x819140", Offset = "0x817F40", VA = "0x180819140", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F45F0", Offset = "0x7F33F0", VA = "0x1807F45F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA04630", Offset = "0xA03430", VA = "0x180A04630", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8CE950", Offset = "0x8CD750", VA = "0x1808CE950", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1B80040", Offset = "0x1B7EE40", VA = "0x181B80040", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3DF58D0", Offset = "0x3DF46D0", VA = "0x183DF58D0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x46C8FA0", Offset = "0x46C7DA0", VA = "0x1846C8FA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x46C8330", Offset = "0x46C7130", VA = "0x1846C8330", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4050BC0", Offset = "0x404F9C0", VA = "0x184050BC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4050BE0", Offset = "0x404F9E0", VA = "0x184050BE0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool COBNBGFHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x945400", Offset = "0x944200", VA = "0x180945400", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool GEJKBIJMFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x17944E0", Offset = "0x17932E0", VA = "0x1817944E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5E07B40", Offset = "0x5E06940", VA = "0x185E07B40", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x404BA80", Offset = "0x404A880", VA = "0x18404BA80", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x9718E0", Offset = "0x9706E0", VA = "0x1809718E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x65539F0", Offset = "0x65527F0", VA = "0x1865539F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1A84BD0", Offset = "0x1A839D0", VA = "0x181A84BD0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x91EC90", Offset = "0x91DA90", VA = "0x18091EC90", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float FBLPIJCIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool GNKJKEDOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "48")]
		get
		{
			return default(OIIAKGKODFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xD078D0", Offset = "0xD066D0", VA = "0x180D078D0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform GDAKNEOILHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9B2520", Offset = "0x9B1320", VA = "0x1809B2520", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 CHHOCLKGNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float AEBHJKHKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float NAACHPNFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion DCJMENCHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9B36E0", Offset = "0x9B24E0", VA = "0x1809B36E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 FGMHAIMGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion LMICPFEIIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x9B36E0", Offset = "0x9B24E0", VA = "0x1809B36E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints KJDGFBCFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode KCBKNHGILJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool IHJAGFDOKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8DC680", Offset = "0x8DB480", VA = "0x1808DC680", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event MIKBECLFJBF NGEJMPGOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event MIKBECLFJBF CPAAPFDLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event ICEFHJCPMAE MNFACJLLLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event MIKBECLFJBF NGAOOEACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event MIKBECLFJBF OKNKKIHCEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event MIKBECLFJBF DPIPNOEPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event MIKBECLFJBF CIBDNBIBNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event MIKBECLFJBF COGENIEGILN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "41")]
	public void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "71")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "72")]
	public void JMHOODKNNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "73")]
	public void EIEMBELJJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "74")]
	public void PHLPCGAAGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "81")]
	public void IEJEABLOHEA(JNIFIKAJIFG NKKIECLCEML, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "84")]
	public void GBKIGGDPOAB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "85")]
	public void BFLIOOMGNAM(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "86")]
	public Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "87")]
	public Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "88")]
	public void KBEKNHHPGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "89")]
	public void KNJOKJCMBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "90")]
	public void PJGEDJCLCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "91")]
	public void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "92")]
	public void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "93")]
	public void LKFKPMIHMME(Vector3 DKBFOCHMODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "94")]
	public void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "95")]
	public void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "96")]
	public void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "97")]
	public Vector3 BIHBJCCIEAK(Vector3 NKKIECLCEML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xB30740", Offset = "0xB2F540", VA = "0x180B30740", Slot = "98")]
	public Vector3 JMHBKLNLJGK(Vector3 NKKIECLCEML)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "99")]
	public void AMIJBFNEEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "100")]
	public void KPHAFHBKKPC(JNIFIKAJIFG IMFBHLANEHI, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "101")]
	public void OBNPKECIFCB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "104")]
	public void FJGFMBGMDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "105")]
	public void FMODEPOJMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "106")]
	public void ICOLGPNACMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "109")]
	public bool DCLANEKGGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "110")]
	public void KIHEPGKOBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "115")]
	public IDisposable IJGPGHCGMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "116")]
	public void JPNMGIKCEGB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "117")]
	public void EANHACBLKGI(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "118")]
	public void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "121")]
	public void JNILHPKPLOE(Vector3 EPFLHJDIJPA, Quaternion GGDMCPJFCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "122")]
	public void ENKOLCJJHON(Vector3 HFDFKBBEJAO, Quaternion GCOLCIFOCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "123")]
	public bool OACEGBPIMAF(float HPMOKOMLGDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "124")]
	public void AKCCMFJJEKK(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "125")]
	public void KHACCLGPDBK(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "126")]
	public void CDPAFGMHMDL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "127")]
	public void MEKAPPHPEHP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "128")]
	public void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "129")]
	public void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "130")]
	public void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "131")]
	public void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6553A10", Offset = "0x6552810", VA = "0x186553A10", Slot = "132")]
	public bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "133")]
	public void DKJFEKKPLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DCENOFFEFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class DNGCHFDPOCD : BHJLHMHCLMK, BNMCAMKAGGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal MIGCCDNHDEL GDLGHGPGIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal HEGJMPEONPB JHEANIIBECF;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x654F1B0", Offset = "0x654DFB0", VA = "0x18654F1B0")]
	public DNGCHFDPOCD(GameObject IPHCMOEHILB, RigidbodyEx HHGAHJIEKDO, KPGKLAGMOGC IEHBMNBOFCL, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x65540B0", Offset = "0x6552EB0", VA = "0x1865540B0", Slot = "135")]
	protected override void GALJJDFNOBB(KPGKLAGMOGC IEHBMNBOFCL, HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "141")]
	protected override IDisposable OACCLACJMAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6553D10", Offset = "0x6552B10", VA = "0x186553D10", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6553AB0", Offset = "0x65528B0", VA = "0x186553AB0", Slot = "142")]
	public void AHCEFLDOPOF(PEEEMJJCGFN HPFNNCFAOFH, PEEEMJJCGFN FLONDMFIAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6554380", Offset = "0x6553180", VA = "0x186554380", Slot = "143")]
	public void GKKAKNPKGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x65544A0", Offset = "0x65532A0", VA = "0x1865544A0", Slot = "144")]
	public void PJEFOENMCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6554320", Offset = "0x6553120", VA = "0x186554320", Slot = "145")]
	public void GGCBDINGOMK(bool KFHMHOFNHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6553B80", Offset = "0x6552980", VA = "0x186553B80", Slot = "146")]
	public bool DEHOBCKKILK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6554440", Offset = "0x6553240", VA = "0x186554440", Slot = "147")]
	public void OKKOAHPBOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "140")]
	protected override void DBALEKPPCMM(RigidbodyEx AIFJDDMPMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6553E80", Offset = "0x6552C80", VA = "0x186553E80")]
	private void FMAGAIODLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class JDMEOPFGAGN
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x655E700", Offset = "0x655D500", VA = "0x18655E700")]
	public static BHJLHMHCLMK LAHKJHFMMHI(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KOAEEJNLAKG : NHGIDJKNFAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POLLOHFPCNE(JNIFIKAJIFG NPOMGMGDKBM);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJHLAHADDHF(JNIFIKAJIFG NPOMGMGDKBM);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNGFIEBANEK(JNIFIKAJIFG BIEFPFAGGLB);

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLAIIEJIEFF(JNIFIKAJIFG BIEFPFAGGLB);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NKPIAHACOMB : JEHGAGDGEEE
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	AECCJKFPEMF<JNIFIKAJIFG> CGHNJFHKIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	JNIFIKAJIFG JOIGBJDFBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface FDFMIOKNPCH : BHFAAMLNOOH
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NFIMNMGPDKG(Rigidbody ELNCLJFODKM);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface EJPLDNPJPLM : GPDAHBNNHMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView JIFJDDGHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class OFCEJNLJGGO : NPDBKMIPJOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode JHNIGALIDLI;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode KCBKNHGILJP
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6563020", Offset = "0x6561E20", VA = "0x186563020", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6563240", Offset = "0x6562040", VA = "0x186563240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6545E70", Offset = "0x6544C70", VA = "0x186545E70")]
	public OFCEJNLJGGO(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6563130", Offset = "0x6561F30", VA = "0x186563130", Slot = "6")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6562FA0", Offset = "0x6561DA0", VA = "0x186562FA0", Slot = "9")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6562E60", Offset = "0x6561C60", VA = "0x186562E60", Slot = "7")]
	public void AKKFOMFAGJD(bool GLJMFCDGBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6562E70", Offset = "0x6561C70", VA = "0x186562E70", Slot = "8")]
	public void CFELFNOKNLK(bool GLJMFCDGBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x65632B0", Offset = "0x65620B0", VA = "0x1865632B0", Slot = "10")]
	public bool PNJJGCJHCDJ(Vector3 LLMNHBKBLPP, [Out] RaycastHit IKPFKBFFILC, float ABEPJPPAIOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6562E80", Offset = "0x6561C80", VA = "0x186562E80")]
	private void ILLAJOIHIOE(bool GLJMFCDGBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DBEBMLFPACK : IHHOELGMLAK, IDisposable, FMFFPEPNOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OIIAKGKODFP OFLAMJGBEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AFLEKNEEHDF CGKANCPOHOJ;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public OIIAKGKODFP PHPFHPOLJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6553510", Offset = "0x6552310", VA = "0x186553510", Slot = "6")]
		get
		{
			return default(OIIAKGKODFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6553440", Offset = "0x6552240", VA = "0x186553440", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform DDBBPCOFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6553270", Offset = "0x6552070", VA = "0x186553270", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<AMOHOHNPBGH, AMOHOHNPBGH> DKDGLEMPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x65532E0", Offset = "0x65520E0", VA = "0x1865532E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6553390", Offset = "0x6552190", VA = "0x186553390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6553960", Offset = "0x6552760", VA = "0x186553960")]
	public DBEBMLFPACK(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6553660", Offset = "0x6552460", VA = "0x186553660", Slot = "8")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6553290", Offset = "0x6552090", VA = "0x186553290", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0ADD0", Offset = "0x1C09BD0", VA = "0x181C0ADD0", Slot = "11")]
	private void KLCIGEIDOLA(AMOHOHNPBGH CLIAGDNIEBC, AMOHOHNPBGH FGMBHENNCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "12")]
	private void BHADPBGAKPB(bool MAAMCGOAHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class DBABENHNMOM : EHKMCJIAECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6552FA0", Offset = "0x6551DA0", VA = "0x186552FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6552A90", Offset = "0x6551890", VA = "0x186552A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x6551CF0", Offset = "0x6550AF0", VA = "0x186551CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6552770", Offset = "0x6551570", VA = "0x186552770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6545E70", Offset = "0x6544C70", VA = "0x186545E70")]
	public DBABENHNMOM(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6552930", Offset = "0x6551730", VA = "0x186552930", Slot = "4")]
	public void IFIDLPBCDPL(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6552510", Offset = "0x6551310", VA = "0x186552510")]
	private void EBBLHMLIHPJ(Vector3 KCOHBBNEOFL, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6552FF0", Offset = "0x6551DF0", VA = "0x186552FF0", Slot = "5")]
	public void NKOFIAGHAKC(Vector3 KCOHBBNEOFL, Vector3 JCOIMLJCHFJ, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x65527D0", Offset = "0x65515D0", VA = "0x1865527D0", Slot = "6")]
	public void HJPCGMIHPGF(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6552AE0", Offset = "0x65518E0", VA = "0x186552AE0")]
	private void JEJMCKPAPKJ(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6552D40", Offset = "0x6551B40", VA = "0x186552D40", Slot = "7")]
	public void KJLJHNBNMAN(Vector3 NCLHEGHFDKP, ForceMode KBBEIMAMPBJ = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class AKIPIGDINBK : GGDAMBMLLEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool ILFNPMHJDHH;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool GNKJKEDOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6545D60", Offset = "0x6544B60", VA = "0x186545D60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6545E70", Offset = "0x6544C70", VA = "0x186545E70")]
	public AKIPIGDINBK(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6545D30", Offset = "0x6544B30", VA = "0x186545D30", Slot = "6")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6545CC0", Offset = "0x6544AC0", VA = "0x186545CC0", Slot = "7")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class OJKNBPAFOKL : KOAEEJNLAKG, NHGIDJKNFAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JNIFIKAJIFG NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<JNIFIKAJIFG> ONHELHMPEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JNIFIKAJIFG ADCDJFADKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private JNIFIKAJIFG AJKCELPHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform AMOKGCIGMGO;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6564EF0", Offset = "0x6563CF0", VA = "0x186564EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6563F50", Offset = "0x6562D50", VA = "0x186563F50", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public JNIFIKAJIFG CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<JNIFIKAJIFG> KOBCODCKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event MIKBECLFJBF NGEJMPGOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x65634B0", Offset = "0x65622B0", VA = "0x1865634B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6563EB0", Offset = "0x6562CB0", VA = "0x186563EB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event MIKBECLFJBF CPAAPFDLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6563410", Offset = "0x6562210", VA = "0x186563410", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6564B20", Offset = "0x6563920", VA = "0x186564B20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ICEFHJCPMAE MNFACJLLLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6564940", Offset = "0x6563740", VA = "0x186564940", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x65647B0", Offset = "0x65635B0", VA = "0x1865647B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action OCBLGNGLGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x65644E0", Offset = "0x65632E0", VA = "0x1865644E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6564670", Offset = "0x6563470", VA = "0x186564670", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action MOBCICGAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6564710", Offset = "0x6563510", VA = "0x186564710", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x65639C0", Offset = "0x65627C0", VA = "0x1865639C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<JNIFIKAJIFG> FJDOGJLHLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6564890", Offset = "0x6563690", VA = "0x186564890", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6563BA0", Offset = "0x65629A0", VA = "0x186563BA0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<JNIFIKAJIFG> GEHJDPEKAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6564BC0", Offset = "0x65639C0", VA = "0x186564BC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6563550", Offset = "0x6562350", VA = "0x186563550", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action BGCHCONHCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6565000", Offset = "0x6563E00", VA = "0x186565000", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6563600", Offset = "0x6562400", VA = "0x186563600", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<JNIFIKAJIFG> PJJFLOLOHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6564F50", Offset = "0x6563D50", VA = "0x186564F50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6563910", Offset = "0x6562710", VA = "0x186563910", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6565230", Offset = "0x6564030", VA = "0x186565230")]
	public OJKNBPAFOKL(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6563A60", Offset = "0x6562860", VA = "0x186563A60", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6563F60", Offset = "0x6562D60", VA = "0x186563F60", Slot = "30")]
	public void IEJEABLOHEA(JNIFIKAJIFG PKMANOIKNOC, bool JEJBEBJPFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x65636A0", Offset = "0x65624A0", VA = "0x1865636A0", Slot = "6")]
	public void BNGFIEBANEK(JNIFIKAJIFG BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6564C70", Offset = "0x6563A70", VA = "0x186564C70", Slot = "7")]
	public void OLAIIEJIEFF(JNIFIKAJIFG BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6565140", Offset = "0x6563F40", VA = "0x186565140", Slot = "4")]
	public void POLLOHFPCNE(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x65650A0", Offset = "0x6563EA0", VA = "0x1865650A0", Slot = "5")]
	public void PJHLAHADDHF(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6563B00", Offset = "0x6562900", VA = "0x186563B00")]
	private void EFGCBNFCNFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6564850", Offset = "0x6563650", VA = "0x186564850")]
	private void LICAJNAPINP(JNIFIKAJIFG BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65649E0", Offset = "0x65637E0", VA = "0x1865649E0")]
	private void NGMPLAMAIIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6563C50", Offset = "0x6562A50", VA = "0x186563C50")]
	private void GLJGLMFNCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6563D80", Offset = "0x6562B80", VA = "0x186563D80")]
	private void GOAEIPCJONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6564580", Offset = "0x6563380", VA = "0x186564580")]
	[CompilerGenerated]
	private object IOLCHEFGFBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class AINLLHBEHGD
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6545C00", Offset = "0x6544A00", VA = "0x186545C00")]
	public static KOAEEJNLAKG GNCIEAAOHHD(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class ABHPCMPAPOP : NKPIAHACOMB, JEHGAGDGEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AECCJKFPEMF<JNIFIKAJIFG> AKNDAFOIIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool PNLKMAJDPOA;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public AECCJKFPEMF<JNIFIKAJIFG> CGHNJFHKIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 BKFBGOKPINF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6545070", Offset = "0x6543E70", VA = "0x186545070", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 GCBEBDPEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6545500", Offset = "0x6544300", VA = "0x186545500", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6544F80", Offset = "0x6543D80", VA = "0x186544F80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public JNIFIKAJIFG JOIGBJDFBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x65456C0", Offset = "0x65444C0", VA = "0x1865456C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6545B00", Offset = "0x6544900", VA = "0x186545B00")]
	public ABHPCMPAPOP(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6545490", Offset = "0x6544290", VA = "0x186545490", Slot = "8")]
	public void IGGGFPLIMLB(JNIFIKAJIFG AJKCELPHOFC, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x6545430", Offset = "0x6544230", VA = "0x186545430", Slot = "9")]
	public void DKLPCNMLODL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6545770", Offset = "0x6544570", VA = "0x186545770")]
	private Vector3 ONOPBHGCOKI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x65450A0", Offset = "0x6543EA0", VA = "0x1865450A0")]
	private void CFOPKNHCDNG(JNIFIKAJIFG FJGLKFPPNCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MEKDOMILLFJ
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6560A70", Offset = "0x655F870", VA = "0x186560A70")]
	public static NKPIAHACOMB EGOFFHPPHDH(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class HMPLJHPACKI : FDFMIOKNPCH, BHFAAMLNOOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 AJAKDEHIKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 FBHFCMIJCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float LPCAAJKDNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float IBABECJCJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 KBCJHMLOEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? IDFMLECGHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? DGLAGKBNNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool CDPAOGGEDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool HNHDJBOJPPH;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 KOOGNDMOALM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10AA2B0", Offset = "0x10A90B0", VA = "0x1810AA2B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x655AE60", Offset = "0x6559C60", VA = "0x18655AE60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 GAGIGFIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x655C0C0", Offset = "0x655AEC0", VA = "0x18655C0C0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float CAFOCMIMJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x113EE70", Offset = "0x113DC70", VA = "0x18113EE70", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x655AA20", Offset = "0x6559820", VA = "0x18655AA20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float HJJHIEDHGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xBBBBB0", Offset = "0xBBA9B0", VA = "0x180BBBBB0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x655B950", Offset = "0x655A750", VA = "0x18655B950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 OLHMMAPCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x655BA00", Offset = "0x655A800", VA = "0x18655BA00", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion AEGEICLOHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x655BF40", Offset = "0x655AD40", VA = "0x18655BF40", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x6546660", Offset = "0x6545460", VA = "0x186546660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event MIKBECLFJBF KKKGFKCKBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x655AB30", Offset = "0x6559930", VA = "0x18655AB30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x655BB90", Offset = "0x655A990", VA = "0x18655BB90", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x655D450", Offset = "0x655C250", VA = "0x18655D450")]
	public HMPLJHPACKI(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x655B3B0", Offset = "0x655A1B0", VA = "0x18655B3B0", Slot = "17")]
	public void FJGFMBGMDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x655B560", Offset = "0x655A360", VA = "0x18655B560", Slot = "16")]
	public void FMODEPOJMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x655BC30", Offset = "0x655AA30", VA = "0x18655BC30", Slot = "19")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x655ABD0", Offset = "0x65599D0", VA = "0x18655ABD0", Slot = "20")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x655B640", Offset = "0x655A440", VA = "0x18655B640", Slot = "18")]
	public void ICOLGPNACMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x655AF10", Offset = "0x6559D10", VA = "0x18655AF10", Slot = "21")]
	public void DKJFEKKPLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x655AE60", Offset = "0x6559C60", VA = "0x18655AE60")]
	private void OBNPGDLKOFA(Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x655D360", Offset = "0x655C160", VA = "0x18655D360")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OFFCKMGPHOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x655AA20", Offset = "0x6559820", VA = "0x18655AA20")]
	private void ABGLKCNCPAC(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x655B950", Offset = "0x655A750", VA = "0x18655B950")]
	private void PNGEOPILNMJ(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x655B7B0", Offset = "0x655A5B0", VA = "0x18655B7B0")]
	private Vector3 IFHMGLOFNPJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x655BD10", Offset = "0x655AB10", VA = "0x18655BD10", Slot = "15")]
	public void LKJGIBEGMJF((Quaternion rot, Vector3 moments) JDFPGJKLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x655C1C0", Offset = "0x655AFC0", VA = "0x18655C1C0")]
	private Quaternion MALLHLCEMAC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x655D290", Offset = "0x655C090", VA = "0x18655D290")]
	public void NFIMNMGPDKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x655C340", Offset = "0x655B140", VA = "0x18655C340", Slot = "4")]
	public (float, Vector3) NFIMNMGPDKG(Rigidbody ELNCLJFODKM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EEBLIJJCAEI
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6555530", Offset = "0x6554330", VA = "0x186555530")]
	public static FDFMIOKNPCH JHCCADPMKDA(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class BGKNCADDILL : CGLADKHONPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HENOHJNKMME IEJCKHKIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PMOKGNOEINJ PNBIKGIPGPP;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool GJOKPCPMHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xD024B0", Offset = "0xD012B0", VA = "0x180D024B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public PMOKGNOEINJ PKLBAHNBPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0", Slot = "11")]
		get
		{
			return default(PMOKGNOEINJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x65491F0", Offset = "0x6547FF0", VA = "0x1865491F0")]
	public BGKNCADDILL(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6548FE0", Offset = "0x6547DE0", VA = "0x186548FE0", Slot = "4")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6548C70", Offset = "0x6547A70", VA = "0x186548C70")]
	private bool NOJNKOIEDBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6548C00", Offset = "0x6547A00", VA = "0x186548C00", Slot = "5")]
	public void MALJJLCCGAE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6548BD0", Offset = "0x65479D0", VA = "0x186548BD0", Slot = "6")]
	public void AIMFMPJJDIE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x65490B0", Offset = "0x6547EB0", VA = "0x1865490B0", Slot = "9")]
	public void PDCOBMKCEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6548D10", Offset = "0x6547B10", VA = "0x186548D10")]
	private void ODPEGIFODFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6548E70", Offset = "0x6547C70", VA = "0x186548E70")]
	private void OMAGDFLPEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6548C30", Offset = "0x6547A30", VA = "0x186548C30", Slot = "8")]
	public void MPIJINNJCDF(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6548E30", Offset = "0x6547C30", VA = "0x186548E30", Slot = "7")]
	public void OEAOOBJOGCE(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class HJGMGEBECMP : APKMGJGILDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HENOHJNKMME EEAEBMIGMGD;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool AMMBJOPJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x655A6E0", Offset = "0x65594E0", VA = "0x18655A6E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event MIKBECLFJBF CIBDNBIBNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x655A890", Offset = "0x6559690", VA = "0x18655A890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x655A4B0", Offset = "0x65592B0", VA = "0x18655A4B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x655A930", Offset = "0x6559730", VA = "0x18655A930")]
	public HJGMGEBECMP(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x655A790", Offset = "0x6559590", VA = "0x18655A790", Slot = "11")]
	public IDisposable IJGPGHCGMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x655A800", Offset = "0x6559600", VA = "0x18655A800", Slot = "8")]
	public void JPNMGIKCEGB(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x655A6D0", Offset = "0x65594D0", VA = "0x18655A6D0", Slot = "9")]
	public void EANHACBLKGI(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x655A5C0", Offset = "0x65593C0", VA = "0x18655A5C0", Slot = "10")]
	public void DECDAJCJFDH(object NBGOKNOECBH, bool DDKFBELPPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x655A580", Offset = "0x6559380", VA = "0x18655A580", Slot = "6")]
	public void BGNLJNEHDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x655A810", Offset = "0x6559610", VA = "0x18655A810", Slot = "12")]
	public void LCBGGHBAEAG(Rigidbody EMNDMNOMIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x655A550", Offset = "0x6559350", VA = "0x18655A550", Slot = "13")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class MPDJGJFPPKN : EJPLDNPJPLM, GPDAHBNNHMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView FBKOKGALPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool JJGALCKGPPP;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView JIFJDDGHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool AAIJLENGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x655EAF0", Offset = "0x655D8F0", VA = "0x18655EAF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool JIGCIEEMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E7F0", VA = "0x18088F9F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event MIKBECLFJBF NGAOOEACHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6561150", Offset = "0x655FF50", VA = "0x186561150", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x65611F0", Offset = "0x655FFF0", VA = "0x1865611F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x6561900", Offset = "0x6560700", VA = "0x186561900")]
	public MPDJGJFPPKN(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x65617D0", Offset = "0x65605D0", VA = "0x1865617D0", Slot = "9")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x6561290", Offset = "0x6560090", VA = "0x186561290", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6561660", Offset = "0x6560460", VA = "0x186561660", Slot = "10")]
	public void OGGJIKHOGOI(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x6560D70", Offset = "0x655FB70", VA = "0x186560D70", Slot = "11")]
	public void CFIKMONJEFJ(JNIFIKAJIFG AJKCELPHOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x65614F0", Offset = "0x65602F0", VA = "0x1865614F0")]
	private void MIOAGIONDFI(PhotonView FACPIADECOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x6561390", Offset = "0x6560190", VA = "0x186561390")]
	private void IICACPLMNDJ(RigidbodyEx LNLEJFPPNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x6560EE0", Offset = "0x655FCE0", VA = "0x186560EE0")]
	private void CKEJFPKHGAJ(PhotonView OGFOBDFKFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class FCOCDGOJFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x65556E0", Offset = "0x65544E0", VA = "0x1865556E0")]
	public static EJPLDNPJPLM KFCNCBOPMEG(this JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class KBAFOPDHLJP : OEOFLJMCEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints CAJIGFCNKFE;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool EIMCIHBKPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xB0B720", Offset = "0xB0A520", VA = "0x180B0B720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F1B0", Offset = "0x3E3DFB0", VA = "0x183E3F1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool LONMNADJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xD50D50", Offset = "0xD4FB50", VA = "0x180D50D50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F1A0", Offset = "0x3E3DFA0", VA = "0x183E3F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints KJDGFBCFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x655E850", Offset = "0x655D650", VA = "0x18655E850", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x655E9B0", Offset = "0x655D7B0", VA = "0x18655E9B0")]
	public KBAFOPDHLJP(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x655E980", Offset = "0x655D780", VA = "0x18655E980", Slot = "9")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x655E820", Offset = "0x655D620", VA = "0x18655E820", Slot = "10")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class CMGLJKAFOOF : PNFIGMNBOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JNIFIKAJIFG NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float ALMIPBGDHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float LGAMILJNGKH;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float LAFGFHLMMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF010", Offset = "0x8CDE10", VA = "0x1808CF010", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x65522E0", Offset = "0x65510E0", VA = "0x1865522E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float FBLPIJCIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x94CB70", Offset = "0x94B970", VA = "0x18094CB70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x65523B0", Offset = "0x65511B0", VA = "0x1865523B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x65524D0", Offset = "0x65512D0", VA = "0x1865524D0")]
	public CMGLJKAFOOF(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6552480", Offset = "0x6551280", VA = "0x186552480", Slot = "8")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6552240", Offset = "0x6551040", VA = "0x186552240", Slot = "9")]
	public void BGIJMBCEBKE(Rigidbody EDIBDMMLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class AOPPCKBLAGE : OGNODMAJMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool GPKCAKJJNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool AGICOALGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int HDIGJPNKHEP;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6546660", Offset = "0x6545460", VA = "0x186546660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool IBBFCHGPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x65460B0", Offset = "0x6544EB0", VA = "0x1865460B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private JNIFIKAJIFG DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x65460E0", Offset = "0x6544EE0", VA = "0x1865460E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6546050", Offset = "0x6544E50", VA = "0x186546050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event MIKBECLFJBF DPIPNOEPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6546370", Offset = "0x6545170", VA = "0x186546370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x65466B0", Offset = "0x65454B0", VA = "0x1865466B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6546A10", Offset = "0x6545810", VA = "0x186546A10")]
	public AOPPCKBLAGE(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x65468E0", Offset = "0x65456E0", VA = "0x1865468E0", Slot = "6")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x65460D0", Offset = "0x6544ED0", VA = "0x1865460D0", Slot = "8")]
	public void FGNIGEKKLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6545F00", Offset = "0x6544D00", VA = "0x186545F00", Slot = "7")]
	public bool DCLANEKGGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6546970", Offset = "0x6545770", VA = "0x186546970", Slot = "9")]
	public void PHLPCGAAGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6546410", Offset = "0x6545210", VA = "0x186546410", Slot = "11")]
	public void KIHEPGKOBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6546140", Offset = "0x6544F40", VA = "0x186546140", Slot = "12")]
	public void GGCBDINGOMK(bool KFHMHOFNHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65464B0", Offset = "0x65452B0", VA = "0x1865464B0", Slot = "10")]
	public void LJFJCGEHNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6546190", Offset = "0x6544F90", VA = "0x186546190")]
	private bool IACDNFOEFGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6546750", Offset = "0x6545550", VA = "0x186546750")]
	private void NEMJDEEGLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class MHFKOHHJJMB : DJOGEADPCGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly HENOHJNKMME FCJGENNJKDO;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody CDDBDMLICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool IJNNDGOLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x656FF30", Offset = "0x656ED30", VA = "0x18656FF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool MDOIIMOBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xD024B0", Offset = "0xD012B0", VA = "0x180D024B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6570980", Offset = "0x656F780", VA = "0x186570980")]
	public MHFKOHHJJMB(JNIFIKAJIFG NPOMGMGDKBM, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6570610", Offset = "0x656F410", VA = "0x186570610", Slot = "5")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x656FB90", Offset = "0x656E990", VA = "0x18656FB90", Slot = "7")]
	public void CDPAFGMHMDL(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x65705E0", Offset = "0x656F3E0", VA = "0x1865705E0", Slot = "8")]
	public void MEKAPPHPEHP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x65706B0", Offset = "0x656F4B0", VA = "0x1865706B0", Slot = "9")]
	public void PKDLEPKDEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x656FBC0", Offset = "0x656E9C0", VA = "0x18656FBC0", Slot = "11")]
	public void CEJGAHDHJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x656FDB0", Offset = "0x656EBB0", VA = "0x18656FDB0", Slot = "12")]
	public void CJJPHHOIMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x65700D0", Offset = "0x656EED0", VA = "0x1865700D0", Slot = "10")]
	public void KPOIENHIAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x656FF50", Offset = "0x656ED50", VA = "0x18656FF50")]
	private void IPLEIPFKCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x656FA10", Offset = "0x656E810", VA = "0x18656FA10")]
	private void AHEPHPAFNAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class PJAAPPLDGAG : DHMGNKBAAIH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly BHJLHMHCLMK NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly HENOHJNKMME KAJLNNJDDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float OMFBLEBFAGC;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public MABPGHFPKBK DHCEONLHDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public FBNLPKHODPC GIGEDMEPAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 ILDEOJLDEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6570B70", Offset = "0x656F970", VA = "0x186570B70", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6571800", Offset = "0x6570600", VA = "0x186571800", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 KEODGJGMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6571710", Offset = "0x6570510", VA = "0x186571710", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x65715F0", Offset = "0x65703F0", VA = "0x1865715F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 IOMOENAEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x6571A60", Offset = "0x6570860", VA = "0x186571A60", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6571650", Offset = "0x6570450", VA = "0x186571650", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 HOCICGPNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6570DF0", Offset = "0x656FBF0", VA = "0x186570DF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x6571620", Offset = "0x6570420", VA = "0x186571620", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float BGIBBCLOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x800B50", Offset = "0x7FF950", VA = "0x180800B50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6571DA0", Offset = "0x6570BA0", VA = "0x186571DA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool FALJHNAANJO
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x16B2700", Offset = "0x16B1500", VA = "0x1816B2700", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private EHKMCJIAECG GAFHNIHPIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA990", Offset = "0x5EA9790", VA = "0x185EAA990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool IBBFCHGPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6556730", Offset = "0x6555530", VA = "0x186556730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x65739C0", Offset = "0x65727C0", VA = "0x1865739C0")]
	public PJAAPPLDGAG(JNIFIKAJIFG NPOMGMGDKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6571E50", Offset = "0x6570C50", VA = "0x186571E50", Slot = "19")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6571590", Offset = "0x6570390", VA = "0x186571590", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6572E60", Offset = "0x6571C60", VA = "0x186572E60", Slot = "28")]
	public void LCBGGHBAEAG(Rigidbody EDIBDMMLGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xB37720", Offset = "0xB36520", VA = "0x180B37720", Slot = "20")]
	public void AGKPFNNAENP(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xB38760", Offset = "0xB37560", VA = "0x180B38760", Slot = "30")]
	public void GKGKPIEJHCF(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6571420", Offset = "0x6570220", VA = "0x186571420", Slot = "35")]
	public Vector3 DOEACGJENFD(Vector3 MBJMJHACAHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6573100", Offset = "0x6571F00", VA = "0x186573100", Slot = "34")]
	public Vector3 NKJDHJECAPC(Vector3 MECEBMJGHLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6571E50", Offset = "0x6570C50", VA = "0x186571E50", Slot = "27")]
	public void KBEKNHHPGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x65729C0", Offset = "0x65717C0", VA = "0x1865729C0", Slot = "25")]
	public void KNJOKJCMBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6573960", Offset = "0x6572760", VA = "0x186573960", Slot = "24")]
	public void PJGEDJCLCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x65718C0", Offset = "0x65706C0", VA = "0x1865718C0", Slot = "33")]
	public void HGOCCCOLAFP(Vector3 ELEEKONLMFH, Vector3 HMLAEOLPEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x65730A0", Offset = "0x6571EA0", VA = "0x1865730A0", Slot = "32")]
	public void MKOHAJMDLJC(Vector3 OJMLAIAEILN, Vector3 DIPOODJFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6572F30", Offset = "0x6571D30", VA = "0x186572F30", Slot = "31")]
	public void LKFKPMIHMME(Vector3 DKBFOCHMODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6571F00", Offset = "0x6570D00", VA = "0x186571F00", Slot = "22")]
	public void KFLCKKLMJKK(DPLOONIGBAD PIIGMJFPGIL, Vector3 CPGKDIMJKNH, float GJKENCFKPNC, float NLEKMINJABO = 8f, float PLOJMLJCFCL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x65736D0", Offset = "0x65724D0", VA = "0x1865736D0", Slot = "21")]
	public void OLCEOMLDBPH(AEFHKHEJCCM OMANKENBGCC, Vector3 FNICFFEJGMF, float EILLNHEHEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6573250", Offset = "0x6572050", VA = "0x186573250", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void NMDKDKHDIFP(AEFHKHEJCCM OMANKENBGCC, Vector3 GJMDICOFEBG, float KCIODLPBAGO = 7f, float OCMEFBKENOB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6570C90", Offset = "0x656FA90", VA = "0x186570C90", Slot = "29")]
	public Vector3 BIHBJCCIEAK(Vector3 FEAOCKEGNIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6570A40", Offset = "0x656F840", VA = "0x186570A40", Slot = "26")]
	public void AMIJBFNEEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6571DA0", Offset = "0x6570BA0", VA = "0x186571DA0")]
	private void JNLJIFONGKG(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6571B80", Offset = "0x6570980", VA = "0x186571B80")]
	private void IKHEHALIBPL(Vector3 FNICFFEJGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x65735F0", Offset = "0x65723F0", VA = "0x1865735F0")]
	private Vector3 NPKJPOIMEHE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6570FC0", Offset = "0x656FDC0", VA = "0x186570FC0")]
	private void DGNPHHGFPIM(Vector3 MECEBMJGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6570EE0", Offset = "0x656FCE0", VA = "0x186570EE0")]
	private Vector3 DADKEEPOLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6572A20", Offset = "0x6571820", VA = "0x186572A20")]
	private void LBCGABLLHJC(Vector3 NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6572530", Offset = "0x6571330", VA = "0x186572530")]
	private void KNFLIHGLEFF(Vector3 MECEBMJGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6571CF0", Offset = "0x6570AF0", VA = "0x186571CF0")]
	private void JHKNGNFBLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EMNFKDNCOMA : HPOENFLBIFL
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x656F8A0", Offset = "0x656E6A0", VA = "0x18656F8A0", Slot = "4")]
	public NHGIDJKNFAL NGGFAGEODLD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x656F5D0", Offset = "0x656E3D0", VA = "0x18656F5D0", Slot = "5")]
	public DHMGNKBAAIH HONOCMLKCDN(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x656F9B0", Offset = "0x656E7B0", VA = "0x18656F9B0", Slot = "6")]
	public JEHGAGDGEEE PPKGHGBAIBP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x656F510", Offset = "0x656E310", VA = "0x18656F510", Slot = "7")]
	public PNFIGMNBOMO DOPJDLCHCJD(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x656F6B0", Offset = "0x656E4B0", VA = "0x18656F6B0", Slot = "8")]
	public OGNODMAJMMG IAPPHAAABGE(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x656F7E0", Offset = "0x656E5E0", VA = "0x18656F7E0", Slot = "9")]
	public IHHOELGMLAK KNLFGIOFOLP(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x656F350", Offset = "0x656E150", VA = "0x18656F350", Slot = "10")]
	public APKMGJGILDJ BECJEBOKJNJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x656F570", Offset = "0x656E370", VA = "0x18656F570", Slot = "11")]
	public EHKMCJIAECG HJJDBKFKEPJ(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x656F840", Offset = "0x656E640", VA = "0x18656F840", Slot = "12")]
	public NPDBKMIPJOC MIJIMEHMLON(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x656F710", Offset = "0x656E510", VA = "0x18656F710", Slot = "13")]
	public GGDAMBMLLEL INNJHDKJDAI(JNIFIKAJIFG HBHLLIKFPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x656F3B0", Offset = "0x656E1B0", VA = "0x18656F3B0")]
	public DJOGEADPCGL EOGLBPAPFMD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x656F270", Offset = "0x656E070", VA = "0x18656F270")]
	public GPDAHBNNHMD CGDDJPODGFD(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x656F2E0", Offset = "0x656E0E0", VA = "0x18656F2E0")]
	public CGLADKHONPG PIFPPOGIOPO(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x656F770", Offset = "0x656E570", VA = "0x18656F770")]
	public BHFAAMLNOOH MAMAMLLMFJH(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x656F4A0", Offset = "0x656E2A0", VA = "0x18656F4A0")]
	public OEOFLJMCEFM FMDAGBDDHCJ(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x656F900", Offset = "0x656E700", VA = "0x18656F900", Slot = "19")]
	public JNIFIKAJIFG PNCNBAFGHIH(RigidbodyEx NPOMGMGDKBM, HINAIMEEDAK OMHIFBJFAGA, KPGKLAGMOGC IEHBMNBOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EMNFKDNCOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x656F3B0", Offset = "0x656E1B0", VA = "0x18656F3B0", Slot = "14")]
	private DJOGEADPCGL BMNPFLCGBKP(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x656F270", Offset = "0x656E070", VA = "0x18656F270", Slot = "15")]
	private GPDAHBNNHMD AILHMKPGMFI(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x656F2E0", Offset = "0x656E0E0", VA = "0x18656F2E0", Slot = "16")]
	private CGLADKHONPG ANEFEFGEEOB(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x656F770", Offset = "0x656E570", VA = "0x18656F770", Slot = "17")]
	private BHFAAMLNOOH KFMKMDIKOMK(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x656F4A0", Offset = "0x656E2A0", VA = "0x18656F4A0", Slot = "18")]
	private OEOFLJMCEFM CKBJEJPGPKG(JNIFIKAJIFG HBHLLIKFPMD, [In] HINAIMEEDAK OMHIFBJFAGA)
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
