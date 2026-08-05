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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static CJPPGPOGFKM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int OJKKJLOHCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int EHGICDCNLME;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x702F930", Offset = "0x702EB30", VA = "0x18702F930")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x702F970", Offset = "0x702EB70", VA = "0x18702F970")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x702F950", Offset = "0x702EB50", VA = "0x18702F950")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CEOMJLPEFPB, [Optional] UnityEngine.Object APPLJOFCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CEOMJLPEFPB, [Optional] UnityEngine.Object APPLJOFCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x702FA60", Offset = "0x702EC60", VA = "0x18702FA60")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AFCBAMOGKIA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class GHKGLMJGCGJ : BPEIPBLOJDJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x14D4EA0", Offset = "0x14D40A0", VA = "0x1814D4EA0", Slot = "4")]
		public Vector3 OIEGLDLEBJG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14D4EA0", Offset = "0x14D40A0", VA = "0x1814D4EA0", Slot = "5")]
		public Vector3 ACPPKAJDLPC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GHKGLMJGCGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BPEIPBLOJDJ OCKJJCADAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB06F0", Offset = "0x5DAF8F0", VA = "0x185DB06F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ENGBMBNJAKF BIFNEEPDIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool JJKMPKPOGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FHNBDEAMHEB PNAGJFGNFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[LOLBLOLLILE(OANOIFMCHLE.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private BEFLDPKKAIM physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal FHNBDEAMHEB FKLJLBMDNAF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x702FB40", Offset = "0x702ED40", VA = "0x18702FB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> HBAAOHAMFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x93C0D0", Offset = "0x93B2D0", VA = "0x18093C0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx NMMPFACCNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x70326D0", Offset = "0x70318D0", VA = "0x1870326D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HOKLBIFFMCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7032670", Offset = "0x7031870", VA = "0x187032670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BLFIAOLNAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7033220", Offset = "0x7032420", VA = "0x187033220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70346E0", Offset = "0x70338E0", VA = "0x1870346E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform MONNHCMHDLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE172E0", Offset = "0xE164E0", VA = "0x180E172E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BLMNLPICDEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xE172E0", Offset = "0xE164E0", VA = "0x180E172E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FKFODBAGGHC KNFCMCCHCKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7032430", Offset = "0x7031630", VA = "0x187032430")]
			get
			{
				return default(FKFODBAGGHC);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7033E80", Offset = "0x7033080", VA = "0x187033E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EOLCHPPJINK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7032930", Offset = "0x7031B30", VA = "0x187032930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHCBOOIEHNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7032550", Offset = "0x7031750", VA = "0x187032550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BPEIPBLOJDJ AIAEEJIPJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7032870", Offset = "0x7031A70", VA = "0x187032870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7034090", Offset = "0x7033290", VA = "0x187034090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PMLEEIJAFOB FHNMDJMNPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7032810", Offset = "0x7031A10", VA = "0x187032810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7034020", Offset = "0x7033220", VA = "0x187034020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool NECPEADOCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7032700", Offset = "0x7031900", VA = "0x187032700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody MBJFFDGCBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7032760", Offset = "0x7031960", VA = "0x187032760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KOFLMFHCALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70325B0", Offset = "0x70317B0", VA = "0x1870325B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7033F40", Offset = "0x7033140", VA = "0x187033F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GPJNKIEIGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D1AB50", Offset = "0x1D19D50", VA = "0x181D1AB50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3C9FE90", Offset = "0x3C9F090", VA = "0x183C9FE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float HLEHAADLBPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x70331C0", Offset = "0x70323C0", VA = "0x1870331C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float GPLFMODDLNM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7033160", Offset = "0x7032360", VA = "0x187033160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7034670", Offset = "0x7033870", VA = "0x187034670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float MEFFMOEKFHA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7032B80", Offset = "0x7031D80", VA = "0x187032B80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7034320", Offset = "0x7033520", VA = "0x187034320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NAOCBOJPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7032990", Offset = "0x7031B90", VA = "0x187032990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7034100", Offset = "0x7033300", VA = "0x187034100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CHHBDNPLJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x70336F0", Offset = "0x70328F0", VA = "0x1870336F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7034BD0", Offset = "0x7033DD0", VA = "0x187034BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 MBCMMFGMJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7032F60", Offset = "0x7032160", VA = "0x187032F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7034460", Offset = "0x7033660", VA = "0x187034460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 IMHBLPOBEKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7033820", Offset = "0x7032A20", VA = "0x187033820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode LFOCNENHKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7032AC0", Offset = "0x7031CC0", VA = "0x187032AC0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7034240", Offset = "0x7033440", VA = "0x187034240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float IAKKMNHMMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7032610", Offset = "0x7031810", VA = "0x187032610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7033FB0", Offset = "0x70331B0", VA = "0x187033FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints JOOHJHIIMEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7032B20", Offset = "0x7031D20", VA = "0x187032B20")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x70342B0", Offset = "0x70334B0", VA = "0x1870342B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 NBDGJLADHCB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7033280", Offset = "0x7032480", VA = "0x187033280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MAHIKAKBIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7033280", Offset = "0x7032480", VA = "0x187033280")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x70349C0", Offset = "0x7033BC0", VA = "0x1870349C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float JGDPIMBHEIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7033030", Offset = "0x7032230", VA = "0x187033030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7034530", Offset = "0x7033730", VA = "0x187034530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DDFDFBAFPCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7033690", Offset = "0x7032890", VA = "0x187033690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7034B60", Offset = "0x7033D60", VA = "0x187034B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion KACAHNHEEDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7033350", Offset = "0x7032550", VA = "0x187033350")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7034750", Offset = "0x7033950", VA = "0x187034750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion HIKPDLHANFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x70335C0", Offset = "0x70327C0", VA = "0x1870335C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7034A90", Offset = "0x7033C90", VA = "0x187034A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 FHKBHFOFJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7033420", Offset = "0x7032620", VA = "0x187033420")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7034820", Offset = "0x7033A20", VA = "0x187034820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion DBLOOPCPGFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70334F0", Offset = "0x70326F0", VA = "0x1870334F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x70348F0", Offset = "0x7033AF0", VA = "0x1870348F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 ODDDGBEGEIL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7033750", Offset = "0x7032950", VA = "0x187033750")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7034C40", Offset = "0x7033E40", VA = "0x187034C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GDHALLLEGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7033090", Offset = "0x7032290", VA = "0x187033090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x70345A0", Offset = "0x70337A0", VA = "0x1870345A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 KDIKDMAHLGO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x70329F0", Offset = "0x7031BF0", VA = "0x1870329F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7034170", Offset = "0x7033370", VA = "0x187034170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DFFBBKCFJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7032E90", Offset = "0x7032090", VA = "0x187032E90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7034390", Offset = "0x7033590", VA = "0x187034390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DOKMFKLPCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7032D60", Offset = "0x7031F60", VA = "0x187032D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion LNNJDCHLNCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7032C90", Offset = "0x7031E90", VA = "0x187032C90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 PKLLGDDLBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x70339C0", Offset = "0x7032BC0", VA = "0x1870339C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IIGHNILMPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x70338F0", Offset = "0x7032AF0", VA = "0x1870338F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool PJOPHEEFJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7032E30", Offset = "0x7032030", VA = "0x187032E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JLEBEIOJKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x70328D0", Offset = "0x7031AD0", VA = "0x1870328D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BLANIEDPIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x70324F0", Offset = "0x70316F0", VA = "0x1870324F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JEIPEPHCLPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7032490", Offset = "0x7031690", VA = "0x187032490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CKKGFCEEABL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x70323D0", Offset = "0x70315D0", VA = "0x1870323D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DDJCGLNDDNB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7032BE0", Offset = "0x7031DE0", VA = "0x187032BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GAIAFJLIGLP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9CB880", Offset = "0x9CAA80", VA = "0x1809CB880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GGFJJGDFDOL KNJNPKAFKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x70322F0", Offset = "0x70314F0", VA = "0x1870322F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7033DA0", Offset = "0x7032FA0", VA = "0x187033DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AICJGHABIKI NJIMJKDEADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7032280", Offset = "0x7031480", VA = "0x187032280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7033D30", Offset = "0x7032F30", VA = "0x187033D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GGFJJGDFDOL PGMCKJHNNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7031FE0", Offset = "0x70311E0", VA = "0x187031FE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7033A90", Offset = "0x7032C90", VA = "0x187033A90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event GGFJJGDFDOL LHDIMBKGJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7032050", Offset = "0x7031250", VA = "0x187032050")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7033B00", Offset = "0x7032D00", VA = "0x187033B00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event GGFJJGDFDOL MGNFKGCLJPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x70321A0", Offset = "0x70313A0", VA = "0x1870321A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7033C50", Offset = "0x7032E50", VA = "0x187033C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7032130", Offset = "0x7031330", VA = "0x187032130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7033BE0", Offset = "0x7032DE0", VA = "0x187033BE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event GGFJJGDFDOL FJILFHAJDKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7032210", Offset = "0x7031410", VA = "0x187032210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7033CC0", Offset = "0x7032EC0", VA = "0x187033CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event GGFJJGDFDOL KKDMAEPICDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7032360", Offset = "0x7031560", VA = "0x187032360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7033E10", Offset = "0x7033010", VA = "0x187033E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event GGFJJGDFDOL AGCDILJIAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x70320C0", Offset = "0x70312C0", VA = "0x1870320C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7033B70", Offset = "0x7032D70", VA = "0x187033B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10")]
		internal void JCNIFBMGFEI(FHNBDEAMHEB NKLFKPOOEFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x702FAB0", Offset = "0x702ECB0", VA = "0x18702FAB0")]
		internal void ADADCDFPKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7031CD0", Offset = "0x7030ED0", VA = "0x187031CD0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PBGIHPMKPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7031990", Offset = "0x7030B90", VA = "0x187031990")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) NEODCFKLEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7030630", Offset = "0x702F830", VA = "0x187030630")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x702FB40", Offset = "0x702ED40", VA = "0x18702FB40")]
		private FHNBDEAMHEB LLFDHKGILBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x70308E0", Offset = "0x702FAE0", VA = "0x1870308E0")]
		private void FPAONKDPNEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7031180", Offset = "0x7030380", VA = "0x187031180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7031110", Offset = "0x7030310", VA = "0x187031110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7030C70", Offset = "0x702FE70", VA = "0x187030C70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7031120", Offset = "0x7030320", VA = "0x187031120")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x70311E0", Offset = "0x70303E0", VA = "0x1870311E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x702FBF0", Offset = "0x702EDF0", VA = "0x18702FBF0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7031250", Offset = "0x7030450", VA = "0x187031250")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7030880", Offset = "0x702FA80", VA = "0x187030880")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x70310B0", Offset = "0x70302B0", VA = "0x1870310B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7031AF0", Offset = "0x7030CF0", VA = "0x187031AF0")]
		public void SetParent(RigidbodyEx ACKOJNNBEBO, bool MLAKNPIOJBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7031550", Offset = "0x7030750", VA = "0x187031550")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7030ED0", Offset = "0x70300D0", VA = "0x187030ED0")]
		public bool IsRigidbodyAncestor(RigidbodyEx LLNCMOOKKIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7030F10", Offset = "0x7030110", VA = "0x187030F10")]
		public bool IsRigidbodyDescendant(RigidbodyEx JIENFIHONDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x702FE60", Offset = "0x702F060", VA = "0x18702FE60")]
		public void AddInterpolationRestriction(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70312C0", Offset = "0x70304C0", VA = "0x1870312C0")]
		public void RemoveInterpolationRestriction(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70306A0", Offset = "0x702F8A0", VA = "0x1870306A0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x702FED0", Offset = "0x702F0D0", VA = "0x18702FED0")]
		public void AddKinematic(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7031330", Offset = "0x7030530", VA = "0x187031330")]
		public void RemoveKinematic(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7031A70", Offset = "0x7030C70", VA = "0x187031A70")]
		public void SetKinematic(object IBIKCCMDMHA, bool ONBIDCCJKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70318A0", Offset = "0x7030AA0", VA = "0x1870318A0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IGKKEEOKAFG, Quaternion JHLHDPHCNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70317B0", Offset = "0x70309B0", VA = "0x1870317B0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EAFDNPIHGME, Quaternion JELLMBCLNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7030DD0", Offset = "0x702FFD0", VA = "0x187030DD0")]
		public Vector3 GetConstrainedVelocity(Vector3 ODDDGBEGEIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7030CD0", Offset = "0x702FED0", VA = "0x187030CD0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 KDIKDMAHLGO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x702FD70", Offset = "0x702EF70", VA = "0x18702FD70")]
		public void AddForce(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x702FC60", Offset = "0x702EE60", VA = "0x18702FC60")]
		public void AddForceAtPosition(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x70300A0", Offset = "0x702F2A0", VA = "0x1870300A0")]
		public void AddTorque(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x702FF40", Offset = "0x702F140", VA = "0x18702FF40")]
		public void AddRelativeTorque(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7031DB0", Offset = "0x7030FB0", VA = "0x187031DB0")]
		public Vector3 WorldToLocalVelocity(Vector3 DJDAAPHBCIG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7030FB0", Offset = "0x70301B0", VA = "0x187030FB0")]
		public Vector3 LocalToWorldVelocity(Vector3 GDHALLLEGNH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7030820", Offset = "0x702FA20", VA = "0x187030820")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70307C0", Offset = "0x702F9C0", VA = "0x1870307C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7030760", Offset = "0x702F960", VA = "0x187030760")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7030700", Offset = "0x702F900", VA = "0x187030700")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70316B0", Offset = "0x70308B0", VA = "0x1870316B0")]
		public void ResetVelocityWorldSpace(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x70315B0", Offset = "0x70307B0", VA = "0x1870315B0")]
		public void ResetVelocityLocalSpace(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7031480", Offset = "0x7030680", VA = "0x187031480")]
		public void ResetLinearVelocityLocalSpace(Vector3 CKEEBIANPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7031BE0", Offset = "0x7030DE0", VA = "0x187031BE0")]
		public bool SweepTest(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7030F50", Offset = "0x7030150", VA = "0x187030F50")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7031B80", Offset = "0x7030D80", VA = "0x187031B80")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7031D50", Offset = "0x7030F50", VA = "0x187031D50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7030030", Offset = "0x702F230", VA = "0x187030030")]
		public void AddShouldHaveUnityRigidbodyToken(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x70313A0", Offset = "0x70305A0", VA = "0x1870313A0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7030420", Offset = "0x702F620", VA = "0x187030420")]
		public void ApplyForceVelocityChange(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7030330", Offset = "0x702F530", VA = "0x187030330")]
		public void ApplyAngularVelocityChange(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7030530", Offset = "0x702F730", VA = "0x187030530")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7030270", Offset = "0x702F470", VA = "0x187030270")]
		public bool AllowedScaleChange(float NEPMEFCPECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7030190", Offset = "0x702F390", VA = "0x187030190")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PIJNANBGIAC, object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7031410", Offset = "0x7030610", VA = "0x187031410")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7031F40", Offset = "0x7031140", VA = "0x187031F40")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class DJHNMPIDEAM
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7080", Offset = "0x5DB6280", VA = "0x185DB7080")]
	public static FHNBDEAMHEB FKLJLBMDNAF(this RigidbodyEx GPIDMMLMBCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void GGFJJGDFDOL(RigidbodyEx AIMKFDDCGOI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FJCMEBNIJKP : MNJBPEDMMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FMDFFDAGOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NFDJKKMOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x841C80", Offset = "0x840E80", VA = "0x180841C80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "6")]
	public GHPGHMJFCDB DCNCNHGJHNM(float NELOPAHIPAA)
	{
		return default(GHPGHMJFCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
	public void PPMBLONPHPF(OALPABPCAMP BHEOHCEHIBM, float AANJADLMGPL, FKFODBAGGHC DJNACNHJANK = FKFODBAGGHC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void PPMBLONPHPF(OALPABPCAMP BHEOHCEHIBM, Transform HGLBJPOJOGP, float AANJADLMGPL, FKFODBAGGHC DJNACNHJANK = FKFODBAGGHC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "9")]
	public void BDFGLINLOLJ(OALPABPCAMP BHEOHCEHIBM, [Optional] float? AANJADLMGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "10")]
	public void PLKCAALIKKA(OALPABPCAMP PCPLLLAJJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "11")]
	public GHPGHMJFCDB LLKPPLKPNCA(OALPABPCAMP BHEOHCEHIBM)
	{
		return default(GHPGHMJFCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "12")]
	public bool FANLKAEGNIB(OALPABPCAMP BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "13")]
	public void IJBPDKHKOHO(OALPABPCAMP BHEOHCEHIBM, FKFODBAGGHC PCOIBBNIHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public FJCMEBNIJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BEFLDPKKAIM
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum CIBEODNAMJD
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IIKMLKNINKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody CAACFEDFBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView LCDKDJPKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 GFKCALECFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 BHFPPDDOIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BEFLDPKKAIM ALGPDFOHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool HHHOJEBCHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool OAIJPAEELJI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void AICJGHABIKI(RigidbodyEx AIMKFDDCGOI, bool MLAKNPIOJBD = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KJPIDBGIKDC(typeof(GLMLKGKIJNO), new string[] { "Ignore", "Mock" })]
public class OJAKBNPGBGI : GLMLKGKIJNO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CLALBBGAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x844720", Offset = "0x843920", VA = "0x180844720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
	public void CCNOOFGCLJL(string KLEKJFJOCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "6")]
	public void HKGHALFEGKO(RigidbodyEx GPIDMMLMBCH, Action JFFMHPNGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x86F940", Offset = "0x86EB40", VA = "0x18086F940", Slot = "7")]
	public MNJBPEDMMOI KJHAEMMLLGL(int NDLOHKLDAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void NHNGDGLBBIJ(Vector3 IMHBLPOBEKC, float OEGBEKPOACB, Color MBOFNGAOJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public OJAKBNPGBGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KJPIDBGIKDC(typeof(FCNEAIBMEDD), new string[] { })]
public class MMBFNPDKFAF : FCNEAIBMEDD, FHPOLFAIAHE
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BFPPGIPJGJM CKPHAGCJAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GLMLKGKIJNO JCECDDPGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GCANJDLOKJD CHNHLMMMOAF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CGHKMLCFILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x702AFA0", Offset = "0x702A1A0", VA = "0x18702AFA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GLMLKGKIJNO HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GCANJDLOKJD BNDIGIEEPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x702B530", Offset = "0x702A730", VA = "0x18702B530", Slot = "12")]
	public void InitReferences(EJCDFCAJDED KJDFKKLNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x702B240", Offset = "0x702A440", VA = "0x18702B240", Slot = "7")]
	public NGBBJMBOBME ICCFMKJGFAK(RigidbodyEx GPIDMMLMBCH)
	{
		return default(NGBBJMBOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x702AFF0", Offset = "0x702A1F0", VA = "0x18702AFF0")]
	private static NGBBJMBOBME EOEELJKHHBD(RigidbodyEx GPIDMMLMBCH)
	{
		return default(NGBBJMBOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x702AE90", Offset = "0x702A090", VA = "0x18702AE90", Slot = "8")]
	public FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x702B5C0", Offset = "0x702A7C0", VA = "0x18702B5C0", Slot = "11")]
	private RigidbodyEx OPMJJLJAOAA(GameObject HHFCGHHBGCH, IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x702ADA0", Offset = "0x7029FA0", VA = "0x18702ADA0", Slot = "9")]
	public void AFDOFIOFDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x702B0F0", Offset = "0x702A2F0", VA = "0x18702B0F0", Slot = "10")]
	public void GPOICLGDEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public MMBFNPDKFAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class OFPEPAPPNNO
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float IBPHMIMEHNJ = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float MOPEIKEBPFI = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float CAIKNNAIJDL = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public OFPEPAPPNNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PGMACFBPCAP
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x702F6D0", Offset = "0x702E8D0", VA = "0x18702F6D0")]
	public static void OFOCDPEHOJM(this Rigidbody PBGIHPMKPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x702F820", Offset = "0x702EA20", VA = "0x18702F820")]
	public static void OFOCDPEHOJM(this Rigidbody PBGIHPMKPPK, Vector3 HOJHPLEGDEP, Quaternion LNNJDCHLNCO, Vector3 DIBPFACDFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x702F620", Offset = "0x702E820", VA = "0x18702F620")]
	public static void NGFFCJOGFAJ(Vector3 ODDDGBEGEIL, Vector3 IJGNBLHAEPN, out Vector3 DNFEIDHIDOD, out Vector3 MDEDGPKMPKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GMGFPGIHPLK
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ELNBNKMGOPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GGFJJGDFDOL FIBKICHDLAA;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLODEADKFLH(FHNBDEAMHEB BLFIAOLNAKG);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBCGGBKPGJF(FHNBDEAMHEB BLFIAOLNAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MMJPCNKBKEM
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface GLMLKGKIJNO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool CLALBBGAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCNOOFGCLJL(string KLEKJFJOCHO);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKGHALFEGKO(RigidbodyEx GPIDMMLMBCH, Action JFFMHPNGJBK);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNJBPEDMMOI KJHAEMMLLGL(int NDLOHKLDAIE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHNGDGLBBIJ(Vector3 IMHBLPOBEKC, float OEGBEKPOACB, Color MBOFNGAOJFM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface FCNEAIBMEDD
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GLMLKGKIJNO HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GCANJDLOKJD BNDIGIEEPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool CGHKMLCFILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGBBJMBOBME ICCFMKJGFAK(RigidbodyEx GPIDMMLMBCH);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFDOFIOFDMA();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GPOICLGDEMJ();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx BLGEMEDIJLC(GameObject HHFCGHHBGCH, [Optional] IIKMLKNINKM JCEJEOAKGOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EBFCEFNCFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx BKIIIAAADIP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LKIOGGAEKIC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKOCFBIKAHJ(FHNBDEAMHEB BLFIAOLNAKG, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLBPNCFPMKI(object IBIKCCMDMHA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class AFELDMDPJGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0820", Offset = "0x5DAFA20", VA = "0x185DB0820")]
	public AFELDMDPJGB(MKICEPDICHP KDPBEOJMKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DB07C0", Offset = "0x5DAF9C0", VA = "0x185DB07C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MKICEPDICHP : FHNBDEAMHEB, IDisposable, IDCIGAKHCGD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string LJIDKDMDPEP = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly FCNEAIBMEDD EKDODOMDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal PFMKIIEBHIJ CBLHBMDHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal NLFLFCCLOME OKEGCAALGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal ELNBNKMGOPL ELECDMDGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal AGOPKIGJDAN ODDDGBEGEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal LKIOGGAEKIC NFICFIJFHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal FGEFEOBFMEO OPIGJOLOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal MMJPCNKBKEM BOEPDNCGIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal FAFKPGMJFPN FEFFMMNFAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal CHEOOBBEMFC KAJJGMIJBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HEHINKJOIEI KDGOPAMGOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal FMNKNKOFCJB PJPEAKODCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal NOBGAICGEJB PPHFAHHOGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OBBACJNIACD ALDMBEFALJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IFKPEHMIIAE CAACFEDFBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal LIAOGPGONHC HHDKHENIHBP;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx GPPKGOJCECI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xABAFC0", Offset = "0xABA1C0", VA = "0x180ABAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject ALPDOCMMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x912450", Offset = "0x911650", VA = "0x180912450", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xABB1B0", Offset = "0xABA3B0", VA = "0x180ABB1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF0B0", Offset = "0x5DCE2B0", VA = "0x185DCF0B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> BJKINAJKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDE90", Offset = "0x5DCD090", VA = "0x185DCDE90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DD24A0", Offset = "0x5DD16A0", VA = "0x185DD24A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE670", Offset = "0x5DCD870", VA = "0x185DCE670", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1C70", Offset = "0x5DD0E70", VA = "0x185DD1C70", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFDF0", Offset = "0x5DCEFF0", VA = "0x185DCFDF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD22C0", Offset = "0x5DD14C0", VA = "0x185DD22C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCF90", Offset = "0x5DCC190", VA = "0x185DCCF90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDA70", Offset = "0x5DCCC70", VA = "0x185DCDA70", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDE40", Offset = "0x5DCD040", VA = "0x185DCDE40", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF810", Offset = "0x5DCEA10", VA = "0x185DCF810", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DD00F0", Offset = "0x5DCF2F0", VA = "0x185DD00F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD3B0", Offset = "0x5DCC5B0", VA = "0x185DCD3B0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDBB0", Offset = "0x5DCCDB0", VA = "0x185DCDBB0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFB80", Offset = "0x5DCED80", VA = "0x185DCFB80", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD5B0", Offset = "0x5DCC7B0", VA = "0x185DCD5B0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE100", Offset = "0x5DCD300", VA = "0x185DCE100", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFE40", Offset = "0x5DCF040", VA = "0x185DCFE40", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1F70", Offset = "0x5DD1170", VA = "0x185DD1F70", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFA00", Offset = "0x5DCEC00", VA = "0x185DCFA00", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD4C0", Offset = "0x5DCC6C0", VA = "0x185DCD4C0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD9A0", Offset = "0x5DCCBA0", VA = "0x185DCD9A0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD09E0", Offset = "0x5DCFBE0", VA = "0x185DD09E0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD760", Offset = "0x5DCC960", VA = "0x185DCD760", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool BLANIEDPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCED30", Offset = "0x5DCDF30", VA = "0x185DCED30", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool JEIPEPHCLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0150", Offset = "0x5DCF350", VA = "0x185DD0150", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool CKKGFCEEABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0430", Offset = "0x5DCF630", VA = "0x185DD0430", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5DD23F0", Offset = "0x5DD15F0", VA = "0x185DD23F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF930", Offset = "0x5DCEB30", VA = "0x185DCF930", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFCC0", Offset = "0x5DCEEC0", VA = "0x185DCFCC0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1120", Offset = "0x5DD0320", VA = "0x185DD1120", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0360", Offset = "0x5DCF560", VA = "0x185DD0360", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1BA0", Offset = "0x5DD0DA0", VA = "0x185DD1BA0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF3E0", Offset = "0x5DCE5E0", VA = "0x185DCF3E0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0D30", Offset = "0x5DCFF30", VA = "0x185DD0D30", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFAD0", Offset = "0x5DCECD0", VA = "0x185DCFAD0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD830", Offset = "0x5DCCA30", VA = "0x185DCD830", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFF10", Offset = "0x5DCF110", VA = "0x185DCFF10", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE850", Offset = "0x5DCDA50", VA = "0x185DCE850", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1510", Offset = "0x5DD0710", VA = "0x185DD1510", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0250", Offset = "0x5DCF450", VA = "0x185DD0250", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0090", Offset = "0x5DCF290", VA = "0x185DD0090", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0FE0", Offset = "0x5DD01E0", VA = "0x185DD0FE0", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0980", Offset = "0x5DCFB80", VA = "0x185DD0980", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5DD13B0", Offset = "0x5DD05B0", VA = "0x185DD13B0", Slot = "51")]
		get
		{
			return default(GFOBGKKNJAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2550", Offset = "0x5DD1750", VA = "0x185DD2550", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE8A0", Offset = "0x5DCDAA0", VA = "0x185DCE8A0", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform MONNHCMHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD610", Offset = "0x5DCC810", VA = "0x185DCD610", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform BLMNLPICDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD610", Offset = "0x5DCC810", VA = "0x185DCD610", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 HNKNNHMEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE1D0", Offset = "0x5DCD3D0", VA = "0x185DCE1D0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2110", Offset = "0x5DD1310", VA = "0x185DD2110", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float OIOGJBJKCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1390", Offset = "0x5DD0590", VA = "0x185DD1390", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEE90", Offset = "0x5DCE090", VA = "0x185DCEE90", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float HEOPLDAELCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF3C0", Offset = "0x5DCE5C0", VA = "0x185DCF3C0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0E70", Offset = "0x5DD0070", VA = "0x185DD0E70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion DJDCKLEDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFFE0", Offset = "0x5DCF1E0", VA = "0x185DCFFE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC9B0", Offset = "0x5DCBBB0", VA = "0x185DCC9B0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5DD06E0", Offset = "0x5DCF8E0", VA = "0x185DD06E0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF770", Offset = "0x5DCE970", VA = "0x185DCF770", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2800", Offset = "0x5DD1A00", VA = "0x185DD2800", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE290", Offset = "0x5DCD490", VA = "0x185DCE290", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDEE0", Offset = "0x5DCD0E0", VA = "0x185DCDEE0", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0680", Offset = "0x5DCF880", VA = "0x185DD0680", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF7C0", Offset = "0x5DCE9C0", VA = "0x185DCF7C0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF1A0", Offset = "0x5DCE3A0", VA = "0x185DCF1A0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1CD0", Offset = "0x5DD0ED0", VA = "0x185DD1CD0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDDF0", Offset = "0x5DCCFF0", VA = "0x185DCDDF0", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF250", Offset = "0x5DCE450", VA = "0x185DCF250", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCAB0", Offset = "0x5DCBCB0", VA = "0x185DCCAB0", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool JLEBEIOJKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE4E0", Offset = "0x5DCD6E0", VA = "0x185DCE4E0", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool KNLIMKAHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5DCED80", Offset = "0x5DCDF80", VA = "0x185DCED80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool BBPOMKPIPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0730", Offset = "0x5DCF930", VA = "0x185DD0730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event GGFJJGDFDOL PGMCKJHNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DD12E0", Offset = "0x5DD04E0", VA = "0x185DD12E0", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5DD1400", Offset = "0x5DD0600", VA = "0x185DD1400", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event GGFJJGDFDOL LHDIMBKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5DCD700", Offset = "0x5DCC900", VA = "0x185DCD700", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5DCEE30", Offset = "0x5DCE030", VA = "0x185DCEE30", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event AICJGHABIKI MNLPMNFBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0C00", Offset = "0x5DCFE00", VA = "0x185DD0C00", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF710", Offset = "0x5DCE910", VA = "0x185DCF710", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event GGFJJGDFDOL FIBKICHDLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0C60", Offset = "0x5DCFE60", VA = "0x185DD0C60", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCFF0", Offset = "0x5DCC1F0", VA = "0x185DCCFF0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event GGFJJGDFDOL MGNFKGCLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF140", Offset = "0x5DCE340", VA = "0x185DCF140", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DD02A0", Offset = "0x5DCF4A0", VA = "0x185DD02A0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event GGFJJGDFDOL MLEMLFIBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0F80", Offset = "0x5DD0180", VA = "0x185DD0F80", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCCA50", Offset = "0x5DCBC50", VA = "0x185DCCA50", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5DCECD0", Offset = "0x5DCDED0", VA = "0x185DCECD0", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5DD21C0", Offset = "0x5DD13C0", VA = "0x185DD21C0", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event GGFJJGDFDOL LKLHEFBCDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5DD24F0", Offset = "0x5DD16F0", VA = "0x185DD24F0", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0620", Offset = "0x5DCF820", VA = "0x185DD0620", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event GGFJJGDFDOL AGCDILJIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD01B0", Offset = "0x5DCF3B0", VA = "0x185DD01B0", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDC10", Offset = "0x5DCCE10", VA = "0x185DCDC10", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0230", Offset = "0x5DBF430", VA = "0x185DC0230")]
	public MKICEPDICHP(GameObject JBOGCBPFIGA, RigidbodyEx FBBMNDLDAFE, FCNEAIBMEDD EKDODOMDNPH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE940", Offset = "0x5DCDB40", VA = "0x185DCE940", Slot = "143")]
	protected virtual void FBJDAJDJKHB(FCNEAIBMEDD EKDODOMDNPH, IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE2D0", Offset = "0x5DCD4D0", VA = "0x185DCE2D0", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE710", Offset = "0x5DCD910", VA = "0x185DCE710", Slot = "75")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD470", Offset = "0x5DCC670", VA = "0x185DCD470", Slot = "76")]
	public void NMCFLHMHINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD590", Offset = "0x5DCC790", VA = "0x185DCD590", Slot = "77")]
	public void BGEONNNHJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1AF0", Offset = "0x5DD0CF0", VA = "0x185DD1AF0", Slot = "145")]
	public virtual void NBOBGDMCJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD400", Offset = "0x5DCC600", VA = "0x185DCD400", Slot = "86")]
	public void ANGEEGJGALL(FHNBDEAMHEB ACKOJNNBEBO, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD240", Offset = "0x5DCC440", VA = "0x185DCD240", Slot = "89")]
	public void AIJMBFEPEHI(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0300", Offset = "0x5DCF500", VA = "0x185DD0300", Slot = "90")]
	public void JKMCNLFAHMA(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0D80", Offset = "0x5DCFF80", VA = "0x185DD0D80", Slot = "91")]
	public Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDAC0", Offset = "0x5DCCCC0", VA = "0x185DCDAC0", Slot = "92")]
	public Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD470", Offset = "0x5DCC670", VA = "0x185DCD470", Slot = "93")]
	public void BEBHODJBOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1340", Offset = "0x5DD0540", VA = "0x185DD1340", Slot = "94")]
	public void MJEIAKFJICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DD08E0", Offset = "0x5DCFAE0", VA = "0x185DD08E0", Slot = "95")]
	public void KFPNMMCLAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFBD0", Offset = "0x5DCEDD0", VA = "0x185DCFBD0", Slot = "96")]
	public void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1030", Offset = "0x5DD0230", VA = "0x185DD1030", Slot = "97")]
	public void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF860", Offset = "0x5DCEA60", VA = "0x185DCF860", Slot = "98")]
	public void HHCCMGEPFLF(Vector3 KAKEDCFJIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF2B0", Offset = "0x5DCE4B0", VA = "0x185DCF2B0", Slot = "99")]
	public void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0B10", Offset = "0x5DCFD10", VA = "0x185DD0B10", Slot = "100")]
	public void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0520", Offset = "0x5DCF720", VA = "0x185DD0520", Slot = "101")]
	[Obsolete]
	public void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DD11F0", Offset = "0x5DD03F0", VA = "0x185DD11F0", Slot = "102")]
	public Vector3 MHEPDLGAMII(Vector3 ACKOJNNBEBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1D20", Offset = "0x5DD0F20", VA = "0x185DD1D20", Slot = "103")]
	public Vector3 NHBCFGLGGNC(Vector3 ACKOJNNBEBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD950", Offset = "0x5DCCB50", VA = "0x185DCD950", Slot = "104")]
	public void BOLNNPGGPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2740", Offset = "0x5DD1940", VA = "0x185DD2740", Slot = "105")]
	public void PNBGAFPMBEN(FHNBDEAMHEB PIJNANBGIAC, object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDD90", Offset = "0x5DCCF90", VA = "0x185DCDD90", Slot = "106")]
	public void CLKLHDMNPPE(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD620", Offset = "0x5DCC820", VA = "0x185DCD620", Slot = "44")]
	public void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE8F0", Offset = "0x5DCDAF0", VA = "0x185DCE8F0", Slot = "109")]
	public void FANMDJHBJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0930", Offset = "0x5DCFB30", VA = "0x185DD0930", Slot = "110")]
	public void KGBPBFPOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCC00", Offset = "0x5DCBE00", VA = "0x185DCCC00", Slot = "111")]
	public void AEMGHKEJANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE6C0", Offset = "0x5DCD8C0", VA = "0x185DCE6C0", Slot = "114")]
	public bool EFNEMBNMAEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC960", Offset = "0x5DCBB60", VA = "0x185DCC960", Slot = "78")]
	public void AAPGHPCNAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFB30", Offset = "0x5DCED30", VA = "0x185DCFB30", Slot = "115")]
	public void HLCJDLAAPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF200", Offset = "0x5DCE400", VA = "0x185DCF200", Slot = "120")]
	public IDisposable GKKIKONAHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2440", Offset = "0x5DD1640", VA = "0x185DD2440", Slot = "121")]
	public void PAGBFNPKBII(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0AB0", Offset = "0x5DCFCB0", VA = "0x185DD0AB0", Slot = "122")]
	public void KIPDDJGDEBM(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0CC0", Offset = "0x5DCFEC0", VA = "0x185DD0CC0", Slot = "123")]
	public void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2840", Offset = "0x5DD1A40", VA = "0x185DD2840", Slot = "126")]
	public void PPMIKIKGMEJ(Vector3 IGKKEEOKAFG, Quaternion JHLHDPHCNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEF00", Offset = "0x5DCE100", VA = "0x185DCEF00", Slot = "127")]
	public void GFIKAPLLBKK(Vector3 EAFDNPIHGME, Quaternion JELLMBCLNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE480", Offset = "0x5DCD680", VA = "0x185DCE480", Slot = "128")]
	public bool EBFFJIIMJMJ(float NEPMEFCPECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFD90", Offset = "0x5DCEF90", VA = "0x185DCFD90", Slot = "129")]
	public void IMBLCKMABJC(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCC50", Offset = "0x5DCBE50", VA = "0x185DCCC50", Slot = "130")]
	public void AEOAGHOHCOA(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCF30", Offset = "0x5DCC130", VA = "0x185DCCF30", Slot = "131")]
	public void AHHNEFEMJBL(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1F10", Offset = "0x5DD1110", VA = "0x185DD1F10", Slot = "132")]
	public void NHIAMLHBBKK(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2220", Offset = "0x5DD1420", VA = "0x185DD2220")]
	public void OJCNOLCOEJO(object IBIKCCMDMHA, bool NLCGADBFNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDF30", Offset = "0x5DCD130", VA = "0x185DCDF30", Slot = "134")]
	public void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD2A0", Offset = "0x5DCC4A0", VA = "0x185DCD2A0", Slot = "135")]
	public void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDCB0", Offset = "0x5DCCEB0", VA = "0x185DCDCB0", Slot = "136")]
	public void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC880", Offset = "0x5DCBA80", VA = "0x185DCC880", Slot = "137")]
	public void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE010", Offset = "0x5DCD210", VA = "0x185DCE010", Slot = "138")]
	public bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD900", Offset = "0x5DCCB00", VA = "0x185DCD900", Slot = "139")]
	public void BOAPJJLOBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2AB0", Offset = "0x5DD1CB0", VA = "0x185DD2AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2040", Offset = "0x5DD1240", VA = "0x185DD2040")]
	private void NKKHBGMGMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1940", Offset = "0x5DD0B40", VA = "0x185DD1940")]
	private void MPNIDEEFHLO(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD050", Offset = "0x5DCC250", VA = "0x185DCD050")]
	private void AIJDCDPBJAC(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEC20", Offset = "0x5DCDE20", VA = "0x185DCEC20")]
	private void FHOKMHCCNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1E10", Offset = "0x5DD1010", VA = "0x185DD1E10")]
	private void NHGFABMCKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1460", Offset = "0x5DD0660", VA = "0x185DD1460")]
	private void MNDCADDHCCA(FHNBDEAMHEB HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2310", Offset = "0x5DD1510", VA = "0x185DD2310")]
	private void OLODEADKFLH(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE3A0", Offset = "0x5DCD5A0", VA = "0x185DCE3A0")]
	private void EBCGGBKPGJF(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0770", Offset = "0x5DCF970", VA = "0x185DD0770")]
	private void KBLLMGGOHEO(RigidbodyEx BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCCB0", Offset = "0x5DCBEB0", VA = "0x185DCCCB0", Slot = "146")]
	protected virtual void AFEACLBNLDI(RigidbodyEx GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2610", Offset = "0x5DD1810", VA = "0x185DD2610")]
	[Conditional("UNITY_EDITOR")]
	private void PIKCNBDMPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF430", Offset = "0x5DCE630", VA = "0x185DCF430")]
	protected void HBCCAFEDAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1570", Offset = "0x5DD0770", VA = "0x185DD1570")]
	protected void MPGJFIAPFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class EILONOMGHMK
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC380", Offset = "0x5DBB580", VA = "0x185DBC380")]
	public static FHNBDEAMHEB JEEAPCGEDAF(this FHNBDEAMHEB GPIDMMLMBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC300", Offset = "0x5DBB500", VA = "0x185DBC300")]
	public static bool IPFNAFLOHKP(this FHNBDEAMHEB GPIDMMLMBCH, FHNBDEAMHEB LLNCMOOKKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC440", Offset = "0x5DBB640", VA = "0x185DBC440")]
	public static bool NCGNCDLHCNF(this FHNBDEAMHEB GPIDMMLMBCH, FHNBDEAMHEB JIENFIHONDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC240", Offset = "0x5DBB440", VA = "0x185DBC240")]
	public static RigidbodyEx GPPKGOJCECI(this FHNBDEAMHEB FKLJLBMDNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC290", Offset = "0x5DBB490", VA = "0x185DBC290")]
	public static MKICEPDICHP IAFDMKKDDLK(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FGEFEOBFMEO
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GGFJJGDFDOL FIBGKOMFNMG;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KGBPBFPOOGN();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FANMDJHBJAO();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AEMGHKEJANA();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOAPJJLOBKI();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface IDCIGAKHCGD
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FHNBDEAMHEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx GPPKGOJCECI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject ALPDOCMMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> BJKINAJKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool BLANIEDPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool JEIPEPHCLPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool CKKGFCEEABL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform MONNHCMHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform BLMNLPICDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 HNKNNHMEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float OIOGJBJKCED
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float HEOPLDAELCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion DJDCKLEDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool JLEBEIOJKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event GGFJJGDFDOL PGMCKJHNNLK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GGFJJGDFDOL LHDIMBKGJPN;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event AICJGHABIKI MNLPMNFBBGJ;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event GGFJJGDFDOL FIBKICHDLAA;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event GGFJJGDFDOL MGNFKGCLJPP;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GGFJJGDFDOL MLEMLFIBFCH;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event GGFJJGDFDOL LKLHEFBCDKH;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event GGFJJGDFDOL AGCDILJIAHL;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void NMCFLHMHINM();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void BGEONNNHJAF();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void AAPGHPCNAFA();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void NBOBGDMCJKB();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void ANGEEGJGALL(FHNBDEAMHEB ACKOJNNBEBO, bool MLAKNPIOJBD = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void AIJMBFEPEHI(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void JKMCNLFAHMA(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void BEBHODJBOLD();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void MJEIAKFJICD();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void KFPNMMCLAPH();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void HHCCMGEPFLF(Vector3 KAKEDCFJIFI);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 MHEPDLGAMII(Vector3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 NHBCFGLGGNC(Vector3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void BOLNNPGGPLP();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void PNBGAFPMBEN(FHNBDEAMHEB PIJNANBGIAC, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CLKLHDMNPPE(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FANMDJHBJAO();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void KGBPBFPOOGN();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void AEMGHKEJANA();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool EFNEMBNMAEP();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void HLCJDLAAPDG();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable GKKIKONAHNM();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PAGBFNPKBII(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void KIPDDJGDEBM(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void PPMIKIKGMEJ(Vector3 IGKKEEOKAFG, Quaternion JHLHDPHCNBP);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void GFIKAPLLBKK(Vector3 EAFDNPIHGME, Quaternion JELLMBCLNHB);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool EBFFJIIMJMJ(float NEPMEFCPECN);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void IMBLCKMABJC(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AEOAGHOHCOA(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void AHHNEFEMJBL(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NHIAMLHBBKK(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void BOAPJJLOBKI();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NOBGAICGEJB
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BPEIPBLOJDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 OIEGLDLEBJG();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 ACPPKAJDLPC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NLFLFCCLOME
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool KNNOOAEDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	IICIADPPFLC ECEMFLGGPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHCEJFDOOMF(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDOPGGGMFMN(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FADGMIMJNFJ(FHNBDEAMHEB GPIDMMLMBCH);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFPLEIOIFBP(FHNBDEAMHEB GPIDMMLMBCH);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNPOJJLMFKD();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HEHINKJOIEI : IDisposable, OALPABPCAMP
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMIKNJLDNOP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PFMKIIEBHIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event GGFJJGDFDOL PGMCKJHNNLK;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event GGFJJGDFDOL LHDIMBKGJPN;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event AICJGHABIKI MNLPMNFBBGJ;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action OIGMHFBPFBN;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action KLKCMKJJAHH;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<FHNBDEAMHEB> PGMJHAEOANH;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<FHNBDEAMHEB> EIHOIPGLMDG;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action GAHKACAELFE;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<FHNBDEAMHEB> HJIMBKDEFFL;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ANGEEGJGALL(FHNBDEAMHEB AENILMDGHEI, bool MLAKNPIOJBD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface GCANJDLOKJD
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFMKIIEBHIJ HEMDOAPHKFI(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGOPKIGJDAN GLLNFANKKFN(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LKIOGGAEKIC CALGOGKFNIH(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMJPCNKBKEM CCPHAHONOKG(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CHEOOBBEMFC OJJKKIGPPEP(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HEHINKJOIEI ODPFFBHCNLM(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FMNKNKOFCJB NHIGILKLPJF(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NOBGAICGEJB JHMIEKGOOIE(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LIAOGPGONHC PHJGNDMOPMG(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FAFKPGMJFPN CNBEFPEFMLJ(FHNBDEAMHEB NKLFKPOOEFB);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IFKPEHMIIAE OGMLPKKNBFD(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ELNBNKMGOPL BHLKLHMNDNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NLFLFCCLOME LBHJCJMBFCB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FGEFEOBFMEO EBDINONEKCL(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OBBACJNIACD CLMMDHOKHNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ, FCNEAIBMEDD EKDODOMDNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OBBACJNIACD
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool FKHCPFDHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PMLEEIJAFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJFAILKGBHO(Vector3 FPIAKMEOOGB);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPICNHONHFD(Vector3 KDIKDMAHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPHCHLENJOB(Vector3 FPIAKMEOOGB);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOKNAFHCDIL(Vector3 KDIKDMAHLGO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FMNKNKOFCJB
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> IPBGMBDIEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event GGFJJGDFDOL LKLHEFBCDKH;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMJEMNGDFED();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAGBFNPKBII(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KIPDDJGDEBM(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable GKKIKONAHNM();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKPDPGPFBOI(Rigidbody IKACAOHCKNG);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LIAOGPGONHC
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJCEDILLBAA(bool PJOPHEEFJLM);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIMGIJDMLFA(bool PJOPHEEFJLM);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AGOPKIGJDAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BBKKHGANADE(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KFPNMMCLAPH();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MJEIAKFJICD();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BOLNNPGGPLP();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BEBHODJBOLD();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NHBCFGLGGNC(Vector3 KDIKDMAHLGO);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 MHEPDLGAMII(Vector3 ODDDGBEGEIL);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FKIIFGCGMLD(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HHCCMGEPFLF(Vector3 KAKEDCFJIFI);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IFKPEHMIIAE
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHHNEFEMJBL(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHIAMLHBBKK(object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJEODGHNGFE();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AANGCODMKHN();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHMFDJGLBKB();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIBNAFINNBI();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FAFKPGMJFPN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CHEOOBBEMFC
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event GGFJJGDFDOL MLEMLFIBFCH;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMIKNJLDNOP();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EFNEMBNMAEP();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMHMIEOIPDA();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAPGHPCNAFA();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DMMBGNPNKHO();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLCJDLAAPDG();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AHICLPFGLCJ(bool KNONAIJGIKG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KJPIDBGIKDC(typeof(PBIAEBDDJPF), new string[] { })]
public sealed class PBEEJCALFCF : FHPOLFAIAHE, PBIAEBDDJPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[FEAMOPHNPMA]
	private JGIPKANALKC GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool FKBOPHAPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x702D210", Offset = "0x702C410", VA = "0x18702D210", Slot = "4")]
	public void InitReferences(EJCDFCAJDED KJDFKKLNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x702D080", Offset = "0x702C280", VA = "0x18702D080", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x702D450", Offset = "0x702C650", VA = "0x18702D450", Slot = "6")]
	public void NDBEBBMHLIJ(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x702D260", Offset = "0x702C460", VA = "0x18702D260", Slot = "7")]
	public void JILCFDLJCMO(NGBBJMBOBME LDDMDOBAIIL, bool LJDKPKOOOOF, bool AMLHMELHLNE, bool FALNHDPJCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x702D5C0", Offset = "0x702C7C0", VA = "0x18702D5C0")]
	private bool NDOFIODLLJF(NGBBJMBOBME LDDMDOBAIIL, out GBJKMOINFOC NKLFKPOOEFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x702CF20", Offset = "0x702C120", VA = "0x18702CF20")]
	private bool CAKDIDEGFBC(NGBBJMBOBME LDDMDOBAIIL, out DPDOJHOBCAP AJPBFPCOEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x702D0B0", Offset = "0x702C2B0", VA = "0x18702D0B0")]
	private bool GPCHEJABGBH(NGBBJMBOBME LDDMDOBAIIL, out JBFIIAOHCEG OLOHFOEDBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public PBEEJCALFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class JBFIIAOHCEG : IOEKFFKLHDF, FGEFEOBFMEO
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5B40", Offset = "0x5DC4D40", VA = "0x185DC5B40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4C60", Offset = "0x5DC3E60", VA = "0x185DC4C60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 ECPIFJNICJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC52D0", Offset = "0x5DC44D0", VA = "0x185DC52D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4C60", Offset = "0x5DC3E60", VA = "0x185DC4C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 CGOMPDOMDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4900", Offset = "0x5DC3B00", VA = "0x185DC4900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5D20", Offset = "0x5DC4F20", VA = "0x185DC5D20", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4F90", Offset = "0x5DC4190", VA = "0x185DC4F90", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float CEIBJFKBFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC57A0", Offset = "0x5DC49A0", VA = "0x185DC57A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5A70", Offset = "0x5DC4C70", VA = "0x185DC5A70", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DC5060", Offset = "0x5DC4260", VA = "0x185DC5060", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3E70", Offset = "0x5DC3070", VA = "0x185DC3E70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DC53F0", Offset = "0x5DC45F0", VA = "0x185DC53F0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5400", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event GGFJJGDFDOL FIBGKOMFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DC59D0", Offset = "0x5DC4BD0", VA = "0x185DC59D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DC6F50", Offset = "0x5DC6150", VA = "0x185DC6F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC70E0", Offset = "0x5DC62E0", VA = "0x185DC70E0")]
	public JBFIIAOHCEG(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5C60", Offset = "0x5DC4E60", VA = "0x185DC5C60")]
	public float3 MGBOPOFEJFE()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6FF0", Offset = "0x5DC61F0", VA = "0x185DC6FF0")]
	public bool OMOKOGOIMMF(out float3 IMHBLPOBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4C90", Offset = "0x5DC3E90", VA = "0x185DC4C90")]
	public void FPBLMLCJJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4A30", Offset = "0x5DC3C30", VA = "0x185DC4A30")]
	public bool FDMIPMIKKBH(out float HLEHAADLBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3C00", Offset = "0x5DC2E00", VA = "0x185DC3C00", Slot = "14")]
	public void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4670", Offset = "0x5DC3870", VA = "0x185DC4670", Slot = "16")]
	public void FANMDJHBJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5420", Offset = "0x5DC4620", VA = "0x185DC5420", Slot = "15")]
	public void KGBPBFPOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5890", Offset = "0x5DC4A90", VA = "0x185DC5890", Slot = "18")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DC43C0", Offset = "0x5DC35C0", VA = "0x185DC43C0", Slot = "19")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DC38F0", Offset = "0x5DC2AF0", VA = "0x185DC38F0", Slot = "17")]
	public void AEMGHKEJANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3EA0", Offset = "0x5DC30A0", VA = "0x185DC3EA0", Slot = "20")]
	public void BOAPJJLOBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAA90", Offset = "0x5DB9C90", VA = "0x185DBAA90")]
	public void LAJNLLDOGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4B20", Offset = "0x5DC3D20", VA = "0x185DC4B20")]
	private void FMBACHBFBOP(Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5160", Offset = "0x5DC4360", VA = "0x185DC5160")]
	[Obsolete]
	private Vector3 HPGDOGACKDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5060", Offset = "0x5DC4260", VA = "0x185DC5060")]
	private void MDNPONPNOHP(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC39C0", Offset = "0x5DC2BC0", VA = "0x185DC39C0")]
	private Vector3 AHHFFELCPOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC4D60", Offset = "0x5DC3F60", VA = "0x185DC4D60")]
	private Quaternion GAONHIHALKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC5EA0", Offset = "0x5DC50A0", VA = "0x185DC5EA0")]
	internal (float, Vector3) NDBEBBMHLIJ(Rigidbody PPKNGDFCIBF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class LMNNOGJKGMA
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB0E0", Offset = "0x5DCA2E0", VA = "0x185DCB0E0")]
	public static JBFIIAOHCEG FGPKDFDPBEK(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ADOJPJBMDLH : IOEKFFKLHDF, AGOPKIGJDAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEBB0", Offset = "0x5DADDB0", VA = "0x185DAEBB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF220", Offset = "0x5DAE420", VA = "0x185DAF220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DACDF0", Offset = "0x5DABFF0", VA = "0x185DACDF0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DADD80", Offset = "0x5DACF80", VA = "0x185DADD80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD250", Offset = "0x5DAC450", VA = "0x185DAD250", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DADB00", Offset = "0x5DACD00", VA = "0x185DADB00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DADE70", Offset = "0x5DAD070", VA = "0x185DADE70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF1F0", Offset = "0x5DAE3F0", VA = "0x185DAF1F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF920", Offset = "0x5DAEB20", VA = "0x185DAF920", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD490", Offset = "0x5DAC690", VA = "0x185DAD490", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0560", Offset = "0x5DAF760", VA = "0x185DB0560", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEEB0", Offset = "0x5DAE0B0", VA = "0x185DAEEB0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEEE0", Offset = "0x5DAE0E0", VA = "0x185DAEEE0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD480", Offset = "0x5DAC680", VA = "0x185DAD480", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0590", Offset = "0x5DAF790", VA = "0x185DB0590", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private NOBGAICGEJB IOKPJDDJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2D72470", Offset = "0x2D71670", VA = "0x182D72470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5DACB20", Offset = "0x5DABD20", VA = "0x185DACB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public ADOJPJBMDLH(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD0F0", Offset = "0x5DAC2F0", VA = "0x185DAD0F0", Slot = "20")]
	public void BBKKHGANADE(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE640", Offset = "0x5DAD840", VA = "0x185DAE640", Slot = "31")]
	public void FKIIFGCGMLD(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD1E0", Offset = "0x5DAC3E0", VA = "0x185DAD1E0", Slot = "19")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DADEA0", Offset = "0x5DAD0A0", VA = "0x185DADEA0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF980", Offset = "0x5DAEB80", VA = "0x185DAF980", Slot = "28")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0060", Offset = "0x5DAF260", VA = "0x185DB0060", Slot = "36")]
	public Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5DADBC0", Offset = "0x5DACDC0", VA = "0x185DADBC0", Slot = "35")]
	public Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD1E0", Offset = "0x5DAC3E0", VA = "0x185DAD1E0", Slot = "27")]
	public void BEBHODJBOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0360", Offset = "0x5DAF560", VA = "0x185DB0360", Slot = "25")]
	public void MJEIAKFJICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF8E0", Offset = "0x5DAEAE0", VA = "0x185DAF8E0", Slot = "24")]
	public void KFPNMMCLAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEFB0", Offset = "0x5DAE1B0", VA = "0x185DAEFB0", Slot = "34")]
	public void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0240", Offset = "0x5DAF440", VA = "0x185DB0240", Slot = "33")]
	public void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5DAECE0", Offset = "0x5DADEE0", VA = "0x185DAECE0", Slot = "32")]
	public void HHCCMGEPFLF(Vector3 KAKEDCFJIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE730", Offset = "0x5DAD930", VA = "0x185DAE730", Slot = "22")]
	public void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF9C0", Offset = "0x5DAEBC0", VA = "0x185DAF9C0", Slot = "21")]
	public void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF5C0", Offset = "0x5DAE7C0", VA = "0x185DAF5C0", Slot = "23")]
	[Obsolete]
	public void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB02A0", Offset = "0x5DAF4A0", VA = "0x185DB02A0", Slot = "30")]
	public Vector3 MHEPDLGAMII(Vector3 ODDDGBEGEIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB03A0", Offset = "0x5DAF5A0", VA = "0x185DB03A0", Slot = "29")]
	public Vector3 NHBCFGLGGNC(Vector3 KDIKDMAHLGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD550", Offset = "0x5DAC750", VA = "0x185DAD550", Slot = "26")]
	public void BOLNNPGGPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD2B0", Offset = "0x5DAC4B0", VA = "0x185DAD2B0")]
	private void BJGFFGOIPAN(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5DACF20", Offset = "0x5DAC120", VA = "0x185DACF20")]
	private void AOBDPKNHBDJ(Vector3 NDKIIPDPNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF310", Offset = "0x5DAE510", VA = "0x185DAF310")]
	private Vector3 JNIGIGDGPEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFC00", Offset = "0x5DAEE00", VA = "0x185DAFC00")]
	private void LALGFNECJCH(Vector3 GDHALLLEGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5DACB40", Offset = "0x5DABD40", VA = "0x185DACB40")]
	private Vector3 ACPPKAJDLPC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD6B0", Offset = "0x5DAC8B0", VA = "0x185DAD6B0")]
	private void BPICNHONHFD(Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5DADFD0", Offset = "0x5DAD1D0", VA = "0x185DADFD0")]
	private void ECACGDBACDA(Vector3 ODDDGBEGEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEB50", Offset = "0x5DADD50", VA = "0x185DAEB50")]
	private void GMOKNHBKKLN(Vector3 KDIKDMAHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE030", Offset = "0x5DAD230", VA = "0x185DAE030")]
	private void EFAACIPCACD(string EMGEBPNMJCK, Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB04A0", Offset = "0x5DAF6A0", VA = "0x185DB04A0")]
	private void NJJGFCIKFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class HOCHPIPMIDH : IOEKFFKLHDF, MMJPCNKBKEM
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1DA0", Offset = "0x5DC0FA0", VA = "0x185DC1DA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC22D0", Offset = "0x5DC14D0", VA = "0x185DC22D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2040", Offset = "0x5DC1240", VA = "0x185DC2040", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1E70", Offset = "0x5DC1070", VA = "0x185DC1E70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public HOCHPIPMIDH(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2110", Offset = "0x5DC1310", VA = "0x185DC2110", Slot = "8")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1CD0", Offset = "0x5DC0ED0", VA = "0x185DC1CD0", Slot = "9")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class JMAIEIJHGGF : FHNBDEAMHEB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JMAIEIJHGGF EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx GPPKGOJCECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject ALPDOCMMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> BJKINAJKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF660", Offset = "0x8DE860", VA = "0x1808DF660", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x98D6F0", Offset = "0x98C8F0", VA = "0x18098D6F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x98D730", Offset = "0x98C930", VA = "0x18098D730", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x98D720", Offset = "0x98C920", VA = "0x18098D720", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BE0", Offset = "0x8D5DE0", VA = "0x1808D6BE0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x93C0C0", Offset = "0x93B2C0", VA = "0x18093C0C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x93C0D0", Offset = "0x93B2D0", VA = "0x18093C0D0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1B025B0", Offset = "0x1B017B0", VA = "0x181B025B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1B01440", Offset = "0x1B00640", VA = "0x181B01440", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4669E80", Offset = "0x4669080", VA = "0x184669E80", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4669E40", Offset = "0x4669040", VA = "0x184669E40", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2333720", Offset = "0x2332920", VA = "0x182333720", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2331D70", Offset = "0x2330F70", VA = "0x182331D70", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2154270", Offset = "0x2153470", VA = "0x182154270", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2154020", Offset = "0x2153220", VA = "0x182154020", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool BLANIEDPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x105C490", Offset = "0x105B690", VA = "0x18105C490", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool JEIPEPHCLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x109D840", Offset = "0x109CA40", VA = "0x18109D840", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool CKKGFCEEABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x109D830", Offset = "0x109CA30", VA = "0x18109D830", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE6D920", Offset = "0xE6CB20", VA = "0x180E6D920", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x20BDD00", Offset = "0x20BCF00", VA = "0x1820BDD00", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x21C10F0", Offset = "0x21C02F0", VA = "0x1821C10F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1679D20", Offset = "0x1678F20", VA = "0x181679D20", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xCB20A0", Offset = "0xCB12A0", VA = "0x180CB20A0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1713990", Offset = "0x1712B90", VA = "0x181713990", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x830E90", Offset = "0x830090", VA = "0x180830E90", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1713990", Offset = "0x1712B90", VA = "0x181713990", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1713990", Offset = "0x1712B90", VA = "0x181713990", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool ABBPIDDNFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "51")]
		get
		{
			return default(GFOBGKKNJAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x389AC00", Offset = "0x3899E00", VA = "0x18389AC00", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform MONNHCMHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xB0E240", Offset = "0xB0D440", VA = "0x180B0E240", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform BLMNLPICDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA7B690", Offset = "0xA7A890", VA = "0x180A7B690", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 HNKNNHMEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float OIOGJBJKCED
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1713990", Offset = "0x1712B90", VA = "0x181713990", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float HEOPLDAELCA
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1713990", Offset = "0x1712B90", VA = "0x181713990", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion DJDCKLEDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x18E5AA0", Offset = "0x18E4CA0", VA = "0x1818E5AA0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x18E5AA0", Offset = "0x18E4CA0", VA = "0x1818E5AA0", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool JLEBEIOJKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x18883F0", Offset = "0x18875F0", VA = "0x1818883F0", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event GGFJJGDFDOL PGMCKJHNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event GGFJJGDFDOL LHDIMBKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event AICJGHABIKI MNLPMNFBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event GGFJJGDFDOL FIBKICHDLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event GGFJJGDFDOL MGNFKGCLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event GGFJJGDFDOL MLEMLFIBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event GGFJJGDFDOL LKLHEFBCDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event GGFJJGDFDOL AGCDILJIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "44")]
	public void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "75")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "76")]
	public void NMCFLHMHINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "77")]
	public void BGEONNNHJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "78")]
	public void AAPGHPCNAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "79")]
	public void NBOBGDMCJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "86")]
	public void ANGEEGJGALL(FHNBDEAMHEB ACKOJNNBEBO, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "89")]
	public void AIJMBFEPEHI(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "90")]
	public void JKMCNLFAHMA(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "91")]
	public Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "92")]
	public Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "93")]
	public void BEBHODJBOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "94")]
	public void MJEIAKFJICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "95")]
	public void KFPNMMCLAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "96")]
	public void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "97")]
	public void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "98")]
	public void HHCCMGEPFLF(Vector3 KAKEDCFJIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "99")]
	public void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "100")]
	public void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "101")]
	public void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "102")]
	public Vector3 MHEPDLGAMII(Vector3 ACKOJNNBEBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x82EB70", Offset = "0x82DD70", VA = "0x18082EB70", Slot = "103")]
	public Vector3 NHBCFGLGGNC(Vector3 ACKOJNNBEBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "104")]
	public void BOLNNPGGPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "105")]
	public void PNBGAFPMBEN(FHNBDEAMHEB PIJNANBGIAC, object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "106")]
	public void CLKLHDMNPPE(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "109")]
	public void FANMDJHBJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "110")]
	public void KGBPBFPOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "111")]
	public void AEMGHKEJANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "114")]
	public bool EFNEMBNMAEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "115")]
	public void HLCJDLAAPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "120")]
	public IDisposable GKKIKONAHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "121")]
	public void PAGBFNPKBII(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "122")]
	public void KIPDDJGDEBM(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "123")]
	public void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "126")]
	public void PPMIKIKGMEJ(Vector3 IGKKEEOKAFG, Quaternion JHLHDPHCNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "127")]
	public void GFIKAPLLBKK(Vector3 EAFDNPIHGME, Quaternion JELLMBCLNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "128")]
	public bool EBFFJIIMJMJ(float NEPMEFCPECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "129")]
	public void IMBLCKMABJC(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "130")]
	public void AEOAGHOHCOA(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "131")]
	public void AHHNEFEMJBL(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "132")]
	public void NHIAMLHBBKK(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "134")]
	public void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "135")]
	public void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "136")]
	public void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "137")]
	public void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC91B0", Offset = "0x5DC83B0", VA = "0x185DC91B0", Slot = "138")]
	public bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "139")]
	public void BOAPJJLOBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public JMAIEIJHGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class MDGCBNIGBOA : IOEKFFKLHDF, LKIOGGAEKIC
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBD30", Offset = "0x5DCAF30", VA = "0x185DCBD30", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBD60", Offset = "0x5DCAF60", VA = "0x185DCBD60", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBC50", Offset = "0x5DCAE50", VA = "0x185DCBC50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private FHNBDEAMHEB JACGBJIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC1C0", Offset = "0x5DCB3C0", VA = "0x185DCC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public MDGCBNIGBOA(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBF20", Offset = "0x5DCB120", VA = "0x185DCBF20", Slot = "6")]
	public void IKOCFBIKAHJ(FHNBDEAMHEB BLFIAOLNAKG, object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC0A0", Offset = "0x5DCB2A0", VA = "0x185DCC0A0")]
	private void IKOCFBIKAHJ(GBJKMOINFOC BLFIAOLNAKG, object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC6D0", Offset = "0x5DCB8D0", VA = "0x185DCC6D0", Slot = "7")]
	public void NLBPNCFPMKI(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC320", Offset = "0x5DCB520", VA = "0x185DCC320")]
	private Vector3 NLBIPAKFCDL()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class NGPPJBFEOKH
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x702CEB0", Offset = "0x702C0B0", VA = "0x18702CEB0")]
	public static MDGCBNIGBOA PKIELMBNJAI(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class BAJJPHKKNBE : IOEKFFKLHDF, PFMKIIEBHIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly ENGBMBNJAKF HDKDFKCGFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JFMODMHGJEO AGOJGEALHPL;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB17F0", Offset = "0x5DB09F0", VA = "0x185DB17F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public NGBBJMBOBME CAMKNDLLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1DA0", Offset = "0x5DB0FA0", VA = "0x185DB1DA0")]
		get
		{
			return default(NGBBJMBOBME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0DB0", Offset = "0x5DAFFB0", VA = "0x185DB0DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1710", Offset = "0x5DB0910", VA = "0x185DB1710", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2B60", Offset = "0x5DB1D60", VA = "0x185DB2B60", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public NGBBJMBOBME LDFLKNJCFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2E90", Offset = "0x5DB2090", VA = "0x185DB2E90")]
		get
		{
			return default(NGBBJMBOBME);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1610", Offset = "0x5DB0810", VA = "0x185DB1610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2E50", Offset = "0x5DB2050", VA = "0x185DB2E50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event GGFJJGDFDOL PGMCKJHNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2A20", Offset = "0x5DB1C20", VA = "0x185DB2A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2AC0", Offset = "0x5DB1CC0", VA = "0x185DB2AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event GGFJJGDFDOL LHDIMBKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB11B0", Offset = "0x5DB03B0", VA = "0x185DB11B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1750", Offset = "0x5DB0950", VA = "0x185DB1750", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event AICJGHABIKI MNLPMNFBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1EA0", Offset = "0x5DB10A0", VA = "0x185DB1EA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1820", Offset = "0x5DB0A20", VA = "0x185DB1820", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action OIGMHFBPFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1250", Offset = "0x5DB0450", VA = "0x185DB1250", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1390", Offset = "0x5DB0590", VA = "0x185DB1390", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action KLKCMKJJAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1D00", Offset = "0x5DB0F00", VA = "0x185DB1D00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB12F0", Offset = "0x5DB04F0", VA = "0x185DB12F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<FHNBDEAMHEB> PGMJHAEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2F90", Offset = "0x5DB2190", VA = "0x185DB2F90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1070", Offset = "0x5DB0270", VA = "0x185DB1070", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<FHNBDEAMHEB> EIHOIPGLMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2110", Offset = "0x5DB1310", VA = "0x185DB2110", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1C60", Offset = "0x5DB0E60", VA = "0x185DB1C60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action GAHKACAELFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2D00", Offset = "0x5DB1F00", VA = "0x185DB2D00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1110", Offset = "0x5DB0310", VA = "0x185DB1110", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<FHNBDEAMHEB> HJIMBKDEFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2980", Offset = "0x5DB1B80", VA = "0x185DB2980", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2070", Offset = "0x5DB1270", VA = "0x185DB2070", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB30C0", Offset = "0x5DB22C0", VA = "0x185DB30C0")]
	public BAJJPHKKNBE(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1430", Offset = "0x5DB0630", VA = "0x185DB1430", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0FF0", Offset = "0x5DB01F0", VA = "0x185DB0FF0", Slot = "26")]
	public void ANGEEGJGALL(FHNBDEAMHEB AENILMDGHEI, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0F80", Offset = "0x5DB0180", VA = "0x185DB0F80")]
	private void ANGEEGJGALL(GBJKMOINFOC AENILMDGHEI, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2350", Offset = "0x5DB1550", VA = "0x185DB2350")]
	private void LLNJDALOLHO(GBJKMOINFOC AENILMDGHEI, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1AC0", Offset = "0x5DB0CC0", VA = "0x185DB1AC0")]
	private void IMMBPMGFNLK(GBJKMOINFOC HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB21B0", Offset = "0x5DB13B0", VA = "0x185DB21B0")]
	private void LLFAHOEJMNE(GBJKMOINFOC HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB18C0", Offset = "0x5DB0AC0", VA = "0x185DB18C0")]
	private void IDFKPIHFMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0EB0", Offset = "0x5DB00B0", VA = "0x185DB0EB0")]
	private void AHKEMAPAOFL(GBJKMOINFOC HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2DA0", Offset = "0x5DB1FA0", VA = "0x185DB2DA0")]
	private void OHJIBAKBIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1F40", Offset = "0x5DB1140", VA = "0x185DB1F40")]
	private void KPDBLCMOHKN(GBJKMOINFOC GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2BD0", Offset = "0x5DB1DD0", VA = "0x185DB2BD0")]
	private void NIHOLBFKPBD(GBJKMOINFOC GPIDMMLMBCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class CNMIFFICNCD
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DB62E0", Offset = "0x5DB54E0", VA = "0x185DB62E0")]
	public static BAJJPHKKNBE CNLJLEIOHON(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class GBJKMOINFOC : MKICEPDICHP, IMJFMCOALGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal JGIPKANALKC OHEAHNOBDOM;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0230", Offset = "0x5DBF430", VA = "0x185DC0230")]
	public GBJKMOINFOC(GameObject JBOGCBPFIGA, RigidbodyEx FBBMNDLDAFE, FCNEAIBMEDD EKDODOMDNPH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFC60", Offset = "0x5DBEE60", VA = "0x185DBFC60", Slot = "143")]
	protected override void FBJDAJDJKHB(FCNEAIBMEDD EKDODOMDNPH, IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFA10", Offset = "0x5DBEC10", VA = "0x185DBFA10", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFBA0", Offset = "0x5DBEDA0", VA = "0x185DBFBA0", Slot = "147")]
	public void EFJNOPFEDKF(HBPAECLBINE EHCPBLKKGBB, HBPAECLBINE LNFLJFBBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0000", Offset = "0x5DBF200", VA = "0x185DC0000", Slot = "148")]
	public void KAENIFBAEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFF40", Offset = "0x5DBF140", VA = "0x185DBFF40", Slot = "149")]
	public void FJACKOGDDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF770", Offset = "0x5DBE970", VA = "0x185DBF770", Slot = "150")]
	public void AHICLPFGLCJ(bool KNONAIJGIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC00C0", Offset = "0x5DBF2C0", VA = "0x185DC00C0", Slot = "151")]
	public bool OEHEIEJIBDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF710", Offset = "0x5DBE910", VA = "0x185DBF710", Slot = "152")]
	public void ACOJLPEFOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "146")]
	protected override void AFEACLBNLDI(RigidbodyEx AGKOCALGANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF7D0", Offset = "0x5DBE9D0", VA = "0x185DBF7D0")]
	private void CAIOOMDLGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "145")]
	public override void NBOBGDMCJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class LOFNCOHKBBK
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB170", Offset = "0x5DCA370", VA = "0x185DCB170")]
	public static MKICEPDICHP EJDHAOBFBEK(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class DPNNFFFBDIM : IOEKFFKLHDF, NLFLFCCLOME
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string JODGJCFBJFB = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool KNNOOAEDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB410", Offset = "0x5DBA610", VA = "0x185DBB410", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public IICIADPPFLC ECEMFLGGPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB130", Offset = "0x5DBA330", VA = "0x185DBB130", Slot = "5")]
		get
		{
			return default(IICIADPPFLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private IICIADPPFLC AJLAFKMGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB240", Offset = "0x5DBA440", VA = "0x185DBB240")]
		get
		{
			return default(IICIADPPFLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAD70", Offset = "0x5DB9F70", VA = "0x185DBAD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB4E0", Offset = "0x5DBA6E0", VA = "0x185DBB4E0")]
	public DPNNFFFBDIM(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAF40", Offset = "0x5DBA140", VA = "0x185DBAF40", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAE60", Offset = "0x5DBA060", VA = "0x185DBAE60")]
	private bool DFBGCONLDOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB140", Offset = "0x5DBA340", VA = "0x185DBB140", Slot = "7")]
	public void IHCEJFDOOMF(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB310", Offset = "0x5DBA510", VA = "0x185DBB310", Slot = "8")]
	public void LDOPGGGMFMN(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAAD0", Offset = "0x5DB9CD0", VA = "0x185DBAAD0", Slot = "11")]
	public void BNPOJJLMFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB040", Offset = "0x5DBA240", VA = "0x185DBB040")]
	private void FFJEFMJJIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBABE0", Offset = "0x5DB9DE0", VA = "0x185DBABE0")]
	private void CBFPFDFHFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAF00", Offset = "0x5DBA100", VA = "0x185DBAF00", Slot = "10")]
	public void DFPLEIOIFBP(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB000", Offset = "0x5DBA200", VA = "0x185DBB000", Slot = "9")]
	public void FADGMIMJNFJ(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class NEJKDGPJLBA : IOEKFFKLHDF, NOBGAICGEJB
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x702CAE0", Offset = "0x702BCE0", VA = "0x18702CAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x702C660", Offset = "0x702B860", VA = "0x18702C660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x702C0D0", Offset = "0x702B2D0", VA = "0x18702C0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x702C600", Offset = "0x702B800", VA = "0x18702C600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x702CB00", Offset = "0x702BD00", VA = "0x18702CB00")]
	public NEJKDGPJLBA(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x702C420", Offset = "0x702B620", VA = "0x18702C420", Slot = "4")]
	public void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x702C680", Offset = "0x702B880", VA = "0x18702C680")]
	private void FFKNFNOMOAE(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x702C0F0", Offset = "0x702B2F0", VA = "0x18702C0F0", Slot = "5")]
	public void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x702C300", Offset = "0x702B500", VA = "0x18702C300", Slot = "6")]
	public void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x702C8E0", Offset = "0x702BAE0", VA = "0x18702C8E0")]
	private void HECKJEEECBJ(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x702BED0", Offset = "0x702B0D0", VA = "0x18702BED0", Slot = "7")]
	public void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x702C510", Offset = "0x702B710", VA = "0x18702C510")]
	private void DJGNNKLAGEN(string CEOMJLPEFPB, UnityEngine.Object APPLJOFCBIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class JHBPMBIJOOG : IOEKFFKLHDF, IFKPEHMIIAE
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string GPBIGEPGAIB = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9050", Offset = "0x5DC8250", VA = "0x185DC9050", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8F60", Offset = "0x5DC8160", VA = "0x185DC8F60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE470", Offset = "0x5DBD670", VA = "0x185DBE470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8D90", Offset = "0x5DC7F90", VA = "0x185DC8D90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9120", Offset = "0x5DC8320", VA = "0x185DC9120")]
	public JHBPMBIJOOG(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8950", Offset = "0x5DC7B50", VA = "0x185DC8950", Slot = "5")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC83E0", Offset = "0x5DC75E0", VA = "0x185DC83E0", Slot = "7")]
	public void AHHNEFEMJBL(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8E60", Offset = "0x5DC8060", VA = "0x185DC8E60", Slot = "8")]
	public void NHIAMLHBBKK(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5DC84E0", Offset = "0x5DC76E0", VA = "0x185DC84E0", Slot = "9")]
	public void AJEODGHNGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8180", Offset = "0x5DC7380", VA = "0x185DC8180", Slot = "10")]
	public void AANGCODMKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8BC0", Offset = "0x5DC7DC0", VA = "0x185DC8BC0", Slot = "11")]
	public void MHMFDJGLBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "12")]
	public void JIBNAFINNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8790", Offset = "0x5DC7990", VA = "0x185DC8790")]
	private void EMDJPJMLIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8A00", Offset = "0x5DC7C00", VA = "0x185DC8A00")]
	private void GICAEHDPIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class DPDOJHOBCAP : IOEKFFKLHDF, FMNKNKOFCJB
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA400", Offset = "0x5DB9600", VA = "0x185DBA400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> IPBGMBDIEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA150", Offset = "0x5DB9350", VA = "0x185DBA150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool MDECFGGEDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA590", Offset = "0x5DB9790", VA = "0x185DBA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event GGFJJGDFDOL LKLHEFBCDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA9F0", Offset = "0x5DB9BF0", VA = "0x185DBA9F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA660", Offset = "0x5DB9860", VA = "0x185DBA660", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public DPDOJHOBCAP(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA4D0", Offset = "0x5DB96D0", VA = "0x185DBA4D0", Slot = "12")]
	public IDisposable GKKIKONAHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA9E0", Offset = "0x5DB9BE0", VA = "0x185DBA9E0", Slot = "9")]
	public void PAGBFNPKBII(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA700", Offset = "0x5DB9900", VA = "0x185DBA700", Slot = "10")]
	public void KIPDDJGDEBM(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA8E0", Offset = "0x5DB9AE0", VA = "0x185DBA8E0", Slot = "11")]
	public void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA710", Offset = "0x5DB9910", VA = "0x185DBA710", Slot = "13")]
	public void KKPDPGPFBOI(Rigidbody IKACAOHCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA220", Offset = "0x5DB9420", VA = "0x185DBA220", Slot = "14")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAA90", Offset = "0x5DB9C90", VA = "0x185DBAA90", Slot = "6")]
	public void PMJEMNGDFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JBKLJFHLCCJ : IOEKFFKLHDF, LIAOGPGONHC
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode NKFKAMFOCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7750", Offset = "0x5DC6950", VA = "0x185DC7750")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5DC73E0", Offset = "0x5DC65E0", VA = "0x185DC73E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5400", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC74D0", Offset = "0x5DC66D0", VA = "0x185DC74D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7940", Offset = "0x5DC6B40", VA = "0x185DC7940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public JBKLJFHLCCJ(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7830", Offset = "0x5DC6A30", VA = "0x185DC7830", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5DC79C0", Offset = "0x5DC6BC0", VA = "0x185DC79C0", Slot = "9")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7820", Offset = "0x5DC6A20", VA = "0x185DC7820", Slot = "7")]
	public void EJCEDILLBAA(bool PJOPHEEFJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC73D0", Offset = "0x5DC65D0", VA = "0x185DC73D0", Slot = "8")]
	public void AIMGIJDMLFA(bool PJOPHEEFJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC75E0", Offset = "0x5DC67E0", VA = "0x185DC75E0", Slot = "10")]
	public bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7A50", Offset = "0x5DC6C50", VA = "0x185DC7A50")]
	private void MCNIBHPALOF(bool PJOPHEEFJLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class JFMODMHGJEO : IReadOnlyList<FHNBDEAMHEB>, IEnumerable<FHNBDEAMHEB>, IEnumerable, IReadOnlyCollection<FHNBDEAMHEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly JGIPKANALKC FLCEELNBPDO;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7E40", Offset = "0x5DC7040", VA = "0x185DC7E40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public FHNBDEAMHEB LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7F10", Offset = "0x5DC7110", VA = "0x185DC7F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7DF0", Offset = "0x5DC6FF0", VA = "0x185DC7DF0")]
	public JFMODMHGJEO(NGBBJMBOBME IHKJNNPMCLD, JGIPKANALKC FLCEELNBPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7C50", Offset = "0x5DC6E50", VA = "0x185DC7C50", Slot = "6")]
	public IEnumerator<FHNBDEAMHEB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7C50", Offset = "0x5DC6E50", VA = "0x185DC7C50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5DC7DE0", Offset = "0x5DC6FE0", VA = "0x185DC7DE0")]
	[CompilerGenerated]
	private FHNBDEAMHEB NHDEILLOGDE(int PPKKHBJMHLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HKFNHFGJHBE : GCANJDLOKJD
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1860", Offset = "0x5DC0A60", VA = "0x185DC1860", Slot = "4")]
	public PFMKIIEBHIJ HEMDOAPHKFI(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5DC17C0", Offset = "0x5DC09C0", VA = "0x185DC17C0", Slot = "5")]
	public AGOPKIGJDAN GLLNFANKKFN(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5DC13E0", Offset = "0x5DC05E0", VA = "0x185DC13E0", Slot = "6")]
	public LKIOGGAEKIC CALGOGKFNIH(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1480", Offset = "0x5DC0680", VA = "0x185DC1480", Slot = "7")]
	public MMJPCNKBKEM CCPHAHONOKG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1BD0", Offset = "0x5DC0DD0", VA = "0x185DC1BD0", Slot = "8")]
	public CHEOOBBEMFC OJJKKIGPPEP(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1B30", Offset = "0x5DC0D30", VA = "0x185DC1B30", Slot = "9")]
	public HEHINKJOIEI ODPFFBHCNLM(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1A90", Offset = "0x5DC0C90", VA = "0x185DC1A90", Slot = "10")]
	public FMNKNKOFCJB NHIGILKLPJF(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1A30", Offset = "0x5DC0C30", VA = "0x185DC1A30", Slot = "11")]
	public NOBGAICGEJB JHMIEKGOOIE(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1C30", Offset = "0x5DC0E30", VA = "0x185DC1C30", Slot = "12")]
	public LIAOGPGONHC PHJGNDMOPMG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1520", Offset = "0x5DC0720", VA = "0x185DC1520", Slot = "13")]
	public FAFKPGMJFPN CNBEFPEFMLJ(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1580", Offset = "0x5DC0780", VA = "0x185DC1580")]
	public IFKPEHMIIAE OGMLPKKNBFD(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1290", Offset = "0x5DC0490", VA = "0x185DC1290")]
	public ELNBNKMGOPL BHLKLHMNDNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1640", Offset = "0x5DC0840", VA = "0x185DC1640")]
	public NLFLFCCLOME LBHJCJMBFCB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1370", Offset = "0x5DC0570", VA = "0x185DC1370")]
	public FGEFEOBFMEO EBDINONEKCL(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1300", Offset = "0x5DC0500", VA = "0x185DC1300")]
	public OBBACJNIACD CLMMDHOKHNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1170", Offset = "0x5DC0370", VA = "0x185DC1170", Slot = "19")]
	public FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ, FCNEAIBMEDD EKDODOMDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public HKFNHFGJHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1580", Offset = "0x5DC0780", VA = "0x185DC1580", Slot = "14")]
	private IFKPEHMIIAE ELANDPKKANE(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1290", Offset = "0x5DC0490", VA = "0x185DC1290", Slot = "15")]
	private ELNBNKMGOPL NEFOGGLKMJB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1640", Offset = "0x5DC0840", VA = "0x185DC1640", Slot = "16")]
	private NLFLFCCLOME FKAFGLIBCEP(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1370", Offset = "0x5DC0570", VA = "0x185DC1370", Slot = "17")]
	private FGEFEOBFMEO BLHCLECMJBG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1300", Offset = "0x5DC0500", VA = "0x185DC1300", Slot = "18")]
	private OBBACJNIACD BJJDFJIKIIG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class FHLFANDHEDB : IOEKFFKLHDF, CHEOOBBEMFC
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int GCDDJECPCHH = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float ALBFOIHKKGJ = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float JDDPIKHJEPI = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float DHKPIAODGFM = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5400", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool GDPDFLAPJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDD80", Offset = "0x5DBCF80", VA = "0x185DBDD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5DACB20", Offset = "0x5DABD20", VA = "0x185DACB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD3C0", Offset = "0x5DBC5C0", VA = "0x185DBD3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD260", Offset = "0x5DBC460", VA = "0x185DBD260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool HEAPGNAIJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDF80", Offset = "0x5DBD180", VA = "0x185DBDF80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD980", Offset = "0x5DBCB80", VA = "0x185DBD980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool PGDHGPIDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDC10", Offset = "0x5DBCE10", VA = "0x185DBDC10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD2D0", Offset = "0x5DBC4D0", VA = "0x185DBD2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int DHCOINHMFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD6F0", Offset = "0x5DBC8F0", VA = "0x185DBD6F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDB20", Offset = "0x5DBCD20", VA = "0x185DBDB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event GGFJJGDFDOL MLEMLFIBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDCE0", Offset = "0x5DBCEE0", VA = "0x185DBDCE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD1C0", Offset = "0x5DBC3C0", VA = "0x185DBD1C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE050", Offset = "0x5DBD250", VA = "0x185DBE050")]
	public FHLFANDHEDB(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD640", Offset = "0x5DBC840", VA = "0x185DBD640", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD2C0", Offset = "0x5DBC4C0", VA = "0x185DBD2C0", Slot = "8")]
	public void BMHMIEOIPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD420", Offset = "0x5DBC620", VA = "0x185DBD420", Slot = "7")]
	public bool EFNEMBNMAEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD110", Offset = "0x5DBC310", VA = "0x185DBD110", Slot = "9")]
	public void AAPGHPCNAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAA90", Offset = "0x5DB9C90", VA = "0x185DBAA90", Slot = "12")]
	public void AHICLPFGLCJ(bool KNONAIJGIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDA70", Offset = "0x5DBCC70", VA = "0x185DBDA70", Slot = "11")]
	public void HLCJDLAAPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "10")]
	public void DMMBGNPNKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD7C0", Offset = "0x5DBC9C0", VA = "0x185DBD7C0")]
	private bool GNDPDCCFMFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDE20", Offset = "0x5DBD020", VA = "0x185DBDE20")]
	private void NEKGGMNPONH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KJPIDBGIKDC(typeof(GCANJDLOKJD), new string[] { })]
public class FEHMLALJIHF : GCANJDLOKJD, FHPOLFAIAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly GCANJDLOKJD HFMKBEJIJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GCANJDLOKJD IFMGBKNCLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private BFPPGIPJGJM CKPHAGCJAEF;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private GCANJDLOKJD BNDIGIEEPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5DBCD90", Offset = "0x5DBBF90", VA = "0x185DBCD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCCA0", Offset = "0x5DBBEA0", VA = "0x185DBCCA0", Slot = "20")]
	public void InitReferences(EJCDFCAJDED KJDFKKLNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCC00", Offset = "0x5DBBE00", VA = "0x185DBCC00", Slot = "4")]
	public PFMKIIEBHIJ HEMDOAPHKFI(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCB60", Offset = "0x5DBBD60", VA = "0x185DBCB60", Slot = "5")]
	public AGOPKIGJDAN GLLNFANKKFN(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC820", Offset = "0x5DBBA20", VA = "0x185DBC820", Slot = "6")]
	public LKIOGGAEKIC CALGOGKFNIH(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC8C0", Offset = "0x5DBBAC0", VA = "0x185DBC8C0", Slot = "7")]
	public MMJPCNKBKEM CCPHAHONOKG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCF30", Offset = "0x5DBC130", VA = "0x185DBCF30", Slot = "8")]
	public CHEOOBBEMFC OJJKKIGPPEP(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCE90", Offset = "0x5DBC090", VA = "0x185DBCE90", Slot = "9")]
	public HEHINKJOIEI ODPFFBHCNLM(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCDF0", Offset = "0x5DBBFF0", VA = "0x185DBCDF0", Slot = "10")]
	public FMNKNKOFCJB NHIGILKLPJF(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCCF0", Offset = "0x5DBBEF0", VA = "0x185DBCCF0", Slot = "11")]
	public NOBGAICGEJB JHMIEKGOOIE(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCFD0", Offset = "0x5DBC1D0", VA = "0x185DBCFD0", Slot = "12")]
	public LIAOGPGONHC PHJGNDMOPMG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC960", Offset = "0x5DBBB60", VA = "0x185DBC960", Slot = "13")]
	public FAFKPGMJFPN CNBEFPEFMLJ(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCA00", Offset = "0x5DBBC00", VA = "0x185DBCA00")]
	public IFKPEHMIIAE OGMLPKKNBFD(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC610", Offset = "0x5DBB810", VA = "0x185DBC610")]
	public ELNBNKMGOPL BHLKLHMNDNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCAB0", Offset = "0x5DBBCB0", VA = "0x185DBCAB0")]
	public NLFLFCCLOME LBHJCJMBFCB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC770", Offset = "0x5DBB970", VA = "0x185DBC770")]
	public FGEFEOBFMEO EBDINONEKCL(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC6C0", Offset = "0x5DBB8C0", VA = "0x185DBC6C0")]
	public OBBACJNIACD CLMMDHOKHNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4C0", Offset = "0x5DBB6C0", VA = "0x185DBC4C0", Slot = "19")]
	public FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ, FCNEAIBMEDD EKDODOMDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD070", Offset = "0x5DBC270", VA = "0x185DBD070")]
	public FEHMLALJIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCA00", Offset = "0x5DBBC00", VA = "0x185DBCA00", Slot = "14")]
	private IFKPEHMIIAE ELANDPKKANE(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC610", Offset = "0x5DBB810", VA = "0x185DBC610", Slot = "15")]
	private ELNBNKMGOPL NEFOGGLKMJB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5DBCAB0", Offset = "0x5DBBCB0", VA = "0x185DBCAB0", Slot = "16")]
	private NLFLFCCLOME FKAFGLIBCEP(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC770", Offset = "0x5DBB970", VA = "0x185DBC770", Slot = "17")]
	private FGEFEOBFMEO BLHCLECMJBG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC6C0", Offset = "0x5DBB8C0", VA = "0x185DBC6C0", Slot = "18")]
	private OBBACJNIACD BJJDFJIKIIG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NFCJEADMCFP : IOEKFFKLHDF, FAFKPGMJFPN
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x702CDD0", Offset = "0x702BFD0", VA = "0x18702CDD0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x702CB50", Offset = "0x702BD50", VA = "0x18702CB50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x702CB00", Offset = "0x702BD00", VA = "0x18702CB00")]
	public NFCJEADMCFP(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x702CCC0", Offset = "0x702BEC0", VA = "0x18702CCC0", Slot = "6")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x702CB10", Offset = "0x702BD10", VA = "0x18702CB10", Slot = "7")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class IOEKFFKLHDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly GBJKMOINFOC GPIDMMLMBCH;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected JGIPKANALKC AGAILMAIBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1058820", Offset = "0x1057A20", VA = "0x181058820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5DC37A0", Offset = "0x5DC29A0", VA = "0x185DC37A0")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public IOEKFFKLHDF(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5DC37D0", Offset = "0x5DC29D0", VA = "0x185DC37D0")]
	protected FHNBDEAMHEB OAKDLCDAGJC(NGBBJMBOBME IHKJNNPMCLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class PFJGFBNNAHI : IOEKFFKLHDF, ELNBNKMGOPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView LCDKDJPKHHN;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6410", Offset = "0x5DB5610", VA = "0x185DB6410", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x702EC30", Offset = "0x702DE30", VA = "0x18702EC30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event GGFJJGDFDOL FIBKICHDLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x702F3D0", Offset = "0x702E5D0", VA = "0x18702F3D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x702E9B0", Offset = "0x702DBB0", VA = "0x18702E9B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x702F5E0", Offset = "0x702E7E0", VA = "0x18702F5E0")]
	public PFJGFBNNAHI(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x702F160", Offset = "0x702E360", VA = "0x18702F160", Slot = "8")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x702EDF0", Offset = "0x702DFF0", VA = "0x18702EDF0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x702F470", Offset = "0x702E670", VA = "0x18702F470", Slot = "9")]
	public void OLODEADKFLH(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x702EFF0", Offset = "0x702E1F0", VA = "0x18702EFF0", Slot = "10")]
	public void EBCGGBKPGJF(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x702F2B0", Offset = "0x702E4B0", VA = "0x18702F2B0")]
	private void JJAACIKJOJH(PhotonView PIAAAECOJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x702ED60", Offset = "0x702DF60", VA = "0x18702ED60")]
	private void DNCHGJMGICB(RigidbodyEx LNKBJHMGJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x702EA50", Offset = "0x702DC50", VA = "0x18702EA50")]
	private void CGCBAJGBBGN(PhotonView PAFFOGONHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class ALANGDFMPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0D50", Offset = "0x5DAFF50", VA = "0x185DB0D50")]
	public static PFJGFBNNAHI HGOKJGNNGDD(this MKICEPDICHP NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LPMEBEOIBIH : IOEKFFKLHDF, OBBACJNIACD
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB570", Offset = "0x5DCA770", VA = "0x185DCB570", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB390", Offset = "0x5DCA590", VA = "0x185DCB390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool FKHCPFDHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB950", Offset = "0x5DCAB50", VA = "0x185DCB950", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB480", Offset = "0x5DCA680", VA = "0x185DCB480")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB1C0", Offset = "0x5DCA3C0", VA = "0x185DCB1C0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB640", Offset = "0x5DCA840", VA = "0x185DCB640", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBA20", Offset = "0x5DCAC20", VA = "0x185DCBA20")]
	public LPMEBEOIBIH(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB850", Offset = "0x5DCAA50", VA = "0x185DCB850", Slot = "9")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB290", Offset = "0x5DCA490", VA = "0x185DCB290", Slot = "10")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class IBNPLDOBHJB : IOEKFFKLHDF, HEHINKJOIEI, IDisposable, OALPABPCAMP
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public GFOBGKKNJAL DFHAAPOALAF
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC24A0", Offset = "0x5DC16A0", VA = "0x185DC24A0")]
		get
		{
			return default(GFOBGKKNJAL);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2920", Offset = "0x5DC1B20", VA = "0x185DC2920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2610", Offset = "0x5DC1810", VA = "0x185DC2610", Slot = "6")]
		get
		{
			return default(GFOBGKKNJAL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2920", Offset = "0x5DC1B20", VA = "0x185DC2920", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform MKAJCMPOLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2570", Offset = "0x5DC1770", VA = "0x185DC2570", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2820", Offset = "0x5DC1A20", VA = "0x185DC2820", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0670", Offset = "0x5DAF870", VA = "0x185DB0670")]
	public IBNPLDOBHJB(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DC28C0", Offset = "0x5DC1AC0", VA = "0x185DC28C0", Slot = "11")]
	public void OnChangedDistanceBand(GHPGHMJFCDB EHCPBLKKGBB, GHPGHMJFCDB LNFLJFBBBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "12")]
	public void OnChangedVisibility(bool IIKBBCLGIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PCKIMAILGOJ : HEHINKJOIEI, IDisposable, OALPABPCAMP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int DPKIGFCELGK = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private GFOBGKKNJAL HBGFMKOLKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private MNJBPEDMMOI CFJIIDACMBH;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public GFOBGKKNJAL KNFCMCCHCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x702E1D0", Offset = "0x702D3D0", VA = "0x18702E1D0", Slot = "6")]
		get
		{
			return default(GFOBGKKNJAL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x702E3A0", Offset = "0x702D5A0", VA = "0x18702E3A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform MKAJCMPOLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x702E2E0", Offset = "0x702D4E0", VA = "0x18702E2E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GHPGHMJFCDB, GHPGHMJFCDB> GGDKIDJAMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x702E130", Offset = "0x702D330", VA = "0x18702E130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x702E300", Offset = "0x702D500", VA = "0x18702E300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x702E470", Offset = "0x702D670", VA = "0x18702E470")]
	public PCKIMAILGOJ(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x702DED0", Offset = "0x702D0D0", VA = "0x18702DED0", Slot = "8")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x702DE80", Offset = "0x702D080", VA = "0x18702DE80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x702E280", Offset = "0x702D480", VA = "0x18702E280", Slot = "11")]
	private void MMBBECIJNEH(GHPGHMJFCDB OEGGKGEGFCG, GHPGHMJFCDB ADBHMIOECLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "12")]
	private void PBODEKHENLI(bool IIKBBCLGIMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class DCMBIPDMPDE : GJMOFFLDDGM, ELNBNKMGOPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView LCDKDJPKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool OEJDKJGDGON;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView ONMILLMBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool EOLCHPPJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6410", Offset = "0x5DB5610", VA = "0x185DB6410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool MHCBOOIEHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event GGFJJGDFDOL FIBKICHDLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6DB0", Offset = "0x5DB5FB0", VA = "0x185DB6DB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6370", Offset = "0x5DB5570", VA = "0x185DB6370", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6FE0", Offset = "0x5DB61E0", VA = "0x185DB6FE0")]
	public DCMBIPDMPDE(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6AE0", Offset = "0x5DB5CE0", VA = "0x185DB6AE0", Slot = "9")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6840", Offset = "0x5DB5A40", VA = "0x185DB6840", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6E50", Offset = "0x5DB6050", VA = "0x185DB6E50", Slot = "10")]
	public void OLODEADKFLH(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6950", Offset = "0x5DB5B50", VA = "0x185DB6950", Slot = "11")]
	public void EBCGGBKPGJF(FHNBDEAMHEB BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6C30", Offset = "0x5DB5E30", VA = "0x185DB6C30")]
	private void JJAACIKJOJH(PhotonView PIAAAECOJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB66C0", Offset = "0x5DB58C0", VA = "0x185DB66C0")]
	private void DNCHGJMGICB(RigidbodyEx LNKBJHMGJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6430", Offset = "0x5DB5630", VA = "0x185DB6430")]
	private void CGCBAJGBBGN(PhotonView PAFFOGONHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class KNBKIDOFBIM
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB020", Offset = "0x5DCA220", VA = "0x185DCB020")]
	public static GJMOFFLDDGM HGOKJGNNGDD(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FMMPDIFCLML : IFKPEHMIIAE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string GPBIGEPGAIB = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly COJCOIOHKKE MOGAGJEHFEH;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE470", Offset = "0x5DBD670", VA = "0x185DBE470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool NCNGBJLGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x15BAD90", Offset = "0x15B9F90", VA = "0x1815BAD90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF290", Offset = "0x5DBE490", VA = "0x185DBF290")]
	public FMMPDIFCLML(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE9E0", Offset = "0x5DBDBE0", VA = "0x185DBE9E0", Slot = "5")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE440", Offset = "0x5DBD640", VA = "0x185DBE440", Slot = "7")]
	public void AHHNEFEMJBL(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF260", Offset = "0x5DBE460", VA = "0x185DBF260", Slot = "8")]
	public void NHIAMLHBBKK(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE4D0", Offset = "0x5DBD6D0", VA = "0x185DBE4D0", Slot = "9")]
	public void AJEODGHNGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE240", Offset = "0x5DBD440", VA = "0x185DBE240", Slot = "10")]
	public void AANGCODMKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF0E0", Offset = "0x5DBE2E0", VA = "0x185DBF0E0", Slot = "11")]
	public void MHMFDJGLBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEC40", Offset = "0x5DBDE40", VA = "0x185DBEC40", Slot = "12")]
	public void JIBNAFINNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE830", Offset = "0x5DBDA30", VA = "0x185DBE830")]
	private void EMDJPJMLIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBEA90", Offset = "0x5DBDC90", VA = "0x185DBEA90")]
	private void GICAEHDPIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class NCONIKBKOHE : OBBACJNIACD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints JOOHJHIIMEO;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool KOFLMFHCALF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x948350", Offset = "0x947550", VA = "0x180948350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x948360", Offset = "0x947560", VA = "0x180948360", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FKHCPFDHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3628470", Offset = "0x3627670", VA = "0x183628470", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3628710", Offset = "0x3627910", VA = "0x183628710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints CJADFHEMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B0", Offset = "0x8D78B0", VA = "0x1808D86B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x702BD60", Offset = "0x702AF60", VA = "0x18702BD60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x702BE70", Offset = "0x702B070", VA = "0x18702BE70")]
	public NCONIKBKOHE(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x702BE40", Offset = "0x702B040", VA = "0x18702BE40", Slot = "9")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x702BD30", Offset = "0x702AF30", VA = "0x18702BD30", Slot = "10")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class ICNPNICPCLO : NOBGAICGEJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5400", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3250", Offset = "0x5DC2450", VA = "0x185DC3250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE470", Offset = "0x5DBD670", VA = "0x185DBE470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DC31F0", Offset = "0x5DC23F0", VA = "0x185DC31F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6250", Offset = "0x5DB5450", VA = "0x185DB6250")]
	public ICNPNICPCLO(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3090", Offset = "0x5DC2290", VA = "0x185DC3090", Slot = "4")]
	public void DGONECHDAED(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC32A0", Offset = "0x5DC24A0", VA = "0x185DC32A0")]
	private void FFKNFNOMOAE(Vector3 PPHFAHHOGGC, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2C90", Offset = "0x5DC1E90", VA = "0x185DC2C90", Slot = "5")]
	public void AIOHFAAFLDM(Vector3 PPHFAHHOGGC, Vector3 FNDKHLEFPKD, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2F30", Offset = "0x5DC2130", VA = "0x185DC2F30", Slot = "6")]
	public void CLIHKOOOLOE(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DC3520", Offset = "0x5DC2720", VA = "0x185DC3520")]
	private void HECKJEEECBJ(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2A10", Offset = "0x5DC1C10", VA = "0x185DC2A10", Slot = "7")]
	public void AAAGJPPNBMP(Vector3 JJBOADLMOLF, ForceMode ICLPCOGIDHO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class GPAABELKGFA : FOGNDPKOOND, LKIOGGAEKIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NBCHNIBNMAN<FHNBDEAMHEB> JDINCIJPANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool MJPKOPMDAMG;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public NBCHNIBNMAN<FHNBDEAMHEB> OLLEMLMOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 EIBBHIJAOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC03E0", Offset = "0x5DBF5E0", VA = "0x185DC03E0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 DGICHNILJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0410", Offset = "0x5DBF610", VA = "0x185DC0410", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0300", Offset = "0x5DBF500", VA = "0x185DC0300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public FHNBDEAMHEB JACGBJIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0A00", Offset = "0x5DBFC00", VA = "0x185DC0A00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0E40", Offset = "0x5DC0040", VA = "0x185DC0E40")]
	public GPAABELKGFA(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DC05E0", Offset = "0x5DBF7E0", VA = "0x185DC05E0", Slot = "8")]
	public void IKOCFBIKAHJ(FHNBDEAMHEB BLFIAOLNAKG, object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0DE0", Offset = "0x5DBFFE0", VA = "0x185DC0DE0", Slot = "9")]
	public void NLBPNCFPMKI(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0AB0", Offset = "0x5DBFCB0", VA = "0x185DC0AB0")]
	private Vector3 NLBIPAKFCDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0650", Offset = "0x5DBF850", VA = "0x185DC0650")]
	private void MKDPGEIGJII(FHNBDEAMHEB HMOLIPANNCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class GBGMEHKNLPN
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF650", Offset = "0x5DBE850", VA = "0x185DBF650")]
	public static FOGNDPKOOND PKIELMBNJAI(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class CDHFOEICDCH : IMDHJAAAKHB, FGEFEOBFMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 GFKCALECFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 BHFPPDDOIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float GPLFMODDLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float HLEHAADLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 MBCMMFGMJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? DOKMFKLPCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? LNNJDCHLNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool KFBJMKPFJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool BJPODNNIANM;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 HMELIEOKKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4A73430", Offset = "0x4A72630", VA = "0x184A73430", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3540", Offset = "0x5DB2740", VA = "0x185DB3540", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 GECHJLCLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4A80", Offset = "0x5DB3C80", VA = "0x185DB4A80", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float AGKLFCANLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xB9E450", Offset = "0xB9D650", VA = "0x180B9E450", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB46C0", Offset = "0x5DB38C0", VA = "0x185DB46C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float INIFCENOADO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x18EA630", Offset = "0x18E9830", VA = "0x1818EA630", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4390", Offset = "0x5DB3590", VA = "0x185DB4390", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 MLNJGKAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3830", Offset = "0x5DB2A30", VA = "0x185DB3830", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion LPAPHOKEEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4550", Offset = "0x5DB3750", VA = "0x185DB4550", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5AD0", Offset = "0x5DB4CD0", VA = "0x185DB5AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event GGFJJGDFDOL FIBGKOMFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB49E0", Offset = "0x5DB3BE0", VA = "0x185DB49E0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5A30", Offset = "0x5DB4C30", VA = "0x185DB5A30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5B20", Offset = "0x5DB4D20", VA = "0x185DB5B20")]
	public CDHFOEICDCH(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4050", Offset = "0x5DB3250", VA = "0x185DB4050", Slot = "17")]
	public void FANMDJHBJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB47E0", Offset = "0x5DB39E0", VA = "0x185DB47E0", Slot = "16")]
	public void KGBPBFPOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4900", Offset = "0x5DB3B00", VA = "0x185DB4900", Slot = "19")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3E60", Offset = "0x5DB3060", VA = "0x185DB3E60", Slot = "20")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3270", Offset = "0x5DB2470", VA = "0x185DB3270", Slot = "18")]
	public void AEMGHKEJANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB39A0", Offset = "0x5DB2BA0", VA = "0x185DB39A0", Slot = "21")]
	public void BOAPJJLOBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3540", Offset = "0x5DB2740", VA = "0x185DB3540")]
	private void ANHIFMCDJMG(Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4440", Offset = "0x5DB3640", VA = "0x185DB4440")]
	[Obsolete]
	private Vector3 HPGDOGACKDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5DB46C0", Offset = "0x5DB38C0", VA = "0x185DB46C0")]
	private void PGGPMDLOCHC(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4390", Offset = "0x5DB3590", VA = "0x185DB4390")]
	private void MDNPONPNOHP(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5DB33D0", Offset = "0x5DB25D0", VA = "0x185DB33D0")]
	private Vector3 AHHFFELCPOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5DB35F0", Offset = "0x5DB27F0", VA = "0x185DB35F0", Slot = "15")]
	public void BKIHBFBPPJM((Quaternion rot, Vector3 moments) NEODCFKLEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4220", Offset = "0x5DB3420", VA = "0x185DB4220")]
	private Quaternion GAONHIHALKO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5950", Offset = "0x5DB4B50", VA = "0x185DB5950")]
	public void NDBEBBMHLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4B90", Offset = "0x5DB3D90", VA = "0x185DB4B90", Slot = "4")]
	public (float, Vector3) NDBEBBMHLIJ(Rigidbody PPKNGDFCIBF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class JGBPKFBHOBE
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5DC80C0", Offset = "0x5DC72C0", VA = "0x185DC80C0")]
	public static IMDHJAAAKHB FGPKDFDPBEK(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FOGNDPKOOND : LKIOGGAEKIC
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	NBCHNIBNMAN<FHNBDEAMHEB> OLLEMLMOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	FHNBDEAMHEB JACGBJIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class DLOLNJMMLDI : AGOPKIGJDAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly COJCOIOHKKE CFDFDNBBLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float DCPKPCAHFIM;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public BPEIPBLOJDJ AIAEEJIPJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x841E50", Offset = "0x841050", VA = "0x180841E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public PMLEEIJAFOB FHNMDJMNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 PFODDFDLLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7410", Offset = "0x5DB6610", VA = "0x185DB7410", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7BA0", Offset = "0x5DB6DA0", VA = "0x185DB7BA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 BOFMHPLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7E20", Offset = "0x5DB7020", VA = "0x185DB7E20", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8E70", Offset = "0x5DB8070", VA = "0x185DB8E70", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 CPEEBGECIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5DB92D0", Offset = "0x5DB84D0", VA = "0x185DB92D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7650", Offset = "0x5DB6850", VA = "0x185DB7650", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 FCKFFKNPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9F80", Offset = "0x5DB9180", VA = "0x185DB9F80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8C00", Offset = "0x5DB7E00", VA = "0x185DB8C00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float IAKKMNHMMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xC7C840", Offset = "0xC7BA40", VA = "0x180C7C840", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7530", Offset = "0x5DB6730", VA = "0x185DB7530", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool NECPEADOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x17307C0", Offset = "0x172F9C0", VA = "0x1817307C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private NOBGAICGEJB IOKPJDDJGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2D72470", Offset = "0x2D71670", VA = "0x182D72470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5DACB20", Offset = "0x5DABD20", VA = "0x185DACB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA070", Offset = "0x5DB9270", VA = "0x185DBA070")]
	public DLOLNJMMLDI(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB73A0", Offset = "0x5DB65A0", VA = "0x185DB73A0", Slot = "19")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7F10", Offset = "0x5DB7110", VA = "0x185DB7F10", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9400", Offset = "0x5DB8600", VA = "0x185DB9400", Slot = "28")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1730390", Offset = "0x172F590", VA = "0x181730390", Slot = "20")]
	public void BBKKHGANADE(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x172FBB0", Offset = "0x172EDB0", VA = "0x18172FBB0", Slot = "31")]
	public void FKIIFGCGMLD(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9A80", Offset = "0x5DB8C80", VA = "0x185DB9A80", Slot = "36")]
	public Vector3 LMFFMMJIPGD(Vector3 DJDAAPHBCIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7C60", Offset = "0x5DB6E60", VA = "0x185DB7C60", Slot = "35")]
	public Vector3 CBNKDINHEOI(Vector3 GDHALLLEGNH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5DB73A0", Offset = "0x5DB65A0", VA = "0x185DB73A0", Slot = "27")]
	public void BEBHODJBOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9D80", Offset = "0x5DB8F80", VA = "0x185DB9D80", Slot = "25")]
	public void MJEIAKFJICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9290", Offset = "0x5DB8490", VA = "0x185DB9290", Slot = "24")]
	public void KFPNMMCLAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8C30", Offset = "0x5DB7E30", VA = "0x185DB8C30", Slot = "34")]
	public void ICCJDCALLDM(Vector3 ECPHDNGHLGO, Vector3 IGGDGKGHBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9C60", Offset = "0x5DB8E60", VA = "0x185DB9C60", Slot = "33")]
	public void MDIGKJJKKLM(Vector3 CKEEBIANPDM, Vector3 DFFBBKCFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8A60", Offset = "0x5DB7C60", VA = "0x185DB8A60", Slot = "32")]
	public void HHCCMGEPFLF(Vector3 KAKEDCFJIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8570", Offset = "0x5DB7770", VA = "0x185DB8570", Slot = "22")]
	public void GLMNHPAMICD(GMGFPGIHPLK NBCEJDONEJI, Vector3 COGAKAJFGAF, float ANAKPHCAOEM, float PGLDBCHLFNJ = 8f, float BFEEPDIHCPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9530", Offset = "0x5DB8730", VA = "0x185DB9530", Slot = "21")]
	public void KLDNFLFHLAD(CIBEODNAMJD MNCMJJBADJM, Vector3 NDKIIPDPNOL, float OIOCHNDJJHN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8F90", Offset = "0x5DB8190", VA = "0x185DB8F90", Slot = "23")]
	[Obsolete]
	public void JONIPENMAAN(CIBEODNAMJD MNCMJJBADJM, Vector3 AAECNILGNMA, float CNFNBDKBAIM = 7f, float OFLNNBPGMED = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9CC0", Offset = "0x5DB8EC0", VA = "0x185DB9CC0", Slot = "30")]
	public Vector3 MHEPDLGAMII(Vector3 ODDDGBEGEIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9DC0", Offset = "0x5DB8FC0", VA = "0x185DB9DC0", Slot = "29")]
	public Vector3 NHBCFGLGGNC(Vector3 KDIKDMAHLGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7710", Offset = "0x5DB6910", VA = "0x185DB7710", Slot = "26")]
	public void BOLNNPGGPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7530", Offset = "0x5DB6730", VA = "0x185DB7530")]
	private void BJGFFGOIPAN(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7200", Offset = "0x5DB6400", VA = "0x185DB7200")]
	private void AOBDPKNHBDJ(Vector3 NDKIIPDPNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8EA0", Offset = "0x5DB80A0", VA = "0x185DB8EA0")]
	private Vector3 JNIGIGDGPEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9760", Offset = "0x5DB8960", VA = "0x185DB9760")]
	private void LALGFNECJCH(Vector3 GDHALLLEGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7100", Offset = "0x5DB6300", VA = "0x185DB7100")]
	private Vector3 ACPPKAJDLPC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7870", Offset = "0x5DB6A70", VA = "0x185DB7870")]
	private void BPICNHONHFD(Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7F70", Offset = "0x5DB7170", VA = "0x185DB7F70")]
	private void ECACGDBACDA(Vector3 GDHALLLEGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9EC0", Offset = "0x5DB90C0", VA = "0x185DB9EC0")]
	private void NJJGFCIKFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class PCNBJDNAFJH : FMNKNKOFCJB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string HHOJJECOFAD = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly COJCOIOHKKE KKHPPMADAEA;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool AICOKMDIKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x702E500", Offset = "0x702D700", VA = "0x18702E500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> IPBGMBDIEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x702E4B0", Offset = "0x702D6B0", VA = "0x18702E4B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event GGFJJGDFDOL LKLHEFBCDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x702E840", Offset = "0x702DA40", VA = "0x18702E840", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x702E600", Offset = "0x702D800", VA = "0x18702E600", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x702E920", Offset = "0x702DB20", VA = "0x18702E920")]
	public PCNBJDNAFJH(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x702E5A0", Offset = "0x702D7A0", VA = "0x18702E5A0", Slot = "12")]
	public IDisposable GKKIKONAHNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x702E830", Offset = "0x702DA30", VA = "0x18702E830", Slot = "9")]
	public void PAGBFNPKBII(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x702E6A0", Offset = "0x702D8A0", VA = "0x18702E6A0", Slot = "10")]
	public void KIPDDJGDEBM(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x702E730", Offset = "0x702D930", VA = "0x18702E730", Slot = "11")]
	public void LIBHELDHJCC(object IBIKCCMDMHA, bool ONBIDCCJKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x702E8E0", Offset = "0x702DAE0", VA = "0x18702E8E0", Slot = "6")]
	public void PMJEMNGDFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x702E6B0", Offset = "0x702D8B0", VA = "0x18702E6B0", Slot = "13")]
	public void KKPDPGPFBOI(Rigidbody IKACAOHCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x702E4D0", Offset = "0x702D6D0", VA = "0x18702E4D0", Slot = "14")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class CNHDJOGKHCO : LIAOGPGONHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode IKKGJKMEBCC;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5400", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode PAGFGEDAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5C30", Offset = "0x5DB4E30", VA = "0x185DB5C30", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5FE0", Offset = "0x5DB51E0", VA = "0x185DB5FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6250", Offset = "0x5DB5450", VA = "0x185DB6250")]
	public CNHDJOGKHCO(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5EC0", Offset = "0x5DB50C0", VA = "0x185DB5EC0", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6050", Offset = "0x5DB5250", VA = "0x185DB6050", Slot = "9")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5EB0", Offset = "0x5DB50B0", VA = "0x185DB5EB0", Slot = "7")]
	public void EJCEDILLBAA(bool PJOPHEEFJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5C20", Offset = "0x5DB4E20", VA = "0x185DB5C20", Slot = "8")]
	public void AIMGIJDMLFA(bool PJOPHEEFJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5D40", Offset = "0x5DB4F40", VA = "0x185DB5D40", Slot = "10")]
	public bool DGPHFNEILBM(Vector3 DKILHHENEBB, out RaycastHit JMAFLOLMPFB, float GMDPDEIGPMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB60D0", Offset = "0x5DB52D0", VA = "0x185DB60D0")]
	private void MCNIBHPALOF(bool PJOPHEEFJLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PBIPMPBOMON : GCANJDLOKJD
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x702DBD0", Offset = "0x702CDD0", VA = "0x18702DBD0", Slot = "4")]
	public PFMKIIEBHIJ HEMDOAPHKFI(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x702DB70", Offset = "0x702CD70", VA = "0x18702DB70", Slot = "5")]
	public AGOPKIGJDAN GLLNFANKKFN(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x702D910", Offset = "0x702CB10", VA = "0x18702D910", Slot = "6")]
	public LKIOGGAEKIC CALGOGKFNIH(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x702D970", Offset = "0x702CB70", VA = "0x18702D970", Slot = "7")]
	public MMJPCNKBKEM CCPHAHONOKG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x702DDC0", Offset = "0x702CFC0", VA = "0x18702DDC0", Slot = "8")]
	public CHEOOBBEMFC OJJKKIGPPEP(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x702DD50", Offset = "0x702CF50", VA = "0x18702DD50", Slot = "9")]
	public HEHINKJOIEI ODPFFBHCNLM(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x702DC90", Offset = "0x702CE90", VA = "0x18702DC90", Slot = "10")]
	public FMNKNKOFCJB NHIGILKLPJF(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x702DC30", Offset = "0x702CE30", VA = "0x18702DC30", Slot = "11")]
	public NOBGAICGEJB JHMIEKGOOIE(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x702DE20", Offset = "0x702D020", VA = "0x18702DE20", Slot = "12")]
	public LIAOGPGONHC PHJGNDMOPMG(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x702D9D0", Offset = "0x702CBD0", VA = "0x18702D9D0", Slot = "13")]
	public FAFKPGMJFPN CNBEFPEFMLJ(FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x702DA30", Offset = "0x702CC30", VA = "0x18702DA30")]
	public IFKPEHMIIAE OGMLPKKNBFD(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x702D7A0", Offset = "0x702C9A0", VA = "0x18702D7A0")]
	public ELNBNKMGOPL BHLKLHMNDNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x702DAA0", Offset = "0x702CCA0", VA = "0x18702DAA0")]
	public NLFLFCCLOME LBHJCJMBFCB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x702D8A0", Offset = "0x702CAA0", VA = "0x18702D8A0")]
	public FGEFEOBFMEO EBDINONEKCL(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x702D810", Offset = "0x702CA10", VA = "0x18702D810")]
	public OBBACJNIACD CLMMDHOKHNN(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x702D6F0", Offset = "0x702C8F0", VA = "0x18702D6F0", Slot = "19")]
	public FHNBDEAMHEB BBKOLDNLFBG(RigidbodyEx GPIDMMLMBCH, IIKMLKNINKM JCEJEOAKGOJ, FCNEAIBMEDD EKDODOMDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public PBIPMPBOMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x702DA30", Offset = "0x702CC30", VA = "0x18702DA30", Slot = "14")]
	private IFKPEHMIIAE ELANDPKKANE(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x702D7A0", Offset = "0x702C9A0", VA = "0x18702D7A0", Slot = "15")]
	private ELNBNKMGOPL NEFOGGLKMJB(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x702DAA0", Offset = "0x702CCA0", VA = "0x18702DAA0", Slot = "16")]
	private NLFLFCCLOME FKAFGLIBCEP(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x702D8A0", Offset = "0x702CAA0", VA = "0x18702D8A0", Slot = "17")]
	private FGEFEOBFMEO BLHCLECMJBG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x702D810", Offset = "0x702CA10", VA = "0x18702D810", Slot = "18")]
	private OBBACJNIACD BJJDFJIKIIG(FHNBDEAMHEB NKLFKPOOEFB, in IIKMLKNINKM JCEJEOAKGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class KLHKCIINODA : NNAOJLCEMGA, PFMKIIEBHIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly FHNBDEAMHEB GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<FHNBDEAMHEB> OLFODNBFFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private FHNBDEAMHEB NPDELNKHCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private FHNBDEAMHEB BLFIAOLNAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform DEKEGCGFLDG;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9E20", Offset = "0x5DC9020", VA = "0x185DC9E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3B0", Offset = "0x8ED5B0", VA = "0x1808EE3B0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5DCAC40", Offset = "0x5DC9E40", VA = "0x185DCAC40", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public FHNBDEAMHEB HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<FHNBDEAMHEB> DJBINDFABOC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event GGFJJGDFDOL PGMCKJHNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5DCAB00", Offset = "0x5DC9D00", VA = "0x185DCAB00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5DCABA0", Offset = "0x5DC9DA0", VA = "0x185DCABA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event GGFJJGDFDOL LHDIMBKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9A80", Offset = "0x5DC8C80", VA = "0x185DC9A80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9D80", Offset = "0x5DC8F80", VA = "0x185DC9D80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event AICJGHABIKI MNLPMNFBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA340", Offset = "0x5DC9540", VA = "0x185DCA340", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9E80", Offset = "0x5DC9080", VA = "0x185DC9E80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action OIGMHFBPFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9B20", Offset = "0x5DC8D20", VA = "0x185DC9B20", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9C60", Offset = "0x5DC8E60", VA = "0x185DC9C60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action KLKCMKJJAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA2A0", Offset = "0x5DC94A0", VA = "0x185DCA2A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9BC0", Offset = "0x5DC8DC0", VA = "0x185DC9BC0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FHNBDEAMHEB> PGMJHAEOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5DCAEC0", Offset = "0x5DCA0C0", VA = "0x185DCAEC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9810", Offset = "0x5DC8A10", VA = "0x185DC9810", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<FHNBDEAMHEB> EIHOIPGLMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA520", Offset = "0x5DC9720", VA = "0x185DCA520", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA200", Offset = "0x5DC9400", VA = "0x185DCA200", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action GAHKACAELFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5DCACF0", Offset = "0x5DC9EF0", VA = "0x185DCACF0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5DC99E0", Offset = "0x5DC8BE0", VA = "0x185DC99E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<FHNBDEAMHEB> HJIMBKDEFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA820", Offset = "0x5DC9A20", VA = "0x185DCA820", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA480", Offset = "0x5DC9680", VA = "0x185DCA480", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAF60", Offset = "0x5DCA160", VA = "0x185DCAF60")]
	public KLHKCIINODA(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9D00", Offset = "0x5DC8F00", VA = "0x185DC9D00", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9270", Offset = "0x5DC8470", VA = "0x185DC9270", Slot = "30")]
	public void ANGEEGJGALL(FHNBDEAMHEB AENILMDGHEI, bool MLAKNPIOJBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9FB0", Offset = "0x5DC91B0", VA = "0x185DC9FB0", Slot = "6")]
	public void IMMBPMGFNLK(FHNBDEAMHEB HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA5C0", Offset = "0x5DC97C0", VA = "0x185DCA5C0", Slot = "7")]
	public void LLFAHOEJMNE(FHNBDEAMHEB HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA3E0", Offset = "0x5DC95E0", VA = "0x185DCA3E0", Slot = "4")]
	public void KPDBLCMOHKN(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAC50", Offset = "0x5DC9E50", VA = "0x185DCAC50", Slot = "5")]
	public void NIHOLBFKPBD(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9F20", Offset = "0x5DC9120", VA = "0x185DC9F20")]
	private void IDFKPIHFMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9230", Offset = "0x5DC8430", VA = "0x185DC9230")]
	private void AHKEMAPAOFL(FHNBDEAMHEB HIBNKKEINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA8C0", Offset = "0x5DC9AC0", VA = "0x185DCA8C0")]
	private void MDGOFJHPABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAD90", Offset = "0x5DC9F90", VA = "0x185DCAD90")]
	private void OHJIBAKBIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5DC98B0", Offset = "0x5DC8AB0", VA = "0x185DC98B0")]
	private void BEBGLFFKBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAA10", Offset = "0x5DC9C10", VA = "0x185DCAA10")]
	[CompilerGenerated]
	private object MGMDCMHOGEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class MKBMCHMGNMN
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC7C0", Offset = "0x5DCB9C0", VA = "0x185DCC7C0")]
	public static NNAOJLCEMGA CNLJLEIOHON(this FHNBDEAMHEB NKLFKPOOEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class NAHGDFHPCGO : NLFLFCCLOME
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string JODGJCFBJFB = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly COJCOIOHKKE NBDAKBLCIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly IICIADPPFLC ALGPDFOHEJL;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool KNNOOAEDKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x15BAD90", Offset = "0x15B9F90", VA = "0x1815BAD90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public IICIADPPFLC ECEMFLGGPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90", Slot = "5")]
		get
		{
			return default(IICIADPPFLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x702BC90", Offset = "0x702AE90", VA = "0x18702BC90")]
	public NAHGDFHPCGO(FHNBDEAMHEB GPIDMMLMBCH, in IIKMLKNINKM JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x702BA10", Offset = "0x702AC10", VA = "0x18702BA10", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x702B930", Offset = "0x702AB30", VA = "0x18702B930")]
	private bool DFBGCONLDOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x702BC30", Offset = "0x702AE30", VA = "0x18702BC30", Slot = "7")]
	public void IHCEJFDOOMF(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x702BC60", Offset = "0x702AE60", VA = "0x18702BC60", Slot = "8")]
	public void LDOPGGGMFMN(object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x702B720", Offset = "0x702A920", VA = "0x18702B720", Slot = "11")]
	public void BNPOJJLMFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x702BB20", Offset = "0x702AD20", VA = "0x18702BB20")]
	private void FFJEFMJJIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x702B850", Offset = "0x702AA50", VA = "0x18702B850")]
	private void CBFPFDFHFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x702B9D0", Offset = "0x702ABD0", VA = "0x18702B9D0", Slot = "10")]
	public void DFPLEIOIFBP(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x702BAE0", Offset = "0x702ACE0", VA = "0x18702BAE0", Slot = "9")]
	public void FADGMIMJNFJ(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IMDHJAAAKHB : FGEFEOBFMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NDBEBBMHLIJ(Rigidbody PPKNGDFCIBF);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NNAOJLCEMGA : PFMKIIEBHIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPDBLCMOHKN(FHNBDEAMHEB GPIDMMLMBCH);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIHOLBFKPBD(FHNBDEAMHEB GPIDMMLMBCH);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMMBPMGFNLK(FHNBDEAMHEB HIBNKKEINMK);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLFAHOEJMNE(FHNBDEAMHEB HIBNKKEINMK);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class HFIHIEIADEE : FAFKPGMJFPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool CHHBDNPLJFK;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool JPIHFKDMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0FA0", Offset = "0x5DC01A0", VA = "0x185DC0FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5DC10E0", Offset = "0x5DC02E0", VA = "0x185DC10E0")]
	public HFIHIEIADEE(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC10B0", Offset = "0x5DC02B0", VA = "0x185DC10B0", Slot = "6")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0F30", Offset = "0x5DC0130", VA = "0x185DC0F30", Slot = "7")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EFCILPCDMBL : CHEOOBBEMFC
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int GCDDJECPCHH = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float ALBFOIHKKGJ = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float JDDPIKHJEPI = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float DHKPIAODGFM = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly MKICEPDICHP GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool HAONEMMLEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool CBBBDLBCJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int MHKHLJFJLFL;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody MBJFFDGCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5AD0", Offset = "0x5DB4CD0", VA = "0x185DB5AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool GDPDFLAPJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBF60", Offset = "0x5DBB160", VA = "0x185DBBF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool LEFOJOGNCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB780", Offset = "0x5DBA980", VA = "0x185DBB780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private FHNBDEAMHEB JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBA00", Offset = "0x5DBAC00", VA = "0x185DBBA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool OEJPAMFBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB7E0", Offset = "0x5DBA9E0", VA = "0x185DBB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event GGFJJGDFDOL MLEMLFIBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBEC0", Offset = "0x5DBB0C0", VA = "0x185DBBEC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB6E0", Offset = "0x5DBA8E0", VA = "0x185DBB6E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC190", Offset = "0x5DBB390", VA = "0x185DBC190")]
	public EFCILPCDMBL(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBBC0", Offset = "0x5DBADC0", VA = "0x185DBBBC0", Slot = "6")]
	public void EMIKNJLDNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB840", Offset = "0x5DBAA40", VA = "0x185DBB840", Slot = "8")]
	public void BMHMIEOIPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBA60", Offset = "0x5DBAC60", VA = "0x185DBBA60", Slot = "7")]
	public bool EFNEMBNMAEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB640", Offset = "0x5DBA840", VA = "0x185DBB640", Slot = "9")]
	public void AAPGHPCNAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBE20", Offset = "0x5DBB020", VA = "0x185DBBE20", Slot = "11")]
	public void HLCJDLAAPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB7A0", Offset = "0x5DBA9A0", VA = "0x185DBB7A0", Slot = "12")]
	public void AHICLPFGLCJ(bool KNONAIJGIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB850", Offset = "0x5DBAA50", VA = "0x185DBB850", Slot = "10")]
	public void DMMBGNPNKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DBBC60", Offset = "0x5DBAE60", VA = "0x185DBBC60")]
	private bool GNDPDCCFMFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC000", Offset = "0x5DBB200", VA = "0x185DBC000")]
	private void NEKGGMNPONH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class GALLNJDLIMN : MMJPCNKBKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly FHNBDEAMHEB GPIDMMLMBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float MEFFMOEKFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float NAOCBOJPHDN;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float GELKENCBJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x981930", Offset = "0x980B30", VA = "0x180981930", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF540", Offset = "0x5DBE740", VA = "0x185DBF540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float GHJKDEKOEED
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8D0", Offset = "0xC79AD0", VA = "0x180C7A8D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF420", Offset = "0x5DBE620", VA = "0x185DBF420", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF610", Offset = "0x5DBE810", VA = "0x185DBF610")]
	public GALLNJDLIMN(FHNBDEAMHEB GPIDMMLMBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF4F0", Offset = "0x5DBE6F0", VA = "0x185DBF4F0", Slot = "8")]
	public void KKPDPGPFBOI(Rigidbody CAACFEDFBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF380", Offset = "0x5DBE580", VA = "0x185DBF380", Slot = "9")]
	public void EEFHDJAFIOH(Rigidbody CAACFEDFBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GJMOFFLDDGM : ELNBNKMGOPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView ONMILLMBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : LMEKEFOFLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7034E20", Offset = "0x7034020", VA = "0x187034E20", Slot = "6")]
		public sealed override void AKIIAJCBBFE(CPFDECJIHBH NMCNKNBHPHF)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
