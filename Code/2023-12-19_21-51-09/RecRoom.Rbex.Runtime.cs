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
			[Cpp2IlInjected.Address(RVA = "0x63B6650", Offset = "0x63B5250", VA = "0x1863B6650")]
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
			[Cpp2IlInjected.Address(RVA = "0x63B8460", Offset = "0x63B7060", VA = "0x1863B8460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx EGCFCBLCCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63B83C0", Offset = "0x63B6FC0", VA = "0x1863B83C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HHNAEDAPOHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63B9080", Offset = "0x63B7C80", VA = "0x1863B9080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63BA600", Offset = "0x63B9200", VA = "0x1863BA600")]
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
			[Cpp2IlInjected.Address(RVA = "0x63B8180", Offset = "0x63B6D80", VA = "0x1863B8180")]
			get
			{
				return default(LGAAKFHBOCB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9DB0", Offset = "0x63B89B0", VA = "0x1863B9DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AHJFJLOAFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63B8710", Offset = "0x63B7310", VA = "0x1863B8710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FENPGOBDPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63B82A0", Offset = "0x63B6EA0", VA = "0x1863B82A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IPLEJINKGKJ HHBPDLODGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63B8650", Offset = "0x63B7250", VA = "0x1863B8650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9F70", Offset = "0x63B8B70", VA = "0x1863B9F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FAJHLMMDDLF COCPMJDMOGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63B85F0", Offset = "0x63B71F0", VA = "0x1863B85F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63B9F00", Offset = "0x63B8B00", VA = "0x1863B9F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ABNLGNLKEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63B8540", Offset = "0x63B7140", VA = "0x1863B8540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody AFENJAMGBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63B85A0", Offset = "0x63B71A0", VA = "0x1863B85A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FFDBBKPLAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63B8300", Offset = "0x63B6F00", VA = "0x1863B8300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63B9E20", Offset = "0x63B8A20", VA = "0x1863B9E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool AHNPEAKENBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1B22540", Offset = "0x1B21140", VA = "0x181B22540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5BE7590", Offset = "0x5BE6190", VA = "0x185BE7590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KAHEGMOFBDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63B9020", Offset = "0x63B7C20", VA = "0x1863B9020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EEDDDIIPBKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63B8FC0", Offset = "0x63B7BC0", VA = "0x1863B8FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63BA590", Offset = "0x63B9190", VA = "0x1863BA590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float PNEOPFBAHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8970", Offset = "0x63B7570", VA = "0x1863B8970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA210", Offset = "0x63B8E10", VA = "0x1863BA210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NFNLCFMFAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8770", Offset = "0x63B7370", VA = "0x1863B8770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63B9FE0", Offset = "0x63B8BE0", VA = "0x1863B9FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CICAACOEPDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x63B95E0", Offset = "0x63B81E0", VA = "0x1863B95E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63BAB60", Offset = "0x63B9760", VA = "0x1863BAB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 FCPCCIGNOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63B8DA0", Offset = "0x63B79A0", VA = "0x1863B8DA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63BA360", Offset = "0x63B8F60", VA = "0x1863BA360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JHIHJBFBDFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63B9720", Offset = "0x63B8320", VA = "0x1863B9720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode GEIPIJFHKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63B88B0", Offset = "0x63B74B0", VA = "0x1863B88B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63BA130", Offset = "0x63B8D30", VA = "0x1863BA130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NENGIOPIHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63B8360", Offset = "0x63B6F60", VA = "0x1863B8360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63B9E90", Offset = "0x63B8A90", VA = "0x1863B9E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IDMEOBBKOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63B8910", Offset = "0x63B7510", VA = "0x1863B8910")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63BA1A0", Offset = "0x63B8DA0", VA = "0x1863BA1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 CJABPDGBOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63B9120", Offset = "0x63B7D20", VA = "0x1863B9120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 LENIGMOJEDP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9120", Offset = "0x63B7D20", VA = "0x1863B9120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA940", Offset = "0x63B9540", VA = "0x1863BA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float IGICPJJPDGI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8E80", Offset = "0x63B7A80", VA = "0x1863B8E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63BA440", Offset = "0x63B9040", VA = "0x1863BA440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float LDCGOENBDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9580", Offset = "0x63B8180", VA = "0x1863B9580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63BAAF0", Offset = "0x63B96F0", VA = "0x1863BAAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion FLLLGMBOOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63B9200", Offset = "0x63B7E00", VA = "0x1863B9200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63BA6C0", Offset = "0x63B92C0", VA = "0x1863BA6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LDEEDGMDHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63B94A0", Offset = "0x63B80A0", VA = "0x1863B94A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63BAA20", Offset = "0x63B9620", VA = "0x1863BAA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 MGCIOFHHFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63B92E0", Offset = "0x63B7EE0", VA = "0x1863B92E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63BA790", Offset = "0x63B9390", VA = "0x1863BA790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CPFJALGCICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63B93C0", Offset = "0x63B7FC0", VA = "0x1863B93C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63BA870", Offset = "0x63B9470", VA = "0x1863BA870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 OAAOAKNCDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63B9640", Offset = "0x63B8240", VA = "0x1863B9640")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63BABD0", Offset = "0x63B97D0", VA = "0x1863BABD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PMHHDDKKDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8EE0", Offset = "0x63B7AE0", VA = "0x1863B8EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA4B0", Offset = "0x63B90B0", VA = "0x1863BA4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NHOJBJMMDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63B87D0", Offset = "0x63B73D0", VA = "0x1863B87D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63BA050", Offset = "0x63B8C50", VA = "0x1863BA050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HAGKOPCILNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8CC0", Offset = "0x63B78C0", VA = "0x1863B8CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x63BA280", Offset = "0x63B8E80", VA = "0x1863BA280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 JJIOHFBKFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x63B8B80", Offset = "0x63B7780", VA = "0x1863B8B80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion BBEANGPPEIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63B8AA0", Offset = "0x63B76A0", VA = "0x1863B8AA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 JFFDLMFCODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63B98E0", Offset = "0x63B84E0", VA = "0x1863B98E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BOPHMNHHAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63B9800", Offset = "0x63B8400", VA = "0x1863B9800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool IGOALBDIPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63B8C60", Offset = "0x63B7860", VA = "0x1863B8C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MIEPMENDILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63B86B0", Offset = "0x63B72B0", VA = "0x1863B86B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ECEGNOKHCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63B8240", Offset = "0x63B6E40", VA = "0x1863B8240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LGHEANPHFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63B81E0", Offset = "0x63B6DE0", VA = "0x1863B81E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MHEDDKGKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63B8120", Offset = "0x63B6D20", VA = "0x1863B8120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LBGBLDABDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x63B89D0", Offset = "0x63B75D0", VA = "0x1863B89D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BKIHKFDKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC40C0", Offset = "0x4FC2CC0", VA = "0x184FC40C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OGOEIPLNHKB CGEOOFINKME
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63B8040", Offset = "0x63B6C40", VA = "0x1863B8040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x63B9CD0", Offset = "0x63B88D0", VA = "0x1863B9CD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CFPKEOMCFGB DDIMMFKBJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63B7FD0", Offset = "0x63B6BD0", VA = "0x1863B7FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63B9C60", Offset = "0x63B8860", VA = "0x1863B9C60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OGOEIPLNHKB BGNPBFCMPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63B7D30", Offset = "0x63B6930", VA = "0x1863B7D30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63B99C0", Offset = "0x63B85C0", VA = "0x1863B99C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OGOEIPLNHKB GBDEACGOBAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63B7DA0", Offset = "0x63B69A0", VA = "0x1863B7DA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63B9A30", Offset = "0x63B8630", VA = "0x1863B9A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OGOEIPLNHKB DKPFAAIGKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63B7EF0", Offset = "0x63B6AF0", VA = "0x1863B7EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x63B9B80", Offset = "0x63B8780", VA = "0x1863B9B80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E80", Offset = "0x63B6A80", VA = "0x1863B7E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9B10", Offset = "0x63B8710", VA = "0x1863B9B10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OGOEIPLNHKB KJOJFLAAIJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F60", Offset = "0x63B6B60", VA = "0x1863B7F60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63B9BF0", Offset = "0x63B87F0", VA = "0x1863B9BF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OGOEIPLNHKB DCHKOPNEBNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63B80B0", Offset = "0x63B6CB0", VA = "0x1863B80B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9D40", Offset = "0x63B8940", VA = "0x1863B9D40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event OGOEIPLNHKB MJEONDGBFND
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E10", Offset = "0x63B6A10", VA = "0x1863B7E10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63B9AA0", Offset = "0x63B86A0", VA = "0x1863B9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B61D0", Offset = "0x63B4DD0", VA = "0x1863B61D0")]
		internal void BCLIDIJCPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B7A50", Offset = "0x63B6650", VA = "0x1863B7A50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody HBHFGLOIFPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63B7720", Offset = "0x63B6320", VA = "0x1863B7720")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63B6160", Offset = "0x63B4D60", VA = "0x1863B6160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B6650", Offset = "0x63B5250", VA = "0x1863B6650")]
		private CLILEGLKHIM CMOHLIKMGLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63B6260", Offset = "0x63B4E60", VA = "0x1863B6260")]
		private void BGGKBEMAPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63B6EF0", Offset = "0x63B5AF0", VA = "0x1863B6EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63B61D0", Offset = "0x63B4DD0", VA = "0x1863B61D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63B6E90", Offset = "0x63B5A90", VA = "0x1863B6E90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63B6F50", Offset = "0x63B5B50", VA = "0x1863B6F50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63B5810", Offset = "0x63B4410", VA = "0x1863B5810")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63B6FB0", Offset = "0x63B5BB0", VA = "0x1863B6FB0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63B6880", Offset = "0x63B5480", VA = "0x1863B6880")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63B6E30", Offset = "0x63B5A30", VA = "0x1863B6E30")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63B7880", Offset = "0x63B6480", VA = "0x1863B7880")]
		public void SetParent(RigidbodyEx GCPEEAODAIB, bool LGIEADGADKO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63B72C0", Offset = "0x63B5EC0", VA = "0x1863B72C0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63B6B00", Offset = "0x63B5700", VA = "0x1863B6B00")]
		public bool IsRigidbodyAncestor(RigidbodyEx OJBFIKOJPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6BE0", Offset = "0x63B57E0", VA = "0x1863B6BE0")]
		public bool IsRigidbodyDescendant(RigidbodyEx EKOLKIEBGFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5A80", Offset = "0x63B4680", VA = "0x1863B5A80")]
		public void AddInterpolationRestriction(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63B7020", Offset = "0x63B5C20", VA = "0x1863B7020")]
		public void RemoveInterpolationRestriction(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63B65F0", Offset = "0x63B51F0", VA = "0x1863B65F0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63B5AF0", Offset = "0x63B46F0", VA = "0x1863B5AF0")]
		public void AddKinematic(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63B7090", Offset = "0x63B5C90", VA = "0x1863B7090")]
		public void RemoveKinematic(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63B7800", Offset = "0x63B6400", VA = "0x1863B7800")]
		public void SetKinematic(object KJCAGLABEME, bool IEPCDJKIMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63B7620", Offset = "0x63B6220", VA = "0x1863B7620")]
		public void SetDiscontinuousPositionAndRotation(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63B7520", Offset = "0x63B6120", VA = "0x1863B7520")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63B69F0", Offset = "0x63B55F0", VA = "0x1863B69F0")]
		public Vector3 GetConstrainedVelocity(Vector3 OAAOAKNCDMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63B68E0", Offset = "0x63B54E0", VA = "0x1863B68E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NHOJBJMMDJB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63B5990", Offset = "0x63B4590", VA = "0x1863B5990")]
		public void AddForce(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63B5880", Offset = "0x63B4480", VA = "0x1863B5880")]
		public void AddForceAtPosition(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63B5CC0", Offset = "0x63B48C0", VA = "0x1863B5CC0")]
		public void AddTorque(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B60", Offset = "0x63B4760", VA = "0x1863B5B60")]
		public void AddRelativeTorque(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63B7B20", Offset = "0x63B6720", VA = "0x1863B7B20")]
		public Vector3 WorldToLocalVelocity(Vector3 BHLFPCKJLFL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6D20", Offset = "0x63B5920", VA = "0x1863B6D20")]
		public Vector3 LocalToWorldVelocity(Vector3 PMHHDDKKDHI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63B6820", Offset = "0x63B5420", VA = "0x1863B6820")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63B67C0", Offset = "0x63B53C0", VA = "0x1863B67C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63B6760", Offset = "0x63B5360", VA = "0x1863B6760")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63B6700", Offset = "0x63B5300", VA = "0x1863B6700")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63B7420", Offset = "0x63B6020", VA = "0x1863B7420")]
		public void ResetVelocityWorldSpace(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63B7320", Offset = "0x63B5F20", VA = "0x1863B7320")]
		public void ResetVelocityLocalSpace(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63B71E0", Offset = "0x63B5DE0", VA = "0x1863B71E0")]
		public void ResetLinearVelocityLocalSpace(Vector3 KPIPFDNKPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63B79B0", Offset = "0x63B65B0", VA = "0x1863B79B0")]
		public bool SweepTest(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x63B6CC0", Offset = "0x63B58C0", VA = "0x1863B6CC0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63B7950", Offset = "0x63B6550", VA = "0x1863B7950")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x63B7AC0", Offset = "0x63B66C0", VA = "0x1863B7AC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63B5C50", Offset = "0x63B4850", VA = "0x1863B5C50")]
		public void AddShouldHaveUnityRigidbodyToken(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63B7100", Offset = "0x63B5D00", VA = "0x1863B7100")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63B5FF0", Offset = "0x63B4BF0", VA = "0x1863B5FF0")]
		public void ApplyForceVelocityChange(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63B5F50", Offset = "0x63B4B50", VA = "0x1863B5F50")]
		public void ApplyAngularVelocityChange(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63B60B0", Offset = "0x63B4CB0", VA = "0x1863B60B0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5E80", Offset = "0x63B4A80", VA = "0x1863B5E80")]
		public bool AllowedScaleChange(float MFAAODEGFEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5DB0", Offset = "0x63B49B0", VA = "0x1863B5DB0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PHEEDLMPGKK, object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x63B7170", Offset = "0x63B5D70", VA = "0x1863B7170")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63B7CC0", Offset = "0x63B68C0", VA = "0x1863B7CC0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DNNJANIHFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x639D260", Offset = "0x639BE60", VA = "0x18639D260")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A6E30", Offset = "0x63A5A30", VA = "0x1863A6E30", Slot = "8")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A6A10", Offset = "0x63A5610", VA = "0x1863A6A10", Slot = "6")]
	public HIMFIAMFCKI CNJBBJCKCMH(RigidbodyEx NGEPMJPLOFK)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A6CC0", Offset = "0x63A58C0", VA = "0x1863A6CC0")]
	private static HIMFIAMFCKI DADDFBHLIPO(RigidbodyEx NGEPMJPLOFK)
	{
		return default(HIMFIAMFCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A6D90", Offset = "0x63A5990", VA = "0x1863A6D90", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B5670", Offset = "0x63B4270", VA = "0x1863B5670")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x63B56B0", Offset = "0x63B42B0", VA = "0x1863B56B0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x63B5690", Offset = "0x63B4290", VA = "0x1863B5690")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B57C0", Offset = "0x63B43C0", VA = "0x1863B57C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LOIFNKGNCFO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A9A60", Offset = "0x63A8660", VA = "0x1863A9A60")]
	public static void KGAGDMAMAEN(this Rigidbody HBHFGLOIFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A9BF0", Offset = "0x63A87F0", VA = "0x1863A9BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x639FB70", Offset = "0x639E770", VA = "0x18639FB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6394AF0", Offset = "0x63936F0", VA = "0x186394AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6394450", Offset = "0x6393050", VA = "0x186394450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6397240", Offset = "0x6395E40", VA = "0x186397240", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63964C0", Offset = "0x63950C0", VA = "0x1863964C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<CLILEGLKHIM> GKOGNLGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63934A0", Offset = "0x63920A0", VA = "0x1863934A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63934F0", Offset = "0x63920F0", VA = "0x1863934F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6398250", Offset = "0x6396E50", VA = "0x186398250", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool AHJFJLOAFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6397850", Offset = "0x6396450", VA = "0x186397850", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6396630", Offset = "0x6395230", VA = "0x186396630", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IPLEJINKGKJ HHBPDLODGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6394EE0", Offset = "0x6393AE0", VA = "0x186394EE0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x63943F0", Offset = "0x6392FF0", VA = "0x1863943F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6398AE0", Offset = "0x63976E0", VA = "0x186398AE0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6398A80", Offset = "0x6397680", VA = "0x186398A80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6393450", Offset = "0x6392050", VA = "0x186393450", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6394840", Offset = "0x6393440", VA = "0x186394840", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x63980C0", Offset = "0x6396CC0", VA = "0x1863980C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6392E30", Offset = "0x6391A30", VA = "0x186392E30", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6395A40", Offset = "0x6394640", VA = "0x186395A40", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6396EE0", Offset = "0x6395AE0", VA = "0x186396EE0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x63978A0", Offset = "0x63964A0", VA = "0x1863978A0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6397FE0", Offset = "0x6396BE0", VA = "0x186397FE0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x63935A0", Offset = "0x63921A0", VA = "0x1863935A0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6394560", Offset = "0x6393160", VA = "0x186394560", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ECEGNOKHCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x63950F0", Offset = "0x6393CF0", VA = "0x1863950F0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LGHEANPHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6393790", Offset = "0x6392390", VA = "0x186393790", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MHEDDKGKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6393D60", Offset = "0x6392960", VA = "0x186393D60", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x63965E0", Offset = "0x63951E0", VA = "0x1863965E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 DKHKKDMHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6396B00", Offset = "0x6395700", VA = "0x186396B00", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x63986F0", Offset = "0x63972F0", VA = "0x1863986F0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 BIPPHOPLMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6396BD0", Offset = "0x63957D0", VA = "0x186396BD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6397DC0", Offset = "0x63969C0", VA = "0x186397DC0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6397390", Offset = "0x6395F90", VA = "0x186397390", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float EIIGFHEJJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6395C80", Offset = "0x6394880", VA = "0x186395C80", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6393F40", Offset = "0x6392B40", VA = "0x186393F40", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6396A50", Offset = "0x6395650", VA = "0x186396A50", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63955E0", Offset = "0x63941E0", VA = "0x1863955E0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6396CB0", Offset = "0x63958B0", VA = "0x186396CB0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float OGFLDPPFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6394B80", Offset = "0x6393780", VA = "0x186394B80", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6398B90", Offset = "0x6397790", VA = "0x186398B90", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x63981A0", Offset = "0x6396DA0", VA = "0x1863981A0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x63932E0", Offset = "0x6391EE0", VA = "0x1863932E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JIMIMKOEKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x63956C0", Offset = "0x63942C0", VA = "0x1863956C0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x63981F0", Offset = "0x6396DF0", VA = "0x1863981F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6394E30", Offset = "0x6393A30", VA = "0x186394E30", Slot = "48")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x63949C0", Offset = "0x63935C0", VA = "0x1863949C0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x63986A0", Offset = "0x63972A0", VA = "0x1863986A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform JMLEHOPCKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63952D0", Offset = "0x6393ED0", VA = "0x1863952D0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 BDHADAPDDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x63933A0", Offset = "0x6391FA0", VA = "0x1863933A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x63954C0", Offset = "0x63940C0", VA = "0x1863954C0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float IOPDOGALHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6395710", Offset = "0x6394310", VA = "0x186395710", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6395730", Offset = "0x6394330", VA = "0x186395730", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float BLIGPHJJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6394A20", Offset = "0x6393620", VA = "0x186394A20", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6396D80", Offset = "0x6395980", VA = "0x186396D80", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion EEHOPJHJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6393680", Offset = "0x6392280", VA = "0x186393680", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6394C40", Offset = "0x6393840", VA = "0x186394C40", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 DFDHGFBBAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6395280", Offset = "0x6393E80", VA = "0x186395280", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63972F0", Offset = "0x6395EF0", VA = "0x1863972F0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion GGBPFGKEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63971B0", Offset = "0x6395DB0", VA = "0x1863971B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6395D70", Offset = "0x6394970", VA = "0x186395D70", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6394790", Offset = "0x6393390", VA = "0x186394790", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6394E80", Offset = "0x6393A80", VA = "0x186394E80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool FFDBBKPLAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6393BA0", Offset = "0x63927A0", VA = "0x186393BA0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6396E80", Offset = "0x6395A80", VA = "0x186396E80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6393F90", Offset = "0x6392B90", VA = "0x186393F90", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6397290", Offset = "0x6395E90", VA = "0x186397290", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6397020", Offset = "0x6395C20", VA = "0x186397020", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MIEPMENDILL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6397C40", Offset = "0x6396840", VA = "0x186397C40", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GGEJDFJFOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6394F80", Offset = "0x6393B80", VA = "0x186394F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JPIBKIJOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6395FD0", Offset = "0x6394BD0", VA = "0x186395FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OGOEIPLNHKB BGNPBFCMPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63947E0", Offset = "0x63933E0", VA = "0x1863947E0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6396580", Offset = "0x6395180", VA = "0x186396580", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6396520", Offset = "0x6395120", VA = "0x186396520", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6395C20", Offset = "0x6394820", VA = "0x186395C20", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6396680", Offset = "0x6395280", VA = "0x186396680", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6398380", Offset = "0x6396F80", VA = "0x186398380", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6398B30", Offset = "0x6397730", VA = "0x186398B30", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6394500", Offset = "0x6393100", VA = "0x186394500", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event OGOEIPLNHKB DKPFAAIGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x63957A0", Offset = "0x63943A0", VA = "0x1863957A0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6393280", Offset = "0x6391E80", VA = "0x186393280", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6393950", Offset = "0x6392550", VA = "0x186393950", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x63938F0", Offset = "0x63924F0", VA = "0x1863938F0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6393340", Offset = "0x6391F40", VA = "0x186393340", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6393BF0", Offset = "0x63927F0", VA = "0x186393BF0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6396FC0", Offset = "0x6395BC0", VA = "0x186396FC0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6395020", Offset = "0x6393C20", VA = "0x186395020", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event OGOEIPLNHKB MJEONDGBFND
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63952E0", Offset = "0x6393EE0", VA = "0x1863952E0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6395F20", Offset = "0x6394B20", VA = "0x186395F20", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6398C30", Offset = "0x6397830", VA = "0x186398C30")]
	public DGLLDCMCBOK(GameObject LCHNDEILNAI, RigidbodyEx JABJLOBNFKI, HBFIOLAIDGN CEICFMOFGAN, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6397560", Offset = "0x6396160", VA = "0x186397560", Slot = "135")]
	protected virtual void NBHADOFBBJF(HBFIOLAIDGN CEICFMOFGAN, AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6394260", Offset = "0x6392E60", VA = "0x186394260", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6397EA0", Offset = "0x6396AA0", VA = "0x186397EA0", Slot = "71")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6392D70", Offset = "0x6391970", VA = "0x186392D70", Slot = "72")]
	public void HDGHMIOPPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x63985E0", Offset = "0x63971E0", VA = "0x1863985E0", Slot = "73")]
	public void OMDBKBLHJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x63987D0", Offset = "0x63973D0", VA = "0x1863987D0")]
	private void PDJCDDIBAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6395080", Offset = "0x6393C80", VA = "0x186395080", Slot = "81")]
	public void GMIJDPBCEJN(CLILEGLKHIM GCPEEAODAIB, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6393E40", Offset = "0x6392A40", VA = "0x186393E40", Slot = "84")]
	public void DBFDEEPEAND(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6393540", Offset = "0x6392140", VA = "0x186393540", Slot = "85")]
	public void BJIBLOJHNCI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6397980", Offset = "0x6396580", VA = "0x186397980", Slot = "86")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6394160", Offset = "0x6392D60", VA = "0x186394160", Slot = "87")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6392D70", Offset = "0x6391970", VA = "0x186392D70", Slot = "88")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6396AB0", Offset = "0x63956B0", VA = "0x186396AB0", Slot = "89")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6398600", Offset = "0x6397200", VA = "0x186398600", Slot = "90")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6397470", Offset = "0x6396070", VA = "0x186397470", Slot = "91")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6394640", Offset = "0x6393240", VA = "0x186394640", Slot = "92")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6393FE0", Offset = "0x6392BE0", VA = "0x186393FE0", Slot = "93")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6394330", Offset = "0x6392F30", VA = "0x186394330", Slot = "94")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63940C0", Offset = "0x6392CC0", VA = "0x1863940C0", Slot = "95")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6396170", Offset = "0x6394D70", VA = "0x186396170", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x63937F0", Offset = "0x63923F0", VA = "0x1863937F0", Slot = "97")]
	public Vector3 CBABHGJJPKF(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6394D30", Offset = "0x6393930", VA = "0x186394D30", Slot = "98")]
	public Vector3 GDJCEJCHEDO(Vector3 GCPEEAODAIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6398650", Offset = "0x6397250", VA = "0x186398650", Slot = "99")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6394BD0", Offset = "0x63937D0", VA = "0x186394BD0", Slot = "100")]
	public void GDHCGPOBHCJ(CLILEGLKHIM PHEEDLMPGKK, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6394730", Offset = "0x6393330", VA = "0x186394730", Slot = "101")]
	public void FEMKOCLIAPI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6395140", Offset = "0x6393D40", VA = "0x186395140", Slot = "41")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6395390", Offset = "0x6393F90", VA = "0x186395390", Slot = "104")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6398590", Offset = "0x6397190", VA = "0x186398590", Slot = "105")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6392F10", Offset = "0x6391B10", VA = "0x186392F10", Slot = "106")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63971F0", Offset = "0x6395DF0", VA = "0x1863971F0", Slot = "109")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6397340", Offset = "0x6395F40", VA = "0x186397340", Slot = "74")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63948A0", Offset = "0x63934A0", VA = "0x1863948A0", Slot = "110")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6394F30", Offset = "0x6393B30", VA = "0x186394F30", Slot = "115")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6395580", Offset = "0x6394180", VA = "0x186395580", Slot = "116")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6393730", Offset = "0x6392330", VA = "0x186393730", Slot = "117")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6392DC0", Offset = "0x63919C0", VA = "0x186392DC0", Slot = "118")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6398880", Offset = "0x6397480", VA = "0x186398880", Slot = "121")]
	public void PFAPPCDBFIE(Vector3 FKCIMLGPDFF, Quaternion BNPCKHFIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6398440", Offset = "0x6397040", VA = "0x186398440", Slot = "122")]
	public void OFMMOLCGMJH(Vector3 PFOLENACLBD, Quaternion HEEFOKBEAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6395220", Offset = "0x6393E20", VA = "0x186395220", Slot = "123")]
	public bool HECEPIIFOCH(float MFAAODEGFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6395800", Offset = "0x6394400", VA = "0x186395800", Slot = "124")]
	public void ICMNCHDLLDM(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63930A0", VA = "0x1863944A0", Slot = "125")]
	public void EGDBONAKCBF(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x63983E0", Offset = "0x6396FE0", VA = "0x1863983E0", Slot = "126")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6396000", Offset = "0x6394C00", VA = "0x186396000", Slot = "127")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6396220", Offset = "0x6394E20", VA = "0x186396220", Slot = "128")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6393C50", Offset = "0x6392850", VA = "0x186393C50", Slot = "129")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6397A80", Offset = "0x6396680", VA = "0x186397A80", Slot = "130")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x63953E0", Offset = "0x6393FE0", VA = "0x1863953E0", Slot = "131")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6395CD0", Offset = "0x63948D0", VA = "0x186395CD0", Slot = "132")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6397160", Offset = "0x6395D60", VA = "0x186397160", Slot = "133")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6398BF0", Offset = "0x63977F0", VA = "0x186398BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6397B60", Offset = "0x6396760", VA = "0x186397B60")]
	private void NEJMHGMPOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6396060", Offset = "0x6394C60", VA = "0x186396060")]
	private void JHDGOEDHDBJ(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63939B0", Offset = "0x63925B0", VA = "0x1863939B0")]
	private void CFKOKFBNPFE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6394A40", Offset = "0x6393640", VA = "0x186394A40")]
	private void FPFGOJGGPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6395B20", Offset = "0x6394720", VA = "0x186395B20")]
	private void IGDFFJLNGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6395860", Offset = "0x6394460", VA = "0x186395860")]
	private void IEGAOAAOBEM(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63982B0", Offset = "0x6396EB0", VA = "0x1863982B0")]
	private void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63948F0", Offset = "0x63934F0", VA = "0x1863948F0")]
	private void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6395DB0", Offset = "0x63949B0", VA = "0x186395DB0")]
	private void ILCIMKHHOLC(RigidbodyEx HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6396300", Offset = "0x6394F00", VA = "0x186396300", Slot = "140")]
	protected virtual void JHMDCGKOPAI(RigidbodyEx NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6392F60", Offset = "0x6391B60", VA = "0x186392F60")]
	protected void AEHCKCCMJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x63966E0", Offset = "0x63952E0", VA = "0x1863966E0")]
	protected void KNONLCKOEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6393EA0", Offset = "0x6392AA0", VA = "0x186393EA0", Slot = "141")]
	protected virtual IDisposable DBHLFGNEEOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class FHBOKDOGOFK
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x639E920", Offset = "0x639D520", VA = "0x18639E920")]
	public static CLILEGLKHIM KHCFAAIDMDM(this CLILEGLKHIM NGEPMJPLOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x639E7D0", Offset = "0x639D3D0", VA = "0x18639E7D0")]
	public static bool BAHIAHNENME(this CLILEGLKHIM NGEPMJPLOFK, CLILEGLKHIM OJBFIKOJPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x639E750", Offset = "0x639D350", VA = "0x18639E750")]
	public static bool AFAFEMABLKI(this CLILEGLKHIM NGEPMJPLOFK, CLILEGLKHIM EKOLKIEBGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x639E850", Offset = "0x639D450", VA = "0x18639E850")]
	public static RigidbodyEx CAHFGEEGHBM(this CLILEGLKHIM JDONOAIINGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x639E8A0", Offset = "0x639D4A0", VA = "0x18639E8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A04C0", Offset = "0x639F0C0", VA = "0x1863A04C0")]
	public GKOLACODPEA(DGLLDCMCBOK OIPEAFPNBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63A0460", Offset = "0x639F060", VA = "0x1863A0460", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A1EC0", Offset = "0x63A0AC0", VA = "0x1863A1EC0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63A2300", Offset = "0x63A0F00", VA = "0x1863A2300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x63A1F20", Offset = "0x63A0B20", VA = "0x1863A1F20", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63A2380", Offset = "0x63A0F80", VA = "0x1863A2380", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public ICIGCPCPNCL(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x63A2520", Offset = "0x63A1120", VA = "0x1863A2520", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x63A2440", Offset = "0x63A1040", VA = "0x1863A2440", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x63A2670", Offset = "0x63A1270", VA = "0x1863A2670", Slot = "7")]
	public void PDLKPLFJPBP(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x63A2370", Offset = "0x63A0F70", VA = "0x1863A2370", Slot = "8")]
	public void JNIJEEAEHLJ(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x63A21A0", Offset = "0x63A0DA0", VA = "0x1863A21A0", Slot = "10")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63A2030", Offset = "0x63A0C30", VA = "0x1863A2030")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A0070", Offset = "0x639EC70", VA = "0x1863A0070")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A0150", Offset = "0x639ED50", VA = "0x1863A0150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public AKKMOBBIBLF GNFFBNNKDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A0240", Offset = "0x639EE40", VA = "0x1863A0240", Slot = "6")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A0150", Offset = "0x639ED50", VA = "0x1863A0150", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x639FF10", Offset = "0x639EB10", VA = "0x18639FF10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x639FFC0", Offset = "0x639EBC0", VA = "0x18639FFC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public GJJPCDCDEJK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A0440", Offset = "0x639F040", VA = "0x1863A0440", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x63A3340", Offset = "0x63A1F40", VA = "0x1863A3340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6390E20", Offset = "0x638FA20", VA = "0x186390E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x63AA980", Offset = "0x63A9580", VA = "0x1863AA980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public MCNABBOOKKN(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63AA740", Offset = "0x63A9340", VA = "0x1863AA740", Slot = "4")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A9D20", Offset = "0x63A8920", VA = "0x1863A9D20")]
	private void BHCOCEGHJLN(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63AA260", Offset = "0x63A8E60", VA = "0x1863AA260", Slot = "5")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63AA9E0", Offset = "0x63A95E0", VA = "0x1863AA9E0", Slot = "6")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AA000", Offset = "0x63A8C00", VA = "0x1863AA000")]
	private void CEGDEFNIAEI(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63AA4E0", Offset = "0x63A90E0", VA = "0x1863AA4E0", Slot = "7")]
	public void HKJJPBKDICM(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63AA8A0", Offset = "0x63A94A0", VA = "0x1863AA8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6391D80", Offset = "0x6390980", VA = "0x186391D80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6391E70", Offset = "0x6390A70", VA = "0x186391E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public CGDODDCIJGP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6391DE0", Offset = "0x63909E0", VA = "0x186391DE0", Slot = "6")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6391FC0", Offset = "0x6390BC0", VA = "0x186391FC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B2AB0", Offset = "0x63B16B0", VA = "0x1863B2AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HIMFIAMFCKI IMBNAELJKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x63B3B60", Offset = "0x63B2760", VA = "0x1863B3B60")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x63B2B80", Offset = "0x63B1780", VA = "0x1863B2B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x63B3580", Offset = "0x63B2180", VA = "0x1863B3580", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x63B3290", Offset = "0x63B1E90", VA = "0x1863B3290", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public HIMFIAMFCKI IHJEOLPDHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x63B2F40", Offset = "0x63B1B40", VA = "0x1863B2F40")]
		get
		{
			return default(HIMFIAMFCKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63B38A0", Offset = "0x63B24A0", VA = "0x1863B38A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CLILEGLKHIM EGCFCBLCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B2150", Offset = "0x63B0D50", VA = "0x1863B2150", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B2960", Offset = "0x63B1560", VA = "0x1863B2960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63B33A0", Offset = "0x63B1FA0", VA = "0x1863B33A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x63B3300", Offset = "0x63B1F00", VA = "0x1863B3300", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63B3090", Offset = "0x63B1C90", VA = "0x1863B3090", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x63B3440", Offset = "0x63B2040", VA = "0x1863B3440", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63B3BC0", Offset = "0x63B27C0", VA = "0x1863B3BC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action OLFMHBNNIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x63B34E0", Offset = "0x63B20E0", VA = "0x1863B34E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x63B1F60", Offset = "0x63B0B60", VA = "0x1863B1F60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action NILEMMLPJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x63B2EA0", Offset = "0x63B1AA0", VA = "0x1863B2EA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63B2AE0", Offset = "0x63B16E0", VA = "0x1863B2AE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<CLILEGLKHIM> AGBNPPLPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63B37F0", Offset = "0x63B23F0", VA = "0x1863B37F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x63B1E10", Offset = "0x63B0A10", VA = "0x1863B1E10", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<CLILEGLKHIM> LEGHKNLKFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x63B2780", Offset = "0x63B1380", VA = "0x1863B2780", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x63B20A0", Offset = "0x63B0CA0", VA = "0x1863B20A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action HGNEPMKMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x63B2000", Offset = "0x63B0C00", VA = "0x1863B2000", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x63B26E0", Offset = "0x63B12E0", VA = "0x1863B26E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<CLILEGLKHIM> BIKBACEBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63B31E0", Offset = "0x63B1DE0", VA = "0x1863B31E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x63B3130", Offset = "0x63B1D30", VA = "0x1863B3130", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63B3CF0", Offset = "0x63B28F0", VA = "0x1863B3CF0")]
	public NIMGJOOFFAA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63B2830", Offset = "0x63B1430", VA = "0x1863B2830", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63B2BF0", Offset = "0x63B17F0", VA = "0x1863B2BF0", Slot = "26")]
	public void GMIJDPBCEJN(CLILEGLKHIM OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63B2C70", Offset = "0x63B1870", VA = "0x1863B2C70")]
	private void GMIJDPBCEJN(KKMILDLPGMG OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x63B2260", Offset = "0x63B0E60", VA = "0x1863B2260")]
	private void DDEICLFKDHK(KKMILDLPGMG OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63B3910", Offset = "0x63B2510", VA = "0x1863B3910")]
	private void NLHLDPBPJBG(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x63B35F0", Offset = "0x63B21F0", VA = "0x1863B35F0")]
	private void MJHJCLDHBJN(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63B2CC0", Offset = "0x63B18C0", VA = "0x1863B2CC0")]
	private void HBMJDCNFGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A00", Offset = "0x63B1600", VA = "0x1863B2A00")]
	private void FLMOENJIEAN(KKMILDLPGMG PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B2FA0", Offset = "0x63B1BA0", VA = "0x1863B2FA0")]
	private void IFPNIADGDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B21C0", Offset = "0x63B0DC0", VA = "0x1863B21C0")]
	private void DDBFHNLJBCE(KKMILDLPGMG NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B1EC0", Offset = "0x63B0AC0", VA = "0x1863B1EC0")]
	private void BCPPHKCNPIG(KKMILDLPGMG NGEPMJPLOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class CCEPLLBOGHO
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6391BF0", Offset = "0x63907F0", VA = "0x186391BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x639CD40", Offset = "0x639B940", VA = "0x18639CD40", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x639CED0", Offset = "0x639BAD0", VA = "0x18639CED0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x639CDE0", Offset = "0x639B9E0", VA = "0x18639CDE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private CLILEGLKHIM HOPEHPMKHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x639D100", Offset = "0x639BD00", VA = "0x18639D100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public DJBEPEABJBH(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x639C6D0", Offset = "0x639B2D0", VA = "0x18639C6D0", Slot = "6")]
	public void IOBGBBEPPKF(CLILEGLKHIM HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x639C820", Offset = "0x639B420", VA = "0x18639C820")]
	private void IOBGBBEPPKF(KKMILDLPGMG HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x639CD70", Offset = "0x639B970", VA = "0x18639CD70", Slot = "7")]
	public void LHBNKJHAMAA(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x639C930", Offset = "0x639B530", VA = "0x18639C930")]
	private Vector3 KJBIIKFNEKK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EFIHGHEKHIG
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x639D2D0", Offset = "0x639BED0", VA = "0x18639D2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x639B0C0", Offset = "0x6399CC0", VA = "0x18639B0C0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6399C20", Offset = "0x6398820", VA = "0x186399C20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 EBOFFPNCNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6398E60", Offset = "0x6397A60", VA = "0x186398E60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 LBMAKPMAKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x63993A0", Offset = "0x6397FA0", VA = "0x1863993A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x639B870", Offset = "0x639A470", VA = "0x18639B870", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6399BC0", Offset = "0x63987C0", VA = "0x186399BC0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float DCEMBMHMCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x639C360", Offset = "0x639AF60", VA = "0x18639C360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float CJNNGJHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6398E00", Offset = "0x6397A00", VA = "0x186398E00", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6399DA0", Offset = "0x63989A0", VA = "0x186399DA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6399950", Offset = "0x6398550", VA = "0x186399950", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x639B170", Offset = "0x6399D70", VA = "0x18639B170", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event OGOEIPLNHKB EOBAIGEGIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x639BA60", Offset = "0x639A660", VA = "0x18639BA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6398D60", Offset = "0x6397960", VA = "0x186398D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x639C3E0", Offset = "0x639AFE0", VA = "0x18639C3E0")]
	public DICLMKGNGPO(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x639BB00", Offset = "0x639A700", VA = "0x18639BB00")]
	public float3 NOOFAPAMMDN()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63994D0", Offset = "0x63980D0", VA = "0x1863994D0", Slot = "14")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6399760", Offset = "0x6398360", VA = "0x186399760", Slot = "16")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x639C010", Offset = "0x639AC10", VA = "0x18639C010", Slot = "15")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x639B7A0", Offset = "0x639A3A0", VA = "0x18639B7A0", Slot = "18")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x639BC20", Offset = "0x639A820", VA = "0x18639BC20", Slot = "19")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6398D00", Offset = "0x6397900", VA = "0x186398D00", Slot = "17")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x639B1A0", Offset = "0x6399DA0", VA = "0x18639B1A0", Slot = "20")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6391510", Offset = "0x6390110", VA = "0x186391510")]
	public void GCEJKNBMGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6399C20", Offset = "0x6398820", VA = "0x186399C20")]
	private void KIEBBGKDHKM(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6398F10", Offset = "0x6397B10", VA = "0x186398F10")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 DIKNILAGHJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6399DA0", Offset = "0x63989A0", VA = "0x186399DA0")]
	private void PJLBHDMMAEJ(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6399140", Offset = "0x6397D40", VA = "0x186399140")]
	private Vector3 EHFEJJCOOKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6399980", Offset = "0x6398580", VA = "0x186399980")]
	private Quaternion IHGJEPAKGOG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6399E60", Offset = "0x6398A60", VA = "0x186399E60")]
	internal (float, Vector3) LADLLHGCBIO(Rigidbody JMIIEAMEOBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LNDNJHCLKLP
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63A99D0", Offset = "0x63A85D0", VA = "0x1863A99D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x639EEA0", Offset = "0x639DAA0", VA = "0x18639EEA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NLLCDEONLOL HJMOMBBLICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x639E9D0", Offset = "0x639D5D0", VA = "0x18639E9D0", Slot = "11")]
		get
		{
			return default(NLLCDEONLOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private NLLCDEONLOL OHPPIBOBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x639E9D0", Offset = "0x639D5D0", VA = "0x18639E9D0")]
		get
		{
			return default(NLLCDEONLOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x639EBB0", Offset = "0x639D7B0", VA = "0x18639EBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x639F2E0", Offset = "0x639DEE0", VA = "0x18639F2E0")]
	public FIJAODCFAHB(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x639F160", Offset = "0x639DD60", VA = "0x18639F160", Slot = "4")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x639EC20", Offset = "0x639D820", VA = "0x18639EC20")]
	private bool FHDHEKEGDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x639F260", Offset = "0x639DE60", VA = "0x18639F260", Slot = "5")]
	public void OACOBDCKHGB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x639EB30", Offset = "0x639D730", VA = "0x18639EB30", Slot = "6")]
	public void FEDLOEEFJBP(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x639EF00", Offset = "0x639DB00", VA = "0x18639EF00", Slot = "9")]
	public void JBLKMCFBKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x639EA30", Offset = "0x639D630", VA = "0x18639EA30")]
	private void EILCIKCCDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x639ED00", Offset = "0x639D900", VA = "0x18639ED00")]
	private void GMIJGIHDHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x639F060", Offset = "0x639DC60", VA = "0x18639F060", Slot = "8")]
	public void LEBKMNKBKFA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x639F0E0", Offset = "0x639DCE0", VA = "0x18639F0E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6391450", Offset = "0x6390050", VA = "0x186391450", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool CIJMIMDKPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x63914B0", Offset = "0x63900B0", VA = "0x1863914B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x63911F0", Offset = "0x638FDF0", VA = "0x1863911F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6391140", Offset = "0x638FD40", VA = "0x186391140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public ABCBCGCJNJJ(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x63910D0", Offset = "0x638FCD0", VA = "0x1863910D0", Slot = "11")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x63911E0", Offset = "0x638FDE0", VA = "0x1863911E0", Slot = "8")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x63910C0", Offset = "0x638FCC0", VA = "0x1863910C0", Slot = "9")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6390FC0", Offset = "0x638FBC0", VA = "0x186390FC0", Slot = "10")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6391290", Offset = "0x638FE90", VA = "0x186391290", Slot = "12")]
	public void MMMPLHKBEGG(Rigidbody IDJLKFJMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6391370", Offset = "0x638FF70", VA = "0x186391370", Slot = "13")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6391510", Offset = "0x6390110", VA = "0x186391510", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x639DB20", Offset = "0x639C720", VA = "0x18639DB20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FENPGOBDPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x639D940", Offset = "0x639C540", VA = "0x18639D940", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OGOEIPLNHKB MFLAPEJBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x639E030", Offset = "0x639CC30", VA = "0x18639E030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x639D4C0", Offset = "0x639C0C0", VA = "0x18639D4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x639E0D0", Offset = "0x639CCD0", VA = "0x18639E0D0")]
	public EHNDLHLHHNC(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x639DB40", Offset = "0x639C740", VA = "0x18639DB40", Slot = "8")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x639D360", Offset = "0x639BF60", VA = "0x18639D360", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x639DE30", Offset = "0x639CA30", VA = "0x18639DE30", Slot = "9")]
	public void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x639D740", Offset = "0x639C340", VA = "0x18639D740", Slot = "10")]
	public void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x639D560", Offset = "0x639C160", VA = "0x18639D560")]
	private void FCODMEHCEOM(PhotonView KFHLGPCEJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x639D9D0", Offset = "0x639C5D0", VA = "0x18639D9D0")]
	private void KELGPNGFFHP(RigidbodyEx BDNPBMBDKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x639DC70", Offset = "0x639C870", VA = "0x18639DC70")]
	private void NLEGMHOHKFJ(PhotonView KJFGFKCMNHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class FJLCKCCDDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x639F3F0", Offset = "0x639DFF0", VA = "0x18639F3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63915F0", Offset = "0x63901F0", VA = "0x1863915F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x63918A0", Offset = "0x63904A0", VA = "0x1863918A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OECAEIFCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6391910", Offset = "0x6390510", VA = "0x186391910", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6391650", Offset = "0x6390250", VA = "0x186391650")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints PAELKKDAOED
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x63916C0", Offset = "0x63902C0", VA = "0x1863916C0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6391720", Offset = "0x6390320", VA = "0x186391720", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6391A80", Offset = "0x6390680", VA = "0x186391A80")]
	public ACBDPIBBFKF(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6391970", Offset = "0x6390570", VA = "0x186391970", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6391A00", Offset = "0x6390600", VA = "0x186391A00", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x639E380", Offset = "0x639CF80", VA = "0x18639E380", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x639E600", Offset = "0x639D200", VA = "0x18639E600", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float CPAOLNDEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x639E4D0", Offset = "0x639D0D0", VA = "0x18639E4D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x639E230", Offset = "0x639CE30", VA = "0x18639E230", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public FFMIDAMDOIP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x639E3E0", Offset = "0x639CFE0", VA = "0x18639E3E0", Slot = "8")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x639E530", Offset = "0x639D130", VA = "0x18639E530", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A1AD0", Offset = "0x63A06D0", VA = "0x1863A1AD0", Slot = "4")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x63A1790", Offset = "0x63A0390", VA = "0x1863A1790", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x63A1C60", Offset = "0x63A0860", VA = "0x1863A1C60", Slot = "6")]
	public void LADLLHGCBIO(HIMFIAMFCKI JMADFINDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x63A18B0", Offset = "0x63A04B0", VA = "0x1863A18B0", Slot = "7")]
	public void GKPKDAOPFPI(HIMFIAMFCKI JMADFINDJPP, bool DFFPADHABEE, bool OKBHBCKEAAE, bool POBFAOIOMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1B20", Offset = "0x63A0720", VA = "0x1863A1B20", Slot = "8")]
	public void KJDGMNNJMJN(HIMFIAMFCKI JMADFINDJPP, float3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x63A1D80", Offset = "0x63A0980", VA = "0x1863A1D80", Slot = "9")]
	public void NEGFIOJHAGH(HIMFIAMFCKI JMADFINDJPP, float3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x63A15E0", Offset = "0x63A01E0", VA = "0x1863A15E0")]
	private bool COAGNOJMKKH(HIMFIAMFCKI JMADFINDJPP, [Out] KKMILDLPGMG OGDBMIPIOMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x63A17C0", Offset = "0x63A03C0", VA = "0x1863A17C0")]
	private bool FLLFFCDOMHK(HIMFIAMFCKI JMADFINDJPP, [Out] DICLMKGNGPO JMJLNPMKJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63A16A0", Offset = "0x63A02A0", VA = "0x1863A16A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x63B02F0", Offset = "0x63AEEF0", VA = "0x1863B02F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x63B1A80", Offset = "0x63B0680", VA = "0x1863B1A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x63B1C80", Offset = "0x63B0880", VA = "0x1863B1C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool HJCPDOLFGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x63B17A0", Offset = "0x63B03A0", VA = "0x1863B17A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x63B1520", Offset = "0x63B0120", VA = "0x1863B1520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool JAGAPMNGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x63B1740", Offset = "0x63B0340", VA = "0x1863B1740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x63B16D0", Offset = "0x63B02D0", VA = "0x1863B16D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int IACOLECINOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x63B1870", Offset = "0x63B0470", VA = "0x1863B1870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x63B1480", Offset = "0x63B0080", VA = "0x1863B1480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x63B13E0", Offset = "0x63AFFE0", VA = "0x1863B13E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63B1CE0", Offset = "0x63B08E0", VA = "0x1863B1CE0")]
	public NDDANHKEPKL(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63B1BD0", Offset = "0x63B07D0", VA = "0x1863B1BD0", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x63B1800", Offset = "0x63B0400", VA = "0x1863B1800", Slot = "8")]
	public void HJHIJKPFBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x63B18E0", Offset = "0x63B04E0", VA = "0x1863B18E0", Slot = "7")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63B1AE0", Offset = "0x63B06E0", VA = "0x1863B1AE0", Slot = "9")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6391510", Offset = "0x6390110", VA = "0x186391510", Slot = "12")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x63B1590", Offset = "0x63B0190", VA = "0x1863B1590", Slot = "11")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "10")]
	public void BLGDEGHEGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x63B1300", Offset = "0x63AFF00", VA = "0x1863B1300")]
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
		[Cpp2IlInjected.Address(RVA = "0x63908A0", Offset = "0x638F4A0", VA = "0x1863908A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6390A60", Offset = "0x638F660", VA = "0x186390A60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6390E20", Offset = "0x638FA20", VA = "0x186390E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool DKDEMEEKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6390980", Offset = "0x638F580", VA = "0x186390980", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6390F00", Offset = "0x638FB00", VA = "0x186390F00")]
	public AAAMMPJFOPL(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6390D70", Offset = "0x638F970", VA = "0x186390D70", Slot = "5")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6390E80", Offset = "0x638FA80", VA = "0x186390E80", Slot = "7")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x63909E0", Offset = "0x638F5E0", VA = "0x1863909E0", Slot = "8")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6390B50", Offset = "0x638F750", VA = "0x186390B50", Slot = "9")]
	public void NEAHDEDOACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6390470", Offset = "0x638F070", VA = "0x186390470", Slot = "11")]
	public void BELMCIBIMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x63906D0", Offset = "0x638F2D0", VA = "0x1863906D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x63AF400", Offset = "0x63AE000", VA = "0x1863AF400", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x63AF200", Offset = "0x63ADE00", VA = "0x1863AF200", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public FAJHLMMDDLF COCPMJDMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63B0C50", Offset = "0x63AF850", VA = "0x1863B0C50", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x63B0BE0", Offset = "0x63AF7E0", VA = "0x1863B0BE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x63B06C0", Offset = "0x63AF2C0", VA = "0x1863B06C0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x63B0900", Offset = "0x63AF500", VA = "0x1863B0900", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x63B09C0", Offset = "0x63AF5C0", VA = "0x1863B09C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x63AD7D0", Offset = "0x63AC3D0", VA = "0x1863AD7D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x63ADAE0", Offset = "0x63AC6E0", VA = "0x1863ADAE0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x63AF270", Offset = "0x63ADE70", VA = "0x1863AF270", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x63AFA80", Offset = "0x63AE680", VA = "0x1863AFA80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x63B02C0", Offset = "0x63AEEC0", VA = "0x1863B02C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float NENGIOPIHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x63ADA80", Offset = "0x63AC680", VA = "0x1863ADA80", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x63ADC90", Offset = "0x63AC890", VA = "0x1863ADC90", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool ABNLGNLKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x63AFF70", Offset = "0x63AEB70", VA = "0x1863AFF70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private AHLABJLGKJI GJNBOIKJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CB66B0", Offset = "0x1CB52B0", VA = "0x181CB66B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x63B02F0", Offset = "0x63AEEF0", VA = "0x1863B02F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public MMANNDEFLCE(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63AF390", Offset = "0x63ADF90", VA = "0x1863AF390", Slot = "20")]
	public void FAKHMMGELAJ(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x63ADC20", Offset = "0x63AC820", VA = "0x1863ADC20", Slot = "30")]
	public void CKIMBGIPJJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x63AD720", Offset = "0x63AC320", VA = "0x1863AD720", Slot = "19")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x63AEBD0", Offset = "0x63AD7D0", VA = "0x1863AEBD0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x63B0310", Offset = "0x63AEF10", VA = "0x1863B0310", Slot = "28")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x63B0720", Offset = "0x63AF320", VA = "0x1863B0720", Slot = "35")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x63AEA10", Offset = "0x63AD610", VA = "0x1863AEA10", Slot = "34")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x63AD720", Offset = "0x63AC320", VA = "0x1863AD720", Slot = "27")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x63B0260", Offset = "0x63AEE60", VA = "0x1863B0260", Slot = "25")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x63B09F0", Offset = "0x63AF5F0", VA = "0x1863B09F0", Slot = "24")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63B0480", Offset = "0x63AF080", VA = "0x1863B0480", Slot = "33")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x63AF330", Offset = "0x63ADF30", VA = "0x1863AF330", Slot = "32")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x63AE590", Offset = "0x63AD190", VA = "0x1863AE590", Slot = "31")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC90", Offset = "0x63AD890", VA = "0x1863AEC90", Slot = "22")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x63AE760", Offset = "0x63AD360", VA = "0x1863AE760", Slot = "21")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x63AFAB0", Offset = "0x63AE6B0", VA = "0x1863AFAB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x63ADB40", Offset = "0x63AC740", VA = "0x1863ADB40", Slot = "29")]
	public Vector3 CBABHGJJPKF(Vector3 OAAOAKNCDMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63B0A50", Offset = "0x63AF650", VA = "0x1863B0A50", Slot = "26")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63ADC90", Offset = "0x63AC890", VA = "0x1863ADC90")]
	private void CMBPFKHCHEE(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63AE360", Offset = "0x63ACF60", VA = "0x1863AE360")]
	private void DCBNDJBMBCH(Vector3 OLNHEMAINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63AD800", Offset = "0x63AC400", VA = "0x1863AD800")]
	private Vector3 BBCFODFLNIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x63ADDE0", Offset = "0x63AC9E0", VA = "0x1863ADDE0")]
	private void CMMNNGGKIMB(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x63AFFD0", Offset = "0x63AEBD0", VA = "0x1863AFFD0")]
	private Vector3 KLMACOIEGDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x63AF510", Offset = "0x63AE110", VA = "0x1863AF510")]
	private void HBHCEEOLJBP(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x63AE530", Offset = "0x63AD130", VA = "0x1863AE530")]
	private void DGCMNFFBELI(Vector3 OAAOAKNCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x63AF4B0", Offset = "0x63AE0B0", VA = "0x1863AF4B0")]
	private void GNCOKCGFFHI(Vector3 NHOJBJMMDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x63B0D00", Offset = "0x63AF900", VA = "0x1863B0D00")]
	private void PIAPIOOPHNO(string OFFCKGHBNFG, Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63AFEC0", Offset = "0x63AEAC0", VA = "0x1863AFEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5514E70", Offset = "0x5513A70", VA = "0x185514E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected HIMFIAMFCKI LCGLEBLNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5514EB0", Offset = "0x5513AB0", VA = "0x185514EB0")]
		get
		{
			return default(HIMFIAMFCKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6391550", Offset = "0x6390150", VA = "0x186391550")]
	public FBINNMIICHO(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x639E190", Offset = "0x639CD90", VA = "0x18639E190")]
	protected CLILEGLKHIM BGGEHPDAEHP(HIMFIAMFCKI OEBOJHNMNBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IPBGGMGCNHI : POEPMBPGKKN
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63A57C0", Offset = "0x63A43C0", VA = "0x1863A57C0", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x63A4D60", Offset = "0x63A3960", VA = "0x1863A4D60", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x63A55D0", Offset = "0x63A41D0", VA = "0x1863A55D0", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A00", Offset = "0x63A4600", VA = "0x1863A5A00", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A5890", Offset = "0x63A4490", VA = "0x1863A5890", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A54F0", Offset = "0x63A40F0", VA = "0x1863A54F0", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A5AE0", Offset = "0x63A46E0", VA = "0x1863A5AE0", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x63A5410", Offset = "0x63A4010", VA = "0x1863A5410", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x63A51F0", Offset = "0x63A3DF0", VA = "0x1863A51F0", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x63A5110", Offset = "0x63A3D10", VA = "0x1863A5110", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x63A56C0", Offset = "0x63A42C0", VA = "0x1863A56C0")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A4C60", Offset = "0x63A3860", VA = "0x1863A4C60")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x63A52D0", Offset = "0x63A3ED0", VA = "0x1863A52D0")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A5820", Offset = "0x63A4420", VA = "0x1863A5820")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x63A4E40", Offset = "0x63A3A40", VA = "0x1863A4E40")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A4FE0", Offset = "0x63A3BE0", VA = "0x1863A4FE0", Slot = "19")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A56C0", Offset = "0x63A42C0", VA = "0x1863A56C0", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x63A4C60", Offset = "0x63A3860", VA = "0x1863A4C60", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x63A52D0", Offset = "0x63A3ED0", VA = "0x1863A52D0", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A5820", Offset = "0x63A4420", VA = "0x1863A5820", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x63A56B0", Offset = "0x63A42B0", VA = "0x1863A56B0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A5E20", Offset = "0x63A4A20", VA = "0x1863A5E20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CLILEGLKHIM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x63A5BC0", Offset = "0x63A47C0", VA = "0x1863A5BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x35C98E0", Offset = "0x35C84E0", VA = "0x1835C98E0")]
	public JGMCPGPGBLB(HIMFIAMFCKI OEBOJHNMNBH, DMOPNDHELBN KBPCHNGOIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x63A5D10", Offset = "0x63A4910", VA = "0x1863A5D10", Slot = "6")]
	public IEnumerator<CLILEGLKHIM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63A5D10", Offset = "0x63A4910", VA = "0x1863A5D10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63A5BC0", Offset = "0x63A47C0", VA = "0x1863A5BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A3570", Offset = "0x63A2170", VA = "0x1863A3570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x63A3BF0", Offset = "0x63A27F0", VA = "0x1863A3BF0", Slot = "20")]
	public void InitReferences(AKLOJBGPAJC LCFMOEJDELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x63A3C40", Offset = "0x63A2840", VA = "0x1863A3C40", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x63A34D0", Offset = "0x63A20D0", VA = "0x1863A34D0", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x63A3AA0", Offset = "0x63A26A0", VA = "0x1863A3AA0", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x63A3E30", Offset = "0x63A2A30", VA = "0x1863A3E30", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x63A3D90", Offset = "0x63A2990", VA = "0x1863A3D90", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x63A3A00", Offset = "0x63A2600", VA = "0x1863A3A00", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x63A3ED0", Offset = "0x63A2AD0", VA = "0x1863A3ED0", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x63A3960", Offset = "0x63A2560", VA = "0x1863A3960", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x63A3810", Offset = "0x63A2410", VA = "0x1863A3810", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x63A3770", Offset = "0x63A2370", VA = "0x1863A3770", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x63A3B40", Offset = "0x63A2740", VA = "0x1863A3B40")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2020", VA = "0x1863A3420")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x63A38B0", Offset = "0x63A24B0", VA = "0x1863A38B0")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63A3CE0", Offset = "0x63A28E0", VA = "0x1863A3CE0")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x63A35D0", Offset = "0x63A21D0", VA = "0x1863A35D0")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x63A3680", Offset = "0x63A2280", VA = "0x1863A3680", Slot = "19")]
	public CLILEGLKHIM FBLDCLLCDGF(RigidbodyEx NGEPMJPLOFK, AKGLBOOOAME IGJLGPELHOJ, HBFIOLAIDGN CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x63A3F70", Offset = "0x63A2B70", VA = "0x1863A3F70")]
	public IFMJMANNADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x63A3B40", Offset = "0x63A2740", VA = "0x1863A3B40", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2020", VA = "0x1863A3420", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x63A38B0", Offset = "0x63A24B0", VA = "0x1863A38B0", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x63A3CE0", Offset = "0x63A28E0", VA = "0x1863A3CE0", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x63A35D0", Offset = "0x63A21D0", VA = "0x1863A35D0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x3690F10", Offset = "0x368FB10", VA = "0x183690F10", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F50", Offset = "0x63A5B50", VA = "0x1863A6F50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F90", Offset = "0x63A5B90", VA = "0x1863A6F90", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x35AE9D0", Offset = "0x35AD5D0", VA = "0x1835AE9D0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C87F80", Offset = "0x5C86B80", VA = "0x185C87F80", Slot = "30")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A9800", Offset = "0x35A8400", VA = "0x1835A9800", Slot = "31")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A6FA0", Offset = "0x63A5BA0", VA = "0x1863A6FA0", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x542EAD0", Offset = "0x542D6D0", VA = "0x18542EAD0", Slot = "36")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A6F70", Offset = "0x63A5B70", VA = "0x1863A6F70", Slot = "132")]
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
	[Cpp2IlInjected.Address(RVA = "0x6398C30", Offset = "0x6397830", VA = "0x186398C30")]
	public KKMILDLPGMG(GameObject LCHNDEILNAI, RigidbodyEx JABJLOBNFKI, HBFIOLAIDGN CEICFMOFGAN, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x63A77B0", Offset = "0x63A63B0", VA = "0x1863A77B0", Slot = "135")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A7330", Offset = "0x63A5F30", VA = "0x1863A7330", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63A7A20", Offset = "0x63A6620", VA = "0x1863A7A20", Slot = "142")]
	public void ODONBGLIOKM(JPJFGPKMKAE MLMDDEIDFHL, JPJFGPKMKAE CHGDNKMNMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63A7040", Offset = "0x63A5C40", VA = "0x1863A7040", Slot = "143")]
	public void AFLLOCINJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63A76F0", Offset = "0x63A62F0", VA = "0x1863A76F0", Slot = "144")]
	public void KJHDMLMEGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63A74A0", Offset = "0x63A60A0", VA = "0x1863A74A0", Slot = "145")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x63A7560", Offset = "0x63A6160", VA = "0x1863A7560", Slot = "146")]
	public bool ICICGGFALMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x63A7500", Offset = "0x63A6100", VA = "0x1863A7500", Slot = "147")]
	public void GJMMAJFPCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "140")]
	protected override void JHMDCGKOPAI(RigidbodyEx IKFHEHLCJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x63A7100", Offset = "0x63A5D00", VA = "0x1863A7100")]
	private void CGDIPNNNOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class MPKCNCEFPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x63B12B0", Offset = "0x63AFEB0", VA = "0x1863B12B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode IFBOLKALKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F80", Offset = "0x63B3B80", VA = "0x1863B4F80", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x63B5320", Offset = "0x63B3F20", VA = "0x1863B5320", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63A3390", Offset = "0x63A1F90", VA = "0x1863A3390")]
	public OOGJPANDNBD(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63B5410", Offset = "0x63B4010", VA = "0x1863B5410", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x63B5390", Offset = "0x63B3F90", VA = "0x1863B5390", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63B5520", Offset = "0x63B4120", VA = "0x1863B5520", Slot = "7")]
	public void PDLKPLFJPBP(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x63B5310", Offset = "0x63B3F10", VA = "0x1863B5310", Slot = "8")]
	public void JNIJEEAEHLJ(bool IGOALBDIPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x63B51B0", Offset = "0x63B3DB0", VA = "0x1863B51B0", Slot = "10")]
	public bool IIPCAHKGJPM(Vector3 DIFJPIHEJAN, [Out] RaycastHit BAOLPDBJAFE, float KIMLGCJBKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x63B5090", Offset = "0x63B3C90", VA = "0x1863B5090")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B49C0", Offset = "0x63B35C0", VA = "0x1863B49C0", Slot = "6")]
		get
		{
			return default(AKKMOBBIBLF);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x63B48F0", Offset = "0x63B34F0", VA = "0x1863B48F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform HPNIBGPOPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x63B4E10", Offset = "0x63B3A10", VA = "0x1863B4E10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<HHMPBKNCJLA, HHMPBKNCJLA> EPHMILKCLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x63B4740", Offset = "0x63B3340", VA = "0x1863B4740", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x63B47F0", Offset = "0x63B33F0", VA = "0x1863B47F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x63B4E30", Offset = "0x63B3A30", VA = "0x1863B4E30")]
	public NPLKDADEHNN(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x63B4B10", Offset = "0x63B3710", VA = "0x1863B4B10", Slot = "8")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x63B48A0", Offset = "0x63B34A0", VA = "0x1863B48A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B6B6E0", Offset = "0x1B6A2E0", VA = "0x181B6B6E0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x63990F0", Offset = "0x6397CF0", VA = "0x1863990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool DPNBAINOCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x63A3340", Offset = "0x63A1F40", VA = "0x1863A3340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6390E20", Offset = "0x638FA20", VA = "0x186390E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x63A3180", Offset = "0x63A1D80", VA = "0x1863A3180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63A3390", Offset = "0x63A1F90", VA = "0x1863A3390")]
	public IDMCLNOIOFB(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x63A3020", Offset = "0x63A1C20", VA = "0x1863A3020", Slot = "4")]
	public void JHJKEKCIHOE(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x63A2680", Offset = "0x63A1280", VA = "0x1863A2680")]
	private void BHCOCEGHJLN(Vector3 JNADMECNEPO, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63A2B40", Offset = "0x63A1740", VA = "0x1863A2B40", Slot = "5")]
	public void CMLADPLCDOF(Vector3 JNADMECNEPO, Vector3 CFCLFCDKKPD, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63A31E0", Offset = "0x63A1DE0", VA = "0x1863A31E0", Slot = "6")]
	public void NDPCEDOJEPN(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63A28E0", Offset = "0x63A14E0", VA = "0x1863A28E0")]
	private void CEGDEFNIAEI(Vector3 DIGMBNDHCGJ, ForceMode KHELKGNAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x63A2DC0", Offset = "0x63A19C0", VA = "0x1863A2DC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B5560", Offset = "0x63B4160", VA = "0x1863B5560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63A3390", Offset = "0x63A1F90", VA = "0x1863A3390")]
	public PBKGHFAFNMK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x63B5530", Offset = "0x63B4130", VA = "0x1863B5530", Slot = "6")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6391FC0", Offset = "0x6390BC0", VA = "0x186391FC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A8460", Offset = "0x63A7060", VA = "0x1863A8460")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A8F50", Offset = "0x63A7B50", VA = "0x1863A8F50", Slot = "29")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A8250", Offset = "0x63A6E50", VA = "0x1863A8250", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x63A9000", Offset = "0x63A7C00", VA = "0x1863A9000", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event OGOEIPLNHKB GBDEACGOBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x63A8F60", Offset = "0x63A7B60", VA = "0x1863A8F60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x63A8D50", Offset = "0x63A7950", VA = "0x1863A8D50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event CFPKEOMCFGB OJIAPCJIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x63A90A0", Offset = "0x63A7CA0", VA = "0x1863A90A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63A9870", Offset = "0x63A8470", VA = "0x1863A9870", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action OLFMHBNNIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x63A9140", Offset = "0x63A7D40", VA = "0x1863A9140", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x63A7C40", Offset = "0x63A6840", VA = "0x1863A7C40", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action NILEMMLPJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63A8B80", Offset = "0x63A7780", VA = "0x1863A8B80", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x63A84C0", Offset = "0x63A70C0", VA = "0x1863A84C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<CLILEGLKHIM> AGBNPPLPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63A9550", Offset = "0x63A8150", VA = "0x1863A9550", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63A7AF0", Offset = "0x63A66F0", VA = "0x1863A7AF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<CLILEGLKHIM> LEGHKNLKFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x63A7FC0", Offset = "0x63A6BC0", VA = "0x1863A7FC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D80", Offset = "0x63A6980", VA = "0x1863A7D80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HGNEPMKMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x63A7CE0", Offset = "0x63A68E0", VA = "0x1863A7CE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A7F20", Offset = "0x63A6B20", VA = "0x1863A7F20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<CLILEGLKHIM> BIKBACEBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A8EA0", Offset = "0x63A7AA0", VA = "0x1863A8EA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A8DF0", Offset = "0x63A79F0", VA = "0x1863A8DF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A9910", Offset = "0x63A8510", VA = "0x1863A9910")]
	public LBPBOKOPBIK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A8070", Offset = "0x63A6C70", VA = "0x1863A8070", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A8560", Offset = "0x63A7160", VA = "0x1863A8560", Slot = "30")]
	public void GMIJDPBCEJN(CLILEGLKHIM OGNJAKACDHE, bool LGIEADGADKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63A9600", Offset = "0x63A8200", VA = "0x1863A9600", Slot = "6")]
	public void NLHLDPBPJBG(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A92D0", Offset = "0x63A7ED0", VA = "0x1863A92D0", Slot = "7")]
	public void MJHJCLDHBJN(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63A7E30", Offset = "0x63A6A30", VA = "0x1863A7E30", Slot = "4")]
	public void DDBFHNLJBCE(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A7BA0", Offset = "0x63A67A0", VA = "0x1863A7BA0", Slot = "5")]
	public void BCPPHKCNPIG(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A8AE0", Offset = "0x63A76E0", VA = "0x1863A8AE0")]
	private void HBMJDCNFGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A8420", Offset = "0x63A7020", VA = "0x1863A8420")]
	private void FLMOENJIEAN(CLILEGLKHIM PNONAPDCOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63A8110", Offset = "0x63A6D10", VA = "0x1863A8110")]
	private void FCELDJCHPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63A8C20", Offset = "0x63A7820", VA = "0x1863A8C20")]
	private void IFPNIADGDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A82F0", Offset = "0x63A6EF0", VA = "0x1863A82F0")]
	private void FLIDNPIKABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x63A91E0", Offset = "0x63A7DE0", VA = "0x1863A91E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63AD660", Offset = "0x63AC260", VA = "0x1863AD660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6392880", Offset = "0x6391480", VA = "0x186392880", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 GCGCMPACKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6392A00", Offset = "0x6391600", VA = "0x186392A00", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 NADJAMJDHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6392910", Offset = "0x6391510", VA = "0x186392910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public CLILEGLKHIM HOPEHPMKHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6392BC0", Offset = "0x63917C0", VA = "0x186392BC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6392C70", Offset = "0x6391870", VA = "0x186392C70")]
	public CPNFMAONJAK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6392480", Offset = "0x6391080", VA = "0x186392480", Slot = "8")]
	public void IOBGBBEPPKF(CLILEGLKHIM HHNAEDAPOHF, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x63928B0", Offset = "0x63914B0", VA = "0x1863928B0", Slot = "9")]
	public void LHBNKJHAMAA(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x63924F0", Offset = "0x63910F0", VA = "0x1863924F0")]
	private Vector3 KJBIIKFNEKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x63920F0", Offset = "0x6390CF0", VA = "0x1863920F0")]
	private void GAEGEAOPFIB(CLILEGLKHIM BBHJIJMHBOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OBNIDNOBACA
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x63B4EC0", Offset = "0x63B3AC0", VA = "0x1863B4EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63AB7E0", Offset = "0x63AA3E0", VA = "0x1863AB7E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 BCAMEPBKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x63AD060", Offset = "0x63ABC60", VA = "0x1863AD060", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x63AAD50", Offset = "0x63A9950", VA = "0x1863AAD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x63AB890", Offset = "0x63AA490", VA = "0x1863AB890", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 IHNCLIGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x63AB4D0", Offset = "0x63AA0D0", VA = "0x1863AB4D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion AICNONONEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x63AC960", Offset = "0x63AB560", VA = "0x1863AC960", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody AFENJAMGBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x63A64D0", Offset = "0x63A50D0", VA = "0x1863A64D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event OGOEIPLNHKB EOBAIGEGIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x63AD160", Offset = "0x63ABD60", VA = "0x1863AD160", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x63AACB0", Offset = "0x63A98B0", VA = "0x1863AACB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x63AD570", Offset = "0x63AC170", VA = "0x1863AD570")]
	public MGMHCJNLJEP(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63AB320", Offset = "0x63A9F20", VA = "0x1863AB320", Slot = "17")]
	public void HJHICEMDBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x63AD490", Offset = "0x63AC090", VA = "0x1863AD490", Slot = "16")]
	public void OLHALCKHAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x63ACF80", Offset = "0x63ABB80", VA = "0x1863ACF80", Slot = "19")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x63AD200", Offset = "0x63ABE00", VA = "0x1863AD200", Slot = "20")]
	public void OJLDBOLDIKM(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x63AAB40", Offset = "0x63A9740", VA = "0x1863AAB40", Slot = "18")]
	public void ADPIHHLENJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x63ACAE0", Offset = "0x63AB6E0", VA = "0x1863ACAE0", Slot = "21")]
	public void LNJDCLMNJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63AB7E0", Offset = "0x63AA3E0", VA = "0x1863AB7E0")]
	private void KNJOGAIIIAI(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x63AAE60", Offset = "0x63A9A60", VA = "0x1863AAE60")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DIKNILAGHJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63AAD50", Offset = "0x63A9950", VA = "0x1863AAD50")]
	private void OBFHNNKPFEI(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x63AB890", Offset = "0x63AA490", VA = "0x1863AB890")]
	private void PJLBHDMMAEJ(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63AAF50", Offset = "0x63A9B50", VA = "0x1863AAF50")]
	private Vector3 EHFEJJCOOKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63AB0F0", Offset = "0x63A9CF0", VA = "0x1863AB0F0", Slot = "15")]
	public void GPHLGFBABLC((Quaternion rot, Vector3 moments) KMLFOKBPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63AB660", Offset = "0x63AA260", VA = "0x1863AB660")]
	private Quaternion IHGJEPAKGOG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x63AB940", Offset = "0x63AA540", VA = "0x1863AB940")]
	public void LADLLHGCBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63ABA10", Offset = "0x63AA610", VA = "0x1863ABA10", Slot = "4")]
	public (float, Vector3) LADLLHGCBIO(Rigidbody JMIIEAMEOBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class NJHNDHGOPCB
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B3ED0", Offset = "0x63B2AD0", VA = "0x1863B3ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x639FA70", Offset = "0x639E670", VA = "0x18639FA70")]
	public GFBCKPCIFIJ(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x639F970", Offset = "0x639E570", VA = "0x18639F970", Slot = "4")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x639F5A0", Offset = "0x639E1A0", VA = "0x18639F5A0")]
	private bool FHDHEKEGDJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x639FA40", Offset = "0x639E640", VA = "0x18639FA40", Slot = "5")]
	public void OACOBDCKHGB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x639F570", Offset = "0x639E170", VA = "0x18639F570", Slot = "6")]
	public void FEDLOEEFJBP(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x639F7B0", Offset = "0x639E3B0", VA = "0x18639F7B0", Slot = "9")]
	public void JBLKMCFBKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x639F450", Offset = "0x639E050", VA = "0x18639F450")]
	private void EILCIKCCDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x639F640", Offset = "0x639E240", VA = "0x18639F640")]
	private void GMIJGIHDHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x639F8F0", Offset = "0x639E4F0", VA = "0x18639F8F0", Slot = "8")]
	public void LEBKMNKBKFA(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x639F930", Offset = "0x639E530", VA = "0x18639F930", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B4320", Offset = "0x63B2F20", VA = "0x1863B4320", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event OGOEIPLNHKB GPBFDBHNODC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x63B41D0", Offset = "0x63B2DD0", VA = "0x1863B41D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x63B4120", Offset = "0x63B2D20", VA = "0x1863B4120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x63B4410", Offset = "0x63B3010", VA = "0x1863B4410")]
	public NKHOCLONDNC(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x63B40B0", Offset = "0x63B2CB0", VA = "0x1863B40B0", Slot = "11")]
	public IDisposable GKBDEHJHPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x63B41C0", Offset = "0x63B2DC0", VA = "0x1863B41C0", Slot = "8")]
	public void HNBBAIDPKJG(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x63B40A0", Offset = "0x63B2CA0", VA = "0x1863B40A0", Slot = "9")]
	public void BPGIJLNAJEB(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x63B3F90", Offset = "0x63B2B90", VA = "0x1863B3F90", Slot = "10")]
	public void ABBDNHDIDAC(object KJCAGLABEME, bool IEPCDJKIMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x63B43D0", Offset = "0x63B2FD0", VA = "0x1863B43D0", Slot = "6")]
	public void PKDOINHLNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x63B4270", Offset = "0x63B2E70", VA = "0x1863B4270", Slot = "12")]
	public void MMMPLHKBEGG(Rigidbody IDJLKFJMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x63B42F0", Offset = "0x63B2EF0", VA = "0x1863B42F0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x639DB20", Offset = "0x639C720", VA = "0x18639DB20", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A4B10", Offset = "0x63A3710", VA = "0x1863A4B10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x63A4120", Offset = "0x63A2D20", VA = "0x1863A4120", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x63A4BB0", Offset = "0x63A37B0", VA = "0x1863A4BB0")]
	public IIBAEMHMKKN(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x63A4600", Offset = "0x63A3200", VA = "0x1863A4600", Slot = "9")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x63A4020", Offset = "0x63A2C20", VA = "0x1863A4020", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x63A49A0", Offset = "0x63A35A0", VA = "0x1863A49A0", Slot = "10")]
	public void OBCOPDEEFLK(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x63A4330", Offset = "0x63A2F30", VA = "0x1863A4330", Slot = "11")]
	public void FMMOEPHFAEE(CLILEGLKHIM HHNAEDAPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x63A41C0", Offset = "0x63A2DC0", VA = "0x1863A41C0")]
	private void FCODMEHCEOM(PhotonView KFHLGPCEJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x63A44A0", Offset = "0x63A30A0", VA = "0x1863A44A0")]
	private void KELGPNGFFHP(RigidbodyEx BDNPBMBDKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x63A4730", Offset = "0x63A3330", VA = "0x1863A4730")]
	private void NLEGMHOHKFJ(PhotonView KJFGFKCMNHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class CLOOJCHNHJA
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6392030", Offset = "0x6390C30", VA = "0x186392030")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CF0A80", Offset = "0x3CEF680", VA = "0x183CF0A80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CF0A70", Offset = "0x3CEF670", VA = "0x183CF0A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x63B4500", Offset = "0x63B3100", VA = "0x1863B4500", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x63B4690", Offset = "0x63B3290", VA = "0x1863B4690")]
	public NMHGPKFDKNF(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x63B4630", Offset = "0x63B3230", VA = "0x1863B4630", Slot = "9")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x63B4660", Offset = "0x63B3260", VA = "0x1863B4660", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x639FE00", Offset = "0x639EA00", VA = "0x18639FE00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x639FC40", Offset = "0x639E840", VA = "0x18639FC40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x639FED0", Offset = "0x639EAD0", VA = "0x18639FED0")]
	public GHJACJJMOHP(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x639FD10", Offset = "0x639E910", VA = "0x18639FD10", Slot = "8")]
	public void MMMPLHKBEGG(Rigidbody ABIICCJBIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x639FD60", Offset = "0x639E960", VA = "0x18639FD60", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x63A64D0", Offset = "0x63A50D0", VA = "0x1863A64D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x63A6620", Offset = "0x63A5220", VA = "0x1863A6620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private CLILEGLKHIM OCFNBALEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x63A6790", Offset = "0x63A5390", VA = "0x1863A6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool CJJMNNPCEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x63A6920", Offset = "0x63A5520", VA = "0x1863A6920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event OGOEIPLNHKB CNNIHNHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x63A6250", Offset = "0x63A4E50", VA = "0x1863A6250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x63A61B0", Offset = "0x63A4DB0", VA = "0x1863A61B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x63A6980", Offset = "0x63A5580", VA = "0x1863A6980")]
	public JHJIEMOKHLO(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x63A6890", Offset = "0x63A5490", VA = "0x1863A6890", Slot = "6")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x63A6610", Offset = "0x63A5210", VA = "0x1863A6610", Slot = "8")]
	public void HJHIJKPFBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x63A6640", Offset = "0x63A5240", VA = "0x1863A6640", Slot = "7")]
	public bool LOMNPEJHMAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x63A67F0", Offset = "0x63A53F0", VA = "0x1863A67F0", Slot = "9")]
	public void MOGJLPFBOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x63A6570", Offset = "0x63A5170", VA = "0x1863A6570", Slot = "11")]
	public void FLPCJPBDCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x63A6520", Offset = "0x63A5120", VA = "0x1863A6520", Slot = "12")]
	public void FDAAJBODNFO(bool BLKPFDLAGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x63A5E70", Offset = "0x63A4A70", VA = "0x1863A5E70", Slot = "10")]
	public void BLGDEGHEGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x63A62F0", Offset = "0x63A4EF0", VA = "0x1863A62F0")]
	private bool DOKACNHGHPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x63A6020", Offset = "0x63A4C20", VA = "0x1863A6020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6390E20", Offset = "0x638FA20", VA = "0x186390E20")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A14D0", Offset = "0x63A00D0", VA = "0x1863A14D0")]
	public HEBIJJGMIBM(CLILEGLKHIM NGEPMJPLOFK, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1400", Offset = "0x63A0000", VA = "0x1863A1400", Slot = "5")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x63A14A0", Offset = "0x63A00A0", VA = "0x1863A14A0", Slot = "7")]
	public void OEOPAAJBNBI(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x63A10A0", Offset = "0x639FCA0", VA = "0x1863A10A0", Slot = "8")]
	public void JGIPCLHFIPE(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x63A10D0", Offset = "0x639FCD0", VA = "0x1863A10D0", Slot = "9")]
	public void NEAHDEDOACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x63A0540", Offset = "0x639F140", VA = "0x1863A0540", Slot = "11")]
	public void BELMCIBIMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x63A0730", Offset = "0x639F330", VA = "0x1863A0730", Slot = "12")]
	public void CIGBACBOEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x63A08B0", Offset = "0x639F4B0", VA = "0x1863A08B0", Slot = "10")]
	public void DOMFCHGAJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D40", Offset = "0x639F940", VA = "0x1863A0D40")]
	private void EHAAIMGGOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x63A0EF0", Offset = "0x639FAF0", VA = "0x1863A0EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63BD7A0", Offset = "0x63BC3A0", VA = "0x1863BD7A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x63BDA30", Offset = "0x63BC630", VA = "0x1863BDA30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 GHDGEONJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x63BDAF0", Offset = "0x63BC6F0", VA = "0x1863BDAF0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x63BAE30", Offset = "0x63B9A30", VA = "0x1863BAE30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 HPJGDDMDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x63BAF40", Offset = "0x63B9B40", VA = "0x1863BAF40", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x63BC920", Offset = "0x63BB520", VA = "0x1863BC920", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 BCFOEPLGIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63BCE80", Offset = "0x63BBA80", VA = "0x1863BCE80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63BD500", Offset = "0x63BC100", VA = "0x1863BD500", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x63BB1C0", Offset = "0x63B9DC0", VA = "0x1863BB1C0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CB66B0", Offset = "0x1CB52B0", VA = "0x181CB66B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool NHOFHEPJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x63B02F0", Offset = "0x63AEEF0", VA = "0x1863B02F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x63BDD70", Offset = "0x63BC970", VA = "0x1863BDD70")]
	public EJCOJPJMEEK(CLILEGLKHIM NGEPMJPLOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63BAD80", Offset = "0x63B9980", VA = "0x1863BAD80", Slot = "19")]
	public void NGFNEFGPKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x63BC220", Offset = "0x63BAE20", VA = "0x1863BC220", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x63BD530", Offset = "0x63BC130", VA = "0x1863BD530", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x63BD8C0", Offset = "0x63BC4C0", VA = "0x1863BD8C0", Slot = "35")]
	public Vector3 NDHGDCCEKPP(Vector3 BHLFPCKJLFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x63BC0D0", Offset = "0x63BACD0", VA = "0x1863BC0D0", Slot = "34")]
	public Vector3 DMHHHKBFKKE(Vector3 PMHHDDKKDHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x63BAD80", Offset = "0x63B9980", VA = "0x1863BAD80", Slot = "27")]
	public void AADAGEFKAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x63BD4A0", Offset = "0x63BC0A0", VA = "0x1863BD4A0", Slot = "25")]
	public void LCOLOHKDNLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x63BDBE0", Offset = "0x63BC7E0", VA = "0x1863BDBE0", Slot = "24")]
	public void OMLOLFNJDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x63BD600", Offset = "0x63BC200", VA = "0x1863BD600", Slot = "33")]
	public void MPMBPGLMCHH(Vector3 PJAHABGLKFL, Vector3 DJANBADIBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x63BC9E0", Offset = "0x63BB5E0", VA = "0x1863BC9E0", Slot = "32")]
	public void EPMOFPMGMJF(Vector3 KPIPFDNKPJA, Vector3 HAGKOPCILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x63BBCD0", Offset = "0x63BA8D0", VA = "0x1863BBCD0", Slot = "31")]
	public void DHPGMPPFKMM(Vector3 AMIFBDPJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x63BC2F0", Offset = "0x63BAEF0", VA = "0x1863BC2F0", Slot = "22")]
	public void EAMADICEOFH(ICHLBMNNNNE NPFHGLCMEJO, Vector3 GBPOABOPAIF, float JALOGBPFLGE, float HMFHLCFOHKD = 8f, float IEMGNMEBJCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x63BBE40", Offset = "0x63BAA40", VA = "0x1863BBE40", Slot = "21")]
	public void DLJFFJFDDIC(LKBNAALOLPJ CFLKCNIHPBG, Vector3 OLNHEMAINIF, float ECIMKFPODPC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x63BCF70", Offset = "0x63BBB70", VA = "0x1863BCF70", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JHEMOGLJICI(LKBNAALOLPJ CFLKCNIHPBG, Vector3 HFKFMHAMLPE, float LIOOJPIIFMM = 7f, float NFGDCPMPLPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x63BB060", Offset = "0x63B9C60", VA = "0x1863BB060", Slot = "29")]
	public Vector3 CBABHGJJPKF(Vector3 OAAOAKNCDMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x63BDC40", Offset = "0x63BC840", VA = "0x1863BDC40", Slot = "26")]
	public void OOOAOLIDEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x63BB1C0", Offset = "0x63B9DC0", VA = "0x1863BB1C0")]
	private void CMBPFKHCHEE(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x63BB6D0", Offset = "0x63BA2D0", VA = "0x1863BB6D0")]
	private void DCBNDJBMBCH(Vector3 OLNHEMAINIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE60", Offset = "0x63B9A60", VA = "0x1863BAE60")]
	private Vector3 BBCFODFLNIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x63BB270", Offset = "0x63B9E70", VA = "0x1863BB270")]
	private void CMMNNGGKIMB(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x63BD3C0", Offset = "0x63BBFC0", VA = "0x1863BD3C0")]
	private Vector3 KLMACOIEGDJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x63BCA40", Offset = "0x63BB640", VA = "0x1863BCA40")]
	private void HBHCEEOLJBP(Vector3 GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x63BB840", Offset = "0x63BA440", VA = "0x1863BB840")]
	private void DGCMNFFBELI(Vector3 PMHHDDKKDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x63BD310", Offset = "0x63BBF10", VA = "0x1863BD310")]
	private void JJDMOCOPHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JLOFGHIKBOP : POEPMBPGKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x63BE340", Offset = "0x63BCF40", VA = "0x1863BE340", Slot = "4")]
	public EEIHPONFIOE KINCOHNPLAJ(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE80", Offset = "0x63BCA80", VA = "0x1863BDE80", Slot = "5")]
	public KCMLKLODAPB DPJPBPFANHC(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x63BE270", Offset = "0x63BCE70", VA = "0x1863BE270", Slot = "6")]
	public PIPBDGDHDEJ ICLNLFLHMAD(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x63BE470", Offset = "0x63BD070", VA = "0x1863BE470", Slot = "7")]
	public CHDOPAMEKNL NENEOBKJOAE(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x63BE410", Offset = "0x63BD010", VA = "0x1863BE410", Slot = "8")]
	public MEKLFNOFPOO NCPPJPEGMDA(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x63BE210", Offset = "0x63BCE10", VA = "0x1863BE210", Slot = "9")]
	public BENFKCACMDO HLKPKHCAJJM(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x63BE4D0", Offset = "0x63BD0D0", VA = "0x1863BE4D0", Slot = "10")]
	public LBEMOOJEDNP PEMHJLOKAOH(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x63BE1B0", Offset = "0x63BCDB0", VA = "0x1863BE1B0", Slot = "11")]
	public AHLABJLGKJI HFLEHKPEMDI(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x63BE0E0", Offset = "0x63BCCE0", VA = "0x1863BE0E0", Slot = "12")]
	public KGCLDJCOPKE GBFEDLEAPKK(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x63BE080", Offset = "0x63BCC80", VA = "0x1863BE080", Slot = "13")]
	public GFAEJIJOIIM FHIBEBPMCCB(CLILEGLKHIM OGDBMIPIOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x63BE2D0", Offset = "0x63BCED0", VA = "0x1863BE2D0")]
	public IHCLONJPHBC LNDFMADCDIN(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE10", Offset = "0x63BCA10", VA = "0x1863BDE10")]
	public KICNEDMPOBN FOIPPIOIDIP(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x63BE140", Offset = "0x63BCD40", VA = "0x1863BE140")]
	public NNGGKLPDBGF INDEDMIJMOM(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x63BE3A0", Offset = "0x63BCFA0", VA = "0x1863BE3A0")]
	public KMICGGOIAGK MCHFNFOGFLF(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x63BDF60", Offset = "0x63BCB60", VA = "0x1863BDF60")]
	public OFECNLJJPMK EPGNKMACJCD(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x63BDFD0", Offset = "0x63BCBD0", VA = "0x1863BDFD0", Slot = "19")]
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
	[Cpp2IlInjected.Address(RVA = "0x63BE2D0", Offset = "0x63BCED0", VA = "0x1863BE2D0", Slot = "14")]
	private IHCLONJPHBC IJNHOLLHKBG(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x63BDE10", Offset = "0x63BCA10", VA = "0x1863BDE10", Slot = "15")]
	private KICNEDMPOBN BDNJIINNDOO(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x63BE140", Offset = "0x63BCD40", VA = "0x1863BE140", Slot = "16")]
	private NNGGKLPDBGF GELJJCJLBJL(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x63BE3A0", Offset = "0x63BCFA0", VA = "0x1863BE3A0", Slot = "17")]
	private KMICGGOIAGK MOJGOHMCLJC(CLILEGLKHIM OGDBMIPIOMM, [In] AKGLBOOOAME IGJLGPELHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x63BDF60", Offset = "0x63BCB60", VA = "0x1863BDF60", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x63BE530", Offset = "0x63BD130", VA = "0x1863BE530", Slot = "6")]
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
