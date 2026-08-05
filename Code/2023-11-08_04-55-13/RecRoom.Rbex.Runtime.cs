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
public delegate void ADLOFIFALML(RigidbodyEx NDDAJNAOOJK);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void FIODGJBLMML(RigidbodyEx NDDAJNAOOJK, bool GJMMOFEDCKI = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum COPIBMJGLBC
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
public enum EFGFMNNGGFP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LFGDMPDDINM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PLLADOOKFGO(typeof(FEKNCLKDIMC), new string[] { "Ignore", "Mock" })]
public class PHCENKBILMG : FEKNCLKDIMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EPKAMNFNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C3260", Offset = "0x7C2060", VA = "0x1807C3260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
	public void LBFFIPKKNOL(string LMJIIJBFLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
	public void CBMPIJKIIBK(RigidbodyEx GKOAICANGAP, Action CBNAIFNPGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "7")]
	public IIHHOFKBIHF GBIGMMBDGEL(int BIDGIBMAFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "8")]
	public void LPJFGLLDIHN(Vector3 FBPBOFJFCJG, float DEHBOBDJFFC, Color HBLLOHAOGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PHCENKBILMG()
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
		private static readonly BOGDNAKJHCL IILEBPAEFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool LBELCFKFKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EMCMNBFGMOJ MHPOANLMMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[BICPFBOLGLL(CDIJBINDLCN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[BICPFBOLGLL(CDIJBINDLCN.SelfAndParent, true, false, false)]
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
		private EFGFMNNGGFP physicsInterpolation;

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
		internal EMCMNBFGMOJ ENJHNCFKIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x638E750", Offset = "0x638D550", VA = "0x18638E750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> KEEMEJDOOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x76FF20", Offset = "0x76ED20", VA = "0x18076FF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x76FF30", Offset = "0x76ED30", VA = "0x18076FF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx GOKEEJICLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63909E0", Offset = "0x638F7E0", VA = "0x1863909E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CGOPDPOJACK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6390940", Offset = "0x638F740", VA = "0x186390940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BMNEKBHDGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6391600", Offset = "0x6390400", VA = "0x186391600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6392B80", Offset = "0x6391980", VA = "0x186392B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform NHMGKKHNEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7985A0", Offset = "0x7973A0", VA = "0x1807985A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform NLDJFIKBOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7985A0", Offset = "0x7973A0", VA = "0x1807985A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NPEDCJCPBDB AMLGFINMNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6390700", Offset = "0x638F500", VA = "0x186390700")]
			get
			{
				return default(NPEDCJCPBDB);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6392330", Offset = "0x6391130", VA = "0x186392330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DFPNLCKAGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6390C90", Offset = "0x638FA90", VA = "0x186390C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PPGMAIOCNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6390820", Offset = "0x638F620", VA = "0x186390820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ANOMGEJPJNN BGBGODEJIPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6390BD0", Offset = "0x638F9D0", VA = "0x186390BD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63924F0", Offset = "0x63912F0", VA = "0x1863924F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PCFACBMAEKA PCPIKHINFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6390B70", Offset = "0x638F970", VA = "0x186390B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6392480", Offset = "0x6391280", VA = "0x186392480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KHBKNPPAJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6390AC0", Offset = "0x638F8C0", VA = "0x186390AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody PDOCOAKHMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6390B20", Offset = "0x638F920", VA = "0x186390B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DCBCEHHGOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6390880", Offset = "0x638F680", VA = "0x186390880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63923A0", Offset = "0x63911A0", VA = "0x1863923A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BDEMCCGBHJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1AE1600", Offset = "0x1AE0400", VA = "0x181AE1600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5BC5320", Offset = "0x5BC4120", VA = "0x185BC5320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float NEPNGFCGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63915A0", Offset = "0x63903A0", VA = "0x1863915A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KFCMPEFKJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6391540", Offset = "0x6390340", VA = "0x186391540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6392B10", Offset = "0x6391910", VA = "0x186392B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JPHBLGKAJDC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6390EF0", Offset = "0x638FCF0", VA = "0x186390EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6392790", Offset = "0x6391590", VA = "0x186392790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LGEDOIMNJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6390CF0", Offset = "0x638FAF0", VA = "0x186390CF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6392560", Offset = "0x6391360", VA = "0x186392560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KHFFOOMCEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6391B60", Offset = "0x6390960", VA = "0x186391B60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63930E0", Offset = "0x6391EE0", VA = "0x1863930E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 IEILMELOIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6391320", Offset = "0x6390120", VA = "0x186391320")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63928E0", Offset = "0x63916E0", VA = "0x1863928E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 FBPBOFJFCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6391CA0", Offset = "0x6390AA0", VA = "0x186391CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode OLDJBELDEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6390E30", Offset = "0x638FC30", VA = "0x186390E30")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63926B0", Offset = "0x63914B0", VA = "0x1863926B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float DNILLMAMIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63908E0", Offset = "0x638F6E0", VA = "0x1863908E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6392410", Offset = "0x6391210", VA = "0x186392410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints JNMHKCCLGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6390E90", Offset = "0x638FC90", VA = "0x186390E90")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6392720", Offset = "0x6391520", VA = "0x186392720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 KHHKKANKIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63916A0", Offset = "0x63904A0", VA = "0x1863916A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 KEGNFLJIOLN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63916A0", Offset = "0x63904A0", VA = "0x1863916A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6392EC0", Offset = "0x6391CC0", VA = "0x186392EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FHDPCEHPCDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6391400", Offset = "0x6390200", VA = "0x186391400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63929C0", Offset = "0x63917C0", VA = "0x1863929C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BAEBKJICGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6391B00", Offset = "0x6390900", VA = "0x186391B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6393070", Offset = "0x6391E70", VA = "0x186393070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion KJDCFBJFPAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6391780", Offset = "0x6390580", VA = "0x186391780")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6392C40", Offset = "0x6391A40", VA = "0x186392C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion KDGIDPOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6391A20", Offset = "0x6390820", VA = "0x186391A20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6392FA0", Offset = "0x6391DA0", VA = "0x186392FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 ALNLNBMDGGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6391860", Offset = "0x6390660", VA = "0x186391860")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6392D10", Offset = "0x6391B10", VA = "0x186392D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion EFCBIMLHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6391940", Offset = "0x6390740", VA = "0x186391940")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6392DF0", Offset = "0x6391BF0", VA = "0x186392DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 MAEAAOMNFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6391BC0", Offset = "0x63909C0", VA = "0x186391BC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6393150", Offset = "0x6391F50", VA = "0x186393150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 OIMALFIAIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6391460", Offset = "0x6390260", VA = "0x186391460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6392A30", Offset = "0x6391830", VA = "0x186392A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 GEOFLKGAFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6390D50", Offset = "0x638FB50", VA = "0x186390D50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63925D0", Offset = "0x63913D0", VA = "0x1863925D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DHNAJHLJMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6391240", Offset = "0x6390040", VA = "0x186391240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6392800", Offset = "0x6391600", VA = "0x186392800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 NPFFHGENMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6391100", Offset = "0x638FF00", VA = "0x186391100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion IDPHMLELMDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6391020", Offset = "0x638FE20", VA = "0x186391020")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 HDDAOHHOKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6391E60", Offset = "0x6390C60", VA = "0x186391E60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 EDNAECINFPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6391D80", Offset = "0x6390B80", VA = "0x186391D80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EAIFPNLJNBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63911E0", Offset = "0x638FFE0", VA = "0x1863911E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MOHFJANAFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6390C30", Offset = "0x638FA30", VA = "0x186390C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HJHBFFELHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63907C0", Offset = "0x638F5C0", VA = "0x1863907C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OOLLCENLCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6390760", Offset = "0x638F560", VA = "0x186390760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CFBAHGPOLBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63906A0", Offset = "0x638F4A0", VA = "0x1863906A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IEPCGOCNGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6390F50", Offset = "0x638FD50", VA = "0x186390F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool LNODLGKLEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4D10", Offset = "0x4FA3B10", VA = "0x184FA4D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ADLOFIFALML JPDNEJGOGCO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63905C0", Offset = "0x638F3C0", VA = "0x1863905C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6392250", Offset = "0x6391050", VA = "0x186392250")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FIODGJBLMML BPEIKDNIBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6390550", Offset = "0x638F350", VA = "0x186390550")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63921E0", Offset = "0x6390FE0", VA = "0x1863921E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ADLOFIFALML CILDKJKODFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63902B0", Offset = "0x638F0B0", VA = "0x1863902B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6391F40", Offset = "0x6390D40", VA = "0x186391F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ADLOFIFALML CECNOPEHLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6390320", Offset = "0x638F120", VA = "0x186390320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6391FB0", Offset = "0x6390DB0", VA = "0x186391FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ADLOFIFALML HMBIILCIIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6390470", Offset = "0x638F270", VA = "0x186390470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6392100", Offset = "0x6390F00", VA = "0x186392100")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6390400", Offset = "0x638F200", VA = "0x186390400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6392090", Offset = "0x6390E90", VA = "0x186392090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ADLOFIFALML MDJAPJKCDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63904E0", Offset = "0x638F2E0", VA = "0x1863904E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6392170", Offset = "0x6390F70", VA = "0x186392170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ADLOFIFALML FNODIPAHMIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6390630", Offset = "0x638F430", VA = "0x186390630")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63922C0", Offset = "0x63910C0", VA = "0x1863922C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ADLOFIFALML IINDPIONGNG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6390390", Offset = "0x638F190", VA = "0x186390390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6392020", Offset = "0x6390E20", VA = "0x186392020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
		internal void AJAHAEDHIAG(EMCMNBFGMOJ DDAGOAKHODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x638EC60", Offset = "0x638DA60", VA = "0x18638EC60")]
		internal void IGNBKIIINAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x638FFD0", Offset = "0x638EDD0", VA = "0x18638FFD0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LMDPCNCNMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x638FCA0", Offset = "0x638EAA0", VA = "0x18638FCA0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) ABHEAGLOLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x638E6E0", Offset = "0x638D4E0", VA = "0x18638E6E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x638E750", Offset = "0x638D550", VA = "0x18638E750")]
		private EMCMNBFGMOJ OIJADGLOKCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x638F1A0", Offset = "0x638DFA0", VA = "0x18638F1A0")]
		private void PDINACCMPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x638F0E0", Offset = "0x638DEE0", VA = "0x18638F0E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x638EC60", Offset = "0x638DA60", VA = "0x18638EC60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x638F080", Offset = "0x638DE80", VA = "0x18638F080")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x638F140", Offset = "0x638DF40", VA = "0x18638F140")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x638DD90", Offset = "0x638CB90", VA = "0x18638DD90")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x638F530", Offset = "0x638E330", VA = "0x18638F530")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x638E9E0", Offset = "0x638D7E0", VA = "0x18638E9E0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x638F020", Offset = "0x638DE20", VA = "0x18638F020")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x638FE00", Offset = "0x638EC00", VA = "0x18638FE00")]
		public void SetParent(RigidbodyEx PHPDIJICBJO, bool GJMMOFEDCKI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x638F840", Offset = "0x638E640", VA = "0x18638F840")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x638ECF0", Offset = "0x638DAF0", VA = "0x18638ECF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GIBIJGOFICG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x638EDD0", Offset = "0x638DBD0", VA = "0x18638EDD0")]
		public bool IsRigidbodyDescendant(RigidbodyEx ABBIAOKMJBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x638E000", Offset = "0x638CE00", VA = "0x18638E000")]
		public void AddInterpolationRestriction(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x638F5A0", Offset = "0x638E3A0", VA = "0x18638F5A0")]
		public void RemoveInterpolationRestriction(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x638E800", Offset = "0x638D600", VA = "0x18638E800")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x638E070", Offset = "0x638CE70", VA = "0x18638E070")]
		public void AddKinematic(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x638F610", Offset = "0x638E410", VA = "0x18638F610")]
		public void RemoveKinematic(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x638FD80", Offset = "0x638EB80", VA = "0x18638FD80")]
		public void SetKinematic(object HOBAPMCPFML, bool MOOGEOGEGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x638FBA0", Offset = "0x638E9A0", VA = "0x18638FBA0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MGBDBMNHBCL, Quaternion BMICPHIEDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x638FAA0", Offset = "0x638E8A0", VA = "0x18638FAA0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 BCCGBAKEOMJ, Quaternion HBPKBIAHANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x638EB50", Offset = "0x638D950", VA = "0x18638EB50")]
		public Vector3 GetConstrainedVelocity(Vector3 MAEAAOMNFME)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x638EA40", Offset = "0x638D840", VA = "0x18638EA40")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 GEOFLKGAFKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x638DF10", Offset = "0x638CD10", VA = "0x18638DF10")]
		public void AddForce(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x638DE00", Offset = "0x638CC00", VA = "0x18638DE00")]
		public void AddForceAtPosition(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x638E240", Offset = "0x638D040", VA = "0x18638E240")]
		public void AddTorque(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x638E0E0", Offset = "0x638CEE0", VA = "0x18638E0E0")]
		public void AddRelativeTorque(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63900A0", Offset = "0x638EEA0", VA = "0x1863900A0")]
		public Vector3 WorldToLocalVelocity(Vector3 BOBGPABDLGJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x638EF10", Offset = "0x638DD10", VA = "0x18638EF10")]
		public Vector3 LocalToWorldVelocity(Vector3 OIMALFIAIDE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x638E980", Offset = "0x638D780", VA = "0x18638E980")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x638E920", Offset = "0x638D720", VA = "0x18638E920")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x638E8C0", Offset = "0x638D6C0", VA = "0x18638E8C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x638E860", Offset = "0x638D660", VA = "0x18638E860")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x638F9A0", Offset = "0x638E7A0", VA = "0x18638F9A0")]
		public void ResetVelocityWorldSpace(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x638F8A0", Offset = "0x638E6A0", VA = "0x18638F8A0")]
		public void ResetVelocityLocalSpace(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x638F760", Offset = "0x638E560", VA = "0x18638F760")]
		public void ResetLinearVelocityLocalSpace(Vector3 DIFHGPOEKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x638FF30", Offset = "0x638ED30", VA = "0x18638FF30")]
		public bool SweepTest(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x638EEB0", Offset = "0x638DCB0", VA = "0x18638EEB0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x638FED0", Offset = "0x638ECD0", VA = "0x18638FED0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6390040", Offset = "0x638EE40", VA = "0x186390040")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x638E1D0", Offset = "0x638CFD0", VA = "0x18638E1D0")]
		public void AddShouldHaveUnityRigidbodyToken(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x638F680", Offset = "0x638E480", VA = "0x18638F680")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x638E570", Offset = "0x638D370", VA = "0x18638E570")]
		public void ApplyForceVelocityChange(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x638E4D0", Offset = "0x638D2D0", VA = "0x18638E4D0")]
		public void ApplyAngularVelocityChange(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x638E630", Offset = "0x638D430", VA = "0x18638E630")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x638E400", Offset = "0x638D200", VA = "0x18638E400")]
		public bool AllowedScaleChange(float LKLBEHBFPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x638E330", Offset = "0x638D130", VA = "0x18638E330")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HIMGCOMGJBC, object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x638F6F0", Offset = "0x638E4F0", VA = "0x18638F6F0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HOBAPMCPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6390240", Offset = "0x638F040", VA = "0x186390240")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class CLMJPDGPMNO
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x636AAB0", Offset = "0x63698B0", VA = "0x18636AAB0")]
	public static EMCMNBFGMOJ ENJHNCFKIFK(this RigidbodyEx GKOAICANGAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EDIDBFLBAIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody FAMGBCAKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView FGKNBKAADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 KEIIMOLPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 IPLNPLMJHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EFGFMNNGGFP GPNGHPLKPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool AAKBOJMHNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool LEMLOHIBOCN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PLLADOOKFGO(typeof(HOIBMFNJHPD), new string[] { })]
public class DAJJIGPHJFG : HOIBMFNJHPD, ECOFDNFPFFG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly BOGDNAKJHCL BNIILMIMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BNLOPGCJCAK KLCMDPANGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FEKNCLKDIMC GPBKPNHGBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MCDLIBHCKMK HNLEBFFJDHB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FEKNCLKDIMC NHCKKAMNPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MCDLIBHCKMK JJMFCHAFPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x636BA90", Offset = "0x636A890", VA = "0x18636BA90", Slot = "8")]
	public void InitReferences(DFLOIMJPFAA KDACNGHEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x636B7E0", Offset = "0x636A5E0", VA = "0x18636B7E0", Slot = "6")]
	public ICMPCFCEMJM GPNIDJGDDCN(RigidbodyEx GKOAICANGAP)
	{
		return default(ICMPCFCEMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x636BB20", Offset = "0x636A920", VA = "0x18636BB20")]
	private static ICMPCFCEMJM KFLGFKCFIGD(RigidbodyEx GKOAICANGAP)
	{
		return default(ICMPCFCEMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x636BBF0", Offset = "0x636A9F0", VA = "0x18636BBF0", Slot = "7")]
	public EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DAJJIGPHJFG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static INNFNKFCEKE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int MAHDMKINIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int JLKBDJLFNFH;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x638DBF0", Offset = "0x638C9F0", VA = "0x18638DBF0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x638DC30", Offset = "0x638CA30", VA = "0x18638DC30")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x638DC10", Offset = "0x638CA10", VA = "0x18638DC10")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KHIFMDJDLEG, [Optional] UnityEngine.Object GMIADHJEACD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KHIFMDJDLEG, [Optional] UnityEngine.Object GMIADHJEACD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x638DD40", Offset = "0x638CB40", VA = "0x18638DD40")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GAHOIEJJAIL
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6374F10", Offset = "0x6373D10", VA = "0x186374F10")]
	public static void OMIJKFHGELK(this Rigidbody LMDPCNCNMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63750A0", Offset = "0x6373EA0", VA = "0x1863750A0")]
	public static void OMIJKFHGELK(this Rigidbody LMDPCNCNMIH, Vector3 DFNLCDOAONI, Quaternion IDPHMLELMDP, Vector3 MAENEKIKHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB931A0", Offset = "0xB91FA0", VA = "0x180B931A0")]
	public static void KHCAFHLECHO(Vector3 MAEAAOMNFME, Vector3 PPEOGMAIJEH, [Out] Vector3 HBNLLNFMBNM, [Out] Vector3 MHBAHECHPLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FHJGMLCHGLO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class KCDLCCHGKDK : ANOMGEJPJNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x77F990", Offset = "0x77E790", VA = "0x18077F990", Slot = "4")]
		public Vector3 ALAAOEJMNAD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x77F990", Offset = "0x77E790", VA = "0x18077F990", Slot = "5")]
		public Vector3 DALAGMNOGAO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public KCDLCCHGKDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static ANOMGEJPJNN GMJFNPPAEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6374D40", Offset = "0x6373B40", VA = "0x186374D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NBIOCGFCHNB
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode KMLICJMEANH
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
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJIEBMGDOKL(bool EAIFPNLJNBE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOBCADEFFEN(bool EAIFPNLJNBE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GAIKMIPBMEJ : IDisposable, ILIICCDHOOB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAIBKGFNFNH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface MCDLIBHCKMK
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAGCAHIOFOP KEBDCNFDDKC(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PINEELOCNCE CNMCOJOMHGO(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IIOPHLLHJLP NEJLKPFFJDK(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BONLMHAGDFE OHHLCLBFMPK(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FANHOHBHDML GJPLCHOCPFA(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GAIKMIPBMEJ KECDNNHGOFH(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HLBLIKOPBKE JLKHOICOFKJ(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CBHAPCHGCLF ODEKABJAHGI(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NBIOCGFCHNB LBICFLLECIK(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NGHLNFILAAA PHBIILBFPPG(EMCMNBFGMOJ DDAGOAKHODP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NLELMMAENGH AHIHFMCKLNA(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FOOLOBIMAJA CKBBNCCHKJF(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BHDHMDJKJKI ANNLDOPNBJD(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GGBBHEDCLGE IAEABBEMICJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AFFFHOOGEHK MJNJGFCAADJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC, HOIBMFNJHPD LBHKILDBCNO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CBHAPCHGCLF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NGHLNFILAAA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AJHNFMKDJGH
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
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJCJJADNAJH(Rigidbody FAMGBCAKFFC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MAGCAHIOFOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ADLOFIFALML CILDKJKODFE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event ADLOFIFALML CECNOPEHLPI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event FIODGJBLMML NIJDMINIGCI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HBJJLNKGLME;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action DGFIBHHOPPO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<EMCMNBFGMOJ> GFJKMPFCNBO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<EMCMNBFGMOJ> EGAIBMKCEIO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action KAIJPFLCLBJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<EMCMNBFGMOJ> PACGAAMOJHG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IFKFCKDOJJB(EMCMNBFGMOJ BNOFKPJBDLH, bool GJMMOFEDCKI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IIOPHLLHJLP
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOBDONLLNDC(EMCMNBFGMOJ BMNEKBHDGLJ, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALGIAFCMNHH(object HOBAPMCPFML);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GGBBHEDCLGE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ADLOFIFALML LFFAALNOPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HDGODKPGCGJ();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PKFJKIAODLK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DKFKMLKCLAC();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HJCJJADNAJH(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JFCGIAEMMJK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BHDHMDJKJKI
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBPLFFODBGI(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJECEBPLDMI(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJOHHEAJCOG(EMCMNBFGMOJ GKOAICANGAP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNHPLDFHOOH(EMCMNBFGMOJ GKOAICANGAP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEHCJJHJIOF();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HLBLIKOPBKE
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ADLOFIFALML OKBNOPNGHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJIGGBDAAKP();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCEDHLFDABL(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKFBAFAINKO(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable FGFBBPKLBGG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ICJDCDNGPJB(Rigidbody EIODOLNINOL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HJCJJADNAJH(Rigidbody FAMGBCAKFFC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FOOLOBIMAJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ADLOFIFALML JLKKFJLKABL;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCNEHDKFDOC(EMCMNBFGMOJ BMNEKBHDGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFCCJHIBMFG(EMCMNBFGMOJ BMNEKBHDGLJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AFFFHOOGEHK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LFJFEBCNDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints HJLMJCJKMJH
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
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJCJJADNAJH(Rigidbody FAMGBCAKFFC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BONLMHAGDFE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float ACICDEAJDGK
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
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJCJJADNAJH(Rigidbody FAMGBCAKFFC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FIHBHDHCJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx IGBJPKFKNME);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FANHOHBHDML
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event ADLOFIFALML MPCFCPDAGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLJANFJFEMD();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKCHGGIFKOA();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJFKBEBNLPM();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CILCIHEOIMI();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLDGMKJDBGI();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LCPNCLELBKA(bool OAKMGPFAMEK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NLELMMAENGH
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool PHJAAPKPCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLKDAJOCJHI(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMPBJANDFLE(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FANCOGLAPLO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJCHPOPNLGC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PINEELOCNCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LEKJJFIIPBG(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EJILHHACMPM();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void APNECOMFKNO();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PEONNDNLACN();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MMFKCDJPKBB();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MCAJKEFGHGP(Vector3 MAEAAOMNFME);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IKDOBOJHBBP(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface FEKNCLKDIMC
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool EPKAMNFNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBFFIPKKNOL(string LMJIIJBFLBD);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBMPIJKIIBK(RigidbodyEx GKOAICANGAP, Action CBNAIFNPGEI);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIHHOFKBIHF GBIGMMBDGEL(int BIDGIBMAFFL);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPJFGLLDIHN(Vector3 FBPBOFJFCJG, float DEHBOBDJFFC, Color HBLLOHAOGDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HOIBMFNJHPD
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	FEKNCLKDIMC NHCKKAMNPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MCDLIBHCKMK JJMFCHAFPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICMPCFCEMJM GPNIDJGDDCN(RigidbodyEx GKOAICANGAP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface PCFACBMAEKA
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLPELOGCHOL(Vector3 OEAJIDJPGJM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKCDPMIDEPE(Vector3 GEOFLKGAFKA);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEIPKMHBHMG(Vector3 OEAJIDJPGJM);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGNPFBGIDFH(Vector3 GEOFLKGAFKA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface ANOMGEJPJNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 ALAAOEJMNAD();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DALAGMNOGAO();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EMCMNBFGMOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx NMEIEBBHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject DCHEMEBLILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool OOLLCENLCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool CFBAHGPOLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float ACICDEAJDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool AJHNFMKDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform NLDJFIKBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 LEDDGOIJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float MHBNHKHGICB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float FBKAFJDIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion OMBICKMAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints HJLMJCJKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode KMLICJMEANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool MOHFJANAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event ADLOFIFALML CILDKJKODFE;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event ADLOFIFALML CECNOPEHLPI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FIODGJBLMML NIJDMINIGCI;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event ADLOFIFALML JLKKFJLKABL;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event ADLOFIFALML HMBIILCIIPC;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event ADLOFIFALML MPCFCPDAGHJ;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event ADLOFIFALML OKBNOPNGHDJ;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event ADLOFIFALML IINDPIONGNG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void HAIBKGFNFNH();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void CCCABCCBJJM();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void OLFMDOOHMKB();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void FJFKBEBNLPM();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void IFKFCKDOJJB(EMCMNBFGMOJ PHPDIJICBJO, bool GJMMOFEDCKI = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void JFGEKFFBKLP(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void JDKPNCDGBHF(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void MMFKCDJPKBB();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void APNECOMFKNO();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void EJILHHACMPM();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 MCAJKEFGHGP(Vector3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 NDAELPKDHGC(Vector3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PEONNDNLACN();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PBOJOIKAKPL(EMCMNBFGMOJ HIMGCOMGJBC, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void GCKGNEDHCBH(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PKFJKIAODLK();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HDGODKPGCGJ();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void DKFKMLKCLAC();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool PLJANFJFEMD();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void KLDGMKJDBGI();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable FGFBBPKLBGG();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void MCEDHLFDABL(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void JKFBAFAINKO(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MMKOIPOMFGO(Vector3 MGBDBMNHBCL, Quaternion BMICPHIEDJB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HPPMPGOJBJC(Vector3 BCCGBAKEOMJ, Quaternion HBPKBIAHANO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool HPKOELONGPM(float LKLBEHBFPBB);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CKOJANFOPOD(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JEJHFHHEBJM(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LLKDAJOCJHI(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FMPBJANDFLE(object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JFCGIAEMMJK();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LMDCMFOLAIH : EMCMNBFGMOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly HOIBMFNJHPD LBHKILDBCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal MAGCAHIOFOP CDCNCPAONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BHDHMDJKJKI OBKGGLMPKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FOOLOBIMAJA MHHLLNKGACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PINEELOCNCE MAEAAOMNFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IIOPHLLHJLP CKKLAKHIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal GGBBHEDCLGE NIHLOGFCJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal BONLMHAGDFE GPDCKGEKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal NGHLNFILAAA MBPCEOOJINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal FANHOHBHDML JHEEAAMDMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal GAIKMIPBMEJ CGLKJFAGICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal HLBLIKOPBKE JLEGJPGBHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CBHAPCHGCLF OOFPOBCGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal AFFFHOOGEHK OCAJDBAFNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal NLELMMAENGH FAMGBCAKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal NBIOCGFCHNB CDEOCGAAIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable FLDNBDEKAEI;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx NMEIEBBHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773300", VA = "0x180774500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7745A0", Offset = "0x7733A0", VA = "0x1807745A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject DCHEMEBLILM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F7440", Offset = "0x7F6240", VA = "0x1807F7440", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F7500", Offset = "0x7F6300", VA = "0x1807F7500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63857B0", Offset = "0x63845B0", VA = "0x1863857B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6380EB0", Offset = "0x637FCB0", VA = "0x186380EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6382790", Offset = "0x6381590", VA = "0x186382790", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63807D0", Offset = "0x637F5D0", VA = "0x1863807D0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63836E0", Offset = "0x63824E0", VA = "0x1863836E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6384490", Offset = "0x6383290", VA = "0x186384490", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6383A80", Offset = "0x6382880", VA = "0x186383A80", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x63837F0", Offset = "0x63825F0", VA = "0x1863837F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6385BD0", Offset = "0x63849D0", VA = "0x186385BD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6383840", Offset = "0x6382640", VA = "0x186383840", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6385F10", Offset = "0x6384D10", VA = "0x186385F10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x63849F0", Offset = "0x63837F0", VA = "0x1863849F0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6382230", Offset = "0x6381030", VA = "0x186382230", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6381D80", Offset = "0x6380B80", VA = "0x186381D80", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6385B70", Offset = "0x6384970", VA = "0x186385B70", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6381CA0", Offset = "0x6380AA0", VA = "0x186381CA0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6383390", Offset = "0x6382190", VA = "0x186383390", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6385D50", Offset = "0x6384B50", VA = "0x186385D50", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6386300", Offset = "0x6385100", VA = "0x186386300", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6381F90", Offset = "0x6380D90", VA = "0x186381F90", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x63842F0", Offset = "0x63830F0", VA = "0x1863842F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6382A80", Offset = "0x6381880", VA = "0x186382A80", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6382ED0", Offset = "0x6381CD0", VA = "0x186382ED0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool HJHBFFELHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6381BF0", Offset = "0x63809F0", VA = "0x186381BF0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OOLLCENLCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x63848A0", Offset = "0x63836A0", VA = "0x1863848A0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CFBAHGPOLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6380D50", Offset = "0x637FB50", VA = "0x186380D50", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6381700", Offset = "0x6380500", VA = "0x186381700", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6386530", Offset = "0x6385330", VA = "0x186386530", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6380AB0", Offset = "0x637F8B0", VA = "0x186380AB0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63853F0", Offset = "0x63841F0", VA = "0x1863853F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6382560", Offset = "0x6381360", VA = "0x186382560", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6382DA0", Offset = "0x6381BA0", VA = "0x186382DA0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6383010", Offset = "0x6381E10", VA = "0x186383010", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x63820D0", Offset = "0x6380ED0", VA = "0x1863820D0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63821D0", Offset = "0x6380FD0", VA = "0x1863821D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63856D0", Offset = "0x63844D0", VA = "0x1863856D0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6385A50", Offset = "0x6384850", VA = "0x186385A50", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6385B20", Offset = "0x6384920", VA = "0x186385B20", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6380E50", Offset = "0x637FC50", VA = "0x186380E50", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float ACICDEAJDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6382D50", Offset = "0x6381B50", VA = "0x186382D50", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6382FB0", Offset = "0x6381DB0", VA = "0x186382FB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool AJHNFMKDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6386600", Offset = "0x6385400", VA = "0x186386600", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6380CF0", Offset = "0x637FAF0", VA = "0x186380CF0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x63851C0", Offset = "0x6383FC0", VA = "0x1863851C0", Slot = "48")]
		get
		{
			return default(MDGAADFLMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6385E30", Offset = "0x6384C30", VA = "0x186385E30", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6381AD0", Offset = "0x63808D0", VA = "0x186381AD0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform NLDJFIKBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6381130", Offset = "0x637FF30", VA = "0x186381130", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 LEDDGOIJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6386430", Offset = "0x6385230", VA = "0x186386430", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6384B50", Offset = "0x6383950", VA = "0x186384B50", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float MHBNHKHGICB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6380E30", Offset = "0x637FC30", VA = "0x186380E30", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x63859E0", Offset = "0x63847E0", VA = "0x1863859E0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float FBKAFJDIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6381110", Offset = "0x637FF10", VA = "0x186381110", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6380BF0", Offset = "0x637F9F0", VA = "0x186380BF0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion OMBICKMAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6384A40", Offset = "0x6383840", VA = "0x186384A40", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6380F00", Offset = "0x637FD00", VA = "0x186380F00", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6385C20", Offset = "0x6384A20", VA = "0x186385C20", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6384CF0", Offset = "0x6383AF0", VA = "0x186384CF0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6385C70", Offset = "0x6384A70", VA = "0x186385C70", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6385840", Offset = "0x6384640", VA = "0x186385840", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints HJLMJCJKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6381140", Offset = "0x637FF40", VA = "0x186381140", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6381C40", Offset = "0x6380A40", VA = "0x186381C40", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6382B60", Offset = "0x6381960", VA = "0x186382B60", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6385980", Offset = "0x6384780", VA = "0x186385980", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode KMLICJMEANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63837A0", Offset = "0x63825A0", VA = "0x1863837A0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6382A20", Offset = "0x6381820", VA = "0x186382A20", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool PLCGLFFIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6381930", Offset = "0x6380730", VA = "0x186381930", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MOHFJANAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6383060", Offset = "0x6381E60", VA = "0x186383060", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JDCIBKMJKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6384950", Offset = "0x6383750", VA = "0x186384950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool EIDALKGJMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x63842C0", Offset = "0x63830C0", VA = "0x1863842C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ADLOFIFALML CILDKJKODFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63810B0", Offset = "0x637FEB0", VA = "0x1863810B0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6381A70", Offset = "0x6380870", VA = "0x186381A70", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ADLOFIFALML CECNOPEHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6383BA0", Offset = "0x63829A0", VA = "0x186383BA0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6382640", Offset = "0x6381440", VA = "0x186382640", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FIODGJBLMML NIJDMINIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63812A0", Offset = "0x63800A0", VA = "0x1863812A0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6382070", Offset = "0x6380E70", VA = "0x186382070", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event ADLOFIFALML JLKKFJLKABL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6385EB0", Offset = "0x6384CB0", VA = "0x186385EB0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6380B90", Offset = "0x637F990", VA = "0x186380B90", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event ADLOFIFALML HMBIILCIIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6384430", Offset = "0x6383230", VA = "0x186384430", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6383B40", Offset = "0x6382940", VA = "0x186383B40", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event ADLOFIFALML MPCFCPDAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x63813B0", Offset = "0x63801B0", VA = "0x1863813B0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x63843D0", Offset = "0x63831D0", VA = "0x1863843D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6382CF0", Offset = "0x6381AF0", VA = "0x186382CF0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6382290", Offset = "0x6381090", VA = "0x186382290", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event ADLOFIFALML OKBNOPNGHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6380830", Offset = "0x637F630", VA = "0x186380830", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6384020", Offset = "0x6382E20", VA = "0x186384020", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event ADLOFIFALML IINDPIONGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63811F0", Offset = "0x637FFF0", VA = "0x1863811F0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6383630", Offset = "0x6382430", VA = "0x186383630", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x63740E0", Offset = "0x6372EE0", VA = "0x1863740E0")]
	public LMDCMFOLAIH(GameObject CJHJDJNKIGF, RigidbodyEx FKHCKFIKJEF, HOIBMFNJHPD LBHKILDBCNO, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6381410", Offset = "0x6380210", VA = "0x186381410", Slot = "135")]
	protected virtual void DCAEOLNFCPM(HOIBMFNJHPD LBHKILDBCNO, EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6381B20", Offset = "0x6380920", VA = "0x186381B20", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6382BB0", Offset = "0x63819B0", VA = "0x186382BB0", Slot = "71")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6381060", Offset = "0x637FE60", VA = "0x186381060", Slot = "72")]
	public void CCCABCCBJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6385E90", Offset = "0x6384C90", VA = "0x186385E90", Slot = "73")]
	public void OLFMDOOHMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6382120", Offset = "0x6380F20", VA = "0x186382120")]
	private void FAFFAHJOFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6383730", Offset = "0x6382530", VA = "0x186383730", Slot = "81")]
	public void IFKFCKDOJJB(EMCMNBFGMOJ PHPDIJICBJO, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6383C50", Offset = "0x6382A50", VA = "0x186383C50", Slot = "84")]
	public void JFGEKFFBKLP(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6383A20", Offset = "0x6382820", VA = "0x186383A20", Slot = "85")]
	public void JDKPNCDGBHF(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63845B0", Offset = "0x63833B0", VA = "0x1863845B0", Slot = "86")]
	public Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6385210", Offset = "0x6384010", VA = "0x186385210", Slot = "87")]
	public Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6381060", Offset = "0x637FE60", VA = "0x186381060", Slot = "88")]
	public void MMFKCDJPKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6380890", Offset = "0x637F690", VA = "0x186380890", Slot = "89")]
	public void APNECOMFKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6381F40", Offset = "0x6380D40", VA = "0x186381F40", Slot = "90")]
	public void EJILHHACMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6381750", Offset = "0x6380550", VA = "0x186381750", Slot = "91")]
	public void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63826A0", Offset = "0x63814A0", VA = "0x1863826A0", Slot = "92")]
	public void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6385310", Offset = "0x6384110", VA = "0x186385310", Slot = "93")]
	public void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63809F0", Offset = "0x637F7F0", VA = "0x1863809F0", Slot = "94")]
	public void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6385CB0", Offset = "0x6384AB0", VA = "0x186385CB0", Slot = "95")]
	public void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6383890", Offset = "0x6382690", VA = "0x186383890", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6384D40", Offset = "0x6383B40", VA = "0x186384D40", Slot = "97")]
	public Vector3 MCAJKEFGHGP(Vector3 PHPDIJICBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6385880", Offset = "0x6384680", VA = "0x186385880", Slot = "98")]
	public Vector3 NDAELPKDHGC(Vector3 PHPDIJICBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x63861A0", Offset = "0x6384FA0", VA = "0x1863861A0", Slot = "99")]
	public void PEONNDNLACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6385F70", Offset = "0x6384D70", VA = "0x186385F70", Slot = "100")]
	public void PBOJOIKAKPL(EMCMNBFGMOJ HIMGCOMGJBC, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63828C0", Offset = "0x63816C0", VA = "0x1863828C0", Slot = "101")]
	public void GCKGNEDHCBH(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6383550", Offset = "0x6382350", VA = "0x186383550", Slot = "41")]
	public void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63863E0", Offset = "0x63851E0", VA = "0x1863863E0", Slot = "104")]
	public void PKFJKIAODLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6382E80", Offset = "0x6381C80", VA = "0x186382E80", Slot = "105")]
	public void HDGODKPGCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x63818E0", Offset = "0x63806E0", VA = "0x1863818E0", Slot = "106")]
	public void DKFKMLKCLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63864E0", Offset = "0x63852E0", VA = "0x1863864E0", Slot = "109")]
	public bool PLJANFJFEMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6382410", Offset = "0x6381210", VA = "0x186382410", Slot = "74")]
	public void FJFKBEBNLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6384900", Offset = "0x6383700", VA = "0x186384900", Slot = "110")]
	public void KLDGMKJDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63823C0", Offset = "0x63811C0", VA = "0x1863823C0", Slot = "115")]
	public IDisposable FGFBBPKLBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6384E40", Offset = "0x6383C40", VA = "0x186384E40", Slot = "116")]
	public void MCEDHLFDABL(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6384080", Offset = "0x6382E80", VA = "0x186384080", Slot = "117")]
	public void JKFBAFAINKO(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6380FF0", Offset = "0x637FDF0", VA = "0x186380FF0", Slot = "118")]
	public void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63854D0", Offset = "0x63842D0", VA = "0x1863854D0", Slot = "121")]
	public void MMKOIPOMFGO(Vector3 MGBDBMNHBCL, Quaternion BMICPHIEDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6383240", Offset = "0x6382040", VA = "0x186383240", Slot = "122")]
	public void HPPMPGOJBJC(Vector3 BCCGBAKEOMJ, Quaternion HBPKBIAHANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63831E0", Offset = "0x6381FE0", VA = "0x1863831E0", Slot = "123")]
	public bool HPKOELONGPM(float LKLBEHBFPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6381190", Offset = "0x637FF90", VA = "0x186381190", Slot = "124")]
	public void CKOJANFOPOD(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6383AE0", Offset = "0x63828E0", VA = "0x186383AE0", Slot = "125")]
	public void JEJHFHHEBJM(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6384AF0", Offset = "0x63838F0", VA = "0x186384AF0", Slot = "126")]
	public void LLKDAJOCJHI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6382500", Offset = "0x6381300", VA = "0x186382500", Slot = "127")]
	public void FMPBJANDFLE(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6383470", Offset = "0x6382270", VA = "0x186383470", Slot = "128")]
	public void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x63808E0", Offset = "0x637F6E0", VA = "0x1863808E0", Slot = "129")]
	public void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6383940", Offset = "0x6382740", VA = "0x186383940", Slot = "130")]
	public void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6384C10", Offset = "0x6383A10", VA = "0x186384C10", Slot = "131")]
	public void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6382460", Offset = "0x6381260", VA = "0x186382460", Slot = "132")]
	public bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6383C00", Offset = "0x6382A00", VA = "0x186383C00", Slot = "133")]
	public void JFCGIAEMMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6386650", Offset = "0x6385450", VA = "0x186386650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x63827E0", Offset = "0x63815E0", VA = "0x1863827E0")]
	private void GBKLHJGPFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63861F0", Offset = "0x6384FF0", VA = "0x1863861F0")]
	private void PHFLDOPLGBC(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63846B0", Offset = "0x63834B0", VA = "0x1863846B0")]
	private void KFPEMIGHOAE(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6381300", Offset = "0x6380100", VA = "0x186381300")]
	private void CLIKLOLDIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6382920", Offset = "0x6381720", VA = "0x186382920")]
	private void GHKGGJJBCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63840E0", Offset = "0x6382EE0", VA = "0x1863840E0")]
	private void JMFIKJEBFLE(EMCMNBFGMOJ LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63844E0", Offset = "0x63832E0", VA = "0x1863844E0")]
	private void KCNEHDKFDOC(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63822F0", Offset = "0x63810F0", VA = "0x1863822F0")]
	private void FFCCJHIBMFG(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6381DD0", Offset = "0x6380BD0", VA = "0x186381DD0")]
	private void EIAGBFJCNFA(RigidbodyEx BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6385FE0", Offset = "0x6384DE0", VA = "0x186385FE0", Slot = "140")]
	protected virtual void PCKECFKAFJE(RigidbodyEx GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6384EA0", Offset = "0x6383CA0", VA = "0x186384EA0")]
	protected void MCJFDGPIJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6383CB0", Offset = "0x6382AB0", VA = "0x186383CB0")]
	protected void JFJMEKNENHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6381840", Offset = "0x6380640", VA = "0x186381840", Slot = "141")]
	protected virtual IDisposable DIMKCDJBIKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class AHBCOFNOMNI
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6369490", Offset = "0x6368290", VA = "0x186369490")]
	public static EMCMNBFGMOJ AOCHOIHEPDC(this EMCMNBFGMOJ GKOAICANGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63695C0", Offset = "0x63683C0", VA = "0x1863695C0")]
	public static bool FLGGJIPIEGF(this EMCMNBFGMOJ GKOAICANGAP, EMCMNBFGMOJ GIBIJGOFICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6369410", Offset = "0x6368210", VA = "0x186369410")]
	public static bool AJLGJLGAGCD(this EMCMNBFGMOJ GKOAICANGAP, EMCMNBFGMOJ ABBIAOKMJBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6369640", Offset = "0x6368440", VA = "0x186369640")]
	public static RigidbodyEx NMEIEBBHMCA(this EMCMNBFGMOJ ENJHNCFKIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6369540", Offset = "0x6368340", VA = "0x186369540")]
	public static LMDCMFOLAIH CHFIICJKFGP(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CDADKGNGAGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JJLFBNEDAFO;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x636AA30", Offset = "0x6369830", VA = "0x18636AA30")]
	public CDADKGNGAGA(LMDCMFOLAIH OLDPDBPDEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x636A9D0", Offset = "0x63697D0", VA = "0x18636A9D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class ELAIHNPBBON : LLEKIECPELG, NBIOCGFCHNB
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode POKDBLEBBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6371AD0", Offset = "0x63708D0", VA = "0x186371AD0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6371A60", Offset = "0x6370860", VA = "0x186371A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode KMLICJMEANH
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6371F90", Offset = "0x6370D90", VA = "0x186371F90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6371CA0", Offset = "0x6370AA0", VA = "0x186371CA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public ELAIHNPBBON(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6371D60", Offset = "0x6370B60", VA = "0x186371D60", Slot = "6")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6371EB0", Offset = "0x6370CB0", VA = "0x186371EB0", Slot = "9")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x63720A0", Offset = "0x6370EA0", VA = "0x1863720A0", Slot = "7")]
	public void PJIEBMGDOKL(bool EAIFPNLJNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6371B30", Offset = "0x6370930", VA = "0x186371B30", Slot = "8")]
	public void EOBCADEFFEN(bool EAIFPNLJNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6371B40", Offset = "0x6370940", VA = "0x186371B40", Slot = "10")]
	public bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63718F0", Offset = "0x63706F0", VA = "0x1863718F0")]
	private void ACIAHMOBBBH(bool EAIFPNLJNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class IACNPKKCBKA : LLEKIECPELG, GAIKMIPBMEJ, IDisposable, ILIICCDHOOB
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MDGAADFLMAK KLMLCEIDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x637B020", Offset = "0x6379E20", VA = "0x18637B020")]
		get
		{
			return default(MDGAADFLMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x637B300", Offset = "0x637A100", VA = "0x18637B300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x637B100", Offset = "0x6379F00", VA = "0x18637B100", Slot = "6")]
		get
		{
			return default(MDGAADFLMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x637B300", Offset = "0x637A100", VA = "0x18637B300", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform GNJHJHBJBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x637AF70", Offset = "0x6379D70", VA = "0x18637AF70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x637AEC0", Offset = "0x6379CC0", VA = "0x18637AEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public IACNPKKCBKA(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x637B3F0", Offset = "0x637A1F0", VA = "0x18637B3F0", Slot = "11")]
	public void OnChangedDistanceBand(MNEBJHJFDEB JOEPHIIALLP, MNEBJHJFDEB FKKBLEKOJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "12")]
	public void OnChangedVisibility(bool BACAADICNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "8")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class LHGPKHNHCJP : LLEKIECPELG, CBHAPCHGCLF
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x636D3A0", Offset = "0x636C1A0", VA = "0x18636D3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x636CCD0", Offset = "0x636BAD0", VA = "0x18636CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x637FF50", Offset = "0x637ED50", VA = "0x18637FF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public LHGPKHNHCJP(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x637FFB0", Offset = "0x637EDB0", VA = "0x18637FFB0", Slot = "4")]
	public void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x637F910", Offset = "0x637E710", VA = "0x18637F910")]
	private void AMLBCKNOAPA(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x637FBF0", Offset = "0x637E9F0", VA = "0x18637FBF0", Slot = "5")]
	public void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6380110", Offset = "0x637EF10", VA = "0x186380110", Slot = "6")]
	public void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6380270", Offset = "0x637F070", VA = "0x186380270")]
	private void LGMBCFMMBHB(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63804D0", Offset = "0x637F2D0", VA = "0x1863804D0", Slot = "7")]
	public void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x637FE70", Offset = "0x637EC70", VA = "0x18637FE70")]
	private void CLFELIEFDPO(string KHIFMDJDLEG, UnityEngine.Object GMIADHJEACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OIGBCMFDKND : LLEKIECPELG, NGHLNFILAAA
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool AJHNFMKDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x638AF00", Offset = "0x6389D00", VA = "0x18638AF00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x638ACB0", Offset = "0x6389AB0", VA = "0x18638ACB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public OIGBCMFDKND(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x638AE70", Offset = "0x6389C70", VA = "0x18638AE70", Slot = "6")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x638AE00", Offset = "0x6389C00", VA = "0x18638AE00", Slot = "7")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class PIHANLLDMNN : LLEKIECPELG, MAGCAHIOFOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly BOGDNAKJHCL MMIMIKHEJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LNJPAMBBLOG GCFNCKALPGG;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x638D5D0", Offset = "0x638C3D0", VA = "0x18638D5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public ICMPCFCEMJM MOOCBODBMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x638BAB0", Offset = "0x638A8B0", VA = "0x18638BAB0")]
		get
		{
			return default(ICMPCFCEMJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x638CB60", Offset = "0x638B960", VA = "0x18638CB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x638CA40", Offset = "0x638B840", VA = "0x18638CA40", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x638BA40", Offset = "0x638A840", VA = "0x18638BA40", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public ICMPCFCEMJM PBENANFAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x638BB10", Offset = "0x638A910", VA = "0x18638BB10")]
		get
		{
			return default(ICMPCFCEMJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x638C580", Offset = "0x638B380", VA = "0x18638C580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x638CFE0", Offset = "0x638BDE0", VA = "0x18638CFE0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76FF20", Offset = "0x76ED20", VA = "0x18076FF20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ADLOFIFALML CILDKJKODFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x638C0A0", Offset = "0x638AEA0", VA = "0x18638C0A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x638C5F0", Offset = "0x638B3F0", VA = "0x18638C5F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ADLOFIFALML CECNOPEHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x638CF40", Offset = "0x638BD40", VA = "0x18638CF40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x638C9A0", Offset = "0x638B7A0", VA = "0x18638C9A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FIODGJBLMML NIJDMINIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x638C4E0", Offset = "0x638B2E0", VA = "0x18638C4E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x638C860", Offset = "0x638B660", VA = "0x18638C860", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action HBJJLNKGLME
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x638C900", Offset = "0x638B700", VA = "0x18638C900", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x638D740", Offset = "0x638C540", VA = "0x18638D740", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action DGFIBHHOPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x638D600", Offset = "0x638C400", VA = "0x18638D600", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x638D6A0", Offset = "0x638C4A0", VA = "0x18638D6A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<EMCMNBFGMOJ> GFJKMPFCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x638D7E0", Offset = "0x638C5E0", VA = "0x18638D7E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x638BFF0", Offset = "0x638ADF0", VA = "0x18638BFF0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<EMCMNBFGMOJ> EGAIBMKCEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x638CC70", Offset = "0x638BA70", VA = "0x18638CC70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x638CD20", Offset = "0x638BB20", VA = "0x18638CD20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action KAIJPFLCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x638CDD0", Offset = "0x638BBD0", VA = "0x18638CDD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x638CBD0", Offset = "0x638B9D0", VA = "0x18638CBD0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<EMCMNBFGMOJ> PACGAAMOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x638C430", Offset = "0x638B230", VA = "0x18638C430", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x638CAB0", Offset = "0x638B8B0", VA = "0x18638CAB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x638D920", Offset = "0x638C720", VA = "0x18638D920")]
	public PIHANLLDMNN(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x638C690", Offset = "0x638B490", VA = "0x18638C690", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x638CE70", Offset = "0x638BC70", VA = "0x18638CE70", Slot = "26")]
	public void IFKFCKDOJJB(EMCMNBFGMOJ BNOFKPJBDLH, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x638CEF0", Offset = "0x638BCF0", VA = "0x18638CEF0")]
	private void IFKFCKDOJJB(EPOOCOIJPAN BNOFKPJBDLH, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x638BB70", Offset = "0x638A970", VA = "0x18638BB70")]
	private void AJICLPFGGJK(EPOOCOIJPAN BNOFKPJBDLH, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x638D050", Offset = "0x638BE50", VA = "0x18638D050")]
	private void KHJOJFELDED(EPOOCOIJPAN LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x638C230", Offset = "0x638B030", VA = "0x18638C230")]
	private void CICNNGLBHHB(EPOOCOIJPAN LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x638D350", Offset = "0x638C150", VA = "0x18638D350")]
	private void LAMLEHKIPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x638D2A0", Offset = "0x638C0A0", VA = "0x18638D2A0")]
	private void KNAJIBPEOIG(EPOOCOIJPAN LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x638C140", Offset = "0x638AF40", VA = "0x18638C140")]
	private void CEDMPBDDBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x638D530", Offset = "0x638C330", VA = "0x18638D530")]
	private void MKPCBGMLOBB(EPOOCOIJPAN GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x638C7C0", Offset = "0x638B5C0", VA = "0x18638C7C0")]
	private void EEJHGNEHILF(EPOOCOIJPAN GKOAICANGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class LBINCPNLBAH
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x637F880", Offset = "0x637E680", VA = "0x18637F880")]
	public static PIHANLLDMNN HDOCJJOIAGB(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FBOIAOCFJJP : LLEKIECPELG, IIOPHLLHJLP
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6374D10", Offset = "0x6373B10", VA = "0x186374D10", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6374220", Offset = "0x6373020", VA = "0x186374220", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x63745B0", Offset = "0x63733B0", VA = "0x1863745B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private EMCMNBFGMOJ LDDBFOEAJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6374450", Offset = "0x6373250", VA = "0x186374450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public FBOIAOCFJJP(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x63747B0", Offset = "0x63735B0", VA = "0x1863747B0", Slot = "6")]
	public void HOBDONLLNDC(EMCMNBFGMOJ BMNEKBHDGLJ, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x63746A0", Offset = "0x63734A0", VA = "0x1863746A0")]
	private void HOBDONLLNDC(EPOOCOIJPAN BMNEKBHDGLJ, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x63741B0", Offset = "0x6372FB0", VA = "0x1863741B0", Slot = "7")]
	public void ALGIAFCMNHH(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6374900", Offset = "0x6373700", VA = "0x186374900")]
	private Vector3 MPKCCCBLHAC()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EOFCAAGAFBA
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63735A0", Offset = "0x63723A0", VA = "0x1863735A0")]
	public static FBOIAOCFJJP HBGEBFFKPBA(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class KJNKEOBAIKC : LLEKIECPELG, GGBBHEDCLGE
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x637E6F0", Offset = "0x637D4F0", VA = "0x18637E6F0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x637BCA0", Offset = "0x637AAA0", VA = "0x18637BCA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 LFKJBLJCDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x637E7D0", Offset = "0x637D5D0", VA = "0x18637E7D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 FPCKIJHMMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x637B410", Offset = "0x637A210", VA = "0x18637B410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x637BE20", Offset = "0x637AC20", VA = "0x18637BE20", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x637C750", Offset = "0x637B550", VA = "0x18637C750", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float AMLINDLILJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x637CB10", Offset = "0x637B910", VA = "0x18637CB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x637B900", Offset = "0x637A700", VA = "0x18637B900", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x637B960", Offset = "0x637A760", VA = "0x18637B960", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x637E7A0", Offset = "0x637D5A0", VA = "0x18637E7A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x637E880", Offset = "0x637D680", VA = "0x18637E880", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ADLOFIFALML LFFAALNOPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x637D3F0", Offset = "0x637C1F0", VA = "0x18637D3F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x637BC00", Offset = "0x637AA00", VA = "0x18637BC00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x637EAA0", Offset = "0x637D8A0", VA = "0x18637EAA0")]
	public KJNKEOBAIKC(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x637B540", Offset = "0x637A340", VA = "0x18637B540")]
	public float3 CCELAACDKKG()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x637C880", Offset = "0x637B680", VA = "0x18637C880", Slot = "14")]
	public void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x637E8B0", Offset = "0x637D6B0", VA = "0x18637E8B0", Slot = "16")]
	public void PKFJKIAODLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x637C010", Offset = "0x637AE10", VA = "0x18637C010", Slot = "15")]
	public void HDGODKPGCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x637C7B0", Offset = "0x637B5B0", VA = "0x18637C7B0", Slot = "18")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x637C360", Offset = "0x637B160", VA = "0x18637C360", Slot = "19")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x637B660", Offset = "0x637A460", VA = "0x18637B660", Slot = "17")]
	public void DKFKMLKCLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x637CB90", Offset = "0x637B990", VA = "0x18637CB90", Slot = "20")]
	public void JFCGIAEMMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x63731B0", Offset = "0x6371FB0", VA = "0x1863731B0")]
	public void DOGKPHLCCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x637BCA0", Offset = "0x637AAA0", VA = "0x18637BCA0")]
	private void GEPEENCCBJN(Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x637BA20", Offset = "0x637A820", VA = "0x18637BA20")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 FGFPPGKEMDH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x637B960", Offset = "0x637A760", VA = "0x18637B960")]
	private void GPEKAHHEJHN(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x637D190", Offset = "0x637BF90", VA = "0x18637D190")]
	private Vector3 JKIALNLKNOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x637B6C0", Offset = "0x637A4C0", VA = "0x18637B6C0")]
	private Quaternion EDAKNACOHHA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x637D490", Offset = "0x637C290", VA = "0x18637D490")]
	internal (float, Vector3) KKMLIHEALJN(Rigidbody LCCMNIFMHKN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class GBNLPHOLMDD
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63751D0", Offset = "0x6373FD0", VA = "0x1863751D0")]
	public static KJNKEOBAIKC KPMMMLNFAKM(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class ADEBOGPNJON : LLEKIECPELG, BHDHMDJKJKI
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool HCAOBELDCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6369220", Offset = "0x6368020", VA = "0x186369220", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FBMIFKFEGDK EBIEGFGAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6368AD0", Offset = "0x63678D0", VA = "0x186368AD0", Slot = "11")]
		get
		{
			return default(FBMIFKFEGDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private FBMIFKFEGDK ABCHHCFFEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6368AD0", Offset = "0x63678D0", VA = "0x186368AD0")]
		get
		{
			return default(FBMIFKFEGDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6368E50", Offset = "0x6367C50", VA = "0x186368E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6369300", Offset = "0x6368100", VA = "0x186369300")]
	public ADEBOGPNJON(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x63690A0", Offset = "0x6367EA0", VA = "0x1863690A0", Slot = "4")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x63689F0", Offset = "0x63677F0", VA = "0x1863689F0")]
	private bool ADADMMGLPNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6368C30", Offset = "0x6367A30", VA = "0x186368C30", Slot = "5")]
	public void CBPLFFODBGI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6369280", Offset = "0x6368080", VA = "0x186369280", Slot = "6")]
	public void NJECEBPLDMI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6368EC0", Offset = "0x6367CC0", VA = "0x186368EC0", Slot = "9")]
	public void GEHCJJHJIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6368B30", Offset = "0x6367930", VA = "0x186368B30")]
	private void BGEINOCIPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6368CB0", Offset = "0x6367AB0", VA = "0x186368CB0")]
	private void EHFFIFNAFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6369020", Offset = "0x6367E20", VA = "0x186369020", Slot = "8")]
	public void GNHPLDFHOOH(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x63691A0", Offset = "0x6367FA0", VA = "0x1863691A0", Slot = "7")]
	public void HJOHHEAJCOG(EMCMNBFGMOJ GKOAICANGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class EODJHAHKFPF : LLEKIECPELG, HLBLIKOPBKE
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x63731F0", Offset = "0x6371FF0", VA = "0x1863731F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool BCIPONACFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x63732C0", Offset = "0x63720C0", VA = "0x1863732C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ADLOFIFALML OKBNOPNGHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6373010", Offset = "0x6371E10", VA = "0x186373010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63734E0", Offset = "0x63722E0", VA = "0x1863734E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public EODJHAHKFPF(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6373250", Offset = "0x6372050", VA = "0x186373250", Slot = "11")]
	public IDisposable FGFBBPKLBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6373590", Offset = "0x6372390", VA = "0x186373590", Slot = "8")]
	public void MCEDHLFDABL(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6373580", Offset = "0x6372380", VA = "0x186373580", Slot = "9")]
	public void JKFBAFAINKO(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x63730B0", Offset = "0x6371EB0", VA = "0x1863730B0", Slot = "10")]
	public void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6373400", Offset = "0x6372200", VA = "0x186373400", Slot = "12")]
	public void ICJDCDNGPJB(Rigidbody EIODOLNINOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6373320", Offset = "0x6372120", VA = "0x186373320", Slot = "13")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x63731B0", Offset = "0x6371FB0", VA = "0x1863731B0", Slot = "6")]
	public void DJIGGBDAAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BDIELCPANDP : LLEKIECPELG, FOOLOBIMAJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView FGKNBKAADCK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6369ED0", Offset = "0x6368CD0", VA = "0x186369ED0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x636A2D0", Offset = "0x63690D0", VA = "0x18636A2D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event ADLOFIFALML JLKKFJLKABL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x636A360", Offset = "0x6369160", VA = "0x18636A360", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6369690", Offset = "0x6368490", VA = "0x186369690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x636A400", Offset = "0x6369200", VA = "0x18636A400")]
	public BDIELCPANDP(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6369A90", Offset = "0x6368890", VA = "0x186369A90", Slot = "8")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6369730", Offset = "0x6368530", VA = "0x186369730", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6369EF0", Offset = "0x6368CF0", VA = "0x186369EF0", Slot = "9")]
	public void KCNEHDKFDOC(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6369890", Offset = "0x6368690", VA = "0x186369890", Slot = "10")]
	public void FFCCJHIBMFG(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x636A0F0", Offset = "0x6368EF0", VA = "0x18636A0F0")]
	private void LLINDCMKBKN(PhotonView JAAPACPBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6369BC0", Offset = "0x63689C0", VA = "0x186369BC0")]
	private void HCFCBMEINOI(RigidbodyEx JOMMNELLGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6369D10", Offset = "0x6368B10", VA = "0x186369D10")]
	private void ICJLEFCHAOF(PhotonView KOOMADEJOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class DMEFHNBLBGD
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x636DC60", Offset = "0x636CA60", VA = "0x18636DC60")]
	public static BDIELCPANDP FCFPELJBBCE(this LMDCMFOLAIH DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class HIBEPICAFGP : LLEKIECPELG, AFFFHOOGEHK
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6377FF0", Offset = "0x6376DF0", VA = "0x186377FF0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x63781C0", Offset = "0x6376FC0", VA = "0x1863781C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool LFJFEBCNDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6378160", Offset = "0x6376F60", VA = "0x186378160", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6377E00", Offset = "0x6376C00", VA = "0x186377E00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints HJLMJCJKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6377DA0", Offset = "0x6376BA0", VA = "0x186377DA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6377E70", Offset = "0x6376C70", VA = "0x186377E70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x6378230", Offset = "0x6377030", VA = "0x186378230")]
	public HIBEPICAFGP(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x63780D0", Offset = "0x6376ED0", VA = "0x1863780D0", Slot = "9")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6378050", Offset = "0x6376E50", VA = "0x186378050", Slot = "10")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class GPNIIPLCBPL : LLEKIECPELG, BONLMHAGDFE
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6376930", Offset = "0x6375730", VA = "0x186376930", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6376470", Offset = "0x6375270", VA = "0x186376470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float ACICDEAJDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x63765C0", Offset = "0x63753C0", VA = "0x1863765C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x63766F0", Offset = "0x63754F0", VA = "0x1863766F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public GPNIIPLCBPL(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6376840", Offset = "0x6375640", VA = "0x186376840", Slot = "8")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6376620", Offset = "0x6375420", VA = "0x186376620", Slot = "9")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PLLADOOKFGO(typeof(IGGNMJBENLC), new string[] { })]
public sealed class OKJDEDGIGKO : ECOFDNFPFFG, IGGNMJBENLC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[GDCPPADOKIA]
	private AKEDKKKIDLP GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool JJLFBNEDAFO;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x638B300", Offset = "0x638A100", VA = "0x18638B300", Slot = "4")]
	public void InitReferences(DFLOIMJPFAA KDACNGHEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x638B0A0", Offset = "0x6389EA0", VA = "0x18638B0A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x638B720", Offset = "0x638A520", VA = "0x18638B720", Slot = "6")]
	public void KKMLIHEALJN(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x638B350", Offset = "0x638A150", VA = "0x18638B350", Slot = "7")]
	public void JOFGALJKENJ(ICMPCFCEMJM APAPEJEHLCD, bool NGFLOPMDGLA, bool PHFMOHCBFNP, bool EJPKMLIJMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x638AF60", Offset = "0x6389D60", VA = "0x18638AF60", Slot = "8")]
	public void DNOMPKIHFPH(ICMPCFCEMJM APAPEJEHLCD, float3 OIMALFIAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x638B0D0", Offset = "0x6389ED0", VA = "0x18638B0D0", Slot = "9")]
	public void EKAEGAKENIM(ICMPCFCEMJM APAPEJEHLCD, float3 DHNAJHLJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x638B570", Offset = "0x638A370", VA = "0x18638B570")]
	private bool JOJHMEMEPJF(ICMPCFCEMJM APAPEJEHLCD, [Out] EPOOCOIJPAN DDAGOAKHODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x638B630", Offset = "0x638A430", VA = "0x18638B630")]
	private bool KJAKAJBLGIN(ICMPCFCEMJM APAPEJEHLCD, [Out] KJNKEOBAIKC DJDGDPOMIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x638B210", Offset = "0x638A010", VA = "0x18638B210")]
	private bool GNGJHEAHGME(ICMPCFCEMJM APAPEJEHLCD, [Out] EEKDIICPEED ANOAJJKMNMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public OKJDEDGIGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class NJLAFEFLDDA : LLEKIECPELG, FANHOHBHDML
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool PLCGLFFIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x636EFF0", Offset = "0x636DDF0", VA = "0x18636EFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x63897A0", Offset = "0x63885A0", VA = "0x1863897A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x63898B0", Offset = "0x63886B0", VA = "0x1863898B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool GPBLCGLCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6389500", Offset = "0x6388300", VA = "0x186389500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x63899B0", Offset = "0x63887B0", VA = "0x1863899B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool LNCOINEDOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6389B60", Offset = "0x6388960", VA = "0x186389B60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6389560", Offset = "0x6388360", VA = "0x186389560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int IEMPBKNIKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6389C30", Offset = "0x6388A30", VA = "0x186389C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event ADLOFIFALML MPCFCPDAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6389460", Offset = "0x6388260", VA = "0x186389460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6389910", Offset = "0x6388710", VA = "0x186389910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6389E40", Offset = "0x6388C40", VA = "0x186389E40")]
	public NJLAFEFLDDA(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6389800", Offset = "0x6388600", VA = "0x186389800", Slot = "6")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6389BC0", Offset = "0x63889C0", VA = "0x186389BC0", Slot = "8")]
	public void MKCHGGIFKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6389CA0", Offset = "0x6388AA0", VA = "0x186389CA0", Slot = "7")]
	public bool PLJANFJFEMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63895D0", Offset = "0x63883D0", VA = "0x1863895D0", Slot = "9")]
	public void FJFKBEBNLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x63731B0", Offset = "0x6371FB0", VA = "0x1863731B0", Slot = "12")]
	public void LCPNCLELBKA(bool OAKMGPFAMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6389A20", Offset = "0x6388820", VA = "0x186389A20", Slot = "11")]
	public void KLDGMKJDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "10")]
	public void CILCIHEOIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x63896C0", Offset = "0x63884C0", VA = "0x1863896C0")]
	private void FMCCOFBBGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KLPEFGOBHMM : LLEKIECPELG, NLELMMAENGH
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x637ED90", Offset = "0x637DB90", VA = "0x18637ED90", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x637F5F0", Offset = "0x637E3F0", VA = "0x18637F5F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x636CCD0", Offset = "0x636BAD0", VA = "0x18636CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool PHJAAPKPCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x637F760", Offset = "0x637E560", VA = "0x18637F760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x637F7C0", Offset = "0x637E5C0", VA = "0x18637F7C0")]
	public KLPEFGOBHMM(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x637F2E0", Offset = "0x637E0E0", VA = "0x18637F2E0", Slot = "5")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x637F6E0", Offset = "0x637E4E0", VA = "0x18637F6E0", Slot = "7")]
	public void LLKDAJOCJHI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x637F260", Offset = "0x637E060", VA = "0x18637F260", Slot = "8")]
	public void FMPBJANDFLE(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x637F040", Offset = "0x637DE40", VA = "0x18637F040", Slot = "9")]
	public void FANCOGLAPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x637F390", Offset = "0x637E190", VA = "0x18637F390", Slot = "11")]
	public void HHNADBMKLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x637EE70", Offset = "0x637DC70", VA = "0x18637EE70", Slot = "12")]
	public void ENHIEMJKDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "10")]
	public void EJCHPOPNLGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class EEKDIICPEED : LLEKIECPELG, PINEELOCNCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x636F990", Offset = "0x636E790", VA = "0x18636F990", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6371620", Offset = "0x6370420", VA = "0x186371620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63702C0", Offset = "0x636F0C0", VA = "0x1863702C0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x636F370", Offset = "0x636E170", VA = "0x18636F370", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x636F310", Offset = "0x636E110", VA = "0x18636F310", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x636FE50", Offset = "0x636EC50", VA = "0x18636FE50", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x636F220", Offset = "0x636E020", VA = "0x18636F220", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x636F6D0", Offset = "0x636E4D0", VA = "0x18636F6D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x636F4A0", Offset = "0x636E2A0", VA = "0x18636F4A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x636F5B0", Offset = "0x636E3B0", VA = "0x18636F5B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x63715F0", Offset = "0x63703F0", VA = "0x1863715F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6371820", Offset = "0x6370620", VA = "0x186371820", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x636F250", Offset = "0x636E050", VA = "0x18636F250", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x636F0D0", Offset = "0x636DED0", VA = "0x18636F0D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x636ED50", Offset = "0x636DB50", VA = "0x18636ED50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private CBHAPCHGCLF DMAELEGFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1C94690", Offset = "0x1C93490", VA = "0x181C94690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool PLCGLFFIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x636EFF0", Offset = "0x636DDF0", VA = "0x18636EFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public EEKDIICPEED(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6370370", Offset = "0x636F170", VA = "0x186370370", Slot = "20")]
	public void LEKJJFIIPBG(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x636F920", Offset = "0x636E720", VA = "0x18636F920", Slot = "30")]
	public void IKDOBOJHBBP(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x636F500", Offset = "0x636E300", VA = "0x18636F500", Slot = "19")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x636F010", Offset = "0x636DE10", VA = "0x18636F010", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x636F700", Offset = "0x636E500", VA = "0x18636F700", Slot = "28")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x636FF10", Offset = "0x636ED10", VA = "0x18636FF10", Slot = "35")]
	public Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6370FB0", Offset = "0x636FDB0", VA = "0x186370FB0", Slot = "34")]
	public Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x636F500", Offset = "0x636E300", VA = "0x18636F500", Slot = "27")]
	public void MMFKCDJPKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x636DCC0", Offset = "0x636CAC0", VA = "0x18636DCC0", Slot = "25")]
	public void APNECOMFKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x636F2B0", Offset = "0x636E0B0", VA = "0x18636F2B0", Slot = "24")]
	public void EJILHHACMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x636EDB0", Offset = "0x636DBB0", VA = "0x18636EDB0", Slot = "33")]
	public void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x636F3E0", Offset = "0x636E1E0", VA = "0x18636F3E0", Slot = "32")]
	public void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6371170", Offset = "0x636FF70", VA = "0x186371170", Slot = "31")]
	public void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x636DD20", Offset = "0x636CB20", VA = "0x18636DD20", Slot = "22")]
	public void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6371340", Offset = "0x6370140", VA = "0x186371340", Slot = "21")]
	public void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x636FA40", Offset = "0x636E840", VA = "0x18636FA40", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6370ED0", Offset = "0x636FCD0", VA = "0x186370ED0", Slot = "29")]
	public Vector3 MCAJKEFGHGP(Vector3 MAEAAOMNFME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6371690", Offset = "0x6370490", VA = "0x186371690", Slot = "26")]
	public void PEONNDNLACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x636F0D0", Offset = "0x636DED0", VA = "0x18636F0D0")]
	private void EDKNCGIBMPL(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63700F0", Offset = "0x636EEF0", VA = "0x1863700F0")]
	private void KKFAFNCNJFF(Vector3 GHLDCNALGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x636E840", Offset = "0x636D640", VA = "0x18636E840")]
	private Vector3 CHJGLDEMPFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6370950", Offset = "0x636F750", VA = "0x186370950")]
	private void LMPMJOIFNLK(Vector3 OIMALFIAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x636EAC0", Offset = "0x636D8C0", VA = "0x18636EAC0")]
	private Vector3 DALAGMNOGAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x63703E0", Offset = "0x636F1E0", VA = "0x1863703E0")]
	private void LKCDPMIDEPE(Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x636F440", Offset = "0x636E240", VA = "0x18636F440")]
	private void GDLKIDFHOCP(Vector3 MAEAAOMNFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x636F670", Offset = "0x636E470", VA = "0x18636F670")]
	private void HJKPDBFCMBA(Vector3 GEOFLKGAFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x636E290", Offset = "0x636D090", VA = "0x18636E290")]
	private void CHGGMDICLBH(string LDLDLECFJLL, Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x636F870", Offset = "0x636E670", VA = "0x18636F870")]
	private void IJNEAOKDBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class LLEKIECPELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly EPOOCOIJPAN GKOAICANGAP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected AKEDKKKIDLP NGCPFOEEGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x54F5AC0", Offset = "0x54F48C0", VA = "0x1854F5AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x54F5B00", Offset = "0x54F4900", VA = "0x1854F5B00")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6371850", Offset = "0x6370650", VA = "0x186371850")]
	public LLEKIECPELG(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6380730", Offset = "0x637F530", VA = "0x186380730")]
	protected EMCMNBFGMOJ FHPEEOCIEBE(ICMPCFCEMJM EMALEGKCAJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class ELIPMCFHEBD : MCDLIBHCKMK
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63727A0", Offset = "0x63715A0", VA = "0x1863727A0", Slot = "4")]
	public MAGCAHIOFOP KEBDCNFDDKC(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x63723F0", Offset = "0x63711F0", VA = "0x1863723F0", Slot = "5")]
	public PINEELOCNCE CNMCOJOMHGO(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6372B60", Offset = "0x6371960", VA = "0x186372B60", Slot = "6")]
	public IIOPHLLHJLP NEJLKPFFJDK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6372D20", Offset = "0x6371B20", VA = "0x186372D20", Slot = "7")]
	public BONLMHAGDFE OHHLCLBFMPK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x63724D0", Offset = "0x63712D0", VA = "0x1863724D0", Slot = "8")]
	public FANHOHBHDML GJPLCHOCPFA(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6372800", Offset = "0x6371600", VA = "0x186372800", Slot = "9")]
	public GAIKMIPBMEJ KECDNNHGOFH(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x63726B0", Offset = "0x63714B0", VA = "0x1863726B0", Slot = "10")]
	public HLBLIKOPBKE JLKHOICOFKJ(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6372C40", Offset = "0x6371A40", VA = "0x186372C40", Slot = "11")]
	public CBHAPCHGCLF ODEKABJAHGI(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x63728E0", Offset = "0x63716E0", VA = "0x1863728E0", Slot = "12")]
	public NBIOCGFCHNB LBICFLLECIK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6372F30", Offset = "0x6371D30", VA = "0x186372F30", Slot = "13")]
	public NGHLNFILAAA PHBIILBFPPG(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x63720B0", Offset = "0x6370EB0", VA = "0x1863720B0")]
	public NLELMMAENGH AHIHFMCKLNA(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x63722F0", Offset = "0x63710F0", VA = "0x1863722F0")]
	public FOOLOBIMAJA CKBBNCCHKJF(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x63721B0", Offset = "0x6370FB0", VA = "0x1863721B0")]
	public BHDHMDJKJKI ANNLDOPNBJD(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6372640", Offset = "0x6371440", VA = "0x186372640")]
	public GGBBHEDCLGE IAEABBEMICJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x63729C0", Offset = "0x63717C0", VA = "0x1863729C0")]
	public AFFFHOOGEHK MJNJGFCAADJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6372E00", Offset = "0x6371C00", VA = "0x186372E00", Slot = "19")]
	public EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC, HOIBMFNJHPD LBHKILDBCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ELIPMCFHEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x63720B0", Offset = "0x6370EB0", VA = "0x1863720B0", Slot = "14")]
	private NLELMMAENGH GJFGMKFIBNJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x63722F0", Offset = "0x63710F0", VA = "0x1863722F0", Slot = "15")]
	private FOOLOBIMAJA AOPKEOCEFBO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x63721B0", Offset = "0x6370FB0", VA = "0x1863721B0", Slot = "16")]
	private BHDHMDJKJKI MLPMMMBEDED(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6372640", Offset = "0x6371440", VA = "0x186372640", Slot = "17")]
	private GGBBHEDCLGE NHAJDAPJFAO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6372790", Offset = "0x6371590", VA = "0x186372790", Slot = "18")]
	private AFFFHOOGEHK KAACAELPKJP(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class LNJPAMBBLOG : IReadOnlyList<EMCMNBFGMOJ>, IEnumerable<EMCMNBFGMOJ>, IEnumerable, IReadOnlyCollection<EMCMNBFGMOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly AKEDKKKIDLP ELOPFOKALOB;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x63868F0", Offset = "0x63856F0", VA = "0x1863868F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public EMCMNBFGMOJ LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6386690", Offset = "0x6385490", VA = "0x186386690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3689990", Offset = "0x3688790", VA = "0x183689990")]
	public LNJPAMBBLOG(ICMPCFCEMJM EMALEGKCAJH, AKEDKKKIDLP ELOPFOKALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x63867E0", Offset = "0x63855E0", VA = "0x1863867E0", Slot = "6")]
	public IEnumerator<EMCMNBFGMOJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63867E0", Offset = "0x63855E0", VA = "0x1863867E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6386690", Offset = "0x6385490", VA = "0x186386690")]
	[CompilerGenerated]
	private EMCMNBFGMOJ FCKPPEMFIPG(int POGGKDPIPDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PLLADOOKFGO(typeof(MCDLIBHCKMK), new string[] { })]
public class CPNNIHMBBID : MCDLIBHCKMK, ECOFDNFPFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly MCDLIBHCKMK IOCHDKFFDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MCDLIBHCKMK JAPABNBPENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private BNLOPGCJCAK KLCMDPANGMF;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private MCDLIBHCKMK JJMFCHAFPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x636AE90", Offset = "0x6369C90", VA = "0x18636AE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x636B040", Offset = "0x6369E40", VA = "0x18636B040", Slot = "20")]
	public void InitReferences(DFLOIMJPFAA KDACNGHEDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x636B1E0", Offset = "0x6369FE0", VA = "0x18636B1E0", Slot = "4")]
	public MAGCAHIOFOP KEBDCNFDDKC(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x636ADF0", Offset = "0x6369BF0", VA = "0x18636ADF0", Slot = "5")]
	public PINEELOCNCE CNMCOJOMHGO(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x636B3C0", Offset = "0x636A1C0", VA = "0x18636B3C0", Slot = "6")]
	public IIOPHLLHJLP NEJLKPFFJDK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x636B500", Offset = "0x636A300", VA = "0x18636B500", Slot = "7")]
	public BONLMHAGDFE OHHLCLBFMPK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x636AEF0", Offset = "0x6369CF0", VA = "0x18636AEF0", Slot = "8")]
	public FANHOHBHDML GJPLCHOCPFA(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x636B280", Offset = "0x636A080", VA = "0x18636B280", Slot = "9")]
	public GAIKMIPBMEJ KECDNNHGOFH(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x636B090", Offset = "0x6369E90", VA = "0x18636B090", Slot = "10")]
	public HLBLIKOPBKE JLKHOICOFKJ(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x636B460", Offset = "0x636A260", VA = "0x18636B460", Slot = "11")]
	public CBHAPCHGCLF ODEKABJAHGI(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x636B320", Offset = "0x636A120", VA = "0x18636B320", Slot = "12")]
	public NBIOCGFCHNB LBICFLLECIK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x636B690", Offset = "0x636A490", VA = "0x18636B690", Slot = "13")]
	public NGHLNFILAAA PHBIILBFPPG(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x636ABE0", Offset = "0x63699E0", VA = "0x18636ABE0")]
	public NLELMMAENGH AHIHFMCKLNA(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x636AD40", Offset = "0x6369B40", VA = "0x18636AD40")]
	public FOOLOBIMAJA CKBBNCCHKJF(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x636AC90", Offset = "0x6369A90", VA = "0x18636AC90")]
	public BHDHMDJKJKI ANNLDOPNBJD(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x636AF90", Offset = "0x6369D90", VA = "0x18636AF90")]
	public GGBBHEDCLGE IAEABBEMICJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x636B130", Offset = "0x6369F30", VA = "0x18636B130")]
	public AFFFHOOGEHK MJNJGFCAADJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x636B5A0", Offset = "0x636A3A0", VA = "0x18636B5A0", Slot = "19")]
	public EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC, HOIBMFNJHPD LBHKILDBCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x636B730", Offset = "0x636A530", VA = "0x18636B730")]
	public CPNNIHMBBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x636ABE0", Offset = "0x63699E0", VA = "0x18636ABE0", Slot = "14")]
	private NLELMMAENGH GJFGMKFIBNJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x636AD40", Offset = "0x6369B40", VA = "0x18636AD40", Slot = "15")]
	private FOOLOBIMAJA AOPKEOCEFBO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x636AC90", Offset = "0x6369A90", VA = "0x18636AC90", Slot = "16")]
	private BHDHMDJKJKI MLPMMMBEDED(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x636AF90", Offset = "0x6369D90", VA = "0x18636AF90", Slot = "17")]
	private GGBBHEDCLGE NHAJDAPJFAO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x636B130", Offset = "0x6369F30", VA = "0x18636B130", Slot = "18")]
	private AFFFHOOGEHK KAACAELPKJP(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class PLNGKOJDOAM : EMCMNBFGMOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly PLNGKOJDOAM ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx NMEIEBBHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject DCHEMEBLILM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7729F0", Offset = "0x7717F0", VA = "0x1807729F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x779D70", Offset = "0x778B70", VA = "0x180779D70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FA0", Offset = "0x7F7DA0", VA = "0x1807F8FA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xCE8F10", Offset = "0xCE7D10", VA = "0x180CE8F10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x76FF50", Offset = "0x76ED50", VA = "0x18076FF50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x76FF40", Offset = "0x76ED40", VA = "0x18076FF40", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x76FF60", Offset = "0x76ED60", VA = "0x18076FF60", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x76FF70", Offset = "0x76ED70", VA = "0x18076FF70", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x97C620", Offset = "0x97B420", VA = "0x18097C620", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x83B620", Offset = "0x83A420", VA = "0x18083B620", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A8EBD0", Offset = "0x1A8D9D0", VA = "0x181A8EBD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D35D80", Offset = "0x3D34B80", VA = "0x183D35D80", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x638DB40", Offset = "0x638C940", VA = "0x18638DB40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x638DB60", Offset = "0x638C960", VA = "0x18638DB60", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x35203D0", Offset = "0x351F1D0", VA = "0x1835203D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19BA570", Offset = "0x19B9370", VA = "0x1819BA570", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool OOLLCENLCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0C0", Offset = "0x8BDEC0", VA = "0x1808BF0C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CFBAHGPOLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x16E1560", Offset = "0x16E0360", VA = "0x1816E1560", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5C5E930", Offset = "0x5C5D730", VA = "0x185C5E930", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x35203F0", Offset = "0x351F1F0", VA = "0x1835203F0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x92C970", Offset = "0x92B770", VA = "0x18092C970", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x638DB20", Offset = "0x638C920", VA = "0x18638DB20", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5412520", Offset = "0x5411320", VA = "0x185412520", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7C31B0", Offset = "0x7C1FB0", VA = "0x1807C31B0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float ACICDEAJDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AJHNFMKDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "48")]
		get
		{
			return default(MDGAADFLMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x114C0F0", Offset = "0x114AEF0", VA = "0x18114C0F0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform NLDJFIKBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x88D950", Offset = "0x88C750", VA = "0x18088D950", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 LEDDGOIJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float MHBNHKHGICB
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float FBKAFJDIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D0", Offset = "0x7C33D0", VA = "0x1807C45D0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OMBICKMAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x8F07C0", Offset = "0x8EF5C0", VA = "0x1808F07C0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8F07C0", Offset = "0x8EF5C0", VA = "0x1808F07C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints HJLMJCJKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode KMLICJMEANH
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MOHFJANAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x84A780", Offset = "0x849580", VA = "0x18084A780", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event ADLOFIFALML CILDKJKODFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event ADLOFIFALML CECNOPEHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event FIODGJBLMML NIJDMINIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event ADLOFIFALML JLKKFJLKABL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event ADLOFIFALML HMBIILCIIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ADLOFIFALML MPCFCPDAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ADLOFIFALML OKBNOPNGHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event ADLOFIFALML IINDPIONGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "41")]
	public void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "71")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "72")]
	public void CCCABCCBJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "73")]
	public void OLFMDOOHMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "74")]
	public void FJFKBEBNLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "81")]
	public void IFKFCKDOJJB(EMCMNBFGMOJ PHPDIJICBJO, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "84")]
	public void JFGEKFFBKLP(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "85")]
	public void JDKPNCDGBHF(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "86")]
	public Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "87")]
	public Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "88")]
	public void MMFKCDJPKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "89")]
	public void APNECOMFKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "90")]
	public void EJILHHACMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "91")]
	public void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "92")]
	public void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "93")]
	public void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "94")]
	public void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "95")]
	public void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "96")]
	public void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "97")]
	public Vector3 MCAJKEFGHGP(Vector3 PHPDIJICBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xAB23E0", Offset = "0xAB11E0", VA = "0x180AB23E0", Slot = "98")]
	public Vector3 NDAELPKDHGC(Vector3 PHPDIJICBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "99")]
	public void PEONNDNLACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "100")]
	public void PBOJOIKAKPL(EMCMNBFGMOJ HIMGCOMGJBC, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "101")]
	public void GCKGNEDHCBH(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "104")]
	public void PKFJKIAODLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "105")]
	public void HDGODKPGCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "106")]
	public void DKFKMLKCLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "109")]
	public bool PLJANFJFEMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "110")]
	public void KLDGMKJDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "115")]
	public IDisposable FGFBBPKLBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "116")]
	public void MCEDHLFDABL(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "117")]
	public void JKFBAFAINKO(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "118")]
	public void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "121")]
	public void MMKOIPOMFGO(Vector3 MGBDBMNHBCL, Quaternion BMICPHIEDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "122")]
	public void HPPMPGOJBJC(Vector3 BCCGBAKEOMJ, Quaternion HBPKBIAHANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "123")]
	public bool HPKOELONGPM(float LKLBEHBFPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "124")]
	public void CKOJANFOPOD(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "125")]
	public void JEJHFHHEBJM(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "126")]
	public void LLKDAJOCJHI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "127")]
	public void FMPBJANDFLE(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "128")]
	public void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "129")]
	public void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "130")]
	public void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "131")]
	public void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x638DB00", Offset = "0x638C900", VA = "0x18638DB00", Slot = "132")]
	public bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "133")]
	public void JFCGIAEMMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PLNGKOJDOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class EPOOCOIJPAN : LMDCMFOLAIH, IMPMKPGDGFD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal AKEDKKKIDLP INKGKODOBFN;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x63740E0", Offset = "0x6372EE0", VA = "0x1863740E0")]
	public EPOOCOIJPAN(GameObject CJHJDJNKIGF, RigidbodyEx FKHCKFIKJEF, HOIBMFNJHPD LBHKILDBCNO, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x63736F0", Offset = "0x63724F0", VA = "0x1863736F0", Slot = "135")]
	protected override void DCAEOLNFCPM(HOIBMFNJHPD LBHKILDBCNO, EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "141")]
	protected override IDisposable DIMKCDJBIKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6373960", Offset = "0x6372760", VA = "0x186373960", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6373DC0", Offset = "0x6372BC0", VA = "0x186373DC0", Slot = "142")]
	public void OBCHPDBAHPG(BCLONCNCHJM JOEPHIIALLP, BCLONCNCHJM FKKBLEKOJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6373630", Offset = "0x6372430", VA = "0x186373630", Slot = "143")]
	public void BPFPKAGLDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6374020", Offset = "0x6372E20", VA = "0x186374020", Slot = "144")]
	public void PLJIFMHFHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6373D60", Offset = "0x6372B60", VA = "0x186373D60", Slot = "145")]
	public void LCPNCLELBKA(bool OAKMGPFAMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6373E90", Offset = "0x6372C90", VA = "0x186373E90", Slot = "146")]
	public bool PECKMKJGIIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6373AD0", Offset = "0x63728D0", VA = "0x186373AD0", Slot = "147")]
	public void HKBBDNCLFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "140")]
	protected override void PCKECFKAFJE(RigidbodyEx ANLNKNAJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6373B30", Offset = "0x6372930", VA = "0x186373B30")]
	private void JBGMNIAKDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class DANCLHAKAJB
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x636BD20", Offset = "0x636AB20", VA = "0x18636BD20")]
	public static LMDCMFOLAIH BNLNDFIAJOE(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OIHBJIMFAFG : MAGCAHIOFOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKPCBGMLOBB(EMCMNBFGMOJ GKOAICANGAP);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEJHGNEHILF(EMCMNBFGMOJ GKOAICANGAP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHJOJFELDED(EMCMNBFGMOJ LNMLCBMDGDP);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CICNNGLBHHB(EMCMNBFGMOJ LNMLCBMDGDP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AJDOFJFMIPO : IIOPHLLHJLP
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	PHEOKLNJGFL<EMCMNBFGMOJ> ONHLMBGKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	EMCMNBFGMOJ LDDBFOEAJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CMOIIBKECOI : GGBBHEDCLGE
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KKMLIHEALJN(Rigidbody LCCMNIFMHKN);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ONJEBBPDAOE : FOOLOBIMAJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView IMNBGDKNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class GMNEIHOEKGC : NBIOCGFCHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode EDNONOJCFIM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode KMLICJMEANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6376350", Offset = "0x6375150", VA = "0x186376350", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6376150", Offset = "0x6374F50", VA = "0x186376150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x636DBD0", Offset = "0x636C9D0", VA = "0x18636DBD0")]
	public GMNEIHOEKGC(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63761C0", Offset = "0x6374FC0", VA = "0x1863761C0", Slot = "6")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x63762D0", Offset = "0x63750D0", VA = "0x1863762D0", Slot = "9")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6376460", Offset = "0x6375260", VA = "0x186376460", Slot = "7")]
	public void PJIEBMGDOKL(bool EAIFPNLJNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6375FE0", Offset = "0x6374DE0", VA = "0x186375FE0", Slot = "8")]
	public void EOBCADEFFEN(bool EAIFPNLJNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6375FF0", Offset = "0x6374DF0", VA = "0x186375FF0", Slot = "10")]
	public bool FMBBHGHIDAJ(Vector3 NJLPJDHGIMB, [Out] RaycastHit PBKHOLKDKIK, float PABLLIHNBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6375EC0", Offset = "0x6374CC0", VA = "0x186375EC0")]
	private void ACIAHMOBBBH(bool EAIFPNLJNBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class HGPLDABGFDG : GAIKMIPBMEJ, IDisposable, ILIICCDHOOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private MDGAADFLMAK MPEGBMBMHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private IIHHOFKBIHF PKFODFABGDB;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public MDGAADFLMAK AMLGFINMNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x63773B0", Offset = "0x63761B0", VA = "0x1863773B0", Slot = "6")]
		get
		{
			return default(MDGAADFLMAK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6377520", Offset = "0x6376320", VA = "0x186377520", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform GNJHJHBJBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6377500", Offset = "0x6376300", VA = "0x186377500", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<MNEBJHJFDEB, MNEBJHJFDEB> GDFHOKPICHB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6377300", Offset = "0x6376100", VA = "0x186377300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6376F50", Offset = "0x6375D50", VA = "0x186376F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x63775F0", Offset = "0x63763F0", VA = "0x1863775F0")]
	public HGPLDABGFDG(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6377000", Offset = "0x6375E00", VA = "0x186377000", Slot = "8")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6376F00", Offset = "0x6375D00", VA = "0x186376F00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B0E130", Offset = "0x1B0CF30", VA = "0x181B0E130", Slot = "11")]
	private void DDGOMIAAFIE(MNEBJHJFDEB IAKOAOAPBED, MNEBJHJFDEB CDKBIKKBPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "12")]
	private void NFNDDNDEAJF(bool BACAADICNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DIMJHJCJHNO : CBHAPCHGCLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x636D350", Offset = "0x636C150", VA = "0x18636D350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x636D3A0", Offset = "0x636C1A0", VA = "0x18636D3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x636CCD0", Offset = "0x636BAD0", VA = "0x18636CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x636D3F0", Offset = "0x636C1F0", VA = "0x18636D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x636DBD0", Offset = "0x636C9D0", VA = "0x18636DBD0")]
	public DIMJHJCJHNO(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x636D450", Offset = "0x636C250", VA = "0x18636D450", Slot = "4")]
	public void IBJPNJHNGMP(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x636CE70", Offset = "0x636BC70", VA = "0x18636CE70")]
	private void AMLBCKNOAPA(Vector3 OOFPOBCGECA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x636D0D0", Offset = "0x636BED0", VA = "0x18636D0D0", Slot = "5")]
	public void APNKBNCEOND(Vector3 OOFPOBCGECA, Vector3 LMGPBOPOFGA, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x636D5B0", Offset = "0x636C3B0", VA = "0x18636D5B0", Slot = "6")]
	public void JBKLABFJHGA(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x636D710", Offset = "0x636C510", VA = "0x18636D710")]
	private void LGMBCFMMBHB(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x636D970", Offset = "0x636C770", VA = "0x18636D970", Slot = "7")]
	public void LNHMLLHHAIH(Vector3 IOJMHGDECEF, ForceMode ENBAOMCAPBK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class OLKBDMEMOCO : NGHLNFILAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool KHFFOOMCEKL;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool AJHNFMKDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x81EC90", Offset = "0x81DA90", VA = "0x18081EC90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x638B840", Offset = "0x638A640", VA = "0x18638B840", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x636DBD0", Offset = "0x636C9D0", VA = "0x18636DBD0")]
	public OLKBDMEMOCO(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x638B950", Offset = "0x638A750", VA = "0x18638B950", Slot = "6")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x638AE00", Offset = "0x6389C00", VA = "0x18638AE00", Slot = "7")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class MLBFDIKODPD : OIHBJIMFAFG, MAGCAHIOFOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EMCMNBFGMOJ GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<EMCMNBFGMOJ> LADGIPGJONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private EMCMNBFGMOJ NANDDCHCAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private EMCMNBFGMOJ BMNEKBHDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform ONBNIGMJGEO;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6388470", Offset = "0x6387270", VA = "0x186388470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x773BF0", Offset = "0x7729F0", VA = "0x180773BF0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6386940", Offset = "0x6385740", VA = "0x186386940", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public EMCMNBFGMOJ CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x773C10", Offset = "0x772A10", VA = "0x180773C10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<EMCMNBFGMOJ> ILDGPCFKMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x76FF20", Offset = "0x76ED20", VA = "0x18076FF20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ADLOFIFALML CILDKJKODFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6386A00", Offset = "0x6385800", VA = "0x186386A00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x63870E0", Offset = "0x6385EE0", VA = "0x1863870E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ADLOFIFALML CECNOPEHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6387F90", Offset = "0x6386D90", VA = "0x186387F90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x63874F0", Offset = "0x63862F0", VA = "0x1863874F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event FIODGJBLMML NIJDMINIGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6386F00", Offset = "0x6385D00", VA = "0x186386F00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63872C0", Offset = "0x63860C0", VA = "0x1863872C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action HBJJLNKGLME
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6387360", Offset = "0x6386160", VA = "0x186387360", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6388610", Offset = "0x6387410", VA = "0x186388610", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action DGFIBHHOPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63884D0", Offset = "0x63872D0", VA = "0x1863884D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6388570", Offset = "0x6387370", VA = "0x186388570", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<EMCMNBFGMOJ> GFJKMPFCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63886B0", Offset = "0x63874B0", VA = "0x1863886B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6386950", Offset = "0x6385750", VA = "0x186386950", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<EMCMNBFGMOJ> EGAIBMKCEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6387810", Offset = "0x6386610", VA = "0x186387810", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63878C0", Offset = "0x63866C0", VA = "0x1863878C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action KAIJPFLCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6387970", Offset = "0x6386770", VA = "0x186387970", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6387640", Offset = "0x6386440", VA = "0x186387640", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<EMCMNBFGMOJ> PACGAAMOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6386E50", Offset = "0x6385C50", VA = "0x186386E50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6387590", Offset = "0x6386390", VA = "0x186387590", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6388760", Offset = "0x6387560", VA = "0x186388760")]
	public MLBFDIKODPD(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6387180", Offset = "0x6385F80", VA = "0x186387180", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6387A10", Offset = "0x6386810", VA = "0x186387A10", Slot = "30")]
	public void IFKFCKDOJJB(EMCMNBFGMOJ BNOFKPJBDLH, bool GJMMOFEDCKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6388030", Offset = "0x6386E30", VA = "0x186388030", Slot = "6")]
	public void KHJOJFELDED(EMCMNBFGMOJ LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6386BD0", Offset = "0x63859D0", VA = "0x186386BD0", Slot = "7")]
	public void CICNNGLBHHB(EMCMNBFGMOJ LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6388380", Offset = "0x6387180", VA = "0x186388380", Slot = "4")]
	public void MKPCBGMLOBB(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6387220", Offset = "0x6386020", VA = "0x186387220", Slot = "5")]
	public void EEJHGNEHILF(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x63882E0", Offset = "0x63870E0", VA = "0x1863882E0")]
	private void LAMLEHKIPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x63882A0", Offset = "0x63870A0", VA = "0x1863882A0")]
	private void KNAJIBPEOIG(EMCMNBFGMOJ LNMLCBMDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6386FA0", Offset = "0x6385DA0", VA = "0x186386FA0")]
	private void CLHLCHKOIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6386AA0", Offset = "0x63858A0", VA = "0x186386AA0")]
	private void CEDMPBDDBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x63876E0", Offset = "0x63864E0", VA = "0x1863876E0")]
	private void GNKKPIJABFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6387400", Offset = "0x6386200", VA = "0x186387400")]
	[CompilerGenerated]
	private object FNDJGBGMKCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class CPCKENMLAJO
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x636AB20", Offset = "0x6369920", VA = "0x18636AB20")]
	public static OIHBJIMFAFG HDOCJJOIAGB(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class OAECHLGKCFD : AJDOFJFMIPO, IIOPHLLHJLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PHEOKLNJGFL<EMCMNBFGMOJ> IJADDFPBLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool BJMIHGNLIBM;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public PHEOKLNJGFL<EMCMNBFGMOJ> ONHLMBGKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 BDELDBHNBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x638AB80", Offset = "0x6389980", VA = "0x18638AB80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 BODABDLKBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x638A090", Offset = "0x6388E90", VA = "0x18638A090", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x638A300", Offset = "0x6389100", VA = "0x18638A300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public EMCMNBFGMOJ LDDBFOEAJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x638A250", Offset = "0x6389050", VA = "0x18638A250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x638ABB0", Offset = "0x63899B0", VA = "0x18638ABB0")]
	public OAECHLGKCFD(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x638A3F0", Offset = "0x63891F0", VA = "0x18638A3F0", Slot = "8")]
	public void HOBDONLLNDC(EMCMNBFGMOJ BMNEKBHDGLJ, object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x638A030", Offset = "0x6388E30", VA = "0x18638A030", Slot = "9")]
	public void ALGIAFCMNHH(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x638A460", Offset = "0x6389260", VA = "0x18638A460")]
	private Vector3 MPKCCCBLHAC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x638A7F0", Offset = "0x63895F0", VA = "0x18638A7F0")]
	private void NFEIOEBIECG(EMCMNBFGMOJ KBGNNPDKAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class NMMGOFHILBN
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6389F70", Offset = "0x6388D70", VA = "0x186389F70")]
	public static AJDOFJFMIPO HBGEBFFKPBA(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class HOEAADJKOAP : CMOIIBKECOI, GGBBHEDCLGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 KEIIMOLPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 IPLNPLMJHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float KFCMPEFKJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float NEPNGFCGBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 IEILMELOIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? NPFFHGENMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? IDPHMLELMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool JDCCENPNHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool MMIJCENGDCG;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 HLEDJBIPFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xFD1490", Offset = "0xFD0290", VA = "0x180FD1490", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x63784B0", Offset = "0x63772B0", VA = "0x1863784B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 OAGNFGLELGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6378A90", Offset = "0x6377890", VA = "0x186378A90", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float FCIELJOKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10C0C20", Offset = "0x10BFA20", VA = "0x1810C0C20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x63783A0", Offset = "0x63771A0", VA = "0x1863783A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float HKDDJIKEPDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB42820", Offset = "0xB41620", VA = "0x180B42820", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x6378850", Offset = "0x6377650", VA = "0x186378850", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 LKBKCNKLABG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x637A910", Offset = "0x6379710", VA = "0x18637A910", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion LLOHDDHFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x637AAA0", Offset = "0x63798A0", VA = "0x18637AAA0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6375500", Offset = "0x6374300", VA = "0x186375500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event ADLOFIFALML LFFAALNOPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6379850", Offset = "0x6378650", VA = "0x186379850", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x63789F0", Offset = "0x63777F0", VA = "0x1863789F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x637ADD0", Offset = "0x6379BD0", VA = "0x18637ADD0")]
	public HOEAADJKOAP(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x637AC20", Offset = "0x6379A20", VA = "0x18637AC20", Slot = "17")]
	public void PKFJKIAODLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6378B90", Offset = "0x6377990", VA = "0x186378B90", Slot = "16")]
	public void HDGODKPGCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6378F00", Offset = "0x6377D00", VA = "0x186378F00", Slot = "19")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6378C70", Offset = "0x6377A70", VA = "0x186378C70", Slot = "20")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6378560", Offset = "0x6377360", VA = "0x186378560", Slot = "18")]
	public void DKFKMLKCLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6379210", Offset = "0x6378010", VA = "0x186379210", Slot = "21")]
	public void JFCGIAEMMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63784B0", Offset = "0x63772B0", VA = "0x1863784B0")]
	private void DAKMOJOAKOO(Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6378900", Offset = "0x6377700", VA = "0x186378900")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FGFPPGKEMDH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63783A0", Offset = "0x63771A0", VA = "0x1863783A0")]
	private void JGHIMEENCJF(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6378850", Offset = "0x6377650", VA = "0x186378850")]
	private void GPEKAHHEJHN(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63796B0", Offset = "0x63784B0", VA = "0x1863796B0")]
	private Vector3 JKIALNLKNOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6378FE0", Offset = "0x6377DE0", VA = "0x186378FE0", Slot = "15")]
	public void ICNOAKICKIB((Quaternion rot, Vector3 moments) ABHEAGLOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63786D0", Offset = "0x63774D0", VA = "0x1863786D0")]
	private Quaternion EDAKNACOHHA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x637A840", Offset = "0x6379640", VA = "0x18637A840")]
	public void KKMLIHEALJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63798F0", Offset = "0x63786F0", VA = "0x1863798F0", Slot = "4")]
	public (float, Vector3) KKMLIHEALJN(Rigidbody LCCMNIFMHKN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class OOEGNOFFKKI
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x638B980", Offset = "0x638A780", VA = "0x18638B980")]
	public static CMOIIBKECOI KPMMMLNFAKM(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class HHFKPPHLDDJ : BHDHMDJKJKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FMCHKOLFDCF OEMMOIJDAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly FBMIFKFEGDK GPNGHPLKPGM;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool HCAOBELDCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xC74ED0", Offset = "0xC73CD0", VA = "0x180C74ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public FBMIFKFEGDK EBIEGFGAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0", Slot = "11")]
		get
		{
			return default(FBMIFKFEGDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6377CA0", Offset = "0x6376AA0", VA = "0x186377CA0")]
	public HHFKPPHLDDJ(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6377B60", Offset = "0x6376960", VA = "0x186377B60", Slot = "4")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6377680", Offset = "0x6376480", VA = "0x186377680")]
	private bool ADADMMGLPNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6377840", Offset = "0x6376640", VA = "0x186377840", Slot = "5")]
	public void CBPLFFODBGI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6377C70", Offset = "0x6376A70", VA = "0x186377C70", Slot = "6")]
	public void NJECEBPLDMI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x63779E0", Offset = "0x63767E0", VA = "0x1863779E0", Slot = "9")]
	public void GEHCJJHJIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6377720", Offset = "0x6376520", VA = "0x186377720")]
	private void BGEINOCIPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6377870", Offset = "0x6376670", VA = "0x186377870")]
	private void EHFFIFNAFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6377B20", Offset = "0x6376920", VA = "0x186377B20", Slot = "8")]
	public void GNHPLDFHOOH(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6377C30", Offset = "0x6376A30", VA = "0x186377C30", Slot = "7")]
	public void HJOHHEAJCOG(EMCMNBFGMOJ GKOAICANGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class HBGOAHFJAMC : HLBLIKOPBKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly FMCHKOLFDCF BMEAFNPDBMG;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool PIPIJMFJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6376B80", Offset = "0x6375980", VA = "0x186376B80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event ADLOFIFALML OKBNOPNGHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6376990", Offset = "0x6375790", VA = "0x186376990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6376D50", Offset = "0x6375B50", VA = "0x186376D50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6376E10", Offset = "0x6375C10", VA = "0x186376E10")]
	public HBGOAHFJAMC(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6376C30", Offset = "0x6375A30", VA = "0x186376C30", Slot = "11")]
	public IDisposable FGFBBPKLBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6376E00", Offset = "0x6375C00", VA = "0x186376E00", Slot = "8")]
	public void MCEDHLFDABL(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6376DF0", Offset = "0x6375BF0", VA = "0x186376DF0", Slot = "9")]
	public void JKFBAFAINKO(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6376A30", Offset = "0x6375830", VA = "0x186376A30", Slot = "10")]
	public void CCBCCKMBDMC(object HOBAPMCPFML, bool MOOGEOGEGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6376B40", Offset = "0x6375940", VA = "0x186376B40", Slot = "6")]
	public void DJIGGBDAAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6376CD0", Offset = "0x6375AD0", VA = "0x186376CD0", Slot = "12")]
	public void ICJDCDNGPJB(Rigidbody EIODOLNINOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6376CA0", Offset = "0x6375AA0", VA = "0x186376CA0", Slot = "13")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class NGDEOAGDDOL : ONJEBBPDAOE, FOOLOBIMAJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView FGKNBKAADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CLGELINCLPO;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView IMNBGDKNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool DFPNLCKAGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6369ED0", Offset = "0x6368CD0", VA = "0x186369ED0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool PPGMAIOCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x81DA80", Offset = "0x81C880", VA = "0x18081DA80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event ADLOFIFALML JLKKFJLKABL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6389310", Offset = "0x6388110", VA = "0x186389310", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6388820", Offset = "0x6387620", VA = "0x186388820", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x63893B0", Offset = "0x63881B0", VA = "0x1863893B0")]
	public NGDEOAGDDOL(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6388B30", Offset = "0x6387930", VA = "0x186388B30", Slot = "9")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x63888C0", Offset = "0x63876C0", VA = "0x1863888C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6389030", Offset = "0x6387E30", VA = "0x186389030", Slot = "10")]
	public void KCNEHDKFDOC(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x63889C0", Offset = "0x63877C0", VA = "0x1863889C0", Slot = "11")]
	public void FFCCJHIBMFG(EMCMNBFGMOJ BMNEKBHDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x63891A0", Offset = "0x6387FA0", VA = "0x1863891A0")]
	private void LLINDCMKBKN(PhotonView JAAPACPBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6388C60", Offset = "0x6387A60", VA = "0x186388C60")]
	private void HCFCBMEINOI(RigidbodyEx JOMMNELLGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6388DC0", Offset = "0x6387BC0", VA = "0x186388DC0")]
	private void ICJLEFCHAOF(PhotonView KOOMADEJOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class GCCHHHLBKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6375260", Offset = "0x6374060", VA = "0x186375260")]
	public static ONJEBBPDAOE FCFPELJBBCE(this EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class BDINJGJGEII : AFFFHOOGEHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints JNMHKCCLGIN;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool DCBCEHHGOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8D150", VA = "0x180A8E350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3CF75D0", Offset = "0x3CF63D0", VA = "0x183CF75D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool LFJFEBCNDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B190", Offset = "0x1A79F90", VA = "0x181A7B190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF75C0", Offset = "0x3CF63C0", VA = "0x183CF75C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints HJLMJCJKMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x636A4C0", Offset = "0x63692C0", VA = "0x18636A4C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x636A650", Offset = "0x6369450", VA = "0x18636A650")]
	public BDINJGJGEII(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x636A620", Offset = "0x6369420", VA = "0x18636A620", Slot = "9")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x636A5F0", Offset = "0x63693F0", VA = "0x18636A5F0", Slot = "10")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class BKBPODIGPGN : BONLMHAGDFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly EMCMNBFGMOJ GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float JPHBLGKAJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float LGEDOIMNJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float AJCBNLHBOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x83BB90", Offset = "0x83A990", VA = "0x18083BB90", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x636A700", Offset = "0x6369500", VA = "0x18636A700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float ACICDEAJDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF40", Offset = "0x8DDD40", VA = "0x1808DEF40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x636A870", Offset = "0x6369670", VA = "0x18636A870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x636A990", Offset = "0x6369790", VA = "0x18636A990")]
	public BKBPODIGPGN(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x636A940", Offset = "0x6369740", VA = "0x18636A940", Slot = "8")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x636A7D0", Offset = "0x63695D0", VA = "0x18636A7D0", Slot = "9")]
	public void HJCJJADNAJH(Rigidbody FAMGBCAKFFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class GDLHEMLNJPN : FANHOHBHDML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool JIOLHAAJHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool IJIDMACADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int DBDGIIGOPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6375500", Offset = "0x6374300", VA = "0x186375500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool PLCGLFFIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x63757A0", Offset = "0x63745A0", VA = "0x1863757A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private EMCMNBFGMOJ ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x63759F0", Offset = "0x63747F0", VA = "0x1863759F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6375AE0", Offset = "0x63748E0", VA = "0x186375AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ADLOFIFALML MPCFCPDAGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6375700", Offset = "0x6374500", VA = "0x186375700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6375B40", Offset = "0x6374940", VA = "0x186375B40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6375E30", Offset = "0x6374C30", VA = "0x186375E30")]
	public GDLHEMLNJPN(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6375A50", Offset = "0x6374850", VA = "0x186375A50", Slot = "6")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6375CD0", Offset = "0x6374AD0", VA = "0x186375CD0", Slot = "8")]
	public void MKCHGGIFKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6375CE0", Offset = "0x6374AE0", VA = "0x186375CE0", Slot = "7")]
	public bool PLJANFJFEMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x63757C0", Offset = "0x63745C0", VA = "0x1863757C0", Slot = "9")]
	public void FJFKBEBNLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6375BE0", Offset = "0x63749E0", VA = "0x186375BE0", Slot = "11")]
	public void KLDGMKJDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6375C80", Offset = "0x6374A80", VA = "0x186375C80", Slot = "12")]
	public void LCPNCLELBKA(bool OAKMGPFAMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6375550", Offset = "0x6374350", VA = "0x186375550", Slot = "10")]
	public void CILCIHEOIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6375320", Offset = "0x6374120", VA = "0x186375320")]
	private bool BNNMPFLHCKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6375860", Offset = "0x6374660", VA = "0x186375860")]
	private void FMCCOFBBGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DBHJAHHHKKL : NLELMMAENGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly FMCHKOLFDCF EDLIHFPCNFI;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody PDOCOAKHMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool JFHDEHHGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x636CCD0", Offset = "0x636BAD0", VA = "0x18636CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool PHJAAPKPCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xC74ED0", Offset = "0xC73CD0", VA = "0x180C74ED0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x636CD60", Offset = "0x636BB60", VA = "0x18636CD60")]
	public DBHJAHHHKKL(EMCMNBFGMOJ GKOAICANGAP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x636C890", Offset = "0x636B690", VA = "0x18636C890", Slot = "5")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x636CD30", Offset = "0x636BB30", VA = "0x18636CD30", Slot = "7")]
	public void LLKDAJOCJHI(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x636C860", Offset = "0x636B660", VA = "0x18636C860", Slot = "8")]
	public void FMPBJANDFLE(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x636C530", Offset = "0x636B330", VA = "0x18636C530", Slot = "9")]
	public void FANCOGLAPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x636C930", Offset = "0x636B730", VA = "0x18636C930", Slot = "11")]
	public void HHNADBMKLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x636C3B0", Offset = "0x636B1B0", VA = "0x18636C3B0", Slot = "12")]
	public void ENHIEMJKDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x636BF20", Offset = "0x636AD20", VA = "0x18636BF20", Slot = "10")]
	public void EJCHPOPNLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x636CB20", Offset = "0x636B920", VA = "0x18636CB20")]
	private void HPLNHDFJNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x636BD70", Offset = "0x636AB70", VA = "0x18636BD70")]
	private void DHPNAMFEADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class BKOJKMDAIMA : PINEELOCNCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly LMDCMFOLAIH GKOAICANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly FMCHKOLFDCF DPJPFBGHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float EBOMDOOFNJE;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public ANOMGEJPJNN BGBGODEJIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x779B70", Offset = "0x778970", VA = "0x180779B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public PCFACBMAEKA PCPIKHINFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 HCOBKPPECCD
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6393FC0", Offset = "0x6392DC0", VA = "0x186393FC0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6394DB0", Offset = "0x6393BB0", VA = "0x186394DB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 HLGKACMHJON
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6393E70", Offset = "0x6392C70", VA = "0x186393E70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6394860", Offset = "0x6393660", VA = "0x186394860", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 NDEFCMPDFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x63945D0", Offset = "0x63933D0", VA = "0x1863945D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x63947A0", Offset = "0x63935A0", VA = "0x1863947A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 LDPIICELAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63960A0", Offset = "0x6394EA0", VA = "0x1863960A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63962C0", Offset = "0x63950C0", VA = "0x1863962C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float DNILLMAMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA80", Offset = "0x7BC880", VA = "0x1807BDA80", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6393DC0", Offset = "0x6392BC0", VA = "0x186393DC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool KHBKNPPAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1603160", Offset = "0x1601F60", VA = "0x181603160", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private CBHAPCHGCLF DMAELEGFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1C94690", Offset = "0x1C93490", VA = "0x181C94690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool PLCGLFFIHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x636EFF0", Offset = "0x636DDF0", VA = "0x18636EFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x63962F0", Offset = "0x63950F0", VA = "0x1863962F0")]
	public BKOJKMDAIMA(EMCMNBFGMOJ GKOAICANGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63946F0", Offset = "0x63934F0", VA = "0x1863946F0", Slot = "19")]
	public void HAIBKGFNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x6393CF0", Offset = "0x6392AF0", VA = "0x186393CF0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6394890", Offset = "0x6393690", VA = "0x186394890", Slot = "28")]
	public void ICJDCDNGPJB(Rigidbody FAMGBCAKFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xABED40", Offset = "0xABDB40", VA = "0x180ABED40", Slot = "20")]
	public void LEKJJFIIPBG(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xAC0F10", Offset = "0xABFD10", VA = "0x180AC0F10", Slot = "30")]
	public void IKDOBOJHBBP(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6394E70", Offset = "0x6393C70", VA = "0x186394E70", Slot = "35")]
	public Vector3 KEJMEJCHNEO(Vector3 BOBGPABDLGJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6395B50", Offset = "0x6394950", VA = "0x186395B50", Slot = "34")]
	public Vector3 MDPOKMBJJLN(Vector3 OIMALFIAIDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x63946F0", Offset = "0x63934F0", VA = "0x1863946F0", Slot = "27")]
	public void MMFKCDJPKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6393300", Offset = "0x6392100", VA = "0x186393300", Slot = "25")]
	public void APNECOMFKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6393F60", Offset = "0x6392D60", VA = "0x186393F60", Slot = "24")]
	public void EJILHHACMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6393B50", Offset = "0x6392950", VA = "0x186393B50", Slot = "33")]
	public void DHIGCNFNNIC(Vector3 HEOIFOEINBI, Vector3 NPAFKMDOAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x63940E0", Offset = "0x6392EE0", VA = "0x1863940E0", Slot = "32")]
	public void FPGPLJCJELF(Vector3 DIFHGPOEKHJ, Vector3 DHNAJHLJMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6395CA0", Offset = "0x6394AA0", VA = "0x186395CA0", Slot = "31")]
	public void MFGJMLOMFAI(Vector3 OMNKCHLMAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6393360", Offset = "0x6392160", VA = "0x186393360", Slot = "22")]
	public void BBJFOGPLDIA(COPIBMJGLBC DINHEIGGAOE, Vector3 KFJLAJKGODK, float CANEAOMIGJC, float HHIEHOEBJJA = 8f, float PEHDMIKCKMD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6395E10", Offset = "0x6394C10", VA = "0x186395E10", Slot = "21")]
	public void ODEFOJCFAAI(LFGDMPDDINM CKODIFBLJGO, Vector3 GHLDCNALGKN, float NLCMLIKOMIC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6394A10", Offset = "0x6393810", VA = "0x186394A10", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JACAHIBMDCB(LFGDMPDDINM CKODIFBLJGO, Vector3 BPBCJFMFECG, float LEBNOAPNBKJ = 7f, float GDLDMIAHGGN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x63959F0", Offset = "0x63947F0", VA = "0x1863959F0", Slot = "29")]
	public Vector3 MCAJKEFGHGP(Vector3 MAEAAOMNFME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6396190", Offset = "0x6394F90", VA = "0x186396190", Slot = "26")]
	public void PEONNDNLACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6393DC0", Offset = "0x6392BC0", VA = "0x186393DC0")]
	private void EDKNCGIBMPL(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6394FE0", Offset = "0x6393DE0", VA = "0x186394FE0")]
	private void KKFAFNCNJFF(Vector3 GHLDCNALGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6393990", Offset = "0x6392790", VA = "0x186393990")]
	private Vector3 CHJGLDEMPFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6395590", Offset = "0x6394390", VA = "0x186395590")]
	private void LMPMJOIFNLK(Vector3 OIMALFIAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6393A70", Offset = "0x6392870", VA = "0x186393A70")]
	private Vector3 DALAGMNOGAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6395150", Offset = "0x6393F50", VA = "0x186395150")]
	private void LKCDPMIDEPE(Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6394140", Offset = "0x6392F40", VA = "0x186394140")]
	private void GDLKIDFHOCP(Vector3 OIMALFIAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6394960", Offset = "0x6393760", VA = "0x186394960")]
	private void IJNEAOKDBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EEHINIEHFIE : MCDLIBHCKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6396760", Offset = "0x6395560", VA = "0x186396760", Slot = "4")]
	public MAGCAHIOFOP KEBDCNFDDKC(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x63964E0", Offset = "0x63952E0", VA = "0x1863964E0", Slot = "5")]
	public PINEELOCNCE CNMCOJOMHGO(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6396880", Offset = "0x6395680", VA = "0x186396880", Slot = "6")]
	public IIOPHLLHJLP NEJLKPFFJDK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6396940", Offset = "0x6395740", VA = "0x186396940", Slot = "7")]
	public BONLMHAGDFE OHHLCLBFMPK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x63965C0", Offset = "0x63953C0", VA = "0x1863965C0", Slot = "8")]
	public FANHOHBHDML GJPLCHOCPFA(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x63967C0", Offset = "0x63955C0", VA = "0x1863967C0", Slot = "9")]
	public GAIKMIPBMEJ KECDNNHGOFH(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6396690", Offset = "0x6395490", VA = "0x186396690", Slot = "10")]
	public HLBLIKOPBKE JLKHOICOFKJ(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x63968E0", Offset = "0x63956E0", VA = "0x1863968E0", Slot = "11")]
	public CBHAPCHGCLF ODEKABJAHGI(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6396820", Offset = "0x6395620", VA = "0x186396820", Slot = "12")]
	public NBIOCGFCHNB LBICFLLECIK(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6396A50", Offset = "0x6395850", VA = "0x186396A50", Slot = "13")]
	public NGHLNFILAAA PHBIILBFPPG(EMCMNBFGMOJ DDAGOAKHODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6396390", Offset = "0x6395190", VA = "0x186396390")]
	public NLELMMAENGH AHIHFMCKLNA(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6396470", Offset = "0x6395270", VA = "0x186396470")]
	public FOOLOBIMAJA CKBBNCCHKJF(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6396400", Offset = "0x6395200", VA = "0x186396400")]
	public BHDHMDJKJKI ANNLDOPNBJD(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6396620", Offset = "0x6395420", VA = "0x186396620")]
	public GGBBHEDCLGE IAEABBEMICJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x63966F0", Offset = "0x63954F0", VA = "0x1863966F0")]
	public AFFFHOOGEHK MJNJGFCAADJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x63969A0", Offset = "0x63957A0", VA = "0x1863969A0", Slot = "19")]
	public EMCMNBFGMOJ OKEKIOJHMPE(RigidbodyEx GKOAICANGAP, EDIDBFLBAIC KNAIEKIJLBC, HOIBMFNJHPD LBHKILDBCNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EEHINIEHFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6396390", Offset = "0x6395190", VA = "0x186396390", Slot = "14")]
	private NLELMMAENGH GJFGMKFIBNJ(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6396470", Offset = "0x6395270", VA = "0x186396470", Slot = "15")]
	private FOOLOBIMAJA AOPKEOCEFBO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6396400", Offset = "0x6395200", VA = "0x186396400", Slot = "16")]
	private BHDHMDJKJKI MLPMMMBEDED(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6396620", Offset = "0x6395420", VA = "0x186396620", Slot = "17")]
	private GGBBHEDCLGE NHAJDAPJFAO(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x63966F0", Offset = "0x63954F0", VA = "0x1863966F0", Slot = "18")]
	private AFFFHOOGEHK KAACAELPKJP(EMCMNBFGMOJ DDAGOAKHODP, [In] EDIDBFLBAIC KNAIEKIJLBC)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : IMHCJPKCGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6396AB0", Offset = "0x63958B0", VA = "0x186396AB0", Slot = "6")]
		public sealed override void PGPOIJFPEMI(MACKNKFCFBE PJJEKPONKPF)
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
