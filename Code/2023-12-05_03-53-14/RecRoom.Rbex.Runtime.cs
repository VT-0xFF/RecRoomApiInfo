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
public delegate void AICPJBKLFIE(RigidbodyEx MJLDBJKOKLK);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OMAFPFMLLJP(RigidbodyEx MJLDBJKOKLK, bool NGKDPLNJHNP = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BBPFHADMICB
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
public enum ONEAPANLNJE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HLEAAEFHLHA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JAHFMFEHFPG(typeof(MOOHOCAHMHP), new string[] { "Ignore", "Mock" })]
public class KMGOJOICMGN : MOOHOCAHMHP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MFIKMBBIPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C5050", Offset = "0x7C4450", VA = "0x1807C5050", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
	public void PODIKEGJFFJ(string HCMLCAPJMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
	public void GBLINKAGFIP(RigidbodyEx KCDNLAJONGP, Action ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "7")]
	public IPCOLFCLNPN GHOCLFKCDEK(int IPKKMDNNJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void KCLIHBFGFND(Vector3 GPHFNLGICPE, float KNFLOOBGDOB, Color DDJLPLIEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public KMGOJOICMGN()
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
		private static readonly GBIKKFKHKKF IAKONGMEBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool GFNNJINGONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ICFPGDKKBGP CJKMCELIAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ABALMBEBCPA(BLCCKOBNIPN.SelfAndParent, true, false, false)]
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
		private ONEAPANLNJE physicsInterpolation;

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
		internal ICFPGDKKBGP NPDNHPEDODE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x63B5AD0", Offset = "0x63B4ED0", VA = "0x1863B5AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> AAHFLMHFOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x779420", Offset = "0x778820", VA = "0x180779420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x779410", Offset = "0x778810", VA = "0x180779410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx ODCJLDNBHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63B7D00", Offset = "0x63B7100", VA = "0x1863B7D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx MINGBKNACHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63B7C60", Offset = "0x63B7060", VA = "0x1863B7C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ECLIMLPEPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63B8920", Offset = "0x63B7D20", VA = "0x1863B8920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63B9EA0", Offset = "0x63B92A0", VA = "0x1863B9EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform FFGCBKHBPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x79A6B0", Offset = "0x799AB0", VA = "0x18079A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform NDJLEDALOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x79A6B0", Offset = "0x799AB0", VA = "0x18079A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FMGKNGKCHKA PGLPBIIJIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63B7A20", Offset = "0x63B6E20", VA = "0x1863B7A20")]
			get
			{
				return default(FMGKNGKCHKA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63B9650", Offset = "0x63B8A50", VA = "0x1863B9650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FDDKBEAFMGO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63B7FB0", Offset = "0x63B73B0", VA = "0x1863B7FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FNCCAFCGMHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63B7B40", Offset = "0x63B6F40", VA = "0x1863B7B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public PGLGBIMHNJM GBPDKCLBHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63B7EF0", Offset = "0x63B72F0", VA = "0x1863B7EF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63B9810", Offset = "0x63B8C10", VA = "0x1863B9810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GJPMCECLNCD IGLHNONNELH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E90", Offset = "0x63B7290", VA = "0x1863B7E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63B97A0", Offset = "0x63B8BA0", VA = "0x1863B97A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NBMBLIKAPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63B7DE0", Offset = "0x63B71E0", VA = "0x1863B7DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody EMGDMOALHEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E40", Offset = "0x63B7240", VA = "0x1863B7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LCHHEKPIDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63B7BA0", Offset = "0x63B6FA0", VA = "0x1863B7BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63B96C0", Offset = "0x63B8AC0", VA = "0x1863B96C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PMIOGHNBPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1B21BE0", Offset = "0x1B20FE0", VA = "0x181B21BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5C00E70", Offset = "0x5C00270", VA = "0x185C00E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float MCBMFOOILNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63B88C0", Offset = "0x63B7CC0", VA = "0x1863B88C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EIIHKNLMHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63B8860", Offset = "0x63B7C60", VA = "0x1863B8860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63B9E30", Offset = "0x63B9230", VA = "0x1863B9E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NNEGLBPLAIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8210", Offset = "0x63B7610", VA = "0x1863B8210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63B9AB0", Offset = "0x63B8EB0", VA = "0x1863B9AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ANFOAPMCLNA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8010", Offset = "0x63B7410", VA = "0x1863B8010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63B9880", Offset = "0x63B8C80", VA = "0x1863B9880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool KIINDGOBPOF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8E80", Offset = "0x63B8280", VA = "0x1863B8E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63BA400", Offset = "0x63B9800", VA = "0x1863BA400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 MMONBLLDCOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63B8640", Offset = "0x63B7A40", VA = "0x1863B8640")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63B9C00", Offset = "0x63B9000", VA = "0x1863B9C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 GPHFNLGICPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63B8FC0", Offset = "0x63B83C0", VA = "0x1863B8FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode BCIBGLLPIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63B8150", Offset = "0x63B7550", VA = "0x1863B8150")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63B99D0", Offset = "0x63B8DD0", VA = "0x1863B99D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NIEEABCANCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63B7C00", Offset = "0x63B7000", VA = "0x1863B7C00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63B9730", Offset = "0x63B8B30", VA = "0x1863B9730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IODIGGIIFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63B81B0", Offset = "0x63B75B0", VA = "0x1863B81B0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63B9A40", Offset = "0x63B8E40", VA = "0x1863B9A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 MAECLDPPLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63B89C0", Offset = "0x63B7DC0", VA = "0x1863B89C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 BLDPHBMHNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63B89C0", Offset = "0x63B7DC0", VA = "0x1863B89C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63BA1E0", Offset = "0x63B95E0", VA = "0x1863BA1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CBMHIKLPFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8720", Offset = "0x63B7B20", VA = "0x1863B8720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63B9CE0", Offset = "0x63B90E0", VA = "0x1863B9CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IJNDHAAJICE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8E20", Offset = "0x63B8220", VA = "0x1863B8E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63BA390", Offset = "0x63B9790", VA = "0x1863BA390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion KOFLIHLHMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63B8AA0", Offset = "0x63B7EA0", VA = "0x1863B8AA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63B9F60", Offset = "0x63B9360", VA = "0x1863B9F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion LKCCACCAEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63B8D40", Offset = "0x63B8140", VA = "0x1863B8D40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63BA2C0", Offset = "0x63B96C0", VA = "0x1863BA2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 OHGFAJEHGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63B8B80", Offset = "0x63B7F80", VA = "0x1863B8B80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63BA030", Offset = "0x63B9430", VA = "0x1863BA030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion KICFMJNDEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63B8C60", Offset = "0x63B8060", VA = "0x1863B8C60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63BA110", Offset = "0x63B9510", VA = "0x1863BA110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 JFJFCLDIDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63B8EE0", Offset = "0x63B82E0", VA = "0x1863B8EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63BA470", Offset = "0x63B9870", VA = "0x1863BA470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 AONAEDFHDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8780", Offset = "0x63B7B80", VA = "0x1863B8780")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63B9D50", Offset = "0x63B9150", VA = "0x1863B9D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 ANBOFBNCNAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63B8070", Offset = "0x63B7470", VA = "0x1863B8070")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63B98F0", Offset = "0x63B8CF0", VA = "0x1863B98F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DDBAELMPNOK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8560", Offset = "0x63B7960", VA = "0x1863B8560")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x63B9B20", Offset = "0x63B8F20", VA = "0x1863B9B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 GPDJMCLJAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x63B8420", Offset = "0x63B7820", VA = "0x1863B8420")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion ICOOKEIONCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63B8340", Offset = "0x63B7740", VA = "0x1863B8340")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 IFEGOLILFLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63B9180", Offset = "0x63B8580", VA = "0x1863B9180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IIPNEABBCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63B90A0", Offset = "0x63B84A0", VA = "0x1863B90A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NPKCHKNPJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63B8500", Offset = "0x63B7900", VA = "0x1863B8500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JDNDBOOEEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F50", Offset = "0x63B7350", VA = "0x1863B7F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GPFEEAIDLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63B7AE0", Offset = "0x63B6EE0", VA = "0x1863B7AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LINHKHGFPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63B7A80", Offset = "0x63B6E80", VA = "0x1863B7A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NODACHMKIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63B79C0", Offset = "0x63B6DC0", VA = "0x1863B79C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NHODLJMILAG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8270", Offset = "0x63B7670", VA = "0x1863B8270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EJJHGBIINJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3960", Offset = "0x4FC2D60", VA = "0x184FC3960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AICPJBKLFIE KNBPAFKMOAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63B78E0", Offset = "0x63B6CE0", VA = "0x1863B78E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x63B9570", Offset = "0x63B8970", VA = "0x1863B9570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OMAFPFMLLJP GHHPICANOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63B7870", Offset = "0x63B6C70", VA = "0x1863B7870")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63B9500", Offset = "0x63B8900", VA = "0x1863B9500")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event AICPJBKLFIE KKECCHNDKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63B75D0", Offset = "0x63B69D0", VA = "0x1863B75D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63B9260", Offset = "0x63B8660", VA = "0x1863B9260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event AICPJBKLFIE CCHCPKBPHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63B7640", Offset = "0x63B6A40", VA = "0x1863B7640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63B92D0", Offset = "0x63B86D0", VA = "0x1863B92D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event AICPJBKLFIE FJAPHPBALIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63B7790", Offset = "0x63B6B90", VA = "0x1863B7790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x63B9420", Offset = "0x63B8820", VA = "0x1863B9420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63B7720", Offset = "0x63B6B20", VA = "0x1863B7720")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63B93B0", Offset = "0x63B87B0", VA = "0x1863B93B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event AICPJBKLFIE LFCJDEHANOM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63B7800", Offset = "0x63B6C00", VA = "0x1863B7800")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63B9490", Offset = "0x63B8890", VA = "0x1863B9490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event AICPJBKLFIE PPGMMDDCOFI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63B7950", Offset = "0x63B6D50", VA = "0x1863B7950")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63B95E0", Offset = "0x63B89E0", VA = "0x1863B95E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event AICPJBKLFIE KNNHJHALDOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63B76B0", Offset = "0x63B6AB0", VA = "0x1863B76B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63B9340", Offset = "0x63B8740", VA = "0x1863B9340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
		internal void FELFKLACDPC(ICFPGDKKBGP KAAAMIPABJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5D60", Offset = "0x63B5160", VA = "0x1863B5D60")]
		internal void EMOCMEOBDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B72F0", Offset = "0x63B66F0", VA = "0x1863B72F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EAFNFHKEBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63B6FC0", Offset = "0x63B63C0", VA = "0x1863B6FC0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CEAIKJHDEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5A00", Offset = "0x63B4E00", VA = "0x1863B5A00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5AD0", Offset = "0x63B4ED0", VA = "0x1863B5AD0")]
		private ICFPGDKKBGP CGLJKGAGFML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63B6010", Offset = "0x63B5410", VA = "0x1863B6010")]
		private void IOFGIHBGGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63B6790", Offset = "0x63B5B90", VA = "0x1863B6790")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63B5D60", Offset = "0x63B5160", VA = "0x1863B5D60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63B6730", Offset = "0x63B5B30", VA = "0x1863B6730")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63B67F0", Offset = "0x63B5BF0", VA = "0x1863B67F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63B50B0", Offset = "0x63B44B0", VA = "0x1863B50B0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63B6850", Offset = "0x63B5C50", VA = "0x1863B6850")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63B5D00", Offset = "0x63B5100", VA = "0x1863B5D00")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63B66D0", Offset = "0x63B5AD0", VA = "0x1863B66D0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63B7120", Offset = "0x63B6520", VA = "0x1863B7120")]
		public void SetParent(RigidbodyEx NMENOOMOOJP, bool NGKDPLNJHNP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63B6B60", Offset = "0x63B5F60", VA = "0x1863B6B60")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63B63A0", Offset = "0x63B57A0", VA = "0x1863B63A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GGLPCIOOICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63B6480", Offset = "0x63B5880", VA = "0x1863B6480")]
		public bool IsRigidbodyDescendant(RigidbodyEx KHKDHLBKBPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5320", Offset = "0x63B4720", VA = "0x1863B5320")]
		public void AddInterpolationRestriction(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63B68C0", Offset = "0x63B5CC0", VA = "0x1863B68C0")]
		public void RemoveInterpolationRestriction(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63B5A70", Offset = "0x63B4E70", VA = "0x1863B5A70")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63B5390", Offset = "0x63B4790", VA = "0x1863B5390")]
		public void AddKinematic(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63B6930", Offset = "0x63B5D30", VA = "0x1863B6930")]
		public void RemoveKinematic(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63B70A0", Offset = "0x63B64A0", VA = "0x1863B70A0")]
		public void SetKinematic(object NOEAHPPKHNC, bool MPOAPDJGAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63B6EC0", Offset = "0x63B62C0", VA = "0x1863B6EC0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IHPFEGHCFFP, Quaternion ANHMGCLDJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63B6DC0", Offset = "0x63B61C0", VA = "0x1863B6DC0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 CMMBCMGJFFP, Quaternion AHLGILNAJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63B5F00", Offset = "0x63B5300", VA = "0x1863B5F00")]
		public Vector3 GetConstrainedVelocity(Vector3 JFJFCLDIDKG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63B5DF0", Offset = "0x63B51F0", VA = "0x1863B5DF0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 ANBOFBNCNAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63B5230", Offset = "0x63B4630", VA = "0x1863B5230")]
		public void AddForce(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63B5120", Offset = "0x63B4520", VA = "0x1863B5120")]
		public void AddForceAtPosition(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63B5560", Offset = "0x63B4960", VA = "0x1863B5560")]
		public void AddTorque(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63B5400", Offset = "0x63B4800", VA = "0x1863B5400")]
		public void AddRelativeTorque(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63B73C0", Offset = "0x63B67C0", VA = "0x1863B73C0")]
		public Vector3 WorldToLocalVelocity(Vector3 GDAJPKMGPIM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63B65C0", Offset = "0x63B59C0", VA = "0x1863B65C0")]
		public Vector3 LocalToWorldVelocity(Vector3 AONAEDFHDDF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5CA0", Offset = "0x63B50A0", VA = "0x1863B5CA0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5C40", Offset = "0x63B5040", VA = "0x1863B5C40")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63B5BE0", Offset = "0x63B4FE0", VA = "0x1863B5BE0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B80", Offset = "0x63B4F80", VA = "0x1863B5B80")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63B6CC0", Offset = "0x63B60C0", VA = "0x1863B6CC0")]
		public void ResetVelocityWorldSpace(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63B6BC0", Offset = "0x63B5FC0", VA = "0x1863B6BC0")]
		public void ResetVelocityLocalSpace(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63B6A80", Offset = "0x63B5E80", VA = "0x1863B6A80")]
		public void ResetLinearVelocityLocalSpace(Vector3 LKJEBIEGPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63B7250", Offset = "0x63B6650", VA = "0x1863B7250")]
		public bool SweepTest(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x63B6560", Offset = "0x63B5960", VA = "0x1863B6560")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63B71F0", Offset = "0x63B65F0", VA = "0x1863B71F0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x63B7360", Offset = "0x63B6760", VA = "0x1863B7360")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63B54F0", Offset = "0x63B48F0", VA = "0x1863B54F0")]
		public void AddShouldHaveUnityRigidbodyToken(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63B69A0", Offset = "0x63B5DA0", VA = "0x1863B69A0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63B5890", Offset = "0x63B4C90", VA = "0x1863B5890")]
		public void ApplyForceVelocityChange(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63B57F0", Offset = "0x63B4BF0", VA = "0x1863B57F0")]
		public void ApplyAngularVelocityChange(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63B5950", Offset = "0x63B4D50", VA = "0x1863B5950")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63B5720", Offset = "0x63B4B20", VA = "0x1863B5720")]
		public bool AllowedScaleChange(float KMHALLDFFIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5650", Offset = "0x63B4A50", VA = "0x1863B5650")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KFLLOGAOMPJ, object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x63B6A10", Offset = "0x63B5E10", VA = "0x1863B6A10")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63B7560", Offset = "0x63B6960", VA = "0x1863B7560")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class NFIOJPCDOEN
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63B1A50", Offset = "0x63B0E50", VA = "0x1863B1A50")]
	public static ICFPGDKKBGP NPDNHPEDODE(this RigidbodyEx KCDNLAJONGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JJOFCHEKAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody OIFEKCCFJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView AEABNKPIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 MHPKAMFOODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 KGMLOJABECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ONEAPANLNJE ICBKLKBBNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool HLIIFLIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool IOLMKBFNPCB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JAHFMFEHFPG(typeof(FBMJPJJHLGH), new string[] { })]
public class OMAEEBBLNAF : FBMJPJJHLGH, BFJKHKFONLF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly GBIKKFKHKKF BLHBFCHIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JGMHDCMFALE MFEFNNBCMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MOOHOCAHMHP MNLFLOOOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EKLDHFPGOCP FDFPJLPLGBI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MOOHOCAHMHP GGPMPLPOPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EKLDHFPGOCP PNJGAFPBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x63B39C0", Offset = "0x63B2DC0", VA = "0x1863B39C0", Slot = "8")]
	public void InitReferences(DCDICCBPDIP KAPGNOEILJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63B3670", Offset = "0x63B2A70", VA = "0x1863B3670", Slot = "6")]
	public HKGGDKBPMDI BDFECBOCAFL(RigidbodyEx KCDNLAJONGP)
	{
		return default(HKGGDKBPMDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63B3A50", Offset = "0x63B2E50", VA = "0x1863B3A50")]
	private static HKGGDKBPMDI OEPIMAIOIFH(RigidbodyEx KCDNLAJONGP)
	{
		return default(HKGGDKBPMDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63B3920", Offset = "0x63B2D20", VA = "0x1863B3920", Slot = "7")]
	public ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OMAEEBBLNAF()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static FCJKIAIKOOM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int OJKOJEPONGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int BKDOPIBLANA;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F10", Offset = "0x63B4310", VA = "0x1863B4F10")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F50", Offset = "0x63B4350", VA = "0x1863B4F50")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F30", Offset = "0x63B4330", VA = "0x1863B4F30")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KCFFPPIEBHH, [Optional] UnityEngine.Object LAACBMJOJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KCFFPPIEBHH, [Optional] UnityEngine.Object LAACBMJOJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x63B5060", Offset = "0x63B4460", VA = "0x1863B5060")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JEBBACNIPNB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A9560", Offset = "0x63A8960", VA = "0x1863A9560")]
	public static void FLMEJHNOBLL(this Rigidbody EAFNFHKEBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A9430", Offset = "0x63A8830", VA = "0x1863A9430")]
	public static void FLMEJHNOBLL(this Rigidbody EAFNFHKEBCJ, Vector3 JGKLHPJJGMM, Quaternion ICOOKEIONCJ, Vector3 HACNLDNJAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xBD52C0", Offset = "0xBD46C0", VA = "0x180BD52C0")]
	public static void IDDAMELKMFO(Vector3 JFJFCLDIDKG, Vector3 CEGMEAOIEDE, [Out] Vector3 DKMOMOJIOKC, [Out] Vector3 OHEIFOMHLMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ECCNLCEMPFI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class LBMBFPHPKDP : PGLGBIMHNJM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780D90", VA = "0x180781990", Slot = "4")]
		public Vector3 KNAEMCAHKJF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780D90", VA = "0x180781990", Slot = "5")]
		public Vector3 DEIBNHPNDEO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public LBMBFPHPKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static PGLGBIMHNJM FNDHDFOJDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x639E000", Offset = "0x639D400", VA = "0x18639E000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ICFDECEDHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode CKFGIJJLEBD
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
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACNNIBMMJFD(bool NPKCHKNPJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAMPHBLLMEL(bool NPKCHKNPJJK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PGIDKFABEEC : IDisposable, BHBELFGOFDE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFDBKDGFIEF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OLPAKKNBCIO(ACGEPJDCHDF.Application)]
public interface EKLDHFPGOCP
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFGCCEDHLIL JIJFFKBFPBM(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKFFIHCIBHD OJNGPDGKPPE(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKPBNHCJCIE BIEIOLHOIIM(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOKEAJKLLAI NMOFCNJOCAP(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPACJHBBKKN BMBBHMHGCNE(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PGIDKFABEEC KIJDBHBKPFI(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DGDOICOHCDA MDCMEEEJKFL(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BPAIIGGILLB FNMBFHDNJKN(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICFDECEDHMM IBOLLDBNEJP(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MONEDGACANN OJPOLAIFPEN(ICFPGDKKBGP KAAAMIPABJJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IDBCPFELODG IBCDKMMAEBB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FKBLGLANPPF LPOACLBPCNE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PMKCMJMKHAP HNFDOKNJCEG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OFFBAHLFJMB OGCLEFABCBF(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MIIACLHADEK BBLCCHFHENE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML, FBMJPJJHLGH CHJDMKIKGKN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BPAIIGGILLB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MONEDGACANN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AFFFHGMBDCK
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
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OFGCCEDHLIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event AICPJBKLFIE KKECCHNDKGD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event AICPJBKLFIE CCHCPKBPHBK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event OMAFPFMLLJP PIEGFFNMFNG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action ANNDJPHDDLJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action MFJDFMGEGID;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ICFPGDKKBGP> IGADELJFBCC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<ICFPGDKKBGP> OCKOEPPCOGH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action LBFGGLNKKCC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ICFPGDKKBGP> FKKHFCECCOO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GLBLGOBNEIM(ICFPGDKKBGP IPAKJOEMEMJ, bool NGKDPLNJHNP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EKPBNHCJCIE
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLDPGKEOIJM(ICFPGDKKBGP ECLIMLPEPIL, object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCNLBAHLFGI(object NOEAHPPKHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OFFBAHLFJMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event AICPJBKLFIE HEOKNADEGMH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KGDFDLMMMNK();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGIIEMCKJGF();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GJNOGKFILAH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FAIMLGMFIMH();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PMKCMJMKHAP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGDIGDMDKDJ(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMEAPNCALHG(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MELPNEILEKM(ICFPGDKKBGP KCDNLAJONGP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJKJLEGGKHD(ICFPGDKKBGP KCDNLAJONGP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJIJDMLGBGC();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DGDOICOHCDA
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event AICPJBKLFIE BFNAAFIEIDB;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMLPBENBIOF();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDKCEJCAFOF(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCLMMKEAPGE(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GOCOIDHEHAE();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MFFKFLDHFNP(Rigidbody FFEOMAPAFKC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FKBLGLANPPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event AICPJBKLFIE FEOJNOADJGJ;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKMMLNJAPOH(ICFPGDKKBGP ECLIMLPEPIL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CEFGODPLJGI(ICFPGDKKBGP ECLIMLPEPIL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MIIACLHADEK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OKPJCEDMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints JHJMNPGKDEL
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
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface HOKEAJKLLAI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float HCHBBGGHHID
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
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FIFDGLGICNH
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JEPDODPPLIE);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DPACJHBBKKN
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event AICPJBKLFIE FCHPCGANJBI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHNFPAICIDL();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPDECJEEICI();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIHAPLNAKKL();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FPDGJLLPHDF();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AIIHJBFHHGM();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIEKNBHPEIL(bool LJMHPFKDFPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IDBCPFELODG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool AAAGLJNBMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMLHLOOFFLA(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNKNHPHAGKC(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDMEFFJJELA();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCDBPBEOGNI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HKFFIHCIBHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LLAHKLCFBKG(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LCKNGBOBFGN();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AAMBKEKJMCO();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NLBHAJLPHIO();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OKBLDPIEBDG();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JENKCOJBPIC(Vector3 JFJFCLDIDKG);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ENLFJMDEOKO(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JGABFILEGCD(Vector3 ICPNFOPKJEE);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OLPAKKNBCIO(ACGEPJDCHDF.Application)]
public interface MOOHOCAHMHP
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MFIKMBBIPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PODIKEGJFFJ(string HCMLCAPJMPH);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBLINKAGFIP(RigidbodyEx KCDNLAJONGP, Action ONCLGAMIHNG);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IPCOLFCLNPN GHOCLFKCDEK(int IPKKMDNNJPI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCLIHBFGFND(Vector3 GPHFNLGICPE, float KNFLOOBGDOB, Color DDJLPLIEHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OLPAKKNBCIO(ACGEPJDCHDF.Application)]
public interface FBMJPJJHLGH
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	MOOHOCAHMHP GGPMPLPOPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EKLDHFPGOCP PNJGAFPBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKGGDKBPMDI BDFECBOCAFL(RigidbodyEx KCDNLAJONGP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GJPMCECLNCD
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBDJDPFPKPC(Vector3 BNECHMBBOMN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EADABCKPDIK(Vector3 ANBOFBNCNAD);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFKIAHBENFH(Vector3 BNECHMBBOMN);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOKCIBJNNCJ(Vector3 ANBOFBNCNAD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PGLGBIMHNJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 KNAEMCAHKJF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DEIBNHPNDEO();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ICFPGDKKBGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx BOMMBDPFBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject JPJEGCALIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform DIGGJCGKIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool LINHKHGFPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool NODACHMKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float HCHBBGGHHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool AFFFHGMBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform NDJLEDALOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 OMGILIJPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float ADHBEPCMAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float DNBOKGBADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion KNDKENIBGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 ELIFPOBKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion NPADIBBPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints JHJMNPGKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode CKFGIJJLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool JDNDBOOEEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event AICPJBKLFIE KKECCHNDKGD;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event AICPJBKLFIE CCHCPKBPHBK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event OMAFPFMLLJP PIEGFFNMFNG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event AICPJBKLFIE FEOJNOADJGJ;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event AICPJBKLFIE FJAPHPBALIM;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event AICPJBKLFIE FCHPCGANJBI;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event AICPJBKLFIE BFNAAFIEIDB;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event AICPJBKLFIE KNNHJHALDOP;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void KFDBKDGFIEF();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void CPJNJCCDEOB();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JODGJHANFDF();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void KIHAPLNAKKL();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void GLBLGOBNEIM(ICFPGDKKBGP NMENOOMOOJP, bool NGKDPLNJHNP = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void DCAFBPNBIHO(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void CIHDKGPJACD(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void OKBLDPIEBDG();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void AAMBKEKJMCO();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void LCKNGBOBFGN();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JGABFILEGCD(Vector3 ICPNFOPKJEE);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 JENKCOJBPIC(Vector3 NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 LEGIPCHPMON(Vector3 NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NLBHAJLPHIO();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CGBDKPFEPMG(ICFPGDKKBGP KFLLOGAOMPJ, object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KDDEECOCLNO(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void FGIIEMCKJGF();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void KGDFDLMMMNK();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GJNOGKFILAH();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DHNFPAICIDL();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void AIIHJBFHHGM();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable GOCOIDHEHAE();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IDKCEJCAFOF(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CCLMMKEAPGE(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void KAMCNAELNAL(Vector3 IHPFEGHCFFP, Quaternion ANHMGCLDJKN);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LNDGMFPCHOI(Vector3 CMMBCMGJFFP, Quaternion AHLGILNAJNH);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool OGJHLCNFLJL(float KMHALLDFFIA);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LNKDFHBFMID(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void MPHNFGHPLHA(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void NMLHLOOFFLA(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void KNKNHPHAGKC(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void FAIMLGMFIMH();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HIDAPPCLLAO : ICFPGDKKBGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly FBMJPJJHLGH CHJDMKIKGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal OFGCCEDHLIL HNHKBIACEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal PMKCMJMKHAP EJNMBOGDGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FKBLGLANPPF JEINLPOJPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HKFFIHCIBHD JFJFCLDIDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal EKPBNHCJCIE CHAHKGJNBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal OFFBAHLFJMB GDAPNJGDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal HOKEAJKLLAI MDOCOFBLLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal MONEDGACANN JMGLHFMDMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal DPACJHBBKKN HOGPCECBMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal PGIDKFABEEC GIGFKKDGMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DGDOICOHCDA DNNJIILNFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal BPAIIGGILLB EHGFADNFMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal MIIACLHADEK NNENIMKICAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal IDBCPFELODG OIFEKCCFJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal ICFDECEDHMM NHECKPCBHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable HFABOCIAFGB;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx BOMMBDPFBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x770C10", Offset = "0x770010", VA = "0x180770C10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x770BA0", Offset = "0x76FFA0", VA = "0x180770BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject JPJEGCALIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x837040", Offset = "0x836440", VA = "0x180837040", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x837310", Offset = "0x836710", VA = "0x180837310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform DIGGJCGKIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63A5F00", Offset = "0x63A5300", VA = "0x1863A5F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F90", Offset = "0x63A6390", VA = "0x1863A6F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63A2DC0", Offset = "0x63A21C0", VA = "0x1863A2DC0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x63A5C30", Offset = "0x63A5030", VA = "0x1863A5C30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63A7580", Offset = "0x63A6980", VA = "0x1863A7580", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63A4B20", Offset = "0x63A3F20", VA = "0x1863A4B20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x63A24B0", Offset = "0x63A18B0", VA = "0x1863A24B0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x63A2510", Offset = "0x63A1910", VA = "0x1863A2510", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x63A32D0", Offset = "0x63A26D0", VA = "0x1863A32D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x63A7620", Offset = "0x63A6A20", VA = "0x1863A7620", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x63A50F0", Offset = "0x63A44F0", VA = "0x1863A50F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x63A5150", Offset = "0x63A4550", VA = "0x1863A5150", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x63A37D0", Offset = "0x63A2BD0", VA = "0x1863A37D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x63A7410", Offset = "0x63A6810", VA = "0x1863A7410", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x63A23C0", Offset = "0x63A17C0", VA = "0x1863A23C0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AD0", Offset = "0x63A5ED0", VA = "0x1863A6AD0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x63A3420", Offset = "0x63A2820", VA = "0x1863A3420", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x63A69F0", Offset = "0x63A5DF0", VA = "0x1863A69F0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x63A2B50", Offset = "0x63A1F50", VA = "0x1863A2B50", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3A00", Offset = "0x63A2E00", VA = "0x1863A3A00", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x63A2C90", Offset = "0x63A2090", VA = "0x1863A2C90", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x63A4150", Offset = "0x63A3550", VA = "0x1863A4150", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x63A6660", Offset = "0x63A5A60", VA = "0x1863A6660", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GPFEEAIDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x63A2A40", Offset = "0x63A1E40", VA = "0x1863A2A40", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LINHKHGFPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x63A5650", Offset = "0x63A4A50", VA = "0x1863A5650", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NODACHMKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x63A36F0", Offset = "0x63A2AF0", VA = "0x1863A36F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x63A77E0", Offset = "0x63A6BE0", VA = "0x1863A77E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63A4230", Offset = "0x63A3630", VA = "0x1863A4230", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x63A5AA0", Offset = "0x63A4EA0", VA = "0x1863A5AA0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63A1FC0", Offset = "0x63A13C0", VA = "0x1863A1FC0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63A3500", Offset = "0x63A2900", VA = "0x1863A3500", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3D20", Offset = "0x63A3120", VA = "0x1863A3D20", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x63A4300", Offset = "0x63A3700", VA = "0x1863A4300", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x63A7210", Offset = "0x63A6610", VA = "0x1863A7210", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63A6460", Offset = "0x63A5860", VA = "0x1863A6460", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63A7C50", Offset = "0x63A7050", VA = "0x1863A7C50", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x63A6D50", Offset = "0x63A6150", VA = "0x1863A6D50", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x63A3110", Offset = "0x63A2510", VA = "0x1863A3110", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x63A4710", Offset = "0x63A3B10", VA = "0x1863A4710", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float HCHBBGGHHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x63A3F10", Offset = "0x63A3310", VA = "0x1863A3F10", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x63A5B80", Offset = "0x63A4F80", VA = "0x1863A5B80", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool AFFFHGMBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x63A7730", Offset = "0x63A6B30", VA = "0x1863A7730", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F30", Offset = "0x63A6330", VA = "0x1863A6F30", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x63A7520", Offset = "0x63A6920", VA = "0x1863A7520", Slot = "48")]
		get
		{
			return default(CBIDEAIHNIC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x63A6FE0", Offset = "0x63A63E0", VA = "0x1863A6FE0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x63A3AE0", Offset = "0x63A2EE0", VA = "0x1863A3AE0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform NDJLEDALOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63A7570", Offset = "0x63A6970", VA = "0x1863A7570", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 OMGILIJPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x63A3060", Offset = "0x63A2460", VA = "0x1863A3060", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x63A7040", Offset = "0x63A6440", VA = "0x1863A7040", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float ADHBEPCMAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x63A26B0", Offset = "0x63A1AB0", VA = "0x1863A26B0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x63A73A0", Offset = "0x63A67A0", VA = "0x1863A73A0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float DNBOKGBADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x63A45F0", Offset = "0x63A39F0", VA = "0x1863A45F0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x63A3B30", Offset = "0x63A2F30", VA = "0x1863A3B30", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion KNDKENIBGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x63A5280", Offset = "0x63A4680", VA = "0x1863A5280", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x63A3880", Offset = "0x63A2C80", VA = "0x1863A3880", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 ELIFPOBKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x63A3CD0", Offset = "0x63A30D0", VA = "0x1863A3CD0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x63A2810", Offset = "0x63A1C10", VA = "0x1863A2810", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion NPADIBBPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63A4610", Offset = "0x63A3A10", VA = "0x1863A4610", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63A39C0", Offset = "0x63A2DC0", VA = "0x1863A39C0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints JHJMNPGKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63A6BB0", Offset = "0x63A5FB0", VA = "0x1863A6BB0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x63A3000", Offset = "0x63A2400", VA = "0x1863A3000", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x63A75D0", Offset = "0x63A69D0", VA = "0x1863A75D0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x63A7670", Offset = "0x63A6A70", VA = "0x1863A7670", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode CKFGIJJLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63A2600", Offset = "0x63A1A00", VA = "0x1863A2600", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x63A3EB0", Offset = "0x63A32B0", VA = "0x1863A3EB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool OKNLFBAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x63A43A0", Offset = "0x63A37A0", VA = "0x1863A43A0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JDNDBOOEEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x63A4D30", Offset = "0x63A4130", VA = "0x1863A4D30", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool PDJHBKEIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63A2560", Offset = "0x63A1960", VA = "0x1863A2560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool OLCDHCFONDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x63A2480", Offset = "0x63A1880", VA = "0x1863A2480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event AICPJBKLFIE KKECCHNDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x63A4A60", Offset = "0x63A3E60", VA = "0x1863A4A60", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x63A2C30", Offset = "0x63A2030", VA = "0x1863A2C30", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event AICPJBKLFIE CCHCPKBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x63A7780", Offset = "0x63A6B80", VA = "0x1863A7780", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x63A4590", Offset = "0x63A3990", VA = "0x1863A4590", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OMAFPFMLLJP PIEGFFNMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63A4650", Offset = "0x63A3A50", VA = "0x1863A4650", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63A5090", Offset = "0x63A4490", VA = "0x1863A5090", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event AICPJBKLFIE FEOJNOADJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x63A7260", Offset = "0x63A6660", VA = "0x1863A7260", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x63A2F50", Offset = "0x63A2350", VA = "0x1863A2F50", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event AICPJBKLFIE FJAPHPBALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x63A4AC0", Offset = "0x63A3EC0", VA = "0x1863A4AC0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x63A2420", Offset = "0x63A1820", VA = "0x1863A2420", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event AICPJBKLFIE FCHPCGANJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x63A2AF0", Offset = "0x63A1EF0", VA = "0x1863A2AF0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x63A7150", Offset = "0x63A6550", VA = "0x1863A7150", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x63A76D0", Offset = "0x63A6AD0", VA = "0x1863A76D0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x63A3FB0", Offset = "0x63A33B0", VA = "0x1863A3FB0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event AICPJBKLFIE BFNAAFIEIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x63A74C0", Offset = "0x63A68C0", VA = "0x1863A74C0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x63A6740", Offset = "0x63A5B40", VA = "0x1863A6740", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event AICPJBKLFIE KNNHJHALDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3E00", Offset = "0x63A3200", VA = "0x1863A3E00", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x63A6890", Offset = "0x63A5C90", VA = "0x1863A6890", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x639CE30", Offset = "0x639C230", VA = "0x18639CE30")]
	public HIDAPPCLLAO(GameObject PLLPJJEOIKJ, RigidbodyEx IHDEOINNBHJ, FBMJPJJHLGH CHJDMKIKGKN, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x63A4770", Offset = "0x63A3B70", VA = "0x1863A4770", Slot = "135")]
	protected virtual void IGGPONNEIJB(FBMJPJJHLGH CHJDMKIKGKN, JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63A3160", Offset = "0x63A2560", VA = "0x1863A3160", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x63A5780", Offset = "0x63A4B80", VA = "0x1863A5780", Slot = "71")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x63A2D70", Offset = "0x63A2170", VA = "0x1863A2D70", Slot = "72")]
	public void CPJNJCCDEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x63A5330", Offset = "0x63A4730", VA = "0x1863A5330", Slot = "73")]
	public void JODGJHANFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x63A6940", Offset = "0x63A5D40", VA = "0x1863A6940")]
	private void MNPPDGLOEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x63A40E0", Offset = "0x63A34E0", VA = "0x1863A40E0", Slot = "81")]
	public void GLBLGOBNEIM(ICFPGDKKBGP NMENOOMOOJP, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63A2EF0", Offset = "0x63A22F0", VA = "0x1863A2EF0", Slot = "84")]
	public void DCAFBPNBIHO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63A2A90", Offset = "0x63A1E90", VA = "0x1863A2A90", Slot = "85")]
	public void CIHDKGPJACD(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63A3320", Offset = "0x63A2720", VA = "0x1863A3320", Slot = "86")]
	public Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63A64C0", Offset = "0x63A58C0", VA = "0x1863A64C0", Slot = "87")]
	public Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x63A2D70", Offset = "0x63A2170", VA = "0x1863A2D70", Slot = "88")]
	public void OKBLDPIEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x63A1F70", Offset = "0x63A1370", VA = "0x1863A1F70", Slot = "89")]
	public void AAMBKEKJMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x63A5BE0", Offset = "0x63A4FE0", VA = "0x1863A5BE0", Slot = "90")]
	public void LCKNGBOBFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x63A67A0", Offset = "0x63A5BA0", VA = "0x1863A67A0", Slot = "91")]
	public void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63A6C00", Offset = "0x63A6000", VA = "0x1863A6C00", Slot = "92")]
	public void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63A4FB0", Offset = "0x63A43B0", VA = "0x1863A4FB0", Slot = "93")]
	public void JGABFILEGCD(Vector3 ICPNFOPKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1EB0", Offset = "0x63A12B0", VA = "0x1863A1EB0", Slot = "94")]
	public void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63A65C0", Offset = "0x63A59C0", VA = "0x1863A65C0", Slot = "95")]
	public void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x63A44E0", Offset = "0x63A38E0", VA = "0x1863A44E0", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x63A4EB0", Offset = "0x63A42B0", VA = "0x1863A4EB0", Slot = "97")]
	public Vector3 JENKCOJBPIC(Vector3 NMENOOMOOJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x63A5E00", Offset = "0x63A5200", VA = "0x1863A5E00", Slot = "98")]
	public Vector3 LEGIPCHPMON(Vector3 NMENOOMOOJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x63A7100", Offset = "0x63A6500", VA = "0x1863A7100", Slot = "99")]
	public void NLBHAJLPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x63A27A0", Offset = "0x63A1BA0", VA = "0x1863A27A0", Slot = "100")]
	public void CGBDKPFEPMG(ICFPGDKKBGP KFLLOGAOMPJ, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x63A5720", Offset = "0x63A4B20", VA = "0x1863A5720", Slot = "101")]
	public void KDDEECOCLNO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x63A5910", Offset = "0x63A4D10", VA = "0x1863A5910", Slot = "41")]
	public void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x63A3970", Offset = "0x63A2D70", VA = "0x1863A3970", Slot = "104")]
	public void FGIIEMCKJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x63A58C0", Offset = "0x63A4CC0", VA = "0x1863A58C0", Slot = "105")]
	public void KGDFDLMMMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x63A3F60", Offset = "0x63A3360", VA = "0x1863A3F60", Slot = "106")]
	public void GJNOGKFILAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63A2FB0", Offset = "0x63A23B0", VA = "0x1863A2FB0", Slot = "109")]
	public bool DHNFPAICIDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x63A59F0", Offset = "0x63A4DF0", VA = "0x1863A59F0", Slot = "74")]
	public void KIHAPLNAKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63A2180", Offset = "0x63A1580", VA = "0x1863A2180", Slot = "110")]
	public void AIIHJBFHHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x63A4350", Offset = "0x63A3750", VA = "0x1863A4350", Slot = "115")]
	public IDisposable GOCOIDHEHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x63A46B0", Offset = "0x63A3AB0", VA = "0x1863A46B0", Slot = "116")]
	public void IDKCEJCAFOF(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63A2650", Offset = "0x63A1A50", VA = "0x1863A2650", Slot = "117")]
	public void CCLMMKEAPGE(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x63A56B0", Offset = "0x63A4AB0", VA = "0x1863A56B0", Slot = "118")]
	public void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63A5450", Offset = "0x63A4850", VA = "0x1863A5450", Slot = "121")]
	public void KAMCNAELNAL(Vector3 IHPFEGHCFFP, Quaternion ANHMGCLDJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x63A62B0", Offset = "0x63A56B0", VA = "0x1863A62B0", Slot = "122")]
	public void LNDGMFPCHOI(Vector3 CMMBCMGJFFP, Quaternion AHLGILNAJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63A7460", Offset = "0x63A6860", VA = "0x1863A7460", Slot = "123")]
	public bool OGJHLCNFLJL(float KMHALLDFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x63A6400", Offset = "0x63A5800", VA = "0x1863A6400", Slot = "124")]
	public void LNKDFHBFMID(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x63A6CF0", Offset = "0x63A60F0", VA = "0x1863A6CF0", Slot = "125")]
	public void MPHNFGHPLHA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x63A71B0", Offset = "0x63A65B0", VA = "0x1863A71B0", Slot = "126")]
	public void NMLHLOOFFLA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A40", Offset = "0x63A4E40", VA = "0x1863A5A40", Slot = "127")]
	public void KNKNHPHAGKC(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x63A72C0", Offset = "0x63A66C0", VA = "0x1863A72C0", Slot = "128")]
	public void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E20", Offset = "0x63A6220", VA = "0x1863A6E20", Slot = "129")]
	public void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x63A20A0", Offset = "0x63A14A0", VA = "0x1863A20A0", Slot = "130")]
	public void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x63A51A0", Offset = "0x63A45A0", VA = "0x1863A51A0", Slot = "131")]
	public void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x63A3230", Offset = "0x63A2630", VA = "0x1863A3230", Slot = "132")]
	public bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x63A3830", Offset = "0x63A2C30", VA = "0x1863A3830", Slot = "133")]
	public void FAIMLGMFIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x63A7D30", Offset = "0x63A7130", VA = "0x1863A7D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x63A2E10", Offset = "0x63A2210", VA = "0x1863A2E10")]
	private void DAMJLCCPGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x63A35E0", Offset = "0x63A29E0", VA = "0x1863A35E0")]
	private void EKGJJGDHBGB(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x63A21D0", Offset = "0x63A15D0", VA = "0x1863A21D0")]
	private void BACKANHLEHJ(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x63A7830", Offset = "0x63A6C30", VA = "0x1863A7830")]
	private void PMJPIFCIBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63A5350", Offset = "0x63A4750", VA = "0x1863A5350")]
	private void KABCACPJGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63A2860", Offset = "0x63A1C60", VA = "0x1863A2860")]
	private void CHECILNINJF(ICFPGDKKBGP LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63A4010", Offset = "0x63A3410", VA = "0x1863A4010")]
	private void GKMMLNJAPOH(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63A26D0", Offset = "0x63A1AD0", VA = "0x1863A26D0")]
	private void CEFGODPLJGI(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x63A5C90", Offset = "0x63A5090", VA = "0x1863A5C90")]
	private void LDGOBEBAMNH(RigidbodyEx ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63A4B70", Offset = "0x63A3F70", VA = "0x1863A4B70", Slot = "140")]
	protected virtual void IPLKKPKFMOE(RigidbodyEx KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63A5F90", Offset = "0x63A5390", VA = "0x1863A5F90")]
	protected void LMIMEJDCPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x63A78E0", Offset = "0x63A6CE0", VA = "0x1863A78E0")]
	protected void PNLFKOLHIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x63A3C30", Offset = "0x63A3030", VA = "0x1863A3C30", Slot = "141")]
	protected virtual IDisposable GABACBKPBPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class GAAIEIJPLOB
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x63A0700", Offset = "0x639FB00", VA = "0x1863A0700")]
	public static ICFPGDKKBGP ADBDJCABIHF(this ICFPGDKKBGP KCDNLAJONGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63A0900", Offset = "0x639FD00", VA = "0x1863A0900")]
	public static bool PNEHHBDMKMJ(this ICFPGDKKBGP KCDNLAJONGP, ICFPGDKKBGP GGLPCIOOICL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x63A0880", Offset = "0x639FC80", VA = "0x1863A0880")]
	public static bool MCPHNEEHJKO(this ICFPGDKKBGP KCDNLAJONGP, ICFPGDKKBGP KHKDHLBKBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x63A07B0", Offset = "0x639FBB0", VA = "0x1863A07B0")]
	public static RigidbodyEx BOMMBDPFBAB(this ICFPGDKKBGP NPDNHPEDODE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x63A0800", Offset = "0x639FC00", VA = "0x1863A0800")]
	public static HIDAPPCLLAO CDLEBOGHAKK(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class IHJICIBJNOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DEPIKGHNAID;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63A87D0", Offset = "0x63A7BD0", VA = "0x1863A87D0")]
	public IHJICIBJNOK(HIDAPPCLLAO BCPCCCLDBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63A8770", Offset = "0x63A7B70", VA = "0x1863A8770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class HKDAIBLJPLC : NFCNIFIAECJ, ICFDECEDHMM
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode HJJMJIKFHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x63A8130", Offset = "0x63A7530", VA = "0x1863A8130")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63A7FF0", Offset = "0x63A73F0", VA = "0x1863A7FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode CKFGIJJLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D80", Offset = "0x63A7180", VA = "0x1863A7D80", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63A8060", Offset = "0x63A7460", VA = "0x1863A8060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public HKDAIBLJPLC(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x63A8190", Offset = "0x63A7590", VA = "0x1863A8190", Slot = "6")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x63A82E0", Offset = "0x63A76E0", VA = "0x1863A82E0", Slot = "9")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x63A7D70", Offset = "0x63A7170", VA = "0x1863A7D70", Slot = "7")]
	public void ACNNIBMMJFD(bool NPKCHKNPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x63A8120", Offset = "0x63A7520", VA = "0x1863A8120", Slot = "8")]
	public void HAMPHBLLMEL(bool NPKCHKNPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x63A7E90", Offset = "0x63A7290", VA = "0x1863A7E90", Slot = "10")]
	public bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63A83C0", Offset = "0x63A77C0", VA = "0x1863A83C0")]
	private void PHCLFDFLBFP(bool NPKCHKNPJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GLAFHLPPMID : NFCNIFIAECJ, PGIDKFABEEC, IDisposable, BHBELFGOFDE
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CBIDEAIHNIC NNOAMJNMIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x63A1960", Offset = "0x63A0D60", VA = "0x1863A1960")]
		get
		{
			return default(CBIDEAIHNIC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A1AF0", Offset = "0x63A0EF0", VA = "0x1863A1AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A1BE0", Offset = "0x63A0FE0", VA = "0x1863A1BE0", Slot = "6")]
		get
		{
			return default(CBIDEAIHNIC);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A1AF0", Offset = "0x63A0EF0", VA = "0x1863A1AF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform CLPEIBNFHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x63A1E00", Offset = "0x63A1200", VA = "0x1863A1E00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A1A40", Offset = "0x63A0E40", VA = "0x1863A1A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public GLAFHLPPMID(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x63A1DE0", Offset = "0x63A11E0", VA = "0x1863A1DE0", Slot = "11")]
	public void OnChangedDistanceBand(EFOCEKEKLEE HMJGIBNKFPI, EFOCEKEKLEE IJJOJKPFIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "12")]
	public void OnChangedVisibility(bool AOBBJJFEJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class NJJLIKJFMNN : NFCNIFIAECJ, BPAIIGGILLB
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x639FB20", Offset = "0x639EF20", VA = "0x18639FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x639CF00", Offset = "0x639C300", VA = "0x18639CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x63B1C20", Offset = "0x63B1020", VA = "0x1863B1C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public NJJLIKJFMNN(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63B2240", Offset = "0x63B1640", VA = "0x1863B2240", Slot = "4")]
	public void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63B23A0", Offset = "0x63B17A0", VA = "0x1863B23A0")]
	private void OGDPLGHLOLN(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63B1FC0", Offset = "0x63B13C0", VA = "0x1863B1FC0", Slot = "5")]
	public void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63B1AC0", Offset = "0x63B0EC0", VA = "0x1863B1AC0", Slot = "6")]
	public void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63B2680", Offset = "0x63B1A80", VA = "0x1863B2680")]
	private void PLNPIKMJGIP(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63B1D60", Offset = "0x63B1160", VA = "0x1863B1D60", Slot = "7")]
	public void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63B1C80", Offset = "0x63B1080", VA = "0x1863B1C80")]
	private void FPKCBBOJANI(string KCFFPPIEBHH, UnityEngine.Object LAACBMJOJOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MLMCLDJHCFN : NFCNIFIAECJ, MONEDGACANN
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool AFFFHGMBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x63B1950", Offset = "0x63B0D50", VA = "0x1863B1950", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x63B1800", Offset = "0x63B0C00", VA = "0x1863B1800", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public MLMCLDJHCFN(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x63B1770", Offset = "0x63B0B70", VA = "0x1863B1770", Slot = "6")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x63ABD20", Offset = "0x63AB120", VA = "0x1863ABD20", Slot = "7")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class MBNPKHOOJND : NFCNIFIAECJ, OFGCCEDHLIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly GBIKKFKHKKF BKEJPONMHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly GKJMMBDEDPJ KLLOFPGACJH;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform DIGGJCGKIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x63B0430", Offset = "0x63AF830", VA = "0x1863B0430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HKGGDKBPMDI AINOCKGBIIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x63AFF60", Offset = "0x63AF360", VA = "0x1863AFF60")]
		get
		{
			return default(HKGGDKBPMDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x63AFBB0", Offset = "0x63AEFB0", VA = "0x1863AFBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x63AF440", Offset = "0x63AE840", VA = "0x1863AF440", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x63B0360", Offset = "0x63AF760", VA = "0x1863B0360", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public HKGGDKBPMDI IJEDAMHMLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x63B03D0", Offset = "0x63AF7D0", VA = "0x1863B03D0")]
		get
		{
			return default(HKGGDKBPMDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63AFD80", Offset = "0x63AF180", VA = "0x1863AFD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B01A0", Offset = "0x63AF5A0", VA = "0x1863B01A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x779420", Offset = "0x778820", VA = "0x180779420", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event AICPJBKLFIE KKECCHNDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x63B0100", Offset = "0x63AF500", VA = "0x1863B0100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63AF3A0", Offset = "0x63AE7A0", VA = "0x1863AF3A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event AICPJBKLFIE CCHCPKBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x63B0B80", Offset = "0x63AFF80", VA = "0x1863B0B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63AFFC0", Offset = "0x63AF3C0", VA = "0x1863AFFC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OMAFPFMLLJP PIEGFFNMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x63B0060", Offset = "0x63AF460", VA = "0x1863B0060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63B0210", Offset = "0x63AF610", VA = "0x1863B0210", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action ANNDJPHDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x63AF4B0", Offset = "0x63AE8B0", VA = "0x1863AF4B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x63AF930", Offset = "0x63AED30", VA = "0x1863AF930", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action MFJDFMGEGID
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x63AFEC0", Offset = "0x63AF2C0", VA = "0x1863AFEC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63B0940", Offset = "0x63AFD40", VA = "0x1863B0940", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<ICFPGDKKBGP> IGADELJFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63B0890", Offset = "0x63AFC90", VA = "0x1863B0890", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x63B09E0", Offset = "0x63AFDE0", VA = "0x1863B09E0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<ICFPGDKKBGP> OCKOEPPCOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x63B02B0", Offset = "0x63AF6B0", VA = "0x1863B02B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x63AF2F0", Offset = "0x63AE6F0", VA = "0x1863AF2F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action LBFGGLNKKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x63B0460", Offset = "0x63AF860", VA = "0x1863B0460", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x63AF250", Offset = "0x63AE650", VA = "0x1863AF250", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<ICFPGDKKBGP> FKKHFCECCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63AF550", Offset = "0x63AE950", VA = "0x1863AF550", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x63AFC20", Offset = "0x63AF020", VA = "0x1863AFC20", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63B0CB0", Offset = "0x63B00B0", VA = "0x1863B0CB0")]
	public MBNPKHOOJND(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63AF800", Offset = "0x63AEC00", VA = "0x1863AF800", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63AFDF0", Offset = "0x63AF1F0", VA = "0x1863AFDF0", Slot = "26")]
	public void GLBLGOBNEIM(ICFPGDKKBGP IPAKJOEMEMJ, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63AFE70", Offset = "0x63AF270", VA = "0x1863AFE70")]
	private void GLBLGOBNEIM(DEGJHKJEOGL IPAKJOEMEMJ, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x63AEDD0", Offset = "0x63AE1D0", VA = "0x1863AEDD0")]
	private void ADPIIBDMEBG(DEGJHKJEOGL IPAKJOEMEMJ, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63B0500", Offset = "0x63AF900", VA = "0x1863B0500")]
	private void NGFILOENMNC(DEGJHKJEOGL LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x63AF600", Offset = "0x63AEA00", VA = "0x1863AF600")]
	private void DIHDPFAGIIM(DEGJHKJEOGL LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63AF9D0", Offset = "0x63AEDD0", VA = "0x1863AF9D0")]
	private void EFNPDBCCFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63AFCD0", Offset = "0x63AF0D0", VA = "0x1863AFCD0")]
	private void EPIMIAOFHIO(DEGJHKJEOGL LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B0A90", Offset = "0x63AFE90", VA = "0x1863B0A90")]
	private void OMNKAGNOFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B07F0", Offset = "0x63AFBF0", VA = "0x1863B07F0")]
	private void NPCHCHIGNHH(DEGJHKJEOGL KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B0750", Offset = "0x63AFB50", VA = "0x1863B0750")]
	private void NHPEFIJDMCB(DEGJHKJEOGL KCDNLAJONGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class PHICNAOKCLK
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x63B4370", Offset = "0x63B3770", VA = "0x1863B4370")]
	public static MBNPKHOOJND KPHNPBKAFLL(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CELCIIJDALE : NFCNIFIAECJ, EKPBNHCJCIE
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6396090", Offset = "0x6395490", VA = "0x186396090", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x63964D0", Offset = "0x63958D0", VA = "0x1863964D0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6395FA0", Offset = "0x63953A0", VA = "0x186395FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private ICFPGDKKBGP OLIFJKMKLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6396700", Offset = "0x6395B00", VA = "0x186396700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public CELCIIJDALE(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6396860", Offset = "0x6395C60", VA = "0x186396860", Slot = "6")]
	public void MLDPGKEOIJM(ICFPGDKKBGP ECLIMLPEPIL, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x63969B0", Offset = "0x6395DB0", VA = "0x1863969B0")]
	private void MLDPGKEOIJM(DEGJHKJEOGL ECLIMLPEPIL, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6395F30", Offset = "0x6395330", VA = "0x186395F30", Slot = "7")]
	public void CCNLBAHLFGI(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x63960C0", Offset = "0x63954C0", VA = "0x1863960C0")]
	private Vector3 HACGBAACDNF()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GAEKLKKPONJ
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63A0980", Offset = "0x639FD80", VA = "0x1863A0980")]
	public static CELCIIJDALE FNOINILGOKM(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class CJGKLIIFKNH : NFCNIFIAECJ, OFFBAHLFJMB
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6396AC0", Offset = "0x6395EC0", VA = "0x186396AC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6397E70", Offset = "0x6397270", VA = "0x186397E70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 MEBMGKPKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6398D50", Offset = "0x6398150", VA = "0x186398D50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 NNMACAPHMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6399580", Offset = "0x6398980", VA = "0x186399580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6398880", Offset = "0x6397C80", VA = "0x186398880", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6398CF0", Offset = "0x63980F0", VA = "0x186398CF0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float CPJGILMGAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6398E00", Offset = "0x6398200", VA = "0x186398E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x63998C0", Offset = "0x6398CC0", VA = "0x1863998C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x63996B0", Offset = "0x6398AB0", VA = "0x1863996B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6399DC0", Offset = "0x63991C0", VA = "0x186399DC0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6399840", Offset = "0x6398C40", VA = "0x186399840", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event AICPJBKLFIE HEOKNADEGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6397FF0", Offset = "0x63973F0", VA = "0x186397FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6396B70", Offset = "0x6395F70", VA = "0x186396B70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x639A1E0", Offset = "0x63995E0", VA = "0x18639A1E0")]
	public CJGKLIIFKNH(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6398E80", Offset = "0x6398280", VA = "0x186398E80")]
	public float3 IDHJIIALGEI()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63992F0", Offset = "0x63986F0", VA = "0x1863992F0", Slot = "14")]
	public void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6398690", Offset = "0x6397A90", VA = "0x186398690", Slot = "16")]
	public void FGIIEMCKJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6398FA0", Offset = "0x63983A0", VA = "0x186398FA0", Slot = "15")]
	public void KGDFDLMMMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6399770", Offset = "0x6398B70", VA = "0x186399770", Slot = "18")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6399DF0", Offset = "0x63991F0", VA = "0x186399DF0", Slot = "19")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6398C90", Offset = "0x6398090", VA = "0x186398C90", Slot = "17")]
	public void GJNOGKFILAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6398090", Offset = "0x6397490", VA = "0x186398090", Slot = "20")]
	public void FAIMLGMFIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6398A70", Offset = "0x6397E70", VA = "0x186398A70")]
	public void GGJANMOBFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6397E70", Offset = "0x6397270", VA = "0x186397E70")]
	private void HGKBHJALCDB(Vector3 NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6398AB0", Offset = "0x6397EB0", VA = "0x186398AB0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 GHJJFLDLLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x63996B0", Offset = "0x6398AB0", VA = "0x1863996B0")]
	private void NJCGDBDHNME(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6399920", Offset = "0x6398D20", VA = "0x186399920")]
	private Vector3 NNNKGDBMFHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6399B80", Offset = "0x6398F80", VA = "0x186399B80")]
	private Quaternion OLHEBLIBOLL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6396C10", Offset = "0x6396010", VA = "0x186396C10")]
	internal (float, Vector3) EFCHGDLMJML(Rigidbody PJOOJBLFJOH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CCKHKJCGBDH
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6395EA0", Offset = "0x63952A0", VA = "0x186395EA0")]
	public static CJGKLIIFKNH GECILAOPKCJ(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CAJEIFOJDCL : NFCNIFIAECJ, PMKCMJMKHAP
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool MMCOIPCGDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6395800", Offset = "0x6394C00", VA = "0x186395800", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DJMAOELABKD DDCNFEIPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x63958E0", Offset = "0x6394CE0", VA = "0x1863958E0", Slot = "11")]
		get
		{
			return default(DJMAOELABKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private DJMAOELABKD NDAJHIFGNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x63958E0", Offset = "0x6394CE0", VA = "0x1863958E0")]
		get
		{
			return default(DJMAOELABKD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6395940", Offset = "0x6394D40", VA = "0x186395940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6395D90", Offset = "0x6395190", VA = "0x186395D90")]
	public CAJEIFOJDCL(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6395B30", Offset = "0x6394F30", VA = "0x186395B30", Slot = "4")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6395CB0", Offset = "0x63950B0", VA = "0x186395CB0")]
	private bool ODHHAKCDECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x63959B0", Offset = "0x6394DB0", VA = "0x1863959B0", Slot = "5")]
	public void IGDIGDMDKDJ(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6395860", Offset = "0x6394C60", VA = "0x186395860", Slot = "6")]
	public void FMEAPNCALHG(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x63956A0", Offset = "0x6394AA0", VA = "0x1863956A0", Slot = "9")]
	public void EJIJDMLGBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6395A30", Offset = "0x6394E30", VA = "0x186395A30")]
	private void JPEGEPIGEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6395480", Offset = "0x6394880", VA = "0x186395480")]
	private void CAEKLGNFDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6395620", Offset = "0x6394A20", VA = "0x186395620", Slot = "8")]
	public void DJKJLEGGKHD(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6395C30", Offset = "0x6395030", VA = "0x186395C30", Slot = "7")]
	public void MELPNEILEKM(ICFPGDKKBGP KCDNLAJONGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JJLJGGCBDAO : NFCNIFIAECJ, DGDOICOHCDA
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x63AB700", Offset = "0x63AAB00", VA = "0x1863AB700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool GKMFNFIONPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x63AB690", Offset = "0x63AAA90", VA = "0x1863AB690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event AICPJBKLFIE BFNAAFIEIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x63ABA60", Offset = "0x63AAE60", VA = "0x1863ABA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x63AB9C0", Offset = "0x63AADC0", VA = "0x1863AB9C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public JJLJGGCBDAO(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x63AB760", Offset = "0x63AAB60", VA = "0x1863AB760", Slot = "11")]
	public IDisposable GOCOIDHEHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x63AB7D0", Offset = "0x63AABD0", VA = "0x1863AB7D0", Slot = "8")]
	public void IDKCEJCAFOF(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x63AB6F0", Offset = "0x63AAAF0", VA = "0x1863AB6F0", Slot = "9")]
	public void CCLMMKEAPGE(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x63AB7E0", Offset = "0x63AABE0", VA = "0x1863AB7E0", Slot = "10")]
	public void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x63AB8E0", Offset = "0x63AACE0", VA = "0x1863AB8E0", Slot = "12")]
	public void MFFKFLDHFNP(Rigidbody FFEOMAPAFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x63ABB00", Offset = "0x63AAF00", VA = "0x1863ABB00", Slot = "13")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6398A70", Offset = "0x6397E70", VA = "0x186398A70", Slot = "6")]
	public void IMLPBENBIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BGMJEFBINGG : NFCNIFIAECJ, FKBLGLANPPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView AEABNKPIOPH;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x63946E0", Offset = "0x6393AE0", VA = "0x1863946E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6394B00", Offset = "0x6393F00", VA = "0x186394B00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event AICPJBKLFIE FEOJNOADJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x63950A0", Offset = "0x63944A0", VA = "0x1863950A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6394900", Offset = "0x6393D00", VA = "0x186394900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6395300", Offset = "0x6394700", VA = "0x186395300")]
	public BGMJEFBINGG(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6394F70", Offset = "0x6394370", VA = "0x186394F70", Slot = "8")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x63949A0", Offset = "0x6393DA0", VA = "0x1863949A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6394B90", Offset = "0x6393F90", VA = "0x186394B90", Slot = "9")]
	public void GKMMLNJAPOH(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6394700", Offset = "0x6393B00", VA = "0x186394700", Slot = "10")]
	public void CEFGODPLJGI(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6394D90", Offset = "0x6394190", VA = "0x186394D90")]
	private void JEJECCPHCNI(PhotonView DMHLHACGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6394590", Offset = "0x6393990", VA = "0x186394590")]
	private void BBFJPPBFLHB(RigidbodyEx HIIINNEGODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6395140", Offset = "0x6394540", VA = "0x186395140")]
	private void PLKGKHOBALD(PhotonView IFJNBBOEHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class GCMFMOFCOCG
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x63A0A10", Offset = "0x639FE10", VA = "0x1863A0A10")]
	public static BGMJEFBINGG MLMBKPJGPIM(this HIDAPPCLLAO KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PCJALIFIAMF : NFCNIFIAECJ, MIIACLHADEK
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x63B40B0", Offset = "0x63B34B0", VA = "0x1863B40B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x63B4110", Offset = "0x63B3510", VA = "0x1863B4110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OKPJCEDMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x63B4050", Offset = "0x63B3450", VA = "0x1863B4050", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x63B3EF0", Offset = "0x63B32F0", VA = "0x1863B3EF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints JHJMNPGKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x63B3FF0", Offset = "0x63B33F0", VA = "0x1863B3FF0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x63B3D70", Offset = "0x63B3170", VA = "0x1863B3D70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x63B4200", Offset = "0x63B3600", VA = "0x1863B4200")]
	public PCJALIFIAMF(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x63B3F60", Offset = "0x63B3360", VA = "0x1863B3F60", Slot = "9")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x63B4180", Offset = "0x63B3580", VA = "0x1863B4180", Slot = "10")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class LBNJJEHNCOK : NFCNIFIAECJ, HOKEAJKLLAI
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x63AE8B0", Offset = "0x63ADCB0", VA = "0x1863AE8B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x63AE970", Offset = "0x63ADD70", VA = "0x1863AE970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float HCHBBGGHHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x63AE910", Offset = "0x63ADD10", VA = "0x1863AE910", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x63AEAC0", Offset = "0x63ADEC0", VA = "0x1863AEAC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public LBNJJEHNCOK(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC10", Offset = "0x63AE010", VA = "0x1863AEC10", Slot = "8")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x63AED00", Offset = "0x63AE100", VA = "0x1863AED00", Slot = "9")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[JAHFMFEHFPG(typeof(JDHINNNOIHN), new string[] { })]
public sealed class MDPPPEJJINN : BFJKHKFONLF, JDHINNNOIHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[PKJNMMINAIF]
	private OLJHEIDKIFL KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool DEPIKGHNAID;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool HCOCIBGGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x63B1200", Offset = "0x63B0600", VA = "0x1863B1200", Slot = "4")]
	public void InitReferences(DCDICCBPDIP KAPGNOEILJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x63B0E90", Offset = "0x63B0290", VA = "0x1863B0E90", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x63B0EC0", Offset = "0x63B02C0", VA = "0x1863B0EC0", Slot = "6")]
	public void EFCHGDLMJML(HKGGDKBPMDI LNNMEKKDHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x63B0FE0", Offset = "0x63B03E0", VA = "0x1863B0FE0", Slot = "7")]
	public void HFCBAIMIDHL(HKGGDKBPMDI LNNMEKKDHOB, bool KDKDPAENOPI, bool OPJCHNPDGLL, bool DEINMKEBKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x63B1390", Offset = "0x63B0790", VA = "0x1863B1390", Slot = "8")]
	public void JKADPONHINB(HKGGDKBPMDI LNNMEKKDHOB, float3 AONAEDFHDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x63B1250", Offset = "0x63B0650", VA = "0x1863B1250", Slot = "9")]
	public void JCMDBKFKJKK(HKGGDKBPMDI LNNMEKKDHOB, float3 DDBAELMPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x63B16B0", Offset = "0x63B0AB0", VA = "0x1863B16B0")]
	private bool PFFONAHJHNF(HKGGDKBPMDI LNNMEKKDHOB, [Out] DEGJHKJEOGL KAAAMIPABJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x63B14D0", Offset = "0x63B08D0", VA = "0x1863B14D0")]
	private bool KNNLOHMCLHD(HKGGDKBPMDI LNNMEKKDHOB, [Out] CJGKLIIFKNH FAIOBHNOABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x63B15C0", Offset = "0x63B09C0", VA = "0x1863B15C0")]
	private bool PCBFENKNIJO(HKGGDKBPMDI LNNMEKKDHOB, [Out] ALIFHJCIBEO MHFANPLOFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public MDPPPEJJINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class PPBBKPEFIJI : NFCNIFIAECJ, DPACJHBBKKN
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool OKNLFBAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x63927C0", Offset = "0x6391BC0", VA = "0x1863927C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x63B46A0", Offset = "0x63B3AA0", VA = "0x1863B46A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x63B4540", Offset = "0x63B3940", VA = "0x1863B4540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool MIINDDLOJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x63B4640", Offset = "0x63B3A40", VA = "0x1863B4640")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x63B4CD0", Offset = "0x63B40D0", VA = "0x1863B4CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool DCPNNJLEFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x63B4B90", Offset = "0x63B3F90", VA = "0x1863B4B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x63B4980", Offset = "0x63B3D80", VA = "0x1863B4980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int FDNKLEIBCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x63B48A0", Offset = "0x63B3CA0", VA = "0x1863B48A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event AICPJBKLFIE FCHPCGANJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x63B45A0", Offset = "0x63B39A0", VA = "0x1863B45A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x63B4D40", Offset = "0x63B4140", VA = "0x1863B4D40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63B4DE0", Offset = "0x63B41E0", VA = "0x1863B4DE0")]
	public PPBBKPEFIJI(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63B49F0", Offset = "0x63B3DF0", VA = "0x1863B49F0", Slot = "6")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x63B4910", Offset = "0x63B3D10", VA = "0x1863B4910", Slot = "8")]
	public void FPDECJEEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x63B4700", Offset = "0x63B3B00", VA = "0x1863B4700", Slot = "7")]
	public bool DHNFPAICIDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63B4AA0", Offset = "0x63B3EA0", VA = "0x1863B4AA0", Slot = "9")]
	public void KIHAPLNAKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6398A70", Offset = "0x6397E70", VA = "0x186398A70", Slot = "12")]
	public void NIEKNBHPEIL(bool LJMHPFKDFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x63B4400", Offset = "0x63B3800", VA = "0x1863B4400", Slot = "11")]
	public void AIIHJBFHHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "10")]
	public void FPDGJLLPHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x63B4BF0", Offset = "0x63B3FF0", VA = "0x1863B4BF0")]
	private void LNGCLFICCKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class IOEBFIEIEIC : NFCNIFIAECJ, IDBCPFELODG
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x63A8DE0", Offset = "0x63A81E0", VA = "0x1863A8DE0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x63A8BC0", Offset = "0x63A7FC0", VA = "0x1863A8BC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x639CF00", Offset = "0x639C300", VA = "0x18639CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool AAAGLJNBMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x63A8940", Offset = "0x63A7D40", VA = "0x1863A8940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x63A9370", Offset = "0x63A8770", VA = "0x1863A9370")]
	public IOEBFIEIEIC(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CB0", Offset = "0x63A80B0", VA = "0x1863A8CB0", Slot = "5")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x63A8EC0", Offset = "0x63A82C0", VA = "0x1863A8EC0", Slot = "7")]
	public void NMLHLOOFFLA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x63A8D60", Offset = "0x63A8160", VA = "0x1863A8D60", Slot = "8")]
	public void KNKNHPHAGKC(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x63A89A0", Offset = "0x63A7DA0", VA = "0x1863A89A0", Slot = "9")]
	public void HDMEFFJJELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x63A9110", Offset = "0x63A8510", VA = "0x1863A9110", Slot = "11")]
	public void PPJFAPPNDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x63A8F40", Offset = "0x63A8340", VA = "0x1863A8F40", Slot = "12")]
	public void OFEICLCJHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "10")]
	public void OCDBPBEOGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class ALIFHJCIBEO : NFCNIFIAECJ, HKFFIHCIBHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6394390", Offset = "0x6393790", VA = "0x186394390", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6392EA0", Offset = "0x63922A0", VA = "0x186392EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6392F10", Offset = "0x6392310", VA = "0x186392F10", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6392460", Offset = "0x6391860", VA = "0x186392460", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x63924D0", Offset = "0x63918D0", VA = "0x1863924D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6391860", Offset = "0x6390C60", VA = "0x186391860", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6394060", Offset = "0x6393460", VA = "0x186394060", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x63923C0", Offset = "0x63917C0", VA = "0x1863923C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6392530", Offset = "0x6391930", VA = "0x186392530", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6393D30", Offset = "0x6393130", VA = "0x186393D30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6394030", Offset = "0x6393430", VA = "0x186394030", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6391830", Offset = "0x6390C30", VA = "0x186391830", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6394280", Offset = "0x6393680", VA = "0x186394280", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6391460", Offset = "0x6390860", VA = "0x186391460", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6394440", Offset = "0x6393840", VA = "0x186394440", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private BPAIIGGILLB CEDCJMHLPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CA89D0", Offset = "0x1CA7DD0", VA = "0x181CA89D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool OKNLFBAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x63927C0", Offset = "0x6391BC0", VA = "0x1863927C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public ALIFHJCIBEO(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63936E0", Offset = "0x6392AE0", VA = "0x1863936E0", Slot = "20")]
	public void LLAHKLCFBKG(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x63923F0", Offset = "0x63917F0", VA = "0x1863923F0", Slot = "30")]
	public void ENLFJMDEOKO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6392FC0", Offset = "0x63923C0", VA = "0x186392FC0", Slot = "19")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6391BB0", Offset = "0x6390FB0", VA = "0x186391BB0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6393BC0", Offset = "0x6392FC0", VA = "0x186393BC0", Slot = "28")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x63921E0", Offset = "0x63915E0", VA = "0x1863921E0", Slot = "35")]
	public Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6393750", Offset = "0x6392B50", VA = "0x186393750", Slot = "34")]
	public Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6392FC0", Offset = "0x63923C0", VA = "0x186392FC0", Slot = "27")]
	public void OKBLDPIEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6390E80", Offset = "0x6390280", VA = "0x186390E80", Slot = "25")]
	public void AAMBKEKJMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6393620", Offset = "0x6392A20", VA = "0x186393620", Slot = "24")]
	public void LCKNGBOBFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6393DF0", Offset = "0x63931F0", VA = "0x186393DF0", Slot = "33")]
	public void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6394090", Offset = "0x6393490", VA = "0x186394090", Slot = "32")]
	public void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6392CD0", Offset = "0x63920D0", VA = "0x186392CD0", Slot = "31")]
	public void JGABFILEGCD(Vector3 ICPNFOPKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6390910", Offset = "0x638FD10", VA = "0x186390910", Slot = "22")]
	public void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6393910", Offset = "0x6392D10", VA = "0x186393910", Slot = "21")]
	public void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x63927E0", Offset = "0x6391BE0", VA = "0x1863927E0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6392BF0", Offset = "0x6391FF0", VA = "0x186392BF0", Slot = "29")]
	public Vector3 JENKCOJBPIC(Vector3 JFJFCLDIDKG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63940F0", Offset = "0x63934F0", VA = "0x1863940F0", Slot = "26")]
	public void NLBHAJLPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6391460", Offset = "0x6390860", VA = "0x186391460")]
	private void DAALMGMHFNL(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6392590", Offset = "0x6391990", VA = "0x186392590")]
	private void GPMHAJPJDHN(Vector3 MMILFABKCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63915B0", Offset = "0x63909B0", VA = "0x1863915B0")]
	private Vector3 CJIHKFJGJGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6390EE0", Offset = "0x63902E0", VA = "0x186390EE0")]
	private void AEFEEBNOCPN(Vector3 AONAEDFHDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6391920", Offset = "0x6390D20", VA = "0x186391920")]
	private Vector3 DEIBNHPNDEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6391C70", Offset = "0x6391070", VA = "0x186391C70")]
	private void EADABCKPDIK(Vector3 NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6392760", Offset = "0x6391B60", VA = "0x186392760")]
	private void GPOGPKBJLIM(Vector3 JFJFCLDIDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6393680", Offset = "0x6392A80", VA = "0x186393680")]
	private void LFNMIJGDICO(Vector3 ANBOFBNCNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6393070", Offset = "0x6392470", VA = "0x186393070")]
	private void KGGHFEBJHDD(string KMGLEFFLACC, Vector3 NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63942E0", Offset = "0x63936E0", VA = "0x1863942E0")]
	private void OHGGJFLKPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class NFCNIFIAECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly DEGJHKJEOGL KCDNLAJONGP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected OLJHEIDKIFL ENEAKFLBGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5514710", Offset = "0x5513B10", VA = "0x185514710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected HKGGDKBPMDI CENBKNFOLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5514750", Offset = "0x5513B50", VA = "0x185514750")]
		get
		{
			return default(HKGGDKBPMDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x63944A0", Offset = "0x63938A0", VA = "0x1863944A0")]
	public NFCNIFIAECJ(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x63B19B0", Offset = "0x63B0DB0", VA = "0x1863B19B0")]
	protected ICFPGDKKBGP EDDABIEGEAH(HKGGDKBPMDI BJBPHKFHFNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CNLJCINCEAF : EKLDHFPGOCP
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x639B240", Offset = "0x639A640", VA = "0x18639B240", Slot = "4")]
	public OFGCCEDHLIL JIJFFKBFPBM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x639B540", Offset = "0x639A940", VA = "0x18639B540", Slot = "5")]
	public HKFFIHCIBHD OJNGPDGKPPE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x639A940", Offset = "0x6399D40", VA = "0x18639A940", Slot = "6")]
	public EKPBNHCJCIE BIEIOLHOIIM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x639B460", Offset = "0x639A860", VA = "0x18639B460", Slot = "7")]
	public HOKEAJKLLAI NMOFCNJOCAP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x639AA20", Offset = "0x6399E20", VA = "0x18639AA20", Slot = "8")]
	public DPACJHBBKKN BMBBHMHGCNE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x639B2A0", Offset = "0x639A6A0", VA = "0x18639B2A0", Slot = "9")]
	public PGIDKFABEEC KIJDBHBKPFI(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x639B380", Offset = "0x639A780", VA = "0x18639B380", Slot = "10")]
	public DGDOICOHCDA MDCMEEEJKFL(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x639AF00", Offset = "0x639A300", VA = "0x18639AF00", Slot = "11")]
	public BPAIIGGILLB FNMBFHDNJKN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x639B150", Offset = "0x639A550", VA = "0x18639B150", Slot = "12")]
	public ICFDECEDHMM IBOLLDBNEJP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x639B620", Offset = "0x639AA20", VA = "0x18639B620", Slot = "13")]
	public MONEDGACANN OJPOLAIFPEN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x639B050", Offset = "0x639A450", VA = "0x18639B050")]
	public IDBCPFELODG IBCDKMMAEBB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x639AE00", Offset = "0x639A200", VA = "0x18639AE00")]
	public FKBLGLANPPF LPOACLBPCNE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x639AB90", Offset = "0x6399F90", VA = "0x18639AB90")]
	public PMKCMJMKHAP HNFDOKNJCEG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x639AFE0", Offset = "0x639A3E0", VA = "0x18639AFE0")]
	public OFFBAHLFJMB OGCLEFABCBF(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x639A7A0", Offset = "0x6399BA0", VA = "0x18639A7A0")]
	public MIIACLHADEK BBLCCHFHENE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x639ACD0", Offset = "0x639A0D0", VA = "0x18639ACD0", Slot = "19")]
	public ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML, FBMJPJJHLGH CHJDMKIKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CNLJCINCEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x639B050", Offset = "0x639A450", VA = "0x18639B050", Slot = "14")]
	private IDBCPFELODG MPEALHCABMG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x639AE00", Offset = "0x639A200", VA = "0x18639AE00", Slot = "15")]
	private FKBLGLANPPF FILGCHKMCIH(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x639AB90", Offset = "0x6399F90", VA = "0x18639AB90", Slot = "16")]
	private PMKCMJMKHAP CDBEMBMJOIO(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x639AFE0", Offset = "0x639A3E0", VA = "0x18639AFE0", Slot = "17")]
	private OFFBAHLFJMB HFMJNJNDEGD(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x639B230", Offset = "0x639A630", VA = "0x18639B230", Slot = "18")]
	private MIIACLHADEK ICEDPNCBHOB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class GKJMMBDEDPJ : IReadOnlyList<ICFPGDKKBGP>, IEnumerable<ICFPGDKKBGP>, IEnumerable, IReadOnlyCollection<ICFPGDKKBGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly HKGGDKBPMDI BJBPHKFHFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly OLJHEIDKIFL DOFAMNDLCMA;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x63A1910", Offset = "0x63A0D10", VA = "0x1863A1910", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public ICFPGDKKBGP BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x63A16B0", Offset = "0x63A0AB0", VA = "0x1863A16B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x4230450", Offset = "0x422F850", VA = "0x184230450")]
	public GKJMMBDEDPJ(HKGGDKBPMDI BJBPHKFHFNH, OLJHEIDKIFL DOFAMNDLCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x63A1800", Offset = "0x63A0C00", VA = "0x1863A1800", Slot = "6")]
	public IEnumerator<ICFPGDKKBGP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63A1800", Offset = "0x63A0C00", VA = "0x1863A1800", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63A16B0", Offset = "0x63A0AB0", VA = "0x1863A16B0")]
	[CompilerGenerated]
	private ICFPGDKKBGP EPEKBONOMKB(int JNJOJJJELGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[JAHFMFEHFPG(typeof(EKLDHFPGOCP), new string[] { })]
public class AKPLLJALJMP : EKLDHFPGOCP, BFJKHKFONLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EKLDHFPGOCP PJKAEOFKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EKLDHFPGOCP DPMGBJFNEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private JGMHDCMFALE MFEFNNBCMHE;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private EKLDHFPGOCP PNJGAFPBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x63906C0", Offset = "0x638FAC0", VA = "0x1863906C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x63903F0", Offset = "0x638F7F0", VA = "0x1863903F0", Slot = "20")]
	public void InitReferences(DCDICCBPDIP KAPGNOEILJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6390440", Offset = "0x638F840", VA = "0x186390440", Slot = "4")]
	public OFGCCEDHLIL JIJFFKBFPBM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6390720", Offset = "0x638FB20", VA = "0x186390720", Slot = "5")]
	public HKFFIHCIBHD OJNGPDGKPPE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x638FDC0", Offset = "0x638F1C0", VA = "0x18638FDC0", Slot = "6")]
	public EKPBNHCJCIE BIEIOLHOIIM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6390620", Offset = "0x638FA20", VA = "0x186390620", Slot = "7")]
	public HOKEAJKLLAI NMOFCNJOCAP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x638FE60", Offset = "0x638F260", VA = "0x18638FE60", Slot = "8")]
	public DPACJHBBKKN BMBBHMHGCNE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x63904E0", Offset = "0x638F8E0", VA = "0x1863904E0", Slot = "9")]
	public PGIDKFABEEC KIJDBHBKPFI(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6390580", Offset = "0x638F980", VA = "0x186390580", Slot = "10")]
	public DGDOICOHCDA MDCMEEEJKFL(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6390150", Offset = "0x638F550", VA = "0x186390150", Slot = "11")]
	public BPAIIGGILLB FNMBFHDNJKN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6390350", Offset = "0x638F750", VA = "0x186390350", Slot = "12")]
	public ICFDECEDHMM IBOLLDBNEJP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x63907C0", Offset = "0x638FBC0", VA = "0x1863907C0", Slot = "13")]
	public MONEDGACANN OJPOLAIFPEN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x63902A0", Offset = "0x638F6A0", VA = "0x1863902A0")]
	public IDBCPFELODG IBCDKMMAEBB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x63900A0", Offset = "0x638F4A0", VA = "0x1863900A0")]
	public FKBLGLANPPF LPOACLBPCNE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x638FF00", Offset = "0x638F300", VA = "0x18638FF00")]
	public PMKCMJMKHAP HNFDOKNJCEG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63901F0", Offset = "0x638F5F0", VA = "0x1863901F0")]
	public OFFBAHLFJMB OGCLEFABCBF(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x638FD10", Offset = "0x638F110", VA = "0x18638FD10")]
	public MIIACLHADEK BBLCCHFHENE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x638FFB0", Offset = "0x638F3B0", VA = "0x18638FFB0", Slot = "19")]
	public ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML, FBMJPJJHLGH CHJDMKIKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6390860", Offset = "0x638FC60", VA = "0x186390860")]
	public AKPLLJALJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x63902A0", Offset = "0x638F6A0", VA = "0x1863902A0", Slot = "14")]
	private IDBCPFELODG MPEALHCABMG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x63900A0", Offset = "0x638F4A0", VA = "0x1863900A0", Slot = "15")]
	private FKBLGLANPPF FILGCHKMCIH(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x638FF00", Offset = "0x638F300", VA = "0x18638FF00", Slot = "16")]
	private PMKCMJMKHAP CDBEMBMJOIO(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x63901F0", Offset = "0x638F5F0", VA = "0x1863901F0", Slot = "17")]
	private OFFBAHLFJMB HFMJNJNDEGD(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x638FD10", Offset = "0x638F110", VA = "0x18638FD10", Slot = "18")]
	private MIIACLHADEK ICEDPNCBHOB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class IJIFPNMPPLL : ICFPGDKKBGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IJIFPNMPPLL NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx BOMMBDPFBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject JPJEGCALIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform DIGGJCGKIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x775860", Offset = "0x774C60", VA = "0x180775860", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF350", Offset = "0x7DE750", VA = "0x1807DF350", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xD279A0", Offset = "0xD26DA0", VA = "0x180D279A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x778420", Offset = "0x777820", VA = "0x180778420", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x778410", Offset = "0x777810", VA = "0x180778410", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x778320", Offset = "0x777720", VA = "0x180778320", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x778210", Offset = "0x777610", VA = "0x180778210", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B49A0", Offset = "0x9B3DA0", VA = "0x1809B49A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x870A80", Offset = "0x86FE80", VA = "0x180870A80", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD1F90", Offset = "0x1AD1390", VA = "0x181AD1F90", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x455B1C0", Offset = "0x455A5C0", VA = "0x18455B1C0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x63A88A0", Offset = "0x63A7CA0", VA = "0x1863A88A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A8850", Offset = "0x63A7C50", VA = "0x1863A8850", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x351C840", Offset = "0x351BC40", VA = "0x18351C840", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19FA810", Offset = "0x19F9C10", VA = "0x1819FA810", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool LINHKHGFPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8F1C80", Offset = "0x8F1080", VA = "0x1808F1C80", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool NODACHMKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1718F00", Offset = "0x1718300", VA = "0x181718F00", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5C861C0", Offset = "0x5C855C0", VA = "0x185C861C0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x351C1B0", Offset = "0x351B5B0", VA = "0x18351C1B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x942620", Offset = "0x941A20", VA = "0x180942620", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x63A8880", Offset = "0x63A7C80", VA = "0x1863A8880", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x54310F0", Offset = "0x54304F0", VA = "0x1854310F0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C43A0", VA = "0x1807C4FA0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float HCHBBGGHHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AFFFHGMBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "48")]
		get
		{
			return default(CBIDEAIHNIC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1185B90", Offset = "0x1184F90", VA = "0x181185B90", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform NDJLEDALOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B90", Offset = "0x8C1F90", VA = "0x1808C2B90", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 OMGILIJPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float ADHBEPCMAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float DNBOKGBADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion KNDKENIBGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x94F7E0", Offset = "0x94EBE0", VA = "0x18094F7E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 ELIFPOBKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion NPADIBBPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x94F7E0", Offset = "0x94EBE0", VA = "0x18094F7E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints JHJMNPGKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode CKFGIJJLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool JDNDBOOEEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x87FB20", Offset = "0x87EF20", VA = "0x18087FB20", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event AICPJBKLFIE KKECCHNDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event AICPJBKLFIE CCHCPKBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event OMAFPFMLLJP PIEGFFNMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event AICPJBKLFIE FEOJNOADJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event AICPJBKLFIE FJAPHPBALIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event AICPJBKLFIE FCHPCGANJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event AICPJBKLFIE BFNAAFIEIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event AICPJBKLFIE KNNHJHALDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "41")]
	public void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "71")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "72")]
	public void CPJNJCCDEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "73")]
	public void JODGJHANFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "74")]
	public void KIHAPLNAKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "81")]
	public void GLBLGOBNEIM(ICFPGDKKBGP NMENOOMOOJP, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "84")]
	public void DCAFBPNBIHO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "85")]
	public void CIHDKGPJACD(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "86")]
	public Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "87")]
	public Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "88")]
	public void OKBLDPIEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "89")]
	public void AAMBKEKJMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "90")]
	public void LCKNGBOBFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "91")]
	public void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "92")]
	public void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "93")]
	public void JGABFILEGCD(Vector3 ICPNFOPKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "94")]
	public void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "95")]
	public void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "96")]
	public void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "97")]
	public Vector3 JENKCOJBPIC(Vector3 NMENOOMOOJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xAE14A0", Offset = "0xAE08A0", VA = "0x180AE14A0", Slot = "98")]
	public Vector3 LEGIPCHPMON(Vector3 NMENOOMOOJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "99")]
	public void NLBHAJLPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "100")]
	public void CGBDKPFEPMG(ICFPGDKKBGP KFLLOGAOMPJ, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "101")]
	public void KDDEECOCLNO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "104")]
	public void FGIIEMCKJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "105")]
	public void KGDFDLMMMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "106")]
	public void GJNOGKFILAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "109")]
	public bool DHNFPAICIDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "110")]
	public void AIIHJBFHHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "115")]
	public IDisposable GOCOIDHEHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "116")]
	public void IDKCEJCAFOF(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "117")]
	public void CCLMMKEAPGE(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "118")]
	public void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "121")]
	public void KAMCNAELNAL(Vector3 IHPFEGHCFFP, Quaternion ANHMGCLDJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "122")]
	public void LNDGMFPCHOI(Vector3 CMMBCMGJFFP, Quaternion AHLGILNAJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "123")]
	public bool OGJHLCNFLJL(float KMHALLDFFIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "124")]
	public void LNKDFHBFMID(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "125")]
	public void MPHNFGHPLHA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "126")]
	public void NMLHLOOFFLA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "127")]
	public void KNKNHPHAGKC(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "128")]
	public void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "129")]
	public void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "130")]
	public void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "131")]
	public void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x63A8860", Offset = "0x63A7C60", VA = "0x1863A8860", Slot = "132")]
	public bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "133")]
	public void FAIMLGMFIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IJIFPNMPPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class DEGJHKJEOGL : HIDAPPCLLAO, PHLGGGDOEBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal HKGGDKBPMDI BJBPHKFHFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal OLJHEIDKIFL IMAJJEGPIGG;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x639CE30", Offset = "0x639C230", VA = "0x18639CE30")]
	public DEGJHKJEOGL(GameObject PLLPJJEOIKJ, RigidbodyEx IHDEOINNBHJ, FBMJPJJHLGH CHJDMKIKGKN, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x639C610", Offset = "0x639BA10", VA = "0x18639C610", Slot = "135")]
	protected override void IGGPONNEIJB(FBMJPJJHLGH CHJDMKIKGKN, JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "141")]
	protected override IDisposable GABACBKPBPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x639C440", Offset = "0x639B840", VA = "0x18639C440", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x639CD60", Offset = "0x639C160", VA = "0x18639CD60", Slot = "142")]
	public void PIKAJPDDMMN(KIANNNNHAKO HMJGIBNKFPI, KIANNNNHAKO IJJOJKPFIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x639C380", Offset = "0x639B780", VA = "0x18639C380", Slot = "143")]
	public void ALMANPAPPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x639CA10", Offset = "0x639BE10", VA = "0x18639CA10", Slot = "144")]
	public void KPFOFLGGIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x639CAD0", Offset = "0x639BED0", VA = "0x18639CAD0", Slot = "145")]
	public void NIEKNBHPEIL(bool LJMHPFKDFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x639C880", Offset = "0x639BC80", VA = "0x18639C880", Slot = "146")]
	public bool KMLMCFOBAND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x639C5B0", Offset = "0x639B9B0", VA = "0x18639C5B0", Slot = "147")]
	public void HKGIDKPNLNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "140")]
	protected override void IPLKKPKFMOE(RigidbodyEx FPOCHAEKMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x639CB30", Offset = "0x639BF30", VA = "0x18639CB30")]
	private void OKLAJEOFBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class BDOFFDCFOEA
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6394540", Offset = "0x6393940", VA = "0x186394540")]
	public static HIDAPPCLLAO MHNOBFOKBGD(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface IKJBMKOPLHN : OFGCCEDHLIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPCHCHIGNHH(ICFPGDKKBGP KCDNLAJONGP);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHPEFIJDMCB(ICFPGDKKBGP KCDNLAJONGP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGFILOENMNC(ICFPGDKKBGP LNNMFOGKNNM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIHDPFAGIIM(ICFPGDKKBGP LNNMFOGKNNM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DGIPJCHLOCM : EKPBNHCJCIE
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	CPFKHKPFLOI<ICFPGDKKBGP> ENIKODMFOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	ICFPGDKKBGP OLIFJKMKLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DNDKDKPGDGK : OFFBAHLFJMB
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) EFCHGDLMJML(Rigidbody PJOOJBLFJOH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HGADMNPPLMO : FKBLGLANPPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView ADJIBAICDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class NJOCMAMGJGO : ICFDECEDHMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode CBEDPDEPCMK;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode CKFGIJJLEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x63B28F0", Offset = "0x63B1CF0", VA = "0x1863B28F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x63B2B60", Offset = "0x63B1F60", VA = "0x1863B2B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63A0670", Offset = "0x639FA70", VA = "0x1863A0670")]
	public NJOCMAMGJGO(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63B2BE0", Offset = "0x63B1FE0", VA = "0x1863B2BE0", Slot = "6")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x63B2CF0", Offset = "0x63B20F0", VA = "0x1863B2CF0", Slot = "9")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63B28E0", Offset = "0x63B1CE0", VA = "0x1863B28E0", Slot = "7")]
	public void ACNNIBMMJFD(bool NPKCHKNPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x63B2BD0", Offset = "0x63B1FD0", VA = "0x1863B2BD0", Slot = "8")]
	public void HAMPHBLLMEL(bool NPKCHKNPJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A00", Offset = "0x63B1E00", VA = "0x1863B2A00", Slot = "10")]
	public bool EAOOEMKLHIN(Vector3 MOLHDBHIKBL, [Out] RaycastHit MNDOPJOMKOD, float MEOGMCFNILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x63B2D70", Offset = "0x63B2170", VA = "0x1863B2D70")]
	private void PHCLFDFLBFP(bool NPKCHKNPJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class FBCPBJMDMEN : PGIDKFABEEC, IDisposable, BHBELFGOFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CBIDEAIHNIC GJLIMIPBMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private IPCOLFCLNPN FNIPLNKILKN;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CBIDEAIHNIC PGLPBIIJIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x639F6D0", Offset = "0x639EAD0", VA = "0x18639F6D0", Slot = "6")]
		get
		{
			return default(CBIDEAIHNIC);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x639F5E0", Offset = "0x639E9E0", VA = "0x18639F5E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform CLPEIBNFHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x639F6B0", Offset = "0x639EAB0", VA = "0x18639F6B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<EFOCEKEKLEE, EFOCEKEKLEE> DLMLLCGOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x639F820", Offset = "0x639EC20", VA = "0x18639F820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x639F230", Offset = "0x639E630", VA = "0x18639F230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x639F8D0", Offset = "0x639ECD0", VA = "0x18639F8D0")]
	public FBCPBJMDMEN(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x639F2E0", Offset = "0x639E6E0", VA = "0x18639F2E0", Slot = "8")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x639F1E0", Offset = "0x639E5E0", VA = "0x18639F1E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B54EB0", Offset = "0x1B542B0", VA = "0x181B54EB0", Slot = "11")]
	private void EMGFCLOKHCF(EFOCEKEKLEE HINODNBJLFA, EFOCEKEKLEE HBJELDNKGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "12")]
	private void AKOHHFEHAFL(bool AOBBJJFEJKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FPDPBNLKIPC : BPAIIGGILLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6399870", Offset = "0x6398C70", VA = "0x186399870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x639FB20", Offset = "0x639EF20", VA = "0x18639FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x639CF00", Offset = "0x639C300", VA = "0x18639CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x639FAC0", Offset = "0x639EEC0", VA = "0x18639FAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63A0670", Offset = "0x639FA70", VA = "0x1863A0670")]
	public FPDPBNLKIPC(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x63A0050", Offset = "0x639F450", VA = "0x1863A0050", Slot = "4")]
	public void OABEKFAPOIG(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x63A01B0", Offset = "0x639F5B0", VA = "0x1863A01B0")]
	private void OGDPLGHLOLN(Vector3 EHGFADNFMAI, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x639FDD0", Offset = "0x639F1D0", VA = "0x18639FDD0", Slot = "5")]
	public void NDILBLFIEDN(Vector3 EHGFADNFMAI, Vector3 JCADPOBEOPO, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x639F960", Offset = "0x639ED60", VA = "0x18639F960", Slot = "6")]
	public void ADKCGGKHMAB(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63A0410", Offset = "0x639F810", VA = "0x1863A0410")]
	private void PLNPIKMJGIP(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x639FB70", Offset = "0x639EF70", VA = "0x18639FB70", Slot = "7")]
	public void JLFKPGLLCLF(Vector3 LDFNEPNNHNM, ForceMode ICEJEOHDAKB = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JNPOEAANJDB : MONEDGACANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool KIINDGOBPOF;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool AFFFHGMBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x63ABC10", Offset = "0x63AB010", VA = "0x1863ABC10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63A0670", Offset = "0x639FA70", VA = "0x1863A0670")]
	public JNPOEAANJDB(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x63ABBE0", Offset = "0x63AAFE0", VA = "0x1863ABBE0", Slot = "6")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x63ABD20", Offset = "0x63AB120", VA = "0x1863ABD20", Slot = "7")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class JEGILHFPOHC : IKJBMKOPLHN, OFGCCEDHLIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ICFPGDKKBGP KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<ICFPGDKKBGP> MNBBBFHNMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private ICFPGDKKBGP AFFGDBELLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private ICFPGDKKBGP ECLIMLPEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform BAACKJMEIIP;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform DIGGJCGKIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x63AAB50", Offset = "0x63A9F50", VA = "0x1863AAB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7782C0", Offset = "0x7776C0", VA = "0x1807782C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x63AAB40", Offset = "0x63A9F40", VA = "0x1863AAB40", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ICFPGDKKBGP MINGBKNACHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7782D0", Offset = "0x7776D0", VA = "0x1807782D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<ICFPGDKKBGP> DPCDPMCJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x779420", Offset = "0x778820", VA = "0x180779420", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event AICPJBKLFIE KKECCHNDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x63AA810", Offset = "0x63A9C10", VA = "0x1863AA810", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x63A9840", Offset = "0x63A8C40", VA = "0x1863A9840", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event AICPJBKLFIE CCHCPKBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x63AB470", Offset = "0x63AA870", VA = "0x1863AB470", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x63AA6D0", Offset = "0x63A9AD0", VA = "0x1863AA6D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event OMAFPFMLLJP PIEGFFNMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x63AA770", Offset = "0x63A9B70", VA = "0x1863AA770", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63AA9F0", Offset = "0x63A9DF0", VA = "0x1863AA9F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action ANNDJPHDDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x63A98E0", Offset = "0x63A8CE0", VA = "0x1863A98E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x63A9D50", Offset = "0x63A9150", VA = "0x1863A9D50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action MFJDFMGEGID
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63AA630", Offset = "0x63A9A30", VA = "0x1863AA630", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x63AB100", Offset = "0x63AA500", VA = "0x1863AB100", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<ICFPGDKKBGP> IGADELJFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63AB050", Offset = "0x63AA450", VA = "0x1863AB050", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63AB290", Offset = "0x63AA690", VA = "0x1863AB290", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<ICFPGDKKBGP> OCKOEPPCOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x63AAA90", Offset = "0x63A9E90", VA = "0x1863AAA90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A9790", Offset = "0x63A8B90", VA = "0x1863A9790", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action LBFGGLNKKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x63AABB0", Offset = "0x63A9FB0", VA = "0x1863AABB0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A96F0", Offset = "0x63A8AF0", VA = "0x1863A96F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<ICFPGDKKBGP> FKKHFCECCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x63A9980", Offset = "0x63A8D80", VA = "0x1863A9980", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A9E90", Offset = "0x63A9290", VA = "0x1863A9E90", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63AB510", Offset = "0x63AA910", VA = "0x1863AB510")]
	public JEGILHFPOHC(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A9CB0", Offset = "0x63A90B0", VA = "0x1863A9CB0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x63AA0B0", Offset = "0x63A94B0", VA = "0x1863AA0B0", Slot = "30")]
	public void GLBLGOBNEIM(ICFPGDKKBGP IPAKJOEMEMJ, bool NGKDPLNJHNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63AAC50", Offset = "0x63AA050", VA = "0x1863AAC50", Slot = "6")]
	public void NGFILOENMNC(ICFPGDKKBGP LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A9A30", Offset = "0x63A8E30", VA = "0x1863A9A30", Slot = "7")]
	public void DIHDPFAGIIM(ICFPGDKKBGP LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63AAF60", Offset = "0x63AA360", VA = "0x1863AAF60", Slot = "4")]
	public void NPCHCHIGNHH(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63AAEC0", Offset = "0x63AA2C0", VA = "0x1863AAEC0", Slot = "5")]
	public void NHPEFIJDMCB(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A9DF0", Offset = "0x63A91F0", VA = "0x1863A9DF0")]
	private void EFNPDBCCFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A9F40", Offset = "0x63A9340", VA = "0x1863A9F40")]
	private void EPIMIAOFHIO(ICFPGDKKBGP LNNMFOGKNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AA8B0", Offset = "0x63A9CB0", VA = "0x1863AA8B0")]
	private void IJGEPFLGJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63AB340", Offset = "0x63AA740", VA = "0x1863AB340")]
	private void OMNKAGNOFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A9F80", Offset = "0x63A9380", VA = "0x1863A9F80")]
	private void GACIPEFNHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x63AB1A0", Offset = "0x63AA5A0", VA = "0x1863AB1A0")]
	[CompilerGenerated]
	private object OHKJJIONGHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class OIAIOCHNKNP
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x63B35B0", Offset = "0x63B29B0", VA = "0x1863B35B0")]
	public static IKJBMKOPLHN KPHNPBKAFLL(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class CNMCAACBHCD : DGIPJCHLOCM, EKPBNHCJCIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CPFKHKPFLOI<ICFPGDKKBGP> OJFEDJMLOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool LFEFBOJDPOO;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CPFKHKPFLOI<ICFPGDKKBGP> ENIKODMFOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 DIJIGNCIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x639B850", Offset = "0x639AC50", VA = "0x18639B850", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 NMGCCGJAEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x639BC10", Offset = "0x639B010", VA = "0x18639BC10", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x639B760", Offset = "0x639AB60", VA = "0x18639B760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public ICFPGDKKBGP OLIFJKMKLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x639BDD0", Offset = "0x639B1D0", VA = "0x18639BDD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x639C280", Offset = "0x639B680", VA = "0x18639C280")]
	public CNMCAACBHCD(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x639BE80", Offset = "0x639B280", VA = "0x18639BE80", Slot = "8")]
	public void MLDPGKEOIJM(ICFPGDKKBGP ECLIMLPEPIL, object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x639B700", Offset = "0x639AB00", VA = "0x18639B700", Slot = "9")]
	public void CCNLBAHLFGI(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x639B880", Offset = "0x639AC80", VA = "0x18639B880")]
	private Vector3 HACGBAACDNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x639BEF0", Offset = "0x639B2F0", VA = "0x18639BEF0")]
	private void NFIKMPPENHJ(ICFPGDKKBGP PEJPKMFEDNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class ONJCOONDJGP
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x63B3CB0", Offset = "0x63B30B0", VA = "0x1863B3CB0")]
	public static DGIPJCHLOCM FNOINILGOKM(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class KMEJPAECJGC : DNDKDKPGDGK, OFFBAHLFJMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 MHPKAMFOODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 KGMLOJABECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float EIIHKNLMHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float MCBMFOOILNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 MMONBLLDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? GPDJMCLJAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? ICOOKEIONCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool JDKPPOJOGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool ANFNPAPMHAE;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 OILMIFHJPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x10281E0", Offset = "0x10275E0", VA = "0x1810281E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x63ABD90", Offset = "0x63AB190", VA = "0x1863ABD90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 MEAGDMHDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x63AD700", Offset = "0x63ACB00", VA = "0x1863AD700", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float EBCENGNBBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FA890", Offset = "0x10F9C90", VA = "0x1810FA890", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x63ACF00", Offset = "0x63AC300", VA = "0x1863ACF00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float OFACNEJJNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB72EE0", Offset = "0xB722E0", VA = "0x180B72EE0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x63ADD70", Offset = "0x63AD170", VA = "0x1863ADD70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 ODNNJCCKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x63AE3A0", Offset = "0x63AD7A0", VA = "0x1863AE3A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion EMHMLCEOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x63ADF00", Offset = "0x63AD300", VA = "0x1863ADF00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x639E910", Offset = "0x639DD10", VA = "0x18639E910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event AICPJBKLFIE HEOKNADEGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x63AD010", Offset = "0x63AC410", VA = "0x1863AD010", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x63ABE40", Offset = "0x63AB240", VA = "0x1863ABE40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x63AE7C0", Offset = "0x63ADBC0", VA = "0x1863AE7C0")]
	public KMEJPAECJGC(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63AD550", Offset = "0x63AC950", VA = "0x1863AD550", Slot = "17")]
	public void FGIIEMCKJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x63ADA60", Offset = "0x63ACE60", VA = "0x1863ADA60", Slot = "16")]
	public void KGDFDLMMMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x63ADE20", Offset = "0x63AD220", VA = "0x1863ADE20", Slot = "19")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x63AE530", Offset = "0x63AD930", VA = "0x1863AE530", Slot = "20")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x63AD8F0", Offset = "0x63ACCF0", VA = "0x1863AD8F0", Slot = "18")]
	public void GJNOGKFILAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x63AD0B0", Offset = "0x63AC4B0", VA = "0x1863AD0B0", Slot = "21")]
	public void FAIMLGMFIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63ABD90", Offset = "0x63AB190", VA = "0x1863ABD90")]
	private void ACFOHKNDHHF(Vector3 NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x63AD800", Offset = "0x63ACC00", VA = "0x1863AD800")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 GHJJFLDLLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63ACF00", Offset = "0x63AC300", VA = "0x1863ACF00")]
	private void EHMLPKDPFPC(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x63ADD70", Offset = "0x63AD170", VA = "0x1863ADD70")]
	private void NJCGDBDHNME(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63AE080", Offset = "0x63AD480", VA = "0x1863AE080")]
	private Vector3 NNNKGDBMFHA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63ADB40", Offset = "0x63ACF40", VA = "0x1863ADB40", Slot = "15")]
	public void KHPBLAFBBLD((Quaternion rot, Vector3 moments) CEAIKJHDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63AE220", Offset = "0x63AD620", VA = "0x1863AE220")]
	private Quaternion OLHEBLIBOLL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x63ACE30", Offset = "0x63AC230", VA = "0x1863ACE30")]
	public void EFCHGDLMJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63ABEE0", Offset = "0x63AB2E0", VA = "0x1863ABEE0", Slot = "4")]
	public (float, Vector3) EFCHGDLMJML(Rigidbody PJOOJBLFJOH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class BGPMOOJPLMJ
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63953C0", Offset = "0x63947C0", VA = "0x1863953C0")]
	public static DNDKDKPGDGK GECILAOPKCJ(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class OEMIGNFPEFH : PMKCMJMKHAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EFHEONJKJKH GJPKEEMOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DJMAOELABKD ICBKLKBBNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool MMCOIPCGDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCAB260", Offset = "0xCAA660", VA = "0x180CAB260", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public DJMAOELABKD DDCNFEIPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x896580", Offset = "0x895980", VA = "0x180896580", Slot = "11")]
		get
		{
			return default(DJMAOELABKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x63B34B0", Offset = "0x63B28B0", VA = "0x1863B34B0")]
	public OEMIGNFPEFH(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x63B3300", Offset = "0x63B2700", VA = "0x1863B3300", Slot = "4")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x63B3410", Offset = "0x63B2810", VA = "0x1863B3410")]
	private bool ODHHAKCDECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x63B31B0", Offset = "0x63B25B0", VA = "0x1863B31B0", Slot = "5")]
	public void IGDIGDMDKDJ(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x63B3180", Offset = "0x63B2580", VA = "0x1863B3180", Slot = "6")]
	public void FMEAPNCALHG(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x63B3040", Offset = "0x63B2440", VA = "0x1863B3040", Slot = "9")]
	public void EJIJDMLGBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x63B31E0", Offset = "0x63B25E0", VA = "0x1863B31E0")]
	private void JPEGEPIGEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x63B2E90", Offset = "0x63B2290", VA = "0x1863B2E90")]
	private void CAEKLGNFDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x63B3000", Offset = "0x63B2400", VA = "0x1863B3000", Slot = "8")]
	public void DJKJLEGGKHD(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x63B33D0", Offset = "0x63B27D0", VA = "0x1863B33D0", Slot = "7")]
	public void MELPNEILEKM(ICFPGDKKBGP KCDNLAJONGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class ELCOPNMHEIH : DGDOICOHCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly EFHEONJKJKH FFBHFKNIGDH;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool LKKABHIKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x639EC80", Offset = "0x639E080", VA = "0x18639EC80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event AICPJBKLFIE BFNAAFIEIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x639F020", Offset = "0x639E420", VA = "0x18639F020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x639EF80", Offset = "0x639E380", VA = "0x18639EF80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x639F0F0", Offset = "0x639E4F0", VA = "0x18639F0F0")]
	public ELCOPNMHEIH(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x639ED30", Offset = "0x639E130", VA = "0x18639ED30", Slot = "11")]
	public IDisposable GOCOIDHEHAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x639EDA0", Offset = "0x639E1A0", VA = "0x18639EDA0", Slot = "8")]
	public void IDKCEJCAFOF(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x639EC70", Offset = "0x639E070", VA = "0x18639EC70", Slot = "9")]
	public void CCLMMKEAPGE(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x639EDF0", Offset = "0x639E1F0", VA = "0x18639EDF0", Slot = "10")]
	public void KDBIDHEFNCL(object NOEAHPPKHNC, bool MPOAPDJGAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x639EDB0", Offset = "0x639E1B0", VA = "0x18639EDB0", Slot = "6")]
	public void IMLPBENBIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x639EF00", Offset = "0x639E300", VA = "0x18639EF00", Slot = "12")]
	public void MFFKFLDHFNP(Rigidbody FFEOMAPAFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x639F0C0", Offset = "0x639E4C0", VA = "0x18639F0C0", Slot = "13")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class GGKFOMKOFFD : HGADMNPPLMO, FKBLGLANPPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView AEABNKPIOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool EDPKMMJDMOM;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView ADJIBAICDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool FDDKBEAFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x63946E0", Offset = "0x6393AE0", VA = "0x1863946E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FNCCAFCGMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x857250", Offset = "0x856650", VA = "0x180857250", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event AICPJBKLFIE FEOJNOADJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x63A12F0", Offset = "0x63A06F0", VA = "0x1863A12F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x63A0D40", Offset = "0x63A0140", VA = "0x1863A0D40", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x63A1600", Offset = "0x63A0A00", VA = "0x1863A1600")]
	public GGKFOMKOFFD(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x63A11C0", Offset = "0x63A05C0", VA = "0x1863A11C0", Slot = "9")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x63A0DE0", Offset = "0x63A01E0", VA = "0x1863A0DE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x63A0EE0", Offset = "0x63A02E0", VA = "0x1863A0EE0", Slot = "10")]
	public void GKMMLNJAPOH(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x63A0BD0", Offset = "0x639FFD0", VA = "0x1863A0BD0", Slot = "11")]
	public void CEFGODPLJGI(ICFPGDKKBGP ECLIMLPEPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x63A1050", Offset = "0x63A0450", VA = "0x1863A1050")]
	private void JEJECCPHCNI(PhotonView DMHLHACGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x63A0A70", Offset = "0x639FE70", VA = "0x1863A0A70")]
	private void BBFJPPBFLHB(RigidbodyEx HIIINNEGODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x63A1390", Offset = "0x63A0790", VA = "0x1863A1390")]
	private void PLKGKHOBALD(PhotonView IFJNBBOEHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class JGAJELJAINC
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x63AB5D0", Offset = "0x63AA9D0", VA = "0x1863AB5D0")]
	public static HGADMNPPLMO MLMBKPJGPIM(this ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class IEFFEFLBALN : MIIACLHADEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints IODIGGIIFOH;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool LCHHEKPIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAB90F0", Offset = "0xAB84F0", VA = "0x180AB90F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3D13980", Offset = "0x3D12D80", VA = "0x183D13980", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool OKPJCEDMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC23D0", Offset = "0x1AC17D0", VA = "0x181AC23D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3D13990", Offset = "0x3D12D90", VA = "0x183D13990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints JHJMNPGKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x770C30", Offset = "0x770030", VA = "0x180770C30", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x63A8530", Offset = "0x63A7930", VA = "0x1863A8530", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x63A86C0", Offset = "0x63A7AC0", VA = "0x1863A86C0")]
	public IEFFEFLBALN(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x63A8660", Offset = "0x63A7A60", VA = "0x1863A8660", Slot = "9")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x63A8690", Offset = "0x63A7A90", VA = "0x1863A8690", Slot = "10")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class CLFPOOBLKKE : HOKEAJKLLAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ICFPGDKKBGP KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float NNEGLBPLAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float ANFOAPMCLNA;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float JIKIHBMMFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8710E0", Offset = "0x8704E0", VA = "0x1808710E0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x639A4D0", Offset = "0x63998D0", VA = "0x18639A4D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float HCHBBGGHHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x912D40", Offset = "0x912140", VA = "0x180912D40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x639A5A0", Offset = "0x63999A0", VA = "0x18639A5A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x639A760", Offset = "0x6399B60", VA = "0x18639A760")]
	public CLFPOOBLKKE(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x639A670", Offset = "0x6399A70", VA = "0x18639A670", Slot = "8")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x639A6C0", Offset = "0x6399AC0", VA = "0x18639A6C0", Slot = "9")]
	public void PPCFNCPPAHE(Rigidbody OIFEKCCFJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class EKAPJLJAOKO : DPACJHBBKKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool INGENDJOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool LKDCKIACBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int CBMPDPEGGNA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x639E910", Offset = "0x639DD10", VA = "0x18639E910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool OKNLFBAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x639E5E0", Offset = "0x639D9E0", VA = "0x18639E5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private ICFPGDKKBGP OCENHJEKAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x639E270", Offset = "0x639D670", VA = "0x18639E270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x639E170", Offset = "0x639D570", VA = "0x18639E170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event AICPJBKLFIE FCHPCGANJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x639E1D0", Offset = "0x639D5D0", VA = "0x18639E1D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x639EB40", Offset = "0x639DF40", VA = "0x18639EB40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x639EBE0", Offset = "0x639DFE0", VA = "0x18639EBE0")]
	public EKAPJLJAOKO(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x639E600", Offset = "0x639DA00", VA = "0x18639E600", Slot = "6")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x639E420", Offset = "0x639D820", VA = "0x18639E420", Slot = "8")]
	public void FPDECJEEICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x639E2D0", Offset = "0x639D6D0", VA = "0x18639E2D0", Slot = "7")]
	public bool DHNFPAICIDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x639E690", Offset = "0x639DA90", VA = "0x18639E690", Slot = "9")]
	public void KIHAPLNAKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x639E0D0", Offset = "0x639D4D0", VA = "0x18639E0D0", Slot = "11")]
	public void AIIHJBFHHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x639E8C0", Offset = "0x639DCC0", VA = "0x18639E8C0", Slot = "12")]
	public void NIEKNBHPEIL(bool LJMHPFKDFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x639E430", Offset = "0x639D830", VA = "0x18639E430", Slot = "10")]
	public void FPDGJLLPHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x639E960", Offset = "0x639DD60", VA = "0x18639E960")]
	private bool NJPONMBKFCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x639E730", Offset = "0x639DB30", VA = "0x18639E730")]
	private void LNGCLFICCKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DOCPIEKENCE : IDBCPFELODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly EFHEONJKJKH LCGNGFPLMIG;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody EMGDMOALHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool OPPNJDGEKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x639CF00", Offset = "0x639C300", VA = "0x18639CF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool AAAGLJNBMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCAB260", Offset = "0xCAA660", VA = "0x180CAB260", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x639DEF0", Offset = "0x639D2F0", VA = "0x18639DEF0")]
	public DOCPIEKENCE(ICFPGDKKBGP KCDNLAJONGP, [In] JJOFCHEKAOB KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x639D290", Offset = "0x639C690", VA = "0x18639D290", Slot = "5")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x639D6C0", Offset = "0x639CAC0", VA = "0x18639D6C0", Slot = "7")]
	public void NMLHLOOFFLA(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x639D330", Offset = "0x639C730", VA = "0x18639D330", Slot = "8")]
	public void KNKNHPHAGKC(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x639CF60", Offset = "0x639C360", VA = "0x18639CF60", Slot = "9")]
	public void HDMEFFJJELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x639DD00", Offset = "0x639D100", VA = "0x18639DD00", Slot = "11")]
	public void PPJFAPPNDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x639DB80", Offset = "0x639CF80", VA = "0x18639DB80", Slot = "12")]
	public void OFEICLCJHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x639D6F0", Offset = "0x639CAF0", VA = "0x18639D6F0", Slot = "10")]
	public void OCDBPBEOGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x639D510", Offset = "0x639C910", VA = "0x18639D510")]
	private void MFIEOCKKHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x639D360", Offset = "0x639C760", VA = "0x18639D360")]
	private void MBKIAGGODAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JCKMBPGNALH : HKFFIHCIBHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly HIDAPPCLLAO KCDNLAJONGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EFHEONJKJKH HNFBFEGEIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float INANJMNFKNG;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public PGLGBIMHNJM GBPDKCLBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GJPMCECLNCD IGLHNONNELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 ACPGDCCDGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x63BC240", Offset = "0x63BB640", VA = "0x1863BC240", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x63BB9F0", Offset = "0x63BADF0", VA = "0x1863BB9F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 OOHMPLHDFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x63BDA00", Offset = "0x63BCE00", VA = "0x1863BDA00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x63BC210", Offset = "0x63BB610", VA = "0x1863BC210", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 LMOGHOMJGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x63BC360", Offset = "0x63BB760", VA = "0x1863BC360", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x63BD6B0", Offset = "0x63BCAB0", VA = "0x1863BD6B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 GICEBILBJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63BD910", Offset = "0x63BCD10", VA = "0x1863BD910", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63BB9C0", Offset = "0x63BADC0", VA = "0x1863BB9C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float NIEEABCANCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6D30", VA = "0x1807C7930", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x63BB830", Offset = "0x63BAC30", VA = "0x1863BB830", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool NBMBLIKAPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x16277A0", Offset = "0x1626BA0", VA = "0x1816277A0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private BPAIIGGILLB CEDCJMHLPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1CA89D0", Offset = "0x1CA7DD0", VA = "0x181CA89D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool OKNLFBAAODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x63927C0", Offset = "0x6391BC0", VA = "0x1863927C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x63BDD30", Offset = "0x63BD130", VA = "0x1863BDD30")]
	public JCKMBPGNALH(ICFPGDKKBGP KCDNLAJONGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63BD0F0", Offset = "0x63BC4F0", VA = "0x1863BD0F0", Slot = "19")]
	public void KFDBKDGFIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x63BBB90", Offset = "0x63BAF90", VA = "0x1863BBB90", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x63BD5E0", Offset = "0x63BC9E0", VA = "0x1863BD5E0", Slot = "28")]
	public void MFFKFLDHFNP(Rigidbody OIFEKCCFJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xAF8BF0", Offset = "0xAF7FF0", VA = "0x180AF8BF0", Slot = "20")]
	public void LLAHKLCFBKG(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xAF9720", Offset = "0xAF8B20", VA = "0x180AF9720", Slot = "30")]
	public void ENLFJMDEOKO(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x63BC0A0", Offset = "0x63BB4A0", VA = "0x1863BC0A0", Slot = "35")]
	public Vector3 EIOKEHHGADI(Vector3 GDAJPKMGPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x63BD200", Offset = "0x63BC600", VA = "0x1863BD200", Slot = "34")]
	public Vector3 MDDEBAPOOFH(Vector3 AONAEDFHDDF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x63BD0F0", Offset = "0x63BC4F0", VA = "0x1863BD0F0", Slot = "27")]
	public void OKBLDPIEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x63BB370", Offset = "0x63BA770", VA = "0x1863BB370", Slot = "25")]
	public void AAMBKEKJMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x63BD1A0", Offset = "0x63BC5A0", VA = "0x1863BD1A0", Slot = "24")]
	public void LCKNGBOBFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x63BD770", Offset = "0x63BCB70", VA = "0x1863BD770", Slot = "33")]
	public void MJFDJHEKLOC(Vector3 BEHDAFNMGNH, Vector3 HNNCKKKABJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x63BDAF0", Offset = "0x63BCEF0", VA = "0x1863BDAF0", Slot = "32")]
	public void MPFEEDOGKCJ(Vector3 LKJEBIEGPFE, Vector3 DDBAELMPNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x63BCF80", Offset = "0x63BC380", VA = "0x1863BCF80", Slot = "31")]
	public void JGABFILEGCD(Vector3 ICPNFOPKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x63BAD40", Offset = "0x63BA140", VA = "0x1863BAD40", Slot = "22")]
	public void AAFLBHHCCGJ(BBPFHADMICB PADBPJPNDCP, Vector3 MCFNPOJBNEC, float HGAOKBOBPDN, float OKOANJGNBDG = 8f, float KDBKIJBIAML = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x63BD350", Offset = "0x63BC750", VA = "0x1863BD350", Slot = "21")]
	public void MDENEOGPMOJ(HLEAAEFHLHA ELLICHDFLHI, Vector3 MMILFABKCAE, float MACJNGDGPEP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x63BCA80", Offset = "0x63BBE80", VA = "0x1863BCA80", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLIIACFLPDH(HLEAAEFHLHA ELLICHDFLHI, Vector3 KCLDFAAPKAB, float BCNJEAGHGMF = 7f, float PFAADIKHMNL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x63BCE20", Offset = "0x63BC220", VA = "0x1863BCE20", Slot = "29")]
	public Vector3 JENKCOJBPIC(Vector3 JFJFCLDIDKG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x63BDB50", Offset = "0x63BCF50", VA = "0x1863BDB50", Slot = "26")]
	public void NLBHAJLPHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x63BB830", Offset = "0x63BAC30", VA = "0x1863BB830")]
	private void DAALMGMHFNL(float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x63BC480", Offset = "0x63BB880", VA = "0x1863BC480")]
	private void GPMHAJPJDHN(Vector3 MMILFABKCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x63BB8E0", Offset = "0x63BACE0", VA = "0x1863BB8E0")]
	private Vector3 CJIHKFJGJGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x63BB3D0", Offset = "0x63BA7D0", VA = "0x1863BB3D0")]
	private void AEFEEBNOCPN(Vector3 AONAEDFHDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x63BBAB0", Offset = "0x63BAEB0", VA = "0x1863BBAB0")]
	private Vector3 DEIBNHPNDEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x63BBC60", Offset = "0x63BB060", VA = "0x1863BBC60")]
	private void EADABCKPDIK(Vector3 NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x63BC5F0", Offset = "0x63BB9F0", VA = "0x1863BC5F0")]
	private void GPOGPKBJLIM(Vector3 AONAEDFHDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x63BDC80", Offset = "0x63BD080", VA = "0x1863BDC80")]
	private void OHGGJFLKPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CKGEFDGMOFI : EKLDHFPGOCP
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x63BAA80", Offset = "0x63B9E80", VA = "0x1863BAA80", Slot = "4")]
	public OFGCCEDHLIL JIJFFKBFPBM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x63BAC00", Offset = "0x63BA000", VA = "0x1863BAC00", Slot = "5")]
	public HKFFIHCIBHD OJNGPDGKPPE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x63BA690", Offset = "0x63B9A90", VA = "0x1863BA690", Slot = "6")]
	public EKPBNHCJCIE BIEIOLHOIIM(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x63BABA0", Offset = "0x63B9FA0", VA = "0x1863BABA0", Slot = "7")]
	public HOKEAJKLLAI NMOFCNJOCAP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x63BA6F0", Offset = "0x63B9AF0", VA = "0x1863BA6F0", Slot = "8")]
	public DPACJHBBKKN BMBBHMHGCNE(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x63BAAE0", Offset = "0x63B9EE0", VA = "0x1863BAAE0", Slot = "9")]
	public PGIDKFABEEC KIJDBHBKPFI(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x63BAB40", Offset = "0x63B9F40", VA = "0x1863BAB40", Slot = "10")]
	public DGDOICOHCDA MDCMEEEJKFL(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x63BA8E0", Offset = "0x63B9CE0", VA = "0x1863BA8E0", Slot = "11")]
	public BPAIIGGILLB FNMBFHDNJKN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x63BAA20", Offset = "0x63B9E20", VA = "0x1863BAA20", Slot = "12")]
	public ICFDECEDHMM IBOLLDBNEJP(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x63BACE0", Offset = "0x63BA0E0", VA = "0x1863BACE0", Slot = "13")]
	public MONEDGACANN OJPOLAIFPEN(ICFPGDKKBGP KAAAMIPABJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x63BA9B0", Offset = "0x63B9DB0", VA = "0x1863BA9B0")]
	public IDBCPFELODG IBCDKMMAEBB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x63BA870", Offset = "0x63B9C70", VA = "0x1863BA870")]
	public FKBLGLANPPF LPOACLBPCNE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x63BA750", Offset = "0x63B9B50", VA = "0x1863BA750")]
	public PMKCMJMKHAP HNFDOKNJCEG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x63BA940", Offset = "0x63B9D40", VA = "0x1863BA940")]
	public OFFBAHLFJMB OGCLEFABCBF(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x63BA620", Offset = "0x63B9A20", VA = "0x1863BA620")]
	public MIIACLHADEK BBLCCHFHENE(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x63BA7C0", Offset = "0x63B9BC0", VA = "0x1863BA7C0", Slot = "19")]
	public ICFPGDKKBGP CHACBFHKKMF(RigidbodyEx KCDNLAJONGP, JJOFCHEKAOB KKOACPFFAML, FBMJPJJHLGH CHJDMKIKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CKGEFDGMOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x63BA9B0", Offset = "0x63B9DB0", VA = "0x1863BA9B0", Slot = "14")]
	private IDBCPFELODG MPEALHCABMG(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x63BA870", Offset = "0x63B9C70", VA = "0x1863BA870", Slot = "15")]
	private FKBLGLANPPF FILGCHKMCIH(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x63BA750", Offset = "0x63B9B50", VA = "0x1863BA750", Slot = "16")]
	private PMKCMJMKHAP CDBEMBMJOIO(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x63BA940", Offset = "0x63B9D40", VA = "0x1863BA940", Slot = "17")]
	private OFFBAHLFJMB HFMJNJNDEGD(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x63BA620", Offset = "0x63B9A20", VA = "0x1863BA620", Slot = "18")]
	private MIIACLHADEK ICEDPNCBHOB(ICFPGDKKBGP KAAAMIPABJJ, [In] JJOFCHEKAOB KKOACPFFAML)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : FMCDNLLKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x63BDDD0", Offset = "0x63BD1D0", VA = "0x1863BDDD0", Slot = "6")]
		public sealed override void IHFNENEGKLH(KACPMKJBEIB PDECDCHNHMC)
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
