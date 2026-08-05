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
	public class LogRegistrationIndex : JEBMLOLOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6731050", Offset = "0x6730050", VA = "0x186731050", Slot = "4")]
		public override void PCEAKBMIBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
	public class _AssemblyIndex : GGAMJMDOFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HCDJNOEMFDF bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HCDJNOEMFDF bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6101500", Offset = "0x6100500", VA = "0x186101500", Slot = "5")]
		public override void FECPPHBOIKG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67429B0", Offset = "0x67419B0", VA = "0x1867429B0")]
		private void MMMABEIHAIP(LBOIHOEMEKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6742580", Offset = "0x6741580", VA = "0x186742580")]
		private void JKJFJAKLCJI(LBOIHOEMEKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6742390", Offset = "0x6741390", VA = "0x186742390", Slot = "6")]
		public override void BPJLBOBFIFD(LBOIHOEMEKD registry, [In] OFPCFOAIPIF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
		public override void PKDINHKFILI(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6742B20", Offset = "0x6741B20", VA = "0x186742B20")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void HHCCBDGDJEE(RigidbodyEx OFONBGJCOPF);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void GKBMLBEBNAB(RigidbodyEx OFONBGJCOPF, bool KIHKHFOPMAC = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FGKPNCIPHBC
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
public enum INNMPOLEDFD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GMAHCCPGLOO
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PMGKIFLEIJE(typeof(CFKCNBGKCLA), new string[] { "Ignore", "Mock" })]
public class AKIDPLPCLGC : CFKCNBGKCLA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HAIMFLDAKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80F210", Offset = "0x80E210", VA = "0x18080F210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
	public void JNKBNDHCDPI(string AIKAPCCDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void KNOFNEJNCOE(RigidbodyEx NKJKBALEEPO, Action DFHNKDINOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "7")]
	public PHPGHNNPJHJ INCMGFKOOMA(int GOEFADNGIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
	public void HKOLCLCOOAM(Vector3 OHFNJOBDPKH, float GNNDFMPEBHD, Color DDCPEHLFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AKIDPLPCLGC()
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
		private static readonly LPCGADPJIJD FPNPLMAGJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool FBIMFANKLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ILDIKLAHNAE PLCDBOCODGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[HEAANNMEKMO(HLBGFFAONPF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[HEAANNMEKMO(HLBGFFAONPF.SelfAndParent, true, false, false)]
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
		private INNMPOLEDFD physicsInterpolation;

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
		internal ILDIKLAHNAE JJPKIGPGLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x673D840", Offset = "0x673C840", VA = "0x18673D840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> AEADNLPNBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C1230", Offset = "0x7C0230", VA = "0x1807C1230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C1240", Offset = "0x7C0240", VA = "0x1807C1240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ELGAKAEPFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x673FA70", Offset = "0x673EA70", VA = "0x18673FA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NGBMMOKFIFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x673F9D0", Offset = "0x673E9D0", VA = "0x18673F9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MMPNPJILHCD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6740690", Offset = "0x673F690", VA = "0x186740690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6741C10", Offset = "0x6740C10", VA = "0x186741C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform GEADHHFGIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E47A0", Offset = "0x7E37A0", VA = "0x1807E47A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KFBNMALPNOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7E47A0", Offset = "0x7E37A0", VA = "0x1807E47A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FBEANLMFLHI CLFNNMHBMHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x673F790", Offset = "0x673E790", VA = "0x18673F790")]
			get
			{
				return default(FBEANLMFLHI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67413C0", Offset = "0x67403C0", VA = "0x1867413C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LGFCFPPBAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x673FD20", Offset = "0x673ED20", VA = "0x18673FD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EHCCBJBEPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x673F8B0", Offset = "0x673E8B0", VA = "0x18673F8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NKDEEAAMDMA BPAFPHPPKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x673FC60", Offset = "0x673EC60", VA = "0x18673FC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6741580", Offset = "0x6740580", VA = "0x186741580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AMIBEJPKIDH NDLMELBILOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x673FC00", Offset = "0x673EC00", VA = "0x18673FC00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6741510", Offset = "0x6740510", VA = "0x186741510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DLOKEIFCHBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x673FB50", Offset = "0x673EB50", VA = "0x18673FB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody ELABPCOIKPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x673FBB0", Offset = "0x673EBB0", VA = "0x18673FBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GIOOKLGEDIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x673F910", Offset = "0x673E910", VA = "0x18673F910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6741430", Offset = "0x6740430", VA = "0x186741430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CNNGMEMKGOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5F09950", Offset = "0x5F08950", VA = "0x185F09950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5F09250", Offset = "0x5F08250", VA = "0x185F09250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HNLAEKCCFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6740630", Offset = "0x673F630", VA = "0x186740630")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PPABFNHGLCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x67405D0", Offset = "0x673F5D0", VA = "0x1867405D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6741BA0", Offset = "0x6740BA0", VA = "0x186741BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GDHIJDDIABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x673FF80", Offset = "0x673EF80", VA = "0x18673FF80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6741820", Offset = "0x6740820", VA = "0x186741820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ANEBNAPLIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x673FD80", Offset = "0x673ED80", VA = "0x18673FD80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x67415F0", Offset = "0x67405F0", VA = "0x1867415F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EMFNDGEOCFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6740BF0", Offset = "0x673FBF0", VA = "0x186740BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6742170", Offset = "0x6741170", VA = "0x186742170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OIDCFCAABOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67403B0", Offset = "0x673F3B0", VA = "0x1867403B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6741970", Offset = "0x6740970", VA = "0x186741970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 OHFNJOBDPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6740D30", Offset = "0x673FD30", VA = "0x186740D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode EBOJEKPFKAE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x673FEC0", Offset = "0x673EEC0", VA = "0x18673FEC0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6741740", Offset = "0x6740740", VA = "0x186741740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float NDKCAILNKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x673F970", Offset = "0x673E970", VA = "0x18673F970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67414A0", Offset = "0x67404A0", VA = "0x1867414A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints EEKLAKLEJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x673FF20", Offset = "0x673EF20", VA = "0x18673FF20")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x67417B0", Offset = "0x67407B0", VA = "0x1867417B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MJNDFFBNNGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6740730", Offset = "0x673F730", VA = "0x186740730")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 BBLPJCAILJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6740730", Offset = "0x673F730", VA = "0x186740730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6741F50", Offset = "0x6740F50", VA = "0x186741F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PEGEMKMKKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6740490", Offset = "0x673F490", VA = "0x186740490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6741A50", Offset = "0x6740A50", VA = "0x186741A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LNNGKBAJIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6740B90", Offset = "0x673FB90", VA = "0x186740B90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6742100", Offset = "0x6741100", VA = "0x186742100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion DENLOOMDCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6740810", Offset = "0x673F810", VA = "0x186740810")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6741CD0", Offset = "0x6740CD0", VA = "0x186741CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BJGCHNMAADN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6740AB0", Offset = "0x673FAB0", VA = "0x186740AB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6742030", Offset = "0x6741030", VA = "0x186742030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 HBIIFDIEPBH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x67408F0", Offset = "0x673F8F0", VA = "0x1867408F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6741DA0", Offset = "0x6740DA0", VA = "0x186741DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion FAJEFDNJPMD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67409D0", Offset = "0x673F9D0", VA = "0x1867409D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6741E80", Offset = "0x6740E80", VA = "0x186741E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JKBHKGAJHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6740C50", Offset = "0x673FC50", VA = "0x186740C50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67421E0", Offset = "0x67411E0", VA = "0x1867421E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 GLKDHNFFAGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67404F0", Offset = "0x673F4F0", VA = "0x1867404F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6741AC0", Offset = "0x6740AC0", VA = "0x186741AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FPIFBDKIOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x673FDE0", Offset = "0x673EDE0", VA = "0x18673FDE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6741660", Offset = "0x6740660", VA = "0x186741660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KDNIBMMAEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x67402D0", Offset = "0x673F2D0", VA = "0x1867402D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6741890", Offset = "0x6740890", VA = "0x186741890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 DKAAPFIKAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6740190", Offset = "0x673F190", VA = "0x186740190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion FLIIALDLAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x67400B0", Offset = "0x673F0B0", VA = "0x1867400B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JHBEKBGDDEL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6740EF0", Offset = "0x673FEF0", VA = "0x186740EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 BPELDLCGCNE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6740E10", Offset = "0x673FE10", VA = "0x186740E10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ANGHKIGFLGN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6740270", Offset = "0x673F270", VA = "0x186740270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool EFLCFDDDAON
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x673FCC0", Offset = "0x673ECC0", VA = "0x18673FCC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KEFCOIAJLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x673F850", Offset = "0x673E850", VA = "0x18673F850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CCDOIBLCDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x673F7F0", Offset = "0x673E7F0", VA = "0x18673F7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JHPEODOFKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x673F730", Offset = "0x673E730", VA = "0x18673F730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JMLCOMGANOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x673FFE0", Offset = "0x673EFE0", VA = "0x18673FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BKDIPLKNCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x526A110", Offset = "0x5269110", VA = "0x18526A110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event HHCCBDGDJEE DFMHCPFMFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x673F650", Offset = "0x673E650", VA = "0x18673F650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67412E0", Offset = "0x67402E0", VA = "0x1867412E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GKBMLBEBNAB OCCLJNACOIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x673F5E0", Offset = "0x673E5E0", VA = "0x18673F5E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6741270", Offset = "0x6740270", VA = "0x186741270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HHCCBDGDJEE NBBPJKJCGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x673F340", Offset = "0x673E340", VA = "0x18673F340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6740FD0", Offset = "0x673FFD0", VA = "0x186740FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HHCCBDGDJEE IDBEGADGPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x673F3B0", Offset = "0x673E3B0", VA = "0x18673F3B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6741040", Offset = "0x6740040", VA = "0x186741040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HHCCBDGDJEE HMCFMAMNGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x673F500", Offset = "0x673E500", VA = "0x18673F500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6741190", Offset = "0x6740190", VA = "0x186741190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x673F490", Offset = "0x673E490", VA = "0x18673F490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6741120", Offset = "0x6740120", VA = "0x186741120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HHCCBDGDJEE LEAGCOILHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x673F570", Offset = "0x673E570", VA = "0x18673F570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6741200", Offset = "0x6740200", VA = "0x186741200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HHCCBDGDJEE ONIGFKGGEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x673F6C0", Offset = "0x673E6C0", VA = "0x18673F6C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6741350", Offset = "0x6740350", VA = "0x186741350")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event HHCCBDGDJEE DNKJFFEINAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x673F420", Offset = "0x673E420", VA = "0x18673F420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67410B0", Offset = "0x67400B0", VA = "0x1867410B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		internal void HJHHGJDIAOF(ILDIKLAHNAE GINEIDDJABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x673E3B0", Offset = "0x673D3B0", VA = "0x18673E3B0")]
		internal void MIOJMFHDCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x673F060", Offset = "0x673E060", VA = "0x18673F060")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody KDLGJLIJFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x673ED30", Offset = "0x673DD30", VA = "0x18673ED30")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) INBEAKEIFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x673D770", Offset = "0x673C770", VA = "0x18673D770")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x673D840", Offset = "0x673C840", VA = "0x18673D840")]
		private ILDIKLAHNAE COJNLMBDNPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x673DCF0", Offset = "0x673CCF0", VA = "0x18673DCF0")]
		private void IPDECBGGCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x673E500", Offset = "0x673D500", VA = "0x18673E500")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x673E3B0", Offset = "0x673D3B0", VA = "0x18673E3B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x673E4A0", Offset = "0x673D4A0", VA = "0x18673E4A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x673E560", Offset = "0x673D560", VA = "0x18673E560")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x673CE20", Offset = "0x673BE20", VA = "0x18673CE20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x673E5C0", Offset = "0x673D5C0", VA = "0x18673E5C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x673DA70", Offset = "0x673CA70", VA = "0x18673DA70")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x673E440", Offset = "0x673D440", VA = "0x18673E440")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x673EE90", Offset = "0x673DE90", VA = "0x18673EE90")]
		public void SetParent(RigidbodyEx CFJDHAGGAJO, bool KIHKHFOPMAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x673E8D0", Offset = "0x673D8D0", VA = "0x18673E8D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x673E080", Offset = "0x673D080", VA = "0x18673E080")]
		public bool IsRigidbodyAncestor(RigidbodyEx DJLJNNLHAAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x673E160", Offset = "0x673D160", VA = "0x18673E160")]
		public bool IsRigidbodyDescendant(RigidbodyEx MHEHDELMCEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x673D090", Offset = "0x673C090", VA = "0x18673D090")]
		public void AddInterpolationRestriction(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x673E630", Offset = "0x673D630", VA = "0x18673E630")]
		public void RemoveInterpolationRestriction(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x673D7E0", Offset = "0x673C7E0", VA = "0x18673D7E0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x673D100", Offset = "0x673C100", VA = "0x18673D100")]
		public void AddKinematic(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x673E6A0", Offset = "0x673D6A0", VA = "0x18673E6A0")]
		public void RemoveKinematic(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x673EE10", Offset = "0x673DE10", VA = "0x18673EE10")]
		public void SetKinematic(object OGACLNNOKDA, bool CPEKOFLDKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x673EC30", Offset = "0x673DC30", VA = "0x18673EC30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OIOPFELBMPK, Quaternion NJEPNFJOJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x673EB30", Offset = "0x673DB30", VA = "0x18673EB30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MCFCAELGDGE, Quaternion LMGNFDMIBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x673DBE0", Offset = "0x673CBE0", VA = "0x18673DBE0")]
		public Vector3 GetConstrainedVelocity(Vector3 JKBHKGAJHBA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x673DAD0", Offset = "0x673CAD0", VA = "0x18673DAD0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FPIFBDKIOIN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x673CFA0", Offset = "0x673BFA0", VA = "0x18673CFA0")]
		public void AddForce(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x673CE90", Offset = "0x673BE90", VA = "0x18673CE90")]
		public void AddForceAtPosition(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x673D2D0", Offset = "0x673C2D0", VA = "0x18673D2D0")]
		public void AddTorque(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x673D170", Offset = "0x673C170", VA = "0x18673D170")]
		public void AddRelativeTorque(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x673F130", Offset = "0x673E130", VA = "0x18673F130")]
		public Vector3 WorldToLocalVelocity(Vector3 OAHPAFLLLDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x673E2A0", Offset = "0x673D2A0", VA = "0x18673E2A0")]
		public Vector3 LocalToWorldVelocity(Vector3 GLKDHNFFAGC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x673DA10", Offset = "0x673CA10", VA = "0x18673DA10")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x673D9B0", Offset = "0x673C9B0", VA = "0x18673D9B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x673D950", Offset = "0x673C950", VA = "0x18673D950")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x673D8F0", Offset = "0x673C8F0", VA = "0x18673D8F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x673EA30", Offset = "0x673DA30", VA = "0x18673EA30")]
		public void ResetVelocityWorldSpace(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x673E930", Offset = "0x673D930", VA = "0x18673E930")]
		public void ResetVelocityLocalSpace(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x673E7F0", Offset = "0x673D7F0", VA = "0x18673E7F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 MIMCMCHALAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x673EFC0", Offset = "0x673DFC0", VA = "0x18673EFC0")]
		public bool SweepTest(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x673E240", Offset = "0x673D240", VA = "0x18673E240")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x673EF60", Offset = "0x673DF60", VA = "0x18673EF60")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x673F0D0", Offset = "0x673E0D0", VA = "0x18673F0D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x673D260", Offset = "0x673C260", VA = "0x18673D260")]
		public void AddShouldHaveUnityRigidbodyToken(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x673E710", Offset = "0x673D710", VA = "0x18673E710")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x673D600", Offset = "0x673C600", VA = "0x18673D600")]
		public void ApplyForceVelocityChange(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x673D560", Offset = "0x673C560", VA = "0x18673D560")]
		public void ApplyAngularVelocityChange(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x673D6C0", Offset = "0x673C6C0", VA = "0x18673D6C0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x673D490", Offset = "0x673C490", VA = "0x18673D490")]
		public bool AllowedScaleChange(float PDPMLJHIDGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x673D3C0", Offset = "0x673C3C0", VA = "0x18673D3C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OEIBPBCPKHH, object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x673E780", Offset = "0x673D780", VA = "0x18673E780")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x673F2D0", Offset = "0x673E2D0", VA = "0x18673F2D0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class PBHPEEFHKBL
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x673B1D0", Offset = "0x673A1D0", VA = "0x18673B1D0")]
	public static ILDIKLAHNAE JJPKIGPGLFE(this RigidbodyEx NKJKBALEEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MMNBKIDMPFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody CODNGEHPHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView HHGGIPAKDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 JGKCLNJJNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 NMLADDAKKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public INNMPOLEDFD LGOPBFADNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool HLCFMOAAMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool NIMHHDGHJEB;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PMGKIFLEIJE(typeof(ABCMFLEOCJP), new string[] { })]
public class OEGOCALPNKG : ABCMFLEOCJP, NIFPNAPKKPN
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MLNEHNEPPFF FPLDGHOIHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private CFKCNBGKCLA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OGAAPOKMDEM MLIEHIEAADC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CFKCNBGKCLA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OGAAPOKMDEM LOJOBJHEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x673A000", Offset = "0x6739000", VA = "0x18673A000", Slot = "8")]
	public void InitReferences(PAOGDAFANAL OEMCDBOBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6739D50", Offset = "0x6738D50", VA = "0x186739D50", Slot = "6")]
	public LAIJBGHHNPC FMNKNENPPCA(RigidbodyEx NKJKBALEEPO)
	{
		return default(LAIJBGHHNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6739C80", Offset = "0x6738C80", VA = "0x186739C80")]
	private static LAIJBGHHNPC ECKFOGPFEDK(RigidbodyEx NKJKBALEEPO)
	{
		return default(LAIJBGHHNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6739BE0", Offset = "0x6738BE0", VA = "0x186739BE0", Slot = "7")]
	public ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public OEGOCALPNKG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static LHMMLLGDOFK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int HGMOCPDOADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int CPHPCGDMCLA;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x673CC80", Offset = "0x673BC80", VA = "0x18673CC80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x673CCC0", Offset = "0x673BCC0", VA = "0x18673CCC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x673CCA0", Offset = "0x673BCA0", VA = "0x18673CCA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DFJKCKBFLAD, [Optional] UnityEngine.Object LNLKAOCIPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DFJKCKBFLAD, [Optional] UnityEngine.Object LNLKAOCIPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x673CDD0", Offset = "0x673BDD0", VA = "0x18673CDD0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PEDGINJLJFL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x673C2D0", Offset = "0x673B2D0", VA = "0x18673C2D0")]
	public static void NGOKFKIHPOL(this Rigidbody KDLGJLIJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x673C1A0", Offset = "0x673B1A0", VA = "0x18673C1A0")]
	public static void NGOKFKIHPOL(this Rigidbody KDLGJLIJFKC, Vector3 CLBAEKDDNDL, Quaternion FLIIALDLAEA, Vector3 MCPOEIOEBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xCC6C00", Offset = "0xCC5C00", VA = "0x180CC6C00")]
	public static void MIBFLGHBEKE(Vector3 JKBHKGAJHBA, Vector3 JEPJKJIDLAI, [Out] Vector3 HNDPFBKNAPL, [Out] Vector3 COBPJODFFKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CLLEMAKAIOI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class KPNEICKAIII : NKDEEAAMDMA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CA990", VA = "0x1807CB990", Slot = "4")]
		public Vector3 CIBJPGFNDBJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CB990", Offset = "0x7CA990", VA = "0x1807CB990", Slot = "5")]
		public Vector3 JCCKHKJNFME()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KPNEICKAIII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static NKDEEAAMDMA GHMEGKFBGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6720060", Offset = "0x671F060", VA = "0x186720060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PIIJCHPHOFC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode NNCACAIIGGG
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
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APNHNOKKPPN(bool ANGHKIGFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEAKPMIBGEM(bool ANGHKIGFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LDFNINBNHKI : IDisposable, HOEIBBBDECC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPKNANEJOGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PFJACEDCDHI(DIENCAJKNHD.Application)]
public interface OGAAPOKMDEM
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKJIHJLLPCC PDGNDPNABDC(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIMEDLCKGGP MMIFGHICLDF(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEDBDICJFMB DFKLNAKHLKD(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJJOJJLMDHA ANABDHKOBLP(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHNPGMILOFB EGELLNKBJLK(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LDFNINBNHKI HBKAKEIBKMJ(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLNHEKLDBHN JJMDGGIHJAE(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AFHCMCCOEML CPFFPEAMBOL(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PIIJCHPHOFC FMOKPDJEHBN(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JPOIHLJEDKK DAAJHLKLIHF(ILDIKLAHNAE GINEIDDJABE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MIBKGKEEDAB EMLGCECJHAH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BAJHLENBDPO AGNFFPPGGKK(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LHIDLBLFPCN BEHNJGFMDBB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OGAIKCGLNBJ OKNBELHPCCC(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PKJAODKDPEK OEFDJKLCOEB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI, ABCMFLEOCJP JDIOCIOLNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AFHCMCCOEML
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JPOIHLJEDKK
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GBKGDPPBLGA
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
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FECOAHNCAJE(Rigidbody CODNGEHPHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKJIHJLLPCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HHCCBDGDJEE NBBPJKJCGDP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event HHCCBDGDJEE IDBEGADGPLB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GKBMLBEBNAB GPHDEBALPIN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EKIMBIFFPIE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action FEGLEGKIHDO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ILDIKLAHNAE> AEFDNNANEOK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<ILDIKLAHNAE> KCGIMADPLGN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action DNDKJHFOHIM;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ILDIKLAHNAE> BGOLEFCIPKE;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JACMFKHLBGF(ILDIKLAHNAE DIMMPCLNOKP, bool KIHKHFOPMAC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JEDBDICJFMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAMCKFIDFGA(ILDIKLAHNAE MMPNPJILHCD, object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLFPGPILPNC(object OGACLNNOKDA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OGAIKCGLNBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HHCCBDGDJEE OCMJCNDOMKI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FNOPPMCNOFC();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JBFAOBEPMNP();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICDKKPLHEHH();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FECOAHNCAJE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HKPOMGHDOMN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LHIDLBLFPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGEMAAAOJBA(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCGDPIODJJM(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJDBJIIKLAH(ILDIKLAHNAE NKJKBALEEPO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECAPICMDCPE(ILDIKLAHNAE NKJKBALEEPO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BJPJHCKMCOL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LLNHEKLDBHN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HHCCBDGDJEE GAOOFNAHMCE;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLICLOIFIKH();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKDAFPEPHEB(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJLNPAECEJJ(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable HNLDFFOBHDE();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NLGFKGKOAEE(Rigidbody GIOJGBHHAFL);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FECOAHNCAJE(Rigidbody CODNGEHPHPK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BAJHLENBDPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HHCCBDGDJEE GEEBKGBDOAD;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDCIKMGKMOL(ILDIKLAHNAE MMPNPJILHCD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOCHBIPJNMJ(ILDIKLAHNAE MMPNPJILHCD);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PKJAODKDPEK
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CKIDBDMBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints CDFDPCCNCCB
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
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FECOAHNCAJE(Rigidbody CODNGEHPHPK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NJJOJJLMDHA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float KIMJDLKEBGE
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
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FECOAHNCAJE(Rigidbody CODNGEHPHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NIDIIMFOADF
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx FBCJMMKCLGD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LHNPGMILOFB
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event HHCCBDGDJEE KGAAGDPJGMC;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBKIMDDEKHM();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHJJJFJLHNM();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLAKGKFOOEN();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BFOPBGOCLAN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PNNBKBPGHDG();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMNFOBBGJMI(bool ONAEAHOIGFP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MIBKGKEEDAB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool CJLLIIAHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKEGMLMFEBP(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKNNLFNCMBE(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BILHKELEOJJ();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNNILOOKCBD();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EIMEDLCKGGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PLCOEMDJPIG(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GICLCPMKNNI();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HGEENGLFPON();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HIMGANPJKGM();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IAIKOJBEKPC();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NLGFKGKOAEE(Rigidbody CODNGEHPHPK);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 CLHAALPDBMF(Vector3 JKBHKGAJHBA);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FFHGKAJGJPF(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KJIIOMDLAFE(Vector3 CNDIDFEDOBL);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PFJACEDCDHI(DIENCAJKNHD.Application)]
public interface CFKCNBGKCLA
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HAIMFLDAKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNKBNDHCDPI(string AIKAPCCDDEJ);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNOFNEJNCOE(RigidbodyEx NKJKBALEEPO, Action DFHNKDINOMO);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHPGHNNPJHJ INCMGFKOOMA(int GOEFADNGIKA);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKOLCLCOOAM(Vector3 OHFNJOBDPKH, float GNNDFMPEBHD, Color DDCPEHLFHPM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PFJACEDCDHI(DIENCAJKNHD.Application)]
public interface ABCMFLEOCJP
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	CFKCNBGKCLA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	OGAAPOKMDEM LOJOBJHEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LAIJBGHHNPC FMNKNENPPCA(RigidbodyEx NKJKBALEEPO);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AMIBEJPKIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLBLDBLKKCL(Vector3 FBBHMKKDNFJ);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMNNFPJPBDL(Vector3 FPIFBDKIOIN);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGKCDENHGBI(Vector3 FBBHMKKDNFJ);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NEBBOLLMBDH(Vector3 FPIFBDKIOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NKDEEAAMDMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 CIBJPGFNDBJ();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JCCKHKJNFME();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ILDIKLAHNAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx BLMDDMHBGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject NGDMKBHFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool CCDOIBLCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool JHPEODOFKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float KIMJDLKEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool GBKGDPPBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform KFBNMALPNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 HLMHEKKPFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float CDCKOGHODLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float MAAOOCMICEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion DHOEKPALDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 DANHCCHNLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion MDCBKNMNABN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints CDFDPCCNCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode NNCACAIIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool EFLCFDDDAON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event HHCCBDGDJEE NBBPJKJCGDP;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event HHCCBDGDJEE IDBEGADGPLB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GKBMLBEBNAB GPHDEBALPIN;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event HHCCBDGDJEE GEEBKGBDOAD;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event HHCCBDGDJEE HMCFMAMNGBN;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event HHCCBDGDJEE KGAAGDPJGMC;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event HHCCBDGDJEE GAOOFNAHMCE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event HHCCBDGDJEE DNKJFFEINAM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void PICGDOIPKKE();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JGEMNFFJBHM();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void PLAKGKFOOEN();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void JACMFKHLBGF(ILDIKLAHNAE CFJDHAGGAJO, bool KIHKHFOPMAC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void EOHFPLCBMFJ(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void KEPLFMNEALP(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void IAIKOJBEKPC();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void HGEENGLFPON();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void GICLCPMKNNI();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void KJIIOMDLAFE(Vector3 CNDIDFEDOBL);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 CLHAALPDBMF(Vector3 CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 BPGFIBAOILA(Vector3 CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void HIMGANPJKGM();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void FOHDEPGNJNG(ILDIKLAHNAE OEIBPBCPKHH, object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void MCLDDMKEKKH(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JBFAOBEPMNP();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FNOPPMCNOFC();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void ICDKKPLHEHH();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DBKIMDDEKHM();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void PNNBKBPGHDG();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable HNLDFFOBHDE();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EKDAFPEPHEB(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void MJLNPAECEJJ(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void KNCAMPJIGDD(Vector3 OIOPFELBMPK, Quaternion NJEPNFJOJIP);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void DOMIBHLKHCK(Vector3 MCFCAELGDGE, Quaternion LMGNFDMIBIL);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool EBHNOFONFDC(float PDPMLJHIDGN);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LAJLFDHMNFC(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void ONOMKFICDHP(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void DKEGMLMFEBP(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void DKNNLFNCMBE(object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void HKPOMGHDOMN();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JAOIINDNBLA : ILDIKLAHNAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly ABCMFLEOCJP JDIOCIOLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal OKJIHJLLPCC HFNBIIGEMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal LHIDLBLFPCN FIODACEFEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal BAJHLENBDPO LIFOFKHKGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal EIMEDLCKGGP JKBHKGAJHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal JEDBDICJFMB APFKNOBECNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal OGAIKCGLNBJ ABGHFFHOPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NJJOJJLMDHA FEBAKEMICBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal JPOIHLJEDKK NHHFJBBHHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal LHNPGMILOFB CEOGPOLCJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal LDFNINBNHKI DGGNGADAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal LLNHEKLDBHN PJKGBPDMPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal AFHCMCCOEML GCPGMMGNKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PKJAODKDPEK ODGHAJMDCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal MIBKGKEEDAB CODNGEHPHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal PIIJCHPHOFC KFCJDANCJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable GACLCEEGKAM;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx BLMDDMHBGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0170", Offset = "0x7BF170", VA = "0x1807C0170", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0130", Offset = "0x7BF130", VA = "0x1807C0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject NGDMKBHFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8828F0", Offset = "0x8818F0", VA = "0x1808828F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x882A10", Offset = "0x881A10", VA = "0x180882A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x672FEE0", Offset = "0x672EEE0", VA = "0x18672FEE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6730210", Offset = "0x672F210", VA = "0x186730210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x672C810", Offset = "0x672B810", VA = "0x18672C810", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x672F270", Offset = "0x672E270", VA = "0x18672F270", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x672E260", Offset = "0x672D260", VA = "0x18672E260", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x672BAB0", Offset = "0x672AAB0", VA = "0x18672BAB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x672CCB0", Offset = "0x672BCB0", VA = "0x18672CCB0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x672C1F0", Offset = "0x672B1F0", VA = "0x18672C1F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x672DB40", Offset = "0x672CB40", VA = "0x18672DB40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x672ACF0", Offset = "0x6729CF0", VA = "0x18672ACF0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x672CB40", Offset = "0x672BB40", VA = "0x18672CB40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x672C900", Offset = "0x672B900", VA = "0x18672C900", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6730050", Offset = "0x672F050", VA = "0x186730050", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x672CAF0", Offset = "0x672BAF0", VA = "0x18672CAF0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x672F500", Offset = "0x672E500", VA = "0x18672F500", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x672B380", Offset = "0x672A380", VA = "0x18672B380", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x672B190", Offset = "0x672A190", VA = "0x18672B190", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x672EFF0", Offset = "0x672DFF0", VA = "0x18672EFF0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x672F190", Offset = "0x672E190", VA = "0x18672F190", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x672FE00", Offset = "0x672EE00", VA = "0x18672FE00", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x672C240", Offset = "0x672B240", VA = "0x18672C240", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x672F3C0", Offset = "0x672E3C0", VA = "0x18672F3C0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x672D710", Offset = "0x672C710", VA = "0x18672D710", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool KEFCOIAJLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x672BEF0", Offset = "0x672AEF0", VA = "0x18672BEF0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CCDOIBLCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x672C190", Offset = "0x672B190", VA = "0x18672C190", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JHPEODOFKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x672CD10", Offset = "0x672BD10", VA = "0x18672CD10", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x672FAD0", Offset = "0x672EAD0", VA = "0x18672FAD0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x672E810", Offset = "0x672D810", VA = "0x18672E810", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x672E8E0", Offset = "0x672D8E0", VA = "0x18672E8E0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x672C5F0", Offset = "0x672B5F0", VA = "0x18672C5F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x672DB90", Offset = "0x672CB90", VA = "0x18672DB90", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x672D580", Offset = "0x672C580", VA = "0x18672D580", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x672D6C0", Offset = "0x672C6C0", VA = "0x18672D6C0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x672F370", Offset = "0x672E370", VA = "0x18672F370", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x672F7E0", Offset = "0x672E7E0", VA = "0x18672F7E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x672E6D0", Offset = "0x672D6D0", VA = "0x18672E6D0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x672C4B0", Offset = "0x672B4B0", VA = "0x18672C4B0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x672C380", Offset = "0x672B380", VA = "0x18672C380", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x67300B0", Offset = "0x672F0B0", VA = "0x1867300B0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KIMJDLKEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x672B270", Offset = "0x672A270", VA = "0x18672B270", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x672C9C0", Offset = "0x672B9C0", VA = "0x18672C9C0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool GBKGDPPBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x67302C0", Offset = "0x672F2C0", VA = "0x1867302C0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x672C070", Offset = "0x672B070", VA = "0x18672C070", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x672AFD0", Offset = "0x6729FD0", VA = "0x18672AFD0", Slot = "48")]
		get
		{
			return default(JHOHKNNGDMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x672B320", Offset = "0x672A320", VA = "0x18672B320", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x672D7F0", Offset = "0x672C7F0", VA = "0x18672D7F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform KFBNMALPNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x672AFC0", Offset = "0x6729FC0", VA = "0x18672AFC0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 HLMHEKKPFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x672E9C0", Offset = "0x672D9C0", VA = "0x18672E9C0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x672D310", Offset = "0x672C310", VA = "0x18672D310", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float CDCKOGHODLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x672CA20", Offset = "0x672BA20", VA = "0x18672CA20", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x672AF20", Offset = "0x6729F20", VA = "0x18672AF20", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float MAAOOCMICEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6730AF0", Offset = "0x672FAF0", VA = "0x186730AF0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x672F5B0", Offset = "0x672E5B0", VA = "0x18672F5B0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion DHOEKPALDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x672FC10", Offset = "0x672EC10", VA = "0x18672FC10", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x672B800", Offset = "0x672A800", VA = "0x18672B800", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 DANHCCHNLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x672F560", Offset = "0x672E560", VA = "0x18672F560", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x672CE40", Offset = "0x672BE40", VA = "0x18672CE40", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion MDCBKNMNABN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x672DC70", Offset = "0x672CC70", VA = "0x18672DC70", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6730960", Offset = "0x672F960", VA = "0x186730960", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CDFDPCCNCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x672C8B0", Offset = "0x672B8B0", VA = "0x18672C8B0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x672C0D0", Offset = "0x672B0D0", VA = "0x18672C0D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x67309A0", Offset = "0x672F9A0", VA = "0x1867309A0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x672F0D0", Offset = "0x672E0D0", VA = "0x18672F0D0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode NNCACAIIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x672E090", Offset = "0x672D090", VA = "0x18672E090", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x672D660", Offset = "0x672C660", VA = "0x18672D660", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CEACOEPNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x672F840", Offset = "0x672E840", VA = "0x18672F840", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool EFLCFDDDAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x672AD40", Offset = "0x6729D40", VA = "0x18672AD40", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MOLMJIJKJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x672E0E0", Offset = "0x672D0E0", VA = "0x18672E0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool KHDAINOIIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x672AF90", Offset = "0x6729F90", VA = "0x18672AF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HHCCBDGDJEE NBBPJKJCGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x672E470", Offset = "0x672D470", VA = "0x18672E470", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x672C6D0", Offset = "0x672B6D0", VA = "0x18672C6D0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HHCCBDGDJEE IDBEGADGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x672CA40", Offset = "0x672BA40", VA = "0x18672CA40", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x672D9E0", Offset = "0x672C9E0", VA = "0x18672D9E0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GKBMLBEBNAB GPHDEBALPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x672AEC0", Offset = "0x6729EC0", VA = "0x18672AEC0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x672CC50", Offset = "0x672BC50", VA = "0x18672CC50", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event HHCCBDGDJEE GEEBKGBDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x672D960", Offset = "0x672C960", VA = "0x18672D960", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x672B7A0", Offset = "0x672A7A0", VA = "0x18672B7A0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event HHCCBDGDJEE HMCFMAMNGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6730310", Offset = "0x672F310", VA = "0x186730310", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x672E030", Offset = "0x672D030", VA = "0x18672E030", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event HHCCBDGDJEE KGAAGDPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x672D8B0", Offset = "0x672C8B0", VA = "0x18672D8B0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x672B560", Offset = "0x672A560", VA = "0x18672B560", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x672F780", Offset = "0x672E780", VA = "0x18672F780", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x672B2C0", Offset = "0x672A2C0", VA = "0x18672B2C0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event HHCCBDGDJEE GAOOFNAHMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x672AC90", Offset = "0x6729C90", VA = "0x18672AC90", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6730A40", Offset = "0x672FA40", VA = "0x186730A40", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event HHCCBDGDJEE DNKJFFEINAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x672B0E0", Offset = "0x672A0E0", VA = "0x18672B0E0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6730540", Offset = "0x672F540", VA = "0x186730540", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6721B30", Offset = "0x6720B30", VA = "0x186721B30")]
	public JAOIINDNBLA(GameObject LNIPGKDIFCK, RigidbodyEx BFCPFHLOEPG, ABCMFLEOCJP JDIOCIOLNIG, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x672CEE0", Offset = "0x672BEE0", VA = "0x18672CEE0", Slot = "135")]
	protected virtual void HKJIDHJDLLA(ABCMFLEOCJP JDIOCIOLNIG, MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x672BF40", Offset = "0x672AF40", VA = "0x18672BF40", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x672FCC0", Offset = "0x672ECC0", VA = "0x18672FCC0", Slot = "71")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x672D270", Offset = "0x672C270", VA = "0x18672D270", Slot = "72")]
	public void PICGDOIPKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x672D9C0", Offset = "0x672C9C0", VA = "0x18672D9C0", Slot = "73")]
	public void JGEMNFFJBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x672F980", Offset = "0x672E980", VA = "0x18672F980")]
	private void NKNAKIMNIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x672D840", Offset = "0x672C840", VA = "0x18672D840", Slot = "81")]
	public void JACMFKHLBGF(ILDIKLAHNAE CFJDHAGGAJO, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x672C320", Offset = "0x672B320", VA = "0x18672C320", Slot = "84")]
	public void EOHFPLCBMFJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x672DCB0", Offset = "0x672CCB0", VA = "0x18672DCB0", Slot = "85")]
	public void KEPLFMNEALP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x672DA40", Offset = "0x672CA40", VA = "0x18672DA40", Slot = "86")]
	public Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6730110", Offset = "0x672F110", VA = "0x186730110", Slot = "87")]
	public Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x672D270", Offset = "0x672C270", VA = "0x18672D270", Slot = "88")]
	public void IAIKOJBEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x672CDF0", Offset = "0x672BDF0", VA = "0x18672CDF0", Slot = "89")]
	public void HGEENGLFPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x672CAA0", Offset = "0x672BAA0", VA = "0x18672CAA0", Slot = "90")]
	public void GICLCPMKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6730450", Offset = "0x672F450", VA = "0x186730450", Slot = "91")]
	public void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x672FB20", Offset = "0x672EB20", VA = "0x18672FB20", Slot = "92")]
	public void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x672E180", Offset = "0x672D180", VA = "0x18672E180", Slot = "93")]
	public void KJIIOMDLAFE(Vector3 CNDIDFEDOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x672B020", Offset = "0x672A020", VA = "0x18672B020", Slot = "94")]
	public void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x672FA30", Offset = "0x672EA30", VA = "0x18672FA30", Slot = "95")]
	public void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x672CBA0", Offset = "0x672BBA0", VA = "0x18672CBA0", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x672B6A0", Offset = "0x672A6A0", VA = "0x18672B6A0", Slot = "97")]
	public Vector3 CLHAALPDBMF(Vector3 CFJDHAGGAJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x672B460", Offset = "0x672A460", VA = "0x18672B460", Slot = "98")]
	public Vector3 BPGFIBAOILA(Vector3 CFJDHAGGAJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x672CE90", Offset = "0x672BE90", VA = "0x18672CE90", Slot = "99")]
	public void HIMGANPJKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x672C950", Offset = "0x672B950", VA = "0x18672C950", Slot = "100")]
	public void FOHDEPGNJNG(ILDIKLAHNAE OEIBPBCPKHH, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x672F130", Offset = "0x672E130", VA = "0x18672F130", Slot = "101")]
	public void MCLDDMKEKKH(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x672FF70", Offset = "0x672EF70", VA = "0x18672FF70", Slot = "41")]
	public void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x672D910", Offset = "0x672C910", VA = "0x18672D910", Slot = "104")]
	public void JBFAOBEPMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x672C860", Offset = "0x672B860", VA = "0x18672C860", Slot = "105")]
	public void FNOPPMCNOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x672D2C0", Offset = "0x672C2C0", VA = "0x18672D2C0", Slot = "106")]
	public void ICDKKPLHEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x672B8F0", Offset = "0x672A8F0", VA = "0x18672B8F0", Slot = "109")]
	public bool DBKIMDDEKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67309F0", Offset = "0x672F9F0", VA = "0x1867309F0", Slot = "74")]
	public void PLAKGKFOOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6730AA0", Offset = "0x672FAA0", VA = "0x186730AA0", Slot = "110")]
	public void PNNBKBPGHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x672D220", Offset = "0x672C220", VA = "0x18672D220", Slot = "115")]
	public IDisposable HNLDFFOBHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x672C130", Offset = "0x672B130", VA = "0x18672C130", Slot = "116")]
	public void EKDAFPEPHEB(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x672F4A0", Offset = "0x672E4A0", VA = "0x18672F4A0", Slot = "117")]
	public void MJLNPAECEJJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x672C580", Offset = "0x672B580", VA = "0x18672C580", Slot = "118")]
	public void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x672E4D0", Offset = "0x672D4D0", VA = "0x18672E4D0", Slot = "121")]
	public void KNCAMPJIGDD(Vector3 OIOPFELBMPK, Quaternion NJEPNFJOJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x672BDA0", Offset = "0x672ADA0", VA = "0x18672BDA0", Slot = "122")]
	public void DOMIBHLKHCK(Vector3 MCFCAELGDGE, Quaternion LMGNFDMIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x672C010", Offset = "0x672B010", VA = "0x18672C010", Slot = "123")]
	public bool EBHNOFONFDC(float PDPMLJHIDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x672E7B0", Offset = "0x672D7B0", VA = "0x18672E7B0", Slot = "124")]
	public void LAJLFDHMNFC(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6730260", Offset = "0x672F260", VA = "0x186730260", Slot = "125")]
	public void ONOMKFICDHP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x672BB00", Offset = "0x672AB00", VA = "0x18672BB00", Slot = "126")]
	public void DKEGMLMFEBP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x672BB60", Offset = "0x672AB60", VA = "0x18672BB60", Slot = "127")]
	public void DKNNLFNCMBE(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x672C730", Offset = "0x672B730", VA = "0x18672C730", Slot = "128")]
	public void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x672EC60", Offset = "0x672DC60", VA = "0x18672EC60", Slot = "129")]
	public void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x672C3D0", Offset = "0x672B3D0", VA = "0x18672C3D0", Slot = "130")]
	public void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6730370", Offset = "0x672F370", VA = "0x186730370", Slot = "131")]
	public void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x672F2D0", Offset = "0x672E2D0", VA = "0x18672F2D0", Slot = "132")]
	public bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x672D1D0", Offset = "0x672C1D0", VA = "0x18672D1D0", Slot = "133")]
	public void HKPOMGHDOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6730B10", Offset = "0x672FB10", VA = "0x186730B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x672B5C0", Offset = "0x672A5C0", VA = "0x18672B5C0")]
	private void CHELCPPIGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x672ED70", Offset = "0x672DD70", VA = "0x18672ED70")]
	private void LLJPLKEJEAC(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x672EA70", Offset = "0x672DA70", VA = "0x18672EA70")]
	private void LHNBDDDGFMK(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x672D3D0", Offset = "0x672C3D0", VA = "0x18672D3D0")]
	private void IGPJDBILKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x672D480", Offset = "0x672C480", VA = "0x18672D480")]
	private void IIDLGALDJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x672BBC0", Offset = "0x672ABC0", VA = "0x18672BBC0")]
	private void DLBCOOEOKEO(ILDIKLAHNAE LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x672F6B0", Offset = "0x672E6B0", VA = "0x18672F6B0")]
	private void NDCIKMGKMOL(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x672EE80", Offset = "0x672DE80", VA = "0x18672EE80")]
	private void LOCHBIPJNMJ(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x672B940", Offset = "0x672A940", VA = "0x18672B940")]
	private void DBPDKJKHPOB(RigidbodyEx MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x672E2B0", Offset = "0x672D2B0", VA = "0x18672E2B0", Slot = "140")]
	protected virtual void KMLECOIMNIL(RigidbodyEx NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x672DD10", Offset = "0x672CD10", VA = "0x18672DD10")]
	protected void KGEFFBLLBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x67305F0", Offset = "0x672F5F0", VA = "0x1867305F0")]
	protected void PFBIPDBHKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x672EF50", Offset = "0x672DF50", VA = "0x18672EF50", Slot = "141")]
	protected virtual IDisposable LONEJJHMEAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class ABIFNGCMPFE
{
	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x671AC50", Offset = "0x6719C50", VA = "0x18671AC50")]
	public static ILDIKLAHNAE HJHHNLAFFMM(this ILDIKLAHNAE NKJKBALEEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x671AD00", Offset = "0x6719D00", VA = "0x18671AD00")]
	public static bool NCJIOKEDGDE(this ILDIKLAHNAE NKJKBALEEPO, ILDIKLAHNAE DJLJNNLHAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x671AB00", Offset = "0x6719B00", VA = "0x18671AB00")]
	public static bool BGKKBKEHAPH(this ILDIKLAHNAE NKJKBALEEPO, ILDIKLAHNAE MHEHDELMCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x671AB80", Offset = "0x6719B80", VA = "0x18671AB80")]
	public static RigidbodyEx BLMDDMHBGNN(this ILDIKLAHNAE JJPKIGPGLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x671ABD0", Offset = "0x6719BD0", VA = "0x18671ABD0")]
	public static JAOIINDNBLA EEHODHAJIFB(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class GNABANHJCFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x67289F0", Offset = "0x67279F0", VA = "0x1867289F0")]
	public GNABANHJCFJ(JAOIINDNBLA HKCCAHKOPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6728990", Offset = "0x6727990", VA = "0x186728990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ALEAPENLNHF : OJBJBCJANJM, PIIJCHPHOFC
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode KGPMBDEBFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x671B2A0", Offset = "0x671A2A0", VA = "0x18671B2A0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x671B580", Offset = "0x671A580", VA = "0x18671B580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode NNCACAIIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x671B030", Offset = "0x671A030", VA = "0x18671B030", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x671AF70", Offset = "0x6719F70", VA = "0x18671AF70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public ALEAPENLNHF(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x671B3E0", Offset = "0x671A3E0", VA = "0x18671B3E0", Slot = "6")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x671B300", Offset = "0x671A300", VA = "0x18671B300", Slot = "9")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x671ADE0", Offset = "0x6719DE0", VA = "0x18671ADE0", Slot = "7")]
	public void APNHNOKKPPN(bool ANGHKIGFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x671AF60", Offset = "0x6719F60", VA = "0x18671AF60", Slot = "8")]
	public void GEAKPMIBGEM(bool ANGHKIGFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x671B140", Offset = "0x671A140", VA = "0x18671B140", Slot = "10")]
	public bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x671ADF0", Offset = "0x6719DF0", VA = "0x18671ADF0")]
	private void DKACMGONLFD(bool ANGHKIGFLGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class GNLLOCJEBGL : OJBJBCJANJM, LDFNINBNHKI, IDisposable, HOEIBBBDECC
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JHOHKNNGDMA OHHBPKOHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6728EE0", Offset = "0x6727EE0", VA = "0x186728EE0")]
		get
		{
			return default(JHOHKNNGDMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6728D20", Offset = "0x6727D20", VA = "0x186728D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6728A70", Offset = "0x6727A70", VA = "0x186728A70", Slot = "6")]
		get
		{
			return default(JHOHKNNGDMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6728D20", Offset = "0x6727D20", VA = "0x186728D20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform JDDDNFABMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6728E10", Offset = "0x6727E10", VA = "0x186728E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6728C70", Offset = "0x6727C70", VA = "0x186728C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public GNLLOCJEBGL(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6728EC0", Offset = "0x6727EC0", VA = "0x186728EC0", Slot = "11")]
	public void OnChangedDistanceBand(GMBNNMLOONM DLNNKNFPKPH, GMBNNMLOONM ALOJCDOHIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "12")]
	public void OnChangedVisibility(bool CELPKGDKFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class IHMKBEKIPLJ : OJBJBCJANJM, AFHCMCCOEML
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x671C2B0", Offset = "0x671B2B0", VA = "0x18671C2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x671C250", Offset = "0x671B250", VA = "0x18671C250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x672A410", Offset = "0x6729410", VA = "0x18672A410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public IHMKBEKIPLJ(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x672A2B0", Offset = "0x67292B0", VA = "0x18672A2B0", Slot = "4")]
	public void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6729E70", Offset = "0x6728E70", VA = "0x186729E70")]
	private void COGBBMMDKDB(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x672A7B0", Offset = "0x67297B0", VA = "0x18672A7B0", Slot = "5")]
	public void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x672A150", Offset = "0x6729150", VA = "0x18672A150", Slot = "6")]
	public void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x672A550", Offset = "0x6729550", VA = "0x18672A550")]
	private void LLBMHLGANFL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x672AA30", Offset = "0x6729A30", VA = "0x18672AA30", Slot = "7")]
	public void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x672A470", Offset = "0x6729470", VA = "0x18672A470")]
	private void LFPFJBDDFDP(string DFJKCKBFLAD, UnityEngine.Object LNLKAOCIPJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JGLKBDDFDBI : OJBJBCJANJM, JPOIHLJEDKK
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool GBKGDPPBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6730F30", Offset = "0x672FF30", VA = "0x186730F30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6730D50", Offset = "0x672FD50", VA = "0x186730D50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public JGLKBDDFDBI(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6730EA0", Offset = "0x672FEA0", VA = "0x186730EA0", Slot = "6")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6730CB0", Offset = "0x672FCB0", VA = "0x186730CB0", Slot = "7")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AADDJCJJMKC : OJBJBCJANJM, OKJIHJLLPCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly LPCGADPJIJD NDMKMMNEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly PLBOKOCPFOF IBCNBBFIPPE;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x671A660", Offset = "0x6719660", VA = "0x18671A660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public LAIJBGHHNPC GLDNJGGJPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x671A1C0", Offset = "0x67191C0", VA = "0x18671A1C0")]
		get
		{
			return default(LAIJBGHHNPC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6719C40", Offset = "0x6718C40", VA = "0x186719C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6719570", Offset = "0x6718570", VA = "0x186719570", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x671A4A0", Offset = "0x67194A0", VA = "0x18671A4A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LAIJBGHHNPC LNHKAKFADNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x671A0C0", Offset = "0x67190C0", VA = "0x18671A0C0")]
		get
		{
			return default(LAIJBGHHNPC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6718C30", Offset = "0x6717C30", VA = "0x186718C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6718F90", Offset = "0x6717F90", VA = "0x186718F90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1230", Offset = "0x7C0230", VA = "0x1807C1230", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HHCCBDGDJEE NBBPJKJCGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x671A360", Offset = "0x6719360", VA = "0x18671A360", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x67194D0", Offset = "0x67184D0", VA = "0x1867194D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HHCCBDGDJEE IDBEGADGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6719CB0", Offset = "0x6718CB0", VA = "0x186719CB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x671A120", Offset = "0x6719120", VA = "0x18671A120", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GKBMLBEBNAB GPHDEBALPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6718A40", Offset = "0x6717A40", VA = "0x186718A40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6719D50", Offset = "0x6718D50", VA = "0x186719D50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action EKIMBIFFPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x671A510", Offset = "0x6719510", VA = "0x18671A510", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x671A400", Offset = "0x6719400", VA = "0x18671A400", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action FEGLEGKIHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x671A220", Offset = "0x6719220", VA = "0x18671A220", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x671A2C0", Offset = "0x67192C0", VA = "0x18671A2C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<ILDIKLAHNAE> AEFDNNANEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6719370", Offset = "0x6718370", VA = "0x186719370", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x671A5B0", Offset = "0x67195B0", VA = "0x18671A5B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<ILDIKLAHNAE> KCGIMADPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6718AE0", Offset = "0x6717AE0", VA = "0x186718AE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6719420", Offset = "0x6718420", VA = "0x186719420", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action DNDKJHFOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6718B90", Offset = "0x6717B90", VA = "0x186718B90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6719EA0", Offset = "0x6718EA0", VA = "0x186719EA0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<ILDIKLAHNAE> BGOLEFCIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6719DF0", Offset = "0x6718DF0", VA = "0x186719DF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x67192C0", Offset = "0x67182C0", VA = "0x1867192C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x671A920", Offset = "0x6719920", VA = "0x18671A920")]
	public AADDJCJJMKC(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x67190F0", Offset = "0x67180F0", VA = "0x1867190F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6719FF0", Offset = "0x6718FF0", VA = "0x186719FF0", Slot = "26")]
	public void JACMFKHLBGF(ILDIKLAHNAE DIMMPCLNOKP, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x671A070", Offset = "0x6719070", VA = "0x18671A070")]
	private void JACMFKHLBGF(DCAPCOLGFJA DIMMPCLNOKP, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x67195E0", Offset = "0x67185E0", VA = "0x1867195E0")]
	private void FLKONPJIAAN(DCAPCOLGFJA DIMMPCLNOKP, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6718CA0", Offset = "0x6717CA0", VA = "0x186718CA0")]
	private void BJJFGDKMEOC(DCAPCOLGFJA LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x671A690", Offset = "0x6719690", VA = "0x18671A690")]
	private void ODBGEHIPDJC(DCAPCOLGFJA LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6719A60", Offset = "0x6718A60", VA = "0x186719A60")]
	private void FMGEMPNEJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6719F40", Offset = "0x6718F40", VA = "0x186719F40")]
	private void IOBCHBNHPJA(DCAPCOLGFJA LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6719000", Offset = "0x6718000", VA = "0x186719000")]
	private void DMHLGCAFBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6719220", Offset = "0x6718220", VA = "0x186719220")]
	private void EPJFLKIHBEG(DCAPCOLGFJA NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6718EF0", Offset = "0x6717EF0", VA = "0x186718EF0")]
	private void CAMALHLCPML(DCAPCOLGFJA NKJKBALEEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class CFIBAJEGKGN
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x671D460", Offset = "0x671C460", VA = "0x18671D460")]
	public static AADDJCJJMKC CMMLPDHIIIA(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class FHLLMDPKDJM : OJBJBCJANJM, JEDBDICJFMB
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6722EB0", Offset = "0x6721EB0", VA = "0x186722EB0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6722EE0", Offset = "0x6721EE0", VA = "0x186722EE0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6723270", Offset = "0x6722270", VA = "0x186723270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private ILDIKLAHNAE OEEFCKFFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6723110", Offset = "0x6722110", VA = "0x186723110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public FHLLMDPKDJM(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6723360", Offset = "0x6722360", VA = "0x186723360", Slot = "6")]
	public void OAMCKFIDFGA(ILDIKLAHNAE MMPNPJILHCD, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x67234B0", Offset = "0x67224B0", VA = "0x1867234B0")]
	private void OAMCKFIDFGA(DCAPCOLGFJA MMPNPJILHCD, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6722A30", Offset = "0x6721A30", VA = "0x186722A30", Slot = "7")]
	public void BLFPGPILPNC(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6722AA0", Offset = "0x6721AA0", VA = "0x186722AA0")]
	private Vector3 CDJGPEKGHGG()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class HEHEADDJJNM
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6728FC0", Offset = "0x6727FC0", VA = "0x186728FC0")]
	public static FHLLMDPKDJM CHEHHIJLFJD(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GJPEIJOFFLM : OJBJBCJANJM, OGAIKCGLNBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6726200", Offset = "0x6725200", VA = "0x186726200", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6727D90", Offset = "0x6726D90", VA = "0x186727D90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 CJOJHPMEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6726D00", Offset = "0x6725D00", VA = "0x186726D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 EAEMGEPGELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6726880", Offset = "0x6725880", VA = "0x186726880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x67278B0", Offset = "0x67268B0", VA = "0x1867278B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6727AA0", Offset = "0x6726AA0", VA = "0x186727AA0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float IOAMAJJJOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x6728100", Offset = "0x6727100", VA = "0x186728100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6727F40", Offset = "0x6726F40", VA = "0x186727F40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x6728040", Offset = "0x6727040", VA = "0x186728040", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x6727F10", Offset = "0x6726F10", VA = "0x186727F10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x67261D0", Offset = "0x67251D0", VA = "0x1867261D0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event HHCCBDGDJEE OCMJCNDOMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6727FA0", Offset = "0x6726FA0", VA = "0x186727FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6727B00", Offset = "0x6726B00", VA = "0x186727B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x67284E0", Offset = "0x67274E0", VA = "0x1867284E0")]
	public GJPEIJOFFLM(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x67260B0", Offset = "0x67250B0", VA = "0x1867260B0")]
	public float3 CGCMCFAECCN()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6728250", Offset = "0x6727250", VA = "0x186728250", Slot = "14")]
	public void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6727BA0", Offset = "0x6726BA0", VA = "0x186727BA0", Slot = "16")]
	public void JBFAOBEPMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x67269B0", Offset = "0x67259B0", VA = "0x1867269B0", Slot = "15")]
	public void FNOPPMCNOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6728180", Offset = "0x6727180", VA = "0x186728180", Slot = "18")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x67262B0", Offset = "0x67252B0", VA = "0x1867262B0", Slot = "19")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6727850", Offset = "0x6726850", VA = "0x186727850", Slot = "17")]
	public void ICDKKPLHEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6726FF0", Offset = "0x6725FF0", VA = "0x186726FF0", Slot = "20")]
	public void HKPOMGHDOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6723720", Offset = "0x6722720", VA = "0x186723720")]
	public void ENPNOEEFDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6727D90", Offset = "0x6726D90", VA = "0x186727D90")]
	private void LPFPIJKHIIC(Vector3 CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x67266A0", Offset = "0x67256A0", VA = "0x1867266A0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 FJFOIDHKHFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6728040", Offset = "0x6727040", VA = "0x186728040")]
	private void ODKGFCAFJBI(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x67275F0", Offset = "0x67265F0", VA = "0x1867275F0")]
	private Vector3 HPGPDEFMDGA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6726DB0", Offset = "0x6725DB0", VA = "0x186726DB0")]
	private Quaternion GPHDCOJDFEK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6724E50", Offset = "0x6723E50", VA = "0x186724E50")]
	internal (float, Vector3) BMOKMACMDFI(Rigidbody HABMHABLJGK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class DBHOHOGHHAK
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6720FF0", Offset = "0x671FFF0", VA = "0x186720FF0")]
	public static GJPEIJOFFLM DNDMMCGIKFA(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CADJHEJLFJF : OJBJBCJANJM, LHIDLBLFPCN
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool PGFFPIFGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x671CD80", Offset = "0x671BD80", VA = "0x18671CD80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public FAKPEAJNMEL JJKOGMAJPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x671CCA0", Offset = "0x671BCA0", VA = "0x18671CCA0", Slot = "11")]
		get
		{
			return default(FAKPEAJNMEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private FAKPEAJNMEL GLPKMGPHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x671CCA0", Offset = "0x671BCA0", VA = "0x18671CCA0")]
		get
		{
			return default(FAKPEAJNMEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x671CEC0", Offset = "0x671BEC0", VA = "0x18671CEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x671D350", Offset = "0x671C350", VA = "0x18671D350")]
	public CADJHEJLFJF(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x671D150", Offset = "0x671C150", VA = "0x18671D150", Slot = "4")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x671CDE0", Offset = "0x671BDE0", VA = "0x18671CDE0")]
	private bool GPHHGMOHKIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x671CC20", Offset = "0x671BC20", VA = "0x18671CC20", Slot = "5")]
	public void CGEMAAAOJBA(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x671CBA0", Offset = "0x671BBA0", VA = "0x18671CBA0", Slot = "6")]
	public void CCGDPIODJJM(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x671CA40", Offset = "0x671BA40", VA = "0x18671CA40", Slot = "9")]
	public void BJPJHCKMCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x671D250", Offset = "0x671C250", VA = "0x18671D250")]
	private void PLCMNNAEOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x671CF30", Offset = "0x671BF30", VA = "0x18671CF30")]
	private void INJBLCFJLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x671CD00", Offset = "0x671BD00", VA = "0x18671CD00", Slot = "8")]
	public void ECAPICMDCPE(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x671D0D0", Offset = "0x671C0D0", VA = "0x18671D0D0", Slot = "7")]
	public void JJDBJIIKLAH(ILDIKLAHNAE NKJKBALEEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GCJAECHAMGJ : OJBJBCJANJM, LLNHEKLDBHN
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6723A20", Offset = "0x6722A20", VA = "0x186723A20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool JMCDCILNPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6723760", Offset = "0x6722760", VA = "0x186723760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event HHCCBDGDJEE GAOOFNAHMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6723680", Offset = "0x6722680", VA = "0x186723680", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6723B70", Offset = "0x6722B70", VA = "0x186723B70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public GCJAECHAMGJ(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x67239B0", Offset = "0x67229B0", VA = "0x1867239B0", Slot = "11")]
	public IDisposable HNLDFFOBHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x67237C0", Offset = "0x67227C0", VA = "0x1867237C0", Slot = "8")]
	public void EKDAFPEPHEB(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6723A80", Offset = "0x6722A80", VA = "0x186723A80", Slot = "9")]
	public void MJLNPAECEJJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x67237D0", Offset = "0x67227D0", VA = "0x1867237D0", Slot = "10")]
	public void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6723A90", Offset = "0x6722A90", VA = "0x186723A90", Slot = "12")]
	public void NLGFKGKOAEE(Rigidbody GIOJGBHHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x67238D0", Offset = "0x67228D0", VA = "0x1867238D0", Slot = "13")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6723720", Offset = "0x6722720", VA = "0x186723720", Slot = "6")]
	public void BLICLOIFIKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class FBHIEFPBLON : OJBJBCJANJM, BAJHLENBDPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView HHGGIPAKDPD;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6721FE0", Offset = "0x6720FE0", VA = "0x186721FE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x67223B0", Offset = "0x67213B0", VA = "0x1867223B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event HHCCBDGDJEE GEEBKGBDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6722310", Offset = "0x6721310", VA = "0x186722310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6721DE0", Offset = "0x6720DE0", VA = "0x186721DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6722970", Offset = "0x6721970", VA = "0x186722970")]
	public FBHIEFPBLON(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6722840", Offset = "0x6721840", VA = "0x186722840", Slot = "8")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6721E80", Offset = "0x6720E80", VA = "0x186721E80", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6722640", Offset = "0x6721640", VA = "0x186722640", Slot = "9")]
	public void NDCIKMGKMOL(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6722440", Offset = "0x6721440", VA = "0x186722440", Slot = "10")]
	public void LOCHBIPJNMJ(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6721C00", Offset = "0x6720C00", VA = "0x186721C00")]
	private void BOAKMMECPJA(PhotonView JLFGDNHDIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6722000", Offset = "0x6721000", VA = "0x186722000")]
	private void ENNBCLCPEFH(RigidbodyEx DPOBKNLFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6722150", Offset = "0x6721150", VA = "0x186722150")]
	private void IKHPILMACPP(PhotonView DMDILNMLJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class AJJBOFPGNLO
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x671AD80", Offset = "0x6719D80", VA = "0x18671AD80")]
	public static FBHIEFPBLON BCKOKGCCALI(this JAOIINDNBLA GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GGIJHHHIGPD : OJBJBCJANJM, PKJAODKDPEK
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6724C80", Offset = "0x6723C80", VA = "0x186724C80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6724B10", Offset = "0x6723B10", VA = "0x186724B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool CKIDBDMBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6724AB0", Offset = "0x6723AB0", VA = "0x186724AB0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6724B80", Offset = "0x6723B80", VA = "0x186724B80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints CDFDPCCNCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6724A50", Offset = "0x6723A50", VA = "0x186724A50", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6724850", Offset = "0x6723850", VA = "0x186724850", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6724CE0", Offset = "0x6723CE0", VA = "0x186724CE0")]
	public GGIJHHHIGPD(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6724BF0", Offset = "0x6723BF0", VA = "0x186724BF0", Slot = "9")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x67249D0", Offset = "0x67239D0", VA = "0x1867249D0", Slot = "10")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class OHGBHEFHHKG : OJBJBCJANJM, NJJOJJLMDHA
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x673A180", Offset = "0x6739180", VA = "0x18673A180", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x673A4F0", Offset = "0x67394F0", VA = "0x18673A4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float KIMJDLKEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x673A120", Offset = "0x6739120", VA = "0x18673A120", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x673A2B0", Offset = "0x67392B0", VA = "0x18673A2B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public OHGBHEFHHKG(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x673A400", Offset = "0x6739400", VA = "0x18673A400", Slot = "8")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x673A1E0", Offset = "0x67391E0", VA = "0x18673A1E0", Slot = "9")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[PMGKIFLEIJE(typeof(NMEEOFNJPML), new string[] { })]
public sealed class NCFPKKACCJE : NIFPNAPKKPN, NMEEOFNJPML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[GMKIEKFMAIN]
	private OGPHBOFLFHM NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6735B00", Offset = "0x6734B00", VA = "0x186735B00", Slot = "4")]
	public void InitReferences(PAOGDAFANAL OEMCDBOBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6735AD0", Offset = "0x6734AD0", VA = "0x186735AD0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x67359B0", Offset = "0x67349B0", VA = "0x1867359B0", Slot = "6")]
	public void BMOKMACMDFI(LAIJBGHHNPC JHPDAOFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6735E40", Offset = "0x6734E40", VA = "0x186735E40", Slot = "7")]
	public void OGDDNMGDNFP(LAIJBGHHNPC JHPDAOFKDGB, bool FOLMOFINKBL, bool MPBMNMKPHIJ, bool IJEAAMOALEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6735B50", Offset = "0x6734B50", VA = "0x186735B50", Slot = "8")]
	public void KHGDJDMDJHL(LAIJBGHHNPC JHPDAOFKDGB, float3 GLKDHNFFAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6736060", Offset = "0x6735060", VA = "0x186736060", Slot = "9")]
	public void PONNADBENLL(LAIJBGHHNPC JHPDAOFKDGB, float3 KDNIBMMAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6735D80", Offset = "0x6734D80", VA = "0x186735D80")]
	private bool NGIHGCBAJAE(LAIJBGHHNPC JHPDAOFKDGB, [Out] DCAPCOLGFJA GINEIDDJABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6735C90", Offset = "0x6734C90", VA = "0x186735C90")]
	private bool KKIPBJBAGEO(LAIJBGHHNPC JHPDAOFKDGB, [Out] GJPEIJOFFLM CKLDAOADFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x67358C0", Offset = "0x67348C0", VA = "0x1867358C0")]
	private bool ALNDMIHEPPF(LAIJBGHHNPC JHPDAOFKDGB, [Out] MAMIDGJNPJC COHNPGOMLKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NCFPKKACCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MKMGCDLKKNI : OJBJBCJANJM, LHNPGMILOFB
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool CEACOEPNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x67342B0", Offset = "0x67332B0", VA = "0x1867342B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x6735060", Offset = "0x6734060", VA = "0x186735060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x67350C0", Offset = "0x67340C0", VA = "0x1867350C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool AOINNKNHNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6735260", Offset = "0x6734260", VA = "0x186735260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6735360", Offset = "0x6734360", VA = "0x186735360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool ECHKKCBCEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6735120", Offset = "0x6734120", VA = "0x186735120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x67354F0", Offset = "0x67344F0", VA = "0x1867354F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int JPKOBKMFOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6734FF0", Offset = "0x6733FF0", VA = "0x186734FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event HHCCBDGDJEE KGAAGDPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x67352C0", Offset = "0x67342C0", VA = "0x1867352C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6734DB0", Offset = "0x6733DB0", VA = "0x186734DB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6735790", Offset = "0x6734790", VA = "0x186735790")]
	public MKMGCDLKKNI(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x67353D0", Offset = "0x67343D0", VA = "0x1867353D0", Slot = "6")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6735480", Offset = "0x6734480", VA = "0x186735480", Slot = "8")]
	public void OHJJJFJLHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6734E50", Offset = "0x6733E50", VA = "0x186734E50", Slot = "7")]
	public bool DBKIMDDEKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6735560", Offset = "0x6734560", VA = "0x186735560", Slot = "9")]
	public void PLAKGKFOOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6723720", Offset = "0x6722720", VA = "0x186723720", Slot = "12")]
	public void KMNFOBBGJMI(bool ONAEAHOIGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6735650", Offset = "0x6734650", VA = "0x186735650", Slot = "11")]
	public void PNNBKBPGHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "10")]
	public void BFOPBGOCLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6735180", Offset = "0x6734180", VA = "0x186735180")]
	private void HMDBENONIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class PAAIMGKKOFH : OJBJBCJANJM, MIBKGKEEDAB
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x673B030", Offset = "0x673A030", VA = "0x18673B030", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x673AD70", Offset = "0x6739D70", VA = "0x18673AD70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x671C250", Offset = "0x671B250", VA = "0x18671C250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool CJLLIIAHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x673A900", Offset = "0x6739900", VA = "0x18673A900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x673B110", Offset = "0x673A110", VA = "0x18673B110")]
	public PAAIMGKKOFH(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x673ACC0", Offset = "0x6739CC0", VA = "0x18673ACC0", Slot = "5")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x673A960", Offset = "0x6739960", VA = "0x18673A960", Slot = "7")]
	public void DKEGMLMFEBP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x673A9E0", Offset = "0x67399E0", VA = "0x18673A9E0", Slot = "8")]
	public void DKNNLFNCMBE(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x673A6E0", Offset = "0x67396E0", VA = "0x18673A6E0", Slot = "9")]
	public void BILHKELEOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x673AA60", Offset = "0x6739A60", VA = "0x18673AA60", Slot = "11")]
	public void MELKIANENHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x673AE60", Offset = "0x6739E60", VA = "0x18673AE60", Slot = "12")]
	public void OFGPEHLCAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "10")]
	public void MNNILOOKCBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class MAMIDGJNPJC : OJBJBCJANJM, EIMEDLCKGGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6731160", Offset = "0x6730160", VA = "0x186731160", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x67329E0", Offset = "0x67319E0", VA = "0x1867329E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6732870", Offset = "0x6731870", VA = "0x186732870", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6734810", Offset = "0x6733810", VA = "0x186734810", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x67347B0", Offset = "0x67337B0", VA = "0x1867347B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x67326E0", Offset = "0x67316E0", VA = "0x1867326E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6731D90", Offset = "0x6730D90", VA = "0x186731D90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6731D60", Offset = "0x6730D60", VA = "0x186731D60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x67341A0", Offset = "0x67331A0", VA = "0x1867341A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6733670", Offset = "0x6732670", VA = "0x186733670", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6734140", Offset = "0x6733140", VA = "0x186734140", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6734170", Offset = "0x6733170", VA = "0x186734170", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6732980", Offset = "0x6731980", VA = "0x186732980", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6733FF0", Offset = "0x6732FF0", VA = "0x186733FF0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x67346F0", Offset = "0x67336F0", VA = "0x1867346F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private AFHCMCCOEML CJJBOGBGKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x60426F0", Offset = "0x60416F0", VA = "0x1860426F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool CEACOEPNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x67342B0", Offset = "0x67332B0", VA = "0x1867342B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public MAMIDGJNPJC(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6734C80", Offset = "0x6733C80", VA = "0x186734C80", Slot = "20")]
	public void PLCOEMDJPIG(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6732800", Offset = "0x6731800", VA = "0x186732800", Slot = "30")]
	public void FFHGKAJGJPF(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6733050", Offset = "0x6732050", VA = "0x186733050", Slot = "19")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6732620", Offset = "0x6731620", VA = "0x186732620", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x67342D0", Offset = "0x67332D0", VA = "0x1867342D0", Slot = "28")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6733C40", Offset = "0x6732C40", VA = "0x186733C40", Slot = "35")]
	public Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6734880", Offset = "0x6733880", VA = "0x186734880", Slot = "34")]
	public Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6733050", Offset = "0x6732050", VA = "0x186733050", Slot = "27")]
	public void IAIKOJBEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6732E60", Offset = "0x6731E60", VA = "0x186732E60", Slot = "25")]
	public void HGEENGLFPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6732920", Offset = "0x6731920", VA = "0x186732920", Slot = "24")]
	public void GICLCPMKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6734A40", Offset = "0x6733A40", VA = "0x186734A40", Slot = "33")]
	public void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6734750", Offset = "0x6733750", VA = "0x186734750", Slot = "32")]
	public void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6733E20", Offset = "0x6732E20", VA = "0x186733E20", Slot = "31")]
	public void KJIIOMDLAFE(Vector3 CNDIDFEDOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x67317F0", Offset = "0x67307F0", VA = "0x1867317F0", Slot = "22")]
	public void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6734440", Offset = "0x6733440", VA = "0x186734440", Slot = "21")]
	public void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6732A50", Offset = "0x6731A50", VA = "0x186732A50", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6731DC0", Offset = "0x6730DC0", VA = "0x186731DC0", Slot = "29")]
	public Vector3 CLHAALPDBMF(Vector3 JKBHKGAJHBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6732EC0", Offset = "0x6731EC0", VA = "0x186732EC0", Slot = "26")]
	public void HIMGANPJKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6733FF0", Offset = "0x6732FF0", VA = "0x186733FF0")]
	private void LCMPPGMCEPH(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6731EA0", Offset = "0x6730EA0", VA = "0x186731EA0")]
	private void CNFGOLBHOEP(Vector3 HLOJJBHMOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6733730", Offset = "0x6732730", VA = "0x186733730")]
	private Vector3 IOBIENALLHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6731210", Offset = "0x6730210", VA = "0x186731210")]
	private void AHLLEALBDCN(Vector3 GLKDHNFFAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x67339B0", Offset = "0x67329B0", VA = "0x1867339B0")]
	private Vector3 JCCKHKJNFME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6733100", Offset = "0x6732100", VA = "0x186733100")]
	private void IMNNFPJPBDL(Vector3 CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x67327A0", Offset = "0x67317A0", VA = "0x1867327A0")]
	private void FDIPPFJMGFM(Vector3 JKBHKGAJHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6731790", Offset = "0x6730790", VA = "0x186731790")]
	private void ALINPCPPKON(Vector3 FPIFBDKIOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6732070", Offset = "0x6731070", VA = "0x186732070")]
	private void DOFLGMDFBFF(string FMJGLEKCHAO, Vector3 CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6734200", Offset = "0x6733200", VA = "0x186734200")]
	private void MIKLKADBGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class OJBJBCJANJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly DCAPCOLGFJA NKJKBALEEPO;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected OGPHBOFLFHM DCBIGBJILDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x57F27C0", Offset = "0x57F17C0", VA = "0x1857F27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected LAIJBGHHNPC ENLFEECHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x57F2800", Offset = "0x57F1800", VA = "0x1857F2800")]
		get
		{
			return default(LAIJBGHHNPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x671B5F0", Offset = "0x671A5F0", VA = "0x18671B5F0")]
	public OJBJBCJANJM(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x673A640", Offset = "0x6739640", VA = "0x18673A640")]
	protected ILDIKLAHNAE MKHDJDMCOEE(LAIJBGHHNPC GDHPLPDIOBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PBLCKCDGODH : OGAAPOKMDEM
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x673C140", Offset = "0x673B140", VA = "0x18673C140", Slot = "4")]
	public OKJIHJLLPCC PDGNDPNABDC(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x673BEC0", Offset = "0x673AEC0", VA = "0x18673BEC0", Slot = "5")]
	public EIMEDLCKGGP MMIFGHICLDF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x673B860", Offset = "0x673A860", VA = "0x18673B860", Slot = "6")]
	public JEDBDICJFMB DFKLNAKHLKD(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x673B470", Offset = "0x673A470", VA = "0x18673B470", Slot = "7")]
	public NJJOJJLMDHA ANABDHKOBLP(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x673B9B0", Offset = "0x673A9B0", VA = "0x18673B9B0", Slot = "8")]
	public LHNPGMILOFB EGELLNKBJLK(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x673BD00", Offset = "0x673AD00", VA = "0x18673BD00", Slot = "9")]
	public LDFNINBNHKI HBKAKEIBKMJ(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x673BDE0", Offset = "0x673ADE0", VA = "0x18673BDE0", Slot = "10")]
	public LLNHEKLDBHN JJMDGGIHJAE(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x673B6A0", Offset = "0x673A6A0", VA = "0x18673B6A0", Slot = "11")]
	public AFHCMCCOEML CPFFPEAMBOL(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x673BC20", Offset = "0x673AC20", VA = "0x18673BC20", Slot = "12")]
	public PIIJCHPHOFC FMOKPDJEHBN(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x673B780", Offset = "0x673A780", VA = "0x18673B780", Slot = "13")]
	public JPOIHLJEDKK DAAJHLKLIHF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x673BB20", Offset = "0x673AB20", VA = "0x18673BB20")]
	public MIBKGKEEDAB EMLGCECJHAH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x673B370", Offset = "0x673A370", VA = "0x18673B370")]
	public BAJHLENBDPO AGNFFPPGGKK(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x673B550", Offset = "0x673A550", VA = "0x18673B550")]
	public LHIDLBLFPCN BEHNJGFMDBB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x673B940", Offset = "0x673A940", VA = "0x18673B940")]
	public OGAIKCGLNBJ OKNBELHPCCC(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x673BFA0", Offset = "0x673AFA0", VA = "0x18673BFA0")]
	public PKJAODKDPEK OEFDJKLCOEB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x673B240", Offset = "0x673A240", VA = "0x18673B240", Slot = "19")]
	public ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI, ABCMFLEOCJP JDIOCIOLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PBLCKCDGODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x673BB20", Offset = "0x673AB20", VA = "0x18673BB20", Slot = "14")]
	private MIBKGKEEDAB LDCJLIHMBPP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x673B370", Offset = "0x673A370", VA = "0x18673B370", Slot = "15")]
	private BAJHLENBDPO IENLOMPJMFP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x673B550", Offset = "0x673A550", VA = "0x18673B550", Slot = "16")]
	private LHIDLBLFPCN GLGFBHEANJH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x673B940", Offset = "0x673A940", VA = "0x18673B940", Slot = "17")]
	private OGAIKCGLNBJ EECCAOMFHIP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x673B690", Offset = "0x673A690", VA = "0x18673B690", Slot = "18")]
	private PKJAODKDPEK BLPKFIOIJBD(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class PLBOKOCPFOF : IReadOnlyList<ILDIKLAHNAE>, IEnumerable<ILDIKLAHNAE>, IEnumerable, IReadOnlyCollection<ILDIKLAHNAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly LAIJBGHHNPC GDHPLPDIOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly OGPHBOFLFHM FNDNLLEJFGE;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x673C6C0", Offset = "0x673B6C0", VA = "0x18673C6C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public ILDIKLAHNAE EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x673C570", Offset = "0x673B570", VA = "0x18673C570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3556A70", Offset = "0x3555A70", VA = "0x183556A70")]
	public PLBOKOCPFOF(LAIJBGHHNPC GDHPLPDIOBF, OGPHBOFLFHM FNDNLLEJFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x673C460", Offset = "0x673B460", VA = "0x18673C460", Slot = "6")]
	public IEnumerator<ILDIKLAHNAE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x673C460", Offset = "0x673B460", VA = "0x18673C460", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x673C570", Offset = "0x673B570", VA = "0x18673C570")]
	[CompilerGenerated]
	private ILDIKLAHNAE LJMBDHJKHNH(int BFOKHFCOJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[PMGKIFLEIJE(typeof(OGAAPOKMDEM), new string[] { })]
public class OALAGNOMNHI : OGAAPOKMDEM, NIFPNAPKKPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OGAAPOKMDEM NOEGFNBLFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly OGAAPOKMDEM DBELFBKDCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MLNEHNEPPFF FPLDGHOIHHG;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private OGAAPOKMDEM LOJOBJHEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x67392B0", Offset = "0x67382B0", VA = "0x1867392B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6739120", Offset = "0x6738120", VA = "0x186739120", Slot = "20")]
	public void InitReferences(PAOGDAFANAL OEMCDBOBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6739310", Offset = "0x6738310", VA = "0x186739310", Slot = "4")]
	public OKJIHJLLPCC PDGNDPNABDC(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6739210", Offset = "0x6738210", VA = "0x186739210", Slot = "5")]
	public EIMEDLCKGGP MMIFGHICLDF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6738D40", Offset = "0x6737D40", VA = "0x186738D40", Slot = "6")]
	public JEDBDICJFMB DFKLNAKHLKD(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6738A00", Offset = "0x6737A00", VA = "0x186738A00", Slot = "7")]
	public NJJOJJLMDHA ANABDHKOBLP(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6738E90", Offset = "0x6737E90", VA = "0x186738E90", Slot = "8")]
	public LHNPGMILOFB EGELLNKBJLK(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6739080", Offset = "0x6738080", VA = "0x186739080", Slot = "9")]
	public LDFNINBNHKI HBKAKEIBKMJ(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6739170", Offset = "0x6738170", VA = "0x186739170", Slot = "10")]
	public LLNHEKLDBHN JJMDGGIHJAE(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6738C00", Offset = "0x6737C00", VA = "0x186738C00", Slot = "11")]
	public AFHCMCCOEML CPFFPEAMBOL(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6738FE0", Offset = "0x6737FE0", VA = "0x186738FE0", Slot = "12")]
	public PIIJCHPHOFC FMOKPDJEHBN(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6738CA0", Offset = "0x6737CA0", VA = "0x186738CA0", Slot = "13")]
	public JPOIHLJEDKK DAAJHLKLIHF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6738F30", Offset = "0x6737F30", VA = "0x186738F30")]
	public MIBKGKEEDAB EMLGCECJHAH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6738950", Offset = "0x6737950", VA = "0x186738950")]
	public BAJHLENBDPO AGNFFPPGGKK(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6738AA0", Offset = "0x6737AA0", VA = "0x186738AA0")]
	public LHIDLBLFPCN BEHNJGFMDBB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6738DE0", Offset = "0x6737DE0", VA = "0x186738DE0")]
	public OGAIKCGLNBJ OKNBELHPCCC(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6738B50", Offset = "0x6737B50", VA = "0x186738B50")]
	public PKJAODKDPEK OEFDJKLCOEB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6738860", Offset = "0x6737860", VA = "0x186738860", Slot = "19")]
	public ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI, ABCMFLEOCJP JDIOCIOLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x67393B0", Offset = "0x67383B0", VA = "0x1867393B0")]
	public OALAGNOMNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6738F30", Offset = "0x6737F30", VA = "0x186738F30", Slot = "14")]
	private MIBKGKEEDAB LDCJLIHMBPP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6738950", Offset = "0x6737950", VA = "0x186738950", Slot = "15")]
	private BAJHLENBDPO IENLOMPJMFP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6738AA0", Offset = "0x6737AA0", VA = "0x186738AA0", Slot = "16")]
	private LHIDLBLFPCN GLGFBHEANJH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6738DE0", Offset = "0x6737DE0", VA = "0x186738DE0", Slot = "17")]
	private OGAIKCGLNBJ EECCAOMFHIP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6738B50", Offset = "0x6737B50", VA = "0x186738B50", Slot = "18")]
	private PKJAODKDPEK BLPKFIOIJBD(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class MGEBLFFJADL : ILDIKLAHNAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly MGEBLFFJADL GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx BLMDDMHBGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject NGDMKBHFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x8828E0", Offset = "0x8818E0", VA = "0x1808828E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8065F0", Offset = "0x8055F0", VA = "0x1808065F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1280", Offset = "0x7C0280", VA = "0x1807C1280", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1270", Offset = "0x7C0270", VA = "0x1807C1270", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1260", Offset = "0x7C0260", VA = "0x1807C1260", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA784F0", Offset = "0xA774F0", VA = "0x180A784F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x941FB0", Offset = "0x940FB0", VA = "0x180941FB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A8B0", Offset = "0x1C298B0", VA = "0x181C2A8B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBEF0", Offset = "0x3BEAEF0", VA = "0x183BEBEF0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x48C9540", Offset = "0x48C8540", VA = "0x1848C9540", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x48C6AA0", Offset = "0x48C5AA0", VA = "0x1848C6AA0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4168CB0", Offset = "0x4167CB0", VA = "0x184168CB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4168590", Offset = "0x4167590", VA = "0x184168590", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CCDOIBLCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9D7470", Offset = "0x9D6470", VA = "0x1809D7470", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool JHPEODOFKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1858090", Offset = "0x1857090", VA = "0x181858090", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9AFA0", Offset = "0x5F99FA0", VA = "0x185F9AFA0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4168CF0", Offset = "0x4167CF0", VA = "0x184168CF0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x98A1E0", Offset = "0x9891E0", VA = "0x18098A1E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6734CF0", Offset = "0x6733CF0", VA = "0x186734CF0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B4ABB0", Offset = "0x1B49BB0", VA = "0x181B4ABB0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x80F160", Offset = "0x80E160", VA = "0x18080F160", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float KIMJDLKEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool GBKGDPPBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "48")]
		get
		{
			return default(JHOHKNNGDMA);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xD72090", Offset = "0xD71090", VA = "0x180D72090", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform KFBNMALPNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x96AA90", Offset = "0x969A90", VA = "0x18096AA90", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 HLMHEKKPFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float CDCKOGHODLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float MAAOOCMICEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD00", Offset = "0x8CBD00", VA = "0x1808CCD00", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion DHOEKPALDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA12AE0", Offset = "0xA11AE0", VA = "0x180A12AE0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 DANHCCHNLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion MDCBKNMNABN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA12AE0", Offset = "0xA11AE0", VA = "0x180A12AE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints CDFDPCCNCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode NNCACAIIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool EFLCFDDDAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x94FDC0", Offset = "0x94EDC0", VA = "0x18094FDC0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event HHCCBDGDJEE NBBPJKJCGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event HHCCBDGDJEE IDBEGADGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event GKBMLBEBNAB GPHDEBALPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event HHCCBDGDJEE GEEBKGBDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event HHCCBDGDJEE HMCFMAMNGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event HHCCBDGDJEE KGAAGDPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event HHCCBDGDJEE GAOOFNAHMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event HHCCBDGDJEE DNKJFFEINAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "41")]
	public void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "71")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "72")]
	public void PICGDOIPKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "73")]
	public void JGEMNFFJBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "74")]
	public void PLAKGKFOOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "81")]
	public void JACMFKHLBGF(ILDIKLAHNAE CFJDHAGGAJO, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "84")]
	public void EOHFPLCBMFJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "85")]
	public void KEPLFMNEALP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "86")]
	public Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "87")]
	public Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "88")]
	public void IAIKOJBEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "89")]
	public void HGEENGLFPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "90")]
	public void GICLCPMKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "91")]
	public void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "92")]
	public void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "93")]
	public void KJIIOMDLAFE(Vector3 CNDIDFEDOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "94")]
	public void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "95")]
	public void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "96")]
	public void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "97")]
	public Vector3 CLHAALPDBMF(Vector3 CFJDHAGGAJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBA3A60", Offset = "0xBA2A60", VA = "0x180BA3A60", Slot = "98")]
	public Vector3 BPGFIBAOILA(Vector3 CFJDHAGGAJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "99")]
	public void HIMGANPJKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "100")]
	public void FOHDEPGNJNG(ILDIKLAHNAE OEIBPBCPKHH, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "101")]
	public void MCLDDMKEKKH(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "104")]
	public void JBFAOBEPMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "105")]
	public void FNOPPMCNOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "106")]
	public void ICDKKPLHEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "109")]
	public bool DBKIMDDEKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "110")]
	public void PNNBKBPGHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "115")]
	public IDisposable HNLDFFOBHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "116")]
	public void EKDAFPEPHEB(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "117")]
	public void MJLNPAECEJJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "118")]
	public void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "121")]
	public void KNCAMPJIGDD(Vector3 OIOPFELBMPK, Quaternion NJEPNFJOJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "122")]
	public void DOMIBHLKHCK(Vector3 MCFCAELGDGE, Quaternion LMGNFDMIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "123")]
	public bool EBHNOFONFDC(float PDPMLJHIDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "124")]
	public void LAJLFDHMNFC(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "125")]
	public void ONOMKFICDHP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "126")]
	public void DKEGMLMFEBP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "127")]
	public void DKNNLFNCMBE(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "128")]
	public void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "129")]
	public void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "130")]
	public void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "131")]
	public void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6734D10", Offset = "0x6733D10", VA = "0x186734D10", Slot = "132")]
	public bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "133")]
	public void HKPOMGHDOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public MGEBLFFJADL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class DCAPCOLGFJA : JAOIINDNBLA, LKLAPCNOJNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal LAIJBGHHNPC GDHPLPDIOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal OGPHBOFLFHM BOMEHNLOPDG;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6721B30", Offset = "0x6720B30", VA = "0x186721B30")]
	public DCAPCOLGFJA(GameObject LNIPGKDIFCK, RigidbodyEx BFCPFHLOEPG, ABCMFLEOCJP JDIOCIOLNIG, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x67214E0", Offset = "0x67204E0", VA = "0x1867214E0", Slot = "135")]
	protected override void HKJIDHJDLLA(ABCMFLEOCJP JDIOCIOLNIG, MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "141")]
	protected override IDisposable LONEJJHMEAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6721140", Offset = "0x6720140", VA = "0x186721140", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6721A60", Offset = "0x6720A60", VA = "0x186721A60", Slot = "142")]
	public void PLLDEEICGNP(HHOMPEABPEF DLNNKNFPKPH, HHOMPEABPEF ALOJCDOHIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x67217B0", Offset = "0x67207B0", VA = "0x1867217B0", Slot = "143")]
	public void JCBFKHLHFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6721080", Offset = "0x6720080", VA = "0x186721080", Slot = "144")]
	public void DFBEIMGLKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6721870", Offset = "0x6720870", VA = "0x186721870", Slot = "145")]
	public void KMNFOBBGJMI(bool ONAEAHOIGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x67218D0", Offset = "0x67208D0", VA = "0x1867218D0", Slot = "146")]
	public bool OKNAICFJIHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6721750", Offset = "0x6720750", VA = "0x186721750", Slot = "147")]
	public void IKELPPJCKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "140")]
	protected override void KMLECOIMNIL(RigidbodyEx IEHPEJEDEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x67212B0", Offset = "0x67202B0", VA = "0x1867212B0")]
	private void EDOAIIIPDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class JEGKBCCDNGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6730B50", Offset = "0x672FB50", VA = "0x186730B50")]
	public static JAOIINDNBLA IAMLOBMICPN(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LNNKAONFHLB : OKJIHJLLPCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPJFLKIHBEG(ILDIKLAHNAE NKJKBALEEPO);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAMALHLCPML(ILDIKLAHNAE NKJKBALEEPO);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJJFGDKMEOC(ILDIKLAHNAE LNBEBOHINAM);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODBGEHIPDJC(ILDIKLAHNAE LNBEBOHINAM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HCFFAPCJMCH : JEDBDICJFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	LAEIHEGEAJO<ILDIKLAHNAE> BIEMDCIONNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	ILDIKLAHNAE OEEFCKFFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BDDAMGNAMOA : OGAIKCGLNBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) BMOKMACMDFI(Rigidbody HABMHABLJGK);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LOFPEJEGBIB : BAJHLENBDPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView BLNNACCEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BDIGGIBCIFH : PIIJCHPHOFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode ANGIMGHPFEF;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode NNCACAIIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x671B840", Offset = "0x671A840", VA = "0x18671B840", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x671B7D0", Offset = "0x671A7D0", VA = "0x18671B7D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x671BC40", Offset = "0x671AC40", VA = "0x18671BC40")]
	public BDIGGIBCIFH(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x671BB30", Offset = "0x671AB30", VA = "0x18671BB30", Slot = "6")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x671BAB0", Offset = "0x671AAB0", VA = "0x18671BAB0", Slot = "9")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x671B690", Offset = "0x671A690", VA = "0x18671B690", Slot = "7")]
	public void APNHNOKKPPN(bool ANGHKIGFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x671B7C0", Offset = "0x671A7C0", VA = "0x18671B7C0", Slot = "8")]
	public void GEAKPMIBGEM(bool ANGHKIGFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x671B950", Offset = "0x671A950", VA = "0x18671B950", Slot = "10")]
	public bool MENAIOCOEOE(Vector3 PKIECLPJPAP, [Out] RaycastHit HFHJNLDBPNN, float GPIGMBNIAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x671B6A0", Offset = "0x671A6A0", VA = "0x18671B6A0")]
	private void DKACMGONLFD(bool ANGHKIGFLGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class OCHKKDKMAGK : LDFNINBNHKI, IDisposable, HOEIBBBDECC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private JHOHKNNGDMA KELFLNNLEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private PHPGHNNPJHJ CGEGCGEDGFP;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public JHOHKNNGDMA CLFNNMHBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6739460", Offset = "0x6738460", VA = "0x186739460", Slot = "6")]
		get
		{
			return default(JHOHKNNGDMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6739660", Offset = "0x6738660", VA = "0x186739660", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform JDDDNFABMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6739780", Offset = "0x6738780", VA = "0x186739780", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GMBNNMLOONM, GMBNNMLOONM> DIKFNMLIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x67397A0", Offset = "0x67387A0", VA = "0x1867397A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x67395B0", Offset = "0x67385B0", VA = "0x1867395B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6739B50", Offset = "0x6738B50", VA = "0x186739B50")]
	public OCHKKDKMAGK(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6739850", Offset = "0x6738850", VA = "0x186739850", Slot = "8")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6739730", Offset = "0x6738730", VA = "0x186739730", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x830000", Offset = "0x82F000", VA = "0x180830000", Slot = "11")]
	private void OCGBMGAAKMC(GMBNNMLOONM AJFLPFKLJHB, GMBNNMLOONM PHCMKGPCKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "12")]
	private void DGJJNHFBOKN(bool CELPKGDKFMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class BMFGGBHBKPK : AFHCMCCOEML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x671B530", Offset = "0x671A530", VA = "0x18671B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x671C2B0", Offset = "0x671B2B0", VA = "0x18671C2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x671C250", Offset = "0x671B250", VA = "0x18671C250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x671C1F0", Offset = "0x671B1F0", VA = "0x18671C1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x671BC40", Offset = "0x671AC40", VA = "0x18671BC40")]
	public BMFGGBHBKPK(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x671C090", Offset = "0x671B090", VA = "0x18671C090", Slot = "4")]
	public void FHFJHCPNDPL(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x671BCD0", Offset = "0x671ACD0", VA = "0x18671BCD0")]
	private void COGBBMMDKDB(Vector3 GCPGMMGNKLP, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x671C560", Offset = "0x671B560", VA = "0x18671C560", Slot = "5")]
	public void LLDIFLMJKIP(Vector3 GCPGMMGNKLP, Vector3 PKDBIHBDKOO, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x671BF30", Offset = "0x671AF30", VA = "0x18671BF30", Slot = "6")]
	public void FAMBKFINHKI(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x671C300", Offset = "0x671B300", VA = "0x18671C300")]
	private void LLBMHLGANFL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x671C7E0", Offset = "0x671B7E0", VA = "0x18671C7E0", Slot = "7")]
	public void PDADHMNCMEL(Vector3 IAKFLMFFAJH, ForceMode BGEODLOHJFI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class JEHPGKPNGPC : JPOIHLJEDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool EMFNDGEOCFG;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool GBKGDPPBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6730BA0", Offset = "0x672FBA0", VA = "0x186730BA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x671BC40", Offset = "0x671AC40", VA = "0x18671BC40")]
	public JEHPGKPNGPC(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6730D20", Offset = "0x672FD20", VA = "0x186730D20", Slot = "6")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6730CB0", Offset = "0x672FCB0", VA = "0x186730CB0", Slot = "7")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class NCPEPEPHFLH : LNNKAONFHLB, OKJIHJLLPCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly ILDIKLAHNAE NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<ILDIKLAHNAE> DHLJNADBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ILDIKLAHNAE HLMIIECLDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private ILDIKLAHNAE MMPNPJILHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform GGPJGGACALL;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6737CE0", Offset = "0x6736CE0", VA = "0x186737CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3250", Offset = "0x7C2250", VA = "0x1807C3250", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6737B80", Offset = "0x6736B80", VA = "0x186737B80", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public ILDIKLAHNAE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1290", Offset = "0x7C0290", VA = "0x1807C1290", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<ILDIKLAHNAE> AJPECBAFOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1230", Offset = "0x7C0230", VA = "0x1807C1230", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event HHCCBDGDJEE NBBPJKJCGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6737900", Offset = "0x6736900", VA = "0x186737900", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6736D90", Offset = "0x6735D90", VA = "0x186736D90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event HHCCBDGDJEE IDBEGADGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6736ED0", Offset = "0x6735ED0", VA = "0x186736ED0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6737720", Offset = "0x6736720", VA = "0x186737720", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event GKBMLBEBNAB GPHDEBALPIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6736290", Offset = "0x6735290", VA = "0x186736290", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6736F70", Offset = "0x6735F70", VA = "0x186736F70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action EKIMBIFFPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6737B90", Offset = "0x6736B90", VA = "0x186737B90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x67379A0", Offset = "0x67369A0", VA = "0x1867379A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action FEGLEGKIHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x67377C0", Offset = "0x67367C0", VA = "0x1867377C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6737860", Offset = "0x6736860", VA = "0x186737860", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<ILDIKLAHNAE> AEFDNNANEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6736C30", Offset = "0x6735C30", VA = "0x186736C30", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6737C30", Offset = "0x6736C30", VA = "0x186737C30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<ILDIKLAHNAE> KCGIMADPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6736330", Offset = "0x6735330", VA = "0x186736330", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6736CE0", Offset = "0x6735CE0", VA = "0x186736CE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action DNDKJHFOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x67363E0", Offset = "0x67353E0", VA = "0x1867363E0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x67370C0", Offset = "0x67360C0", VA = "0x1867370C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<ILDIKLAHNAE> BGOLEFCIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6737010", Offset = "0x6736010", VA = "0x186737010", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6736B80", Offset = "0x6735B80", VA = "0x186736B80", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6737FC0", Offset = "0x6736FC0", VA = "0x186737FC0")]
	public NCPEPEPHFLH(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x67368C0", Offset = "0x67358C0", VA = "0x1867368C0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x67371A0", Offset = "0x67361A0", VA = "0x1867371A0", Slot = "30")]
	public void JACMFKHLBGF(ILDIKLAHNAE DIMMPCLNOKP, bool KIHKHFOPMAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6736480", Offset = "0x6735480", VA = "0x186736480", Slot = "6")]
	public void BJJFGDKMEOC(ILDIKLAHNAE LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6737D40", Offset = "0x6736D40", VA = "0x186737D40", Slot = "7")]
	public void ODBGEHIPDJC(ILDIKLAHNAE LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6736A90", Offset = "0x6735A90", VA = "0x186736A90", Slot = "4")]
	public void EPJFLKIHBEG(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x67366F0", Offset = "0x67356F0", VA = "0x1867366F0", Slot = "5")]
	public void CAMALHLCPML(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6736E30", Offset = "0x6735E30", VA = "0x186736E30")]
	private void FMGEMPNEJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6737160", Offset = "0x6736160", VA = "0x186737160")]
	private void IOBCHBNHPJA(ILDIKLAHNAE LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6737A40", Offset = "0x6736A40", VA = "0x186737A40")]
	private void MCIKJHBPCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6736790", Offset = "0x6735790", VA = "0x186736790")]
	private void DMHLGCAFBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6736960", Offset = "0x6735960", VA = "0x186736960")]
	private void EABMMPOPPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x67361A0", Offset = "0x67351A0", VA = "0x1867361A0")]
	[CompilerGenerated]
	private object ACFHICFHKLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class NLFGLKLKEEN
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x67387A0", Offset = "0x67377A0", VA = "0x1867387A0")]
	public static LNNKAONFHLB CMMLPDHIIIA(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class CPAEAONJBJG : HCFFAPCJMCH, JEDBDICJFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly LAEIHEGEAJO<ILDIKLAHNAE> IMIEENPMOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool LCLCLOFANKN;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public LAEIHEGEAJO<ILDIKLAHNAE> BIEMDCIONNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 JANHLAEPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6720760", Offset = "0x671F760", VA = "0x186720760", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 PLIAFMEMALF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6720790", Offset = "0x671F790", VA = "0x186720790", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6720D90", Offset = "0x671FD90", VA = "0x186720D90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public ILDIKLAHNAE OEEFCKFFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6720CE0", Offset = "0x671FCE0", VA = "0x186720CE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6720EF0", Offset = "0x671FEF0", VA = "0x186720EF0")]
	public CPAEAONJBJG(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6720E80", Offset = "0x671FE80", VA = "0x186720E80", Slot = "8")]
	public void OAMCKFIDFGA(ILDIKLAHNAE MMPNPJILHCD, object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6720370", Offset = "0x671F370", VA = "0x186720370", Slot = "9")]
	public void BLFPGPILPNC(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x67203D0", Offset = "0x671F3D0", VA = "0x1867203D0")]
	private Vector3 CDJGPEKGHGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6720950", Offset = "0x671F950", VA = "0x186720950")]
	private void LBHBNEDHIGG(ILDIKLAHNAE LLFLBIJENFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class GLEPFPIPAGK
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x67288D0", Offset = "0x67278D0", VA = "0x1867288D0")]
	public static HCFFAPCJMCH CHEHHIJLFJD(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class CGNHAFNBKHK : BDDAMGNAMOA, OGAIKCGLNBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 JGKCLNJJNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 NMLADDAKKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float PPABFNHGLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float HNLAEKCCFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 OIDCFCAABOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? DKAAPFIKAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? FLIIALDLAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool ECKEFGCLOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool PJMBOBDDAKN;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 FMMPEGCLPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xBE2250", Offset = "0xBE1250", VA = "0x180BE2250", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x671F770", Offset = "0x671E770", VA = "0x18671F770", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 JFIPKICGPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x671F420", Offset = "0x671E420", VA = "0x18671F420", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float MDFKKONIBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x11F7CD0", Offset = "0x11F6CD0", VA = "0x1811F7CD0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x671FB00", Offset = "0x671EB00", VA = "0x18671FB00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float NOGOFMNHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xC725B0", Offset = "0xC715B0", VA = "0x180C725B0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x671FA50", Offset = "0x671EA50", VA = "0x18671FA50", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 IMIMAKDAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x671F820", Offset = "0x671E820", VA = "0x18671F820", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion FCLLIHLGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x671E510", Offset = "0x671D510", VA = "0x18671E510", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x671FF20", Offset = "0x671EF20", VA = "0x18671FF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event HHCCBDGDJEE OCMJCNDOMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x671F9B0", Offset = "0x671E9B0", VA = "0x18671F9B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x671F520", Offset = "0x671E520", VA = "0x18671F520", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x671FF70", Offset = "0x671EF70", VA = "0x18671FF70")]
	public CGNHAFNBKHK(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x671F5C0", Offset = "0x671E5C0", VA = "0x18671F5C0", Slot = "17")]
	public void JBFAOBEPMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x671EA10", Offset = "0x671DA10", VA = "0x18671EA10", Slot = "16")]
	public void FNOPPMCNOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x671FC10", Offset = "0x671EC10", VA = "0x18671FC10", Slot = "19")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x671E690", Offset = "0x671D690", VA = "0x18671E690", Slot = "20")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x671F2B0", Offset = "0x671E2B0", VA = "0x18671F2B0", Slot = "18")]
	public void ICDKKPLHEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x671EC70", Offset = "0x671DC70", VA = "0x18671EC70", Slot = "21")]
	public void HKPOMGHDOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x671F770", Offset = "0x671E770", VA = "0x18671F770")]
	private void OLBKOCFNAIM(Vector3 CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x671E920", Offset = "0x671D920", VA = "0x18671E920")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FJFOIDHKHFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x671FB00", Offset = "0x671EB00", VA = "0x18671FB00")]
	private void NLFNGKOLJHK(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x671FA50", Offset = "0x671EA50", VA = "0x18671FA50")]
	private void ODKGFCAFJBI(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x671F110", Offset = "0x671E110", VA = "0x18671F110")]
	private Vector3 HPGPDEFMDGA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x671FCF0", Offset = "0x671ECF0", VA = "0x18671FCF0", Slot = "15")]
	public void ODIOBMLMAIE((Quaternion rot, Vector3 moments) INBEAKEIFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x671EAF0", Offset = "0x671DAF0", VA = "0x18671EAF0")]
	private Quaternion GPHDCOJDFEK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x671D4F0", Offset = "0x671C4F0", VA = "0x18671D4F0")]
	public void BMOKMACMDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x671D5C0", Offset = "0x671C5C0", VA = "0x18671D5C0", Slot = "4")]
	public (float, Vector3) BMOKMACMDFI(Rigidbody HABMHABLJGK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class JPDBBBEFBKG
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6730F90", Offset = "0x672FF90", VA = "0x186730F90")]
	public static BDDAMGNAMOA DNDMMCGIKFA(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class NJPCJELMBHF : LHIDLBLFPCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly FCANMKLMDOK DAOLIJKFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly FAKPEAJNMEL LGOPBFADNKO;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool PGFFPIFGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xD6CF50", Offset = "0xD6BF50", VA = "0x180D6CF50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public FAKPEAJNMEL JJKOGMAJPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480", Slot = "11")]
		get
		{
			return default(FAKPEAJNMEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x67386A0", Offset = "0x67376A0", VA = "0x1867386A0")]
	public NJPCJELMBHF(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x67384B0", Offset = "0x67374B0", VA = "0x1867384B0", Slot = "4")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6738260", Offset = "0x6737260", VA = "0x186738260")]
	private bool GPHHGMOHKIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x67381F0", Offset = "0x67371F0", VA = "0x1867381F0", Slot = "5")]
	public void CGEMAAAOJBA(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x67381C0", Offset = "0x67371C0", VA = "0x1867381C0", Slot = "6")]
	public void CCGDPIODJJM(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6738080", Offset = "0x6737080", VA = "0x186738080", Slot = "9")]
	public void BJPJHCKMCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6738580", Offset = "0x6737580", VA = "0x186738580")]
	private void PLCMNNAEOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6738300", Offset = "0x6737300", VA = "0x186738300")]
	private void INJBLCFJLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6738220", Offset = "0x6737220", VA = "0x186738220", Slot = "8")]
	public void ECAPICMDCPE(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6738470", Offset = "0x6737470", VA = "0x186738470", Slot = "7")]
	public void JJDBJIIKLAH(ILDIKLAHNAE NKJKBALEEPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class POALIMBGEJH : LLNHEKLDBHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FCANMKLMDOK DBBCHOEKFJK;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool OGMADLJBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x673C9B0", Offset = "0x673B9B0", VA = "0x18673C9B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event HHCCBDGDJEE GAOOFNAHMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x673C710", Offset = "0x673B710", VA = "0x18673C710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x673CAF0", Offset = "0x673BAF0", VA = "0x18673CAF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x673CB90", Offset = "0x673BB90", VA = "0x18673CB90")]
	public POALIMBGEJH(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x673C940", Offset = "0x673B940", VA = "0x18673C940", Slot = "11")]
	public IDisposable HNLDFFOBHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x673C7F0", Offset = "0x673B7F0", VA = "0x18673C7F0", Slot = "8")]
	public void EKDAFPEPHEB(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x673CA60", Offset = "0x673BA60", VA = "0x18673CA60", Slot = "9")]
	public void MJLNPAECEJJ(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x673C800", Offset = "0x673B800", VA = "0x18673C800", Slot = "10")]
	public void FCCEGEBLECD(object OGACLNNOKDA, bool CPEKOFLDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x673C7B0", Offset = "0x673B7B0", VA = "0x18673C7B0", Slot = "6")]
	public void BLICLOIFIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x673CA70", Offset = "0x673BA70", VA = "0x18673CA70", Slot = "12")]
	public void NLGFKGKOAEE(Rigidbody GIOJGBHHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x673C910", Offset = "0x673B910", VA = "0x18673C910", Slot = "13")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class GDALJLDAECL : LOFPEJEGBIB, BAJHLENBDPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView HHGGIPAKDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool CPBPPNGFMIJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView BLNNACCEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool LGFCFPPBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6721FE0", Offset = "0x6720FE0", VA = "0x186721FE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool EHCCBJBEPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x8FE2D0", Offset = "0x8FD2D0", VA = "0x1808FE2D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event HHCCBDGDJEE GEEBKGBDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x67242F0", Offset = "0x67232F0", VA = "0x1867242F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6723D80", Offset = "0x6722D80", VA = "0x186723D80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x67247A0", Offset = "0x67237A0", VA = "0x1867247A0")]
	public GDALJLDAECL(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x6724670", Offset = "0x6723670", VA = "0x186724670", Slot = "9")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x6723E20", Offset = "0x6722E20", VA = "0x186723E20", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x6724500", Offset = "0x6723500", VA = "0x186724500", Slot = "10")]
	public void NDCIKMGKMOL(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x6724390", Offset = "0x6723390", VA = "0x186724390", Slot = "11")]
	public void LOCHBIPJNMJ(ILDIKLAHNAE MMPNPJILHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x6723C10", Offset = "0x6722C10", VA = "0x186723C10")]
	private void BOAKMMECPJA(PhotonView JLFGDNHDIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x6723F20", Offset = "0x6722F20", VA = "0x186723F20")]
	private void ENNBCLCPEFH(RigidbodyEx DPOBKNLFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x6724080", Offset = "0x6723080", VA = "0x186724080")]
	private void IKHPILMACPP(PhotonView DMDILNMLJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class FPENBOMHEDI
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x67235C0", Offset = "0x67225C0", VA = "0x1867235C0")]
	public static LOFPEJEGBIB BCKOKGCCALI(this ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class CNJCEDIOKHC : PKJAODKDPEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints EEKLAKLEJLM;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool GIOOKLGEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xB7E9D0", Offset = "0xB7D9D0", VA = "0x180B7E9D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3F20BD0", Offset = "0x3F1FBD0", VA = "0x183F20BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool CKIDBDMBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDE6EB0", Offset = "0xDE5EB0", VA = "0x180DE6EB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3F20BC0", Offset = "0x3F1FBC0", VA = "0x183F20BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints CDFDPCCNCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6720130", Offset = "0x671F130", VA = "0x186720130", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x67202C0", Offset = "0x671F2C0", VA = "0x1867202C0")]
	public CNJCEDIOKHC(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6720290", Offset = "0x671F290", VA = "0x186720290", Slot = "9")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6720260", Offset = "0x671F260", VA = "0x186720260", Slot = "10")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HJECAFAIMNJ : NJJOJJLMDHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly ILDIKLAHNAE NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float GDHIJDDIABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float ANEBNAPLIDD;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float OGLFLCBDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x942690", Offset = "0x941690", VA = "0x180942690", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6729210", Offset = "0x6728210", VA = "0x186729210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float KIMJDLKEBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F85B0", VA = "0x1809F95B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x67290F0", Offset = "0x67280F0", VA = "0x1867290F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x67292E0", Offset = "0x67282E0", VA = "0x1867292E0")]
	public HJECAFAIMNJ(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x67291C0", Offset = "0x67281C0", VA = "0x1867291C0", Slot = "8")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6729050", Offset = "0x6728050", VA = "0x186729050", Slot = "9")]
	public void FECOAHNCAJE(Rigidbody CODNGEHPHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class ICGAPJOKLEJ : LHNPGMILOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool PKFIPEGJJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool PJGBHBBJABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int NPOLBFFFLMF;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x671FF20", Offset = "0x671EF20", VA = "0x18671FF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool CEACOEPNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6729BE0", Offset = "0x6728BE0", VA = "0x186729BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private ILDIKLAHNAE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x67296C0", Offset = "0x67286C0", VA = "0x1867296C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6729720", Offset = "0x6728720", VA = "0x186729720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event HHCCBDGDJEE KGAAGDPJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6729910", Offset = "0x6728910", VA = "0x186729910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x67294D0", Offset = "0x67284D0", VA = "0x1867294D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6729DE0", Offset = "0x6728DE0", VA = "0x186729DE0")]
	public ICGAPJOKLEJ(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6729C00", Offset = "0x6728C00", VA = "0x186729C00", Slot = "6")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6729C90", Offset = "0x6728C90", VA = "0x186729C90", Slot = "8")]
	public void OHJJJFJLHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6729570", Offset = "0x6728570", VA = "0x186729570", Slot = "7")]
	public bool DBKIMDDEKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x6729CA0", Offset = "0x6728CA0", VA = "0x186729CA0", Slot = "9")]
	public void PLAKGKFOOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6729D40", Offset = "0x6728D40", VA = "0x186729D40", Slot = "11")]
	public void PNNBKBPGHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6729B90", Offset = "0x6728B90", VA = "0x186729B90", Slot = "12")]
	public void KMNFOBBGJMI(bool ONAEAHOIGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6729320", Offset = "0x6728320", VA = "0x186729320", Slot = "10")]
	public void BFOPBGOCLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x67299B0", Offset = "0x67289B0", VA = "0x1867299B0")]
	private bool JDIDDBKLJIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6729780", Offset = "0x6728780", VA = "0x186729780")]
	private void HMDBENONIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class HLJDENAHPCL : MIBKGKEEDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly FCANMKLMDOK ILHNDFMIFIH;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody ELABPCOIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool JFNDJNMJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6743980", Offset = "0x6742980", VA = "0x186743980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool CJLLIIAHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xD6CF50", Offset = "0xD6BF50", VA = "0x180D6CF50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6744440", Offset = "0x6743440", VA = "0x186744440")]
	public HLJDENAHPCL(ILDIKLAHNAE NKJKBALEEPO, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6744220", Offset = "0x6743220", VA = "0x186744220", Slot = "5")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x67437A0", Offset = "0x67427A0", VA = "0x1867437A0", Slot = "7")]
	public void DKEGMLMFEBP(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x67437D0", Offset = "0x67427D0", VA = "0x1867437D0", Slot = "8")]
	public void DKNNLFNCMBE(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x67434D0", Offset = "0x67424D0", VA = "0x1867434D0", Slot = "9")]
	public void BILHKELEOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x6743B20", Offset = "0x6742B20", VA = "0x186743B20", Slot = "11")]
	public void MELKIANENHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x67442C0", Offset = "0x67432C0", VA = "0x1867442C0", Slot = "12")]
	public void OFGPEHLCAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6743D10", Offset = "0x6742D10", VA = "0x186743D10", Slot = "10")]
	public void MNNILOOKCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x67439A0", Offset = "0x67429A0", VA = "0x1867439A0")]
	private void JKCAHMMBMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6743800", Offset = "0x6742800", VA = "0x186743800")]
	private void FJMNBFMNONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LGCFNCBLGDC : EIMEDLCKGGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly JAOIINDNBLA NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly FCANMKLMDOK EPPHOPECHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float ELFCNDMNJCN;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public NKDEEAAMDMA BPAFPHPPKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public AMIBEJPKIDH NDLMELBILOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 NGALCBILBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6747070", Offset = "0x6746070", VA = "0x186747070", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x67453E0", Offset = "0x67443E0", VA = "0x1867453E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 JKPBJINJMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6744FC0", Offset = "0x6743FC0", VA = "0x186744FC0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6744F90", Offset = "0x6743F90", VA = "0x186744F90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 LMHNBECBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6746AE0", Offset = "0x6745AE0", VA = "0x186746AE0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x67463B0", Offset = "0x67453B0", VA = "0x1867463B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 CHFAKPFLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x67469C0", Offset = "0x67459C0", VA = "0x1867469C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6746AB0", Offset = "0x6745AB0", VA = "0x186746AB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float NDKCAILNKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x97BA10", Offset = "0x97AA10", VA = "0x18097BA10", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6746910", Offset = "0x6745910", VA = "0x186746910", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool DLOKEIFCHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x1715AF0", Offset = "0x1714AF0", VA = "0x181715AF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private AFHCMCCOEML CJJBOGBGKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x60426F0", Offset = "0x60416F0", VA = "0x1860426F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool CEACOEPNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x67342B0", Offset = "0x67332B0", VA = "0x1867342B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6747480", Offset = "0x6746480", VA = "0x186747480")]
	public LGCFNCBLGDC(ILDIKLAHNAE NKJKBALEEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6745EC0", Offset = "0x6744EC0", VA = "0x186745EC0", Slot = "19")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6745380", Offset = "0x6744380", VA = "0x186745380", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6746CB0", Offset = "0x6745CB0", VA = "0x186746CB0", Slot = "28")]
	public void NLGFKGKOAEE(Rigidbody CODNGEHPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xBBA7D0", Offset = "0xBB97D0", VA = "0x180BBA7D0", Slot = "20")]
	public void PLCOEMDJPIG(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xBBBB00", Offset = "0xBBAB00", VA = "0x180BBBB00", Slot = "30")]
	public void FFHGKAJGJPF(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6746630", Offset = "0x6745630", VA = "0x186746630", Slot = "35")]
	public Vector3 JLGIOOPPGFC(Vector3 OAHPAFLLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6747190", Offset = "0x6746190", VA = "0x186747190", Slot = "34")]
	public Vector3 OJGBFLGJIAG(Vector3 GLKDHNFFAGC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6745EC0", Offset = "0x6744EC0", VA = "0x186745EC0", Slot = "27")]
	public void IAIKOJBEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6745D30", Offset = "0x6744D30", VA = "0x186745D30", Slot = "25")]
	public void HGEENGLFPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6745930", Offset = "0x6744930", VA = "0x186745930", Slot = "24")]
	public void GICLCPMKNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x67472E0", Offset = "0x67462E0", VA = "0x1867472E0", Slot = "33")]
	public void PEHANBEDGJI(Vector3 ELGAAJCHPGG, Vector3 HGMCPJMHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6747010", Offset = "0x6746010", VA = "0x186747010", Slot = "32")]
	public void NOJOIFGIPPI(Vector3 MIMCMCHALAJ, Vector3 KDNIBMMAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x67467A0", Offset = "0x67457A0", VA = "0x1867467A0", Slot = "31")]
	public void KJIIOMDLAFE(Vector3 CNDIDFEDOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6744960", Offset = "0x6743960", VA = "0x186744960", Slot = "22")]
	public void APJCNDOFAFP(FGKPNCIPHBC KAFPMNGBOHA, Vector3 LMBMKLKKHMO, float CHLLOIGHIBO, float JMEGDFBOCGJ = 8f, float KJNNEICCMKJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6746D80", Offset = "0x6745D80", VA = "0x186746D80", Slot = "21")]
	public void NLIIPEKIGCK(GMAHCCPGLOO NOJIOFCMCEI, Vector3 HLOJJBHMOMP, float PBDCKDMFAAN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6745990", Offset = "0x6744990", VA = "0x186745990", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GMENALKAHJA(GMAHCCPGLOO NOJIOFCMCEI, Vector3 GOAHENPPMCD, float BDENAAOPGFC = 7f, float IFJFKANFMBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x67450B0", Offset = "0x67440B0", VA = "0x1867450B0", Slot = "29")]
	public Vector3 CLHAALPDBMF(Vector3 JKBHKGAJHBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6745D90", Offset = "0x6744D90", VA = "0x186745D90", Slot = "26")]
	public void HIMGANPJKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6746910", Offset = "0x6745910", VA = "0x186746910")]
	private void LCMPPGMCEPH(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6745210", Offset = "0x6744210", VA = "0x186745210")]
	private void CNFGOLBHOEP(Vector3 HLOJJBHMOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6746470", Offset = "0x6745470", VA = "0x186746470")]
	private Vector3 IOBIENALLHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6744500", Offset = "0x6743500", VA = "0x186744500")]
	private void AHLLEALBDCN(Vector3 GLKDHNFFAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6746550", Offset = "0x6745550", VA = "0x186746550")]
	private Vector3 JCCKHKJNFME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6745F70", Offset = "0x6744F70", VA = "0x186745F70")]
	private void IMNNFPJPBDL(Vector3 CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x67454A0", Offset = "0x67444A0", VA = "0x1867454A0")]
	private void FDIPPFJMGFM(Vector3 GLKDHNFFAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6746C00", Offset = "0x6745C00", VA = "0x186746C00")]
	private void MIKLKADBGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BBGNFHAIIEN : OGAAPOKMDEM
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6743470", Offset = "0x6742470", VA = "0x186743470", Slot = "4")]
	public OKJIHJLLPCC PDGNDPNABDC(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6743390", Offset = "0x6742390", VA = "0x186743390", Slot = "5")]
	public EIMEDLCKGGP MMIFGHICLDF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6743050", Offset = "0x6742050", VA = "0x186743050", Slot = "6")]
	public JEDBDICJFMB DFKLNAKHLKD(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6742E50", Offset = "0x6741E50", VA = "0x186742E50", Slot = "7")]
	public NJJOJJLMDHA ANABDHKOBLP(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6743120", Offset = "0x6742120", VA = "0x186743120", Slot = "8")]
	public LHNPGMILOFB EGELLNKBJLK(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x67432D0", Offset = "0x67422D0", VA = "0x1867432D0", Slot = "9")]
	public LDFNINBNHKI HBKAKEIBKMJ(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6743330", Offset = "0x6742330", VA = "0x186743330", Slot = "10")]
	public LLNHEKLDBHN JJMDGGIHJAE(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6742F90", Offset = "0x6741F90", VA = "0x186742F90", Slot = "11")]
	public AFHCMCCOEML CPFFPEAMBOL(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6743270", Offset = "0x6742270", VA = "0x186743270", Slot = "12")]
	public PIIJCHPHOFC FMOKPDJEHBN(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6742FF0", Offset = "0x6741FF0", VA = "0x186742FF0", Slot = "13")]
	public JPOIHLJEDKK DAAJHLKLIHF(ILDIKLAHNAE GINEIDDJABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6743180", Offset = "0x6742180", VA = "0x186743180")]
	public MIBKGKEEDAB EMLGCECJHAH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6742DE0", Offset = "0x6741DE0", VA = "0x186742DE0")]
	public BAJHLENBDPO AGNFFPPGGKK(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6742EB0", Offset = "0x6741EB0", VA = "0x186742EB0")]
	public LHIDLBLFPCN BEHNJGFMDBB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x67430B0", Offset = "0x67420B0", VA = "0x1867430B0")]
	public OGAIKCGLNBJ OKNBELHPCCC(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6742F20", Offset = "0x6741F20", VA = "0x186742F20")]
	public PKJAODKDPEK OEFDJKLCOEB(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6742D30", Offset = "0x6741D30", VA = "0x186742D30", Slot = "19")]
	public ILDIKLAHNAE ABONLEEELFL(RigidbodyEx NKJKBALEEPO, MMNBKIDMPFN ELANMAGHLLI, ABCMFLEOCJP JDIOCIOLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BBGNFHAIIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6743180", Offset = "0x6742180", VA = "0x186743180", Slot = "14")]
	private MIBKGKEEDAB LDCJLIHMBPP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6742DE0", Offset = "0x6741DE0", VA = "0x186742DE0", Slot = "15")]
	private BAJHLENBDPO IENLOMPJMFP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6742EB0", Offset = "0x6741EB0", VA = "0x186742EB0", Slot = "16")]
	private LHIDLBLFPCN GLGFBHEANJH(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x67430B0", Offset = "0x67420B0", VA = "0x1867430B0", Slot = "17")]
	private OGAIKCGLNBJ EECCAOMFHIP(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6742F20", Offset = "0x6741F20", VA = "0x186742F20", Slot = "18")]
	private PKJAODKDPEK BLPKFIOIJBD(ILDIKLAHNAE GINEIDDJABE, [In] MMNBKIDMPFN ELANMAGHLLI)
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
