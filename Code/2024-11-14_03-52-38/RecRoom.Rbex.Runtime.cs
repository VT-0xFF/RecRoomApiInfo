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
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73E5110", Offset = "0x73E4510", VA = "0x1873E5110", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GJMDKLGBNPE bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x196B590", Offset = "0x196A990", VA = "0x18196B590", Slot = "5")]
		public override void OBCDFIPOOMH(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73EC360", Offset = "0x73EB760", VA = "0x1873EC360")]
		private void FEFAONLMCEI(EIHEMDGDPGL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73EC300", Offset = "0x73EB700", VA = "0x1873EC300", Slot = "6")]
		public override void ANGIPMGEHBC(EIHEMDGDPGL registry, [In] JJHLKKIELHB filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73EC670", Offset = "0x73EBA70", VA = "0x1873EC670")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, GGMPLOAKJOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LDGDBHIGNCI FAICKMBGGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool NEOAPLEDBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private HKDIFKBEBMP ECINNEDPLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[BLMMAJBEPMF(AHBKOCJDDCB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[BLMMAJBEPMF(AHBKOCJDDCB.SelfAndParent, true, false, false)]
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
		private LBCHOGGNAFE physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal HKDIFKBEBMP MHKIBMGFPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x73E7A80", Offset = "0x73E6E80", VA = "0x1873E7A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HKDIFKBEBMP LFFDEFEJGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AMIMIMNBGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x73E9810", Offset = "0x73E8C10", VA = "0x1873E9810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx AJDCAPNPLBN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x73E9B70", Offset = "0x73E8F70", VA = "0x1873E9B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FNBAEIOODBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x73E9AB0", Offset = "0x73E8EB0", VA = "0x1873E9AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx EGIKLIBGODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x73EA770", Offset = "0x73E9B70", VA = "0x1873EA770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x73EBC70", Offset = "0x73EB070", VA = "0x1873EBC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform GNLHOACFAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C4A70", Offset = "0x8C3E70", VA = "0x1808C4A70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MEFPNBMPODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C4A70", Offset = "0x8C3E70", VA = "0x1808C4A70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ANFACPGMLCA HKCEJCLAHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x73E9870", Offset = "0x73E8C70", VA = "0x1873E9870")]
			get
			{
				return default(ANFACPGMLCA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x73EB420", Offset = "0x73EA820", VA = "0x1873EB420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MLGELLDCGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x73E9E80", Offset = "0x73E9280", VA = "0x1873E9E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CFLNEBNLFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x73E9990", Offset = "0x73E8D90", VA = "0x1873E9990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JGADIIFMHNB GONEKALALBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x73E9DC0", Offset = "0x73E91C0", VA = "0x1873E9DC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x73EB5E0", Offset = "0x73EA9E0", VA = "0x1873EB5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NFNPCOLDFJK BFENLNOLEDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x73E9D60", Offset = "0x73E9160", VA = "0x1873E9D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x73EB570", Offset = "0x73EA970", VA = "0x1873EB570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GBAJAELKAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x73E9CB0", Offset = "0x73E90B0", VA = "0x1873E9CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody HHKNFHDMAFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x73E9D10", Offset = "0x73E9110", VA = "0x1873E9D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AHAPIMBJFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x73E99F0", Offset = "0x73E8DF0", VA = "0x1873E99F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x73EB490", Offset = "0x73EA890", VA = "0x1873EB490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PNNEPNJNLAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x70B5D10", Offset = "0x70B5110", VA = "0x1870B5D10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HONMLFBLEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x73EA710", Offset = "0x73E9B10", VA = "0x1873EA710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float MIEENKIDIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x73EA6B0", Offset = "0x73E9AB0", VA = "0x1873EA6B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x73EBC00", Offset = "0x73EB000", VA = "0x1873EBC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HHFMDKJOKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x73EA0E0", Offset = "0x73E94E0", VA = "0x1873EA0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x73EB880", Offset = "0x73EAC80", VA = "0x1873EB880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LCLJDBKEPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x73E9EE0", Offset = "0x73E92E0", VA = "0x1873E9EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x73EB650", Offset = "0x73EAA50", VA = "0x1873EB650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool JIJEDOEGLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x73EACC0", Offset = "0x73EA0C0", VA = "0x1873EACC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x73EC1B0", Offset = "0x73EB5B0", VA = "0x1873EC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 LEKNJLKLEOL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x73EA490", Offset = "0x73E9890", VA = "0x1873EA490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x73EB9D0", Offset = "0x73EADD0", VA = "0x1873EB9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 ILKJGHLKNJL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x73EAE00", Offset = "0x73EA200", VA = "0x1873EAE00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode GHOIMOHGOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x73EA020", Offset = "0x73E9420", VA = "0x1873EA020")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x73EB7A0", Offset = "0x73EABA0", VA = "0x1873EB7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FMLBAIKODKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x73E9A50", Offset = "0x73E8E50", VA = "0x1873E9A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x73EB500", Offset = "0x73EA900", VA = "0x1873EB500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints ABJLOMHPHIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x73EA080", Offset = "0x73E9480", VA = "0x1873EA080")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x73EB810", Offset = "0x73EAC10", VA = "0x1873EB810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 PNICBJPJPFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x73EA830", Offset = "0x73E9C30", VA = "0x1873EA830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LFLGBLJBCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x73EA830", Offset = "0x73E9C30", VA = "0x1873EA830")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x73EBF90", Offset = "0x73EB390", VA = "0x1873EBF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GDEBPFOLHKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x73EA570", Offset = "0x73E9970", VA = "0x1873EA570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x73EBAB0", Offset = "0x73EAEB0", VA = "0x1873EBAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DDBDPCNAGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x73EAC60", Offset = "0x73EA060", VA = "0x1873EAC60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x73EC140", Offset = "0x73EB540", VA = "0x1873EC140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion EFKIAMGHGGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x73EA910", Offset = "0x73E9D10", VA = "0x1873EA910")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x73EBD10", Offset = "0x73EB110", VA = "0x1873EBD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PFIIJNABFJM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x73EAB90", Offset = "0x73E9F90", VA = "0x1873EAB90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x73EC070", Offset = "0x73EB470", VA = "0x1873EC070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 CKILJDFGHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x73EA9E0", Offset = "0x73E9DE0", VA = "0x1873EA9E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x73EBDE0", Offset = "0x73EB1E0", VA = "0x1873EBDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GAPJODEGGDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x73EAAC0", Offset = "0x73E9EC0", VA = "0x1873EAAC0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x73EBEC0", Offset = "0x73EB2C0", VA = "0x1873EBEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 IKJAACJPELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x73EAD20", Offset = "0x73EA120", VA = "0x1873EAD20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x73EC220", Offset = "0x73EB620", VA = "0x1873EC220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NCEDMGGIAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x73EA5D0", Offset = "0x73E99D0", VA = "0x1873EA5D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x73EBB20", Offset = "0x73EAF20", VA = "0x1873EBB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EACBDNMKAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x73E9F40", Offset = "0x73E9340", VA = "0x1873E9F40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x73EB6C0", Offset = "0x73EAAC0", VA = "0x1873EB6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DMEKBAFACHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x73EA3B0", Offset = "0x73E97B0", VA = "0x1873EA3B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x73EB8F0", Offset = "0x73EACF0", VA = "0x1873EB8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 ECGNFJABGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x73EA270", Offset = "0x73E9670", VA = "0x1873EA270")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion NHLPKBJPNKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x73EA1A0", Offset = "0x73E95A0", VA = "0x1873EA1A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KKHBJJINLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x73EAFC0", Offset = "0x73EA3C0", VA = "0x1873EAFC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 PGHOHDLJGIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x73EAEE0", Offset = "0x73EA2E0", VA = "0x1873EAEE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GMBGIFAPLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x73EA350", Offset = "0x73E9750", VA = "0x1873EA350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IDDCNCNGCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x73E9E20", Offset = "0x73E9220", VA = "0x1873E9E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool PLGBBHFLLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x73E9930", Offset = "0x73E8D30", VA = "0x1873E9930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MAMNIAOCFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x73E98D0", Offset = "0x73E8CD0", VA = "0x1873E98D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DGEDNINFDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x73E97B0", Offset = "0x73E8BB0", VA = "0x1873E97B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JOMJFAOFLFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x73EA140", Offset = "0x73E9540", VA = "0x1873EA140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PEHHLBMDPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1BF05F0", Offset = "0x1BEF9F0", VA = "0x181BF05F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JBPGLKNNDNO LGIMCPKEONP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x73E96D0", Offset = "0x73E8AD0", VA = "0x1873E96D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x73EB340", Offset = "0x73EA740", VA = "0x1873EB340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MLHLBDFCGLG LFLDDJGDHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x73E9440", Offset = "0x73E8840", VA = "0x1873E9440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x73EB0A0", Offset = "0x73EA4A0", VA = "0x1873EB0A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MLHLBDFCGLG FONFFHGDODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x73E94A0", Offset = "0x73E88A0", VA = "0x1873E94A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x73EB110", Offset = "0x73EA510", VA = "0x1873EB110")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MLHLBDFCGLG BNJPEEHCKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x73E95F0", Offset = "0x73E89F0", VA = "0x1873E95F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x73EB260", Offset = "0x73EA660", VA = "0x1873EB260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<IHJDLPBPHOK, IHJDLPBPHOK> ABFNMAHNJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x73E9580", Offset = "0x73E8980", VA = "0x1873E9580")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x73EB1F0", Offset = "0x73EA5F0", VA = "0x1873EB1F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MLHLBDFCGLG MAIGNNBIEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x73E9660", Offset = "0x73E8A60", VA = "0x1873E9660")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x73EB2D0", Offset = "0x73EA6D0", VA = "0x1873EB2D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MLHLBDFCGLG OKNEBMKMFIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x73E9740", Offset = "0x73E8B40", VA = "0x1873E9740")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x73EB3B0", Offset = "0x73EA7B0", VA = "0x1873EB3B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MLHLBDFCGLG KEHKOJJDCDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x73E9510", Offset = "0x73E8910", VA = "0x1873E9510")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x73EB180", Offset = "0x73EA580", VA = "0x1873EB180")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0", Slot = "8")]
		private void AMLHNJJDBFB(HKDIFKBEBMP KPECMEHKPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73E79F0", Offset = "0x73E6DF0", VA = "0x1873E79F0")]
		internal void BGIPCFACPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73E9160", Offset = "0x73E8560", VA = "0x1873E9160")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody BPFHLMMFDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x73E7D10", Offset = "0x73E7110", VA = "0x1873E7D10")]
		public GGMPLOAKJOK GetChild(int OBFJPFHENMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73E8E30", Offset = "0x73E8230", VA = "0x1873E8E30")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DGCFGNPKEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x73E7980", Offset = "0x73E6D80", VA = "0x1873E7980")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73E7A80", Offset = "0x73E6E80", VA = "0x1873E7A80")]
		private HKDIFKBEBMP BHFGHAHLEII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73E8330", Offset = "0x73E7730", VA = "0x1873E8330")]
		private void MABFCCPGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73E8600", Offset = "0x73E7A00", VA = "0x1873E8600")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73E79F0", Offset = "0x73E6DF0", VA = "0x1873E79F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73E85A0", Offset = "0x73E79A0", VA = "0x1873E85A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73E8660", Offset = "0x73E7A60", VA = "0x1873E8660")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73E6FD0", Offset = "0x73E63D0", VA = "0x1873E6FD0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x73E86C0", Offset = "0x73E7AC0", VA = "0x1873E86C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73E7CB0", Offset = "0x73E70B0", VA = "0x1873E7CB0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73E8540", Offset = "0x73E7940", VA = "0x1873E8540")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73E8F90", Offset = "0x73E8390", VA = "0x1873E8F90")]
		public void SetParent(RigidbodyEx PFKKDHPJFEH, bool MLNLBIHIEHJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73E89D0", Offset = "0x73E7DD0", VA = "0x1873E89D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73E7FC0", Offset = "0x73E73C0", VA = "0x1873E7FC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx EGLNDOFLNGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x73E80C0", Offset = "0x73E74C0", VA = "0x1873E80C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx FHIJFNGMHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73E7240", Offset = "0x73E6640", VA = "0x1873E7240")]
		public void AddInterpolationRestriction(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x73E8730", Offset = "0x73E7B30", VA = "0x1873E8730")]
		public void RemoveInterpolationRestriction(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x73E72B0", Offset = "0x73E66B0", VA = "0x1873E72B0")]
		public void AddKinematic(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73E87A0", Offset = "0x73E7BA0", VA = "0x1873E87A0")]
		public void RemoveKinematic(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x73E8F10", Offset = "0x73E8310", VA = "0x1873E8F10")]
		public void SetKinematic(object CFGHNHCDKCN, bool OKKKKJJNIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73E8D30", Offset = "0x73E8130", VA = "0x1873E8D30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 HJBINIGDCLK, Quaternion KAMPEILJKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x73E8C30", Offset = "0x73E8030", VA = "0x1873E8C30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ANNAOFBODDH, Quaternion FDJADOGDNFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x73E7EB0", Offset = "0x73E72B0", VA = "0x1873E7EB0")]
		public Vector3 GetConstrainedVelocity(Vector3 IKJAACJPELI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x73E7DA0", Offset = "0x73E71A0", VA = "0x1873E7DA0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 EACBDNMKAIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73E7150", Offset = "0x73E6550", VA = "0x1873E7150")]
		public void AddForce(Vector3 DLFLBGAHCIJ, ForceMode GLHDCBJCKHK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x73E7040", Offset = "0x73E6440", VA = "0x1873E7040")]
		public void AddForceAtPosition(Vector3 DLFLBGAHCIJ, Vector3 OGKCMCMHLOD, ForceMode GLHDCBJCKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73E7480", Offset = "0x73E6880", VA = "0x1873E7480")]
		public void AddTorque(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x73E7320", Offset = "0x73E6720", VA = "0x1873E7320")]
		public void AddRelativeTorque(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x73E9230", Offset = "0x73E8630", VA = "0x1873E9230")]
		public Vector3 WorldToLocalVelocity(Vector3 MCDPEFCAPKN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x73E8220", Offset = "0x73E7620", VA = "0x1873E8220")]
		public Vector3 LocalToWorldVelocity(Vector3 NCEDMGGIAPH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73E7C50", Offset = "0x73E7050", VA = "0x1873E7C50")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73E7BF0", Offset = "0x73E6FF0", VA = "0x1873E7BF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73E7B90", Offset = "0x73E6F90", VA = "0x1873E7B90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x73E7B30", Offset = "0x73E6F30", VA = "0x1873E7B30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73E8B30", Offset = "0x73E7F30", VA = "0x1873E8B30")]
		public void ResetVelocityWorldSpace(Vector3 ICIJNFBIOEN, Vector3 ANCDBKAOBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73E8A30", Offset = "0x73E7E30", VA = "0x1873E8A30")]
		public void ResetVelocityLocalSpace(Vector3 ANBMKABKKPA, Vector3 DMEKBAFACHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73E88F0", Offset = "0x73E7CF0", VA = "0x1873E88F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 ANBMKABKKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73E90C0", Offset = "0x73E84C0", VA = "0x1873E90C0")]
		public bool SweepTest(Vector3 KACCFANBELL, [Out] RaycastHit BCHHBPDKLIH, float ILHNKLAHFJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x73E81C0", Offset = "0x73E75C0", VA = "0x1873E81C0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x73E9060", Offset = "0x73E8460", VA = "0x1873E9060")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73E91D0", Offset = "0x73E85D0", VA = "0x1873E91D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73E7410", Offset = "0x73E6810", VA = "0x1873E7410")]
		public void AddShouldHaveUnityRigidbodyToken(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x73E8810", Offset = "0x73E7C10", VA = "0x1873E8810")]
		public void RemoveShouldHaveUnityRigidbodyToken(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x73E7810", Offset = "0x73E6C10", VA = "0x1873E7810")]
		public void ApplyForceVelocityChange(LADAGGDBJHL CLCHGDOCDDH, Vector3 FFDFPMPCHEI, float GEECNNECJKN, float MGMDBIPLJFO = 8f, float FNHLIFEMKMD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x73E7710", Offset = "0x73E6B10", VA = "0x1873E7710")]
		public void ApplyAngularVelocityChange(CFCMEAFAOKP KEGBOAJEGKA, Vector3 LOFJNONIDID, float CKLBOKLDFBK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x73E78D0", Offset = "0x73E6CD0", VA = "0x1873E78D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CFCMEAFAOKP KEGBOAJEGKA, Vector3 GEMHEIIKJKD, float ADLJPIBPOHJ = 7f, float BNLPMLLPELO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73E7640", Offset = "0x73E6A40", VA = "0x1873E7640")]
		public bool AllowedScaleChange(float LOJPFHOMPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x73E7570", Offset = "0x73E6970", VA = "0x1873E7570")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KMDDBAOCCLO, object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x73E8880", Offset = "0x73E7C80", VA = "0x1873E8880")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x73E93D0", Offset = "0x73E87D0", VA = "0x1873E93D0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCF74A0", Offset = "0xCF68A0", VA = "0x180CF74A0", Slot = "4")]
		private GameObject KMMFJIAJAEF()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A70", Offset = "0x8C3E70", VA = "0x1808C4A70", Slot = "5")]
		private Transform OMEJFADPIJI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class PCLLBLAMPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x73E6A50", Offset = "0x73E5E50", VA = "0x1873E6A50")]
	public static HKDIFKBEBMP MHKIBMGFPMF(this RigidbodyEx FPJKEICLJKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CHJBJNKJDOP(typeof(IIPEKPAHCOG), new string[] { })]
public class KMBJGOMOLIG : IIPEKPAHCOG, FCIAIGPFFOD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DNIJJIEOOJJ CCLCLDNFAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JAPOBJJEIFJ OJNJHJENDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JMOBAILLAKP BJGBIGPCGLO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JAPOBJJEIFJ MOAAGKMJBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JMOBAILLAKP PHDODKKNDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x73E4EA0", Offset = "0x73E42A0", VA = "0x1873E4EA0", Slot = "7")]
	public void InitReferences(IBAFIPOHFKD DAMMHANOFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73E4F30", Offset = "0x73E4330", VA = "0x1873E4F30", Slot = "6")]
	public HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public KMBJGOMOLIG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static BDDIJCFMLKF UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static BDDIJCFMLKF AfterSyncTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HONHMHPDDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MEPGJHECEML;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x73E6D80", Offset = "0x73E6180", VA = "0x1873E6D80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73E6E20", Offset = "0x73E6220", VA = "0x1873E6E20")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73E6DA0", Offset = "0x73E61A0", VA = "0x1873E6DA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NFKMLKNHFEM, [Optional] UnityEngine.Object EPLPPJHJIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NFKMLKNHFEM, [Optional] UnityEngine.Object EPLPPJHJIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73E6F80", Offset = "0x73E6380", VA = "0x1873E6F80")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CKHEEDOGCLH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MPDDDMIAFEE : JGADIIFMHNB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AB870", Offset = "0x8AAC70", VA = "0x1808AB870", Slot = "4")]
		public Vector3 GDDJCKPOBBC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AB870", Offset = "0x8AAC70", VA = "0x1808AB870", Slot = "5")]
		public Vector3 AEOLDGKNKAI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MPDDDMIAFEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static JGADIIFMHNB DJPGMPPNDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x73D9EF0", Offset = "0x73D92F0", VA = "0x1873D9EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LKGIKHOHLDF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode ICPKCFKKOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AACGCJBPOLK(bool GMBGIFAPLDB);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGLAOBNNEHN(bool GMBGIFAPLDB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LDFPLLCMAIE(Vector3 KACCFANBELL, [Out] RaycastHit BCHHBPDKLIH, float ILHNKLAHFJF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JFGEEPLCPIH : IDisposable, EJMLOLLHGGF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ANFACPGMLCA HKCEJCLAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<IHJDLPBPHOK, IHJDLPBPHOK> ABFNMAHNJIO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNBPIPDBJBN();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BHGMCJGNNFL(DHFJHHJLOFA.Application)]
public interface JMOBAILLAKP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APKEIIIDLHN JPAAIAPBCCF(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MDNHPPBIBJE NLLBIHIDMIK(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HLFPNHKEKBN BLKLMPFDPOM(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMMNLNDENJL CEIEHICGIAC(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NADFILPIABG DBFBIMFMHMI(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JFGEEPLCPIH DJHBJGJCALM(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FBEOHGHPPNK NINEDNCCACM(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CCJBPPKOBJE NHJECGNJGHL(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LKGIKHOHLDF JOHMPLNBJAC(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EDFNMALNEOC KALMDNEFBEE(HKDIFKBEBMP KPECMEHKPOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NAMOCPIEMPB MHFIKCLEGOG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HJNODMAMOKO DFHMFOMAIEA(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DKBNKCAHHFN LEKMENKNKMF(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KAOBCIMHGFB MLNFOEEMBGG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HIEDKGMACOF NLFLBOAMIOM(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK, IIPEKPAHCOG EGAKDMHOMDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CCJBPPKOBJE
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFDCCLLAIC(Vector3 DLFLBGAHCIJ, ForceMode GLHDCBJCKHK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHNOJFKLDHD(Vector3 DLFLBGAHCIJ, Vector3 OGKCMCMHLOD, ForceMode GLHDCBJCKHK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLKJJAIAFPI(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGFNJBJPKOP(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EDFNMALNEOC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool BOOKHCFIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMAFAADFHHD(Rigidbody FNNMNPJOBEB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface APKEIIIDLHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<HKDIFKBEBMP> KHINAAJAMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HKDIFKBEBMP FNBAEIOODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HKDIFKBEBMP LHNCJNMLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MLHLBDFCGLG LFLDDJGDHEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MLHLBDFCGLG FONFFHGDODO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JBPGLKNNDNO POPHHAKNLCF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IFKMIILCAPP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HNPIDFMIAJH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<HKDIFKBEBMP> CFODMFEMHLI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HKDIFKBEBMP> PHAPHKNGLOG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action FJEKOPABPFM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<HKDIFKBEBMP> HJPGEJGNKGM;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LKNHCHKPADJ(HKDIFKBEBMP AFFIPMDDGDD, bool MLNLBIHIEHJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HLFPNHKEKBN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 FDOJLPBBAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 CABCDOFNHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGMFBCLBOPC(HKDIFKBEBMP EGIKLIBGODG, object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAOOICJEFCC(object CFGHNHCDKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KAOBCIMHGFB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 HKNFDKPGOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 AJGGHDNOEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float PAOILGPJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float KEFPPHFPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 GABNKBKEJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion AADOLGAHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MLHLBDFCGLG IENBJKADNBF;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KFDANBJJKHC((Quaternion rot, Vector3 moments) DGCFGNPKEOF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BPJOCABFGBB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MBOHMNHKGJI();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HIJCGLHHLMG();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NMAFAADFHHD(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FEPCMIOGOPI();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DKBNKCAHHFN
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFHGNHEGHLG(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNPKFHHENOK(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMHAOBDNIJE(HKDIFKBEBMP FPJKEICLJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KALMKBPDBMG(HKDIFKBEBMP FPJKEICLJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEMJOAIMPCN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FBEOHGHPPNK
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FFOGONKGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MLHLBDFCGLG FBBBHBCOAPJ;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCJEHALBGGD(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFMCJLCCAFA(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGBGGPAPCMM(object CFGHNHCDKCN, bool OKKKKJJNIGK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGNGMGAHADF(Rigidbody GGEKFKJPDOC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMAFAADFHHD(Rigidbody FNNMNPJOBEB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HJNODMAMOKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MLGELLDCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CFLNEBNLFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MLHLBDFCGLG PIBACLNHFKK;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BEPKNLMMMOI(HKDIFKBEBMP EGIKLIBGODG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHDONLDEJBF(HKDIFKBEBMP EGIKLIBGODG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HIEDKGMACOF
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AHAPIMBJFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HLANAKLFGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints PEIIHEFBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMAFAADFHHD(Rigidbody FNNMNPJOBEB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MMMNLNDENJL
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float HLBCAJHJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float GFIGIDPIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMAFAADFHHD(Rigidbody FNNMNPJOBEB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NADFILPIABG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MLHLBDFCGLG AAPJMLNJNAB;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NCKENIOIBBL();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMOLKGGOGDJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIEPEKOHBMI();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGAGMNNBJON();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHGGJGOBLGI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NAMOCPIEMPB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FDABBIDEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCDKHIDMEEB(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GADNNNEIGCM(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBCJCGIKCPB();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MDNHPPBIBJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JGADIIFMHNB GONEKALALBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NFNPCOLDFJK BFENLNOLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 JNPJEMFPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 KNIIKHMBOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 HNNLGFKOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 CKMDOFGFLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float FMLBAIKODKC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GBAJAELKAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NNBPIPDBJBN();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KCIHNDFKLDF(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BGOGGHHKGAG(CFCMEAFAOKP KEGBOAJEGKA, Vector3 LOFJNONIDID, float CKLBOKLDFBK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ANGLLDKFJGH(LADAGGDBJHL CLCHGDOCDDH, Vector3 FFDFPMPCHEI, float GEECNNECJKN, float MGMDBIPLJFO = 8f, float FNHLIFEMKMD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MCICPGLNDMF(CFCMEAFAOKP KEGBOAJEGKA, Vector3 GEMHEIIKJKD, float ADLJPIBPOHJ = 7f, float BNLPMLLPELO = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MFDBPBFHKEO();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IGICBEFDGKL();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BNAPCLJFBOP();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EABCNABFGAC();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FGNGMGAHADF(Rigidbody FNNMNPJOBEB);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MHJHBKPJBHO(Vector3 IKJAACJPELI);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GPKDPFLMGAC(object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JHFLMMDKMPI(Vector3 MJDJFFINNFC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LCHIKGCFHJB(Vector3 ANBMKABKKPA, Vector3 DMEKBAFACHD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MKOMODHDAKP(Vector3 ICIJNFBIOEN, Vector3 ANCDBKAOBOM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 CEPGHNOECGD(Vector3 NCEDMGGIAPH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 GMIKOIIAMMB(Vector3 MCDPEFCAPKN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BHGMCJGNNFL(DHFJHHJLOFA.Application)]
public interface JAPOBJJEIFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GIOKMEGNKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOJHILELOLG(string IBDGAGPHJHE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKLLHFBLLGL(RigidbodyEx FPJKEICLJKJ, Action LLIKOHELCCA);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNMHPBPNEPL PKLHFKPHHFB(int EBFPGIDEKNO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBGOCDNPICG(Vector3 ILKJGHLKNJL, float FJCJLDIPDIK, Color FKCCOIADMAE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BHGMCJGNNFL(DHFJHHJLOFA.Application)]
public interface IIPEKPAHCOG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	JAPOBJJEIFJ MOAAGKMJBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	JMOBAILLAKP PHDODKKNDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMBBBJCMBBL : HKDIFKBEBMP, IDisposable, GFKFDDHIPHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly IIPEKPAHCOG EGAKDMHOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal APKEIIIDLHN IENHGOOGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal DKBNKCAHHFN LNKJKBMEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HJNODMAMOKO ODNILKNMPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal MDNHPPBIBJE IKJAACJPELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal HLFPNHKEKBN PLOEJOBINJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal KAOBCIMHGFB APNDAIEMCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MMMNLNDENJL KDEEHDDAJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal EDFNMALNEOC JMNNHHKCHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal NADFILPIABG DCMPNAIJEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal JFGEEPLCPIH OHHFPIMDCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal FBEOHGHPPNK DJOFKFHICPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal CCJBPPKOBJE DLFLBGAHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HIEDKGMACOF OFOIDJEPKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal NAMOCPIEMPB FNNMNPJOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal LKGIKHOHLDF GPFOPDGJLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal IDisposable FJLFOEFDLMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KHIMHGOGMGB HEIFNNAICFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "22")]
		get
		{
			return default(KHIMHGOGMGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GGMPLOAKJOK IEBHMEPIAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x89FBC0", Offset = "0x89EFC0", VA = "0x18089FBC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89FD60", Offset = "0x89F160", VA = "0x18089FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject GBHFECAFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1750", Offset = "0x9F0B50", VA = "0x1809F1750", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9EFFD0", Offset = "0x9EF3D0", VA = "0x1809EFFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform IMDABJDPEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x89A360", Offset = "0x899760", VA = "0x18089A360", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x89A420", Offset = "0x899820", VA = "0x18089A420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x73D5780", Offset = "0x73D4B80", VA = "0x1873D5780", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public HKDIFKBEBMP LHNCJNMLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73D5300", Offset = "0x73D4700", VA = "0x1873D5300", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x73D7E20", Offset = "0x73D7220", VA = "0x1873D7E20", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int AMIMIMNBGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x73D3890", Offset = "0x73D2C90", VA = "0x1873D3890", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public HKDIFKBEBMP FNBAEIOODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x73D5730", Offset = "0x73D4B30", VA = "0x1873D5730", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool EJAFEJJCICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x73D56D0", Offset = "0x73D4AD0", VA = "0x1873D56D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool MLGELLDCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x73D6C20", Offset = "0x73D6020", VA = "0x1873D6C20", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool CFLNEBNLFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x73D6310", Offset = "0x73D5710", VA = "0x1873D6310", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JGADIIFMHNB GONEKALALBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x73D3290", Offset = "0x73D2690", VA = "0x1873D3290", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x73D6ED0", Offset = "0x73D62D0", VA = "0x1873D6ED0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NFNPCOLDFJK BFENLNOLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x73D64A0", Offset = "0x73D58A0", VA = "0x1873D64A0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x73D3B30", Offset = "0x73D2F30", VA = "0x1873D3B30", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float FMLBAIKODKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x73D4580", Offset = "0x73D3980", VA = "0x1873D4580", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x73D7DC0", Offset = "0x73D71C0", VA = "0x1873D7DC0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 KNIIKHMBOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x73D83B0", Offset = "0x73D77B0", VA = "0x1873D83B0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x73D77B0", Offset = "0x73D6BB0", VA = "0x1873D77B0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 CKMDOFGFLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x73D5BD0", Offset = "0x73D4FD0", VA = "0x1873D5BD0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x73D4F50", Offset = "0x73D4350", VA = "0x1873D4F50", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 JNPJEMFPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x73D65B0", Offset = "0x73D59B0", VA = "0x1873D65B0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x73D4A20", Offset = "0x73D3E20", VA = "0x1873D4A20", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 HNNLGFKOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x73D6B40", Offset = "0x73D5F40", VA = "0x1873D6B40", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x73D44A0", Offset = "0x73D38A0", VA = "0x1873D44A0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool PLGBBHFLLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x73D6DD0", Offset = "0x73D61D0", VA = "0x1873D6DD0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MAMNIAOCFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x73D49C0", Offset = "0x73D3DC0", VA = "0x1873D49C0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DGEDNINFDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x73D31B0", Offset = "0x73D25B0", VA = "0x1873D31B0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool GBAJAELKAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x73D8600", Offset = "0x73D7A00", VA = "0x1873D8600", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 FDOJLPBBAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x73D5E00", Offset = "0x73D5200", VA = "0x1873D5E00", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 CABCDOFNHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x73D7030", Offset = "0x73D6430", VA = "0x1873D7030", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 HKNFDKPGOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x73D45D0", Offset = "0x73D39D0", VA = "0x1873D45D0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x73D8AB0", Offset = "0x73D7EB0", VA = "0x1873D8AB0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 AJGGHDNOEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x73D7890", Offset = "0x73D6C90", VA = "0x1873D7890", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float PAOILGPJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x73D3BA0", Offset = "0x73D2FA0", VA = "0x1873D3BA0", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float KEFPPHFPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x73D5DB0", Offset = "0x73D51B0", VA = "0x1873D5DB0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x73D86D0", Offset = "0x73D7AD0", VA = "0x1873D86D0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 GABNKBKEJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x73D5030", Offset = "0x73D4430", VA = "0x1873D5030", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion AADOLGAHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x73D51D0", Offset = "0x73D45D0", VA = "0x1873D51D0", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float HLBCAJHJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x73D7310", Offset = "0x73D6710", VA = "0x1873D7310", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x73D6550", Offset = "0x73D5950", VA = "0x1873D6550", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float GFIGIDPIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x73D5D60", Offset = "0x73D5160", VA = "0x1873D5D60", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x73D62B0", Offset = "0x73D56B0", VA = "0x1873D62B0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool BOOKHCFIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x73D3910", Offset = "0x73D2D10", VA = "0x1873D3910", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x73D7200", Offset = "0x73D6600", VA = "0x1873D7200", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public ANFACPGMLCA HKCEJCLAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x73D5520", Offset = "0x73D4920", VA = "0x1873D5520", Slot = "69")]
		get
		{
			return default(ANFACPGMLCA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x73D6E20", Offset = "0x73D6220", VA = "0x1873D6E20", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool FFOGONKGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x73D5B20", Offset = "0x73D4F20", VA = "0x1873D5B20", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform MEFPNBMPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x89A360", Offset = "0x899760", VA = "0x18089A360", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 GCFNJIFFAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x73D84F0", Offset = "0x73D78F0", VA = "0x1873D84F0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x73D3FB0", Offset = "0x73D33B0", VA = "0x1873D3FB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float MFPALEECLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x73D3B90", Offset = "0x73D2F90", VA = "0x1873D3B90", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x73D3820", Offset = "0x73D2C20", VA = "0x1873D3820", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float FHJGDJJMAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x73D3900", Offset = "0x73D2D00", VA = "0x1873D3900", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x73D7CE0", Offset = "0x73D70E0", VA = "0x1873D7CE0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion NKDFBMJGDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x73D7970", Offset = "0x73D6D70", VA = "0x1873D7970", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x73D4740", Offset = "0x73D3B40", VA = "0x1873D4740", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 BACJLKMLKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x73D4D80", Offset = "0x73D4180", VA = "0x1873D4D80", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x73D46B0", Offset = "0x73D3AB0", VA = "0x1873D46B0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion LLBOOPLHGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x73D6270", Offset = "0x73D5670", VA = "0x1873D6270", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x73D4300", Offset = "0x73D3700", VA = "0x1873D4300", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints PEIIHEFBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x73D4970", Offset = "0x73D3D70", VA = "0x1873D4970", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x73D3F50", Offset = "0x73D3350", VA = "0x1873D3F50", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool AHAPIMBJFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x73D3EB0", Offset = "0x73D32B0", VA = "0x1873D3EB0", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x73D6070", Offset = "0x73D5470", VA = "0x1873D6070", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode ICPKCFKKOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x73D7760", Offset = "0x73D6B60", VA = "0x1873D7760", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x73D6010", Offset = "0x73D5410", VA = "0x1873D6010", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MPDCIJCGBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x73D57D0", Offset = "0x73D4BD0", VA = "0x1873D57D0", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool IDDCNCNGCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x73D5350", Offset = "0x73D4750", VA = "0x1873D5350", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MLHLBDFCGLG LFLDDJGDHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x73D3650", Offset = "0x73D2A50", VA = "0x1873D3650", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x73D5B70", Offset = "0x73D4F70", VA = "0x1873D5B70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MLHLBDFCGLG FONFFHGDODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x73D4440", Offset = "0x73D3840", VA = "0x1873D4440", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x73D5A60", Offset = "0x73D4E60", VA = "0x1873D5A60", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JBPGLKNNDNO POPHHAKNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x73D6CC0", Offset = "0x73D60C0", VA = "0x1873D6CC0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x73D4820", Offset = "0x73D3C20", VA = "0x1873D4820", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MLHLBDFCGLG PIBACLNHFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x73D40C0", Offset = "0x73D34C0", VA = "0x1873D40C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x73D66E0", Offset = "0x73D5AE0", VA = "0x1873D66E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event MLHLBDFCGLG BNJPEEHCKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x73D5CB0", Offset = "0x73D50B0", VA = "0x1873D5CB0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x73D5110", Offset = "0x73D4510", VA = "0x1873D5110", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event MLHLBDFCGLG AAPJMLNJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x73D8730", Offset = "0x73D7B30", VA = "0x1873D8730", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x73D4E10", Offset = "0x73D4210", VA = "0x1873D4E10", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<IHJDLPBPHOK, IHJDLPBPHOK> ABFNMAHNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x73D5570", Offset = "0x73D4970", VA = "0x1873D5570", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x73D85A0", Offset = "0x73D79A0", VA = "0x1873D85A0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MLHLBDFCGLG FBBBHBCOAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x73D4240", Offset = "0x73D3640", VA = "0x1873D4240", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x73D42A0", Offset = "0x73D36A0", VA = "0x1873D42A0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MLHLBDFCGLG KEHKOJJDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x73D3770", Offset = "0x73D2B70", VA = "0x1873D3770", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x73D7A10", Offset = "0x73D6E10", VA = "0x1873D7A10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x73D9040", Offset = "0x73D8440", VA = "0x1873D9040")]
	public BMBBBJCMBBL(GameObject NEMCGAENDDH, RigidbodyEx BPJONAJCLJM, IIPEKPAHCOG EGAKDMHOMDJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x73D7360", Offset = "0x73D6760", VA = "0x1873D7360", Slot = "137")]
	protected virtual void NHMCHNNGKPD(IIPEKPAHCOG EGAKDMHOMDJ, JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x73D4880", Offset = "0x73D3C80", VA = "0x1873D4880", Slot = "138")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x73D7AC0", Offset = "0x73D6EC0", VA = "0x1873D7AC0", Slot = "92")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x73D46F0", Offset = "0x73D3AF0", VA = "0x1873D46F0", Slot = "93")]
	public void DLKINGKMMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73D4220", Offset = "0x73D3620", VA = "0x1873D4220", Slot = "94")]
	public void CGKLAFKJHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x73D8650", Offset = "0x73D7A50", VA = "0x1873D8650")]
	private void OPGFDLMFGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x73D4B00", Offset = "0x73D3F00", VA = "0x1873D4B00", Slot = "30")]
	public HKDIFKBEBMP ELKCHLLNCHI(int OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x73D6AD0", Offset = "0x73D5ED0", VA = "0x1873D6AD0", Slot = "96")]
	public void LKNHCHKPADJ(HKDIFKBEBMP PFKKDHPJFEH, bool MLNLBIHIEHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x73D5170", Offset = "0x73D4570", VA = "0x1873D5170", Slot = "97")]
	public void FOCOKFCBCKH(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x73D8490", Offset = "0x73D7890", VA = "0x1873D8490", Slot = "98")]
	public void OLOADEACMDN(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x73D55D0", Offset = "0x73D49D0", VA = "0x1873D55D0", Slot = "99")]
	public Vector3 GMIKOIIAMMB(Vector3 MCDPEFCAPKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x73D4120", Offset = "0x73D3520", VA = "0x1873D4120", Slot = "100")]
	public Vector3 CEPGHNOECGD(Vector3 NCEDMGGIAPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x73D46F0", Offset = "0x73D3AF0", VA = "0x1873D46F0", Slot = "101")]
	public void EABCNABFGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x73D5D10", Offset = "0x73D5110", VA = "0x1873D5D10", Slot = "102")]
	public void IGICBEFDGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x73D6E80", Offset = "0x73D6280", VA = "0x1873D6E80", Slot = "103")]
	public void MFDBPBFHKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x73D7110", Offset = "0x73D6510", VA = "0x1873D7110", Slot = "104")]
	public void MKOMODHDAKP(Vector3 ICIJNFBIOEN, Vector3 ANCDBKAOBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x73D6740", Offset = "0x73D5B40", VA = "0x1873D6740", Slot = "105")]
	public void LCHIKGCFHJB(Vector3 ANBMKABKKPA, Vector3 DMEKBAFACHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x73D5F30", Offset = "0x73D5330", VA = "0x1873D5F30", Slot = "106")]
	public void JHFLMMDKMPI(Vector3 MJDJFFINNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x73D36B0", Offset = "0x73D2AB0", VA = "0x1873D36B0", Slot = "107")]
	public void ANGLLDKFJGH(LADAGGDBJHL CLCHGDOCDDH, Vector3 FFDFPMPCHEI, float GEECNNECJKN, float MGMDBIPLJFO = 8f, float FNHLIFEMKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x73D3A30", Offset = "0x73D2E30", VA = "0x1873D3A30", Slot = "108")]
	public void BGOGGHHKGAG(CFCMEAFAOKP KEGBOAJEGKA, Vector3 LOFJNONIDID, float CKLBOKLDFBK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x73D6D20", Offset = "0x73D6120", VA = "0x1873D6D20", Slot = "109")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCICPGLNDMF(CFCMEAFAOKP KEGBOAJEGKA, Vector3 GEMHEIIKJKD, float ADLJPIBPOHJ = 7f, float BNLPMLLPELO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x73D6F30", Offset = "0x73D6330", VA = "0x1873D6F30", Slot = "110")]
	public Vector3 MHJHBKPJBHO(Vector3 PFKKDHPJFEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x73D8B90", Offset = "0x73D7F90", VA = "0x1873D8B90", Slot = "111")]
	public Vector3 PMDEHAOKMNA(Vector3 PFKKDHPJFEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x73D3E60", Offset = "0x73D3260", VA = "0x1873D3E60", Slot = "112")]
	public void BNAPCLJFBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x73D60D0", Offset = "0x73D54D0", VA = "0x1873D60D0", Slot = "113")]
	public void KBFOPOFMBDP(HKDIFKBEBMP KMDDBAOCCLO, object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x73D5AC0", Offset = "0x73D4EC0", VA = "0x1873D5AC0", Slot = "114")]
	public void HPFAGFDAKKP(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x73D6360", Offset = "0x73D5760", VA = "0x1873D6360", Slot = "62")]
	public void KFDANBJJKHC((Quaternion rot, Vector3 moments) DGCFGNPKEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x73D6C70", Offset = "0x73D6070", VA = "0x1873D6C70", Slot = "115")]
	public void MBOHMNHKGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x73D3F00", Offset = "0x73D3300", VA = "0x1873D3F00", Slot = "116")]
	public void BPJOCABFGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x73D5910", Offset = "0x73D4D10", VA = "0x1873D5910", Slot = "117")]
	public void HIJCGLHHLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x73D72C0", Offset = "0x73D66C0", VA = "0x1873D72C0", Slot = "118")]
	public bool NCKENIOIBBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x73D54D0", Offset = "0x73D48D0", VA = "0x1873D54D0", Slot = "95")]
	public void GIEPEKOHBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x73D3600", Offset = "0x73D2A00", VA = "0x1873D3600", Slot = "119")]
	public void AHGGJGOBLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x73D7260", Offset = "0x73D6660", VA = "0x1873D7260", Slot = "120")]
	public void NCJEHALBGGD(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x73D6440", Offset = "0x73D5840", VA = "0x1873D6440", Slot = "121")]
	public void KFMCJLCCAFA(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x73D32E0", Offset = "0x73D26E0", VA = "0x1873D32E0", Slot = "122")]
	public void AGBGGPAPCMM(object CFGHNHCDKCN, bool OKKKKJJNIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x73D68D0", Offset = "0x73D5CD0", VA = "0x1873D68D0", Slot = "123")]
	public void LEJADMDJCLF(Vector3 HJBINIGDCLK, Quaternion KAMPEILJKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x73D6140", Offset = "0x73D5540", VA = "0x1873D6140", Slot = "124")]
	public void KBHAMECCLNA(Vector3 ANNAOFBODDH, Quaternion FDJADOGDNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x73D6690", Offset = "0x73D5A90", VA = "0x1873D6690", Slot = "125")]
	public bool KOOEBCGCBCM(float LOJPFHOMPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x73D4060", Offset = "0x73D3460", VA = "0x1873D4060", Slot = "126")]
	public void CCCIEGFPJBA(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x73D64F0", Offset = "0x73D58F0", VA = "0x1873D64F0", Slot = "127")]
	public void KJAFBBDDJFC(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x73D5ED0", Offset = "0x73D52D0", VA = "0x1873D5ED0", Slot = "128")]
	public void JCDKHIDMEEB(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x73D52A0", Offset = "0x73D46A0", VA = "0x1873D52A0", Slot = "129")]
	public void GADNNNEIGCM(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x73D7C00", Offset = "0x73D7000", VA = "0x1873D7C00", Slot = "130")]
	public void NOFDCCLLAIC(Vector3 DLFLBGAHCIJ, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x73D7650", Offset = "0x73D6A50", VA = "0x1873D7650", Slot = "131")]
	public void NHNOJFKLDHD(Vector3 DLFLBGAHCIJ, Vector3 OGKCMCMHLOD, ForceMode GLHDCBJCKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x73D3CC0", Offset = "0x73D30C0", VA = "0x1873D3CC0", Slot = "132")]
	public void BLKJJAIAFPI(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x73D4E70", Offset = "0x73D4270", VA = "0x1873D4E70", Slot = "133")]
	public void FGFNJBJPKOP(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x73D6830", Offset = "0x73D5C30", VA = "0x1873D6830", Slot = "134")]
	public bool LDFPLLCMAIE(Vector3 KACCFANBELL, [Out] RaycastHit BCHHBPDKLIH, float ILHNKLAHFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x73D4DC0", Offset = "0x73D41C0", VA = "0x1873D4DC0", Slot = "135")]
	public void FEPCMIOGOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x73D9000", Offset = "0x73D8400", VA = "0x1873D9000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x73D3BF0", Offset = "0x73D2FF0", VA = "0x1873D3BF0")]
	private void BKMFGHEPIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x73D4330", Offset = "0x73D3730", VA = "0x1873D4330")]
	private void CMIOOBGPBGC(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x73D3420", Offset = "0x73D2820", VA = "0x1873D3420")]
	private void AHDPKBLNKLG(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x73D4CD0", Offset = "0x73D40D0", VA = "0x1873D4CD0")]
	private void FBIFLFNDKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x73D5960", Offset = "0x73D4D60", VA = "0x1873D5960")]
	private void HKJKINALGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x73D8230", Offset = "0x73D7630", VA = "0x1873D8230")]
	private void OJLDNKLNEFP(HKDIFKBEBMP EAMAIJEMIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x73D3960", Offset = "0x73D2D60", VA = "0x1873D3960")]
	private void BEPKNLMMMOI(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x73D3350", Offset = "0x73D2750", VA = "0x1873D3350")]
	private void AHDONLDEJBF(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x73D4B80", Offset = "0x73D3F80", VA = "0x1873D4B80")]
	private void ENEKMPKNFME(GGMPLOAKJOK EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x73D7E80", Offset = "0x73D7280", VA = "0x1873D7E80", Slot = "141")]
	protected virtual void OENEGCJKMIF(GGMPLOAKJOK FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x73D8790", Offset = "0x73D7B90", VA = "0x1873D8790")]
	protected void PLNKOOBBODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x73D8C90", Offset = "0x73D8090", VA = "0x1873D8C90")]
	protected void POIIKKINPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x73D3DA0", Offset = "0x73D31A0", VA = "0x1873D3DA0", Slot = "142")]
	protected virtual IDisposable BMFPCJGGOFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class PNHFMCEECMB
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x73E6AC0", Offset = "0x73E5EC0", VA = "0x1873E6AC0")]
	public static HKDIFKBEBMP AJDGIOIMHFF(this HKDIFKBEBMP FPJKEICLJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x73E6CE0", Offset = "0x73E60E0", VA = "0x1873E6CE0")]
	public static bool HHHECOBHBPD(this HKDIFKBEBMP FPJKEICLJKJ, HKDIFKBEBMP EGLNDOFLNGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x73E6B80", Offset = "0x73E5F80", VA = "0x1873E6B80")]
	public static bool DCPNFMOJDLH(this HKDIFKBEBMP FPJKEICLJKJ, HKDIFKBEBMP FHIJFNGMHCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x73E6C90", Offset = "0x73E6090", VA = "0x1873E6C90")]
	public static GGMPLOAKJOK GOHLGLMGPPP(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x73E6C20", Offset = "0x73E6020", VA = "0x1873E6C20")]
	public static BMBBBJCMBBL GHNFLHGMCKL(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JCIHJEEAPBJ : JMOBAILLAKP
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x73E4E00", Offset = "0x73E4200", VA = "0x1873E4E00", Slot = "19")]
	public HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK, IIPEKPAHCOG EGAKDMHOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "4")]
	public APKEIIIDLHN JPAAIAPBCCF(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "5")]
	public MDNHPPBIBJE NLLBIHIDMIK(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "6")]
	public HLFPNHKEKBN BLKLMPFDPOM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "7")]
	public MMMNLNDENJL CEIEHICGIAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "8")]
	public NADFILPIABG DBFBIMFMHMI(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "9")]
	public JFGEEPLCPIH DJHBJGJCALM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "10")]
	public FBEOHGHPPNK NINEDNCCACM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "11")]
	public CCJBPPKOBJE NHJECGNJGHL(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "12")]
	public LKGIKHOHLDF JOHMPLNBJAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "13")]
	public EDFNMALNEOC KALMDNEFBEE(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	public NAMOCPIEMPB MHFIKCLEGOG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	public HJNODMAMOKO DFHMFOMAIEA(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	public DKBNKCAHHFN LEKMENKNKMF(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	public KAOBCIMHGFB MLNFOEEMBGG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	public HIEDKGMACOF NLFLBOAMIOM(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JCIHJEEAPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "14")]
	private NAMOCPIEMPB CBNNMAOJPOK(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "15")]
	private HJNODMAMOKO MAIINHMCNJL(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "16")]
	private DKBNKCAHHFN FLMHJNAMHFP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "17")]
	private KAOBCIMHGFB EGHKGMKOJJP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "18")]
	private HIEDKGMACOF FNBNHLLAIII(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[CHJBJNKJDOP(typeof(JMOBAILLAKP), new string[] { })]
public class DODFAAKANPK : JMOBAILLAKP, FCIAIGPFFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly JMOBAILLAKP FLDGAGKGGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JMOBAILLAKP OKKCBFIGNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DNIJJIEOOJJ CCLCLDNFAOI;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private JMOBAILLAKP PHDODKKNDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x73DBC20", Offset = "0x73DB020", VA = "0x1873DBC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x73DC270", Offset = "0x73DB670", VA = "0x1873DC270", Slot = "20")]
	public void InitReferences(IBAFIPOHFKD DAMMHANOFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x73DC360", Offset = "0x73DB760", VA = "0x1873DC360", Slot = "4")]
	public APKEIIIDLHN JPAAIAPBCCF(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x73DC5E0", Offset = "0x73DB9E0", VA = "0x1873DC5E0", Slot = "5")]
	public MDNHPPBIBJE NLLBIHIDMIK(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x73DBC80", Offset = "0x73DB080", VA = "0x1873DBC80", Slot = "6")]
	public HLFPNHKEKBN BLKLMPFDPOM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x73DBDD0", Offset = "0x73DB1D0", VA = "0x1873DBDD0", Slot = "7")]
	public MMMNLNDENJL CEIEHICGIAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x73DBE70", Offset = "0x73DB270", VA = "0x1873DBE70", Slot = "8")]
	public NADFILPIABG DBFBIMFMHMI(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x73DBFC0", Offset = "0x73DB3C0", VA = "0x1873DBFC0", Slot = "9")]
	public JFGEEPLCPIH DJHBJGJCALM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x73DC540", Offset = "0x73DB940", VA = "0x1873DC540", Slot = "10")]
	public FBEOHGHPPNK NINEDNCCACM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x73DC4A0", Offset = "0x73DB8A0", VA = "0x1873DC4A0", Slot = "11")]
	public CCJBPPKOBJE NHJECGNJGHL(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x73DC2C0", Offset = "0x73DB6C0", VA = "0x1873DC2C0", Slot = "12")]
	public LKGIKHOHLDF JOHMPLNBJAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x73DC400", Offset = "0x73DB800", VA = "0x1873DC400", Slot = "13")]
	public EDFNMALNEOC KALMDNEFBEE(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x73DBD20", Offset = "0x73DB120", VA = "0x1873DBD20")]
	public NAMOCPIEMPB MHFIKCLEGOG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x73DBF10", Offset = "0x73DB310", VA = "0x1873DBF10")]
	public HJNODMAMOKO DFHMFOMAIEA(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x73DC110", Offset = "0x73DB510", VA = "0x1873DC110")]
	public DKBNKCAHHFN LEKMENKNKMF(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x73DC060", Offset = "0x73DB460", VA = "0x1873DC060")]
	public KAOBCIMHGFB MLNFOEEMBGG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x73DC1C0", Offset = "0x73DB5C0", VA = "0x1873DC1C0")]
	public HIEDKGMACOF NLFLBOAMIOM(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x73DC680", Offset = "0x73DBA80", VA = "0x1873DC680", Slot = "19")]
	public HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK, IIPEKPAHCOG EGAKDMHOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x73DC760", Offset = "0x73DBB60", VA = "0x1873DC760")]
	public DODFAAKANPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x73DBD20", Offset = "0x73DB120", VA = "0x1873DBD20", Slot = "14")]
	private NAMOCPIEMPB CBNNMAOJPOK(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x73DBF10", Offset = "0x73DB310", VA = "0x1873DBF10", Slot = "15")]
	private HJNODMAMOKO MAIINHMCNJL(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x73DC110", Offset = "0x73DB510", VA = "0x1873DC110", Slot = "16")]
	private DKBNKCAHHFN FLMHJNAMHFP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x73DC060", Offset = "0x73DB460", VA = "0x1873DC060", Slot = "17")]
	private KAOBCIMHGFB EGHKGMKOJJP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x73DC1C0", Offset = "0x73DB5C0", VA = "0x1873DC1C0", Slot = "18")]
	private HIEDKGMACOF FNBNHLLAIII(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LFCBKDGCLBE : APKEIIIDLHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFOLLCLINMK(HKDIFKBEBMP FPJKEICLJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCBNGMJBDH(HKDIFKBEBMP FPJKEICLJKJ);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPAGFPDIPBL(HKDIFKBEBMP EAMAIJEMIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHLPBDPDEMD(HKDIFKBEBMP EAMAIJEMIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LEEPLEKGPOK : HLFPNHKEKBN
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GFFOCKKOHAN<HKDIFKBEBMP> FMNHKHJIJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	HKDIFKBEBMP OMJBFPBIDED
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PAHFCLJIBGK : KAOBCIMHGFB
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AJKAAMILKJP(Rigidbody DACEELKDPAC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KEDIGLCKBGA : HJNODMAMOKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView HAFLELIPOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EHJAIGILCMM : LKGIKHOHLDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private CollisionDetectionMode MCFHJDIMBGN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB70", Offset = "0x73D9F70", VA = "0x1873DAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode ICPKCFKKOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x73DD510", Offset = "0x73DC910", VA = "0x1873DD510", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x73DD210", Offset = "0x73DC610", VA = "0x1873DD210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x73DB4B0", Offset = "0x73DA8B0", VA = "0x1873DB4B0")]
	public EHJAIGILCMM(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x73DD620", Offset = "0x73DCA20", VA = "0x1873DD620", Slot = "6")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x73DD190", Offset = "0x73DC590", VA = "0x1873DD190", Slot = "9")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x73DD180", Offset = "0x73DC580", VA = "0x1873DD180", Slot = "7")]
	public void AACGCJBPOLK(bool GMBGIFAPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x73DD500", Offset = "0x73DC900", VA = "0x1873DD500", Slot = "8")]
	public void NGLAOBNNEHN(bool GMBGIFAPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x73DD3A0", Offset = "0x73DC7A0", VA = "0x1873DD3A0", Slot = "10")]
	public bool LDFPLLCMAIE(Vector3 KACCFANBELL, [Out] RaycastHit BCHHBPDKLIH, float ILHNKLAHFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x73DD280", Offset = "0x73DC680", VA = "0x1873DD280")]
	private void KMADKEFLBPF(bool GMBGIFAPLDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DIEKBOGCHCB : JFGEEPLCPIH, IDisposable, EJMLOLLHGGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private ANFACPGMLCA HPDDDGPIPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HNMHPBPNEPL FCFDLFLDHJN;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ANFACPGMLCA HKCEJCLAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x73DB5B0", Offset = "0x73DA9B0", VA = "0x1873DB5B0", Slot = "6")]
		get
		{
			return default(ANFACPGMLCA);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x73DB7A0", Offset = "0x73DABA0", VA = "0x1873DB7A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform DGGEILNMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x73DB540", Offset = "0x73DA940", VA = "0x1873DB540", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IHJDLPBPHOK, IHJDLPBPHOK> ABFNMAHNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x73DB6F0", Offset = "0x73DAAF0", VA = "0x1873DB6F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x73DBAE0", Offset = "0x73DAEE0", VA = "0x1873DBAE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x73DBB90", Offset = "0x73DAF90", VA = "0x1873DBB90")]
	public DIEKBOGCHCB(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x73DB870", Offset = "0x73DAC70", VA = "0x1873DB870", Slot = "8")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x73DB560", Offset = "0x73DA960", VA = "0x1873DB560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xCBAD40", Offset = "0xCBA140", VA = "0x180CBAD40", Slot = "11")]
	private void OPGCGJJMLHL(IHJDLPBPHOK LCGLMMBJDEL, IHJDLPBPHOK HLJFBPAIAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "12")]
	private void HFALMFEGJJJ(bool ALGCKDBOIEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OEDLHNAALOH : JMOBAILLAKP
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x73E6390", Offset = "0x73E5790", VA = "0x1873E6390", Slot = "4")]
	public APKEIIIDLHN JPAAIAPBCCF(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x73E6720", Offset = "0x73E5B20", VA = "0x1873E6720", Slot = "5")]
	public MDNHPPBIBJE NLLBIHIDMIK(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x73E5910", Offset = "0x73E4D10", VA = "0x1873E5910", Slot = "6")]
	public HLFPNHKEKBN BLKLMPFDPOM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x73E5B80", Offset = "0x73E4F80", VA = "0x1873E5B80", Slot = "7")]
	public MMMNLNDENJL CEIEHICGIAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x73E5C00", Offset = "0x73E5000", VA = "0x1873E5C00", Slot = "8")]
	public NADFILPIABG DBFBIMFMHMI(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x73E5E60", Offset = "0x73E5260", VA = "0x1873E5E60", Slot = "9")]
	public JFGEEPLCPIH DJHBJGJCALM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x73E6600", Offset = "0x73E5A00", VA = "0x1873E6600", Slot = "10")]
	public FBEOHGHPPNK NINEDNCCACM(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x73E6540", Offset = "0x73E5940", VA = "0x1873E6540", Slot = "11")]
	public CCJBPPKOBJE NHJECGNJGHL(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x73E62D0", Offset = "0x73E56D0", VA = "0x1873E62D0", Slot = "12")]
	public LKGIKHOHLDF JOHMPLNBJAC(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x73E6480", Offset = "0x73E5880", VA = "0x1873E6480", Slot = "13")]
	public EDFNMALNEOC KALMDNEFBEE(HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x73E5A40", Offset = "0x73E4E40", VA = "0x1873E5A40")]
	public NAMOCPIEMPB MHFIKCLEGOG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x73E5CD0", Offset = "0x73E50D0", VA = "0x1873E5CD0")]
	public HJNODMAMOKO DFHMFOMAIEA(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x73E60C0", Offset = "0x73E54C0", VA = "0x1873E60C0")]
	public DKBNKCAHHFN LEKMENKNKMF(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x73E5F30", Offset = "0x73E5330", VA = "0x1873E5F30")]
	public KAOBCIMHGFB MLNFOEEMBGG(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x73E61F0", Offset = "0x73E55F0", VA = "0x1873E61F0")]
	public HIEDKGMACOF NLFLBOAMIOM(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x73E6840", Offset = "0x73E5C40", VA = "0x1873E6840", Slot = "19")]
	public HKDIFKBEBMP PHIKAGBHCHE(RigidbodyEx FPJKEICLJKJ, JLHJPMNEDPG EIFGKHNPLEK, IIPEKPAHCOG EGAKDMHOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public OEDLHNAALOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x73E5A40", Offset = "0x73E4E40", VA = "0x1873E5A40", Slot = "14")]
	private NAMOCPIEMPB CBNNMAOJPOK(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x73E5CD0", Offset = "0x73E50D0", VA = "0x1873E5CD0", Slot = "15")]
	private HJNODMAMOKO MAIINHMCNJL(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x73E60C0", Offset = "0x73E54C0", VA = "0x1873E60C0", Slot = "16")]
	private DKBNKCAHHFN FLMHJNAMHFP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x73E5F30", Offset = "0x73E5330", VA = "0x1873E5F30", Slot = "17")]
	private KAOBCIMHGFB EGHKGMKOJJP(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x73E61F0", Offset = "0x73E55F0", VA = "0x1873E61F0", Slot = "18")]
	private HIEDKGMACOF FNBNHLLAIII(HKDIFKBEBMP KPECMEHKPOJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class CMFGNMGLFCH : CCJBPPKOBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB70", Offset = "0x73D9F70", VA = "0x1873DAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool FFOGONKGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x73DABC0", Offset = "0x73D9FC0", VA = "0x1873DABC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool EJAFEJJCICB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB10", Offset = "0x73D9F10", VA = "0x1873DAB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private HKDIFKBEBMP LHNCJNMLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x73DAAB0", Offset = "0x73D9EB0", VA = "0x1873DAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x73DB4B0", Offset = "0x73DA8B0", VA = "0x1873DB4B0")]
	public CMFGNMGLFCH(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x73DAE90", Offset = "0x73DA290", VA = "0x1873DAE90", Slot = "4")]
	public void NOFDCCLLAIC(Vector3 DLFLBGAHCIJ, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x73DB250", Offset = "0x73DA650", VA = "0x1873DB250")]
	private void OKOFGGGDICJ(Vector3 DLFLBGAHCIJ, ForceMode GLHDCBJCKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x73DAC10", Offset = "0x73DA010", VA = "0x1873DAC10", Slot = "5")]
	public void NHNOJFKLDHD(Vector3 DLFLBGAHCIJ, Vector3 OGKCMCMHLOD, ForceMode GLHDCBJCKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x73DA6F0", Offset = "0x73D9AF0", VA = "0x1873DA6F0", Slot = "6")]
	public void BLKJJAIAFPI(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x73DAFF0", Offset = "0x73DA3F0", VA = "0x1873DAFF0")]
	private void OEKOFNPFIBJ(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x73DA850", Offset = "0x73D9C50", VA = "0x1873DA850", Slot = "7")]
	public void FGFNJBJPKOP(Vector3 BDODBFKCBCK, ForceMode GLHDCBJCKHK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class ENDHEEEOBKN : EDFNMALNEOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool JIJEDOEGLHM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BOOKHCFIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB92390", Offset = "0xB91790", VA = "0x180B92390", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x73DDA30", Offset = "0x73DCE30", VA = "0x1873DDA30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x73DB4B0", Offset = "0x73DA8B0", VA = "0x1873DB4B0")]
	public ENDHEEEOBKN(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x73DDA00", Offset = "0x73DCE00", VA = "0x1873DDA00", Slot = "6")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x73DDB40", Offset = "0x73DCF40", VA = "0x1873DDB40", Slot = "7")]
	public void NMAFAADFHHD(Rigidbody FNNMNPJOBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class AMJKOOIEPKO : LFCBKDGCLBE, APKEIIIDLHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HKDIFKBEBMP FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly List<HKDIFKBEBMP> IJNLKHGLGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private HKDIFKBEBMP DADDPLMNJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private HKDIFKBEBMP EGIKLIBGODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Transform CJGGBLHOHMM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform IMDABJDPEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x73D1960", Offset = "0x73D0D60", VA = "0x1873D1960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HKDIFKBEBMP LHNCJNMLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x89D9A0", Offset = "0x89CDA0", VA = "0x18089D9A0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x73D2EF0", Offset = "0x73D22F0", VA = "0x1873D2EF0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public HKDIFKBEBMP FNBAEIOODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89CD80", VA = "0x18089D980", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<HKDIFKBEBMP> KHINAAJAMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x89D9E0", Offset = "0x89CDE0", VA = "0x18089D9E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MLHLBDFCGLG LFLDDJGDHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x73D1440", Offset = "0x73D0840", VA = "0x1873D1440", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x73D2060", Offset = "0x73D1460", VA = "0x1873D2060", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MLHLBDFCGLG FONFFHGDODO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x73D1630", Offset = "0x73D0A30", VA = "0x1873D1630", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x73D1FC0", Offset = "0x73D13C0", VA = "0x1873D1FC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JBPGLKNNDNO POPHHAKNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x73D2B80", Offset = "0x73D1F80", VA = "0x1873D2B80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x73D1770", Offset = "0x73D0B70", VA = "0x1873D1770", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IFKMIILCAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x73D2560", Offset = "0x73D1960", VA = "0x1873D2560", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x73D1590", Offset = "0x73D0990", VA = "0x1873D1590", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action HNPIDFMIAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x73D2D60", Offset = "0x73D2160", VA = "0x1873D2D60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x73D12E0", Offset = "0x73D06E0", VA = "0x1873D12E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<HKDIFKBEBMP> CFODMFEMHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x73D2E40", Offset = "0x73D2240", VA = "0x1873D2E40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x73D18B0", Offset = "0x73D0CB0", VA = "0x1873D18B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<HKDIFKBEBMP> PHAPHKNGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x73D14E0", Offset = "0x73D08E0", VA = "0x1873D14E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x73D2410", Offset = "0x73D1810", VA = "0x1873D2410", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action FJEKOPABPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x73D16D0", Offset = "0x73D0AD0", VA = "0x1873D16D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x73D3050", Offset = "0x73D2450", VA = "0x1873D3050", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<HKDIFKBEBMP> HJPGEJGNKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x73D2100", Offset = "0x73D1500", VA = "0x1873D2100", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73D2FA0", Offset = "0x73D23A0", VA = "0x1873D2FA0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x73D30F0", Offset = "0x73D24F0", VA = "0x1873D30F0")]
	public AMJKOOIEPKO(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x73D1810", Offset = "0x73D0C10", VA = "0x1873D1810", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x73D2600", Offset = "0x73D1A00", VA = "0x1873D2600", Slot = "30")]
	public void LKNHCHKPADJ(HKDIFKBEBMP AFFIPMDDGDD, bool MLNLBIHIEHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x73D1D50", Offset = "0x73D1150", VA = "0x1873D1D50", Slot = "6")]
	public void FPAGFPDIPBL(HKDIFKBEBMP EAMAIJEMIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x73D1AD0", Offset = "0x73D0ED0", VA = "0x1873D1AD0", Slot = "7")]
	public void FHLPBDPDEMD(HKDIFKBEBMP EAMAIJEMIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x73D19C0", Offset = "0x73D0DC0", VA = "0x1873D19C0", Slot = "4")]
	public void FFOLLCLINMK(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x73D2F00", Offset = "0x73D2300", VA = "0x1873D2F00", Slot = "5")]
	public void OGCBNGMJBDH(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x73D24C0", Offset = "0x73D18C0", VA = "0x1873D24C0")]
	private void JKMNECHNDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x73D2E00", Offset = "0x73D2200", VA = "0x1873D2E00")]
	private void NKJOEOCJFKO(HKDIFKBEBMP EAMAIJEMIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x73D2C20", Offset = "0x73D2020", VA = "0x1873D2C20")]
	private void MEEKDDNIJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x73D21B0", Offset = "0x73D15B0", VA = "0x1873D21B0")]
	private void JCEKDEBMEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x73D22E0", Offset = "0x73D16E0", VA = "0x1873D22E0")]
	private void JIKAOALOACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x73D1380", Offset = "0x73D0780", VA = "0x1873D1380")]
	[CompilerGenerated]
	private object AGEHAAJFBFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OIHJLDEIPFN
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x73E6990", Offset = "0x73E5D90", VA = "0x1873E6990")]
	public static LFCBKDGCLBE BPCNMPHHLDO(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CBFMLGKJDLJ : LEEPLEKGPOK, HLFPNHKEKBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly GFFOCKKOHAN<HKDIFKBEBMP> AACCEBALMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool EPAIMODHPCA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GFFOCKKOHAN<HKDIFKBEBMP> FMNHKHJIJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 FDOJLPBBAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x73D9650", Offset = "0x73D8A50", VA = "0x1873D9650", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 CABCDOFNHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x73D9AF0", Offset = "0x73D8EF0", VA = "0x1873D9AF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 JNPJEMFPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x73D9A10", Offset = "0x73D8E10", VA = "0x1873D9A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public HKDIFKBEBMP OMJBFPBIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x73D95A0", Offset = "0x73D89A0", VA = "0x1873D95A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x73D9DF0", Offset = "0x73D91F0", VA = "0x1873D9DF0")]
	public CBFMLGKJDLJ(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x73D9190", Offset = "0x73D8590", VA = "0x1873D9190", Slot = "8")]
	public void IGMFBCLBOPC(HKDIFKBEBMP EGIKLIBGODG, object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x73D9130", Offset = "0x73D8530", VA = "0x1873D9130", Slot = "9")]
	public void AAOOICJEFCC(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x73D9200", Offset = "0x73D8600", VA = "0x1873D9200")]
	private Vector3 ILNIAIDMOBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x73D9680", Offset = "0x73D8A80", VA = "0x1873D9680")]
	private void JCDCPJCBOPK(HKDIFKBEBMP CKLDLFGHDFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EBAGEPJKGLA
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x73DC810", Offset = "0x73DBC10", VA = "0x1873DC810")]
	public static LEEPLEKGPOK FCCJJLIMLMB(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class IKCADNEIBBK : PAHFCLJIBGK, KAOBCIMHGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 DBIOMFPAKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OverridableVector3 PHEILDBONCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float MIEENKIDIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float HONMLFBLEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3 LEKNJLKLEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Vector3? ECGNFJABGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Quaternion? NHLPKBJPNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool GDMALGHANJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool PPJNEGAFJLK;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 HKNFDKPGOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10C0FD0", Offset = "0x10C03D0", VA = "0x1810C0FD0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x73E3310", Offset = "0x73E2710", VA = "0x1873E3310", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 AJGGHDNOEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x73E47D0", Offset = "0x73E3BD0", VA = "0x1873E47D0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float PAOILGPJEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB923B0", Offset = "0xB917B0", VA = "0x180B923B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73E46C0", Offset = "0x73E3AC0", VA = "0x1873E46C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float KEFPPHFPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB923A0", Offset = "0xB917A0", VA = "0x180B923A0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x73E33C0", Offset = "0x73E27C0", VA = "0x1873E33C0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GABNKBKEJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x73E39D0", Offset = "0x73E2DD0", VA = "0x1873E39D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion AADOLGAHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x73E3B60", Offset = "0x73E2F60", VA = "0x1873E3B60", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73E3CE0", Offset = "0x73E30E0", VA = "0x1873E3CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MLHLBDFCGLG IENBJKADNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x73E4AA0", Offset = "0x73E3EA0", VA = "0x1873E4AA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x73E4B40", Offset = "0x73E3F40", VA = "0x1873E4B40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x73E4BE0", Offset = "0x73E3FE0", VA = "0x1873E4BE0")]
	public IKCADNEIBBK(HKDIFKBEBMP FPJKEICLJKJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x73E4510", Offset = "0x73E3910", VA = "0x1873E4510", Slot = "17")]
	public void MBOHMNHKGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x73E3230", Offset = "0x73E2630", VA = "0x1873E3230", Slot = "16")]
	public void BPJOCABFGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x73E38F0", Offset = "0x73E2CF0", VA = "0x1873E38F0", Slot = "19")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x73E48C0", Offset = "0x73E3CC0", VA = "0x1873E48C0", Slot = "20")]
	public void NMAFAADFHHD(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x73E3D30", Offset = "0x73E3130", VA = "0x1873E3D30", Slot = "18")]
	public void HIJCGLHHLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x73E3470", Offset = "0x73E2870", VA = "0x1873E3470", Slot = "21")]
	public void FEPCMIOGOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x73E3310", Offset = "0x73E2710", VA = "0x1873E3310")]
	private void COBNBAGMGEE(Vector3 PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x73E3ED0", Offset = "0x73E32D0", VA = "0x1873E3ED0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 INOCCECLDPI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x73E46C0", Offset = "0x73E3AC0", VA = "0x1873E46C0")]
	private void MOMIKIIDMMN(float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x73E33C0", Offset = "0x73E27C0", VA = "0x1873E33C0")]
	private void EENJLKEGAEO(float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x73E3FC0", Offset = "0x73E33C0", VA = "0x1873E3FC0")]
	private Vector3 IPDCEHDLKDB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x73E4160", Offset = "0x73E3560", VA = "0x1873E4160", Slot = "15")]
	public void KFDANBJJKHC((Quaternion rot, Vector3 moments) DGCFGNPKEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x73E4390", Offset = "0x73E3790", VA = "0x1873E4390")]
	private Quaternion LCBJBLEJKIB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x73E23B0", Offset = "0x73E17B0", VA = "0x1873E23B0")]
	public void AJKAAMILKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x73E2480", Offset = "0x73E1880", VA = "0x1873E2480", Slot = "4")]
	public (float, Vector3) AJKAAMILKJP(Rigidbody DACEELKDPAC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class INEOMCBJINJ
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x73E4D40", Offset = "0x73E4140", VA = "0x1873E4D40")]
	public static PAHFCLJIBGK BPPCDCEKGAO(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CKICDHFKMHJ : DKBNKCAHHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JLCPCMNKJOG DKKENGADFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LBCHOGGNAFE LDKKHBHCIHC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool ABBEAGGPIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x124A2A0", Offset = "0x12496A0", VA = "0x18124A2A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public LBCHOGGNAFE EIJCBACHEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0", Slot = "11")]
		get
		{
			return default(LBCHOGGNAFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x73DA5F0", Offset = "0x73D99F0", VA = "0x1873DA5F0")]
	public CKICDHFKMHJ(HKDIFKBEBMP FPJKEICLJKJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x73DA520", Offset = "0x73D9920", VA = "0x1873DA520", Slot = "4")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x73D9FC0", Offset = "0x73D93C0", VA = "0x1873D9FC0")]
	private bool BLDACBMIBKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x73DA0A0", Offset = "0x73D94A0", VA = "0x1873DA0A0", Slot = "5")]
	public void CFHGNHEGHLG(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x73DA4F0", Offset = "0x73D98F0", VA = "0x1873DA4F0", Slot = "6")]
	public void LNPKFHHENOK(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x73DA250", Offset = "0x73D9650", VA = "0x1873DA250", Slot = "9")]
	public void JEMJOAIMPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x73DA3D0", Offset = "0x73D97D0", VA = "0x1873DA3D0")]
	private void LFKOHLEFMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x73DA0D0", Offset = "0x73D94D0", VA = "0x1873DA0D0")]
	private void HINMPFGKFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x73DA390", Offset = "0x73D9790", VA = "0x1873DA390", Slot = "8")]
	public void KALMKBPDBMG(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x73DA060", Offset = "0x73D9460", VA = "0x1873DA060", Slot = "7")]
	public void BMHAOBDNIJE(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OADJNJAEJMM : FBEOHGHPPNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JLCPCMNKJOG AIAFBPDBOLH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FFOGONKGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x73E5720", Offset = "0x73E4B20", VA = "0x1873E5720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MLHLBDFCGLG FBBBHBCOAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x73E5520", Offset = "0x73E4920", VA = "0x1873E5520", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x73E55C0", Offset = "0x73E49C0", VA = "0x1873E55C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x73E5820", Offset = "0x73E4C20", VA = "0x1873E5820")]
	public OADJNJAEJMM(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x73E57E0", Offset = "0x73E4BE0", VA = "0x1873E57E0", Slot = "7")]
	public void NCJEHALBGGD(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x73E57D0", Offset = "0x73E4BD0", VA = "0x1873E57D0", Slot = "8")]
	public void KFMCJLCCAFA(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x73E5410", Offset = "0x73E4810", VA = "0x1873E5410", Slot = "9")]
	public void AGBGGPAPCMM(object CFGHNHCDKCN, bool OKKKKJJNIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x73E5660", Offset = "0x73E4A60", VA = "0x1873E5660", Slot = "12")]
	public void FEGBCLGPFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x73E56A0", Offset = "0x73E4AA0", VA = "0x1873E56A0", Slot = "10")]
	public void FGNGMGAHADF(Rigidbody GGEKFKJPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x73E57F0", Offset = "0x73E4BF0", VA = "0x1873E57F0", Slot = "11")]
	public void NMAFAADFHHD(Rigidbody FNNMNPJOBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class AAPLNLCIJIF : KEDIGLCKBGA, HJNODMAMOKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private PhotonView LJCJINKPICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool LGHMPDKHDKF;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView HAFLELIPOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MLGELLDCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x73D1040", Offset = "0x73D0440", VA = "0x1873D1040", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool CFLNEBNLFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x983FC0", Offset = "0x9833C0", VA = "0x180983FC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MLHLBDFCGLG PIBACLNHFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x73D08D0", Offset = "0x73CFCD0", VA = "0x1873D08D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x73D0FA0", Offset = "0x73D03A0", VA = "0x1873D0FA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x73D1190", Offset = "0x73D0590", VA = "0x1873D1190")]
	public AAPLNLCIJIF(HKDIFKBEBMP FPJKEICLJKJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x73D1060", Offset = "0x73D0460", VA = "0x1873D1060", Slot = "9")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x73D0970", Offset = "0x73CFD70", VA = "0x1873D0970", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x73D0760", Offset = "0x73CFB60", VA = "0x1873D0760", Slot = "10")]
	public void BEPKNLMMMOI(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x73D05F0", Offset = "0x73CF9F0", VA = "0x1873D05F0", Slot = "11")]
	public void AHDONLDEJBF(HKDIFKBEBMP EGIKLIBGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x73D0CE0", Offset = "0x73D00E0", VA = "0x1873D0CE0")]
	private void JHJBLEEDFCO(PhotonView GBJBMLDNNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x73D0E50", Offset = "0x73D0250", VA = "0x1873D0E50")]
	private void KNELAPPLHOK(GGMPLOAKJOK CEAGMNEPGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x73D0A70", Offset = "0x73CFE70", VA = "0x1873D0A70")]
	private void EMOKMFIGLHJ(PhotonView FEAJBBKNLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LJFDIBMBLGP
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x73E5050", Offset = "0x73E4450", VA = "0x1873E5050")]
	public static KEDIGLCKBGA PMOCHLNDAAN(this HKDIFKBEBMP KPECMEHKPOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MEGNDDBNIJP : HIEDKGMACOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RigidbodyConstraints ABJLOMHPHIB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool AHAPIMBJFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9428F0", Offset = "0x941CF0", VA = "0x1809428F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x49264E0", Offset = "0x49258E0", VA = "0x1849264E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HLANAKLFGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xB92350", Offset = "0xB91750", VA = "0x180B92350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x49264D0", Offset = "0x49258D0", VA = "0x1849264D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints PEIIHEFBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x73E51E0", Offset = "0x73E45E0", VA = "0x1873E51E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x73E5370", Offset = "0x73E4770", VA = "0x1873E5370")]
	public MEGNDDBNIJP(HKDIFKBEBMP FPJKEICLJKJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x73E5310", Offset = "0x73E4710", VA = "0x1873E5310", Slot = "9")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x73E5340", Offset = "0x73E4740", VA = "0x1873E5340", Slot = "10")]
	public void NMAFAADFHHD(Rigidbody FNNMNPJOBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EIPMEDEGNOM : MMMNLNDENJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HKDIFKBEBMP FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float HHFMDKJOKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private float LCLJDBKEPEG;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float HLBCAJHJKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA89110", Offset = "0xA88510", VA = "0x180A89110", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x73DD850", Offset = "0x73DCC50", VA = "0x1873DD850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float GFIGIDPIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xBD2900", Offset = "0xBD1D00", VA = "0x180BD2900", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x73DD780", Offset = "0x73DCB80", VA = "0x1873DD780", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x73DD9C0", Offset = "0x73DCDC0", VA = "0x1873DD9C0")]
	public EIPMEDEGNOM(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x73DD730", Offset = "0x73DCB30", VA = "0x1873DD730", Slot = "8")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x73DD920", Offset = "0x73DCD20", VA = "0x1873DD920", Slot = "9")]
	public void NMAFAADFHHD(Rigidbody FNNMNPJOBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class FCOJDCAMJEA : NADFILPIABG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private OLLILMFFDHE HIDILJBLNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool MAFNAFLBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool AMFOGLDHPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int HAANOAEMKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool CLGILGEPHOG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x73DE330", Offset = "0x73DD730", VA = "0x1873DE330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool MPDCIJCGBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x73DE380", Offset = "0x73DD780", VA = "0x1873DE380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private HKDIFKBEBMP LHNCJNMLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x73DE180", Offset = "0x73DD580", VA = "0x1873DE180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EJAFEJJCICB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x73DE2D0", Offset = "0x73DD6D0", VA = "0x1873DE2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MLHLBDFCGLG AAPJMLNJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x73DE970", Offset = "0x73DDD70", VA = "0x1873DE970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x73DDED0", Offset = "0x73DD2D0", VA = "0x1873DDED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x73DEA10", Offset = "0x73DDE10", VA = "0x1873DEA10")]
	public FCOJDCAMJEA(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x73DE7A0", Offset = "0x73DDBA0", VA = "0x1873DE7A0", Slot = "6")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x73DDC50", Offset = "0x73DD050", VA = "0x1873DDC50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x73DE580", Offset = "0x73DD980", VA = "0x1873DE580", Slot = "8")]
	public void LMOLKGGOGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x73DE650", Offset = "0x73DDA50", VA = "0x1873DE650", Slot = "7")]
	public bool NCKENIOIBBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x73DE1E0", Offset = "0x73DD5E0", VA = "0x1873DE1E0", Slot = "9")]
	public void GIEPEKOHBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x73DE590", Offset = "0x73DD990", VA = "0x1873DE590")]
	private void MHFJMNNGDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x73DDBB0", Offset = "0x73DCFB0", VA = "0x1873DDBB0", Slot = "11")]
	public void AHGGJGOBLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x73DDF70", Offset = "0x73DD370", VA = "0x1873DDF70", Slot = "10")]
	public void FGAGMNNBJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x73DE3A0", Offset = "0x73DD7A0", VA = "0x1873DE3A0")]
	private bool HPCLNAELLAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x73DDD40", Offset = "0x73DD140", VA = "0x1873DDD40")]
	private void ELMHFFHDLML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EGGGFEDMBKI : NAMOCPIEMPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly JLCPCMNKJOG EJNNFJCMNPO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody HHKNFHDMAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool EJAFEJJCICB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x73DAB10", Offset = "0x73D9F10", VA = "0x1873DAB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool FDABBIDEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x124A2A0", Offset = "0x12496A0", VA = "0x18124A2A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x73DD070", Offset = "0x73DC470", VA = "0x1873DD070")]
	public EGGGFEDMBKI(HKDIFKBEBMP FPJKEICLJKJ, [In] JLHJPMNEDPG EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x73DCFD0", Offset = "0x73DC3D0", VA = "0x1873DCFD0", Slot = "5")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x73DCC70", Offset = "0x73DC070", VA = "0x1873DCC70", Slot = "7")]
	public void JCDKHIDMEEB(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x73DCAC0", Offset = "0x73DBEC0", VA = "0x1873DCAC0", Slot = "8")]
	public void GADNNNEIGCM(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x73DCCA0", Offset = "0x73DC0A0", VA = "0x1873DCCA0", Slot = "9")]
	public void NBCJCGIKCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x73DC8D0", Offset = "0x73DBCD0", VA = "0x1873DC8D0", Slot = "10")]
	public void CMAHBFGAGFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x73DCAF0", Offset = "0x73DBEF0", VA = "0x1873DCAF0", Slot = "11")]
	public void IMKFEKBMDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GOGPNGEJAAC : MDNHPPBIBJE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BMBBBJCMBBL FPJKEICLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JLCPCMNKJOG LPCFOGHEMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private float JHJMHMDFKFN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JGADIIFMHNB GONEKALALBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89EF00", Offset = "0x89E300", VA = "0x18089EF00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public NFNPCOLDFJK BFENLNOLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 JNPJEMFPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x73E15B0", Offset = "0x73E09B0", VA = "0x1873E15B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x73E0080", Offset = "0x73DF480", VA = "0x1873E0080", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 KNIIKHMBOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x73E2140", Offset = "0x73E1540", VA = "0x1873E2140", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x73E2110", Offset = "0x73E1510", VA = "0x1873E2110", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 HNNLGFKOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x73E17D0", Offset = "0x73E0BD0", VA = "0x1873E17D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x73DFD30", Offset = "0x73DF130", VA = "0x1873DFD30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 CKMDOFGFLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x73E0C00", Offset = "0x73E0000", VA = "0x1873E0C00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x73E0270", Offset = "0x73DF670", VA = "0x1873E0270", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float FMLBAIKODKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xB923C0", Offset = "0xB917C0", VA = "0x180B923C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x73E0530", Offset = "0x73DF930", VA = "0x1873E0530", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool GBAJAELKAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1BD9D60", Offset = "0x1BD9160", VA = "0x181BD9D60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private CCJBPPKOBJE AJJHCONKJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6BB02B0", Offset = "0x6BAF6B0", VA = "0x186BB02B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool MPDCIJCGBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x73E0BE0", Offset = "0x73DFFE0", VA = "0x1873E0BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x73E22C0", Offset = "0x73E16C0", VA = "0x1873E22C0")]
	public GOGPNGEJAAC(HKDIFKBEBMP FPJKEICLJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x73DFE50", Offset = "0x73DF250", VA = "0x1873DFE50", Slot = "19")]
	public void NNBPIPDBJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x73DFDF0", Offset = "0x73DF1F0", VA = "0x1873DFDF0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x73E0140", Offset = "0x73DF540", VA = "0x1873E0140", Slot = "28")]
	public void FGNGMGAHADF(Rigidbody FNNMNPJOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1079230", Offset = "0x1078630", VA = "0x181079230", Slot = "20")]
	public void KCIHNDFKLDF(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1079050", Offset = "0x1078450", VA = "0x181079050", Slot = "30")]
	public void GPKDPFLMGAC(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0350", Offset = "0x73DF750", VA = "0x1873E0350", Slot = "35")]
	public Vector3 GMIKOIIAMMB(Vector3 MCDPEFCAPKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x73DFB70", Offset = "0x73DEF70", VA = "0x1873DFB70", Slot = "34")]
	public Vector3 CEPGHNOECGD(Vector3 NCEDMGGIAPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x73DFE50", Offset = "0x73DF250", VA = "0x1873DFE50", Slot = "27")]
	public void EABCNABFGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x73E1210", Offset = "0x73E0610", VA = "0x1873E1210", Slot = "25")]
	public void IGICBEFDGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x73E1D90", Offset = "0x73E1190", VA = "0x1873E1D90", Slot = "24")]
	public void MFDBPBFHKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x73E1ED0", Offset = "0x73E12D0", VA = "0x1873E1ED0", Slot = "33")]
	public void MKOMODHDAKP(Vector3 ICIJNFBIOEN, Vector3 ANCDBKAOBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x73E1770", Offset = "0x73E0B70", VA = "0x1873E1770", Slot = "32")]
	public void LCHIKGCFHJB(Vector3 ANBMKABKKPA, Vector3 DMEKBAFACHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x73E1270", Offset = "0x73E0670", VA = "0x1873E1270", Slot = "31")]
	public void JHFLMMDKMPI(Vector3 MJDJFFINNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x73DF0B0", Offset = "0x73DE4B0", VA = "0x1873DF0B0", Slot = "22")]
	public void ANGLLDKFJGH(LADAGGDBJHL CLCHGDOCDDH, Vector3 FFDFPMPCHEI, float GEECNNECJKN, float MGMDBIPLJFO = 8f, float FNHLIFEMKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x73DF760", Offset = "0x73DEB60", VA = "0x1873DF760", Slot = "21")]
	public void BGOGGHHKGAG(CFCMEAFAOKP KEGBOAJEGKA, Vector3 LOFJNONIDID, float CKLBOKLDFBK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x73E19A0", Offset = "0x73E0DA0", VA = "0x1873E19A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MCICPGLNDMF(CFCMEAFAOKP KEGBOAJEGKA, Vector3 GEMHEIIKJKD, float ADLJPIBPOHJ = 7f, float BNLPMLLPELO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x11A3640", Offset = "0x11A2A40", VA = "0x1811A3640")]
	private static void OBBJAOEKAIP(Vector3 IKJAACJPELI, Vector3 HAGCLANLPAD, [Out] Vector3 CKOPJBBPFGL, [Out] Vector3 BCJHLHBGEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x73E1DF0", Offset = "0x73E11F0", VA = "0x1873E1DF0", Slot = "29")]
	public Vector3 MHJHBKPJBHO(Vector3 IKJAACJPELI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x73DF9E0", Offset = "0x73DEDE0", VA = "0x1873DF9E0", Slot = "26")]
	public void BNAPCLJFBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x73E0530", Offset = "0x73DF930", VA = "0x1873E0530")]
	private void HCHPANJNIFI(float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x73E1410", Offset = "0x73E0810", VA = "0x1873E1410")]
	private void JKABGAACEAN(Vector3 LOFJNONIDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x73DFF00", Offset = "0x73DF300", VA = "0x1873DFF00")]
	private Vector3 ECNHOMPOCPL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x73E0D90", Offset = "0x73E0190", VA = "0x1873E0D90")]
	private void ICLIEDNGKOE(Vector3 NCEDMGGIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x73DEF20", Offset = "0x73DE320", VA = "0x1873DEF20")]
	private Vector3 AEOLDGKNKAI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x73DEAA0", Offset = "0x73DDEA0", VA = "0x1873DEAA0")]
	private void ADLAKGAKJHG(Vector3 PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x73E0640", Offset = "0x73DFA40", VA = "0x1873E0640")]
	private void HEHLMJEGMPN(Vector3 NCEDMGGIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x73E02A0", Offset = "0x73DF6A0", VA = "0x1873E02A0")]
	private void GINLFMLOFBE()
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
