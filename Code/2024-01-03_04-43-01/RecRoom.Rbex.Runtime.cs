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
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void OGOEIPLNHKB(RigidbodyEx HDELAOPOGOL);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CFPKEOMCFGB(RigidbodyEx HDELAOPOGOL, bool LGIEADGADKO = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ICHLBMNNNNE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CNCCDAMIONL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LKBNAALOLPJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GKFKBGDODHH(typeof(LLJDFFFDPNL), new string[] { "Ignore", "Mock" })]
public class LBNJBOAPPMN : LLJDFFFDPNL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KGHKKAOFOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4240", Offset = "0x7C2E40", VA = "0x1807C4240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
	public void POMDOELFCOG(string GNLAGDDNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
	public void HNEBIBHFEBL(RigidbodyEx NGEPMJPLOFK, Action GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "7")]
	public INIJIIICIKE GKFLLFDODIJ(int MDHFAEOPEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void OJNJBNKKAIN(Vector3 JHIHJBFBDFF, float DKFGBKANJHB, Color EFLLOODPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LBNJBOAPPMN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ELHKCOAEACJ AOGHHGEODFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool AJKFOHINKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CLILEGLKHIM HAKDLBEAKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[AEBANLKNJHD(GNDHFGBAEMN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[AEBANLKNJHD(GNDHFGBAEMN.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private CNCCDAMIONL physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal CLILEGLKHIM JDONOAIINGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x63B66E0", Offset = "0x63B52E0", VA = "0x1863B66E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> JDAJBCIPDMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx EEGKHNJHPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63B84F0", Offset = "0x63B70F0", VA = "0x1863B84F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx EGCFCBLCCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63B8450", Offset = "0x63B7050", VA = "0x1863B8450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HHNAEDAPOHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63B9110", Offset = "0x63B7D10", VA = "0x1863B9110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63BA690", Offset = "0x63B9290", VA = "0x1863BA690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform KDJDCKHNCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x79A810", Offset = "0x799410", VA = "0x18079A810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform JMLEHOPCKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x79A810", Offset = "0x799410", VA = "0x18079A810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LGAAKFHBOCB GNFFBNNKDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63B8210", Offset = "0x63B6E10", VA = "0x1863B8210")]
			get
			{
				return default(LGAAKFHBOCB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9E40", Offset = "0x63B8A40", VA = "0x1863B9E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AHJFJLOAFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63B87A0", Offset = "0x63B73A0", VA = "0x1863B87A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FENPGOBDPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8330", Offset = "0x63B6F30", VA = "0x1863B8330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IPLEJINKGKJ HHBPDLODGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63B86E0", Offset = "0x63B72E0", VA = "0x1863B86E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63BA000", Offset = "0x63B8C00", VA = "0x1863BA000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FAJHLMMDDLF COCPMJDMOGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63B8680", Offset = "0x63B7280", VA = "0x1863B8680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63B9F90", Offset = "0x63B8B90", VA = "0x1863B9F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ABNLGNLKEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63B85D0", Offset = "0x63B71D0", VA = "0x1863B85D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody AFENJAMGBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63B8630", Offset = "0x63B7230", VA = "0x1863B8630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FFDBBKPLAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63B8390", Offset = "0x63B6F90", VA = "0x1863B8390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63B9EB0", Offset = "0x63B8AB0", VA = "0x1863B9EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AHNPEAKENBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1B225D0", Offset = "0x1B211D0", VA = "0x181B225D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7620", Offset = "0x5BE6220", VA = "0x185BE7620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KAHEGMOFBDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63B90B0", Offset = "0x63B7CB0", VA = "0x1863B90B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EEDDDIIPBKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63B9050", Offset = "0x63B7C50", VA = "0x1863B9050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63BA620", Offset = "0x63B9220", VA = "0x1863BA620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PNEOPFBAHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8A00", Offset = "0x63B7600", VA = "0x1863B8A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA2A0", Offset = "0x63B8EA0", VA = "0x1863BA2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NFNLCFMFAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8800", Offset = "0x63B7400", VA = "0x1863B8800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63BA070", Offset = "0x63B8C70", VA = "0x1863BA070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CICAACOEPDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9670", Offset = "0x63B8270", VA = "0x1863B9670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63BABF0", Offset = "0x63B97F0", VA = "0x1863BABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 FCPCCIGNOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63B8E30", Offset = "0x63B7A30", VA = "0x1863B8E30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63BA3F0", Offset = "0x63B8FF0", VA = "0x1863BA3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JHIHJBFBDFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63B97B0", Offset = "0x63B83B0", VA = "0x1863B97B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode GEIPIJFHKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63B8940", Offset = "0x63B7540", VA = "0x1863B8940")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63BA1C0", Offset = "0x63B8DC0", VA = "0x1863BA1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NENGIOPIHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63B83F0", Offset = "0x63B6FF0", VA = "0x1863B83F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63B9F20", Offset = "0x63B8B20", VA = "0x1863B9F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IDMEOBBKOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63B89A0", Offset = "0x63B75A0", VA = "0x1863B89A0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63BA230", Offset = "0x63B8E30", VA = "0x1863BA230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 CJABPDGBOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63B91B0", Offset = "0x63B7DB0", VA = "0x1863B91B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 LENIGMOJEDP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63B91B0", Offset = "0x63B7DB0", VA = "0x1863B91B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA9D0", Offset = "0x63B95D0", VA = "0x1863BA9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float IGICPJJPDGI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8F10", Offset = "0x63B7B10", VA = "0x1863B8F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63BA4D0", Offset = "0x63B90D0", VA = "0x1863BA4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LDCGOENBDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9610", Offset = "0x63B8210", VA = "0x1863B9610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63BAB80", Offset = "0x63B9780", VA = "0x1863BAB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion FLLLGMBOOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63B9290", Offset = "0x63B7E90", VA = "0x1863B9290")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63BA750", Offset = "0x63B9350", VA = "0x1863BA750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LDEEDGMDHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63B9530", Offset = "0x63B8130", VA = "0x1863B9530")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63BAAB0", Offset = "0x63B96B0", VA = "0x1863BAAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 MGCIOFHHFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63B9370", Offset = "0x63B7F70", VA = "0x1863B9370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63BA820", Offset = "0x63B9420", VA = "0x1863BA820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CPFJALGCICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63B9450", Offset = "0x63B8050", VA = "0x1863B9450")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63BA900", Offset = "0x63B9500", VA = "0x1863BA900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 OAAOAKNCDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63B96D0", Offset = "0x63B82D0", VA = "0x1863B96D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63BAC60", Offset = "0x63B9860", VA = "0x1863BAC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PMHHDDKKDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8F70", Offset = "0x63B7B70", VA = "0x1863B8F70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA540", Offset = "0x63B9140", VA = "0x1863BA540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NHOJBJMMDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8860", Offset = "0x63B7460", VA = "0x1863B8860")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63BA0E0", Offset = "0x63B8CE0", VA = "0x1863BA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HAGKOPCILNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8D50", Offset = "0x63B7950", VA = "0x1863B8D50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x63BA310", Offset = "0x63B8F10", VA = "0x1863BA310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 JJIOHFBKFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x63B8C10", Offset = "0x63B7810", VA = "0x1863B8C10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion BBEANGPPEIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63B8B30", Offset = "0x63B7730", VA = "0x1863B8B30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 JFFDLMFCODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63B9970", Offset = "0x63B8570", VA = "0x1863B9970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BOPHMNHHAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63B9890", Offset = "0x63B8490", VA = "0x1863B9890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool IGOALBDIPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63B8CF0", Offset = "0x63B78F0", VA = "0x1863B8CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MIEPMENDILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63B8740", Offset = "0x63B7340", VA = "0x1863B8740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ECEGNOKHCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63B82D0", Offset = "0x63B6ED0", VA = "0x1863B82D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LGHEANPHFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63B8270", Offset = "0x63B6E70", VA = "0x1863B8270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MHEDDKGKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63B81B0", Offset = "0x63B6DB0", VA = "0x1863B81B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LBGBLDABDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8A60", Offset = "0x63B7660", VA = "0x1863B8A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BKIHKFDKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC4150", Offset = "0x4FC2D50", VA = "0x184FC4150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OGOEIPLNHKB CGEOOFINKME
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63B80D0", Offset = "0x63B6CD0", VA = "0x1863B80D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x63B9D60", Offset = "0x63B8960", VA = "0x1863B9D60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CFPKEOMCFGB DDIMMFKBJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63B8060", Offset = "0x63B6C60", VA = "0x1863B8060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63B9CF0", Offset = "0x63B88F0", VA = "0x1863B9CF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OGOEIPLNHKB BGNPBFCMPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63B7DC0", Offset = "0x63B69C0", VA = "0x1863B7DC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63B9A50", Offset = "0x63B8650", VA = "0x1863B9A50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OGOEIPLNHKB GBDEACGOBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E30", Offset = "0x63B6A30", VA = "0x1863B7E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63B9AC0", Offset = "0x63B86C0", VA = "0x1863B9AC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OGOEIPLNHKB DKPFAAIGKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F80", Offset = "0x63B6B80", VA = "0x1863B7F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x63B9C10", Offset = "0x63B8810", VA = "0x1863B9C10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F10", Offset = "0x63B6B10", VA = "0x1863B7F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9BA0", Offset = "0x63B87A0", VA = "0x1863B9BA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OGOEIPLNHKB KJOJFLAAIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63B7FF0", Offset = "0x63B6BF0", VA = "0x1863B7FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63B9C80", Offset = "0x63B8880", VA = "0x1863B9C80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OGOEIPLNHKB DCHKOPNEBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63B8140", Offset = "0x63B6D40", VA = "0x1863B8140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9DD0", Offset = "0x63B89D0", VA = "0x1863B9DD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event OGOEIPLNHKB MJEONDGBFND
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63B7EA0", Offset = "0x63B6AA0", VA = "0x1863B7EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63B9B30", Offset = "0x63B8730", VA = "0x1863B9B30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		internal void ECCMMIPJICL(CLILEGLKHIM OGDBMIPIOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63B6260", Offset = "0x63B4E60", VA = "0x1863B6260")]
		internal void BCLIDIJCPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B7AE0", Offset = "0x63B66E0", VA = "0x1863B7AE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody HBHFGLOIFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63B77B0", Offset = "0x63B63B0", VA = "0x1863B77B0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63B61F0", Offset = "0x63B4DF0", VA = "0x1863B61F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B66E0", Offset = "0x63B52E0", VA = "0x1863B66E0")]
		private CLILEGLKHIM CMOHLIKMGLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63B62F0", Offset = "0x63B4EF0", VA = "0x1863B62F0")]
		private void BGGKBEMAPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63B6F80", Offset = "0x63B5B80", VA = "0x1863B6F80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63B6260", Offset = "0x63B4E60", VA = "0x1863B6260")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63B6F20", Offset = "0x63B5B20", VA = "0x1863B6F20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63B6FE0", Offset = "0x63B5BE0", VA = "0x1863B6FE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63B58A0", Offset = "0x63B44A0", VA = "0x1863B58A0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63B7040", Offset = "0x63B5C40", VA = "0x1863B7040")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63B6910", Offset = "0x63B5510", VA = "0x1863B6910")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63B6EC0", Offset = "0x63B5AC0", VA = "0x1863B6EC0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63B7910", Offset = "0x63B6510", VA = "0x1863B7910")]
		public void SetParent(RigidbodyEx GCPEEAODAIB, bool LGIEADGADKO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63B7350", Offset = "0x63B5F50", VA = "0x1863B7350")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63B6B90", Offset = "0x63B5790", VA = "0x1863B6B90")]
		public bool IsRigidbodyAncestor(RigidbodyEx OJBFIKOJPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6C70", Offset = "0x63B5870", VA = "0x1863B6C70")]
		public bool IsRigidbodyDescendant(RigidbodyEx EKOLKIEBGFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B10", Offset = "0x63B4710", VA = "0x1863B5B10")]
		public void AddInterpolationRestriction(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63B70B0", Offset = "0x63B5CB0", VA = "0x1863B70B0")]
		public void RemoveInterpolationRestriction(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63B6680", Offset = "0x63B5280", VA = "0x1863B6680")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B80", Offset = "0x63B4780", VA = "0x1863B5B80")]
		public void AddKinematic(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63B7120", Offset = "0x63B5D20", VA = "0x1863B7120")]
		public void RemoveKinematic(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63B7890", Offset = "0x63B6490", VA = "0x1863B7890")]
		public void SetKinematic(object KJCAGLABEME, bool IEPCDJKIMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63B76B0", Offset = "0x63B62B0", VA = "0x1863B76B0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63B75B0", Offset = "0x63B61B0", VA = "0x1863B75B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63B6A80", Offset = "0x63B5680", VA = "0x1863B6A80")]
		public Vector3 GetConstrainedVelocity(Vector3 OAAOAKNCDMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63B6970", Offset = "0x63B5570", VA = "0x1863B6970")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NHOJBJMMDJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63B5A20", Offset = "0x63B4620", VA = "0x1863B5A20")]
		public void AddForce(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63B5910", Offset = "0x63B4510", VA = "0x1863B5910")]
		public void AddForceAtPosition(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63B5D50", Offset = "0x63B4950", VA = "0x1863B5D50")]
		public void AddTorque(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63B5BF0", Offset = "0x63B47F0", VA = "0x1863B5BF0")]
		public void AddRelativeTorque(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63B7BB0", Offset = "0x63B67B0", VA = "0x1863B7BB0")]
		public Vector3 WorldToLocalVelocity(Vector3 BHLFPCKJLFL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6DB0", Offset = "0x63B59B0", VA = "0x1863B6DB0")]
		public Vector3 LocalToWorldVelocity(Vector3 PMHHDDKKDHI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63B68B0", Offset = "0x63B54B0", VA = "0x1863B68B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63B6850", Offset = "0x63B5450", VA = "0x1863B6850")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63B67F0", Offset = "0x63B53F0", VA = "0x1863B67F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63B6790", Offset = "0x63B5390", VA = "0x1863B6790")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63B74B0", Offset = "0x63B60B0", VA = "0x1863B74B0")]
		public void ResetVelocityWorldSpace(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63B73B0", Offset = "0x63B5FB0", VA = "0x1863B73B0")]
		public void ResetVelocityLocalSpace(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63B7270", Offset = "0x63B5E70", VA = "0x1863B7270")]
		public void ResetLinearVelocityLocalSpace(Vector3 KPIPFDNKPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63B7A40", Offset = "0x63B6640", VA = "0x1863B7A40")]
		public bool SweepTest(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x63B6D50", Offset = "0x63B5950", VA = "0x1863B6D50")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63B79E0", Offset = "0x63B65E0", VA = "0x1863B79E0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x63B7B50", Offset = "0x63B6750", VA = "0x1863B7B50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63B5CE0", Offset = "0x63B48E0", VA = "0x1863B5CE0")]
		public void AddShouldHaveUnityRigidbodyToken(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63B7190", Offset = "0x63B5D90", VA = "0x1863B7190")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63B6080", Offset = "0x63B4C80", VA = "0x1863B6080")]
		public void ApplyForceVelocityChange(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63B5FE0", Offset = "0x63B4BE0", VA = "0x1863B5FE0")]
		public void ApplyAngularVelocityChange(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6140", Offset = "0x63B4D40", VA = "0x1863B6140")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5F10", Offset = "0x63B4B10", VA = "0x1863B5F10")]
		public bool AllowedScaleChange(float MFAAODEGFEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5E40", Offset = "0x63B4A40", VA = "0x1863B5E40")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PHEEDLMPGKK, object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x63B7200", Offset = "0x63B5E00", VA = "0x1863B7200")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63B7D50", Offset = "0x63B6950", VA = "0x1863B7D50")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DNNJANIHFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x639D2F0", Offset = "0x639BEF0", VA = "0x18639D2F0")]
	public static CLILEGLKHIM JDONOAIINGL(this RigidbodyEx NGEPMJPLOFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AKGLBOOOAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody ABIICCJBIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView BFJDFNLOLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 JBJNMKNAMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 EOKFFGBPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CNCCDAMIONL NJHFANHKNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool HJDJILPFEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool JDDNDFBCPAP;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GKFKBGDODHH(typeof(HBFIOLAIDGN), new string[] { })]
public class KABANNDAHOO : HBFIOLAIDGN, HKECKBDIOOH
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PDKMOJIAHEM BIJHKBKHNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LLJDFFFDPNL IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private POEPMBPGKKN HICFOFLMLLI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LLJDFFFDPNL MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public POEPMBPGKKN HBKJOMDOGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x63A6EC0", Offset = "0x63A5AC0", VA = "0x1863A6EC0", Slot = "8")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A6AA0", Offset = "0x63A56A0", VA = "0x1863A6AA0", Slot = "6")]
	public HIMFIAMFCKI CNJBBJCKCMH(RigidbodyEx NGEPMJPLOFK)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A6D50", Offset = "0x63A5950", VA = "0x1863A6D50")]
	private static HIMFIAMFCKI DADDFBHLIPO(RigidbodyEx NGEPMJPLOFK)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E20", Offset = "0x63A5A20", VA = "0x1863A6E20", Slot = "7")]
	public CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KABANNDAHOO()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static NGHNHLLDGBJ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int BMGGNEHACLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int LFOBMBPICHE;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63B5700", Offset = "0x63B4300", VA = "0x1863B5700")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x63B5740", Offset = "0x63B4340", VA = "0x1863B5740")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x63B5720", Offset = "0x63B4320", VA = "0x1863B5720")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EOOPGFAEMIH, [Optional] UnityEngine.Object BFDLBONPDOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EOOPGFAEMIH, [Optional] UnityEngine.Object BFDLBONPDOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x63B5850", Offset = "0x63B4450", VA = "0x1863B5850")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LOIFNKGNCFO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A9AF0", Offset = "0x63A86F0", VA = "0x1863A9AF0")]
	public static void KGAGDMAMAEN(this Rigidbody HBHFGLOIFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A9C80", Offset = "0x63A8880", VA = "0x1863A9C80")]
	public static void KGAGDMAMAEN(this Rigidbody HBHFGLOIFPP, Vector3 BOKJFBAMENE, Quaternion BBEANGPPEIF, Vector3 BBCPKCENIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xBC4EB0", Offset = "0xBC3AB0", VA = "0x180BC4EB0")]
	public static void FBAOGHOJNPK(Vector3 OAAOAKNCDMA, Vector3 FNDECJGLHAI, [Out] Vector3 EKCBCDGHIGG, [Out] Vector3 LCFMGDEAHPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GFPNOEODPNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class CLIEIMJNOGJ : IPLEJINKGKJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780590", VA = "0x180781990", Slot = "4")]
		public Vector3 AILKNJEFAGK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780590", VA = "0x180781990", Slot = "5")]
		public Vector3 KLMACOIEGDJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CLIEIMJNOGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static IPLEJINKGKJ FMFPFKLEINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x639FC00", Offset = "0x639E800", VA = "0x18639FC00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KGCLDJCOPKE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDLKPLFJPBP(bool IGOALBDIPEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNIJEEAEHLJ(bool IGOALBDIPEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BENFKCACMDO : IDisposable, OBKCDKHLKCL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGFNEFGPKMD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface POEPMBPGKKN
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ, HBFIOLAIDGN CEICFMOFGAN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AHLABJLGKJI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GFAEJIJOIIM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJLDBOLDIKM(Rigidbody ABIICCJBIMP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EEIHPONFIOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OGOEIPLNHKB BGNPBFCMPGC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OGOEIPLNHKB GBDEACGOBAH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event CFPKEOMCFGB OJIAPCJIBFC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action OLFMHBNNIJN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action NILEMMLPJHI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CLILEGLKHIM> AGBNPPLPEEF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<CLILEGLKHIM> LEGHKNLKFLK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action HGNEPMKMNHH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<CLILEGLKHIM> BIKBACEBBEC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GMIJDPBCEJN(CLILEGLKHIM OGNJAKACDHE, bool LGIEADGADKO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PIPBDGDHDEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOBGBBEPPKF(CLILEGLKHIM HHNAEDAPOHF, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHBNKJHAMAA(object KJCAGLABEME);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KMICGGOIAGK
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OGOEIPLNHKB EOBAIGEGIHM;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OLHALCKHAMJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HJHICEMDBIG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ADPIHHLENJE();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OJLDBOLDIKM(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LNJDCLMNJLM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NNGGKLPDBGF
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OACOBDCKHGB(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEDLOEEFJBP(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHEJHHEDMIC(CLILEGLKHIM NGEPMJPLOFK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEBKMNKBKFA(CLILEGLKHIM NGEPMJPLOFK);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBLKMCFBKHB();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LBEMOOJEDNP
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OGOEIPLNHKB GPBFDBHNODC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKDOINHLNHE();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNBBAIDPKJG(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPGIJLNAJEB(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GKBDEHJHPOG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMMPLHKBEGG(Rigidbody IDJLKFJMEJJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OJLDBOLDIKM(Rigidbody ABIICCJBIMP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KICNEDMPOBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event OGOEIPLNHKB MFLAPEJBAAG;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OFECNLJJPMK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OECAEIFCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJLDBOLDIKM(Rigidbody ABIICCJBIMP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CHDOPAMEKNL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJLDBOLDIKM(Rigidbody ABIICCJBIMP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GIMPGFABMID
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JKIEBOIPEFL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MEKLFNOFPOO
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event OGOEIPLNHKB CNNIHNHIBME;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOMNPEJHMAH();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HJHIJKPFBML();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOGJLPFBOPM();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLGDEGHEGDL();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FLPCJPBDCOK();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDAAJBODNFO(bool BLKPFDLAGAP);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IHCLONJPHBC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DKDEMEEKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEOPAAJBNBI(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGIPCLHFIPE(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEAHDEDOACK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOMFCHGAJOO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KCMLKLODAPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FAKHMMGELAJ(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OMLOLFNJDEA();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LCOLOHKDNLP();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OOOAOLIDEFM();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AADAGEFKAPN();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MMMPLHKBEGG(Rigidbody ABIICCJBIMP);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 CBABHGJJPKF(Vector3 OAAOAKNCDMA);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CKIMBGIPJJG(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DHPGMPPFKMM(Vector3 AMIFBDPJABJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface LLJDFFFDPNL
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool KGHKKAOFOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POMDOELFCOG(string GNLAGDDNMDN);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNEBIBHFEBL(RigidbodyEx NGEPMJPLOFK, Action GAFABDCELFL);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	INIJIIICIKE GKFLLFDODIJ(int MDHFAEOPEAK);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJNJBNKKAIN(Vector3 JHIHJBFBDFF, float DKFGBKANJHB, Color EFLLOODPMDH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NNHGGBDLEBL(POFEBJKDGBG.Application)]
public interface HBFIOLAIDGN
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LLJDFFFDPNL MOFFCFCLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	POEPMBPGKKN HBKJOMDOGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIMFIAMFCKI CNJBBJCKCMH(RigidbodyEx NGEPMJPLOFK);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FAJHLMMDDLF
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJLOCEJOMJ(Vector3 IALELHNBPAC);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBHCEEOLJBP(Vector3 NHOJBJMMDJB);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMFNLPHMJOE(Vector3 IALELHNBPAC);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMAFPMEMOGL(Vector3 NHOJBJMMDJB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IPLEJINKGKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 AILKNJEFAGK();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KLMACOIEGDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CLILEGLKHIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx CAHFGEEGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject FIJMIMBILAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool LGHEANPHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MHEDDKGKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform JMLEHOPCKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 BDHADAPDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float IOPDOGALHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float BLIGPHJJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion EEHOPJHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool MIEPMENDILL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event OGOEIPLNHKB BGNPBFCMPGC;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event OGOEIPLNHKB GBDEACGOBAH;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event CFPKEOMCFGB OJIAPCJIBFC;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event OGOEIPLNHKB MFLAPEJBAAG;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event OGOEIPLNHKB DKPFAAIGKGL;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event OGOEIPLNHKB CNNIHNHIBME;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event OGOEIPLNHKB GPBFDBHNODC;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event OGOEIPLNHKB MJEONDGBFND;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void NGFNEFGPKMD();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void HDGHMIOPPLB();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void OMDBKBLHJMO();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void MOGJLPFBOPM();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void GMIJDPBCEJN(CLILEGLKHIM GCPEEAODAIB, bool LGIEADGADKO = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void DBFDEEPEAND(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void BJIBLOJHNCI(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void AADAGEFKAPN();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void LCOLOHKDNLP();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void OMLOLFNJDEA();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DHPGMPPFKMM(Vector3 AMIFBDPJABJ);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 CBABHGJJPKF(Vector3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 GDJCEJCHEDO(Vector3 GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void OOOAOLIDEFM();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void GDHCGPOBHCJ(CLILEGLKHIM PHEEDLMPGKK, object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void FEMKOCLIAPI(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void HJHICEMDBIG();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void OLHALCKHAMJ();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void ADPIHHLENJE();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool LOMNPEJHMAH();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FLPCJPBDCOK();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable GKBDEHJHPOG();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HNBBAIDPKJG(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void BPGIJLNAJEB(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PFAPPCDBFIE(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OFMMOLCGMJH(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool HECEPIIFOCH(float MFAAODEGFEP);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void ICMNCHDLLDM(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void EGDBONAKCBF(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void OEOPAAJBNBI(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void JGIPCLHFIPE(object KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LNJDCLMNJLM();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DGLLDCMCBOK : CLILEGLKHIM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly HBFIOLAIDGN CEICFMOFGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal EEIHPONFIOE EEAGHNDNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NNGGKLPDBGF GKKAHELJENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KICNEDMPOBN NKKGDFGIPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal KCMLKLODAPB OAAOAKNCDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal PIPBDGDHDEJ HCMGJCDLJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KMICGGOIAGK PKIFLJOJDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal CHDOPAMEKNL ONBHNLKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal GFAEJIJOIIM DNDNLDEEAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MEKLFNOFPOO MGJNMEEIJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal BENFKCACMDO HPEJKEEPJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal LBEMOOJEDNP DPIKCDDINJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal AHLABJLGKJI JNADMECNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal OFECNLJJPMK KKANNCCHNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal IHCLONJPHBC ABIICCJBIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal KGCLDJCOPKE HNOHGNPDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable FDIEOLEGMOH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx CAHFGEEGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x778690", Offset = "0x777290", VA = "0x180778690", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7786D0", Offset = "0x7772D0", VA = "0x1807786D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject FIJMIMBILAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x837820", Offset = "0x836420", VA = "0x180837820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x837230", Offset = "0x835E30", VA = "0x180837230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6394B80", Offset = "0x6393780", VA = "0x186394B80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63944E0", Offset = "0x63930E0", VA = "0x1863944E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63972D0", Offset = "0x6395ED0", VA = "0x1863972D0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6396550", Offset = "0x6395150", VA = "0x186396550", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6393530", Offset = "0x6392130", VA = "0x186393530", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6393580", Offset = "0x6392180", VA = "0x186393580", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x63982E0", Offset = "0x6396EE0", VA = "0x1863982E0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x63978E0", Offset = "0x63964E0", VA = "0x1863978E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x63966C0", Offset = "0x63952C0", VA = "0x1863966C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6394F70", Offset = "0x6393B70", VA = "0x186394F70", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6394480", Offset = "0x6393080", VA = "0x186394480", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6398B70", Offset = "0x6397770", VA = "0x186398B70", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6398B10", Offset = "0x6397710", VA = "0x186398B10", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x63934E0", Offset = "0x63920E0", VA = "0x1863934E0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x63948D0", Offset = "0x63934D0", VA = "0x1863948D0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6398150", Offset = "0x6396D50", VA = "0x186398150", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6392EC0", Offset = "0x6391AC0", VA = "0x186392EC0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6395AD0", Offset = "0x63946D0", VA = "0x186395AD0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6396F70", Offset = "0x6395B70", VA = "0x186396F70", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6397930", Offset = "0x6396530", VA = "0x186397930", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6398070", Offset = "0x6396C70", VA = "0x186398070", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6393630", Offset = "0x6392230", VA = "0x186393630", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x63945F0", Offset = "0x63931F0", VA = "0x1863945F0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ECEGNOKHCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6395180", Offset = "0x6393D80", VA = "0x186395180", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LGHEANPHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6393820", Offset = "0x6392420", VA = "0x186393820", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MHEDDKGKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6393DF0", Offset = "0x63929F0", VA = "0x186393DF0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6396670", Offset = "0x6395270", VA = "0x186396670", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6396B90", Offset = "0x6395790", VA = "0x186396B90", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6398780", Offset = "0x6397380", VA = "0x186398780", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6396C60", Offset = "0x6395860", VA = "0x186396C60", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6397E50", Offset = "0x6396A50", VA = "0x186397E50", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6397420", Offset = "0x6396020", VA = "0x186397420", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6395D10", Offset = "0x6394910", VA = "0x186395D10", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6393FD0", Offset = "0x6392BD0", VA = "0x186393FD0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6396AE0", Offset = "0x63956E0", VA = "0x186396AE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6395670", Offset = "0x6394270", VA = "0x186395670", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6396D40", Offset = "0x6395940", VA = "0x186396D40", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6394C10", Offset = "0x6393810", VA = "0x186394C10", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6398C20", Offset = "0x6397820", VA = "0x186398C20", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6398230", Offset = "0x6396E30", VA = "0x186398230", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6393370", Offset = "0x6391F70", VA = "0x186393370", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6395750", Offset = "0x6394350", VA = "0x186395750", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6398280", Offset = "0x6396E80", VA = "0x186398280", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6394EC0", Offset = "0x6393AC0", VA = "0x186394EC0", Slot = "48")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6394A50", Offset = "0x6393650", VA = "0x186394A50", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6398730", Offset = "0x6397330", VA = "0x186398730", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform JMLEHOPCKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6395360", Offset = "0x6393F60", VA = "0x186395360", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 BDHADAPDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6393430", Offset = "0x6392030", VA = "0x186393430", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6395550", Offset = "0x6394150", VA = "0x186395550", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float IOPDOGALHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x63957A0", Offset = "0x63943A0", VA = "0x1863957A0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x63957C0", Offset = "0x63943C0", VA = "0x1863957C0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float BLIGPHJJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6394AB0", Offset = "0x63936B0", VA = "0x186394AB0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6396E10", Offset = "0x6395A10", VA = "0x186396E10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion EEHOPJHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6393710", Offset = "0x6392310", VA = "0x186393710", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6394CD0", Offset = "0x63938D0", VA = "0x186394CD0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6395310", Offset = "0x6393F10", VA = "0x186395310", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6397380", Offset = "0x6395F80", VA = "0x186397380", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6397240", Offset = "0x6395E40", VA = "0x186397240", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6395E00", Offset = "0x6394A00", VA = "0x186395E00", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6394820", Offset = "0x6393420", VA = "0x186394820", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6394F10", Offset = "0x6393B10", VA = "0x186394F10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6393C30", Offset = "0x6392830", VA = "0x186393C30", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6396F10", Offset = "0x6395B10", VA = "0x186396F10", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6394020", Offset = "0x6392C20", VA = "0x186394020", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6397320", Offset = "0x6395F20", VA = "0x186397320", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x63970B0", Offset = "0x6395CB0", VA = "0x1863970B0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MIEPMENDILL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6397CD0", Offset = "0x63968D0", VA = "0x186397CD0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GGEJDFJFOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6395010", Offset = "0x6393C10", VA = "0x186395010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JPIBKIJOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6396060", Offset = "0x6394C60", VA = "0x186396060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OGOEIPLNHKB BGNPBFCMPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6394870", Offset = "0x6393470", VA = "0x186394870", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6396610", Offset = "0x6395210", VA = "0x186396610", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x63965B0", Offset = "0x63951B0", VA = "0x1863965B0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6395CB0", Offset = "0x63948B0", VA = "0x186395CB0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6396710", Offset = "0x6395310", VA = "0x186396710", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6398410", Offset = "0x6397010", VA = "0x186398410", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6398BC0", Offset = "0x63977C0", VA = "0x186398BC0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6394590", Offset = "0x6393190", VA = "0x186394590", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event OGOEIPLNHKB DKPFAAIGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6395830", Offset = "0x6394430", VA = "0x186395830", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6393310", Offset = "0x6391F10", VA = "0x186393310", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x63939E0", Offset = "0x63925E0", VA = "0x1863939E0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6393980", Offset = "0x6392580", VA = "0x186393980", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x63933D0", Offset = "0x6391FD0", VA = "0x1863933D0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6393C80", Offset = "0x6392880", VA = "0x186393C80", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6397050", Offset = "0x6395C50", VA = "0x186397050", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x63950B0", Offset = "0x6393CB0", VA = "0x1863950B0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event OGOEIPLNHKB MJEONDGBFND
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6395370", Offset = "0x6393F70", VA = "0x186395370", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6395FB0", Offset = "0x6394BB0", VA = "0x186395FB0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6398CC0", Offset = "0x63978C0", VA = "0x186398CC0")]
	public DGLLDCMCBOK(GameObject LCHNDEILNAI, RigidbodyEx JABJLOBNFKI, HBFIOLAIDGN CEICFMOFGAN, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x63975F0", Offset = "0x63961F0", VA = "0x1863975F0", Slot = "135")]
	protected virtual void NBHADOFBBJF(HBFIOLAIDGN CEICFMOFGAN, AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63942F0", Offset = "0x6392EF0", VA = "0x1863942F0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6397F30", Offset = "0x6396B30", VA = "0x186397F30", Slot = "71")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6392E00", Offset = "0x6391A00", VA = "0x186392E00", Slot = "72")]
	public void HDGHMIOPPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6398670", Offset = "0x6397270", VA = "0x186398670", Slot = "73")]
	public void OMDBKBLHJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6398860", Offset = "0x6397460", VA = "0x186398860")]
	private void PDJCDDIBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6395110", Offset = "0x6393D10", VA = "0x186395110", Slot = "81")]
	public void GMIJDPBCEJN(CLILEGLKHIM GCPEEAODAIB, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6393ED0", Offset = "0x6392AD0", VA = "0x186393ED0", Slot = "84")]
	public void DBFDEEPEAND(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63935D0", Offset = "0x63921D0", VA = "0x1863935D0", Slot = "85")]
	public void BJIBLOJHNCI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6397A10", Offset = "0x6396610", VA = "0x186397A10", Slot = "86")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63941F0", Offset = "0x6392DF0", VA = "0x1863941F0", Slot = "87")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6392E00", Offset = "0x6391A00", VA = "0x186392E00", Slot = "88")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6396B40", Offset = "0x6395740", VA = "0x186396B40", Slot = "89")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6398690", Offset = "0x6397290", VA = "0x186398690", Slot = "90")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6397500", Offset = "0x6396100", VA = "0x186397500", Slot = "91")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63946D0", Offset = "0x63932D0", VA = "0x1863946D0", Slot = "92")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6394070", Offset = "0x6392C70", VA = "0x186394070", Slot = "93")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63943C0", Offset = "0x6392FC0", VA = "0x1863943C0", Slot = "94")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6394150", Offset = "0x6392D50", VA = "0x186394150", Slot = "95")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6396200", Offset = "0x6394E00", VA = "0x186396200", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6393880", Offset = "0x6392480", VA = "0x186393880", Slot = "97")]
	public Vector3 CBABHGJJPKF(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6394DC0", Offset = "0x63939C0", VA = "0x186394DC0", Slot = "98")]
	public Vector3 GDJCEJCHEDO(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x63986E0", Offset = "0x63972E0", VA = "0x1863986E0", Slot = "99")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6394C60", Offset = "0x6393860", VA = "0x186394C60", Slot = "100")]
	public void GDHCGPOBHCJ(CLILEGLKHIM PHEEDLMPGKK, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63947C0", Offset = "0x63933C0", VA = "0x1863947C0", Slot = "101")]
	public void FEMKOCLIAPI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63951D0", Offset = "0x6393DD0", VA = "0x1863951D0", Slot = "41")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6395420", Offset = "0x6394020", VA = "0x186395420", Slot = "104")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6398620", Offset = "0x6397220", VA = "0x186398620", Slot = "105")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6392FA0", Offset = "0x6391BA0", VA = "0x186392FA0", Slot = "106")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6397280", Offset = "0x6395E80", VA = "0x186397280", Slot = "109")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x63973D0", Offset = "0x6395FD0", VA = "0x1863973D0", Slot = "74")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6394930", Offset = "0x6393530", VA = "0x186394930", Slot = "110")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6394FC0", Offset = "0x6393BC0", VA = "0x186394FC0", Slot = "115")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6395610", Offset = "0x6394210", VA = "0x186395610", Slot = "116")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63937C0", Offset = "0x63923C0", VA = "0x1863937C0", Slot = "117")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6392E50", Offset = "0x6391A50", VA = "0x186392E50", Slot = "118")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6398910", Offset = "0x6397510", VA = "0x186398910", Slot = "121")]
	public void PFAPPCDBFIE(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x63984D0", Offset = "0x63970D0", VA = "0x1863984D0", Slot = "122")]
	public void OFMMOLCGMJH(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63952B0", Offset = "0x6393EB0", VA = "0x1863952B0", Slot = "123")]
	public bool HECEPIIFOCH(float MFAAODEGFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6395890", Offset = "0x6394490", VA = "0x186395890", Slot = "124")]
	public void ICMNCHDLLDM(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6394530", Offset = "0x6393130", VA = "0x186394530", Slot = "125")]
	public void EGDBONAKCBF(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6398470", Offset = "0x6397070", VA = "0x186398470", Slot = "126")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6396090", Offset = "0x6394C90", VA = "0x186396090", Slot = "127")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x63962B0", Offset = "0x6394EB0", VA = "0x1863962B0", Slot = "128")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6393CE0", Offset = "0x63928E0", VA = "0x186393CE0", Slot = "129")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6397B10", Offset = "0x6396710", VA = "0x186397B10", Slot = "130")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6395470", Offset = "0x6394070", VA = "0x186395470", Slot = "131")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6395D60", Offset = "0x6394960", VA = "0x186395D60", Slot = "132")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x63971F0", Offset = "0x6395DF0", VA = "0x1863971F0", Slot = "133")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6398C80", Offset = "0x6397880", VA = "0x186398C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6397BF0", Offset = "0x63967F0", VA = "0x186397BF0")]
	private void NEJMHGMPOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63960F0", Offset = "0x6394CF0", VA = "0x1863960F0")]
	private void JHDGOEDHDBJ(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6393A40", Offset = "0x6392640", VA = "0x186393A40")]
	private void CFKOKFBNPFE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6394AD0", Offset = "0x63936D0", VA = "0x186394AD0")]
	private void FPFGOJGGPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6395BB0", Offset = "0x63947B0", VA = "0x186395BB0")]
	private void IGDFFJLNGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63958F0", Offset = "0x63944F0", VA = "0x1863958F0")]
	private void IEGAOAAOBEM(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6398340", Offset = "0x6396F40", VA = "0x186398340")]
	private void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6394980", Offset = "0x6393580", VA = "0x186394980")]
	private void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6395E40", Offset = "0x6394A40", VA = "0x186395E40")]
	private void ILCIMKHHOLC(RigidbodyEx HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6396390", Offset = "0x6394F90", VA = "0x186396390", Slot = "140")]
	protected virtual void JHMDCGKOPAI(RigidbodyEx NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6392FF0", Offset = "0x6391BF0", VA = "0x186392FF0")]
	protected void AEHCKCCMJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6396770", Offset = "0x6395370", VA = "0x186396770")]
	protected void KNONLCKOEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6393F30", Offset = "0x6392B30", VA = "0x186393F30", Slot = "141")]
	protected virtual IDisposable DBHLFGNEEOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class FHBOKDOGOFK
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x639E9B0", Offset = "0x639D5B0", VA = "0x18639E9B0")]
	public static CLILEGLKHIM KHCFAAIDMDM(this CLILEGLKHIM NGEPMJPLOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x639E860", Offset = "0x639D460", VA = "0x18639E860")]
	public static bool BAHIAHNENME(this CLILEGLKHIM NGEPMJPLOFK, CLILEGLKHIM OJBFIKOJPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x639E7E0", Offset = "0x639D3E0", VA = "0x18639E7E0")]
	public static bool AFAFEMABLKI(this CLILEGLKHIM NGEPMJPLOFK, CLILEGLKHIM EKOLKIEBGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x639E8E0", Offset = "0x639D4E0", VA = "0x18639E8E0")]
	public static RigidbodyEx CAHFGEEGHBM(this CLILEGLKHIM JDONOAIINGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x639E930", Offset = "0x639D530", VA = "0x18639E930")]
	public static DGLLDCMCBOK GDLDENIIFFE(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class GKOLACODPEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63A0550", Offset = "0x639F150", VA = "0x1863A0550")]
	public GKOLACODPEA(DGLLDCMCBOK OIPEAFPNBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63A04F0", Offset = "0x639F0F0", VA = "0x1863A04F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class ICIGCPCPNCL : FBINNMIICHO, KGCLDJCOPKE
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode JOKIDHDKKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x63A1F50", Offset = "0x63A0B50", VA = "0x1863A1F50")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63A2390", Offset = "0x63A0F90", VA = "0x1863A2390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x63A1FB0", Offset = "0x63A0BB0", VA = "0x1863A1FB0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63A2410", Offset = "0x63A1010", VA = "0x1863A2410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public ICIGCPCPNCL(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x63A25B0", Offset = "0x63A11B0", VA = "0x1863A25B0", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x63A24D0", Offset = "0x63A10D0", VA = "0x1863A24D0", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x63A2700", Offset = "0x63A1300", VA = "0x1863A2700", Slot = "7")]
	public void PDLKPLFJPBP(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x63A2400", Offset = "0x63A1000", VA = "0x1863A2400", Slot = "8")]
	public void JNIJEEAEHLJ(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x63A2230", Offset = "0x63A0E30", VA = "0x1863A2230", Slot = "10")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63A20C0", Offset = "0x63A0CC0", VA = "0x1863A20C0")]
	private void FDINCMNMGKM(bool IGOALBDIPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GJJPCDCDEJK : FBINNMIICHO, BENFKCACMDO, IDisposable, OBKCDKHLKCL
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public AKKMOBBIBLF AKBEIMFPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x63A0100", Offset = "0x639ED00", VA = "0x1863A0100")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A01E0", Offset = "0x639EDE0", VA = "0x1863A01E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A02D0", Offset = "0x639EED0", VA = "0x1863A02D0", Slot = "6")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A01E0", Offset = "0x639EDE0", VA = "0x1863A01E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform HPNIBGPOPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x639FFA0", Offset = "0x639EBA0", VA = "0x18639FFA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A0050", Offset = "0x639EC50", VA = "0x1863A0050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public GJJPCDCDEJK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A04D0", Offset = "0x639F0D0", VA = "0x1863A04D0", Slot = "11")]
	public void OnChangedDistanceBand(HHMPBKNCJLA MLMDDEIDFHL, HHMPBKNCJLA CHGDNKMNMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "12")]
	public void OnChangedVisibility(bool EBLHCGOJIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class MCNABBOOKKN : FBINNMIICHO, AHLABJLGKJI
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x63A33D0", Offset = "0x63A1FD0", VA = "0x1863A33D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6390EB0", Offset = "0x638FAB0", VA = "0x186390EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x63AAA10", Offset = "0x63A9610", VA = "0x1863AAA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public MCNABBOOKKN(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63AA7D0", Offset = "0x63A93D0", VA = "0x1863AA7D0", Slot = "4")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A9DB0", Offset = "0x63A89B0", VA = "0x1863A9DB0")]
	private void BHCOCEGHJLN(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63AA2F0", Offset = "0x63A8EF0", VA = "0x1863AA2F0", Slot = "5")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63AAA70", Offset = "0x63A9670", VA = "0x1863AAA70", Slot = "6")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AA090", Offset = "0x63A8C90", VA = "0x1863AA090")]
	private void CEGDEFNIAEI(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63AA570", Offset = "0x63A9170", VA = "0x1863AA570", Slot = "7")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63AA930", Offset = "0x63A9530", VA = "0x1863AA930")]
	private void JJBLJPHBGMP(string EOOPGFAEMIH, UnityEngine.Object BFDLBONPDOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CGDODDCIJGP : FBINNMIICHO, GFAEJIJOIIM
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6391E10", Offset = "0x6390A10", VA = "0x186391E10", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6391F00", Offset = "0x6390B00", VA = "0x186391F00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public CGDODDCIJGP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6391E70", Offset = "0x6390A70", VA = "0x186391E70", Slot = "6")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6392050", Offset = "0x6390C50", VA = "0x186392050", Slot = "7")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class NIMGJOOFFAA : FBINNMIICHO, EEIHPONFIOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly ELHKCOAEACJ ONDOOCCPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JGMCPGPGBLB CMBGICPEAJE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x63B2B40", Offset = "0x63B1740", VA = "0x1863B2B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HIMFIAMFCKI IMBNAELJKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x63B3BF0", Offset = "0x63B27F0", VA = "0x1863B3BF0")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x63B2C10", Offset = "0x63B1810", VA = "0x1863B2C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x63B3610", Offset = "0x63B2210", VA = "0x1863B3610", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x63B3320", Offset = "0x63B1F20", VA = "0x1863B3320", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public HIMFIAMFCKI IHJEOLPDHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x63B2FD0", Offset = "0x63B1BD0", VA = "0x1863B2FD0")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63B3930", Offset = "0x63B2530", VA = "0x1863B3930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B21E0", Offset = "0x63B0DE0", VA = "0x1863B21E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event OGOEIPLNHKB BGNPBFCMPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x63B29F0", Offset = "0x63B15F0", VA = "0x1863B29F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63B3430", Offset = "0x63B2030", VA = "0x1863B3430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x63B3390", Offset = "0x63B1F90", VA = "0x1863B3390", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63B3120", Offset = "0x63B1D20", VA = "0x1863B3120", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x63B34D0", Offset = "0x63B20D0", VA = "0x1863B34D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63B3C50", Offset = "0x63B2850", VA = "0x1863B3C50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action OLFMHBNNIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x63B3570", Offset = "0x63B2170", VA = "0x1863B3570", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x63B1FF0", Offset = "0x63B0BF0", VA = "0x1863B1FF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action NILEMMLPJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x63B2F30", Offset = "0x63B1B30", VA = "0x1863B2F30", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63B2B70", Offset = "0x63B1770", VA = "0x1863B2B70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<CLILEGLKHIM> AGBNPPLPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63B3880", Offset = "0x63B2480", VA = "0x1863B3880", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x63B1EA0", Offset = "0x63B0AA0", VA = "0x1863B1EA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<CLILEGLKHIM> LEGHKNLKFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x63B2810", Offset = "0x63B1410", VA = "0x1863B2810", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x63B2130", Offset = "0x63B0D30", VA = "0x1863B2130", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HGNEPMKMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x63B2090", Offset = "0x63B0C90", VA = "0x1863B2090", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x63B2770", Offset = "0x63B1370", VA = "0x1863B2770", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<CLILEGLKHIM> BIKBACEBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63B3270", Offset = "0x63B1E70", VA = "0x1863B3270", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x63B31C0", Offset = "0x63B1DC0", VA = "0x1863B31C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63B3D80", Offset = "0x63B2980", VA = "0x1863B3D80")]
	public NIMGJOOFFAA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63B28C0", Offset = "0x63B14C0", VA = "0x1863B28C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63B2C80", Offset = "0x63B1880", VA = "0x1863B2C80", Slot = "26")]
	public void GMIJDPBCEJN(CLILEGLKHIM OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63B2D00", Offset = "0x63B1900", VA = "0x1863B2D00")]
	private void GMIJDPBCEJN(KKMILDLPGMG OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x63B22F0", Offset = "0x63B0EF0", VA = "0x1863B22F0")]
	private void DDEICLFKDHK(KKMILDLPGMG OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63B39A0", Offset = "0x63B25A0", VA = "0x1863B39A0")]
	private void NLHLDPBPJBG(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x63B3680", Offset = "0x63B2280", VA = "0x1863B3680")]
	private void MJHJCLDHBJN(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63B2D50", Offset = "0x63B1950", VA = "0x1863B2D50")]
	private void HBMJDCNFGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A90", Offset = "0x63B1690", VA = "0x1863B2A90")]
	private void FLMOENJIEAN(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B3030", Offset = "0x63B1C30", VA = "0x1863B3030")]
	private void IFPNIADGDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B2250", Offset = "0x63B0E50", VA = "0x1863B2250")]
	private void DDBFHNLJBCE(KKMILDLPGMG NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B1F50", Offset = "0x63B0B50", VA = "0x1863B1F50")]
	private void BCPPHKCNPIG(KKMILDLPGMG NGEPMJPLOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class CCEPLLBOGHO
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6391C80", Offset = "0x6390880", VA = "0x186391C80")]
	public static NIMGJOOFFAA AHHFEGHKCLN(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DJBEPEABJBH : FBINNMIICHO, PIPBDGDHDEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x639CDD0", Offset = "0x639B9D0", VA = "0x18639CDD0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x639CF60", Offset = "0x639BB60", VA = "0x18639CF60", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x639CE70", Offset = "0x639BA70", VA = "0x18639CE70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private CLILEGLKHIM HOPEHPMKHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x639D190", Offset = "0x639BD90", VA = "0x18639D190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public DJBEPEABJBH(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x639C760", Offset = "0x639B360", VA = "0x18639C760", Slot = "6")]
	public void IOBGBBEPPKF(CLILEGLKHIM HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x639C8B0", Offset = "0x639B4B0", VA = "0x18639C8B0")]
	private void IOBGBBEPPKF(KKMILDLPGMG HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x639CE00", Offset = "0x639BA00", VA = "0x18639CE00", Slot = "7")]
	public void LHBNKJHAMAA(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x639C9C0", Offset = "0x639B5C0", VA = "0x18639C9C0")]
	private Vector3 KJBIIKFNEKK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EFIHGHEKHIG
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x639D360", Offset = "0x639BF60", VA = "0x18639D360")]
	public static DJBEPEABJBH MLHMAMCDIEJ(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class DICLMKGNGPO : FBINNMIICHO, KMICGGOIAGK
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x639B150", Offset = "0x6399D50", VA = "0x18639B150", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6399CB0", Offset = "0x63988B0", VA = "0x186399CB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 EBOFFPNCNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6398EF0", Offset = "0x6397AF0", VA = "0x186398EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 LBMAKPMAKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6399430", Offset = "0x6398030", VA = "0x186399430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x639B900", Offset = "0x639A500", VA = "0x18639B900", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6399C50", Offset = "0x6398850", VA = "0x186399C50", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float DCEMBMHMCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x639C3F0", Offset = "0x639AFF0", VA = "0x18639C3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6398E90", Offset = "0x6397A90", VA = "0x186398E90", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6399E30", Offset = "0x6398A30", VA = "0x186399E30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x63999E0", Offset = "0x63985E0", VA = "0x1863999E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x639B200", Offset = "0x6399E00", VA = "0x18639B200", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event OGOEIPLNHKB EOBAIGEGIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x639BAF0", Offset = "0x639A6F0", VA = "0x18639BAF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6398DF0", Offset = "0x63979F0", VA = "0x186398DF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x639C470", Offset = "0x639B070", VA = "0x18639C470")]
	public DICLMKGNGPO(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x639BB90", Offset = "0x639A790", VA = "0x18639BB90")]
	public float3 NOOFAPAMMDN()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6399560", Offset = "0x6398160", VA = "0x186399560", Slot = "14")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63997F0", Offset = "0x63983F0", VA = "0x1863997F0", Slot = "16")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x639C0A0", Offset = "0x639ACA0", VA = "0x18639C0A0", Slot = "15")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x639B830", Offset = "0x639A430", VA = "0x18639B830", Slot = "18")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x639BCB0", Offset = "0x639A8B0", VA = "0x18639BCB0", Slot = "19")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6398D90", Offset = "0x6397990", VA = "0x186398D90", Slot = "17")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x639B230", Offset = "0x6399E30", VA = "0x18639B230", Slot = "20")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x63915A0", Offset = "0x63901A0", VA = "0x1863915A0")]
	public void GCEJKNBMGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6399CB0", Offset = "0x63988B0", VA = "0x186399CB0")]
	private void KIEBBGKDHKM(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6398FA0", Offset = "0x6397BA0", VA = "0x186398FA0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 DIKNILAGHJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6399E30", Offset = "0x6398A30", VA = "0x186399E30")]
	private void PJLBHDMMAEJ(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63991D0", Offset = "0x6397DD0", VA = "0x1863991D0")]
	private Vector3 EHFEJJCOOKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6399A10", Offset = "0x6398610", VA = "0x186399A10")]
	private Quaternion IHGJEPAKGOG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6399EF0", Offset = "0x6398AF0", VA = "0x186399EF0")]
	internal (float, Vector3) LADLLHGCBIO(Rigidbody JMIIEAMEOBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LNDNJHCLKLP
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63A9A60", Offset = "0x63A8660", VA = "0x1863A9A60")]
	public static DICLMKGNGPO HFGNLCEIHGC(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FIJAODCFAHB : FBINNMIICHO, NNGGKLPDBGF
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool LPBCPLHBEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x639EF30", Offset = "0x639DB30", VA = "0x18639EF30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NLLCDEONLOL HJMOMBBLICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x639EA60", Offset = "0x639D660", VA = "0x18639EA60", Slot = "11")]
		get
		{
			return default(NLLCDEONLOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private NLLCDEONLOL OHPPIBOBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x639EA60", Offset = "0x639D660", VA = "0x18639EA60")]
		get
		{
			return default(NLLCDEONLOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x639EC40", Offset = "0x639D840", VA = "0x18639EC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x639F370", Offset = "0x639DF70", VA = "0x18639F370")]
	public FIJAODCFAHB(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x639F1F0", Offset = "0x639DDF0", VA = "0x18639F1F0", Slot = "4")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x639ECB0", Offset = "0x639D8B0", VA = "0x18639ECB0")]
	private bool FHDHEKEGDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x639F2F0", Offset = "0x639DEF0", VA = "0x18639F2F0", Slot = "5")]
	public void OACOBDCKHGB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x639EBC0", Offset = "0x639D7C0", VA = "0x18639EBC0", Slot = "6")]
	public void FEDLOEEFJBP(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x639EF90", Offset = "0x639DB90", VA = "0x18639EF90", Slot = "9")]
	public void JBLKMCFBKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x639EAC0", Offset = "0x639D6C0", VA = "0x18639EAC0")]
	private void EILCIKCCDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x639ED90", Offset = "0x639D990", VA = "0x18639ED90")]
	private void GMIJGIHDHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x639F0F0", Offset = "0x639DCF0", VA = "0x18639F0F0", Slot = "8")]
	public void LEBKMNKBKFA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x639F170", Offset = "0x639DD70", VA = "0x18639F170", Slot = "7")]
	public void MHEJHHEDMIC(CLILEGLKHIM NGEPMJPLOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ABCBCGCJNJJ : FBINNMIICHO, LBEMOOJEDNP
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x63914E0", Offset = "0x63900E0", VA = "0x1863914E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool CIJMIMDKPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6391540", Offset = "0x6390140", VA = "0x186391540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6391280", Offset = "0x638FE80", VA = "0x186391280", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63911D0", Offset = "0x638FDD0", VA = "0x1863911D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public ABCBCGCJNJJ(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6391160", Offset = "0x638FD60", VA = "0x186391160", Slot = "11")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6391270", Offset = "0x638FE70", VA = "0x186391270", Slot = "8")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6391150", Offset = "0x638FD50", VA = "0x186391150", Slot = "9")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6391050", Offset = "0x638FC50", VA = "0x186391050", Slot = "10")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6391320", Offset = "0x638FF20", VA = "0x186391320", Slot = "12")]
	public void MMMPLHKBEGG(Rigidbody IDJLKFJMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6391400", Offset = "0x6390000", VA = "0x186391400", Slot = "13")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x63915A0", Offset = "0x63901A0", VA = "0x1863915A0", Slot = "6")]
	public void PKDOINHLNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EHNDLHLHHNC : FBINNMIICHO, KICNEDMPOBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView BFJDFNLOLMK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x639DBB0", Offset = "0x639C7B0", VA = "0x18639DBB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x639D9D0", Offset = "0x639C5D0", VA = "0x18639D9D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x639E0C0", Offset = "0x639CCC0", VA = "0x18639E0C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x639D550", Offset = "0x639C150", VA = "0x18639D550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x639E160", Offset = "0x639CD60", VA = "0x18639E160")]
	public EHNDLHLHHNC(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x639DBD0", Offset = "0x639C7D0", VA = "0x18639DBD0", Slot = "8")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x639D3F0", Offset = "0x639BFF0", VA = "0x18639D3F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x639DEC0", Offset = "0x639CAC0", VA = "0x18639DEC0", Slot = "9")]
	public void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x639D7D0", Offset = "0x639C3D0", VA = "0x18639D7D0", Slot = "10")]
	public void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x639D5F0", Offset = "0x639C1F0", VA = "0x18639D5F0")]
	private void FCODMEHCEOM(PhotonView KFHLGPCEJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x639DA60", Offset = "0x639C660", VA = "0x18639DA60")]
	private void KELGPNGFFHP(RigidbodyEx BDNPBMBDKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x639DD00", Offset = "0x639C900", VA = "0x18639DD00")]
	private void NLEGMHOHKFJ(PhotonView KJFGFKCMNHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class FJLCKCCDDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x639F480", Offset = "0x639E080", VA = "0x18639F480")]
	public static EHNDLHLHHNC ADNKGJGMIMI(this DGLLDCMCBOK OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class ACBDPIBBFKF : FBINNMIICHO, OFECNLJJPMK
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6391680", Offset = "0x6390280", VA = "0x186391680", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6391930", Offset = "0x6390530", VA = "0x186391930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OECAEIFCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x63919A0", Offset = "0x63905A0", VA = "0x1863919A0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x63916E0", Offset = "0x63902E0", VA = "0x1863916E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6391750", Offset = "0x6390350", VA = "0x186391750", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x63917B0", Offset = "0x63903B0", VA = "0x1863917B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6391B10", Offset = "0x6390710", VA = "0x186391B10")]
	public ACBDPIBBFKF(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6391A00", Offset = "0x6390600", VA = "0x186391A00", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6391A90", Offset = "0x6390690", VA = "0x186391A90", Slot = "10")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class FFMIDAMDOIP : FBINNMIICHO, CHDOPAMEKNL
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x639E410", Offset = "0x639D010", VA = "0x18639E410", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x639E690", Offset = "0x639D290", VA = "0x18639E690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x639E560", Offset = "0x639D160", VA = "0x18639E560", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x639E2C0", Offset = "0x639CEC0", VA = "0x18639E2C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public FFMIDAMDOIP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x639E470", Offset = "0x639D070", VA = "0x18639E470", Slot = "8")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x639E5C0", Offset = "0x639D1C0", VA = "0x18639E5C0", Slot = "9")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[GKFKBGDODHH(typeof(IMADJJBFFKJ), new string[] { })]
public sealed class HHJMBPHICJK : HKECKBDIOOH, IMADJJBFFKJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[LEKELIKDPPG]
	private DMOPNDHELBN NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x63A1B60", Offset = "0x63A0760", VA = "0x1863A1B60", Slot = "4")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x63A1820", Offset = "0x63A0420", VA = "0x1863A1820", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x63A1CF0", Offset = "0x63A08F0", VA = "0x1863A1CF0", Slot = "6")]
	public void LADLLHGCBIO(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x63A1940", Offset = "0x63A0540", VA = "0x1863A1940", Slot = "7")]
	public void GKPKDAOPFPI(HIMFIAMFCKI JMADFINDJPP, bool DFFPADHABEE, bool OKBHBCKEAAE, bool POBFAOIOMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1BB0", Offset = "0x63A07B0", VA = "0x1863A1BB0", Slot = "8")]
	public void KJDGMNNJMJN(HIMFIAMFCKI JMADFINDJPP, float3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x63A1E10", Offset = "0x63A0A10", VA = "0x1863A1E10", Slot = "9")]
	public void NEGFIOJHAGH(HIMFIAMFCKI JMADFINDJPP, float3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x63A1670", Offset = "0x63A0270", VA = "0x1863A1670")]
	private bool COAGNOJMKKH(HIMFIAMFCKI JMADFINDJPP, [Out] KKMILDLPGMG OGDBMIPIOMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x63A1850", Offset = "0x63A0450", VA = "0x1863A1850")]
	private bool FLLFFCDOMHK(HIMFIAMFCKI JMADFINDJPP, [Out] DICLMKGNGPO JMJLNPMKJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63A1730", Offset = "0x63A0330", VA = "0x1863A1730")]
	private bool DFMAPPOLDPC(HIMFIAMFCKI JMADFINDJPP, [Out] MMANNDEFLCE KHHBOGBBOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public HHJMBPHICJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class NDDANHKEPKL : FBINNMIICHO, MEKLFNOFPOO
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x63B0380", Offset = "0x63AEF80", VA = "0x1863B0380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x63B1B10", Offset = "0x63B0710", VA = "0x1863B1B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x63B1D10", Offset = "0x63B0910", VA = "0x1863B1D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool HJCPDOLFGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x63B1830", Offset = "0x63B0430", VA = "0x1863B1830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x63B15B0", Offset = "0x63B01B0", VA = "0x1863B15B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool JAGAPMNGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x63B17D0", Offset = "0x63B03D0", VA = "0x1863B17D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x63B1760", Offset = "0x63B0360", VA = "0x1863B1760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int IACOLECINOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x63B1900", Offset = "0x63B0500", VA = "0x1863B1900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x63B1510", Offset = "0x63B0110", VA = "0x1863B1510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x63B1470", Offset = "0x63B0070", VA = "0x1863B1470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63B1D70", Offset = "0x63B0970", VA = "0x1863B1D70")]
	public NDDANHKEPKL(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63B1C60", Offset = "0x63B0860", VA = "0x1863B1C60", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x63B1890", Offset = "0x63B0490", VA = "0x1863B1890", Slot = "8")]
	public void HJHIJKPFBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x63B1970", Offset = "0x63B0570", VA = "0x1863B1970", Slot = "7")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63B1B70", Offset = "0x63B0770", VA = "0x1863B1B70", Slot = "9")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x63915A0", Offset = "0x63901A0", VA = "0x1863915A0", Slot = "12")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x63B1620", Offset = "0x63B0220", VA = "0x1863B1620", Slot = "11")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "10")]
	public void BLGDEGHEGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x63B1390", Offset = "0x63AFF90", VA = "0x1863B1390")]
	private void CBILABAMGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class AAAMMPJFOPL : FBINNMIICHO, IHCLONJPHBC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6390930", Offset = "0x638F530", VA = "0x186390930", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6390AF0", Offset = "0x638F6F0", VA = "0x186390AF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6390EB0", Offset = "0x638FAB0", VA = "0x186390EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool DKDEMEEKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6390A10", Offset = "0x638F610", VA = "0x186390A10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6390F90", Offset = "0x638FB90", VA = "0x186390F90")]
	public AAAMMPJFOPL(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6390E00", Offset = "0x638FA00", VA = "0x186390E00", Slot = "5")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6390F10", Offset = "0x638FB10", VA = "0x186390F10", Slot = "7")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6390A70", Offset = "0x638F670", VA = "0x186390A70", Slot = "8")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6390BE0", Offset = "0x638F7E0", VA = "0x186390BE0", Slot = "9")]
	public void NEAHDEDOACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6390500", Offset = "0x638F100", VA = "0x186390500", Slot = "11")]
	public void BELMCIBIMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6390760", Offset = "0x638F360", VA = "0x186390760", Slot = "12")]
	public void CIGBACBOEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "10")]
	public void DOMFCHGAJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MMANNDEFLCE : FBINNMIICHO, KCMLKLODAPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x63AF490", Offset = "0x63AE090", VA = "0x1863AF490", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x63AF290", Offset = "0x63ADE90", VA = "0x1863AF290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63B0CE0", Offset = "0x63AF8E0", VA = "0x1863B0CE0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x63B0C70", Offset = "0x63AF870", VA = "0x1863B0C70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x63B0750", Offset = "0x63AF350", VA = "0x1863B0750", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x63B0990", Offset = "0x63AF590", VA = "0x1863B0990", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x63B0A50", Offset = "0x63AF650", VA = "0x1863B0A50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x63AD860", Offset = "0x63AC460", VA = "0x1863AD860", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x63ADB70", Offset = "0x63AC770", VA = "0x1863ADB70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x63AF300", Offset = "0x63ADF00", VA = "0x1863AF300", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x63AFB10", Offset = "0x63AE710", VA = "0x1863AFB10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x63B0350", Offset = "0x63AEF50", VA = "0x1863B0350", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x63ADB10", Offset = "0x63AC710", VA = "0x1863ADB10", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x63ADD20", Offset = "0x63AC920", VA = "0x1863ADD20", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x63B0000", Offset = "0x63AEC00", VA = "0x1863B0000", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private AHLABJLGKJI GJNBOIKJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6740", Offset = "0x1CB5340", VA = "0x181CB6740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x63B0380", Offset = "0x63AEF80", VA = "0x1863B0380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public MMANNDEFLCE(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63AF420", Offset = "0x63AE020", VA = "0x1863AF420", Slot = "20")]
	public void FAKHMMGELAJ(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x63ADCB0", Offset = "0x63AC8B0", VA = "0x1863ADCB0", Slot = "30")]
	public void CKIMBGIPJJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x63AD7B0", Offset = "0x63AC3B0", VA = "0x1863AD7B0", Slot = "19")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC60", Offset = "0x63AD860", VA = "0x1863AEC60", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x63B03A0", Offset = "0x63AEFA0", VA = "0x1863B03A0", Slot = "28")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x63B07B0", Offset = "0x63AF3B0", VA = "0x1863B07B0", Slot = "35")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x63AEAA0", Offset = "0x63AD6A0", VA = "0x1863AEAA0", Slot = "34")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x63AD7B0", Offset = "0x63AC3B0", VA = "0x1863AD7B0", Slot = "27")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x63B02F0", Offset = "0x63AEEF0", VA = "0x1863B02F0", Slot = "25")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x63B0A80", Offset = "0x63AF680", VA = "0x1863B0A80", Slot = "24")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63B0510", Offset = "0x63AF110", VA = "0x1863B0510", Slot = "33")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x63AF3C0", Offset = "0x63ADFC0", VA = "0x1863AF3C0", Slot = "32")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x63AE620", Offset = "0x63AD220", VA = "0x1863AE620", Slot = "31")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63AED20", Offset = "0x63AD920", VA = "0x1863AED20", Slot = "22")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x63AE7F0", Offset = "0x63AD3F0", VA = "0x1863AE7F0", Slot = "21")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB40", Offset = "0x63AE740", VA = "0x1863AFB40", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x63ADBD0", Offset = "0x63AC7D0", VA = "0x1863ADBD0", Slot = "29")]
	public Vector3 CBABHGJJPKF(Vector3 OAAOAKNCDMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63B0AE0", Offset = "0x63AF6E0", VA = "0x1863B0AE0", Slot = "26")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63ADD20", Offset = "0x63AC920", VA = "0x1863ADD20")]
	private void CMBPFKHCHEE(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63AE3F0", Offset = "0x63ACFF0", VA = "0x1863AE3F0")]
	private void DCBNDJBMBCH(Vector3 OLNHEMAINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63AD890", Offset = "0x63AC490", VA = "0x1863AD890")]
	private Vector3 BBCFODFLNIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x63ADE70", Offset = "0x63ACA70", VA = "0x1863ADE70")]
	private void CMMNNGGKIMB(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x63B0060", Offset = "0x63AEC60", VA = "0x1863B0060")]
	private Vector3 KLMACOIEGDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x63AF5A0", Offset = "0x63AE1A0", VA = "0x1863AF5A0")]
	private void HBHCEEOLJBP(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x63AE5C0", Offset = "0x63AD1C0", VA = "0x1863AE5C0")]
	private void DGCMNFFBELI(Vector3 OAAOAKNCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x63AF540", Offset = "0x63AE140", VA = "0x1863AF540")]
	private void GNCOKCGFFHI(Vector3 NHOJBJMMDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x63B0D90", Offset = "0x63AF990", VA = "0x1863B0D90")]
	private void PIAPIOOPHNO(string OFFCKGHBNFG, Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63AFF50", Offset = "0x63AEB50", VA = "0x1863AFF50")]
	private void JJDMOCOPHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class FBINNMIICHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly KKMILDLPGMG NGEPMJPLOFK;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected DMOPNDHELBN NGNBILGAAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5514F00", Offset = "0x5513B00", VA = "0x185514F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5514F40", Offset = "0x5513B40", VA = "0x185514F40")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x63915E0", Offset = "0x63901E0", VA = "0x1863915E0")]
	public FBINNMIICHO(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x639E220", Offset = "0x639CE20", VA = "0x18639E220")]
	protected CLILEGLKHIM BGGEHPDAEHP(HIMFIAMFCKI OEBOJHNMNBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IPBGGMGCNHI : POEPMBPGKKN
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63A5850", Offset = "0x63A4450", VA = "0x1863A5850", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x63A4DF0", Offset = "0x63A39F0", VA = "0x1863A4DF0", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x63A5660", Offset = "0x63A4260", VA = "0x1863A5660", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A90", Offset = "0x63A4690", VA = "0x1863A5A90", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A5920", Offset = "0x63A4520", VA = "0x1863A5920", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A5580", Offset = "0x63A4180", VA = "0x1863A5580", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A5B70", Offset = "0x63A4770", VA = "0x1863A5B70", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x63A54A0", Offset = "0x63A40A0", VA = "0x1863A54A0", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x63A5280", Offset = "0x63A3E80", VA = "0x1863A5280", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x63A51A0", Offset = "0x63A3DA0", VA = "0x1863A51A0", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x63A5750", Offset = "0x63A4350", VA = "0x1863A5750")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A4CF0", Offset = "0x63A38F0", VA = "0x1863A4CF0")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x63A5360", Offset = "0x63A3F60", VA = "0x1863A5360")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A58B0", Offset = "0x63A44B0", VA = "0x1863A58B0")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x63A4ED0", Offset = "0x63A3AD0", VA = "0x1863A4ED0")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A5070", Offset = "0x63A3C70", VA = "0x1863A5070", Slot = "19")]
	public CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ, HBFIOLAIDGN CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public IPBGGMGCNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A5750", Offset = "0x63A4350", VA = "0x1863A5750", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x63A4CF0", Offset = "0x63A38F0", VA = "0x1863A4CF0", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x63A5360", Offset = "0x63A3F60", VA = "0x1863A5360", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A58B0", Offset = "0x63A44B0", VA = "0x1863A58B0", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x63A5740", Offset = "0x63A4340", VA = "0x1863A5740", Slot = "18")]
	private OFECNLJJPMK IIMOEOBKAAF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class JGMCPGPGBLB : IReadOnlyList<CLILEGLKHIM>, IEnumerable<CLILEGLKHIM>, IEnumerable, IReadOnlyCollection<CLILEGLKHIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly DMOPNDHELBN KBPCHNGOIDL;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x63A5EB0", Offset = "0x63A4AB0", VA = "0x1863A5EB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CLILEGLKHIM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x63A5C50", Offset = "0x63A4850", VA = "0x1863A5C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x35C9970", Offset = "0x35C8570", VA = "0x1835C9970")]
	public JGMCPGPGBLB(HIMFIAMFCKI OEBOJHNMNBH, DMOPNDHELBN KBPCHNGOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x63A5DA0", Offset = "0x63A49A0", VA = "0x1863A5DA0", Slot = "6")]
	public IEnumerator<CLILEGLKHIM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63A5DA0", Offset = "0x63A49A0", VA = "0x1863A5DA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63A5C50", Offset = "0x63A4850", VA = "0x1863A5C50")]
	[CompilerGenerated]
	private CLILEGLKHIM DBMEDODDNLG(int JBCJBAEMMMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GKFKBGDODHH(typeof(POEPMBPGKKN), new string[] { })]
public class IFMJMANNADF : POEPMBPGKKN, HKECKBDIOOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly POEPMBPGKKN OCPFCFPGNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly POEPMBPGKKN IBDHMFKPEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private PDKMOJIAHEM BIJHKBKHNBN;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private POEPMBPGKKN HBKJOMDOGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x63A3600", Offset = "0x63A2200", VA = "0x1863A3600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x63A3C80", Offset = "0x63A2880", VA = "0x1863A3C80", Slot = "20")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x63A3CD0", Offset = "0x63A28D0", VA = "0x1863A3CD0", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x63A3560", Offset = "0x63A2160", VA = "0x1863A3560", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x63A3B30", Offset = "0x63A2730", VA = "0x1863A3B30", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x63A3EC0", Offset = "0x63A2AC0", VA = "0x1863A3EC0", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x63A3E20", Offset = "0x63A2A20", VA = "0x1863A3E20", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x63A3A90", Offset = "0x63A2690", VA = "0x1863A3A90", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x63A3F60", Offset = "0x63A2B60", VA = "0x1863A3F60", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x63A39F0", Offset = "0x63A25F0", VA = "0x1863A39F0", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x63A38A0", Offset = "0x63A24A0", VA = "0x1863A38A0", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x63A3800", Offset = "0x63A2400", VA = "0x1863A3800", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x63A3BD0", Offset = "0x63A27D0", VA = "0x1863A3BD0")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x63A34B0", Offset = "0x63A20B0", VA = "0x1863A34B0")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x63A3940", Offset = "0x63A2540", VA = "0x1863A3940")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63A3D70", Offset = "0x63A2970", VA = "0x1863A3D70")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x63A3660", Offset = "0x63A2260", VA = "0x1863A3660")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x63A3710", Offset = "0x63A2310", VA = "0x1863A3710", Slot = "19")]
	public CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ, HBFIOLAIDGN CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x63A4000", Offset = "0x63A2C00", VA = "0x1863A4000")]
	public IFMJMANNADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x63A3BD0", Offset = "0x63A27D0", VA = "0x1863A3BD0", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x63A34B0", Offset = "0x63A20B0", VA = "0x1863A34B0", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x63A3940", Offset = "0x63A2540", VA = "0x1863A3940", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x63A3D70", Offset = "0x63A2970", VA = "0x1863A3D70", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x63A3660", Offset = "0x63A2260", VA = "0x1863A3660", Slot = "18")]
	private OFECNLJJPMK IIMOEOBKAAF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class KCCDBOHNPOA : CLILEGLKHIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KCCDBOHNPOA IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx CAHFGEEGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject FIJMIMBILAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x773440", Offset = "0x772040", VA = "0x180773440", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6B0", Offset = "0x7DD2B0", VA = "0x1807DE6B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xD226B0", Offset = "0xD212B0", VA = "0x180D226B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B49C0", Offset = "0x9B35C0", VA = "0x1809B49C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x871B10", Offset = "0x870710", VA = "0x180871B10", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD2890", Offset = "0x1AD1490", VA = "0x181AD2890", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3690FA0", Offset = "0x368FBA0", VA = "0x183690FA0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x63A6FE0", Offset = "0x63A5BE0", VA = "0x1863A6FE0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A7020", Offset = "0x63A5C20", VA = "0x1863A7020", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x35AEA60", Offset = "0x35AD660", VA = "0x1835AEA60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19FB230", Offset = "0x19F9E30", VA = "0x1819FB230", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool LGHEANPHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8F1ED0", Offset = "0x8F0AD0", VA = "0x1808F1ED0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MHEDDKGKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x17172D0", Offset = "0x1715ED0", VA = "0x1817172D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5C88010", Offset = "0x5C86C10", VA = "0x185C88010", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x35A9890", Offset = "0x35A8490", VA = "0x1835A9890", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x942620", Offset = "0x941220", VA = "0x180942620", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x63A7030", Offset = "0x63A5C30", VA = "0x1863A7030", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x542EB60", Offset = "0x542D760", VA = "0x18542EB60", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4190", Offset = "0x7C2D90", VA = "0x1807C4190", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "48")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1186080", Offset = "0x1184C80", VA = "0x181186080", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform JMLEHOPCKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8C3150", Offset = "0x8C1D50", VA = "0x1808C3150", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 BDHADAPDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float IOPDOGALHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float BLIGPHJJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7C58C0", Offset = "0x7C44C0", VA = "0x1807C58C0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion EEHOPJHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x94E940", Offset = "0x94D540", VA = "0x18094E940", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x94E940", Offset = "0x94D540", VA = "0x18094E940", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MIEPMENDILL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x87FDB0", Offset = "0x87E9B0", VA = "0x18087FDB0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event OGOEIPLNHKB BGNPBFCMPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event OGOEIPLNHKB DKPFAAIGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event OGOEIPLNHKB MJEONDGBFND
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "41")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "71")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "72")]
	public void HDGHMIOPPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "73")]
	public void OMDBKBLHJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "74")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "81")]
	public void GMIJDPBCEJN(CLILEGLKHIM GCPEEAODAIB, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "84")]
	public void DBFDEEPEAND(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "85")]
	public void BJIBLOJHNCI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "86")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "87")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "88")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "89")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "90")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "91")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "92")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "93")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "94")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "95")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "96")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "97")]
	public Vector3 CBABHGJJPKF(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xADFF70", Offset = "0xADEB70", VA = "0x180ADFF70", Slot = "98")]
	public Vector3 GDJCEJCHEDO(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "99")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "100")]
	public void GDHCGPOBHCJ(CLILEGLKHIM PHEEDLMPGKK, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "101")]
	public void FEMKOCLIAPI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "104")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "105")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "106")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "109")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "110")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "115")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "116")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "117")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "118")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "121")]
	public void PFAPPCDBFIE(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "122")]
	public void OFMMOLCGMJH(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "123")]
	public bool HECEPIIFOCH(float MFAAODEGFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "124")]
	public void ICMNCHDLLDM(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "125")]
	public void EGDBONAKCBF(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "126")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "127")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "128")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "129")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "130")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "131")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x63A7000", Offset = "0x63A5C00", VA = "0x1863A7000", Slot = "132")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "133")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KCCDBOHNPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class KKMILDLPGMG : DGLLDCMCBOK, JNJNNIGHFML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal HIMFIAMFCKI OEBOJHNMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal DMOPNDHELBN KEKLOKJLKDK;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6398CC0", Offset = "0x63978C0", VA = "0x186398CC0")]
	public KKMILDLPGMG(GameObject LCHNDEILNAI, RigidbodyEx JABJLOBNFKI, HBFIOLAIDGN CEICFMOFGAN, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x63A7840", Offset = "0x63A6440", VA = "0x1863A7840", Slot = "135")]
	protected override void NBHADOFBBJF(HBFIOLAIDGN CEICFMOFGAN, AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "141")]
	protected override IDisposable DBHLFGNEEOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x63A73C0", Offset = "0x63A5FC0", VA = "0x1863A73C0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63A7AB0", Offset = "0x63A66B0", VA = "0x1863A7AB0", Slot = "142")]
	public void ODONBGLIOKM(JPJFGPKMKAE MLMDDEIDFHL, JPJFGPKMKAE CHGDNKMNMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63A70D0", Offset = "0x63A5CD0", VA = "0x1863A70D0", Slot = "143")]
	public void AFLLOCINJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63A7780", Offset = "0x63A6380", VA = "0x1863A7780", Slot = "144")]
	public void KJHDMLMEGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63A7530", Offset = "0x63A6130", VA = "0x1863A7530", Slot = "145")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x63A75F0", Offset = "0x63A61F0", VA = "0x1863A75F0", Slot = "146")]
	public bool ICICGGFALMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x63A7590", Offset = "0x63A6190", VA = "0x1863A7590", Slot = "147")]
	public void GJMMAJFPCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "140")]
	protected override void JHMDCGKOPAI(RigidbodyEx IKFHEHLCJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x63A7190", Offset = "0x63A5D90", VA = "0x1863A7190")]
	private void CGDIPNNNOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class MPKCNCEFPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x63B1340", Offset = "0x63AFF40", VA = "0x1863B1340")]
	public static DGLLDCMCBOK GEDGMHLPLOP(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CLBIGKELHEA : EEIHPONFIOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDBFHNLJBCE(CLILEGLKHIM NGEPMJPLOFK);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCPPHKCNPIG(CLILEGLKHIM NGEPMJPLOFK);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLHLDPBPJBG(CLILEGLKHIM PNONAPDCOFP);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJHJCLDHBJN(CLILEGLKHIM PNONAPDCOFP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HACHOGBGJIF : PIPBDGDHDEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	NMHMFCNGCHA<CLILEGLKHIM> MHBFIKOELJE
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	CLILEGLKHIM HOPEHPMKHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OKPLCNKFBKG : KMICGGOIAGK
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LADLLHGCBIO(Rigidbody JMIIEAMEOBN);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NBLIIIBLHFM : KICNEDMPOBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView AINHMAJOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class OOGJPANDNBD : KGCLDJCOPKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode INGGHCFOCCH;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x63B5010", Offset = "0x63B3C10", VA = "0x1863B5010", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x63B53B0", Offset = "0x63B3FB0", VA = "0x1863B53B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2020", VA = "0x1863A3420")]
	public OOGJPANDNBD(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63B54A0", Offset = "0x63B40A0", VA = "0x1863B54A0", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x63B5420", Offset = "0x63B4020", VA = "0x1863B5420", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63B55B0", Offset = "0x63B41B0", VA = "0x1863B55B0", Slot = "7")]
	public void PDLKPLFJPBP(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x63B53A0", Offset = "0x63B3FA0", VA = "0x1863B53A0", Slot = "8")]
	public void JNIJEEAEHLJ(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x63B5240", Offset = "0x63B3E40", VA = "0x1863B5240", Slot = "10")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x63B5120", Offset = "0x63B3D20", VA = "0x1863B5120")]
	private void FDINCMNMGKM(bool IGOALBDIPEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class NPLKDADEHNN : BENFKCACMDO, IDisposable, OBKCDKHLKCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private AKKMOBBIBLF DCNOPJJAFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private INIJIIICIKE NHHEEAEOOFP;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x63B4A50", Offset = "0x63B3650", VA = "0x1863B4A50", Slot = "6")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x63B4980", Offset = "0x63B3580", VA = "0x1863B4980", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform HPNIBGPOPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x63B4EA0", Offset = "0x63B3AA0", VA = "0x1863B4EA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x63B47D0", Offset = "0x63B33D0", VA = "0x1863B47D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x63B4880", Offset = "0x63B3480", VA = "0x1863B4880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x63B4EC0", Offset = "0x63B3AC0", VA = "0x1863B4EC0")]
	public NPLKDADEHNN(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x63B4BA0", Offset = "0x63B37A0", VA = "0x1863B4BA0", Slot = "8")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x63B4930", Offset = "0x63B3530", VA = "0x1863B4930", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B6B770", Offset = "0x1B6A370", VA = "0x181B6B770", Slot = "11")]
	private void OGJICLNDNON(HHMPBKNCJLA NLGHKNJEOOP, HHMPBKNCJLA BOKAPIHJLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "12")]
	private void GALBGIPHJGM(bool EBLHCGOJIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class IDMCLNOIOFB : AHLABJLGKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6399180", Offset = "0x6397D80", VA = "0x186399180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x63A33D0", Offset = "0x63A1FD0", VA = "0x1863A33D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6390EB0", Offset = "0x638FAB0", VA = "0x186390EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x63A3210", Offset = "0x63A1E10", VA = "0x1863A3210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2020", VA = "0x1863A3420")]
	public IDMCLNOIOFB(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x63A30B0", Offset = "0x63A1CB0", VA = "0x1863A30B0", Slot = "4")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x63A2710", Offset = "0x63A1310", VA = "0x1863A2710")]
	private void BHCOCEGHJLN(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63A2BD0", Offset = "0x63A17D0", VA = "0x1863A2BD0", Slot = "5")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63A3270", Offset = "0x63A1E70", VA = "0x1863A3270", Slot = "6")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63A2970", Offset = "0x63A1570", VA = "0x1863A2970")]
	private void CEGDEFNIAEI(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x63A2E50", Offset = "0x63A1A50", VA = "0x1863A2E50", Slot = "7")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class PBKGHFAFNMK : GFAEJIJOIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool CICAACOEPDI;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x63B55F0", Offset = "0x63B41F0", VA = "0x1863B55F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2020", VA = "0x1863A3420")]
	public PBKGHFAFNMK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x63B55C0", Offset = "0x63B41C0", VA = "0x1863B55C0", Slot = "6")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6392050", Offset = "0x6390C50", VA = "0x186392050", Slot = "7")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LBPBOKOPBIK : CLBIGKELHEA, EEIHPONFIOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly CLILEGLKHIM NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<CLILEGLKHIM> JDNGEHLEIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private CLILEGLKHIM NMHGPHBIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private CLILEGLKHIM HHNAEDAPOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform BFIAKHJINOB;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform AEEFBILMNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x63A84F0", Offset = "0x63A70F0", VA = "0x1863A84F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x63A8FE0", Offset = "0x63A7BE0", VA = "0x1863A8FE0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event OGOEIPLNHKB BGNPBFCMPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x63A82E0", Offset = "0x63A6EE0", VA = "0x1863A82E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x63A9090", Offset = "0x63A7C90", VA = "0x1863A9090", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x63A8FF0", Offset = "0x63A7BF0", VA = "0x1863A8FF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x63A8DE0", Offset = "0x63A79E0", VA = "0x1863A8DE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x63A9130", Offset = "0x63A7D30", VA = "0x1863A9130", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63A9900", Offset = "0x63A8500", VA = "0x1863A9900", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action OLFMHBNNIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x63A91D0", Offset = "0x63A7DD0", VA = "0x1863A91D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x63A7CD0", Offset = "0x63A68D0", VA = "0x1863A7CD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action NILEMMLPJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63A8C10", Offset = "0x63A7810", VA = "0x1863A8C10", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x63A8550", Offset = "0x63A7150", VA = "0x1863A8550", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<CLILEGLKHIM> AGBNPPLPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63A95E0", Offset = "0x63A81E0", VA = "0x1863A95E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63A7B80", Offset = "0x63A6780", VA = "0x1863A7B80", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<CLILEGLKHIM> LEGHKNLKFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x63A8050", Offset = "0x63A6C50", VA = "0x1863A8050", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A7E10", Offset = "0x63A6A10", VA = "0x1863A7E10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HGNEPMKMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D70", Offset = "0x63A6970", VA = "0x1863A7D70", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A7FB0", Offset = "0x63A6BB0", VA = "0x1863A7FB0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<CLILEGLKHIM> BIKBACEBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A8F30", Offset = "0x63A7B30", VA = "0x1863A8F30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A8E80", Offset = "0x63A7A80", VA = "0x1863A8E80", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A99A0", Offset = "0x63A85A0", VA = "0x1863A99A0")]
	public LBPBOKOPBIK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A8100", Offset = "0x63A6D00", VA = "0x1863A8100", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A85F0", Offset = "0x63A71F0", VA = "0x1863A85F0", Slot = "30")]
	public void GMIJDPBCEJN(CLILEGLKHIM OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63A9690", Offset = "0x63A8290", VA = "0x1863A9690", Slot = "6")]
	public void NLHLDPBPJBG(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A9360", Offset = "0x63A7F60", VA = "0x1863A9360", Slot = "7")]
	public void MJHJCLDHBJN(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63A7EC0", Offset = "0x63A6AC0", VA = "0x1863A7EC0", Slot = "4")]
	public void DDBFHNLJBCE(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A7C30", Offset = "0x63A6830", VA = "0x1863A7C30", Slot = "5")]
	public void BCPPHKCNPIG(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A8B70", Offset = "0x63A7770", VA = "0x1863A8B70")]
	private void HBMJDCNFGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A84B0", Offset = "0x63A70B0", VA = "0x1863A84B0")]
	private void FLMOENJIEAN(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63A81A0", Offset = "0x63A6DA0", VA = "0x1863A81A0")]
	private void FCELDJCHPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CB0", Offset = "0x63A78B0", VA = "0x1863A8CB0")]
	private void IFPNIADGDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A8380", Offset = "0x63A6F80", VA = "0x1863A8380")]
	private void FLIDNPIKABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x63A9270", Offset = "0x63A7E70", VA = "0x1863A9270")]
	[CompilerGenerated]
	private object MDFPJMIFGMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class MKFMJOBECJP
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x63AD6F0", Offset = "0x63AC2F0", VA = "0x1863AD6F0")]
	public static CLBIGKELHEA AHHFEGHKCLN(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class CPNFMAONJAK : HACHOGBGJIF, PIPBDGDHDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NMHMFCNGCHA<CLILEGLKHIM> EMEHNIDJBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool FEHEGCIHOCG;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public NMHMFCNGCHA<CLILEGLKHIM> MHBFIKOELJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6392910", Offset = "0x6391510", VA = "0x186392910", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6392A90", Offset = "0x6391690", VA = "0x186392A90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x63929A0", Offset = "0x63915A0", VA = "0x1863929A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public CLILEGLKHIM HOPEHPMKHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6392C50", Offset = "0x6391850", VA = "0x186392C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6392D00", Offset = "0x6391900", VA = "0x186392D00")]
	public CPNFMAONJAK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6392510", Offset = "0x6391110", VA = "0x186392510", Slot = "8")]
	public void IOBGBBEPPKF(CLILEGLKHIM HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6392940", Offset = "0x6391540", VA = "0x186392940", Slot = "9")]
	public void LHBNKJHAMAA(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6392580", Offset = "0x6391180", VA = "0x186392580")]
	private Vector3 KJBIIKFNEKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6392180", Offset = "0x6390D80", VA = "0x186392180")]
	private void GAEGEAOPFIB(CLILEGLKHIM BBHJIJMHBOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OBNIDNOBACA
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x63B4F50", Offset = "0x63B3B50", VA = "0x1863B4F50")]
	public static HACHOGBGJIF MLHMAMCDIEJ(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class MGMHCJNLJEP : OKPLCNKFBKG, KMICGGOIAGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 JBJNMKNAMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 EOKFFGBPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float EEDDDIIPBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float KAHEGMOFBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 FCPCCIGNOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? JJIOHFBKFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? BBEANGPPEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool ANKENDKMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool JJHJCHHMKPA;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1029F80", Offset = "0x1028B80", VA = "0x181029F80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x63AB870", Offset = "0x63AA470", VA = "0x1863AB870", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x63AD0F0", Offset = "0x63ABCF0", VA = "0x1863AD0F0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FA930", Offset = "0x10F9530", VA = "0x1810FA930", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x63AADE0", Offset = "0x63A99E0", VA = "0x1863AADE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB72EE0", Offset = "0xB71AE0", VA = "0x180B72EE0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x63AB920", Offset = "0x63AA520", VA = "0x1863AB920", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x63AB560", Offset = "0x63AA160", VA = "0x1863AB560", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x63AC9F0", Offset = "0x63AB5F0", VA = "0x1863AC9F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x63A6560", Offset = "0x63A5160", VA = "0x1863A6560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event OGOEIPLNHKB EOBAIGEGIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x63AD1F0", Offset = "0x63ABDF0", VA = "0x1863AD1F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x63AAD40", Offset = "0x63A9940", VA = "0x1863AAD40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x63AD600", Offset = "0x63AC200", VA = "0x1863AD600")]
	public MGMHCJNLJEP(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63AB3B0", Offset = "0x63A9FB0", VA = "0x1863AB3B0", Slot = "17")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x63AD520", Offset = "0x63AC120", VA = "0x1863AD520", Slot = "16")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x63AD010", Offset = "0x63ABC10", VA = "0x1863AD010", Slot = "19")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x63AD290", Offset = "0x63ABE90", VA = "0x1863AD290", Slot = "20")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x63AABD0", Offset = "0x63A97D0", VA = "0x1863AABD0", Slot = "18")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x63ACB70", Offset = "0x63AB770", VA = "0x1863ACB70", Slot = "21")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63AB870", Offset = "0x63AA470", VA = "0x1863AB870")]
	private void KNJOGAIIIAI(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x63AAEF0", Offset = "0x63A9AF0", VA = "0x1863AAEF0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DIKNILAGHJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63AADE0", Offset = "0x63A99E0", VA = "0x1863AADE0")]
	private void OBFHNNKPFEI(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x63AB920", Offset = "0x63AA520", VA = "0x1863AB920")]
	private void PJLBHDMMAEJ(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63AAFE0", Offset = "0x63A9BE0", VA = "0x1863AAFE0")]
	private Vector3 EHFEJJCOOKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63AB180", Offset = "0x63A9D80", VA = "0x1863AB180", Slot = "15")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63AB6F0", Offset = "0x63AA2F0", VA = "0x1863AB6F0")]
	private Quaternion IHGJEPAKGOG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x63AB9D0", Offset = "0x63AA5D0", VA = "0x1863AB9D0")]
	public void LADLLHGCBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63ABAA0", Offset = "0x63AA6A0", VA = "0x1863ABAA0", Slot = "4")]
	public (float, Vector3) LADLLHGCBIO(Rigidbody JMIIEAMEOBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class NJHNDHGOPCB
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B3F60", Offset = "0x63B2B60", VA = "0x1863B3F60")]
	public static OKPLCNKFBKG HFGNLCEIHGC(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GFBCKPCIFIJ : NNGGKLPDBGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FBHLHHEDNEC JKCEBAEMBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NLLCDEONLOL NJHFANHKNGN;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool LPBCPLHBEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCA8220", Offset = "0xCA6E20", VA = "0x180CA8220", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public NLLCDEONLOL HJMOMBBLICG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30", Slot = "11")]
		get
		{
			return default(NLLCDEONLOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x639FB00", Offset = "0x639E700", VA = "0x18639FB00")]
	public GFBCKPCIFIJ(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x639FA00", Offset = "0x639E600", VA = "0x18639FA00", Slot = "4")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x639F630", Offset = "0x639E230", VA = "0x18639F630")]
	private bool FHDHEKEGDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x639FAD0", Offset = "0x639E6D0", VA = "0x18639FAD0", Slot = "5")]
	public void OACOBDCKHGB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x639F600", Offset = "0x639E200", VA = "0x18639F600", Slot = "6")]
	public void FEDLOEEFJBP(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x639F840", Offset = "0x639E440", VA = "0x18639F840", Slot = "9")]
	public void JBLKMCFBKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x639F4E0", Offset = "0x639E0E0", VA = "0x18639F4E0")]
	private void EILCIKCCDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x639F6D0", Offset = "0x639E2D0", VA = "0x18639F6D0")]
	private void GMIJGIHDHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x639F980", Offset = "0x639E580", VA = "0x18639F980", Slot = "8")]
	public void LEBKMNKBKFA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x639F9C0", Offset = "0x639E5C0", VA = "0x18639F9C0", Slot = "7")]
	public void MHEJHHEDMIC(CLILEGLKHIM NGEPMJPLOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NKHOCLONDNC : LBEMOOJEDNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FBHLHHEDNEC CKIJBLMADJD;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x63B43B0", Offset = "0x63B2FB0", VA = "0x1863B43B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x63B4260", Offset = "0x63B2E60", VA = "0x1863B4260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x63B41B0", Offset = "0x63B2DB0", VA = "0x1863B41B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x63B44A0", Offset = "0x63B30A0", VA = "0x1863B44A0")]
	public NKHOCLONDNC(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x63B4140", Offset = "0x63B2D40", VA = "0x1863B4140", Slot = "11")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x63B4250", Offset = "0x63B2E50", VA = "0x1863B4250", Slot = "8")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x63B4130", Offset = "0x63B2D30", VA = "0x1863B4130", Slot = "9")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x63B4020", Offset = "0x63B2C20", VA = "0x1863B4020", Slot = "10")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x63B4460", Offset = "0x63B3060", VA = "0x1863B4460", Slot = "6")]
	public void PKDOINHLNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x63B4300", Offset = "0x63B2F00", VA = "0x1863B4300", Slot = "12")]
	public void MMMPLHKBEGG(Rigidbody IDJLKFJMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x63B4380", Offset = "0x63B2F80", VA = "0x1863B4380", Slot = "13")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class IIBAEMHMKKN : NBLIIIBLHFM, KICNEDMPOBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView BFJDFNLOLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool JFFNPJMJOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView AINHMAJOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x639DBB0", Offset = "0x639C7B0", VA = "0x18639DBB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x853290", Offset = "0x851E90", VA = "0x180853290", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x63A4BA0", Offset = "0x63A37A0", VA = "0x1863A4BA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x63A41B0", Offset = "0x63A2DB0", VA = "0x1863A41B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x63A4C40", Offset = "0x63A3840", VA = "0x1863A4C40")]
	public IIBAEMHMKKN(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x63A4690", Offset = "0x63A3290", VA = "0x1863A4690", Slot = "9")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x63A40B0", Offset = "0x63A2CB0", VA = "0x1863A40B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x63A4A30", Offset = "0x63A3630", VA = "0x1863A4A30", Slot = "10")]
	public void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x63A43C0", Offset = "0x63A2FC0", VA = "0x1863A43C0", Slot = "11")]
	public void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x63A4250", Offset = "0x63A2E50", VA = "0x1863A4250")]
	private void FCODMEHCEOM(PhotonView KFHLGPCEJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x63A4530", Offset = "0x63A3130", VA = "0x1863A4530")]
	private void KELGPNGFFHP(RigidbodyEx BDNPBMBDKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x63A47C0", Offset = "0x63A33C0", VA = "0x1863A47C0")]
	private void NLEGMHOHKFJ(PhotonView KJFGFKCMNHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class CLOOJCHNHJA
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x63920C0", Offset = "0x6390CC0", VA = "0x1863920C0")]
	public static NBLIIIBLHFM ADNKGJGMIMI(this CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class NMHGPKFDKNF : OFECNLJJPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints IDMEOBBKOGF;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAB9090", Offset = "0xAB7C90", VA = "0x180AB9090", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0B10", Offset = "0x3CEF710", VA = "0x183CF0B10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool OECAEIFCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC700", Offset = "0x1ABB300", VA = "0x181ABC700", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0B00", Offset = "0x3CEF700", VA = "0x183CF0B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x63B4590", Offset = "0x63B3190", VA = "0x1863B4590", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x63B4720", Offset = "0x63B3320", VA = "0x1863B4720")]
	public NMHGPKFDKNF(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x63B46C0", Offset = "0x63B32C0", VA = "0x1863B46C0", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x63B46F0", Offset = "0x63B32F0", VA = "0x1863B46F0", Slot = "10")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class GHJACJJMOHP : CHDOPAMEKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly CLILEGLKHIM NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float PNEOPFBAHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float NFNLCFMFAPC;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8720A0", Offset = "0x870CA0", VA = "0x1808720A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x639FE90", Offset = "0x639EA90", VA = "0x18639FE90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9141B0", Offset = "0x912DB0", VA = "0x1809141B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x639FCD0", Offset = "0x639E8D0", VA = "0x18639FCD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x639FF60", Offset = "0x639EB60", VA = "0x18639FF60")]
	public GHJACJJMOHP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x639FDA0", Offset = "0x639E9A0", VA = "0x18639FDA0", Slot = "8")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x639FDF0", Offset = "0x639E9F0", VA = "0x18639FDF0", Slot = "9")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class JHJIEMOKHLO : MEKLFNOFPOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool ECLLFBICFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool HIBLJKDFEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int IDGNGFDGGIG;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x63A6560", Offset = "0x63A5160", VA = "0x1863A6560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x63A66B0", Offset = "0x63A52B0", VA = "0x1863A66B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x63A6820", Offset = "0x63A5420", VA = "0x1863A6820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x63A69B0", Offset = "0x63A55B0", VA = "0x1863A69B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x63A62E0", Offset = "0x63A4EE0", VA = "0x1863A62E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x63A6240", Offset = "0x63A4E40", VA = "0x1863A6240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x63A6A10", Offset = "0x63A5610", VA = "0x1863A6A10")]
	public JHJIEMOKHLO(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x63A6920", Offset = "0x63A5520", VA = "0x1863A6920", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x63A66A0", Offset = "0x63A52A0", VA = "0x1863A66A0", Slot = "8")]
	public void HJHIJKPFBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x63A66D0", Offset = "0x63A52D0", VA = "0x1863A66D0", Slot = "7")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x63A6880", Offset = "0x63A5480", VA = "0x1863A6880", Slot = "9")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x63A6600", Offset = "0x63A5200", VA = "0x1863A6600", Slot = "11")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x63A65B0", Offset = "0x63A51B0", VA = "0x1863A65B0", Slot = "12")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x63A5F00", Offset = "0x63A4B00", VA = "0x1863A5F00", Slot = "10")]
	public void BLGDEGHEGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x63A6380", Offset = "0x63A4F80", VA = "0x1863A6380")]
	private bool DOKACNHGHPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x63A60B0", Offset = "0x63A4CB0", VA = "0x1863A60B0")]
	private void CBILABAMGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HEBIJJGMIBM : IHCLONJPHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly FBHLHHEDNEC LIJBMBLCDBD;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6390EB0", Offset = "0x638FAB0", VA = "0x186390EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool DKDEMEEKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCA8220", Offset = "0xCA6E20", VA = "0x180CA8220", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x63A1560", Offset = "0x63A0160", VA = "0x1863A1560")]
	public HEBIJJGMIBM(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1490", Offset = "0x63A0090", VA = "0x1863A1490", Slot = "5")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x63A1530", Offset = "0x63A0130", VA = "0x1863A1530", Slot = "7")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x63A1130", Offset = "0x639FD30", VA = "0x1863A1130", Slot = "8")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x63A1160", Offset = "0x639FD60", VA = "0x1863A1160", Slot = "9")]
	public void NEAHDEDOACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x63A05D0", Offset = "0x639F1D0", VA = "0x1863A05D0", Slot = "11")]
	public void BELMCIBIMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x63A07C0", Offset = "0x639F3C0", VA = "0x1863A07C0", Slot = "12")]
	public void CIGBACBOEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x63A0940", Offset = "0x639F540", VA = "0x1863A0940", Slot = "10")]
	public void DOMFCHGAJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x63A0DD0", Offset = "0x639F9D0", VA = "0x1863A0DD0")]
	private void EHAAIMGGOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x63A0F80", Offset = "0x639FB80", VA = "0x1863A0F80")]
	private void INPAMBOHKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class EJCOJPJMEEK : KCMLKLODAPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly DGLLDCMCBOK NGEPMJPLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly FBHLHHEDNEC JJEMPDHIOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float CMPFMDFNDAD;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x63BD830", Offset = "0x63BC430", VA = "0x1863BD830", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x63BDAC0", Offset = "0x63BC6C0", VA = "0x1863BDAC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x63BDB80", Offset = "0x63BC780", VA = "0x1863BDB80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x63BAEC0", Offset = "0x63B9AC0", VA = "0x1863BAEC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x63BAFD0", Offset = "0x63B9BD0", VA = "0x1863BAFD0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x63BC9B0", Offset = "0x63BB5B0", VA = "0x1863BC9B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63BCF10", Offset = "0x63BBB10", VA = "0x1863BCF10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63BD590", Offset = "0x63BC190", VA = "0x1863BD590", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7C7250", Offset = "0x7C5E50", VA = "0x1807C7250", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x63BB250", Offset = "0x63B9E50", VA = "0x1863BB250", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1622530", Offset = "0x1621130", VA = "0x181622530", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private AHLABJLGKJI GJNBOIKJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1CB6740", Offset = "0x1CB5340", VA = "0x181CB6740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x63B0380", Offset = "0x63AEF80", VA = "0x1863B0380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE00", Offset = "0x63BCA00", VA = "0x1863BDE00")]
	public EJCOJPJMEEK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE10", Offset = "0x63B9A10", VA = "0x1863BAE10", Slot = "19")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x63BC2B0", Offset = "0x63BAEB0", VA = "0x1863BC2B0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x63BD5C0", Offset = "0x63BC1C0", VA = "0x1863BD5C0", Slot = "28")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xAFAFE0", Offset = "0xAF9BE0", VA = "0x180AFAFE0", Slot = "20")]
	public void FAKHMMGELAJ(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xAFBFF0", Offset = "0xAFABF0", VA = "0x180AFBFF0", Slot = "30")]
	public void CKIMBGIPJJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x63BD950", Offset = "0x63BC550", VA = "0x1863BD950", Slot = "35")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x63BC160", Offset = "0x63BAD60", VA = "0x1863BC160", Slot = "34")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE10", Offset = "0x63B9A10", VA = "0x1863BAE10", Slot = "27")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x63BD530", Offset = "0x63BC130", VA = "0x1863BD530", Slot = "25")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x63BDC70", Offset = "0x63BC870", VA = "0x1863BDC70", Slot = "24")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x63BD690", Offset = "0x63BC290", VA = "0x1863BD690", Slot = "33")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x63BCA70", Offset = "0x63BB670", VA = "0x1863BCA70", Slot = "32")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x63BBD60", Offset = "0x63BA960", VA = "0x1863BBD60", Slot = "31")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x63BC380", Offset = "0x63BAF80", VA = "0x1863BC380", Slot = "22")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x63BBED0", Offset = "0x63BAAD0", VA = "0x1863BBED0", Slot = "21")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x63BD000", Offset = "0x63BBC00", VA = "0x1863BD000", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x63BB0F0", Offset = "0x63B9CF0", VA = "0x1863BB0F0", Slot = "29")]
	public Vector3 CBABHGJJPKF(Vector3 OAAOAKNCDMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x63BDCD0", Offset = "0x63BC8D0", VA = "0x1863BDCD0", Slot = "26")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x63BB250", Offset = "0x63B9E50", VA = "0x1863BB250")]
	private void CMBPFKHCHEE(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x63BB760", Offset = "0x63BA360", VA = "0x1863BB760")]
	private void DCBNDJBMBCH(Vector3 OLNHEMAINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x63BAEF0", Offset = "0x63B9AF0", VA = "0x1863BAEF0")]
	private Vector3 BBCFODFLNIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x63BB300", Offset = "0x63B9F00", VA = "0x1863BB300")]
	private void CMMNNGGKIMB(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x63BD450", Offset = "0x63BC050", VA = "0x1863BD450")]
	private Vector3 KLMACOIEGDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x63BCAD0", Offset = "0x63BB6D0", VA = "0x1863BCAD0")]
	private void HBHCEEOLJBP(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x63BB8D0", Offset = "0x63BA4D0", VA = "0x1863BB8D0")]
	private void DGCMNFFBELI(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x63BD3A0", Offset = "0x63BBFA0", VA = "0x1863BD3A0")]
	private void JJDMOCOPHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JLOFGHIKBOP : POEPMBPGKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x63BE3D0", Offset = "0x63BCFD0", VA = "0x1863BE3D0", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x63BDF10", Offset = "0x63BCB10", VA = "0x1863BDF10", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x63BE300", Offset = "0x63BCF00", VA = "0x1863BE300", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x63BE500", Offset = "0x63BD100", VA = "0x1863BE500", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x63BE4A0", Offset = "0x63BD0A0", VA = "0x1863BE4A0", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x63BE2A0", Offset = "0x63BCEA0", VA = "0x1863BE2A0", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x63BE560", Offset = "0x63BD160", VA = "0x1863BE560", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x63BE240", Offset = "0x63BCE40", VA = "0x1863BE240", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x63BE170", Offset = "0x63BCD70", VA = "0x1863BE170", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x63BE110", Offset = "0x63BCD10", VA = "0x1863BE110", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x63BE360", Offset = "0x63BCF60", VA = "0x1863BE360")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x63BDEA0", Offset = "0x63BCAA0", VA = "0x1863BDEA0")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x63BE1D0", Offset = "0x63BCDD0", VA = "0x1863BE1D0")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x63BE430", Offset = "0x63BD030", VA = "0x1863BE430")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x63BDFF0", Offset = "0x63BCBF0", VA = "0x1863BDFF0")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x63BE060", Offset = "0x63BCC60", VA = "0x1863BE060", Slot = "19")]
	public CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ, HBFIOLAIDGN CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public JLOFGHIKBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x63BE360", Offset = "0x63BCF60", VA = "0x1863BE360", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x63BDEA0", Offset = "0x63BCAA0", VA = "0x1863BDEA0", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x63BE1D0", Offset = "0x63BCDD0", VA = "0x1863BE1D0", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x63BE430", Offset = "0x63BD030", VA = "0x1863BE430", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x63BDFF0", Offset = "0x63BCBF0", VA = "0x1863BDFF0", Slot = "18")]
	private OFECNLJJPMK IIMOEOBKAAF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : ELKGCLAEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x63BE5C0", Offset = "0x63BD1C0", VA = "0x1863BE5C0", Slot = "6")]
		public sealed override void LPLJBBEMGKL(JLPOCOOPMJD FCFEFDOJHCD)
		{
		}
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
