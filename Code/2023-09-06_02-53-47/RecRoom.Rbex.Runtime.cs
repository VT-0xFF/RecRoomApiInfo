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
		public static IOAJAPLOKEP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int MKFHCKPOEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int NBFJJOKICFC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2840", Offset = "0x6ED0E40", VA = "0x186ED2840")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2880", Offset = "0x6ED0E80", VA = "0x186ED2880")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2860", Offset = "0x6ED0E60", VA = "0x186ED2860")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string DPAJDIEBNKM, [Optional] UnityEngine.Object MFPELEJLJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string DPAJDIEBNKM, [Optional] UnityEngine.Object MFPELEJLJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2970", Offset = "0x6ED0F70", VA = "0x186ED2970")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LPJHFIENLHA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class OOPCEOAJICI : BIEFHFEPLDN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE0CB00", Offset = "0xE0B100", VA = "0x180E0CB00", Slot = "4")]
		public Vector3 FLKHGJHNCJM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE0CB00", Offset = "0xE0B100", VA = "0x180E0CB00", Slot = "5")]
		public Vector3 EOODJDMOBAD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OOPCEOAJICI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BIEFHFEPLDN ABNIGJOPIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5896590", Offset = "0x5894B90", VA = "0x185896590")]
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
		private static readonly IAMDAJKPFJC LMGNMLPOFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool IDBDAPMKGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private AOCLEIAJHKP AAADIAJNHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JFIDOIKGENA(JHNBNMNOADF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[JFIDOIKGENA(JHNBNMNOADF.SelfAndParent, true, false, false)]
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
		private CEIMKNKONCD physicsInterpolation;

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
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal AOCLEIAJHKP KIAIEGBMNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED3470", Offset = "0x6ED1A70", VA = "0x186ED3470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> NJANFDAOLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx LHGABCCHKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5570", Offset = "0x6ED3B70", VA = "0x186ED5570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HDEBMDKMAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5510", Offset = "0x6ED3B10", VA = "0x186ED5510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HDBBNLFBJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6ED60C0", Offset = "0x6ED46C0", VA = "0x186ED60C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7580", Offset = "0x6ED5B80", VA = "0x186ED7580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform AOMAHDEPPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBD8590", Offset = "0xBD6B90", VA = "0x180BD8590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform KDBFAEJIMEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBD8590", Offset = "0xBD6B90", VA = "0x180BD8590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FPJJHNAFLMG NJBJKOECIDG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED52D0", Offset = "0x6ED38D0", VA = "0x186ED52D0")]
			get
			{
				return default(FPJJHNAFLMG);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6D20", Offset = "0x6ED5320", VA = "0x186ED6D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HJAODIIKABB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED57D0", Offset = "0x6ED3DD0", VA = "0x186ED57D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DHOHPBGBHIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED53F0", Offset = "0x6ED39F0", VA = "0x186ED53F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BIEFHFEPLDN EJPKIEIFJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5710", Offset = "0x6ED3D10", VA = "0x186ED5710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6F30", Offset = "0x6ED5530", VA = "0x186ED6F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DDPKKPIIEJI NBIFLHIDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6ED56B0", Offset = "0x6ED3CB0", VA = "0x186ED56B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6EC0", Offset = "0x6ED54C0", VA = "0x186ED6EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DADDAFOKEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6ED55A0", Offset = "0x6ED3BA0", VA = "0x186ED55A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody FBNFGAGNEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5600", Offset = "0x6ED3C00", VA = "0x186ED5600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LCLBMNGOKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5450", Offset = "0x6ED3A50", VA = "0x186ED5450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6DE0", Offset = "0x6ED53E0", VA = "0x186ED6DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JCJFAFLFFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1610B80", Offset = "0x160F180", VA = "0x181610B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x535E200", Offset = "0x535C800", VA = "0x18535E200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float GHNEJKFLBGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6060", Offset = "0x6ED4660", VA = "0x186ED6060")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LBJHKLPMIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6000", Offset = "0x6ED4600", VA = "0x186ED6000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7510", Offset = "0x6ED5B10", VA = "0x186ED7510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float AJMIJLJBCFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5A20", Offset = "0x6ED4020", VA = "0x186ED5A20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED71C0", Offset = "0x6ED57C0", VA = "0x186ED71C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFAOFDACMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5830", Offset = "0x6ED3E30", VA = "0x186ED5830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6FA0", Offset = "0x6ED55A0", VA = "0x186ED6FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool LBFOOLAKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6590", Offset = "0x6ED4B90", VA = "0x186ED6590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7A70", Offset = "0x6ED6070", VA = "0x186ED7A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 ALOIHKHMHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5E00", Offset = "0x6ED4400", VA = "0x186ED5E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7300", Offset = "0x6ED5900", VA = "0x186ED7300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 DELPBMEHGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6ED66C0", Offset = "0x6ED4CC0", VA = "0x186ED66C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode KNOOIKNGMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5960", Offset = "0x6ED3F60", VA = "0x186ED5960")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6ED70E0", Offset = "0x6ED56E0", VA = "0x186ED70E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float MHFCDDIOMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6ED54B0", Offset = "0x6ED3AB0", VA = "0x186ED54B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6E50", Offset = "0x6ED5450", VA = "0x186ED6E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints FLIHBOMIALI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED59C0", Offset = "0x6ED3FC0", VA = "0x186ED59C0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7150", Offset = "0x6ED5750", VA = "0x186ED7150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 OHLKADOPIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6120", Offset = "0x6ED4720", VA = "0x186ED6120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 HJMLPCLNKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6120", Offset = "0x6ED4720", VA = "0x186ED6120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7860", Offset = "0x6ED5E60", VA = "0x186ED7860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float LONBLMKEDEF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5ED0", Offset = "0x6ED44D0", VA = "0x186ED5ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6ED73D0", Offset = "0x6ED59D0", VA = "0x186ED73D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PAOOJFBIOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6530", Offset = "0x6ED4B30", VA = "0x186ED6530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7A00", Offset = "0x6ED6000", VA = "0x186ED7A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion LCLFIBGPCHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6ED61F0", Offset = "0x6ED47F0", VA = "0x186ED61F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6ED75F0", Offset = "0x6ED5BF0", VA = "0x186ED75F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion APHGPOKOGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6460", Offset = "0x6ED4A60", VA = "0x186ED6460")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7930", Offset = "0x6ED5F30", VA = "0x186ED7930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 EBDBONBGLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6ED62C0", Offset = "0x6ED48C0", VA = "0x186ED62C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6ED76C0", Offset = "0x6ED5CC0", VA = "0x186ED76C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion IKLJDDMPOLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6390", Offset = "0x6ED4990", VA = "0x186ED6390")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7790", Offset = "0x6ED5D90", VA = "0x186ED7790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 KEMGHPMICGF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED65F0", Offset = "0x6ED4BF0", VA = "0x186ED65F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7AE0", Offset = "0x6ED60E0", VA = "0x186ED7AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 GKICFHEAHCG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5F30", Offset = "0x6ED4530", VA = "0x186ED5F30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7440", Offset = "0x6ED5A40", VA = "0x186ED7440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FKNMMHBCHIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5890", Offset = "0x6ED3E90", VA = "0x186ED5890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7010", Offset = "0x6ED5610", VA = "0x186ED7010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CCBAPKPOEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5D30", Offset = "0x6ED4330", VA = "0x186ED5D30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6ED7230", Offset = "0x6ED5830", VA = "0x186ED7230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KOMDCJMGILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5C00", Offset = "0x6ED4200", VA = "0x186ED5C00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion FBNDDLKJBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5B30", Offset = "0x6ED4130", VA = "0x186ED5B30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GIDBONLFDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6860", Offset = "0x6ED4E60", VA = "0x186ED6860")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 IOJJPNMCGGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6790", Offset = "0x6ED4D90", VA = "0x186ED6790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DBCLNOPFJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5CD0", Offset = "0x6ED42D0", VA = "0x186ED5CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EBCJPGGOHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5770", Offset = "0x6ED3D70", VA = "0x186ED5770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DMMFAFAOCDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5390", Offset = "0x6ED3990", VA = "0x186ED5390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HPHLPJEDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5330", Offset = "0x6ED3930", VA = "0x186ED5330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IAFGIJMAMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5270", Offset = "0x6ED3870", VA = "0x186ED5270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KOFFHKDKNKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5A80", Offset = "0x6ED4080", VA = "0x186ED5A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DONKHGNKKGP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x31FD1A0", Offset = "0x31FB7A0", VA = "0x1831FD1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JDMLJLCMPHD IECLKFCBBGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5190", Offset = "0x6ED3790", VA = "0x186ED5190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6C40", Offset = "0x6ED5240", VA = "0x186ED6C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DOCLCEPDIKL DNNAEMJKOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5120", Offset = "0x6ED3720", VA = "0x186ED5120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6BD0", Offset = "0x6ED51D0", VA = "0x186ED6BD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JDMLJLCMPHD BFBMPEKKJGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4E80", Offset = "0x6ED3480", VA = "0x186ED4E80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6930", Offset = "0x6ED4F30", VA = "0x186ED6930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event JDMLJLCMPHD KOPNEFGHFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4EF0", Offset = "0x6ED34F0", VA = "0x186ED4EF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6ED69A0", Offset = "0x6ED4FA0", VA = "0x186ED69A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event JDMLJLCMPHD FNGPCAJNBEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5040", Offset = "0x6ED3640", VA = "0x186ED5040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6AF0", Offset = "0x6ED50F0", VA = "0x186ED6AF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4FD0", Offset = "0x6ED35D0", VA = "0x186ED4FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6A80", Offset = "0x6ED5080", VA = "0x186ED6A80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event JDMLJLCMPHD BINOGMLPAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED50B0", Offset = "0x6ED36B0", VA = "0x186ED50B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6B60", Offset = "0x6ED5160", VA = "0x186ED6B60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event JDMLJLCMPHD JPCPFFAJDJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5200", Offset = "0x6ED3800", VA = "0x186ED5200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6CB0", Offset = "0x6ED52B0", VA = "0x186ED6CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event JDMLJLCMPHD NKIOBPKHNKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4F60", Offset = "0x6ED3560", VA = "0x186ED4F60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6A10", Offset = "0x6ED5010", VA = "0x186ED6A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		internal void CEOBAJCCIEF(AOCLEIAJHKP PMIAAPCBGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3DD0", Offset = "0x6ED23D0", VA = "0x186ED3DD0")]
		internal void LDLFIFEDCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4B70", Offset = "0x6ED3170", VA = "0x186ED4B70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody CGGHAFJHFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4830", Offset = "0x6ED2E30", VA = "0x186ED4830")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FDPFMJCBPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3400", Offset = "0x6ED1A00", VA = "0x186ED3400")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3470", Offset = "0x6ED1A70", VA = "0x186ED3470")]
		private AOCLEIAJHKP LMLMJHJDMLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3700", Offset = "0x6ED1D00", VA = "0x186ED3700")]
		private void DOIFCEJGCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4020", Offset = "0x6ED2620", VA = "0x186ED4020")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3DD0", Offset = "0x6ED23D0", VA = "0x186ED3DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3FC0", Offset = "0x6ED25C0", VA = "0x186ED3FC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4080", Offset = "0x6ED2680", VA = "0x186ED4080")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ED29C0", Offset = "0x6ED0FC0", VA = "0x186ED29C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6ED40F0", Offset = "0x6ED26F0", VA = "0x186ED40F0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3A90", Offset = "0x6ED2090", VA = "0x186ED3A90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3F60", Offset = "0x6ED2560", VA = "0x186ED3F60")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4990", Offset = "0x6ED2F90", VA = "0x186ED4990")]
		public void SetParent(RigidbodyEx MOLEJFDINLH, bool NOBJEFGBIAD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED43F0", Offset = "0x6ED29F0", VA = "0x186ED43F0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3CF0", Offset = "0x6ED22F0", VA = "0x186ED3CF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx HOOINOBHKDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3D30", Offset = "0x6ED2330", VA = "0x186ED3D30")]
		public bool IsRigidbodyDescendant(RigidbodyEx HOKCCAOGCCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2C30", Offset = "0x6ED1230", VA = "0x186ED2C30")]
		public void AddInterpolationRestriction(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4160", Offset = "0x6ED2760", VA = "0x186ED4160")]
		public void RemoveInterpolationRestriction(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3520", Offset = "0x6ED1B20", VA = "0x186ED3520")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2CA0", Offset = "0x6ED12A0", VA = "0x186ED2CA0")]
		public void AddKinematic(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6ED41D0", Offset = "0x6ED27D0", VA = "0x186ED41D0")]
		public void RemoveKinematic(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4910", Offset = "0x6ED2F10", VA = "0x186ED4910")]
		public void SetKinematic(object DCEGGIJLHGI, bool IBEINHPEJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4740", Offset = "0x6ED2D40", VA = "0x186ED4740")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ENBHPDFCHED, Quaternion DFJMGODKAOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4650", Offset = "0x6ED2C50", VA = "0x186ED4650")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 OBPNNJPNPLD, Quaternion FHGFBFMJEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3BF0", Offset = "0x6ED21F0", VA = "0x186ED3BF0")]
		public Vector3 GetConstrainedVelocity(Vector3 KEMGHPMICGF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3AF0", Offset = "0x6ED20F0", VA = "0x186ED3AF0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FKNMMHBCHIK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2B40", Offset = "0x6ED1140", VA = "0x186ED2B40")]
		public void AddForce(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2A30", Offset = "0x6ED1030", VA = "0x186ED2A30")]
		public void AddForceAtPosition(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2E70", Offset = "0x6ED1470", VA = "0x186ED2E70")]
		public void AddTorque(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2D10", Offset = "0x6ED1310", VA = "0x186ED2D10")]
		public void AddRelativeTorque(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4C50", Offset = "0x6ED3250", VA = "0x186ED4C50")]
		public Vector3 WorldToLocalVelocity(Vector3 LHEPMHJHODO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3E60", Offset = "0x6ED2460", VA = "0x186ED3E60")]
		public Vector3 LocalToWorldVelocity(Vector3 GKICFHEAHCG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED36A0", Offset = "0x6ED1CA0", VA = "0x186ED36A0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3640", Offset = "0x6ED1C40", VA = "0x186ED3640")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6ED35E0", Offset = "0x6ED1BE0", VA = "0x186ED35E0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3580", Offset = "0x6ED1B80", VA = "0x186ED3580")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4550", Offset = "0x6ED2B50", VA = "0x186ED4550")]
		public void ResetVelocityWorldSpace(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4450", Offset = "0x6ED2A50", VA = "0x186ED4450")]
		public void ResetVelocityLocalSpace(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4320", Offset = "0x6ED2920", VA = "0x186ED4320")]
		public void ResetLinearVelocityLocalSpace(Vector3 AOGBJAOCGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4A80", Offset = "0x6ED3080", VA = "0x186ED4A80")]
		public bool SweepTest(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3D70", Offset = "0x6ED2370", VA = "0x186ED3D70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4A20", Offset = "0x6ED3020", VA = "0x186ED4A20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4BF0", Offset = "0x6ED31F0", VA = "0x186ED4BF0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2E00", Offset = "0x6ED1400", VA = "0x186ED2E00")]
		public void AddShouldHaveUnityRigidbodyToken(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4240", Offset = "0x6ED2840", VA = "0x186ED4240")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED31F0", Offset = "0x6ED17F0", VA = "0x186ED31F0")]
		public void ApplyForceVelocityChange(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3100", Offset = "0x6ED1700", VA = "0x186ED3100")]
		public void ApplyAngularVelocityChange(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3300", Offset = "0x6ED1900", VA = "0x186ED3300")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3040", Offset = "0x6ED1640", VA = "0x186ED3040")]
		public bool AllowedScaleChange(float MNOGCBMJIKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2F60", Offset = "0x6ED1560", VA = "0x186ED2F60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx ALHMAGPDOEF, object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6ED42B0", Offset = "0x6ED28B0", VA = "0x186ED42B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4DE0", Offset = "0x6ED33E0", VA = "0x186ED4DE0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class NCPKPPPIPMM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5898AD0", Offset = "0x58970D0", VA = "0x185898AD0")]
	public static AOCLEIAJHKP KIAIEGBMNCJ(this RigidbodyEx CMMIKMENMLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JDMLJLCMPHD(RigidbodyEx HFPIFNKOOFJ);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CEIMKNKONCD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PEDHAMIFFKK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BPFBPKEMMBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Rigidbody CAGCAFDPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public PhotonView FPBBDDNIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OverridableVector3 JNJNDPIOPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 LCMLDCPALFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public CEIMKNKONCD ELKAPNBKJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool LDJJGNJPFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool IIPDIKLJHLE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void DOCLCEPDIKL(RigidbodyEx HFPIFNKOOFJ, bool NOBJEFGBIAD = false);
[Cpp2IlInjected.Token(Token = "0x200000D")]
[OJJOJOKIEBL(typeof(LPPLMPKJMHM), new string[] { "Ignore", "Mock" })]
public class GOCKNGMHAOF : LPPLMPKJMHM
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PAHMAKPMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void IDLLJMMEEPD(string PMBGBHCKNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void OJFBEAOOFEH(RigidbodyEx CMMIKMENMLL, Action ILLCNPCAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "7")]
	public LIENANGMHBE DMLAKMJOACI(int IICDEMJBPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void LKNIIBLKPGH(Vector3 DELPBMEHGGJ, float PJCJHKDFLJF, Color CMDNLIJPJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GOCKNGMHAOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[OJJOJOKIEBL(typeof(MOKJCBCFMGC), new string[] { })]
public class DIBJLGHIDDF : MOKJCBCFMGC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private HMKFBCDDIDP FBFEJLEAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LPPLMPKJMHM FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GLLJIFAFPDH IJHADCJCEID;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LPPLMPKJMHM PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GLLJIFAFPDH JODJFGCOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5884590", Offset = "0x5882B90", VA = "0x185884590", Slot = "10")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5884830", Offset = "0x5882E30", VA = "0x185884830", Slot = "6")]
	public ENMPPPDAMHN MHMMJDCOMMO(RigidbodyEx CMMIKMENMLL)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5884730", Offset = "0x5882D30", VA = "0x185884730")]
	private static ENMPPPDAMHN LLOLIFPFOHJ(RigidbodyEx CMMIKMENMLL)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5884620", Offset = "0x5882C20", VA = "0x185884620", Slot = "7")]
	public AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5884350", Offset = "0x5882950", VA = "0x185884350", Slot = "8")]
	public void HKAPEAEHNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5884440", Offset = "0x5882A40", VA = "0x185884440", Slot = "9")]
	public void IMBMMHGNPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DIBJLGHIDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DDDIJKDCKKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5883850", Offset = "0x5881E50", VA = "0x185883850")]
	public static void FMBHNKJNGBK(this Rigidbody CGGHAFJHFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x58839A0", Offset = "0x5881FA0", VA = "0x1858839A0")]
	public static void FMBHNKJNGBK(this Rigidbody CGGHAFJHFIN, Vector3 PKIAACMADGF, Quaternion FBNDDLKJBKJ, Vector3 AAFJBBPGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F950", Offset = "0x1F8DF50", VA = "0x181F8F950")]
	public static void CEDPJEICDBF(Vector3 KEMGHPMICGF, Vector3 NGHPIMAKGOH, out Vector3 ALABICLCJKE, out Vector3 KIKHFCHGHDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum INGJMCHLCGB
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MEENLNJJFDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event JDMLJLCMPHD BPJFEFCOFDJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDLJGFDMBPL(AOCLEIAJHKP HDBBNLFBJKG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDAFCHGGCBG(AOCLEIAJHKP HDBBNLFBJKG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BHMGBIACOME
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface LPPLMPKJMHM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PAHMAKPMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDLLJMMEEPD(string PMBGBHCKNKB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJFBEAOOFEH(RigidbodyEx CMMIKMENMLL, Action ILLCNPCAHGD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LIENANGMHBE DMLAKMJOACI(int IICDEMJBPOM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKNIIBLKPGH(Vector3 DELPBMEHGGJ, float PJCJHKDFLJF, Color CMDNLIJPJJE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface MOKJCBCFMGC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	LPPLMPKJMHM PMLEMKJBEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	GLLJIFAFPDH JODJFGCOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENMPPPDAMHN MHMMJDCOMMO(RigidbodyEx CMMIKMENMLL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKAPEAEHNIA();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMBMMHGNPPP();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CHEDGEFNIEP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JJAIOCAHBKB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KKIDFBLCFBC
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIKNGELNMKB(AOCLEIAJHKP HDBBNLFBJKG, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAONEFAIICM(object DCEGGIJLHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class BNKOAIEMCLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x587B5D0", Offset = "0x5879BD0", VA = "0x18587B5D0")]
	public BNKOAIEMCLN(CBKENBPBBPK EMOGFKKIBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x587B570", Offset = "0x5879B70", VA = "0x18587B570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CBKENBPBBPK : AOCLEIAJHKP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly MOKJCBCFMGC AMKEFDBPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal IKHJGOOMJIK PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal OAEPDBGPEAL NGBFOCEOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal MEENLNJJFDF NMLCLDDPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal FCKCKALDJGJ KEMGHPMICGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KKIDFBLCFBC AMEBKKFBLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal MJLAMDFGPOJ HBMMKOGIKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal BHMGBIACOME PEJPCEOHHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MGFOKHNGEBJ INPGIIMEIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal LDEKIIFINIJ DBAIOEFNJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal CKCBLALPPPC AJCKPDKOCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NJJAJEPIBDM HMAHDAIPFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal DGFAMAIKIOI ODPLBAPFKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal JFLCGFJHJOJ HGJLFKLJHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal EHPGBGDNCOD CAGCAFDPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal CJBOBGHJFCG POHGDMHHBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IDisposable KHKFGHBCENA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public RigidbodyEx LKNLGDPHOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA0", Offset = "0x9D81A0", VA = "0x1809D9BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GameObject JPBNIBGFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB30", Offset = "0xA79130", VA = "0x180A7AB30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB20", Offset = "0xA79120", VA = "0x180A7AB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Transform GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x587E070", Offset = "0x587C670", VA = "0x18587E070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x587BDA0", Offset = "0x587A3A0", VA = "0x18587BDA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5880E60", Offset = "0x587F460", VA = "0x185880E60", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5880F30", Offset = "0x587F530", VA = "0x185880F30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x587F570", Offset = "0x587DB70", VA = "0x18587F570", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x587DCE0", Offset = "0x587C2E0", VA = "0x18587DCE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5881670", Offset = "0x587FC70", VA = "0x185881670", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x587C440", Offset = "0x587AA40", VA = "0x18587C440", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x58816D0", Offset = "0x587FCD0", VA = "0x1858816D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x587D3A0", Offset = "0x587B9A0", VA = "0x18587D3A0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x587D880", Offset = "0x587BE80", VA = "0x18587D880", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5880E10", Offset = "0x587F410", VA = "0x185880E10", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x587FFA0", Offset = "0x587E5A0", VA = "0x18587FFA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5880A10", Offset = "0x587F010", VA = "0x185880A10", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x587F3C0", Offset = "0x587D9C0", VA = "0x18587F3C0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x587B9A0", Offset = "0x5879FA0", VA = "0x18587B9A0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x587EB20", Offset = "0x587D120", VA = "0x18587EB20", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x587E2A0", Offset = "0x587C8A0", VA = "0x18587E2A0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x587E4B0", Offset = "0x587CAB0", VA = "0x18587E4B0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x587DF40", Offset = "0x587C540", VA = "0x18587DF40", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x587C970", Offset = "0x587AF70", VA = "0x18587C970", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x587D450", Offset = "0x587BA50", VA = "0x18587D450", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x587CE70", Offset = "0x587B470", VA = "0x18587CE70", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool DMMFAFAOCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x587B8C0", Offset = "0x5879EC0", VA = "0x18587B8C0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HPHLPJEDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x587CC80", Offset = "0x587B280", VA = "0x18587CC80", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool IAFGIJMAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5880640", Offset = "0x587EC40", VA = "0x185880640", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5880B10", Offset = "0x587F110", VA = "0x185880B10", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x587D020", Offset = "0x587B620", VA = "0x18587D020", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x58813B0", Offset = "0x587F9B0", VA = "0x1858813B0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x587DC10", Offset = "0x587C210", VA = "0x18587DC10", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x587DDD0", Offset = "0x587C3D0", VA = "0x18587DDD0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x587ECD0", Offset = "0x587D2D0", VA = "0x18587ECD0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x58805A0", Offset = "0x587EBA0", VA = "0x1858805A0", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x587FD70", Offset = "0x587E370", VA = "0x18587FD70", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x587E780", Offset = "0x587CD80", VA = "0x18587E780", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5880B60", Offset = "0x587F160", VA = "0x185880B60", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x587C090", Offset = "0x587A690", VA = "0x18587C090", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5880550", Offset = "0x587EB50", VA = "0x185880550", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x587D820", Offset = "0x587BE20", VA = "0x18587D820", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5880A60", Offset = "0x587F060", VA = "0x185880A60", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x587CC20", Offset = "0x587B220", VA = "0x18587CC20", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x58805F0", Offset = "0x587EBF0", VA = "0x1858805F0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x587E720", Offset = "0x587CD20", VA = "0x18587E720", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5880750", Offset = "0x587ED50", VA = "0x185880750", Slot = "48")]
		get
		{
			return default(LMDIKFABHDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x587FDD0", Offset = "0x587E3D0", VA = "0x18587FDD0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5880C30", Offset = "0x587F230", VA = "0x185880C30", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Transform KDBFAEJIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x587FDC0", Offset = "0x587E3C0", VA = "0x18587FDC0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 EFHCKDIEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x587C250", Offset = "0x587A850", VA = "0x18587C250", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x587CB70", Offset = "0x587B170", VA = "0x18587CB70", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float CCLJFKBBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x587FF80", Offset = "0x587E580", VA = "0x18587FF80", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x587C020", Offset = "0x587A620", VA = "0x18587C020", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public float LENGADJAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x587CE50", Offset = "0x587B450", VA = "0x18587CE50", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x587BF10", Offset = "0x587A510", VA = "0x18587BF10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Quaternion LKLHMLNBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x587F660", Offset = "0x587DC60", VA = "0x18587F660", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x587F5C0", Offset = "0x587DBC0", VA = "0x18587F5C0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector3 BMIKEFPDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5880910", Offset = "0x587EF10", VA = "0x185880910", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x58818F0", Offset = "0x587FEF0", VA = "0x1858818F0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Quaternion BFLAMDMHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5880120", Offset = "0x587E720", VA = "0x185880120", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5880EF0", Offset = "0x587F4F0", VA = "0x185880EF0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5880200", Offset = "0x587E800", VA = "0x185880200", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x587B860", Offset = "0x5879E60", VA = "0x18587B860", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x58800D0", Offset = "0x587E6D0", VA = "0x1858800D0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x587C760", Offset = "0x587AD60", VA = "0x18587C760", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x587E100", Offset = "0x587C700", VA = "0x18587E100", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x587BEB0", Offset = "0x587A4B0", VA = "0x18587BEB0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool GKKIJDNHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x587E150", Offset = "0x587C750", VA = "0x18587E150", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool EBCJPGGOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5880C80", Offset = "0x587F280", VA = "0x185880C80", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool AMNGPOMLAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5880860", Offset = "0x587EE60", VA = "0x185880860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MIEBPPICAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5880EB0", Offset = "0x587F4B0", VA = "0x185880EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event JDMLJLCMPHD BFBMPEKKJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x587D8E0", Offset = "0x587BEE0", VA = "0x18587D8E0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x587F210", Offset = "0x587D810", VA = "0x18587F210", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event JDMLJLCMPHD KOPNEFGHFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5881080", Offset = "0x587F680", VA = "0x185881080", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x587E5D0", Offset = "0x587CBD0", VA = "0x18587E5D0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event DOCLCEPDIKL CEAJCLKFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x587B800", Offset = "0x5879E00", VA = "0x18587B800", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x587FA30", Offset = "0x587E030", VA = "0x18587FA30", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event JDMLJLCMPHD BPJFEFCOFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x587F360", Offset = "0x587D960", VA = "0x18587F360", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x587C700", Offset = "0x587AD00", VA = "0x18587C700", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event JDMLJLCMPHD FNGPCAJNBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x587BDF0", Offset = "0x587A3F0", VA = "0x18587BDF0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5881720", Offset = "0x587FD20", VA = "0x185881720", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event JDMLJLCMPHD HFCHBNGPOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x587CCE0", Offset = "0x587B2E0", VA = "0x18587CCE0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x58814D0", Offset = "0x587FAD0", VA = "0x1858814D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5880800", Offset = "0x587EE00", VA = "0x185880800", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x587E010", Offset = "0x587C610", VA = "0x18587E010", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event JDMLJLCMPHD PPDDOEOHENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x587BE50", Offset = "0x587A450", VA = "0x18587BE50", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x587D0F0", Offset = "0x587B6F0", VA = "0x18587D0F0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event JDMLJLCMPHD NKIOBPKHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5880160", Offset = "0x587E760", VA = "0x185880160", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x587D680", Offset = "0x587BC80", VA = "0x18587D680", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x587A770", Offset = "0x5878D70", VA = "0x18587A770")]
	public CBKENBPBBPK(GameObject FLCGKEKAMCK, RigidbodyEx NDNCKODFKIM, MOKJCBCFMGC AMKEFDBPHKK, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x587FA90", Offset = "0x587E090", VA = "0x18587FA90", Slot = "135")]
	protected virtual void LGHNOMAHJML(MOKJCBCFMGC AMKEFDBPHKK, BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x587CAA0", Offset = "0x587B0A0", VA = "0x18587CAA0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5881530", Offset = "0x587FB30", VA = "0x185881530", Slot = "71")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x587EAD0", Offset = "0x587D0D0", VA = "0x18587EAD0", Slot = "72")]
	public void JBBCPGPOEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5880730", Offset = "0x587ED30", VA = "0x185880730", Slot = "73")]
	public void NDEMACDLPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5881780", Offset = "0x587FD80", VA = "0x185881780")]
	private void POMPHFNABOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x587EA60", Offset = "0x587D060", VA = "0x18587EA60", Slot = "81")]
	public void JAMGDJKMPGM(AOCLEIAJHKP MOLEJFDINLH, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x587CA40", Offset = "0x587B040", VA = "0x18587CA40", Slot = "84")]
	public void DOOGDGHCKAL(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x587F510", Offset = "0x587DB10", VA = "0x18587F510", Slot = "85")]
	public void KGJNGDONAIO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x587F270", Offset = "0x587D870", VA = "0x18587F270", Slot = "86")]
	public Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x587C160", Offset = "0x587A760", VA = "0x18587C160", Slot = "87")]
	public Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x587EAD0", Offset = "0x587D0D0", VA = "0x18587EAD0", Slot = "88")]
	public void JOGGPADGJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x587C310", Offset = "0x587A910", VA = "0x18587C310", Slot = "89")]
	public void CBENEDLBOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x587DEF0", Offset = "0x587C4F0", VA = "0x18587DEF0", Slot = "90")]
	public void HDHBMKGNDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x587B710", Offset = "0x5879D10", VA = "0x18587B710", Slot = "91")]
	public void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x587F420", Offset = "0x587DA20", VA = "0x18587F420", Slot = "92")]
	public void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x587E940", Offset = "0x587CF40", VA = "0x18587E940", Slot = "93")]
	public void JAAHGENLODK(Vector3 IJOKKCDOCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x587D570", Offset = "0x587BB70", VA = "0x18587D570", Slot = "94")]
	public void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x587D940", Offset = "0x587BF40", VA = "0x18587D940", Slot = "95")]
	public void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x587E840", Offset = "0x587CE40", VA = "0x18587E840", Slot = "96")]
	[Obsolete]
	public void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x587E630", Offset = "0x587CC30", VA = "0x18587E630", Slot = "97")]
	public Vector3 IHNMKPPJJBP(Vector3 MOLEJFDINLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x587FE90", Offset = "0x587E490", VA = "0x18587FE90", Slot = "98")]
	public Vector3 LNNEJNINGKP(Vector3 MOLEJFDINLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5881480", Offset = "0x587FA80", VA = "0x185881480", Slot = "99")]
	public void PFLNEDFLBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5881830", Offset = "0x587FE30", VA = "0x185881830", Slot = "100")]
	public void PPHKMALOPEF(AOCLEIAJHKP ALHMAGPDOEF, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x587D340", Offset = "0x587B940", VA = "0x18587D340", Slot = "101")]
	public void FPPDIEGBABO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x587CF40", Offset = "0x587B540", VA = "0x18587CF40", Slot = "41")]
	public void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x587EA10", Offset = "0x587D010", VA = "0x18587EA10", Slot = "104")]
	public void JADOCOOIFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5880960", Offset = "0x587EF60", VA = "0x185880960", Slot = "105")]
	public void NOKJNKPCOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x587E580", Offset = "0x587CB80", VA = "0x18587E580", Slot = "106")]
	public void IDLJKMLKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x587DD30", Offset = "0x587C330", VA = "0x18587DD30", Slot = "109")]
	public bool GOCENNMEFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x587DEA0", Offset = "0x587C4A0", VA = "0x18587DEA0", Slot = "74")]
	public void HBNCPLGMEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5881360", Offset = "0x587F960", VA = "0x185881360", Slot = "110")]
	public void PEPAIDKMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x587D520", Offset = "0x587BB20", VA = "0x18587D520", Slot = "115")]
	public IDisposable GFGDBJCOOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x587C490", Offset = "0x587AA90", VA = "0x18587C490", Slot = "116")]
	public void CKCCNMBNGFO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x587C6A0", Offset = "0x587ACA0", VA = "0x18587C6A0", Slot = "117")]
	public void DBBAOMBFPFC(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x587F1A0", Offset = "0x587D7A0", VA = "0x18587F1A0", Slot = "118")]
	public void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x587F710", Offset = "0x587DD10", VA = "0x18587F710", Slot = "121")]
	public void LEACOJHNOHN(Vector3 ENBHPDFCHED, Quaternion DFJMGODKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x587C7C0", Offset = "0x587ADC0", VA = "0x18587C7C0", Slot = "122")]
	public void DLHAAHBBGBF(Vector3 OBPNNJPNPLD, Quaternion FHGFBFMJEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5880AB0", Offset = "0x587F0B0", VA = "0x185880AB0", Slot = "123")]
	public bool ODFCAEOGHLD(float MNOGCBMJIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x58809B0", Offset = "0x587EFB0", VA = "0x1858809B0", Slot = "124")]
	public void OANHGPDIJME(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x587D3F0", Offset = "0x587B9F0", VA = "0x18587D3F0", Slot = "125")]
	public void GEMJLKNCNKG(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x587E370", Offset = "0x587C970", VA = "0x18587E370", Slot = "126")]
	public void IBONCPCMLEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x587E7E0", Offset = "0x587CDE0", VA = "0x18587E7E0", Slot = "127")]
	public void IOAGCIAEOEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x587E3D0", Offset = "0x587C9D0", VA = "0x18587E3D0", Slot = "128")]
	public void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x587CD40", Offset = "0x587B340", VA = "0x18587CD40", Slot = "129")]
	public void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x587BA70", Offset = "0x587A070", VA = "0x18587BA70", Slot = "130")]
	public void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x587BCC0", Offset = "0x587A2C0", VA = "0x18587BCC0", Slot = "131")]
	public void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5880F90", Offset = "0x587F590", VA = "0x185880F90", Slot = "132")]
	public bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x587DD80", Offset = "0x587C380", VA = "0x18587DD80", Slot = "133")]
	public void GOHGOJCFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5881940", Offset = "0x587FF40", VA = "0x185881940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5880000", Offset = "0x587E600", VA = "0x185880000")]
	private void MEDMAJCMCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x587C4F0", Offset = "0x587AAF0", VA = "0x18587C4F0")]
	private void COCCGLDECNM(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x587D150", Offset = "0x587B750", VA = "0x18587D150")]
	private void FNIPOKCMCNK(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x587F980", Offset = "0x587DF80", VA = "0x18587F980")]
	private void LEAFFOKAJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x587D720", Offset = "0x587BD20", VA = "0x18587D720")]
	private void GLDPKJAKPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x587DA30", Offset = "0x587C030", VA = "0x18587DA30")]
	private void GNENODILODM(AOCLEIAJHKP GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x587C360", Offset = "0x587A960", VA = "0x18587C360")]
	private void CDLJGFDMBPL(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x587EBF0", Offset = "0x587D1F0", VA = "0x18587EBF0")]
	private void JDAFCHGGCBG(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x587BB50", Offset = "0x587A150", VA = "0x18587BB50")]
	private void BFPPEDFKJFD(RigidbodyEx HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x58810E0", Offset = "0x587F6E0", VA = "0x1858810E0", Slot = "140")]
	protected virtual void PENLKCHDLNA(RigidbodyEx CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5880250", Offset = "0x587E850", VA = "0x185880250")]
	protected void MKJLIMCNHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x587EDA0", Offset = "0x587D3A0", VA = "0x18587EDA0")]
	protected void JDIBOGNGEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x587B910", Offset = "0x5879F10", VA = "0x18587B910", Slot = "141")]
	protected virtual IDisposable BCEBGHPJKKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class KFJJDFLCDGD
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5895290", Offset = "0x5893890", VA = "0x185895290")]
	public static AOCLEIAJHKP JOHPFINCGNO(this AOCLEIAJHKP CMMIKMENMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5895350", Offset = "0x5893950", VA = "0x185895350")]
	public static bool KNANFEEBKCN(this AOCLEIAJHKP CMMIKMENMLL, AOCLEIAJHKP HOOINOBHKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5895420", Offset = "0x5893A20", VA = "0x185895420")]
	public static bool NFHHNHHPOIB(this AOCLEIAJHKP CMMIKMENMLL, AOCLEIAJHKP HOKCCAOGCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x58953D0", Offset = "0x58939D0", VA = "0x1858953D0")]
	public static RigidbodyEx LKNLGDPHOFN(this AOCLEIAJHKP KIAIEGBMNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x58954A0", Offset = "0x5893AA0", VA = "0x1858954A0")]
	public static CBKENBPBBPK OMHBDNPBCPJ(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MJLAMDFGPOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JDMLJLCMPHD NIFHCDEFIKN;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NOKJNKPCOEE();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JADOCOOIFCO();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IDLJKMLKJDD();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GOHGOJCFBGH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AOCLEIAJHKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	RigidbodyEx LKNLGDPHOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GameObject JPBNIBGFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Transform GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool HPHLPJEDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool IAFGIJMAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform KDBFAEJIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 EFHCKDIEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float CCLJFKBBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float LENGADJAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Quaternion LKLHMLNBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 BMIKEFPDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Quaternion BFLAMDMHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool EBCJPGGOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event JDMLJLCMPHD BFBMPEKKJGF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JDMLJLCMPHD KOPNEFGHFEB;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DOCLCEPDIKL CEAJCLKFGAM;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event JDMLJLCMPHD BPJFEFCOFDJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event JDMLJLCMPHD FNGPCAJNBEG;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event JDMLJLCMPHD HFCHBNGPOEC;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event JDMLJLCMPHD PPDDOEOHENO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event JDMLJLCMPHD NKIOBPKHNKC;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void JBBCPGPOEKL();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NDEMACDLPID();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void HBNCPLGMEPG();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void JAMGDJKMPGM(AOCLEIAJHKP MOLEJFDINLH, bool NOBJEFGBIAD = false);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void DOOGDGHCKAL(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void KGJNGDONAIO(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void JOGGPADGJAK();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void CBENEDLBOAE();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void HDHBMKGNDHJ();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JAAHGENLODK(Vector3 IJOKKCDOCLN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 IHNMKPPJJBP(Vector3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 LNNEJNINGKP(Vector3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void PFLNEDFLBAF();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PPHKMALOPEF(AOCLEIAJHKP ALHMAGPDOEF, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void FPPDIEGBABO(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JADOCOOIFCO();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void NOKJNKPCOEE();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void IDLJKMLKJDD();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool GOCENNMEFGJ();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void PEPAIDKMINN();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable GFGDBJCOOME();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void CKCCNMBNGFO(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void DBBAOMBFPFC(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LEACOJHNOHN(Vector3 ENBHPDFCHED, Quaternion DFJMGODKAOH);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void DLHAAHBBGBF(Vector3 OBPNNJPNPLD, Quaternion FHGFBFMJEOI);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool ODFCAEOGHLD(float MNOGCBMJIKG);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void OANHGPDIJME(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void GEMJLKNCNKG(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IBONCPCMLEF(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void IOAGCIAEOEF(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void GOHGOJCFBGH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DGFAMAIKIOI
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BIEFHFEPLDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FLKHGJHNCJM();

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 EOODJDMOBAD();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OAEPDBGPEAL
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OODMLHNMKAL(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFGBDKKPCEG(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABJIDBHLCGP(AOCLEIAJHKP CMMIKMENMLL);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFOIGPDNOFE(AOCLEIAJHKP CMMIKMENMLL);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLGOPJDLMDM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CKCBLALPPPC : IDisposable, GBKLBEOOIJI
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKEGIFGPECP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IKHJGOOMJIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event JDMLJLCMPHD BFBMPEKKJGF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event JDMLJLCMPHD KOPNEFGHFEB;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event DOCLCEPDIKL CEAJCLKFGAM;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action KLFPOJAEGAN;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action PMGADLIGEOE;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<AOCLEIAJHKP> PMJICKMGPFD;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<AOCLEIAJHKP> FJALACOBLCG;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action ALPOBHDPNAF;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<AOCLEIAJHKP> PPMCMABJHIO;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JAMGDJKMPGM(AOCLEIAJHKP EPBIFMJLJFE, bool NOBJEFGBIAD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface GLLJIFAFPDH
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKHJGOOMJIK EOCBGFJDLBO(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCKCKALDJGJ ANGCPCPAOIC(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKIDFBLCFBC DOAMDCLPEDK(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHMGBIACOME OOHJLBEJDNN(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDEKIIFINIJ HMCMIAGHFPC(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CKCBLALPPPC CHCPKFFBKAB(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NJJAJEPIBDM JLCNCPKNCDJ(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DGFAMAIKIOI OPABALKDHOE(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CJBOBGHJFCG LOAKJLPNBOL(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MGFOKHNGEBJ GNBAKJKCDBI(AOCLEIAJHKP PMIAAPCBGPN);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EHPGBGDNCOD AGJMCCNAKFO(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MEENLNJJFDF NDDNOEGMGCI(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OAEPDBGPEAL FIAKLDMDPHF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MJLAMDFGPOJ GAPAGHJINBP(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JFLCGFJHJOJ IJOABGCKIGA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO, MOKJCBCFMGC AMKEFDBPHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JFLCGFJHJOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool DCDGIGFEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DDPKKPIIEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHJAAICJADK(Vector3 PMCJEEDMODL);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKHDOKNOANE(Vector3 FKNMMHBCHIK);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBOFNOLBNOJ(Vector3 PMCJEEDMODL);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOLEEHLBGPI(Vector3 FKNMMHBCHIK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface NJJAJEPIBDM
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event JDMLJLCMPHD PPDDOEOHENO;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDJHHNKDMMG();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKCCNMBNGFO(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBBAOMBFPFC(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GFGDBJCOOME();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NNLOEEJCNKF(Rigidbody FMPHIOBBCLL);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface CJBOBGHJFCG
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJDKGLDEENB(bool DBCLNOPFJBL);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLNBNGGIGFA(bool DBCLNOPFJBL);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FCKCKALDJGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IIKALEJOAME(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HDHBMKGNDHJ();

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CBENEDLBOAE();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PFLNEDFLBAF();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JOGGPADGJAK();

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IHNMKPPJJBP(Vector3 KEMGHPMICGF);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PNCJLJGGHJN(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JAAHGENLODK(Vector3 IJOKKCDOCLN);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EHPGBGDNCOD
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool MEDJLAALBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IBONCPCMLEF(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOAGCIAEOEF(object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFFCEGLDGNJ();

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFIEMOLOCOA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MGFOKHNGEBJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LDEKIIFINIJ
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event JDMLJLCMPHD HFCHBNGPOEC;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKEGIFGPECP();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GOCENNMEFGJ();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJJPLMDFADN();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBNCPLGMEPG();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJJDNNLLBKG();

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PEPAIDKMINN();

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMENLOEIPCO(bool GLHHGCHMOND);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[OJJOJOKIEBL(typeof(LJAFLCDDJAH), new string[] { })]
public sealed class BKPPHBKNEHD : LPOKOJIEHOF, LJAFLCDDJAH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[LABJLBKOJHN]
	private CMJAGJHDBFI CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x587AED0", Offset = "0x58794D0", VA = "0x18587AED0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x587AD30", Offset = "0x5879330", VA = "0x18587AD30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x587AF20", Offset = "0x5879520", VA = "0x18587AF20", Slot = "6")]
	public void JFEMDGPFPIH(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x587B1F0", Offset = "0x58797F0", VA = "0x18587B1F0", Slot = "7")]
	public void NGPLMKEHGEP(ENMPPPDAMHN HMLJKOHAJKN, bool EDFLKCKFCDC, bool OHHGJDIEOHD, bool BPBGEHLMKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x587B0B0", Offset = "0x58796B0", VA = "0x18587B0B0")]
	private bool MPOBIJNOCJO(ENMPPPDAMHN HMLJKOHAJKN, out AKCGGCOFMHJ PMIAAPCBGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x587AD60", Offset = "0x5879360", VA = "0x18587AD60")]
	private bool ECIKPJCDLCM(ENMPPPDAMHN HMLJKOHAJKN, out GCPMDGBPGGG FKOMPJLGEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BKPPHBKNEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class GCPMDGBPGGG : BBDLNMJHEGL, MJLAMDFGPOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	[Obsolete]
	public Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5888E20", Offset = "0x5887420", VA = "0x185888E20", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5889590", Offset = "0x5887B90", VA = "0x185889590", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 JFIKGKIIECN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5888900", Offset = "0x5886F00", VA = "0x185888900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 GKCHGKNJJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x58887C0", Offset = "0x5886DC0", VA = "0x1858887C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[Obsolete]
	public Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5889CA0", Offset = "0x58882A0", VA = "0x185889CA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	[Obsolete]
	public float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x588B440", Offset = "0x5889A40", VA = "0x18588B440", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float CDJLENJIENC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x588BEB0", Offset = "0x588A4B0", VA = "0x18588BEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x588B350", Offset = "0x5889950", VA = "0x18588B350", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x5889480", Offset = "0x5887A80", VA = "0x185889480", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x588BE80", Offset = "0x588A480", VA = "0x18588BE80", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x5888790", Offset = "0x5886D90", VA = "0x185888790", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5880420", VA = "0x185881E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event JDMLJLCMPHD NIFHCDEFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x588B530", Offset = "0x5889B30", VA = "0x18588B530", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x58886F0", Offset = "0x5886CF0", VA = "0x1858886F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x588BFB0", Offset = "0x588A5B0", VA = "0x18588BFB0")]
	public GCPMDGBPGGG(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5889E20", Offset = "0x5888420", VA = "0x185889E20")]
	public float3 JEFJDODNLEB()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5888A40", Offset = "0x5887040", VA = "0x185888A40", Slot = "14")]
	public void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5889A10", Offset = "0x5888010", VA = "0x185889A10", Slot = "16")]
	public void JADOCOOIFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x588B720", Offset = "0x5889D20", VA = "0x18588B720", Slot = "15")]
	public void NOKJNKPCOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x588B5D0", Offset = "0x5889BD0", VA = "0x18588B5D0", Slot = "18")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x588BB30", Offset = "0x588A130", VA = "0x18588BB30", Slot = "19")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5889920", Offset = "0x5887F20", VA = "0x185889920", Slot = "17")]
	public void IDLJKMLKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5888F60", Offset = "0x5887560", VA = "0x185888F60", Slot = "20")]
	public void GOHGOJCFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5883B70", Offset = "0x5882170", VA = "0x185883B70")]
	public void EFEOHEOJOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5888CD0", Offset = "0x58872D0", VA = "0x185888CD0")]
	private void ENBDOGDIGKA(Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5888580", Offset = "0x5886B80", VA = "0x185888580")]
	[Obsolete]
	private Vector3 BCKEHCFGCDF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5889480", Offset = "0x5887A80", VA = "0x185889480")]
	private void HAHBLFJGLIA(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x588B100", Offset = "0x5889700", VA = "0x18588B100")]
	private Vector3 JMAHBCKMMCB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x58896E0", Offset = "0x5887CE0", VA = "0x1858896E0")]
	private Quaternion HLJLPOFDFKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5889EE0", Offset = "0x58884E0", VA = "0x185889EE0")]
	internal (float, Vector3) JFEMDGPFPIH(Rigidbody KFFOOKGMEFG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class BNFBIMPOEAK
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x587B4E0", Offset = "0x5879AE0", VA = "0x18587B4E0")]
	public static GCPMDGBPGGG KILDFFHFILI(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class GNJFMMGJBIA : BBDLNMJHEGL, FCKCKALDJGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x588EA20", Offset = "0x588D020", VA = "0x18588EA20", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x588EFD0", Offset = "0x588D5D0", VA = "0x18588EFD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5890640", Offset = "0x588EC40", VA = "0x185890640", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5890090", Offset = "0x588E690", VA = "0x185890090", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x588F350", Offset = "0x588D950", VA = "0x18588F350", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x588D3D0", Offset = "0x588B9D0", VA = "0x18588D3D0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x588D140", Offset = "0x588B740", VA = "0x18588D140", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x588FDA0", Offset = "0x588E3A0", VA = "0x18588FDA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x588EB50", Offset = "0x588D150", VA = "0x18588EB50", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x588E230", Offset = "0x588C830", VA = "0x18588E230", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x588F3D0", Offset = "0x588D9D0", VA = "0x18588F3D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x588F400", Offset = "0x588DA00", VA = "0x18588F400", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5890460", Offset = "0x588EA60", VA = "0x185890460", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5890020", Offset = "0x588E620", VA = "0x185890020", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5890550", Offset = "0x588EB50", VA = "0x185890550", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private DGFAMAIKIOI BBIDFHIBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x21EF2A0", Offset = "0x21ED8A0", VA = "0x1821EF2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool GKKIJDNHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x588F3B0", Offset = "0x588D9B0", VA = "0x18588F3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public GNJFMMGJBIA(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x588F4F0", Offset = "0x588DAF0", VA = "0x18588F4F0", Slot = "20")]
	public void IIKALEJOAME(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x58908D0", Offset = "0x588EED0", VA = "0x1858908D0", Slot = "30")]
	public void PNCJLJGGHJN(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x588FFB0", Offset = "0x588E5B0", VA = "0x18588FFB0", Slot = "19")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x588DAA0", Offset = "0x588C0A0", VA = "0x18588DAA0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5890420", Offset = "0x588EA20", VA = "0x185890420", Slot = "28")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x588FDD0", Offset = "0x588E3D0", VA = "0x18588FDD0", Slot = "35")]
	public Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x588D170", Offset = "0x588B770", VA = "0x18588D170", Slot = "34")]
	public Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x588FFB0", Offset = "0x588E5B0", VA = "0x18588FFB0", Slot = "27")]
	public void JOGGPADGJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x588D330", Offset = "0x588B930", VA = "0x18588D330", Slot = "25")]
	public void CBENEDLBOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x588F310", Offset = "0x588D910", VA = "0x18588F310", Slot = "24")]
	public void HDHBMKGNDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x588CEA0", Offset = "0x588B4A0", VA = "0x18588CEA0", Slot = "33")]
	public void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5890030", Offset = "0x588E630", VA = "0x185890030", Slot = "32")]
	public void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x588FBD0", Offset = "0x588E1D0", VA = "0x18588FBD0", Slot = "31")]
	public void JAAHGENLODK(Vector3 IJOKKCDOCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x588EBB0", Offset = "0x588D1B0", VA = "0x18588EBB0", Slot = "22")]
	public void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x588F0D0", Offset = "0x588D6D0", VA = "0x18588F0D0", Slot = "21")]
	public void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x588F8B0", Offset = "0x588DEB0", VA = "0x18588F8B0", Slot = "23")]
	[Obsolete]
	public void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x588F430", Offset = "0x588DA30", VA = "0x18588F430", Slot = "29")]
	public Vector3 IHNMKPPJJBP(Vector3 KEMGHPMICGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5890770", Offset = "0x588ED70", VA = "0x185890770", Slot = "26")]
	public void PFLNEDFLBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x588DBE0", Offset = "0x588C1E0", VA = "0x18588DBE0")]
	private void EGIKGPEOFBN(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5890190", Offset = "0x588E790", VA = "0x185890190")]
	private void MLABEEHFFJL(Vector3 IKJGKNDNGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x588F5F0", Offset = "0x588DBF0", VA = "0x18588F5F0")]
	private Vector3 IMPELKKOENJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x588E5B0", Offset = "0x588CBB0", VA = "0x18588E5B0")]
	private void GCOILLKJJBE(Vector3 GKICFHEAHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x588E2F0", Offset = "0x588C8F0", VA = "0x18588E2F0")]
	private Vector3 EOODJDMOBAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x588DDD0", Offset = "0x588C3D0", VA = "0x18588DDD0")]
	private void EKHDOKNOANE(Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x588D370", Offset = "0x588B970", VA = "0x18588D370")]
	private void CELFANCAFIH(Vector3 KEMGHPMICGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x588D0E0", Offset = "0x588B6E0", VA = "0x18588D0E0")]
	private void ADGFNFAIEDN(Vector3 FKNMMHBCHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x588D490", Offset = "0x588BA90", VA = "0x18588D490")]
	private void DOLJJMLDHEC(string FHHMDKKLBCG, Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5890360", Offset = "0x588E960", VA = "0x185890360")]
	private void NKEKLLDEMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class POCIGAAOPAA : BBDLNMJHEGL, BHMGBIACOME
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1130", Offset = "0x6ECF730", VA = "0x186ED1130", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0FA0", Offset = "0x6ECF5A0", VA = "0x186ED0FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1480", Offset = "0x6ECFA80", VA = "0x186ED1480", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0E10", Offset = "0x6ECF410", VA = "0x186ED0E10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0E00", Offset = "0x6ECF400", VA = "0x186ED0E00")]
	public POCIGAAOPAA(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1220", Offset = "0x6ECF820", VA = "0x186ED1220", Slot = "8")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1410", Offset = "0x6ECFA10", VA = "0x186ED1410", Slot = "9")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[UnityEngine.Scripting.Preserve]
public sealed class BPJMFIFDPJO : AOCLEIAJHKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly BPJMFIFDPJO HAMPJMKDJOL;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public RigidbodyEx LKNLGDPHOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GameObject JPBNIBGFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Transform GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9F6FE0", Offset = "0x9F55E0", VA = "0x1809F6FE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA753E0", Offset = "0xA739E0", VA = "0x180A753E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x13DF1D0", Offset = "0x13DD7D0", VA = "0x1813DF1D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x20C8000", Offset = "0x20C6600", VA = "0x1820C8000", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x164DC50", Offset = "0x164C250", VA = "0x18164DC50", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2549110", Offset = "0x2547710", VA = "0x182549110", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D810", Offset = "0x2F9BE10", VA = "0x182F9D810", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x587B660", Offset = "0x5879C60", VA = "0x18587B660", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x457D310", Offset = "0x457B910", VA = "0x18457D310", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1B6D8A0", Offset = "0x1B6BEA0", VA = "0x181B6D8A0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool HPHLPJEDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA095E0", VA = "0x180A0AFE0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IAFGIJMAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A530", VA = "0x180A0BF30", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x10FFA90", Offset = "0x10FE090", VA = "0x1810FFA90", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D840", Offset = "0x2F9BE40", VA = "0x182F9D840", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1164B80", Offset = "0x1163180", VA = "0x181164B80", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF21D0", Offset = "0x1DF07D0", VA = "0x181DF21D0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x587B670", Offset = "0x5879C70", VA = "0x18587B670", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0ADA0", VA = "0x180A0C7A0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x15805E0", Offset = "0x157EBE0", VA = "0x1815805E0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0ADA0", VA = "0x180A0C7A0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0ADA0", VA = "0x180A0C7A0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "48")]
		get
		{
			return default(LMDIKFABHDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x587B680", Offset = "0x5879C80", VA = "0x18587B680", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Transform KDBFAEJIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9EE500", Offset = "0x9ECB00", VA = "0x1809EE500", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 EFHCKDIEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float CCLJFKBBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0ADA0", VA = "0x180A0C7A0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float LENGADJAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C7A0", Offset = "0xA0ADA0", VA = "0x180A0C7A0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion LKLHMLNBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xC4D4B0", Offset = "0xC4BAB0", VA = "0x180C4D4B0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 BMIKEFPDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Quaternion BFLAMDMHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xC4D4B0", Offset = "0xC4BAB0", VA = "0x180C4D4B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool EBCJPGGOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xEF2520", Offset = "0xEF0B20", VA = "0x180EF2520", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event JDMLJLCMPHD BFBMPEKKJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event JDMLJLCMPHD KOPNEFGHFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event DOCLCEPDIKL CEAJCLKFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event JDMLJLCMPHD BPJFEFCOFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event JDMLJLCMPHD FNGPCAJNBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event JDMLJLCMPHD HFCHBNGPOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event JDMLJLCMPHD PPDDOEOHENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event JDMLJLCMPHD NKIOBPKHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "41")]
	public void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "71")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "72")]
	public void JBBCPGPOEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "73")]
	public void NDEMACDLPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "74")]
	public void HBNCPLGMEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "81")]
	public void JAMGDJKMPGM(AOCLEIAJHKP MOLEJFDINLH, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "84")]
	public void DOOGDGHCKAL(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "85")]
	public void KGJNGDONAIO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "86")]
	public Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "87")]
	public Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "88")]
	public void JOGGPADGJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "89")]
	public void CBENEDLBOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "90")]
	public void HDHBMKGNDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "91")]
	public void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "92")]
	public void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "93")]
	public void JAAHGENLODK(Vector3 IJOKKCDOCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "94")]
	public void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "95")]
	public void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "96")]
	public void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "97")]
	public Vector3 IHNMKPPJJBP(Vector3 MOLEJFDINLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1848100", Offset = "0x1846700", VA = "0x181848100", Slot = "98")]
	public Vector3 LNNEJNINGKP(Vector3 MOLEJFDINLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "99")]
	public void PFLNEDFLBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "100")]
	public void PPHKMALOPEF(AOCLEIAJHKP ALHMAGPDOEF, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "101")]
	public void FPPDIEGBABO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "104")]
	public void JADOCOOIFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "105")]
	public void NOKJNKPCOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "106")]
	public void IDLJKMLKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "109")]
	public bool GOCENNMEFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "110")]
	public void PEPAIDKMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "115")]
	public IDisposable GFGDBJCOOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "116")]
	public void CKCCNMBNGFO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "117")]
	public void DBBAOMBFPFC(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "118")]
	public void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "121")]
	public void LEACOJHNOHN(Vector3 ENBHPDFCHED, Quaternion DFJMGODKAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "122")]
	public void DLHAAHBBGBF(Vector3 OBPNNJPNPLD, Quaternion FHGFBFMJEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "123")]
	public bool ODFCAEOGHLD(float MNOGCBMJIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "124")]
	public void OANHGPDIJME(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "125")]
	public void GEMJLKNCNKG(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "126")]
	public void IBONCPCMLEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "127")]
	public void IOAGCIAEOEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "128")]
	public void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "129")]
	public void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "130")]
	public void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "131")]
	public void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x587B690", Offset = "0x5879C90", VA = "0x18587B690", Slot = "132")]
	public bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "133")]
	public void GOHGOJCFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BPJMFIFDPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class GJEKEOMPNMB : BBDLNMJHEGL, KKIDFBLCFBC
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x588C3D0", Offset = "0x588A9D0", VA = "0x18588C3D0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x588C920", Offset = "0x588AF20", VA = "0x18588C920", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x588C580", Offset = "0x588AB80", VA = "0x18588C580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private AOCLEIAJHKP FCMMDOINFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x588C400", Offset = "0x588AA00", VA = "0x18588C400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public GJEKEOMPNMB(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x588C660", Offset = "0x588AC60", VA = "0x18588C660", Slot = "6")]
	public void KIKNGELNMKB(AOCLEIAJHKP HDBBNLFBJKG, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x588C7E0", Offset = "0x588ADE0", VA = "0x18588C7E0")]
	private void KIKNGELNMKB(AKCGGCOFMHJ HDBBNLFBJKG, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x588C2D0", Offset = "0x588A8D0", VA = "0x18588C2D0", Slot = "7")]
	public void BAONEFAIICM(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x588CAE0", Offset = "0x588B0E0", VA = "0x18588CAE0")]
	private Vector3 PPANNGELJGP()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class PCFNNFFDPNM
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF560", Offset = "0x6ECDB60", VA = "0x186ECF560")]
	public static GJEKEOMPNMB ANPDBNKFOGH(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class NPDJILHGCBI : BBDLNMJHEGL, IKHJGOOMJIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly IAMDAJKPFJC LDDMMKAMHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HMFKOFHCLDM HDNKPAOOMEP;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Transform GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x589C9D0", Offset = "0x589AFD0", VA = "0x18589C9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public ENMPPPDAMHN OAAGPJEEBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x589D870", Offset = "0x589BE70", VA = "0x18589D870")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x589CA00", Offset = "0x589B000", VA = "0x18589CA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x589D430", Offset = "0x589BA30", VA = "0x18589D430", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x589D470", Offset = "0x589BA70", VA = "0x18589D470", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ENMPPPDAMHN OCJBIKIGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x589C030", Offset = "0x589A630", VA = "0x18589C030")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x589C540", Offset = "0x589AB40", VA = "0x18589C540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x589C8F0", Offset = "0x589AEF0", VA = "0x18589C8F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event JDMLJLCMPHD BFBMPEKKJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x589C850", Offset = "0x589AE50", VA = "0x18589C850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x589CD40", Offset = "0x589B340", VA = "0x18589CD40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event JDMLJLCMPHD KOPNEFGHFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x589D4E0", Offset = "0x589BAE0", VA = "0x18589D4E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x589CB10", Offset = "0x589B110", VA = "0x18589CB10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DOCLCEPDIKL CEAJCLKFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x589B520", Offset = "0x5899B20", VA = "0x18589B520", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x589CF70", Offset = "0x589B570", VA = "0x18589CF70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action KLFPOJAEGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x589C4A0", Offset = "0x589AAA0", VA = "0x18589C4A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x589D0B0", Offset = "0x589B6B0", VA = "0x18589D0B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action PMGADLIGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x589CDE0", Offset = "0x589B3E0", VA = "0x18589CDE0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x589C400", Offset = "0x589AA00", VA = "0x18589C400", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<AOCLEIAJHKP> PMJICKMGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x589C140", Offset = "0x589A740", VA = "0x18589C140", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x589BE30", Offset = "0x589A430", VA = "0x18589BE30", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<AOCLEIAJHKP> FJALACOBLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x589C930", Offset = "0x589AF30", VA = "0x18589C930", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x589D010", Offset = "0x589B610", VA = "0x18589D010", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action ALPOBHDPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x589D150", Offset = "0x589B750", VA = "0x18589D150", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x589CCA0", Offset = "0x589B2A0", VA = "0x18589CCA0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<AOCLEIAJHKP> PPMCMABJHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x589D1F0", Offset = "0x589B7F0", VA = "0x18589D1F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x589C7B0", Offset = "0x589ADB0", VA = "0x18589C7B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x589DA10", Offset = "0x589C010", VA = "0x18589DA10")]
	public NPDJILHGCBI(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x589C1E0", Offset = "0x589A7E0", VA = "0x18589C1E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x589CC20", Offset = "0x589B220", VA = "0x18589CC20", Slot = "26")]
	public void JAMGDJKMPGM(AOCLEIAJHKP EPBIFMJLJFE, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x589CBB0", Offset = "0x589B1B0", VA = "0x18589CBB0")]
	private void JAMGDJKMPGM(AKCGGCOFMHJ EPBIFMJLJFE, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x589B5C0", Offset = "0x5899BC0", VA = "0x18589B5C0")]
	private void ACHGPBEGKLH(AKCGGCOFMHJ EPBIFMJLJFE, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x589BC80", Offset = "0x589A280", VA = "0x18589BC80")]
	private void ALLFDCABEOP(AKCGGCOFMHJ GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x589D290", Offset = "0x589B890", VA = "0x18589D290")]
	private void OHPBPICONDB(AKCGGCOFMHJ GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x589D640", Offset = "0x589BC40", VA = "0x18589D640")]
	private void PKAODCBFKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x589CE80", Offset = "0x589B480", VA = "0x18589CE80")]
	private void KKGODJCIMGG(AKCGGCOFMHJ GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x589D580", Offset = "0x589BB80", VA = "0x18589D580")]
	private void PGCEKBFOLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x589BED0", Offset = "0x589A4D0", VA = "0x18589BED0")]
	private void CNLHCEJCBPI(AKCGGCOFMHJ CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x589C650", Offset = "0x589AC50", VA = "0x18589C650")]
	private void FNKCMBBPENL(AKCGGCOFMHJ CMMIKMENMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class EIIKJGACJPC
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x58872E0", Offset = "0x58858E0", VA = "0x1858872E0")]
	public static NPDJILHGCBI FBPKJDCDANM(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AKCGGCOFMHJ : CBKENBPBBPK, NBAPNPGIPAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal CMJAGJHDBFI PJCPCPDDBAM;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x587A770", Offset = "0x5878D70", VA = "0x18587A770")]
	public AKCGGCOFMHJ(GameObject FLCGKEKAMCK, RigidbodyEx NDNCKODFKIM, MOKJCBCFMGC AMKEFDBPHKK, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x587A480", Offset = "0x5878A80", VA = "0x18587A480", Slot = "135")]
	protected override void LGHNOMAHJML(MOKJCBCFMGC AMKEFDBPHKK, BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "141")]
	protected override IDisposable BCEBGHPJKKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x587A050", Offset = "0x5878650", VA = "0x18587A050", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x587A3C0", Offset = "0x58789C0", VA = "0x18587A3C0", Slot = "142")]
	public void KIKBPHKHBBI(PLHLBCMJFLC LKPPDEOAPDB, PLHLBCMJFLC ENDLICBNMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x587A1E0", Offset = "0x58787E0", VA = "0x18587A1E0", Slot = "143")]
	public void GBPCDOPOOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x587A300", Offset = "0x5878900", VA = "0x18587A300", Slot = "144")]
	public void JJMJIIPPJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x587A2A0", Offset = "0x58788A0", VA = "0x18587A2A0", Slot = "145")]
	public void GMENLOEIPCO(bool GLHHGCHMOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5879CA0", Offset = "0x58782A0", VA = "0x185879CA0", Slot = "146")]
	public bool CBIJPEJAMND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x587A710", Offset = "0x5878D10", VA = "0x18587A710", Slot = "147")]
	public void PIJJBKLNHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "140")]
	protected override void PENLKCHDLNA(RigidbodyEx OINELIMPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5879E10", Offset = "0x5878410", VA = "0x185879E10")]
	private void DOPNPINJOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class INAEBFDPKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5891AE0", Offset = "0x58900E0", VA = "0x185891AE0")]
	public static CBKENBPBBPK ANIDHOPBHDE(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NEJLDMJOCAO : BBDLNMJHEGL, OAEPDBGPEAL
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool MMOAGBOLPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5899000", Offset = "0x5897600", VA = "0x185899000", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public LMAKLIPDGJL BBPIGHCKMJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5898D20", Offset = "0x5897320", VA = "0x185898D20", Slot = "11")]
		get
		{
			return default(LMAKLIPDGJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private LMAKLIPDGJL LGHOHDJANKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5898D30", Offset = "0x5897330", VA = "0x185898D30")]
		get
		{
			return default(LMAKLIPDGJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5898E20", Offset = "0x5897420", VA = "0x185898E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x58995D0", Offset = "0x5897BD0", VA = "0x1858995D0")]
	public NEJLDMJOCAO(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5899510", Offset = "0x5897B10", VA = "0x185899510", Slot = "4")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5898F20", Offset = "0x5897520", VA = "0x185898F20")]
	private bool JNNMJIBLIOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5899310", Offset = "0x5897910", VA = "0x185899310", Slot = "5")]
	public void OODMLHNMKAL(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5899200", Offset = "0x5897800", VA = "0x185899200", Slot = "6")]
	public void NFGBDKKPCEG(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x58990F0", Offset = "0x58976F0", VA = "0x1858990F0", Slot = "9")]
	public void MLGOPJDLMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5899420", Offset = "0x5897A20", VA = "0x185899420")]
	private void PAFGBOGCJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5898B90", Offset = "0x5897190", VA = "0x185898B90")]
	private void BALFDHBAICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5898FC0", Offset = "0x58975C0", VA = "0x185898FC0", Slot = "8")]
	public void LFOIGPDNOFE(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5898B50", Offset = "0x5897150", VA = "0x185898B50", Slot = "7")]
	public void ABJIDBHLCGP(AOCLEIAJHKP CMMIKMENMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class PPNDJPJJKEO : BBDLNMJHEGL, DGFAMAIKIOI
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1F30", Offset = "0x6ED0530", VA = "0x186ED1F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED27A0", Offset = "0x6ED0DA0", VA = "0x186ED27A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2820", Offset = "0x6ED0E20", VA = "0x186ED2820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6ED27C0", Offset = "0x6ED0DC0", VA = "0x186ED27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0E00", Offset = "0x6ECF400", VA = "0x186ED0E00")]
	public PPNDJPJJKEO(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6ED26B0", Offset = "0x6ED0CB0", VA = "0x186ED26B0", Slot = "4")]
	public void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2160", Offset = "0x6ED0760", VA = "0x186ED2160")]
	private void FHENODHMHOO(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1F50", Offset = "0x6ED0550", VA = "0x186ED1F50", Slot = "5")]
	public void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1C10", Offset = "0x6ED0210", VA = "0x186ED1C10", Slot = "6")]
	public void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6ED23C0", Offset = "0x6ED09C0", VA = "0x186ED23C0")]
	private void GEJGOLEDPMD(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1D30", Offset = "0x6ED0330", VA = "0x186ED1D30", Slot = "7")]
	public void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6ED25C0", Offset = "0x6ED0BC0", VA = "0x186ED25C0")]
	private void ICFDANBOLEC(string DPAJDIEBNKM, UnityEngine.Object MFPELEJLJLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IPHPLOLFCEP : BBDLNMJHEGL, EHPGBGDNCOD
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5891B30", Offset = "0x5890130", VA = "0x185891B30", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x58922E0", Offset = "0x58908E0", VA = "0x1858922E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5882820", Offset = "0x5880E20", VA = "0x185882820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool MEDJLAALBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5892640", Offset = "0x5890C40", VA = "0x185892640", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x58927E0", Offset = "0x5890DE0", VA = "0x1858927E0")]
	public IPHPLOLFCEP(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5892730", Offset = "0x5890D30", VA = "0x185892730", Slot = "5")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x58920C0", Offset = "0x58906C0", VA = "0x1858920C0", Slot = "7")]
	public void IBONCPCMLEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x58921D0", Offset = "0x58907D0", VA = "0x1858921D0", Slot = "8")]
	public void IOAGCIAEOEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5891C20", Offset = "0x5890220", VA = "0x185891C20", Slot = "9")]
	public void FFFCEGLDGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x58923E0", Offset = "0x58909E0", VA = "0x1858923E0", Slot = "11")]
	public void LAHBFIHNCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5891EF0", Offset = "0x58904F0", VA = "0x185891EF0", Slot = "12")]
	public void GLBDKENIKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "10")]
	public void KFIEMOLOCOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class DFBLPDGBEPE : BBDLNMJHEGL, NJJAJEPIBDM
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5884260", Offset = "0x5882860", VA = "0x185884260", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private bool IEIFAHGJAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5883BB0", Offset = "0x58821B0", VA = "0x185883BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event JDMLJLCMPHD PPDDOEOHENO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5883AB0", Offset = "0x58820B0", VA = "0x185883AB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5883CA0", Offset = "0x58822A0", VA = "0x185883CA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public DFBLPDGBEPE(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5883D40", Offset = "0x5882340", VA = "0x185883D40", Slot = "11")]
	public IDisposable GFGDBJCOOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5883B50", Offset = "0x5882150", VA = "0x185883B50", Slot = "8")]
	public void CKCCNMBNGFO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5883B60", Offset = "0x5882160", VA = "0x185883B60", Slot = "9")]
	public void DBBAOMBFPFC(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5883DA0", Offset = "0x58823A0", VA = "0x185883DA0", Slot = "10")]
	public void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5883EB0", Offset = "0x58824B0", VA = "0x185883EB0", Slot = "12")]
	public void NNLOEEJCNKF(Rigidbody FMPHIOBBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5884050", Offset = "0x5882650", VA = "0x185884050", Slot = "13")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5883B70", Offset = "0x5882170", VA = "0x185883B70", Slot = "6")]
	public void DDJHHNKDMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MHLOJLDNPKJ : BBDLNMJHEGL, CJBOBGHJFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private CollisionDetectionMode NHINKIOFIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5897A70", Offset = "0x5896070", VA = "0x185897A70")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x58975A0", Offset = "0x5895BA0", VA = "0x1858975A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5880420", VA = "0x185881E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x58976A0", Offset = "0x5895CA0", VA = "0x1858976A0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5897520", Offset = "0x5895B20", VA = "0x185897520", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public MHLOJLDNPKJ(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5897CD0", Offset = "0x58962D0", VA = "0x185897CD0", Slot = "6")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x58979E0", Offset = "0x5895FE0", VA = "0x1858979E0", Slot = "9")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x58977B0", Offset = "0x5895DB0", VA = "0x1858977B0", Slot = "7")]
	public void IJDKGLDEENB(bool DBCLNOPFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5897510", Offset = "0x5895B10", VA = "0x185897510", Slot = "8")]
	public void BLNBNGGIGFA(bool DBCLNOPFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5897B60", Offset = "0x5896160", VA = "0x185897B60", Slot = "10")]
	public bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x58977C0", Offset = "0x5895DC0", VA = "0x1858977C0")]
	private void LGDHBGFFGMO(bool DBCLNOPFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DefaultMember("Item")]
public sealed class HMFKOFHCLDM : IReadOnlyList<AOCLEIAJHKP>, IEnumerable<AOCLEIAJHKP>, IEnumerable, IReadOnlyCollection<AOCLEIAJHKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly CMJAGJHDBFI GEDHMEAEIPA;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5890BD0", Offset = "0x588F1D0", VA = "0x185890BD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public AOCLEIAJHKP ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5890CB0", Offset = "0x588F2B0", VA = "0x185890CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5890B80", Offset = "0x588F180", VA = "0x185890B80")]
	public HMFKOFHCLDM(ENMPPPDAMHN GIAMACBDIFH, CMJAGJHDBFI GEDHMEAEIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x58909D0", Offset = "0x588EFD0", VA = "0x1858909D0", Slot = "6")]
	public IEnumerator<AOCLEIAJHKP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x58909D0", Offset = "0x588EFD0", VA = "0x1858909D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5890B70", Offset = "0x588F170", VA = "0x185890B70")]
	[CompilerGenerated]
	private AOCLEIAJHKP LPKCLKJANLN(int GPAKLECDLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PPKPEDGMLOB : GLLJIFAFPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1770", Offset = "0x6ECFD70", VA = "0x186ED1770", Slot = "4")]
	public IKHJGOOMJIK EOCBGFJDLBO(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6ED15E0", Offset = "0x6ECFBE0", VA = "0x186ED15E0", Slot = "5")]
	public FCKCKALDJGJ ANGCPCPAOIC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6ED16A0", Offset = "0x6ECFCA0", VA = "0x186ED16A0", Slot = "6")]
	public KKIDFBLCFBC DOAMDCLPEDK(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1B50", Offset = "0x6ED0150", VA = "0x186ED1B50", Slot = "7")]
	public BHMGBIACOME OOHJLBEJDNN(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1910", Offset = "0x6ECFF10", VA = "0x186ED1910", Slot = "8")]
	public LDEKIIFINIJ HMCMIAGHFPC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1640", Offset = "0x6ECFC40", VA = "0x186ED1640", Slot = "9")]
	public CKCBLALPPPC CHCPKFFBKAB(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1A20", Offset = "0x6ED0020", VA = "0x186ED1A20", Slot = "10")]
	public NJJAJEPIBDM JLCNCPKNCDJ(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1BB0", Offset = "0x6ED01B0", VA = "0x186ED1BB0", Slot = "11")]
	public DGFAMAIKIOI OPABALKDHOE(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1AF0", Offset = "0x6ED00F0", VA = "0x186ED1AF0", Slot = "12")]
	public CJBOBGHJFCG LOAKJLPNBOL(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED18B0", Offset = "0x6ECFEB0", VA = "0x186ED18B0", Slot = "13")]
	public MGFOKHNGEBJ GNBAKJKCDBI(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1570", Offset = "0x6ECFB70", VA = "0x186ED1570")]
	public EHPGBGDNCOD AGJMCCNAKFO(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1A80", Offset = "0x6ED0080", VA = "0x186ED1A80")]
	public MEENLNJJFDF NDDNOEGMGCI(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1700", Offset = "0x6ECFD00", VA = "0x186ED1700")]
	public OAEPDBGPEAL FIAKLDMDPHF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1840", Offset = "0x6ECFE40", VA = "0x186ED1840")]
	public MJLAMDFGPOJ GAPAGHJINBP(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6ED17D0", Offset = "0x6ECFDD0", VA = "0x186ED17D0")]
	public JFLCGFJHJOJ IJOABGCKIGA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1970", Offset = "0x6ECFF70", VA = "0x186ED1970", Slot = "19")]
	public AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO, MOKJCBCFMGC AMKEFDBPHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public PPKPEDGMLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1570", Offset = "0x6ECFB70", VA = "0x186ED1570", Slot = "14")]
	private EHPGBGDNCOD NCCOHOKBDBL(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1A80", Offset = "0x6ED0080", VA = "0x186ED1A80", Slot = "15")]
	private MEENLNJJFDF KIMBNEBOIPA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1700", Offset = "0x6ECFD00", VA = "0x186ED1700", Slot = "16")]
	private OAEPDBGPEAL ECKKODBGGLE(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1840", Offset = "0x6ECFE40", VA = "0x186ED1840", Slot = "17")]
	private MJLAMDFGPOJ ODLCKGGIEOF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6ED17D0", Offset = "0x6ECFDD0", VA = "0x186ED17D0", Slot = "18")]
	private JFLCGFJHJOJ FPMGIHJNCFC(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MCNGGMCMFCJ : BBDLNMJHEGL, LDEKIIFINIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5880420", VA = "0x185881E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool GKKIJDNHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x588F3B0", Offset = "0x588D9B0", VA = "0x18588F3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5897030", Offset = "0x5895630", VA = "0x185897030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5897290", Offset = "0x5895890", VA = "0x185897290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private bool AJMKJNDENPN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5896660", Offset = "0x5894C60", VA = "0x185896660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5896D30", Offset = "0x5895330", VA = "0x185896D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private bool GOPHNLNDLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5896AE0", Offset = "0x58950E0", VA = "0x185896AE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5896E30", Offset = "0x5895430", VA = "0x185896E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private int GBFHLLHAJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x5896F30", Offset = "0x5895530", VA = "0x185896F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event JDMLJLCMPHD HFCHBNGPOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5896750", Offset = "0x5894D50", VA = "0x185896750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5897140", Offset = "0x5895740", VA = "0x185897140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x58972F0", Offset = "0x58958F0", VA = "0x1858972F0")]
	public MCNGGMCMFCJ(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x58971E0", Offset = "0x58957E0", VA = "0x1858971E0", Slot = "6")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x58967F0", Offset = "0x5894DF0", VA = "0x1858967F0", Slot = "8")]
	public void EJJPLMDFADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5896800", Offset = "0x5894E00", VA = "0x185896800", Slot = "7")]
	public bool GOCENNMEFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5896A30", Offset = "0x5895030", VA = "0x185896A30", Slot = "9")]
	public void HBNCPLGMEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5883B70", Offset = "0x5882170", VA = "0x185883B70", Slot = "12")]
	public void GMENLOEIPCO(bool GLHHGCHMOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5897090", Offset = "0x5895690", VA = "0x185897090", Slot = "11")]
	public void PEPAIDKMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "10")]
	public void KJJDNNLLBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5896BD0", Offset = "0x58951D0", VA = "0x185896BD0")]
	private void IKNGIANFDMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[OJJOJOKIEBL(typeof(GLLJIFAFPDH), new string[] { })]
public class PGDLBKAKKDE : GLLJIFAFPDH, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GLLJIFAFPDH AHAANACNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GLLJIFAFPDH DDHJCLEIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private HMKFBCDDIDP FBFEJLEAOON;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private GLLJIFAFPDH JODJFGCOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECFFE0", Offset = "0x6ECE5E0", VA = "0x186ECFFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFC50", Offset = "0x6ECE250", VA = "0x186ECFC50", Slot = "20")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF910", Offset = "0x6ECDF10", VA = "0x186ECF910", Slot = "4")]
	public IKHJGOOMJIK EOCBGFJDLBO(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF680", Offset = "0x6ECDC80", VA = "0x186ECF680", Slot = "5")]
	public FCKCKALDJGJ ANGCPCPAOIC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF7C0", Offset = "0x6ECDDC0", VA = "0x186ECF7C0", Slot = "6")]
	public KKIDFBLCFBC DOAMDCLPEDK(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0040", Offset = "0x6ECE640", VA = "0x186ED0040", Slot = "7")]
	public BHMGBIACOME OOHJLBEJDNN(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFBB0", Offset = "0x6ECE1B0", VA = "0x186ECFBB0", Slot = "8")]
	public LDEKIIFINIJ HMCMIAGHFPC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF720", Offset = "0x6ECDD20", VA = "0x186ECF720", Slot = "9")]
	public CKCBLALPPPC CHCPKFFBKAB(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFDF0", Offset = "0x6ECE3F0", VA = "0x186ECFDF0", Slot = "10")]
	public NJJAJEPIBDM JLCNCPKNCDJ(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6ED00E0", Offset = "0x6ECE6E0", VA = "0x186ED00E0", Slot = "11")]
	public DGFAMAIKIOI OPABALKDHOE(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFF40", Offset = "0x6ECE540", VA = "0x186ECFF40", Slot = "12")]
	public CJBOBGHJFCG LOAKJLPNBOL(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFB10", Offset = "0x6ECE110", VA = "0x186ECFB10", Slot = "13")]
	public MGFOKHNGEBJ GNBAKJKCDBI(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF5D0", Offset = "0x6ECDBD0", VA = "0x186ECF5D0")]
	public EHPGBGDNCOD AGJMCCNAKFO(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFE90", Offset = "0x6ECE490", VA = "0x186ECFE90")]
	public MEENLNJJFDF NDDNOEGMGCI(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF860", Offset = "0x6ECDE60", VA = "0x186ECF860")]
	public OAEPDBGPEAL FIAKLDMDPHF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFA60", Offset = "0x6ECE060", VA = "0x186ECFA60")]
	public MJLAMDFGPOJ GAPAGHJINBP(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF9B0", Offset = "0x6ECDFB0", VA = "0x186ECF9B0")]
	public JFLCGFJHJOJ IJOABGCKIGA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFCA0", Offset = "0x6ECE2A0", VA = "0x186ECFCA0", Slot = "19")]
	public AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO, MOKJCBCFMGC AMKEFDBPHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0180", Offset = "0x6ECE780", VA = "0x186ED0180")]
	public PGDLBKAKKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF5D0", Offset = "0x6ECDBD0", VA = "0x186ECF5D0", Slot = "14")]
	private EHPGBGDNCOD NCCOHOKBDBL(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFE90", Offset = "0x6ECE490", VA = "0x186ECFE90", Slot = "15")]
	private MEENLNJJFDF KIMBNEBOIPA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF860", Offset = "0x6ECDE60", VA = "0x186ECF860", Slot = "16")]
	private OAEPDBGPEAL ECKKODBGGLE(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFA60", Offset = "0x6ECE060", VA = "0x186ECFA60", Slot = "17")]
	private MJLAMDFGPOJ ODLCKGGIEOF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF9B0", Offset = "0x6ECDFB0", VA = "0x186ECF9B0", Slot = "18")]
	private JFLCGFJHJOJ FPMGIHJNCFC(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EEGLDEPMPNI : BBDLNMJHEGL, MGFOKHNGEBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5886E90", Offset = "0x5885490", VA = "0x185886E90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5886CA0", Offset = "0x58852A0", VA = "0x185886CA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public EEGLDEPMPNI(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5886F80", Offset = "0x5885580", VA = "0x185886F80", Slot = "6")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x58870A0", Offset = "0x58856A0", VA = "0x1858870A0", Slot = "7")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class BBDLNMJHEGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly AKCGGCOFMHJ CMMIKMENMLL;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected CMJAGJHDBFI IJAHCBLOGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x587AB70", Offset = "0x5879170", VA = "0x18587AB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x587AB40", Offset = "0x5879140", VA = "0x18587AB40")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x587ACB0", Offset = "0x58792B0", VA = "0x18587ACB0")]
	public BBDLNMJHEGL(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x587AB90", Offset = "0x5879190", VA = "0x18587AB90")]
	protected AOCLEIAJHKP GFGHDMNPPOM(ENMPPPDAMHN GIAMACBDIFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class LAGBCMIBMLH : BBDLNMJHEGL, MEENLNJJFDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PhotonView FPBBDDNIIJP;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5895720", Offset = "0x5893D20", VA = "0x185895720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x58963B0", Offset = "0x58949B0", VA = "0x1858963B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event JDMLJLCMPHD BPJFEFCOFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5895F90", Offset = "0x5894590", VA = "0x185895F90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5895740", Offset = "0x5893D40", VA = "0x185895740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5896500", Offset = "0x5894B00", VA = "0x185896500")]
	public LAGBCMIBMLH(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5896030", Offset = "0x5894630", VA = "0x185896030", Slot = "8")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x58957E0", Offset = "0x5893DE0", VA = "0x1858957E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5895510", Offset = "0x5893B10", VA = "0x185895510", Slot = "9")]
	public void CDLJGFDMBPL(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5895D80", Offset = "0x5894380", VA = "0x185895D80", Slot = "10")]
	public void JDAFCHGGCBG(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5896180", Offset = "0x5894780", VA = "0x185896180")]
	private void PKPLGCJFFML(PhotonView PLIPDENHEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x58959F0", Offset = "0x5893FF0", VA = "0x1858959F0")]
	private void EDJGCFIPCCF(RigidbodyEx NCILAHEJPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5895BA0", Offset = "0x58941A0", VA = "0x185895BA0")]
	private void HOHGCHCHINP(PhotonView MKEPLFEMDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class BLDGPGJHIPM
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x587B480", Offset = "0x5879A80", VA = "0x18587B480")]
	public static LAGBCMIBMLH AHBEEDIDIOM(this CBKENBPBBPK PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class DOGJAKNKDDI : BBDLNMJHEGL, JFLCGFJHJOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x5886640", Offset = "0x5884C40", VA = "0x185886640", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5886350", Offset = "0x5884950", VA = "0x185886350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool DCDGIGFEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x5886550", Offset = "0x5884B50", VA = "0x185886550", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5886450", Offset = "0x5884A50", VA = "0x185886450")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5886730", Offset = "0x5884D30", VA = "0x185886730", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x5886140", Offset = "0x5884740", VA = "0x185886140", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5886A50", Offset = "0x5885050", VA = "0x185886A50")]
	public DOGJAKNKDDI(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5886820", Offset = "0x5884E20", VA = "0x185886820", Slot = "9")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5886940", Offset = "0x5884F40", VA = "0x185886940", Slot = "10")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class PNDIFNLNLFB : BBDLNMJHEGL, CKCBLALPPPC, IDisposable, GBKLBEOOIJI
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public LMDIKFABHDL OGOHDPFPCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6ED08D0", Offset = "0x6ECEED0", VA = "0x186ED08D0")]
		get
		{
			return default(LMDIKFABHDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0A60", Offset = "0x6ECF060", VA = "0x186ED0A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0B70", Offset = "0x6ECF170", VA = "0x186ED0B70", Slot = "6")]
		get
		{
			return default(LMDIKFABHDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0A60", Offset = "0x6ECF060", VA = "0x186ED0A60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private Transform DGHEOLAFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0D00", Offset = "0x6ECF300", VA = "0x186ED0D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6ED09C0", Offset = "0x6ECEFC0", VA = "0x186ED09C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0E00", Offset = "0x6ECF400", VA = "0x186ED0E00")]
	public PNDIFNLNLFB(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0DA0", Offset = "0x6ECF3A0", VA = "0x186ED0DA0", Slot = "11")]
	public void OnChangedDistanceBand(DBOALJMGPFL LKPPDEOAPDB, DBOALJMGPFL ENDLICBNMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "12")]
	public void OnChangedVisibility(bool NEDCLNHOJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class PJHDIKDHAKI : CKCBLALPPPC, IDisposable, GBKLBEOOIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LMDIKFABHDL IKNAOECDJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private LIENANGMHBE LJHCOEJGOJB;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LMDIKFABHDL NJBJKOECIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6ED04E0", Offset = "0x6ECEAE0", VA = "0x186ED04E0", Slot = "6")]
		get
		{
			return default(LMDIKFABHDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0410", Offset = "0x6ECEA10", VA = "0x186ED0410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private Transform DGHEOLAFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x6ED03F0", Offset = "0x6ECE9F0", VA = "0x186ED03F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<DBOALJMGPFL, DBOALJMGPFL> JKOFKIEEDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0590", Offset = "0x6ECEB90", VA = "0x186ED0590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6ED0350", Offset = "0x6ECE950", VA = "0x186ED0350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0890", Offset = "0x6ECEE90", VA = "0x186ED0890")]
	public PJHDIKDHAKI(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0630", Offset = "0x6ECEC30", VA = "0x186ED0630", Slot = "8")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6ED02A0", Offset = "0x6ECE8A0", VA = "0x186ED02A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6ED02F0", Offset = "0x6ECE8F0", VA = "0x186ED02F0", Slot = "11")]
	private void FFEDBCDIDAJ(DBOALJMGPFL PPJEODAFBKD, DBOALJMGPFL FFAOKGEEGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "12")]
	private void BFCCMLIMJFI(bool NEDCLNHOJGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class MOBAMIJAHPJ : NNEHCPBHLPA, MEENLNJJFDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PhotonView FPBBDDNIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool PPGMHFEKBON;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PhotonView HOFEPHIFJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool HJAODIIKABB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5895720", Offset = "0x5893D20", VA = "0x185895720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool DHOHPBGBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event JDMLJLCMPHD BPJFEFCOFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x58986C0", Offset = "0x5896CC0", VA = "0x1858986C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5897F70", Offset = "0x5896570", VA = "0x185897F70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5898A30", Offset = "0x5897030", VA = "0x185898A30")]
	public MOBAMIJAHPJ(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5898760", Offset = "0x5896D60", VA = "0x185898760", Slot = "9")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5898010", Offset = "0x5896610", VA = "0x185898010", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5897DE0", Offset = "0x58963E0", VA = "0x185897DE0", Slot = "10")]
	public void CDLJGFDMBPL(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5898530", Offset = "0x5896B30", VA = "0x185898530", Slot = "11")]
	public void JDAFCHGGCBG(AOCLEIAJHKP HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x58988B0", Offset = "0x5896EB0", VA = "0x1858988B0")]
	private void PKPLGCJFFML(PhotonView PLIPDENHEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5898120", Offset = "0x5896720", VA = "0x185898120")]
	private void EDJGCFIPCCF(RigidbodyEx NCILAHEJPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x58982A0", Offset = "0x58968A0", VA = "0x1858982A0")]
	private void HOHGCHCHINP(PhotonView MKEPLFEMDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal static class ANNEOOHLNNI
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x587A840", Offset = "0x5878E40", VA = "0x18587A840")]
	public static NNEHCPBHLPA AHBEEDIDIOM(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DNMGBLPCCFH : EHPGBGDNCOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly DMMBJKBEDJE ADILDJABNDK;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5882820", Offset = "0x5880E20", VA = "0x185882820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool MEDJLAALBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA17CD0", Offset = "0xA162D0", VA = "0x180A17CD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5885BB0", Offset = "0x58841B0", VA = "0x185885BB0")]
	public DNMGBLPCCFH(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5885B00", Offset = "0x5884100", VA = "0x185885B00", Slot = "5")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x58850A0", Offset = "0x58836A0", VA = "0x1858850A0", Slot = "7")]
	public void IBONCPCMLEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x58850D0", Offset = "0x58836D0", VA = "0x1858850D0", Slot = "8")]
	public void IOAGCIAEOEF(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5884BC0", Offset = "0x58831C0", VA = "0x185884BC0", Slot = "9")]
	public void FFFCEGLDGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5885750", Offset = "0x5883D50", VA = "0x185885750", Slot = "11")]
	public void LAHBFIHNCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x5884F20", Offset = "0x5883520", VA = "0x185884F20", Slot = "12")]
	public void GLBDKENIKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5885100", Offset = "0x5883700", VA = "0x185885100", Slot = "10")]
	public void KFIEMOLOCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x58855A0", Offset = "0x5883BA0", VA = "0x1858855A0")]
	private void KKPIBCJMFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5885950", Offset = "0x5883F50", VA = "0x185885950")]
	private void NJABKINLLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class BAMBMAJGDAA : JFLCGFJHJOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private RigidbodyConstraints FLIHBOMIALI;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool LCLBMNGOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xFF2120", Offset = "0xFF0720", VA = "0x180FF2120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1F08640", Offset = "0x1F06C40", VA = "0x181F08640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool DCDGIGFEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2103290", Offset = "0x2101890", VA = "0x182103290", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1F08650", Offset = "0x1F06C50", VA = "0x181F08650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public RigidbodyConstraints ICLCNCFIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x587A900", Offset = "0x5878F00", VA = "0x18587A900", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x587AAA0", Offset = "0x58790A0", VA = "0x18587AAA0")]
	public BAMBMAJGDAA(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x587AA40", Offset = "0x5879040", VA = "0x18587AA40", Slot = "9")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x587AA70", Offset = "0x5879070", VA = "0x18587AA70", Slot = "10")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class CGHKCINOAOM : DGFAMAIKIOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5880420", VA = "0x185881E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5882770", Offset = "0x5880D70", VA = "0x185882770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5882820", Offset = "0x5880E20", VA = "0x185882820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x58827C0", Offset = "0x5880DC0", VA = "0x1858827C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5882880", Offset = "0x5880E80", VA = "0x185882880")]
	public CGHKCINOAOM(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5882610", Offset = "0x5880C10", VA = "0x185882610", Slot = "4")]
	public void IDFPMPAGKCL(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5882110", Offset = "0x5880710", VA = "0x185882110")]
	private void FHENODHMHOO(Vector3 ODPLBAPFKKP, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5881E70", Offset = "0x5880470", VA = "0x185881E70", Slot = "5")]
	public void EICKBPMFACB(Vector3 ODPLBAPFKKP, Vector3 POOFJFBIOJJ, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5881A40", Offset = "0x5880040", VA = "0x185881A40", Slot = "6")]
	public void BEPCBPMDAHG(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5882390", Offset = "0x5880990", VA = "0x185882390")]
	private void GEJGOLEDPMD(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5881BA0", Offset = "0x58801A0", VA = "0x185881BA0", Slot = "7")]
	public void BHCONFBCFDJ(Vector3 LBLOPBKHMEE, ForceMode LHIIGEOIMMI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FJOOEDFNBIE : BEDFGPKDMMI, KKIDFBLCFBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DMMNFKPMDLN<AOCLEIAJHKP> BOFBIMKJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool NOHNDGICLOA;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public DMMNFKPMDLN<AOCLEIAJHKP> DAJIFENFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 KDJMFENHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x58879B0", Offset = "0x5885FB0", VA = "0x1858879B0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 MOGEGJHLKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5887F90", Offset = "0x5886590", VA = "0x185887F90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5887A90", Offset = "0x5886090", VA = "0x185887A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public AOCLEIAJHKP FCMMDOINFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x58879E0", Offset = "0x5885FE0", VA = "0x1858879E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5888490", Offset = "0x5886A90", VA = "0x185888490")]
	public FJOOEDFNBIE(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5887B70", Offset = "0x5886170", VA = "0x185887B70", Slot = "8")]
	public void KIKNGELNMKB(AOCLEIAJHKP HDBBNLFBJKG, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5887950", Offset = "0x5885F50", VA = "0x185887950", Slot = "9")]
	public void BAONEFAIICM(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5888160", Offset = "0x5886760", VA = "0x185888160")]
	private Vector3 PPANNGELJGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5887BE0", Offset = "0x58861E0", VA = "0x185887BE0")]
	private void NJCNMHABDHK(AOCLEIAJHKP JHPOKMFMFLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class CPHCMGJGPFP
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5883790", Offset = "0x5881D90", VA = "0x185883790")]
	public static BEDFGPKDMMI ANPDBNKFOGH(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class JDFLONLNAIO : CDBDNEDIHGD, MJLAMDFGPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OverridableVector3 JNJNDPIOPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OverridableVector3 LCMLDCPALFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float LBJHKLPMIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float GHNEJKFLBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Vector3 ALOIHKHMHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Vector3? KOMDCJMGILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Quaternion? FBNDDLKJBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool OIAOLPDACKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool AEHBMMIKBOG;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 OBFLENPKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xC353B0", Offset = "0xC339B0", VA = "0x180C353B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x5893460", Offset = "0x5891A60", VA = "0x185893460", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 PJNLCKDCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x58939B0", Offset = "0x5891FB0", VA = "0x1858939B0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float IANMMNHBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xEDBE80", Offset = "0xEDA480", VA = "0x180EDBE80", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5892870", Offset = "0x5890E70", VA = "0x185892870")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float EKCBJCIJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC35010", Offset = "0xC33610", VA = "0x180C35010", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x58933B0", Offset = "0x58919B0", VA = "0x1858933B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 NJKJCPCJAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5895020", Offset = "0x5893620", VA = "0x185895020", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Quaternion ODONPHHGICC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5892B40", Offset = "0x5891140", VA = "0x185892B40", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5882910", Offset = "0x5880F10", VA = "0x185882910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event JDMLJLCMPHD NIFHCDEFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5894B30", Offset = "0x5893130", VA = "0x185894B30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5892AA0", Offset = "0x58910A0", VA = "0x185892AA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5895190", Offset = "0x5893790", VA = "0x185895190")]
	public JDFLONLNAIO(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x58937E0", Offset = "0x5891DE0", VA = "0x1858937E0", Slot = "17")]
	public void JADOCOOIFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5894CB0", Offset = "0x58932B0", VA = "0x185894CB0", Slot = "16")]
	public void NOKJNKPCOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5894BD0", Offset = "0x58931D0", VA = "0x185894BD0", Slot = "19")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5894DD0", Offset = "0x58933D0", VA = "0x185894DD0", Slot = "20")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5893680", Offset = "0x5891C80", VA = "0x185893680", Slot = "18")]
	public void IDLJKMLKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5892EF0", Offset = "0x58914F0", VA = "0x185892EF0", Slot = "21")]
	public void GOHGOJCFBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5893460", Offset = "0x5891A60", VA = "0x185893460")]
	private void NPFHCEKOAKF(Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5892990", Offset = "0x5890F90", VA = "0x185892990")]
	[Obsolete]
	private Vector3 BCKEHCFGCDF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5892870", Offset = "0x5890E70", VA = "0x185892870")]
	private void HFPMMJDNMNG(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x58933B0", Offset = "0x58919B0", VA = "0x1858933B0")]
	private void HAHBLFJGLIA(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x58949C0", Offset = "0x5892FC0", VA = "0x1858949C0")]
	private Vector3 JMAHBCKMMCB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5892CB0", Offset = "0x58912B0", VA = "0x185892CB0", Slot = "15")]
	public void ELBDKMGKMOF((Quaternion rot, Vector3 moments) FDPFMJCBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5893510", Offset = "0x5891B10", VA = "0x185893510")]
	private Quaternion HLJLPOFDFKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5893AC0", Offset = "0x58920C0", VA = "0x185893AC0")]
	public void JFEMDGPFPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5893BA0", Offset = "0x58921A0", VA = "0x185893BA0", Slot = "4")]
	public (float, Vector3) JFEMDGPFPIH(Rigidbody KFFOOKGMEFG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class PGGKEEIKCCE
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0220", Offset = "0x6ECE820", VA = "0x186ED0220")]
	public static CDBDNEDIHGD KILDFFHFILI(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BEDFGPKDMMI : KKIDFBLCFBC
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	DMMNFKPMDLN<AOCLEIAJHKP> DAJIFENFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	AOCLEIAJHKP FCMMDOINFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class OGMKNICCEFG : FCKCKALDJGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DMMBJKBEDJE GACGKPDFKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float HDAKPDFOFBI;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public BIEFHFEPLDN EJPKIEIFJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DDPKKPIIEJI NBIFLHIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 KCBBJJMIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x589FA00", Offset = "0x589E000", VA = "0x18589FA00", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x589E720", Offset = "0x589CD20", VA = "0x18589E720", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 APLELECMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x589DE30", Offset = "0x589C430", VA = "0x18589DE30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x58A0290", Offset = "0x589E890", VA = "0x1858A0290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 FPJLCBDGMED
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x589F170", Offset = "0x589D770", VA = "0x18589F170", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x589EC90", Offset = "0x589D290", VA = "0x18589EC90", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 EGGIEILIFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x589FB20", Offset = "0x589E120", VA = "0x18589FB20", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x589FC10", Offset = "0x589E210", VA = "0x18589FC10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float MHFCDDIOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xB90D70", Offset = "0xB8F370", VA = "0x180B90D70", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x589E840", Offset = "0x589CE40", VA = "0x18589E840", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool DADDAFOKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x924D70", Offset = "0x923370", VA = "0x180924D70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private DGFAMAIKIOI BBIDFHIBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x21EF2A0", Offset = "0x21ED8A0", VA = "0x1821EF2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private bool GKKIJDNHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x588F3B0", Offset = "0x588D9B0", VA = "0x18588F3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x58A0A60", Offset = "0x589F060", VA = "0x1858A0A60")]
	public OGMKNICCEFG(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x58A04A0", Offset = "0x589EAA0", VA = "0x1858A04A0", Slot = "19")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x589E7E0", Offset = "0x589CDE0", VA = "0x18589E7E0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x58A07D0", Offset = "0x589EDD0", VA = "0x1858A07D0", Slot = "28")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x924780", Offset = "0x922D80", VA = "0x180924780", Slot = "20")]
	public void IIKALEJOAME(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9247C0", Offset = "0x922DC0", VA = "0x1809247C0", Slot = "30")]
	public void PNCJLJGGHJN(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x58A02C0", Offset = "0x589E8C0", VA = "0x1858A02C0", Slot = "35")]
	public Vector3 JGHEGBFMMPJ(Vector3 LHEPMHJHODO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x589DF20", Offset = "0x589C520", VA = "0x18589DF20", Slot = "34")]
	public Vector3 BPOCFGALEDD(Vector3 GKICFHEAHCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x58A04A0", Offset = "0x589EAA0", VA = "0x1858A04A0", Slot = "27")]
	public void JOGGPADGJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x589E0E0", Offset = "0x589C6E0", VA = "0x18589E0E0", Slot = "25")]
	public void CBENEDLBOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x589F9C0", Offset = "0x589DFC0", VA = "0x18589F9C0", Slot = "24")]
	public void HDHBMKGNDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x589DBF0", Offset = "0x589C1F0", VA = "0x18589DBF0", Slot = "33")]
	public void AAFPKGJOIGN(Vector3 OOAINGHLPEK, Vector3 INELGPGGLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x58A0510", Offset = "0x589EB10", VA = "0x1858A0510", Slot = "32")]
	public void KBLFGFJNAHN(Vector3 AOGBJAOCGAI, Vector3 CCBAPKPOEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x58A00F0", Offset = "0x589E6F0", VA = "0x1858A00F0", Slot = "31")]
	public void JAAHGENLODK(Vector3 IJOKKCDOCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x589F2A0", Offset = "0x589D8A0", VA = "0x18589F2A0", Slot = "22")]
	public void GGPECKHIGOH(INGJMCHLCGB NGIFLGHKIJI, Vector3 HIHBFJIBHJF, float DLIFCJEACKM, float EAPIMFMHACP = 8f, float JPHLAIOOFDO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x589F790", Offset = "0x589DD90", VA = "0x18589F790", Slot = "21")]
	public void GMLABOOKNDN(PEDHAMIFFKK CFIJENMGAHK, Vector3 IKJGKNDNGLC, float NAOBKFHMHJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x589FDF0", Offset = "0x589E3F0", VA = "0x18589FDF0", Slot = "23")]
	[Obsolete]
	public void IPJGCGNJMPA(PEDHAMIFFKK CFIJENMGAHK, Vector3 MEHKCJCIOOL, float OGGCDKDEOIO = 7f, float IBHAAACEDPP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x589FC40", Offset = "0x589E240", VA = "0x18589FC40", Slot = "29")]
	public Vector3 IHNMKPPJJBP(Vector3 KEMGHPMICGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x58A0900", Offset = "0x589EF00", VA = "0x1858A0900", Slot = "26")]
	public void PFLNEDFLBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x589E840", Offset = "0x589CE40", VA = "0x18589E840")]
	private void EGIKGPEOFBN(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x58A0570", Offset = "0x589EB70", VA = "0x1858A0570")]
	private void MLABEEHFFJL(Vector3 IKJGKNDNGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x589FD00", Offset = "0x589E300", VA = "0x18589FD00")]
	private Vector3 IMPELKKOENJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x589EE50", Offset = "0x589D450", VA = "0x18589EE50")]
	private void GCOILLKJJBE(Vector3 GKICFHEAHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x589ED50", Offset = "0x589D350", VA = "0x18589ED50")]
	private Vector3 EOODJDMOBAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x589E960", Offset = "0x589CF60", VA = "0x18589E960")]
	private void EKHDOKNOANE(Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x589E120", Offset = "0x589C720", VA = "0x18589E120")]
	private void CELFANCAFIH(Vector3 GKICFHEAHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x58A0710", Offset = "0x589ED10", VA = "0x1858A0710")]
	private void NKEKLLDEMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class IEMKEHEEOIO : NJJAJEPIBDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DMMBJKBEDJE ENJBPIEFMKA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool MHOHHABFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x5891230", Offset = "0x588F830", VA = "0x185891230", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event JDMLJLCMPHD PPDDOEOHENO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x5890E80", Offset = "0x588F480", VA = "0x185890E80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5890F80", Offset = "0x588F580", VA = "0x185890F80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5891300", Offset = "0x588F900", VA = "0x185891300")]
	public IEMKEHEEOIO(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5891020", Offset = "0x588F620", VA = "0x185891020", Slot = "11")]
	public IDisposable GFGDBJCOOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5890F20", Offset = "0x588F520", VA = "0x185890F20", Slot = "8")]
	public void CKCCNMBNGFO(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5890F30", Offset = "0x588F530", VA = "0x185890F30", Slot = "9")]
	public void DBBAOMBFPFC(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5891080", Offset = "0x588F680", VA = "0x185891080", Slot = "10")]
	public void JEFIOKKCALL(object DCEGGIJLHGI, bool IBEINHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5890F40", Offset = "0x588F540", VA = "0x185890F40", Slot = "6")]
	public void DDJHHNKDMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5891180", Offset = "0x588F780", VA = "0x185891180", Slot = "12")]
	public void NNLOEEJCNKF(Rigidbody FMPHIOBBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5891200", Offset = "0x588F800", VA = "0x185891200", Slot = "13")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal sealed class FBOKBMCJNJJ : CJBOBGHJFCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CollisionDetectionMode JAINHJJAKPA;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5881E20", Offset = "0x5880420", VA = "0x185881E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CollisionDetectionMode GDODHIKOANK
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x58873F0", Offset = "0x58859F0", VA = "0x1858873F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5887380", Offset = "0x5885980", VA = "0x185887380", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5882880", Offset = "0x5880E80", VA = "0x185882880")]
	public FBOKBMCJNJJ(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5887830", Offset = "0x5885E30", VA = "0x185887830", Slot = "6")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5887640", Offset = "0x5885C40", VA = "0x185887640", Slot = "9")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5887500", Offset = "0x5885B00", VA = "0x185887500", Slot = "7")]
	public void IJDKGLDEENB(bool DBCLNOPFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5887370", Offset = "0x5885970", VA = "0x185887370", Slot = "8")]
	public void BLNBNGGIGFA(bool DBCLNOPFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x58876C0", Offset = "0x5885CC0", VA = "0x1858876C0", Slot = "10")]
	public bool PAEMNOKMJLL(Vector3 MAMJCPDDLBH, out RaycastHit HJCMFCOFGIC, float JOJFLKALKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5887510", Offset = "0x5885B10", VA = "0x185887510")]
	private void LGDHBGFFGMO(bool DBCLNOPFJBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OJJKIMHANCF : GLLJIFAFPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF0C0", Offset = "0x6ECD6C0", VA = "0x186ECF0C0", Slot = "4")]
	public IKHJGOOMJIK EOCBGFJDLBO(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEF20", Offset = "0x6ECD520", VA = "0x186ECEF20", Slot = "5")]
	public FCKCKALDJGJ ANGCPCPAOIC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEFF0", Offset = "0x6ECD5F0", VA = "0x186ECEFF0", Slot = "6")]
	public KKIDFBLCFBC DOAMDCLPEDK(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF4A0", Offset = "0x6ECDAA0", VA = "0x186ECF4A0", Slot = "7")]
	public BHMGBIACOME OOHJLBEJDNN(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF260", Offset = "0x6ECD860", VA = "0x186ECF260", Slot = "8")]
	public LDEKIIFINIJ HMCMIAGHFPC(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEF80", Offset = "0x6ECD580", VA = "0x186ECEF80", Slot = "9")]
	public CKCBLALPPPC CHCPKFFBKAB(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF370", Offset = "0x6ECD970", VA = "0x186ECF370", Slot = "10")]
	public NJJAJEPIBDM JLCNCPKNCDJ(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF500", Offset = "0x6ECDB00", VA = "0x186ECF500", Slot = "11")]
	public DGFAMAIKIOI OPABALKDHOE(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF440", Offset = "0x6ECDA40", VA = "0x186ECF440", Slot = "12")]
	public CJBOBGHJFCG LOAKJLPNBOL(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF200", Offset = "0x6ECD800", VA = "0x186ECF200", Slot = "13")]
	public MGFOKHNGEBJ GNBAKJKCDBI(AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEEB0", Offset = "0x6ECD4B0", VA = "0x186ECEEB0")]
	public EHPGBGDNCOD AGJMCCNAKFO(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF3D0", Offset = "0x6ECD9D0", VA = "0x186ECF3D0")]
	public MEENLNJJFDF NDDNOEGMGCI(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF050", Offset = "0x6ECD650", VA = "0x186ECF050")]
	public OAEPDBGPEAL FIAKLDMDPHF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF190", Offset = "0x6ECD790", VA = "0x186ECF190")]
	public MJLAMDFGPOJ GAPAGHJINBP(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF120", Offset = "0x6ECD720", VA = "0x186ECF120")]
	public JFLCGFJHJOJ IJOABGCKIGA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF2C0", Offset = "0x6ECD8C0", VA = "0x186ECF2C0", Slot = "19")]
	public AOCLEIAJHKP JECHNLKJNNA(RigidbodyEx CMMIKMENMLL, BPFBPKEMMBI JAIGDBINGHO, MOKJCBCFMGC AMKEFDBPHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public OJJKIMHANCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEEB0", Offset = "0x6ECD4B0", VA = "0x186ECEEB0", Slot = "14")]
	private EHPGBGDNCOD NCCOHOKBDBL(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF3D0", Offset = "0x6ECD9D0", VA = "0x186ECF3D0", Slot = "15")]
	private MEENLNJJFDF KIMBNEBOIPA(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF050", Offset = "0x6ECD650", VA = "0x186ECF050", Slot = "16")]
	private OAEPDBGPEAL ECKKODBGGLE(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF190", Offset = "0x6ECD790", VA = "0x186ECF190", Slot = "17")]
	private MJLAMDFGPOJ ODLCKGGIEOF(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF120", Offset = "0x6ECD720", VA = "0x186ECF120", Slot = "18")]
	private JFLCGFJHJOJ FPMGIHJNCFC(AOCLEIAJHKP PMIAAPCBGPN, in BPFBPKEMMBI JAIGDBINGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NFMLBBHIOHJ : AMOAHGFPLMO, IKHJGOOMJIK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly AOCLEIAJHKP CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<AOCLEIAJHKP> LAKDMECIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AOCLEIAJHKP AIMNENJKCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AOCLEIAJHKP HDBBNLFBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform GOFCGACNNGE;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Transform GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x589A290", Offset = "0x5898890", VA = "0x18589A290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x589B1F0", Offset = "0x58997F0", VA = "0x18589B1F0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public AOCLEIAJHKP HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IReadOnlyList<AOCLEIAJHKP> PFGMIEKMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event JDMLJLCMPHD BFBMPEKKJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x589A150", Offset = "0x5898750", VA = "0x18589A150", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x589A9C0", Offset = "0x5898FC0", VA = "0x18589A9C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event JDMLJLCMPHD KOPNEFGHFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x589B200", Offset = "0x5899800", VA = "0x18589B200", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x589A2F0", Offset = "0x58988F0", VA = "0x18589A2F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event DOCLCEPDIKL CEAJCLKFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5899740", Offset = "0x5897D40", VA = "0x185899740", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x589AB40", Offset = "0x5899140", VA = "0x18589AB40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action KLFPOJAEGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x5899E80", Offset = "0x5898480", VA = "0x185899E80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x589AC80", Offset = "0x5899280", VA = "0x18589AC80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action PMGADLIGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x589AA60", Offset = "0x5899060", VA = "0x18589AA60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x5899DE0", Offset = "0x58983E0", VA = "0x185899DE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<AOCLEIAJHKP> PMJICKMGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x5899B70", Offset = "0x5898170", VA = "0x185899B70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x5899A30", Offset = "0x5898030", VA = "0x185899A30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<AOCLEIAJHKP> FJALACOBLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x589A1F0", Offset = "0x58987F0", VA = "0x18589A1F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x589ABE0", Offset = "0x58991E0", VA = "0x18589ABE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action ALPOBHDPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x589AD20", Offset = "0x5899320", VA = "0x18589AD20", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x589A920", Offset = "0x5898F20", VA = "0x18589A920", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<AOCLEIAJHKP> PPMCMABJHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x589ADC0", Offset = "0x58993C0", VA = "0x18589ADC0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x589A0B0", Offset = "0x58986B0", VA = "0x18589A0B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x589B460", Offset = "0x5899A60", VA = "0x18589B460")]
	public NFMLBBHIOHJ(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x5899C10", Offset = "0x5898210", VA = "0x185899C10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x589A390", Offset = "0x5898990", VA = "0x18589A390", Slot = "30")]
	public void JAMGDJKMPGM(AOCLEIAJHKP EPBIFMJLJFE, bool NOBJEFGBIAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x58997E0", Offset = "0x5897DE0", VA = "0x1858997E0", Slot = "6")]
	public void ALLFDCABEOP(AOCLEIAJHKP GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x589AF90", Offset = "0x5899590", VA = "0x18589AF90", Slot = "7")]
	public void OHPBPICONDB(AOCLEIAJHKP GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5899AD0", Offset = "0x58980D0", VA = "0x185899AD0", Slot = "4")]
	public void CNLHCEJCBPI(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x589A010", Offset = "0x5898610", VA = "0x18589A010", Slot = "5")]
	public void FNKCMBBPENL(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x589B3D0", Offset = "0x58999D0", VA = "0x18589B3D0")]
	private void PKAODCBFKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x589AB00", Offset = "0x5899100", VA = "0x18589AB00")]
	private void KKGODJCIMGG(AOCLEIAJHKP GIEDJDKODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5899C90", Offset = "0x5898290", VA = "0x185899C90")]
	private void EBEOMLMGODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x589B2A0", Offset = "0x58998A0", VA = "0x18589B2A0")]
	private void PGCEKBFOLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x589AE60", Offset = "0x5899460", VA = "0x18589AE60")]
	private void OCFPACPJMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5899F20", Offset = "0x5898520", VA = "0x185899F20")]
	[CompilerGenerated]
	private object FMDFKMNAPKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal static class CEDHIHHHDJG
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5881980", Offset = "0x587FF80", VA = "0x185881980")]
	public static AMOAHGFPLMO FBPKJDCDANM(this AOCLEIAJHKP PMIAAPCBGPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class IHIDLEDHNKO : OAEPDBGPEAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DMMBJKBEDJE PPJDGMLPFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LMAKLIPDGJL ELKAPNBKJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool MMOAGBOLPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA17CD0", Offset = "0xA162D0", VA = "0x180A17CD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public LMAKLIPDGJL BBPIGHCKMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40", Slot = "11")]
		get
		{
			return default(LMAKLIPDGJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x58919F0", Offset = "0x588FFF0", VA = "0x1858919F0")]
	public IHIDLEDHNKO(AOCLEIAJHKP CMMIKMENMLL, in BPFBPKEMMBI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5891920", Offset = "0x588FF20", VA = "0x185891920", Slot = "4")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x58915A0", Offset = "0x588FBA0", VA = "0x1858915A0")]
	private bool JNNMJIBLIOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x58917E0", Offset = "0x588FDE0", VA = "0x1858917E0", Slot = "5")]
	public void OODMLHNMKAL(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x58917B0", Offset = "0x588FDB0", VA = "0x1858917B0", Slot = "6")]
	public void NFGBDKKPCEG(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5891680", Offset = "0x588FC80", VA = "0x185891680", Slot = "9")]
	public void MLGOPJDLMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5891810", Offset = "0x588FE10", VA = "0x185891810")]
	private void PAFGBOGCJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5891420", Offset = "0x588FA20", VA = "0x185891420")]
	private void BALFDHBAICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5891640", Offset = "0x588FC40", VA = "0x185891640", Slot = "8")]
	public void LFOIGPDNOFE(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x58913E0", Offset = "0x588F9E0", VA = "0x1858913E0", Slot = "7")]
	public void ABJIDBHLCGP(AOCLEIAJHKP CMMIKMENMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface CDBDNEDIHGD : MJLAMDFGPOJ
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JFEMDGPFPIH(Rigidbody KFFOOKGMEFG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AMOAHGFPLMO : IKHJGOOMJIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLHCEJCBPI(AOCLEIAJHKP CMMIKMENMLL);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNKCMBBPENL(AOCLEIAJHKP CMMIKMENMLL);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ALLFDCABEOP(AOCLEIAJHKP GIEDJDKODHP);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHPBPICONDB(AOCLEIAJHKP GIEDJDKODHP);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class EFGCKMMBGEM : MGFOKHNGEBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool LBFOOLAKDKD;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool GOCPEBEIOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5887110", Offset = "0x5885710", VA = "0x185887110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5887250", Offset = "0x5885850", VA = "0x185887250")]
	public EFGCKMMBGEM(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x5887220", Offset = "0x5885820", VA = "0x185887220", Slot = "6")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x58870A0", Offset = "0x58856A0", VA = "0x1858870A0", Slot = "7")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class CHJHFNDDFII : LDEKIIFINIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CBKENBPBBPK CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool GBFNNMLGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool NCDMAAPJPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int LGIDGPKFJOB;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private Rigidbody FBNFGAGNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5882910", Offset = "0x5880F10", VA = "0x185882910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private bool GKKIJDNHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5882E10", Offset = "0x5881410", VA = "0x185882E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private AOCLEIAJHKP ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5883170", Offset = "0x5881770", VA = "0x185883170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool KKAMBADGMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x58833B0", Offset = "0x58819B0", VA = "0x1858833B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event JDMLJLCMPHD HFCHBNGPOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5882B20", Offset = "0x5881120", VA = "0x185882B20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5883270", Offset = "0x5881870", VA = "0x185883270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5883410", Offset = "0x5881A10", VA = "0x185883410")]
	public CHJHFNDDFII(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5883310", Offset = "0x5881910", VA = "0x185883310", Slot = "6")]
	public void PKEGIFGPECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5882BC0", Offset = "0x58811C0", VA = "0x185882BC0", Slot = "8")]
	public void EJJPLMDFADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5882C10", Offset = "0x5881210", VA = "0x185882C10", Slot = "7")]
	public bool GOCENNMEFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x5882D70", Offset = "0x5881370", VA = "0x185882D70", Slot = "9")]
	public void HBNCPLGMEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x58831D0", Offset = "0x58817D0", VA = "0x1858831D0", Slot = "11")]
	public void PEPAIDKMINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5882BD0", Offset = "0x58811D0", VA = "0x185882BD0", Slot = "12")]
	public void GMENLOEIPCO(bool GLHHGCHMOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5882FC0", Offset = "0x58815C0", VA = "0x185882FC0", Slot = "10")]
	public void KJJDNNLLBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5882960", Offset = "0x5880F60", VA = "0x185882960")]
	private bool CIEJMGNJDDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5882E30", Offset = "0x5881430", VA = "0x185882E30")]
	private void IKNGIANFDMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class CINNHMPNOBN : BHMGBIACOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly AOCLEIAJHKP CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float AJMIJLJBCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private float MFAOFDACMDO;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float BEPMGNAKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x935910", Offset = "0x933F10", VA = "0x180935910", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x5883590", Offset = "0x5881B90", VA = "0x185883590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float KODLGMEEOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x935900", Offset = "0x933F00", VA = "0x180935900", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x58834C0", Offset = "0x5881AC0", VA = "0x1858834C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5883750", Offset = "0x5881D50", VA = "0x185883750")]
	public CINNHMPNOBN(AOCLEIAJHKP CMMIKMENMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5883660", Offset = "0x5881C60", VA = "0x185883660", Slot = "8")]
	public void NNLOEEJCNKF(Rigidbody CAGCAFDPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x58836B0", Offset = "0x5881CB0", VA = "0x1858836B0", Slot = "9")]
	public void OBFGONBMCGJ(Rigidbody CAGCAFDPMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface NNEHCPBHLPA : MEENLNJJFDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PhotonView HOFEPHIFJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : KHJNECAEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7CC0", Offset = "0x6ED62C0", VA = "0x186ED7CC0", Slot = "6")]
		public sealed override void LDMPECOOOEM(CIILENBPBII AJNAMFOHMMI)
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
