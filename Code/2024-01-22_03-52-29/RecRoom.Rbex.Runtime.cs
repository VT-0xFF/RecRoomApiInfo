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
public delegate void BNONKBGOOFP(RigidbodyEx EEIKIFMJPGB);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EBOGPGNBJGH(RigidbodyEx EEIKIFMJPGB, bool NHJCDDNIKDO = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GEKKGNEDBCC
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
public enum KFLBFFFKLMO
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KKBBLLCAHKH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GIDPDJJGMLG(typeof(BFNDDKHGPOD), new string[] { "Ignore", "Mock" })]
public class JEHMHGMKKKD : BFNDDKHGPOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DIMJPKFNMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B90", Offset = "0x7DFF90", VA = "0x1807E0B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
	public void KPPFPKDAMOH(string HNINMPIFBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
	public void FEOGNEGGLLC(RigidbodyEx CIJDIMEFBGG, Action EEEBGEOHFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "7")]
	public OLHCGEIINID JCKNHDLGGPA(int COJFDKDJDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "8")]
	public void JFOABPIGBPK(Vector3 HCAAHOLGKFL, float BGPGFKEBLAF, Color JKOGDMNIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public JEHMHGMKKKD()
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
		private static readonly KBKFCGENGMC MEFIBHBNIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool ONFGCNPFCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LOPKIINMLDJ DNAKHBPNFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[OLOHNBHGOEL(ELJJCPAPFEG.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[OLOHNBHGOEL(ELJJCPAPFEG.SelfAndParent, true, false, false)]
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
		private KFLBFFFKLMO physicsInterpolation;

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
		internal LOPKIINMLDJ AFMAIMAFNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x65D14B0", Offset = "0x65D08B0", VA = "0x1865D14B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> PAEHHBBCFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x792F20", Offset = "0x792320", VA = "0x180792F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x792F90", Offset = "0x792390", VA = "0x180792F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx EBNBGKOLGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65D3D70", Offset = "0x65D3170", VA = "0x1865D3D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx KCJODJNNHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x65D3CD0", Offset = "0x65D30D0", VA = "0x1865D3CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AOGBEAODJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65D4990", Offset = "0x65D3D90", VA = "0x1865D4990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65D5F10", Offset = "0x65D5310", VA = "0x1865D5F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform FAGOFKNGAOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform JLIPENOJDJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DHCAIOMHELP JLEJBEOGPGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65D3A90", Offset = "0x65D2E90", VA = "0x1865D3A90")]
			get
			{
				return default(DHCAIOMHELP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65D56C0", Offset = "0x65D4AC0", VA = "0x1865D56C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CDDCPMKNANH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65D4020", Offset = "0x65D3420", VA = "0x1865D4020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ILLHEINJBJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x65D3BB0", Offset = "0x65D2FB0", VA = "0x1865D3BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MHLEIDBKLPP HJJPMBEOMGL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x65D3F60", Offset = "0x65D3360", VA = "0x1865D3F60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x65D5880", Offset = "0x65D4C80", VA = "0x1865D5880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ELDLGDHFDKA IJDPBHLFNCC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x65D3F00", Offset = "0x65D3300", VA = "0x1865D3F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x65D5810", Offset = "0x65D4C10", VA = "0x1865D5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool AEPDALGMEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65D3E50", Offset = "0x65D3250", VA = "0x1865D3E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody LJOBBGCHKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x65D3EB0", Offset = "0x65D32B0", VA = "0x1865D3EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FJIEFFAHKDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x65D3C10", Offset = "0x65D3010", VA = "0x1865D3C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65D5730", Offset = "0x65D4B30", VA = "0x1865D5730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LEMHLBHDPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D9A2E0", Offset = "0x5D996E0", VA = "0x185D9A2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D9A860", Offset = "0x5D99C60", VA = "0x185D9A860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float BCBFAGMOJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x65D4930", Offset = "0x65D3D30", VA = "0x1865D4930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float HNMBCLBOOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x65D48D0", Offset = "0x65D3CD0", VA = "0x1865D48D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65D5EA0", Offset = "0x65D52A0", VA = "0x1865D5EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float MFBBEFCCLBM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x65D4280", Offset = "0x65D3680", VA = "0x1865D4280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x65D5B20", Offset = "0x65D4F20", VA = "0x1865D5B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CGFEPGJDOEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65D4080", Offset = "0x65D3480", VA = "0x1865D4080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x65D58F0", Offset = "0x65D4CF0", VA = "0x1865D58F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CJDANJDABGO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x65D4EF0", Offset = "0x65D42F0", VA = "0x1865D4EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x65D6470", Offset = "0x65D5870", VA = "0x1865D6470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 PKKPIIECEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x65D46B0", Offset = "0x65D3AB0", VA = "0x1865D46B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x65D5C70", Offset = "0x65D5070", VA = "0x1865D5C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 HCAAHOLGKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x65D5030", Offset = "0x65D4430", VA = "0x1865D5030")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode OLALNFOGFMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x65D41C0", Offset = "0x65D35C0", VA = "0x1865D41C0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x65D5A40", Offset = "0x65D4E40", VA = "0x1865D5A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float IBDADGNBJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x65D3C70", Offset = "0x65D3070", VA = "0x1865D3C70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x65D57A0", Offset = "0x65D4BA0", VA = "0x1865D57A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints FMFBOFLOPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x65D4220", Offset = "0x65D3620", VA = "0x1865D4220")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x65D5AB0", Offset = "0x65D4EB0", VA = "0x1865D5AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 POIILIMJKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x65D4A30", Offset = "0x65D3E30", VA = "0x1865D4A30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 ODFEADMFNKL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x65D4A30", Offset = "0x65D3E30", VA = "0x1865D4A30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x65D6250", Offset = "0x65D5650", VA = "0x1865D6250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ADOIKFCFGFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x65D4790", Offset = "0x65D3B90", VA = "0x1865D4790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x65D5D50", Offset = "0x65D5150", VA = "0x1865D5D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MHNKIOODGNC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x65D4E90", Offset = "0x65D4290", VA = "0x1865D4E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65D6400", Offset = "0x65D5800", VA = "0x1865D6400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion BPBMPOMKALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x65D4B10", Offset = "0x65D3F10", VA = "0x1865D4B10")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x65D5FD0", Offset = "0x65D53D0", VA = "0x1865D5FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion BHPMBNCGBNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x65D4DB0", Offset = "0x65D41B0", VA = "0x1865D4DB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x65D6330", Offset = "0x65D5730", VA = "0x1865D6330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 PHMCMIOHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x65D4BF0", Offset = "0x65D3FF0", VA = "0x1865D4BF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x65D60A0", Offset = "0x65D54A0", VA = "0x1865D60A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion KLMBEGPANID
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x65D4CD0", Offset = "0x65D40D0", VA = "0x1865D4CD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x65D6180", Offset = "0x65D5580", VA = "0x1865D6180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 MADKEMKIPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x65D4F50", Offset = "0x65D4350", VA = "0x1865D4F50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x65D64E0", Offset = "0x65D58E0", VA = "0x1865D64E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ACBJEELMNFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x65D47F0", Offset = "0x65D3BF0", VA = "0x1865D47F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x65D5DC0", Offset = "0x65D51C0", VA = "0x1865D5DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PEAINEKGLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x65D40E0", Offset = "0x65D34E0", VA = "0x1865D40E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x65D5960", Offset = "0x65D4D60", VA = "0x1865D5960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NMJFDBALPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x65D45D0", Offset = "0x65D39D0", VA = "0x1865D45D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x65D5B90", Offset = "0x65D4F90", VA = "0x1865D5B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 OCCHNJMAINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x65D4490", Offset = "0x65D3890", VA = "0x1865D4490")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion GLFOOMAEKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x65D43B0", Offset = "0x65D37B0", VA = "0x1865D43B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NNJEJAADKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x65D51F0", Offset = "0x65D45F0", VA = "0x1865D51F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HADKOFFGJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x65D5110", Offset = "0x65D4510", VA = "0x1865D5110")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool MGICFOILBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x65D4570", Offset = "0x65D3970", VA = "0x1865D4570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LGOPJDHBFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x65D3FC0", Offset = "0x65D33C0", VA = "0x1865D3FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ANEFAHILOIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x65D3B50", Offset = "0x65D2F50", VA = "0x1865D3B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DLPLMOEIGGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x65D3AF0", Offset = "0x65D2EF0", VA = "0x1865D3AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GIBENAHIEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x65D3A30", Offset = "0x65D2E30", VA = "0x1865D3A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OPGMFNPIFCB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x65D42E0", Offset = "0x65D36E0", VA = "0x1865D42E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KJBEDCLLEIF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x515AB20", Offset = "0x5159F20", VA = "0x18515AB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BNONKBGOOFP JIMOAMJKCEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x65D3950", Offset = "0x65D2D50", VA = "0x1865D3950")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x65D55E0", Offset = "0x65D49E0", VA = "0x1865D55E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EBOGPGNBJGH DMJBLOEGOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x65D38E0", Offset = "0x65D2CE0", VA = "0x1865D38E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x65D5570", Offset = "0x65D4970", VA = "0x1865D5570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event BNONKBGOOFP FPLNDDEPKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x65D3640", Offset = "0x65D2A40", VA = "0x1865D3640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x65D52D0", Offset = "0x65D46D0", VA = "0x1865D52D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event BNONKBGOOFP MHKPHJBAIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x65D36B0", Offset = "0x65D2AB0", VA = "0x1865D36B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x65D5340", Offset = "0x65D4740", VA = "0x1865D5340")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event BNONKBGOOFP NGFHFKKGHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x65D3800", Offset = "0x65D2C00", VA = "0x1865D3800")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x65D5490", Offset = "0x65D4890", VA = "0x1865D5490")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x65D3790", Offset = "0x65D2B90", VA = "0x1865D3790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x65D5420", Offset = "0x65D4820", VA = "0x1865D5420")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event BNONKBGOOFP EEJMKKKEDFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x65D3870", Offset = "0x65D2C70", VA = "0x1865D3870")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65D5500", Offset = "0x65D4900", VA = "0x1865D5500")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event BNONKBGOOFP EHBDCKBOOND
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x65D39C0", Offset = "0x65D2DC0", VA = "0x1865D39C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x65D5650", Offset = "0x65D4A50", VA = "0x1865D5650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event BNONKBGOOFP MPBNJDPNHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x65D3720", Offset = "0x65D2B20", VA = "0x1865D3720")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x65D53B0", Offset = "0x65D47B0", VA = "0x1865D53B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x792A40", Offset = "0x791E40", VA = "0x180792A40")]
		internal void IODNJOCBLJA(LOPKIINMLDJ ABLKMCPEJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65D2710", Offset = "0x65D1B10", VA = "0x1865D2710")]
		internal void PHDAOKOEMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65D3360", Offset = "0x65D2760", VA = "0x1865D3360")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody INCPKCDPBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x65D3030", Offset = "0x65D2430", VA = "0x1865D3030")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CMOAOKDCAAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65D1EB0", Offset = "0x65D12B0", VA = "0x1865D1EB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x65D14B0", Offset = "0x65D08B0", VA = "0x1865D14B0")]
		private LOPKIINMLDJ AOBFILAENFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x65D1120", Offset = "0x65D0520", VA = "0x1865D1120")]
		private void AFJDDCCJNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65D2800", Offset = "0x65D1C00", VA = "0x1865D2800")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65D2710", Offset = "0x65D1B10", VA = "0x1865D2710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65D27A0", Offset = "0x65D1BA0", VA = "0x1865D27A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65D2860", Offset = "0x65D1C60", VA = "0x1865D2860")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65D1560", Offset = "0x65D0960", VA = "0x1865D1560")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65D28C0", Offset = "0x65D1CC0", VA = "0x1865D28C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65D2100", Offset = "0x65D1500", VA = "0x1865D2100")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x65D26B0", Offset = "0x65D1AB0", VA = "0x1865D26B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65D3190", Offset = "0x65D2590", VA = "0x1865D3190")]
		public void SetParent(RigidbodyEx PAHKKNONPEO, bool NHJCDDNIKDO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x65D2BD0", Offset = "0x65D1FD0", VA = "0x1865D2BD0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65D2380", Offset = "0x65D1780", VA = "0x1865D2380")]
		public bool IsRigidbodyAncestor(RigidbodyEx KLPLFAFLDGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65D2460", Offset = "0x65D1860", VA = "0x1865D2460")]
		public bool IsRigidbodyDescendant(RigidbodyEx DMPKMINEHEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65D17D0", Offset = "0x65D0BD0", VA = "0x1865D17D0")]
		public void AddInterpolationRestriction(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65D2930", Offset = "0x65D1D30", VA = "0x1865D2930")]
		public void RemoveInterpolationRestriction(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65D1F20", Offset = "0x65D1320", VA = "0x1865D1F20")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65D1840", Offset = "0x65D0C40", VA = "0x1865D1840")]
		public void AddKinematic(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65D29A0", Offset = "0x65D1DA0", VA = "0x1865D29A0")]
		public void RemoveKinematic(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65D3110", Offset = "0x65D2510", VA = "0x1865D3110")]
		public void SetKinematic(object KNOHBODGPLL, bool OFNKHCCEJML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x65D2F30", Offset = "0x65D2330", VA = "0x1865D2F30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PBNJKFLAPAK, Quaternion KHBBHAJCCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x65D2E30", Offset = "0x65D2230", VA = "0x1865D2E30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JGJHMIAHIAD, Quaternion NFFONAKHGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65D2270", Offset = "0x65D1670", VA = "0x1865D2270")]
		public Vector3 GetConstrainedVelocity(Vector3 MADKEMKIPKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x65D2160", Offset = "0x65D1560", VA = "0x1865D2160")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 PEAINEKGLBJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65D16E0", Offset = "0x65D0AE0", VA = "0x1865D16E0")]
		public void AddForce(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x65D15D0", Offset = "0x65D09D0", VA = "0x1865D15D0")]
		public void AddForceAtPosition(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x65D1A10", Offset = "0x65D0E10", VA = "0x1865D1A10")]
		public void AddTorque(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x65D18B0", Offset = "0x65D0CB0", VA = "0x1865D18B0")]
		public void AddRelativeTorque(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x65D3430", Offset = "0x65D2830", VA = "0x1865D3430")]
		public Vector3 WorldToLocalVelocity(Vector3 HMGOGHFNDEP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65D25A0", Offset = "0x65D19A0", VA = "0x1865D25A0")]
		public Vector3 LocalToWorldVelocity(Vector3 ACBJEELMNFK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x65D20A0", Offset = "0x65D14A0", VA = "0x1865D20A0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x65D2040", Offset = "0x65D1440", VA = "0x1865D2040")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x65D1FE0", Offset = "0x65D13E0", VA = "0x1865D1FE0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x65D1F80", Offset = "0x65D1380", VA = "0x1865D1F80")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x65D2D30", Offset = "0x65D2130", VA = "0x1865D2D30")]
		public void ResetVelocityWorldSpace(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x65D2C30", Offset = "0x65D2030", VA = "0x1865D2C30")]
		public void ResetVelocityLocalSpace(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65D2AF0", Offset = "0x65D1EF0", VA = "0x1865D2AF0")]
		public void ResetLinearVelocityLocalSpace(Vector3 NEHBCFALGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65D32C0", Offset = "0x65D26C0", VA = "0x1865D32C0")]
		public bool SweepTest(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x65D2540", Offset = "0x65D1940", VA = "0x1865D2540")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x65D3260", Offset = "0x65D2660", VA = "0x1865D3260")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x65D33D0", Offset = "0x65D27D0", VA = "0x1865D33D0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x65D19A0", Offset = "0x65D0DA0", VA = "0x1865D19A0")]
		public void AddShouldHaveUnityRigidbodyToken(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x65D2A10", Offset = "0x65D1E10", VA = "0x1865D2A10")]
		public void RemoveShouldHaveUnityRigidbodyToken(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65D1D40", Offset = "0x65D1140", VA = "0x1865D1D40")]
		public void ApplyForceVelocityChange(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65D1CA0", Offset = "0x65D10A0", VA = "0x1865D1CA0")]
		public void ApplyAngularVelocityChange(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x65D1E00", Offset = "0x65D1200", VA = "0x1865D1E00")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65D1BD0", Offset = "0x65D0FD0", VA = "0x1865D1BD0")]
		public bool AllowedScaleChange(float GLJGILHBCKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x65D1B00", Offset = "0x65D0F00", VA = "0x1865D1B00")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HDIFEJDMLPC, object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65D2A80", Offset = "0x65D1E80", VA = "0x1865D2A80")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65D35D0", Offset = "0x65D29D0", VA = "0x1865D35D0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class FGFMJGJFLDD
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x65B5460", Offset = "0x65B4860", VA = "0x1865B5460")]
	public static LOPKIINMLDJ AFMAIMAFNHJ(this RigidbodyEx CIJDIMEFBGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CKDAJCCBABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody OKBDFKDKNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView NIMPPBCFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 ODGCLHEKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 BDBCDGNNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public KFLBFFFKLMO MAEMLLLMPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool HBALALLKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool CKFDLJFFDME;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GIDPDJJGMLG(typeof(AAPGCFJECKF), new string[] { })]
public class NDBBABPLIMG : AAPGCFJECKF, ACLOEOFNKAE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly KBKFCGENGMC ADLBEINOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BKLHCNIBAOL PKKABGFJAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BFNDDKHGPOD HLPGFGOCKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ALCDMIAMAMK CEENDDBLNPJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BFNDDKHGPOD GOGKHHEPADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALCDMIAMAMK BJAGJLAOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x65CCD80", Offset = "0x65CC180", VA = "0x1865CCD80", Slot = "8")]
	public void InitReferences(NLGOFGOGHKI DPELPGGDADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x65CCAD0", Offset = "0x65CBED0", VA = "0x1865CCAD0", Slot = "6")]
	public PIKFEMDGCNE IDBGFLLIGPO(RigidbodyEx CIJDIMEFBGG)
	{
		return default(PIKFEMDGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x65CCEB0", Offset = "0x65CC2B0", VA = "0x1865CCEB0")]
	private static PIKFEMDGCNE MIFGANJOLDD(RigidbodyEx CIJDIMEFBGG)
	{
		return default(PIKFEMDGCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65CCE10", Offset = "0x65CC210", VA = "0x1865CCE10", Slot = "7")]
	public LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public NDBBABPLIMG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static DECPPMKECOG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int BNIPCFEAHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EEPPNANHHDN;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65D0F80", Offset = "0x65D0380", VA = "0x1865D0F80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65D0FC0", Offset = "0x65D03C0", VA = "0x1865D0FC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65D0FA0", Offset = "0x65D03A0", VA = "0x1865D0FA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string AGOKDCAFCLN, [Optional] UnityEngine.Object AOGDICEMNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string AGOKDCAFCLN, [Optional] UnityEngine.Object AOGDICEMNLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x65D10D0", Offset = "0x65D04D0", VA = "0x1865D10D0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OIGFLFFOPLC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65CECE0", Offset = "0x65CE0E0", VA = "0x1865CECE0")]
	public static void KJEKNAJJGNC(this Rigidbody INCPKCDPBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65CEBB0", Offset = "0x65CDFB0", VA = "0x1865CEBB0")]
	public static void KJEKNAJJGNC(this Rigidbody INCPKCDPBJO, Vector3 JKLJKPEHADH, Quaternion GLFOOMAEKLF, Vector3 KKCIFNIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC19130", Offset = "0xC18530", VA = "0x180C19130")]
	public static void NKONGAOOLNL(Vector3 MADKEMKIPKF, Vector3 KELADLMJIOC, [Out] Vector3 NEGLHIEEAGO, [Out] Vector3 MLIFLJJJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OJFAHFLEBNO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class DPPGJGFECFK : MHLEIDBKLPP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A0990", Offset = "0x79FD90", VA = "0x1807A0990", Slot = "4")]
		public Vector3 JFCAHGKOJLP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A0990", Offset = "0x79FD90", VA = "0x1807A0990", Slot = "5")]
		public Vector3 MCJKJKAEMBB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public DPPGJGFECFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static MHLEIDBKLPP KGEIHPPEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x65CEE70", Offset = "0x65CE270", VA = "0x1865CEE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CJHGCJOMLPH
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode CPKHADEDPCE
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
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKOLHJMMOFE(bool MGICFOILBIC);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIACHLIPLGF(bool MGICFOILBIC);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EIPMHAPKEIH : IDisposable, FIEBEGLBPNG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCPCDPHDHKG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface ALCDMIAMAMK
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFNEBKACGOG LGPPICLPGFI(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFPDBHGELEL GKGMHALHEJB(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOPPPMDNCCJ AABMGKGFDPG(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEMBEPEDECL GKFOKGIFBDO(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PKEMFEKJJOP ABLJCLFNCCO(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIPMHAPKEIH CBNNJPMPLOJ(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MOIAKGIAEBL GDBHLFCNHGJ(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EOHJMBLPLJB OJOJLLCLOEI(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CJHGCJOMLPH COACLBDLNCH(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AJGEPFOHMIH DKINKEHMDGP(LOPKIINMLDJ ABLKMCPEJAG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IONDHNBLODE MAHCMCFGIGN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HPNKGGILPOG ADCKALEENLD(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LEDJPGIEGJJ HPNLECEBPDF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IGEIHFPCEFN AAPCGOMJOMN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NGCFDOFAHHF PPGCOOHJLEG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN, AAPGCFJECKF GPNCNDIBNOH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EOHJMBLPLJB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AJGEPFOHMIH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AGDKBABNHNB
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
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJBDHPANHPO(Rigidbody OKBDFKDKNFM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EFNEBKACGOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event BNONKBGOOFP FPLNDDEPKKP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BNONKBGOOFP MHKPHJBAIEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event EBOGPGNBJGH OPJJCKGCGMH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action IMIIKPKGDJE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action JGKDLBAFMNK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<LOPKIINMLDJ> CEDPFPDCDFA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<LOPKIINMLDJ> MNJAOHIPOOD;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action AJCGMHHIHJC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<LOPKIINMLDJ> CIMCPDBOPHO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DFODMMMMNPP(LOPKIINMLDJ JOPIDNPFKKJ, bool NHJCDDNIKDO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IOPPPMDNCCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKGGBGKAKAG(LOPKIINMLDJ AOGBEAODJPP, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKPHOLMONCD(object KNOHBODGPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IGEIHFPCEFN
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BNONKBGOOFP FEJBOENEGID;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FIIDMNEAIPG();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PPMKLCHMMDH();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BHKBAAKFHFH();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LJBDHPANHPO(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IIGAPFPPEDP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LEDJPGIEGJJ
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFLHBDIDEHD(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLBJGGCGKGF(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EADMBNPPCCK(LOPKIINMLDJ CIJDIMEFBGG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFJGPCPLGEL(LOPKIINMLDJ CIJDIMEFBGG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJJFAPEHMPB();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MOIAKGIAEBL
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event BNONKBGOOFP EBJAHHAKONE;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOMFFFCKIJN();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAFLCLEHBGM(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMHKAJLMECI(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable OGOKFHMDAOP();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGAKKONLIDI(Rigidbody PKDFFNNLBIJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LJBDHPANHPO(Rigidbody OKBDFKDKNFM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HPNKGGILPOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event BNONKBGOOFP NGGELNMLDBN;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIFEENKGECL(LOPKIINMLDJ AOGBEAODJPP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHIPAPIFHMM(LOPKIINMLDJ AOGBEAODJPP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NGCFDOFAHHF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AODJAILCEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints NMBMDIIHHKO
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
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJBDHPANHPO(Rigidbody OKBDFKDKNFM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GEMBEPEDECL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float BBAKNJGMPHC
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
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJBDHPANHPO(Rigidbody OKBDFKDKNFM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FDMHPFPMHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KPINCOEIMHL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PKEMFEKJJOP
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event BNONKBGOOFP CJJNJGMEFIH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LJCOGDJCLOC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFNIEDCOBBI();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGGOHHLELDJ();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJLIPNLFPME();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JAPGJOMEKIF();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMAAJAMFNHI(bool PJKPPHMJKBC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IONDHNBLODE
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool JKJELODCLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKKMMACOGPC(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLFGGGFBBEG(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGGLJJJLAAD();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HHFJFBKKBJL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FFPDBHGELEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DOEABMEIHOL(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EIFIFEIMIMM();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MENPCBEEFEK();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PEMBIILOMPI();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JCNNNDOJMJJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OGAKKONLIDI(Rigidbody OKBDFKDKNFM);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IIANNBIMKCJ(Vector3 MADKEMKIPKF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GIGJNPIMOEF(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HEIDFNDADGL(Vector3 IDAHODGNCCA);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface BFNDDKHGPOD
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DIMJPKFNMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPPFPKDAMOH(string HNINMPIFBCK);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEOGNEGGLLC(RigidbodyEx CIJDIMEFBGG, Action EEEBGEOHFMI);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLHCGEIINID JCKNHDLGGPA(int COJFDKDJDMG);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFOABPIGBPK(Vector3 HCAAHOLGKFL, float BGPGFKEBLAF, Color JKOGDMNIBNM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NBLGEMLEKLJ(BLCHILNGIEA.Application)]
public interface AAPGCFJECKF
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	BFNDDKHGPOD GOGKHHEPADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	ALCDMIAMAMK BJAGJLAOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIKFEMDGCNE IDBGFLLIGPO(RigidbodyEx CIJDIMEFBGG);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface ELDLGDHFDKA
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPKBJHKANEM(Vector3 HBNPCEABPCD);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBCNBEAPOHJ(Vector3 PEAINEKGLBJ);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIHHEKJNEIP(Vector3 HBNPCEABPCD);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIHEOLJLJOE(Vector3 PEAINEKGLBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MHLEIDBKLPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JFCAHGKOJLP();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MCJKJKAEMBB();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LOPKIINMLDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx MCOMEAOILPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject KEAFFOELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool DLPLMOEIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool GIBENAHIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float BBAKNJGMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool AGDKBABNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform JLIPENOJDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 LMCJEHOICMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float ILNIKCAKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float LHMKDCAJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion OENBJJAECOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints NMBMDIIHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode CPKHADEDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool LGOPJDHBFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event BNONKBGOOFP FPLNDDEPKKP;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event BNONKBGOOFP MHKPHJBAIEJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event EBOGPGNBJGH OPJJCKGCGMH;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event BNONKBGOOFP NGGELNMLDBN;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event BNONKBGOOFP NGFHFKKGHJN;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event BNONKBGOOFP CJJNJGMEFIH;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event BNONKBGOOFP EBJAHHAKONE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event BNONKBGOOFP MPBNJDPNHIO;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void NCPCDPHDHKG();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void CJCHOHIMKFA();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void OBEEFAIJBHA();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void KGGOHHLELDJ();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void DFODMMMMNPP(LOPKIINMLDJ PAHKKNONPEO, bool NHJCDDNIKDO = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void CLHBPCELMIN(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void KPODAPFFCBF(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void JCNNNDOJMJJ();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void MENPCBEEFEK();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void EIFIFEIMIMM();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void HEIDFNDADGL(Vector3 IDAHODGNCCA);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 IIANNBIMKCJ(Vector3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 KJHLJJGAFCA(Vector3 PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PEMBIILOMPI();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void FAHOILKMAOF(LOPKIINMLDJ HDIFEJDMLPC, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void GCDMGJHBNEJ(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PPMKLCHMMDH();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FIIDMNEAIPG();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void BHKBAAKFHFH();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool LJCOGDJCLOC();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JAPGJOMEKIF();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable OGOKFHMDAOP();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EAFLCLEHBGM(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void IMHKAJLMECI(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void KIHNEKGIMLI(Vector3 PBNJKFLAPAK, Quaternion KHBBHAJCCFC);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CDNJMCGGLMF(Vector3 JGJHMIAHIAD, Quaternion NFFONAKHGNG);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool BFJMFNANIKN(float GLJGILHBCKJ);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AGCBCLMLEBG(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void OHGHANHOFHH(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void NKKMMACOGPC(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FLFGGGFBBEG(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IIGAPFPPEDP();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LEFAGGGMDHK : LOPKIINMLDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly AAPGCFJECKF GPNCNDIBNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal EFNEBKACGOG MFMFAILCOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LEDJPGIEGJJ KIMIMGLHILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HPNKGGILPOG IBDBEGKEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal FFPDBHGELEL MADKEMKIPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IOPPPMDNCCJ PHIMCMJEMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal IGEIHFPCEFN FPFPDHPPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal GEMBEPEDECL PJFHKDAFPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal AJGEPFOHMIH EFGIHIFFGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PKEMFEKJJOP OFBLABALCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal EIPMHAPKEIH AAIHAOGCFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MOIAKGIAEBL PFIBHPENJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal EOHJMBLPLJB LHIOHICKLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal NGCFDOFAHHF ODBCPJJFNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal IONDHNBLODE OKBDFKDKNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal CJHGCJOMLPH DNLDBPEJFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable GCFALKAFJAK;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx MCOMEAOILPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x78F330", Offset = "0x78E730", VA = "0x18078F330", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x78F290", Offset = "0x78E690", VA = "0x18078F290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject KEAFFOELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x878240", Offset = "0x877640", VA = "0x180878240", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x878730", Offset = "0x877B30", VA = "0x180878730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x65C92C0", Offset = "0x65C86C0", VA = "0x1865C92C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x65C9450", Offset = "0x65C8850", VA = "0x1865C9450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x65C9820", Offset = "0x65C8C20", VA = "0x1865C9820", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x65C8D60", Offset = "0x65C8160", VA = "0x1865C8D60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x65C7B90", Offset = "0x65C6F90", VA = "0x1865C7B90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x65C8A20", Offset = "0x65C7E20", VA = "0x1865C8A20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x65C68A0", Offset = "0x65C5CA0", VA = "0x1865C68A0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x65C7630", Offset = "0x65C6A30", VA = "0x1865C7630", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x65CA120", Offset = "0x65C9520", VA = "0x1865CA120", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x65C7370", Offset = "0x65C6770", VA = "0x1865C7370", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x65C4DC0", Offset = "0x65C41C0", VA = "0x1865C4DC0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x65C8E00", Offset = "0x65C8200", VA = "0x1865C8E00", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x65C5140", Offset = "0x65C4540", VA = "0x1865C5140", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x65C6210", Offset = "0x65C5610", VA = "0x1865C6210", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x65C5200", Offset = "0x65C4600", VA = "0x1865C5200", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x65C6570", Offset = "0x65C5970", VA = "0x1865C6570", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x65C7550", Offset = "0x65C6950", VA = "0x1865C7550", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x65C7900", Offset = "0x65C6D00", VA = "0x1865C7900", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x65C95E0", Offset = "0x65C89E0", VA = "0x1865C95E0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x65C8AD0", Offset = "0x65C7ED0", VA = "0x1865C8AD0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x65C8F30", Offset = "0x65C8330", VA = "0x1865C8F30", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x65CA340", Offset = "0x65C9740", VA = "0x1865CA340", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x65C7820", Offset = "0x65C6C20", VA = "0x1865C7820", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ANEFAHILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x65C9350", Offset = "0x65C8750", VA = "0x1865C9350", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DLPLMOEIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x65C89C0", Offset = "0x65C7DC0", VA = "0x1865C89C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GIBENAHIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x65CA750", Offset = "0x65C9B50", VA = "0x1865CA750", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x65C4F40", Offset = "0x65C4340", VA = "0x1865C4F40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x65C72A0", Offset = "0x65C66A0", VA = "0x1865C72A0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x65C96E0", Offset = "0x65C8AE0", VA = "0x1865C96E0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x65C5830", Offset = "0x65C4C30", VA = "0x1865C5830", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x65C52D0", Offset = "0x65C46D0", VA = "0x1865C52D0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x65CA830", Offset = "0x65C9C30", VA = "0x1865CA830", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x65C6710", Offset = "0x65C5B10", VA = "0x1865C6710", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x65C5E20", Offset = "0x65C5220", VA = "0x1865C5E20", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x65C7170", Offset = "0x65C6570", VA = "0x1865C7170", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x65C7090", Offset = "0x65C6490", VA = "0x1865C7090", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x65CA910", Offset = "0x65C9D10", VA = "0x1865CA910", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x65C7500", Offset = "0x65C6900", VA = "0x1865C7500", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x65C5A60", Offset = "0x65C4E60", VA = "0x1865C5A60", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float BBAKNJGMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x65C9400", Offset = "0x65C8800", VA = "0x1865C9400", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x65CA220", Offset = "0x65C9620", VA = "0x1865CA220", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool AGDKBABNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x65C8970", Offset = "0x65C7D70", VA = "0x1865C8970", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x65C76E0", Offset = "0x65C6AE0", VA = "0x1865C76E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x65C6850", Offset = "0x65C5C50", VA = "0x1865C6850", Slot = "48")]
		get
		{
			return default(PLAOLPDBAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x65C74A0", Offset = "0x65C68A0", VA = "0x1865C74A0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x65C79E0", Offset = "0x65C6DE0", VA = "0x1865C79E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform JLIPENOJDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x65C9D40", Offset = "0x65C9140", VA = "0x1865C9D40", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 LMCJEHOICMG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x65C9C30", Offset = "0x65C9030", VA = "0x1865C9C30", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x65CA470", Offset = "0x65C9870", VA = "0x1865CA470", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float ILNIKCAKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x65C71D0", Offset = "0x65C65D0", VA = "0x1865C71D0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x65C5260", Offset = "0x65C4660", VA = "0x1865C5260", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float LHMKDCAJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x65C96C0", Offset = "0x65C8AC0", VA = "0x1865C96C0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x65C4C60", Offset = "0x65C4060", VA = "0x1865C4C60", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion OENBJJAECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x65C9870", Offset = "0x65C8C70", VA = "0x1865C9870", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x65C6260", Offset = "0x65C5660", VA = "0x1865C6260", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x65C71F0", Offset = "0x65C65F0", VA = "0x1865C71F0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x65CA170", Offset = "0x65C9570", VA = "0x1865CA170", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x65C8DC0", Offset = "0x65C81C0", VA = "0x1865C8DC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x65C7ED0", Offset = "0x65C72D0", VA = "0x1865C7ED0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints NMBMDIIHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x65C7A30", Offset = "0x65C6E30", VA = "0x1865C7A30", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x65C5B10", Offset = "0x65C4F10", VA = "0x1865C5B10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x65C8D10", Offset = "0x65C8110", VA = "0x1865C8D10", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x65C93A0", Offset = "0x65C87A0", VA = "0x1865C93A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode CPKHADEDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x65C8390", Offset = "0x65C7790", VA = "0x1865C8390", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x65CA2E0", Offset = "0x65C96E0", VA = "0x1865CA2E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool EJBIAAMLPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x65C7CE0", Offset = "0x65C70E0", VA = "0x1865C7CE0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LGOPJDHBFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x65C9010", Offset = "0x65C8410", VA = "0x1865C9010", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool AGOJFHLKEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x65C5F60", Offset = "0x65C5360", VA = "0x1865C5F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BLPDJBECLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x65C9920", Offset = "0x65C8D20", VA = "0x1865C9920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event BNONKBGOOFP FPLNDDEPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x65C9CE0", Offset = "0x65C90E0", VA = "0x1865C9CE0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x65C57D0", Offset = "0x65C4BD0", VA = "0x1865C57D0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event BNONKBGOOFP MHKPHJBAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x65CA280", Offset = "0x65C9680", VA = "0x1865CA280", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x65C4D60", Offset = "0x65C4160", VA = "0x1865C4D60", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EBOGPGNBJGH OPJJCKGCGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x65C7A80", Offset = "0x65C6E80", VA = "0x1865C7A80", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x65C9950", Offset = "0x65C8D50", VA = "0x1865C9950", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event BNONKBGOOFP NGGELNMLDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x65C8490", Offset = "0x65C7890", VA = "0x1865C8490", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x65C6C90", Offset = "0x65C6090", VA = "0x1865C6C90", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event BNONKBGOOFP NGFHFKKGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x65C8330", Offset = "0x65C7730", VA = "0x1865C8330", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x65CA1C0", Offset = "0x65C95C0", VA = "0x1865CA1C0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event BNONKBGOOFP CJJNJGMEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x65C5B70", Offset = "0x65C4F70", VA = "0x1865C5B70", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x65C84F0", Offset = "0x65C78F0", VA = "0x1865C84F0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x65C7680", Offset = "0x65C6A80", VA = "0x1865C7680", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x65C51A0", Offset = "0x65C45A0", VA = "0x1865C51A0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event BNONKBGOOFP EBJAHHAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x65C66B0", Offset = "0x65C5AB0", VA = "0x1865C66B0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x65C6650", Offset = "0x65C5A50", VA = "0x1865C6650", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event BNONKBGOOFP MPBNJDPNHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x65CA9E0", Offset = "0x65C9DE0", VA = "0x1865CA9E0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x65C83E0", Offset = "0x65C77E0", VA = "0x1865C83E0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x65AEAC0", Offset = "0x65ADEC0", VA = "0x1865AEAC0")]
	public LEFAGGGMDHK(GameObject IFGJJHCIEPA, RigidbodyEx ALCCAMFCBLN, AAPGCFJECKF GPNCNDIBNOH, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x65C8040", Offset = "0x65C7440", VA = "0x1865C8040", Slot = "135")]
	protected virtual void JFGHLHDLJFL(AAPGCFJECKF GPNCNDIBNOH, CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x65C6440", Offset = "0x65C5840", VA = "0x1865C6440", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x65C94A0", Offset = "0x65C88A0", VA = "0x1865C94A0", Slot = "71")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x65C5AC0", Offset = "0x65C4EC0", VA = "0x1865C5AC0", Slot = "72")]
	public void CJCHOHIMKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x65C9A50", Offset = "0x65C8E50", VA = "0x1865C9A50", Slot = "73")]
	public void OBEEFAIJBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65C5720", Offset = "0x65C4B20", VA = "0x1865C5720")]
	private void CDCKLMHNAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x65C6100", Offset = "0x65C5500", VA = "0x1865C6100", Slot = "81")]
	public void DFODMMMMNPP(LOPKIINMLDJ PAHKKNONPEO, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x65C5DC0", Offset = "0x65C51C0", VA = "0x1865C5DC0", Slot = "84")]
	public void CLHBPCELMIN(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x65C8A70", Offset = "0x65C7E70", VA = "0x1865C8A70", Slot = "85")]
	public void KPODAPFFCBF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x65C5040", Offset = "0x65C4440", VA = "0x1865C5040", Slot = "86")]
	public Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x65C6000", Offset = "0x65C5400", VA = "0x1865C6000", Slot = "87")]
	public Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x65C5AC0", Offset = "0x65C4EC0", VA = "0x1865C5AC0", Slot = "88")]
	public void JCNNNDOJMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x65C9190", Offset = "0x65C8590", VA = "0x1865C9190", Slot = "89")]
	public void MENPCBEEFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x65C6800", Offset = "0x65C5C00", VA = "0x1865C6800", Slot = "90")]
	public void EIFIFEIMIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x65C6350", Offset = "0x65C5750", VA = "0x1865C6350", Slot = "91")]
	public void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x65C5E70", Offset = "0x65C5270", VA = "0x1865C5E70", Slot = "92")]
	public void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x65C7740", Offset = "0x65C6B40", VA = "0x1865C7740", Slot = "93")]
	public void HEIDFNDADGL(Vector3 IDAHODGNCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x65C4E80", Offset = "0x65C4280", VA = "0x1865C4E80", Slot = "94")]
	public void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x65C6170", Offset = "0x65C5570", VA = "0x1865C6170", Slot = "95")]
	public void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x65C7AE0", Offset = "0x65C6EE0", VA = "0x1865C7AE0", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x65C7BE0", Offset = "0x65C6FE0", VA = "0x1865C7BE0", Slot = "97")]
	public Vector3 IIANNBIMKCJ(Vector3 PAHKKNONPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x65C8870", Offset = "0x65C7C70", VA = "0x1865C8870", Slot = "98")]
	public Vector3 KJHLJJGAFCA(Vector3 PAHKKNONPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x65CA420", Offset = "0x65C9820", VA = "0x1865CA420", Slot = "99")]
	public void PEMBIILOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x65C6900", Offset = "0x65C5D00", VA = "0x1865C6900", Slot = "100")]
	public void FAHOILKMAOF(LOPKIINMLDJ HDIFEJDMLPC, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x65C7240", Offset = "0x65C6640", VA = "0x1865C7240", Slot = "101")]
	public void GCDMGJHBNEJ(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x65CA040", Offset = "0x65C9440", VA = "0x1865CA040", Slot = "41")]
	public void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x65CAA90", Offset = "0x65C9E90", VA = "0x1865CAA90", Slot = "104")]
	public void PPMKLCHMMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x65C6FE0", Offset = "0x65C63E0", VA = "0x1865C6FE0", Slot = "105")]
	public void FIIDMNEAIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x65C4FF0", Offset = "0x65C43F0", VA = "0x1865C4FF0", Slot = "106")]
	public void BHKBAAKFHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x65C8CC0", Offset = "0x65C80C0", VA = "0x1865C8CC0", Slot = "109")]
	public bool LJCOGDJCLOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x65C8550", Offset = "0x65C7950", VA = "0x1865C8550", Slot = "74")]
	public void KGGOHHLELDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x65C7F10", Offset = "0x65C7310", VA = "0x1865C7F10", Slot = "110")]
	public void JAPGJOMEKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x65C9D50", Offset = "0x65C9150", VA = "0x1865C9D50", Slot = "115")]
	public IDisposable OGOKFHMDAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x65C6510", Offset = "0x65C5910", VA = "0x1865C6510", Slot = "116")]
	public void EAFLCLEHBGM(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x65C7E70", Offset = "0x65C7270", VA = "0x1865C7E70", Slot = "117")]
	public void IMHKAJLMECI(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x65CA630", Offset = "0x65C9A30", VA = "0x1865CA630", Slot = "118")]
	public void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x65C8670", Offset = "0x65C7A70", VA = "0x1865C8670", Slot = "121")]
	public void KIHNEKGIMLI(Vector3 PBNJKFLAPAK, Quaternion KHBBHAJCCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x65C5910", Offset = "0x65C4D10", VA = "0x1865C5910", Slot = "122")]
	public void CDNJMCGGLMF(Vector3 JGJHMIAHIAD, Quaternion NFFONAKHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x65C4F90", Offset = "0x65C4390", VA = "0x1865C4F90", Slot = "123")]
	public bool BFJMFNANIKN(float GLJGILHBCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x65C4E20", Offset = "0x65C4220", VA = "0x1865C4E20", Slot = "124")]
	public void AGCBCLMLEBG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x65C9F10", Offset = "0x65C9310", VA = "0x1865C9F10", Slot = "125")]
	public void OHGHANHOFHH(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x65C97C0", Offset = "0x65C8BC0", VA = "0x1865C97C0", Slot = "126")]
	public void NKKMMACOGPC(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x65C7030", Offset = "0x65C6430", VA = "0x1865C7030", Slot = "127")]
	public void FLFGGGFBBEG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x65C8E50", Offset = "0x65C8250", VA = "0x1865C8E50", Slot = "128")]
	public void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x65C6CF0", Offset = "0x65C60F0", VA = "0x1865C6CF0", Slot = "129")]
	public void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x65C91E0", Offset = "0x65C85E0", VA = "0x1865C91E0", Slot = "130")]
	public void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x65C7F60", Offset = "0x65C7360", VA = "0x1865C7F60", Slot = "131")]
	public void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x65C6760", Offset = "0x65C5B60", VA = "0x1865C6760", Slot = "132")]
	public bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x65C7E20", Offset = "0x65C7220", VA = "0x1865C7E20", Slot = "133")]
	public void IIGAPFPPEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x65CAAE0", Offset = "0x65C9EE0", VA = "0x1865CAAE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x65C73C0", Offset = "0x65C67C0", VA = "0x1865C73C0")]
	private void GJGIOJOHCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x65C8BB0", Offset = "0x65C7FB0", VA = "0x1865C8BB0")]
	private void LFCAPFBGOHL(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x65C5BD0", Offset = "0x65C4FD0", VA = "0x1865C5BD0")]
	private void CKHPANOAEOM(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x65CA6A0", Offset = "0x65C9AA0", VA = "0x1865CA6A0")]
	private void PKNLCHIHGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x65CA530", Offset = "0x65C9930", VA = "0x1865CA530")]
	private void PHLEGFDPNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x65C6E00", Offset = "0x65C6200", VA = "0x1865C6E00")]
	private void FIEIJONPEMD(LOPKIINMLDJ GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x65C85A0", Offset = "0x65C79A0", VA = "0x1865C85A0")]
	private void KIFEENKGECL(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65C9F70", Offset = "0x65C9370", VA = "0x1865C9F70")]
	private void OHIPAPIFHMM(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x65C9DA0", Offset = "0x65C91A0", VA = "0x1865C9DA0")]
	private void OHAOOBCBHFD(RigidbodyEx AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x65C9A70", Offset = "0x65C8E70", VA = "0x1865C9A70", Slot = "140")]
	protected virtual void OBOOJAKNIND(RigidbodyEx CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x65C6970", Offset = "0x65C5D70", VA = "0x1865C6970")]
	protected void FCAIFNDLDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x65C53B0", Offset = "0x65C47B0", VA = "0x1865C53B0")]
	protected void CCJHHPPMGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x65C99B0", Offset = "0x65C8DB0", VA = "0x1865C99B0", Slot = "141")]
	protected virtual IDisposable OANJHIFDMFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class MABEMLLHKIN
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x65CBD40", Offset = "0x65CB140", VA = "0x1865CBD40")]
	public static LOPKIINMLDJ IIJHBCHEAEH(this LOPKIINMLDJ CIJDIMEFBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x65CBCC0", Offset = "0x65CB0C0", VA = "0x1865CBCC0")]
	public static bool FAKNPHKJHDK(this LOPKIINMLDJ CIJDIMEFBGG, LOPKIINMLDJ KLPLFAFLDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x65CBC40", Offset = "0x65CB040", VA = "0x1865CBC40")]
	public static bool EHJENLHDPFM(this LOPKIINMLDJ CIJDIMEFBGG, LOPKIINMLDJ DMPKMINEHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x65CBDF0", Offset = "0x65CB1F0", VA = "0x1865CBDF0")]
	public static RigidbodyEx MCOMEAOILPK(this LOPKIINMLDJ AFMAIMAFNHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x65CBBC0", Offset = "0x65CAFC0", VA = "0x1865CBBC0")]
	public static LEFAGGGMDHK EBLAEJIEMGF(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class HKIIMIIEEHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BIPKAKIEIHN;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x65B7500", Offset = "0x65B6900", VA = "0x1865B7500")]
	public HKIIMIIEEHM(LEFAGGGMDHK LFEGGLDFJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x65B74A0", Offset = "0x65B68A0", VA = "0x1865B74A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class OBAMKMNOLKB : IBKHILMINOG, CJHGCJOMLPH
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode GDCMFHDJHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x65CDD60", Offset = "0x65CD160", VA = "0x1865CDD60")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65CDCF0", Offset = "0x65CD0F0", VA = "0x1865CDCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode CPKHADEDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x65CDBE0", Offset = "0x65CCFE0", VA = "0x1865CDBE0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x65CDFF0", Offset = "0x65CD3F0", VA = "0x1865CDFF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public OBAMKMNOLKB(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x65CDDC0", Offset = "0x65CD1C0", VA = "0x1865CDDC0", Slot = "6")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x65CDF10", Offset = "0x65CD310", VA = "0x1865CDF10", Slot = "9")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x65CDA60", Offset = "0x65CCE60", VA = "0x1865CDA60", Slot = "7")]
	public void GKOLHJMMOFE(bool MGICFOILBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x65CDA50", Offset = "0x65CCE50", VA = "0x1865CDA50", Slot = "8")]
	public void EIACHLIPLGF(bool MGICFOILBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x65CD8F0", Offset = "0x65CCCF0", VA = "0x1865CD8F0", Slot = "10")]
	public bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x65CDA70", Offset = "0x65CCE70", VA = "0x1865CDA70")]
	private void HAPALJKMNPP(bool MGICFOILBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class OFLKIANAINJ : IBKHILMINOG, EIPMHAPKEIH, IDisposable, FIEBEGLBPNG
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PLAOLPDBAPK NDKLKGKGBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x65CE710", Offset = "0x65CDB10", VA = "0x1865CE710")]
		get
		{
			return default(PLAOLPDBAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x65CE9F0", Offset = "0x65CDDF0", VA = "0x1865CE9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x65CE7F0", Offset = "0x65CDBF0", VA = "0x1865CE7F0", Slot = "6")]
		get
		{
			return default(PLAOLPDBAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x65CE9F0", Offset = "0x65CDDF0", VA = "0x1865CE9F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform GFDIADPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x65CEAE0", Offset = "0x65CDEE0", VA = "0x1865CEAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x65CE660", Offset = "0x65CDA60", VA = "0x1865CE660", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public OFLKIANAINJ(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x65CEB90", Offset = "0x65CDF90", VA = "0x1865CEB90", Slot = "11")]
	public void OnChangedDistanceBand(ELKPCEJHCMJ JBDKOGGCLOE, ELKPCEJHCMJ MCNFPBNKOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "12")]
	public void OnChangedVisibility(bool DJGHECGIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "8")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ACLMIHGPGKF : IBKHILMINOG, EOHJMBLPLJB
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x65AC450", Offset = "0x65AB850", VA = "0x1865AC450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x65AC170", Offset = "0x65AB570", VA = "0x1865AC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC70", Offset = "0x65AC070", VA = "0x1865ACC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public ACLMIHGPGKF(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x65AC960", Offset = "0x65ABD60", VA = "0x1865AC960", Slot = "4")]
	public void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x65ABE90", Offset = "0x65AB290", VA = "0x1865ABE90")]
	private void BGCIPNBBJNI(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x65AC1D0", Offset = "0x65AB5D0", VA = "0x1865AC1D0", Slot = "5")]
	public void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x65ACAC0", Offset = "0x65ABEC0", VA = "0x1865ACAC0", Slot = "6")]
	public void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65AC700", Offset = "0x65ABB00", VA = "0x1865AC700")]
	private void JCEMLGAFONM(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x65AC4A0", Offset = "0x65AB8A0", VA = "0x1865AC4A0", Slot = "7")]
	public void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x65ABDB0", Offset = "0x65AB1B0", VA = "0x1865ABDB0")]
	private void AOEJNDMBIGP(string AGOKDCAFCLN, UnityEngine.Object AOGDICEMNLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class CNMNJFCGECB : IBKHILMINOG, AJGEPFOHMIH
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool AGDKBABNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x65AF8E0", Offset = "0x65AECE0", VA = "0x1865AF8E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x65AF790", Offset = "0x65AEB90", VA = "0x1865AF790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public CNMNJFCGECB(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x65AF9B0", Offset = "0x65AEDB0", VA = "0x1865AF9B0", Slot = "6")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x65AF940", Offset = "0x65AED40", VA = "0x1865AF940", Slot = "7")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class IFBJGIFPPBK : IBKHILMINOG, EFNEBKACGOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly KBKFCGENGMC EJHPIFGFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KLFBGFAFHFD KENIOFOEJPF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x65BD3C0", Offset = "0x65BC7C0", VA = "0x1865BD3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PIKFEMDGCNE LJANLPDMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x65BC480", Offset = "0x65BB880", VA = "0x1865BC480")]
		get
		{
			return default(PIKFEMDGCNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x65BC220", Offset = "0x65BB620", VA = "0x1865BC220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x65BD4A0", Offset = "0x65BC8A0", VA = "0x1865BD4A0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x65BD170", Offset = "0x65BC570", VA = "0x1865BD170", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PIKFEMDGCNE LHAAFEFEIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x65BD110", Offset = "0x65BC510", VA = "0x1865BD110")]
		get
		{
			return default(PIKFEMDGCNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x65BD510", Offset = "0x65BC910", VA = "0x1865BD510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x65BCDB0", Offset = "0x65BC1B0", VA = "0x1865BCDB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x792F20", Offset = "0x792320", VA = "0x180792F20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event BNONKBGOOFP FPLNDDEPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x65BD620", Offset = "0x65BCA20", VA = "0x1865BD620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x65BC330", Offset = "0x65BB730", VA = "0x1865BC330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event BNONKBGOOFP MHKPHJBAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x65BD6C0", Offset = "0x65BCAC0", VA = "0x1865BD6C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x65BB9B0", Offset = "0x65BADB0", VA = "0x1865BB9B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EBOGPGNBJGH OPJJCKGCGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x65BCBD0", Offset = "0x65BBFD0", VA = "0x1865BCBD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x65BD580", Offset = "0x65BC980", VA = "0x1865BD580", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action IMIIKPKGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x65BCE20", Offset = "0x65BC220", VA = "0x1865BCE20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x65BB910", Offset = "0x65BAD10", VA = "0x1865BB910", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action JGKDLBAFMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x65BC290", Offset = "0x65BB690", VA = "0x1865BC290", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x65BCD10", Offset = "0x65BC110", VA = "0x1865BCD10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<LOPKIINMLDJ> CEDPFPDCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x65BD3F0", Offset = "0x65BC7F0", VA = "0x1865BD3F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x65BC3D0", Offset = "0x65BB7D0", VA = "0x1865BC3D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<LOPKIINMLDJ> MNJAOHIPOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x65BC660", Offset = "0x65BBA60", VA = "0x1865BC660", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x65BC710", Offset = "0x65BBB10", VA = "0x1865BC710", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action AJCGMHHIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x65BCB30", Offset = "0x65BBF30", VA = "0x1865BCB30", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x65BBED0", Offset = "0x65BB2D0", VA = "0x1865BBED0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<LOPKIINMLDJ> CIMCPDBOPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x65BC9E0", Offset = "0x65BBDE0", VA = "0x1865BC9E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x65BC5B0", Offset = "0x65BB9B0", VA = "0x1865BC5B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x65BD7F0", Offset = "0x65BCBF0", VA = "0x1865BD7F0")]
	public IFBJGIFPPBK(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x65BC7C0", Offset = "0x65BBBC0", VA = "0x1865BC7C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x65BC4E0", Offset = "0x65BB8E0", VA = "0x1865BC4E0", Slot = "26")]
	public void DFODMMMMNPP(LOPKIINMLDJ JOPIDNPFKKJ, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x65BC560", Offset = "0x65BB960", VA = "0x1865BC560")]
	private void DFODMMMMNPP(CBEOABNIIDM JOPIDNPFKKJ, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x65BBA50", Offset = "0x65BAE50", VA = "0x1865BBA50")]
	private void AECANBNIKCK(CBEOABNIIDM JOPIDNPFKKJ, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x65BCEC0", Offset = "0x65BC2C0", VA = "0x1865BCEC0")]
	private void LIHABECHJDN(CBEOABNIIDM GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x65BBF70", Offset = "0x65BB370", VA = "0x1865BBF70")]
	private void BCDLDEKCADP(CBEOABNIIDM GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x65BD1E0", Offset = "0x65BC5E0", VA = "0x1865BD1E0")]
	private void LNJIDHDBOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x65BC170", Offset = "0x65BB570", VA = "0x1865BC170")]
	private void BDGOCGBHOIH(CBEOABNIIDM GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x65BC8F0", Offset = "0x65BBCF0", VA = "0x1865BC8F0")]
	private void FKKFDHCDANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x65BCC70", Offset = "0x65BC070", VA = "0x1865BCC70")]
	private void HOIHJCNCDNK(CBEOABNIIDM CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x65BCA90", Offset = "0x65BBE90", VA = "0x1865BCA90")]
	private void FMLLAAPNOHK(CBEOABNIIDM CIJDIMEFBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class IJNHABMEDFP
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x65BD9D0", Offset = "0x65BCDD0", VA = "0x1865BD9D0")]
	public static IFBJGIFPPBK JOHGFLKEABF(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BFCMKJAKHAN : IBKHILMINOG, IOPPPMDNCCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x65AD930", Offset = "0x65ACD30", VA = "0x1865AD930", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x65ADD20", Offset = "0x65AD120", VA = "0x1865ADD20", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x65ADC30", Offset = "0x65AD030", VA = "0x1865ADC30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private LOPKIINMLDJ NPGJDIEKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x65AD3C0", Offset = "0x65AC7C0", VA = "0x1865AD3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public BFCMKJAKHAN(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x65ADAE0", Offset = "0x65ACEE0", VA = "0x1865ADAE0", Slot = "6")]
	public void KKGGBGKAKAG(LOPKIINMLDJ AOGBEAODJPP, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x65AD9D0", Offset = "0x65ACDD0", VA = "0x1865AD9D0")]
	private void KKGGBGKAKAG(CBEOABNIIDM AOGBEAODJPP, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x65AD960", Offset = "0x65ACD60", VA = "0x1865AD960", Slot = "7")]
	public void IKPHOLMONCD(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x65AD520", Offset = "0x65AC920", VA = "0x1865AD520")]
	private Vector3 FIEEFCAHMCH()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class IAKKEIOKAOM
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x65B8690", Offset = "0x65B7A90", VA = "0x1865B8690")]
	public static BFCMKJAKHAN EKEGEGMBIAH(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class LAAHEIONBGN : IBKHILMINOG, IGEIHFPCEFN
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x65C0E70", Offset = "0x65C0270", VA = "0x1865C0E70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x65C0CF0", Offset = "0x65C00F0", VA = "0x1865C0CF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 BOKPIKCNOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x65C2BD0", Offset = "0x65C1FD0", VA = "0x1865C2BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 PGMJHKBEBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x65C11C0", Offset = "0x65C05C0", VA = "0x1865C11C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x65C3A70", Offset = "0x65C2E70", VA = "0x1865C3A70", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x65C1160", Offset = "0x65C0560", VA = "0x1865C1160", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float BBMCFGMICIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x65C1040", Offset = "0x65C0440", VA = "0x1865C1040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x65C0FE0", Offset = "0x65C03E0", VA = "0x1865C0FE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x65C0F20", Offset = "0x65C0320", VA = "0x1865C0F20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x65C1820", Offset = "0x65C0C20", VA = "0x1865C1820", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x65C3C60", Offset = "0x65C3060", VA = "0x1865C3C60", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event BNONKBGOOFP FEJBOENEGID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x65C3670", Offset = "0x65C2A70", VA = "0x1865C3670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x65C10C0", Offset = "0x65C04C0", VA = "0x1865C10C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x65C3E80", Offset = "0x65C3280", VA = "0x1865C3E80")]
	public LAAHEIONBGN(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x65C1850", Offset = "0x65C0C50", VA = "0x1865C1850")]
	public float3 HAAFCELHBIG()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x65C37E0", Offset = "0x65C2BE0", VA = "0x1865C37E0", Slot = "14")]
	public void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x65C3C90", Offset = "0x65C3090", VA = "0x1865C3C90", Slot = "16")]
	public void PPMKLCHMMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x65C12F0", Offset = "0x65C06F0", VA = "0x1865C12F0", Slot = "15")]
	public void FIIDMNEAIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x65C3710", Offset = "0x65C2B10", VA = "0x1865C3710", Slot = "18")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x65C3280", Offset = "0x65C2680", VA = "0x1865C3280", Slot = "19")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x65C0C90", Offset = "0x65C0090", VA = "0x1865C0C90", Slot = "17")]
	public void BHKBAAKFHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x65C2C80", Offset = "0x65C2080", VA = "0x1865C2C80", Slot = "20")]
	public void IIGAPFPPEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF90", Offset = "0x65AC390", VA = "0x1865ACF90")]
	public void ILBNAFEAPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x65C0CF0", Offset = "0x65C00F0", VA = "0x1865C0CF0")]
	private void LCOKIBAOACG(Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x65C1640", Offset = "0x65C0A40", VA = "0x1865C1640")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 FILNPBDCKED()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x65C0F20", Offset = "0x65C0320", VA = "0x1865C0F20")]
	private void CIJKONBKKEM(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65C07F0", Offset = "0x65BFBF0", VA = "0x1865C07F0")]
	private Vector3 ABELCLBLDJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x65C0A50", Offset = "0x65BFE50", VA = "0x1865C0A50")]
	private Quaternion BAAHGEAFAHI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65C1970", Offset = "0x65C0D70", VA = "0x1865C1970")]
	internal (float, Vector3) HCBLPJLOMFF(Rigidbody FDIIDHJAFPH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class DLEKEFGHPCL
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65B0870", Offset = "0x65AFC70", VA = "0x1865B0870")]
	public static LAAHEIONBGN KHNFPFOGFDE(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GHJDEELNDOJ : IBKHILMINOG, LEDJPGIEGJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool EIJNAELFFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x65B5C10", Offset = "0x65B5010", VA = "0x1865B5C10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public MDABCJFKJMP KJAMDHPFLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x65B5DD0", Offset = "0x65B51D0", VA = "0x1865B5DD0", Slot = "11")]
		get
		{
			return default(MDABCJFKJMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private MDABCJFKJMP PBLMMPINJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x65B5DD0", Offset = "0x65B51D0", VA = "0x1865B5DD0")]
		get
		{
			return default(MDABCJFKJMP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x65B5E30", Offset = "0x65B5230", VA = "0x1865B5E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65B6020", Offset = "0x65B5420", VA = "0x1865B6020")]
	public GHJDEELNDOJ(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x65B5EA0", Offset = "0x65B52A0", VA = "0x1865B5EA0", Slot = "4")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x65B5C70", Offset = "0x65B5070", VA = "0x1865B5C70")]
	private bool HIFCEPJJCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x65B5D50", Offset = "0x65B5150", VA = "0x1865B5D50", Slot = "5")]
	public void KFLHBDIDEHD(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x65B5B90", Offset = "0x65B4F90", VA = "0x1865B5B90", Slot = "6")]
	public void GLBJGGCGKGF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x65B58B0", Offset = "0x65B4CB0", VA = "0x1865B58B0", Slot = "9")]
	public void CJJFAPEHMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x65B5A10", Offset = "0x65B4E10", VA = "0x1865B5A10")]
	private void CKKOEODKACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x65B5710", Offset = "0x65B4B10", VA = "0x1865B5710")]
	private void AAJDCCNBPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x65B5FA0", Offset = "0x65B53A0", VA = "0x1865B5FA0", Slot = "8")]
	public void NFJGPCPLGEL(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x65B5B10", Offset = "0x65B4F10", VA = "0x1865B5B10", Slot = "7")]
	public void EADMBNPPCCK(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class ACNNCHKEEKG : IBKHILMINOG, MOIAKGIAEBL
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x65ACF20", Offset = "0x65AC320", VA = "0x1865ACF20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool IEKNBIHEALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x65ACD70", Offset = "0x65AC170", VA = "0x1865ACD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event BNONKBGOOFP EBJAHHAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x65ACE80", Offset = "0x65AC280", VA = "0x1865ACE80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x65ACDE0", Offset = "0x65AC1E0", VA = "0x1865ACDE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public ACNNCHKEEKG(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x65AD190", Offset = "0x65AC590", VA = "0x1865AD190", Slot = "11")]
	public IDisposable OGOKFHMDAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x65ACDD0", Offset = "0x65AC1D0", VA = "0x1865ACDD0", Slot = "8")]
	public void EAFLCLEHBGM(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF80", Offset = "0x65AC380", VA = "0x1865ACF80", Slot = "9")]
	public void IMHKAJLMECI(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x65AD200", Offset = "0x65AC600", VA = "0x1865AD200", Slot = "10")]
	public void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x65AD0B0", Offset = "0x65AC4B0", VA = "0x1865AD0B0", Slot = "12")]
	public void OGAKKONLIDI(Rigidbody PKDFFNNLBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x65ACFD0", Offset = "0x65AC3D0", VA = "0x1865ACFD0", Slot = "13")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF90", Offset = "0x65AC390", VA = "0x1865ACF90", Slot = "6")]
	public void JOMFFFCKIJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DHCFANKOFFN : IBKHILMINOG, HPNKGGILPOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView NIMPPBCFGKJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x65B0130", Offset = "0x65AF530", VA = "0x1865B0130", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x65B0720", Offset = "0x65AFB20", VA = "0x1865B0720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event BNONKBGOOFP NGGELNMLDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x65B0150", Offset = "0x65AF550", VA = "0x1865B0150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x65B0090", Offset = "0x65AF490", VA = "0x1865B0090", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x65B07B0", Offset = "0x65AFBB0", VA = "0x1865B07B0")]
	public DHCFANKOFFN(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x65B03F0", Offset = "0x65AF7F0", VA = "0x1865B03F0", Slot = "8")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x65AFD70", Offset = "0x65AF170", VA = "0x1865AFD70", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x65B01F0", Offset = "0x65AF5F0", VA = "0x1865B01F0", Slot = "9")]
	public void KIFEENKGECL(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x65B0520", Offset = "0x65AF920", VA = "0x1865B0520", Slot = "10")]
	public void OHIPAPIFHMM(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x65AFB90", Offset = "0x65AEF90", VA = "0x1865AFB90")]
	private void CLAGBEGBHKA(PhotonView PKIEIKAKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x65AFA40", Offset = "0x65AEE40", VA = "0x1865AFA40")]
	private void BHCBHCJCDND(RigidbodyEx AEPAEDNHHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x65AFED0", Offset = "0x65AF2D0", VA = "0x1865AFED0")]
	private void ENGNBHMFJJL(PhotonView AHPNPDPNHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class CBOFMLFODEM
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x65AEB90", Offset = "0x65ADF90", VA = "0x1865AEB90")]
	public static DHCFANKOFFN IHHDPFAGNIE(this LEFAGGGMDHK ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class HOJMOFGJGLO : IBKHILMINOG, NGCFDOFAHHF
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x65B83C0", Offset = "0x65B77C0", VA = "0x1865B83C0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x65B8420", Offset = "0x65B7820", VA = "0x1865B8420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool AODJAILCEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x65B8280", Offset = "0x65B7680", VA = "0x1865B8280", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x65B8090", Offset = "0x65B7490", VA = "0x1865B8090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints NMBMDIIHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x65B82E0", Offset = "0x65B76E0", VA = "0x1865B82E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x65B8100", Offset = "0x65B7500", VA = "0x1865B8100", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x65B8520", Offset = "0x65B7920", VA = "0x1865B8520")]
	public HOJMOFGJGLO(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x65B8490", Offset = "0x65B7890", VA = "0x1865B8490", Slot = "9")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x65B8340", Offset = "0x65B7740", VA = "0x1865B8340", Slot = "10")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class MOCOCAMJICO : IBKHILMINOG, GEMBEPEDECL
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x65CC700", Offset = "0x65CBB00", VA = "0x1865CC700", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x65CC5B0", Offset = "0x65CB9B0", VA = "0x1865CC5B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float BBAKNJGMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x65CC830", Offset = "0x65CBC30", VA = "0x1865CC830", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x65CC980", Offset = "0x65CBD80", VA = "0x1865CC980", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public MOCOCAMJICO(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x65CC890", Offset = "0x65CBC90", VA = "0x1865CC890", Slot = "8")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x65CC760", Offset = "0x65CBB60", VA = "0x1865CC760", Slot = "9")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[GIDPDJJGMLG(typeof(BPGACLDPFJK), new string[] { })]
public sealed class OAPMOLLPPGL : ACLOEOFNKAE, BPGACLDPFJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[GFFJKOFNHJO]
	private KGBGGKOMJHD CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool BIPKAKIEIHN;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool NABJPIJAAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x65CD470", Offset = "0x65CC870", VA = "0x1865CD470", Slot = "4")]
	public void InitReferences(NLGOFGOGHKI DPELPGGDADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x65CD010", Offset = "0x65CC410", VA = "0x1865CD010", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x65CD130", Offset = "0x65CC530", VA = "0x1865CD130", Slot = "6")]
	public void HCBLPJLOMFF(PIKFEMDGCNE NLDMFIFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x65CD250", Offset = "0x65CC650", VA = "0x1865CD250", Slot = "7")]
	public void HJNMHEKNPFD(PIKFEMDGCNE NLDMFIFGFAP, bool NOCOEFCKKFC, bool LIJNGIIOKBH, bool GMGJFBJDGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x65CD6C0", Offset = "0x65CCAC0", VA = "0x1865CD6C0", Slot = "8")]
	public void OFHCDGFMJDC(PIKFEMDGCNE NLDMFIFGFAP, float3 ACBJEELMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x65CD4C0", Offset = "0x65CC8C0", VA = "0x1865CD4C0", Slot = "9")]
	public void LGNEFIENJEB(PIKFEMDGCNE NLDMFIFGFAP, float3 NMJFDBALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x65CD600", Offset = "0x65CCA00", VA = "0x1865CD600")]
	private bool NAMIJJJPBLM(PIKFEMDGCNE NLDMFIFGFAP, [Out] CBEOABNIIDM ABLKMCPEJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x65CD800", Offset = "0x65CCC00", VA = "0x1865CD800")]
	private bool OHMOHNJPBJM(PIKFEMDGCNE NLDMFIFGFAP, [Out] LAAHEIONBGN OANLFMDCDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x65CD040", Offset = "0x65CC440", VA = "0x1865CD040")]
	private bool EAKEMNIAHBF(PIKFEMDGCNE NLDMFIFGFAP, [Out] ENBBKECCDGI ACKMDBFINBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public OAPMOLLPPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HLHAMHNCCEO : IBKHILMINOG, PKEMFEKJJOP
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool EJBIAAMLPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x65B3BA0", Offset = "0x65B2FA0", VA = "0x1865B3BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x65B7E20", Offset = "0x65B7220", VA = "0x1865B7E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x65B77D0", Offset = "0x65B6BD0", VA = "0x1865B77D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool HOPIFPHNHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x65B7770", Offset = "0x65B6B70", VA = "0x1865B7770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x65B7EF0", Offset = "0x65B72F0", VA = "0x1865B7EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool IMIFJNKCPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x65B7830", Offset = "0x65B6C30", VA = "0x1865B7830")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x65B7E80", Offset = "0x65B7280", VA = "0x1865B7E80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int POGMBHDNHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x65B7B60", Offset = "0x65B6F60", VA = "0x1865B7B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event BNONKBGOOFP CJJNJGMEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x65B76D0", Offset = "0x65B6AD0", VA = "0x1865B76D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x65B79D0", Offset = "0x65B6DD0", VA = "0x1865B79D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x65B7F60", Offset = "0x65B7360", VA = "0x1865B7F60")]
	public HLHAMHNCCEO(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65B7D70", Offset = "0x65B7170", VA = "0x1865B7D70", Slot = "6")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x65B7660", Offset = "0x65B6A60", VA = "0x1865B7660", Slot = "8")]
	public void CFNIEDCOBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x65B7BD0", Offset = "0x65B6FD0", VA = "0x1865B7BD0", Slot = "7")]
	public bool LJCOGDJCLOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x65B7A70", Offset = "0x65B6E70", VA = "0x1865B7A70", Slot = "9")]
	public void KGGOHHLELDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF90", Offset = "0x65AC390", VA = "0x1865ACF90", Slot = "12")]
	public void MMAAJAMFNHI(bool PJKPPHMJKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x65B7890", Offset = "0x65B6C90", VA = "0x1865B7890", Slot = "11")]
	public void JAPGJOMEKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "10")]
	public void AJLIPNLFPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x65B7580", Offset = "0x65B6980", VA = "0x1865B7580")]
	private void CENDBJAKFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class LCGFJMGHPNF : IBKHILMINOG, IONDHNBLODE
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x65C48A0", Offset = "0x65C3CA0", VA = "0x1865C48A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x65C4AB0", Offset = "0x65C3EB0", VA = "0x1865C4AB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x65AC170", Offset = "0x65AB570", VA = "0x1865AC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool JKJELODCLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x65C43D0", Offset = "0x65C37D0", VA = "0x1865C43D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x65C4BA0", Offset = "0x65C3FA0", VA = "0x1865C4BA0")]
	public LCGFJMGHPNF(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x65C4980", Offset = "0x65C3D80", VA = "0x1865C4980", Slot = "5")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x65C4A30", Offset = "0x65C3E30", VA = "0x1865C4A30", Slot = "7")]
	public void NKKMMACOGPC(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x65C4430", Offset = "0x65C3830", VA = "0x1865C4430", Slot = "8")]
	public void FLFGGGFBBEG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x65C44B0", Offset = "0x65C38B0", VA = "0x1865C44B0", Slot = "9")]
	public void IGGLJJJLAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65C4170", Offset = "0x65C3570", VA = "0x1865C4170", Slot = "11")]
	public void BNHDLCGOCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x65C46D0", Offset = "0x65C3AD0", VA = "0x1865C46D0", Slot = "12")]
	public void KIKKJGHPLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "10")]
	public void HHFJFBKKBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class ENBBKECCDGI : IBKHILMINOG, FFPDBHGELEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x65B3190", Offset = "0x65B2590", VA = "0x1865B3190", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x65B18D0", Offset = "0x65B0CD0", VA = "0x1865B18D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x65B44D0", Offset = "0x65B38D0", VA = "0x1865B44D0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x65B20F0", Offset = "0x65B14F0", VA = "0x1865B20F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x65B4470", Offset = "0x65B3870", VA = "0x1865B4470", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x65B4870", Offset = "0x65B3C70", VA = "0x1865B4870", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x65B3100", Offset = "0x65B2500", VA = "0x1865B3100", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x65B32B0", Offset = "0x65B26B0", VA = "0x1865B32B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x65B5270", Offset = "0x65B4670", VA = "0x1865B5270", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x65B3560", Offset = "0x65B2960", VA = "0x1865B3560", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x65B3620", Offset = "0x65B2A20", VA = "0x1865B3620", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x65B4F00", Offset = "0x65B4300", VA = "0x1865B4F00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x65B2D30", Offset = "0x65B2130", VA = "0x1865B2D30", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x65B2160", Offset = "0x65B1560", VA = "0x1865B2160", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x65B1EB0", Offset = "0x65B12B0", VA = "0x1865B1EB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private EOHJMBLPLJB DMAMGPJADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E610", Offset = "0x1E6DA10", VA = "0x181E6E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool EJBIAAMLPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x65B3BA0", Offset = "0x65B2FA0", VA = "0x1865B3BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public ENBBKECCDGI(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x65B2FD0", Offset = "0x65B23D0", VA = "0x1865B2FD0", Slot = "20")]
	public void DOEABMEIHOL(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x65B3240", Offset = "0x65B2640", VA = "0x1865B3240", Slot = "30")]
	public void GIGJNPIMOEF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x65B3BC0", Offset = "0x65B2FC0", VA = "0x1865B3BC0", Slot = "19")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x65B3040", Offset = "0x65B2440", VA = "0x1865B3040", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x65B5100", Offset = "0x65B4500", VA = "0x1865B5100", Slot = "28")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x65B1F10", Offset = "0x65B1310", VA = "0x1865B1F10", Slot = "35")]
	public Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x65B28C0", Offset = "0x65B1CC0", VA = "0x1865B28C0", Slot = "34")]
	public Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x65B3BC0", Offset = "0x65B2FC0", VA = "0x1865B3BC0", Slot = "27")]
	public void JCNNNDOJMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x65B4930", Offset = "0x65B3D30", VA = "0x1865B4930", Slot = "25")]
	public void MENPCBEEFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x65B3130", Offset = "0x65B2530", VA = "0x1865B3130", Slot = "24")]
	public void EIFIFEIMIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x65B2D90", Offset = "0x65B2190", VA = "0x1865B2D90", Slot = "33")]
	public void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x65B22B0", Offset = "0x65B16B0", VA = "0x1865B22B0", Slot = "32")]
	public void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x65B3390", Offset = "0x65B2790", VA = "0x1865B3390", Slot = "31")]
	public void HEIDFNDADGL(Vector3 IDAHODGNCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x65B1940", Offset = "0x65B0D40", VA = "0x1865B1940", Slot = "22")]
	public void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x65B2A80", Offset = "0x65B1E80", VA = "0x1865B2A80", Slot = "21")]
	public void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x65B3650", Offset = "0x65B2A50", VA = "0x1865B3650", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65B3AC0", Offset = "0x65B2EC0", VA = "0x1865B3AC0", Slot = "29")]
	public Vector3 IIANNBIMKCJ(Vector3 MADKEMKIPKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65B52D0", Offset = "0x65B46D0", VA = "0x1865B52D0", Slot = "26")]
	public void PEMBIILOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x65B2160", Offset = "0x65B1560", VA = "0x1865B2160")]
	private void IMKNDKIDFHL(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65B4F30", Offset = "0x65B4330", VA = "0x1865B4F30")]
	private void OALNFOBACAF(Vector3 DLOEOMMLHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65B41F0", Offset = "0x65B35F0", VA = "0x1865B41F0")]
	private Vector3 KLDBIABHLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x65B3C70", Offset = "0x65B3070", VA = "0x1865B3C70")]
	private void KINGJPBCPIB(Vector3 ACBJEELMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x65B45E0", Offset = "0x65B39E0", VA = "0x1865B45E0")]
	private Vector3 MCJKJKAEMBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x65B4990", Offset = "0x65B3D90", VA = "0x1865B4990")]
	private void NBCNBEAPOHJ(Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x65B4580", Offset = "0x65B3980", VA = "0x1865B4580")]
	private void MBANAPKNDCI(Vector3 MADKEMKIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x65B3A60", Offset = "0x65B2E60", VA = "0x1865B3A60")]
	private void IACABKNKOLH(Vector3 PEAINEKGLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x65B2310", Offset = "0x65B1710", VA = "0x1865B2310")]
	private void DBKDMHHAAIJ(string JAADPDIIBDB, Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x65B32E0", Offset = "0x65B26E0", VA = "0x1865B32E0")]
	private void HCHADLMPDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class IBKHILMINOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly CBEOABNIIDM CIJDIMEFBGG;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected KGBGGKOMJHD CHNOJKGBPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x56A8060", Offset = "0x56A7460", VA = "0x1856A8060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected PIKFEMDGCNE JLNBODNOIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x56A80A0", Offset = "0x56A74A0", VA = "0x1856A80A0")]
		get
		{
			return default(PIKFEMDGCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x65ACCD0", Offset = "0x65AC0D0", VA = "0x1865ACCD0")]
	public IBKHILMINOG(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x65B8720", Offset = "0x65B7B20", VA = "0x1865B8720")]
	protected LOPKIINMLDJ MGFKHBBKAHA(PIKFEMDGCNE HICOIGNOKIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GOKBPJPHDAN : ALCDMIAMAMK
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x65B6DB0", Offset = "0x65B61B0", VA = "0x1865B6DB0", Slot = "4")]
	public EFNEBKACGOG LGPPICLPGFI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x65B6A90", Offset = "0x65B5E90", VA = "0x1865B6A90", Slot = "5")]
	public FFPDBHGELEL GKGMHALHEJB(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x65B6130", Offset = "0x65B5530", VA = "0x1865B6130", Slot = "6")]
	public IOPPPMDNCCJ AABMGKGFDPG(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x65B69B0", Offset = "0x65B5DB0", VA = "0x1865B69B0", Slot = "7")]
	public GEMBEPEDECL GKFOKGIFBDO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x65B6280", Offset = "0x65B5680", VA = "0x1865B6280", Slot = "8")]
	public PKEMFEKJJOP ABLJCLFNCCO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x65B6630", Offset = "0x65B5A30", VA = "0x1865B6630", Slot = "9")]
	public EIPMHAPKEIH CBNNJPMPLOJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x65B68D0", Offset = "0x65B5CD0", VA = "0x1865B68D0", Slot = "10")]
	public MOIAKGIAEBL GDBHLFCNHGJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x65B6E10", Offset = "0x65B6210", VA = "0x1865B6E10", Slot = "11")]
	public EOHJMBLPLJB OJOJLLCLOEI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x65B6710", Offset = "0x65B5B10", VA = "0x1865B6710", Slot = "12")]
	public CJHGCJOMLPH COACLBDLNCH(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x65B67F0", Offset = "0x65B5BF0", VA = "0x1865B67F0", Slot = "13")]
	public AJGEPFOHMIH DKINKEHMDGP(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x65B6B80", Offset = "0x65B5F80", VA = "0x1865B6B80")]
	public IONDHNBLODE MAHCMCFGIGN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x65B63F0", Offset = "0x65B57F0", VA = "0x1865B63F0")]
	public HPNKGGILPOG ADCKALEENLD(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x65B64F0", Offset = "0x65B58F0", VA = "0x1865B64F0")]
	public LEDJPGIEGJJ HPNLECEBPDF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x65B6210", Offset = "0x65B5610", VA = "0x1865B6210")]
	public IGEIHFPCEFN AAPCGOMJOMN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x65B6EF0", Offset = "0x65B62F0", VA = "0x1865B6EF0")]
	public NGCFDOFAHHF PPGCOOHJLEG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x65B6C80", Offset = "0x65B6080", VA = "0x1865B6C80", Slot = "19")]
	public LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN, AAPGCFJECKF GPNCNDIBNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public GOKBPJPHDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x65B6B80", Offset = "0x65B5F80", VA = "0x1865B6B80", Slot = "14")]
	private IONDHNBLODE HCGPEGKKPKG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x65B63F0", Offset = "0x65B57F0", VA = "0x1865B63F0", Slot = "15")]
	private HPNKGGILPOG HBJBOANKHHE(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x65B64F0", Offset = "0x65B58F0", VA = "0x1865B64F0", Slot = "16")]
	private LEDJPGIEGJJ BDMKMIJNOHJ(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x65B6210", Offset = "0x65B5610", VA = "0x1865B6210", Slot = "17")]
	private IGEIHFPCEFN HGAAIGKLPKF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x65B6B70", Offset = "0x65B5F70", VA = "0x1865B6B70", Slot = "18")]
	private NGCFDOFAHHF HAHIAJGOKNF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class KLFBGFAFHFD : IReadOnlyList<LOPKIINMLDJ>, IEnumerable<LOPKIINMLDJ>, IEnumerable, IReadOnlyCollection<LOPKIINMLDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly KGBGGKOMJHD AMNMACHIMML;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x65C07A0", Offset = "0x65BFBA0", VA = "0x1865C07A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public LOPKIINMLDJ GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x65C0540", Offset = "0x65BF940", VA = "0x1865C0540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x33B86E0", Offset = "0x33B7AE0", VA = "0x1833B86E0")]
	public KLFBGFAFHFD(PIKFEMDGCNE HICOIGNOKIJ, KGBGGKOMJHD AMNMACHIMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x65C0690", Offset = "0x65BFA90", VA = "0x1865C0690", Slot = "6")]
	public IEnumerator<LOPKIINMLDJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x65C0690", Offset = "0x65BFA90", VA = "0x1865C0690", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x65C0540", Offset = "0x65BF940", VA = "0x1865C0540")]
	[CompilerGenerated]
	private LOPKIINMLDJ DHLGOJPNIEG(int AMJKHBKANHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GIDPDJJGMLG(typeof(ALCDMIAMAMK), new string[] { })]
public class JJDAODCDPLI : ALCDMIAMAMK, ACLOEOFNKAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly ALCDMIAMAMK JCDKHFKJHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly ALCDMIAMAMK KLGLEPCGFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private BKLHCNIBAOL PKKABGFJAFG;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private ALCDMIAMAMK BJAGJLAOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x65BE410", Offset = "0x65BD810", VA = "0x1865BE410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x65BE2D0", Offset = "0x65BD6D0", VA = "0x1865BE2D0", Slot = "20")]
	public void InitReferences(NLGOFGOGHKI DPELPGGDADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x65BE470", Offset = "0x65BD870", VA = "0x1865BE470", Slot = "4")]
	public EFNEBKACGOG LGPPICLPGFI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x65BE0D0", Offset = "0x65BD4D0", VA = "0x1865BE0D0", Slot = "5")]
	public FFPDBHGELEL GKGMHALHEJB(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x65BDA60", Offset = "0x65BCE60", VA = "0x1865BDA60", Slot = "6")]
	public IOPPPMDNCCJ AABMGKGFDPG(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x65BE030", Offset = "0x65BD430", VA = "0x1865BE030", Slot = "7")]
	public GEMBEPEDECL GKFOKGIFBDO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x65BDBB0", Offset = "0x65BCFB0", VA = "0x1865BDBB0", Slot = "8")]
	public PKEMFEKJJOP ABLJCLFNCCO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x65BDDB0", Offset = "0x65BD1B0", VA = "0x1865BDDB0", Slot = "9")]
	public EIPMHAPKEIH CBNNJPMPLOJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x65BDF90", Offset = "0x65BD390", VA = "0x1865BDF90", Slot = "10")]
	public MOIAKGIAEBL GDBHLFCNHGJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x65BE510", Offset = "0x65BD910", VA = "0x1865BE510", Slot = "11")]
	public EOHJMBLPLJB OJOJLLCLOEI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x65BDE50", Offset = "0x65BD250", VA = "0x1865BDE50", Slot = "12")]
	public CJHGCJOMLPH COACLBDLNCH(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x65BDEF0", Offset = "0x65BD2F0", VA = "0x1865BDEF0", Slot = "13")]
	public AJGEPFOHMIH DKINKEHMDGP(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x65BE220", Offset = "0x65BD620", VA = "0x1865BE220")]
	public IONDHNBLODE MAHCMCFGIGN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x65BDC50", Offset = "0x65BD050", VA = "0x1865BDC50")]
	public HPNKGGILPOG ADCKALEENLD(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x65BDD00", Offset = "0x65BD100", VA = "0x1865BDD00")]
	public LEDJPGIEGJJ HPNLECEBPDF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65BDB00", Offset = "0x65BCF00", VA = "0x1865BDB00")]
	public IGEIHFPCEFN AAPCGOMJOMN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65BE170", Offset = "0x65BD570", VA = "0x1865BE170")]
	public NGCFDOFAHHF PPGCOOHJLEG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65BE320", Offset = "0x65BD720", VA = "0x1865BE320", Slot = "19")]
	public LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN, AAPGCFJECKF GPNCNDIBNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65BE5B0", Offset = "0x65BD9B0", VA = "0x1865BE5B0")]
	public JJDAODCDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x65BE220", Offset = "0x65BD620", VA = "0x1865BE220", Slot = "14")]
	private IONDHNBLODE HCGPEGKKPKG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x65BDC50", Offset = "0x65BD050", VA = "0x1865BDC50", Slot = "15")]
	private HPNKGGILPOG HBJBOANKHHE(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x65BDD00", Offset = "0x65BD100", VA = "0x1865BDD00", Slot = "16")]
	private LEDJPGIEGJJ BDMKMIJNOHJ(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65BDB00", Offset = "0x65BCF00", VA = "0x1865BDB00", Slot = "17")]
	private IGEIHFPCEFN HGAAIGKLPKF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65BE170", Offset = "0x65BD570", VA = "0x1865BE170", Slot = "18")]
	private NGCFDOFAHHF HAHIAJGOKNF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class BCPMLFDJPDA : LOPKIINMLDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BCPMLFDJPDA OKALMGBNAPE;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx MCOMEAOILPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject KEAFFOELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x806600", Offset = "0x805A00", VA = "0x180806600", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFA0", Offset = "0x7DA3A0", VA = "0x1807DAFA0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x180792F30", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x792F60", Offset = "0x792360", VA = "0x180792F60", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x792F40", Offset = "0x792340", VA = "0x180792F40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x792F80", Offset = "0x792380", VA = "0x180792F80", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9E5E40", Offset = "0x9E5240", VA = "0x1809E5E40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A09B0", Offset = "0x89FDB0", VA = "0x1808A09B0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B4A750", Offset = "0x1B49B50", VA = "0x181B4A750", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x391A430", Offset = "0x3919830", VA = "0x18391A430", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x47C7900", Offset = "0x47C6D00", VA = "0x1847C7900", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x47C58C0", Offset = "0x47C4CC0", VA = "0x1847C58C0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3744850", Offset = "0x3743C50", VA = "0x183744850", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x373E5A0", Offset = "0x373D9A0", VA = "0x18373E5A0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool DLPLMOEIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x92BE60", Offset = "0x92B260", VA = "0x18092BE60", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool GIBENAHIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x176A350", Offset = "0x1769750", VA = "0x18176A350", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5E42830", Offset = "0x5E41C30", VA = "0x185E42830", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3740920", Offset = "0x373FD20", VA = "0x183740920", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x957EA0", Offset = "0x9572A0", VA = "0x180957EA0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x65AD320", Offset = "0x65AC720", VA = "0x1865AD320", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A4EFE0", Offset = "0x1A4E3E0", VA = "0x181A4EFE0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AE0", Offset = "0x7DFEE0", VA = "0x1807E0AE0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float BBAKNJGMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AGDKBABNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "48")]
		get
		{
			return default(PLAOLPDBAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xCBAB90", Offset = "0xCB9F90", VA = "0x180CBAB90", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform JLIPENOJDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8F7A30", Offset = "0x8F6E30", VA = "0x1808F7A30", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 LMCJEHOICMG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float ILNIKCAKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float LHMKDCAJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7E18D0", Offset = "0x7E0CD0", VA = "0x1807E18D0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OENBJJAECOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x9883D0", Offset = "0x9877D0", VA = "0x1809883D0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9883D0", Offset = "0x9877D0", VA = "0x1809883D0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints NMBMDIIHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode CPKHADEDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool LGOPJDHBFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8CCFA0", Offset = "0x8CC3A0", VA = "0x1808CCFA0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event BNONKBGOOFP FPLNDDEPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event BNONKBGOOFP MHKPHJBAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event EBOGPGNBJGH OPJJCKGCGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event BNONKBGOOFP NGGELNMLDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event BNONKBGOOFP NGFHFKKGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event BNONKBGOOFP CJJNJGMEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event BNONKBGOOFP EBJAHHAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event BNONKBGOOFP MPBNJDPNHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "41")]
	public void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "71")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "72")]
	public void CJCHOHIMKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "73")]
	public void OBEEFAIJBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "74")]
	public void KGGOHHLELDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "81")]
	public void DFODMMMMNPP(LOPKIINMLDJ PAHKKNONPEO, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "84")]
	public void CLHBPCELMIN(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "85")]
	public void KPODAPFFCBF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "86")]
	public Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "87")]
	public Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "88")]
	public void JCNNNDOJMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "89")]
	public void MENPCBEEFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "90")]
	public void EIFIFEIMIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "91")]
	public void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "92")]
	public void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "93")]
	public void HEIDFNDADGL(Vector3 IDAHODGNCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "94")]
	public void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "95")]
	public void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "96")]
	public void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "97")]
	public Vector3 IIANNBIMKCJ(Vector3 PAHKKNONPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xB1E2F0", Offset = "0xB1D6F0", VA = "0x180B1E2F0", Slot = "98")]
	public Vector3 KJHLJJGAFCA(Vector3 PAHKKNONPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "99")]
	public void PEMBIILOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "100")]
	public void FAHOILKMAOF(LOPKIINMLDJ HDIFEJDMLPC, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "101")]
	public void GCDMGJHBNEJ(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "104")]
	public void PPMKLCHMMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "105")]
	public void FIIDMNEAIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "106")]
	public void BHKBAAKFHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "109")]
	public bool LJCOGDJCLOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "110")]
	public void JAPGJOMEKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "115")]
	public IDisposable OGOKFHMDAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "116")]
	public void EAFLCLEHBGM(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "117")]
	public void IMHKAJLMECI(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "118")]
	public void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "121")]
	public void KIHNEKGIMLI(Vector3 PBNJKFLAPAK, Quaternion KHBBHAJCCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "122")]
	public void CDNJMCGGLMF(Vector3 JGJHMIAHIAD, Quaternion NFFONAKHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "123")]
	public bool BFJMFNANIKN(float GLJGILHBCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "124")]
	public void AGCBCLMLEBG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "125")]
	public void OHGHANHOFHH(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "126")]
	public void NKKMMACOGPC(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "127")]
	public void FLFGGGFBBEG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "128")]
	public void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "129")]
	public void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "130")]
	public void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "131")]
	public void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x65AD300", Offset = "0x65AC700", VA = "0x1865AD300", Slot = "132")]
	public bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "133")]
	public void IIGAPFPPEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public BCPMLFDJPDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class CBEOABNIIDM : LEFAGGGMDHK, BNGOJKAKFNA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal PIKFEMDGCNE HICOIGNOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal KGBGGKOMJHD EGDFOJMBGLP;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x65AEAC0", Offset = "0x65ADEC0", VA = "0x1865AEAC0")]
	public CBEOABNIIDM(GameObject IFGJJHCIEPA, RigidbodyEx ALCCAMFCBLN, AAPGCFJECKF GPNCNDIBNOH, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x65AE790", Offset = "0x65ADB90", VA = "0x1865AE790", Slot = "135")]
	protected override void JFGHLHDLJFL(AAPGCFJECKF GPNCNDIBNOH, CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "141")]
	protected override IDisposable OANJHIFDMFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x65AE1A0", Offset = "0x65AD5A0", VA = "0x1865AE1A0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x65AE0D0", Offset = "0x65AD4D0", VA = "0x1865AE0D0", Slot = "142")]
	public void BIOMLEMGMML(HGBHPKGMBNJ JBDKOGGCLOE, HGBHPKGMBNJ MCNFPBNKOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x65AE010", Offset = "0x65AD410", VA = "0x1865AE010", Slot = "143")]
	public void AICNDOAKJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65AE4A0", Offset = "0x65AD8A0", VA = "0x1865AE4A0", Slot = "144")]
	public void HILOHFHPDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65AEA00", Offset = "0x65ADE00", VA = "0x1865AEA00", Slot = "145")]
	public void MMAAJAMFNHI(bool PJKPPHMJKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x65AE310", Offset = "0x65AD710", VA = "0x1865AE310", Slot = "146")]
	public bool FEDLGLDNBIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x65AEA60", Offset = "0x65ADE60", VA = "0x1865AEA60", Slot = "147")]
	public void OCJHJAIDPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "140")]
	protected override void OBOOJAKNIND(RigidbodyEx IBGLEOLMNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x65AE560", Offset = "0x65AD960", VA = "0x1865AE560")]
	private void JDACPICLAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class MCGOFKMPNCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x65CBE40", Offset = "0x65CB240", VA = "0x1865CBE40")]
	public static LEFAGGGMDHK HPHEHBEGIJJ(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GIECMDINJJO : EFNEBKACGOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOIHJCNCDNK(LOPKIINMLDJ CIJDIMEFBGG);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMLLAAPNOHK(LOPKIINMLDJ CIJDIMEFBGG);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIHABECHJDN(LOPKIINMLDJ GOPMDACFDHN);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCDLDEKCADP(LOPKIINMLDJ GOPMDACFDHN);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DBJMKNLPMAH : IOPPPMDNCCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	MHNCAMLBMKD<LOPKIINMLDJ> EJHAAMNFJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	LOPKIINMLDJ NPGJDIEKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GIJNJNMHPJL : IGEIHFPCEFN
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HCBLPJLOMFF(Rigidbody FDIIDHJAFPH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NNPBBKLGOPG : HPNKGGILPOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView FIDCLOIBGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class ODLJFMIOAEC : CJHGCJOMLPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode HNCEGKMGOEK;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode CPKHADEDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x65CE350", Offset = "0x65CD750", VA = "0x1865CE350", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x65CE5F0", Offset = "0x65CD9F0", VA = "0x1865CE5F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x65B15C0", Offset = "0x65B09C0", VA = "0x1865B15C0")]
	public ODLJFMIOAEC(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x65CE460", Offset = "0x65CD860", VA = "0x1865CE460", Slot = "6")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x65CE570", Offset = "0x65CD970", VA = "0x1865CE570", Slot = "9")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x65CE220", Offset = "0x65CD620", VA = "0x1865CE220", Slot = "7")]
	public void GKOLHJMMOFE(bool MGICFOILBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x65CE210", Offset = "0x65CD610", VA = "0x1865CE210", Slot = "8")]
	public void EIACHLIPLGF(bool MGICFOILBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x65CE0B0", Offset = "0x65CD4B0", VA = "0x1865CE0B0", Slot = "10")]
	public bool EHAEIHLLAJF(Vector3 PLJNLCOFMBP, [Out] RaycastHit MELAAABPHLO, float IPFKFHJNJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x65CE230", Offset = "0x65CD630", VA = "0x1865CE230")]
	private void HAPALJKMNPP(bool MGICFOILBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class PJHAODHJBFP : EIPMHAPKEIH, IDisposable, FIEBEGLBPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private PLAOLPDBAPK ILCLODPEPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private OLHCGEIINID PKMBOGLOOMN;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PLAOLPDBAPK JLEJBEOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x65CFCC0", Offset = "0x65CF0C0", VA = "0x1865CFCC0", Slot = "6")]
		get
		{
			return default(PLAOLPDBAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x65CFE10", Offset = "0x65CF210", VA = "0x1865CFE10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform GFDIADPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x65D0290", Offset = "0x65CF690", VA = "0x1865D0290", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<ELKPCEJHCMJ, ELKPCEJHCMJ> FMBKIMCEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x65CFEE0", Offset = "0x65CF2E0", VA = "0x1865CFEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x65CFBC0", Offset = "0x65CEFC0", VA = "0x1865CFBC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x65D02B0", Offset = "0x65CF6B0", VA = "0x1865D02B0")]
	public PJHAODHJBFP(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x65CFF90", Offset = "0x65CF390", VA = "0x1865CFF90", Slot = "8")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x65CFC70", Offset = "0x65CF070", VA = "0x1865CFC70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEDF0", Offset = "0x1BAE1F0", VA = "0x181BAEDF0", Slot = "11")]
	private void HHCFAJAOGJB(ELKPCEJHCMJ GHNMBFBCDGF, ELKPCEJHCMJ JNBGDEOKOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "12")]
	private void IODJEGPKLJJ(bool DJGHECGIPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DNIJAOOKCAF : EOHJMBLPLJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x65ACC20", Offset = "0x65AC020", VA = "0x1865ACC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x65AC450", Offset = "0x65AB850", VA = "0x1865AC450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x65AC170", Offset = "0x65AB570", VA = "0x1865AC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x65B1560", Offset = "0x65B0960", VA = "0x1865B1560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x65B15C0", Offset = "0x65B09C0", VA = "0x1865B15C0")]
	public DNIJAOOKCAF(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x65B12A0", Offset = "0x65B06A0", VA = "0x1865B12A0", Slot = "4")]
	public void MDEBFIJIPCG(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x65B0900", Offset = "0x65AFD00", VA = "0x1865B0900")]
	private void BGCIPNBBJNI(Vector3 LHIOHICKLJF, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x65B0B60", Offset = "0x65AFF60", VA = "0x1865B0B60", Slot = "5")]
	public void FIACOPDKDEC(Vector3 LHIOHICKLJF, Vector3 BCGGHPIMKDA, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x65B1400", Offset = "0x65B0800", VA = "0x1865B1400", Slot = "6")]
	public void MIALGBGDEKH(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x65B1040", Offset = "0x65B0440", VA = "0x1865B1040")]
	private void JCEMLGAFONM(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x65B0DE0", Offset = "0x65B01E0", VA = "0x1865B0DE0", Slot = "7")]
	public void JCBHEHCADJG(Vector3 FFGKLCBCNFK, ForceMode EFDGNPNJKIJ = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class HDBADLILOND : AJGEPFOHMIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool CJDANJDABGO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool AGDKBABNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x817E60", Offset = "0x817260", VA = "0x180817E60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x65B7360", Offset = "0x65B6760", VA = "0x1865B7360", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65B15C0", Offset = "0x65B09C0", VA = "0x1865B15C0")]
	public HDBADLILOND(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x65B7470", Offset = "0x65B6870", VA = "0x1865B7470", Slot = "6")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65AF940", Offset = "0x65AED40", VA = "0x1865AF940", Slot = "7")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class KAMAFMPGJLI : GIECMDINJJO, EFNEBKACGOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LOPKIINMLDJ CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<LOPKIINMLDJ> KHBDODKFPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private LOPKIINMLDJ MMKDJDGOBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LOPKIINMLDJ AOGBEAODJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform DBFPPMOEIEC;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x65C0190", Offset = "0x65BF590", VA = "0x1865C0190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x793FA0", Offset = "0x7933A0", VA = "0x180793FA0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x65BFFF0", Offset = "0x65BF3F0", VA = "0x1865BFFF0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public LOPKIINMLDJ KCJODJNNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x792F70", Offset = "0x792370", VA = "0x180792F70", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<LOPKIINMLDJ> BCIBLCGFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x792F20", Offset = "0x792320", VA = "0x180792F20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event BNONKBGOOFP FPLNDDEPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x65C0340", Offset = "0x65BF740", VA = "0x1865C0340", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x65BEBA0", Offset = "0x65BDFA0", VA = "0x1865BEBA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event BNONKBGOOFP MHKPHJBAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x65C03E0", Offset = "0x65BF7E0", VA = "0x1865C03E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x65BE700", Offset = "0x65BDB00", VA = "0x1865BE700", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event EBOGPGNBJGH OPJJCKGCGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x65BF970", Offset = "0x65BED70", VA = "0x1865BF970", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x65C02A0", Offset = "0x65BF6A0", VA = "0x1865C02A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action IMIIKPKGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x65BFCE0", Offset = "0x65BF0E0", VA = "0x1865BFCE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x65BE660", Offset = "0x65BDA60", VA = "0x1865BE660", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action JGKDLBAFMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x65BEB00", Offset = "0x65BDF00", VA = "0x1865BEB00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x65BFB00", Offset = "0x65BEF00", VA = "0x1865BFB00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<LOPKIINMLDJ> CEDPFPDCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x65C01F0", Offset = "0x65BF5F0", VA = "0x1865C01F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x65BEC40", Offset = "0x65BE040", VA = "0x1865BEC40", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<LOPKIINMLDJ> MNJAOHIPOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x65BF320", Offset = "0x65BE720", VA = "0x1865BF320", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x65BF3D0", Offset = "0x65BE7D0", VA = "0x1865BF3D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action AJCGMHHIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x65BF8D0", Offset = "0x65BECD0", VA = "0x1865BF8D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x65BE7A0", Offset = "0x65BDBA0", VA = "0x1865BE7A0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<LOPKIINMLDJ> CIMCPDBOPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x65BF780", Offset = "0x65BEB80", VA = "0x1865BF780", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x65BF270", Offset = "0x65BE670", VA = "0x1865BF270", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65C0480", Offset = "0x65BF880", VA = "0x1865C0480")]
	public KAMAFMPGJLI(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x65BF480", Offset = "0x65BE880", VA = "0x1865BF480", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x65BECF0", Offset = "0x65BE0F0", VA = "0x1865BECF0", Slot = "30")]
	public void DFODMMMMNPP(LOPKIINMLDJ JOPIDNPFKKJ, bool NHJCDDNIKDO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x65BFD80", Offset = "0x65BF180", VA = "0x1865BFD80", Slot = "6")]
	public void LIHABECHJDN(LOPKIINMLDJ GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x65BE840", Offset = "0x65BDC40", VA = "0x1865BE840", Slot = "7")]
	public void BCDLDEKCADP(LOPKIINMLDJ GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65BFA10", Offset = "0x65BEE10", VA = "0x1865BFA10", Slot = "4")]
	public void HOIHJCNCDNK(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65BF830", Offset = "0x65BEC30", VA = "0x1865BF830", Slot = "5")]
	public void FMLLAAPNOHK(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x65C0000", Offset = "0x65BF400", VA = "0x1865C0000")]
	private void LNJIDHDBOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x65BEAC0", Offset = "0x65BDEC0", VA = "0x1865BEAC0")]
	private void BDGOCGBHOIH(LOPKIINMLDJ GOPMDACFDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65BFBA0", Offset = "0x65BEFA0", VA = "0x1865BFBA0")]
	private void JKGEPCAHBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x65BF650", Offset = "0x65BEA50", VA = "0x1865BF650")]
	private void FKKFDHCDANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x65BF520", Offset = "0x65BE920", VA = "0x1865BF520")]
	private void EKEDPHJOMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x65C00A0", Offset = "0x65BF4A0", VA = "0x1865C00A0")]
	[CompilerGenerated]
	private object LOMGHMAAMGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class EGAHNMMEDHA
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65B1810", Offset = "0x65B0C10", VA = "0x1865B1810")]
	public static GIECMDINJJO JOHGFLKEABF(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class PHDOLBFHAEC : DBJMKNLPMAH, IOPPPMDNCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MHNCAMLBMKD<LOPKIINMLDJ> DKBLLIAJBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool NLOMNFIMLCA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public MHNCAMLBMKD<LOPKIINMLDJ> EJHAAMNFJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 IGIKKMFAGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x65CF710", Offset = "0x65CEB10", VA = "0x1865CF710", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 JLBFNIOFLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x65CF900", Offset = "0x65CED00", VA = "0x1865CF900", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x65CF810", Offset = "0x65CEC10", VA = "0x1865CF810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public LOPKIINMLDJ NPGJDIEKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x65CEF40", Offset = "0x65CE340", VA = "0x1865CEF40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x65CFAC0", Offset = "0x65CEEC0", VA = "0x1865CFAC0")]
	public PHDOLBFHAEC(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65CF7A0", Offset = "0x65CEBA0", VA = "0x1865CF7A0", Slot = "8")]
	public void KKGGBGKAKAG(LOPKIINMLDJ AOGBEAODJPP, object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x65CF740", Offset = "0x65CEB40", VA = "0x1865CF740", Slot = "9")]
	public void IKPHOLMONCD(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x65CF380", Offset = "0x65CE780", VA = "0x1865CF380")]
	private Vector3 FIEEFCAHMCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x65CEFF0", Offset = "0x65CE3F0", VA = "0x1865CEFF0")]
	private void EJAJIJGDHPE(LOPKIINMLDJ KILOJPMKBGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class EBNKDPEDHON
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x65B1650", Offset = "0x65B0A50", VA = "0x1865B1650")]
	public static DBJMKNLPMAH EKEGEGMBIAH(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class IEBEJAODLMO : GIJNJNMHPJL, IGEIHFPCEFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 ODGCLHEKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 BDBCDGNNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float HNMBCLBOOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float BCBFAGMOJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 PKKPIIECEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? OCCHNJMAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? GLFOOMAEKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool MLEJHLMEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool BLAKLJBFKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 DJOGHKAMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x107A650", Offset = "0x1079A50", VA = "0x18107A650", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x65B9280", Offset = "0x65B8680", VA = "0x1865B9280", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 APLIDPLNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x65BB3F0", Offset = "0x65BA7F0", VA = "0x1865BB3F0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float ENAGFMGKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1177130", Offset = "0x1176530", VA = "0x181177130", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x65BACA0", Offset = "0x65BA0A0", VA = "0x1865BACA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float CIHGGLEAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xBA7B10", Offset = "0xBA6F10", VA = "0x180BA7B10", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x65B9330", Offset = "0x65B8730", VA = "0x1865B9330", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 CJNDHNGFFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x65B9650", Offset = "0x65B8A50", VA = "0x1865B9650", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion CPLPGAFFHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x65BB4F0", Offset = "0x65BA8F0", VA = "0x1865BB4F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x65AF3E0", Offset = "0x65AE7E0", VA = "0x1865AF3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event BNONKBGOOFP FEJBOENEGID
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x65BB040", Offset = "0x65BA440", VA = "0x1865BB040", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x65B93E0", Offset = "0x65B87E0", VA = "0x1865B93E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x65BB820", Offset = "0x65BAC20", VA = "0x1865BB820")]
	public IEBEJAODLMO(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x65BB670", Offset = "0x65BAA70", VA = "0x1865BB670", Slot = "17")]
	public void PPMKLCHMMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x65B9480", Offset = "0x65B8880", VA = "0x1865B9480", Slot = "16")]
	public void FIIDMNEAIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x65BB0E0", Offset = "0x65BA4E0", VA = "0x1865BB0E0", Slot = "19")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x65BADB0", Offset = "0x65BA1B0", VA = "0x1865BADB0", Slot = "20")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x65B9110", Offset = "0x65B8510", VA = "0x1865B9110", Slot = "18")]
	public void BHKBAAKFHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x65BA800", Offset = "0x65B9C00", VA = "0x1865BA800", Slot = "21")]
	public void IIGAPFPPEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x65B9280", Offset = "0x65B8680", VA = "0x1865B9280")]
	private void HDAGPKAFOHB(Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x65B9560", Offset = "0x65B8960", VA = "0x1865B9560")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 FILNPBDCKED()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x65BACA0", Offset = "0x65BA0A0", VA = "0x1865BACA0")]
	private void MPKMIHHLAEP(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x65B9330", Offset = "0x65B8730", VA = "0x1865B9330")]
	private void CIJKONBKKEM(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x65B8DF0", Offset = "0x65B81F0", VA = "0x1865B8DF0")]
	private Vector3 ABELCLBLDJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x65BB1C0", Offset = "0x65BA5C0", VA = "0x1865BB1C0", Slot = "15")]
	public void OIONJEIKNDN((Quaternion rot, Vector3 moments) CMOAOKDCAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x65B8F90", Offset = "0x65B8390", VA = "0x1865B8F90")]
	private Quaternion BAAHGEAFAHI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x65B97E0", Offset = "0x65B8BE0", VA = "0x1865B97E0")]
	public void HCBLPJLOMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x65B98B0", Offset = "0x65B8CB0", VA = "0x1865B98B0", Slot = "4")]
	public (float, Vector3) HCBLPJLOMFF(Rigidbody FDIIDHJAFPH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class IDADNCKMADA
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x65B8D30", Offset = "0x65B8130", VA = "0x1865B8D30")]
	public static GIJNJNMHPJL KHNFPFOGFDE(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class MNJHIBKEPDP : LEDJPGIEGJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GDJEDKCANMC PAEHBLEIKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MDABCJFKJMP MAEMLLLMPFG;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool EIJNAELFFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F10", Offset = "0xCD5310", VA = "0x180CD5F10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public MDABCJFKJMP KJAMDHPFLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130", Slot = "11")]
		get
		{
			return default(MDABCJFKJMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x65CC4B0", Offset = "0x65CB8B0", VA = "0x1865CC4B0")]
	public MNJHIBKEPDP(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x65CC3A0", Offset = "0x65CB7A0", VA = "0x1865CC3A0", Slot = "4")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x65CC2D0", Offset = "0x65CB6D0", VA = "0x1865CC2D0")]
	private bool HIFCEPJJCNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x65CC370", Offset = "0x65CB770", VA = "0x1865CC370", Slot = "5")]
	public void KFLHBDIDEHD(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x65CC2A0", Offset = "0x65CB6A0", VA = "0x1865CC2A0", Slot = "6")]
	public void GLBJGGCGKGF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x65CC000", Offset = "0x65CB400", VA = "0x1865CC000", Slot = "9")]
	public void CJJFAPEHMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x65CC140", Offset = "0x65CB540", VA = "0x1865CC140")]
	private void CKKOEODKACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x65CBE90", Offset = "0x65CB290", VA = "0x1865CBE90")]
	private void AAJDCCNBPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x65CC470", Offset = "0x65CB870", VA = "0x1865CC470", Slot = "8")]
	public void NFJGPCPLGEL(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x65CC260", Offset = "0x65CB660", VA = "0x1865CC260", Slot = "7")]
	public void EADMBNPPCCK(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class ICEFOLGJAEE : MOIAKGIAEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GDJEDKCANMC BHCIJLJCLON;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool NLJLIAGNBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x65B8910", Offset = "0x65B7D10", VA = "0x1865B8910", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event BNONKBGOOFP EBJAHHAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x65B8870", Offset = "0x65B7C70", VA = "0x1865B8870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x65B87D0", Offset = "0x65B7BD0", VA = "0x1865B87D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x65B8C40", Offset = "0x65B8040", VA = "0x1865B8C40")]
	public ICEFOLGJAEE(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x65B8AC0", Offset = "0x65B7EC0", VA = "0x1865B8AC0", Slot = "11")]
	public IDisposable OGOKFHMDAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x65B87C0", Offset = "0x65B7BC0", VA = "0x1865B87C0", Slot = "8")]
	public void EAFLCLEHBGM(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x65B89C0", Offset = "0x65B7DC0", VA = "0x1865B89C0", Slot = "9")]
	public void IMHKAJLMECI(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x65B8B30", Offset = "0x65B7F30", VA = "0x1865B8B30", Slot = "10")]
	public void PJDPDLGCMDF(object KNOHBODGPLL, bool OFNKHCCEJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x65B89D0", Offset = "0x65B7DD0", VA = "0x1865B89D0", Slot = "6")]
	public void JOMFFFCKIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x65B8A40", Offset = "0x65B7E40", VA = "0x1865B8A40", Slot = "12")]
	public void OGAKKONLIDI(Rigidbody PKDFFNNLBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x65B8A10", Offset = "0x65B7E10", VA = "0x1865B8A10", Slot = "13")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class PLCGCIEBIJJ : NNPBBKLGOPG, HPNKGGILPOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView NIMPPBCFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool NBGMHFONGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView FIDCLOIBGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool CDDCPMKNANH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x65B0130", Offset = "0x65AF530", VA = "0x1865B0130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool ILLHEINJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x87FB90", Offset = "0x87EF90", VA = "0x18087FB90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event BNONKBGOOFP NGGELNMLDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x65D0A20", Offset = "0x65CFE20", VA = "0x1865D0A20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x65D0980", Offset = "0x65CFD80", VA = "0x1865D0980", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x65D0ED0", Offset = "0x65D02D0", VA = "0x1865D0ED0")]
	public PLCGCIEBIJJ(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x65D0C30", Offset = "0x65D0030", VA = "0x1865D0C30", Slot = "9")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x65D0610", Offset = "0x65CFA10", VA = "0x1865D0610", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x65D0AC0", Offset = "0x65CFEC0", VA = "0x1865D0AC0", Slot = "10")]
	public void KIFEENKGECL(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x65D0D60", Offset = "0x65D0160", VA = "0x1865D0D60", Slot = "11")]
	public void OHIPAPIFHMM(LOPKIINMLDJ AOGBEAODJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x65D04A0", Offset = "0x65CF8A0", VA = "0x1865D04A0")]
	private void CLAGBEGBHKA(PhotonView PKIEIKAKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x65D0340", Offset = "0x65CF740", VA = "0x1865D0340")]
	private void BHCBHCJCDND(RigidbodyEx AEPAEDNHHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x65D0710", Offset = "0x65CFB10", VA = "0x1865D0710")]
	private void ENGNBHMFJJL(PhotonView AHPNPDPNHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class BJBHOJMBAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x65ADF50", Offset = "0x65AD350", VA = "0x1865ADF50")]
	public static NNPBBKLGOPG IHHDPFAGNIE(this LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class FNMANJGOFAI : NGCFDOFAHHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints FMFBOFLOPDE;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool FJIEFFAHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAF7750", Offset = "0xAF6B50", VA = "0x180AF7750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3E5EC40", Offset = "0x3E5E040", VA = "0x183E5EC40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool AODJAILCEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1B06AA0", Offset = "0x1B05EA0", VA = "0x181B06AA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3E5EC30", Offset = "0x3E5E030", VA = "0x183E5EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints NMBMDIIHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x65B54D0", Offset = "0x65B48D0", VA = "0x1865B54D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x65B5660", Offset = "0x65B4A60", VA = "0x1865B5660")]
	public FNMANJGOFAI(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x65B5630", Offset = "0x65B4A30", VA = "0x1865B5630", Slot = "9")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x65B5600", Offset = "0x65B4A00", VA = "0x1865B5600", Slot = "10")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class GOPCJHAKGMA : GEMBEPEDECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly LOPKIINMLDJ CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float MFBBEFCCLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float CGFEPGJDOEN;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float JEEOPKIGJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x65B7090", Offset = "0x65B6490", VA = "0x1865B7090", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float BBAKNJGMPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x968470", Offset = "0x967870", VA = "0x180968470", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x65B7250", Offset = "0x65B6650", VA = "0x1865B7250", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x65B7320", Offset = "0x65B6720", VA = "0x1865B7320")]
	public GOPCJHAKGMA(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x65B7200", Offset = "0x65B6600", VA = "0x1865B7200", Slot = "8")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x65B7160", Offset = "0x65B6560", VA = "0x1865B7160", Slot = "9")]
	public void LJBDHPANHPO(Rigidbody OKBDFKDKNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class CHGMEBKHDKP : PKEMFEKJJOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool DMCPCDAJGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool OJOJLADAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int FICAPJCBEPB;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x65AF3E0", Offset = "0x65AE7E0", VA = "0x1865AF3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool EJBIAAMLPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x65AF040", Offset = "0x65AE440", VA = "0x1865AF040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private LOPKIINMLDJ PDLABICHIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x65AF4C0", Offset = "0x65AE8C0", VA = "0x1865AF4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x65AEFE0", Offset = "0x65AE3E0", VA = "0x1865AEFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event BNONKBGOOFP CJJNJGMEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x65AEF40", Offset = "0x65AE340", VA = "0x1865AEF40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x65AF100", Offset = "0x65AE500", VA = "0x1865AF100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x65AF700", Offset = "0x65AEB00", VA = "0x1865AF700")]
	public CHGMEBKHDKP(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x65AF430", Offset = "0x65AE830", VA = "0x1865AF430", Slot = "6")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x65AEF30", Offset = "0x65AE330", VA = "0x1865AEF30", Slot = "8")]
	public void CFNIEDCOBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x65AF240", Offset = "0x65AE640", VA = "0x1865AF240", Slot = "7")]
	public bool LJCOGDJCLOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x65AF1A0", Offset = "0x65AE5A0", VA = "0x1865AF1A0", Slot = "9")]
	public void KGGOHHLELDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x65AF060", Offset = "0x65AE460", VA = "0x1865AF060", Slot = "11")]
	public void JAPGJOMEKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x65AF390", Offset = "0x65AE790", VA = "0x1865AF390", Slot = "12")]
	public void MMAAJAMFNHI(bool PJKPPHMJKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x65AEBF0", Offset = "0x65ADFF0", VA = "0x1865AEBF0", Slot = "10")]
	public void AJLIPNLFPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x65AF520", Offset = "0x65AE920", VA = "0x1865AF520")]
	private bool PCBODOBJILN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x65AEDA0", Offset = "0x65AE1A0", VA = "0x1865AEDA0")]
	private void CENDBJAKFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class LEJILPHMKCC : IONDHNBLODE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly GDJEDKCANMC NBABGJOMHFB;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody LJOBBGCHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x792A40", Offset = "0x791E40", VA = "0x180792A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool HIIJHPBFFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x65AC170", Offset = "0x65AB570", VA = "0x1865AC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool JKJELODCLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F10", Offset = "0xCD5310", VA = "0x180CD5F10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x65CBAB0", Offset = "0x65CAEB0", VA = "0x1865CBAB0")]
	public LEJILPHMKCC(LOPKIINMLDJ CIJDIMEFBGG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x65CB9E0", Offset = "0x65CADE0", VA = "0x1865CB9E0", Slot = "5")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65CBA80", Offset = "0x65CAE80", VA = "0x1865CBA80", Slot = "7")]
	public void NKKMMACOGPC(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x65CAEC0", Offset = "0x65CA2C0", VA = "0x1865CAEC0", Slot = "8")]
	public void FLFGGGFBBEG(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x65CB380", Offset = "0x65CA780", VA = "0x1865CB380", Slot = "9")]
	public void IGGLJJJLAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x65CAB20", Offset = "0x65C9F20", VA = "0x1865CAB20", Slot = "11")]
	public void BNHDLCGOCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x65CB6B0", Offset = "0x65CAAB0", VA = "0x1865CB6B0", Slot = "12")]
	public void KIKKJGHPLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x65CAEF0", Offset = "0x65CA2F0", VA = "0x1865CAEF0", Slot = "10")]
	public void HHFJFBKKBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x65CAD10", Offset = "0x65CA110", VA = "0x1865CAD10")]
	private void CDLCDPGGPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x65CB830", Offset = "0x65CAC30", VA = "0x1865CB830")]
	private void MLLBCNMANOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class ACMGCJIELFI : FFPDBHGELEL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly LEFAGGGMDHK CIJDIMEFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GDJEDKCANMC OBAMLCDCEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float DKOFALKOKMF;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MHLEIDBKLPP HJJPMBEOMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x796870", Offset = "0x795C70", VA = "0x180796870", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public ELDLGDHFDKA IJDPBHLFNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 EJJNGGMHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x65D85D0", Offset = "0x65D79D0", VA = "0x1865D85D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x65D8C60", Offset = "0x65D8060", VA = "0x1865D8C60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 JIMOPNNOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x65D7590", Offset = "0x65D6990", VA = "0x1865D7590", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x65D76E0", Offset = "0x65D6AE0", VA = "0x1865D76E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 ECOCDMJNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x65D9430", Offset = "0x65D8830", VA = "0x1865D9430", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x65D7930", Offset = "0x65D6D30", VA = "0x1865D7930", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 CPBABAIBGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x65D79F0", Offset = "0x65D6DF0", VA = "0x1865D79F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x65D91C0", Offset = "0x65D85C0", VA = "0x1865D91C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float IBDADGNBJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7E4340", Offset = "0x7E3740", VA = "0x1807E4340", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x65D6E30", Offset = "0x65D6230", VA = "0x1865D6E30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool AEPDALGMEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x166EF40", Offset = "0x166E340", VA = "0x18166EF40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EOHJMBLPLJB DMAMGPJADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E610", Offset = "0x1E6DA10", VA = "0x181E6E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool EJBIAAMLPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x65B3BA0", Offset = "0x65B2FA0", VA = "0x1865B3BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x65D9680", Offset = "0x65D8A80", VA = "0x1865D9680")]
	public ACMGCJIELFI(LOPKIINMLDJ CIJDIMEFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x65D7FE0", Offset = "0x65D73E0", VA = "0x1865D7FE0", Slot = "19")]
	public void NCPCDPHDHKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x65D74C0", Offset = "0x65D68C0", VA = "0x1865D74C0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x65D9360", Offset = "0x65D8760", VA = "0x1865D9360", Slot = "28")]
	public void OGAKKONLIDI(Rigidbody OKBDFKDKNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xB13820", Offset = "0xB12C20", VA = "0x180B13820", Slot = "20")]
	public void DOEABMEIHOL(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xB12560", Offset = "0xB11960", VA = "0x180B12560", Slot = "30")]
	public void GIGJNPIMOEF(object KNOHBODGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x65D6CC0", Offset = "0x65D60C0", VA = "0x1865D6CC0", Slot = "35")]
	public Vector3 BIBLMEGEIHJ(Vector3 HMGOGHFNDEP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x65D6F40", Offset = "0x65D6340", VA = "0x1865D6F40", Slot = "34")]
	public Vector3 DDBONMHBCKL(Vector3 ACBJEELMNFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x65D7FE0", Offset = "0x65D73E0", VA = "0x1865D7FE0", Slot = "27")]
	public void JCNNNDOJMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x65D8D20", Offset = "0x65D8120", VA = "0x1865D8D20", Slot = "25")]
	public void MENPCBEEFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x65D7680", Offset = "0x65D6A80", VA = "0x1865D7680", Slot = "24")]
	public void EIFIFEIMIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x65D7320", Offset = "0x65D6720", VA = "0x1865D7320", Slot = "33")]
	public void DMHCPHDANEJ(Vector3 JLKAEJIEJPJ, Vector3 DIJDKIKCMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x65D6EE0", Offset = "0x65D62E0", VA = "0x1865D6EE0", Slot = "32")]
	public void COHFHPCOAIG(Vector3 NEHBCFALGIK, Vector3 NMJFDBALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x65D77C0", Offset = "0x65D6BC0", VA = "0x1865D77C0", Slot = "31")]
	public void HEIDFNDADGL(Vector3 IDAHODGNCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x65D6690", Offset = "0x65D5A90", VA = "0x1865D6690", Slot = "22")]
	public void BBMKGKDOGLD(GEKKGNEDBCC NPFBFCOAOLJ, Vector3 BBOFJHHOMBL, float OGICAOHPBDO, float IABIOGLAEIN = 8f, float JFPAEGHFPCH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x65D7090", Offset = "0x65D6490", VA = "0x1865D7090", Slot = "21")]
	public void DFPBGEECGDD(KKBBLLCAHKH FDGAHPEHFEO, Vector3 DLOEOMMLHFD, float KDMKEEINHOJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x65D7AE0", Offset = "0x65D6EE0", VA = "0x1865D7AE0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLMCIEPODFP(KKBBLLCAHKH FDGAHPEHFEO, Vector3 GIJALKLADPN, float MOBFNDDCMNJ = 7f, float NNDMACLLPBG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x65D7E80", Offset = "0x65D7280", VA = "0x1865D7E80", Slot = "29")]
	public Vector3 IIANNBIMKCJ(Vector3 MADKEMKIPKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x65D9550", Offset = "0x65D8950", VA = "0x1865D9550", Slot = "26")]
	public void PEMBIILOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x65D6E30", Offset = "0x65D6230", VA = "0x1865D6E30")]
	private void IMKNDKIDFHL(float PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x65D91F0", Offset = "0x65D85F0", VA = "0x1865D91F0")]
	private void OALNFOBACAF(Vector3 DLOEOMMLHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x65D84F0", Offset = "0x65D78F0", VA = "0x1865D84F0")]
	private Vector3 KLDBIABHLFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x65D8090", Offset = "0x65D7490", VA = "0x1865D8090")]
	private void KINGJPBCPIB(Vector3 ACBJEELMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x65D8B80", Offset = "0x65D7F80", VA = "0x1865D8B80")]
	private Vector3 MCJKJKAEMBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x65D8D80", Offset = "0x65D8180", VA = "0x1865D8D80")]
	private void NBCNBEAPOHJ(Vector3 PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x65D86F0", Offset = "0x65D7AF0", VA = "0x1865D86F0")]
	private void MBANAPKNDCI(Vector3 ACBJEELMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x65D7710", Offset = "0x65D6B10", VA = "0x1865D7710")]
	private void HCHADLMPDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PALENJJKBBC : ALCDMIAMAMK
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x65D9D80", Offset = "0x65D9180", VA = "0x1865D9D80", Slot = "4")]
	public EFNEBKACGOG LGPPICLPGFI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x65D9B10", Offset = "0x65D8F10", VA = "0x1865D9B10", Slot = "5")]
	public FFPDBHGELEL GKGMHALHEJB(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x65D9720", Offset = "0x65D8B20", VA = "0x1865D9720", Slot = "6")]
	public IOPPPMDNCCJ AABMGKGFDPG(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x65D9AB0", Offset = "0x65D8EB0", VA = "0x1865D9AB0", Slot = "7")]
	public GEMBEPEDECL GKFOKGIFBDO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x65D97F0", Offset = "0x65D8BF0", VA = "0x1865D97F0", Slot = "8")]
	public PKEMFEKJJOP ABLJCLFNCCO(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x65D9930", Offset = "0x65D8D30", VA = "0x1865D9930", Slot = "9")]
	public EIPMHAPKEIH CBNNJPMPLOJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x65D9A50", Offset = "0x65D8E50", VA = "0x1865D9A50", Slot = "10")]
	public MOIAKGIAEBL GDBHLFCNHGJ(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x65D9DE0", Offset = "0x65D91E0", VA = "0x1865D9DE0", Slot = "11")]
	public EOHJMBLPLJB OJOJLLCLOEI(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x65D9990", Offset = "0x65D8D90", VA = "0x1865D9990", Slot = "12")]
	public CJHGCJOMLPH COACLBDLNCH(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x65D99F0", Offset = "0x65D8DF0", VA = "0x1865D99F0", Slot = "13")]
	public AJGEPFOHMIH DKINKEHMDGP(LOPKIINMLDJ ABLKMCPEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x65D9C60", Offset = "0x65D9060", VA = "0x1865D9C60")]
	public IONDHNBLODE MAHCMCFGIGN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x65D9850", Offset = "0x65D8C50", VA = "0x1865D9850")]
	public HPNKGGILPOG ADCKALEENLD(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x65D98C0", Offset = "0x65D8CC0", VA = "0x1865D98C0")]
	public LEDJPGIEGJJ HPNLECEBPDF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x65D9780", Offset = "0x65D8B80", VA = "0x1865D9780")]
	public IGEIHFPCEFN AAPCGOMJOMN(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x65D9BF0", Offset = "0x65D8FF0", VA = "0x1865D9BF0")]
	public NGCFDOFAHHF PPGCOOHJLEG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x65D9CD0", Offset = "0x65D90D0", VA = "0x1865D9CD0", Slot = "19")]
	public LOPKIINMLDJ JGFKCEODJMJ(RigidbodyEx CIJDIMEFBGG, CKDAJCCBABN GMLIPIALCHN, AAPGCFJECKF GPNCNDIBNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public PALENJJKBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x65D9C60", Offset = "0x65D9060", VA = "0x1865D9C60", Slot = "14")]
	private IONDHNBLODE HCGPEGKKPKG(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x65D9850", Offset = "0x65D8C50", VA = "0x1865D9850", Slot = "15")]
	private HPNKGGILPOG HBJBOANKHHE(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x65D98C0", Offset = "0x65D8CC0", VA = "0x1865D98C0", Slot = "16")]
	private LEDJPGIEGJJ BDMKMIJNOHJ(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x65D9780", Offset = "0x65D8B80", VA = "0x1865D9780", Slot = "17")]
	private IGEIHFPCEFN HGAAIGKLPKF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x65D9BF0", Offset = "0x65D8FF0", VA = "0x1865D9BF0", Slot = "18")]
	private NGCFDOFAHHF HAHIAJGOKNF(LOPKIINMLDJ ABLKMCPEJAG, [In] CKDAJCCBABN GMLIPIALCHN)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NNKBGHGFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x65D9E40", Offset = "0x65D9240", VA = "0x1865D9E40", Slot = "6")]
		public sealed override void EGAEKEEPMBK(EANAHNJCCDI COPFOFGFOAL)
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
