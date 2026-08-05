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
public delegate void PMCONJLJKAF(RigidbodyEx IKKFKKAIGIL);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LHINAAIEKGL(RigidbodyEx IKKFKKAIGIL, bool OEHGICEAIOI = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JBPBANCCDDG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DMGABEPMACL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JFNOAMHMCLL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[FHOIBFDAOOA(typeof(LABCLPMNIFE), new string[] { "Ignore", "Mock" })]
public class NJALJLJGIPA : LABCLPMNIFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMGFFAABIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
	public void CKINDCJLOCJ(string NJAPBBBJJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void MMFIKDPMOPE(RigidbodyEx IJNDFBIKOFO, Action PAFFKHOCLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "7")]
	public ELDMKEBEHNG ADEEAJPADPE(int GAMDGJLAOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "8")]
	public void IPJEIGCJPLE(Vector3 JNPAOGGDIBG, float GLNNIMNBALI, Color KKBAHNFNJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NJALJLJGIPA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly FJOGIBEAJHF DOGIOMAIJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool IIGKLLLIBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PFJEEEPJDGP BCDOOCCLCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[NPINIMCHPKM(OECFEFOEJFL.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[NPINIMCHPKM(OECFEFOEJFL.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private DMGABEPMACL physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal PFJEEEPJDGP ABOJMBBIHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x622AB70", Offset = "0x6229F70", VA = "0x18622AB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> JCAOBOKADOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x766600", Offset = "0x765A00", VA = "0x180766600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx EJDHKOCICAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x622CDA0", Offset = "0x622C1A0", VA = "0x18622CDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx BFOGAKMAJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x622CD00", Offset = "0x622C100", VA = "0x18622CD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DCLCDDGJKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x622D9C0", Offset = "0x622CDC0", VA = "0x18622D9C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x622EF40", Offset = "0x622E340", VA = "0x18622EF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform AEGFHJNPPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78C660", Offset = "0x78BA60", VA = "0x18078C660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform IACBPIMLAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78C660", Offset = "0x78BA60", VA = "0x18078C660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EDDJKJMAGDA GHJIOLPCFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x622CAC0", Offset = "0x622BEC0", VA = "0x18622CAC0")]
			get
			{
				return default(EDDJKJMAGDA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x622E6F0", Offset = "0x622DAF0", VA = "0x18622E6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BKPHNJEGKOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x622D050", Offset = "0x622C450", VA = "0x18622D050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool APCPACOJIAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x622CBE0", Offset = "0x622BFE0", VA = "0x18622CBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MLIAOLFDJLC JNCLFMICILB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x622CF90", Offset = "0x622C390", VA = "0x18622CF90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x622E8B0", Offset = "0x622DCB0", VA = "0x18622E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ADEPPJABBBD PGPMAJIFCBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x622CF30", Offset = "0x622C330", VA = "0x18622CF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x622E840", Offset = "0x622DC40", VA = "0x18622E840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KDKEGANKFKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x622CE80", Offset = "0x622C280", VA = "0x18622CE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody CMKNKJMDMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x622CEE0", Offset = "0x622C2E0", VA = "0x18622CEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HEGPOHMMPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x622CC40", Offset = "0x622C040", VA = "0x18622CC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x622E760", Offset = "0x622DB60", VA = "0x18622E760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FEEHOJCFCCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x19F4200", Offset = "0x19F3600", VA = "0x1819F4200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5AB96F0", Offset = "0x5AB8AF0", VA = "0x185AB96F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ICKLDLHGKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x622D960", Offset = "0x622CD60", VA = "0x18622D960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float AFDMNIGHMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x622D900", Offset = "0x622CD00", VA = "0x18622D900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x622EED0", Offset = "0x622E2D0", VA = "0x18622EED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BIIEOCAJMLN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x622D2B0", Offset = "0x622C6B0", VA = "0x18622D2B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x622EB50", Offset = "0x622DF50", VA = "0x18622EB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BBGNOAKCOED
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x622D0B0", Offset = "0x622C4B0", VA = "0x18622D0B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x622E920", Offset = "0x622DD20", VA = "0x18622E920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool PPBPEDEMDON
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x622DF20", Offset = "0x622D320", VA = "0x18622DF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x622F4A0", Offset = "0x622E8A0", VA = "0x18622F4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 IKACIEDNCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x622D6E0", Offset = "0x622CAE0", VA = "0x18622D6E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x622ECA0", Offset = "0x622E0A0", VA = "0x18622ECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JNPAOGGDIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x622E060", Offset = "0x622D460", VA = "0x18622E060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode KKCGFDGOCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x622D1F0", Offset = "0x622C5F0", VA = "0x18622D1F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x622EA70", Offset = "0x622DE70", VA = "0x18622EA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float GIFPAEDEKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x622CCA0", Offset = "0x622C0A0", VA = "0x18622CCA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x622E7D0", Offset = "0x622DBD0", VA = "0x18622E7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints CHLBLGJLHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x622D250", Offset = "0x622C650", VA = "0x18622D250")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x622EAE0", Offset = "0x622DEE0", VA = "0x18622EAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 LAOEMDKCHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x622DA60", Offset = "0x622CE60", VA = "0x18622DA60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MAMHMKJGMLM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x622DA60", Offset = "0x622CE60", VA = "0x18622DA60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x622F280", Offset = "0x622E680", VA = "0x18622F280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CBLNFJJIPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x622D7C0", Offset = "0x622CBC0", VA = "0x18622D7C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x622ED80", Offset = "0x622E180", VA = "0x18622ED80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JFFMKHODMAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x622DEC0", Offset = "0x622D2C0", VA = "0x18622DEC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x622F430", Offset = "0x622E830", VA = "0x18622F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion CJGBCBNLDDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x622DB40", Offset = "0x622CF40", VA = "0x18622DB40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x622F000", Offset = "0x622E400", VA = "0x18622F000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion OHNBBJFAODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x622DDE0", Offset = "0x622D1E0", VA = "0x18622DDE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x622F360", Offset = "0x622E760", VA = "0x18622F360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 PAIIHHHDHNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x622DC20", Offset = "0x622D020", VA = "0x18622DC20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x622F0D0", Offset = "0x622E4D0", VA = "0x18622F0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion LJMEIDOMDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x622DD00", Offset = "0x622D100", VA = "0x18622DD00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x622F1B0", Offset = "0x622E5B0", VA = "0x18622F1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 FJGOAHOCDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x622DF80", Offset = "0x622D380", VA = "0x18622DF80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x622F510", Offset = "0x622E910", VA = "0x18622F510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NAFPPHMNNHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x622D820", Offset = "0x622CC20", VA = "0x18622D820")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x622EDF0", Offset = "0x622E1F0", VA = "0x18622EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DPKJDPPAHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x622D110", Offset = "0x622C510", VA = "0x18622D110")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x622E990", Offset = "0x622DD90", VA = "0x18622E990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BOLPIDMDKCE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x622D600", Offset = "0x622CA00", VA = "0x18622D600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x622EBC0", Offset = "0x622DFC0", VA = "0x18622EBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 NALIPBLIBJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x622D4C0", Offset = "0x622C8C0", VA = "0x18622D4C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion BABMFLFEBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x622D3E0", Offset = "0x622C7E0", VA = "0x18622D3E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FGLIBNBLAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x622E220", Offset = "0x622D620", VA = "0x18622E220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 GENPKOJHPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x622E140", Offset = "0x622D540", VA = "0x18622E140")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EHHAHLLJFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x622D5A0", Offset = "0x622C9A0", VA = "0x18622D5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool GKFHHGKNGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x622CFF0", Offset = "0x622C3F0", VA = "0x18622CFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MJMLIHJGIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x622CB80", Offset = "0x622BF80", VA = "0x18622CB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OJINFGPFAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x622CB20", Offset = "0x622BF20", VA = "0x18622CB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BOOOIHMBKPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x622CA60", Offset = "0x622BE60", VA = "0x18622CA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EOMOCELLHDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x622D310", Offset = "0x622C710", VA = "0x18622D310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JMGKFCEFHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4ECBB30", Offset = "0x4ECAF30", VA = "0x184ECBB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PMCONJLJKAF JAJECLDDEFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x622C980", Offset = "0x622BD80", VA = "0x18622C980")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x622E610", Offset = "0x622DA10", VA = "0x18622E610")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LHINAAIEKGL FPFIELAFFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x622C910", Offset = "0x622BD10", VA = "0x18622C910")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x622E5A0", Offset = "0x622D9A0", VA = "0x18622E5A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PMCONJLJKAF KDHBNMBFAIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x622C670", Offset = "0x622BA70", VA = "0x18622C670")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x622E300", Offset = "0x622D700", VA = "0x18622E300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PMCONJLJKAF PFMLPJOPBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x622C6E0", Offset = "0x622BAE0", VA = "0x18622C6E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x622E370", Offset = "0x622D770", VA = "0x18622E370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event PMCONJLJKAF OAKOCGEHFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x622C830", Offset = "0x622BC30", VA = "0x18622C830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x622E4C0", Offset = "0x622D8C0", VA = "0x18622E4C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x622C7C0", Offset = "0x622BBC0", VA = "0x18622C7C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x622E450", Offset = "0x622D850", VA = "0x18622E450")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PMCONJLJKAF KJBJDFCJAGF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x622C8A0", Offset = "0x622BCA0", VA = "0x18622C8A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x622E530", Offset = "0x622D930", VA = "0x18622E530")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PMCONJLJKAF CNOOFLOOBHI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x622C9F0", Offset = "0x622BDF0", VA = "0x18622C9F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x622E680", Offset = "0x622DA80", VA = "0x18622E680")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PMCONJLJKAF NAFIKMPOEOL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x622C750", Offset = "0x622BB50", VA = "0x18622C750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x622E3E0", Offset = "0x622D7E0", VA = "0x18622E3E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		internal void LOBDKAMKOGB(PFJEEEPJDGP GHADCFDOJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x622B740", Offset = "0x622AB40", VA = "0x18622B740")]
		internal void ODLFPAJBPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x622C390", Offset = "0x622B790", VA = "0x18622C390")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody JJOFKPICNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x622C060", Offset = "0x622B460", VA = "0x18622C060")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) ALHLPOFJJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x622AAA0", Offset = "0x6229EA0", VA = "0x18622AAA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x622AB70", Offset = "0x6229F70", VA = "0x18622AB70")]
		private PFJEEEPJDGP GBBJHKBICIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x622AE00", Offset = "0x622A200", VA = "0x18622AE00")]
		private void EGBIPNOEPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x622B830", Offset = "0x622AC30", VA = "0x18622B830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x622B740", Offset = "0x622AB40", VA = "0x18622B740")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x622B7D0", Offset = "0x622ABD0", VA = "0x18622B7D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x622B890", Offset = "0x622AC90", VA = "0x18622B890")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x622A150", Offset = "0x6229550", VA = "0x18622A150")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x622B8F0", Offset = "0x622ACF0", VA = "0x18622B8F0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x622ADA0", Offset = "0x622A1A0", VA = "0x18622ADA0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x622B6E0", Offset = "0x622AAE0", VA = "0x18622B6E0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x622C1C0", Offset = "0x622B5C0", VA = "0x18622C1C0")]
		public void SetParent(RigidbodyEx LPCGJALKADL, bool OEHGICEAIOI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x622BC00", Offset = "0x622B000", VA = "0x18622BC00")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x622B3B0", Offset = "0x622A7B0", VA = "0x18622B3B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx NPMADHHIJDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x622B490", Offset = "0x622A890", VA = "0x18622B490")]
		public bool IsRigidbodyDescendant(RigidbodyEx DFKGIGFGPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x622A3C0", Offset = "0x62297C0", VA = "0x18622A3C0")]
		public void AddInterpolationRestriction(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x622B960", Offset = "0x622AD60", VA = "0x18622B960")]
		public void RemoveInterpolationRestriction(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x622AB10", Offset = "0x6229F10", VA = "0x18622AB10")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x622A430", Offset = "0x6229830", VA = "0x18622A430")]
		public void AddKinematic(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x622B9D0", Offset = "0x622ADD0", VA = "0x18622B9D0")]
		public void RemoveKinematic(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x622C140", Offset = "0x622B540", VA = "0x18622C140")]
		public void SetKinematic(object IBLOMPOENGH, bool CHLKIHBDBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x622BF60", Offset = "0x622B360", VA = "0x18622BF60")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ECHEIMKOBLE, Quaternion JOJJJBDHOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x622BE60", Offset = "0x622B260", VA = "0x18622BE60")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 FBBLIAHAPDM, Quaternion LIHLHLCNBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x622B2A0", Offset = "0x622A6A0", VA = "0x18622B2A0")]
		public Vector3 GetConstrainedVelocity(Vector3 FJGOAHOCDJJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x622B190", Offset = "0x622A590", VA = "0x18622B190")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DPKJDPPAHNL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x622A2D0", Offset = "0x62296D0", VA = "0x18622A2D0")]
		public void AddForce(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x622A1C0", Offset = "0x62295C0", VA = "0x18622A1C0")]
		public void AddForceAtPosition(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x622A600", Offset = "0x6229A00", VA = "0x18622A600")]
		public void AddTorque(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x622A4A0", Offset = "0x62298A0", VA = "0x18622A4A0")]
		public void AddRelativeTorque(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x622C460", Offset = "0x622B860", VA = "0x18622C460")]
		public Vector3 WorldToLocalVelocity(Vector3 KLLKNOGPFLM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x622B5D0", Offset = "0x622A9D0", VA = "0x18622B5D0")]
		public Vector3 LocalToWorldVelocity(Vector3 NAFPPHMNNHK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x622AD40", Offset = "0x622A140", VA = "0x18622AD40")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x622ACE0", Offset = "0x622A0E0", VA = "0x18622ACE0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x622AC80", Offset = "0x622A080", VA = "0x18622AC80")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x622AC20", Offset = "0x622A020", VA = "0x18622AC20")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x622BD60", Offset = "0x622B160", VA = "0x18622BD60")]
		public void ResetVelocityWorldSpace(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x622BC60", Offset = "0x622B060", VA = "0x18622BC60")]
		public void ResetVelocityLocalSpace(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x622BB20", Offset = "0x622AF20", VA = "0x18622BB20")]
		public void ResetLinearVelocityLocalSpace(Vector3 FCBCFCFGEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x622C2F0", Offset = "0x622B6F0", VA = "0x18622C2F0")]
		public bool SweepTest(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x622B570", Offset = "0x622A970", VA = "0x18622B570")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x622C290", Offset = "0x622B690", VA = "0x18622C290")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x622C400", Offset = "0x622B800", VA = "0x18622C400")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x622A590", Offset = "0x6229990", VA = "0x18622A590")]
		public void AddShouldHaveUnityRigidbodyToken(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x622BA40", Offset = "0x622AE40", VA = "0x18622BA40")]
		public void RemoveShouldHaveUnityRigidbodyToken(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x622A930", Offset = "0x6229D30", VA = "0x18622A930")]
		public void ApplyForceVelocityChange(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x622A890", Offset = "0x6229C90", VA = "0x18622A890")]
		public void ApplyAngularVelocityChange(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x622A9F0", Offset = "0x6229DF0", VA = "0x18622A9F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x622A7C0", Offset = "0x6229BC0", VA = "0x18622A7C0")]
		public bool AllowedScaleChange(float ENADKENACNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x622A6F0", Offset = "0x6229AF0", VA = "0x18622A6F0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LCKOANHNKHA, object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x622BAB0", Offset = "0x622AEB0", VA = "0x18622BAB0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x622C600", Offset = "0x622BA00", VA = "0x18622C600")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class ACLDPCBJKFB
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62030D0", Offset = "0x62024D0", VA = "0x1862030D0")]
	public static PFJEEEPJDGP ABOJMBBIHIM(this RigidbodyEx IJNDFBIKOFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HKOHFLLCKEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public Rigidbody DIMBCBIMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public PhotonView APLHABDFFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 NDJPHAMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 JFEDIJMIENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public DMGABEPMACL JCCGOBCMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool NHJDBLFLCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GOLFADHMCDB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FHOIBFDAOOA(typeof(OAFLAKLOLEE), new string[] { })]
public class NNEONCHGFKH : OAFLAKLOLEE, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EOAILPGBNIC MHGHDIECJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LABCLPMNIFE FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FFAOLLBCFPK PFDFACJHAPJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LABCLPMNIFE JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FFAOLLBCFPK CNGKDKPPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6228EB0", Offset = "0x62282B0", VA = "0x186228EB0", Slot = "8")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6228AE0", Offset = "0x6227EE0", VA = "0x186228AE0", Slot = "6")]
	public CAKFEHOBCAO CFFCJFGMNND(RigidbodyEx IJNDFBIKOFO)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6228DC0", Offset = "0x62281C0", VA = "0x186228DC0")]
	private static CAKFEHOBCAO IKLNOEGBGHN(RigidbodyEx IJNDFBIKOFO)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6228A40", Offset = "0x6227E40", VA = "0x186228A40", Slot = "7")]
	public PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NNEONCHGFKH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static HJKDHGFMLBJ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int FLPENEKEEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int JLJPMGADMJO;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6229FB0", Offset = "0x62293B0", VA = "0x186229FB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6229FF0", Offset = "0x62293F0", VA = "0x186229FF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6229FD0", Offset = "0x62293D0", VA = "0x186229FD0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string LMJAPBNMKLG, [Optional] UnityEngine.Object CNKGFJIJGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string LMJAPBNMKLG, [Optional] UnityEngine.Object CNKGFJIJGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x622A100", Offset = "0x6229500", VA = "0x18622A100")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HFDDLPNJDGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6217B20", Offset = "0x6216F20", VA = "0x186217B20")]
	public static void OCHEKIGFCMM(this Rigidbody JJOFKPICNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6217CB0", Offset = "0x62170B0", VA = "0x186217CB0")]
	public static void OCHEKIGFCMM(this Rigidbody JJOFKPICNBF, Vector3 JEMPFNMLIFN, Quaternion BABMFLFEBOI, Vector3 POJHINPFBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB0DC20", Offset = "0xB0D020", VA = "0x180B0DC20")]
	public static void MIBMDAMCFMH(Vector3 FJGOAHOCDJJ, Vector3 DDEDMKGDKMA, [Out] Vector3 NALGGFPAOIG, [Out] Vector3 LBKAFNEJBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KFPPGLNGPDE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class CPCBLGAAMMO : MLIAOLFDJLC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0", Slot = "4")]
		public Vector3 PCGLJODOFOL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0", Slot = "5")]
		public Vector3 MKKPBKHJMGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CPCBLGAAMMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static MLIAOLFDJLC BLGEPJFOKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6220790", Offset = "0x621FB90", VA = "0x186220790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PLNHLNJNAPH
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode HCGNOFKHPDP
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
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOEOHIMBGNI(bool EHHAHLLJFMA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBNGMIFGCBJ(bool EHHAHLLJFMA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MMEPBAGLDDK : IDisposable, DANNLMHLCBM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHAKBPEKNHN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface FFAOLLBCFPK
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NOEECIOLHEN PELIFCCNONF(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IPKLFIKKFCE IHCJAENGEDO(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODIHKLIFNOG NNDALAGHOAI(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OCHDBEMEHEI HPAOOEFHCIB(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGKIONLPONA EGMCPADIDOB(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MMEPBAGLDDK EFEHFJDHPPD(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JDJGAANDNAK DKDLIFGIELC(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ANHMPPFHALM KOLMNJNLEBB(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PLNHLNJNAPH ODGOHJEPPAE(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HJMBGHGIKPG NBFMOKKBOJG(PFJEEEPJDGP GHADCFDOJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LPGJCAAOFBM PJHIPFEABPB(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BPKEOJMBMPD OLAJCLOGCGL(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GBCIKCKFFKI KFBCOGCOGAH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DGFNAOONHOB ABLCJEKFDPK(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JMDONDDNJFG DBGKIODADJF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD, OAFLAKLOLEE CCJFCCENPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ANHMPPFHALM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HJMBGHGIKPG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AAKPEJBHDKB
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
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NOEECIOLHEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PMCONJLJKAF KDHBNMBFAIC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PMCONJLJKAF PFMLPJOPBCA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LHINAAIEKGL KOAAHFFMJGA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action OAJPGHELLAF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action GEHMKMKFPAB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PFJEEEPJDGP> GLEJGCBGAEG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<PFJEEEPJDGP> OKJGFMAKPEL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action GAJNENDJJJC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<PFJEEEPJDGP> FCLMOBNLDBC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LEKFLKBIABP(PFJEEEPJDGP KJOCICNOINI, bool OEHGICEAIOI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ODIHKLIFNOG
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFMGAPGHCBO(PFJEEEPJDGP DCLCDDGJKIC, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void APOFALCIKGL(object IBLOMPOENGH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DGFNAOONHOB
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PMCONJLJKAF LIEDCPDMCPO;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPJNFIDCMHN();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OFLNNNMBNOO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LEIHBCILENK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AAJPKADPJEC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GBCIKCKFFKI
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCPJADHNMFM(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHDDDHOJGFI(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBFKNOMKGHF(PFJEEEPJDGP IJNDFBIKOFO);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAFDPFGOKEP(PFJEEEPJDGP IJNDFBIKOFO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBFEPACHMBD();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JDJGAANDNAK
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PMCONJLJKAF DHPCHJAECNM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLPPHDBFFKA();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HJPCEBAPFBJ(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDJJIFBHOFL(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable MNNNBPBFADH();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMMCIHKJEPH(Rigidbody DKNAEDLPCJA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BPKEOJMBMPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PMCONJLJKAF IKMFGIMECGD;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKKEPIJLGEJ(PFJEEEPJDGP DCLCDDGJKIC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEHBPCICNNE(PFJEEEPJDGP DCLCDDGJKIC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JMDONDDNJFG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ADEAMDCGMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints BLHDCKAAFFE
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
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OCHDBEMEHEI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float NDFOPAPAENH
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
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FGLFOLPIOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KMOOGJPOEBN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PGKIONLPONA
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event PMCONJLJKAF KGNMFBHFJOD;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMEBIIDAOAM();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHPLEHOKMMF();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKJFDFJNGLE();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHAAACLBCAG();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHEDIHKEEHD();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HLGOLFFLAAE(bool FGLLJKDIGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LPGJCAAOFBM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool EEOGKHKKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONCMECCPFEJ(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGEHJOCGMEA(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOIOJAMPJHN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBJGLANLFLG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IPKLFIKKFCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EIJLCDDNEMP(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CPBMGFONLMK();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MAHIALLIPDJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NFCAFMPGPAH();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GBFHHDNOOJG();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PLDHOGBBINH(Vector3 FJGOAHOCDJJ);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GJIAPMEOHIB(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DLAFCKDHKCN(Vector3 AOPGBEBGNMM);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface LABCLPMNIFE
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool EMGFFAABIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKINDCJLOCJ(string NJAPBBBJJNP);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMFIKDPMOPE(RigidbodyEx IJNDFBIKOFO, Action PAFFKHOCLGN);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ELDMKEBEHNG ADEEAJPADPE(int GAMDGJLAOOH);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPJEIGCJPLE(Vector3 JNPAOGGDIBG, float GLNNIMNBALI, Color KKBAHNFNJMK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface OAFLAKLOLEE
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LABCLPMNIFE JIBKILINHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	FFAOLLBCFPK CNGKDKPPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAKFEHOBCAO CFFCJFGMNND(RigidbodyEx IJNDFBIKOFO);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface ADEPPJABBBD
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJALKKDAADC(Vector3 NHEELIOLBEK);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DILDIMIEHHP(Vector3 DPKJDPPAHNL);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJMNLMHJKCH(Vector3 NHEELIOLBEK);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCOMNGCKACN(Vector3 DPKJDPPAHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MLIAOLFDJLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 PCGLJODOFOL();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MKKPBKHJMGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PFJEEEPJDGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx AKEFGKJCKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject EHDJFHDMAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool OJINFGPFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool BOOOIHMBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float NDFOPAPAENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool AAKPEJBHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform IACBPIMLAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 JIOHNMPCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float COMHGNIDJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float BLFDJHCMPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion PJDLILOOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints BLHDCKAAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode HCGNOFKHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool GKFHHGKNGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event PMCONJLJKAF KDHBNMBFAIC;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event PMCONJLJKAF PFMLPJOPBCA;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event LHINAAIEKGL KOAAHFFMJGA;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event PMCONJLJKAF IKMFGIMECGD;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event PMCONJLJKAF OAKOCGEHFKP;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event PMCONJLJKAF KGNMFBHFJOD;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event PMCONJLJKAF DHPCHJAECNM;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event PMCONJLJKAF NAFIKMPOEOL;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void BHAKBPEKNHN();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void AEJIJDMOINK();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void EHHLNCGGKIF();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void MKJFDFJNGLE();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void LEKFLKBIABP(PFJEEEPJDGP LPCGJALKADL, bool OEHGICEAIOI = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void OGBHLMOJIPP(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void HNBKKLMIBMF(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void GBFHHDNOOJG();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void MAHIALLIPDJ();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void CPBMGFONLMK();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void DLAFCKDHKCN(Vector3 AOPGBEBGNMM);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 PLDHOGBBINH(Vector3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 ADJFDPJHKEM(Vector3 LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NFCAFMPGPAH();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void OBAMDECLFGJ(PFJEEEPJDGP LCKOANHNKHA, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KHBDKKAOBEE(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void OFLNNNMBNOO();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LPJNFIDCMHN();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LEIHBCILENK();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool CMEBIIDAOAM();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void MHEDIHKEEHD();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable MNNNBPBFADH();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HJPCEBAPFBJ(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void KDJJIFBHOFL(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LKMEKBMECJN(Vector3 ECHEIMKOBLE, Quaternion JOJJJBDHOMP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void NDGHGCGHOCJ(Vector3 FBBLIAHAPDM, Quaternion LIHLHLCNBCF);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool FHJOCNLMPFO(float ENADKENACNO);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void AFEIDMBALFF(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void CBGNLKDDIEE(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void ONCMECCPFEJ(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void GGEHJOCGMEA(object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void AAJPKADPJEC();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EOANOGBMDEJ : PFJEEEPJDGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly OAFLAKLOLEE CCJFCCENPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal NOEECIOLHEN PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GBCIKCKFFKI KDCJMFPAJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BPKEOJMBMPD FBGBGEJBECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IPKLFIKKFCE FJGOAHOCDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal ODIHKLIFNOG DDBJCOINHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal DGFNAOONHOB PAOADHEDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal OCHDBEMEHEI GEBJLBMCICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal HJMBGHGIKPG ILBIMNCJACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal PGKIONLPONA DCDDAELEMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MMEPBAGLDDK JOLCJBMCDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal JDJGAANDNAK DGJNNCPBOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal ANHMPPFHALM EAJNNLJOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal JMDONDDNJFG JIGLOOFGPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal LPGJCAAOFBM DIMBCBIMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal PLNHLNJNAPH JKKFNPFGMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal IDisposable IEMNBICIMBE;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx AKEFGKJCKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x765420", Offset = "0x764820", VA = "0x180765420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject EHDJFHDMAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8877D0", Offset = "0x886BD0", VA = "0x1808877D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x886C40", Offset = "0x886040", VA = "0x180886C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x620F520", Offset = "0x620E920", VA = "0x18620F520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x620C2F0", Offset = "0x620B6F0", VA = "0x18620C2F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x620F470", Offset = "0x620E870", VA = "0x18620F470", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x62109C0", Offset = "0x620FDC0", VA = "0x1862109C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x620D860", Offset = "0x620CC60", VA = "0x18620D860", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x620F760", Offset = "0x620EB60", VA = "0x18620F760", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6210220", Offset = "0x620F620", VA = "0x186210220", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x620D3C0", Offset = "0x620C7C0", VA = "0x18620D3C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x620E1F0", Offset = "0x620D5F0", VA = "0x18620E1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x620DAC0", Offset = "0x620CEC0", VA = "0x18620DAC0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x620EB20", Offset = "0x620DF20", VA = "0x18620EB20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x620EC60", Offset = "0x620E060", VA = "0x18620EC60", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6211830", Offset = "0x6210C30", VA = "0x186211830", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x620F930", Offset = "0x620ED30", VA = "0x18620F930", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x620DCE0", Offset = "0x620D0E0", VA = "0x18620DCE0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x620D070", Offset = "0x620C470", VA = "0x18620D070", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x620E240", Offset = "0x620D640", VA = "0x18620E240", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x620D6B0", Offset = "0x620CAB0", VA = "0x18620D6B0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x620D410", Offset = "0x620C810", VA = "0x18620D410", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x620F390", Offset = "0x620E790", VA = "0x18620F390", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x620EF70", Offset = "0x620E370", VA = "0x18620EF70", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x620D4F0", Offset = "0x620C8F0", VA = "0x18620D4F0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x620ED50", Offset = "0x620E150", VA = "0x18620ED50", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MJMLIHJGIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6211890", Offset = "0x6210C90", VA = "0x186211890", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OJINFGPFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x620E420", Offset = "0x620D820", VA = "0x18620E420", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BOOOIHMBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x620CBC0", Offset = "0x620BFC0", VA = "0x18620CBC0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x620E320", Offset = "0x620D720", VA = "0x18620E320", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x620F050", Offset = "0x620E450", VA = "0x18620F050", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x620C8E0", Offset = "0x620BCE0", VA = "0x18620C8E0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x620C0C0", Offset = "0x620B4C0", VA = "0x18620C0C0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6211750", Offset = "0x6210B50", VA = "0x186211750", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x620EB80", Offset = "0x620DF80", VA = "0x18620EB80", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x620C690", Offset = "0x620BA90", VA = "0x18620C690", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6210BC0", Offset = "0x620FFC0", VA = "0x186210BC0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x620CCA0", Offset = "0x620C0A0", VA = "0x18620CCA0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x620E960", Offset = "0x620DD60", VA = "0x18620E960", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x62103A0", Offset = "0x620F7A0", VA = "0x1862103A0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6211240", Offset = "0x6210640", VA = "0x186211240", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6210710", Offset = "0x620FB10", VA = "0x186210710", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float NDFOPAPAENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x620F240", Offset = "0x620E640", VA = "0x18620F240", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x620C060", Offset = "0x620B460", VA = "0x18620C060", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool AAKPEJBHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x620E910", Offset = "0x620DD10", VA = "0x18620E910", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x620F980", Offset = "0x620ED80", VA = "0x18620F980", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x620EA90", Offset = "0x620DE90", VA = "0x18620EA90", Slot = "48")]
		get
		{
			return default(LHMMHIJEJEH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6210340", Offset = "0x620F740", VA = "0x186210340", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x620ED00", Offset = "0x620E100", VA = "0x18620ED00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform IACBPIMLAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x620E1E0", Offset = "0x620D5E0", VA = "0x18620E1E0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 JIOHNMPCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x620CA30", Offset = "0x620BE30", VA = "0x18620CA30", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x620CD60", Offset = "0x620C160", VA = "0x18620CD60", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float COMHGNIDJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x620F220", Offset = "0x620E620", VA = "0x18620F220", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x620C1A0", Offset = "0x620B5A0", VA = "0x18620C1A0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float BLFDJHCMPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x620F8B0", Offset = "0x620ECB0", VA = "0x18620F8B0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x620F290", Offset = "0x620E690", VA = "0x18620F290", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion PJDLILOOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6210170", Offset = "0x620F570", VA = "0x186210170", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x620DD40", Offset = "0x620D140", VA = "0x18620DD40", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x620ECB0", Offset = "0x620E0B0", VA = "0x18620ECB0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x620FB70", Offset = "0x620EF70", VA = "0x18620FB70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x620C500", Offset = "0x620B900", VA = "0x18620C500", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x620EAE0", Offset = "0x620DEE0", VA = "0x18620EAE0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints BLHDCKAAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6210C10", Offset = "0x6210010", VA = "0x186210C10", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x620DC80", Offset = "0x620D080", VA = "0x18620DC80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x620EA40", Offset = "0x620DE40", VA = "0x18620EA40", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x620CE20", Offset = "0x620C220", VA = "0x18620CE20", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode HCGNOFKHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x620EE90", Offset = "0x620E290", VA = "0x18620EE90", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x620F700", Offset = "0x620EB00", VA = "0x18620F700", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool KABOLKIFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6211090", Offset = "0x6210490", VA = "0x186211090", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GKFHHGKNGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x620FFF0", Offset = "0x620F3F0", VA = "0x18620FFF0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KAPCAAOLPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6210770", Offset = "0x620FB70", VA = "0x186210770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CJPOAIAEOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x620EEE0", Offset = "0x620E2E0", VA = "0x18620EEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PMCONJLJKAF KDHBNMBFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x620E040", Offset = "0x620D440", VA = "0x18620E040", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x620C6E0", Offset = "0x620BAE0", VA = "0x18620C6E0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PMCONJLJKAF PFMLPJOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x620BD60", Offset = "0x620B160", VA = "0x18620BD60", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x620D310", Offset = "0x620C710", VA = "0x18620D310", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LHINAAIEKGL KOAAHFFMJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x62114D0", Offset = "0x62108D0", VA = "0x1862114D0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x62108C0", Offset = "0x620FCC0", VA = "0x1862108C0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event PMCONJLJKAF IKMFGIMECGD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x620DE30", Offset = "0x620D230", VA = "0x18620DE30", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x620F4C0", Offset = "0x620E8C0", VA = "0x18620F4C0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event PMCONJLJKAF OAKOCGEHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x620C630", Offset = "0x620BA30", VA = "0x18620C630", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x620F5B0", Offset = "0x620E9B0", VA = "0x18620F5B0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event PMCONJLJKAF KGNMFBHFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x620F9E0", Offset = "0x620EDE0", VA = "0x18620F9E0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6210810", Offset = "0x620FC10", VA = "0x186210810", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x620C880", Offset = "0x620BC80", VA = "0x18620C880", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x62115E0", Offset = "0x62109E0", VA = "0x1862115E0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event PMCONJLJKAF DHPCHJAECNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x620F8D0", Offset = "0x620ECD0", VA = "0x18620F8D0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6211470", Offset = "0x6210870", VA = "0x186211470", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event PMCONJLJKAF NAFIKMPOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x620FC20", Offset = "0x620F020", VA = "0x18620FC20", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x62118E0", Offset = "0x6210CE0", VA = "0x1862118E0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6211AD0", Offset = "0x6210ED0", VA = "0x186211AD0")]
	public EOANOGBMDEJ(GameObject GHAOKLKOOCA, RigidbodyEx JMHHMLNBHNM, OAFLAKLOLEE CCJFCCENPLD, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6210C60", Offset = "0x6210060", VA = "0x186210C60", Slot = "135")]
	protected virtual void NGMPAIAHNDF(OAFLAKLOLEE CCJFCCENPLD, HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x620D790", Offset = "0x620CB90", VA = "0x18620D790", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x620C740", Offset = "0x620BB40", VA = "0x18620C740", Slot = "71")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x620BED0", Offset = "0x620B2D0", VA = "0x18620BED0", Slot = "72")]
	public void AEJIJDMOINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x620DAA0", Offset = "0x620CEA0", VA = "0x18620DAA0", Slot = "73")]
	public void EHHLNCGGKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6211640", Offset = "0x6210A40", VA = "0x186211640")]
	private void OIDBFPCGOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x62102D0", Offset = "0x620F6D0", VA = "0x1862102D0", Slot = "81")]
	public void LEKFLKBIABP(PFJEEEPJDGP LPCGJALKADL, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6211580", Offset = "0x6210980", VA = "0x186211580", Slot = "84")]
	public void OGBHLMOJIPP(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x620EF10", Offset = "0x620E310", VA = "0x18620EF10", Slot = "85")]
	public void HNBKKLMIBMF(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x620DE90", Offset = "0x620D290", VA = "0x18620DE90", Slot = "86")]
	public Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x620F7B0", Offset = "0x620EBB0", VA = "0x18620F7B0", Slot = "87")]
	public Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x620BED0", Offset = "0x620B2D0", VA = "0x18620BED0", Slot = "88")]
	public void GBFHHDNOOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x62106C0", Offset = "0x620FAC0", VA = "0x1862106C0", Slot = "89")]
	public void MAHIALLIPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x620D370", Offset = "0x620C770", VA = "0x18620D370", Slot = "90")]
	public void CPBMGFONLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x620F610", Offset = "0x620EA10", VA = "0x18620F610", Slot = "91")]
	public void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x620C540", Offset = "0x620B940", VA = "0x18620C540", Slot = "92")]
	public void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x620D5D0", Offset = "0x620C9D0", VA = "0x18620D5D0", Slot = "93")]
	public void DLAFCKDHKCN(Vector3 AOPGBEBGNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x620E7F0", Offset = "0x620DBF0", VA = "0x18620E7F0", Slot = "94")]
	public void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x620DBE0", Offset = "0x620CFE0", VA = "0x18620DBE0", Slot = "95")]
	public void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x620DF90", Offset = "0x620D390", VA = "0x18620DF90", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6211990", Offset = "0x6210D90", VA = "0x186211990", Slot = "97")]
	public Vector3 PLDHOGBBINH(Vector3 LPCGJALKADL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x620BC60", Offset = "0x620B060", VA = "0x18620BC60", Slot = "98")]
	public Vector3 ADJFDPJHKEM(Vector3 LPCGJALKADL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6210B70", Offset = "0x620FF70", VA = "0x186210B70", Slot = "99")]
	public void NFCAFMPGPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x62111D0", Offset = "0x62105D0", VA = "0x1862111D0", Slot = "100")]
	public void OBAMDECLFGJ(PFJEEEPJDGP LCKOANHNKHA, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x620FBC0", Offset = "0x620EFC0", VA = "0x18620FBC0", Slot = "101")]
	public void KHBDKKAOBEE(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x620C210", Offset = "0x620B610", VA = "0x18620C210", Slot = "41")]
	public void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6211530", Offset = "0x6210930", VA = "0x186211530", Slot = "104")]
	public void OFLNNNMBNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6210670", Offset = "0x620FA70", VA = "0x186210670", Slot = "105")]
	public void LPJNFIDCMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6210280", Offset = "0x620F680", VA = "0x186210280", Slot = "106")]
	public void LEIHBCILENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x620D150", Offset = "0x620C550", VA = "0x18620D150", Slot = "109")]
	public bool CMEBIIDAOAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6210920", Offset = "0x620FD20", VA = "0x186210920", Slot = "74")]
	public void MKJFDFJNGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6210870", Offset = "0x620FC70", VA = "0x186210870", Slot = "110")]
	public void MHEDIHKEEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6210970", Offset = "0x620FD70", VA = "0x186210970", Slot = "115")]
	public IDisposable MNNNBPBFADH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x620EE30", Offset = "0x620E230", VA = "0x18620EE30", Slot = "116")]
	public void HJPCEBAPFBJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x620FA40", Offset = "0x620EE40", VA = "0x18620FA40", Slot = "117")]
	public void KDJJIFBHOFL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x620C9C0", Offset = "0x620BDC0", VA = "0x18620C9C0", Slot = "118")]
	public void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6210470", Offset = "0x620F870", VA = "0x186210470", Slot = "121")]
	public void LKMEKBMECJN(Vector3 ECHEIMKOBLE, Quaternion JOJJJBDHOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6210A20", Offset = "0x620FE20", VA = "0x186210A20", Slot = "122")]
	public void NDGHGCGHOCJ(Vector3 FBBLIAHAPDM, Quaternion LIHLHLCNBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x620E180", Offset = "0x620D580", VA = "0x18620E180", Slot = "123")]
	public bool FHJOCNLMPFO(float ENADKENACNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x620BF20", Offset = "0x620B320", VA = "0x18620BF20", Slot = "124")]
	public void AFEIDMBALFF(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x620CD00", Offset = "0x620C100", VA = "0x18620CD00", Slot = "125")]
	public void CBGNLKDDIEE(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x62116F0", Offset = "0x6210AF0", VA = "0x1862116F0", Slot = "126")]
	public void ONCMECCPFEJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x620E8B0", Offset = "0x620DCB0", VA = "0x18620E8B0", Slot = "127")]
	public void GGEHJOCGMEA(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x620E0A0", Offset = "0x620D4A0", VA = "0x18620E0A0", Slot = "128")]
	public void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x620BDC0", Offset = "0x620B1C0", VA = "0x18620BDC0", Slot = "129")]
	public void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x620D8B0", Offset = "0x620CCB0", VA = "0x18620D8B0", Slot = "130")]
	public void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x620BF80", Offset = "0x620B380", VA = "0x18620BF80", Slot = "131")]
	public void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6210F50", Offset = "0x6210350", VA = "0x186210F50", Slot = "132")]
	public bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x620BC10", Offset = "0x620B010", VA = "0x18620BC10", Slot = "133")]
	public void AAJPKADPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6211A90", Offset = "0x6210E90", VA = "0x186211A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x620CAE0", Offset = "0x620BEE0", VA = "0x18620CAE0")]
	private void BLEFMGGIHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x620D990", Offset = "0x620CD90", VA = "0x18620D990")]
	private void ECMICPIMKEN(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x620CE80", Offset = "0x620C280", VA = "0x18620CE80")]
	private void CFGEFLMPLCN(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x620E370", Offset = "0x620D770", VA = "0x18620E370")]
	private void FKOBPIHGGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x620F120", Offset = "0x620E520", VA = "0x18620F120")]
	private void IIPPAILEHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6211290", Offset = "0x6210690", VA = "0x186211290")]
	private void ODPLCMGMDEA(PFJEEEPJDGP KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x620DB10", Offset = "0x620CF10", VA = "0x18620DB10")]
	private void EKKEPIJLGEJ(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x620FAA0", Offset = "0x620EEA0", VA = "0x18620FAA0")]
	private void KEHBPCICNNE(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x620D1A0", Offset = "0x620C5A0", VA = "0x18620D1A0")]
	private void CMJCHMHFBCL(RigidbodyEx DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x620C340", Offset = "0x620B740", VA = "0x18620C340", Slot = "140")]
	protected virtual void BBFLNINCIMO(RigidbodyEx IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x620FCD0", Offset = "0x620F0D0", VA = "0x18620FCD0")]
	protected void KJMGIPJLCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x620E480", Offset = "0x620D880", VA = "0x18620E480")]
	protected void FPBDEHNKLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6210FF0", Offset = "0x62103F0", VA = "0x186210FF0", Slot = "141")]
	protected virtual IDisposable NPJPJGAIABA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class IKKHCDNKFDG
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x62188A0", Offset = "0x6217CA0", VA = "0x1862188A0")]
	public static PFJEEEPJDGP GDGFKDLKBAK(this PFJEEEPJDGP IJNDFBIKOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6218950", Offset = "0x6217D50", VA = "0x186218950")]
	public static bool HFIKDOBLHPH(this PFJEEEPJDGP IJNDFBIKOFO, PFJEEEPJDGP NPMADHHIJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6218820", Offset = "0x6217C20", VA = "0x186218820")]
	public static bool FBFOLLPCKGC(this PFJEEEPJDGP IJNDFBIKOFO, PFJEEEPJDGP DFKGIGFGPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x62187D0", Offset = "0x6217BD0", VA = "0x1862187D0")]
	public static RigidbodyEx AKEFGKJCKOM(this PFJEEEPJDGP ABOJMBBIHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6218750", Offset = "0x6217B50", VA = "0x186218750")]
	public static EOANOGBMDEJ AAEEKJEOHLL(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class PLOGKIACAIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6229DD0", Offset = "0x62291D0", VA = "0x186229DD0")]
	public PLOGKIACAIJ(EOANOGBMDEJ OADEONFPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6229D70", Offset = "0x6229170", VA = "0x186229D70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class CDDHEJLDCIM : POFDCKNGGND, PLNHLNJNAPH
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode GAJHLIBGNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6207840", Offset = "0x6206C40", VA = "0x186207840")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6207AB0", Offset = "0x6206EB0", VA = "0x186207AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode HCGNOFKHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x62076B0", Offset = "0x6206AB0", VA = "0x1862076B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x62077C0", Offset = "0x6206BC0", VA = "0x1862077C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public CDDHEJLDCIM(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x62072F0", Offset = "0x62066F0", VA = "0x1862072F0", Slot = "6")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6207620", Offset = "0x6206A20", VA = "0x186207620", Slot = "9")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6207610", Offset = "0x6206A10", VA = "0x186207610", Slot = "7")]
	public void DOEOHIMBGNI(bool EHHAHLLJFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6207940", Offset = "0x6206D40", VA = "0x186207940", Slot = "8")]
	public void LBNGMIFGCBJ(bool EHHAHLLJFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6207950", Offset = "0x6206D50", VA = "0x186207950", Slot = "10")]
	public bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6207400", Offset = "0x6206800", VA = "0x186207400")]
	private void DIAJFHMBGGK(bool EHHAHLLJFMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class JJJIBPFFMJF : POFDCKNGGND, MMEPBAGLDDK, IDisposable, DANNLMHLCBM
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public LHMMHIJEJEH MIMMNNBADFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x621CEF0", Offset = "0x621C2F0", VA = "0x18621CEF0")]
		get
		{
			return default(LHMMHIJEJEH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x621CFF0", Offset = "0x621C3F0", VA = "0x18621CFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x621D0F0", Offset = "0x621C4F0", VA = "0x18621D0F0", Slot = "6")]
		get
		{
			return default(LHMMHIJEJEH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x621CFF0", Offset = "0x621C3F0", VA = "0x18621CFF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform IMFFJBLPCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x621CE40", Offset = "0x621C240", VA = "0x18621CE40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x621D310", Offset = "0x621C710", VA = "0x18621D310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public JJJIBPFFMJF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x621D3C0", Offset = "0x621C7C0", VA = "0x18621D3C0", Slot = "11")]
	public void OnChangedDistanceBand(BNKNPIOGGJK HDAGINFADOG, BNKNPIOGGJK LFEAEFFENHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
	public void OnChangedVisibility(bool IIAFBMLOLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "8")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class DFCGGFFIGOE : POFDCKNGGND, ANHMPPFHALM
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6209800", Offset = "0x6208C00", VA = "0x186209800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6209BF0", Offset = "0x6208FF0", VA = "0x186209BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6209B90", Offset = "0x6208F90", VA = "0x186209B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public DFCGGFFIGOE(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x62096A0", Offset = "0x6208AA0", VA = "0x1862096A0", Slot = "4")]
	public void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x62093C0", Offset = "0x62087C0", VA = "0x1862093C0")]
	private void ENKBMOKHLFN(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6208D80", Offset = "0x6208180", VA = "0x186208D80", Slot = "5")]
	public void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6209260", Offset = "0x6208660", VA = "0x186209260", Slot = "6")]
	public void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6209850", Offset = "0x6208C50", VA = "0x186209850")]
	private void HIPPAHGCKDA(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6209000", Offset = "0x6208400", VA = "0x186209000", Slot = "7")]
	public void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6209AB0", Offset = "0x6208EB0", VA = "0x186209AB0")]
	private void IJCNCIMJJJN(string LMJAPBNMKLG, UnityEngine.Object CNKGFJIJGPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LCDIFFOGGOJ : POFDCKNGGND, HJMBGHGIKPG
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool AAKPEJBHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6220990", Offset = "0x621FD90", VA = "0x186220990", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6220B00", Offset = "0x621FF00", VA = "0x186220B00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public LCDIFFOGGOJ(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6220860", Offset = "0x621FC60", VA = "0x186220860", Slot = "6")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6220A90", Offset = "0x621FE90", VA = "0x186220A90", Slot = "7")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class KEELHBGKPGF : POFDCKNGGND, NOEECIOLHEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly FJOGIBEAJHF OPEIBEGGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly CHDPJJEDBHH ANNLGGCBKAD;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x621F1B0", Offset = "0x621E5B0", VA = "0x18621F1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CAKFEHOBCAO ALFBPAGABIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x621E8D0", Offset = "0x621DCD0", VA = "0x18621E8D0")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x621F400", Offset = "0x621E800", VA = "0x18621F400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x621F170", Offset = "0x621E570", VA = "0x18621F170", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x621F8E0", Offset = "0x621ECE0", VA = "0x18621F8E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public CAKFEHOBCAO AKJBCMMOPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x621F720", Offset = "0x621EB20", VA = "0x18621F720")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x621FC00", Offset = "0x621F000", VA = "0x18621FC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x621F3C0", Offset = "0x621E7C0", VA = "0x18621F3C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PMCONJLJKAF KDHBNMBFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x621E9F0", Offset = "0x621DDF0", VA = "0x18621E9F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x621E0F0", Offset = "0x621D4F0", VA = "0x18621E0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PMCONJLJKAF PFMLPJOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x621E050", Offset = "0x621D450", VA = "0x18621E050", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x621E2F0", Offset = "0x621D6F0", VA = "0x18621E2F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LHINAAIEKGL KOAAHFFMJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x621FD10", Offset = "0x621F110", VA = "0x18621FD10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x621F840", Offset = "0x621EC40", VA = "0x18621F840", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action OAJPGHELLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x621F5E0", Offset = "0x621E9E0", VA = "0x18621F5E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x621F950", Offset = "0x621ED50", VA = "0x18621F950", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action GEHMKMKFPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x621E590", Offset = "0x621D990", VA = "0x18621E590", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x621F680", Offset = "0x621EA80", VA = "0x18621F680", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<PFJEEEPJDGP> GLEJGCBGAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x621EBF0", Offset = "0x621DFF0", VA = "0x18621EBF0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x621EEB0", Offset = "0x621E2B0", VA = "0x18621EEB0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<PFJEEEPJDGP> OKJGFMAKPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x621EF60", Offset = "0x621E360", VA = "0x18621EF60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x621ED50", Offset = "0x621E150", VA = "0x18621ED50", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action GAJNENDJJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x621F0D0", Offset = "0x621E4D0", VA = "0x18621F0D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6220470", Offset = "0x621F870", VA = "0x186220470", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<PFJEEEPJDGP> FCLMOBNLDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x621EE00", Offset = "0x621E200", VA = "0x18621EE00", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x621ECA0", Offset = "0x621E0A0", VA = "0x18621ECA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x62205A0", Offset = "0x621F9A0", VA = "0x1862205A0")]
	public KEELHBGKPGF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x621E630", Offset = "0x621DA30", VA = "0x18621E630", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x621F510", Offset = "0x621E910", VA = "0x18621F510", Slot = "26")]
	public void LEKFLKBIABP(PFJEEEPJDGP KJOCICNOINI, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x621F590", Offset = "0x621E990", VA = "0x18621F590")]
	private void LEKFLKBIABP(HENGAEMDJAC KJOCICNOINI, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x621FDB0", Offset = "0x621F1B0", VA = "0x18621FDB0")]
	private void PDKGDGEBNCP(HENGAEMDJAC KJOCICNOINI, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x621F9F0", Offset = "0x621EDF0", VA = "0x18621F9F0")]
	private void NNFBDHEHBMC(HENGAEMDJAC KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x621E390", Offset = "0x621D790", VA = "0x18621E390")]
	private void CPHLAKNCPJL(HENGAEMDJAC KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x621F1E0", Offset = "0x621E5E0", VA = "0x18621F1E0")]
	private void JDMOOKCGIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x621DFB0", Offset = "0x621D3B0", VA = "0x18621DFB0")]
	private void ADIKJJDDBPK(HENGAEMDJAC KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x621F010", Offset = "0x621E410", VA = "0x18621F010")]
	private void IJABMCFNKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x621EA90", Offset = "0x621DE90", VA = "0x18621EA90")]
	private void FFBCIDBKJPK(HENGAEMDJAC IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x621E190", Offset = "0x621D590", VA = "0x18621E190")]
	private void BOJDPHNKIJA(HENGAEMDJAC IJNDFBIKOFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class FDFOBEDHJCP
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6213470", Offset = "0x6212870", VA = "0x186213470")]
	public static KEELHBGKPGF EFBMJCLPBLE(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FALDGKMDLPM : POFDCKNGGND, ODIHKLIFNOG
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6211ED0", Offset = "0x62112D0", VA = "0x186211ED0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6211CA0", Offset = "0x62110A0", VA = "0x186211CA0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6211F00", Offset = "0x6211300", VA = "0x186211F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private PFJEEEPJDGP NOKHKNMHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6212400", Offset = "0x6211800", VA = "0x186212400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public FALDGKMDLPM(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6212590", Offset = "0x6211990", VA = "0x186212590", Slot = "6")]
	public void MFMGAPGHCBO(PFJEEEPJDGP DCLCDDGJKIC, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6212720", Offset = "0x6211B20", VA = "0x186212720")]
	private void MFMGAPGHCBO(HENGAEMDJAC DCLCDDGJKIC, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6211BA0", Offset = "0x6210FA0", VA = "0x186211BA0", Slot = "7")]
	public void APOFALCIKGL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6211FF0", Offset = "0x62113F0", VA = "0x186211FF0")]
	private Vector3 KDNNBPHCLMP()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class PEHGOAONLBB
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6229060", Offset = "0x6228460", VA = "0x186229060")]
	public static FALDGKMDLPM CIHOGPFKJEE(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class MGNJLOFPDJK : POFDCKNGGND, DGFNAOONHOB
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x62246B0", Offset = "0x6223AB0", VA = "0x1862246B0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6227650", Offset = "0x6226A50", VA = "0x186227650", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 HCBJNHMFJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6224D50", Offset = "0x6224150", VA = "0x186224D50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 ENHKKJIPOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x62253D0", Offset = "0x62247D0", VA = "0x1862253D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6225250", Offset = "0x6224650", VA = "0x186225250", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6224A90", Offset = "0x6223E90", VA = "0x186224A90", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float IIDMNGOFFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6227150", Offset = "0x6226550", VA = "0x186227150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x62271E0", Offset = "0x62265E0", VA = "0x1862271E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6224B10", Offset = "0x6223F10", VA = "0x186224B10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6224EA0", Offset = "0x62242A0", VA = "0x186224EA0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6226CE0", Offset = "0x62260E0", VA = "0x186226CE0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event PMCONJLJKAF LIEDCPDMCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6226820", Offset = "0x6225C20", VA = "0x186226820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6226C40", Offset = "0x6226040", VA = "0x186226C40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6227940", Offset = "0x6226D40", VA = "0x186227940")]
	public MGNJLOFPDJK(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6224BA0", Offset = "0x6223FA0", VA = "0x186224BA0")]
	public float3 EIDAGDFDJAP()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6224800", Offset = "0x6223C00", VA = "0x186224800", Slot = "14")]
	public void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6227260", Offset = "0x6226660", VA = "0x186227260", Slot = "16")]
	public void OFLNNNMBNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6226D10", Offset = "0x6226110", VA = "0x186226D10", Slot = "15")]
	public void LPJNFIDCMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6224C60", Offset = "0x6224060", VA = "0x186224C60", Slot = "18")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6224ED0", Offset = "0x62242D0", VA = "0x186224ED0", Slot = "19")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6226B40", Offset = "0x6225F40", VA = "0x186226B40", Slot = "17")]
	public void LEIHBCILENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6223F40", Offset = "0x6223340", VA = "0x186223F40", Slot = "20")]
	public void AAJPKADPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x62184F0", Offset = "0x62178F0", VA = "0x1862184F0")]
	public void BBBACKNNFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x62274F0", Offset = "0x62268F0", VA = "0x1862274F0")]
	private void OHJHFPDAKLO(Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x62277B0", Offset = "0x6226BB0", VA = "0x1862277B0")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 PEBKHMCIEEN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6224B10", Offset = "0x6223F10", VA = "0x186224B10")]
	private void KFIOKECDAJF(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x62268C0", Offset = "0x6225CC0", VA = "0x1862268C0")]
	private Vector3 LCHKCIJIEGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6224450", Offset = "0x6223850", VA = "0x186224450")]
	private Quaternion ACIPCJJICFM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6225520", Offset = "0x6224920", VA = "0x186225520")]
	internal (float, Vector3) KIPNPCMDEBA(Rigidbody EPFPIOBMADK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class OGLLCDBFNPG
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6228FD0", Offset = "0x62283D0", VA = "0x186228FD0")]
	public static MGNJLOFPDJK OPEEMKANHBN(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NILIGODAPOL : POFDCKNGGND, GBCIKCKFFKI
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool FJCPAHCHKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6228360", Offset = "0x6227760", VA = "0x186228360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JJDKBJICEBO EKCJMLNNFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6228020", Offset = "0x6227420", VA = "0x186228020", Slot = "11")]
		get
		{
			return default(JJDKBJICEBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private JJDKBJICEBO AENGEJLJHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6228180", Offset = "0x6227580", VA = "0x186228180")]
		get
		{
			return default(JJDKBJICEBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x62287A0", Offset = "0x6227BA0", VA = "0x1862287A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x62288A0", Offset = "0x6227CA0", VA = "0x1862288A0")]
	public NILIGODAPOL(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6227E00", Offset = "0x6227200", VA = "0x186227E00", Slot = "4")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6228280", Offset = "0x6227680", VA = "0x186228280")]
	private bool HEABJHFMJBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6228680", Offset = "0x6227A80", VA = "0x186228680", Slot = "5")]
	public void OCPJADHNMFM(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6227F00", Offset = "0x6227300", VA = "0x186227F00", Slot = "6")]
	public void DHDDDHOJGFI(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6228560", Offset = "0x6227960", VA = "0x186228560", Slot = "9")]
	public void NBFEPACHMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6228460", Offset = "0x6227860", VA = "0x186228460")]
	private void MGJKGPLPPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6228030", Offset = "0x6227430", VA = "0x186228030")]
	private void FGGDBKOLNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6228320", Offset = "0x6227720", VA = "0x186228320", Slot = "8")]
	public void LAFDPFGOKEP(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6227EC0", Offset = "0x62272C0", VA = "0x186227EC0", Slot = "7")]
	public void DBFKNOMKGHF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class IAOJFAHHNBC : POFDCKNGGND, JDJGAANDNAK
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6218340", Offset = "0x6217740", VA = "0x186218340", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool LGGKOOEPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6218540", Offset = "0x6217940", VA = "0x186218540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event PMCONJLJKAF DHPCHJAECNM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6218450", Offset = "0x6217850", VA = "0x186218450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x62186B0", Offset = "0x6217AB0", VA = "0x1862186B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public IAOJFAHHNBC(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6218640", Offset = "0x6217A40", VA = "0x186218640", Slot = "11")]
	public IDisposable MNNNBPBFADH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6218440", Offset = "0x6217840", VA = "0x186218440", Slot = "8")]
	public void HJPCEBAPFBJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6218530", Offset = "0x6217930", VA = "0x186218530", Slot = "9")]
	public void KDJJIFBHOFL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6217DE0", Offset = "0x62171E0", VA = "0x186217DE0", Slot = "10")]
	public void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6217F00", Offset = "0x6217300", VA = "0x186217F00", Slot = "12")]
	public void FMMCIHKJEPH(Rigidbody DKNAEDLPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6218120", Offset = "0x6217520", VA = "0x186218120", Slot = "13")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x62184F0", Offset = "0x62178F0", VA = "0x1862184F0", Slot = "6")]
	public void JLPPHDBFFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EAIKIBMAPPB : POFDCKNGGND, BPKEOJMBMPD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private PhotonView APLHABDFFFG;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x620AB70", Offset = "0x6209F70", VA = "0x18620AB70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x620B180", Offset = "0x620A580", VA = "0x18620B180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event PMCONJLJKAF IKMFGIMECGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x620B0E0", Offset = "0x620A4E0", VA = "0x18620B0E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x620B2D0", Offset = "0x620A6D0", VA = "0x18620B2D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x620B910", Offset = "0x620AD10", VA = "0x18620B910")]
	public EAIKIBMAPPB(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x620AA40", Offset = "0x6209E40", VA = "0x18620AA40", Slot = "8")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x620ACE0", Offset = "0x620A0E0", VA = "0x18620ACE0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x620AEE0", Offset = "0x620A2E0", VA = "0x18620AEE0", Slot = "9")]
	public void EKKEPIJLGEJ(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x620B370", Offset = "0x620A770", VA = "0x18620B370", Slot = "10")]
	public void KEHBPCICNNE(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x620B570", Offset = "0x620A970", VA = "0x18620B570")]
	private void ODHNNFLJECM(PhotonView MGCBDBBHGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x620AB90", Offset = "0x6209F90", VA = "0x18620AB90")]
	private void DLGCIJCKFEP(RigidbodyEx NDCAIADKCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x620B750", Offset = "0x620AB50", VA = "0x18620B750")]
	private void OKJKLDPJGEC(PhotonView IOHDNDILODD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class MMKMCKOLFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6227C60", Offset = "0x6227060", VA = "0x186227C60")]
	public static EAIKIBMAPPB JNJLHAFPLCI(this EOANOGBMDEJ GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class JKIABEKJBNK : POFDCKNGGND, JMDONDDNJFG
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x621D920", Offset = "0x621CD20", VA = "0x18621D920", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x621D3E0", Offset = "0x621C7E0", VA = "0x18621D3E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool ADEAMDCGMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x621DB20", Offset = "0x621CF20", VA = "0x18621DB20", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x621DA20", Offset = "0x621CE20", VA = "0x18621DA20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints BLHDCKAAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x621DC20", Offset = "0x621D020", VA = "0x18621DC20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x621D4E0", Offset = "0x621C8E0", VA = "0x18621D4E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x621DD20", Offset = "0x621D120", VA = "0x18621DD20")]
	public JKIABEKJBNK(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x621D6F0", Offset = "0x621CAF0", VA = "0x18621D6F0", Slot = "9")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x621D810", Offset = "0x621CC10", VA = "0x18621D810", Slot = "10")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class FNBPPGKBPMI : POFDCKNGGND, OCHDBEMEHEI
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6213A50", Offset = "0x6212E50", VA = "0x186213A50", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x62138E0", Offset = "0x6212CE0", VA = "0x1862138E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float NDFOPAPAENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6213860", Offset = "0x6212C60", VA = "0x186213860", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6213500", Offset = "0x6212900", VA = "0x186213500", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public FNBPPGKBPMI(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6213670", Offset = "0x6212A70", VA = "0x186213670", Slot = "8")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6213790", Offset = "0x6212B90", VA = "0x186213790", Slot = "9")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[FHOIBFDAOOA(typeof(FEGCGGPGJLI), new string[] { })]
public sealed class JAOKKJJMLOH : ENDDIKHKCDF, FEGCGGPGJLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[DMNKPOGEHOO]
	private CAMBFJGGDMI IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6219BE0", Offset = "0x6218FE0", VA = "0x186219BE0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6219BB0", Offset = "0x6218FB0", VA = "0x186219BB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6219C30", Offset = "0x6219030", VA = "0x186219C30", Slot = "6")]
	public void KIPNPCMDEBA(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6219910", Offset = "0x6218D10", VA = "0x186219910", Slot = "7")]
	public void CCLCIBPDLJB(CAKFEHOBCAO AJAFIOGCMHP, bool KFEKGACJEDO, bool PAEBLLNNODM, bool MCHEPAJCBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6219F50", Offset = "0x6219350", VA = "0x186219F50")]
	private bool OECNDGINHEA(CAKFEHOBCAO AJAFIOGCMHP, [Out] HENGAEMDJAC GHADCFDOJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6219DD0", Offset = "0x62191D0", VA = "0x186219DD0")]
	private bool NBDECNBOGFO(CAKFEHOBCAO AJAFIOGCMHP, [Out] MGNJLOFPDJK LNMAICEEABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JAOKKJJMLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IPAIMNJBEAG : POFDCKNGGND, PGKIONLPONA
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool KABOLKIFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6207000", Offset = "0x6206400", VA = "0x186207000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6218DD0", Offset = "0x62181D0", VA = "0x186218DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6218FD0", Offset = "0x62183D0", VA = "0x186218FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NHCCLAMBICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x62195B0", Offset = "0x62189B0", VA = "0x1862195B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x62193B0", Offset = "0x62187B0", VA = "0x1862193B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool DLLJDCCJAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6218E30", Offset = "0x6218230", VA = "0x186218E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x62194B0", Offset = "0x62188B0", VA = "0x1862194B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int BFBBBOFLKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6218CC0", Offset = "0x62180C0", VA = "0x186218CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event PMCONJLJKAF KGNMFBHFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6218F30", Offset = "0x6218330", VA = "0x186218F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x62191B0", Offset = "0x62185B0", VA = "0x1862191B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x62196B0", Offset = "0x6218AB0", VA = "0x1862196B0")]
	public IPAIMNJBEAG(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x62189D0", Offset = "0x6217DD0", VA = "0x1862189D0", Slot = "6")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6218DC0", Offset = "0x62181C0", VA = "0x186218DC0", Slot = "8")]
	public void FHPLEHOKMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6218A80", Offset = "0x6217E80", VA = "0x186218A80", Slot = "7")]
	public bool CMEBIIDAOAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6219300", Offset = "0x6218700", VA = "0x186219300", Slot = "9")]
	public void MKJFDFJNGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x62184F0", Offset = "0x62178F0", VA = "0x1862184F0", Slot = "12")]
	public void HLGOLFFLAAE(bool FGLLJKDIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6219250", Offset = "0x6218650", VA = "0x186219250", Slot = "11")]
	public void MHEDIHKEEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "10")]
	public void MHAAACLBCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6219030", Offset = "0x6218430", VA = "0x186219030")]
	private void LDEDJNNAIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class DNIIPMPKHMF : POFDCKNGGND, LPGJCAAOFBM
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6209DA0", Offset = "0x62091A0", VA = "0x186209DA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6209CA0", Offset = "0x62090A0", VA = "0x186209CA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6209BF0", Offset = "0x6208FF0", VA = "0x186209BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool EEOGKHKKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x620A120", Offset = "0x6209520", VA = "0x18620A120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x620A980", Offset = "0x6209D80", VA = "0x18620A980")]
	public DNIIPMPKHMF(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x620A070", Offset = "0x6209470", VA = "0x18620A070", Slot = "5")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x620A860", Offset = "0x6209C60", VA = "0x18620A860", Slot = "7")]
	public void ONCMECCPFEJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x620A4E0", Offset = "0x62098E0", VA = "0x18620A4E0", Slot = "8")]
	public void GGEHJOCGMEA(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x620A220", Offset = "0x6209620", VA = "0x18620A220", Slot = "9")]
	public void DOIOJAMPJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x620A600", Offset = "0x6209A00", VA = "0x18620A600", Slot = "11")]
	public void INCHGFAPDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6209EA0", Offset = "0x62092A0", VA = "0x186209EA0", Slot = "12")]
	public void BBCHOEDJAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "10")]
	public void LBJGLANLFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class BJINEGBMDDH : POFDCKNGGND, IPKLFIKKFCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6204550", Offset = "0x6203950", VA = "0x186204550", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x62058B0", Offset = "0x6204CB0", VA = "0x1862058B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x62059B0", Offset = "0x6204DB0", VA = "0x1862059B0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6207020", Offset = "0x6206420", VA = "0x186207020", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6205F10", Offset = "0x6205310", VA = "0x186205F10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6205BB0", Offset = "0x6204FB0", VA = "0x186205BB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6203970", Offset = "0x6202D70", VA = "0x186203970", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x62050A0", Offset = "0x62044A0", VA = "0x1862050A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6204040", Offset = "0x6203440", VA = "0x186204040", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6205AF0", Offset = "0x6204EF0", VA = "0x186205AF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6204270", Offset = "0x6203670", VA = "0x186204270", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6203A00", Offset = "0x6202E00", VA = "0x186203A00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6206920", Offset = "0x6205D20", VA = "0x186206920", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6204940", Offset = "0x6203D40", VA = "0x186204940", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x62050D0", Offset = "0x62044D0", VA = "0x1862050D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private ANHMPPFHALM DNMCOEPCMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x1C09730", Offset = "0x1C08B30", VA = "0x181C09730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool KABOLKIFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6207000", Offset = "0x6206400", VA = "0x186207000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public BJINEGBMDDH(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x62043F0", Offset = "0x62037F0", VA = "0x1862043F0", Slot = "20")]
	public void EIJLCDDNEMP(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x62057B0", Offset = "0x6204BB0", VA = "0x1862057B0", Slot = "30")]
	public void GJIAPMEOHIB(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x62038C0", Offset = "0x6202CC0", VA = "0x1862038C0", Slot = "19")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x62042A0", Offset = "0x62036A0", VA = "0x1862042A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x62051D0", Offset = "0x62045D0", VA = "0x1862051D0", Slot = "28")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6204AB0", Offset = "0x6203EB0", VA = "0x186204AB0", Slot = "35")]
	public Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6206760", Offset = "0x6205B60", VA = "0x186206760", Slot = "34")]
	public Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x62038C0", Offset = "0x6202CC0", VA = "0x1862038C0", Slot = "27")]
	public void GBFHHDNOOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6206B70", Offset = "0x6205F70", VA = "0x186206B70", Slot = "25")]
	public void MAHIALLIPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x62039A0", Offset = "0x6202DA0", VA = "0x1862039A0", Slot = "24")]
	public void CPBMGFONLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6205F70", Offset = "0x6205370", VA = "0x186205F70", Slot = "33")]
	public void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x62037B0", Offset = "0x6202BB0", VA = "0x1862037B0", Slot = "32")]
	public void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x62040A0", Offset = "0x62034A0", VA = "0x1862040A0", Slot = "31")]
	public void DLAFCKDHKCN(Vector3 AOPGBEBGNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6205350", Offset = "0x6204750", VA = "0x186205350", Slot = "22")]
	public void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6204690", Offset = "0x6203A90", VA = "0x186204690", Slot = "21")]
	public void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6204C90", Offset = "0x6204090", VA = "0x186204C90", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6207120", Offset = "0x6206520", VA = "0x186207120", Slot = "29")]
	public Vector3 PLDHOGBBINH(Vector3 FJGOAHOCDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6206E70", Offset = "0x6206270", VA = "0x186206E70", Slot = "26")]
	public void NFCAFMPGPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6204940", Offset = "0x6203D40", VA = "0x186204940")]
	private void GBALDBDDJEH(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x62069A0", Offset = "0x6205DA0", VA = "0x1862069A0")]
	private void KDFBAPMJKLP(Vector3 HPBPOMBLEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6205C70", Offset = "0x6205070", VA = "0x186205C70")]
	private Vector3 IGEGDLCMPHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x62031A0", Offset = "0x62025A0", VA = "0x1862031A0")]
	private void AFDBOMNAJCG(Vector3 NAFPPHMNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6206BD0", Offset = "0x6205FD0", VA = "0x186206BD0")]
	private Vector3 MKKPBKHJMGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6203A30", Offset = "0x6202E30", VA = "0x186203A30")]
	private void DILDIMIEHHP(Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6203140", Offset = "0x6202540", VA = "0x186203140")]
	private void AAPEJBNKJLG(Vector3 FJGOAHOCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x62044F0", Offset = "0x62038F0", VA = "0x1862044F0")]
	private void EIKBHGDDCHJ(Vector3 DPKJDPPAHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x62061B0", Offset = "0x62055B0", VA = "0x1862061B0")]
	private void JHKCDGJPLDB(string GBDJONFNPDL, Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6203810", Offset = "0x6202C10", VA = "0x186203810")]
	private void BCIEKGEDGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class POFDCKNGGND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly HENGAEMDJAC IJNDFBIKOFO;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected CAMBFJGGDMI HCOEPPMFPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5E488B0", Offset = "0x5E47CB0", VA = "0x185E488B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected CAKFEHOBCAO DBJNLKBFEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x6229F80", Offset = "0x6229380", VA = "0x186229F80")]
		get
		{
			return default(CAKFEHOBCAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6207200", Offset = "0x6206600", VA = "0x186207200")]
	public POFDCKNGGND(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6229E50", Offset = "0x6229250", VA = "0x186229E50")]
	protected PFJEEEPJDGP BMMACONHLJH(CAKFEHOBCAO PCOAABDKEED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DCAIHAAIIKF : FFAOLLBCFPK
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6208D20", Offset = "0x6208120", VA = "0x186208D20", Slot = "4")]
	public NOEECIOLHEN PELIFCCNONF(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6208750", Offset = "0x6207B50", VA = "0x186208750", Slot = "5")]
	public IPKLFIKKFCE IHCJAENGEDO(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6208A60", Offset = "0x6207E60", VA = "0x186208A60", Slot = "6")]
	public ODIHKLIFNOG NNDALAGHOAI(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6208670", Offset = "0x6207A70", VA = "0x186208670", Slot = "7")]
	public OCHDBEMEHEI HPAOOEFHCIB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6208610", Offset = "0x6207A10", VA = "0x186208610", Slot = "8")]
	public PGKIONLPONA EGMCPADIDOB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6208530", Offset = "0x6207930", VA = "0x186208530", Slot = "9")]
	public MMEPBAGLDDK EFEHFJDHPPD(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6208450", Offset = "0x6207850", VA = "0x186208450", Slot = "10")]
	public JDJGAANDNAK DKDLIFGIELC(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x62088A0", Offset = "0x6207CA0", VA = "0x1862088A0", Slot = "11")]
	public ANHMPPFHALM KOLMNJNLEBB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6208B40", Offset = "0x6207F40", VA = "0x186208B40", Slot = "12")]
	public PLNHLNJNAPH ODGOHJEPPAE(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6208980", Offset = "0x6207D80", VA = "0x186208980", Slot = "13")]
	public HJMBGHGIKPG NBFMOKKBOJG(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x62081B0", Offset = "0x62075B0", VA = "0x1862081B0")]
	public LPGJCAAOFBM PJHIPFEABPB(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6208C20", Offset = "0x6208020", VA = "0x186208C20")]
	public BPKEOJMBMPD OLAJCLOGCGL(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6208830", Offset = "0x6207C30", VA = "0x186208830")]
	public GBCIKCKFFKI KFBCOGCOGAH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6208140", Offset = "0x6207540", VA = "0x186208140")]
	public DGFNAOONHOB ABLCJEKFDPK(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x62083E0", Offset = "0x62077E0", VA = "0x1862083E0")]
	public JMDONDDNJFG DBGKIODADJF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x62082B0", Offset = "0x62076B0", VA = "0x1862082B0", Slot = "19")]
	public PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD, OAFLAKLOLEE CCJFCCENPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DCAIHAAIIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x62081B0", Offset = "0x62075B0", VA = "0x1862081B0", Slot = "14")]
	private LPGJCAAOFBM BPNBHIOCCPH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6208C20", Offset = "0x6208020", VA = "0x186208C20", Slot = "15")]
	private BPKEOJMBMPD OPJGHCLPHPD(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6208830", Offset = "0x6207C30", VA = "0x186208830", Slot = "16")]
	private GBCIKCKFFKI NKCJMDCJDEF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6208140", Offset = "0x6207540", VA = "0x186208140", Slot = "17")]
	private DGFNAOONHOB CDKNIGFKKHE(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x62083E0", Offset = "0x62077E0", VA = "0x1862083E0", Slot = "18")]
	private JMDONDDNJFG EAKBOJJFODA(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class CHDPJJEDBHH : IReadOnlyList<PFJEEEPJDGP>, IEnumerable<PFJEEEPJDGP>, IEnumerable, IReadOnlyCollection<PFJEEEPJDGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly CAMBFJGGDMI CDNLGICPHJL;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6207DA0", Offset = "0x62071A0", VA = "0x186207DA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public PFJEEEPJDGP ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6207E90", Offset = "0x6207290", VA = "0x186207E90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6207D50", Offset = "0x6207150", VA = "0x186207D50")]
	public CHDPJJEDBHH(CAKFEHOBCAO PCOAABDKEED, CAMBFJGGDMI CDNLGICPHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6207BB0", Offset = "0x6206FB0", VA = "0x186207BB0", Slot = "6")]
	public IEnumerator<PFJEEEPJDGP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6207BB0", Offset = "0x6206FB0", VA = "0x186207BB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6207D40", Offset = "0x6207140", VA = "0x186207D40")]
	[CompilerGenerated]
	private PFJEEEPJDGP OMHHAFAACBM(int PBOOCHALMNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[FHOIBFDAOOA(typeof(FFAOLLBCFPK), new string[] { })]
public class FDBKCPNIFDF : FFAOLLBCFPK, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FFAOLLBCFPK OACOKMDNNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FFAOLLBCFPK AKMKBNFOGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private EOAILPGBNIC MHGHDIECJPA;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private FFAOLLBCFPK CNGKDKPPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x62132C0", Offset = "0x62126C0", VA = "0x1862132C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6212E90", Offset = "0x6212290", VA = "0x186212E90", Slot = "20")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6213320", Offset = "0x6212720", VA = "0x186213320", Slot = "4")]
	public NOEECIOLHEN PELIFCCNONF(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6212DF0", Offset = "0x62121F0", VA = "0x186212DF0", Slot = "5")]
	public IPKLFIKKFCE IHCJAENGEDO(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x62130D0", Offset = "0x62124D0", VA = "0x1862130D0", Slot = "6")]
	public ODIHKLIFNOG NNDALAGHOAI(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6212D50", Offset = "0x6212150", VA = "0x186212D50", Slot = "7")]
	public OCHDBEMEHEI HPAOOEFHCIB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6212CB0", Offset = "0x62120B0", VA = "0x186212CB0", Slot = "8")]
	public PGKIONLPONA EGMCPADIDOB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6212C10", Offset = "0x6212010", VA = "0x186212C10", Slot = "9")]
	public MMEPBAGLDDK EFEHFJDHPPD(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6212B70", Offset = "0x6211F70", VA = "0x186212B70", Slot = "10")]
	public JDJGAANDNAK DKDLIFGIELC(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6212F90", Offset = "0x6212390", VA = "0x186212F90", Slot = "11")]
	public ANHMPPFHALM KOLMNJNLEBB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6213170", Offset = "0x6212570", VA = "0x186213170", Slot = "12")]
	public PLNHLNJNAPH ODGOHJEPPAE(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6213030", Offset = "0x6212430", VA = "0x186213030", Slot = "13")]
	public HJMBGHGIKPG NBFMOKKBOJG(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6212920", Offset = "0x6211D20", VA = "0x186212920")]
	public LPGJCAAOFBM PJHIPFEABPB(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6213210", Offset = "0x6212610", VA = "0x186213210")]
	public BPKEOJMBMPD OLAJCLOGCGL(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6212EE0", Offset = "0x62122E0", VA = "0x186212EE0")]
	public GBCIKCKFFKI KFBCOGCOGAH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6212870", Offset = "0x6211C70", VA = "0x186212870")]
	public DGFNAOONHOB ABLCJEKFDPK(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6212AC0", Offset = "0x6211EC0", VA = "0x186212AC0")]
	public JMDONDDNJFG DBGKIODADJF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x62129D0", Offset = "0x6211DD0", VA = "0x1862129D0", Slot = "19")]
	public PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD, OAFLAKLOLEE CCJFCCENPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x62133C0", Offset = "0x62127C0", VA = "0x1862133C0")]
	public FDBKCPNIFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6212920", Offset = "0x6211D20", VA = "0x186212920", Slot = "14")]
	private LPGJCAAOFBM BPNBHIOCCPH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6213210", Offset = "0x6212610", VA = "0x186213210", Slot = "15")]
	private BPKEOJMBMPD OPJGHCLPHPD(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6212EE0", Offset = "0x62122E0", VA = "0x186212EE0", Slot = "16")]
	private GBCIKCKFFKI NKCJMDCJDEF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6212870", Offset = "0x6211C70", VA = "0x186212870", Slot = "17")]
	private DGFNAOONHOB CDKNIGFKKHE(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6212AC0", Offset = "0x6211EC0", VA = "0x186212AC0", Slot = "18")]
	private JMDONDDNJFG EAKBOJJFODA(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class HCBCJPOHMDE : PFJEEEPJDGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly HCBCJPOHMDE OMCMBELJBID;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx AKEFGKJCKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject EHDJFHDMAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x76A450", Offset = "0x769850", VA = "0x18076A450", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x830C60", Offset = "0x830060", VA = "0x180830C60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xC74220", Offset = "0xC73620", VA = "0x180C74220", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x766620", Offset = "0x765A20", VA = "0x180766620", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x766630", Offset = "0x765A30", VA = "0x180766630", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x766610", Offset = "0x765A10", VA = "0x180766610", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7665E0", Offset = "0x7659E0", VA = "0x1807665E0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8EC080", Offset = "0x8EB480", VA = "0x1808EC080", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CF93B0", Offset = "0x3CF87B0", VA = "0x183CF93B0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x19BF560", Offset = "0x19BE960", VA = "0x1819BF560", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x34CE540", Offset = "0x34CD940", VA = "0x1834CE540", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6216E30", Offset = "0x6216230", VA = "0x186216E30", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x6216E20", Offset = "0x6216220", VA = "0x186216E20", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CA37D0", Offset = "0x3CA2BD0", VA = "0x183CA37D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x18F7610", Offset = "0x18F6A10", VA = "0x1818F7610", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool OJINFGPFAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x84CED0", Offset = "0x84C2D0", VA = "0x18084CED0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool BOOOIHMBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xC25370", Offset = "0xC24770", VA = "0x180C25370", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xC25380", Offset = "0xC24780", VA = "0x180C25380", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA220", Offset = "0x3CA9620", VA = "0x183CAA220", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8D7400", Offset = "0x8D6800", VA = "0x1808D7400", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6216E50", Offset = "0x6216250", VA = "0x186216E50", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5336E20", Offset = "0x5336220", VA = "0x185336E20", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4720", Offset = "0x7B3B20", VA = "0x1807B4720", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float NDFOPAPAENH
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AAKPEJBHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "48")]
		get
		{
			return default(LHMMHIJEJEH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10AB0C0", Offset = "0x10AA4C0", VA = "0x1810AB0C0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform IACBPIMLAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x89BB30", Offset = "0x89AF30", VA = "0x18089BB30", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 JIOHNMPCCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float COMHGNIDJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float BLFDJHCMPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A50", Offset = "0x7B5E50", VA = "0x1807B6A50", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion PJDLILOOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x89E2C0", Offset = "0x89D6C0", VA = "0x18089E2C0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 MBLHMGPEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion JFMPNIDBDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x89E2C0", Offset = "0x89D6C0", VA = "0x18089E2C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints BLHDCKAAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode HCGNOFKHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool GKFHHGKNGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x44FAF80", Offset = "0x44FA380", VA = "0x1844FAF80", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event PMCONJLJKAF KDHBNMBFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event PMCONJLJKAF PFMLPJOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event LHINAAIEKGL KOAAHFFMJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event PMCONJLJKAF IKMFGIMECGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event PMCONJLJKAF OAKOCGEHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event PMCONJLJKAF KGNMFBHFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event PMCONJLJKAF DHPCHJAECNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event PMCONJLJKAF NAFIKMPOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "41")]
	public void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "71")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "72")]
	public void AEJIJDMOINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "73")]
	public void EHHLNCGGKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "74")]
	public void MKJFDFJNGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "81")]
	public void LEKFLKBIABP(PFJEEEPJDGP LPCGJALKADL, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "84")]
	public void OGBHLMOJIPP(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "85")]
	public void HNBKKLMIBMF(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "86")]
	public Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "87")]
	public Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "88")]
	public void GBFHHDNOOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "89")]
	public void MAHIALLIPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "90")]
	public void CPBMGFONLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "91")]
	public void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "92")]
	public void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "93")]
	public void DLAFCKDHKCN(Vector3 AOPGBEBGNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "94")]
	public void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "95")]
	public void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "96")]
	public void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "97")]
	public Vector3 PLDHOGBBINH(Vector3 LPCGJALKADL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA197B0", VA = "0x180A1A3B0", Slot = "98")]
	public Vector3 ADJFDPJHKEM(Vector3 LPCGJALKADL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "99")]
	public void NFCAFMPGPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "100")]
	public void OBAMDECLFGJ(PFJEEEPJDGP LCKOANHNKHA, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "101")]
	public void KHBDKKAOBEE(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "104")]
	public void OFLNNNMBNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "105")]
	public void LPJNFIDCMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "106")]
	public void LEIHBCILENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "109")]
	public bool CMEBIIDAOAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "110")]
	public void MHEDIHKEEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "115")]
	public IDisposable MNNNBPBFADH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "116")]
	public void HJPCEBAPFBJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "117")]
	public void KDJJIFBHOFL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "118")]
	public void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "121")]
	public void LKMEKBMECJN(Vector3 ECHEIMKOBLE, Quaternion JOJJJBDHOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "122")]
	public void NDGHGCGHOCJ(Vector3 FBBLIAHAPDM, Quaternion LIHLHLCNBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "123")]
	public bool FHJOCNLMPFO(float ENADKENACNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "124")]
	public void AFEIDMBALFF(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "125")]
	public void CBGNLKDDIEE(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "126")]
	public void ONCMECCPFEJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "127")]
	public void GGEHJOCGMEA(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "128")]
	public void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "129")]
	public void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "130")]
	public void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "131")]
	public void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6216E70", Offset = "0x6216270", VA = "0x186216E70", Slot = "132")]
	public bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "133")]
	public void AAJPKADPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HCBCJPOHMDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class HENGAEMDJAC : EOANOGBMDEJ, EOMJBFBJHKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal CAKFEHOBCAO PCOAABDKEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal CAMBFJGGDMI LFJFCONPOFF;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6211AD0", Offset = "0x6210ED0", VA = "0x186211AD0")]
	public HENGAEMDJAC(GameObject GHAOKLKOOCA, RigidbodyEx JMHHMLNBHNM, OAFLAKLOLEE CCJFCCENPLD, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6217810", Offset = "0x6216C10", VA = "0x186217810", Slot = "135")]
	protected override void NGMPAIAHNDF(OAFLAKLOLEE CCJFCCENPLD, HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "141")]
	protected override IDisposable NPJPJGAIABA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6216FD0", Offset = "0x62163D0", VA = "0x186216FD0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6217740", Offset = "0x6216B40", VA = "0x186217740", Slot = "142")]
	public void KAKPEMINCNN(OJEJFFJPFHH HDAGINFADOG, OJEJFFJPFHH LFEAEFFENHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6217620", Offset = "0x6216A20", VA = "0x186217620", Slot = "143")]
	public void HIFMKCLBFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6217140", Offset = "0x6216540", VA = "0x186217140", Slot = "144")]
	public void EIEINDCLKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x62176E0", Offset = "0x6216AE0", VA = "0x1862176E0", Slot = "145")]
	public void HLGOLFFLAAE(bool FGLLJKDIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6217200", Offset = "0x6216600", VA = "0x186217200", Slot = "146")]
	public bool FNOEGGCIOLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x62175C0", Offset = "0x62169C0", VA = "0x1862175C0", Slot = "147")]
	public void GHNINHPNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "140")]
	protected override void BBFLNINCIMO(RigidbodyEx JMBKGKDJDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6217390", Offset = "0x6216790", VA = "0x186217390")]
	private void GDBFCELKHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class DNAOKHNLGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6209C50", Offset = "0x6209050", VA = "0x186209C50")]
	public static EOANOGBMDEJ CHMCKBMOFFE(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GBBLCLBLDIH : NOEECIOLHEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFBCIDBKJPK(PFJEEEPJDGP IJNDFBIKOFO);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOJDPHNKIJA(PFJEEEPJDGP IJNDFBIKOFO);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNFBDHEHBMC(PFJEEEPJDGP KMLGOHLFBLF);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPHLAKNCPJL(PFJEEEPJDGP KMLGOHLFBLF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HDEGAEFJLDJ : ODIHKLIFNOG
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	PNEIOIOPGBE<PFJEEEPJDGP> ADCBIDMKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	PFJEEEPJDGP NOKHKNMHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface APKHHAJAMBF : DGFNAOONHOB
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KIPNPCMDEBA(Rigidbody EPFPIOBMADK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MMGDEAAGHMO : BPKEOJMBMPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView GJKMILCDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class JEDDPKMCPMM : PLNHLNJNAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CollisionDetectionMode EKDOOMPMEKM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode HCGNOFKHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x621A630", Offset = "0x6219A30", VA = "0x18621A630", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x621A740", Offset = "0x6219B40", VA = "0x18621A740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6214EB0", Offset = "0x62142B0", VA = "0x186214EB0")]
	public JEDDPKMCPMM(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x621A370", Offset = "0x6219770", VA = "0x18621A370", Slot = "6")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x621A5B0", Offset = "0x62199B0", VA = "0x18621A5B0", Slot = "9")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x621A5A0", Offset = "0x62199A0", VA = "0x18621A5A0", Slot = "7")]
	public void DOEOHIMBGNI(bool EHHAHLLJFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x621A7B0", Offset = "0x6219BB0", VA = "0x18621A7B0", Slot = "8")]
	public void LBNGMIFGCBJ(bool EHHAHLLJFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x621A7C0", Offset = "0x6219BC0", VA = "0x18621A7C0", Slot = "10")]
	public bool NPALNFCENHN(Vector3 DDLNIHBIJPM, [Out] RaycastHit JOIALBEOJFP, float FECAAKMJJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x621A480", Offset = "0x6219880", VA = "0x18621A480")]
	private void DIAJFHMBGGK(bool EHHAHLLJFMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class JHAFKAIANFL : MMEPBAGLDDK, IDisposable, DANNLMHLCBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LHMMHIJEJEH FGAMJHNFCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private ELDMKEBEHNG BHLMANKCPAA;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public LHMMHIJEJEH GHJIOLPCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x621CA00", Offset = "0x621BE00", VA = "0x18621CA00", Slot = "6")]
		get
		{
			return default(LHMMHIJEJEH);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x621CB70", Offset = "0x621BF70", VA = "0x18621CB70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform IMFFJBLPCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x621CB50", Offset = "0x621BF50", VA = "0x18621CB50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<BNKNPIOGGJK, BNKNPIOGGJK> NIJEKONAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x621C900", Offset = "0x621BD00", VA = "0x18621C900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x621CC40", Offset = "0x621C040", VA = "0x18621CC40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x621CCF0", Offset = "0x621C0F0", VA = "0x18621CCF0")]
	public JHAFKAIANFL(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x621C600", Offset = "0x621BA00", VA = "0x18621C600", Slot = "8")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x621C9B0", Offset = "0x621BDB0", VA = "0x18621C9B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1A29D40", Offset = "0x1A29140", VA = "0x181A29D40", Slot = "11")]
	private void LKPNFDOAFML(BNKNPIOGGJK ICFFEKPCFNB, BNKNPIOGGJK EEOPBEIAHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
	private void ANEKPOBONHP(bool IIAFBMLOLMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class GFFELHLAMOM : ANHMPPFHALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x62072A0", Offset = "0x62066A0", VA = "0x1862072A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6209800", Offset = "0x6208C00", VA = "0x186209800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6209BF0", Offset = "0x6208FF0", VA = "0x186209BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6214E50", Offset = "0x6214250", VA = "0x186214E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6214EB0", Offset = "0x62142B0", VA = "0x186214EB0")]
	public GFFELHLAMOM(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6214A90", Offset = "0x6213E90", VA = "0x186214A90", Slot = "4")]
	public void FDCCKIAIHHC(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6214830", Offset = "0x6213C30", VA = "0x186214830")]
	private void ENKBMOKHLFN(Vector3 EAJNNLJOPDA, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x62141F0", Offset = "0x62135F0", VA = "0x1862141F0", Slot = "5")]
	public void AEELKOJHEEE(Vector3 EAJNNLJOPDA, Vector3 BAONBICGOEJ, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x62146D0", Offset = "0x6213AD0", VA = "0x1862146D0", Slot = "6")]
	public void ECCKJNKEFII(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6214BF0", Offset = "0x6213FF0", VA = "0x186214BF0")]
	private void HIPPAHGCKDA(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6214470", Offset = "0x6213870", VA = "0x186214470", Slot = "7")]
	public void AILADAHMDIF(Vector3 PEJEIKINFHM, ForceMode PGHEPFONFFH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class NHEKJMNOJNP : HJMBGHGIKPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool PPBPEDEMDON;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool AAKPEJBHDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6227CF0", Offset = "0x62270F0", VA = "0x186227CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6214EB0", Offset = "0x62142B0", VA = "0x186214EB0")]
	public NHEKJMNOJNP(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6227CC0", Offset = "0x62270C0", VA = "0x186227CC0", Slot = "6")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6220A90", Offset = "0x621FE90", VA = "0x186220A90", Slot = "7")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class HANIJFEDLDF : GBBLCLBLDIH, NOEECIOLHEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PFJEEEPJDGP IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<PFJEEEPJDGP> FEGECHNBDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private PFJEEEPJDGP JMNDOLBKAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private PFJEEEPJDGP DCLCDDGJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Transform NMIPBBMBNDJ;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform LGIAJFCOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x62160A0", Offset = "0x62154A0", VA = "0x1862160A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6216900", Offset = "0x6215D00", VA = "0x186216900", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public PFJEEEPJDGP BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<PFJEEEPJDGP> KDGLBPOIBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event PMCONJLJKAF KDHBNMBFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x62156F0", Offset = "0x6214AF0", VA = "0x1862156F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x6215150", Offset = "0x6214550", VA = "0x186215150", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event PMCONJLJKAF PFMLPJOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x6214F80", Offset = "0x6214380", VA = "0x186214F80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6215290", Offset = "0x6214690", VA = "0x186215290", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event LHINAAIEKGL KOAAHFFMJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6216C20", Offset = "0x6216020", VA = "0x186216C20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6216860", Offset = "0x6215C60", VA = "0x186216860", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action OAJPGHELLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6216720", Offset = "0x6215B20", VA = "0x186216720", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6216910", Offset = "0x6215D10", VA = "0x186216910", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action GEHMKMKFPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x62155B0", Offset = "0x62149B0", VA = "0x1862155B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x62167C0", Offset = "0x6215BC0", VA = "0x1862167C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<PFJEEEPJDGP> GLEJGCBGAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x62159C0", Offset = "0x6214DC0", VA = "0x1862159C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6215D70", Offset = "0x6215170", VA = "0x186215D70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<PFJEEEPJDGP> OKJGFMAKPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6215E20", Offset = "0x6215220", VA = "0x186215E20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6215C10", Offset = "0x6215010", VA = "0x186215C10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action GAJNENDJJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6216000", Offset = "0x6215400", VA = "0x186216000", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6216CC0", Offset = "0x62160C0", VA = "0x186216CC0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PFJEEEPJDGP> FCLMOBNLDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6215CC0", Offset = "0x62150C0", VA = "0x186215CC0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6215B60", Offset = "0x6214F60", VA = "0x186215B60", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6216D60", Offset = "0x6216160", VA = "0x186216D60")]
	public HANIJFEDLDF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6215650", Offset = "0x6214A50", VA = "0x186215650", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x62161A0", Offset = "0x62155A0", VA = "0x1862161A0", Slot = "30")]
	public void LEKFLKBIABP(PFJEEEPJDGP KJOCICNOINI, bool OEHGICEAIOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x62169B0", Offset = "0x6215DB0", VA = "0x1862169B0", Slot = "6")]
	public void NNFBDHEHBMC(PFJEEEPJDGP KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6215330", Offset = "0x6214730", VA = "0x186215330", Slot = "7")]
	public void CPHLAKNCPJL(PFJEEEPJDGP KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6215790", Offset = "0x6214B90", VA = "0x186215790", Slot = "4")]
	public void FFBCIDBKJPK(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x62151F0", Offset = "0x62145F0", VA = "0x1862151F0", Slot = "5")]
	public void BOJDPHNKIJA(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6216100", Offset = "0x6215500", VA = "0x186216100")]
	private void JDMOOKCGIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6214F40", Offset = "0x6214340", VA = "0x186214F40")]
	private void ADIKJJDDBPK(PFJEEEPJDGP KMLGOHLFBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6215880", Offset = "0x6214C80", VA = "0x186215880")]
	private void FHODKCMBMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6215ED0", Offset = "0x62152D0", VA = "0x186215ED0")]
	private void IJABMCFNKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6215020", Offset = "0x6214420", VA = "0x186215020")]
	private void BACGPPFBPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6215A70", Offset = "0x6214E70", VA = "0x186215A70")]
	[CompilerGenerated]
	private object FJDGLOIGLNE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class JIOJBLIEJPI
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x621CD80", Offset = "0x621C180", VA = "0x18621CD80")]
	public static GBBLCLBLDIH EFBMJCLPBLE(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class PKFBEHPMMOI : HDEGAEFJLDJ, ODIHKLIFNOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PNEIOIOPGBE<PFJEEEPJDGP> FFOMLJNOJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool FMFGKBMINKA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public PNEIOIOPGBE<PFJEEEPJDGP> ADCBIDMKLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 HJNGJPJMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6229310", Offset = "0x6228710", VA = "0x186229310", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 DOMECHKNPED
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6229150", Offset = "0x6228550", VA = "0x186229150", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6229340", Offset = "0x6228740", VA = "0x186229340")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public PFJEEEPJDGP NOKHKNMHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x62297C0", Offset = "0x6228BC0", VA = "0x1862297C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6229C70", Offset = "0x6229070", VA = "0x186229C70")]
	public PKFBEHPMMOI(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6229870", Offset = "0x6228C70", VA = "0x186229870", Slot = "8")]
	public void MFMGAPGHCBO(PFJEEEPJDGP DCLCDDGJKIC, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x62290F0", Offset = "0x62284F0", VA = "0x1862290F0", Slot = "9")]
	public void APOFALCIKGL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6229430", Offset = "0x6228830", VA = "0x186229430")]
	private Vector3 KDNNBPHCLMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x62298E0", Offset = "0x6228CE0", VA = "0x1862298E0")]
	private void OLMLCDBBFME(PFJEEEPJDGP AJGMJPDOJOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class CJMAKPCLCLH
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6208080", Offset = "0x6207480", VA = "0x186208080")]
	public static HDEGAEFJLDJ CIHOGPFKJEE(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class LFLANMNOJDB : APKHHAJAMBF, DGFNAOONHOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OverridableVector3 NDJPHAMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 JFEDIJMIENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private float AFDMNIGHMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float ICKLDLHGKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Vector3 IKACIEDNCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3? NALIPBLIBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Quaternion? BABMFLFEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool OELIKCNDLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool ANEAPJBALFB;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 ANIMKKMCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xF45FF0", Offset = "0xF453F0", VA = "0x180F45FF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6221D00", Offset = "0x6221100", VA = "0x186221D00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 JOPLFKJOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x6221AF0", Offset = "0x6220EF0", VA = "0x186221AF0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float GHCLDOJNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1004120", Offset = "0x1003520", VA = "0x181004120", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6221BF0", Offset = "0x6220FF0", VA = "0x186221BF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float EHPFAAAHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB2060", Offset = "0xAB1460", VA = "0x180AB2060", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x6221540", Offset = "0x6220940", VA = "0x186221540", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 FJLJMBMIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x62216D0", Offset = "0x6220AD0", VA = "0x1862216D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion IBOGPKJFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6223220", Offset = "0x6222620", VA = "0x186223220", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x6202530", Offset = "0x6201930", VA = "0x186202530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event PMCONJLJKAF LIEDCPDMCPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6222DD0", Offset = "0x62221D0", VA = "0x186222DD0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6223180", Offset = "0x6222580", VA = "0x186223180", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6223720", Offset = "0x6222B20", VA = "0x186223720")]
	public LFLANMNOJDB(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6223480", Offset = "0x6222880", VA = "0x186223480", Slot = "17")]
	public void OFLNNNMBNOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x62233A0", Offset = "0x62227A0", VA = "0x1862233A0", Slot = "16")]
	public void LPJNFIDCMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x62215F0", Offset = "0x62209F0", VA = "0x1862215F0", Slot = "19")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6221860", Offset = "0x6220C60", VA = "0x186221860", Slot = "20")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6223010", Offset = "0x6222410", VA = "0x186223010", Slot = "18")]
	public void LEIHBCILENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6220CF0", Offset = "0x62200F0", VA = "0x186220CF0", Slot = "21")]
	public void AAJPKADPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6221D00", Offset = "0x6221100", VA = "0x186221D00")]
	private void JOOICEHGFPI(Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6223630", Offset = "0x6222A30", VA = "0x186223630")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PEBKHMCIEEN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6221BF0", Offset = "0x6220FF0", VA = "0x186221BF0")]
	private void KCEHOEIHIHP(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6221540", Offset = "0x6220940", VA = "0x186221540")]
	private void KFIOKECDAJF(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6222E70", Offset = "0x6222270", VA = "0x186222E70")]
	private Vector3 LCHKCIJIEGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6221310", Offset = "0x6220710", VA = "0x186221310", Slot = "15")]
	public void AOONJKGLCNJ((Quaternion rot, Vector3 moments) ALHLPOFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6221190", Offset = "0x6220590", VA = "0x186221190")]
	private Quaternion ACIPCJJICFM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6221DB0", Offset = "0x62211B0", VA = "0x186221DB0")]
	public void KIPNPCMDEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6221E80", Offset = "0x6221280", VA = "0x186221E80", Slot = "4")]
	public (float, Vector3) KIPNPCMDEBA(Rigidbody EPFPIOBMADK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MGJOAPDOFAH
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6223E80", Offset = "0x6223280", VA = "0x186223E80")]
	public static APKHHAJAMBF OPEEMKANHBN(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class FNMCHMGFLND : GBCIKCKFFKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ILIODHAIMDL LJLKFOHELCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JJDKBJICEBO JCCGOBCMAPF;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FJCPAHCHKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xBF5470", Offset = "0xBF4870", VA = "0x180BF5470", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public JJDKBJICEBO EKCJMLNNFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "11")]
		get
		{
			return default(JJDKBJICEBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x62140F0", Offset = "0x62134F0", VA = "0x1862140F0")]
	public FNMCHMGFLND(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6213AD0", Offset = "0x6212ED0", VA = "0x186213AD0", Slot = "4")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6213D80", Offset = "0x6213180", VA = "0x186213D80")]
	private bool HEABJHFMJBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x62140C0", Offset = "0x62134C0", VA = "0x1862140C0", Slot = "5")]
	public void OCPJADHNMFM(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6213BE0", Offset = "0x6212FE0", VA = "0x186213BE0", Slot = "6")]
	public void DHDDDHOJGFI(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6213F80", Offset = "0x6213380", VA = "0x186213F80", Slot = "9")]
	public void NBFEPACHMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6213E60", Offset = "0x6213260", VA = "0x186213E60")]
	private void MGJKGPLPPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6213C10", Offset = "0x6213010", VA = "0x186213C10")]
	private void FGGDBKOLNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6213E20", Offset = "0x6213220", VA = "0x186213E20", Slot = "8")]
	public void LAFDPFGOKEP(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6213BA0", Offset = "0x6212FA0", VA = "0x186213BA0", Slot = "7")]
	public void DBFKNOMKGHF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class LMHAGEACCHP : JDJGAANDNAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ILIODHAIMDL IFJKBMHOELK;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool FGMBIHKBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6223AD0", Offset = "0x6222ED0", VA = "0x186223AD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event PMCONJLJKAF DHPCHJAECNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6223B90", Offset = "0x6222F90", VA = "0x186223B90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x6223CF0", Offset = "0x62230F0", VA = "0x186223CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6223D90", Offset = "0x6223190", VA = "0x186223D90")]
	public LMHAGEACCHP(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6223C80", Offset = "0x6223080", VA = "0x186223C80", Slot = "11")]
	public IDisposable MNNNBPBFADH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6223B80", Offset = "0x6222F80", VA = "0x186223B80", Slot = "8")]
	public void HJPCEBAPFBJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6223C70", Offset = "0x6223070", VA = "0x186223C70", Slot = "9")]
	public void KDJJIFBHOFL(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6223910", Offset = "0x6222D10", VA = "0x186223910", Slot = "10")]
	public void BJEKGDCNMEN(object IBLOMPOENGH, bool CHLKIHBDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6223C30", Offset = "0x6223030", VA = "0x186223C30", Slot = "6")]
	public void JLPPHDBFFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6223A20", Offset = "0x6222E20", VA = "0x186223A20", Slot = "12")]
	public void FMMCIHKJEPH(Rigidbody DKNAEDLPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6223AA0", Offset = "0x6222EA0", VA = "0x186223AA0", Slot = "13")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JGFPJBCJKOE : MMGDEAAGHMO, BPKEOJMBMPD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private PhotonView APLHABDFFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool FFAJABNKINK;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView GJKMILCDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool BKPHNJEGKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x620AB70", Offset = "0x6209F70", VA = "0x18620AB70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool APCPACOJIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event PMCONJLJKAF IKMFGIMECGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x621BEC0", Offset = "0x621B2C0", VA = "0x18621BEC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x621BF60", Offset = "0x621B360", VA = "0x18621BF60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x621C550", Offset = "0x621B950", VA = "0x18621C550")]
	public JGFPJBCJKOE(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x621B9C0", Offset = "0x621ADC0", VA = "0x18621B9C0", Slot = "9")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x621BC50", Offset = "0x621B050", VA = "0x18621BC50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x621BD50", Offset = "0x621B150", VA = "0x18621BD50", Slot = "10")]
	public void EKKEPIJLGEJ(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x621C000", Offset = "0x621B400", VA = "0x18621C000", Slot = "11")]
	public void KEHBPCICNNE(PFJEEEPJDGP DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x621C170", Offset = "0x621B570", VA = "0x18621C170")]
	private void ODHNNFLJECM(PhotonView MGCBDBBHGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x621BAF0", Offset = "0x621AEF0", VA = "0x18621BAF0")]
	private void DLGCIJCKFEP(RigidbodyEx NDCAIADKCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x621C2E0", Offset = "0x621B6E0", VA = "0x18621C2E0")]
	private void OKJKLDPJGEC(PhotonView IOHDNDILODD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class HCMCIPPPLLL
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6216F10", Offset = "0x6216310", VA = "0x186216F10")]
	public static MMGDEAAGHMO JNJLHAFPLCI(this PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class EBIHCFHKFED : JMDONDDNJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private RigidbodyConstraints CHLBLGJLHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool HEGPOHMMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x9F7780", Offset = "0x9F6B80", VA = "0x1809F7780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3509AE0", Offset = "0x3508EE0", VA = "0x183509AE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool ADEAMDCGMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1160", Offset = "0x3BC0560", VA = "0x183BC1160", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x3509AD0", Offset = "0x3508ED0", VA = "0x183509AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints BLHDCKAAFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x620B9D0", Offset = "0x620ADD0", VA = "0x18620B9D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x620BB60", Offset = "0x620AF60", VA = "0x18620BB60")]
	public EBIHCFHKFED(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x620BB00", Offset = "0x620AF00", VA = "0x18620BB00", Slot = "9")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x620BB30", Offset = "0x620AF30", VA = "0x18620BB30", Slot = "10")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class JDJAOEDEOIF : OCHDBEMEHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly PFJEEEPJDGP IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private float BIIEOCAJMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float BBGNOAKCOED;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float EJLKIBGILPH
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FA0", Offset = "0x8A93A0", VA = "0x1808A9FA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x621A260", Offset = "0x6219660", VA = "0x18621A260", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float NDFOPAPAENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x855690", Offset = "0x854A90", VA = "0x180855690", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x621A0A0", Offset = "0x62194A0", VA = "0x18621A0A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x621A330", Offset = "0x6219730", VA = "0x18621A330")]
	public JDJAOEDEOIF(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x621A170", Offset = "0x6219570", VA = "0x18621A170", Slot = "8")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x621A1C0", Offset = "0x62195C0", VA = "0x18621A1C0", Slot = "9")]
	public void GNKHDNOBHCJ(Rigidbody DIMBCBIMGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class ABBMONEDBNH : PGKIONLPONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool FKBIHLFBOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool AHFCMPACBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int CPMIKLNPAMD;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6202530", Offset = "0x6201930", VA = "0x186202530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool KABOLKIFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6203020", Offset = "0x6202420", VA = "0x186203020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private PFJEEEPJDGP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x62029A0", Offset = "0x6201DA0", VA = "0x1862029A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6202AA0", Offset = "0x6201EA0", VA = "0x186202AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event PMCONJLJKAF KGNMFBHFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6202A00", Offset = "0x6201E00", VA = "0x186202A00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6202C90", Offset = "0x6202090", VA = "0x186202C90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6203040", Offset = "0x6202440", VA = "0x186203040")]
	public ABBMONEDBNH(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6202580", Offset = "0x6201980", VA = "0x186202580", Slot = "6")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6202760", Offset = "0x6201B60", VA = "0x186202760", Slot = "8")]
	public void FHPLEHOKMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6202610", Offset = "0x6201A10", VA = "0x186202610", Slot = "7")]
	public bool CMEBIIDAOAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6202F80", Offset = "0x6202380", VA = "0x186202F80", Slot = "9")]
	public void MKJFDFJNGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6202EE0", Offset = "0x62022E0", VA = "0x186202EE0", Slot = "11")]
	public void MHEDIHKEEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6202950", Offset = "0x6201D50", VA = "0x186202950", Slot = "12")]
	public void HLGOLFFLAAE(bool FGLLJKDIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6202D30", Offset = "0x6202130", VA = "0x186202D30", Slot = "10")]
	public void MHAAACLBCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6202770", Offset = "0x6201B70", VA = "0x186202770")]
	private bool GPKNHJHOKNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6202B00", Offset = "0x6201F00", VA = "0x186202B00")]
	private void LDEDJNNAIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JFBAKOJKNGJ : LPGJCAAOFBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly ILIODHAIMDL NPOBBNEOLPF;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody CMKNKJMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool IKEOHJNIHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6209BF0", Offset = "0x6208FF0", VA = "0x186209BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool EEOGKHKKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xBF5470", Offset = "0xBF4870", VA = "0x180BF5470", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x621B8B0", Offset = "0x621ACB0", VA = "0x18621B8B0")]
	public JFBAKOJKNGJ(PFJEEEPJDGP IJNDFBIKOFO, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x621AE00", Offset = "0x621A200", VA = "0x18621AE00", Slot = "5")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x621B880", Offset = "0x621AC80", VA = "0x18621B880", Slot = "7")]
	public void ONCMECCPFEJ(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x621B1D0", Offset = "0x621A5D0", VA = "0x18621B1D0", Slot = "8")]
	public void GGEHJOCGMEA(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x621AEA0", Offset = "0x621A2A0", VA = "0x18621AEA0", Slot = "9")]
	public void DOIOJAMPJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x621B200", Offset = "0x621A600", VA = "0x18621B200", Slot = "11")]
	public void INCHGFAPDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x621AAD0", Offset = "0x6219ED0", VA = "0x18621AAD0", Slot = "12")]
	public void BBCHOEDJAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x621B3F0", Offset = "0x621A7F0", VA = "0x18621B3F0", Slot = "10")]
	public void LBJGLANLFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x621A920", Offset = "0x6219D20", VA = "0x18621A920")]
	private void AIEBNPOCKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x621AC50", Offset = "0x621A050", VA = "0x18621AC50")]
	private void BFDJNGAIOLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class EJHHFIDFKKO : IPKLFIKKFCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly EOANOGBMDEJ IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly ILIODHAIMDL INHECNFBMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private float BHGMAPEPNPP;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MLIAOLFDJLC JNCLFMICILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public ADEPPJABBBD PGPMAJIFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 JHAIFCBNAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6231D50", Offset = "0x6231150", VA = "0x186231D50", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6231BB0", Offset = "0x6230FB0", VA = "0x186231BB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 EAIOIIDHMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6230170", Offset = "0x622F570", VA = "0x186230170", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x62313D0", Offset = "0x62307D0", VA = "0x1862313D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 CELGFEBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6230730", Offset = "0x622FB30", VA = "0x186230730", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6231AF0", Offset = "0x6230EF0", VA = "0x186231AF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 LHNFHGMPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x62309C0", Offset = "0x622FDC0", VA = "0x1862309C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x62302C0", Offset = "0x622F6C0", VA = "0x1862302C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float GIFPAEDEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B84E0", Offset = "0x7B78E0", VA = "0x1807B84E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6230E10", Offset = "0x6230210", VA = "0x186230E10", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool KDKEGANKFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1583E20", Offset = "0x1583220", VA = "0x181583E20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private ANHMPPFHALM DNMCOEPCMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1C09730", Offset = "0x1C08B30", VA = "0x181C09730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool KABOLKIFCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6207000", Offset = "0x6206400", VA = "0x186207000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x62326A0", Offset = "0x6231AA0", VA = "0x1862326A0")]
	public EJHHFIDFKKO(PFJEEEPJDGP IJNDFBIKOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x62300C0", Offset = "0x622F4C0", VA = "0x1862300C0", Slot = "19")]
	public void BHAKBPEKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6230AB0", Offset = "0x622FEB0", VA = "0x186230AB0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x6231400", Offset = "0x6230800", VA = "0x186231400", Slot = "28")]
	public void FMMCIHKJEPH(Rigidbody DIMBCBIMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xA251B0", Offset = "0xA245B0", VA = "0x180A251B0", Slot = "20")]
	public void EIJLCDDNEMP(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xA243F0", Offset = "0xA237F0", VA = "0x180A243F0", Slot = "30")]
	public void GJIAPMEOHIB(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6230EC0", Offset = "0x62302C0", VA = "0x186230EC0", Slot = "35")]
	public Vector3 EPOAELIPMBB(Vector3 KLLKNOGPFLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x6232010", Offset = "0x6231410", VA = "0x186232010", Slot = "34")]
	public Vector3 JHPEJLKONOM(Vector3 NAFPPHMNNHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x62300C0", Offset = "0x622F4C0", VA = "0x1862300C0", Slot = "27")]
	public void GBFHHDNOOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x62322D0", Offset = "0x62316D0", VA = "0x1862322D0", Slot = "25")]
	public void MAHIALLIPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6230260", Offset = "0x622F660", VA = "0x186230260", Slot = "24")]
	public void CPBMGFONLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6231E70", Offset = "0x6231270", VA = "0x186231E70", Slot = "33")]
	public void JFMFNDEJPFM(Vector3 BDBOMHLPJEK, Vector3 OPMDNKAGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x622FFB0", Offset = "0x622F3B0", VA = "0x18622FFB0", Slot = "32")]
	public void BCCEKCKMPJL(Vector3 FCBCFCFGEEM, Vector3 BOLPIDMDKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6230850", Offset = "0x622FC50", VA = "0x186230850", Slot = "31")]
	public void DLAFCKDHKCN(Vector3 AOPGBEBGNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x62314D0", Offset = "0x62308D0", VA = "0x1862314D0", Slot = "22")]
	public void GEAELIMCLCB(JBPBANCCDDG HIEKBIDPJJA, Vector3 NFLECKOGINL, float DDOACKFJDIN, float CJNBNCHKGGE = 8f, float BGANGGGLLHI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6230B80", Offset = "0x622FF80", VA = "0x186230B80", Slot = "21")]
	public void EKPIJFEGLIP(JFNOAMHMCLL DFGFICDGOEH, Vector3 HPBPOMBLEOM, float EAJNOIGJMPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6231030", Offset = "0x6230430", VA = "0x186231030", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FACLMJIEPFH(JFNOAMHMCLL DFGFICDGOEH, Vector3 CKFJFCLIANA, float GKNJFCCEFGI = 7f, float AMPPPGINGOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6232540", Offset = "0x6231940", VA = "0x186232540", Slot = "29")]
	public Vector3 PLDHOGBBINH(Vector3 FJGOAHOCDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6232410", Offset = "0x6231810", VA = "0x186232410", Slot = "26")]
	public void NFCAFMPGPAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6230E10", Offset = "0x6230210", VA = "0x186230E10")]
	private void GBALDBDDJEH(float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6232160", Offset = "0x6231560", VA = "0x186232160")]
	private void KDFBAPMJKLP(Vector3 HPBPOMBLEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6231C70", Offset = "0x6231070", VA = "0x186231C70")]
	private Vector3 IGEGDLCMPHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x622FB50", Offset = "0x622EF50", VA = "0x18622FB50")]
	private void AFDBOMNAJCG(Vector3 NAFPPHMNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6232330", Offset = "0x6231730", VA = "0x186232330")]
	private Vector3 MKKPBKHJMGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x62302F0", Offset = "0x622F6F0", VA = "0x1862302F0")]
	private void DILDIMIEHHP(Vector3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x622F6C0", Offset = "0x622EAC0", VA = "0x18622F6C0")]
	private void AAPEJBNKJLG(Vector3 NAFPPHMNNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6230010", Offset = "0x622F410", VA = "0x186230010")]
	private void BCIEKGEDGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KJOKLFLMCAO : FFAOLLBCFPK
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6232E00", Offset = "0x6232200", VA = "0x186232E00", Slot = "4")]
	public NOEECIOLHEN PELIFCCNONF(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6232AC0", Offset = "0x6231EC0", VA = "0x186232AC0", Slot = "5")]
	public IPKLFIKKFCE IHCJAENGEDO(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6232CD0", Offset = "0x62320D0", VA = "0x186232CD0", Slot = "6")]
	public ODIHKLIFNOG NNDALAGHOAI(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6232A60", Offset = "0x6231E60", VA = "0x186232A60", Slot = "7")]
	public OCHDBEMEHEI HPAOOEFHCIB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6232A00", Offset = "0x6231E00", VA = "0x186232A00", Slot = "8")]
	public PGKIONLPONA EGMCPADIDOB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x62329A0", Offset = "0x6231DA0", VA = "0x1862329A0", Slot = "9")]
	public MMEPBAGLDDK EFEHFJDHPPD(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6232940", Offset = "0x6231D40", VA = "0x186232940", Slot = "10")]
	public JDJGAANDNAK DKDLIFGIELC(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6232C10", Offset = "0x6232010", VA = "0x186232C10", Slot = "11")]
	public ANHMPPFHALM KOLMNJNLEBB(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6232D30", Offset = "0x6232130", VA = "0x186232D30", Slot = "12")]
	public PLNHLNJNAPH ODGOHJEPPAE(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6232C70", Offset = "0x6232070", VA = "0x186232C70", Slot = "13")]
	public HJMBGHGIKPG NBFMOKKBOJG(PFJEEEPJDGP GHADCFDOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x62327B0", Offset = "0x6231BB0", VA = "0x1862327B0")]
	public LPGJCAAOFBM PJHIPFEABPB(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6232D90", Offset = "0x6232190", VA = "0x186232D90")]
	public BPKEOJMBMPD OLAJCLOGCGL(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6232BA0", Offset = "0x6231FA0", VA = "0x186232BA0")]
	public GBCIKCKFFKI KFBCOGCOGAH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6232740", Offset = "0x6231B40", VA = "0x186232740")]
	public DGFNAOONHOB ABLCJEKFDPK(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x62328D0", Offset = "0x6231CD0", VA = "0x1862328D0")]
	public JMDONDDNJFG DBGKIODADJF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6232820", Offset = "0x6231C20", VA = "0x186232820", Slot = "19")]
	public PFJEEEPJDGP CCNINNPLALG(RigidbodyEx IJNDFBIKOFO, HKOHFLLCKEC OOIBMCBCEPD, OAFLAKLOLEE CCJFCCENPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KJOKLFLMCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x62327B0", Offset = "0x6231BB0", VA = "0x1862327B0", Slot = "14")]
	private LPGJCAAOFBM BPNBHIOCCPH(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6232D90", Offset = "0x6232190", VA = "0x186232D90", Slot = "15")]
	private BPKEOJMBMPD OPJGHCLPHPD(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6232BA0", Offset = "0x6231FA0", VA = "0x186232BA0", Slot = "16")]
	private GBCIKCKFFKI NKCJMDCJDEF(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6232740", Offset = "0x6231B40", VA = "0x186232740", Slot = "17")]
	private DGFNAOONHOB CDKNIGFKKHE(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x62328D0", Offset = "0x6231CD0", VA = "0x1862328D0", Slot = "18")]
	private JMDONDDNJFG EAKBOJJFODA(PFJEEEPJDGP GHADCFDOJAA, [In] HKOHFLLCKEC OOIBMCBCEPD)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GHHKFIIHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6232E60", Offset = "0x6232260", VA = "0x186232E60", Slot = "6")]
		public sealed override void LHBGMEBPDNO(IOIHKDFKKJB AIBILCAOCLG)
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
